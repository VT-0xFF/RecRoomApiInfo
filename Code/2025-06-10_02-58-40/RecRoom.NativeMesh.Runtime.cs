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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF480", Offset = "0x7CEE680", VA = "0x187CEF480", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class COAKDPGGIKH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly KEPOMIIOHBM HOEFLPDFKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly KEPOMIIOHBM OEOKCCMEDIK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly KEPOMIIOHBM BJJKHMNAKKI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly KEPOMIIOHBM DJFHJNIAFEP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly KEPOMIIOHBM HAMHBFGMKIF;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class OFDEEGMOHMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public AIFNOHGABOD LGHGMLPIJLC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HIKIJPFMGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public OFDEEGMOHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct AIFNOHGABOD
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct KMPJNFDNDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half CHMDFHNFAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort FIJHNCJPLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte HCAHEBFLDIA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void FHDIIOCJOLH([NoAlias] float3* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class CBFDMLICCBL
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4DC0", Offset = "0x7CE3FC0", VA = "0x187CE4DC0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4C70", Offset = "0x7CE3E70", VA = "0x187CE4C70")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7CE49B0", Offset = "0x7CE3BB0", VA = "0x187CE49B0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4A50", Offset = "0x7CE3C50", VA = "0x187CE4A50")]
		public unsafe static void CLNGLIDPKMF([NoAlias] float3* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void MMNEIOCAAKB([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class EBMDNCOJPKL
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8060", Offset = "0x7CE7260", VA = "0x187CE8060")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7F10", Offset = "0x7CE7110", VA = "0x187CE7F10")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7BD0", Offset = "0x7CE6DD0", VA = "0x187CE7BD0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7C70", Offset = "0x7CE6E70", VA = "0x187CE7C70")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void BOFPGBNEGPF([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class GCNDAKEBDGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA420", Offset = "0x7CE9620", VA = "0x187CEA420")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA2D0", Offset = "0x7CE94D0", VA = "0x187CEA2D0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9F90", Offset = "0x7CE9190", VA = "0x187CE9F90")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA030", Offset = "0x7CE9230", VA = "0x187CEA030")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void LEAEJFJFBEI([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class OACFGECMCCA
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0EB0", Offset = "0x7CF00B0", VA = "0x187CF0EB0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0D60", Offset = "0x7CEFF60", VA = "0x187CF0D60")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0A20", Offset = "0x7CEFC20", VA = "0x187CF0A20")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0AC0", Offset = "0x7CEFCC0", VA = "0x187CF0AC0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void LGKHIBOKAMG([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class FJNDHJMFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE96D0", Offset = "0x7CE88D0", VA = "0x187CE96D0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9580", Offset = "0x7CE8780", VA = "0x187CE9580")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9240", Offset = "0x7CE8440", VA = "0x187CE9240")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE92E0", Offset = "0x7CE84E0", VA = "0x187CE92E0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void BDGANDPACBP([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class AOCJAANPFBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3530", Offset = "0x7CE2730", VA = "0x187CE3530")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE33E0", Offset = "0x7CE25E0", VA = "0x187CE33E0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3010", Offset = "0x7CE2210", VA = "0x187CE3010")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE30B0", Offset = "0x7CE22B0", VA = "0x187CE30B0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void MDMNJCFPACC([NoAlias] ushort* LKNIKPOOJHD, [Out] float3 HJFABBABJBI, [Out] float3 FHLLJFJJJJB, [In][NoAlias] float3* DGAKPOOIJFA, int MGKDFBPDFDC, int AEKPCFCEKPO);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class IIBIJDCGLDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE6C0", Offset = "0x7CED8C0", VA = "0x187CEE6C0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE570", Offset = "0x7CED770", VA = "0x187CEE570")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE2A0", Offset = "0x7CED4A0", VA = "0x187CEE2A0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE340", Offset = "0x7CED540", VA = "0x187CEE340")]
		public unsafe static void CLNGLIDPKMF([NoAlias] ushort* LKNIKPOOJHD, [Out] float3 HJFABBABJBI, [Out] float3 FHLLJFJJJJB, [In][NoAlias] float3* DGAKPOOIJFA, int MGKDFBPDFDC, int AEKPCFCEKPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void LHGKIHLIALD([NoAlias] ushort* GMOEMFCBAKL, [In][NoAlias] float3* OMMABLHAPMO, int AEKPCFCEKPO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class CNJJOICOBMM
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6560", Offset = "0x7CE5760", VA = "0x187CE6560")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6410", Offset = "0x7CE5610", VA = "0x187CE6410")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6170", Offset = "0x7CE5370", VA = "0x187CE6170")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6210", Offset = "0x7CE5410", VA = "0x187CE6210")]
		public unsafe static void CLNGLIDPKMF([NoAlias] ushort* GMOEMFCBAKL, [In][NoAlias] float3* OMMABLHAPMO, int AEKPCFCEKPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void IDLNOFMPIOF([NoAlias] float3* PGCOLIPBNEA, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class OMFJNMFNGNI
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CF88F0", Offset = "0x7CF7AF0", VA = "0x187CF88F0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CF87A0", Offset = "0x7CF79A0", VA = "0x187CF87A0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8500", Offset = "0x7CF7700", VA = "0x187CF8500")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CF85A0", Offset = "0x7CF77A0", VA = "0x187CF85A0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] float3* PGCOLIPBNEA, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void LAAOLMNLLBD([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class NHLKFMCJNJP
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0290", Offset = "0x7CEF490", VA = "0x187CF0290")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0140", Offset = "0x7CEF340", VA = "0x187CF0140")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFEA0", Offset = "0x7CEF0A0", VA = "0x187CEFEA0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFF40", Offset = "0x7CEF140", VA = "0x187CEFF40")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void MPGGJIOBKPJ([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class HDEEALNDFDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CECA40", Offset = "0x7CEBC40", VA = "0x187CECA40")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC8F0", Offset = "0x7CEBAF0", VA = "0x187CEC8F0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC560", Offset = "0x7CEB760", VA = "0x187CEC560")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC600", Offset = "0x7CEB800", VA = "0x187CEC600")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void EDOHFKMBMKC([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class GMGLDLLIMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB1D0", Offset = "0x7CEA3D0", VA = "0x187CEB1D0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB080", Offset = "0x7CEA280", VA = "0x187CEB080")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7CEACF0", Offset = "0x7CE9EF0", VA = "0x187CEACF0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAD90", Offset = "0x7CE9F90", VA = "0x187CEAD90")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void PFEPPAMKFJB([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class BONEANLBBEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4890", Offset = "0x7CE3A90", VA = "0x187CE4890")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4740", Offset = "0x7CE3940", VA = "0x187CE4740")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4380", Offset = "0x7CE3580", VA = "0x187CE4380")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4420", Offset = "0x7CE3620", VA = "0x187CE4420")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void PMIJCOLJFGA([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class GEKBEDJEDJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAA50", Offset = "0x7CE9C50", VA = "0x187CEAA50")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA900", Offset = "0x7CE9B00", VA = "0x187CEA900")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA540", Offset = "0x7CE9740", VA = "0x187CEA540")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA5E0", Offset = "0x7CE97E0", VA = "0x187CEA5E0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void MOFCMNLCHCK([NoAlias] uint* FFABLKCOADK, [Out] float2 HBKFIEJJBNA, [Out] float2 EMKPAGDHIHO, [In][NoAlias] float2* DCEJBHKNLOO, int MGKDFBPDFDC, int AEKPCFCEKPO);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class CKCGIALKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5F50", Offset = "0x7CE5150", VA = "0x187CE5F50")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5E00", Offset = "0x7CE5000", VA = "0x187CE5E00")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5B30", Offset = "0x7CE4D30", VA = "0x187CE5B30")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5BD0", Offset = "0x7CE4DD0", VA = "0x187CE5BD0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] uint* FFABLKCOADK, [Out] float2 HBKFIEJJBNA, [Out] float2 EMKPAGDHIHO, [In][NoAlias] float2* DCEJBHKNLOO, int MGKDFBPDFDC, int AEKPCFCEKPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void CMEHHJJLHCD([Out] float2 FNBPIGLFKLN, uint LCHJNIAINCF, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class FFHIKOPEJFP
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8BC0", Offset = "0x7CE7DC0", VA = "0x187CE8BC0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8A70", Offset = "0x7CE7C70", VA = "0x187CE8A70")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8780", Offset = "0x7CE7980", VA = "0x187CE8780")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8820", Offset = "0x7CE7A20", VA = "0x187CE8820")]
		public static void CLNGLIDPKMF([Out] float2 FNBPIGLFKLN, uint LCHJNIAINCF, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void DMBNDJGDHBP([NoAlias] float2* FFABLKCOADK, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class MFBIBKMDBEM
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFD80", Offset = "0x7CEEF80", VA = "0x187CEFD80")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFC30", Offset = "0x7CEEE30", VA = "0x187CEFC30")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF8B0", Offset = "0x7CEEAB0", VA = "0x187CEF8B0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF950", Offset = "0x7CEEB50", VA = "0x187CEF950")]
		public unsafe static void CLNGLIDPKMF([NoAlias] float2* FFABLKCOADK, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void JEJMBBCMLKI([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class GNFLMMEMNLB
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB800", Offset = "0x7CEAA00", VA = "0x187CEB800")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB6B0", Offset = "0x7CEA8B0", VA = "0x187CEB6B0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB2F0", Offset = "0x7CEA4F0", VA = "0x187CEB2F0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB390", Offset = "0x7CEA590", VA = "0x187CEB390")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void MKDFDEDLOLE([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class CDFFHANJMJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE53F0", Offset = "0x7CE45F0", VA = "0x187CE53F0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7CE52A0", Offset = "0x7CE44A0", VA = "0x187CE52A0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4EE0", Offset = "0x7CE40E0", VA = "0x187CE4EE0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4F80", Offset = "0x7CE4180", VA = "0x187CE4F80")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void BEPBDEJBGAL([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class OPIGHCCOICC
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9450", Offset = "0x7CF8650", VA = "0x187CF9450")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9300", Offset = "0x7CF8500", VA = "0x187CF9300")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9040", Offset = "0x7CF8240", VA = "0x187CF9040")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF90E0", Offset = "0x7CF82E0", VA = "0x187CF90E0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void LIOBGLLCNDG([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class CKBLEOAFODG
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5A10", Offset = "0x7CE4C10", VA = "0x187CE5A10")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7CE58C0", Offset = "0x7CE4AC0", VA = "0x187CE58C0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5510", Offset = "0x7CE4710", VA = "0x187CE5510")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7CE55B0", Offset = "0x7CE47B0", VA = "0x187CE55B0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void KPKLAKPIBPD([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class BEAEGPHCOKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4160", Offset = "0x7CE3360", VA = "0x187CE4160")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4010", Offset = "0x7CE3210", VA = "0x187CE4010")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3C60", Offset = "0x7CE2E60", VA = "0x187CE3C60")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3D00", Offset = "0x7CE2F00", VA = "0x187CE3D00")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void NNADNEILMDM([NoAlias] ushort* MDNHBNMHFEP, [In][NoAlias] float4* GNPDAPOHFAM, int MGKDFBPDFDC, int AEKPCFCEKPO);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class KJEKBFJDGIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF1A0", Offset = "0x7CEE3A0", VA = "0x187CEF1A0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF050", Offset = "0x7CEE250", VA = "0x187CEF050")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7CEED20", Offset = "0x7CEDF20", VA = "0x187CEED20")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEDC0", Offset = "0x7CEDFC0", VA = "0x187CEEDC0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] ushort* MDNHBNMHFEP, [In][NoAlias] float4* GNPDAPOHFAM, int MGKDFBPDFDC, int AEKPCFCEKPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort MKMEEIOMJDM([In] float4 OCNKKCLKIKM);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class FJAPJLHEHDC
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9120", Offset = "0x7CE8320", VA = "0x187CE9120")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8FD0", Offset = "0x7CE81D0", VA = "0x187CE8FD0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8CE0", Offset = "0x7CE7EE0", VA = "0x187CE8CE0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8D80", Offset = "0x7CE7F80", VA = "0x187CE8D80")]
		public static ushort CLNGLIDPKMF([In] float4 OCNKKCLKIKM)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void EIAKNHCAIPN([NoAlias] float4* MDNHBNMHFEP, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class CPAGGIANGJM
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6C90", Offset = "0x7CE5E90", VA = "0x187CE6C90")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6B40", Offset = "0x7CE5D40", VA = "0x187CE6B40")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6810", Offset = "0x7CE5A10", VA = "0x187CE6810")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7CE68B0", Offset = "0x7CE5AB0", VA = "0x187CE68B0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] float4* MDNHBNMHFEP, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void GMEHBOEIBHD([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class BAFKOEDNPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3A40", Offset = "0x7CE2C40", VA = "0x187CE3A40")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7CE38F0", Offset = "0x7CE2AF0", VA = "0x187CE38F0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3650", Offset = "0x7CE2850", VA = "0x187CE3650")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE36F0", Offset = "0x7CE28F0", VA = "0x187CE36F0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void BLANFAKJDFP([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class ONKJHDGMNAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8F20", Offset = "0x7CF8120", VA = "0x187CF8F20")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8DD0", Offset = "0x7CF7FD0", VA = "0x187CF8DD0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8A10", Offset = "0x7CF7C10", VA = "0x187CF8A10")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8AB0", Offset = "0x7CF7CB0", VA = "0x187CF8AB0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void BEDDNDENMFE([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class DKGALHLFAHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7CE78F0", Offset = "0x7CE6AF0", VA = "0x187CE78F0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7CE77A0", Offset = "0x7CE69A0", VA = "0x187CE77A0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7CE73E0", Offset = "0x7CE65E0", VA = "0x187CE73E0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7480", Offset = "0x7CE6680", VA = "0x187CE7480")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void MKFFCKBLNEI([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class FKKFJFHCCMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9D70", Offset = "0x7CE8F70", VA = "0x187CE9D70")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9C20", Offset = "0x7CE8E20", VA = "0x187CE9C20")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7CE97F0", Offset = "0x7CE89F0", VA = "0x187CE97F0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9890", Offset = "0x7CE8A90", VA = "0x187CE9890")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void OHLFBEJHNEK([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class GOHFHAPMIKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBEA0", Offset = "0x7CEB0A0", VA = "0x187CEBEA0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBD50", Offset = "0x7CEAF50", VA = "0x187CEBD50")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB920", Offset = "0x7CEAB20", VA = "0x187CEB920")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB9C0", Offset = "0x7CEABC0", VA = "0x187CEB9C0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void EECKILLBGOI([Out] float4 ACALKMLJJOL, ushort LCHJNIAINCF);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class PKPMFEFJANM
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF99F0", Offset = "0x7CF8BF0", VA = "0x187CF99F0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7CF98A0", Offset = "0x7CF8AA0", VA = "0x187CF98A0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9570", Offset = "0x7CF8770", VA = "0x187CF9570")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9610", Offset = "0x7CF8810", VA = "0x187CF9610")]
		public static void CLNGLIDPKMF([Out] float4 ACALKMLJJOL, ushort LCHJNIAINCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void FKOGKKALPCN([NoAlias] float4* FNFOBBAEDHI, [NoAlias] byte* GCCKPBFLBNA, [Out] int EOILPKNFOEN, [Out] int MCEBBNHMFOG, [NoAlias] float4* OAICHPLGJIA, int MGKDFBPDFDC, int AEKPCFCEKPO);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class KFHCPJJKKKD
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEC00", Offset = "0x7CEDE00", VA = "0x187CEEC00")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEAB0", Offset = "0x7CEDCB0", VA = "0x187CEEAB0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE7E0", Offset = "0x7CED9E0", VA = "0x187CEE7E0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE880", Offset = "0x7CEDA80", VA = "0x187CEE880")]
		public unsafe static void CLNGLIDPKMF([NoAlias] float4* FNFOBBAEDHI, [NoAlias] byte* GCCKPBFLBNA, [Out] int EOILPKNFOEN, [Out] int MCEBBNHMFOG, [NoAlias] float4* OAICHPLGJIA, int MGKDFBPDFDC, int AEKPCFCEKPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void EGHFNCCHODJ([NoAlias] float4* BJJGCFDBCCN, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class OFABDHBGNBE
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF83E0", Offset = "0x7CF75E0", VA = "0x187CF83E0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8290", Offset = "0x7CF7490", VA = "0x187CF8290")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7EF0", Offset = "0x7CF70F0", VA = "0x187CF7EF0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7F90", Offset = "0x7CF7190", VA = "0x187CF7F90")]
		public unsafe static void CLNGLIDPKMF([NoAlias] float4* BJJGCFDBCCN, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void KMPEFPJLIML([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class PMPMDJADJPE
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA0B0", Offset = "0x7CF92B0", VA = "0x187CFA0B0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9F60", Offset = "0x7CF9160", VA = "0x187CF9F60")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9B10", Offset = "0x7CF8D10", VA = "0x187CF9B10")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9BB0", Offset = "0x7CF8DB0", VA = "0x187CF9BB0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void LNJDDIKFJJO([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class AEIHBEMNNGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8CA0", Offset = "0x7CD7EA0", VA = "0x187CD8CA0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8B50", Offset = "0x7CD7D50", VA = "0x187CD8B50")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7CD86F0", Offset = "0x7CD78F0", VA = "0x187CD86F0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8790", Offset = "0x7CD7990", VA = "0x187CD8790")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void AHFFNIFFDNF([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class HINCPKKOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7CED610", Offset = "0x7CEC810", VA = "0x187CED610")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7CED4C0", Offset = "0x7CEC6C0", VA = "0x187CED4C0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7CED070", Offset = "0x7CEC270", VA = "0x187CED070")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7CED110", Offset = "0x7CEC310", VA = "0x187CED110")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void MLFGHEDBGNA([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class AEICLENMELN
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD85D0", Offset = "0x7CD77D0", VA = "0x187CD85D0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8480", Offset = "0x7CD7680", VA = "0x187CD8480")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CD81C0", Offset = "0x7CD73C0", VA = "0x187CD81C0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8260", Offset = "0x7CD7460", VA = "0x187CD8260")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void OPGAGJEMEGE([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class DGIJOBCDKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE72C0", Offset = "0x7CE64C0", VA = "0x187CE72C0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7170", Offset = "0x7CE6370", VA = "0x187CE7170")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6EB0", Offset = "0x7CE60B0", VA = "0x187CE6EB0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6F50", Offset = "0x7CE6150", VA = "0x187CE6F50")]
		public unsafe static void CLNGLIDPKMF([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int HMALHEHJHPD([NoAlias] byte* FHEFLLJIOFA, [In][NoAlias] int* CLCPLOBPEOK, int HFDAHCMBPEH);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class GOIGKLFDJPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC440", Offset = "0x7CEB640", VA = "0x187CEC440")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC2F0", Offset = "0x7CEB4F0", VA = "0x187CEC2F0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBFC0", Offset = "0x7CEB1C0", VA = "0x187CEBFC0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC060", Offset = "0x7CEB260", VA = "0x187CEC060")]
		public unsafe static int CLNGLIDPKMF([NoAlias] byte* FHEFLLJIOFA, [In][NoAlias] int* CLCPLOBPEOK, int HFDAHCMBPEH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void FPMBFCKCACE([NoAlias] int* ONDFAMKNFEC, [In][NoAlias] byte* KNHMKPNDODC, int BBBKLBHPKOI);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class NLHPCHHFODO
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0800", Offset = "0x7CEFA00", VA = "0x187CF0800")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CF06B0", Offset = "0x7CEF8B0", VA = "0x187CF06B0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CF03B0", Offset = "0x7CEF5B0", VA = "0x187CF03B0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0450", Offset = "0x7CEF650", VA = "0x187CF0450")]
		public unsafe static void CLNGLIDPKMF([NoAlias] int* ONDFAMKNFEC, [In][NoAlias] byte* KNHMKPNDODC, int BBBKLBHPKOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void HDOAJBGPIFJ([NoAlias] ushort* ONDFAMKNFEC, [In][NoAlias] byte* KNHMKPNDODC, int BBBKLBHPKOI);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class HJBBBKHCPKF
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CEDB80", Offset = "0x7CECD80", VA = "0x187CEDB80")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CEDA30", Offset = "0x7CECC30", VA = "0x187CEDA30")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CED730", Offset = "0x7CEC930", VA = "0x187CED730")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CED7D0", Offset = "0x7CEC9D0", VA = "0x187CED7D0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] ushort* ONDFAMKNFEC, [In][NoAlias] byte* KNHMKPNDODC, int BBBKLBHPKOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void HJNKBJADCFP([Out] float3 FNBPIGLFKLN, ushort LCHJNIAINCF);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class HHNGLAHHIBK
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF50", Offset = "0x7CEC150", VA = "0x187CECF50")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CECE00", Offset = "0x7CEC000", VA = "0x187CECE00")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CECB60", Offset = "0x7CEBD60", VA = "0x187CECB60")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CECC00", Offset = "0x7CEBE00", VA = "0x187CECC00")]
		public static void CLNGLIDPKMF([Out] float3 FNBPIGLFKLN, ushort LCHJNIAINCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort DCOIECLPJEK([In] float3 OCNKKCLKIKM);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class IFPKCMBGOID
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE180", Offset = "0x7CED380", VA = "0x187CEE180")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE030", Offset = "0x7CED230", VA = "0x187CEE030")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CEDDA0", Offset = "0x7CECFA0", VA = "0x187CEDDA0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CEDE40", Offset = "0x7CED040", VA = "0x187CEDE40")]
		public static ushort CLNGLIDPKMF([In] float3 OCNKKCLKIKM)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker PJMHKBFLINO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker EGFMACHGGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int HIKIJPFMGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int BBBKLBHPKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> FDOENJHIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> OFFILAFEDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> DJAKFEGKIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> IBKILBKOLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<KMPJNFDNDBM> BJLGOJMOHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> KPFLHLEMPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> BOCKDNCNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 JPBEJLOOKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 FHLLJFJJJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 AGFINEJHIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 EMKPAGDHIHO;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long BDDLNHLHBKG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long OBKCLHKEGPE;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float PFNHEAFEHAC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool MNNHOGOGGMP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AEOGNGCAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB000", Offset = "0x7CDA200", VA = "0x187CDB000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LLKLCLCJBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD330", Offset = "0x7CDC530", VA = "0x187CDD330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD97D0", Offset = "0x7CD89D0", VA = "0x187CD97D0")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB130", Offset = "0x7CDA330", VA = "0x187CDB130")]
	public static AIFNOHGABOD DBJJOAFKEPP(Allocator DPAKHKILCMF, NativeArray<float3> DGAKPOOIJFA, NativeArray<float3> OMMABLHAPMO, NativeArray<float2> DCEJBHKNLOO, NativeArray<float4> OAICHPLGJIA, bool FCDIJPMJFBA, NativeArray<float4> GECGMPECIGO, NativeArray<int> CLCPLOBPEOK, int HIKIJPFMGFD, int CIBIFAOFPKB, int BBBKLBHPKOI, int MGKDFBPDFDC)
	{
		return default(AIFNOHGABOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE9F0", Offset = "0x7CDDBF0", VA = "0x187CDE9F0")]
	public OBIAGGAMNIO IHPLKIPLDGP(Allocator DPAKHKILCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDEA90", Offset = "0x7CDDC90", VA = "0x187CDEA90")]
	public void IHPLKIPLDGP(OBIAGGAMNIO ACALKMLJJOL, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE03C0", Offset = "0x7CDF5C0", VA = "0x187CE03C0")]
	public void LEPFDPJGMDD(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE630", Offset = "0x7CDD830", VA = "0x187CDE630")]
	private void IANBIMMPLHL(Mesh CGGHHEJPJND, NativeArray<ushort> EDJJOJNLFAI, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB5F0", Offset = "0x7CDA7F0", VA = "0x187CDB5F0")]
	public void DBNPCAGCOFH(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0CD0", Offset = "0x7CDFED0", VA = "0x187CE0CD0")]
	public void MMLMACPJKID(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CDFB20", Offset = "0x7CDED20", VA = "0x187CDFB20")]
	public void KENAGBOHNCJ(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9EC0", Offset = "0x7CD90C0", VA = "0x187CD9EC0")]
	public void BMKGFALCAKA(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CDBEF0", Offset = "0x7CDB0F0", VA = "0x187CDBEF0")]
	public void DGBDNGGNPFG(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1320", Offset = "0x7CE0520", VA = "0x187CE1320")]
	public void MOIHKPFDICN(Mesh CGGHHEJPJND, OBIAGGAMNIO.EGOHCGPMAAB LHADPGCGDPB, bool NAECLJJPDBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAB70", Offset = "0x7CD9D70", VA = "0x187CDAB70")]
	public long CCGENIHKLJD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2300", Offset = "0x7CE1500", VA = "0x187CE2300")]
	public long OLONDKAOCLN(OBIAGGAMNIO.EGOHCGPMAAB LHADPGCGDPB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAC30", Offset = "0x7CD9E30", VA = "0x187CDAC30")]
	private void CDONPKCPGIP(int GJODKHLCBNE, int AEKPCFCEKPO, Allocator DPAKHKILCMF, bool DHNDHHDANNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD720", Offset = "0x7CDC920", VA = "0x187CDD720")]
	private void GOLJLNPLJIE(NativeArray<float3> LKNIKPOOJHD, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD840", Offset = "0x7CDCA40", VA = "0x187CDD840")]
	[BurstCompile]
	private unsafe static void GOLJLNPLJIE([NoAlias] float3* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1B70", Offset = "0x7CE0D70", VA = "0x187CE1B70")]
	[BurstCompile]
	private unsafe static void NMBGHFGLNPM([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9750", Offset = "0x7CD8950", VA = "0x187CD9750")]
	[BurstCompile]
	private unsafe static void BEPAGHBBCOF([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCA60", Offset = "0x7CDBC60", VA = "0x187CDCA60")]
	[BurstCompile]
	private unsafe static void ENFNDKBLAJB([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD940", Offset = "0x7CDCB40", VA = "0x187CDD940")]
	[BurstCompile]
	private unsafe static void HCBOGONPOPC([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC840", Offset = "0x7CDBA40", VA = "0x187CDC840")]
	[BurstCompile]
	private unsafe static void EDJKEHGDEDG([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2810", Offset = "0x7CE1A10", VA = "0x187CE2810")]
	private void PMFLPFKMFHO(NativeArray<float3> DGAKPOOIJFA, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2930", Offset = "0x7CE1B30", VA = "0x187CE2930")]
	[BurstCompile]
	private unsafe static void PMFLPFKMFHO([NoAlias] ushort* LKNIKPOOJHD, [Out] float3 HJFABBABJBI, [Out] float3 FHLLJFJJJJB, [In][NoAlias] float3* DGAKPOOIJFA, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDC00", Offset = "0x7CDCE00", VA = "0x187CDDC00")]
	private void HEGKHJEKHMP(NativeArray<float3> OMMABLHAPMO, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD9C0", Offset = "0x7CDCBC0", VA = "0x187CDD9C0")]
	[BurstCompile]
	private unsafe static void HEGKHJEKHMP([NoAlias] ushort* GMOEMFCBAKL, [In][NoAlias] float3* OMMABLHAPMO, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1F70", Offset = "0x7CE1170", VA = "0x187CE1F70")]
	private void NPNIIJBEAHO(NativeArray<float3> PGCOLIPBNEA, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1D30", Offset = "0x7CE0F30", VA = "0x187CE1D30")]
	[BurstCompile]
	private unsafe static void NPNIIJBEAHO([NoAlias] float3* PGCOLIPBNEA, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE2F0", Offset = "0x7CDD4F0", VA = "0x187CDE2F0")]
	[BurstCompile]
	private unsafe static void HKCMEAIAEPL([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB040", Offset = "0x7CDA240", VA = "0x187CDB040")]
	[BurstCompile]
	private unsafe static void DAFJCIBIHLL([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CE24E0", Offset = "0x7CE16E0", VA = "0x187CE24E0")]
	[BurstCompile]
	private unsafe static void PBIDKLKAKLJ([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CE27A0", Offset = "0x7CE19A0", VA = "0x187CE27A0")]
	[BurstCompile]
	private unsafe static void PLDJOJBMCIH([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD6B0", Offset = "0x7CDC8B0", VA = "0x187CDD6B0")]
	[BurstCompile]
	private unsafe static void GOLHKAPEJBF([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE25F0", Offset = "0x7CE17F0", VA = "0x187CE25F0")]
	private void PJMPAHPDMDL(NativeArray<float2> DCEJBHKNLOO, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2710", Offset = "0x7CE1910", VA = "0x187CE2710")]
	[BurstCompile]
	private unsafe static void PJMPAHPDMDL([NoAlias] uint* FFABLKCOADK, [Out] float2 HBKFIEJJBNA, [Out] float2 EMKPAGDHIHO, [In][NoAlias] float2* DCEJBHKNLOO, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD8C0", Offset = "0x7CDCAC0", VA = "0x187CDD8C0")]
	[BurstCompile]
	private static void HBDPDIFPKAH([Out] float2 FNBPIGLFKLN, uint LCHJNIAINCF, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2030", Offset = "0x7CE1230", VA = "0x187CE2030")]
	private void NPNKAFGBDJB(NativeArray<float2> FFABLKCOADK, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2150", Offset = "0x7CE1350", VA = "0x187CE2150")]
	[BurstCompile]
	private unsafe static void NPNKAFGBDJB([NoAlias] float2* FFABLKCOADK, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0250", Offset = "0x7CDF450", VA = "0x187CE0250")]
	[BurstCompile]
	private unsafe static void LBHAMNFHBNH([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCE10", Offset = "0x7CDC010", VA = "0x187CDCE10")]
	[BurstCompile]
	private unsafe static void FHNKLPPMLCG([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB0B0", Offset = "0x7CDA2B0", VA = "0x187CDB0B0")]
	[BurstCompile]
	private unsafe static void DBDFKCHEGKM([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE860", Offset = "0x7CDDA60", VA = "0x187CDE860")]
	[BurstCompile]
	private unsafe static void ICLCHBKJNCL([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CE02D0", Offset = "0x7CDF4D0", VA = "0x187CE02D0")]
	[BurstCompile]
	private unsafe static void LDFLCNDIIFF([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF7D0", Offset = "0x7CDE9D0", VA = "0x187CDF7D0")]
	private void JPKMGKNJIGC(NativeArray<float4> GECGMPECIGO, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF750", Offset = "0x7CDE950", VA = "0x187CDF750")]
	[BurstCompile]
	private unsafe static void JPKMGKNJIGC([NoAlias] ushort* MDNHBNMHFEP, [In][NoAlias] float4* GNPDAPOHFAM, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CE22B0", Offset = "0x7CE14B0", VA = "0x187CE22B0")]
	[BurstCompile]
	private static ushort OIMHFHNPDJL([In] float4 OCNKKCLKIKM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDD50", Offset = "0x7CDCF50", VA = "0x187CDDD50")]
	private void HEPAJOCNHBL(NativeArray<float4> MDNHBNMHFEP, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDCE0", Offset = "0x7CDCEE0", VA = "0x187CDDCE0")]
	[BurstCompile]
	private unsafe static void HEPAJOCNHBL([NoAlias] float4* MDNHBNMHFEP, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF8E0", Offset = "0x7CDEAE0", VA = "0x187CDF8E0")]
	[BurstCompile]
	private unsafe static void KDEACDPNNCI([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2240", Offset = "0x7CE1440", VA = "0x187CE2240")]
	[BurstCompile]
	private unsafe static void OHPKPOGDJFG([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9480", Offset = "0x7CD8680", VA = "0x187CD9480")]
	[BurstCompile]
	private unsafe static void AMMKOFODGCD([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE8E0", Offset = "0x7CDDAE0", VA = "0x187CDE8E0")]
	[BurstCompile]
	private unsafe static void IDINCEBFGPP([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE21D0", Offset = "0x7CE13D0", VA = "0x187CE21D0")]
	[BurstCompile]
	private unsafe static void OFBFNHNPAHJ([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE290", Offset = "0x7CDD490", VA = "0x187CDE290")]
	[BurstCompile]
	private static void HJEMEBPMLKO([Out] float4 ACALKMLJJOL, ushort LCHJNIAINCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0810", Offset = "0x7CDFA10", VA = "0x187CE0810")]
	private void MGLLKCOBMHI(Allocator DPAKHKILCMF, NativeArray<float4> OAICHPLGJIA, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0780", Offset = "0x7CDF980", VA = "0x187CE0780")]
	[BurstCompile]
	private unsafe static void MGLLKCOBMHI([NoAlias] float4* FNFOBBAEDHI, [NoAlias] byte* GCCKPBFLBNA, [Out] int EOILPKNFOEN, [Out] int MCEBBNHMFOG, [NoAlias] float4* OAICHPLGJIA, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE160", Offset = "0x7CDD360", VA = "0x187CDE160")]
	private static void HIHINPLABLE(NativeArray<float4> BJJGCFDBCCN, NativeArray<KMPJNFDNDBM> JMHAJFOJCBL, NativeArray<byte> KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE0E0", Offset = "0x7CDD2E0", VA = "0x187CDE0E0")]
	[BurstCompile]
	private unsafe static void HIHINPLABLE([NoAlias] float4* BJJGCFDBCCN, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE530", Offset = "0x7CDD730", VA = "0x187CDE530")]
	[BurstCompile]
	private unsafe static void HLHDJEAJHBM([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE5B0", Offset = "0x7CDD7B0", VA = "0x187CDE5B0")]
	[BurstCompile]
	private unsafe static void IAAOLIHCCPB([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0C50", Offset = "0x7CDFE50", VA = "0x187CE0C50")]
	[BurstCompile]
	private unsafe static void MINKCIFAEHN([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CDEE50", Offset = "0x7CDE050", VA = "0x187CDEE50")]
	[BurstCompile]
	private unsafe static void IIAAFIMIHPL([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CD94F0", Offset = "0x7CD86F0", VA = "0x187CD94F0")]
	[BurstCompile]
	private unsafe static void AOCFIPONANP([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD5B0", Offset = "0x7CDC7B0", VA = "0x187CDD5B0")]
	private void GLNPJIFIDCC(Allocator DPAKHKILCMF, NativeArray<int> CLCPLOBPEOK, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF210", Offset = "0x7CDE410", VA = "0x187CDF210")]
	private static NativeArray<byte> JEENBGMPJEA(Allocator DPAKHKILCMF, NativeArray<int> CLCPLOBPEOK, int HFDAHCMBPEH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF4E0", Offset = "0x7CDE6E0", VA = "0x187CDF4E0")]
	[BurstCompile]
	private unsafe static int JEENBGMPJEA([NoAlias] byte* FHEFLLJIOFA, [In][NoAlias] int* CLCPLOBPEOK, int HFDAHCMBPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF0B0", Offset = "0x7CDE2B0", VA = "0x187CDF0B0")]
	private static void IPJFIMKDNCA(NativeArray<int> ONDFAMKNFEC, NativeArray<byte> KNHMKPNDODC, int BBBKLBHPKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF1A0", Offset = "0x7CDE3A0", VA = "0x187CDF1A0")]
	[BurstCompile]
	private unsafe static void IPJFIMKDNCA([NoAlias] int* ONDFAMKNFEC, [In][NoAlias] byte* KNHMKPNDODC, int BBBKLBHPKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0350", Offset = "0x7CDF550", VA = "0x187CE0350")]
	[BurstCompile]
	private unsafe static void LEJAFALIHLD([NoAlias] ushort* ONDFAMKNFEC, [In][NoAlias] byte* KNHMKPNDODC, int BBBKLBHPKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA4D0", Offset = "0x7CD96D0", VA = "0x187CDA4D0")]
	[BurstCompile]
	private static void BNMJDPPHENN([Out] float3 FNBPIGLFKLN, ushort LCHJNIAINCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CD98F0", Offset = "0x7CD8AF0", VA = "0x187CD98F0")]
	[BurstCompile]
	private static ushort BJCOFKNOEIN([In] float3 OCNKKCLKIKM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CD7450", Offset = "0x7CD6650", VA = "0x187CD7450")]
	[BurstCompile]
	public unsafe static void IOFAFOECKKE([NoAlias] float3* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDE40", Offset = "0x7CDD040", VA = "0x187CDDE40")]
	[BurstCompile]
	public unsafe static void HGNKJDKOEGP([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1980", Offset = "0x7CE0B80", VA = "0x187CE1980")]
	[BurstCompile]
	public unsafe static void NCLNACHIJOO([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC780", Offset = "0x7CDB980", VA = "0x187CDC780")]
	[BurstCompile]
	public unsafe static void KFDKCLABKKK([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC780", Offset = "0x7CDB980", VA = "0x187CDC780")]
	[BurstCompile]
	public unsafe static void ECEIMOKDDMB([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9320", Offset = "0x7CD8520", VA = "0x187CD9320")]
	[BurstCompile]
	public unsafe static void AJBJAHHFHAB([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* DGAKPOOIJFA, int HIKIJPFMGFD, [In] float3 JPBEJLOOKKO, [In] float3 FHLLJFJJJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7CD76B0", Offset = "0x7CD68B0", VA = "0x187CD76B0")]
	[BurstCompile]
	public unsafe static void LFEGOIOKDJE([NoAlias] ushort* LKNIKPOOJHD, [Out] float3 HJFABBABJBI, [Out] float3 FHLLJFJJJJB, [In][NoAlias] float3* DGAKPOOIJFA, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA700", Offset = "0x7CD9900", VA = "0x187CDA700")]
	[BurstCompile]
	public unsafe static void CAFAMGFJHJM([NoAlias] ushort* GMOEMFCBAKL, [In][NoAlias] float3* OMMABLHAPMO, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAD60", Offset = "0x7CD9F60", VA = "0x187CDAD60")]
	[BurstCompile]
	public unsafe static void CHDFCHKMOBM([NoAlias] float3* PGCOLIPBNEA, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCFA0", Offset = "0x7CDC1A0", VA = "0x187CDCFA0")]
	[BurstCompile]
	public unsafe static void FPHCEJLNGOB([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDBBD0", Offset = "0x7CDADD0", VA = "0x187CDBBD0")]
	[BurstCompile]
	public unsafe static void DCLMAHEOFGB([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD1F0", Offset = "0x7CDC3F0", VA = "0x187CDD1F0")]
	[BurstCompile]
	public unsafe static void GBAJLGOFHKI([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2370", Offset = "0x7CE1570", VA = "0x187CE2370")]
	[BurstCompile]
	public unsafe static void PBAKMKIGOIC([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF5E0", Offset = "0x7CDE7E0", VA = "0x187CDF5E0")]
	[BurstCompile]
	public unsafe static void JFDPCMGNKLN([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* OMMABLHAPMO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CD64F0", Offset = "0x7CD56F0", VA = "0x187CD64F0")]
	[BurstCompile]
	public unsafe static void CLNHFBONADG([NoAlias] uint* FFABLKCOADK, [Out] float2 HBKFIEJJBNA, [Out] float2 EMKPAGDHIHO, [In][NoAlias] float2* DCEJBHKNLOO, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCDD0", Offset = "0x7CDBFD0", VA = "0x187CDCDD0")]
	[BurstCompile]
	public static void FFNHIAMMBCF([Out] float2 FNBPIGLFKLN, uint LCHJNIAINCF, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCE90", Offset = "0x7CDC090", VA = "0x187CDCE90")]
	[BurstCompile]
	public unsafe static void FPHBGONHHCE([NoAlias] float2* FFABLKCOADK, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC500", Offset = "0x7CDB700", VA = "0x187CDC500")]
	[BurstCompile]
	public unsafe static void DIOIGONAHOD([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC640", Offset = "0x7CDB840", VA = "0x187CDC640")]
	[BurstCompile]
	public unsafe static void DPLICGBKPIJ([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8EC0", Offset = "0x7CD80C0", VA = "0x187CD8EC0")]
	[BurstCompile]
	public unsafe static void AFDAILOGFPA([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0650", Offset = "0x7CDF850", VA = "0x187CE0650")]
	[BurstCompile]
	public unsafe static void LPKOBMHGLKI([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1A40", Offset = "0x7CE0C40", VA = "0x187CE1A40")]
	[BurstCompile]
	public unsafe static void NIMACCGLDJD([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [NoAlias] uint* DCEJBHKNLOO, int HIKIJPFMGFD, [In] float2 AGFINEJHIPK, [In] float2 EMKPAGDHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC980", Offset = "0x7CDBB80", VA = "0x187CDC980")]
	[BurstCompile]
	public unsafe static void EJHADCNCOMJ([NoAlias] ushort* MDNHBNMHFEP, [In][NoAlias] float4* GNPDAPOHFAM, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF550", Offset = "0x7CDE750", VA = "0x187CDF550")]
	[BurstCompile]
	public static ushort JFBPIAHFNPA([In] float4 OCNKKCLKIKM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0170", Offset = "0x7CDF370", VA = "0x187CE0170")]
	[BurstCompile]
	public unsafe static void KFKAODAGMKK([NoAlias] float4* MDNHBNMHFEP, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCAE0", Offset = "0x7CDBCE0", VA = "0x187CDCAE0")]
	[BurstCompile]
	public unsafe static void FEFCDGIJBPB([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE04E0", Offset = "0x7CDF6E0", VA = "0x187CE04E0")]
	[BurstCompile]
	public unsafe static void LMGDBFKLLCC([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1810", Offset = "0x7CE0A10", VA = "0x187CE1810")]
	[BurstCompile]
	public unsafe static void MPLNLBKPOLP([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9CF0", Offset = "0x7CD8EF0", VA = "0x187CD9CF0")]
	[BurstCompile]
	public unsafe static void BMHPICBGKNH([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA9A0", Offset = "0x7CD9BA0", VA = "0x187CDA9A0")]
	[BurstCompile]
	public unsafe static void CCAPKDAJFCH([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] ushort* GECGMPECIGO, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC8C0", Offset = "0x7CDBAC0", VA = "0x187CDC8C0")]
	[BurstCompile]
	public static void EGBJJEIJIHN([Out] float4 ACALKMLJJOL, ushort LCHJNIAINCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6EB0", Offset = "0x7CD60B0", VA = "0x187CD6EB0")]
	[BurstCompile]
	public unsafe static void GIGKLIFKIAF([NoAlias] float4* FNFOBBAEDHI, [NoAlias] byte* GCCKPBFLBNA, [Out] int EOILPKNFOEN, [Out] int MCEBBNHMFOG, [NoAlias] float4* OAICHPLGJIA, int MGKDFBPDFDC, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1BF0", Offset = "0x7CE0DF0", VA = "0x187CE1BF0")]
	[BurstCompile]
	public unsafe static void NMHHJFIOANI([NoAlias] float4* BJJGCFDBCCN, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9B10", Offset = "0x7CD8D10", VA = "0x187CD9B10")]
	[BurstCompile]
	public unsafe static void BMBEAJLJGLH([NoAlias] OBIAGGAMNIO.KMDNBCAAIKD* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDF00", Offset = "0x7CDD100", VA = "0x187CDDF00")]
	[BurstCompile]
	public unsafe static void HIBPKLHGKME([NoAlias] OBIAGGAMNIO.DONGPPNMCPL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CDBD10", Offset = "0x7CDAF10", VA = "0x187CDBD10")]
	[BurstCompile]
	public unsafe static void DGAFCJNANDH([NoAlias] OBIAGGAMNIO.EHAPEPPJBHL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD370", Offset = "0x7CDC570", VA = "0x187CDD370")]
	[BurstCompile]
	public unsafe static void GLDBMBDEFOI([NoAlias] OBIAGGAMNIO.EHBHNGLLMBC* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CD90E0", Offset = "0x7CD82E0", VA = "0x187CD90E0")]
	[BurstCompile]
	public unsafe static void AIBBIFKOIJA([NoAlias] OBIAGGAMNIO.GFHHMCFMPDL* LKNIKPOOJHD, [In][NoAlias] KMPJNFDNDBM* JMHAJFOJCBL, [In][NoAlias] byte* KABHEAKCKCH, int HIKIJPFMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8DC0", Offset = "0x7CD7FC0", VA = "0x187CD8DC0")]
	[BurstCompile]
	public unsafe static int ADBHNNOGKFE([NoAlias] byte* FHEFLLJIOFA, [In][NoAlias] int* CLCPLOBPEOK, int HFDAHCMBPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE950", Offset = "0x7CDDB50", VA = "0x187CDE950")]
	[BurstCompile]
	public unsafe static void IDNLLGMIOFE([NoAlias] int* ONDFAMKNFEC, [In][NoAlias] byte* KNHMKPNDODC, int BBBKLBHPKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2550", Offset = "0x7CE1750", VA = "0x187CE2550")]
	[BurstCompile]
	public unsafe static void PILANHNJCAI([NoAlias] ushort* ONDFAMKNFEC, [In][NoAlias] byte* KNHMKPNDODC, int BBBKLBHPKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD72B0", Offset = "0x7CD64B0", VA = "0x187CD72B0")]
	[BurstCompile]
	public static void GNDJGKFPHJN([Out] float3 FNBPIGLFKLN, ushort LCHJNIAINCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD67B0", Offset = "0x7CD59B0", VA = "0x187CD67B0")]
	[BurstCompile]
	public static ushort DCNGNPHBEPK([In] float3 OCNKKCLKIKM)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class OBIAGGAMNIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum EGOHCGPMAAB
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
	public enum FMLMOHNFFCJ
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
	public struct KDHGACPDKEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EGOHCGPMAAB LHADPGCGDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool FAAOJGBJIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int MIOJPOJBICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] CLFDPBDJEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct EICPHNFPNCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 FICCENLPJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 BNGNHOGLPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 HGJENMIPHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 EKKIOACDOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 BJLGOJMOHMO;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] CLFDPBDJEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct KMDNBCAAIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 FICCENLPJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 BNGNHOGLPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 HGJENMIPHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 EKKIOACDOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 BJLGOJMOHMO;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] CLFDPBDJEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct DONGPPNMCPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 FICCENLPJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint BNGNHOGLPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint HGJENMIPHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 EKKIOACDOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 BJLGOJMOHMO;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] CLFDPBDJEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct EHAPEPPJBHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 FICCENLPJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint BNGNHOGLPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint HGJENMIPHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 EKKIOACDOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 BJLGOJMOHMO;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] CLFDPBDJEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct EHBHNGLLMBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 FICCENLPJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint EBBOHLCACEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 EKKIOACDOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint BOGMCNHJJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint CBOICIEDOGK;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] CLFDPBDJEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct GFHHMCFMPDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NGOIPEMIGJI.MGJGGPDPNEM HJABCKFBAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint EBBOHLCACEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 EKKIOACDOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint BOGMCNHJJPD;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] CLFDPBDJEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int KKJIHLCLNDI(float HGCMPGNMMIB);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class AMAAAALACEF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2EF0", Offset = "0x7CE20F0", VA = "0x187CE2EF0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2DA0", Offset = "0x7CE1FA0", VA = "0x187CE2DA0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2AA0", Offset = "0x7CE1CA0", VA = "0x187CE2AA0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2B40", Offset = "0x7CE1D40", VA = "0x187CE2B40")]
		public static int CLNGLIDPKMF(float HGCMPGNMMIB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint MGICLGDIFGO([In] float4 JIKDBGFICJD);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class EDBAKACOKGB
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7D00B80", Offset = "0x7CFFD80", VA = "0x187D00B80")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7D00A30", Offset = "0x7CFFC30", VA = "0x187D00A30")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7D00720", Offset = "0x7CFF920", VA = "0x187D00720")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7D007C0", Offset = "0x7CFF9C0", VA = "0x187D007C0")]
		public static uint CLNGLIDPKMF([In] float4 JIKDBGFICJD)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint IPBCDDNOODI([In] float3 JIKDBGFICJD);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class BOCENOJBGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7D00280", Offset = "0x7CFF480", VA = "0x187D00280")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7D00130", Offset = "0x7CFF330", VA = "0x187D00130")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFE50", Offset = "0x7CFF050", VA = "0x187CFFE50")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFEF0", Offset = "0x7CFF0F0", VA = "0x187CFFEF0")]
		public static uint CLNGLIDPKMF([In] float3 JIKDBGFICJD)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void FGDFLCKPKLB([NoAlias] DONGPPNMCPL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class GAHNJOBJGIF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7D02E70", Offset = "0x7D02070", VA = "0x187D02E70")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7D02D20", Offset = "0x7D01F20", VA = "0x187D02D20")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7D02A50", Offset = "0x7D01C50", VA = "0x187D02A50")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7D02AF0", Offset = "0x7D01CF0", VA = "0x187D02AF0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] DONGPPNMCPL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void OFJPHMAJJJO([NoAlias] EHAPEPPJBHL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class FBCPFECKMML
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7D02930", Offset = "0x7D01B30", VA = "0x187D02930")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7D027E0", Offset = "0x7D019E0", VA = "0x187D027E0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7D02510", Offset = "0x7D01710", VA = "0x187D02510")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7D025B0", Offset = "0x7D017B0", VA = "0x187D025B0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] EHAPEPPJBHL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void CEAJPIDKIEI([NoAlias] EHBHNGLLMBC* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class MBHKBBFDJBO
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7D0DED0", Offset = "0x7D0D0D0", VA = "0x187D0DED0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D0DD80", Offset = "0x7D0CF80", VA = "0x187D0DD80")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D900", Offset = "0x7D0CB00", VA = "0x187D0D900")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D9A0", Offset = "0x7D0CBA0", VA = "0x187D0D9A0")]
		public unsafe static void CLNGLIDPKMF([NoAlias] EHBHNGLLMBC* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void BNHHOMHIAML([NoAlias] GFHHMCFMPDL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO, [Out] float3 JEJNOKIKEGD, [Out] float3 CGINAOEONCK);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class NFHMOJMNFIP
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7D11430", Offset = "0x7D10630", VA = "0x187D11430")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7D112E0", Offset = "0x7D104E0", VA = "0x187D112E0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7D10CF0", Offset = "0x7D0FEF0", VA = "0x187D10CF0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7D10D90", Offset = "0x7D0FF90", VA = "0x187D10D90")]
		public unsafe static void CLNGLIDPKMF([NoAlias] GFHHMCFMPDL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO, [Out] float3 JEJNOKIKEGD, [Out] float3 CGINAOEONCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int DGOPINCLDDL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> PIOFNOHANHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> LJNGMMFPJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> BMLBAMFLPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> ODDDDLMECFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> CCJODAFAHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> LMHHBOPHABB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] KJMDHFGELFI;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool NAEFHAIFMBP;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static KDHGACPDKEG[] JFJKJHAOMPI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AEOGNGCAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1C40", Offset = "0x7CF0E40", VA = "0x187CF1C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KKHPKCBJJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4930", Offset = "0x7CF3B30", VA = "0x187CF4930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DJGLDAAIOED
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7CF70E0", Offset = "0x7CF62E0", VA = "0x187CF70E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LLKLCLCJBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4460", Offset = "0x7CF3660", VA = "0x187CF4460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3C80", Offset = "0x7CF2E80", VA = "0x187CF3C80")]
	public static FMLMOHNFFCJ FGJDKLKJFBI(EGOHCGPMAAB LHADPGCGDPB)
	{
		return default(FMLMOHNFFCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4970", Offset = "0x7CF3B70", VA = "0x187CF4970")]
	public static void IKKACPOBFKE(FMLMOHNFFCJ PPPBPADOHON, Material ADKDGJDNNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3AF0", Offset = "0x7CF2CF0", VA = "0x187CF3AF0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1A50", Offset = "0x7CF0C50", VA = "0x187CF1A50")]
	public void CDONPKCPGIP(int GJODKHLCBNE, int AEKPCFCEKPO, Allocator DPAKHKILCMF, bool EALPJDCOLLF, bool DHNDHHDANNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5A20", Offset = "0x7CF4C20", VA = "0x187CF5A20")]
	public void KODJBMFFBIP(int GJODKHLCBNE, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4C30", Offset = "0x7CF3E30", VA = "0x187CF4C30", Slot = "6")]
	public bool IOAIFEHABIP(Mesh CGGHHEJPJND, bool LEAJNNPPNCN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5AA0", Offset = "0x7CF4CA0", VA = "0x187CF5AA0")]
	public bool LEPFDPJGMDD(Mesh CGGHHEJPJND, bool LEAJNNPPNCN, bool NAECLJJPDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7CF27A0", Offset = "0x7CF19A0", VA = "0x187CF27A0")]
	public bool DDPJAAMPCNN(Mesh CGGHHEJPJND, OBIAGGAMNIO IANILIEADNH, bool LEAJNNPPNCN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1050", Offset = "0x7CF0250", VA = "0x187CF1050")]
	public bool BAMGKHJEFMD(Mesh CGGHHEJPJND, OBIAGGAMNIO IANILIEADNH, EGOHCGPMAAB LHADPGCGDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5EA0", Offset = "0x7CF50A0", VA = "0x187CF5EA0")]
	private void LOCIEEOKEDB(Mesh CGGHHEJPJND, OBIAGGAMNIO IANILIEADNH, bool NAECLJJPDBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6630", Offset = "0x7CF5830", VA = "0x187CF6630")]
	public void LOCIEEOKEDB(NativeArray<ushort> CHOHIBPJBLL, NativeArray<EHBHNGLLMBC> DKILIBDNBAE, Mesh CGGHHEJPJND, OBIAGGAMNIO IANILIEADNH, bool NAECLJJPDBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1D60", Offset = "0x7CF0F60", VA = "0x187CF1D60")]
	public void DBNPCAGCOFH(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CF39A0", Offset = "0x7CF2BA0", VA = "0x187CF39A0")]
	[BurstCompile]
	public static int DJGIIEEGOIE(float HGCMPGNMMIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CF39F0", Offset = "0x7CF2BF0", VA = "0x187CF39F0")]
	[BurstCompile]
	public static uint DJGIIEEGOIE([In] float4 JIKDBGFICJD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3A40", Offset = "0x7CF2C40", VA = "0x187CF3A40")]
	[BurstCompile]
	public static uint DJGIIEEGOIE([In] float3 JIKDBGFICJD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7CF69C0", Offset = "0x7CF5BC0", VA = "0x187CF69C0")]
	public void MMLMACPJKID(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0FD0", Offset = "0x7CF01D0", VA = "0x187CF0FD0")]
	[BurstCompile]
	private unsafe static void APFDIMHFDAC([NoAlias] DONGPPNMCPL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5390", Offset = "0x7CF4590", VA = "0x187CF5390")]
	public void KENAGBOHNCJ(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6940", Offset = "0x7CF5B40", VA = "0x187CF6940")]
	[BurstCompile]
	private unsafe static void MKEKMFGLFAD([NoAlias] EHAPEPPJBHL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1120", Offset = "0x7CF0320", VA = "0x187CF1120")]
	public void BMKGFALCAKA(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7CF14F0", Offset = "0x7CF06F0", VA = "0x187CF14F0")]
	public void BMKGFALCAKA(NativeArray<ushort> EDJJOJNLFAI, NativeArray<EHBHNGLLMBC> LDIEJBLHKPD, Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7A70", Offset = "0x7CF6C70", VA = "0x187CF7A70")]
	[BurstCompile]
	public unsafe static void PGJMJMPEEJK([NoAlias] EHBHNGLLMBC* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2CA0", Offset = "0x7CF1EA0", VA = "0x187CF2CA0")]
	public void DGBDNGGNPFG(Mesh CGGHHEJPJND, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3C00", Offset = "0x7CF2E00", VA = "0x187CF3C00")]
	[BurstCompile]
	private unsafe static void FEMELLHKFCL([NoAlias] GFHHMCFMPDL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO, [Out] float3 JEJNOKIKEGD, [Out] float3 CGINAOEONCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7050", Offset = "0x7CF6250", VA = "0x187CF7050")]
	public void MOIHKPFDICN(Mesh CGGHHEJPJND, EGOHCGPMAAB LHADPGCGDPB, bool NAECLJJPDBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7800", Offset = "0x7CF6A00", VA = "0x187CF7800")]
	public void PECECAOBPHM(OBIAGGAMNIO CGGHHEJPJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7CF72C0", Offset = "0x7CF64C0", VA = "0x187CF72C0")]
	public void OFKPNBGCOOI(OBIAGGAMNIO MLMPPNLIAEF, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1900", Offset = "0x7CF0B00", VA = "0x187CF1900")]
	public long CCGENIHKLJD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7CF18A0", Offset = "0x7CF0AA0", VA = "0x187CF18A0")]
	public static long CCGENIHKLJD(int EAHGAGJCEPF, int JDEOMHJJDKE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7CF73C0", Offset = "0x7CF65C0", VA = "0x187CF73C0")]
	public static long OLONDKAOCLN(int EAHGAGJCEPF, int JDEOMHJJDKE, EGOHCGPMAAB LHADPGCGDPB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7460", Offset = "0x7CF6660", VA = "0x187CF7460")]
	public long OLONDKAOCLN(EGOHCGPMAAB LHADPGCGDPB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3A90", Offset = "0x7CF2C90", VA = "0x187CF3A90")]
	public void DLFHCCLIPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7CF33E0", Offset = "0x7CF25E0", VA = "0x187CF33E0")]
	public static void DJGFLNEFKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4C50", Offset = "0x7CF3E50", VA = "0x187CF4C50")]
	public EGOHCGPMAAB KAHFIFFEGFN()
	{
		return default(EGOHCGPMAAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4860", Offset = "0x7CF3A60", VA = "0x187CF4860")]
	public static (int, int) HEEFCJKKCLP(Mesh CGGHHEJPJND)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1C80", Offset = "0x7CF0E80", VA = "0x187CF1C80")]
	public static int CPLMHGKJGND(VertexAttributeDescriptor[] PPGOHKNNNDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7120", Offset = "0x7CF6320", VA = "0x187CF7120")]
	public static long NCCCIHBKPCL(Mesh CGGHHEJPJND, int HBJOMKLMOPD, int INOLECDJNHL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7190", Offset = "0x7CF6390", VA = "0x187CF7190")]
	public static long NCCCIHBKPCL(Mesh CGGHHEJPJND)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public OBIAGGAMNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7520", Offset = "0x7CF6720", VA = "0x187CF7520")]
	[BurstCompile]
	public static int ONPOKNFFHEG(float HGCMPGNMMIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7670", Offset = "0x7CF6870", VA = "0x187CF7670")]
	[BurstCompile]
	public static uint ONPOKNFFHEG([In] float4 JIKDBGFICJD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7CF75C0", Offset = "0x7CF67C0", VA = "0x187CF75C0")]
	[BurstCompile]
	public static uint ONPOKNFFHEG([In] float3 JIKDBGFICJD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7CF44A0", Offset = "0x7CF36A0", VA = "0x187CF44A0")]
	[BurstCompile]
	public unsafe static void GPIOKCMCGAC([NoAlias] DONGPPNMCPL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3CD0", Offset = "0x7CF2ED0", VA = "0x187CF3CD0")]
	[BurstCompile]
	public unsafe static void FGODGOILGOF([NoAlias] EHAPEPPJBHL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4A30", Offset = "0x7CF3C30", VA = "0x187CF4A30")]
	[BurstCompile]
	public unsafe static void INJFEDIFMJJ([NoAlias] EHBHNGLLMBC* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4120", Offset = "0x7CF3320", VA = "0x187CF4120")]
	[BurstCompile]
	public unsafe static void GILEHEMBJGH([NoAlias] GFHHMCFMPDL* LKNIKPOOJHD, int HIKIJPFMGFD, [In][NoAlias] float3* KOHBBKHIEFL, [In][NoAlias] float3* OFFILAFEDCG, [In][NoAlias] float4* DJAKFEGKIFC, [In][NoAlias] float2* IBKILBKOLMP, [In][NoAlias] float4* BJLGOJMOHMO, [Out] float3 JEJNOKIKEGD, [Out] float3 CGINAOEONCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct NOPCJKDACKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int DMMCAFJEJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 OCKNPFEJHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion FIFKOEEMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 OKLMJLGLEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int MLKDHMPMIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int IDDHCGFKLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int BLNGDOPBMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float ICLFNBIPKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 JGNNJPINBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool NKNKNBKOLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public CMKNEAGFBCH CPPAICLPGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 OKEALMPCKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float GBIDMGMNBJP;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class ABBAFNICANG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static BHLPMLOGOAA CPHJPAECICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<NOPCJKDACKI> NMCPMPMJGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<KKOJEPJJKGK> GNFGIMDCELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<POJIHKDEADG> DIKPFEOADOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<FOAHBAFICDA> FGEKAMGCPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<KKOJEPJJKGK> NFADCNGCAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<IDCFJIGKKFL> CLIBHKFFFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<FOAHBAFICDA>> GKIBDNGICNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<OKNHCIOHHKH> JNPOHJHDMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> EJKFMNLIOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> KOCIPDFDAFD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<DGGOEILGAHG.MFMMOKDHBOK> MHINLLCDEGF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KKHPKCBJJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA088A0", Offset = "0xA07AA0", VA = "0x180A088A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA088D0", Offset = "0xA07AD0", VA = "0x180A088D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DJGLDAAIOED
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xC768A0", Offset = "0xC75AA0", VA = "0x180C768A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xC768B0", Offset = "0xC75AB0", VA = "0x180C768B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7CFCAB0", Offset = "0x7CFBCB0", VA = "0x187CFCAB0")]
	public ABBAFNICANG(int HCEBMMEBEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAC80", Offset = "0x7CF9E80", VA = "0x187CFAC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAA90", Offset = "0x7CF9C90", VA = "0x187CFAA90")]
	public void BHPGJKNEABL(JobHandle KHHGIDEGAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7CFC890", Offset = "0x7CFBA90", VA = "0x187CFC890")]
	public void PFHGFNIBAKG(NOPCJKDACKI CAIGHLKIDBF, OKNHCIOHHKH FKHKLEAFGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7CFC750", Offset = "0x7CFB950", VA = "0x187CFC750")]
	public void OPLCOGOINLJ(POJIHKDEADG CAIGHLKIDBF, NativeArray<FOAHBAFICDA> MKNGKCOJHDP, int HIKIJPFMGFD, int BBBKLBHPKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7CFB110", Offset = "0x7CFA310", VA = "0x187CFB110")]
	public JobHandle LCOGNKENBON(OBIAGGAMNIO GHBMGGLGPKC, PIBCHLIPNBK CBCOHLKBGCO, float3 IELFKDEKHFO, quaternion IPGOEGHGMDA, float FMELPDPNIGM, bool MGPPDBCMAKH, int LEIGMJDOLHI = 0, int FPGHKOIJCCL = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7CFB230", Offset = "0x7CFA430", VA = "0x187CFB230")]
	public JobHandle LCOGNKENBON(OBIAGGAMNIO GHBMGGLGPKC, PIBCHLIPNBK CBCOHLKBGCO, NativeList<DGGOEILGAHG.MFMMOKDHBOK> NHPFNBABDEA, float3 IELFKDEKHFO, quaternion IPGOEGHGMDA, float FMELPDPNIGM, bool MGPPDBCMAKH, bool LFNGLNHGNGD, int LEIGMJDOLHI = 0, int FPGHKOIJCCL = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7CFC3E0", Offset = "0x7CFB5E0", VA = "0x187CFC3E0")]
	public static JobHandle OIKIFDJBFDO(JAEJCBEBFHK ODOFDLIOKAM, OBIAGGAMNIO GHBMGGLGPKC, NativeArray<int> KOCIPDFDAFD, NOPCJKDACKI CAIGHLKIDBF, JobHandle KHHGIDEGAOE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAE60", Offset = "0x7CFA060", VA = "0x187CFAE60")]
	public static JobHandle EBJPFGFDCCA(BAFEAOEGIPH ODOFDLIOKAM, OBIAGGAMNIO GHBMGGLGPKC, POJIHKDEADG CAIGHLKIDBF, NativeArray<FOAHBAFICDA> MKNGKCOJHDP, int HIKIJPFMGFD, int BBBKLBHPKOI, JobHandle KHHGIDEGAOE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JNJEFNAPJMP
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct NEJJAMNMHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer HLIOBIEFOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public GDEHJPAJNIA.DPNOPMFMHEO OAAGHLAMHCN;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA01A0", Offset = "0x5C9F3A0", VA = "0x185CA01A0")]
		public NEJJAMNMHAE(MeshRenderer HLIOBIEFOPB, GDEHJPAJNIA.DPNOPMFMHEO OAAGHLAMHCN)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7D10C70", Offset = "0x7D0FE70", VA = "0x187D10C70")]
		public static NEJJAMNMHAE PDHAGBEBCNG((MeshRenderer, GDEHJPAJNIA.DPNOPMFMHEO) CFCICIOAJCD)
		{
			return default(NEJJAMNMHAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker BOIELGADFOE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker GLPOMLMIOGP;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker IPMPDDHKGKJ;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker CLDLDNMIOKA;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CB60", Offset = "0x7D0BD60", VA = "0x187D0CB60")]
	internal void PKKMGABOEKC(GameObject KLFAFLEMHDL, GDEHJPAJNIA.DDGNLGCJICL NNNDFPAEIDC, List<NEJJAMNMHAE> FKMJIBCPIPI, Material ADKDGJDNNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7D0B250", Offset = "0x7D0A450", VA = "0x187D0B250")]
	internal void EJFBJCPOJJH(GameObject KLFAFLEMHDL, GDEHJPAJNIA.DDGNLGCJICL NNNDFPAEIDC, List<NEJJAMNMHAE> FKMJIBCPIPI, List<LODGroup> IPKAPDOLBJA, Material ADKDGJDNNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7D09A40", Offset = "0x7D08C40", VA = "0x187D09A40")]
	private MeshRenderer CKCKBOOLMDO(GDEHJPAJNIA.DDGNLGCJICL NNNDFPAEIDC, Material ADKDGJDNNAD, List<NEJJAMNMHAE> FKMJIBCPIPI, bool BBFHMPBJPFP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7D0BAD0", Offset = "0x7D0ACD0", VA = "0x187D0BAD0")]
	private List<(List<NEJJAMNMHAE>, float)> IOOJMJKEPAA(GDEHJPAJNIA.DDGNLGCJICL NNNDFPAEIDC, List<LODGroup> IPKAPDOLBJA, Material ADKDGJDNNAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7D0A4F0", Offset = "0x7D096F0", VA = "0x187D0A4F0")]
	private List<List<(List<NEJJAMNMHAE>, float)>> EGKJBNAMOAB(GDEHJPAJNIA.DDGNLGCJICL NNNDFPAEIDC, List<LODGroup> IPKAPDOLBJA, Material ADKDGJDNNAD, [Out] int DALNCIEHGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JNJEFNAPJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7D0C9F0", Offset = "0x7D0BBF0", VA = "0x187D0C9F0")]
	[CompilerGenerated]
	internal static (float, int) JOOPAHJMFFI(List<List<(List<NEJJAMNMHAE> meshList, float lodTransition)>> LBDDKOCJGFH, int[] KCPODELJFPO)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MFBFHEHLICH
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker MCEOPFMIMCK;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker DJOKHCAEPFB;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker PKAMALMPAOL;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker CGJGPBHIMFE;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker PGHKKAKCPBK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker EDOEOKDBGEB;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker KKFAOCJMNHM;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly KEPOMIIOHBM NCGNKCJIGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GDEHJPAJNIA INCKBGNEHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JNJEFNAPJMP FBJMFNHIFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader FPBPNCEHEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock DNPMIGCMGKG;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E9A0", Offset = "0x7D0DBA0", VA = "0x187D0E9A0")]
	public static void CLKAPIKMEMD(GameObject KLFAFLEMHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E040", Offset = "0x7D0D240", VA = "0x187D0E040")]
	public void AFLILFPIJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7D0ED00", Offset = "0x7D0DF00", VA = "0x187D0ED00")]
	public void EHBJGIFAHFD(GameObject KLFAFLEMHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E820", Offset = "0x7D0DA20", VA = "0x187D0E820")]
	private bool CIEMFCECLOL(MeshRenderer HLIOBIEFOPB, [Out] MeshFilter LGPJGNKNJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F860", Offset = "0x7D0EA60", VA = "0x187D0F860")]
	private bool IFEJBHEIJNF(int CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FAC0", Offset = "0x7D0ECC0", VA = "0x187D0FAC0")]
	private void IPFLHHIBNFF(GameObject KLFAFLEMHDL, int CMDFFDAPDIB, Material ADKDGJDNNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F020", Offset = "0x7D0E220", VA = "0x187D0F020")]
	private List<JNJEFNAPJMP.NEJJAMNMHAE> HLBELHBIJOL(int CMDFFDAPDIB, [Out] List<LODGroup> IPKAPDOLBJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FDA0", Offset = "0x7D0EFA0", VA = "0x187D0FDA0")]
	private List<(int, Material)> LMBNGCMNAGL(float AGJLOOIFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EF70", Offset = "0x7D0E170", VA = "0x187D0EF70")]
	public void FKEDJLMBNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7D10340", Offset = "0x7D0F540", VA = "0x187D10340")]
	private bool OILKBAPOBLH(GameObject LBBGHAOMHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7D10C10", Offset = "0x7D0FE10", VA = "0x187D10C10")]
	public MFBFHEHLICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class GDEHJPAJNIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct DDGNLGCJICL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 AFOBMPBBEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 FHHDCGHGHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float AEIBMBLIDKC;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7D005B0", Offset = "0x7CFF7B0", VA = "0x187D005B0")]
		public DDGNLGCJICL(Bounds CMJBIEKALPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7D004A0", Offset = "0x7CFF6A0", VA = "0x187D004A0")]
		public DDGNLGCJICL(float3 AFOBMPBBEDH, float3 FHHDCGHGHIP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct JGHOPNAKMJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public DDGNLGCJICL KFDOFDMCGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int CKPIIABJEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int ALAFEFBIDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float MEHANNKOPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int GJODKHLCBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int HJNBKCHBGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int CMMMGELIPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int AICCIODMNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int JDLLIBMHNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool KNCKBJHNOEF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct DPNOPMFMHEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh OBJAHFCONND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 LGBMKLCPOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int PGGAGFOHNBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct KLOPKEMBAIO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<JGHOPNAKMJA> CHHDDEKAGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> LLGFOHBEPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int OLJMJIOBNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public DDGNLGCJICL CMJBIEKALPE;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D5B0", Offset = "0x7D0C7B0", VA = "0x187D0D5B0")]
		private float BOOBBOPFPEB(DDGNLGCJICL BGPKBCGBDMP, DDGNLGCJICL NIJBGCGEGBN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D6E0", Offset = "0x7D0C8E0", VA = "0x187D0D6E0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker HAEABNKMCHO;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker KPDBJFOCMAJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker LNAHMMNHDIN;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker DGNJFCKCANH;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker ABAGBFEHBPN;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker PFAJGBGBFFH;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker COLNMILABAE;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker LGPJFFPCEAL;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker IFPKEMGPBFD;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker NHOHBAFPKPE;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker GOOCNJMBLGF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker NKOAFCKDLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<JGHOPNAKMJA> CHHDDEKAGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> MMKCDEALNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int NIPKLPEJIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> GHEIONLKDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<DPNOPMFMHEO> DFGGGCAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> IPKAPDOLBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> FMCAADOPCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> LBFOLKLKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader LBNBOLGPBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader CAAKEENBHPF;

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7D071D0", Offset = "0x7D063D0", VA = "0x187D071D0")]
	public GDEHJPAJNIA(int JNANDDFFHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7D06840", Offset = "0x7D05A40", VA = "0x187D06840")]
	private void NINGFPCJKEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7D04190", Offset = "0x7D03390", VA = "0x187D04190")]
	public bool BBIOFCJIOLO(MeshRenderer EDJMJHPPKIL, MeshFilter GGJELFDCPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7D033F0", Offset = "0x7D025F0", VA = "0x187D033F0")]
	public bool BBIOFCJIOLO(LODGroup OMHKOMBKDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7D069B0", Offset = "0x7D05BB0", VA = "0x187D069B0")]
	private bool NJCAMOKKLGF(MeshRenderer EDJMJHPPKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7D052F0", Offset = "0x7D044F0", VA = "0x187D052F0")]
	private int ECGBCEKOJLC(MeshRenderer EDJMJHPPKIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7D05D60", Offset = "0x7D04F60", VA = "0x187D05D60")]
	private int HMKJMBDOLJM(LODGroup OMHKOMBKDFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7D06A30", Offset = "0x7D05C30", VA = "0x187D06A30")]
	private int NPLHHHBOHOJ(MeshFilter GGJELFDCPKK, int MDGNJPMMNIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7D03060", Offset = "0x7D02260", VA = "0x187D03060")]
	private int AKBIDFKKHCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7D06450", Offset = "0x7D05650", VA = "0x187D06450")]
	private static DDGNLGCJICL LAOMJLOBOPC(DDGNLGCJICL BGPKBCGBDMP, DDGNLGCJICL NIJBGCGEGBN)
	{
		return default(DDGNLGCJICL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7D046A0", Offset = "0x7D038A0", VA = "0x187D046A0")]
	private static float BMBDJKJKKLH(Vector3 AFOBMPBBEDH, Vector3 FHHDCGHGHIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7D06B90", Offset = "0x7D05D90", VA = "0x187D06B90")]
	private int ONJIIMKONDH(int GMJAOFAAELI, DDGNLGCJICL IFOMLDJNCMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7D04FB0", Offset = "0x7D041B0", VA = "0x187D04FB0")]
	private void DPDEIONPONG(DDGNLGCJICL IFOMLDJNCMB, int CMDFFDAPDIB, [Out] float NHKJCEKFABM, [Out] float OHMEAFNGBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7D04AB0", Offset = "0x7D03CB0", VA = "0x187D04AB0")]
	private void DJCLHIPMOGE(DDGNLGCJICL IFOMLDJNCMB, int LJBFBPMBAOK, Material ADKDGJDNNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7D04830", Offset = "0x7D03A30", VA = "0x187D04830")]
	private float BOOBBOPFPEB(DDGNLGCJICL BGPKBCGBDMP, DDGNLGCJICL NIJBGCGEGBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7D058A0", Offset = "0x7D04AA0", VA = "0x187D058A0")]
	private void GGAADOIBFGC(int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7D05410", Offset = "0x7D04610", VA = "0x187D05410")]
	private void FKHMKOAHLEN(int AMOPLAKIEKI, int EBBCBLHPEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7D05E20", Offset = "0x7D05020", VA = "0x187D05E20")]
	private void KBMICEMKEKI(int AMOPLAKIEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7D05240", Offset = "0x7D04440", VA = "0x187D05240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct FEDDBOFDMEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 IJIKKLFMGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 NEBGJALNIOI;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class OEGJHGCOHKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<FEDDBOFDMEN> PLFBEJLCLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> JGPLEEKIFHJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KKHPKCBJJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DJGLDAAIOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA036F0", Offset = "0xA028F0", VA = "0x180A036F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7D12C20", Offset = "0x7D11E20", VA = "0x187D12C20")]
	public OEGJHGCOHKK(int GJODKHLCBNE, int AEKPCFCEKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7D12AE0", Offset = "0x7D11CE0", VA = "0x187D12AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7D12B40", Offset = "0x7D11D40", VA = "0x187D12B40")]
	public void PECECAOBPHM(OEGJHGCOHKK OAPIHMFBAOP, int DCFHNGNIKNP, int KOKMPCAPCJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class BENNNHDOMCI
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static OEGJHGCOHKK FGNLAOGIPAP;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<KKOJEPJJKGK> HBJDPLAHFPI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] IFOPFMFHPNA;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool BELAGEOGFKI;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, OEGJHGCOHKK> MFIFKDMDKOG;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, OEGJHGCOHKK> GIFLIPLOMPH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool NBLBMMCGCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF540", Offset = "0x7CFE740", VA = "0x187CFF540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<KKOJEPJJKGK> OOKDGMMEFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE790", Offset = "0x7CFD990", VA = "0x187CFE790")]
		get
		{
			return default(NativeList<KKOJEPJJKGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static OEGJHGCOHKK ILPHCNMIBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE2F0", Offset = "0x7CFD4F0", VA = "0x187CFE2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7CFEC80", Offset = "0x7CFDE80", VA = "0x187CFEC80")]
	private static void KKPEEEMKGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE740", Offset = "0x7CFD940", VA = "0x187CFE740")]
	public static int FPIBCIKHPHF(bool CMINMLCFEFK, int EPDMOMIBBDK, bool BHNHEAIBJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE820", Offset = "0x7CFDA20", VA = "0x187CFE820")]
	private static int JEIMIKFCFIM(int EPDMOMIBBDK, bool EHBNDMEOJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE840", Offset = "0x7CFDA40", VA = "0x187CFE840")]
	private static int JIKBHBJNMPP(int EPDMOMIBBDK, bool EHBNDMEOJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE3B0", Offset = "0x7CFD5B0", VA = "0x187CFE3B0")]
	public static int FAGAFCGPFAJ(int AEABCPDILIB, int EPDMOMIBBDK, int BIBBLNECHCI, bool EHBNDMEOJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF4B0", Offset = "0x7CFE6B0", VA = "0x187CFF4B0")]
	public static int NKENAIFJDNP(int AEABCPDILIB, int EPDMOMIBBDK, int BIBBLNECHCI, bool EHBNDMEOJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE380", Offset = "0x7CFD580", VA = "0x187CFE380")]
	public static int CAHMPAGFFPE(int BIBBLNECHCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDEE0", Offset = "0x7CFD0E0", VA = "0x187CFDEE0")]
	private static int AGGLBFPPFPF(int EPDMOMIBBDK, bool EHBNDMEOJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE770", Offset = "0x7CFD970", VA = "0x187CFE770")]
	private static int GKIFEAHMAFE(int EPDMOMIBBDK, bool EHBNDMEOJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE6D0", Offset = "0x7CFD8D0", VA = "0x187CFE6D0")]
	public static int FENONJJNFHJ(int AEABCPDILIB, int EPDMOMIBBDK, int BIBBLNECHCI, bool EHBNDMEOJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF330", Offset = "0x7CFE530", VA = "0x187CFF330")]
	public static int LHMGMLNKBPB(int AEABCPDILIB, int EPDMOMIBBDK, int BIBBLNECHCI, bool EHBNDMEOJAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE390", Offset = "0x7CFD590", VA = "0x187CFE390")]
	public static int DICFENBDBBL(int BIBBLNECHCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF3C0", Offset = "0x7CFE5C0", VA = "0x187CFF3C0")]
	public static OEGJHGCOHKK LNMNJJHIDJH(int EPDMOMIBBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE440", Offset = "0x7CFD640", VA = "0x187CFE440")]
	private static OEGJHGCOHKK FDINPPPLLNM(int EPDMOMIBBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7CFEB90", Offset = "0x7CFDD90", VA = "0x187CFEB90")]
	public static OEGJHGCOHKK KBPAJJGPFDD(int EPDMOMIBBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE850", Offset = "0x7CFDA50", VA = "0x187CFE850")]
	private static OEGJHGCOHKK JJKBGGFOFBD(int EPDMOMIBBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDEF0", Offset = "0x7CFD0F0", VA = "0x187CFDEF0")]
	public static void AJLHFJKFAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct POJIHKDEADG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int CEIOHKKNEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 OCKNPFEJHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion FIFKOEEMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float OKLMJLGLEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float ACIBIADHFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int MLKDHMPMIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int IDDHCGFKLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int BLNGDOPBMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool KELBBDIAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool FEEDPHGPFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float ICLFNBIPKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 JGNNJPINBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool HMKLAPIIBOC;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct IDCFJIGKKFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int KHBCEICJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int NNLEOODBEIH;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct BAFEAOEGIPH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<POJIHKDEADG> LDMFMJBFEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<FOAHBAFICDA> EMKPJEBBFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<KKOJEPJJKGK> MEJGPCEJAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<IDCFJIGKKFL> KEJLMNAAOCC;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD8F0", Offset = "0x7CFCAF0", VA = "0x187CFD8F0")]
	public BAFEAOEGIPH(NativeArray<FOAHBAFICDA> EMKPJEBBFBE, int GCFCAGDGDIN = 1, Allocator DPAKHKILCMF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD800", Offset = "0x7CFCA00", VA = "0x187CFD800", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct GKLELHAJJEH : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<FEDDBOFDMEN> MHHGFPNNGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> NOHPBCEIAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<KKOJEPJJKGK> GIGAGPDFPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<POJIHKDEADG> LDMFMJBFEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<FOAHBAFICDA> EMKPJEBBFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<KKOJEPJJKGK> MEJGPCEJAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<IDCFJIGKKFL> KEJLMNAAOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int OPFKIMCNNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int OHNPDKICEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 IGNIPHEPIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion JFGCNCBIKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 MKAIEANGJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FDNBHPMDCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OCBNGEBNOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GHMMPOPOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NGELECJCACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FEFCANLLIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JHDADOPNDPJ;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D09400", Offset = "0x7D08600", VA = "0x187D09400")]
	public GKLELHAJJEH(ABBAFNICANG DFJJCCJCBCA, OBIAGGAMNIO MFALEEINIFK, float3 OBHMJADBJOB, quaternion GAKLFEJMLMN, float GHDPLEEDNDL, int LEIGMJDOLHI = 0, int FPGHKOIJCCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D09680", Offset = "0x7D08880", VA = "0x187D09680")]
	public GKLELHAJJEH(BAFEAOEGIPH DFJJCCJCBCA, OBIAGGAMNIO MFALEEINIFK, float3 OBHMJADBJOB, quaternion GAKLFEJMLMN, float3 GHDPLEEDNDL, int LEIGMJDOLHI = 0, int FPGHKOIJCCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D092B0", Offset = "0x7D084B0", VA = "0x187D092B0")]
	private float3 NELKJDMAEDG(float3 FEAAAPAHPKN, Matrix4x4 AMPJPBGKCNP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D08DF0", Offset = "0x7D07FF0", VA = "0x187D08DF0")]
	private float3x3 HJPCLBFMFKF(float3x3 JOGKEEHOPKE, float3x3 ALLJMFKIICA)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D093F0", Offset = "0x7D085F0", VA = "0x187D093F0")]
	private float PEEFMHPJKJK(float GPOEDAABNAL, float AILNNBEHGPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D076D0", Offset = "0x7D068D0", VA = "0x187D076D0", Slot = "4")]
	public void Execute(int CIAPLOIMNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D07560", Offset = "0x7D06760", VA = "0x187D07560")]
	private void EPANNGOPGFH(int LFBIAAJKPPD, float3 FICCENLPJEL, float3 BNGNHOGLPHP, float3 HGJENMIPHNG, float DKGEGBLOEHH, bool PFJCIOIHOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D08E70", Offset = "0x7D08070", VA = "0x187D08E70")]
	private void IKDFNJJFNDG(POJIHKDEADG DCPFLNHNKGC, float3 ICPEADDPOJA, float3x3 DIFHEMCKFDL, float GPOEDAABNAL, int EHFCEKGDPGE, int BDENEIDNNMM, int MNANCFGCHGK, float ANKOEGMGKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D08870", Offset = "0x7D07A70", VA = "0x187D08870")]
	private void GPCBPEPDJKE(int LFBIAAJKPPD, int FLIBKIJHJEG, POJIHKDEADG DCPFLNHNKGC, float3 ICPEADDPOJA, float3x3 DIFHEMCKFDL, bool PCBCNMBALLH, float GPOEDAABNAL, int GBGJMAOPKEM, int BPNAFFICPBB, int MNANCFGCHGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct JAEJCBEBFHK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<NOPCJKDACKI> BPBDJFOPOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<KKOJEPJJKGK> KEGMMMADBJA;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D09950", Offset = "0x7D08B50", VA = "0x187D09950")]
	public JAEJCBEBFHK(int GCFCAGDGDIN, Allocator DPAKHKILCMF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D098B0", Offset = "0x7D08AB0", VA = "0x187D098B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct EDBELCFBMKF : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum GGAJFDINPHC
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
	private NativeList<float3> BNIAFANPLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> CEJJGOHBJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> MLAAADMMIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> NEDPGDDLAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> NNHCEBGMKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> KPBKEIMGPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> AHBFAIEFGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> PANJOPNPEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> EANFCJNPKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<KKOJEPJJKGK> NGJDEOPEBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<NOPCJKDACKI> BPBDJFOPOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<KKOJEPJJKGK> KEGMMMADBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int OPFKIMCNNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int OHNPDKICEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FDNBHPMDCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OCBNGEBNOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GHMMPOPOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NGELECJCACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FEFCANLLIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KOCIPDFDAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JHDADOPNDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 MKAIEANGJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion JFGCNCBIKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 IGNIPHEPIBH;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D02100", Offset = "0x7D01300", VA = "0x187D02100")]
	public EDBELCFBMKF(ABBAFNICANG DFJJCCJCBCA, OBIAGGAMNIO MFALEEINIFK, NativeArray<int> LDPECHNIFEF, float3 OBHMJADBJOB, quaternion GAKLFEJMLMN, float GHDPLEEDNDL, int LEIGMJDOLHI = 0, int FPGHKOIJCCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D02310", Offset = "0x7D01510", VA = "0x187D02310")]
	public EDBELCFBMKF(JAEJCBEBFHK CAIGHLKIDBF, OBIAGGAMNIO MFALEEINIFK, NativeArray<int> LDPECHNIFEF, float3 OBHMJADBJOB, quaternion GAKLFEJMLMN, float3 GHDPLEEDNDL, int LEIGMJDOLHI = 0, int FPGHKOIJCCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D00CE0", Offset = "0x7CFFEE0", VA = "0x187D00CE0", Slot = "4")]
	public void Execute(int CIAPLOIMNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D01C90", Offset = "0x7D00E90", VA = "0x187D01C90")]
	private void HEPNPBLDKJF(float4x4 CNHJCNHBCFB, int CIAPLOIMNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D02090", Offset = "0x7D01290", VA = "0x187D02090")]
	private GGAJFDINPHC MEGBNPBANBM(float3 BNGNHOGLPHP)
	{
		return default(GGAJFDINPHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D02040", Offset = "0x7D01240", VA = "0x187D02040")]
	private float4 IPEPBIPBNPP(GGAJFDINPHC EEEICBALCGN, int CMDFFDAPDIB)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D00CA0", Offset = "0x7CFFEA0", VA = "0x187D00CA0")]
	private float2 EJDABBPLNPJ(GGAJFDINPHC EEEICBALCGN, float3 FICCENLPJEL)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct OKNHCIOHHKH
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum DCAAJJNDBCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static OKNHCIOHHKH BCEMEONNHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 MILMNOPOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 DDKKAJIGLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 BBPOBHNIEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public DCAAJJNDBCG BGLOFMKFAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 PJHBOPIELEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 FABMHOPMGPG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool APFGOMCKPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D12CE0", Offset = "0x7D11EE0", VA = "0x187D12CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 DOIJHAMJAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7D12CF0", Offset = "0x7D11EF0", VA = "0x187D12CF0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D13650", Offset = "0x7D12850", VA = "0x187D13650")]
	public OKNHCIOHHKH(float3 FICCENLPJEL, quaternion NDOBKEDDJAJ, float3 GCFCAGDGDIN, DCAAJJNDBCG GDHKDBJPDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D12DD0", Offset = "0x7D11FD0", VA = "0x187D12DD0")]
	public float JLECLKIHHEI(float3 ICPEADDPOJA, float EPCKGLCFCGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D12FD0", Offset = "0x7D121D0", VA = "0x187D12FD0")]
	public bool LGIGJJEKIJA(float3 BNGNHOGLPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D13350", Offset = "0x7D12550", VA = "0x187D13350")]
	public void NIJAKPPCOOK(float3 GDGNHPGDOFI, float3x3 PNEEJFDLDIH, float LCJAKDBDBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D13500", Offset = "0x7D12700", VA = "0x187D13500")]
	private void PLDNLAEJJLF(float3 IBLGPKNKJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D130C0", Offset = "0x7D122C0", VA = "0x187D130C0")]
	public void NFKIEENOECA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct AOIMCHABGNE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<OKNHCIOHHKH> CAIGHLKIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> FDOENJHIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> BOCKDNCNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EJKFMNLIOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<KKOJEPJJKGK> KEGMMMADBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int EPBNMJGIPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int BENCPHHAGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float EPCKGLCFCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float BNOBOBCMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GKOCHLDBJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> NAABFADJAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> BBDIDNFIGJJ;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD760", Offset = "0x7CFC960", VA = "0x187CFD760")]
	public AOIMCHABGNE(OBIAGGAMNIO CGGHHEJPJND, float GIOFOOGFKMJ, int KOKMPCAPCJD, int EHFCEKGDPGE, NativeList<OKNHCIOHHKH> CAIGHLKIDBF, NativeArray<int> EJKFMNLIOPN, NativeList<KKOJEPJJKGK> KEGMMMADBJA, PIBCHLIPNBK CBCOHLKBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7CFCD90", Offset = "0x7CFBF90", VA = "0x187CFCD90", Slot = "4")]
	public void Execute(int KABOIBILPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CFCCD0", Offset = "0x7CFBED0", VA = "0x187CFCCD0")]
	private bool CNAOKBLBJNJ(OKNHCIOHHKH BGPKBCGBDMP, OKNHCIOHHKH NIJBGCGEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD4D0", Offset = "0x7CFC6D0", VA = "0x187CFD4D0")]
	private bool OMLCOFEGCFO(OKNHCIOHHKH DEIMDHJJNKD, int FMOJEMICKOG, int LPKILCFBBED, int PKKECIAAKOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct GCCJPIIMJGL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<DGGOEILGAHG.MFMMOKDHBOK> NHPFNBABDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> NMHNCHEKMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int LEIGMJDOLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int FPGHKOIJCCL;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D03040", Offset = "0x7D02240", VA = "0x187D03040")]
	public GCCJPIIMJGL(NativeList<DGGOEILGAHG.MFMMOKDHBOK> NHPFNBABDEA, NativeArray<int> NMHNCHEKMDL, int FPGHKOIJCCL = 0, int LEIGMJDOLHI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D02F90", Offset = "0x7D02190", VA = "0x187D02F90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class PIBCHLIPNBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> NDLBOEIKBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> NLCNLDKJOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> KAKCDIDABBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> EJLFMKPFNOM;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D13830", Offset = "0x7D12A30", VA = "0x187D13830")]
	public void CDONPKCPGIP(int GJODKHLCBNE, int AEKPCFCEKPO, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D13A40", Offset = "0x7D12C40", VA = "0x187D13A40")]
	public static long FJPFMMCAJOJ(int GJODKHLCBNE, int AEKPCFCEKPO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D13950", Offset = "0x7D12B50", VA = "0x187D13950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D13740", Offset = "0x7D12940", VA = "0x187D13740")]
	public void BHPGJKNEABL(JobHandle KHHGIDEGAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PIBCHLIPNBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct BBDPFDDOJFE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> FDOENJHIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> OFFILAFEDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> BJLGOJMOHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> IBKILBKOLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> BOCKDNCNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DJAKFEGKIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> MHAMJFHEINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> GKOCHLDBJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> NAABFADJAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int LEIGMJDOLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int FPGHKOIJCCL;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDE60", Offset = "0x7CFD060", VA = "0x187CFDE60")]
	public BBDPFDDOJFE(OBIAGGAMNIO CGGHHEJPJND, PIBCHLIPNBK CBCOHLKBGCO, int FPGHKOIJCCL = 0, int LEIGMJDOLHI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDA20", Offset = "0x7CFCC20", VA = "0x187CFDA20", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDE00", Offset = "0x7CFD000", VA = "0x187CFDE00")]
	private void GONJCCIHGCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class LNHOMHGAJDL
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD1A0", Offset = "0x3ACC3A0", VA = "0x183ACD1A0")]
	public static bool FKOFFJHHOPL<T>(NativeArray<T> KBILCKNPAKO, int GCFCAGDGDIN, Allocator DPAKHKILCMF, NativeArrayOptions AFJJJNJGALF = NativeArrayOptions.ClearMemory, int OCEPPCDJGBO = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD370", Offset = "0x3ACC570", VA = "0x183ACD370")]
	public static bool FKOFFJHHOPL<T>(NativeList<T> CFFEIIKPOPD, int GCFCAGDGDIN, Allocator DPAKHKILCMF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD240", Offset = "0x3ACC440", VA = "0x183ACD240")]
	public static bool FKOFFJHHOPL<T>(NativeQueue<T> IIOIMKJECAH, Allocator DPAKHKILCMF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum JFHEFEBDPBL
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
public interface GAPLKABMPAJ
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NBFOPEBCFOD(JFHEFEBDPBL AEABCPDILIB);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int NJAOEBNGOEG(JFHEFEBDPBL AEABCPDILIB);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DJNIFEMIMBD PJILNBLKJJJ();

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float MCEBCKIHEPA();

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKIIKKCMDOD(JFHEFEBDPBL AEABCPDILIB, ABBAFNICANG MMLCEMNKICA, int POPPFCECMBF = -1);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int FKDNLIODKMM(int DPHJHINJAIC);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class MCBMJFFAMAP
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DFF0", Offset = "0x7D0D1F0", VA = "0x187D0DFF0")]
	public static void AJLHFJKFAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class NGHGHDFAFLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> PIOFNOHANHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> LJNGMMFPJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> MMENCOMEBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> KAINGBEECHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> CBOCIPAMOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> OOAOBJJPGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> AHFHEKFBOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> EFFIFPFNJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> LMHHBOPHABB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KKHPKCBJJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D11670", Offset = "0x7D10870", VA = "0x187D11670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DJGLDAAIOED
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D11B80", Offset = "0x7D10D80", VA = "0x187D11B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ILJMINAEHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D11B40", Offset = "0x7D10D40", VA = "0x187D11B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D12460", Offset = "0x7D11660", VA = "0x187D12460")]
	public NGHGHDFAFLN(int GJODKHLCBNE, int AEKPCFCEKPO, int CLMFIGEIKPC, Allocator DPAKHKILCMF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D12780", Offset = "0x7D11980", VA = "0x187D12780")]
	public NGHGHDFAFLN(Mesh CGGHHEJPJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D11550", Offset = "0x7D10750", VA = "0x187D11550", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D12130", Offset = "0x7D11330", VA = "0x187D12130")]
	public void PECECAOBPHM(NGHGHDFAFLN CGGHHEJPJND, bool LLBCLGIHJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D116B0", Offset = "0x7D108B0", VA = "0x187D116B0")]
	private void IMADGPLGFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D11BC0", Offset = "0x7D10DC0", VA = "0x187D11BC0")]
	private void OPIMHFDMMNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct KKOJEPJJKGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int FKALOIMKJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int KKHPKCBJJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int MBAOCHHAEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int DJGLDAAIOED;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2057F60", Offset = "0x2057160", VA = "0x182057F60")]
	public KKOJEPJJKGK(int EHFCEKGDPGE, int HIKIJPFMGFD, int KOKMPCAPCJD, int BBBKLBHPKOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class BHLPMLOGOAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<KKOJEPJJKGK> OPIBHGHDEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<KKOJEPJJKGK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xD9D600", Offset = "0xD9C800", VA = "0x180D9D600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NGHGHDFAFLN OBJAHFCONND
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF780", Offset = "0x7CFE980", VA = "0x187CFF780")]
	public BHLPMLOGOAA(IEnumerable<NGHGHDFAFLN> ECMMPHFCBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF710", Offset = "0x7CFE910", VA = "0x187CFF710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum CMKNEAGFBCH
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class NBKDJINGGKE
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> FHPABLEOJLJ;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> GGBIBEOCDDL;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> CDHOEGMGILM;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> BEBOBFAFDHE;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D278F0", Offset = "0x7D26AF0", VA = "0x187D278F0")]
	public static void AJLHFJKFAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D27C00", Offset = "0x7D26E00", VA = "0x187D27C00")]
	public static NativeArray<float2> EPJEHNILBCC(NativeArray<float2> HJBPDJALBAB, int OMEPPMJOIDM, NativeArray<float2> CKCBDIINMJG, int NEOMOBLANCF)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D27A00", Offset = "0x7D26C00", VA = "0x187D27A00")]
	public static NativeArray<float3> APKMCBKDPKJ(NativeArray<float3> HJBPDJALBAB, int OMEPPMJOIDM, NativeArray<float3> CKCBDIINMJG, int NEOMOBLANCF)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D27B00", Offset = "0x7D26D00", VA = "0x187D27B00")]
	public static NativeArray<float4> DJCBJAGECAH(NativeArray<float4> HJBPDJALBAB, int OMEPPMJOIDM, NativeArray<float4> CKCBDIINMJG, int NEOMOBLANCF)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D27D00", Offset = "0x7D26F00", VA = "0x187D27D00")]
	public static NativeArray<int> LHICNLAPGDL(NativeArray<int> HJBPDJALBAB, int OMEPPMJOIDM, NativeArray<int> CKCBDIINMJG, int NEOMOBLANCF)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C8B0", Offset = "0x3B5BAB0", VA = "0x183B5C8B0")]
	private static void NKCLIPFGDGN<T>(NativeArray<T> KBILCKNPAKO, int CANGAEPNPMB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C800", Offset = "0x3B5BA00", VA = "0x183B5C800")]
	private static void IPJGNNPLLBP<T>(NativeArray<T> HJBPDJALBAB, int OMEPPMJOIDM, NativeArray<T> CKCBDIINMJG, int NEOMOBLANCF, NativeArray<T> HDNLOMIFPLL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class NGOIPEMIGJI
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct MGJGGPDPNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort HGCMPGNMMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort PIALGICKFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort AKEKIBJOPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort KPOHJAMPNIM;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D28B80", Offset = "0x7D27D80", VA = "0x187D28B80")]
	public static uint KOLPNONCEBD(float BIJKOHFINCN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D28620", Offset = "0x7D27820", VA = "0x187D28620")]
	public static void BKNPBBGAIKL(float4 BJLGOJMOHMO, float IKAFFDHOLDA, [Out] uint BOGMCNHJJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D28730", Offset = "0x7D27930", VA = "0x187D28730")]
	public static void BKNPBBGAIKL(float4 BJLGOJMOHMO, uint FDGEPIINIJD, [Out] uint BOGMCNHJJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D28170", Offset = "0x7D27370", VA = "0x187D28170")]
	public static void ABGNDDLJDBB(float3 DFIPIHLDGIL, float3 MLJGBDIAPCC, float4 GJLPHNKCLDJ, float2 AIHKCDLHJFN, float4 BJLGOJMOHMO, [Out] OBIAGGAMNIO.EHBHNGLLMBC DNNOEILHJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D283C0", Offset = "0x7D275C0", VA = "0x187D283C0")]
	public static void ABGNDDLJDBB(float3 DFIPIHLDGIL, float3 MLJGBDIAPCC, float4 GJLPHNKCLDJ, float2 AIHKCDLHJFN, float4 BJLGOJMOHMO, [Out] OBIAGGAMNIO.GFHHMCFMPDL DNNOEILHJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D28AE0", Offset = "0x7D27CE0", VA = "0x187D28AE0")]
	public static byte JJDFPJMCJEA(float KJIOHKMJAPE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D28B30", Offset = "0x7D27D30", VA = "0x187D28B30")]
	public static ushort JNGMOBAHKDP(float KJIOHKMJAPE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D28800", Offset = "0x7D27A00", VA = "0x187D28800")]
	public static uint DHBCABGAMME(float KJIOHKMJAPE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D28CE0", Offset = "0x7D27EE0", VA = "0x187D28CE0")]
	public static float2 PNNHCFODOMB(float2 JIKDBGFICJD)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D28B90", Offset = "0x7D27D90", VA = "0x187D28B90")]
	public static float2 OCCCBKPLIBF(float3 KAMENFELAAB)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D28990", Offset = "0x7D27B90", VA = "0x187D28990")]
	public static void IKJINFOCBJD(float3 KJIOHKMJAPE, [Out] float3 PCLLKMFDLOA, [Out] uint3 KPOHJAMPNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D28830", Offset = "0x7D27A30", VA = "0x187D28830")]
	public static MGJGGPDPNEM HJLABHPMBMB(float3 FICCENLPJEL)
	{
		return default(MGJGGPDPNEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class GNPHNAKLFHJ
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker AIEPEONLMGK;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float NCAHFKDDJBG;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void FPOMOOAADBP(bool BPDIEFNEKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D26C70", Offset = "0x7D25E70", VA = "0x187D26C70")]
	public static float LJIBGKICIHM(float NKIMLHKCKIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D27220", Offset = "0x7D26420", VA = "0x187D27220")]
	public static long ODEDHMNHFLO(float NKIMLHKCKIB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D26D80", Offset = "0x7D25F80", VA = "0x187D26D80")]
	public static void NKMPPPFJNNO(float NKIMLHKCKIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface NLFNKALGCEB
{
	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKMPPPFJNNO(float AILDKODAAAI);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) HDPPEOAIIJC(float JKCABALBMCM);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class OJJKFHIIDOO
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum MKEMHMOJNOP
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
	private class LMGLGNCDBND : POKEHGKLMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public MKEMHMOJNOP GDHKDBJPDLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public BatchedMeshRenderer HCEEMLJMDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public FIFMAOIAEPB ECEHLHKNGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public DGGOEILGAHG PKLEBJCIEAK;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override float OBFEBJHFBGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x1105650", Offset = "0x1104850", VA = "0x181105650", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x1871790", Offset = "0x1870990", VA = "0x181871790", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7D27490", Offset = "0x7D26690", VA = "0x187D27490", Slot = "7")]
		public override void FAIPCIDKNKC([Out] bool NCEEEBPHGGB, [Out] bool NHMNBKKOLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LMGLGNCDBND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int ONIIIIJLDEM;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int KPFNJMJNPMN;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int LBAALGELIJE;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long EPHOKKDGMGO;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long DILJCPDELAG;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long DAEOAMDJNJN;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long HFOFBEGCGML;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int DPDOJCKLMHH;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float KFCBICAPOAI;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool PJIKBCKKCMK;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int JIAHIEEFNCB;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int NDPJCJHBIKN;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int DINLMEDCAJL;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long LGHEHJDGIKO;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int DCBGKOIIGGN;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool EFAPAIMKNKK;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static uint HCNJHPIFLOL;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static BHLCPHIDAOC BGKBFNBLNNF;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static List<uint> LHKCEIJECNN;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static NLFNKALGCEB DDENPCOGPHN;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool KIMMLFHBKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7D291C0", Offset = "0x7D283C0", VA = "0x187D291C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void LNLCDBACOJP(bool BPDIEFNEKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void FPOMOOAADBP(bool BPDIEFNEKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void LNLCDBACOJP(bool BPDIEFNEKNC, string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7D292E0", Offset = "0x7D284E0", VA = "0x187D292E0")]
	public static void CCAMCJMJIKJ(NLFNKALGCEB OPDMNGLAJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C8A0", Offset = "0x7D2BAA0", VA = "0x187D2C8A0")]
	public static (long, long, long, int, int) PCCKPOHJNIM(long AKPLNEEPLNO)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7D29A70", Offset = "0x7D28C70", VA = "0x187D29A70")]
	public static void GGKIGCAEHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A5D0", Offset = "0x7D297D0", VA = "0x187D2A5D0")]
	public static void NKMPPPFJNNO(long AKPLNEEPLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A230", Offset = "0x7D29430", VA = "0x187D2A230")]
	public static void MBBFHBKPCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7D298D0", Offset = "0x7D28AD0", VA = "0x187D298D0")]
	public static long FOOAIICOKPH(long BLINEOAJGIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7D29210", Offset = "0x7D28410", VA = "0x187D29210")]
	public static bool BHACNIDBCHM(long FALBHEBFNIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C720", Offset = "0x7D2B920", VA = "0x187D2C720")]
	public static bool NMAJDCDKOMJ(long FALBHEBFNIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7D28DE0", Offset = "0x7D27FE0", VA = "0x187D28DE0")]
	public static float AMIHAMEDALH(long BBCGEFEOFNM, int PDDALPKBCFH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7D29AF0", Offset = "0x7D28CF0", VA = "0x187D29AF0")]
	public static (long, long, int) HDPPEOAIIJC(float NKIMLHKCKIB)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A0A0", Offset = "0x7D292A0", VA = "0x187D2A0A0")]
	public static void JLFFIDNKFGI(DGGOEILGAHG PKLEBJCIEAK, BatchedMeshRenderer HCEEMLJMDHF, long IEELEBBGBJG, long BPFEMMOAIGA, float GIOOCEBJFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7D29750", Offset = "0x7D28950", VA = "0x187D29750")]
	public static void FEIKAONLBGJ(DGGOEILGAHG PKLEBJCIEAK, BatchedMeshRenderer HCEEMLJMDHF, long IEELEBBGBJG, long BPFEMMOAIGA, float AJGIMHCHAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A3B0", Offset = "0x7D295B0", VA = "0x187D2A3B0")]
	public static void MHFPECJECCF(DGGOEILGAHG PKLEBJCIEAK, BatchedMeshRenderer HCEEMLJMDHF, long BPFEMMOAIGA, float AJGIMHCHAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7D29EF0", Offset = "0x7D290F0", VA = "0x187D29EF0")]
	public static void IDGGKKHOCGL(DGGOEILGAHG PKLEBJCIEAK, BatchedMeshRenderer HCEEMLJMDHF, long IEELEBBGBJG, long BPFEMMOAIGA, float AJGIMHCHAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7D29350", Offset = "0x7D28550", VA = "0x187D29350")]
	private static void DEJDGFOKCEF(MKEMHMOJNOP GDHKDBJPDLG, DGGOEILGAHG PKLEBJCIEAK, FIFMAOIAEPB ECEHLHKNGKD, BatchedMeshRenderer HCEEMLJMDHF, long IEELEBBGBJG, long BPFEMMOAIGA, float HOGLBANEBNG, bool EJMJLLPOFMA, bool HNKBJPBPNLK, float JKPJMPOAKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C7F0", Offset = "0x7D2B9F0", VA = "0x187D2C7F0")]
	public static bool OHEFFKDINBD(float KAPOEKCKIEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A560", Offset = "0x7D29760", VA = "0x187D2A560")]
	public static void MPNMCAPEBJM(float KAPOEKCKIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7D29640", Offset = "0x7D28840", VA = "0x187D29640")]
	public static bool EAIPMIFFKLD(float KAPOEKCKIEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class POKEHGKLMDH : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum BMGEIKFMFOE : byte
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
	public BMGEIKFMFOE DFEBCJBADHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public long JHMJDIDNOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public long BPFEMMOAIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public float EKPJADFBJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public bool HNKBJPBPNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool EJMJLLPOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	internal uint APBCLGNDGBE;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract float OBFEBJHFBGN
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
	public abstract void FAIPCIDKNKC([Out] bool NCEEEBPHGGB, [Out] bool NHMNBKKOLNO);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7D2CD70", Offset = "0x7D2BF70", VA = "0x187D2CD70", Slot = "4")]
	public int CompareTo(object KFMNDOMPAMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected POKEHGKLMDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class BHLCPHIDAOC : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private List<POKEHGKLMDH> DPNONFNOFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private List<POKEHGKLMDH> HKHIMAGDJKJ;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7D13D30", Offset = "0x7D12F30", VA = "0x187D13D30")]
	public void LHOMNBOIMGH(POKEHGKLMDH LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7D13CD0", Offset = "0x7D12ED0", VA = "0x187D13CD0")]
	public void DNECOIMFKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7D14160", Offset = "0x7D13360", VA = "0x187D14160")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7D13E00", Offset = "0x7D13000", VA = "0x187D13E00")]
	public void MPAKAIGFMHI(IEnumerable<uint> LHKCEIJECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7D141F0", Offset = "0x7D133F0", VA = "0x187D141F0")]
	private void PKCJOLGDFLO(uint APBCLGNDGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7D142B0", Offset = "0x7D134B0", VA = "0x187D142B0", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7D13C70", Offset = "0x7D12E70", VA = "0x187D13C70")]
	public NCHMENGCHED BFKODFEKGDL()
	{
		return default(NCHMENGCHED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7D14350", Offset = "0x7D13550", VA = "0x187D14350")]
	public BHLCPHIDAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct NCHMENGCHED : IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private List<POKEHGKLMDH> DPNONFNOFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private List<POKEHGKLMDH> HKHIMAGDJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int NEHINOCPKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private int MLIMNNNAMAM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7D28120", Offset = "0x7D27320", VA = "0x187D28120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public POKEHGKLMDH FJFNMMOOKII
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7D27E00", Offset = "0x7D27000", VA = "0x187D27E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7D28130", Offset = "0x7D27330", VA = "0x187D28130")]
	public NCHMENGCHED(List<POKEHGKLMDH> DPNONFNOFBE, List<POKEHGKLMDH> HKHIMAGDJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7D27F80", Offset = "0x7D27180", VA = "0x187D27F80", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7D28110", Offset = "0x7D27310", VA = "0x187D28110", Slot = "6")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class FIFMAOIAEPB
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal enum JJLBGFKHPAN
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
	public static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly string EMEOGAOLBAA;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly string CDKJLMIOAPE;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker PNNLOPIOLJF;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker GKNDPLLCCDE;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker AIEPEONLMGK;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker FMIJEPIDPEM;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker JLNIECAODLB;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker JEPDJCEMAJC;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker DEBKIIFBHCH;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker LMPHBCHNOFC;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker PPKNLLJFLEE;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker APJADHKFEDL;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker OJMCIOJPMOE;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker BMOAMIAEKBC;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker HJBIFDFPLBN;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker NDAFGONNMBP;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker PKBGNAEPBFL;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker DPHCFHBKEEB;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker ACIEKAMNELL;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker KABNICJIGGF;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly ProfilerMarker KFNKDNAGIAP;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly ProfilerMarker EFHCIALMPJB;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly ProfilerMarker LNOFEAFMJCB;

	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static readonly ProfilerMarker FBGJCGCCNCH;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly ProfilerMarker KDCAODNHGBI;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly ProfilerMarker IBMNOEEAFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal readonly List<DGGOEILGAHG> DEKBEJOBMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	internal DGGOEILGAHG JPJLKPPEHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly AIBGEOBFMGI MBNFLBACKFP;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public const bool ACBAMNLIKCN = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public bool BLHIHJKNFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	internal JJLBGFKHPAN JLOJMDPJLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	internal int BKKHEIJGPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	internal int KFGNFCIBEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	internal int OLCDKDOPILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	internal int OFGAMFFJBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	internal long BDIEBBACCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	internal long DEIEADOPEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	internal long NGHHNOJDHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private OBIAGGAMNIO JNCGGIPPBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private OBIAGGAMNIO GEDMAMHOGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private OBIAGGAMNIO.EGOHCGPMAAB OOPMAEOBPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private bool EOMNPCNGNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private int JMPCAJPLGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private FOJHJOMHPKH MIPFEFJNFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private float3 OFNLFFCICDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private float FKMCHOKOEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private float BEEPMNIECJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float FHDDHOANPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private float ADBIIOOCMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float DHHEEPLONBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private float CEHINJAJFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private float3 DFBLCPBAGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float HCIHBHDCHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private float FPFIHHKBIFG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal Mesh OBJAHFCONND
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MeshFilter CHLIACBFDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MeshRenderer FPGKPDADBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3E0", Offset = "0xA0C5E0", VA = "0x180A0D3E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<Material> HLDJAHJLHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA00BC0", Offset = "0x9FFDC0", VA = "0x180A00BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int OHOAMFADECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7D23660", Offset = "0x7D22860", VA = "0x187D23660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CJBHIAIIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xDD9A20", Offset = "0xDD8C20", VA = "0x180DD9A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int KKHPKCBJJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7D23AF0", Offset = "0x7D22CF0", VA = "0x187D23AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7D234A0", Offset = "0x7D226A0", VA = "0x187D234A0")]
	public void GDBDDMOBGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7D22A90", Offset = "0x7D21C90", VA = "0x187D22A90")]
	public bool CMJAKHHPLLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7D223F0", Offset = "0x7D215F0", VA = "0x187D223F0")]
	private void CEPNPLEPGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7D25D10", Offset = "0x7D24F10", VA = "0x187D25D10")]
	private void NOAHOAJPMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7D26A70", Offset = "0x7D25C70", VA = "0x187D26A70")]
	public FIFMAOIAEPB(string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7D21E30", Offset = "0x7D21030", VA = "0x187D21E30")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7D236A0", Offset = "0x7D228A0", VA = "0x187D236A0")]
	private void HCJEKADKEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7D25F30", Offset = "0x7D25130", VA = "0x187D25F30")]
	private void OHIPHEGKNMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7D235D0", Offset = "0x7D227D0", VA = "0x187D235D0")]
	public Mesh GJJOPHAOFHA(MeshFilter LGPJGNKNJEL, Transform JGOMLHGOKKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7D22BB0", Offset = "0x7D21DB0", VA = "0x187D22BB0")]
	private void CPFJPHAHADP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7D26260", Offset = "0x7D25460", VA = "0x187D26260")]
	public void POMOILGGHLC(GAPLKABMPAJ FGPBDAMKPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7D25E60", Offset = "0x7D25060", VA = "0x187D25E60")]
	public bool NPNDPCJFFNG(GAPLKABMPAJ FGPBDAMKPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7D24F80", Offset = "0x7D24180", VA = "0x187D24F80")]
	public bool NJCAMOKKLGF(GAPLKABMPAJ FGPBDAMKPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7D24270", Offset = "0x7D23470", VA = "0x187D24270", Slot = "4")]
	public virtual void JOILAKGICEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7D23F00", Offset = "0x7D23100", VA = "0x187D23F00")]
	public void IPFELFHBLJG(Transform AMGEMGHCOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7D24430", Offset = "0x7D23630", VA = "0x187D24430")]
	public bool LAAONFBLKME(Transform AMGEMGHCOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7D249D0", Offset = "0x7D23BD0", VA = "0x187D249D0")]
	public bool MPONNOOPFKL(bool HPNPMKFHOPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7D227F0", Offset = "0x7D219F0", VA = "0x187D227F0")]
	private void CKJPBAEFDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7D25010", Offset = "0x7D24210", VA = "0x187D25010")]
	public bool NKMPPPFJNNO(float4x4 HCBKMIBOFFI, BatchedMeshRenderer IIPBCJBFEPM, bool FEAGMOHNAPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7D22CB0", Offset = "0x7D21EB0", VA = "0x187D22CB0")]
	public bool ELMCFCNGFDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7D24880", Offset = "0x7D23A80", VA = "0x187D24880")]
	public void LEBADLLLBMH(OBIAGGAMNIO CGGHHEJPJND, int BOCLJAAJIDN, int ICCEDGJPFOJ, float PEGFECMOHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7D22370", Offset = "0x7D21570", VA = "0x187D22370")]
	public (long, long, long) CCGENIHKLJD()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF570", VA = "0x180A00370")]
	public long LHEJNAKBGHA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7D21D10", Offset = "0x7D20F10", VA = "0x187D21D10")]
	private void BCBBHEGBNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7D23740", Offset = "0x7D22940", VA = "0x187D23740")]
	public (long, long, int) HDPPEOAIIJC(float NKIMLHKCKIB, float4x4 HCBKMIBOFFI)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7D23680", Offset = "0x7D22880", VA = "0x187D23680")]
	internal void HALPBKMHHGN(JJLBGFKHPAN HPKELKBJOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7D215E0", Offset = "0x7D207E0", VA = "0x187D215E0")]
	internal (float, float, float, float) AEGPJFPAKJF(float DIMBBALBKIM, float4x4 HCBKMIBOFFI)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7D22870", Offset = "0x7D21A70", VA = "0x187D22870")]
	public void CMGJPPBHBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7D22170", Offset = "0x7D21370", VA = "0x187D22170")]
	private void BJKKANEEPPE(OBIAGGAMNIO DAPFGLKHPBK, OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7D21CF0", Offset = "0x7D20EF0", VA = "0x187D21CF0")]
	private void AEHIDCBBAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7D248C0", Offset = "0x7D23AC0", VA = "0x187D248C0")]
	internal bool MOOMJBLOBJK(bool HPNPMKFHOPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7D22510", Offset = "0x7D21710", VA = "0x187D22510")]
	private void CHPICEBDDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7D23B20", Offset = "0x7D22D20", VA = "0x187D23B20")]
	private void IEIDAAMKBMP([In] AIFNOHGABOD DAPFGLKHPBK, OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG, bool NAECLJJPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7D24390", Offset = "0x7D23590", VA = "0x187D24390")]
	private void KGEFADDLPFM(OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7D261C0", Offset = "0x7D253C0", VA = "0x187D261C0")]
	private void PJHDNJEKIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7D239B0", Offset = "0x7D22BB0", VA = "0x187D239B0")]
	private void HFOOOPLCKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7D231C0", Offset = "0x7D223C0", VA = "0x187D231C0")]
	public long FOOAIICOKPH(long BLINEOAJGIP, int NLODHHJHJJB)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class DGGOEILGAHG
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum AHAOALBCKLM
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
	public struct MFMMOKDHBOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int IMEMPJAIKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int DIFDEOAGFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public float NHKJCEKFABM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct IOIOPENCFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AIFNOHGABOD CGGHHEJPJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int FPEKANMMDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int LLCGJEHNIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public long EDLDFOONHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public long HDLDGMFFJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public float JEIMNAGADHO;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7D27460", Offset = "0x7D26660", VA = "0x187D27460")]
		public void IJDFNMPLFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7D273E0", Offset = "0x7D265E0", VA = "0x187D273E0")]
		public void BHPGJKNEABL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly string EMEOGAOLBAA;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly string CDKJLMIOAPE;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker PNNLOPIOLJF;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker GKNDPLLCCDE;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker AIEPEONLMGK;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker FMIJEPIDPEM;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker JLNIECAODLB;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker JEPDJCEMAJC;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker DEBKIIFBHCH;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker LMPHBCHNOFC;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker PPKNLLJFLEE;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker APJADHKFEDL;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly ProfilerMarker OJMCIOJPMOE;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly ProfilerMarker BMOAMIAEKBC;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly ProfilerMarker HJBIFDFPLBN;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly ProfilerMarker NDAFGONNMBP;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly ProfilerMarker PKBGNAEPBFL;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly ProfilerMarker DPHCFHBKEEB;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly ProfilerMarker ACIEKAMNELL;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly ProfilerMarker KABNICJIGGF;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static readonly ProfilerMarker KFNKDNAGIAP;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly ProfilerMarker EFHCIALMPJB;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly ProfilerMarker LNOFEAFMJCB;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly ProfilerMarker FBGJCGCCNCH;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly ProfilerMarker KDCAODNHGBI;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly ProfilerMarker IBMNOEEAFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal readonly List<GAPLKABMPAJ> ELIAJIMNNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal FIFMAOIAEPB GGCOMPFEDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private readonly AIBGEOBFMGI MBNFLBACKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal int EOOOLMHLMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal int KPIGAECMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal bool DMIAICEFIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal bool HDPDBKHBECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal AHAOALBCKLM ALLBPCAEDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal bool PPCHFLKLMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal float3 POCBIIJCPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal float3 CGDEEAEKDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal float JFKCLNCMHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int OLANDMIOJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal int JLAIIDGAOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal float JBMBLJNPIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal float GIGLAMOLFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal int DCIENLPDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal long BCLBIGEJJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public int JJIKEJENFED;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal const int COIOPCCDLND = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float[] MMOPCDPHGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal int[] PDBEMALKLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal long[] FNIJMLCAHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public List<IOIOPENCFJF> BMJLPDCMKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal OBIAGGAMNIO DDNNGENJKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal long NNJGMMEFCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal int GAFCABDLAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal float LCLGFBBPOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal OBIAGGAMNIO.EGOHCGPMAAB NBJEIPCFFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal bool AKNGKFIKOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	internal DDBHCJNHKJD NLPBEKMMMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal JobHandle HENMJGNGPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal NativeList<MFMMOKDHBOK> OFDBPJGIOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal NativeArray<long> DDHCKFKLKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal bool HHCPCBDMPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	internal JobHandle EOKKHPBCMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal OBIAGGAMNIO KLPJHHEDGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	internal PIBCHLIPNBK OIAEDELCAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	internal NativeList<MFMMOKDHBOK> PNLCKBLGLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	internal Transform PBBMOJFIJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	internal JFHEFEBDPBL OELDPHAIEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	internal long LFFOLCEOOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	internal long IOJLGAJINDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	internal long NEMLAEOKCOF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<GAPLKABMPAJ> DGPCJHDMKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal int KKHPKCBJJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CB50", Offset = "0x7D1BD50", VA = "0x187D1CB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BE60", Offset = "0x7D1B060", VA = "0x187D1BE60")]
	internal void GDBDDMOBGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7D18C50", Offset = "0x7D17E50", VA = "0x187D18C50")]
	internal void CEPNPLEPGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7D212C0", Offset = "0x7D204C0", VA = "0x187D212C0")]
	internal DGGOEILGAHG(string GBOCGPJOEEK, FIFMAOIAEPB FLKKOCNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7D180D0", Offset = "0x7D172D0", VA = "0x187D180D0")]
	internal void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B090", Offset = "0x7D1A290", VA = "0x187D1B090")]
	internal void CPFJPHAHADP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7D20960", Offset = "0x7D1FB60", VA = "0x187D20960")]
	internal void POMOILGGHLC(GAPLKABMPAJ FGPBDAMKPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7D20810", Offset = "0x7D1FA10", VA = "0x187D20810")]
	internal bool NPNDPCJFFNG(GAPLKABMPAJ FGPBDAMKPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7D1EF70", Offset = "0x7D1E170", VA = "0x187D1EF70")]
	internal bool NJCAMOKKLGF(GAPLKABMPAJ FGPBDAMKPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D540", Offset = "0x7D1C740", VA = "0x187D1D540", Slot = "4")]
	internal virtual void JOILAKGICEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B670", Offset = "0x7D1A870", VA = "0x187D1B670")]
	internal long FBOLIPKDODG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7D20700", Offset = "0x7D1F900", VA = "0x187D20700")]
	internal long NKOEINDDONB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D5D0", Offset = "0x7D1C7D0", VA = "0x187D1D5D0")]
	internal bool LAAONFBLKME(Transform AMGEMGHCOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E340", Offset = "0x7D1D540", VA = "0x187D1E340")]
	internal (bool, OBIAGGAMNIO) MPONNOOPFKL(bool HPNPMKFHOPB)
	{
		return default((bool, OBIAGGAMNIO));
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7D18E10", Offset = "0x7D18010", VA = "0x187D18E10")]
	internal void CKJPBAEFDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1EFD0", Offset = "0x7D1E1D0", VA = "0x187D1EFD0")]
	internal bool NKMPPPFJNNO(float4x4 HCBKMIBOFFI, BatchedMeshRenderer IIPBCJBFEPM, bool FEAGMOHNAPH, bool FHBOAECOGBI, float BEEPMNIECJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B320", Offset = "0x7D1A520", VA = "0x187D1B320")]
	public (bool, AIFNOHGABOD) ELMCFCNGFDG()
	{
		return default((bool, AIFNOHGABOD));
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D4C0", Offset = "0x7D1C6C0", VA = "0x187D1D4C0")]
	internal void JLICJBGKLOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7D17540", Offset = "0x7D16740", VA = "0x187D17540")]
	internal bool AJBCHJJCFLG(bool HPNPMKFHOPB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7D20890", Offset = "0x7D1FA90", VA = "0x187D20890")]
	internal void OMFGICPHCJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E270", Offset = "0x7D1D470", VA = "0x187D1E270")]
	internal void LEBADLLLBMH(OBIAGGAMNIO CGGHHEJPJND, int BOCLJAAJIDN, int ICCEDGJPFOJ, float PEGFECMOHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D240", Offset = "0x7D1C440", VA = "0x187D1D240")]
	internal void IJLJDPAAOHL(AIFNOHGABOD PBDJCKKPJJE, int BOCLJAAJIDN, int ICCEDGJPFOJ, float PEGFECMOHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7D17CE0", Offset = "0x7D16EE0", VA = "0x187D17CE0")]
	internal void BCBBHEGBNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C370", Offset = "0x7D1B570", VA = "0x187D1C370")]
	internal (long, long, int) HDPPEOAIIJC(float NKIMLHKCKIB, float4x4 HCBKMIBOFFI)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C320", Offset = "0x7D1B520", VA = "0x187D1C320")]
	internal void HALPBKMHHGN(AHAOALBCKLM HPKELKBJOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7D16D60", Offset = "0x7D15F60", VA = "0x187D16D60")]
	internal (float, float, float, float) AEGPJFPAKJF(float DIMBBALBKIM, float4x4 HCBKMIBOFFI)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CAF0", Offset = "0x7D1BCF0", VA = "0x187D1CAF0")]
	private float HOHJACJLLHA(float DIMBBALBKIM, float4x4 HCBKMIBOFFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BE70", Offset = "0x7D1B070", VA = "0x187D1BE70")]
	private (int, int) GFLOPAMKAEF(float GBMJFLMMIOH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E2A0", Offset = "0x7D1D4A0", VA = "0x187D1E2A0")]
	internal static float MCBIMFOFDLA(GAPLKABMPAJ CGGHHEJPJND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7D19540", Offset = "0x7D18740", VA = "0x187D19540")]
	internal void CMGJPPBHBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7D20930", Offset = "0x7D1FB30", VA = "0x187D20930")]
	internal void PJHDNJEKIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C7D0", Offset = "0x7D1B9D0", VA = "0x187D1C7D0")]
	internal void HFOOOPLCKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B720", Offset = "0x7D1A920", VA = "0x187D1B720")]
	internal long FOOAIICOKPH(long BLINEOAJGIP, int NLODHHJHJJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A470", Offset = "0x7D19670", VA = "0x187D1A470")]
	private void CMHKOJOGGKJ(OBIAGGAMNIO IOBGKHKEKBL, NativeList<MFMMOKDHBOK> JOCKPAICPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7D17870", Offset = "0x7D16A70", VA = "0x187D17870")]
	internal void APCDDJPEEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CB70", Offset = "0x7D1BD70", VA = "0x187D1CB70")]
	public static void IDALINEGDPJ(NativeList<MFMMOKDHBOK> GDFOBAMHFMJ, OBIAGGAMNIO IOBGKHKEKBL, int BDPHAJKFCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7D208A0", Offset = "0x7D1FAA0", VA = "0x187D208A0")]
	private float PFMODKNADGM(int MOIDCHJKCGB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7D18220", Offset = "0x7D17420", VA = "0x187D18220")]
	internal void BLJCOKIICJO(OBIAGGAMNIO CGGHHEJPJND, OFDEEGMOHMJ PBDJCKKPJJE, int BOCLJAAJIDN, int ICCEDGJPFOJ, float PEGFECMOHPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BurstCompile]
internal struct CIOJNKLNKBF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal struct FCNJJODEDID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int MKCJBGDHJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int EMJGHHDFFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int CNMMBIGFOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public float AJJHIFEFFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float OGCACLBJDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public float GOEBGLKEJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public float POMEMPHDAHH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	internal struct BKFIEDNMHAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int MKCJBGDHJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int EMJGHHDFFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int CNMMBIGFOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int IGNMNOGJEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public float AJJHIFEFFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public float OGCACLBJDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public float CINJEFHHJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public float MOEOPEDBCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public float POMEMPHDAHH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public struct PJBIOEACFED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int NKDHFGKNHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int APGFDNPOALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public float DDJLBMLAAAK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public delegate void OBCFKFPBINB(CIOJNKLNKBF FLLIGLGEOBJ, [In] FCNJJODEDID GIMGOBENBCL);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class CCNAALLINHO
	{
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7D365F0", Offset = "0x7D357F0", VA = "0x187D365F0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7D364A0", Offset = "0x7D356A0", VA = "0x187D364A0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7D36220", Offset = "0x7D35420", VA = "0x187D36220")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7D362C0", Offset = "0x7D354C0", VA = "0x187D362C0")]
		public static void CLNGLIDPKMF(CIOJNKLNKBF FLLIGLGEOBJ, [In] FCNJJODEDID GIMGOBENBCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void CGNPLAFPFEA(CIOJNKLNKBF FLLIGLGEOBJ, [In] BKFIEDNMHAI HLMIDDBKJHA);

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal static class LLPLBAKHMGP
	{
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C3D0", Offset = "0x7D3B5D0", VA = "0x187D3C3D0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C280", Offset = "0x7D3B480", VA = "0x187D3C280")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C000", Offset = "0x7D3B200", VA = "0x187D3C000")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C0A0", Offset = "0x7D3B2A0", VA = "0x187D3C0A0")]
		public static void CLNGLIDPKMF(CIOJNKLNKBF FLLIGLGEOBJ, [In] BKFIEDNMHAI HLMIDDBKJHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public unsafe delegate void KBNPIKKCPMG(UnsafeList<int>* KJIIHDEKDMN, UnsafeList<float3>* OCPJILNMDHB, [NoAlias] float3* DKABOPCNNJB, [NoAlias] float4* NLKKGIIBLJK, [NoAlias] float2* PDICIBCLIHD, [NoAlias] float4* MOJCCJEBNEB, UnsafeList<NMNOAIMHACE>* JIOKCEOLCBG, UnsafeList<int>* FICBNHFNBCG, UnsafeList<float3>* PHMCKLJEJFF, [NoAlias] float3* EPHACKEBLKM, [NoAlias] float4* AOINIDMPGCN, [NoAlias] float2* JDCKHMMNOLB, [NoAlias] float4* FBIEPAFJJDC, int AEKPCFCEKPO, int GJODKHLCBNE);

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal static class LOBCPBGMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA10", Offset = "0x7D3BC10", VA = "0x187D3CA10")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C8C0", Offset = "0x7D3BAC0", VA = "0x187D3C8C0")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C4F0", Offset = "0x7D3B6F0", VA = "0x187D3C4F0")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C590", Offset = "0x7D3B790", VA = "0x187D3C590")]
		public unsafe static void CLNGLIDPKMF(UnsafeList<int>* KJIIHDEKDMN, UnsafeList<float3>* OCPJILNMDHB, [NoAlias] float3* DKABOPCNNJB, [NoAlias] float4* NLKKGIIBLJK, [NoAlias] float2* PDICIBCLIHD, [NoAlias] float4* MOJCCJEBNEB, UnsafeList<NMNOAIMHACE>* JIOKCEOLCBG, UnsafeList<int>* FICBNHFNBCG, UnsafeList<float3>* PHMCKLJEJFF, [NoAlias] float3* EPHACKEBLKM, [NoAlias] float4* AOINIDMPGCN, [NoAlias] float2* JDCKHMMNOLB, [NoAlias] float4* FBIEPAFJJDC, int AEKPCFCEKPO, int GJODKHLCBNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public float3 OFNLFFCICDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public float IBPEMFNHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public float PAAOEMMCFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public float MMENGGLONJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public HCKDLLLJBGM.PJOPONMMPPL HKCEJNFABGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public bool FGDMGBMLHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<NMNOAIMHACE>* JIOKCEOLCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* FICBNHFNBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<FCNJJODEDID>* BEJIDLEKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<FCNJJODEDID>* CFJGCKPJNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<BKFIEDNMHAI>* HCCLOEOIIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<BKFIEDNMHAI>* NEPLKEJFMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public int ABKNGKJBBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public int CHACNGCBHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public int BFOEAOFHHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe float3* PHMCKLJEJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe int* DFFLDPPENLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe PJBIOEACFED* MGKDBALIGKJ;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x7D14C10", Offset = "0x7D13E10", VA = "0x187D14C10")]
	private static float BOHMKKHDADI([In] CIOJNKLNKBF FLLIGLGEOBJ, [In] float3 PKHKHLNNMFK, float POMEMPHDAHH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7D16BE0", Offset = "0x7D15DE0", VA = "0x187D16BE0")]
	private static int OOJEONJCKPM(CIOJNKLNKBF FLLIGLGEOBJ, [Out] NMNOAIMHACE GFOMBPMLIMB, [In] NMNOAIMHACE IIGENOHBLJE, [In] NMNOAIMHACE KDKCCBKGANA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7D161E0", Offset = "0x7D153E0", VA = "0x187D161E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void MONNNHPGNAI(CIOJNKLNKBF FLLIGLGEOBJ, [In] FCNJJODEDID GIMGOBENBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7D144A0", Offset = "0x7D136A0", VA = "0x187D144A0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void AGAIDLFCFKC(CIOJNKLNKBF FLLIGLGEOBJ, [In] BKFIEDNMHAI HLMIDDBKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7D159C0", Offset = "0x7D14BC0", VA = "0x187D159C0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7D14C90", Offset = "0x7D13E90", VA = "0x187D14C90")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal void DJCMLEAHGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7D14410", Offset = "0x7D13610", VA = "0x187D14410")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void AEDKNJBCMHD(UnsafeList<int>* KJIIHDEKDMN, UnsafeList<float3>* OCPJILNMDHB, [NoAlias] float3* DKABOPCNNJB, [NoAlias] float4* NLKKGIIBLJK, [NoAlias] float2* PDICIBCLIHD, [NoAlias] float4* MOJCCJEBNEB, UnsafeList<NMNOAIMHACE>* JIOKCEOLCBG, UnsafeList<int>* FICBNHFNBCG, UnsafeList<float3>* PHMCKLJEJFF, [NoAlias] float3* EPHACKEBLKM, [NoAlias] float4* AOINIDMPGCN, [NoAlias] float2* JDCKHMMNOLB, [NoAlias] float4* FBIEPAFJJDC, int AEKPCFCEKPO, int GJODKHLCBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7D16240", Offset = "0x7D15440", VA = "0x187D16240")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void NBOPKMDICIB(CIOJNKLNKBF FLLIGLGEOBJ, [In] FCNJJODEDID GIMGOBENBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7D159D0", Offset = "0x7D14BD0", VA = "0x187D159D0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void ILBDCDLFDGK(CIOJNKLNKBF FLLIGLGEOBJ, [In] BKFIEDNMHAI HLMIDDBKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7D14500", Offset = "0x7D13700", VA = "0x187D14500")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void BIDAINMEEHO(UnsafeList<int>* KJIIHDEKDMN, UnsafeList<float3>* OCPJILNMDHB, [NoAlias] float3* DKABOPCNNJB, [NoAlias] float4* NLKKGIIBLJK, [NoAlias] float2* PDICIBCLIHD, [NoAlias] float4* MOJCCJEBNEB, UnsafeList<NMNOAIMHACE>* JIOKCEOLCBG, UnsafeList<int>* FICBNHFNBCG, UnsafeList<float3>* PHMCKLJEJFF, [NoAlias] float3* EPHACKEBLKM, [NoAlias] float4* AOINIDMPGCN, [NoAlias] float2* JDCKHMMNOLB, [NoAlias] float4* FBIEPAFJJDC, int AEKPCFCEKPO, int GJODKHLCBNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class FOJHJOMHPKH
{
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly ProfilerMarker PLFIAKLPCCG;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public const int CDCDACMOECB = 2;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private const int ICJHCANDIEC = 1;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private static int DBHGCEDHGLH;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private static Stack<FOJHJOMHPKH> MHKJBENBPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private OBIAGGAMNIO HIIGGHNIFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private NativeList<NMNOAIMHACE> JIOKCEOLCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private NativeList<int> FICBNHFNBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private NativeList<CIOJNKLNKBF.FCNJJODEDID> BEJIDLEKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private NativeList<CIOJNKLNKBF.FCNJJODEDID> CFJGCKPJNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private NativeList<CIOJNKLNKBF.BKFIEDNMHAI> HCCLOEOIIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private NativeList<CIOJNKLNKBF.BKFIEDNMHAI> NEPLKEJFMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private CIOJNKLNKBF FLLIGLGEOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private JobHandle KHHGIDEGAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private CIOJNKLNKBF.PJBIOEACFED HFDEPCNJEAL;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private const int BFOEAOFHHBK = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B2A0", Offset = "0x7D3A4A0", VA = "0x187D3B2A0")]
	private FOJHJOMHPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A6E0", Offset = "0x7D398E0", VA = "0x187D3A6E0")]
	public void FJIJEODGFEC(OBIAGGAMNIO BHLDBEOLNPO, float3 ANBCKPELCEJ, float CIEJNOELDJB, float AOAMKKBOOFF, float OCNNAJAHKAB, List<DGGOEILGAHG.MFMMOKDHBOK> GJLLFBIHPBD, Allocator FFMBEELPMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AB20", Offset = "0x7D39D20", VA = "0x187D3AB20")]
	public (bool, OBIAGGAMNIO, float) JBJNHIAANBO(List<DGGOEILGAHG.MFMMOKDHBOK> GJLLFBIHPBD, Allocator FFMBEELPMGB, bool HPNPMKFHOPB)
	{
		return default((bool, OBIAGGAMNIO, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A3D0", Offset = "0x7D395D0", VA = "0x187D3A3D0")]
	public static bool CCFNFKLAANC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B150", Offset = "0x7D3A350", VA = "0x187D3B150")]
	public static int OFIIOMBNIKH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A580", Offset = "0x7D39780", VA = "0x187D3A580")]
	public static FOJHJOMHPKH FGCGCBPACNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A340", Offset = "0x7D39540", VA = "0x187D3A340")]
	internal static void BEHCFNBFEGA(FOJHJOMHPKH CIOKNLDHNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A420", Offset = "0x7D39620", VA = "0x187D3A420")]
	public static void EOIFFOADIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A1A0", Offset = "0x7D393A0", VA = "0x187D3A1A0")]
	[DHCHJGMMEBK(GCHHJKKLOFC.ExitingPlayMode, 0)]
	public static void AJLHFJKFAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BurstCompile]
internal struct NMNOAIMHACE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public float3 ICPEADDPOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public int FLGDOCBLNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public int HNOEJHHNJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public int ACIFFDGPKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public float DJCHJBEHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public float NIPPPKKDMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public int KHOMINGKHHO;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D406B0", Offset = "0x7D3F8B0", VA = "0x187D406B0")]
	public static void DBJJOAFKEPP([Out] NMNOAIMHACE ACALKMLJJOL, int CHCDNCJICIM, [In] float3 DACOJIIGPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D40700", Offset = "0x7D3F900", VA = "0x187D40700")]
	[IgnoreWarning(1371)]
	public static void DBJJOAFKEPP([Out] NMNOAIMHACE ACALKMLJJOL, [In] NMNOAIMHACE OEMGHFPDJLC, [In] NMNOAIMHACE ABDENJNOPME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BurstCompile]
internal struct DDBHCJNHKJD : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct NIJKIHDOHCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int HNJBNFBEMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int GHDGFLIHLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int IILPFGPNGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int IGMNJNFPJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int PCDFACKOJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int MAFKAJAFIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int FPEKANMMDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public int LLCGJEHNIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public float JEIMNAGADHO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private struct FMPOPKNGLEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public HCKDLLLJBGM.IIACBFJNEHP MDPFHHHJCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public float JGGNONLFCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public float OPDCHHEDLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public float DHJPDMIPCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public float JNAJBBEGPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public float JHFOGFOPPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public float HJECENDCHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public float DFIIJPNGPNC;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private struct MCJIGDIGHKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public NativeArray<float3> PIOFNOHANHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public NativeArray<float3> LJNGMMFPJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public NativeArray<float4> BMLBAMFLPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeArray<float4> ODDDDLMECFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public NativeArray<float2> CCJODAFAHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public NativeArray<int> LMHHBOPHABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public bool FCDIJPMJFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int KKHPKCBJJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public int DJGLDAAIOED;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CE40", Offset = "0x7D3C040", VA = "0x187D3CE40")]
		public void CDONPKCPGIP(int GJODKHLCBNE, int AEKPCFCEKPO, Allocator DPAKHKILCMF, bool DHNDHHDANNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CBF0", Offset = "0x7D3BDF0", VA = "0x187D3CBF0")]
		public static MCJIGDIGHKE BIMJDHDJBEC(OBIAGGAMNIO LMDCFNDMKMH)
		{
			return default(MCJIGDIGHKE);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CB30", Offset = "0x7D3BD30", VA = "0x187D3CB30")]
		public void BHPGJKNEABL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private static readonly ProfilerMarker FDHBIJDLDMP;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private static readonly ProfilerMarker MCJMPIDBLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<NIJKIHDOHCP> PKEBGBHEKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private MCJIGDIGHKE BDACLJLMJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private MCJIGDIGHKE IOBGKHKEKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private float3 AJCGFJPGEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private float3 BBCIMKBAJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private FMPOPKNGLEH CDOLCPPICFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* JBCEKCNHIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private NativeArray<DGGOEILGAHG.MFMMOKDHBOK> IANDDLIJMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NativeList<DGGOEILGAHG.MFMMOKDHBOK> EEDNIGBGCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NativeArray<int> FICBNHFNBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NativeArray<bool> NAABFADJAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private NativeArray<int> OFOLENLNFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private NativeArray<int> AMKAIDKENFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private NativeArray<float> KFNOMPKNNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private NativeArray<int> CLFJPKLCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private NativeArray<float> GIPBCDFJGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private NativeArray<int> KHEOKALHPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private NativeArray<int> KFBJEIIHCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private NativeArray<float> NDPFBIMIIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private NativeArray<float> FGHAKDAAOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private NativeArray<int> JEHEBPDNJJJ;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D398D0", Offset = "0x7D38AD0", VA = "0x187D398D0")]
	public DDBHCJNHKJD([In] List<DGGOEILGAHG.IOIOPENCFJF> PBNCHNFACGI, NativeList<DGGOEILGAHG.MFMMOKDHBOK> KAHOFMALJEH, [In] OBIAGGAMNIO OGILKCBFLEP, [In] NativeList<DGGOEILGAHG.MFMMOKDHBOK> JOCKPAICPKA, [In] NativeArray<long> DDHCKFKLKIL, float3 ADINHIDLCHM, float3 LOGNCBPIGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D369A0", Offset = "0x7D35BA0", VA = "0x187D369A0")]
	public static long DHODONNKKLA(int GJODKHLCBNE, int AEKPCFCEKPO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D369C0", Offset = "0x7D35BC0", VA = "0x187D369C0", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D36A10", Offset = "0x7D35C10", VA = "0x187D36A10")]
	public void FCDBDPKMMPB(List<DGGOEILGAHG.IOIOPENCFJF> JBOHNEAODDK, [In] DGGOEILGAHG DPDBKFGIKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D392C0", Offset = "0x7D384C0", VA = "0x187D392C0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool LAJPBMMBCDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D392E0", Offset = "0x7D384E0", VA = "0x187D392E0")]
	private AIFNOHGABOD OFOPGKMNADL(int BFOILLKEGHO, Allocator DPAKHKILCMF)
	{
		return default(AIFNOHGABOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D37510", Offset = "0x7D36710", VA = "0x187D37510")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void GPAOFAEFFIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D38C50", Offset = "0x7D37E50", VA = "0x187D38C50")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float KPGKINJNPFL(int CJNCLOFEHPG, int LAOBPJEOHCK, bool AELBAKLELKI, bool BCNLDPPPJFL, float KAFFLBAAHFG, float INKKKLLCHLF, float NAPIJHBBMBO, float LHLFODBCEMH, float LNJMDNCMGOK, float OPEIDCNMIIM, float MCDDAHLBNGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D39510", Offset = "0x7D38710", VA = "0x187D39510")]
	[IgnoreWarning(1371)]
	private NIJKIHDOHCP POCNOGCOABH([In] NIJKIHDOHCP PLKNDJKDPDK, int CAEPHDEFPKB, [In] NativeArray<int> BOCKDNCNDFL, [In] NativeArray<bool> NAABFADJAON, NativeArray<int> OFOLENLNFLK)
	{
		return default(NIJKIHDOHCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D367C0", Offset = "0x7D359C0", VA = "0x187D367C0")]
	public static int CENIPJLMHLA(NativeArray<int> BOCKDNCNDFL, NativeArray<int> JEHEBPDNJJJ, int GOCAMOLFDPK, int AKJPKDFNCKA, int AJCMFNCHIGA)
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
		private struct IHBHGAHLJEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public long CLOMDPNNPOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public DJNIFEMIMBD CMJBIEKALPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public GAPLKABMPAJ CGGHHEJPJND;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7D3B440", Offset = "0x7D3A640", VA = "0x187D3B440")]
			public IHBHGAHLJEH(DJNIFEMIMBD MIMIDOJIFDC, GAPLKABMPAJ JCHBNBLMCLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		private class DCMBHFGLJFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public DJNIFEMIMBD CMJBIEKALPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public int HIKIJPFMGFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public float JFKCLNCMHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public List<IHBHGAHLJEH> ECMMPHFCBLK;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x7D36710", Offset = "0x7D35910", VA = "0x187D36710")]
			public DCMBHFGLJFI(DJNIFEMIMBD MIMIDOJIFDC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly KEPOMIIOHBM log;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private static readonly ProfilerMarker EDBIPGEBCAF;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private static readonly ProfilerMarker CNDOHMLBCJK;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private static readonly ProfilerMarker CDOKEBABFPA;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private static readonly ProfilerMarker KBJIEMKHIFE;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private static readonly ProfilerMarker MAGMLMCCHBC;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly ProfilerMarker DEBKIIFBHCH;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker AKNCDJADGEK;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		internal const int ODPIKHEBADN = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		internal static Dictionary<Material, List<Material>> HNGOHEDHIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Dictionary<Material, List<FIFMAOIAEPB>> GKDCMHNBEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		internal List<FIFMAOIAEPB> GDGBCHGCDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private List<MeshRenderer> GFDEEPDNAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private Transform AHPNCLLHAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private bool CAEJHGKAEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private bool BOBGGEMMIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private int EOHAJECAMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private FIFMAOIAEPB KKNLDBAENEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private Material PIIOGHIFDNI;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static bool? CAOJJMPKJCL;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private const int OOOOAIKMOLN = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private static List<IHBHGAHLJEH> BJECLINECLM;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<MeshRenderer> IJDLMKGIBKL
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int ACOIBALHHPA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7D361D0", Offset = "0x7D353D0", VA = "0x187D361D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private static bool BIHNJNFEJOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7D32A90", Offset = "0x7D31C90", VA = "0x187D32A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		private static void LNLCDBACOJP(bool BPDIEFNEKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		private static void LNLCDBACOJP(bool BPDIEFNEKNC, string NPEJLHCJPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		private static void IDAIMCPOGGC(string GBOCGPJOEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FC30", Offset = "0x7D2EE30", VA = "0x187D2FC30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D30F00", Offset = "0x7D30100", VA = "0x187D30F00")]
		internal bool FLOECPAMFPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D32BC0", Offset = "0x7D31DC0", VA = "0x187D32BC0")]
		private Transform PNAPHJMPJBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D32BB0", Offset = "0x7D31DB0", VA = "0x187D32BB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D30790", Offset = "0x7D2F990", VA = "0x187D30790", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FA20", Offset = "0x7D2EC20", VA = "0x187D2FA20")]
		public FIFMAOIAEPB AddToBatchedMesh(GAPLKABMPAJ NAIALNMFCBK, Material ADKDGJDNNAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D35CB0", Offset = "0x7D34EB0", VA = "0x187D35CB0")]
		public void RemoveFromBatchedMesh(GAPLKABMPAJ CGGHHEJPJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D30020", Offset = "0x7D2F220", VA = "0x187D30020")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D30710", Offset = "0x7D2F910", VA = "0x187D30710")]
		private void DJFEBLJDHKG(Renderer HLIOBIEFOPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D318A0", Offset = "0x7D30AA0", VA = "0x187D318A0")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D31890", Offset = "0x7D30A90", VA = "0x187D31890")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D30150", Offset = "0x7D2F350", VA = "0x187D30150")]
		private void DIOLPLKJINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D32460", Offset = "0x7D31660", VA = "0x187D32460")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FC60", Offset = "0x7D2EE60", VA = "0x187D2FC60")]
		private FIFMAOIAEPB BBLNFLHPPFJ(GAPLKABMPAJ CGGHHEJPJND, Material ADKDGJDNNAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D30BA0", Offset = "0x7D2FDA0", VA = "0x187D30BA0")]
		private FIFMAOIAEPB FCBNIFJEAOP(Material ADKDGJDNNAD, int EJJJGLEAMKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D31910", Offset = "0x7D30B10", VA = "0x187D31910")]
		private FIFMAOIAEPB MNLMLPJDFCM(Material ADKDGJDNNAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D329F0", Offset = "0x7D31BF0", VA = "0x187D329F0")]
		internal float4x4 OIGMPBPPDBA()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D31060", Offset = "0x7D30260", VA = "0x187D31060")]
		public static List<Material> GenerateVertexFormatVariants(Material ADKDGJDNNAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x142E730", Offset = "0x142D930", VA = "0x18142E730")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D32300", Offset = "0x7D31500", VA = "0x187D32300")]
		public void MarkDirty(GAPLKABMPAJ CGGHHEJPJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7D30F60", Offset = "0x7D30160", VA = "0x187D30F60")]
		[Conditional("CHECK_STATE")]
		private void FNHOJEEOJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D325E0", Offset = "0x7D317E0", VA = "0x187D325E0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float NKIMLHKCKIB)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FEF0", Offset = "0x7D2F0F0", VA = "0x187D2FEF0")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D34B50", Offset = "0x7D33D50", VA = "0x187D34B50")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D311D0", Offset = "0x7D303D0", VA = "0x187D311D0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7D32D10", Offset = "0x7D31F10", VA = "0x187D32D10")]
		public void RebatchOptimally(int HAHPAHPJGEF, int DANDDPHKOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7D32C40", Offset = "0x7D31E40", VA = "0x187D32C40")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D360A0", Offset = "0x7D352A0", VA = "0x187D360A0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class NEINMKKHKLK
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct KGNJPOMENGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public BatchedMeshRenderer HLIOBIEFOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public FIFMAOIAEPB CGGHHEJPJND;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1AF0540", Offset = "0x1AEF740", VA = "0x181AF0540")]
		public void ADPENAIIIHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct IIJBDHMNNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public float AJOKGDIBBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public FIFMAOIAEPB FOKKKEJFDFB;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class BHMNAACEABM : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x11891F0", Offset = "0x11883F0", VA = "0x1811891F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D2F8B0", Offset = "0x7D2EAB0", VA = "0x187D2F8B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x137E0F0", Offset = "0x137D2F0", VA = "0x18137E0F0")]
		[DebuggerHidden]
		public BHMNAACEABM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F900", Offset = "0x7D2EB00", VA = "0x187D2F900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E950", Offset = "0x7D2DB50", VA = "0x187D2E950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E8B0", Offset = "0x7D2DAB0", VA = "0x187D2E8B0")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E900", Offset = "0x7D2DB00", VA = "0x187D2E900")]
		private void GHEPLDLLGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F860", Offset = "0x7D2EA60", VA = "0x187D2F860", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F7B0", Offset = "0x7D2E9B0", VA = "0x187D2F7B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F7B0", Offset = "0x7D2E9B0", VA = "0x187D2F7B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private static readonly ProfilerMarker DEBKIIFBHCH;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly ProfilerMarker PFAAPEGAOHI;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly ProfilerMarker AOIKIDJBKPI;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private static readonly ProfilerMarker EOIODMCIJEI;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static float3 ELJGOJODCHF;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static int FBEELGEDFPN;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static int DCOBLGHKBNH;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static int LKKHFEMMMHJ;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static int ODOHBOMLNFA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static int HJKDPMHDBGM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static float LCGBFMADCNH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static float EKGNHDPCMEE;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static float CDCPPDHBNGB;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static float PJLAONNEHEF;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static float OBEMPPNHLOM;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static float CIMOMDAGBCJ;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static float BCPEOOILHPN;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static float KHIAOOEEJAP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private static List<BatchedMeshRenderer> EPBHGEEGALG;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private static Stack<OBIAGGAMNIO> JFIMPOMNLOC;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static Stack<PIBCHLIPNBK> NIGGHJHFKKL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static BJOOKMNONND EBGIKMFALOH;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private static KGNJPOMENGB GLBMOECOBLB;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static int OIKBDCMJDMO;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void LNLCDBACOJP(bool BPDIEFNEKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void FPOMOOAADBP(bool BPDIEFNEKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void LNLCDBACOJP(bool BPDIEFNEKNC, string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EF10", Offset = "0x7D3E110", VA = "0x187D3EF10")]
	public static void IJDFNMPLFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DC80", Offset = "0x7D3CE80", VA = "0x187D3DC80")]
	public static void ENMIAHAEDFL(BatchedMeshRenderer KKHBABHOIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EDF0", Offset = "0x7D3DFF0", VA = "0x187D3EDF0")]
	public static void IIBPKANHBLO(BatchedMeshRenderer KKHBABHOIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D020", Offset = "0x7D3C220", VA = "0x187D3D020")]
	public static void AGMANLPBENI(GAPLKABMPAJ FGPBDAMKPKI, bool HNGMAOLAGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EF90", Offset = "0x7D3E190", VA = "0x187D3EF90")]
	public static void LIHCEFDPBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F7E0", Offset = "0x7D3E9E0", VA = "0x187D3F7E0")]
	public static void NKMPPPFJNNO(float NKIMLHKCKIB, bool IOJHICDNHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F310", Offset = "0x7D3E510", VA = "0x187D3F310")]
	private static void LOICAIGAHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DF80", Offset = "0x7D3D180", VA = "0x187D3DF80")]
	public static long FOOAIICOKPH(int NLODHHJHJJB, long BLINEOAJGIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EA60", Offset = "0x7D3DC60", VA = "0x187D3EA60")]
	public static (long, long, int) HDPPEOAIIJC(float NKIMLHKCKIB)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D400F0", Offset = "0x7D3F2F0", VA = "0x187D400F0")]
	[IteratorStateMachine(typeof(BHMNAACEABM))]
	public static IEnumerable<bool> NMLBLBFBIII(long HLFKCBHOIFD, bool NLKBAJBONDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D870", Offset = "0x7D3CA70", VA = "0x187D3D870")]
	public static void BDNDBPEFCKJ(long HLFKCBHOIFD, bool NLKBAJBONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D40180", Offset = "0x7D3F380", VA = "0x187D40180")]
	public static int PIHKAKKADPA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EC70", Offset = "0x7D3DE70", VA = "0x187D3EC70")]
	internal static OBIAGGAMNIO IGPIMLEGDLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DB50", Offset = "0x7D3CD50", VA = "0x187D3DB50")]
	internal static void BEHCFNBFEGA(OBIAGGAMNIO AFEPAMDCHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E920", Offset = "0x7D3DB20", VA = "0x187D3E920")]
	internal static PIBCHLIPNBK GDJCMEPAPHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DBF0", Offset = "0x7D3CDF0", VA = "0x187D3DBF0")]
	internal static void BEHCFNBFEGA(PIBCHLIPNBK CBCOHLKBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DDC0", Offset = "0x7D3CFC0", VA = "0x187D3DDC0")]
	public static void EOIFFOADIJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class JMHDDKBEMIH<KeyType> : FIFMAOIAEPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly Dictionary<KeyType, GAPLKABMPAJ> AMBCLBPEBKN;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5077900", Offset = "0x5076B00", VA = "0x185077900")]
	public JMHDDKBEMIH(string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x50778B0", Offset = "0x5076AB0", VA = "0x1850778B0")]
	public void POMOILGGHLC(KeyType MHDODBCCAJB, GAPLKABMPAJ FGPBDAMKPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x50776A0", Offset = "0x50768A0", VA = "0x1850776A0")]
	public bool MABAGGCHHOA(KeyType MHDODBCCAJB, GAPLKABMPAJ FCKHNMDPEEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5077770", Offset = "0x5076970", VA = "0x185077770")]
	public void NDALCIBHNLL(KeyType MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5077590", Offset = "0x5076790", VA = "0x185077590", Slot = "4")]
	public override void JOILAKGICEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class LIGDDHODIJI
{
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly ProfilerCategory BCKDGCIJCKJ;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	internal static readonly ProfilerMarker AMIHAMEDALH;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	internal static readonly PMAPHKHKBMM NKMPPPFJNNO;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly NEGKCDAGDPM<float> KCCMAOLNJCM;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly NEGKCDAGDPM<float> CEMDMBIHPBD;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly NEGKCDAGDPM<double> NBLPIMDINGH;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private static readonly NEGKCDAGDPM<double> EACIBMLCIMB;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly NEGKCDAGDPM<double> OPHMPMGGDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private static readonly NEGKCDAGDPM<int> FIBMKBCNEOO;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly NEGKCDAGDPM<int> LOCBEKJIAEP;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly NEGKCDAGDPM<int> OLGNKLEIJMJ;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly NEGKCDAGDPM<int> JHAJNJKDAMG;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private static readonly NEGKCDAGDPM<int> MEHPICJNKHK;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly NEGKCDAGDPM<long> PPIOBLCGBNI;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private static readonly NEGKCDAGDPM<long> NKFIMCJLHMJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private static readonly NEGKCDAGDPM<long> FDNLKMJILME;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private static readonly NEGKCDAGDPM<long> BMIODNIOLON;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private static readonly NEGKCDAGDPM<long> MEBELDEBIIE;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B630", Offset = "0x7D3A830", VA = "0x187D3B630")]
	public static void LOJKNMCIGCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7D409F0", Offset = "0x7D3FBF0", VA = "0x187D409F0")]
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
