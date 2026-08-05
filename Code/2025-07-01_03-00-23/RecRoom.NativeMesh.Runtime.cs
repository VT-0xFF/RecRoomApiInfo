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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x804C7C0", Offset = "0x804ADC0", VA = "0x18804C7C0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class LNNFPPDAHHD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly LHMKAIAPMBI GIHFALJKHIL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly LHMKAIAPMBI CBCAOGOAMCO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly LHMKAIAPMBI GOKPBECIFCA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly LHMKAIAPMBI DJLNMFAJCGM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly LHMKAIAPMBI KADEPNAMHKO;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class NJDLLHCEEAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public ECGCNLKJEKF BJIKALEHOLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KABGKOBDGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NJDLLHCEEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct ECGCNLKJEKF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PCMCBDMPNNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half JKDBHMJIJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort FIFCAAJGDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte DCGKDGDJBDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void PEHLANBCAII([NoAlias] float3* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class GCBJOGPPHAA
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x803D030", Offset = "0x803B630", VA = "0x18803D030")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x803CED0", Offset = "0x803B4D0", VA = "0x18803CED0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x803CE20", Offset = "0x803B420", VA = "0x18803CE20")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x803CBF0", Offset = "0x803B1F0", VA = "0x18803CBF0")]
		public unsafe static void GHDKDALNEMC([NoAlias] float3* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void FBPIBBEMPIF([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class JGMDLPIPIFD
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8041450", Offset = "0x803FA50", VA = "0x188041450")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x80412F0", Offset = "0x803F8F0", VA = "0x1880412F0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8041240", Offset = "0x803F840", VA = "0x188041240")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8040F90", Offset = "0x803F590", VA = "0x188040F90")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void GLIHBMBDMGB([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class BOMEFIOAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80328F0", Offset = "0x8030EF0", VA = "0x1880328F0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8032790", Offset = "0x8030D90", VA = "0x188032790")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80326E0", Offset = "0x8030CE0", VA = "0x1880326E0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8032430", Offset = "0x8030A30", VA = "0x188032430")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void HBFIBOBHEFC([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class LGEABFMPHKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x804B7C0", Offset = "0x8049DC0", VA = "0x18804B7C0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x804B660", Offset = "0x8049C60", VA = "0x18804B660")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x804B5B0", Offset = "0x8049BB0", VA = "0x18804B5B0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x804B300", Offset = "0x8049900", VA = "0x18804B300")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void GJPMNMGNICE([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class LHCJFGBBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x804BDB0", Offset = "0x804A3B0", VA = "0x18804BDB0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x804BC50", Offset = "0x804A250", VA = "0x18804BC50")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x804BBA0", Offset = "0x804A1A0", VA = "0x18804BBA0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x804B8F0", Offset = "0x8049EF0", VA = "0x18804B8F0")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void BBOFGMJEFPO([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class OHDLDMDLGDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8051430", Offset = "0x804FA30", VA = "0x188051430")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x80512D0", Offset = "0x804F8D0", VA = "0x1880512D0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8051220", Offset = "0x804F820", VA = "0x188051220")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8050EE0", Offset = "0x804F4E0", VA = "0x188050EE0")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void IMMEKICCJIC([NoAlias] ushort* HLNIGNDMGJL, [Out] float3 DECAKMPEJMC, [Out] float3 ABLEGJFGEBC, [In][NoAlias] float3* JHECMPLADOK, int LNDPOAIFNJD, int IGENIDBBLGE);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class NLFMOFOOCBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8050BF0", Offset = "0x804F1F0", VA = "0x188050BF0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8050A90", Offset = "0x804F090", VA = "0x188050A90")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x80509E0", Offset = "0x804EFE0", VA = "0x1880509E0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x80507A0", Offset = "0x804EDA0", VA = "0x1880507A0")]
		public unsafe static void GHDKDALNEMC([NoAlias] ushort* HLNIGNDMGJL, [Out] float3 DECAKMPEJMC, [Out] float3 ABLEGJFGEBC, [In][NoAlias] float3* JHECMPLADOK, int LNDPOAIFNJD, int IGENIDBBLGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void MPPMJNKGGKI([NoAlias] ushort* JFGMDLPGKIA, [In][NoAlias] float3* KMIGOFHCCFB, int IGENIDBBLGE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class NHMNGGBEEJK
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8050670", Offset = "0x804EC70", VA = "0x188050670")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8050510", Offset = "0x804EB10", VA = "0x188050510")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8050460", Offset = "0x804EA60", VA = "0x188050460")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8050250", Offset = "0x804E850", VA = "0x188050250")]
		public unsafe static void GHDKDALNEMC([NoAlias] ushort* JFGMDLPGKIA, [In][NoAlias] float3* KMIGOFHCCFB, int IGENIDBBLGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void BMGIPFDBPFK([NoAlias] float3* JFOIAFLDLJM, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class MMPPNAMGHMP
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x804F5F0", Offset = "0x804DBF0", VA = "0x18804F5F0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x804F490", Offset = "0x804DA90", VA = "0x18804F490")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x804F3E0", Offset = "0x804D9E0", VA = "0x18804F3E0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x804F1D0", Offset = "0x804D7D0", VA = "0x18804F1D0")]
		public unsafe static void GHDKDALNEMC([NoAlias] float3* JFOIAFLDLJM, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void MNPCICMFPIK([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class BAIFJJHHLKI
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8031AF0", Offset = "0x80300F0", VA = "0x188031AF0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8031990", Offset = "0x802FF90", VA = "0x188031990")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x80318E0", Offset = "0x802FEE0", VA = "0x1880318E0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x80316D0", Offset = "0x802FCD0", VA = "0x1880316D0")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void FNNDHEJEGED([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class MCHNALBPGCB
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x804D000", Offset = "0x804B600", VA = "0x18804D000")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x804CEA0", Offset = "0x804B4A0", VA = "0x18804CEA0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x804CDF0", Offset = "0x804B3F0", VA = "0x18804CDF0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x804CAF0", Offset = "0x804B0F0", VA = "0x18804CAF0")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void OBPLPJJHBCM([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class MMEPLGCCNGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x804F0A0", Offset = "0x804D6A0", VA = "0x18804F0A0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x804EF40", Offset = "0x804D540", VA = "0x18804EF40")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x804EE90", Offset = "0x804D490", VA = "0x18804EE90")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x804EB90", Offset = "0x804D190", VA = "0x18804EB90")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void NHGBHLDNEMF([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class HHCAIFDJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x803EB10", Offset = "0x803D110", VA = "0x18803EB10")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x803E9B0", Offset = "0x803CFB0", VA = "0x18803E9B0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x803E900", Offset = "0x803CF00", VA = "0x18803E900")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x803E5D0", Offset = "0x803CBD0", VA = "0x18803E5D0")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void KEDLCNIJMMN([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class PLFADHMNDGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8052E30", Offset = "0x8051430", VA = "0x188052E30")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8052CD0", Offset = "0x80512D0", VA = "0x188052CD0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8052C20", Offset = "0x8051220", VA = "0x188052C20")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x80528F0", Offset = "0x8050EF0", VA = "0x1880528F0")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void OACKHJFBNJK([NoAlias] uint* NDOKLPKDCEL, [Out] float2 NOKJNNIHNBI, [Out] float2 NACCPECNNNM, [In][NoAlias] float2* PDJILIHBLEA, int LNDPOAIFNJD, int IGENIDBBLGE);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class GLDJPLEEIPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x803DD60", Offset = "0x803C360", VA = "0x18803DD60")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x803DC00", Offset = "0x803C200", VA = "0x18803DC00")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x803DB50", Offset = "0x803C150", VA = "0x18803DB50")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x803D910", Offset = "0x803BF10", VA = "0x18803D910")]
		public unsafe static void GHDKDALNEMC([NoAlias] uint* NDOKLPKDCEL, [Out] float2 NOKJNNIHNBI, [Out] float2 NACCPECNNNM, [In][NoAlias] float2* PDJILIHBLEA, int LNDPOAIFNJD, int IGENIDBBLGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void CBGOKJKEJOP([Out] float2 BGDJIGMEPID, uint KEIGHFIPJBC, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class DMBEFGKMEHK
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8033670", Offset = "0x8031C70", VA = "0x188033670")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8033510", Offset = "0x8031B10", VA = "0x188033510")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8033460", Offset = "0x8031A60", VA = "0x188033460")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8033200", Offset = "0x8031800", VA = "0x188033200")]
		public static void GHDKDALNEMC([Out] float2 BGDJIGMEPID, uint KEIGHFIPJBC, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void MHHDGIHLDND([NoAlias] float2* NDOKLPKDCEL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class PEPGDNNBPLD
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x80521E0", Offset = "0x80507E0", VA = "0x1880521E0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8052080", Offset = "0x8050680", VA = "0x188052080")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8051FD0", Offset = "0x80505D0", VA = "0x188051FD0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8051CE0", Offset = "0x80502E0", VA = "0x188051CE0")]
		public unsafe static void GHDKDALNEMC([NoAlias] float2* NDOKLPKDCEL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void OMKAANPGEBL([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class EBHPLOFHPJC
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8034280", Offset = "0x8032880", VA = "0x188034280")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8034120", Offset = "0x8032720", VA = "0x188034120")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8034070", Offset = "0x8032670", VA = "0x188034070")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8033D50", Offset = "0x8032350", VA = "0x188033D50")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void ADPNHHCIPJI([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class IHLJNKIBHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x803F270", Offset = "0x803D870", VA = "0x18803F270")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x803F110", Offset = "0x803D710", VA = "0x18803F110")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x803F060", Offset = "0x803D660", VA = "0x18803F060")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x803ED40", Offset = "0x803D340", VA = "0x18803ED40")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void DJMKPGCABPG([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class AKDFAAPNPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x802F2C0", Offset = "0x802D8C0", VA = "0x18802F2C0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x802F160", Offset = "0x802D760", VA = "0x18802F160")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x802F0B0", Offset = "0x802D6B0", VA = "0x18802F0B0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x802EE80", Offset = "0x802D480", VA = "0x18802EE80")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void IBAPBMFABOF([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class JCNKBDOCOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8040660", Offset = "0x803EC60", VA = "0x188040660")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8040500", Offset = "0x803EB00", VA = "0x188040500")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8040450", Offset = "0x803EA50", VA = "0x188040450")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8040140", Offset = "0x803E740", VA = "0x188040140")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void AILNAOMNCMJ([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class MLCFFABBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x804EA60", Offset = "0x804D060", VA = "0x18804EA60")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x804E900", Offset = "0x804CF00", VA = "0x18804E900")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x804E850", Offset = "0x804CE50", VA = "0x18804E850")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x804E530", Offset = "0x804CB30", VA = "0x18804E530")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void PDMENCJELGC([NoAlias] ushort* JNJIDDEDMAE, [In][NoAlias] float4* KJMHIJKLDDM, int LNDPOAIFNJD, int IGENIDBBLGE);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class DACOOMGBIFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8032FD0", Offset = "0x80315D0", VA = "0x188032FD0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8032E70", Offset = "0x8031470", VA = "0x188032E70")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8032DC0", Offset = "0x80313C0", VA = "0x188032DC0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8032B20", Offset = "0x8031120", VA = "0x188032B20")]
		public unsafe static void GHDKDALNEMC([NoAlias] ushort* JNJIDDEDMAE, [In][NoAlias] float4* KJMHIJKLDDM, int LNDPOAIFNJD, int IGENIDBBLGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort JEDACLCGDGO([In] float4 IBFCJLODHHJ);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class MJOHOEEMKCH
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x804E400", Offset = "0x804CA00", VA = "0x18804E400")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x804E2A0", Offset = "0x804C8A0", VA = "0x18804E2A0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x804E1F0", Offset = "0x804C7F0", VA = "0x18804E1F0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x804DF90", Offset = "0x804C590", VA = "0x18804DF90")]
		public static ushort GHDKDALNEMC([In] float4 IBFCJLODHHJ)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void BNHBFGMHJKL([NoAlias] float4* JNJIDDEDMAE, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class MPIPBHFCMIM
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x804FBD0", Offset = "0x804E1D0", VA = "0x18804FBD0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x804FA70", Offset = "0x804E070", VA = "0x18804FA70")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x804F9C0", Offset = "0x804DFC0", VA = "0x18804F9C0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x804F720", Offset = "0x804DD20", VA = "0x18804F720")]
		public unsafe static void GHDKDALNEMC([NoAlias] float4* JNJIDDEDMAE, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void NJKLALENGJJ([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class KKLKKLPNKGH
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x804A310", Offset = "0x8048910", VA = "0x18804A310")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x804A1B0", Offset = "0x80487B0", VA = "0x18804A1B0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x804A100", Offset = "0x8048700", VA = "0x18804A100")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8049EF0", Offset = "0x80484F0", VA = "0x188049EF0")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void BFAACFOPBHD([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class MFLNLNDFOGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x804D670", Offset = "0x804BC70", VA = "0x18804D670")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x804D510", Offset = "0x804BB10", VA = "0x18804D510")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x804D460", Offset = "0x804BA60", VA = "0x18804D460")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x804D130", Offset = "0x804B730", VA = "0x18804D130")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void FNGAHDHHHDF([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class MHFGACCAPDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x804DCE0", Offset = "0x804C2E0", VA = "0x18804DCE0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x804DB80", Offset = "0x804C180", VA = "0x18804DB80")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x804DAD0", Offset = "0x804C0D0", VA = "0x18804DAD0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x804D7A0", Offset = "0x804BDA0", VA = "0x18804D7A0")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void OGNPKGMPFMD([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class EPONBKACJCB
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x803C200", Offset = "0x803A800", VA = "0x18803C200")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x803C0A0", Offset = "0x803A6A0", VA = "0x18803C0A0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x803BFF0", Offset = "0x803A5F0", VA = "0x18803BFF0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x803BC60", Offset = "0x803A260", VA = "0x18803BC60")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void MHNICBNOEND([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class KOLIPNCOOCE
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x804A9E0", Offset = "0x8048FE0", VA = "0x18804A9E0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x804A880", Offset = "0x8048E80", VA = "0x18804A880")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x804A7D0", Offset = "0x8048DD0", VA = "0x18804A7D0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x804A440", Offset = "0x8048A40", VA = "0x18804A440")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void LDAKMIAODBM([Out] float4 HPCDHGHHCOO, ushort KEIGHFIPJBC);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class PIEFLOENLOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x80527C0", Offset = "0x8050DC0", VA = "0x1880527C0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8052660", Offset = "0x8050C60", VA = "0x188052660")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x80525B0", Offset = "0x8050BB0", VA = "0x1880525B0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8052310", Offset = "0x8050910", VA = "0x188052310")]
		public static void GHDKDALNEMC([Out] float4 HPCDHGHHCOO, ushort KEIGHFIPJBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void PMEEJEBKFBK([NoAlias] float4* DMDBOIDLPIC, [NoAlias] byte* LNFFNFJGJFH, [Out] int DPBDJMHCGJM, [Out] int PKGLJJAPNPN, [NoAlias] float4* PMAICPIHNHJ, int LNDPOAIFNJD, int IGENIDBBLGE);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class AGEIHNBKBLF
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x802E260", Offset = "0x802C860", VA = "0x18802E260")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x802E100", Offset = "0x802C700", VA = "0x18802E100")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x802E050", Offset = "0x802C650", VA = "0x18802E050")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x802DE10", Offset = "0x802C410", VA = "0x18802DE10")]
		public unsafe static void GHDKDALNEMC([NoAlias] float4* DMDBOIDLPIC, [NoAlias] byte* LNFFNFJGJFH, [Out] int DPBDJMHCGJM, [Out] int PKGLJJAPNPN, [NoAlias] float4* PMAICPIHNHJ, int LNDPOAIFNJD, int IGENIDBBLGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void EEJCEPJKEKB([NoAlias] float4* FEKEJMKOCBI, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class FKHOGDELBPE
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x803C940", Offset = "0x803AF40", VA = "0x18803C940")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x803C7E0", Offset = "0x803ADE0", VA = "0x18803C7E0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x803C730", Offset = "0x803AD30", VA = "0x18803C730")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x803C430", Offset = "0x803AA30", VA = "0x18803C430")]
		public unsafe static void GHDKDALNEMC([NoAlias] float4* FEKEJMKOCBI, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void FGIHBMALAEF([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class JBFIALFNEHB
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8040010", Offset = "0x803E610", VA = "0x188040010")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x803FEB0", Offset = "0x803E4B0", VA = "0x18803FEB0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x803FE00", Offset = "0x803E400", VA = "0x18803FE00")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x803FA50", Offset = "0x803E050", VA = "0x18803FA50")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void CPEAPECOGAF([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class JGIFGLNPEIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8040E60", Offset = "0x803F460", VA = "0x188040E60")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8040D00", Offset = "0x803F300", VA = "0x188040D00")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8040C50", Offset = "0x803F250", VA = "0x188040C50")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8040890", Offset = "0x803EE90", VA = "0x188040890")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void MBPODJCPCLI([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class LFPNMENGLCO
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x804B1D0", Offset = "0x80497D0", VA = "0x18804B1D0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x804B070", Offset = "0x8049670", VA = "0x18804B070")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x804AFC0", Offset = "0x80495C0", VA = "0x18804AFC0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x804AC10", Offset = "0x8049210", VA = "0x18804AC10")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void PJEKONEOGCC([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class AIIJFKPKLMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x802E7D0", Offset = "0x802CDD0", VA = "0x18802E7D0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x802E670", Offset = "0x802CC70", VA = "0x18802E670")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x802E5C0", Offset = "0x802CBC0", VA = "0x18802E5C0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x802E390", Offset = "0x802C990", VA = "0x18802E390")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void LMHAMIDHAOM([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class GNBBBPMPGNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x803E2D0", Offset = "0x803C8D0", VA = "0x18803E2D0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x803E170", Offset = "0x803C770", VA = "0x18803E170")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x803E0C0", Offset = "0x803C6C0", VA = "0x18803E0C0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x803DE90", Offset = "0x803C490", VA = "0x18803DE90")]
		public unsafe static void GHDKDALNEMC([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int LFDHKJPKACN([NoAlias] byte* FEAOPAJBNBH, [In][NoAlias] int* AHNPHKDIDBJ, int CHIJPGAHNMB);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class GKFNNFDCONL
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x803D7E0", Offset = "0x803BDE0", VA = "0x18803D7E0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x803D680", Offset = "0x803BC80", VA = "0x18803D680")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x803D5D0", Offset = "0x803BBD0", VA = "0x18803D5D0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x803D330", Offset = "0x803B930", VA = "0x18803D330")]
		public unsafe static int GHDKDALNEMC([NoAlias] byte* FEAOPAJBNBH, [In][NoAlias] int* AHNPHKDIDBJ, int CHIJPGAHNMB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void MHLPPILLEFO([NoAlias] int* EKADFKKFPJK, [In][NoAlias] byte* LJLIEJOLAGG, int AIHHKEFNBIM);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class JKMGPLFGCMF
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8041F70", Offset = "0x8040570", VA = "0x188041F70")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8041E10", Offset = "0x8040410", VA = "0x188041E10")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8041D60", Offset = "0x8040360", VA = "0x188041D60")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8041B00", Offset = "0x8040100", VA = "0x188041B00")]
		public unsafe static void GHDKDALNEMC([NoAlias] int* EKADFKKFPJK, [In][NoAlias] byte* LJLIEJOLAGG, int AIHHKEFNBIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void NNPAEJBBLPF([NoAlias] ushort* EKADFKKFPJK, [In][NoAlias] byte* LJLIEJOLAGG, int AIHHKEFNBIM);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class IJCIOMJLPIO
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x803F820", Offset = "0x803DE20", VA = "0x18803F820")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x803F6C0", Offset = "0x803DCC0", VA = "0x18803F6C0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x803F610", Offset = "0x803DC10", VA = "0x18803F610")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x803F3A0", Offset = "0x803D9A0", VA = "0x18803F3A0")]
		public unsafe static void GHDKDALNEMC([NoAlias] ushort* EKADFKKFPJK, [In][NoAlias] byte* LJLIEJOLAGG, int AIHHKEFNBIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void DANGNBKBCNA([Out] float3 BGDJIGMEPID, ushort KEIGHFIPJBC);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class NEPCEDHDMIB
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8050120", Offset = "0x804E720", VA = "0x188050120")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x804FFC0", Offset = "0x804E5C0", VA = "0x18804FFC0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x804FF10", Offset = "0x804E510", VA = "0x18804FF10")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x804FD00", Offset = "0x804E300", VA = "0x18804FD00")]
		public static void GHDKDALNEMC([Out] float3 BGDJIGMEPID, ushort KEIGHFIPJBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort MPNENMBCDEK([In] float3 IBFCJLODHHJ);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class BCDJNAAPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8032030", Offset = "0x8030630", VA = "0x188032030")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8031ED0", Offset = "0x80304D0", VA = "0x188031ED0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8031E20", Offset = "0x8030420", VA = "0x188031E20")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8031C20", Offset = "0x8030220", VA = "0x188031C20")]
		public static ushort GHDKDALNEMC([In] float3 IBFCJLODHHJ)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker CEGHFHFIEAN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker OGIGJKGLAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int KABGKOBDGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int AIHHKEFNBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> OAFFCDPLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> NJFMDNHHIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> DIGJAIJPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> NOIBLEJCHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<PCMCBDMPNNC> PEKKOAHHCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> BBNFIHFMJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> MKHHILLHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 JPOCNCENBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 ABLEGJFGEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 AEOKEGOPDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 NACCPECNNNM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long ADEBPOFDJAP;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long GFFADJOGMAL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float JDDGLDGGIJJ;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool NCOJPFPOAOD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NGPOKKIJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8038AA0", Offset = "0x80370A0", VA = "0x188038AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DIFMPMJMPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80355E0", Offset = "0x8033BE0", VA = "0x1880355E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8036520", Offset = "0x8034B20", VA = "0x188036520")]
	public void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x803A1F0", Offset = "0x80387F0", VA = "0x18803A1F0")]
	public static ECGCNLKJEKF MMBKOMPANAO(Allocator HOHBLCPFIEJ, JOHNDGNODKM KIIBBHFNDKL)
	{
		return default(ECGCNLKJEKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x803A4C0", Offset = "0x8038AC0", VA = "0x18803A4C0")]
	public static ECGCNLKJEKF MMBKOMPANAO(Allocator HOHBLCPFIEJ, NativeArray<float3> JHECMPLADOK, NativeArray<float3> KMIGOFHCCFB, NativeArray<float2> PDJILIHBLEA, NativeArray<float4> PMAICPIHNHJ, bool HDPEKOJBINA, NativeArray<float4> EFJNOEEPHBK, NativeArray<int> AHNPHKDIDBJ, int KABGKOBDGEB, int FLCMIDBBGFA, int AIHHKEFNBIM, int LNDPOAIFNJD)
	{
		return default(ECGCNLKJEKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8037DB0", Offset = "0x80363B0", VA = "0x188037DB0")]
	public void FPACEGHACCO(JOHNDGNODKM HPCDHGHHCOO, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8039C00", Offset = "0x8038200", VA = "0x188039C00")]
	public long LHGBIGIHOLH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8039B90", Offset = "0x8038190", VA = "0x188039B90")]
	public long LBPJGFIAILG(JOHNDGNODKM.DLPLPJGMGAK MCLEKLAABMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8035F00", Offset = "0x8034500", VA = "0x188035F00")]
	private void CMAKEHGLHJI(int MNAPDCDOKHC, int IGENIDBBLGE, Allocator HOHBLCPFIEJ, bool KOGDOLOLJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8035D60", Offset = "0x8034360", VA = "0x188035D60")]
	private void CKFJCIKIIID(NativeArray<float3> HLNIGNDMGJL, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8035CE0", Offset = "0x80342E0", VA = "0x188035CE0")]
	[BurstCompile]
	private unsafe static void CKFJCIKIIID([NoAlias] float3* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x803AC40", Offset = "0x8039240", VA = "0x18803AC40")]
	[BurstCompile]
	private unsafe static void NNBKPAGKCNA([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80394C0", Offset = "0x8037AC0", VA = "0x1880394C0")]
	[BurstCompile]
	private unsafe static void KAELLNEGNAH([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80392A0", Offset = "0x80378A0", VA = "0x1880392A0")]
	[BurstCompile]
	private unsafe static void JJMCIGPKOEB([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8036FC0", Offset = "0x80355C0", VA = "0x188036FC0")]
	[BurstCompile]
	private unsafe static void EHNGCKLKOCM([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8039440", Offset = "0x8037A40", VA = "0x188039440")]
	[BurstCompile]
	private unsafe static void JOHGBKONENI([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8036830", Offset = "0x8034E30", VA = "0x188036830")]
	private void DLDMOFHGJOB(NativeArray<float3> JHECMPLADOK, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80367A0", Offset = "0x8034DA0", VA = "0x1880367A0")]
	[BurstCompile]
	private unsafe static void DLDMOFHGJOB([NoAlias] ushort* HLNIGNDMGJL, [Out] float3 DECAKMPEJMC, [Out] float3 ABLEGJFGEBC, [In][NoAlias] float3* JHECMPLADOK, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x803B1D0", Offset = "0x80397D0", VA = "0x18803B1D0")]
	private void ODHKMDOPDGE(NativeArray<float3> KMIGOFHCCFB, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x803B2B0", Offset = "0x80398B0", VA = "0x18803B2B0")]
	[BurstCompile]
	private unsafe static void ODHKMDOPDGE([NoAlias] ushort* JFGMDLPGKIA, [In][NoAlias] float3* KMIGOFHCCFB, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8035050", Offset = "0x8033650", VA = "0x188035050")]
	private void BLMHMNJIMAC(NativeArray<float3> JFOIAFLDLJM, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8035110", Offset = "0x8033710", VA = "0x188035110")]
	[BurstCompile]
	private unsafe static void BLMHMNJIMAC([NoAlias] float3* JFOIAFLDLJM, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8038320", Offset = "0x8036920", VA = "0x188038320")]
	[BurstCompile]
	private unsafe static void HCHOOLLPGJK([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8034D30", Offset = "0x8033330", VA = "0x188034D30")]
	[BurstCompile]
	private unsafe static void APIMLHCDHPD([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8039B20", Offset = "0x8038120", VA = "0x188039B20")]
	[BurstCompile]
	private unsafe static void KLEHADBNHPD([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8036E20", Offset = "0x8035420", VA = "0x188036E20")]
	[BurstCompile]
	private unsafe static void EEDMHACOIGC([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80378F0", Offset = "0x8035EF0", VA = "0x1880378F0")]
	[BurstCompile]
	private unsafe static void FEGEPEKJHCO([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8034AD0", Offset = "0x80330D0", VA = "0x188034AD0")]
	private void ALFFOEHBDCD(NativeArray<float2> PDJILIHBLEA, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8034A40", Offset = "0x8033040", VA = "0x188034A40")]
	[BurstCompile]
	private unsafe static void ALFFOEHBDCD([NoAlias] uint* NDOKLPKDCEL, [Out] float2 NOKJNNIHNBI, [Out] float2 NACCPECNNNM, [In][NoAlias] float2* PDJILIHBLEA, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8034DA0", Offset = "0x80333A0", VA = "0x188034DA0")]
	[BurstCompile]
	private static void BDILEADBKDF([Out] float2 BGDJIGMEPID, uint KEIGHFIPJBC, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8039180", Offset = "0x8037780", VA = "0x188039180")]
	private void JHMMPPKLCJB(NativeArray<float2> NDOKLPKDCEL, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8039100", Offset = "0x8037700", VA = "0x188039100")]
	[BurstCompile]
	private unsafe static void JHMMPPKLCJB([NoAlias] float2* NDOKLPKDCEL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8038230", Offset = "0x8036830", VA = "0x188038230")]
	[BurstCompile]
	private unsafe static void GBKGCIHOFFM([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x803AA80", Offset = "0x8039080", VA = "0x18803AA80")]
	[BurstCompile]
	private unsafe static void NBJFIMBHAHF([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80397B0", Offset = "0x8037DB0", VA = "0x1880397B0")]
	[BurstCompile]
	private unsafe static void KKODAAIMAJO([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x803B6D0", Offset = "0x8039CD0", VA = "0x18803B6D0")]
	[BurstCompile]
	private unsafe static void PBAGOKBKIIF([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x803B650", Offset = "0x8039C50", VA = "0x18803B650")]
	[BurstCompile]
	private unsafe static void PADHNHJGMIF([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8037040", Offset = "0x8035640", VA = "0x188037040")]
	private void EIFIDMNNLDH(NativeArray<float4> EFJNOEEPHBK, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8037150", Offset = "0x8035750", VA = "0x188037150")]
	[BurstCompile]
	private unsafe static void EIFIDMNNLDH([NoAlias] ushort* JNJIDDEDMAE, [In][NoAlias] float4* KJMHIJKLDDM, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8038AE0", Offset = "0x80370E0", VA = "0x188038AE0")]
	[BurstCompile]
	private static ushort JBKGHCOGLMG([In] float4 IBFCJLODHHJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8035B80", Offset = "0x8034180", VA = "0x188035B80")]
	private void CGOBCFDPLHO(NativeArray<float4> JNJIDDEDMAE, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8035C70", Offset = "0x8034270", VA = "0x188035C70")]
	[BurstCompile]
	private unsafe static void CGOBCFDPLHO([NoAlias] float4* JNJIDDEDMAE, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8038700", Offset = "0x8036D00", VA = "0x188038700")]
	[BurstCompile]
	private unsafe static void IHHNKAIELFE([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8038950", Offset = "0x8036F50", VA = "0x188038950")]
	[BurstCompile]
	private unsafe static void IKHLFAMEPDJ([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8039E50", Offset = "0x8038450", VA = "0x188039E50")]
	[BurstCompile]
	private unsafe static void MCJLBIHEDCC([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8038570", Offset = "0x8036B70", VA = "0x188038570")]
	[BurstCompile]
	private unsafe static void HNFDMINDAGE([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8036DB0", Offset = "0x80353B0", VA = "0x188036DB0")]
	[BurstCompile]
	private unsafe static void ECLNFENDEKH([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80385E0", Offset = "0x8036BE0", VA = "0x1880385E0")]
	[BurstCompile]
	private static void HNKFMEAMAJJ([Out] float4 HPCDHGHHCOO, ushort KEIGHFIPJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80371D0", Offset = "0x80357D0", VA = "0x1880371D0")]
	private void EKAFJGJLNBC(Allocator HOHBLCPFIEJ, NativeArray<float4> PMAICPIHNHJ, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8037610", Offset = "0x8035C10", VA = "0x188037610")]
	[BurstCompile]
	private unsafe static void EKAFJGJLNBC([NoAlias] float4* DMDBOIDLPIC, [NoAlias] byte* LNFFNFJGJFH, [Out] int DPBDJMHCGJM, [Out] int PKGLJJAPNPN, [NoAlias] float4* PMAICPIHNHJ, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8037C00", Offset = "0x8036200", VA = "0x188037C00")]
	private static void FLBDCINIFDK(NativeArray<float4> FEKEJMKOCBI, NativeArray<PCMCBDMPNNC> HCLIMLODNJL, NativeArray<byte> DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8037D30", Offset = "0x8036330", VA = "0x188037D30")]
	[BurstCompile]
	private unsafe static void FLBDCINIFDK([NoAlias] float4* FEKEJMKOCBI, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x803B150", Offset = "0x8039750", VA = "0x18803B150")]
	[BurstCompile]
	private unsafe static void OAMNAOGBFLM([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8039320", Offset = "0x8037920", VA = "0x188039320")]
	[BurstCompile]
	private unsafe static void JKGFBNODJHA([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8035E80", Offset = "0x8034480", VA = "0x188035E80")]
	[BurstCompile]
	private unsafe static void CLOBGBMGNLC([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8039EC0", Offset = "0x80384C0", VA = "0x188039EC0")]
	[BurstCompile]
	private unsafe static void MHKDIBFDDCO([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80345F0", Offset = "0x8032BF0", VA = "0x1880345F0")]
	[BurstCompile]
	private unsafe static void AIJMKHAFBNK([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8039540", Offset = "0x8037B40", VA = "0x188039540")]
	private void KAFHEKEHNMH(Allocator HOHBLCPFIEJ, NativeArray<int> AHNPHKDIDBJ, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8036030", Offset = "0x8034630", VA = "0x188036030")]
	private static NativeArray<byte> CMKKKOAOLPI(Allocator HOHBLCPFIEJ, NativeArray<int> AHNPHKDIDBJ, int CHIJPGAHNMB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8036310", Offset = "0x8034910", VA = "0x188036310")]
	[BurstCompile]
	private unsafe static int CMKKKOAOLPI([NoAlias] byte* FEAOPAJBNBH, [In][NoAlias] int* AHNPHKDIDBJ, int CHIJPGAHNMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80366B0", Offset = "0x8034CB0", VA = "0x1880366B0")]
	private static void DJOGNLBFJLN(NativeArray<int> EKADFKKFPJK, NativeArray<byte> LJLIEJOLAGG, int AIHHKEFNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8036640", Offset = "0x8034C40", VA = "0x188036640")]
	[BurstCompile]
	private unsafe static void DJOGNLBFJLN([NoAlias] int* EKADFKKFPJK, [In][NoAlias] byte* LJLIEJOLAGG, int AIHHKEFNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80382B0", Offset = "0x80368B0", VA = "0x1880382B0")]
	[BurstCompile]
	private unsafe static void GMPHMBADHOK([NoAlias] ushort* EKADFKKFPJK, [In][NoAlias] byte* LJLIEJOLAGG, int AIHHKEFNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80343B0", Offset = "0x80329B0", VA = "0x1880343B0")]
	[BurstCompile]
	private static void AEOOAKFCHKJ([Out] float3 BGDJIGMEPID, ushort KEIGHFIPJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8034E20", Offset = "0x8033420", VA = "0x188034E20")]
	[BurstCompile]
	private static ushort BJKMDAOLBHE([In] float3 IBFCJLODHHJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x802BD80", Offset = "0x802A380", VA = "0x18802BD80")]
	[BurstCompile]
	public unsafe static void HKBNEJDLOHI([NoAlias] float3* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8038170", Offset = "0x8036770", VA = "0x188038170")]
	[BurstCompile]
	public unsafe static void GAMFKDFLNDG([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8038640", Offset = "0x8036C40", VA = "0x188038640")]
	[BurstCompile]
	public unsafe static void IEKKJJGGBPJ([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x803A130", Offset = "0x8038730", VA = "0x18803A130")]
	[BurstCompile]
	public unsafe static void OFDKCDOHANP([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x803A130", Offset = "0x8038730", VA = "0x18803A130")]
	[BurstCompile]
	public unsafe static void MIDBAOJLCNC([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8038FA0", Offset = "0x80375A0", VA = "0x188038FA0")]
	[BurstCompile]
	public unsafe static void JECENHPFHFG([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* JHECMPLADOK, int KABGKOBDGEB, [In] float3 JPOCNCENBFC, [In] float3 ABLEGJFGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x802B590", Offset = "0x8029B90", VA = "0x18802B590")]
	[BurstCompile]
	public unsafe static void EKDIEOPIJOI([NoAlias] ushort* HLNIGNDMGJL, [Out] float3 DECAKMPEJMC, [Out] float3 ABLEGJFGEBC, [In][NoAlias] float3* JHECMPLADOK, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8035700", Offset = "0x8033D00", VA = "0x188035700")]
	[BurstCompile]
	public unsafe static void CGKEGGMMHHK([NoAlias] ushort* JFGMDLPGKIA, [In][NoAlias] float3* KMIGOFHCCFB, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8038D00", Offset = "0x8037300", VA = "0x188038D00")]
	[BurstCompile]
	public unsafe static void JDNGJCLPAJO([NoAlias] float3* JFOIAFLDLJM, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80376A0", Offset = "0x8035CA0", VA = "0x1880376A0")]
	[BurstCompile]
	public unsafe static void FCKCOFOFNDL([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8034BF0", Offset = "0x80331F0", VA = "0x188034BF0")]
	[BurstCompile]
	public unsafe static void APBBNOEABPD([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x803AEA0", Offset = "0x80394A0", VA = "0x18803AEA0")]
	[BurstCompile]
	public unsafe static void NOIGCMMPAFK([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x803AFE0", Offset = "0x80395E0", VA = "0x18803AFE0")]
	[BurstCompile]
	public unsafe static void NPFJCOGMKPF([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8037A90", Offset = "0x8036090", VA = "0x188037A90")]
	[BurstCompile]
	public unsafe static void FFNPHOAFFFO([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* KMIGOFHCCFB, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x802C340", Offset = "0x802A940", VA = "0x18802C340")]
	[BurstCompile]
	public unsafe static void ILNAODBMJMC([NoAlias] uint* NDOKLPKDCEL, [Out] float2 NOKJNNIHNBI, [Out] float2 NACCPECNNNM, [In][NoAlias] float2* PDJILIHBLEA, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x803B610", Offset = "0x8039C10", VA = "0x18803B610")]
	[BurstCompile]
	public static void OKNFDIEMPAC([Out] float2 BGDJIGMEPID, uint KEIGHFIPJBC, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x803B500", Offset = "0x8039B00", VA = "0x18803B500")]
	[BurstCompile]
	public unsafe static void OFPLLAPLPAF([NoAlias] float2* NDOKLPKDCEL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x803AB00", Offset = "0x8039100", VA = "0x18803AB00")]
	[BurstCompile]
	public unsafe static void NDJANHOJNNN([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80354A0", Offset = "0x8033AA0", VA = "0x1880354A0")]
	[BurstCompile]
	public unsafe static void CEFPPDHFPAP([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8036B90", Offset = "0x8035190", VA = "0x188036B90")]
	[BurstCompile]
	public unsafe static void EBCHIGDAOHF([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8037960", Offset = "0x8035F60", VA = "0x188037960")]
	[BurstCompile]
	public unsafe static void FEHDNJHPJFP([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8036E90", Offset = "0x8035490", VA = "0x188036E90")]
	[BurstCompile]
	public unsafe static void EEHIJMGBGPO([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [NoAlias] uint* PDJILIHBLEA, int KABGKOBDGEB, [In] float2 AEOKEGOPDOL, [In] float2 NACCPECNNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8035620", Offset = "0x8033C20", VA = "0x188035620")]
	[BurstCompile]
	public unsafe static void CFFMBHIOOEP([NoAlias] ushort* JNJIDDEDMAE, [In][NoAlias] float4* KJMHIJKLDDM, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8039D00", Offset = "0x8038300", VA = "0x188039D00")]
	[BurstCompile]
	public static ushort LHMEFGGFANN([In] float4 IBFCJLODHHJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80389C0", Offset = "0x8036FC0", VA = "0x1880389C0")]
	[BurstCompile]
	public unsafe static void IOKNNMBBFNP([NoAlias] float4* JNJIDDEDMAE, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8039830", Offset = "0x8037E30", VA = "0x188039830")]
	[BurstCompile]
	public unsafe static void KLAEHEBEAGL([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8039640", Offset = "0x8037C40", VA = "0x188039640")]
	[BurstCompile]
	public unsafe static void KGHHKGHNGCC([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x803A910", Offset = "0x8038F10", VA = "0x18803A910")]
	[BurstCompile]
	public unsafe static void MODNIHOGIGK([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8038B30", Offset = "0x8037130", VA = "0x188038B30")]
	[BurstCompile]
	public unsafe static void JCFMIAGCMIP([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80359B0", Offset = "0x8033FB0", VA = "0x1880359B0")]
	[BurstCompile]
	public unsafe static void CGNLNOFLHJI([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] ushort* EFJNOEEPHBK, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8039D90", Offset = "0x8038390", VA = "0x188039D90")]
	[BurstCompile]
	public static void LPKFCCIFGJO([Out] float4 HPCDHGHHCOO, ushort KEIGHFIPJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x802C180", Offset = "0x802A780", VA = "0x18802C180")]
	[BurstCompile]
	public unsafe static void IKOKMKJOLHO([NoAlias] float4* DMDBOIDLPIC, [NoAlias] byte* LNFFNFJGJFH, [Out] int DPBDJMHCGJM, [Out] int PKGLJJAPNPN, [NoAlias] float4* PMAICPIHNHJ, int LNDPOAIFNJD, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8035360", Offset = "0x8033960", VA = "0x188035360")]
	[BurstCompile]
	public unsafe static void CBBHEEOOAKN([NoAlias] float4* FEKEJMKOCBI, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x803ACC0", Offset = "0x80392C0", VA = "0x18803ACC0")]
	[BurstCompile]
	public unsafe static void NNHPMGMNEKD([NoAlias] JOHNDGNODKM.BEEFPAOJJLA* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8034860", Offset = "0x8032E60", VA = "0x188034860")]
	[BurstCompile]
	public unsafe static void AKLKECBIFMF([NoAlias] JOHNDGNODKM.HBAJGOADLHJ* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x803B990", Offset = "0x8039F90", VA = "0x18803B990")]
	[BurstCompile]
	public unsafe static void PPHFJGKPPGF([NoAlias] JOHNDGNODKM.GKCHEPKAFKP* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8036950", Offset = "0x8034F50", VA = "0x188036950")]
	[BurstCompile]
	public unsafe static void EAEEONHLGEA([NoAlias] JOHNDGNODKM.MHHLOPGOHBK* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x803B750", Offset = "0x8039D50", VA = "0x18803B750")]
	[BurstCompile]
	public unsafe static void PBFICDOMKDE([NoAlias] JOHNDGNODKM.FLGLCKDGDCN* HLNIGNDMGJL, [In][NoAlias] PCMCBDMPNNC* HCLIMLODNJL, [In][NoAlias] byte* DPJMHKJKJPC, int KABGKOBDGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8036380", Offset = "0x8034980", VA = "0x188036380")]
	[BurstCompile]
	public unsafe static int COJCFIIPFKO([NoAlias] byte* FEAOPAJBNBH, [In][NoAlias] int* AHNPHKDIDBJ, int CHIJPGAHNMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x80393A0", Offset = "0x80379A0", VA = "0x1880393A0")]
	[BurstCompile]
	public unsafe static void JNBDIODFEJA([NoAlias] int* EKADFKKFPJK, [In][NoAlias] byte* LJLIEJOLAGG, int AIHHKEFNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8036480", Offset = "0x8034A80", VA = "0x188036480")]
	[BurstCompile]
	public unsafe static void COJDPNGELEM([NoAlias] ushort* EKADFKKFPJK, [In][NoAlias] byte* LJLIEJOLAGG, int AIHHKEFNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x802BFE0", Offset = "0x802A5E0", VA = "0x18802BFE0")]
	[BurstCompile]
	public static void HNGNFDAMONE([Out] float3 BGDJIGMEPID, ushort KEIGHFIPJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x802BBC0", Offset = "0x802A1C0", VA = "0x18802BBC0")]
	[BurstCompile]
	public static ushort FHIOHBMCGLD([In] float3 IBFCJLODHHJ)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class JOHNDGNODKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum DLPLPJGMGAK
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
	public enum HKMHNFLLJNA
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
	public struct EDIIBFLGDCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DLPLPJGMGAK MCLEKLAABMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool HAKLHOJENAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int NLNFOINBAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] MFJEDPOBALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct OGDPOMLCOKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 NHLFNDFGAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 IFDADDNBHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 FABHMFNHHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 APGLNJGBNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 PEKKOAHHCKB;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] MFJEDPOBALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct BEEFPAOJJLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 NHLFNDFGAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 IFDADDNBHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 FABHMFNHHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 APGLNJGBNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 PEKKOAHHCKB;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] MFJEDPOBALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct HBAJGOADLHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 NHLFNDFGAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint IFDADDNBHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint FABHMFNHHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 APGLNJGBNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 PEKKOAHHCKB;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] MFJEDPOBALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct GKCHEPKAFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 NHLFNDFGAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint IFDADDNBHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint FABHMFNHHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 APGLNJGBNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 PEKKOAHHCKB;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] MFJEDPOBALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct MHHLOPGOHBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 NHLFNDFGAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint IPANDDAKNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 APGLNJGBNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint NDEKEABBCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint BBGDKDCBDON;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] MFJEDPOBALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct FLGLCKDGDCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public KGACNPDCBBH.BBGKHHPLNAL FKDAEPBBLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint IPANDDAKNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 APGLNJGBNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint NDEKEABBCCI;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] MFJEDPOBALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int OENJCMPPJAB(float POMHCCBBBGD);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class EBBOBHNGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8033C20", Offset = "0x8032220", VA = "0x188033C20")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8033AC0", Offset = "0x80320C0", VA = "0x188033AC0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8033A10", Offset = "0x8032010", VA = "0x188033A10")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x80337A0", Offset = "0x8031DA0", VA = "0x1880337A0")]
		public static int GHDKDALNEMC(float POMHCCBBBGD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint CJLFFIAKMOC([In] float4 JIJNMCDLDDE);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class OLJCNNGKEHC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8051AB0", Offset = "0x80500B0", VA = "0x188051AB0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8051950", Offset = "0x804FF50", VA = "0x188051950")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x80518A0", Offset = "0x804FEA0", VA = "0x1880518A0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8051560", Offset = "0x804FB60", VA = "0x188051560")]
		public static uint GHDKDALNEMC([In] float4 JIJNMCDLDDE)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint EOIJONIPNJD([In] float3 JIJNMCDLDDE);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class KEOHEGIMFDP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8049DC0", Offset = "0x80483C0", VA = "0x188049DC0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8049C60", Offset = "0x8048260", VA = "0x188049C60")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8049BB0", Offset = "0x80481B0", VA = "0x188049BB0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8049930", Offset = "0x8047F30", VA = "0x188049930")]
		public static uint GHDKDALNEMC([In] float3 JIJNMCDLDDE)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void INBHNGDMPMH([NoAlias] HBAJGOADLHJ* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class JJICPHGOKHC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x80419D0", Offset = "0x803FFD0", VA = "0x1880419D0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8041870", Offset = "0x803FE70", VA = "0x188041870")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x80417C0", Offset = "0x803FDC0", VA = "0x1880417C0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8041580", Offset = "0x803FB80", VA = "0x188041580")]
		public unsafe static void GHDKDALNEMC([NoAlias] HBAJGOADLHJ* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void PAGGJBKFMNB([NoAlias] GKCHEPKAFKP* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class AJJNGEIDPKB
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x802ED50", Offset = "0x802D350", VA = "0x18802ED50")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x802EBF0", Offset = "0x802D1F0", VA = "0x18802EBF0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x802EB40", Offset = "0x802D140", VA = "0x18802EB40")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x802E900", Offset = "0x802CF00", VA = "0x18802E900")]
		public unsafe static void GHDKDALNEMC([NoAlias] GKCHEPKAFKP* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void HNFFBBHPABJ([NoAlias] MHHLOPGOHBK* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class LKPIHDAKJBI
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x804C4E0", Offset = "0x804AAE0", VA = "0x18804C4E0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x804C380", Offset = "0x804A980", VA = "0x18804C380")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x804C2D0", Offset = "0x804A8D0", VA = "0x18804C2D0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x804BEE0", Offset = "0x804A4E0", VA = "0x18804BEE0")]
		public unsafe static void GHDKDALNEMC([NoAlias] MHHLOPGOHBK* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void FBHKLPNKHBJ([NoAlias] FLGLCKDGDCN* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB, [Out] float3 ADFODCIOKDI, [Out] float3 OFGAOHACFOD);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class KAMCIKFBHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8049800", Offset = "0x8047E00", VA = "0x188049800")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x80496A0", Offset = "0x8047CA0", VA = "0x1880496A0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x80495F0", Offset = "0x8047BF0", VA = "0x1880495F0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8049090", Offset = "0x8047690", VA = "0x188049090")]
		public unsafe static void GHDKDALNEMC([NoAlias] FLGLCKDGDCN* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB, [Out] float3 ADFODCIOKDI, [Out] float3 OFGAOHACFOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int GCJEJBLIJFM = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> OJJKAOLLJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> CEECJMPCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> OKNPPMHAECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> JHAJLJLMCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> CAMKOJIMJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> GDBIONGPMCA;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] LJLOGNKDMBH;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool GDEJECBPCFE;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static EDIIBFLGDCF[] CNGMDIAJPFN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NGPOKKIJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8045080", Offset = "0x8043680", VA = "0x188045080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FPAGOELIBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8043A00", Offset = "0x8042000", VA = "0x188043A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EAEIKGJDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8045190", Offset = "0x8043790", VA = "0x188045190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DIFMPMJMPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x80420C0", Offset = "0x80406C0", VA = "0x1880420C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x8045140", Offset = "0x8043740", VA = "0x188045140")]
	public static HKMHNFLLJNA KHEOMPDAGJP(DLPLPJGMGAK MCLEKLAABMK)
	{
		return default(HKMHNFLLJNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8042550", Offset = "0x8040B50", VA = "0x188042550")]
	public static void CKKKLNHINHH(HKMHNFLLJNA GNCFJJKCMIB, Material KKIOJDIOKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x8042AF0", Offset = "0x80410F0", VA = "0x188042AF0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x8042610", Offset = "0x8040C10", VA = "0x188042610")]
	public void CMAKEHGLHJI(int MNAPDCDOKHC, int IGENIDBBLGE, Allocator HOHBLCPFIEJ, bool HLFCAFFNINP, bool KOGDOLOLJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x80450C0", Offset = "0x80436C0", VA = "0x1880450C0")]
	public void KGEDJPJHFDA(int MNAPDCDOKHC, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x80420A0", Offset = "0x80406A0", VA = "0x1880420A0", Slot = "6")]
	public bool AODAFBHMLHL(Mesh IDMOPPBKAAO, bool GCEPEEFNCHO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x80480F0", Offset = "0x80466F0", VA = "0x1880480F0")]
	public bool OPENPEJLCOH(Mesh IDMOPPBKAAO, bool GCEPEEFNCHO, bool NIOKPKANEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8042FA0", Offset = "0x80415A0", VA = "0x188042FA0")]
	public bool EFHGPJKOHDC(Mesh IDMOPPBKAAO, JOHNDGNODKM KDJECFCHKGI, bool GCEPEEFNCHO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x80434A0", Offset = "0x8041AA0", VA = "0x1880434A0")]
	public bool FIOCOBCJNIH(Mesh IDMOPPBKAAO, JOHNDGNODKM KDJECFCHKGI, DLPLPJGMGAK MCLEKLAABMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8046900", Offset = "0x8044F00", VA = "0x188046900")]
	private void MJAHJAGLGNH(Mesh IDMOPPBKAAO, JOHNDGNODKM KDJECFCHKGI, bool NIOKPKANEKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8047090", Offset = "0x8045690", VA = "0x188047090")]
	public void MJAHJAGLGNH(NativeArray<ushort> MDOOGKCLNDJ, NativeArray<MHHLOPGOHBK> AONOGIBIGAJ, Mesh IDMOPPBKAAO, JOHNDGNODKM KDJECFCHKGI, bool NIOKPKANEKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x8043A40", Offset = "0x8042040", VA = "0x188043A40")]
	public void ICGJLADMEPG(Mesh IDMOPPBKAAO, bool NIOKPKANEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8043920", Offset = "0x8041F20", VA = "0x188043920")]
	[BurstCompile]
	public static int GKILFNDECJF(float POMHCCBBBGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x80438D0", Offset = "0x8041ED0", VA = "0x1880438D0")]
	[BurstCompile]
	public static uint GKILFNDECJF([In] float4 JIJNMCDLDDE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8043880", Offset = "0x8041E80", VA = "0x188043880")]
	[BurstCompile]
	public static uint GKILFNDECJF([In] float3 JIJNMCDLDDE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8046270", Offset = "0x8044870", VA = "0x188046270")]
	public void MFPGDAHLHBI(Mesh IDMOPPBKAAO, bool NIOKPKANEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x80473A0", Offset = "0x80459A0", VA = "0x1880473A0")]
	[BurstCompile]
	private unsafe static void NADKFGPCAMA([NoAlias] HBAJGOADLHJ* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8047780", Offset = "0x8045D80", VA = "0x188047780")]
	public void OHIICLDPKCI(Mesh IDMOPPBKAAO, bool NIOKPKANEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8047420", Offset = "0x8045A20", VA = "0x188047420")]
	[BurstCompile]
	private unsafe static void OCAABGNCCNB([NoAlias] GKCHEPKAFKP* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x80484F0", Offset = "0x8046AF0", VA = "0x1880484F0")]
	public void PENHOCEOAOH(Mesh IDMOPPBKAAO, bool NIOKPKANEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x80488C0", Offset = "0x8046EC0", VA = "0x1880488C0")]
	public void PENHOCEOAOH(NativeArray<ushort> FJICBKCLHKB, NativeArray<MHHLOPGOHBK> ECODDHEEFOM, Mesh IDMOPPBKAAO, bool NIOKPKANEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8042A70", Offset = "0x8041070", VA = "0x188042A70")]
	[BurstCompile]
	public unsafe static void DMKONIADCCN([NoAlias] MHHLOPGOHBK* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8044840", Offset = "0x8042E40", VA = "0x188044840")]
	public void IFLIECDCBGN(Mesh IDMOPPBKAAO, bool NIOKPKANEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8045C30", Offset = "0x8044230", VA = "0x188045C30")]
	[BurstCompile]
	private unsafe static void MDLGHIDAEMA([NoAlias] FLGLCKDGDCN* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB, [Out] float3 ADFODCIOKDI, [Out] float3 OFGAOHACFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8043970", Offset = "0x8041F70", VA = "0x188043970")]
	public void HBMBCHLJIJD(Mesh IDMOPPBKAAO, DLPLPJGMGAK MCLEKLAABMK, bool NIOKPKANEKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8042800", Offset = "0x8040E00", VA = "0x188042800")]
	public void DJMKPHJGGIE(JOHNDGNODKM IDMOPPBKAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8044F80", Offset = "0x8043580", VA = "0x188044F80")]
	public void IPILHLKEAMF(JOHNDGNODKM INCFEGIJJJL, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8045A80", Offset = "0x8044080", VA = "0x188045A80")]
	public long LHGBIGIHOLH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8045BD0", Offset = "0x80441D0", VA = "0x188045BD0")]
	public static long LHGBIGIHOLH(int ILNNBOALEIF, int EGODLAJCBMF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x80459E0", Offset = "0x8043FE0", VA = "0x1880459E0")]
	public static long LBPJGFIAILG(int ILNNBOALEIF, int EGODLAJCBMF, DLPLPJGMGAK MCLEKLAABMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x8045920", Offset = "0x8043F20", VA = "0x188045920")]
	public long LBPJGFIAILG(DLPLPJGMGAK MCLEKLAABMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x8042C00", Offset = "0x8041200", VA = "0x188042C00")]
	public void EBONOEAEPNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8045CB0", Offset = "0x80442B0", VA = "0x188045CB0")]
	public static void MFPDKCDJPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x80451D0", Offset = "0x80437D0", VA = "0x1880451D0")]
	public DLPLPJGMGAK KOCLGCCADCI()
	{
		return default(DLPLPJGMGAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x80437B0", Offset = "0x8041DB0", VA = "0x1880437B0")]
	public static (int, int) GFOPOIHMDPD(Mesh IDMOPPBKAAO)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8048010", Offset = "0x8046610", VA = "0x188048010")]
	public static int OMEKNOBNODD(VertexAttributeDescriptor[] LDHKEBCGIPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8043610", Offset = "0x8041C10", VA = "0x188043610")]
	public static long FNBHAPDBGCF(Mesh IDMOPPBKAAO, int ILCOLEOMCIJ, int HOAGKIHMADH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8043680", Offset = "0x8041C80", VA = "0x188043680")]
	public static long FNBHAPDBGCF(Mesh IDMOPPBKAAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JOHNDGNODKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x80476E0", Offset = "0x8045CE0", VA = "0x1880476E0")]
	[BurstCompile]
	public static int OFBIDPMOEMF(float POMHCCBBBGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x80474A0", Offset = "0x8045AA0", VA = "0x1880474A0")]
	[BurstCompile]
	public static uint OFBIDPMOEMF([In] float4 JIJNMCDLDDE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8047630", Offset = "0x8045C30", VA = "0x188047630")]
	[BurstCompile]
	public static uint OFBIDPMOEMF([In] float3 JIJNMCDLDDE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8044480", Offset = "0x8042A80", VA = "0x188044480")]
	[BurstCompile]
	public unsafe static void ICPCOFFMIAP([NoAlias] HBAJGOADLHJ* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8042100", Offset = "0x8040700", VA = "0x188042100")]
	[BurstCompile]
	public unsafe static void CGBLPCLNHKH([NoAlias] GKCHEPKAFKP* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8047E10", Offset = "0x8046410", VA = "0x188047E10")]
	[BurstCompile]
	public unsafe static void OKKFOELHLLG([NoAlias] MHHLOPGOHBK* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8042C60", Offset = "0x8041260", VA = "0x188042C60")]
	[BurstCompile]
	public unsafe static void EEKDCHJHKIG([NoAlias] FLGLCKDGDCN* HLNIGNDMGJL, int KABGKOBDGEB, [In][NoAlias] float3* LEGHMOIFMOP, [In][NoAlias] float3* NJFMDNHHIJF, [In][NoAlias] float4* DIGJAIJPCPM, [In][NoAlias] float2* NOIBLEJCHKO, [In][NoAlias] float4* PEKKOAHHCKB, [Out] float3 ADFODCIOKDI, [Out] float3 OFGAOHACFOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct POFJLBIHJDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int IMGGFDKMIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 JFGBBNNANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion IOENIOAFHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 HDOAMPMCOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int PFNPFBIHOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int AKMCIMNLAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int HCNBMJPANKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float DNMLDIOIFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 LBOKOIGMABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool PHNDLOKMCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public DDEGPPICJGJ MIKIKPIPBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 LLEHKGBFEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float BGEJLBNBHNG;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class AKEMDMPFBPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static GDMABCGDCIE CIMJEPLEMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<POFJLBIHJDD> BNBFPFIHGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<DBBEOABNPNA> EKECEGCOPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<FIIHBOCJHGE> CGGMNFHDMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<FEALKEEJBEM> LCNDILFKNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<DBBEOABNPNA> OLCJJCCDJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<PDOLDJNLBNK> JOMCCFFEEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<FEALKEEJBEM>> ODKCIDNNCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<OMIDOJNADAI> GAGGNBCKFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> FMPMICJFNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> KIBEPOEDHAK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<JFFFMDLEDBA.MDOOJJDOLJF> BJOILCAOODH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FPAGOELIBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA54B60", Offset = "0xA53160", VA = "0x180A54B60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA54B80", Offset = "0xA53180", VA = "0x180A54B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EAEIKGJDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xCC9E90", Offset = "0xCC8490", VA = "0x180CC9E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xCC9EA0", Offset = "0xCC84A0", VA = "0x180CC9EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x80314B0", Offset = "0x802FAB0", VA = "0x1880314B0")]
	public AKEMDMPFBPH(int BNPFANDDOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8030B60", Offset = "0x802F160", VA = "0x188030B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x8030970", Offset = "0x802EF70", VA = "0x188030970")]
	public void DIGOPEEDGGN(JobHandle JNHDFACBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x802F3F0", Offset = "0x802D9F0", VA = "0x18802F3F0")]
	public void BMIKBDNKEKF(POFJLBIHJDD ACJFHCNBBBO, OMIDOJNADAI HBGGJDIOPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x80310C0", Offset = "0x802F6C0", VA = "0x1880310C0")]
	public void MDNMIGAGAJF(FIIHBOCJHGE ACJFHCNBBBO, NativeArray<FEALKEEJBEM> BFOBOGCINLC, int KABGKOBDGEB, int AIHHKEFNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x802F620", Offset = "0x802DC20", VA = "0x18802F620")]
	public JobHandle DGGKNEPGBCH(JOHNDGNODKM GNAJGBKGNGN, JDIPKNPCLDJ PJABPPGEPIK, float3 NBBLCBIKICE, quaternion BNABPDCIJJD, float OHKPAJKDIEF, bool GJKPKMDMGCJ, int KBAECJMPDNE = 0, int FELBDCFBIDB = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x802F740", Offset = "0x802DD40", VA = "0x18802F740")]
	public JobHandle DGGKNEPGBCH(JOHNDGNODKM GNAJGBKGNGN, JDIPKNPCLDJ PJABPPGEPIK, NativeList<JFFFMDLEDBA.MDOOJJDOLJF> AEPOHJJGNHF, float3 NBBLCBIKICE, quaternion BNABPDCIJJD, float OHKPAJKDIEF, bool GJKPKMDMGCJ, bool ANKNBGFJOCC, int KBAECJMPDNE = 0, int FELBDCFBIDB = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8030D40", Offset = "0x802F340", VA = "0x188030D40")]
	public static JobHandle LNLMKNENHOE(AOAACPPODAJ CJMFGEDFBJN, JOHNDGNODKM GNAJGBKGNGN, NativeArray<int> KIBEPOEDHAK, POFJLBIHJDD ACJFHCNBBBO, JobHandle JNHDFACBLOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x8031200", Offset = "0x802F800", VA = "0x188031200")]
	public static JobHandle MOAHBAMGDMF(FBLPICJIPDL CJMFGEDFBJN, JOHNDGNODKM GNAJGBKGNGN, FIIHBOCJHGE ACJFHCNBBBO, NativeArray<FEALKEEJBEM> BFOBOGCINLC, int KABGKOBDGEB, int AIHHKEFNBIM, JobHandle JNHDFACBLOI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class CHOJAKIIMFE
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct BFKEPCCGINM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer ILMDPGBOCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public GHBPHDOJNAO.LMCGFJGHHLL OKEEKFKPKCJ;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0F70", Offset = "0x5EBF570", VA = "0x185EC0F70")]
		public BFKEPCCGINM(MeshRenderer ILMDPGBOCFL, GHBPHDOJNAO.LMCGFJGHHLL OKEEKFKPKCJ)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8053630", Offset = "0x8051C30", VA = "0x188053630")]
		public static BFKEPCCGINM EIMKEBEILPD((MeshRenderer, GHBPHDOJNAO.LMCGFJGHHLL) JGPHMOHCCLH)
		{
			return default(BFKEPCCGINM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker DLAFKDMPKNB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker MOGEFEHOCCJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker PHLKIEGIHIO;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker FMHGEHINDBH;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8056910", Offset = "0x8054F10", VA = "0x188056910")]
	internal void NDKDAELIJBN(GameObject LMCNGALHOAF, GHBPHDOJNAO.CJHMCAMNCNK HCLMJHFPGEL, List<BFKEPCCGINM> OFGGJJPABEH, Material KKIOJDIOKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x80560E0", Offset = "0x80546E0", VA = "0x1880560E0")]
	internal void MFOCNDKMOGG(GameObject LMCNGALHOAF, GHBPHDOJNAO.CJHMCAMNCNK HCLMJHFPGEL, List<BFKEPCCGINM> OFGGJJPABEH, List<LODGroup> BDKPBOEONEL, Material KKIOJDIOKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8055660", Offset = "0x8053C60", VA = "0x188055660")]
	private MeshRenderer MCDAOBNGAPP(GHBPHDOJNAO.CJHMCAMNCNK HCLMJHFPGEL, Material KKIOJDIOKCM, List<BFKEPCCGINM> OFGGJJPABEH, bool BMHFMCEKIKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x80538B0", Offset = "0x8051EB0", VA = "0x1880538B0")]
	private List<(List<BFKEPCCGINM>, float)> APDBDLMFNOK(GHBPHDOJNAO.CJHMCAMNCNK HCLMJHFPGEL, List<LODGroup> BDKPBOEONEL, Material KKIOJDIOKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x8054900", Offset = "0x8052F00", VA = "0x188054900")]
	private List<List<(List<BFKEPCCGINM>, float)>> MAEJFKKOFHN(GHBPHDOJNAO.CJHMCAMNCNK HCLMJHFPGEL, List<LODGroup> BDKPBOEONEL, Material KKIOJDIOKCM, [Out] int DDOOAJEPELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CHOJAKIIMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8054790", Offset = "0x8052D90", VA = "0x188054790")]
	[CompilerGenerated]
	internal static (float, int) JCFMGFDOCPH(List<List<(List<BFKEPCCGINM> meshList, float lodTransition)>> LGMNMFINION, int[] GAALDKLMFMJ)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class JKCLKAICHMH
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker KBKEOAJHLKL;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker HMPJIKPEMPL;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker KMHFEGDNCBA;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker IBHCNNMEFHC;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker EKPGAMKFHAO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker IIOHJHOKOKJ;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker ONOAPECHNNO;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly LHMKAIAPMBI HAOFODGCEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GHBPHDOJNAO PFEFFNDKKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CHOJAKIIMFE GNLMMKEONNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader GJBKBOMJNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock PCGIJDFHFCA;

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8064CB0", Offset = "0x80632B0", VA = "0x188064CB0")]
	public static void ALKGJHCMHNO(GameObject LMCNGALHOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8065560", Offset = "0x8063B60", VA = "0x188065560")]
	public void FLMOPKJJIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8066150", Offset = "0x8064750", VA = "0x188066150")]
	public void MLELDLPOBOE(GameObject LMCNGALHOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8065DA0", Offset = "0x80643A0", VA = "0x188065DA0")]
	private bool JANGMGONEPA(MeshRenderer ILMDPGBOCFL, [Out] MeshFilter POCOLGCEFDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x80670B0", Offset = "0x80656B0", VA = "0x1880670B0")]
	private bool PHCKLFKNCFE(int KHMHPNKMLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8065F20", Offset = "0x8064520", VA = "0x188065F20")]
	private void LAEICHPPBMK(GameObject LMCNGALHOAF, int KHMHPNKMLMD, Material KKIOJDIOKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8066900", Offset = "0x8064F00", VA = "0x188066900")]
	private List<CHOJAKIIMFE.BFKEPCCGINM> NOBJOAFGAOM(int KHMHPNKMLMD, [Out] List<LODGroup> BDKPBOEONEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8066390", Offset = "0x8064990", VA = "0x188066390")]
	private List<(int, Material)> NBGHPODALJN(float EDBELFPBMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8065CF0", Offset = "0x80642F0", VA = "0x188065CF0")]
	public void GLGIKECFEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8065030", Offset = "0x8063630", VA = "0x188065030")]
	private bool CGFOIFAKIAF(GameObject KGMBEOBCDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8067530", Offset = "0x8065B30", VA = "0x188067530")]
	public JKCLKAICHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class GHBPHDOJNAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct CJHMCAMNCNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 CMGDLKAFPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 LPAMMAPPJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float JDHLBGBJFCG;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x80572F0", Offset = "0x80558F0", VA = "0x1880572F0")]
		public CJHMCAMNCNK(Bounds ACMLBEHJCNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8057460", Offset = "0x8055A60", VA = "0x188057460")]
		public CJHMCAMNCNK(float3 CMGDLKAFPEE, float3 LPAMMAPPJAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct DEOJELHIFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CJHMCAMNCNK POMMDFBKEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int COMLGJMHJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int GFNGAEINBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float EPFLPPIBCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int MNAPDCDOKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int EHECHHJODJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int LPGEDHPEILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int NLAGKNGNEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int MNFDOLPJDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool LEMDPOOOELL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct LMCGFJGHHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh GAMNJOHBFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 GHOAGKLPPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int AIBMNLCBPHH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct EKKCGEHHGAE : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<DEOJELHIFKP> PLMEBPLFEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> LBGECFLOADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int LPCENFBJEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CJHMCAMNCNK ACMLBEHJCNK;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x805B910", Offset = "0x8059F10", VA = "0x18805B910")]
		private float AEAFIILEPGN(CJHMCAMNCNK DLGEPLKGJOC, CJHMCAMNCNK OKKFDNDPGLP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x805BA40", Offset = "0x805A040", VA = "0x18805BA40", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker DEFHLLNDOJL;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker HLEILCLHJCG;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker ILDKGHDNBAJ;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker GOOPNEHALJP;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker OPGBKHIBDHL;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker IKLHFFFOLFA;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker HLPMHECFJID;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker NPAGIODGIDO;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker LIBNBEFPGFD;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker ICFKAIHAFCH;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker ILDDIAHEKCO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker PNMLGCGPMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<DEOJELHIFKP> PLMEBPLFEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> AIMHMDAEJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int JDIKNHGPJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> GEOMGJBOAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<LMCGFJGHHLL> IAKOCMKGHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> BDKPBOEONEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> COLGIDONHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> CMNHEPMJODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader JDJEDFGJOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader EJPCEIGBOBI;

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8060170", Offset = "0x805E770", VA = "0x188060170")]
	public GHBPHDOJNAO(int CDLIKKNPPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x805E3C0", Offset = "0x805C9C0", VA = "0x18805E3C0")]
	private void JJDIJOFCOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x805ED30", Offset = "0x805D330", VA = "0x18805ED30")]
	public bool PIKCKHGEDDI(MeshRenderer OKDBLNAJAPD, MeshFilter GDMKBKHGDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x805F1C0", Offset = "0x805D7C0", VA = "0x18805F1C0")]
	public bool PIKCKHGEDDI(LODGroup JFIEIJLADDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x805DFE0", Offset = "0x805C5E0", VA = "0x18805DFE0")]
	private bool JEFAFDBINCI(MeshRenderer OKDBLNAJAPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x805C7A0", Offset = "0x805ADA0", VA = "0x18805C7A0")]
	private int EOJMBEFBOPG(MeshRenderer OKDBLNAJAPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x805C8C0", Offset = "0x805AEC0", VA = "0x18805C8C0")]
	private int GAIAAPNMKLB(LODGroup JFIEIJLADDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x805E970", Offset = "0x805CF70", VA = "0x18805E970")]
	private int LHGPPCNHEAM(MeshFilter GDMKBKHGDCJ, int LABAPBFICLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x805E060", Offset = "0x805C660", VA = "0x18805E060")]
	private int JGIDCCLDIBO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x805D7B0", Offset = "0x805BDB0", VA = "0x18805D7B0")]
	private static CJHMCAMNCNK IGGPBLAHPPF(CJHMCAMNCNK DLGEPLKGJOC, CJHMCAMNCNK OKKFDNDPGLP)
	{
		return default(CJHMCAMNCNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x805CEE0", Offset = "0x805B4E0", VA = "0x18805CEE0")]
	private static float GGEOIGAHJEB(Vector3 CMGDLKAFPEE, Vector3 LPAMMAPPJAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x805D030", Offset = "0x805B630", VA = "0x18805D030")]
	private int HAKGKHCHGCD(int COJDICCCJGI, CJHMCAMNCNK MLOFIFFFGPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x805EAD0", Offset = "0x805D0D0", VA = "0x18805EAD0")]
	private void PAKCPMHEJEC(CJHMCAMNCNK MLOFIFFFGPI, int KHMHPNKMLMD, [Out] float GEMLBGFKPGC, [Out] float DJCBBEOALIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x805DB60", Offset = "0x805C160", VA = "0x18805DB60")]
	private void IJGDPFFLCHJ(CJHMCAMNCNK MLOFIFFFGPI, int CCOMCMBKMOF, Material KKIOJDIOKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x805C4B0", Offset = "0x805AAB0", VA = "0x18805C4B0")]
	private float AEAFIILEPGN(CJHMCAMNCNK DLGEPLKGJOC, CJHMCAMNCNK OKKFDNDPGLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x805E530", Offset = "0x805CB30", VA = "0x18805E530")]
	private void KHOGKJKDGJM(int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x805D360", Offset = "0x805B960", VA = "0x18805D360")]
	private void HINHABFKBIG(int DKLPAIPBKGC, int KPLPIBOJLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x805C930", Offset = "0x805AF30", VA = "0x18805C930")]
	private void GBECAPKMPLF(int DKLPAIPBKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x805C6F0", Offset = "0x805ACF0", VA = "0x18805C6F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct FBEKKCFPBDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 FKCGNHACNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 BBIEEIIPMBB;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class BKAIGMEALKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<FBEKKCFPBDH> MCMMFKCOPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> DFOAKHIMECN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FPAGOELIBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EAEIKGJDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x80537F0", Offset = "0x8051DF0", VA = "0x1880537F0")]
	public BKAIGMEALKL(int MNAPDCDOKHC, int IGENIDBBLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x8053790", Offset = "0x8051D90", VA = "0x188053790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x80536B0", Offset = "0x8051CB0", VA = "0x1880536B0")]
	public void DJMKPHJGGIE(BKAIGMEALKL GCLEFDFIFHG, int KFKINALANEP, int IGHNHCKLCCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class DPOEBCBKOMG
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static BKAIGMEALKL JOGAHFPDHNH;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<DBBEOABNPNA> PJLNIANOBKH;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] PEICGOPDLLG;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool COCPKACMPCK;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, BKAIGMEALKL> OLDOAFIPOIH;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, BKAIGMEALKL> BNJCJKEKALM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool BNIAPNBDOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x805B6D0", Offset = "0x8059CD0", VA = "0x18805B6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<DBBEOABNPNA> IAAIJGOLHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x805B520", Offset = "0x8059B20", VA = "0x18805B520")]
		get
		{
			return default(NativeList<DBBEOABNPNA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BKAIGMEALKL HINKBCJCMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x805AA70", Offset = "0x8059070", VA = "0x18805AA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x805AE50", Offset = "0x8059450", VA = "0x18805AE50")]
	private static void ICMOFOKBKFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x805B750", Offset = "0x8059D50", VA = "0x18805B750")]
	public static int MICHKEKGGHN(bool KDLLIHJCNOO, int DAIFOFJAHFO, bool CMDDEMMIMIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x805B460", Offset = "0x8059A60", VA = "0x18805B460")]
	private static int IHBEBPFENCB(int DAIFOFJAHFO, bool NFCPIIGFIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x805B790", Offset = "0x8059D90", VA = "0x18805B790")]
	private static int MNIDCPIKJCN(int DAIFOFJAHFO, bool NFCPIIGFIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x805AB10", Offset = "0x8059110", VA = "0x18805AB10")]
	public static int GGCAKPNOMIH(int CLFLCICHDCN, int DAIFOFJAHFO, int OIJHFILKHMA, bool NFCPIIGFIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x805B480", Offset = "0x8059A80", VA = "0x18805B480")]
	public static int IINKKOFPHHC(int CLFLCICHDCN, int DAIFOFJAHFO, int OIJHFILKHMA, bool NFCPIIGFIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x805B510", Offset = "0x8059B10", VA = "0x18805B510")]
	public static int JDEGBFKPNPL(int OIJHFILKHMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x805B780", Offset = "0x8059D80", VA = "0x18805B780")]
	private static int MNHOMNBEGDA(int DAIFOFJAHFO, bool NFCPIIGFIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x805ABA0", Offset = "0x80591A0", VA = "0x18805ABA0")]
	private static int HIKNDKLDLED(int DAIFOFJAHFO, bool NFCPIIGFIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x805A5F0", Offset = "0x8058BF0", VA = "0x18805A5F0")]
	public static int CEMPOJNAIBD(int CLFLCICHDCN, int DAIFOFJAHFO, int OIJHFILKHMA, bool NFCPIIGFIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x805A130", Offset = "0x8058730", VA = "0x18805A130")]
	public static int BFMPDOOIBPH(int CLFLCICHDCN, int DAIFOFJAHFO, int OIJHFILKHMA, bool NFCPIIGFIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x805B5C0", Offset = "0x8059BC0", VA = "0x18805B5C0")]
	public static int KJLFABMBLJG(int OIJHFILKHMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x805A500", Offset = "0x8058B00", VA = "0x18805A500")]
	public static BKAIGMEALKL CDFKOLKNDMB(int DAIFOFJAHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x805ABC0", Offset = "0x80591C0", VA = "0x18805ABC0")]
	private static BKAIGMEALKL HIOAGJHBLJA(int DAIFOFJAHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x805B5E0", Offset = "0x8059BE0", VA = "0x18805B5E0")]
	public static BKAIGMEALKL KPMAILKKPEM(int DAIFOFJAHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x805A1C0", Offset = "0x80587C0", VA = "0x18805A1C0")]
	private static BKAIGMEALKL BKOHOOBDKIN(int DAIFOFJAHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x805A660", Offset = "0x8058C60", VA = "0x18805A660")]
	public static void CHJGCNBDBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct FIIHBOCJHGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int DHNGOLKHJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 JFGBBNNANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion IOENIOAFHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float HDOAMPMCOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float INCNJNGJDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int PFNPFBIHOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int AKMCIMNLAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int HCNBMJPANKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool COLOIOMACKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool FCEIGKPHEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float DNMLDIOIFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 LBOKOIGMABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool ILEGJCACKPF;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct PDOLDJNLBNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int GAGCOBHCJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int EBNICINLBOA;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct FBLPICJIPDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<FIIHBOCJHGE> LELKBPIIMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<FEALKEEJBEM> NHIHOKIIOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<DBBEOABNPNA> KEEMAJKNMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<PDOLDJNLBNK> LNFAMJOHAGL;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x805BD50", Offset = "0x805A350", VA = "0x18805BD50")]
	public FBLPICJIPDL(NativeArray<FEALKEEJBEM> NHIHOKIIOLO, int GPNBMIDFKMK = 1, Allocator HOHBLCPFIEJ = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x805BC60", Offset = "0x805A260", VA = "0x18805BC60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct MNDFFDCCOEC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<FBEKKCFPBDH> DKBGEJMJPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> BDFANNJNOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<DBBEOABNPNA> EDOJACLNKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<FIIHBOCJHGE> LELKBPIIMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<FEALKEEJBEM> NHIHOKIIOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<DBBEOABNPNA> KEEMAJKNMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<PDOLDJNLBNK> LNFAMJOHAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int LEALGAJIPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int MGKJGHHEIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 LHLKCGIBBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion OKIDFKMBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 OOEEIPFCPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DBJEEDALGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> INONPJNIBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CFPFNCCIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MHIPEAPOGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NFICKOPAAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> ALFAJCCHHNI;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x806A2E0", Offset = "0x80688E0", VA = "0x18806A2E0")]
	public MNDFFDCCOEC(AKEMDMPFBPH NBMKOHOCJBL, JOHNDGNODKM IIHEOKLJJAI, float3 IBCFPIAOLPC, quaternion JNNNJGINGKC, float LBKDNONEDKI, int KBAECJMPDNE = 0, int FELBDCFBIDB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x806A0B0", Offset = "0x80686B0", VA = "0x18806A0B0")]
	public MNDFFDCCOEC(FBLPICJIPDL NBMKOHOCJBL, JOHNDGNODKM IIHEOKLJJAI, float3 IBCFPIAOLPC, quaternion JNNNJGINGKC, float3 LBKDNONEDKI, int KBAECJMPDNE = 0, int FELBDCFBIDB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8069F70", Offset = "0x8068570", VA = "0x188069F70")]
	private float3 JODCHDMBICN(float3 OODHEFCJMPI, Matrix4x4 EEPEPLEHCKO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8069520", Offset = "0x8067B20", VA = "0x188069520")]
	private float3x3 FJMEPMDGDHH(float3x3 PMGBIPBIHJD, float3x3 BABDEJAGEII)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x80695A0", Offset = "0x8067BA0", VA = "0x1880695A0")]
	private float GJNJJFBCEPC(float HKINPNLCPPL, float NJAFEDJFMJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x8068380", Offset = "0x8066980", VA = "0x188068380", Slot = "4")]
	public void Execute(int JAENDMHBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8068210", Offset = "0x8066810", VA = "0x188068210")]
	private void ANAJKCHFJEK(int IMEEIIMFGOB, float3 NHLFNDFGAHK, float3 IFDADDNBHKB, float3 FABHMFNHHAA, float OFCEKCJNBGJ, bool LCKGPKOEMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8069B30", Offset = "0x8068130", VA = "0x188069B30")]
	private void JEIPGMHJIDJ(FIIHBOCJHGE GAKFDNBODDL, float3 JPAIMFCOEEF, float3x3 LFABKDOANNB, float HKINPNLCPPL, int LMPFLOABKAH, int DJADEIBLFPO, int MIGLOOMDLFP, float BBNHOGHNOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x80695B0", Offset = "0x8067BB0", VA = "0x1880695B0")]
	private void IHECNLDNEBM(int IMEEIIMFGOB, int OIHHHIKEPEI, FIIHBOCJHGE GAKFDNBODDL, float3 JPAIMFCOEEF, float3x3 LFABKDOANNB, bool NGJBIGKCEAP, float HKINPNLCPPL, int CMKHBIGCMNL, int PPJJELOKDIO, int MIGLOOMDLFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct AOAACPPODAJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<POFJLBIHJDD> DOOCDOKANEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<DBBEOABNPNA> HNMCMMIOCIC;

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x8053540", Offset = "0x8051B40", VA = "0x188053540")]
	public AOAACPPODAJ(int GPNBMIDFKMK, Allocator HOHBLCPFIEJ = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x80534A0", Offset = "0x8051AA0", VA = "0x1880534A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct DFGHCDKFPDL : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum JILJGBPNFNA
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
	private NativeList<float3> MFEJMKAENEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> BNDGJJJKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> IMLEKKHIFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> PHNICKBJFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> JHBMJNMEELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> AMFAKCFONHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> GGDAMNGOJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> CLGLCNHIPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> BKGCNHJENML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<DBBEOABNPNA> OMGLBEPPPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<POFJLBIHJDD> DOOCDOKANEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<DBBEOABNPNA> HNMCMMIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int LEALGAJIPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int MGKJGHHEIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DBJEEDALGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> INONPJNIBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CFPFNCCIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MHIPEAPOGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NFICKOPAAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KIBEPOEDHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> ALFAJCCHHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 OOEEIPFCPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion OKIDFKMBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 LHLKCGIBBGJ;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8059D10", Offset = "0x8058310", VA = "0x188059D10")]
	public DFGHCDKFPDL(AKEMDMPFBPH NBMKOHOCJBL, JOHNDGNODKM IIHEOKLJJAI, NativeArray<int> KIPJMLPBFIB, float3 IBCFPIAOLPC, quaternion JNNNJGINGKC, float LBKDNONEDKI, int KBAECJMPDNE = 0, int FELBDCFBIDB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8059F20", Offset = "0x8058520", VA = "0x188059F20")]
	public DFGHCDKFPDL(AOAACPPODAJ ACJFHCNBBBO, JOHNDGNODKM IIHEOKLJJAI, NativeArray<int> KIPJMLPBFIB, float3 IBCFPIAOLPC, quaternion JNNNJGINGKC, float3 LBKDNONEDKI, int KBAECJMPDNE = 0, int FELBDCFBIDB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8058CA0", Offset = "0x80572A0", VA = "0x188058CA0", Slot = "4")]
	public void Execute(int JAENDMHBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x80588F0", Offset = "0x8056EF0", VA = "0x1880588F0")]
	private void DNCHLKIHLPB(float4x4 GAHFEAAJIMP, int JAENDMHBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8059CA0", Offset = "0x80582A0", VA = "0x188059CA0")]
	private JILJGBPNFNA MKIEFHMIBPN(float3 IFDADDNBHKB)
	{
		return default(JILJGBPNFNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8059C50", Offset = "0x8058250", VA = "0x188059C50")]
	private float4 LEDJEFMMCEH(JILJGBPNFNA HCMLNKCPEIM, int KHMHPNKMLMD)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x80588B0", Offset = "0x8056EB0", VA = "0x1880588B0")]
	private float2 ANKHBMICBFP(JILJGBPNFNA HCMLNKCPEIM, float3 NHLFNDFGAHK)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct OMIDOJNADAI
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum NGHKIAKNJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static OMIDOJNADAI PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 DGHMAMNELGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 GBHJDFCFFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 GBKBNOBKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NGHKIAKNJKJ AKEHBOGGIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 AJABAHJCBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 DEKNIFLLFKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool LAPKEHOOABF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x806BD90", Offset = "0x806A390", VA = "0x18806BD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 BIONDJAKKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x806C040", Offset = "0x806A640", VA = "0x18806C040")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x806C480", Offset = "0x806AA80", VA = "0x18806C480")]
	public OMIDOJNADAI(float3 NHLFNDFGAHK, quaternion CFFPEJBOBIA, float3 GPNBMIDFKMK, NGHKIAKNJKJ JLPANLJHHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x806C210", Offset = "0x806A810", VA = "0x18806C210")]
	public float PLAMMJEAIFN(float3 JPAIMFCOEEF, float DDCNAJEOANI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x806C120", Offset = "0x806A720", VA = "0x18806C120")]
	public bool PJHMOHMOLDL(float3 IFDADDNBHKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x806BDA0", Offset = "0x806A3A0", VA = "0x18806BDA0")]
	public void LPNDKMIIOMA(float3 OOHNEPPNDFN, float3x3 INBMLCHEAPD, float FFNGHHDMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x806BF50", Offset = "0x806A550", VA = "0x18806BF50")]
	private void NKOEFNBAGNO(float3 OCHJKMNJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x806BB00", Offset = "0x806A100", VA = "0x18806BB00")]
	public void AJHJPFJGKIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct DBCANNEEFFE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<OMIDOJNADAI> ACJFHCNBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> OAFFCDPLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> MKHHILLHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FMPMICJFNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<DBBEOABNPNA> HNMCMMIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int FFGBNMFHMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int KIBFHDOPJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float DDCNAJEOANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float KPLIGCONEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> EBNEPLKJGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> DLJCGFDDJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> EMHJGAJIIBO;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8058810", Offset = "0x8056E10", VA = "0x188058810")]
	public DBCANNEEFFE(JOHNDGNODKM IDMOPPBKAAO, float DBJFDKLGDHC, int IGHNHCKLCCN, int LMPFLOABKAH, NativeList<OMIDOJNADAI> ACJFHCNBBBO, NativeArray<int> FMPMICJFNFG, NativeList<DBBEOABNPNA> HNMCMMIOCIC, JDIPKNPCLDJ PJABPPGEPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8057D80", Offset = "0x8056380", VA = "0x188057D80", Slot = "4")]
	public void Execute(int HIIEDKDLMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8058750", Offset = "0x8056D50", VA = "0x188058750")]
	private bool LAMLANBMBCA(OMIDOJNADAI DLGEPLKGJOC, OMIDOJNADAI OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x80584C0", Offset = "0x8056AC0", VA = "0x1880584C0")]
	private bool HAHMECKPCNG(OMIDOJNADAI HJFONKAADOK, int GIBGOCAFKOJ, int CAEJNMMAKDP, int KCNKBJHAMMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct PCLOMJCLPCK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<JFFFMDLEDBA.MDOOJJDOLJF> AEPOHJJGNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> ANPNGGGNEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int KBAECJMPDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int FELBDCFBIDB;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x806CB80", Offset = "0x806B180", VA = "0x18806CB80")]
	public PCLOMJCLPCK(NativeList<JFFFMDLEDBA.MDOOJJDOLJF> AEPOHJJGNHF, NativeArray<int> ANPNGGGNEEG, int FELBDCFBIDB = 0, int KBAECJMPDNE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x806CAD0", Offset = "0x806B0D0", VA = "0x18806CAD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class JDIPKNPCLDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> KDJECONFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> BICFNNOKKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> BIOIBOIBOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> LHCOAGFPLCM;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8064990", Offset = "0x8062F90", VA = "0x188064990")]
	public void CMAKEHGLHJI(int MNAPDCDOKHC, int IGENIDBBLGE, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8064C90", Offset = "0x8063290", VA = "0x188064C90")]
	public static long KCLILOFKBLE(int MNAPDCDOKHC, int IGENIDBBLGE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8064BA0", Offset = "0x80631A0", VA = "0x188064BA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8064AB0", Offset = "0x80630B0", VA = "0x188064AB0")]
	public void DIGOPEEDGGN(JobHandle JNHDFACBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JDIPKNPCLDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct JBLBPEDCPEG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> OAFFCDPLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> NJFMDNHHIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> PEKKOAHHCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> NOIBLEJCHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> MKHHILLHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DIGJAIJPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> EAIDMMGBOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> EBNEPLKJGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> DLJCGFDDJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int KBAECJMPDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int FELBDCFBIDB;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8064910", Offset = "0x8062F10", VA = "0x188064910")]
	public JBLBPEDCPEG(JOHNDGNODKM IDMOPPBKAAO, JDIPKNPCLDJ PJABPPGEPIK, int FELBDCFBIDB = 0, int KBAECJMPDNE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8064530", Offset = "0x8062B30", VA = "0x188064530", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x80644D0", Offset = "0x8062AD0", VA = "0x1880644D0")]
	private void CJOLBKGJAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class LAHPIKAPOIC
{
	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BED250", Offset = "0x3BEB850", VA = "0x183BED250")]
	public static bool EGCMKBEEACH<T>(NativeArray<T> DDENONPPKCL, int GPNBMIDFKMK, Allocator HOHBLCPFIEJ, NativeArrayOptions PANLLLBJFBB = NativeArrayOptions.ClearMemory, int HLFOCBKENOC = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3BED430", Offset = "0x3BEBA30", VA = "0x183BED430")]
	public static bool EGCMKBEEACH<T>(NativeList<T> BGGFBGFNIID, int GPNBMIDFKMK, Allocator HOHBLCPFIEJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3BED4F0", Offset = "0x3BEBAF0", VA = "0x183BED4F0")]
	public static bool EGCMKBEEACH<T>(NativeQueue<T> CDDEFPCECLM, Allocator HOHBLCPFIEJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum PNMMMGBOHFL
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
public interface BBFFBKDDGCJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DGFCOHNBGDJ(PNMMMGBOHFL CLFLCICHDCN);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OJNHFFBCLEH(PNMMMGBOHFL CLFLCICHDCN);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBGPOBEFNJF DKKCIACPPJL();

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float GFOGEHGAENO();

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPIODMKADEO(PNMMMGBOHFL CLFLCICHDCN, AKEMDMPFBPH HPJLKKGBLCO, int ELMBLIGGLCN = -1);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int MAAEJLDCBGJ(int EAJJDPOANCF);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class AIIHLNGFOLN
{
	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8053350", Offset = "0x8051950", VA = "0x188053350")]
	public static void CHJGCNBDBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class OGHJCIFIOAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> OJJKAOLLJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> CEECJMPCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> AMPIMMGAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> OEAEBKGADFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> LPCAFMNAOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> GHJBPMOFJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> BFIIEJELKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> BGDPHPCOMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> GDBIONGPMCA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FPAGOELIBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x806A9C0", Offset = "0x8068FC0", VA = "0x18806A9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EAEIKGJDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x806AA00", Offset = "0x8069000", VA = "0x18806AA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ILKEFGNFMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x806B440", Offset = "0x8069A40", VA = "0x18806B440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x806B480", Offset = "0x8069A80", VA = "0x18806B480")]
	public OGHJCIFIOAO(int MNAPDCDOKHC, int IGENIDBBLGE, int MLBNAMDGDOJ, Allocator HOHBLCPFIEJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x806B7A0", Offset = "0x8069DA0", VA = "0x18806B7A0")]
	public OGHJCIFIOAO(Mesh IDMOPPBKAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x806A8A0", Offset = "0x8068EA0", VA = "0x18806A8A0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x806A570", Offset = "0x8068B70", VA = "0x18806A570")]
	public void DJMKPHJGGIE(OGHJCIFIOAO IDMOPPBKAAO, bool OGECGKDENII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x806AFB0", Offset = "0x80695B0", VA = "0x18806AFB0")]
	private void MKKPCOOJKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x806AA40", Offset = "0x8069040", VA = "0x18806AA40")]
	private void MHPDKMLPDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct DBBEOABNPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int CNCAFGOFBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int FPAGOELIBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int LNFGKFKGMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int EAEIKGJDEKJ;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2127180", Offset = "0x2125780", VA = "0x182127180")]
	public DBBEOABNPNA(int LMPFLOABKAH, int KABGKOBDGEB, int IGHNHCKLCCN, int AIHHKEFNBIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class GDMABCGDCIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<DBBEOABNPNA> LEMPLANHJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<DBBEOABNPNA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OGHJCIFIOAO GAMNJOHBFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x805BEF0", Offset = "0x805A4F0", VA = "0x18805BEF0")]
	public GDMABCGDCIE(IEnumerable<OGHJCIFIOAO> GPHJGCKMMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x805BE80", Offset = "0x805A480", VA = "0x18805BE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum DDEGPPICJGJ
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class PCEHKJDFIGN
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> MOPHFPDGABF;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> CPDDAMGBKNC;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> GAKNAECMODN;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> FCKFDBDAHPC;

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x806C680", Offset = "0x806AC80", VA = "0x18806C680")]
	public static void CHJGCNBDBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x806C9C0", Offset = "0x806AFC0", VA = "0x18806C9C0")]
	public static NativeArray<float2> IAJIAPHJFFH(NativeArray<float2> FLJPILLLDKE, int LCHDIDOEKLJ, NativeArray<float2> GBAAMPHFEEK, int JOJHLIMKCJK)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x806C8B0", Offset = "0x806AEB0", VA = "0x18806C8B0")]
	public static NativeArray<float3> GAOFJNDKCAM(NativeArray<float3> FLJPILLLDKE, int LCHDIDOEKLJ, NativeArray<float3> GBAAMPHFEEK, int JOJHLIMKCJK)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x806C7A0", Offset = "0x806ADA0", VA = "0x18806C7A0")]
	public static NativeArray<float4> FFMPFDAKDBB(NativeArray<float4> FLJPILLLDKE, int LCHDIDOEKLJ, NativeArray<float4> GBAAMPHFEEK, int JOJHLIMKCJK)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x806C570", Offset = "0x806AB70", VA = "0x18806C570")]
	public static NativeArray<int> APCCJNCLAAA(NativeArray<int> FLJPILLLDKE, int LCHDIDOEKLJ, NativeArray<int> GBAAMPHFEEK, int JOJHLIMKCJK)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5D70", Offset = "0x3CF4370", VA = "0x183CF5D70")]
	private static void MEMNJIDCBPL<T>(NativeArray<T> DDENONPPKCL, int CEBJEAHBAOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5F70", Offset = "0x3CF4570", VA = "0x183CF5F70")]
	private static void PHAHJHIFCEP<T>(NativeArray<T> FLJPILLLDKE, int LCHDIDOEKLJ, NativeArray<T> GBAAMPHFEEK, int JOJHLIMKCJK, NativeArray<T> ODIOGFMEAMC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class KGACNPDCBBH
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct BBGKHHPLNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort POMHCCBBBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort JKKMGDMGNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort OMJKKEJFOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort LBMLDBFPJAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8067D70", Offset = "0x8066370", VA = "0x188067D70")]
	public static uint JNOKJBHCKNC(float LDHDLMHMBON)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8067FA0", Offset = "0x80665A0", VA = "0x188067FA0")]
	public static void KJHDMCNPPPD(float4 PEKKOAHHCKB, float FPKCPGCLLHE, [Out] uint NDEKEABBCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8067ED0", Offset = "0x80664D0", VA = "0x188067ED0")]
	public static void KJHDMCNPPPD(float4 PEKKOAHHCKB, uint OGOOBNLPEMP, [Out] uint NDEKEABBCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8067970", Offset = "0x8065F70", VA = "0x188067970")]
	public static void EKBLGJOOOGD(float3 BNABGEDHEAP, float3 OFLFJIBCDOD, float4 EIOPNIALDPL, float2 LHPEOCKBJKH, float4 PEKKOAHHCKB, [Out] JOHNDGNODKM.MHHLOPGOHBK NOKJPBINCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8067710", Offset = "0x8065D10", VA = "0x188067710")]
	public static void EKBLGJOOOGD(float3 BNABGEDHEAP, float3 OFLFJIBCDOD, float4 EIOPNIALDPL, float2 LHPEOCKBJKH, float4 PEKKOAHHCKB, [Out] JOHNDGNODKM.FLGLCKDGDCN NOKJPBINCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x80680B0", Offset = "0x80666B0", VA = "0x1880680B0")]
	public static byte LMPEFOFFPGH(float KKGBKLFKCPO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x8067BC0", Offset = "0x80661C0", VA = "0x188067BC0")]
	public static ushort FDPMNFHHIJF(float KKGBKLFKCPO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x80676E0", Offset = "0x8065CE0", VA = "0x1880676E0")]
	public static uint DNEEJCFJKPA(float KKGBKLFKCPO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x8068100", Offset = "0x8066700", VA = "0x188068100")]
	public static float2 ODPCGAPDNEO(float2 JIJNMCDLDDE)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8067D80", Offset = "0x8066380", VA = "0x188067D80")]
	public static float2 KCGADMHFEPI(float3 LFBNNGIKBPK)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x8067590", Offset = "0x8065B90", VA = "0x188067590")]
	public static void AMGGILBLNKO(float3 KKGBKLFKCPO, [Out] float3 CNJNAPJLMHN, [Out] uint3 LBMLDBFPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8067C10", Offset = "0x8066210", VA = "0x188067C10")]
	public static BBGKHHPLNAL JGIFFJMFIIJ(float3 NHLFNDFGAHK)
	{
		return default(BBGKHHPLNAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class DBCACGOGPLG
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker EIJFOAIFDNK;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float LEFMAHLCHGE;

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void ICDILAGAFAI(bool HLBGMBDPKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8057660", Offset = "0x8055C60", VA = "0x188057660")]
	public static float KKDDKNOELDA(float IGJMPABLMOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8057570", Offset = "0x8055B70", VA = "0x188057570")]
	public static long BODLPNLHEIO(float IGJMPABLMOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x80577C0", Offset = "0x8055DC0", VA = "0x1880577C0")]
	public static void MLNKBGKEFJL(float IGJMPABLMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface DLOMPNMIFOC
{
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLNKBGKEFJL(float JALPPKKDOEB);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) BKOKGAIGONB(float FEHCJJAEPLP);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class IICJLDOEIKL
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum ODHHJOMPJID
	{
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		ShapesStartTreeGeneration,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		ShapesTreeRefresh,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		ShapesUploadMesh,
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		ShapesLod012Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class BEIEGDPBFDD : NBIBNNHBMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public ODHHJOMPJID JLPANLJHHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public BatchedMeshRenderer KJBPFHJBAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public EDBEHNFKGLJ PKDOEHJPFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public JFFFMDLEDBA DFGCCPHMCME;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override float PCEHILJIKLE
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x118A830", Offset = "0x1188E30", VA = "0x18118A830", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x191D580", Offset = "0x191BB80", VA = "0x18191D580", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x806CC50", Offset = "0x806B250", VA = "0x18806CC50", Slot = "7")]
		public override void NJPLCABILLF([Out] bool OMJHPLLIELF, [Out] bool LOENONCNICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BEIEGDPBFDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int NIOGBPPNJLO;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int PMBAKPBEICF;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int EPEKBJLMNBM;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long POHEACGHFOF;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long LLMNIHJBCNH;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long EPFBJNOEKOL;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long CGBNMELMOJI;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int LPMPFNCJOJK;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float MKOOGBEFFPP;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool DPPKHFLJLDG;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int PIDCBNHCLDM;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int LLMLJMNGLCG;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int PEHPBDDPIEC;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long EJPLHMAFIFF;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int FEJGFCNOOFO;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool LKIKANKJIID;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static uint DEHDOBKKPOP;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static KEKHEIOPHDE GJLJPEMOHGC;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static List<uint> DICONACHDDK;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static DLOMPNMIFOC CHCCKONMJKN;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool NAKLCKGPIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8063DC0", Offset = "0x80623C0", VA = "0x188063DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void HHPLHFNCNJG(bool HLBGMBDPKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void ICDILAGAFAI(bool HLBGMBDPKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void HHPLHFNCNJG(bool HLBGMBDPKNE, string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x8061390", Offset = "0x805F990", VA = "0x188061390")]
	public static void GIMDAHOHNHM(DLOMPNMIFOC FCNKHADFNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x8063F90", Offset = "0x8062590", VA = "0x188063F90")]
	public static (long, long, long, int, int) PIBBFIKFJFK(long KBCILPEDKHK)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x8060BE0", Offset = "0x805F1E0", VA = "0x188060BE0")]
	public static void ENGKIBEABGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8061990", Offset = "0x805FF90", VA = "0x188061990")]
	public static void MLNKBGKEFJL(long KBCILPEDKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8060510", Offset = "0x805EB10", VA = "0x188060510")]
	public static void AMAPPAJIPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8060A30", Offset = "0x805F030", VA = "0x188060A30")]
	public static long CHNGIICLNKE(long KAHGPBBKOCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8063CF0", Offset = "0x80622F0", VA = "0x188063CF0")]
	public static bool NCMJCKEKLKN(long LFHGNACBCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8064150", Offset = "0x8062750", VA = "0x188064150")]
	public static bool PPHJMGBEEMC(long LFHGNACBCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8061030", Offset = "0x805F630", VA = "0x188061030")]
	public static float GHANOEPKKEC(long BBPGLBCNFMC, int IAKJLDGAPEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8060620", Offset = "0x805EC20", VA = "0x188060620")]
	public static (long, long, int) BKOKGAIGONB(float IGJMPABLMOM)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x80616C0", Offset = "0x805FCC0", VA = "0x1880616C0")]
	public static void LNNGFPLONJP(JFFFMDLEDBA DFGCCPHMCME, BatchedMeshRenderer KJBPFHJBAPF, long OLHLENFOKCK, long ICHPOMEIHKK, float JPNKJNOJEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8063E10", Offset = "0x8062410", VA = "0x188063E10")]
	public static void NPEPAAKBJPK(JFFFMDLEDBA DFGCCPHMCME, BatchedMeshRenderer KJBPFHJBAPF, long OLHLENFOKCK, long ICHPOMEIHKK, float HJNLNFHOOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8060C60", Offset = "0x805F260", VA = "0x188060C60")]
	public static void EOMDHMABJCD(EDBEHNFKGLJ PKDOEHJPFPO, BatchedMeshRenderer KJBPFHJBAPF, long ICHPOMEIHKK, float HJNLNFHOOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8061400", Offset = "0x805FA00", VA = "0x188061400")]
	public static void LBDAEOCDDJA(JFFFMDLEDBA DFGCCPHMCME, BatchedMeshRenderer KJBPFHJBAPF, long OLHLENFOKCK, long ICHPOMEIHKK, float HJNLNFHOOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8060E10", Offset = "0x805F410", VA = "0x188060E10")]
	private static void GBIFMGPGPCH(ODHHJOMPJID JLPANLJHHFI, JFFFMDLEDBA DFGCCPHMCME, EDBEHNFKGLJ PKDOEHJPFPO, BatchedMeshRenderer KJBPFHJBAPF, long OLHLENFOKCK, long ICHPOMEIHKK, float OOHDHADBPAE, bool IPDNEKAONPH, bool OLPJDAIIKDP, float FKHLDNNBKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x80618D0", Offset = "0x805FED0", VA = "0x1880618D0")]
	public static bool MGANCCOIAHN(float PEGJEIJBOIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8061850", Offset = "0x805FE50", VA = "0x188061850")]
	public static void MBGPLJADMCF(float PEGJEIJBOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x80615B0", Offset = "0x805FBB0", VA = "0x1880615B0")]
	public static bool LDHHEFFKFNN(float PEGJEIJBOIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class NBIBNNHBMHO : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum FLJEDAPLAIK : byte
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
	public FLJEDAPLAIK AJNFAIALOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public long PJPFOIFNFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public long ICHPOMEIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public float OPEHEALHLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public bool OLPJDAIIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool IPDNEKAONPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	internal uint HLIPPIOIAJK;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract float PCEHILJIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void NJPLCABILLF([Out] bool OMJHPLLIELF, [Out] bool LOENONCNICE);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x807E390", Offset = "0x807C990", VA = "0x18807E390", Slot = "4")]
	public int CompareTo(object ODCICEDDLMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected NBIBNNHBMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KEKHEIOPHDE : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private List<NBIBNNHBMHO> PKANGIBCEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private List<NBIBNNHBMHO> CFACILEEJFE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x807DCE0", Offset = "0x807C2E0", VA = "0x18807DCE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x807E100", Offset = "0x807C700", VA = "0x18807E100")]
	public void JDPCENHCAFL(NBIBNNHBMHO GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x807E1D0", Offset = "0x807C7D0", VA = "0x18807E1D0")]
	public void LKCHPPHHBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x807E070", Offset = "0x807C670", VA = "0x18807E070")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x807DD30", Offset = "0x807C330", VA = "0x18807DD30")]
	public void GNLDBCCAECK(IEnumerable<uint> DICONACHDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x807DBC0", Offset = "0x807C1C0", VA = "0x18807DBC0")]
	private void BAFGFGCDOJB(uint HLIPPIOIAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x807E230", Offset = "0x807C830", VA = "0x18807E230", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x807DC80", Offset = "0x807C280", VA = "0x18807DC80")]
	public COBBBIFOLNP DHKFMABLBKB()
	{
		return default(COBBBIFOLNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x807E2D0", Offset = "0x807C8D0", VA = "0x18807E2D0")]
	public KEKHEIOPHDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct COBBBIFOLNP : IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private List<NBIBNNHBMHO> PKANGIBCEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private List<NBIBNNHBMHO> CFACILEEJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int ALFACJNKOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private int CLKIEOIOCGH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x806DA00", Offset = "0x806C000", VA = "0x18806DA00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public NBIBNNHBMHO CGHPBCAOGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x806D6E0", Offset = "0x806BCE0", VA = "0x18806D6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x806DA10", Offset = "0x806C010", VA = "0x18806DA10")]
	public COBBBIFOLNP(List<NBIBNNHBMHO> PKANGIBCEGI, List<NBIBNNHBMHO> CFACILEEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x806D860", Offset = "0x806BE60", VA = "0x18806D860", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x806D9F0", Offset = "0x806BFF0", VA = "0x18806D9F0", Slot = "6")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class EDBEHNFKGLJ
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal enum GMKFKDOIDCF
	{
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		NoMeshRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		Mesh,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		MeshFrozen,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		MeshRefresh,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly string LAALHIAHIED;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly string GJNDDCDEBBF;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker PGMKGIFNKNH;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker JGFKDEHNCEN;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker EIJFOAIFDNK;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker GFKOLOBDAIJ;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker JCMIIBMENDC;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker EJNJJBDPEEP;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker AOKOMLIBGEA;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker NOMOHLEHKBI;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker PEMLMHDHHPP;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker FLHCGJDCJPK;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker IFBBIBPFCKH;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker FBBMKMEFNNB;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker HLFNBMCNLJM;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker KKPODLKIFCM;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker LDNNJJLKGFA;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker DAHECMJBFOC;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker IHKEFKMEDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker BNOGBKCADGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	internal readonly List<JFFFMDLEDBA> CBPAFLFDCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly DALACCGALDC OLKENBPNEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal int BDIEEHJLJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	internal int ACCHNECOKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	internal bool LHPALANDEGA;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public const bool EIDGGPAJFBI = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public bool EFLDLMHBEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	internal GMKFKDOIDCF DIIEFKLECMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	internal int CEGJFILCDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	internal int KLKBMDOCFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	internal int AFILPEOBFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	internal int AFGMKGFIHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	internal long IFHLJOOFIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	internal long BFILADPFAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	internal long OIMAAFKADDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private JOHNDGNODKM ADDCOOLEANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private JOHNDGNODKM EFKBEEFPCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private JOHNDGNODKM.DLPLPJGMGAK IMMAMJIAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private bool AOCDPPKNLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private int MEKHAMGJBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private DALKENOHGLD NCINFNBMNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private float3 BCEODNDKPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private float JCAJMHKFCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private float NHHCHIHNIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private float EFAMAJHCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private float ABLNPFFCHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private float ALJAOADKAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private float LFJDHCDEPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float3 GEBIDDJPNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private float EFLGFGMIKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float DIKEELEKCEN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal Mesh GAMNJOHBFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MeshFilter GEDLLJPPNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MeshRenderer MFMPDODKFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<Material> EKBJLEDOKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int PDGIEPBKMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9EE0", Offset = "0xAA84E0", VA = "0x180AA9EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int FPAGOELIBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8071400", Offset = "0x806FA00", VA = "0x188071400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8071650", Offset = "0x806FC50", VA = "0x188071650")]
	public void JAPKIMFKNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8071D60", Offset = "0x8070360", VA = "0x188071D60")]
	public bool MGHDNIJLGEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8072DF0", Offset = "0x80713F0", VA = "0x188072DF0")]
	private void MNPAGCMJCCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8071230", Offset = "0x806F830", VA = "0x188071230")]
	private void HJPMMJNJKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x80737E0", Offset = "0x8071DE0", VA = "0x1880737E0")]
	public EDBEHNFKGLJ(string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x806F310", Offset = "0x806D910", VA = "0x18806F310")]
	public void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x806FBA0", Offset = "0x806E1A0", VA = "0x18806FBA0")]
	private void EHOOAFKKBNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8071B50", Offset = "0x8070150", VA = "0x188071B50")]
	private void LLPCHDCLOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x80708C0", Offset = "0x806EEC0", VA = "0x1880708C0")]
	private void GGNPBILIFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x806FF40", Offset = "0x806E540", VA = "0x18806FF40")]
	public Mesh ELCCKBCFPCL(MeshFilter POCOLGCEFDK, Transform DFOHJKCGEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x806E850", Offset = "0x806CE50", VA = "0x18806E850")]
	public void BCAODFCKLBO(bool MBDJAGOEBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x806F8F0", Offset = "0x806DEF0", VA = "0x18806F8F0")]
	private void EBLBBLMCPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8071E80", Offset = "0x8070480", VA = "0x188071E80")]
	public void MHIBBJLIPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8071420", Offset = "0x806FA20", VA = "0x188071420")]
	public void IFODEOFHJDD(BBFFBKDDGCJ LBFDKIMLIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8070960", Offset = "0x806EF60", VA = "0x188070960")]
	public bool GKGJBLPDALI(BBFFBKDDGCJ LBFDKIMLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8071780", Offset = "0x806FD80", VA = "0x188071780")]
	public bool JEFAFDBINCI(BBFFBKDDGCJ LBFDKIMLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x8072F10", Offset = "0x8071510", VA = "0x188072F10", Slot = "4")]
	public virtual void NBEMJGODPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x806F4C0", Offset = "0x806DAC0", VA = "0x18806F4C0")]
	public void DPGOKLFOEEK(Transform ICPKNMBNNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x806FC40", Offset = "0x806E240", VA = "0x18806FC40")]
	public bool EICIJCAGCNJ(Transform ICPKNMBNNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x8070B60", Offset = "0x806F160", VA = "0x188070B60")]
	public bool HBNNOKJEFEL(bool JIJGOOLFNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x806EDB0", Offset = "0x806D3B0", VA = "0x18806EDB0")]
	private void CFNNLNJCHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x8072190", Offset = "0x8070790", VA = "0x188072190")]
	public bool MLNKBGKEFJL(float4x4 PFNFBELHBGM, BatchedMeshRenderer DDLJBEFPKIF, bool BAHPEOLJCFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x8071900", Offset = "0x806FF00", VA = "0x188071900")]
	public bool LFDFKELBBJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x806DC20", Offset = "0x806C220", VA = "0x18806DC20")]
	public bool BBOODMMEFFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x806FA40", Offset = "0x806E040", VA = "0x18806FA40")]
	public void ECLBOLCADLO(JOHNDGNODKM IDMOPPBKAAO, int HFGPGHDHDPF, int NAAGHFCBNDO, float HCINPDMLFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x80719B0", Offset = "0x806FFB0", VA = "0x1880719B0")]
	public (long, long, long) LHGBIGIHOLH()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0")]
	public long BCJOIEBKMHF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x8073140", Offset = "0x8071740", VA = "0x188073140")]
	private void NOOJDJHIHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x806EB00", Offset = "0x806D100", VA = "0x18806EB00")]
	public (long, long, int) BKOKGAIGONB(float IGJMPABLMOM, float4x4 PFNFBELHBGM)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xF2E900", Offset = "0xF2CF00", VA = "0x180F2E900")]
	internal void KMAGHGFMMGN(GMKFKDOIDCF ACBJLKJPPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x806FFB0", Offset = "0x806E5B0", VA = "0x18806FFB0")]
	internal (float, float, float, float) FBKJBAMJPEG(float CLELOCIKCHC, float4x4 PFNFBELHBGM)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8071F90", Offset = "0x8070590", VA = "0x188071F90")]
	private void MLEMAKHGEAP(JOHNDGNODKM KKNNHIPOEKG, JOHNDGNODKM.DLPLPJGMGAK MJLNGFFONGJ, bool NIOKPKANEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x80708A0", Offset = "0x806EEA0", VA = "0x1880708A0")]
	private void FCDGKMPCCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x806F200", Offset = "0x806D800", VA = "0x18806F200")]
	internal bool CNKPOLBKOIF(bool JIJGOOLFNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8070E60", Offset = "0x806F460", VA = "0x188070E60")]
	private void HEHCEAOJCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x80730A0", Offset = "0x80716A0", VA = "0x1880730A0")]
	private void NEHIMMNGPKC(JOHNDGNODKM.DLPLPJGMGAK MJLNGFFONGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x806DA50", Offset = "0x806C050", VA = "0x18806DA50")]
	private void ADEJFOOGCMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x806EED0", Offset = "0x806D4D0", VA = "0x18806EED0")]
	public long CHNGIICLNKE(long KAHGPBBKOCJ, int PBECPMECGHD)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class JFFFMDLEDBA
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum DAIAKEGGFID
	{
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public struct MDOOJJDOLJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int DBJCFMPPIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int LBDLCBINGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public float GEMLBGFKPGC;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct FNIEFLKFPJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public ECGCNLKJEKF IDMOPPBKAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public int DBLHKPJJNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int NICOBKDHMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public long LICOFDFGKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public long LKGCJKAKPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public float KMJBAPPKCCF;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8073980", Offset = "0x8071F80", VA = "0x188073980")]
		public void PNLBMDNIIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8073900", Offset = "0x8071F00", VA = "0x188073900")]
		public void DIGOPEEDGGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private static readonly string LAALHIAHIED;

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private static readonly string GJNDDCDEBBF;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private static readonly ProfilerMarker PGMKGIFNKNH;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private static readonly ProfilerMarker GBJABDJHOHA;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private static readonly ProfilerMarker EIJFOAIFDNK;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private static readonly ProfilerMarker POPDEJIHBPF;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private static readonly ProfilerMarker GFKOLOBDAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private static readonly ProfilerMarker JCMIIBMENDC;

	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private static readonly ProfilerMarker EJNJJBDPEEP;

	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private static readonly ProfilerMarker AOKOMLIBGEA;

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private static readonly ProfilerMarker NOMOHLEHKBI;

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly ProfilerMarker DPEMNFDJDJH;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly ProfilerMarker PEMLMHDHHPP;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly ProfilerMarker LBJMEHIDDFE;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly ProfilerMarker IJFIODDFPIE;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly ProfilerMarker IKJEDGPAPEE;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker NOILBAELJDP;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker FLHCGJDCJPK;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker IFBBIBPFCKH;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker FBBMKMEFNNB;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker HLFNBMCNLJM;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker KKPODLKIFCM;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker LDNNJJLKGFA;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker DAHECMJBFOC;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker IHKEFKMEDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	internal readonly List<BBFFBKDDGCJ> GBIHKBDEEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	internal EDBEHNFKGLJ DOKANLGPJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private readonly DALACCGALDC OLKENBPNEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	internal int BMKMFIPOMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	internal int NBILBCDPALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	internal bool NFEMMHPKGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	internal bool AKLGINDKDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	internal DAIAKEGGFID DIAIHEGFECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	internal bool GGGEHAJCHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	internal float3 BAFCHBEGGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	internal float3 DJCDLGILEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal float PGDIIAFECGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal int NLBGAENBNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal int FLCPBNDDEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal int LDEICCIJKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal float NFMJEIDILCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal int AGJEOJOPKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	internal float GFGFFDAELNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal float DPKNFOJLKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal int NODEDJAHKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal long KGGMHKPLEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public int GOEKPJKCKAB;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal const int GMCJFLFBNPH = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal float[] BCBOEDBIFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal int[] GADBDGGNFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal long[] LGIICDMFPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public List<FNIEFLKFPJP> IJBLJCGAHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal JOHNDGNODKM PLBNKOJFMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal long HKADFBDBPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal int LIDFGOKAJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal float FKCNMJEENHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal JOHNDGNODKM.DLPLPJGMGAK LOIPNGCCOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal ECGCNLKJEKF BMMDPGFOCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	internal int JFMLHJKEJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal float NCCACJNJHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal long AKDHAIDJPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal bool CLMCGFNLCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal PJPOKPKKFDC GFLAMJOOIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	internal JobHandle ELDMLMLBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal NativeList<MDOOJJDOLJF> BMOKEIMNIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal NativeArray<long> PGAPEHHMGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal bool EBIPKMBLNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal JobHandle DADPBAANDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal JOHNDGNODKM ADFDOMHDIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal JDIPKNPCLDJ EBLLLMEHFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	internal NativeList<MDOOJJDOLJF> FKAIDDJMOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal Transform CGPJMOHANDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal PNMMMGBOHFL FJMBPNHDBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal long LKJKMACEGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal long MGPIBBKLJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	internal long GECOBBAKLFK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<BBFFBKDDGCJ> DPMAIMDJOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal int FPAGOELIBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8079A60", Offset = "0x8078060", VA = "0x188079A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8079AE0", Offset = "0x80780E0", VA = "0x188079AE0")]
	internal void JAPKIMFKNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x807B3C0", Offset = "0x80799C0", VA = "0x18807B3C0")]
	internal void MNPAGCMJCCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x807D830", Offset = "0x807BE30", VA = "0x18807D830")]
	internal JFFFMDLEDBA(string IEDAJGLJHNI, EDBEHNFKGLJ NBIJLPJHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x80769A0", Offset = "0x8074FA0", VA = "0x1880769A0")]
	internal void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8076B60", Offset = "0x8075160", VA = "0x188076B60")]
	internal void EBLBBLMCPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x80785A0", Offset = "0x8076BA0", VA = "0x1880785A0")]
	internal void GAHMBHGFKLH(BBFFBKDDGCJ LBFDKIMLIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8079AF0", Offset = "0x80780F0", VA = "0x188079AF0")]
	internal bool JNHJCEOBPKB(BBFFBKDDGCJ LBFDKIMLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x8078540", Offset = "0x8076B40", VA = "0x188078540")]
	internal bool FICAIIMGPFG(BBFFBKDDGCJ LBFDKIMLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x807B8D0", Offset = "0x8079ED0", VA = "0x18807B8D0", Slot = "4")]
	internal virtual void NBEMJGODPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8074B80", Offset = "0x8073180", VA = "0x188074B80")]
	public float BIPFIFLLHID(float OLDNKPPKCJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x8079C20", Offset = "0x8078220", VA = "0x188079C20")]
	public bool LHFGDOAJBLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x807BE70", Offset = "0x807A470", VA = "0x18807BE70")]
	public (ECGCNLKJEKF, JOHNDGNODKM.DLPLPJGMGAK) OJHNGGPLPOO()
	{
		return default((ECGCNLKJEKF, JOHNDGNODKM.DLPLPJGMGAK));
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x807B820", Offset = "0x8079E20", VA = "0x18807B820")]
	internal long NALFCGDGAOB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x807BD50", Offset = "0x807A350", VA = "0x18807BD50")]
	internal long OIELDFOIBBD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x8076F80", Offset = "0x8075580", VA = "0x188076F80")]
	internal bool EICIJCAGCNJ(Transform ICPKNMBNNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8078CD0", Offset = "0x80772D0", VA = "0x188078CD0")]
	internal bool HBNNOKJEFEL(bool JIJGOOLFNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x8075120", Offset = "0x8073720", VA = "0x188075120")]
	internal void CFNNLNJCHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x8079DC0", Offset = "0x80783C0", VA = "0x188079DC0")]
	internal bool MLNKBGKEFJL(float4x4 PFNFBELHBGM, BatchedMeshRenderer DDLJBEFPKIF, bool BAHPEOLJCFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x8077C30", Offset = "0x8076230", VA = "0x188077C30")]
	internal bool EMLPECOBHHB(bool JIJGOOLFNLM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8076F70", Offset = "0x8075570", VA = "0x188076F70")]
	internal void EENKFHDHENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x8076F40", Offset = "0x8075540", VA = "0x188076F40")]
	internal void ECLBOLCADLO(JOHNDGNODKM IDMOPPBKAAO, int HFGPGHDHDPF, int NAAGHFCBNDO, float HCINPDMLFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x80739B0", Offset = "0x8071FB0", VA = "0x1880739B0")]
	internal void AALIANJFINF(ECGCNLKJEKF LPGIMHJCJDG, int HFGPGHDHDPF, int NAAGHFCBNDO, float HCINPDMLFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x807B950", Offset = "0x8079F50", VA = "0x18807B950")]
	internal void NOOJDJHIHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x8074C70", Offset = "0x8073270", VA = "0x188074C70")]
	internal (long, long, int) BKOKGAIGONB(float IGJMPABLMOM, float4x4 PFNFBELHBGM, float GLGBJHAFOKO)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xA47FD0", Offset = "0xA465D0", VA = "0x180A47FD0")]
	internal void KMAGHGFMMGN(DAIAKEGGFID ACBJLKJPPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x8078120", Offset = "0x8076720", VA = "0x188078120")]
	public static (float, float, float, float) FBKJBAMJPEG(float3 CELHCLHOFCK, float3 BMNDIBBDKPB, float CLELOCIKCHC, float4x4 PFNFBELHBGM, float GLGBJHAFOKO)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x8077EE0", Offset = "0x80764E0", VA = "0x188077EE0")]
	internal (float, float, float, float) FBKJBAMJPEG(float CLELOCIKCHC, float4x4 PFNFBELHBGM, float GLGBJHAFOKO)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x8079A80", Offset = "0x8078080", VA = "0x188079A80")]
	private float IFFDOKKMLGL(float CLELOCIKCHC, float4x4 PFNFBELHBGM, float GLGBJHAFOKO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x80787C0", Offset = "0x8076DC0", VA = "0x1880787C0")]
	private (int, int, float) GCFNBMJDPDC(float BIBGFPNOPCA)
	{
		return default((int, int, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x8079B70", Offset = "0x8078170", VA = "0x188079B70")]
	internal static float KGCBPGOCBDM(BBFFBKDDGCJ IDMOPPBKAAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x8073C40", Offset = "0x8072240", VA = "0x188073C40")]
	internal void ABIDENBHDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x8074AF0", Offset = "0x80730F0", VA = "0x188074AF0")]
	internal void ADEJFOOGCMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x807B500", Offset = "0x8079B00", VA = "0x18807B500")]
	internal void NAJHGMFOGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x80756E0", Offset = "0x8073CE0", VA = "0x1880756E0")]
	internal long CHNGIICLNKE(long KAHGPBBKOCJ, int PBECPMECGHD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x8075DE0", Offset = "0x80743E0", VA = "0x188075DE0")]
	private void CJPOGDMMLNC(JOHNDGNODKM AKMMEACMLLF, NativeList<MDOOJJDOLJF> MIIAKMNBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x807CD90", Offset = "0x807B390", VA = "0x18807CD90")]
	internal void PJEIJCBBKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x807AD30", Offset = "0x8079330", VA = "0x18807AD30")]
	public static void MNJOMGLILPH(NativeList<MDOOJJDOLJF> CBECKFGAKMD, JOHNDGNODKM AKMMEACMLLF, int OIJMMHLNDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8076AD0", Offset = "0x80750D0", VA = "0x188076AD0")]
	private float DMDCBNFLNFG(int HOPJGMEPPBF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x807C350", Offset = "0x807A950", VA = "0x18807C350")]
	internal void OOPGNCLICBK(JOHNDGNODKM IDMOPPBKAAO, NJDLLHCEEAO LPGIMHJCJDG, int HFGPGHDHDPF, int NAAGHFCBNDO, float HCINPDMLFJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BurstCompile]
internal struct OOEHGBLKADD : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal struct GEEBFDDCDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public int AABHBEMOHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public int DIJENGOGGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int CEJFDEPAFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public float LAOJAIGHCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public float JMOFAIABHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public float PEEPJCMILGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float ADDJKLAHIHI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	internal struct IIOLFAGEFFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int AABHBEMOHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public int DIJENGOGGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int CEJFDEPAFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int PIIFNJHDKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public float LAOJAIGHCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public float JMOFAIABHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float JPHFOAEDAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public float IDABEPHPOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public float ADDJKLAHIHI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public struct HBHKDHPMFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int EANFFGHOMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int BNHOLLCKPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public float ACLNKMGEFJI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public delegate void GHIOEKHPIEN(OOEHGBLKADD AFDFOMMAFPC, [In] GEEBFDDCDGG PGOODFLENPJ);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class FIPAALDNJKH
	{
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x808F720", Offset = "0x808DD20", VA = "0x18808F720")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x808F5C0", Offset = "0x808DBC0", VA = "0x18808F5C0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x808F510", Offset = "0x808DB10", VA = "0x18808F510")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x808F320", Offset = "0x808D920", VA = "0x18808F320")]
		public static void GHDKDALNEMC(OOEHGBLKADD AFDFOMMAFPC, [In] GEEBFDDCDGG PGOODFLENPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void IFJANKFCCHL(OOEHGBLKADD AFDFOMMAFPC, [In] IIOLFAGEFFL GCJOHLIBBCI);

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal static class IJHAGINKCJM
	{
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x80908A0", Offset = "0x808EEA0", VA = "0x1880908A0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x8090740", Offset = "0x808ED40", VA = "0x188090740")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8090690", Offset = "0x808EC90", VA = "0x188090690")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x80904A0", Offset = "0x808EAA0", VA = "0x1880904A0")]
		public static void GHDKDALNEMC(OOEHGBLKADD AFDFOMMAFPC, [In] IIOLFAGEFFL GCJOHLIBBCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public unsafe delegate void KJMGIHFFBBJ(UnsafeList<int>* EDKDECBLPLO, UnsafeList<float3>* ALCEELBNJLK, [NoAlias] float3* BHCDMPCEPKE, [NoAlias] float4* JBOMJGKJCFI, [NoAlias] float2* PCLKFMCPBEL, [NoAlias] float4* EKDLHDJNCEE, UnsafeList<MCFAIMMNKGE>* DNAAILGCEHH, UnsafeList<int>* OJADIHBFADF, UnsafeList<float3>* KDBGHIKEIAG, [NoAlias] float3* HBCLJLLJGJE, [NoAlias] float4* MCFNHBCODKE, [NoAlias] float2* DMANCOPDIJL, [NoAlias] float4* HMPKPDLLJCH, int IGENIDBBLGE, int MNAPDCDOKHC);

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal static class PJLEIADDEIM
	{
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8091910", Offset = "0x808FF10", VA = "0x188091910")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x80917B0", Offset = "0x808FDB0", VA = "0x1880917B0")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x8091700", Offset = "0x808FD00", VA = "0x188091700")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x80913C0", Offset = "0x808F9C0", VA = "0x1880913C0")]
		public unsafe static void GHDKDALNEMC(UnsafeList<int>* EDKDECBLPLO, UnsafeList<float3>* ALCEELBNJLK, [NoAlias] float3* BHCDMPCEPKE, [NoAlias] float4* JBOMJGKJCFI, [NoAlias] float2* PCLKFMCPBEL, [NoAlias] float4* EKDLHDJNCEE, UnsafeList<MCFAIMMNKGE>* DNAAILGCEHH, UnsafeList<int>* OJADIHBFADF, UnsafeList<float3>* KDBGHIKEIAG, [NoAlias] float3* HBCLJLLJGJE, [NoAlias] float4* MCFNHBCODKE, [NoAlias] float2* DMANCOPDIJL, [NoAlias] float4* HMPKPDLLJCH, int IGENIDBBLGE, int MNAPDCDOKHC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public float3 BCEODNDKPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public float CGJFIIKFFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public float ACOFKNFGAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public float PEOBHJGNPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public JEDJMLACHKM.AINEPAOALIE HICOPJFIFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public bool PFHAFFNJNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<MCFAIMMNKGE>* DNAAILGCEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* OJADIHBFADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<GEEBFDDCDGG>* IBENMDOCODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<GEEBFDDCDGG>* OGKIKAAFGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<IIOLFAGEFFL>* EJLCFHJPNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<IIOLFAGEFFL>* BBILEKKLANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public int OGCIMPNKBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public int DOMGFAMOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public int LHPGDGJMOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe float3* KDBGHIKEIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe int* JBNPHEFOPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe HBHKDHPMFGI* JMMJIFKPGAE;

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x807FB00", Offset = "0x807E100", VA = "0x18807FB00")]
	private static float HEMOIDNAIAB([In] OOEHGBLKADD AFDFOMMAFPC, [In] float3 PNJILNIFCPJ, float ADDJKLAHIHI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8080C90", Offset = "0x807F290", VA = "0x188080C90")]
	private static int NHJPDIJKOOD(OOEHGBLKADD AFDFOMMAFPC, [Out] MCFAIMMNKGE GGKNBBMADPA, [In] MCFAIMMNKGE NDKJKCHNFOJ, [In] MCFAIMMNKGE KPPGCCPNNBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x807E4C0", Offset = "0x807CAC0", VA = "0x18807E4C0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private static void CIAIOKFLAEL(OOEHGBLKADD AFDFOMMAFPC, [In] GEEBFDDCDGG PGOODFLENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x807FB80", Offset = "0x807E180", VA = "0x18807FB80")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void JLGCLAGHOLI(OOEHGBLKADD AFDFOMMAFPC, [In] IIOLFAGEFFL GCJOHLIBBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x807E520", Offset = "0x807CB20", VA = "0x18807E520", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x807EDD0", Offset = "0x807D3D0", VA = "0x18807EDD0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal void GCDHGBEJMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x807ED40", Offset = "0x807D340", VA = "0x18807ED40")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal unsafe static void FGNBDKBDKDA(UnsafeList<int>* EDKDECBLPLO, UnsafeList<float3>* ALCEELBNJLK, [NoAlias] float3* BHCDMPCEPKE, [NoAlias] float4* JBOMJGKJCFI, [NoAlias] float2* PCLKFMCPBEL, [NoAlias] float4* EKDLHDJNCEE, UnsafeList<MCFAIMMNKGE>* DNAAILGCEHH, UnsafeList<int>* OJADIHBFADF, UnsafeList<float3>* KDBGHIKEIAG, [NoAlias] float3* HBCLJLLJGJE, [NoAlias] float4* MCFNHBCODKE, [NoAlias] float2* DMANCOPDIJL, [NoAlias] float4* HMPKPDLLJCH, int IGENIDBBLGE, int MNAPDCDOKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x807FBE0", Offset = "0x807E1E0", VA = "0x18807FBE0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void LKJCOJJJNCI(OOEHGBLKADD AFDFOMMAFPC, [In] GEEBFDDCDGG PGOODFLENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x807E530", Offset = "0x807CB30", VA = "0x18807E530")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void FFACIGFMMLG(OOEHGBLKADD AFDFOMMAFPC, [In] IIOLFAGEFFL GCJOHLIBBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x8080580", Offset = "0x807EB80", VA = "0x188080580")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void MCGGONCJCAD(UnsafeList<int>* EDKDECBLPLO, UnsafeList<float3>* ALCEELBNJLK, [NoAlias] float3* BHCDMPCEPKE, [NoAlias] float4* JBOMJGKJCFI, [NoAlias] float2* PCLKFMCPBEL, [NoAlias] float4* EKDLHDJNCEE, UnsafeList<MCFAIMMNKGE>* DNAAILGCEHH, UnsafeList<int>* OJADIHBFADF, UnsafeList<float3>* KDBGHIKEIAG, [NoAlias] float3* HBCLJLLJGJE, [NoAlias] float4* MCFNHBCODKE, [NoAlias] float2* DMANCOPDIJL, [NoAlias] float4* HMPKPDLLJCH, int IGENIDBBLGE, int MNAPDCDOKHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class DALKENOHGLD
{
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private static readonly ProfilerMarker GEJACIGEDGA;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public const int MGOOFFJMKII = 2;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private const int AHABIPBFGOF = 1;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private static int EPOBJOIKACJ;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private static Stack<DALKENOHGLD> LKJJEJPDKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private JOHNDGNODKM KIIBBHFNDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private NativeList<MCFAIMMNKGE> DNAAILGCEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private NativeList<int> OJADIHBFADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private NativeList<OOEHGBLKADD.GEEBFDDCDGG> IBENMDOCODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private NativeList<OOEHGBLKADD.GEEBFDDCDGG> OGKIKAAFGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private NativeList<OOEHGBLKADD.IIOLFAGEFFL> EJLCFHJPNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private NativeList<OOEHGBLKADD.IIOLFAGEFFL> BBILEKKLANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private OOEHGBLKADD AFDFOMMAFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private JobHandle JNHDFACBLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private OOEHGBLKADD.HBHKDHPMFGI KOCKJBCKIKF;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private const int LHPGDGJMOLL = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x808F180", Offset = "0x808D780", VA = "0x18808F180")]
	private DALKENOHGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x808EB10", Offset = "0x808D110", VA = "0x18808EB10")]
	public void OIHHNDPLODA(JOHNDGNODKM OIDKPLBGKBO, float3 AEMNEKAPLEA, float KCGAOIGOLKC, float JEJCHDAEGMF, float OKMDMANIKGN, List<JFFFMDLEDBA.MDOOJJDOLJF> NDGPFJKOKKG, Allocator OPJHHGPIOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x808E3C0", Offset = "0x808C9C0", VA = "0x18808E3C0")]
	public (bool, JOHNDGNODKM, float) LNEHADHPEPA(List<JFFFMDLEDBA.MDOOJJDOLJF> NDGPFJKOKKG, Allocator OPJHHGPIOEP, bool JIJGOOLFNLM)
	{
		return default((bool, JOHNDGNODKM, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x808E360", Offset = "0x808C960", VA = "0x18808E360")]
	public static bool JKGNOAAAMMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x808EAA0", Offset = "0x808D0A0", VA = "0x18808EAA0")]
	public static int NMHPNEKIIHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x808E200", Offset = "0x808C800", VA = "0x18808E200")]
	public static DALKENOHGLD HOEJOAILDDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x808EA00", Offset = "0x808D000", VA = "0x18808EA00")]
	internal static void NBMPCCIMFOG(DALKENOHGLD EKJMJPCMDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x808EF20", Offset = "0x808D520", VA = "0x18808EF20")]
	public static void OKMHCIMIKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x808E050", Offset = "0x808C650", VA = "0x18808E050")]
	[IEDOGDIKGGL(DEKJCOCACDG.ExitingPlayMode, 0)]
	public static void CHJGCNBDBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BurstCompile]
internal struct MCFAIMMNKGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public float3 JPAIMFCOEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public int AHAGBAPFHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public int AJEJAECKNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public int JGPJGCIFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public float MBOEKFGKLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public float IDCFINEFCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public int AKHOHCBIBOF;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8090B90", Offset = "0x808F190", VA = "0x188090B90")]
	public static void MMBKOMPANAO([Out] MCFAIMMNKGE HPCDHGHHCOO, int PCHKGIFGMKM, [In] float3 EGKHIBNBGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x8090BE0", Offset = "0x808F1E0", VA = "0x188090BE0")]
	[IgnoreWarning(1371)]
	public static void MMBKOMPANAO([Out] MCFAIMMNKGE HPCDHGHHCOO, [In] MCFAIMMNKGE DBMJINMFNBJ, [In] MCFAIMMNKGE BCLNLNDAPBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BurstCompile]
internal struct PJPOKPKKFDC : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct BNHGDAONNMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int BMHKOEDFKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int MLGAOGJIHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int FNCPDDMIGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public int OJMPOKNBEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int FFIHLOODJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int KJEHAFJIEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int DBLHKPJJNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int NICOBKDHMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public float OMEKLBCOJFG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private struct CLCIPKGGDKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public JEDJMLACHKM.MKPPFBPKGHI JJHEHILODIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public float GAOOFHDAOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public float NACOJJAOOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public float LEDGMMHKCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public float JDMOEMGCPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public float ABJKIINPBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public float LNBHJDELOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public float MEKEBGEKDHK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private struct MNFJHCLEMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public NativeArray<float3> OJJKAOLLJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public NativeArray<float3> CEECJMPCHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeArray<float4> OKNPPMHAECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeArray<float4> JHAJLJLMCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeArray<float2> CAMKOJIMJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeArray<int> GDBIONGPMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public bool HDPEKOJBINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public int FPAGOELIBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int EAEIKGJDEKJ;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8090ED0", Offset = "0x808F4D0", VA = "0x188090ED0")]
		public void CMAKEHGLHJI(int MNAPDCDOKHC, int IGENIDBBLGE, Allocator HOHBLCPFIEJ, bool KOGDOLOLJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8091170", Offset = "0x808F770", VA = "0x188091170")]
		public static MNFJHCLEMKK GFPOKGGIFHO(JOHNDGNODKM LFMKIINCPNH)
		{
			return default(MNFJHCLEMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x80910B0", Offset = "0x808F6B0", VA = "0x1880910B0")]
		public void DIGOPEEDGGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private static readonly ProfilerMarker MIIJKLAPNGE;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private static readonly ProfilerMarker IMIKMEJDMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private NativeArray<BNHGDAONNMO> NGDMPLMOEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private MNFJHCLEMKK IOKEEGNIDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private MNFJHCLEMKK AKMMEACMLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private float3 LLFCHBEMGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private float3 NBFHODEMKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private CLCIPKGGDKK JCOBGDOEJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* AILJPIBNNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private NativeArray<JFFFMDLEDBA.MDOOJJDOLJF> KLPKFLEJCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private NativeList<JFFFMDLEDBA.MDOOJJDOLJF> JPJKLNBDPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<int> OJADIHBFADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NativeArray<bool> DLJCGFDDJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NativeArray<int> LPMJJKKAGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private NativeArray<int> KPEBGIMDMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private NativeArray<float> EAPFIOOPNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private NativeArray<int> LGKEDJIDLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private NativeArray<float> IMNHMAJKDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private NativeArray<int> JGFEMEDEAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NativeArray<int> PJHPNMFGNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NativeArray<float> NHEBGFGFHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NativeArray<float> AOKOCAIPCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private NativeArray<int> CLNJHKALKHD;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x8094AA0", Offset = "0x80930A0", VA = "0x188094AA0")]
	public PJPOKPKKFDC([In] List<JFFFMDLEDBA.FNIEFLKFPJP> JEDNHMIIMJA, NativeList<JFFFMDLEDBA.MDOOJJDOLJF> MBNLFBIHNMN, [In] JOHNDGNODKM JEHFDFMMEPH, [In] NativeList<JFFFMDLEDBA.MDOOJJDOLJF> MIIAKMNBFPH, [In] NativeArray<long> PGAPEHHMGFO, float3 ODJPICEPMKA, float3 IJALAMGBIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x8093E20", Offset = "0x8092420", VA = "0x188093E20")]
	public static long ILOKJEFPBMB(int MNAPDCDOKHC, int IGENIDBBLGE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x8091C40", Offset = "0x8090240", VA = "0x188091C40", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x8091C90", Offset = "0x8090290", VA = "0x188091C90")]
	public void GIFAKKDMGPA(List<JFFFMDLEDBA.FNIEFLKFPJP> CKMDAAOOCGM, [In] JFFFMDLEDBA OJCIOCFIEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x8091C20", Offset = "0x8090220", VA = "0x188091C20")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool BJEFIMMABGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x80947D0", Offset = "0x8092DD0", VA = "0x1880947D0")]
	private ECGCNLKJEKF PHDCOGIGDKE(int HKBEDNIIPCN, Allocator HOHBLCPFIEJ)
	{
		return default(ECGCNLKJEKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x80926E0", Offset = "0x8090CE0", VA = "0x1880926E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void GOCEBICHEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x8093E40", Offset = "0x8092440", VA = "0x188093E40")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float KHNILFMEPKN(int GJHNPIGHOAD, int CNNDKBMAIGB, bool PHAEJOJHCHP, bool MGKJEFDDOMG, float BNDFNGMNDMD, float GDEJIKOFOOJ, float AKBKEAOFEMH, float MODAPPLJLNI, float ODGDBOCEOIB, float GAEPBLCJEOM, float DAGPKEAGGGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x80944B0", Offset = "0x8092AB0", VA = "0x1880944B0")]
	[IgnoreWarning(1371)]
	private BNHGDAONNMO MDOPMMJAOED([In] BNHGDAONNMO AGGFKPFHCOI, int AICDIMBJGJA, [In] NativeArray<int> MKHHILLHEAP, [In] NativeArray<bool> DLJCGFDDJBP, NativeArray<int> LPMJJKKAGDA)
	{
		return default(BNHGDAONNMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x8091A40", Offset = "0x8090040", VA = "0x188091A40")]
	public static int ALNCJGDNNAM(NativeArray<int> MKHHILLHEAP, NativeArray<int> CLNJHKALKHD, int FGPAPPAEKDI, int HIFJFNMGAKN, int BIADMCLLKIM)
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
		private struct FNEFBMHDKFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public long NAJOAMHNALL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public CBGPOBEFNJF ACMLBEHJCNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public BBFFBKDDGCJ LPCNJBGEJJI;

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x808F850", Offset = "0x808DE50", VA = "0x18808F850")]
			public FNEFBMHDKFI(CBGPOBEFNJF BEEGGECIKLP, BBFFBKDDGCJ KPDMNMEEFBJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		private class BDFCNKKGOGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public CBGPOBEFNJF ACMLBEHJCNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public int KABGKOBDGEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public float PGDIIAFECGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public List<FNEFBMHDKFI> KNCFBCFANON;

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x8085FC0", Offset = "0x80845C0", VA = "0x188085FC0")]
			public BDFCNKKGOGE(CBGPOBEFNJF BEEGGECIKLP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly ProfilerMarker AIDKCKAFJGA;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private static readonly ProfilerMarker HGHAGGAPKIO;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private static readonly ProfilerMarker APLFNLEHLON;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private static readonly ProfilerMarker ICEPPJOOLKG;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private static readonly ProfilerMarker NCHHKPKLIOG;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private static readonly ProfilerMarker EJNJJBDPEEP;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private static readonly ProfilerMarker MIELEBCDPJO;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		internal const int JGOJLBCOJOO = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		internal static Dictionary<Material, List<Material>> DPLHMNHNGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private Dictionary<Material, List<EDBEHNFKGLJ>> KBKHEIMIDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		internal List<EDBEHNFKGLJ> GGNNFJHDBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private List<MeshRenderer> FFGOPGKIKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private Transform NIHFOINEKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private bool LCABHOLIDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private bool IHNMLAMAKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private int IJBGLEKHFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EDBEHNFKGLJ OHINAHKMDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private Material HEAJMEEBFLA;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static bool? HKDDIHDGGEI;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private const int FEGBAPBJABM = 1024;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static List<FNEFBMHDKFI> LAKHPPNFOAK;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<MeshRenderer> HCPHNINPGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int FMDCMCGJPDP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x808E000", Offset = "0x808C600", VA = "0x18808E000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private static bool CKJPBFIIJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x80892B0", Offset = "0x80878B0", VA = "0x1880892B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		private static void HHPLHFNCNJG(bool HLBGMBDPKNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		private static void HHPLHFNCNJG(bool HLBGMBDPKNE, string CJIMOMNMAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		private static void JGOCBLJIDKD(string IEDAJGLJHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8087E00", Offset = "0x8086400", VA = "0x188087E00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8088740", Offset = "0x8086D40", VA = "0x188088740")]
		internal bool EOAEOFFABGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8087E30", Offset = "0x8086430", VA = "0x188087E30")]
		private Transform CIHMHDDOAKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x808A5A0", Offset = "0x8088BA0", VA = "0x18808A5A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8088330", Offset = "0x8086930", VA = "0x188088330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8087BE0", Offset = "0x80861E0", VA = "0x188087BE0")]
		public EDBEHNFKGLJ AddToBatchedMesh(BBFFBKDDGCJ NEEAHBFEMIE, Material KKIOJDIOKCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x808DAC0", Offset = "0x808C0C0", VA = "0x18808DAC0")]
		public void RemoveFromBatchedMesh(BBFFBKDDGCJ IDMOPPBKAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x8088200", Offset = "0x8086800", VA = "0x188088200")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8089480", Offset = "0x8087A80", VA = "0x188089480")]
		private void MGJKFJHOAEB(Renderer ILMDPGBOCFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8089240", Offset = "0x8087840", VA = "0x188089240")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x8089230", Offset = "0x8087830", VA = "0x188089230")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8087580", Offset = "0x8085B80", VA = "0x188087580")]
		private void AAOBCFMOINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8089660", Offset = "0x8087C60", VA = "0x188089660")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8087EB0", Offset = "0x80864B0", VA = "0x188087EB0")]
		private EDBEHNFKGLJ COHAOIGOIPD(BBFFBKDDGCJ IDMOPPBKAAO, Material KKIOJDIOKCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x80887A0", Offset = "0x8086DA0", VA = "0x1880887A0")]
		private EDBEHNFKGLJ FDIMFEHPDEF(Material KKIOJDIOKCM, int LCLFLFEEHAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8089D70", Offset = "0x8088370", VA = "0x188089D70")]
		private EDBEHNFKGLJ OMKDPCHECOM(Material KKIOJDIOKCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x80893E0", Offset = "0x80879E0", VA = "0x1880893E0")]
		internal float4x4 LAEHHKJLELF()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8088A80", Offset = "0x8087080", VA = "0x188088A80")]
		public static List<Material> GenerateVertexFormatVariants(Material KKIOJDIOKCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x14ED580", Offset = "0x14EBB80", VA = "0x1814ED580")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8089500", Offset = "0x8087B00", VA = "0x188089500")]
		public void MarkDirty(BBFFBKDDGCJ IDMOPPBKAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8089C70", Offset = "0x8088270", VA = "0x188089C70")]
		[Conditional("CHECK_STATE")]
		private void OCBFKDGOOJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8089890", Offset = "0x8087E90", VA = "0x188089890")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float IGJMPABLMOM)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x80880D0", Offset = "0x80866D0", VA = "0x1880880D0")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x808C560", Offset = "0x808AB60", VA = "0x18808C560")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8088BA0", Offset = "0x80871A0", VA = "0x188088BA0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x808A690", Offset = "0x8088C90", VA = "0x18808A690")]
		public void RebatchOptimally(int DGGGPNDJGPI, int PMDBHPNJJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x808A5B0", Offset = "0x8088BB0", VA = "0x18808A5B0")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x808DED0", Offset = "0x808C4D0", VA = "0x18808DED0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class ABNKEICHFIG
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct NJGAMJHEICK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public BatchedMeshRenderer ILMDPGBOCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public EDBEHNFKGLJ IDMOPPBKAAO;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1BC92C0", Offset = "0x1BC78C0", VA = "0x181BC92C0")]
		public void OPEPCFEDANA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct LLMMANGLHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public float IGMLCELABON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public EDBEHNFKGLJ HNOGHKLGEMK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class BMPHJCKKHGA : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private int <batchesPerYield>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private int <countdownBeforeYield>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <batchSizeNaughty>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private int <batchSizeNice>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x12003E0", Offset = "0x11FE9E0", VA = "0x1812003E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x8087410", Offset = "0x8085A10", VA = "0x188087410", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x142AB90", Offset = "0x1429190", VA = "0x18142AB90")]
		[DebuggerHidden]
		public BMPHJCKKHGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8087460", Offset = "0x8085A60", VA = "0x188087460", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x80860C0", Offset = "0x80846C0", VA = "0x1880860C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8086070", Offset = "0x8084670", VA = "0x188086070")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x80872C0", Offset = "0x80858C0", VA = "0x1880872C0")]
		private void NECCDOCMECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x80873C0", Offset = "0x80859C0", VA = "0x1880873C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8087310", Offset = "0x8085910", VA = "0x188087310", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8087310", Offset = "0x8085910", VA = "0x188087310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private static readonly ProfilerMarker EJNJJBDPEEP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private static readonly ProfilerMarker GBLHMEJIICH;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private static readonly ProfilerMarker HIIBNOCJJHJ;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private static readonly ProfilerMarker ILONDCDIIIJ;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static float3 CNMNIAJHKJO;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static int GIDOBCMNAKE;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static int ALFLEDJMMFD;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static int BOBOGIMDJDE;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static int FIHGGABNIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static int JMBGFJDNDBK;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static float FNPDHMJMHFD;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static float MBDBNLCDIGE;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static float OGKIMMIEBFG;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static float FOJOIOMOMPH;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static float HCPJJOMDHGO;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static float BJDBJIPPMIJ;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static float GGFEJLLGBHL;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static float GFDANFDDMAP;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private static List<BatchedMeshRenderer> ABIIEMEJGCI;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private static Stack<JOHNDGNODKM> NOIKDBIBGKB;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static Stack<JDIPKNPCLDJ> MAICGMNKDOL;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static GIELKEINIAC IDOJBJFNNFA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static NJGAMJHEICK GCMIBENOKDB;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static int LJANNGDLOKD;

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void HHPLHFNCNJG(bool HLBGMBDPKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void ICDILAGAFAI(bool HLBGMBDPKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void HHPLHFNCNJG(bool HLBGMBDPKNE, string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x8085B20", Offset = "0x8084120", VA = "0x188085B20")]
	public static void PNLBMDNIIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x8083FB0", Offset = "0x80825B0", VA = "0x188083FB0")]
	public static void JPDJIEMHALH(BatchedMeshRenderer GMDJBJNHCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8083E80", Offset = "0x8082480", VA = "0x188083E80")]
	public static void HFEPKKJPOMF(BatchedMeshRenderer GMDJBJNHCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x80853B0", Offset = "0x80839B0", VA = "0x1880853B0")]
	public static void PDLJCDHANBE(BBFFBKDDGCJ LBFDKIMLIBL, bool MBDJAGOEBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8083B00", Offset = "0x8082100", VA = "0x188083B00")]
	public static void GKJGLNMBPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8084740", Offset = "0x8082D40", VA = "0x188084740")]
	public static void MLNKBGKEFJL(float IGJMPABLMOM, bool JDGKAINDPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x80840F0", Offset = "0x80826F0", VA = "0x1880840F0")]
	private static void KEAHECDCCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8082BD0", Offset = "0x80811D0", VA = "0x188082BD0")]
	public static long CHNGIICLNKE(int PBECPMECGHD, long KAHGPBBKOCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x80829C0", Offset = "0x8080FC0", VA = "0x1880829C0")]
	public static (long, long, int) BKOKGAIGONB(float IGJMPABLMOM)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8085320", Offset = "0x8083920", VA = "0x188085320")]
	[IteratorStateMachine(typeof(BMPHJCKKHGA))]
	public static IEnumerable<bool> OLJGEAABNIH(long GIMCMNAPGHH, bool NGIKEGEIPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8083850", Offset = "0x8081E50", VA = "0x188083850")]
	public static void FIGPBDBIAKD(long GIMCMNAPGHH, bool NGIKEGEIPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x80836D0", Offset = "0x8081CD0", VA = "0x1880836D0")]
	public static int FDMGJPKBOMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8082840", Offset = "0x8080E40", VA = "0x188082840")]
	internal static JOHNDGNODKM BJDLKGEDHPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8085000", Offset = "0x8083600", VA = "0x188085000")]
	internal static void NBMPCCIMFOG(JOHNDGNODKM MIAFLIFPFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x80845F0", Offset = "0x8082BF0", VA = "0x1880845F0")]
	internal static JDIPKNPCLDJ MDEMJIAOONF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x80850B0", Offset = "0x80836B0", VA = "0x1880850B0")]
	internal static void NBMPCCIMFOG(JDIPKNPCLDJ PJABPPGEPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8085140", Offset = "0x8083740", VA = "0x188085140")]
	public static void OKMHCIMIKBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class MJOBIJEHAPD<KeyType> : EDBEHNFKGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private readonly Dictionary<KeyType, BBFFBKDDGCJ> HCOJFOGILIE;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5612F90", Offset = "0x5611590", VA = "0x185612F90")]
	public MJOBIJEHAPD(string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5612DA0", Offset = "0x56113A0", VA = "0x185612DA0")]
	public void IFODEOFHJDD(KeyType BLIBAMJKLIA, BBFFBKDDGCJ LBFDKIMLIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5612BE0", Offset = "0x56111E0", VA = "0x185612BE0")]
	public bool IEINBKAHDCJ(KeyType BLIBAMJKLIA, BBFFBKDDGCJ ANBANAJNEON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5612EE0", Offset = "0x56114E0", VA = "0x185612EE0")]
	public void OKKKLKLICBA(KeyType BLIBAMJKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5612DF0", Offset = "0x56113F0", VA = "0x185612DF0", Slot = "4")]
	public override void NBEMJGODPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class GCLMFGPAGDD
{
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly ProfilerCategory FJHHDAFLOGF;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	internal static readonly ProfilerMarker GHANOEPKKEC;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	internal static readonly GKPLGGPFIBC MLNKBGKEFJL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private static readonly FFJFPDPMAEH<float> MMEELICPNHH;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private static readonly FFJFPDPMAEH<float> IAEAOJLOGCK;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly FFJFPDPMAEH<double> BKACBKAGCNK;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly FFJFPDPMAEH<double> LEEFPDNGGHE;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly FFJFPDPMAEH<double> EKIOPDLFFNN;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static readonly FFJFPDPMAEH<int> GBAMGNGJNNJ;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly FFJFPDPMAEH<int> DDGNJIMGGOL;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly FFJFPDPMAEH<int> ENAJJNKEHEA;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly FFJFPDPMAEH<int> KNIFDAKICPD;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly FFJFPDPMAEH<int> AKPBJINGIPN;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly FFJFPDPMAEH<int> ALMAFBFAMDK;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly FFJFPDPMAEH<int> GIDKGPPGLMC;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private static readonly FFJFPDPMAEH<int> GMMDLNPIJAH;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly FFJFPDPMAEH<long> LKLNMNEKBAA;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private static readonly FFJFPDPMAEH<long> JAOLALEPPML;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly FFJFPDPMAEH<long> HEBKENCOPPO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly FFJFPDPMAEH<long> HLDFOGOADCL;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly FFJFPDPMAEH<long> GNFOEEKCNFG;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x808F880", Offset = "0x808DE80", VA = "0x18808F880")]
	public static void EGGBNOJOBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x8095370", Offset = "0x8093970", VA = "0x188095370")]
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
