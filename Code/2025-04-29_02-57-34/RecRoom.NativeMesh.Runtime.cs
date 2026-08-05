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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9B4F0", Offset = "0x7B9A8F0", VA = "0x187B9B4F0", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BDNNEFBHPBM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly LMKAPNBAFDO EAMIEKOMCOM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly LMKAPNBAFDO EKPGOKANDHE;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly LMKAPNBAFDO DPGHPHGLGMH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly LMKAPNBAFDO AEJPFILDNMK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly LMKAPNBAFDO FOOFCGMKFPH;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class JNGLOKEPDKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public LMKBCHBJNON JGMOKPMKBNI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DMCCFBNGLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public JNGLOKEPDKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct LMKBCHBJNON
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct AHFHPHGOPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half NMBBAKILCLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort OPMGGMLOBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte HMGBCJABFHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void JLKBNAAGLMC([NoAlias] float3* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class GHAFKCKOOAF
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BAA0", Offset = "0x7B8AEA0", VA = "0x187B8BAA0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B660", Offset = "0x7B8AA60", VA = "0x187B8B660")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B9F0", Offset = "0x7B8ADF0", VA = "0x187B8B9F0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B7C0", Offset = "0x7B8ABC0", VA = "0x187B8B7C0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] float3* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void ADCHNDINDOB([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class LJNILFDLCML
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B91240", Offset = "0x7B90640", VA = "0x187B91240")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B90D80", Offset = "0x7B90180", VA = "0x187B90D80")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B91190", Offset = "0x7B90590", VA = "0x187B91190")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B90EE0", Offset = "0x7B902E0", VA = "0x187B90EE0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void KACLMFIJNBI([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class LNFBOANGJOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9B3C0", Offset = "0x7B9A7C0", VA = "0x187B9B3C0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B9AF00", Offset = "0x7B9A300", VA = "0x187B9AF00")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7B9B310", Offset = "0x7B9A710", VA = "0x187B9B310")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7B9B060", Offset = "0x7B9A460", VA = "0x187B9B060")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void CLJHHPEBBEM([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class DGCFFJFOEHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7B81960", Offset = "0x7B80D60", VA = "0x187B81960")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B814A0", Offset = "0x7B808A0", VA = "0x187B814A0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7B818B0", Offset = "0x7B80CB0", VA = "0x187B818B0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B81600", Offset = "0x7B80A00", VA = "0x187B81600")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void AFIKHEGBJON([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class MFGPKACCFPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C230", Offset = "0x7B9B630", VA = "0x187B9C230")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B9BD70", Offset = "0x7B9B170", VA = "0x187B9BD70")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C180", Offset = "0x7B9B580", VA = "0x187B9C180")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B9BED0", Offset = "0x7B9B2D0", VA = "0x187B9BED0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void JIKNDNMLJEM([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class OLNEGKCCHGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EC50", Offset = "0x7B9E050", VA = "0x187B9EC50")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E700", Offset = "0x7B9DB00", VA = "0x187B9E700")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EBA0", Offset = "0x7B9DFA0", VA = "0x187B9EBA0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E860", Offset = "0x7B9DC60", VA = "0x187B9E860")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void BCAFMILANHL([NoAlias] ushort* HOABLOMBPKB, [Out] float3 CPLJPMJMPLM, [Out] float3 EIDGEMKCKCM, [In][NoAlias] float3* IFKLEMIEFMH, int BIKIKJNDBDH, int OBALFOMMEDB);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class AEAFKECHMDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B7E4A0", Offset = "0x7B7D8A0", VA = "0x187B7E4A0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B7E050", Offset = "0x7B7D450", VA = "0x187B7E050")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B7E3F0", Offset = "0x7B7D7F0", VA = "0x187B7E3F0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B7E1B0", Offset = "0x7B7D5B0", VA = "0x187B7E1B0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] ushort* HOABLOMBPKB, [Out] float3 CPLJPMJMPLM, [Out] float3 EIDGEMKCKCM, [In][NoAlias] float3* IFKLEMIEFMH, int BIKIKJNDBDH, int OBALFOMMEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void CGKPFLJEHJJ([NoAlias] ushort* IIPEFHMFFED, [In][NoAlias] float3* BAIHOOLDFBD, int OBALFOMMEDB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class LJDDNPHIBLF
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B905E0", Offset = "0x7B8F9E0", VA = "0x187B905E0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B901C0", Offset = "0x7B8F5C0", VA = "0x187B901C0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B90530", Offset = "0x7B8F930", VA = "0x187B90530")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B90320", Offset = "0x7B8F720", VA = "0x187B90320")]
		public unsafe static void HFGDGIKOIHK([NoAlias] ushort* IIPEFHMFFED, [In][NoAlias] float3* BAIHOOLDFBD, int OBALFOMMEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void IBECGECOGDN([NoAlias] float3* KBLIIPDNLKF, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class ONNGPKJEBCE
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F780", Offset = "0x7B9EB80", VA = "0x187B9F780")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F360", Offset = "0x7B9E760", VA = "0x187B9F360")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F6D0", Offset = "0x7B9EAD0", VA = "0x187B9F6D0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F4C0", Offset = "0x7B9E8C0", VA = "0x187B9F4C0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] float3* KBLIIPDNLKF, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void HPLDBFKNECK([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class PFGCADPJINC
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0240", Offset = "0x7B9F640", VA = "0x187BA0240")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FE20", Offset = "0x7B9F220", VA = "0x187B9FE20")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0190", Offset = "0x7B9F590", VA = "0x187BA0190")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FF80", Offset = "0x7B9F380", VA = "0x187B9FF80")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void JFGDKLKEGCH([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class MGPFKCNJEEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C870", Offset = "0x7B9BC70", VA = "0x187B9C870")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C360", Offset = "0x7B9B760", VA = "0x187B9C360")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C7C0", Offset = "0x7B9BBC0", VA = "0x187B9C7C0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C4C0", Offset = "0x7B9B8C0", VA = "0x187B9C4C0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void EDLNGJJLJMH([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class FEKPKEJMDPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B89CE0", Offset = "0x7B890E0", VA = "0x187B89CE0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B897D0", Offset = "0x7B88BD0", VA = "0x187B897D0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B89C30", Offset = "0x7B89030", VA = "0x187B89C30")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B89930", Offset = "0x7B88D30", VA = "0x187B89930")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void CGAOIFGPJPF([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class DHIPGDKHGAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B81FD0", Offset = "0x7B813D0", VA = "0x187B81FD0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B81A90", Offset = "0x7B80E90", VA = "0x187B81A90")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B81F20", Offset = "0x7B81320", VA = "0x187B81F20")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B81BF0", Offset = "0x7B80FF0", VA = "0x187B81BF0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void JHGAPHLMMKF([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class CALPAACAENE
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B7FF80", Offset = "0x7B7F380", VA = "0x187B7FF80")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B7FA40", Offset = "0x7B7EE40", VA = "0x187B7FA40")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B7FED0", Offset = "0x7B7F2D0", VA = "0x187B7FED0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B7FBA0", Offset = "0x7B7EFA0", VA = "0x187B7FBA0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void PBEGFLJBFNP([NoAlias] uint* CEJFLHKEKOG, [Out] float2 FNCHPCCCBNH, [Out] float2 CGHLPACFJDK, [In][NoAlias] float2* ANLBCLBDABI, int BIKIKJNDBDH, int OBALFOMMEDB);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class GFNIHJKFFCD
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B530", Offset = "0x7B8A930", VA = "0x187B8B530")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B0E0", Offset = "0x7B8A4E0", VA = "0x187B8B0E0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B480", Offset = "0x7B8A880", VA = "0x187B8B480")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B240", Offset = "0x7B8A640", VA = "0x187B8B240")]
		public unsafe static void HFGDGIKOIHK([NoAlias] uint* CEJFLHKEKOG, [Out] float2 FNCHPCCCBNH, [Out] float2 CGHLPACFJDK, [In][NoAlias] float2* ANLBCLBDABI, int BIKIKJNDBDH, int OBALFOMMEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void CMJGDHDAEBD([Out] float2 IHCNIPPBNFD, uint BHFLOFOIHKM, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class FIBHBDJLEGO
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A280", Offset = "0x7B89680", VA = "0x187B8A280")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B89E10", Offset = "0x7B89210", VA = "0x187B89E10")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A1D0", Offset = "0x7B895D0", VA = "0x187B8A1D0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B89F70", Offset = "0x7B89370", VA = "0x187B89F70")]
		public static void HFGDGIKOIHK([Out] float2 IHCNIPPBNFD, uint BHFLOFOIHKM, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void JJMKJONBIOI([NoAlias] float2* CEJFLHKEKOG, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class HKGEILHBHHF
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C680", Offset = "0x7B8BA80", VA = "0x187B8C680")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C180", Offset = "0x7B8B580", VA = "0x187B8C180")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C5D0", Offset = "0x7B8B9D0", VA = "0x187B8C5D0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C2E0", Offset = "0x7B8B6E0", VA = "0x187B8C2E0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] float2* CEJFLHKEKOG, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void OGEJCOLBDKG([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class GFEGBHDKMEN
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7B8AFB0", Offset = "0x7B8A3B0", VA = "0x187B8AFB0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B8AA80", Offset = "0x7B89E80", VA = "0x187B8AA80")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7B8AF00", Offset = "0x7B8A300", VA = "0x187B8AF00")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8ABE0", Offset = "0x7B89FE0", VA = "0x187B8ABE0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void KGLEDAAEKJC([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class NAKINMJICJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D6A0", Offset = "0x7B9CAA0", VA = "0x187B9D6A0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D170", Offset = "0x7B9C570", VA = "0x187B9D170")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D5F0", Offset = "0x7B9C9F0", VA = "0x187B9D5F0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D2D0", Offset = "0x7B9C6D0", VA = "0x187B9D2D0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void BMLNEHIFOCB([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class OPGOEFAAJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FCF0", Offset = "0x7B9F0F0", VA = "0x187B9FCF0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F8B0", Offset = "0x7B9ECB0", VA = "0x187B9F8B0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FC40", Offset = "0x7B9F040", VA = "0x187B9FC40")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FA10", Offset = "0x7B9EE10", VA = "0x187B9FA10")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void CAADEEENCJC([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class MHJMIKILACI
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CEC0", Offset = "0x7B9C2C0", VA = "0x187B9CEC0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C9A0", Offset = "0x7B9BDA0", VA = "0x187B9C9A0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CE10", Offset = "0x7B9C210", VA = "0x187B9CE10")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CB00", Offset = "0x7B9BF00", VA = "0x187B9CB00")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void BGPIDNNHLMA([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class DOFOHGOAFDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7B82630", Offset = "0x7B81A30", VA = "0x187B82630")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7B82100", Offset = "0x7B81500", VA = "0x187B82100")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B82580", Offset = "0x7B81980", VA = "0x187B82580")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7B82260", Offset = "0x7B81660", VA = "0x187B82260")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void LHMJGCHKFEO([NoAlias] ushort* FELJFKMIOCO, [In][NoAlias] float4* IMAFKDNIDCD, int BIKIKJNDBDH, int OBALFOMMEDB);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class BGAPIGPMFIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F3A0", Offset = "0x7B7E7A0", VA = "0x187B7F3A0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7B7EEF0", Offset = "0x7B7E2F0", VA = "0x187B7EEF0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F2F0", Offset = "0x7B7E6F0", VA = "0x187B7F2F0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F050", Offset = "0x7B7E450", VA = "0x187B7F050")]
		public unsafe static void HFGDGIKOIHK([NoAlias] ushort* FELJFKMIOCO, [In][NoAlias] float4* IMAFKDNIDCD, int BIKIKJNDBDH, int OBALFOMMEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort FAOGPIMKJOJ([In] float4 NIOLAEBPLEA);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class PLCHGFGOCHD
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7BA07E0", Offset = "0x7B9FBE0", VA = "0x187BA07E0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0370", Offset = "0x7B9F770", VA = "0x187BA0370")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0730", Offset = "0x7B9FB30", VA = "0x187BA0730")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA04D0", Offset = "0x7B9F8D0", VA = "0x187BA04D0")]
		public static ushort HFGDGIKOIHK([In] float4 NIOLAEBPLEA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void MILDCAHCEPF([NoAlias] float4* FELJFKMIOCO, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class OLPJLNEBPEA
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F230", Offset = "0x7B9E630", VA = "0x187B9F230")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7B9ED80", Offset = "0x7B9E180", VA = "0x187B9ED80")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F180", Offset = "0x7B9E580", VA = "0x187B9F180")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EEE0", Offset = "0x7B9E2E0", VA = "0x187B9EEE0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] float4* FELJFKMIOCO, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void LFCGMLLJMGJ([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class MAMNICBMNFH
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7B9BC40", Offset = "0x7B9B040", VA = "0x187B9BC40")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7B9B820", Offset = "0x7B9AC20", VA = "0x187B9B820")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7B9BB90", Offset = "0x7B9AF90", VA = "0x187B9BB90")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9B980", Offset = "0x7B9AD80", VA = "0x187B9B980")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void JNCJCDGEAMA([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class LJFAAGINKFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B90C50", Offset = "0x7B90050", VA = "0x187B90C50")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7B90710", Offset = "0x7B8FB10", VA = "0x187B90710")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B90BA0", Offset = "0x7B8FFA0", VA = "0x187B90BA0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7B90870", Offset = "0x7B8FC70", VA = "0x187B90870")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void FDFPILDHGNH([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class AIAFGBECGDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B7EB10", Offset = "0x7B7DF10", VA = "0x187B7EB10")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7B7E5D0", Offset = "0x7B7D9D0", VA = "0x187B7E5D0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7B7EA60", Offset = "0x7B7DE60", VA = "0x187B7EA60")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7B7E730", Offset = "0x7B7DB30", VA = "0x187B7E730")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void DBBNBMFCDMK([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class CJFPGIOCPFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7B80C90", Offset = "0x7B80090", VA = "0x187B80C90")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7B806F0", Offset = "0x7B7FAF0", VA = "0x187B806F0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7B80BE0", Offset = "0x7B7FFE0", VA = "0x187B80BE0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7B80850", Offset = "0x7B7FC50", VA = "0x187B80850")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void DMLGOHJOLEK([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class FMPLKNHFOGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A950", Offset = "0x7B89D50", VA = "0x187B8A950")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A3B0", Offset = "0x7B897B0", VA = "0x187B8A3B0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A8A0", Offset = "0x7B89CA0", VA = "0x187B8A8A0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A510", Offset = "0x7B89910", VA = "0x187B8A510")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void IKHKLEDLONJ([Out] float4 APLCGCDLEGH, ushort BHFLOFOIHKM);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class KHLPDPCIKKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8FDD0", Offset = "0x7B8F1D0", VA = "0x187B8FDD0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F920", Offset = "0x7B8ED20", VA = "0x187B8F920")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7B8FD20", Offset = "0x7B8F120", VA = "0x187B8FD20")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7B8FA80", Offset = "0x7B8EE80", VA = "0x187B8FA80")]
		public static void HFGDGIKOIHK([Out] float4 APLCGCDLEGH, ushort BHFLOFOIHKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void JKLINOPKEPI([NoAlias] float4* IDPCIJLMEIF, [NoAlias] byte* PNDKDDMDECP, [Out] int HNDLDMGNCNB, [Out] int PLIMFCFKGHE, [NoAlias] float4* HIMAFJIOHBB, int BIKIKJNDBDH, int OBALFOMMEDB);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class IMCFONEJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E620", Offset = "0x7B8DA20", VA = "0x187B8E620")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E1D0", Offset = "0x7B8D5D0", VA = "0x187B8E1D0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E570", Offset = "0x7B8D970", VA = "0x187B8E570")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E330", Offset = "0x7B8D730", VA = "0x187B8E330")]
		public unsafe static void HFGDGIKOIHK([NoAlias] float4* IDPCIJLMEIF, [NoAlias] byte* PNDKDDMDECP, [Out] int HNDLDMGNCNB, [Out] int PLIMFCFKGHE, [NoAlias] float4* HIMAFJIOHBB, int BIKIKJNDBDH, int OBALFOMMEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void MHIOMGKFKFN([NoAlias] float4* CCLKJOBBMMI, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class KBGFBPAOBBB
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F620", Offset = "0x7B8EA20", VA = "0x187B8F620")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F110", Offset = "0x7B8E510", VA = "0x187B8F110")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F570", Offset = "0x7B8E970", VA = "0x187B8F570")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F270", Offset = "0x7B8E670", VA = "0x187B8F270")]
		public unsafe static void HFGDGIKOIHK([NoAlias] float4* CCLKJOBBMMI, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void HHBICNDPOCG([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class JBJKGMFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7B8ED10", Offset = "0x7B8E110", VA = "0x187B8ED10")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E750", Offset = "0x7B8DB50", VA = "0x187B8E750")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7B8EC60", Offset = "0x7B8E060", VA = "0x187B8EC60")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E8B0", Offset = "0x7B8DCB0", VA = "0x187B8E8B0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void NDGDGBBCEHO([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class IJCOPLDIAAC
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8DFA0", Offset = "0x7B8D3A0", VA = "0x187B8DFA0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D9D0", Offset = "0x7B8CDD0", VA = "0x187B8D9D0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7B8DEF0", Offset = "0x7B8D2F0", VA = "0x187B8DEF0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7B8DB30", Offset = "0x7B8CF30", VA = "0x187B8DB30")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void LHJOFOICCFH([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class OACKCPGAPKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E400", Offset = "0x7B9D800", VA = "0x187B9E400")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DE40", Offset = "0x7B9D240", VA = "0x187B9DE40")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E350", Offset = "0x7B9D750", VA = "0x187B9E350")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DFA0", Offset = "0x7B9D3A0", VA = "0x187B9DFA0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void APFEMANIGBJ([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class CAEEPMKIKIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F910", Offset = "0x7B7ED10", VA = "0x187B7F910")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F4D0", Offset = "0x7B7E8D0", VA = "0x187B7F4D0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F860", Offset = "0x7B7EC60", VA = "0x187B7F860")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F630", Offset = "0x7B7EA30", VA = "0x187B7F630")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void LGBAJGPCJPF([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class NFONPMEFIFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DD10", Offset = "0x7B9D110", VA = "0x187B9DD10")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D8D0", Offset = "0x7B9CCD0", VA = "0x187B9D8D0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DC60", Offset = "0x7B9D060", VA = "0x187B9DC60")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DA30", Offset = "0x7B9CE30", VA = "0x187B9DA30")]
		public unsafe static void HFGDGIKOIHK([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int NDCKONHDKBG([NoAlias] byte* KKBGEGGDKEI, [In][NoAlias] int* MIBCPGGMJHK, int JILFGMKGLFA);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class CJJCCFPPIMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B81270", Offset = "0x7B80670", VA = "0x187B81270")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B80DC0", Offset = "0x7B801C0", VA = "0x187B80DC0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B811C0", Offset = "0x7B805C0", VA = "0x187B811C0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B80F20", Offset = "0x7B80320", VA = "0x187B80F20")]
		public unsafe static int HFGDGIKOIHK([NoAlias] byte* KKBGEGGDKEI, [In][NoAlias] int* MIBCPGGMJHK, int JILFGMKGLFA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void GNBJBPLBOCH([NoAlias] int* MNBKLFJFDFC, [In][NoAlias] byte* DHKGPDJPBCA, int DKFOONNFLLO);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class HLLJNGKOBFL
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CC20", Offset = "0x7B8C020", VA = "0x187B8CC20")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C7B0", Offset = "0x7B8BBB0", VA = "0x187B8C7B0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB70", Offset = "0x7B8BF70", VA = "0x187B8CB70")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C910", Offset = "0x7B8BD10", VA = "0x187B8C910")]
		public unsafe static void HFGDGIKOIHK([NoAlias] int* MNBKLFJFDFC, [In][NoAlias] byte* DHKGPDJPBCA, int DKFOONNFLLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void NHKGDLHJGBM([NoAlias] ushort* MNBKLFJFDFC, [In][NoAlias] byte* DHKGPDJPBCA, int DKFOONNFLLO);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class GLHDBALLJMM
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C050", Offset = "0x7B8B450", VA = "0x187B8C050")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BBD0", Offset = "0x7B8AFD0", VA = "0x187B8BBD0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BFA0", Offset = "0x7B8B3A0", VA = "0x187B8BFA0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BD30", Offset = "0x7B8B130", VA = "0x187B8BD30")]
		public unsafe static void HFGDGIKOIHK([NoAlias] ushort* MNBKLFJFDFC, [In][NoAlias] byte* DHKGPDJPBCA, int DKFOONNFLLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void PNICKHPJLOJ([Out] float3 IHCNIPPBNFD, ushort BHFLOFOIHKM);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class IDMOMMFKPBG
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D170", Offset = "0x7B8C570", VA = "0x187B8D170")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CD50", Offset = "0x7B8C150", VA = "0x187B8CD50")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D0C0", Offset = "0x7B8C4C0", VA = "0x187B8D0C0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CEB0", Offset = "0x7B8C2B0", VA = "0x187B8CEB0")]
		public static void HFGDGIKOIHK([Out] float3 IHCNIPPBNFD, ushort BHFLOFOIHKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort JBHNDCKEMKM([In] float3 NIOLAEBPLEA);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class CBFJANBDDDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B804C0", Offset = "0x7B7F8C0", VA = "0x187B804C0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B800B0", Offset = "0x7B7F4B0", VA = "0x187B800B0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B80410", Offset = "0x7B7F810", VA = "0x187B80410")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B80210", Offset = "0x7B7F610", VA = "0x187B80210")]
		public static ushort HFGDGIKOIHK([In] float3 NIOLAEBPLEA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker NOKNPPIJHOO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker FKHKHNIBIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int DMCCFBNGLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int DKFOONNFLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> DOPBLIMAAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> OJBFBCFKCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> JDKPOCGANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> PDDIIOMKKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<AHFHPHGOPCC> FBPFHNCEAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> LGENNDNMGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> JHPGMMOMMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 FDJOOICFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 EIDGEMKCKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 BCEEKEAEAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 CGHLPACFJDK;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long FJLCHMFOCKJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long NJJCEEECBAG;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float OLCKPKHDIOI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool BFLFDCNOIHM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GHONCNALJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B947E0", Offset = "0x7B93BE0", VA = "0x187B947E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AMIMOEABHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B9A4D0", Offset = "0x7B998D0", VA = "0x187B9A4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B926A0", Offset = "0x7B91AA0", VA = "0x187B926A0")]
	public void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B92C00", Offset = "0x7B92000", VA = "0x187B92C00")]
	public static LMKBCHBJNON BPKMLDCMEGB(Allocator LMMGDELCIGC, NativeArray<float3> IFKLEMIEFMH, NativeArray<float3> BAIHOOLDFBD, NativeArray<float2> ANLBCLBDABI, NativeArray<float4> HIMAFJIOHBB, bool IMJFMDDODJH, NativeArray<float4> ONLELDIDLMB, NativeArray<int> MIBCPGGMJHK, int DMCCFBNGLAK, int AEJAIIHPKOG, int DKFOONNFLLO, int BIKIKJNDBDH)
	{
		return default(LMKBCHBJNON);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B941F0", Offset = "0x7B935F0", VA = "0x187B941F0")]
	public EFFDIJJLADK DOMJCKHCABO(Allocator LMMGDELCIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7B94290", Offset = "0x7B93690", VA = "0x187B94290")]
	public void DOMJCKHCABO(EFFDIJJLADK APLCGCDLEGH, Allocator LMMGDELCIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7B94650", Offset = "0x7B93A50", VA = "0x187B94650")]
	public void EBLONFPGOKH(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7B92470", Offset = "0x7B91870", VA = "0x187B92470")]
	private void BHPLGBABGKH(Mesh IGPCANDHEAE, NativeArray<ushort> NBFOEFEABNC, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7B934C0", Offset = "0x7B928C0", VA = "0x187B934C0")]
	public void CMDMKPOHEII(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7B97FA0", Offset = "0x7B973A0", VA = "0x187B97FA0")]
	public void KJPOJLIBNJG(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7B96820", Offset = "0x7B95C20", VA = "0x187B96820")]
	public void HNBNDNPGNHP(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B97880", Offset = "0x7B96C80", VA = "0x187B97880")]
	public void KAKFJNGLJOF(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B94BD0", Offset = "0x7B93FD0", VA = "0x187B94BD0")]
	public void EJJMAEFFKKJ(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B928C0", Offset = "0x7B91CC0", VA = "0x187B928C0")]
	public void BPDNIELCODH(Mesh IGPCANDHEAE, EFFDIJJLADK.OLOGDNNFPLF EIDACCNCFOG, bool FLBNDMMOENL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B974D0", Offset = "0x7B968D0", VA = "0x187B974D0")]
	public long IPOELGFFMMG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B992A0", Offset = "0x7B986A0", VA = "0x187B992A0")]
	public long MMHHHILONCN(EFFDIJJLADK.OLOGDNNFPLF EIDACCNCFOG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B99B50", Offset = "0x7B98F50", VA = "0x187B99B50")]
	private void NLNPPHKFKKL(int MIJFEJOJGGN, int OBALFOMMEDB, Allocator LMMGDELCIGC, bool BNIKFHMCKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B98840", Offset = "0x7B97C40", VA = "0x187B98840")]
	private void KKJICGNEJKG(NativeArray<float3> HOABLOMBPKB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B987C0", Offset = "0x7B97BC0", VA = "0x187B987C0")]
	[BurstCompile]
	private unsafe static void KKJICGNEJKG([NoAlias] float3* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B933B0", Offset = "0x7B927B0", VA = "0x187B933B0")]
	[BurstCompile]
	private unsafe static void CJKPHOFAHKG([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B98F60", Offset = "0x7B98360", VA = "0x187B98F60")]
	[BurstCompile]
	private unsafe static void LMNEKGCGKHE([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B95B90", Offset = "0x7B94F90", VA = "0x187B95B90")]
	[BurstCompile]
	private unsafe static void GLBLJAOJOGP([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B97F20", Offset = "0x7B97320", VA = "0x187B97F20")]
	[BurstCompile]
	private unsafe static void KHAJFBGOEIF([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B99C80", Offset = "0x7B99080", VA = "0x187B99C80")]
	[BurstCompile]
	private unsafe static void NMMCLHNAEJD([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B976D0", Offset = "0x7B96AD0", VA = "0x187B976D0")]
	private void JNFIKNBEGME(NativeArray<float3> IFKLEMIEFMH, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B977F0", Offset = "0x7B96BF0", VA = "0x187B977F0")]
	[BurstCompile]
	private unsafe static void JNFIKNBEGME([NoAlias] ushort* HOABLOMBPKB, [Out] float3 CPLJPMJMPLM, [Out] float3 EIDGEMKCKCM, [In][NoAlias] float3* IFKLEMIEFMH, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B99FF0", Offset = "0x7B993F0", VA = "0x187B99FF0")]
	private void OFGGMPADEKN(NativeArray<float3> BAIHOOLDFBD, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A0D0", Offset = "0x7B994D0", VA = "0x187B9A0D0")]
	[BurstCompile]
	private unsafe static void OFGGMPADEKN([NoAlias] ushort* IIPEFHMFFED, [In][NoAlias] float3* BAIHOOLDFBD, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B915C0", Offset = "0x7B909C0", VA = "0x187B915C0")]
	private void ABFIHJDDHMB(NativeArray<float3> KBLIIPDNLKF, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7B91370", Offset = "0x7B90770", VA = "0x187B91370")]
	[BurstCompile]
	private unsafe static void ABFIHJDDHMB([NoAlias] float3* KBLIIPDNLKF, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B91680", Offset = "0x7B90A80", VA = "0x187B91680")]
	[BurstCompile]
	private unsafe static void ABJBDDDFHCF([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B95EF0", Offset = "0x7B952F0", VA = "0x187B95EF0")]
	[BurstCompile]
	private unsafe static void HFMMKMEJLDE([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A5F0", Offset = "0x7B999F0", VA = "0x187B9A5F0")]
	[BurstCompile]
	private unsafe static void OOLPLBGCNLH([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B993B0", Offset = "0x7B987B0", VA = "0x187B993B0")]
	[BurstCompile]
	private unsafe static void MPFAOGJDFGD([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B91B80", Offset = "0x7B90F80", VA = "0x187B91B80")]
	[BurstCompile]
	private unsafe static void BABIJPNIIOG([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A660", Offset = "0x7B99A60", VA = "0x187B9A660")]
	private void PANBIGPCCAB(NativeArray<float2> ANLBCLBDABI, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A780", Offset = "0x7B99B80", VA = "0x187B9A780")]
	[BurstCompile]
	private unsafe static void PANBIGPCCAB([NoAlias] uint* CEJFLHKEKOG, [Out] float2 FNCHPCCCBNH, [Out] float2 CGHLPACFJDK, [In][NoAlias] float2* ANLBCLBDABI, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B99420", Offset = "0x7B98820", VA = "0x187B99420")]
	[BurstCompile]
	private static void MPFOJEINCLB([Out] float2 IHCNIPPBNFD, uint BHFLOFOIHKM, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B94AB0", Offset = "0x7B93EB0", VA = "0x187B94AB0")]
	private void EIKALKEPLOL(NativeArray<float2> CEJFLHKEKOG, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B94A30", Offset = "0x7B93E30", VA = "0x187B94A30")]
	[BurstCompile]
	private unsafe static void EIKALKEPLOL([NoAlias] float2* CEJFLHKEKOG, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B94820", Offset = "0x7B93C20", VA = "0x187B94820")]
	[BurstCompile]
	private unsafe static void EEHAMFBEJPF([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B97EA0", Offset = "0x7B972A0", VA = "0x187B97EA0")]
	[BurstCompile]
	private unsafe static void KEJKDCACPHC([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B95430", Offset = "0x7B94830", VA = "0x187B95430")]
	[BurstCompile]
	private unsafe static void FCFLBANAEIJ([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B92840", Offset = "0x7B91C40", VA = "0x187B92840")]
	[BurstCompile]
	private unsafe static void BPDEMBGIOEC([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A450", Offset = "0x7B99850", VA = "0x187B9A450")]
	[BurstCompile]
	private unsafe static void OKJHGOLBCOO([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B94920", Offset = "0x7B93D20", VA = "0x187B94920")]
	private void EHPENOIJKHO(NativeArray<float4> ONLELDIDLMB, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B948A0", Offset = "0x7B93CA0", VA = "0x187B948A0")]
	[BurstCompile]
	private unsafe static void EHPENOIJKHO([NoAlias] ushort* FELJFKMIOCO, [In][NoAlias] float4* IMAFKDNIDCD, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B9ADC0", Offset = "0x7B9A1C0", VA = "0x187B9ADC0")]
	[BurstCompile]
	private static ushort PPLMPAEDJOP([In] float4 NIOLAEBPLEA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B99140", Offset = "0x7B98540", VA = "0x187B99140")]
	private void MBFFCEMBMBG(NativeArray<float4> FELJFKMIOCO, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B99230", Offset = "0x7B98630", VA = "0x187B99230")]
	[BurstCompile]
	private unsafe static void MBFFCEMBMBG([NoAlias] float4* FELJFKMIOCO, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B965D0", Offset = "0x7B959D0", VA = "0x187B965D0")]
	[BurstCompile]
	private unsafe static void HKNFJJOPKDJ([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B931D0", Offset = "0x7B925D0", VA = "0x187B931D0")]
	[BurstCompile]
	private unsafe static void CIJBMJAIPBL([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B918D0", Offset = "0x7B90CD0", VA = "0x187B918D0")]
	[BurstCompile]
	private unsafe static void AMFKDKLCNEJ([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B95C10", Offset = "0x7B95010", VA = "0x187B95C10")]
	[BurstCompile]
	private unsafe static void GMHBMHJONDG([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B94770", Offset = "0x7B93B70", VA = "0x187B94770")]
	[BurstCompile]
	private unsafe static void ECGNHHMPNIC([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B91940", Offset = "0x7B90D40", VA = "0x187B91940")]
	[BurstCompile]
	private static void AMPGLOGBGJC([Out] float4 APLCGCDLEGH, ushort BHFLOFOIHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7B91FA0", Offset = "0x7B913A0", VA = "0x187B91FA0")]
	private void BGJGCLPKHKK(Allocator LMMGDELCIGC, NativeArray<float4> HIMAFJIOHBB, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B923E0", Offset = "0x7B917E0", VA = "0x187B923E0")]
	[BurstCompile]
	private unsafe static void BGJGCLPKHKK([NoAlias] float4* IDPCIJLMEIF, [NoAlias] byte* PNDKDDMDECP, [Out] int HNDLDMGNCNB, [Out] int PLIMFCFKGHE, [NoAlias] float4* HIMAFJIOHBB, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7B93C80", Offset = "0x7B93080", VA = "0x187B93C80")]
	private static void DADLOGHNGJK(NativeArray<float4> CCLKJOBBMMI, NativeArray<AHFHPHGOPCC> FELGEJPEPGN, NativeArray<byte> AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B93DB0", Offset = "0x7B931B0", VA = "0x187B93DB0")]
	[BurstCompile]
	private unsafe static void DADLOGHNGJK([NoAlias] float4* CCLKJOBBMMI, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7B98EE0", Offset = "0x7B982E0", VA = "0x187B98EE0")]
	[BurstCompile]
	private unsafe static void LLJDJICPLHD([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7B927C0", Offset = "0x7B91BC0", VA = "0x187B927C0")]
	[BurstCompile]
	private unsafe static void BLFIFEMDEIP([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7B95800", Offset = "0x7B94C00", VA = "0x187B95800")]
	[BurstCompile]
	private unsafe static void FLKCBKHNIEK([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7B96070", Offset = "0x7B95470", VA = "0x187B96070")]
	[BurstCompile]
	private unsafe static void HGFKMIKEAIO([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7B998E0", Offset = "0x7B98CE0", VA = "0x187B998E0")]
	[BurstCompile]
	private unsafe static void NKNFKLAGKHC([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B91C60", Offset = "0x7B91060", VA = "0x187B91C60")]
	private void BEGIBNKBFBE(Allocator LMMGDELCIGC, NativeArray<int> MIBCPGGMJHK, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B954B0", Offset = "0x7B948B0", VA = "0x187B954B0")]
	private static NativeArray<byte> FDHGLFAHCOO(Allocator LMMGDELCIGC, NativeArray<int> MIBCPGGMJHK, int JILFGMKGLFA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B95790", Offset = "0x7B94B90", VA = "0x187B95790")]
	[BurstCompile]
	private unsafe static int FDHGLFAHCOO([NoAlias] byte* KKBGEGGDKEI, [In][NoAlias] int* MIBCPGGMJHK, int JILFGMKGLFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B98C80", Offset = "0x7B98080", VA = "0x187B98C80")]
	private static void LJFBIAHDCPG(NativeArray<int> MNBKLFJFDFC, NativeArray<byte> DHKGPDJPBCA, int DKFOONNFLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B98C10", Offset = "0x7B98010", VA = "0x187B98C10")]
	[BurstCompile]
	private unsafe static void LJFBIAHDCPG([NoAlias] int* MNBKLFJFDFC, [In][NoAlias] byte* DHKGPDJPBCA, int DKFOONNFLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B91BF0", Offset = "0x7B90FF0", VA = "0x187B91BF0")]
	[BurstCompile]
	private unsafe static void BDAKNGEGNPI([NoAlias] ushort* MNBKLFJFDFC, [In][NoAlias] byte* DHKGPDJPBCA, int DKFOONNFLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B91D60", Offset = "0x7B91160", VA = "0x187B91D60")]
	[BurstCompile]
	private static void BEHBDANKNDF([Out] float3 IHCNIPPBNFD, ushort BHFLOFOIHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B99DC0", Offset = "0x7B991C0", VA = "0x187B99DC0")]
	[BurstCompile]
	private static ushort OEFCOPEFPDF([In] float3 NIOLAEBPLEA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BA70", Offset = "0x7B7AE70", VA = "0x187B7BA70")]
	[BurstCompile]
	public unsafe static void ELNJFCPIOCF([NoAlias] float3* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B93110", Offset = "0x7B92510", VA = "0x187B93110")]
	[BurstCompile]
	public unsafe static void CIHNONBPBHP([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7B93050", Offset = "0x7B92450", VA = "0x187B93050")]
	[BurstCompile]
	public unsafe static void CGLKJFDCIHF([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B95AD0", Offset = "0x7B94ED0", VA = "0x187B95AD0")]
	[BurstCompile]
	public unsafe static void PABHENHDPMP([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B95AD0", Offset = "0x7B94ED0", VA = "0x187B95AD0")]
	[BurstCompile]
	public unsafe static void GHNBJABAOAG([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B98FE0", Offset = "0x7B983E0", VA = "0x187B98FE0")]
	[BurstCompile]
	public unsafe static void LNOGKEMPOAD([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* IFKLEMIEFMH, int DMCCFBNGLAK, [In] float3 FDJOOICFHJC, [In] float3 EIDGEMKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C610", Offset = "0x7B7BA10", VA = "0x187B7C610")]
	[BurstCompile]
	public unsafe static void IEGJHHOFJJN([NoAlias] ushort* HOABLOMBPKB, [Out] float3 CPLJPMJMPLM, [Out] float3 EIDGEMKCKCM, [In][NoAlias] float3* IFKLEMIEFMH, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B98960", Offset = "0x7B97D60", VA = "0x187B98960")]
	[BurstCompile]
	public unsafe static void LFFMEDJAAKH([NoAlias] ushort* IIPEFHMFFED, [In][NoAlias] float3* BAIHOOLDFBD, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A810", Offset = "0x7B99C10", VA = "0x187B9A810")]
	[BurstCompile]
	public unsafe static void PFJHJBHNNDJ([NoAlias] float3* KBLIIPDNLKF, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B95880", Offset = "0x7B94C80", VA = "0x187B95880")]
	[BurstCompile]
	public unsafe static void GHHFOFEODGM([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B997A0", Offset = "0x7B98BA0", VA = "0x187B997A0")]
	[BurstCompile]
	public unsafe static void NIBPGNGBEJK([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B97590", Offset = "0x7B96990", VA = "0x187B97590")]
	[BurstCompile]
	public unsafe static void JIGLHDCHFCJ([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B97120", Offset = "0x7B96520", VA = "0x187B97120")]
	[BurstCompile]
	public unsafe static void IKHBCMGDEKI([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B98D70", Offset = "0x7B98170", VA = "0x187B98D70")]
	[BurstCompile]
	public unsafe static void LJGJAAHDJHN([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* BAIHOOLDFBD, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D2C0", Offset = "0x7B7C6C0", VA = "0x187B7D2C0")]
	[BurstCompile]
	public unsafe static void OPKNDDOFCPN([NoAlias] uint* CEJFLHKEKOG, [Out] float2 FNCHPCCCBNH, [Out] float2 CGHLPACFJDK, [In][NoAlias] float2* ANLBCLBDABI, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B970E0", Offset = "0x7B964E0", VA = "0x187B970E0")]
	[BurstCompile]
	public static void HPAMLAFBBPC([Out] float2 IHCNIPPBNFD, uint BHFLOFOIHKM, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B95F60", Offset = "0x7B95360", VA = "0x187B95F60")]
	[BurstCompile]
	public unsafe static void HFNJEMGHDLM([NoAlias] float2* CEJFLHKEKOG, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B9AC80", Offset = "0x7B9A080", VA = "0x187B9AC80")]
	[BurstCompile]
	public unsafe static void POBNNDCOEJB([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7B93B40", Offset = "0x7B92F40", VA = "0x187B93B40")]
	[BurstCompile]
	public unsafe static void COOALABHFHF([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B99580", Offset = "0x7B98980", VA = "0x187B99580")]
	[BurstCompile]
	public unsafe static void NFFDBBIAMKH([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A320", Offset = "0x7B99720", VA = "0x187B9A320")]
	[BurstCompile]
	public unsafe static void OGPNLBOEOJD([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B95DC0", Offset = "0x7B951C0", VA = "0x187B95DC0")]
	[BurstCompile]
	public unsafe static void HBOOCFGHPNG([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [NoAlias] uint* ANLBCLBDABI, int DMCCFBNGLAK, [In] float2 BCEEKEAEAHF, [In] float2 CGHLPACFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B994A0", Offset = "0x7B988A0", VA = "0x187B994A0")]
	[BurstCompile]
	public unsafe static void NAKPJOLMMBM([NoAlias] ushort* FELJFKMIOCO, [In][NoAlias] float4* IMAFKDNIDCD, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B93430", Offset = "0x7B92830", VA = "0x187B93430")]
	[BurstCompile]
	public static ushort CMAFNOJHJCM([In] float4 NIOLAEBPLEA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A510", Offset = "0x7B99910", VA = "0x187B9A510")]
	[BurstCompile]
	public unsafe static void OMKJDPJNNDL([NoAlias] float4* FELJFKMIOCO, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B962E0", Offset = "0x7B956E0", VA = "0x187B962E0")]
	[BurstCompile]
	public unsafe static void HJDLNIAFDBE([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7B93240", Offset = "0x7B92640", VA = "0x187B93240")]
	[BurstCompile]
	public unsafe static void CJJIFDEECKK([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B96F70", Offset = "0x7B96370", VA = "0x187B96F70")]
	[BurstCompile]
	public unsafe static void HOKNCIFMMHL([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B985F0", Offset = "0x7B979F0", VA = "0x187B985F0")]
	[BurstCompile]
	public unsafe static void KKECHBMJKID([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B9AAB0", Offset = "0x7B99EB0", VA = "0x187B9AAB0")]
	[BurstCompile]
	public unsafe static void PHCECMBIMOE([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] ushort* ONLELDIDLMB, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7B99D00", Offset = "0x7B99100", VA = "0x187B99D00")]
	[BurstCompile]
	public static void OCDBFHPECFM([Out] float4 APLCGCDLEGH, ushort BHFLOFOIHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BF10", Offset = "0x7B7B310", VA = "0x187B7BF10")]
	[BurstCompile]
	public unsafe static void FPIPHHMEAJK([NoAlias] float4* IDPCIJLMEIF, [NoAlias] byte* PNDKDDMDECP, [Out] int HNDLDMGNCNB, [Out] int PLIMFCFKGHE, [NoAlias] float4* HIMAFJIOHBB, int BIKIKJNDBDH, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B95C80", Offset = "0x7B95080", VA = "0x187B95C80")]
	[BurstCompile]
	public unsafe static void GOILLDCPPAL([NoAlias] float4* CCLKJOBBMMI, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B919A0", Offset = "0x7B90DA0", VA = "0x187B919A0")]
	[BurstCompile]
	public unsafe static void APMPAMAHNIL([NoAlias] EFFDIJJLADK.KDNHFEMBJFI* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B94010", Offset = "0x7B93410", VA = "0x187B94010")]
	[BurstCompile]
	public unsafe static void DHMJGCOLAEG([NoAlias] EFFDIJJLADK.JBOBBCKPDOA* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B93E30", Offset = "0x7B93230", VA = "0x187B93E30")]
	[BurstCompile]
	public unsafe static void DAJKEOFJABI([NoAlias] EFFDIJJLADK.OLBLDNJPGND* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B951F0", Offset = "0x7B945F0", VA = "0x187B951F0")]
	[BurstCompile]
	public unsafe static void FBKENKKLPBK([NoAlias] EFFDIJJLADK.MIPCNMIEFPJ* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B97290", Offset = "0x7B96690", VA = "0x187B97290")]
	[BurstCompile]
	public unsafe static void IPNNLDCJKOK([NoAlias] EFFDIJJLADK.IEIAPPJHLKP* HOABLOMBPKB, [In][NoAlias] AHFHPHGOPCC* FELGEJPEPGN, [In][NoAlias] byte* AJMJPMKBEHN, int DMCCFBNGLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B96E70", Offset = "0x7B96270", VA = "0x187B96E70")]
	[BurstCompile]
	public unsafe static int HNOOEHOIAAJ([NoAlias] byte* KKBGEGGDKEI, [In][NoAlias] int* MIBCPGGMJHK, int JILFGMKGLFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B99310", Offset = "0x7B98710", VA = "0x187B99310")]
	[BurstCompile]
	public unsafe static void MNBFCBNKEOK([NoAlias] int* MNBKLFJFDFC, [In][NoAlias] byte* DHKGPDJPBCA, int DKFOONNFLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B93AA0", Offset = "0x7B92EA0", VA = "0x187B93AA0")]
	[BurstCompile]
	public unsafe static void CNNGGJCDOOH([NoAlias] ushort* MNBKLFJFDFC, [In][NoAlias] byte* DHKGPDJPBCA, int DKFOONNFLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B8D0", Offset = "0x7B7ACD0", VA = "0x187B7B8D0")]
	[BurstCompile]
	public static void BMHHJKEJAOC([Out] float3 IHCNIPPBNFD, ushort BHFLOFOIHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C9F0", Offset = "0x7B7BDF0", VA = "0x187B7C9F0")]
	[BurstCompile]
	public static ushort IKGCCNAKICJ([In] float3 NIOLAEBPLEA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class EFFDIJJLADK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum OLOGDNNFPLF
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
	public enum EEOJGFFNOHF
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
	public struct KABDCJCCJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OLOGDNNFPLF EIDACCNCFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool GBGPMGHFFCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int EDFJMLJKIJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] HKBMCKKBNNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct KKKCKOBJOJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 KBPOHLLNAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 KBGACFDBMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 KIEOKDMFIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 ILELMPAHOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 FBPFHNCEAKL;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] HKBMCKKBNNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct KDNHFEMBJFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 KBPOHLLNAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 KBGACFDBMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 KIEOKDMFIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 ILELMPAHOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 FBPFHNCEAKL;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] HKBMCKKBNNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct JBOBBCKPDOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 KBPOHLLNAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint KBGACFDBMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint KIEOKDMFIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 ILELMPAHOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 FBPFHNCEAKL;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] HKBMCKKBNNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct OLBLDNJPGND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 KBPOHLLNAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint KBGACFDBMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint KIEOKDMFIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 ILELMPAHOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 FBPFHNCEAKL;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] HKBMCKKBNNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct MIPCNMIEFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 KBPOHLLNAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint JKDCGBLPPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 ILELMPAHOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint IKHLJHFKOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint AIINFJBAELC;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] HKBMCKKBNNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct IEIAPPJHLKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public KENOLEMODBA.PDFHINIBIOI OIMCLCBAIAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint JKDCGBLPPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 ILELMPAHOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint IKHLJHFKOCE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] HKBMCKKBNNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int DFCJJILMCPC(float COBPEJEHIHC);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class IFGAAIPKDBP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D8A0", Offset = "0x7B8CCA0", VA = "0x187B8D8A0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D420", Offset = "0x7B8C820", VA = "0x187B8D420")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D7F0", Offset = "0x7B8CBF0", VA = "0x187B8D7F0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D580", Offset = "0x7B8C980", VA = "0x187B8D580")]
		public static int HFGDGIKOIHK(float COBPEJEHIHC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint HMODBIFAFGG([In] float4 LLEKGMDPLMK);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class CELDPIMNJEM
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7BA32E0", Offset = "0x7BA26E0", VA = "0x187BA32E0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E50", Offset = "0x7BA2250", VA = "0x187BA2E50")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3230", Offset = "0x7BA2630", VA = "0x187BA3230")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2FB0", Offset = "0x7BA23B0", VA = "0x187BA2FB0")]
		public static uint HFGDGIKOIHK([In] float4 LLEKGMDPLMK)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint PJHBDIOKEPG([In] float3 LLEKGMDPLMK);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class AOPCBLOCOCK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2CA0", Offset = "0x7BA20A0", VA = "0x187BA2CA0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2840", Offset = "0x7BA1C40", VA = "0x187BA2840")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2BF0", Offset = "0x7BA1FF0", VA = "0x187BA2BF0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7BA29A0", Offset = "0x7BA1DA0", VA = "0x187BA29A0")]
		public static uint HFGDGIKOIHK([In] float3 LLEKGMDPLMK)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void JHPHMCAIIMC([NoAlias] JBOBBCKPDOA* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class GEBPBAJIEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC620", Offset = "0x7BABA20", VA = "0x187BAC620")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC1D0", Offset = "0x7BAB5D0", VA = "0x187BAC1D0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC570", Offset = "0x7BAB970", VA = "0x187BAC570")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC330", Offset = "0x7BAB730", VA = "0x187BAC330")]
		public unsafe static void HFGDGIKOIHK([NoAlias] JBOBBCKPDOA* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void EBOGGNEJIDI([NoAlias] OLBLDNJPGND* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class OBEMGICLICP
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7BB4CD0", Offset = "0x7BB40D0", VA = "0x187BB4CD0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7BB4880", Offset = "0x7BB3C80", VA = "0x187BB4880")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7BB4C20", Offset = "0x7BB4020", VA = "0x187BB4C20")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7BB49E0", Offset = "0x7BB3DE0", VA = "0x187BB49E0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] OLBLDNJPGND* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void KHJABACBANF([NoAlias] MIPCNMIEFPJ* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class JLPJHGHFJJA
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE720", Offset = "0x7BADB20", VA = "0x187BAE720")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE120", Offset = "0x7BAD520", VA = "0x187BAE120")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE670", Offset = "0x7BADA70", VA = "0x187BAE670")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE280", Offset = "0x7BAD680", VA = "0x187BAE280")]
		public unsafe static void HFGDGIKOIHK([NoAlias] MIPCNMIEFPJ* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void IMKPNAMKDKC([NoAlias] IEIAPPJHLKP* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL, [Out] float3 KJJCCHNAKDH, [Out] float3 MHIKCIEIFPC);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class KIBLGLHNFKI
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF2E0", Offset = "0x7BAE6E0", VA = "0x187BAF2E0")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEB70", Offset = "0x7BADF70", VA = "0x187BAEB70")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF230", Offset = "0x7BAE630", VA = "0x187BAF230")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7BAECD0", Offset = "0x7BAE0D0", VA = "0x187BAECD0")]
		public unsafe static void HFGDGIKOIHK([NoAlias] IEIAPPJHLKP* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL, [Out] float3 KJJCCHNAKDH, [Out] float3 MHIKCIEIFPC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int LMEPBAFCKIO = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> ADDMDCBIMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> KDOFENDCMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> JLAOPOBELLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> CGDFOIJKOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> JLBLEIJACDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> HPPJMLBEDKF;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] NPAGIDHAEDE;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool CCFNMOMMGMK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static KABDCJCCJGD[] OLLAPADMPDF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool GHONCNALJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F20", Offset = "0x7B84320", VA = "0x187B84F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HBNBJNMIHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B88060", Offset = "0x7B87460", VA = "0x187B88060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JCPPNAIFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B86620", Offset = "0x7B85A20", VA = "0x187B86620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AMIMOEABHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B89260", Offset = "0x7B88660", VA = "0x187B89260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B86C30", Offset = "0x7B86030", VA = "0x187B86C30")]
	public static EEOJGFFNOHF JNOGIACBCMG(OLOGDNNFPLF EIDACCNCFOG)
	{
		return default(EEOJGFFNOHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B84880", Offset = "0x7B83C80", VA = "0x187B84880")]
	public static void DFDFLLHPACG(EEOJGFFNOHF JLBENLHNNNM, Material FFHFAEDNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B84A10", Offset = "0x7B83E10", VA = "0x187B84A10", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B88FF0", Offset = "0x7B883F0", VA = "0x187B88FF0")]
	public void NLNPPHKFKKL(int MIJFEJOJGGN, int OBALFOMMEDB, Allocator LMMGDELCIGC, bool JKGOOMGCMJC, bool BNIKFHMCKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B83220", Offset = "0x7B82620", VA = "0x187B83220")]
	public void CEIKODEHPII(int MIJFEJOJGGN, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B88440", Offset = "0x7B87840", VA = "0x187B88440", Slot = "6")]
	public bool MEECCOFBDKN(Mesh IGPCANDHEAE, bool FJPLPCFNLAL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7B84B20", Offset = "0x7B83F20", VA = "0x187B84B20")]
	public bool EBLONFPGOKH(Mesh IGPCANDHEAE, bool FJPLPCFNLAL, bool FLBNDMMOENL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7B85720", Offset = "0x7B84B20", VA = "0x187B85720")]
	public bool FDDHGNJELMD(Mesh IGPCANDHEAE, EFFDIJJLADK MPMPNMKNOKD, bool FJPLPCFNLAL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B869B0", Offset = "0x7B85DB0", VA = "0x187B869B0")]
	public bool IKLHHDMALIK(Mesh IGPCANDHEAE, EFFDIJJLADK MPMPNMKNOKD, OLOGDNNFPLF EIDACCNCFOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B83DE0", Offset = "0x7B831E0", VA = "0x187B83DE0")]
	private void CNNLBKJBFEG(Mesh IGPCANDHEAE, EFFDIJJLADK MPMPNMKNOKD, bool FLBNDMMOENL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B84570", Offset = "0x7B83970", VA = "0x187B84570")]
	public void CNNLBKJBFEG(NativeArray<ushort> IMFGHNILMJE, NativeArray<MIPCNMIEFPJ> KJDEFLHGAIG, Mesh IGPCANDHEAE, EFFDIJJLADK MPMPNMKNOKD, bool FLBNDMMOENL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B832A0", Offset = "0x7B826A0", VA = "0x187B832A0")]
	public void CMDMKPOHEII(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B85E70", Offset = "0x7B85270", VA = "0x187B85E70")]
	[BurstCompile]
	public static int GLFFFLFFCFD(float COBPEJEHIHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B85EC0", Offset = "0x7B852C0", VA = "0x187B85EC0")]
	[BurstCompile]
	public static uint GLFFFLFFCFD([In] float4 LLEKGMDPLMK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7B85E20", Offset = "0x7B85220", VA = "0x187B85E20")]
	[BurstCompile]
	public static uint GLFFFLFFCFD([In] float3 LLEKGMDPLMK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B879D0", Offset = "0x7B86DD0", VA = "0x187B879D0")]
	public void KJPOJLIBNJG(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B856A0", Offset = "0x7B84AA0", VA = "0x187B856A0")]
	[BurstCompile]
	private unsafe static void EPMDFCANCMG([NoAlias] JBOBBCKPDOA* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7B85F90", Offset = "0x7B85390", VA = "0x187B85F90")]
	public void HNBNDNPGNHP(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7B85F10", Offset = "0x7B85310", VA = "0x187B85F10")]
	[BurstCompile]
	private unsafe static void GMEJHJIGANM([NoAlias] OLBLDNJPGND* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7B87030", Offset = "0x7B86430", VA = "0x187B87030")]
	public void KAKFJNGLJOF(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7B86C80", Offset = "0x7B86080", VA = "0x187B86C80")]
	public void KAKFJNGLJOF(NativeArray<ushort> NBFOEFEABNC, NativeArray<MIPCNMIEFPJ> KHJOOAKPGCG, Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B891E0", Offset = "0x7B885E0", VA = "0x187B891E0")]
	[BurstCompile]
	public unsafe static void OGKPBKCNIDG([NoAlias] MIPCNMIEFPJ* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7B84F60", Offset = "0x7B84360", VA = "0x187B84F60")]
	public void EJJMAEFFKKJ(Mesh IGPCANDHEAE, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7B82CC0", Offset = "0x7B820C0", VA = "0x187B82CC0")]
	[BurstCompile]
	private unsafe static void BCOHPFODMJO([NoAlias] IEIAPPJHLKP* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL, [Out] float3 KJJCCHNAKDH, [Out] float3 MHIKCIEIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7B82D40", Offset = "0x7B82140", VA = "0x187B82D40")]
	public void BPDNIELCODH(Mesh IGPCANDHEAE, OLOGDNNFPLF EIDACCNCFOG, bool FLBNDMMOENL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7B86660", Offset = "0x7B85A60", VA = "0x187B86660")]
	public void IAGEDJMCMMO(EFFDIJJLADK IGPCANDHEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7B83CE0", Offset = "0x7B830E0", VA = "0x187B83CE0")]
	public void CMOCGOAEHJN(EFFDIJJLADK ILNONAAFECI, Allocator LMMGDELCIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7B86A80", Offset = "0x7B85E80", VA = "0x187B86A80")]
	public long IPOELGFFMMG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7B86BD0", Offset = "0x7B85FD0", VA = "0x187B86BD0")]
	public static long IPOELGFFMMG(int OBDAAFOJBJK, int KLCBAJEMNFN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7B88460", Offset = "0x7B87860", VA = "0x187B88460")]
	public static long MMHHHILONCN(int OBDAAFOJBJK, int KLCBAJEMNFN, OLOGDNNFPLF EIDACCNCFOG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7B88500", Offset = "0x7B87900", VA = "0x187B88500")]
	public long MMHHHILONCN(OLOGDNNFPLF EIDACCNCFOG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B883E0", Offset = "0x7B877E0", VA = "0x187B883E0")]
	public void LOGFHDJLLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7B87400", Offset = "0x7B86800", VA = "0x187B87400")]
	public static void KEJEKKKCDJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B885C0", Offset = "0x7B879C0", VA = "0x187B885C0")]
	public OLOGDNNFPLF NGDBDPDOEKA()
	{
		return default(OLOGDNNFPLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7B84940", Offset = "0x7B83D40", VA = "0x187B84940")]
	public static (int, int) DFGKEOMOKCP(Mesh IGPCANDHEAE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7B868D0", Offset = "0x7B85CD0", VA = "0x187B868D0")]
	public static int IIPJHJIPHMG(VertexAttributeDescriptor[] FLMMDHOJDJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7B82760", Offset = "0x7B81B60", VA = "0x187B82760")]
	public static long AHBOPHNHAJP(Mesh IGPCANDHEAE, int NKIPNBIOINA, int FEKNNLHHOLC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B827D0", Offset = "0x7B81BD0", VA = "0x187B827D0")]
	public static long AHBOPHNHAJP(Mesh IGPCANDHEAE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public EFFDIJJLADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7B88D10", Offset = "0x7B88110", VA = "0x187B88D10")]
	[BurstCompile]
	public static int NGGCHGHIFNG(float COBPEJEHIHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7B88DB0", Offset = "0x7B881B0", VA = "0x187B88DB0")]
	[BurstCompile]
	public static uint NGGCHGHIFNG([In] float4 LLEKGMDPLMK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7B88F40", Offset = "0x7B88340", VA = "0x187B88F40")]
	[BurstCompile]
	public static uint NGGCHGHIFNG([In] float3 LLEKGMDPLMK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7B82900", Offset = "0x7B81D00", VA = "0x187B82900")]
	[BurstCompile]
	public unsafe static void AHNIHIFBIPJ([NoAlias] JBOBBCKPDOA* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7B82DD0", Offset = "0x7B821D0", VA = "0x187B82DD0")]
	[BurstCompile]
	public unsafe static void CAMMPCDHGHB([NoAlias] OLBLDNJPGND* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7B85C20", Offset = "0x7B85020", VA = "0x187B85C20")]
	[BurstCompile]
	public unsafe static void FNPKLBIEMAC([NoAlias] MIPCNMIEFPJ* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7B880A0", Offset = "0x7B874A0", VA = "0x187B880A0")]
	[BurstCompile]
	public unsafe static void LMPKIEMLODL([NoAlias] IEIAPPJHLKP* HOABLOMBPKB, int DMCCFBNGLAK, [In][NoAlias] float3* PNDHPFCEJFN, [In][NoAlias] float3* OJBFBCFKCKE, [In][NoAlias] float4* JDKPOCGANDE, [In][NoAlias] float2* PDDIIOMKKCB, [In][NoAlias] float4* FBPFHNCEAKL, [Out] float3 KJJCCHNAKDH, [Out] float3 MHIKCIEIFPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BAEOIAALKDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int JFDPGOFBKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 IEHPCDHCOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion CAPOFJPNGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 OAFFIMHOGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int KGJJNNOKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int GCPEOPHCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int JAMPKJBPKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float KPHDBNLAJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 KMCBJFDCGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool DDLBIFCAHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public ECCJBFKFHGL KPGPAKCHBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 KHDCEBEFKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float MBJCHEODHKL;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class PLFGDBMHKGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static NCHCFNFMMPI EKNKHIDLLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<BAEOIAALKDM> JGPPLEIJLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<KAFMOCADPGE> GLLJGHFFECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<LGJKLCBBIPI> MHHMEMKBINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<KOLCMGJNCCI> KHGNGGINCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<KAFMOCADPGE> AONNFAGFFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<PENNCBILPHD> HEABLEODGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<KOLCMGJNCCI>> DPBMPICAMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<NGIMKCBCGCA> FLAKEGFGNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> CPNLIKCCNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> NFENAGOJNIN;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<BEKGKNHPJKN.FGMMJCICOHA> JFNENOFBBKM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HBNBJNMIHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9D8BF0", Offset = "0x9D7FF0", VA = "0x1809D8BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9D8BC0", Offset = "0x9D7FC0", VA = "0x1809D8BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JCPPNAIFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xBEA180", Offset = "0xBE9580", VA = "0x180BEA180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xBEA190", Offset = "0xBE9590", VA = "0x180BEA190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9710", Offset = "0x7BB8B10", VA = "0x187BB9710")]
	public PLFGDBMHKGH(int MLGBPABBJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8B80", Offset = "0x7BB7F80", VA = "0x187BB8B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7BB76C0", Offset = "0x7BB6AC0", VA = "0x187BB76C0")]
	public void BKMLDGFOOLL(JobHandle KAKLANICLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9390", Offset = "0x7BB8790", VA = "0x187BB9390")]
	public void ONLFBDAGEMP(BAEOIAALKDM AOFGGGKINCN, NGIMKCBCGCA GIJICIFEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB95B0", Offset = "0x7BB89B0", VA = "0x187BB95B0")]
	public void PHOMDLAPEGK(LGJKLCBBIPI AOFGGGKINCN, NativeArray<KOLCMGJNCCI> MFOILAAKEOH, int DMCCFBNGLAK, int DKFOONNFLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB78B0", Offset = "0x7BB6CB0", VA = "0x187BB78B0")]
	public JobHandle DBIDLGHAHEO(EFFDIJJLADK FBCINGPIGDA, JPGCMFCMNLL HAIAJGNFDBG, float3 ALFMBOOEDDH, quaternion PGMBPHFLFDF, float GIHDMNJIELD, bool AJCIGMJMPOB, int ELIJOEMDBIP = 0, int BOLDLBFIMGF = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7BB79D0", Offset = "0x7BB6DD0", VA = "0x187BB79D0")]
	public JobHandle DBIDLGHAHEO(EFFDIJJLADK FBCINGPIGDA, JPGCMFCMNLL HAIAJGNFDBG, NativeList<BEKGKNHPJKN.FGMMJCICOHA> DHAJBLOBBGG, float3 ALFMBOOEDDH, quaternion PGMBPHFLFDF, float GIHDMNJIELD, bool AJCIGMJMPOB, bool PFBEAFLJOCI, int ELIJOEMDBIP = 0, int BOLDLBFIMGF = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9010", Offset = "0x7BB8410", VA = "0x187BB9010")]
	public static JobHandle NJJDNDEAJFG(EAKADENKGMG LDLGNCNKBNM, EFFDIJJLADK FBCINGPIGDA, NativeArray<int> NFENAGOJNIN, BAEOIAALKDM AOFGGGKINCN, JobHandle KAKLANICLFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8D60", Offset = "0x7BB8160", VA = "0x187BB8D60")]
	public static JobHandle MDNGHCLFPCM(NPEEJPEHNJE LDLGNCNKBNM, EFFDIJJLADK FBCINGPIGDA, LGJKLCBBIPI AOFGGGKINCN, NativeArray<KOLCMGJNCCI> MFOILAAKEOH, int DMCCFBNGLAK, int DKFOONNFLLO, JobHandle KAKLANICLFE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class MJMIDBNNJNL
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct CABKPMEJJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer JBNKAEBEMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public EMPNILLGHPO.KFFHDFEDALH EJOBMJFDEIK;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5A74850", Offset = "0x5A73C50", VA = "0x185A74850")]
		public CABKPMEJJEI(MeshRenderer JBNKAEBEMAK, EMPNILLGHPO.KFFHDFEDALH EJOBMJFDEIK)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2DD0", Offset = "0x7BA21D0", VA = "0x187BA2DD0")]
		public static CABKPMEJJEI HIHFKEJHDAH((MeshRenderer, EMPNILLGHPO.KFFHDFEDALH) OFDLFCAMOAE)
		{
			return default(CABKPMEJJEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker FNDOAJLLIPL;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker AMIGLJABBHL;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker BLNELJGIGPE;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker PKIMCNBGOHF;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7BB27A0", Offset = "0x7BB1BA0", VA = "0x187BB27A0")]
	internal void OKLDELINOCC(EMPNILLGHPO.NMINKLELBIE EHFLAKMJIEP, List<CABKPMEJJEI> ILMOMHGFJFP, Material FFHFAEDNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7BB04C0", Offset = "0x7BAF8C0", VA = "0x187BB04C0")]
	internal void BKHBPJKGADP(EMPNILLGHPO.NMINKLELBIE EHFLAKMJIEP, List<CABKPMEJJEI> ILMOMHGFJFP, List<LODGroup> HBBECFKAPLK, Material FFHFAEDNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0E20", Offset = "0x7BB0220", VA = "0x187BB0E20")]
	private MeshRenderer KBPJMBDPGBA(EMPNILLGHPO.NMINKLELBIE EHFLAKMJIEP, Material FFHFAEDNMPG, List<CABKPMEJJEI> ILMOMHGFJFP, bool IBPKHKLHGGB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7BB18A0", Offset = "0x7BB0CA0", VA = "0x187BB18A0")]
	private List<(List<CABKPMEJJEI>, float)> NGHHKGFBFJF(EMPNILLGHPO.NMINKLELBIE EHFLAKMJIEP, List<LODGroup> HBBECFKAPLK, Material FFHFAEDNMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF760", Offset = "0x7BAEB60", VA = "0x187BAF760")]
	private List<List<(List<CABKPMEJJEI>, float)>> BJDKFFOCFDH(EMPNILLGHPO.NMINKLELBIE EHFLAKMJIEP, List<LODGroup> HBBECFKAPLK, Material FFHFAEDNMPG, [Out] int EODKCOJPDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MJMIDBNNJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0CB0", Offset = "0x7BB00B0", VA = "0x187BB0CB0")]
	[CompilerGenerated]
	internal static (float, int) EKAPBCKBNKO(List<List<(List<CABKPMEJJEI> meshList, float lodTransition)>> DIHNABEFMJA, int[] AKOCNHEEPJF)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class OCCGPDFKLNN
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker BIOBPPNDOFK;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker EHLGCGHMNHG;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker OHGHDMPDFOD;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker KNMHNKMKIBD;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker FMEOCLJINBE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker FLCMHMBFKAD;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker BHNCGMFPBBD;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly LMKAPNBAFDO FMKGJINMHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private EMPNILLGHPO OKIBDLALBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private MJMIDBNNJNL NPMCFBCPDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader BAJIKLEAHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock HLMAHIHKEDB;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7090", Offset = "0x7BB6490", VA = "0x187BB7090")]
	public static void PGMDMHDEFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5380", Offset = "0x7BB4780", VA = "0x187BB5380")]
	public void ENMMELFAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6E70", Offset = "0x7BB6270", VA = "0x187BB6E70")]
	public void OKIGAJLLLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5BC0", Offset = "0x7BB4FC0", VA = "0x187BB5BC0")]
	private bool IBJJPPFLHFO(MeshRenderer JBNKAEBEMAK, [Out] MeshFilter DEENNNHIHBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6270", Offset = "0x7BB5670", VA = "0x187BB6270")]
	private bool JGCABHCEFFG(int COPLIEINKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6490", Offset = "0x7BB5890", VA = "0x187BB6490")]
	private void JNEPCIJJFIE(int COPLIEINKOF, Material FFHFAEDNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7BB66B0", Offset = "0x7BB5AB0", VA = "0x187BB66B0")]
	private List<MJMIDBNNJNL.CABKPMEJJEI> KDKNNCDLHBM(int COPLIEINKOF, [Out] List<LODGroup> HBBECFKAPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4E00", Offset = "0x7BB4200", VA = "0x187BB4E00")]
	private List<(int, Material)> AMCAJHJLHDE(float LLDLLHHHCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5B10", Offset = "0x7BB4F10", VA = "0x187BB5B10")]
	public void HAHHCGEAEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5D40", Offset = "0x7BB5140", VA = "0x187BB5D40")]
	private bool JEIICLEHEJB(GameObject GMFIIANHHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7660", Offset = "0x7BB6A60", VA = "0x187BB7660")]
	public OCCGPDFKLNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class EMPNILLGHPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct NMINKLELBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 CBHAMKJGEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 JLCBKIPFKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float CNMGHIPABPK;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7BB44F0", Offset = "0x7BB38F0", VA = "0x187BB44F0")]
		public NMINKLELBIE(Bounds ECGIIMPBODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7BB43E0", Offset = "0x7BB37E0", VA = "0x187BB43E0")]
		public NMINKLELBIE(float3 CBHAMKJGEOB, float3 JLCBKIPFKML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct GJNADDDIJED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NMINKLELBIE IJFJBFLLBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int DDKGJJEDJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int HABMKHFDFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float IJKPPNLAFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int MIJFEJOJGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int AMKNBAPKIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int INODNHEJDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int MMNNHGHDJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int IBPHGCGAPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool JMIHEIHCDGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct KFFHDFEDALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh FGNNOJBFLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 HJFEMPCLMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int JLNFNODAEJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct LMAGBKLGFBB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<GJNADDDIJED> ELKEEDJPIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> GKIPCPOAHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int LKIDPLLFCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public NMINKLELBIE ECGIIMPBODP;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF410", Offset = "0x7BAE810", VA = "0x187BAF410")]
		private float ABDOKBAMGJA(NMINKLELBIE EHIMHGHKFCP, NMINKLELBIE MDCPFJBHOAB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF540", Offset = "0x7BAE940", VA = "0x187BAF540", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker PAFFKAGODHJ;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker LJNLHLAAAEH;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker PJOCNPHKGOH;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker EBAPLJMIBKC;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker FFFAMLJNNMI;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker BCGLDEPDEGK;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker FGHKBIJGKEB;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker FEDANCAEGDK;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker IKCEKJGPEAC;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker OIBPHBJJHPK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker DIAMFFCGHBH;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker NANPDJEMHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<GJNADDDIJED> ELKEEDJPIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> HDJJKCNGELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int FAELFFCEBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> PNMKPNHIHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<KFFHDFEDALH> OGJAFLNJFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> HBBECFKAPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> CAKOBAPDKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> CECOHCJLEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader AEJPAEGPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader OFPNBEBMMPP;

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7BABE90", Offset = "0x7BAB290", VA = "0x187BABE90")]
	public EMPNILLGHPO(int BHLPCOFJHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA500", Offset = "0x7BA9900", VA = "0x187BAA500")]
	private void GPGINBINFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9CC0", Offset = "0x7BA90C0", VA = "0x187BA9CC0")]
	public bool EDCKCECAKGC(MeshRenderer IIMBHKLPEEK, MeshFilter EOIIOGGNOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9000", Offset = "0x7BA8400", VA = "0x187BA9000")]
	public bool EDCKCECAKGC(LODGroup OGLNNDPDABL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7BAAAC0", Offset = "0x7BA9EC0", VA = "0x187BAAAC0")]
	private bool HEMHPGJLPIO(MeshRenderer IIMBHKLPEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8E30", Offset = "0x7BA8230", VA = "0x187BA8E30")]
	private int DJMCCKLNDPG(MeshRenderer IIMBHKLPEEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7BABB30", Offset = "0x7BAAF30", VA = "0x187BABB30")]
	private int PEOKNJOIMPL(LODGroup OGLNNDPDABL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8850", Offset = "0x7BA7C50", VA = "0x187BA8850")]
	private int CAGDPIDHDPF(MeshFilter EOIIOGGNOLI, int EBBDANBAIHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB0D0", Offset = "0x7BAA4D0", VA = "0x187BAB0D0")]
	private int MFJIAGGFAME()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA150", Offset = "0x7BA9550", VA = "0x187BAA150")]
	private static NMINKLELBIE FLALNALFODI(NMINKLELBIE EHIMHGHKFCP, NMINKLELBIE MDCPFJBHOAB)
	{
		return default(NMINKLELBIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB9E0", Offset = "0x7BAADE0", VA = "0x187BAB9E0")]
	private static float NFHIOMLCEJP(Vector3 CBHAMKJGEOB, Vector3 JLCBKIPFKML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7BAADA0", Offset = "0x7BAA1A0", VA = "0x187BAADA0")]
	private int LEJDNKNOIEB(int PGDPDENNINC, NMINKLELBIE JALJGJOJMBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7BAAB40", Offset = "0x7BA9F40", VA = "0x187BAAB40")]
	private void KGPPHLPGOGK(NMINKLELBIE JALJGJOJMBC, int COPLIEINKOF, [Out] float HFNOFBJMNJE, [Out] float IHDHHHJJJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7BA89B0", Offset = "0x7BA7DB0", VA = "0x187BA89B0")]
	private void CFKLGABNPHF(NMINKLELBIE JALJGJOJMBC, int PFAEEIIALNA, Material FFHFAEDNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA81D0", Offset = "0x7BA75D0", VA = "0x187BA81D0")]
	private float ABDOKBAMGJA(NMINKLELBIE EHIMHGHKFCP, NMINKLELBIE MDCPFJBHOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8410", Offset = "0x7BA7810", VA = "0x187BA8410")]
	private void BICAIIIHBNH(int COPLIEINKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA670", Offset = "0x7BA9A70", VA = "0x187BAA670")]
	private void HABDGKKJOJB(int DFJFBPGKGOB, int AJIMMAKPHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB430", Offset = "0x7BAA830", VA = "0x187BAB430")]
	private void MLKNJKNDJAL(int DFJFBPGKGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8F50", Offset = "0x7BA8350", VA = "0x187BA8F50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct FCAALAJOLFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 BGMAPKEKIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 BGEOGBAFMGA;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class NIJEJPONOEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<FCAALAJOLFC> AJOFJMBPIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> EDNBBKCHEGO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HBNBJNMIHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JCPPNAIFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCD0", Offset = "0x9CF0D0", VA = "0x1809CFCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4320", Offset = "0x7BB3720", VA = "0x187BB4320")]
	public NIJEJPONOEO(int MIJFEJOJGGN, int OBALFOMMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7BB41E0", Offset = "0x7BB35E0", VA = "0x187BB41E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4240", Offset = "0x7BB3640", VA = "0x187BB4240")]
	public void IAGEDJMCMMO(NIJEJPONOEO JNKHIFDIKGK, int EDGAJGKDDBL, int NHKONNPHPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class EKCDIEBJFCK
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static NIJEJPONOEO HHDPNOBANGH;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<KAFMOCADPGE> BEHAEHPEHLP;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] PEMGOFEAMOI;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool ECMCPNMJJCE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, NIJEJPONOEO> KABBOEFADEH;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, NIJEJPONOEO> JHKAENGOMGD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool MGJIAHLCJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7B30", Offset = "0x7BA6F30", VA = "0x187BA7B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<KAFMOCADPGE> PBGBCCEAJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7970", Offset = "0x7BA6D70", VA = "0x187BA7970")]
		get
		{
			return default(NativeList<KAFMOCADPGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static NIJEJPONOEO JMMIMCHJEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA78D0", Offset = "0x7BA6CD0", VA = "0x187BA78D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7090", Offset = "0x7BA6490", VA = "0x187BA7090")]
	private static void CLGKOKEDEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7060", Offset = "0x7BA6460", VA = "0x187BA7060")]
	public static int CFIOLOEKGBD(bool PECLHCMLFIJ, int EENKAMICPOK, bool IIPJJHHCOJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7A10", Offset = "0x7BA6E10", VA = "0x187BA7A10")]
	private static int IMIGEJNBDFB(int EENKAMICPOK, bool PCLHPHBLNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6FC0", Offset = "0x7BA63C0", VA = "0x187BA6FC0")]
	private static int BGDGMKNIDJN(int EENKAMICPOK, bool PCLHPHBLNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6FD0", Offset = "0x7BA63D0", VA = "0x187BA6FD0")]
	public static int BLPDKNAIFFD(int BKCGKLBAHGO, int EENKAMICPOK, int BHOHOPOLACN, bool PCLHPHBLNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7BA76A0", Offset = "0x7BA6AA0", VA = "0x187BA76A0")]
	public static int DMKFLAGJLKG(int BKCGKLBAHGO, int EENKAMICPOK, int BHOHOPOLACN, bool PCLHPHBLNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8050", Offset = "0x7BA7450", VA = "0x187BA8050")]
	public static int PHEMFBEDBHB(int BHOHOPOLACN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7B20", Offset = "0x7BA6F20", VA = "0x187BA7B20")]
	private static int MBMFIIOPJHD(int EENKAMICPOK, bool PCLHPHBLNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8030", Offset = "0x7BA7430", VA = "0x187BA8030")]
	private static int ONINEODIFAD(int EENKAMICPOK, bool PCLHPHBLNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7BB0", Offset = "0x7BA6FB0", VA = "0x187BA7BB0")]
	public static int MPEIAELOKMA(int BKCGKLBAHGO, int EENKAMICPOK, int BHOHOPOLACN, bool PCLHPHBLNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7820", Offset = "0x7BA6C20", VA = "0x187BA7820")]
	public static int GGJIDIILGCN(int BKCGKLBAHGO, int EENKAMICPOK, int BHOHOPOLACN, bool PCLHPHBLNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7BA78B0", Offset = "0x7BA6CB0", VA = "0x187BA78B0")]
	public static int HHDEOEHOELL(int BHOHOPOLACN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7730", Offset = "0x7BA6B30", VA = "0x187BA7730")]
	public static NIJEJPONOEO FLDPDNENGMC(int EENKAMICPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6D30", Offset = "0x7BA6130", VA = "0x187BA6D30")]
	private static NIJEJPONOEO BDMIILOPHCM(int EENKAMICPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7A30", Offset = "0x7BA6E30", VA = "0x187BA7A30")]
	public static NIJEJPONOEO INJPENAPHJE(int EENKAMICPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA69F0", Offset = "0x7BA5DF0", VA = "0x187BA69F0")]
	private static NIJEJPONOEO AJAKAGAAOCF(int EENKAMICPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7C20", Offset = "0x7BA7020", VA = "0x187BA7C20")]
	public static void NPALAMLGMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct LGJKLCBBIPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int FJCPMDKDJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 IEHPCDHCOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion CAPOFJPNGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float OAFFIMHOGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float MOADGMPEBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int KGJJNNOKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int GCPEOPHCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int JAMPKJBPKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool CDAHAFGIMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool LOKJIBOOKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float KPHDBNLAJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 KMCBJFDCGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool PNJCBEKMLBI;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct PENNCBILPHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int IKBOKHFOAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int MAKPDFHDIMH;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct NPEEJPEHNJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<LGJKLCBBIPI> FEPKHNBOAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<KOLCMGJNCCI> DEIBAMKJCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<KAFMOCADPGE> BBMCIFMGKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<PENNCBILPHD> PMCOOHGBLJP;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4750", Offset = "0x7BB3B50", VA = "0x187BB4750")]
	public NPEEJPEHNJE(NativeArray<KOLCMGJNCCI> DEIBAMKJCFE, int LLBNOFGPNDN = 1, Allocator LMMGDELCIGC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4660", Offset = "0x7BB3A60", VA = "0x187BB4660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct EDCCPPONIAG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<FCAALAJOLFC> AMJFGOLFPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> OHDFEHEPIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<KAFMOCADPGE> GGELHADMANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<LGJKLCBBIPI> FEPKHNBOAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<KOLCMGJNCCI> DEIBAMKJCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<KAFMOCADPGE> BBMCIFMGKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<PENNCBILPHD> PMCOOHGBLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int AFCBBDNCPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int EFHBBPJFPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 LKBMNINFLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion AFAOJDCBNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 HOMKJMPCAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FFPHPCKMNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BOPGFAEJPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GNMFMEFEMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DIGIGIHNPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EBBBKALAHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CNDFEDGKJBJ;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BA62A0", Offset = "0x7BA56A0", VA = "0x187BA62A0")]
	public EDCCPPONIAG(PLFGDBMHKGH FJPHMCFGACL, EFFDIJJLADK PIACFBNMBOO, float3 CEBLHBHBMNI, quaternion ICDBNPIFBDG, float CNIKGFLOMHO, int ELIJOEMDBIP = 0, int BOLDLBFIMGF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6070", Offset = "0x7BA5470", VA = "0x187BA6070")]
	public EDCCPPONIAG(NPEEJPEHNJE FJPHMCFGACL, EFFDIJJLADK PIACFBNMBOO, float3 CEBLHBHBMNI, quaternion ICDBNPIFBDG, float3 CNIKGFLOMHO, int ELIJOEMDBIP = 0, int BOLDLBFIMGF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BA54F0", Offset = "0x7BA48F0", VA = "0x187BA54F0")]
	private float3 FAPOGHEGJNF(float3 ENOJABGJICG, Matrix4x4 LLGHHDBNBKA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5630", Offset = "0x7BA4A30", VA = "0x187BA5630")]
	private float3x3 FKIGPKFGBLN(float3x3 JPIAJJPAGFD, float3x3 JEFEPIMDEDB)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4340", Offset = "0x7BA3740", VA = "0x187BA4340")]
	private float EEMPHOAFHDO(float KPABPLHPKDL, float MHLNPGFMNGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4350", Offset = "0x7BA3750", VA = "0x187BA4350", Slot = "4")]
	public void Execute(int MLHFFBNEEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA41D0", Offset = "0x7BA35D0", VA = "0x187BA41D0")]
	private void DDJIENEBHOL(int FPEMKJKOCNN, float3 KBPOHLLNAIG, float3 KBGACFDBMJG, float3 KIEOKDMFIGP, float PPFBOIIFNHM, bool DNFBNHFNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5C30", Offset = "0x7BA5030", VA = "0x187BA5C30")]
	private void MCIPPIKFAHI(LGJKLCBBIPI KLBEKOEMEID, float3 EIODCDKJBOE, float3x3 PNMIEECLPJC, float KPABPLHPKDL, int CCBNIPJGPCA, int OBOBOJJHLJP, int EGGCIGEKAOJ, float LIJHIMPDKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BA56B0", Offset = "0x7BA4AB0", VA = "0x187BA56B0")]
	private void LINDMAGLFBO(int FPEMKJKOCNN, int BIJJBKNGFFP, LGJKLCBBIPI KLBEKOEMEID, float3 EIODCDKJBOE, float3x3 PNMIEECLPJC, bool FMGJBEHGNLP, float KPABPLHPKDL, int LFEMJEADMNG, int GDIHOJEFEPO, int EGGCIGEKAOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct EAKADENKGMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<BAEOIAALKDM> MFAMAMJDHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<KAFMOCADPGE> FKKCOCCMPPG;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BA34B0", Offset = "0x7BA28B0", VA = "0x187BA34B0")]
	public EAKADENKGMG(int LLBNOFGPNDN, Allocator LMMGDELCIGC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3410", Offset = "0x7BA2810", VA = "0x187BA3410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct HLIEADGNECB : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum DDMPPFPMMGH
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
	private NativeList<float3> EMFMFKBMOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> KFGBNHLDODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> EDDADEHIMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> CLLJMOMLIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> NFGKEDGIGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> MHJJLPKMBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> GLJPHOIBJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> PDAIGFEFCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> FNPICDACBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<KAFMOCADPGE> EINGPFKKCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<BAEOIAALKDM> MFAMAMJDHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<KAFMOCADPGE> FKKCOCCMPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int AFCBBDNCPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int EFHBBPJFPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FFPHPCKMNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BOPGFAEJPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GNMFMEFEMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DIGIGIHNPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EBBBKALAHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NFENAGOJNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CNDFEDGKJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 HOMKJMPCAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion AFAOJDCBNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 LKBMNINFLJH;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7BADDC0", Offset = "0x7BAD1C0", VA = "0x187BADDC0")]
	public HLIEADGNECB(PLFGDBMHKGH FJPHMCFGACL, EFFDIJJLADK PIACFBNMBOO, NativeArray<int> BMMMFEGPMPO, float3 CEBLHBHBMNI, quaternion ICDBNPIFBDG, float CNIKGFLOMHO, int ELIJOEMDBIP = 0, int BOLDLBFIMGF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7BADBB0", Offset = "0x7BACFB0", VA = "0x187BADBB0")]
	public HLIEADGNECB(EAKADENKGMG AOFGGGKINCN, EFFDIJJLADK PIACFBNMBOO, NativeArray<int> BMMMFEGPMPO, float3 CEBLHBHBMNI, quaternion ICDBNPIFBDG, float3 CNIKGFLOMHO, int ELIJOEMDBIP = 0, int BOLDLBFIMGF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC750", Offset = "0x7BABB50", VA = "0x187BAC750", Slot = "4")]
	public void Execute(int MLHFFBNEEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7BAD700", Offset = "0x7BACB00", VA = "0x187BAD700")]
	private void IMOPJMJKHBC(float4x4 IKNALLCGPLO, int MLHFFBNEEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7BADB40", Offset = "0x7BACF40", VA = "0x187BADB40")]
	private DDMPPFPMMGH ONBAMMKFGON(float3 KBGACFDBMJG)
	{
		return default(DDMPPFPMMGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7BADAB0", Offset = "0x7BACEB0", VA = "0x187BADAB0")]
	private float4 KFBNDCOKFLP(DDMPPFPMMGH ALCDBFIDEEA, int COPLIEINKOF)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BADB00", Offset = "0x7BACF00", VA = "0x187BADB00")]
	private float2 MMFPDGNCCNO(DDMPPFPMMGH ALCDBFIDEEA, float3 KBPOHLLNAIG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct NGIMKCBCGCA
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum CMDENNANMLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static NGIMKCBCGCA HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 KHAINEMBOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 CNCCLHDGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 JFMOMNOKICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public CMDENNANMLC PLJKCMOLLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 BCBAPIHLGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 OBIIKFKPAOA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool CMMDKLGDPDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BB4070", Offset = "0x7BB3470", VA = "0x187BB4070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 PPFHOKPGGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3860", Offset = "0x7BB2C60", VA = "0x187BB3860")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BB40F0", Offset = "0x7BB34F0", VA = "0x187BB40F0")]
	public NGIMKCBCGCA(float3 KBPOHLLNAIG, quaternion PNEDBEMJDJJ, float3 LLBNOFGPNDN, CMDENNANMLC KHNCICOHHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3BD0", Offset = "0x7BB2FD0", VA = "0x187BB3BD0")]
	public float LPGFOIJPIDF(float3 EIODCDKJBOE, float IFKLGEIGDIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3F80", Offset = "0x7BB3380", VA = "0x187BB3F80")]
	public bool OGIPJMPOICN(float3 KBGACFDBMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3DD0", Offset = "0x7BB31D0", VA = "0x187BB3DD0")]
	public void NOHNGKJHCLA(float3 JNJNMNMBBGF, float3x3 ENIOOGPHGPK, float GJHLGFCGAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3770", Offset = "0x7BB2B70", VA = "0x187BB3770")]
	private void APPGAAACNIL(float3 BCFKCHJBFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3940", Offset = "0x7BB2D40", VA = "0x187BB3940")]
	public void KEGKGPDDAOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct EBOBBOCFCNA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<NGIMKCBCGCA> AOFGGGKINCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> DOPBLIMAAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> JHPGMMOMMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CPNLIKCCNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<KAFMOCADPGE> FKKCOCCMPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int AGHDODANMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int CDFIBNGJPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float IFKLGEIGDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float HBKGEEJELLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> AGMMIDHCLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GMODLCKACKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> CLBNBDLNCJO;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4030", Offset = "0x7BA3430", VA = "0x187BA4030")]
	public EBOBBOCFCNA(EFFDIJJLADK IGPCANDHEAE, float JPLHNKPJPBG, int NHKONNPHPEL, int CCBNIPJGPCA, NativeList<NGIMKCBCGCA> AOFGGGKINCN, NativeArray<int> CPNLIKCCNAM, NativeList<KAFMOCADPGE> FKKCOCCMPPG, JPGCMFCMNLL HAIAJGNFDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3660", Offset = "0x7BA2A60", VA = "0x187BA3660", Slot = "4")]
	public void Execute(int GPBCLOJIMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BA35A0", Offset = "0x7BA29A0", VA = "0x187BA35A0")]
	private bool BIDJBEENHDB(NGIMKCBCGCA EHIMHGHKFCP, NGIMKCBCGCA MDCPFJBHOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3DA0", Offset = "0x7BA31A0", VA = "0x187BA3DA0")]
	private bool POEGNIJEAEI(NGIMKCBCGCA IICPBKFBAIN, int LHHIJCJHPOM, int JAKFILMJLFF, int LJADBHDNBDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct AEFCBPPONGG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<BEKGKNHPJKN.FGMMJCICOHA> DHAJBLOBBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> CIOMPDICBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int ELIJOEMDBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int BOLDLBFIMGF;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1290", Offset = "0x7BA0690", VA = "0x187BA1290")]
	public AEFCBPPONGG(NativeList<BEKGKNHPJKN.FGMMJCICOHA> DHAJBLOBBGG, NativeArray<int> CIOMPDICBCD, int BOLDLBFIMGF = 0, int ELIJOEMDBIP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BA11E0", Offset = "0x7BA05E0", VA = "0x187BA11E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class JPGCMFCMNLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> JPCAGIPEHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> AMNBMGGLEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> NLAGKPDDNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> MFAOBKCEHHI;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BAEA50", Offset = "0x7BADE50", VA = "0x187BAEA50")]
	public void NLNPPHKFKKL(int MIJFEJOJGGN, int OBALFOMMEDB, Allocator LMMGDELCIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BAE940", Offset = "0x7BADD40", VA = "0x187BAE940")]
	public static long CCLJGAGHGCB(int MIJFEJOJGGN, int OBALFOMMEDB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BAE960", Offset = "0x7BADD60", VA = "0x187BAE960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BAE850", Offset = "0x7BADC50", VA = "0x187BAE850")]
	public void BKMLDGFOOLL(JobHandle KAKLANICLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public JPGCMFCMNLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct EJGPPDGOPAA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> DOPBLIMAAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> OJBFBCFKCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> FBPFHNCEAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> PDDIIOMKKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> JHPGMMOMMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JDKPOCGANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> HAPNJOBGBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> AGMMIDHCLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> GMODLCKACKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int ELIJOEMDBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int BOLDLBFIMGF;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6970", Offset = "0x7BA5D70", VA = "0x187BA6970")]
	public EJGPPDGOPAA(EFFDIJJLADK IGPCANDHEAE, JPGCMFCMNLL HAIAJGNFDBG, int BOLDLBFIMGF = 0, int ELIJOEMDBIP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6530", Offset = "0x7BA5930", VA = "0x187BA6530", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6910", Offset = "0x7BA5D10", VA = "0x187BA6910")]
	private void IPPOOFGDKDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class LNODEKLJEIH
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x37A52D0", Offset = "0x37A46D0", VA = "0x1837A52D0")]
	public static bool DHHGMNKGLKI<T>(NativeArray<T> IMLJIFPAFGH, int LLBNOFGPNDN, Allocator LMMGDELCIGC, NativeArrayOptions EEANHGMNGAI = NativeArrayOptions.ClearMemory, int PJAHKPHBJCG = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x37A55A0", Offset = "0x37A49A0", VA = "0x1837A55A0")]
	public static bool DHHGMNKGLKI<T>(NativeList<T> ANHMDLEGCDL, int LLBNOFGPNDN, Allocator LMMGDELCIGC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x37A5510", Offset = "0x37A4910", VA = "0x1837A5510")]
	public static bool DHHGMNKGLKI<T>(NativeQueue<T> LGKOBMEJHMC, Allocator LMMGDELCIGC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum CHLDBBPIOBG
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
public interface CFLAAKGBDND
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DEOHHHGPPCC(CHLDBBPIOBG BKCGKLBAHGO);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HIMJGIFAKHM(CHLDBBPIOBG BKCGKLBAHGO);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODMOBPPJDNA NAFKPJBGCFH();

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float KFAJNCDDLMA();

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DILFBCDDEDM(CHLDBBPIOBG BKCGKLBAHGO, PLFGDBMHKGH CADNALAJDNJ, int NCCKAFKAJGC = -1);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int NCFLKLFENOH(int MLCOPMLJPKI);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class IFCEILOHBHM
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BADFD0", Offset = "0x7BAD3D0", VA = "0x187BADFD0")]
	public static void NPALAMLGMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class AMADKAACINB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> ADDMDCBIMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> KDOFENDCMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> EOOPNHDDEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> HGEEFOACFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> MNNHCBAFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> IAGJIHCHJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> IOBGDJNDLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> FBGCLBJFIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> HPPJMLBEDKF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HBNBJNMIHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2180", Offset = "0x7BA1580", VA = "0x187BA2180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JCPPNAIFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA18A0", Offset = "0x7BA0CA0", VA = "0x187BA18A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int MOCJILLDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1860", Offset = "0x7BA0C60", VA = "0x187BA1860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2520", Offset = "0x7BA1920", VA = "0x187BA2520")]
	public AMADKAACINB(int MIJFEJOJGGN, int OBALFOMMEDB, int BJICDCMBCGO, Allocator LMMGDELCIGC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA21C0", Offset = "0x7BA15C0", VA = "0x187BA21C0")]
	public AMADKAACINB(Mesh IGPCANDHEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BA12B0", Offset = "0x7BA06B0", VA = "0x187BA12B0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BA18E0", Offset = "0x7BA0CE0", VA = "0x187BA18E0")]
	public void IAGEDJMCMMO(AMADKAACINB IGPCANDHEAE, bool IEDBIMEGPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7BA13D0", Offset = "0x7BA07D0", VA = "0x187BA13D0")]
	private void EAHAHDCNNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1C10", Offset = "0x7BA1010", VA = "0x187BA1C10")]
	private void KMCHLMNEEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct KAFMOCADPGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int AJHKLCGCFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int HBNBJNMIHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int GBIOAOEFIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int JCPPNAIFGGC;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1EB83D0", Offset = "0x1EB77D0", VA = "0x181EB83D0")]
	public KAFMOCADPGE(int CCBNIPJGPCA, int DMCCFBNGLAK, int NHKONNPHPEL, int DKFOONNFLLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class NCHCFNFMMPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<KAFMOCADPGE> LJDDHJAOJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<KAFMOCADPGE>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xEFF440", Offset = "0xEFE840", VA = "0x180EFF440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AMADKAACINB FGNNOJBFLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BB31A0", Offset = "0x7BB25A0", VA = "0x187BB31A0")]
	public NCHCFNFMMPI(IEnumerable<AMADKAACINB> GKNMEGNOFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3130", Offset = "0x7BB2530", VA = "0x187BB3130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum ECCJBFKFHGL
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class ACHCJENGLFA
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> HBFGDILMDGN;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> ANKLGCDKCBM;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> KNAAHODLLLI;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> ODEJHOCJHOJ;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9F90", Offset = "0x7BB9390", VA = "0x187BB9F90")]
	public static void NPALAMLGMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9C60", Offset = "0x7BB9060", VA = "0x187BB9C60")]
	public static NativeArray<float2> HDKEGOEIIFH(NativeArray<float2> PPDMHPNCAPI, int MOCEFGIJDLH, NativeArray<float2> GIMPKBBBFGP, int FIJMLCMJGBG)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9B50", Offset = "0x7BB8F50", VA = "0x187BB9B50")]
	public static NativeArray<float3> DODKHNPLLCC(NativeArray<float3> PPDMHPNCAPI, int MOCEFGIJDLH, NativeArray<float3> GIMPKBBBFGP, int FIJMLCMJGBG)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9D70", Offset = "0x7BB9170", VA = "0x187BB9D70")]
	public static NativeArray<float4> KFJLGHEGMOM(NativeArray<float4> PPDMHPNCAPI, int MOCEFGIJDLH, NativeArray<float4> GIMPKBBBFGP, int FIJMLCMJGBG)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9E80", Offset = "0x7BB9280", VA = "0x187BB9E80")]
	public static NativeArray<int> MJBKFOBEPJK(NativeArray<int> PPDMHPNCAPI, int MOCEFGIJDLH, NativeArray<int> GIMPKBBBFGP, int FIJMLCMJGBG)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3E45290", Offset = "0x3E44690", VA = "0x183E45290")]
	private static void IJCEFMBJEOK<T>(NativeArray<T> IMLJIFPAFGH, int KAHCHODPEBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3E45490", Offset = "0x3E44890", VA = "0x183E45490")]
	private static void KFDOMPIMOBJ<T>(NativeArray<T> PPDMHPNCAPI, int MOCEFGIJDLH, NativeArray<T> GIMPKBBBFGP, int FIJMLCMJGBG, NativeArray<T> MGONOJEBBDH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class KENOLEMODBA
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct PDFHINIBIOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort COBPEJEHIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort CEJJJCAALLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort CHKEBKHPLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort NLCCEEFCPFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDF90", Offset = "0x7BCD390", VA = "0x187BCDF90")]
	public static uint EAADFJDCHNK(float KNEFMJBNMOP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE070", Offset = "0x7BCD470", VA = "0x187BCE070")]
	public static void FOBPLKIKFKL(float4 FBPFHNCEAKL, float AGNOEKCGKLI, [Out] uint IKHLJHFKOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDFA0", Offset = "0x7BCD3A0", VA = "0x187BCDFA0")]
	public static void FOBPLKIKFKL(float4 FBPFHNCEAKL, uint AMJBCDKPCBP, [Out] uint IKHLJHFKOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE230", Offset = "0x7BCD630", VA = "0x187BCE230")]
	public static void NEJJBILGBBK(float3 CCIABAEBMFB, float3 OIFLJIMCICH, float4 KKADJLOIPPN, float2 ODBEDFLMPIE, float4 FBPFHNCEAKL, [Out] EFFDIJJLADK.MIPCNMIEFPJ IDINKBEHANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE480", Offset = "0x7BCD880", VA = "0x187BCE480")]
	public static void NEJJBILGBBK(float3 CCIABAEBMFB, float3 OIFLJIMCICH, float4 KKADJLOIPPN, float2 ODBEDFLMPIE, float4 FBPFHNCEAKL, [Out] EFFDIJJLADK.IEIAPPJHLKP IDINKBEHANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDF40", Offset = "0x7BCD340", VA = "0x187BCDF40")]
	public static byte BMPFOJHKONC(float OOEMJLHLIHJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE6E0", Offset = "0x7BCDAE0", VA = "0x187BCE6E0")]
	public static ushort PDEALIBAFLB(float OOEMJLHLIHJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE200", Offset = "0x7BCD600", VA = "0x187BCE200")]
	public static uint LPNCGELCJEO(float OOEMJLHLIHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE180", Offset = "0x7BCD580", VA = "0x187BCE180")]
	public static float2 IKLOOHENPDN(float2 LLEKGMDPLMK)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDC90", Offset = "0x7BCD090", VA = "0x187BCDC90")]
	public static float2 AFLPGMGBBNO(float3 LDMILEIDPGI)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE730", Offset = "0x7BCDB30", VA = "0x187BCE730")]
	public static void PKHPNIDKPDF(float3 OOEMJLHLIHJ, [Out] float3 HGIOCPFIJDB, [Out] uint3 NLCCEEFCPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDDE0", Offset = "0x7BCD1E0", VA = "0x187BCDDE0")]
	public static PDFHINIBIOI ANJIPPPNPKH(float3 KBPOHLLNAIG)
	{
		return default(PDFHINIBIOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class GCMKIFFOOEL
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker PLFJEBEOLHJ;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float CGINLCABIJK;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void MFKPHJHPJOJ(bool CIKDCLHCJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD4D0", Offset = "0x7BCC8D0", VA = "0x187BCD4D0")]
	public static float AKLNDFMDJLE(float MDDGBGOJKJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD5E0", Offset = "0x7BCC9E0", VA = "0x187BCD5E0")]
	public static long GIOBPNHAMEO(float MDDGBGOJKJD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD6D0", Offset = "0x7BCCAD0", VA = "0x187BCD6D0")]
	public static void PJMCJLCELHH(float MDDGBGOJKJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface LOKEFALDLNP
{
	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJMCJLCELHH(float POOBFJJNMHP);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) BGMIKLGEJLL(float DNAPNGNCMDH);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class EIGJBNOOFHE
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public enum FKBLDPNBIIK
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
	private struct GMCKEMEJHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public FKBLDPNBIIK KHNCICOHHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public float CBJBMBLMJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public BatchedMeshRenderer ODEJLENKHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public DEOBLNBIOLA NJELLLNBKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public BEKGKNHPJKN EIDLPPBGLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public long APMAFPHCINE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public long HONLCBEPECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public float OPHAAOIDGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public bool CEKDCMCINIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public bool PILFJOAMHAN;
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int ELHBBKONGME;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int GHLJLJJPBAI;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int FFLPAKBDFAA;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long NPLMIEIEAEN;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long KJMEKOHKFBK;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long PDMCHGNFKGK;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long KPMMBALPOOA;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int IEPHIGGHAFD;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float HPHGOFPGPOI;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool DBCDFCDGCKE;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int BIJJLAOOAKB;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int CCHLFGBJCLK;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int DNIOINPMLNI;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long LGAGBFGGPIK;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int FDLKKCEPGOE;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool HCGHKFOGPDK;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static List<GMCKEMEJHAE> JFAOAPJJJIH;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static LOKEFALDLNP IHIPIBHPEFD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool PGLELGGEAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9980", Offset = "0x7BC8D80", VA = "0x187BC9980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void LFNJEAECIKM(bool CIKDCLHCJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void MFKPHJHPJOJ(bool CIKDCLHCJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void LFNJEAECIKM(bool CIKDCLHCJFN, string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA7A0", Offset = "0x7BC9BA0", VA = "0x187BCA7A0")]
	public static void NMPEKOJJAMH(LOKEFALDLNP EINBBCFFGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA100", Offset = "0x7BC9500", VA = "0x187BCA100")]
	public static (long, long, long, int, int) JLGPPJNLJEL(long PIBDMCCBHPA)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7BC99D0", Offset = "0x7BC8DD0", VA = "0x187BC99D0")]
	public static void BNGHGDFOJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAC40", Offset = "0x7BCA040", VA = "0x187BCAC40")]
	public static void PJMCJLCELHH(long PIBDMCCBHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9AD0", Offset = "0x7BC8ED0", VA = "0x187BC9AD0")]
	public static void DJINNAOJPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA9D0", Offset = "0x7BC9DD0", VA = "0x187BCA9D0")]
	public static long PEPDIFHGIMB(long MFIBEBBLNDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA3D0", Offset = "0x7BC97D0", VA = "0x187BCA3D0")]
	public static bool KJEKICDCKMN(long BPEFJMAKEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA030", Offset = "0x7BC9430", VA = "0x187BCA030")]
	public static bool IDCGKDKCDIJ(long BPEFJMAKEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9210", Offset = "0x7BC8610", VA = "0x187BC9210")]
	public static float AGAFPDEPFKL(long OOEFKIOENGM, int EPEALGEAION)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9570", Offset = "0x7BC8970", VA = "0x187BC9570")]
	public static (long, long, int) BGMIKLGEJLL(float MDDGBGOJKJD)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9CF0", Offset = "0x7BC90F0", VA = "0x187BC9CF0")]
	public static void ECLFEJMFALH(BEKGKNHPJKN EIDLPPBGLOI, BatchedMeshRenderer ODEJLENKHND, long MIFNJFELGGN, long HONLCBEPECH, float ADJDFFFPBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9B70", Offset = "0x7BC8F70", VA = "0x187BC9B70")]
	public static void DPIKCPIGEIL(BEKGKNHPJKN EIDLPPBGLOI, BatchedMeshRenderer ODEJLENKHND, long MIFNJFELGGN, long HONLCBEPECH, float EMNILILKKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA810", Offset = "0x7BC9C10", VA = "0x187BCA810")]
	public static void OOAECPFHADJ(BEKGKNHPJKN EIDLPPBGLOI, BatchedMeshRenderer ODEJLENKHND, long HONLCBEPECH, float EMNILILKKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9E80", Offset = "0x7BC9280", VA = "0x187BC9E80")]
	public static void GADBNOEMAFG(BEKGKNHPJKN EIDLPPBGLOI, BatchedMeshRenderer ODEJLENKHND, long MIFNJFELGGN, long HONLCBEPECH, float EMNILILKKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA4A0", Offset = "0x7BC98A0", VA = "0x187BCA4A0")]
	public static void MJKCKAHNONC(FKBLDPNBIIK KHNCICOHHHJ, BEKGKNHPJKN EIDLPPBGLOI, DEOBLNBIOLA NJELLLNBKBE, BatchedMeshRenderer ODEJLENKHND, long MIFNJFELGGN, long HONLCBEPECH, float GJAMJBAGCAG, bool CEKDCMCINIF, bool PILFJOAMHAN, float CBJBMBLMJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAB80", Offset = "0x7BC9F80", VA = "0x187BCAB80")]
	public static bool PJFIBKFJBJI(float NOEPBFLDELK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9A50", Offset = "0x7BC8E50", VA = "0x187BC9A50")]
	public static void CEGJOKBGLGH(float NOEPBFLDELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA2C0", Offset = "0x7BC96C0", VA = "0x187BCA2C0")]
	public static bool KAOMBCDBLDC(float NOEPBFLDELK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class DEOBLNBIOLA
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal enum HALMOEAGOPC
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
	public static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly string JDOIKLCAEFP;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly string IJHFNIILKJI;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly ProfilerMarker LDEKNDPKOKF;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static readonly ProfilerMarker CGLMPFCGCDM;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static readonly ProfilerMarker PLFJEBEOLHJ;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private static readonly ProfilerMarker ALGBBJFPDLA;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly ProfilerMarker EJADAHHBCPH;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly ProfilerMarker OMBEJPCLLGK;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly ProfilerMarker ACCFEFMMGBD;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly ProfilerMarker HGAKFCJBHGE;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly ProfilerMarker BOGMFJCGPJJ;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ProfilerMarker FIENBOCIFPP;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly ProfilerMarker EOIIDADHCIP;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly ProfilerMarker MDFBMFEOMBA;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly ProfilerMarker FBDNFMEIHII;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly ProfilerMarker BNBAONCMCOL;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker FMMNPPABNMB;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker KLHCAJDDJLJ;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker IMGEOIHGIIF;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker HJIICPIHKKJ;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker GAEBCNAKDPO;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker KGACAEPAPDL;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker ONABFBHDPNG;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker FOAAPNIGIPL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker HNEBNBFLLKL;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker NMCNIGMPBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	internal readonly List<BEKGKNHPJKN> BGMAJCHFMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal BEKGKNHPJKN KHIPOBCFHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly FMDNBBJKFJO JPMMFKENECK;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const bool KMNLECGGCCH = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public bool GEPKGIMAHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal HALMOEAGOPC BDBOLKCPBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal int KLMCPFIHEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	internal int DHEBOKDFNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	internal int BEMGMMNKIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	internal int LPBHNDPEBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal long ECMPOPBDGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	internal long LPIEGAONJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	internal long PLOEGHBMPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private EFFDIJJLADK KPKEFCONEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private EFFDIJJLADK EHNHCMPDNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private EFFDIJJLADK.OLOGDNNFPLF EJGMMHHENMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private bool CNPBGMDMHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private int BGKOLFAACLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private BBNPNLEPAGD DFGPBBLKIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private float3 NBCBOFDONIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private float ELGBKFMKEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private float JEMFCEHCHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private float AKNJGDDKPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private float LFJHCJPJGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private float CFIEPBNPIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private float AHGNGLKHDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private float3 MAPNBEAJPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private float MALEBFDCKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private float LAINCIGMLDI;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal Mesh FGNNOJBFLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshFilter ALNFDPPGHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MeshRenderer PELIMMAELHO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public List<Material> CFKMJMAFLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9C9240", Offset = "0x9C8640", VA = "0x1809C9240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HPHMDOCIBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7BC78A0", Offset = "0x7BC6CA0", VA = "0x187BC78A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int BMKCDLBEPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xD37CA0", Offset = "0xD370A0", VA = "0x180D37CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int HBNBJNMIHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6F70", Offset = "0x7BC6370", VA = "0x187BC6F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7A20", Offset = "0x7BC6E20", VA = "0x187BC7A20")]
	public void OHOOMHKPJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4B80", Offset = "0x7BC3F80", VA = "0x187BC4B80")]
	public bool CODMPGCBAPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5A90", Offset = "0x7BC4E90", VA = "0x187BC5A90")]
	private void FPAALONAEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6A90", Offset = "0x7BC5E90", VA = "0x187BC6A90")]
	private void IMBMLDCJLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9070", Offset = "0x7BC8470", VA = "0x187BC9070")]
	public DEOBLNBIOLA(string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4770", Offset = "0x7BC3B70", VA = "0x187BC4770")]
	public void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7BC88E0", Offset = "0x7BC7CE0", VA = "0x187BC88E0")]
	private void PMNHAGHPJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7BC51A0", Offset = "0x7BC45A0", VA = "0x187BC51A0")]
	private void DLOBHLOLIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6EE0", Offset = "0x7BC62E0", VA = "0x187BC6EE0")]
	public Mesh LADIGALLLNN(MeshFilter DEENNNHIHBM, Transform NIBJBBEPHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC53B0", Offset = "0x7BC47B0", VA = "0x187BC53B0")]
	private void DMPLLAEMKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5DE0", Offset = "0x7BC51E0", VA = "0x187BC5DE0")]
	public void GGEOCDKAPLP(CFLAAKGBDND KAJGCGBNFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4AB0", Offset = "0x7BC3EB0", VA = "0x187BC4AB0")]
	public bool BNAFNMGHAAD(CFLAAKGBDND KAJGCGBNFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6080", Offset = "0x7BC5480", VA = "0x187BC6080")]
	public bool HEMHPGJLPIO(CFLAAKGBDND KAJGCGBNFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5BB0", Offset = "0x7BC4FB0", VA = "0x187BC5BB0", Slot = "4")]
	public virtual void GELKPOGLHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4EA0", Offset = "0x7BC42A0", VA = "0x187BC4EA0")]
	public void DGPDBACCJFI(Transform GJLNIFCNLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7BC40B0", Offset = "0x7BC34B0", VA = "0x187BC40B0")]
	public bool AICMDOPKCPC(Transform GJLNIFCNLDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5550", Offset = "0x7BC4950", VA = "0x187BC5550")]
	public bool ENKCFNBPHEC(bool DLIKAMNKCGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7BC46F0", Offset = "0x7BC3AF0", VA = "0x187BC46F0")]
	private void BGNJJEDECAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7E50", Offset = "0x7BC7250", VA = "0x187BC7E50")]
	public bool PJMCJLCELHH(float4x4 FBLOEBGKBDO, BatchedMeshRenderer BHLIMBJLMEA, bool DHMNKJINLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7390", Offset = "0x7BC6790", VA = "0x187BC7390")]
	public bool MAIPGJPKAIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7BC79E0", Offset = "0x7BC6DE0", VA = "0x187BC79E0")]
	public void MPILGEPKOBG(EFFDIJJLADK IGPCANDHEAE, int HKJGODCBKLL, int CDHNFJKKFIA, float NDIOHPPFMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6BE0", Offset = "0x7BC5FE0", VA = "0x187BC6BE0")]
	public (long, long, long) IPOELGFFMMG()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x9CD7D0", Offset = "0x9CCBD0", VA = "0x1809CD7D0")]
	public long HNPPEDGKPHN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC78C0", Offset = "0x7BC6CC0", VA = "0x187BC78C0")]
	private void MHKJBAMGLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4480", Offset = "0x7BC3880", VA = "0x187BC4480")]
	public (long, long, int) BGMIKLGEJLL(float MDDGBGOJKJD, float4x4 FBLOEBGKBDO)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5F20", Offset = "0x7BC5320", VA = "0x187BC5F20")]
	internal void GLNMPHBEEFK(HALMOEAGOPC FLJBAOHEIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6110", Offset = "0x7BC5510", VA = "0x187BC6110")]
	internal (float, float, float, float) IFDLFFMEGFL(float HKPJDBCCLPB, float4x4 FBLOEBGKBDO)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6C60", Offset = "0x7BC6060", VA = "0x187BC6C60")]
	public void JPIJHBIFBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4CA0", Offset = "0x7BC40A0", VA = "0x187BC4CA0")]
	private void DBLNDHMPCCO(EFFDIJJLADK HOBKNFJNEEB, EFFDIJJLADK.OLOGDNNFPLF KGJMMDBONJF, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B50", Offset = "0x7BC6F50", VA = "0x187BC7B50")]
	private void OIABGECAJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5CD0", Offset = "0x7BC50D0", VA = "0x187BC5CD0")]
	internal bool GELMBHPLANL(bool DLIKAMNKCGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6800", Offset = "0x7BC5C00", VA = "0x187BC6800")]
	private void IGNJCDFBBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6FA0", Offset = "0x7BC63A0", VA = "0x187BC6FA0")]
	private void LPOLJGNJOCM([In] LMKBCHBJNON HOBKNFJNEEB, EFFDIJJLADK.OLOGDNNFPLF KGJMMDBONJF, bool FLBNDMMOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7BC54B0", Offset = "0x7BC48B0", VA = "0x187BC54B0")]
	private void EEIDOGNJBKK(EFFDIJJLADK.OLOGDNNFPLF KGJMMDBONJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6E40", Offset = "0x7BC6240", VA = "0x187BC6E40")]
	private void JPPKKMCMFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5F40", Offset = "0x7BC5340", VA = "0x187BC5F40")]
	private void HCAMDLCPHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B70", Offset = "0x7BC6F70", VA = "0x187BC7B70")]
	public long PEPDIFHGIMB(long MFIBEBBLNDD, int PBPGJOODABO)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class BEKGKNHPJKN
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	internal enum PEIJEKIPENJ
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
	public struct FGMMJCICOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int GKCLMOEIPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public int BJFBLFCILOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public float HFNOFBJMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public struct KMDNENFINHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public LMKBCHBJNON IGPCANDHEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int HLNLLJCCGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int MDAKNFDLHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public long CEIKKOJJEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public long NEKHJOJFJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public float KOCDAMPGNBI;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE990", Offset = "0x7BCDD90", VA = "0x187BCE990")]
		public void HGEPFBBIJLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE910", Offset = "0x7BCDD10", VA = "0x187BCE910")]
		public void BKMLDGFOOLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private static readonly string JDOIKLCAEFP;

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private static readonly string IJHFNIILKJI;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private static readonly ProfilerMarker LDEKNDPKOKF;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private static readonly ProfilerMarker CGLMPFCGCDM;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private static readonly ProfilerMarker PLFJEBEOLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private static readonly ProfilerMarker ALGBBJFPDLA;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private static readonly ProfilerMarker EJADAHHBCPH;

	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private static readonly ProfilerMarker OMBEJPCLLGK;

	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private static readonly ProfilerMarker ACCFEFMMGBD;

	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private static readonly ProfilerMarker HGAKFCJBHGE;

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private static readonly ProfilerMarker BOGMFJCGPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly ProfilerMarker FIENBOCIFPP;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly ProfilerMarker EOIIDADHCIP;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly ProfilerMarker MDFBMFEOMBA;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly ProfilerMarker FBDNFMEIHII;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly ProfilerMarker BNBAONCMCOL;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker FMMNPPABNMB;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker KLHCAJDDJLJ;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker IMGEOIHGIIF;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker HJIICPIHKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker GAEBCNAKDPO;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker KGACAEPAPDL;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker ONABFBHDPNG;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker FOAAPNIGIPL;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker HNEBNBFLLKL;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker NMCNIGMPBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	internal readonly List<CFLAAKGBDND> ILHAEJGFKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	internal DEOBLNBIOLA COAKIMPAGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private readonly FMDNBBJKFJO JPMMFKENECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	internal int KFLFFOEMPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	internal int ILDMDKAEFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	internal bool DIMJKFINBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	internal bool OOHGCFEHFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	internal PEIJEKIPENJ KMOCKNHABFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	internal bool FJLGBJEJNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	internal float3 COHCNEABJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal float3 MLDHBIPDPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal float KFJCAGGCGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal int ADMGOPNPLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal int NLHJDNMEKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal float EKIDIGJGHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal float FFNGCGCMEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	internal int PAIIICMCLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal long FMBIJLKCGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public int ALIJNPOJKEE;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal const int KHJLEBJAAAI = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal float[] IJNNGBBDAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal int[] NGKGGHEPDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal long[] GFJLADIFMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public List<KMDNENFINHH> CJCDDEMODJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal EFFDIJJLADK FNFDDIPHLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal long DGPELIFNOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int FDCICBJBBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal float GOADPNBPLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal EFFDIJJLADK.OLOGDNNFPLF LENEPCOLMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal bool BEIHOMLGHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal ABMMAIBJNCF NLCCFKBDDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal JobHandle GCBNNEEFFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	internal NativeList<FGMMJCICOHA> KJBNLFOJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal NativeArray<long> BCDMMGFJLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal bool NHJAOEKJNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal JobHandle ACNOOOBEKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal EFFDIJJLADK PCCBIPDODAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	internal JPGCMFCMNLL KBGDNEHHMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal NativeList<FGMMJCICOHA> BDMEFDCADAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal Transform JNMBBMKBHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal CHLDBBPIOBG ALNBKJAHGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal long DPLAMKLFIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal long NDHCFLOHMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal long ICDDIHEAIBP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<CFLAAKGBDND> KJOHNJEGHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal int HBNBJNMIHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC09F0", Offset = "0x7BBFDF0", VA = "0x187BC09F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1B00", Offset = "0x7BC0F00", VA = "0x187BC1B00")]
	internal void OHOOMHKPJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDF60", Offset = "0x7BBD360", VA = "0x187BBDF60")]
	internal void FPAALONAEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3D90", Offset = "0x7BC3190", VA = "0x187BC3D90")]
	internal BEKGKNHPJKN(string KCCMEIDBNGP, DEOBLNBIOLA GEFLCBDBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC140", Offset = "0x7BBB540", VA = "0x187BBC140")]
	internal void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD050", Offset = "0x7BBC450", VA = "0x187BBD050")]
	internal void DMPLLAEMKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE1C0", Offset = "0x7BBD5C0", VA = "0x187BBE1C0")]
	internal void GGEOCDKAPLP(CFLAAKGBDND KAJGCGBNFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC290", Offset = "0x7BBB690", VA = "0x187BBC290")]
	internal bool BNAFNMGHAAD(CFLAAKGBDND KAJGCGBNFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE770", Offset = "0x7BBDB70", VA = "0x187BBE770")]
	internal bool HEMHPGJLPIO(CFLAAKGBDND KAJGCGBNFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE130", Offset = "0x7BBD530", VA = "0x187BBE130", Slot = "4")]
	internal virtual void GELKPOGLHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC310", Offset = "0x7BBB710", VA = "0x187BBC310")]
	internal long CJODPCBOKCC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDE40", Offset = "0x7BBD240", VA = "0x187BBDE40")]
	internal long FELHAIBILLF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA0B0", Offset = "0x7BB94B0", VA = "0x187BBA0B0")]
	internal bool AICMDOPKCPC(Transform GJLNIFCNLDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD2E0", Offset = "0x7BBC6E0", VA = "0x187BBD2E0")]
	internal (bool, EFFDIJJLADK) ENKCFNBPHEC(bool DLIKAMNKCGB)
	{
		return default((bool, EFFDIJJLADK));
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB410", Offset = "0x7BBA810", VA = "0x187BBB410")]
	internal void BGNJJEDECAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2250", Offset = "0x7BC1650", VA = "0x187BC2250")]
	internal bool PJMCJLCELHH(float4x4 FBLOEBGKBDO, BatchedMeshRenderer BHLIMBJLMEA, bool DHMNKJINLBC, bool OAMJOPBNEHI, float JEMFCEHCHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0A20", Offset = "0x7BBFE20", VA = "0x187BC0A20")]
	public (bool, LMKBCHBJNON) MAIPGJPKAIH()
	{
		return default((bool, LMKBCHBJNON));
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC3C0", Offset = "0x7BBB7C0", VA = "0x187BBC3C0")]
	internal void DHMLAHGGKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE7D0", Offset = "0x7BBDBD0", VA = "0x187BBE7D0")]
	internal bool HFFDIOMMKJE(bool DLIKAMNKCGB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0A10", Offset = "0x7BBFE10", VA = "0x187BC0A10")]
	internal void MADPGKKMMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1160", Offset = "0x7BC0560", VA = "0x187BC1160")]
	internal void MPILGEPKOBG(EFFDIJJLADK IGPCANDHEAE, int HKJGODCBKLL, int CDHNFJKKFIA, float NDIOHPPFMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBAD10", Offset = "0x7BBA110", VA = "0x187BBAD10")]
	internal void BGJLKPEIEHE(LMKBCHBJNON HNHJJEPNKHF, int HKJGODCBKLL, int CDHNFJKKFIA, float NDIOHPPFMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0D70", Offset = "0x7BC0170", VA = "0x187BC0D70")]
	internal void MHKJBAMGLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7BBAFA0", Offset = "0x7BBA3A0", VA = "0x187BBAFA0")]
	internal (long, long, int) BGMIKLGEJLL(float MDDGBGOJKJD, float4x4 FBLOEBGKBDO)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE400", Offset = "0x7BBD800", VA = "0x187BBE400")]
	internal void GLNMPHBEEFK(PEIJEKIPENJ FLJBAOHEIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7BBEAD0", Offset = "0x7BBDED0", VA = "0x187BBEAD0")]
	internal (float, float, float, float) IFDLFFMEGFL(float HKPJDBCCLPB, float4x4 FBLOEBGKBDO)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF5A0", Offset = "0x7BBE9A0", VA = "0x187BBF5A0")]
	private float IPPNAMEJAHC(float HKPJDBCCLPB, float4x4 FBLOEBGKBDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF600", Offset = "0x7BBEA00", VA = "0x187BBF600")]
	private (int, int) JOGJDIJFAEG(float HAOGGDJBPHC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0940", Offset = "0x7BBFD40", VA = "0x187BC0940")]
	internal static float KCBDNGJAFJD(CFLAAKGBDND IGPCANDHEAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFAC0", Offset = "0x7BBEEC0", VA = "0x187BBFAC0")]
	internal void JPIJHBIFBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0910", Offset = "0x7BBFD10", VA = "0x187BC0910")]
	internal void JPPKKMCMFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE450", Offset = "0x7BBD850", VA = "0x187BBE450")]
	internal void HCAMDLCPHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1B10", Offset = "0x7BC0F10", VA = "0x187BC1B10")]
	internal long PEPDIFHGIMB(long MFIBEBBLNDD, int PBPGJOODABO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC440", Offset = "0x7BBB840", VA = "0x187BBC440")]
	private void DKOLHNPFPIH(EFFDIJJLADK KABMIDMBHHG, NativeList<FGMMJCICOHA> OBEEMFBGKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF1C0", Offset = "0x7BBE5C0", VA = "0x187BBF1C0")]
	internal void IIDGGEOJJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBBAB0", Offset = "0x7BBAEB0", VA = "0x187BBBAB0")]
	public static void BJCILBNMGHA(NativeList<FGMMJCICOHA> MGNHPKFAAFD, EFFDIJJLADK KABMIDMBHHG, int GDJOBKBDFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBEA40", Offset = "0x7BBDE40", VA = "0x187BBEA40")]
	private float IEICIEPBJFO(int IEDEMBGOAMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1190", Offset = "0x7BC0590", VA = "0x187BC1190")]
	internal void NLLLAJLBJIC(EFFDIJJLADK IGPCANDHEAE, JNGLOKEPDKL HNHJJEPNKHF, int HKJGODCBKLL, int CDHNFJKKFIA, float NDIOHPPFMEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[BurstCompile]
internal struct KNLPKJCELJC : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal struct DKGCINFIPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int NCKDMOGMBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int CFGJPKEKKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int JOJMJLHHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public float JALGAJCIALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public float HDCFECCMLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public float AIHOICMELJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public float OPFFIDKJBKL;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	internal struct KCFFGMHHJNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int NCKDMOGMBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int CFGJPKEKKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int JOJMJLHHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int JPIBBBINAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float JALGAJCIALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float HDCFECCMLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public float BIGANBGLHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public float DGKBFGMLBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public float OPFFIDKJBKL;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct NHPEEHMPHJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int MEFFDCLGNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int DGJAFOANCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float JGGGHCNNOAP;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public delegate void PECJAICPBDF(KNLPKJCELJC HNMAAJKFEIE, [In] DKGCINFIPEG BKKGHOIEPMJ);

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal static class AMPOIKMKIBG
	{
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD7130", Offset = "0x7BD6530", VA = "0x187BD7130")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6D30", Offset = "0x7BD6130", VA = "0x187BD6D30")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7BD7080", Offset = "0x7BD6480", VA = "0x187BD7080")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6E90", Offset = "0x7BD6290", VA = "0x187BD6E90")]
		public static void HFGDGIKOIHK(KNLPKJCELJC HNMAAJKFEIE, [In] DKGCINFIPEG BKKGHOIEPMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public delegate void CNEJENCDBGD(KNLPKJCELJC HNMAAJKFEIE, [In] KCFFGMHHJNE FFPCNOIJDIG);

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	internal static class BOALKKMKFHL
	{
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9B80", Offset = "0x7BD8F80", VA = "0x187BD9B80")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9780", Offset = "0x7BD8B80", VA = "0x187BD9780")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9AD0", Offset = "0x7BD8ED0", VA = "0x187BD9AD0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD98E0", Offset = "0x7BD8CE0", VA = "0x187BD98E0")]
		public static void HFGDGIKOIHK(KNLPKJCELJC HNMAAJKFEIE, [In] KCFFGMHHJNE FFPCNOIJDIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public unsafe delegate void JLBEHEOEDOG(UnsafeList<int>* EFOADDKBFDO, UnsafeList<float3>* PPJOBMOIJPM, [NoAlias] float3* KCMOIPPOGKH, [NoAlias] float4* FJMFHLOMKBC, [NoAlias] float2* LKFPHLACODF, [NoAlias] float4* ENMJNKIGJCE, UnsafeList<GJCFOEJAIJH>* ALKDKFDINCD, UnsafeList<int>* MJIFCHHFFGE, UnsafeList<float3>* EFNOCEPCOJB, [NoAlias] float3* HJCMNCPPGGB, [NoAlias] float4* EAKKCDIDMFJ, [NoAlias] float2* FEEGMPGOHBJ, [NoAlias] float4* LIADHGBHCKO, int OBALFOMMEDB, int MIJFEJOJGGN);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class AFEFFPBAHNI
	{
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6C00", Offset = "0x7BD6000", VA = "0x187BD6C00")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7BD66B0", Offset = "0x7BD5AB0", VA = "0x187BD66B0")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6B50", Offset = "0x7BD5F50", VA = "0x187BD6B50")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6810", Offset = "0x7BD5C10", VA = "0x187BD6810")]
		public unsafe static void HFGDGIKOIHK(UnsafeList<int>* EFOADDKBFDO, UnsafeList<float3>* PPJOBMOIJPM, [NoAlias] float3* KCMOIPPOGKH, [NoAlias] float4* FJMFHLOMKBC, [NoAlias] float2* LKFPHLACODF, [NoAlias] float4* ENMJNKIGJCE, UnsafeList<GJCFOEJAIJH>* ALKDKFDINCD, UnsafeList<int>* MJIFCHHFFGE, UnsafeList<float3>* EFNOCEPCOJB, [NoAlias] float3* HJCMNCPPGGB, [NoAlias] float4* EAKKCDIDMFJ, [NoAlias] float2* FEEGMPGOHBJ, [NoAlias] float4* LIADHGBHCKO, int OBALFOMMEDB, int MIJFEJOJGGN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public float3 NBCBOFDONIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public float BJACAEBMLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public float LCGAFIEKECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public float MEEPAALJDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public PHKAAPBHJFB.ECIHGHIDGJP IMGKJOMNAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public bool BAECIACPONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<GJCFOEJAIJH>* ALKDKFDINCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* MJIFCHHFFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<DKGCINFIPEG>* LKLCGGEEJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<DKGCINFIPEG>* ILFNOHDGGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<KCFFGMHHJNE>* DJNKAKPGFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<KCFFGMHHJNE>* LFMGIGNIPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public int FHCFIFEHDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public int HFLNECIGENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public int EFCLENDDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe float3* EFNOCEPCOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe int* MIIIAMJFMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe NHPEEHMPHJA* CCEBDKMCFHH;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF760", Offset = "0x7BCEB60", VA = "0x187BCF760")]
	private static float GHNADJBOCAI([In] KNLPKJCELJC HNMAAJKFEIE, [In] float3 MHBKMCCHECH, float OPFFIDKJBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0790", Offset = "0x7BCFB90", VA = "0x187BD0790")]
	private static int KODPCFKIJCP(KNLPKJCELJC HNMAAJKFEIE, [Out] GJCFOEJAIJH MOGGIOEGMMM, [In] GJCFOEJAIJH HBJJJJBPMLB, [In] GJCFOEJAIJH DHOJGFGNLLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE9C0", Offset = "0x7BCDDC0", VA = "0x187BCE9C0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private static void CPIPHHEJNJK(KNLPKJCELJC HNMAAJKFEIE, [In] DKGCINFIPEG BKKGHOIEPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0910", Offset = "0x7BCFD10", VA = "0x187BD0910")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private static void LNBNBKPIPAK(KNLPKJCELJC HNMAAJKFEIE, [In] KCFFGMHHJNE FFPCNOIJDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF750", Offset = "0x7BCEB50", VA = "0x187BCF750", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7BCEA20", Offset = "0x7BCDE20", VA = "0x187BCEA20")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal void ENAIAIEJGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF7E0", Offset = "0x7BCEBE0", VA = "0x187BCF7E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal unsafe static void HKFHDGLJABI(UnsafeList<int>* EFOADDKBFDO, UnsafeList<float3>* PPJOBMOIJPM, [NoAlias] float3* KCMOIPPOGKH, [NoAlias] float4* FJMFHLOMKBC, [NoAlias] float2* LKFPHLACODF, [NoAlias] float4* ENMJNKIGJCE, UnsafeList<GJCFOEJAIJH>* ALKDKFDINCD, UnsafeList<int>* MJIFCHHFFGE, UnsafeList<float3>* EFNOCEPCOJB, [NoAlias] float3* HJCMNCPPGGB, [NoAlias] float4* EAKKCDIDMFJ, [NoAlias] float2* FEEGMPGOHBJ, [NoAlias] float4* LIADHGBHCKO, int OBALFOMMEDB, int MIJFEJOJGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0970", Offset = "0x7BCFD70", VA = "0x187BD0970")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void NBNJOBHKEEM(KNLPKJCELJC HNMAAJKFEIE, [In] DKGCINFIPEG BKKGHOIEPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF870", Offset = "0x7BCEC70", VA = "0x187BCF870")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void HPPLEGMDCJM(KNLPKJCELJC HNMAAJKFEIE, [In] KCFFGMHHJNE FFPCNOIJDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0080", Offset = "0x7BCF480", VA = "0x187BD0080")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void IKDIBIFEPHN(UnsafeList<int>* EFOADDKBFDO, UnsafeList<float3>* PPJOBMOIJPM, [NoAlias] float3* KCMOIPPOGKH, [NoAlias] float4* FJMFHLOMKBC, [NoAlias] float2* LKFPHLACODF, [NoAlias] float4* ENMJNKIGJCE, UnsafeList<GJCFOEJAIJH>* ALKDKFDINCD, UnsafeList<int>* MJIFCHHFFGE, UnsafeList<float3>* EFNOCEPCOJB, [NoAlias] float3* HJCMNCPPGGB, [NoAlias] float4* EAKKCDIDMFJ, [NoAlias] float2* FEEGMPGOHBJ, [NoAlias] float4* LIADHGBHCKO, int OBALFOMMEDB, int MIJFEJOJGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class BBNPNLEPAGD
{
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private static readonly ProfilerMarker GDEEFLNBNML;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public const int CHIEKEOFDAI = 2;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private const int MODCFBHPKKK = 1;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private static int PELKLDLBGNH;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private static Stack<BBNPNLEPAGD> KNOGDBNPAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private EFFDIJJLADK PHOGKBKDFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private NativeList<GJCFOEJAIJH> ALKDKFDINCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private NativeList<int> MJIFCHHFFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private NativeList<KNLPKJCELJC.DKGCINFIPEG> LKLCGGEEJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private NativeList<KNLPKJCELJC.DKGCINFIPEG> ILFNOHDGGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private NativeList<KNLPKJCELJC.KCFFGMHHJNE> DJNKAKPGFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private NativeList<KNLPKJCELJC.KCFFGMHHJNE> LFMGIGNIPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private KNLPKJCELJC HNMAAJKFEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private JobHandle KAKLANICLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private KNLPKJCELJC.NHPEEHMPHJA BLELDEPHHKH;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private const int EFCLENDDEMP = 65530;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8390", Offset = "0x7BD7790", VA = "0x187BD8390")]
	private BBNPNLEPAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7B10", Offset = "0x7BD6F10", VA = "0x187BD7B10")]
	public void JALHEEBOBCO(EFFDIJJLADK FEODHLOOCKF, float3 GBBPOOAHNNB, float ONMDBNOFCIG, float LABBNOJFLOG, float OFCMMDKBKLO, List<BEKGKNHPJKN.FGMMJCICOHA> GEFLDJGBGKH, Allocator PMIGMIBFCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7430", Offset = "0x7BD6830", VA = "0x187BD7430")]
	public (bool, EFFDIJJLADK, float) HKNPFHKAOLL(List<BEKGKNHPJKN.FGMMJCICOHA> GEFLDJGBGKH, Allocator PMIGMIBFCBG, bool DLIKAMNKCGB)
	{
		return default((bool, EFFDIJJLADK, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8240", Offset = "0x7BD7640", VA = "0x187BD8240")]
	public static bool POEFJJNEAOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7BD73C0", Offset = "0x7BD67C0", VA = "0x187BD73C0")]
	public static int GIDKHNOFPBD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7260", Offset = "0x7BD6660", VA = "0x187BD7260")]
	public static BBNPNLEPAGD EKGGDNEEHEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7A70", Offset = "0x7BD6E70", VA = "0x187BD7A70")]
	internal static void IADAHKDAGLI(BBNPNLEPAGD PMKDHHDNDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD80D0", Offset = "0x7BD74D0", VA = "0x187BD80D0")]
	public static void PFGLHBKBNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7F20", Offset = "0x7BD7320", VA = "0x187BD7F20")]
	[ACNGIGGALON(NCEMIMPHJMG.ExitingPlayMode, 0)]
	public static void NPALAMLGMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[BurstCompile]
internal struct GJCFOEJAIJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public float3 EIODCDKJBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public int FFLPPEBIFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public int ANICFNGGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public int PKKOENNBOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public float NAMHBKJIIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public float LJPOGMLPGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public int CPFGBKKIHJJ;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3FB0", Offset = "0x7BE33B0", VA = "0x187BE3FB0")]
	public static void BPKMLDCMEGB([Out] GJCFOEJAIJH APLCGCDLEGH, int ILLDCLCDOIM, [In] float3 ECHPFOBGIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3CC0", Offset = "0x7BE30C0", VA = "0x187BE3CC0")]
	[IgnoreWarning(1371)]
	public static void BPKMLDCMEGB([Out] GJCFOEJAIJH APLCGCDLEGH, [In] GJCFOEJAIJH LOBDIIAEBDB, [In] GJCFOEJAIJH DMMPDNGHLHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[BurstCompile]
internal struct ABMMAIBJNCF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private struct OKACLKOEOPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public int FFIBFHJCPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int CKBBODEOPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public int DOBCIFIGOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int AOPBEHMIOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int MDMHPBGNBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int PDJBDJEKGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int HLNLLJCCGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int MDAKNFDLHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public float KOCDAMPGNBI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct HCOICHAINJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public PHKAAPBHJFB.IJAKHIANDGM PAFIAIKNNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public float FFHBHMECFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public float IJDDCFIHCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public float KCBPIKNBILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public float ANHEBAKJIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public float OODGEKELGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public float NHLFEBNCCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public float NFKCFFPPFOH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private struct FEIANJFFDHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public NativeArray<float3> ADDMDCBIMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public NativeArray<float3> KDOFENDCMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NativeArray<float4> JLAOPOBELLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public NativeArray<float4> CGDFOIJKOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public NativeArray<float2> JLBLEIJACDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public NativeArray<int> HPPJMLBEDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public bool IMJFMDDODJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int HBNBJNMIHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int JCPPNAIFGGC;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0470", Offset = "0x7BDF870", VA = "0x187BE0470")]
		public void NLNPPHKFKKL(int MIJFEJOJGGN, int OBALFOMMEDB, Allocator LMMGDELCIGC, bool BNIKFHMCKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0220", Offset = "0x7BDF620", VA = "0x187BE0220")]
		public static FEIANJFFDHL GFKGKDPOLLO(EFFDIJJLADK BHCEDEKBMHE)
		{
			return default(FEIANJFFDHL);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0160", Offset = "0x7BDF560", VA = "0x187BE0160")]
		public void BKMLDGFOOLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private static readonly ProfilerMarker CKJFPJBEOAM;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private static readonly ProfilerMarker IDBEDFMPOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private NativeArray<OKACLKOEOPD> MNNFMOIFALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private FEIANJFFDHL AHCMGCDLLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private FEIANJFFDHL KABMIDMBHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private float3 ODKJECBFBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private float3 JNHILKGCOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private HCOICHAINJK EJEHBFENFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* AOGMFAIGGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private NativeArray<BEKGKNHPJKN.FGMMJCICOHA> AJNLOJMHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private NativeList<BEKGKNHPJKN.FGMMJCICOHA> HGCLGFPLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private NativeArray<int> MJIFCHHFFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private NativeArray<bool> GMODLCKACKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private NativeArray<int> BGJPEFNBLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private NativeArray<int> CBMDHDNBONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private NativeArray<float> BMHCJDHJEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<int> GBCOJFNFIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NativeArray<float> PFBCFAJKODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NativeArray<int> LKALMKBKNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private NativeArray<int> BPCBNBEHIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private NativeArray<float> OBGGHBMGLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private NativeArray<float> NNLPOBADMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private NativeArray<int> BCOMBCLOJLH;

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5DE0", Offset = "0x7BD51E0", VA = "0x187BD5DE0")]
	public ABMMAIBJNCF([In] List<BEKGKNHPJKN.KMDNENFINHH> JGGNBANDOME, NativeList<BEKGKNHPJKN.FGMMJCICOHA> FLJDGGCGBGI, [In] EFFDIJJLADK AAAKPINLFCO, [In] NativeList<BEKGKNHPJKN.FGMMJCICOHA> OBEEMFBGKHN, [In] NativeArray<long> BCDMMGFJLHH, float3 GGENOOBONFP, float3 MPOFPAJJBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD44C0", Offset = "0x7BD38C0", VA = "0x187BD44C0")]
	public static long DIPKMJEFHCE(int MIJFEJOJGGN, int OBALFOMMEDB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD44E0", Offset = "0x7BD38E0", VA = "0x187BD44E0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4C80", Offset = "0x7BD4080", VA = "0x187BD4C80")]
	public void MDHELOKKAOB(List<BEKGKNHPJKN.KMDNENFINHH> EGNJGNOJJDA, [In] BEKGKNHPJKN HAIFJKODGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4940", Offset = "0x7BD3D40", VA = "0x187BD4940")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private bool KMCCCBHEICB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4530", Offset = "0x7BD3930", VA = "0x187BD4530")]
	private LMKBCHBJNON HPIENNBGAPI(int AIGGDBADFCJ, Allocator LMMGDELCIGC)
	{
		return default(LMKBCHBJNON);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2D80", Offset = "0x7BD2180", VA = "0x187BD2D80")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void BAEIPNOPKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD56D0", Offset = "0x7BD4AD0", VA = "0x187BD56D0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private float PLONALKGAAN(int OBEHDJKAEKF, int BHGLMCAIDCN, bool NDGFPKDJMFK, bool KPJLNHALLMH, float AEPKHBAMKKP, float FLFBFNNMPKD, float GHFJJOMOLJB, float FAELDMABMPM, float FFPPFHCIGDA, float NFACBLFHCLA, float LHHMMAEEHPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4960", Offset = "0x7BD3D60", VA = "0x187BD4960")]
	[IgnoreWarning(1371)]
	private OKACLKOEOPD LNGECKKKKAD([In] OKACLKOEOPD KICOGHIEJOB, int FKGIIBFGKFC, [In] NativeArray<int> JHPGMMOMMNK, [In] NativeArray<bool> GMODLCKACKJ, NativeArray<int> BGJPEFNBLAE)
	{
		return default(OKACLKOEOPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4760", Offset = "0x7BD3B60", VA = "0x187BD4760")]
	public static int KCBAADKIDHM(NativeArray<int> JHPGMMOMMNK, NativeArray<int> BCOMBCLOJLH, int EJBPLCKGDFE, int LNGKLFPBNOL, int OBGAMJFEEEE)
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
		private struct PPFPANNPLNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public long HGBCELCPKFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public ODMOBPPJDNA ECGIIMPBODP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public CFLAAKGBDND IGPCANDHEAE;

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4C60", Offset = "0x7BE4060", VA = "0x187BE4C60")]
			public PPFPANNPLNI(ODMOBPPJDNA CGONIADJMDM, CFLAAKGBDND DOPIBBDHIFB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		private class BFEFOICECLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public ODMOBPPJDNA ECGIIMPBODP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public int DMCCFBNGLAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public float KFJCAGGCGCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public List<PPFPANNPLNI> GKNMEGNOFHB;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x7BD8530", Offset = "0x7BD7930", VA = "0x187BD8530")]
			public BFEFOICECLK(ODMOBPPJDNA CGONIADJMDM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private static readonly ProfilerMarker INBLAGNMOFK;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private static readonly ProfilerMarker PGPAHIANLKG;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private static readonly ProfilerMarker OOAEOPPJEEM;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private static readonly ProfilerMarker LALEDBIKKHI;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly ProfilerMarker APFCMCCJCPF;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly ProfilerMarker ACCFEFMMGBD;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private static readonly ProfilerMarker HFHOLAIKJBF;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		internal const int FNAOHKBGFGF = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		internal static Dictionary<Material, List<Material>> OLLGJJEALPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Dictionary<Material, List<DEOBLNBIOLA>> NMIELADABFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		internal List<DEOBLNBIOLA> DOEACIHEEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private List<MeshRenderer> ADBPAGEINIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private Transform DBIIEMKDJHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private bool PECBEEOIODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private bool CDFFIOHGBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private int EPHGCHJMCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private DEOBLNBIOLA CNEEBJBLGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private Material JAMIKEFHKKK;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private static bool? EEADPHCJNLD;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private const int KGHDMKBFHLB = 1024;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static List<PPFPANNPLNI> GLEAFCOPJOK;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IReadOnlyList<MeshRenderer> MKINFEOELCB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int IHAHJILLIPI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7BE0110", Offset = "0x7BDF510", VA = "0x187BE0110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private static bool HMCENBGCIPG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7BDA1C0", Offset = "0x7BD95C0", VA = "0x187BDA1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		private static void LFNJEAECIKM(bool CIKDCLHCJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		private static void LFNJEAECIKM(bool CIKDCLHCJFN, string FGEBHLNNMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		private static void ILLMDKGAIGD(string KCCMEIDBNGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9F30", Offset = "0x7BD9330", VA = "0x187BD9F30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9CB0", Offset = "0x7BD90B0", VA = "0x187BD9CB0")]
		internal bool AKLKDJKDENC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBE00", Offset = "0x7BDB200", VA = "0x187BDBE00")]
		private Transform LIPFPPCEDIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC5C0", Offset = "0x7BDB9C0", VA = "0x187BDC5C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA2F0", Offset = "0x7BD96F0", VA = "0x187BDA2F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9D10", Offset = "0x7BD9110", VA = "0x187BD9D10")]
		public DEOBLNBIOLA AddToBatchedMesh(CFLAAKGBDND FHOKEFGLIDP, Material FFHFAEDNMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFBD0", Offset = "0x7BDEFD0", VA = "0x187BDFBD0")]
		public void RemoveFromBatchedMesh(CFLAAKGBDND IGPCANDHEAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA090", Offset = "0x7BD9490", VA = "0x187BDA090")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBE80", Offset = "0x7BDB280", VA = "0x187BDBE80")]
		private void LPDNOKGGHBH(Renderer JBNKAEBEMAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB560", Offset = "0x7BDA960", VA = "0x187BDB560")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB550", Offset = "0x7BDA950", VA = "0x187BDB550")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC5D0", Offset = "0x7BDB9D0", VA = "0x187BDC5D0")]
		private void PCABFOONNJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC060", Offset = "0x7BDB460", VA = "0x187BDC060")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAAE0", Offset = "0x7BD9EE0", VA = "0x187BDAAE0")]
		private DEOBLNBIOLA FLGGPKMACAA(CFLAAKGBDND IGPCANDHEAE, Material FFHFAEDNMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA700", Offset = "0x7BD9B00", VA = "0x187BDA700")]
		private DEOBLNBIOLA EMICPKMJBEL(Material FFHFAEDNMPG, int JBICMFCAINE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB5D0", Offset = "0x7BDA9D0", VA = "0x187BDB5D0")]
		private DEOBLNBIOLA KNOMCNJECMC(Material FFHFAEDNMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAD00", Offset = "0x7BDA100", VA = "0x187BDAD00")]
		internal float4x4 GLOBGNDNNOJ()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BDADA0", Offset = "0x7BDA1A0", VA = "0x187BDADA0")]
		public static List<Material> GenerateVertexFormatVariants(Material FFHFAEDNMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x128F2B0", Offset = "0x128E6B0", VA = "0x18128F2B0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBF00", Offset = "0x7BDB300", VA = "0x187BDBF00")]
		public void MarkDirty(CFLAAKGBDND IGPCANDHEAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA9E0", Offset = "0x7BD9DE0", VA = "0x187BDA9E0")]
		[Conditional("CHECK_STATE")]
		private void FKIPHHFKCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC1E0", Offset = "0x7BDB5E0", VA = "0x187BDC1E0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float MDDGBGOJKJD)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9F60", Offset = "0x7BD9360", VA = "0x187BD9F60")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BDEA30", Offset = "0x7BDDE30", VA = "0x187BDEA30")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAEC0", Offset = "0x7BDA2C0", VA = "0x187BDAEC0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCC20", Offset = "0x7BDC020", VA = "0x187BDCC20")]
		public void RebatchOptimally(int NCNHJHFOCHN, int HMIHHPKPNLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCB40", Offset = "0x7BDBF40", VA = "0x187BDCB40")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFFE0", Offset = "0x7BDF3E0", VA = "0x187BDFFE0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class GGNBFGNLLFM
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private struct NNPKHNNINMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public BatchedMeshRenderer JBNKAEBEMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public DEOBLNBIOLA IGPCANDHEAE;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x195E1B0", Offset = "0x195D5B0", VA = "0x18195E1B0")]
		public void CLFNLJKDHJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct MJLEEPODJNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public float OMCEDHBEMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public DEOBLNBIOLA IINDCALGGEG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class BLCEAOANPFL : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x10AE5A0", Offset = "0x10AD9A0", VA = "0x1810AE5A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BD9610", Offset = "0x7BD8A10", VA = "0x187BD9610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x120FEE0", Offset = "0x120F2E0", VA = "0x18120FEE0")]
		[DebuggerHidden]
		public BLCEAOANPFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9660", Offset = "0x7BD8A60", VA = "0x187BD9660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8680", Offset = "0x7BD7A80", VA = "0x187BD8680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD85E0", Offset = "0x7BD79E0", VA = "0x187BD85E0")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8630", Offset = "0x7BD7A30", VA = "0x187BD8630")]
		private void LNCBGHLOKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD95C0", Offset = "0x7BD89C0", VA = "0x187BD95C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9510", Offset = "0x7BD8910", VA = "0x187BD9510", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9510", Offset = "0x7BD8910", VA = "0x187BD9510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private static readonly ProfilerMarker ACCFEFMMGBD;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private static readonly ProfilerMarker MHJCOLHKMKB;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private static readonly ProfilerMarker MHJOALCLJAA;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private static readonly ProfilerMarker KJEOFMFLPLO;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static float3 AJGDPBJICNH;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static int NFJODMFEHEC;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static int BIJAACJPAPK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static int BLOCEDBHPJI;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static int IPKNBCOIFLP;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static int AGJMKKEONPL;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static float GGPHIGMLANA;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static float NEMKDPFHCKH;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static float JLEFCENGGDN;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static float KIHENOCHPBB;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static float CHAKBKFLPOO;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static float DJIOCMGFCLK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static float DMEFJGGIKEB;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static float PPIMOKAKDHK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static List<BatchedMeshRenderer> OHGCEJKICMN;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static Stack<EFFDIJJLADK> LKEEFBAKNFN;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static Stack<JPGCMFCMNLL> DJCLCICKEIM;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static GJBDMCKPJAO BGCLOEPMJGN;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static NNPKHNNINMA LDCAAKBCPGG;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static int GOJJFIONJAL;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void LFNJEAECIKM(bool CIKDCLHCJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void MFKPHJHPJOJ(bool CIKDCLHCJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void LFNJEAECIKM(bool CIKDCLHCJFN, string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0DB0", Offset = "0x7BE01B0", VA = "0x187BE0DB0")]
	public static void HGEPFBBIJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0650", Offset = "0x7BDFA50", VA = "0x187BE0650")]
	public static void BELLKBLMPNJ(BatchedMeshRenderer AJDINKABENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7BE10F0", Offset = "0x7BE04F0", VA = "0x187BE10F0")]
	public static void KKLGJKJCHED(BatchedMeshRenderer AJDINKABENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BE14F0", Offset = "0x7BE08F0", VA = "0x187BE14F0")]
	public static void MHGPKAPMNJA(CFLAAKGBDND KAJGCGBNFEH, bool FBKDLNMGBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0A30", Offset = "0x7BDFE30", VA = "0x187BE0A30")]
	public static void GNHLBBINJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2FE0", Offset = "0x7BE23E0", VA = "0x187BE2FE0")]
	public static void PJMCJLCELHH(float MDDGBGOJKJD, bool FCAKCLIOBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1F30", Offset = "0x7BE1330", VA = "0x187BE1F30")]
	private static void OCDHPKJDJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2430", Offset = "0x7BE1830", VA = "0x187BE2430")]
	public static long PEPDIFHGIMB(int PBPGJOODABO, long MFIBEBBLNDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0790", Offset = "0x7BDFB90", VA = "0x187BE0790")]
	public static (long, long, int) BGMIKLGEJLL(float MDDGBGOJKJD)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BE09A0", Offset = "0x7BDFDA0", VA = "0x187BE09A0")]
	[IteratorStateMachine(typeof(BLCEAOANPFL))]
	public static IEnumerable<bool> DBOEDJILKFL(long AIEEBJDFCKL, bool DBCANINABIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1C80", Offset = "0x7BE1080", VA = "0x187BE1C80")]
	public static void NEKFHEPEGGH(long AIEEBJDFCKL, bool DBCANINABIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1220", Offset = "0x7BE0620", VA = "0x187BE1220")]
	public static int KPBDJEJJFHN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0F70", Offset = "0x7BE0370", VA = "0x187BE0F70")]
	internal static EFFDIJJLADK KFPOHOCMPOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0EC0", Offset = "0x7BE02C0", VA = "0x187BE0EC0")]
	internal static void IADAHKDAGLI(EFFDIJJLADK BPHJFKGJAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BE13A0", Offset = "0x7BE07A0", VA = "0x187BE13A0")]
	internal static JPGCMFCMNLL LBKMDDJDKDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0E30", Offset = "0x7BE0230", VA = "0x187BE0E30")]
	internal static void IADAHKDAGLI(JPGCMFCMNLL HAIAJGNFDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2E00", Offset = "0x7BE2200", VA = "0x187BE2E00")]
	public static void PFGLHBKBNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public class GMCFILJLLBG<KeyType> : DEOBLNBIOLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private readonly Dictionary<KeyType, CFLAAKGBDND> PMNFPADCJGM;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x48C8700", Offset = "0x48C7B00", VA = "0x1848C8700")]
	public GMCFILJLLBG(string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x48C8390", Offset = "0x48C7790", VA = "0x1848C8390")]
	public void GGEOCDKAPLP(KeyType IICGAABOENK, CFLAAKGBDND KAJGCGBNFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x48C8400", Offset = "0x48C7800", VA = "0x1848C8400")]
	public bool NJJLJNLPCLM(KeyType IICGAABOENK, CFLAAKGBDND MNGHLBODHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x48C8170", Offset = "0x48C7570", VA = "0x1848C8170")]
	public void BBPOLALIJKM(KeyType IICGAABOENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x48C8330", Offset = "0x48C7730", VA = "0x1848C8330", Slot = "4")]
	public override void GELKPOGLHON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class PINHNACJEGL
{
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly ProfilerCategory DAPGHPGGEDC;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	internal static readonly ProfilerMarker AGAFPDEPFKL;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	internal static readonly ODOPGKFMFPF PJMCJLCELHH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private static readonly IELLNLLEEAO<float> FCHCKBHPKBI;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly IELLNLLEEAO<float> JAPDGCPLGNC;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private static readonly IELLNLLEEAO<double> NHJJEBNDAAN;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly IELLNLLEEAO<double> KBNGFJIEOCI;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private static readonly IELLNLLEEAO<double> OEDNANKHOCL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private static readonly IELLNLLEEAO<int> JOBFMKKAPEG;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private static readonly IELLNLLEEAO<int> EEAHNGIHOMP;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly IELLNLLEEAO<int> DPDBCHACNNP;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly IELLNLLEEAO<int> LNEOFBENFCE;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly IELLNLLEEAO<int> HMNGEPNHFGG;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static readonly IELLNLLEEAO<long> BJBFNMDGELJ;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly IELLNLLEEAO<long> CFFBICLKNGK;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly IELLNLLEEAO<long> IFAHFAKFLLF;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly IELLNLLEEAO<long> LILCLBGKKCH;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly IELLNLLEEAO<long> GHFEKFKBBOL;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7BE41C0", Offset = "0x7BE35C0", VA = "0x187BE41C0")]
	public static void LCBGLLPPAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4C90", Offset = "0x7BE4090", VA = "0x187BE4C90")]
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
