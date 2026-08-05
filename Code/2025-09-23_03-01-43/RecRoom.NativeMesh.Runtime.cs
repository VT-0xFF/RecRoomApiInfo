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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x859ACD0", Offset = "0x85992D0", VA = "0x18859ACD0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class CODBOJNEEGP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IPHNFELODMJ KKOOHJCKDCB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly IPHNFELODMJ KINAMKAEIKG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly IPHNFELODMJ CKICDDFJFGI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly IPHNFELODMJ EMENLIIBBOB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly IPHNFELODMJ DLENLEECAMD;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class BIIDLGNKDOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public MDMMNAGODKB NPKCMCHDHHN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MENDNKMGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public BIIDLGNKDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct MDMMNAGODKB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct HJINBKGKIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half HGLCAJHEGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort DACEAIDFMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte OBCPINMCNPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void AMMANPDIAGG([NoAlias] float3* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class AMOJCKKGLNG
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8583FB0", Offset = "0x85825B0", VA = "0x188583FB0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85843C0", Offset = "0x85829C0", VA = "0x1885843C0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8584310", Offset = "0x8582910", VA = "0x188584310")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85840E0", Offset = "0x85826E0", VA = "0x1885840E0")]
		public unsafe static void MJPLNPACNDN([NoAlias] float3* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void HKHHFANIAPD([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class NBPFHEBIICH
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85A3640", Offset = "0x85A1C40", VA = "0x1885A3640")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85A3AD0", Offset = "0x85A20D0", VA = "0x1885A3AD0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85A3A20", Offset = "0x85A2020", VA = "0x1885A3A20")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85A3770", Offset = "0x85A1D70", VA = "0x1885A3770")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void JEBCBMLLNGJ([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class FOJBIHJKFHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x858B5C0", Offset = "0x8589BC0", VA = "0x18858B5C0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x858BA50", Offset = "0x858A050", VA = "0x18858BA50")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x858B9A0", Offset = "0x8589FA0", VA = "0x18858B9A0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x858B6F0", Offset = "0x8589CF0", VA = "0x18858B6F0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void PPLMKFJFDKH([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class EMAJLIFLBHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x858A3F0", Offset = "0x85889F0", VA = "0x18858A3F0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x858A880", Offset = "0x8588E80", VA = "0x18858A880")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x858A7D0", Offset = "0x8588DD0", VA = "0x18858A7D0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x858A520", Offset = "0x8588B20", VA = "0x18858A520")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void EMJLLFMLJFJ([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class GOGPGAKHJIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8594BB0", Offset = "0x85931B0", VA = "0x188594BB0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8595040", Offset = "0x8593640", VA = "0x188595040")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8594F90", Offset = "0x8593590", VA = "0x188594F90")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8594CE0", Offset = "0x85932E0", VA = "0x188594CE0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void GPBLOLBOPJJ([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class EADANOCPOJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85885A0", Offset = "0x8586BA0", VA = "0x1885885A0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8588AC0", Offset = "0x85870C0", VA = "0x188588AC0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8588A10", Offset = "0x8587010", VA = "0x188588A10")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85886D0", Offset = "0x8586CD0", VA = "0x1885886D0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void GMCALILMKFD([NoAlias] ushort* EBHKBCADLJB, [Out] float3 EDADINCFKFM, [Out] float3 JBPFEBGEDGP, [In][NoAlias] float3* BAAFMIKAAEK, int KCBGBOHCGPM, int PAHLOFNIDEF);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class BBHIFEGKEMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8585330", Offset = "0x8583930", VA = "0x188585330")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8585750", Offset = "0x8583D50", VA = "0x188585750")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85856A0", Offset = "0x8583CA0", VA = "0x1885856A0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8585460", Offset = "0x8583A60", VA = "0x188585460")]
		public unsafe static void MJPLNPACNDN([NoAlias] ushort* EBHKBCADLJB, [Out] float3 EDADINCFKFM, [Out] float3 JBPFEBGEDGP, [In][NoAlias] float3* BAAFMIKAAEK, int KCBGBOHCGPM, int PAHLOFNIDEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void DJCDFJEKLCB([NoAlias] ushort* EFCBGNMNILN, [In][NoAlias] float3* NFLGDOPNNDK, int PAHLOFNIDEF);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class GJLBABJHNIK
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x858CE50", Offset = "0x858B450", VA = "0x18858CE50")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x858D240", Offset = "0x858B840", VA = "0x18858D240")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x858D190", Offset = "0x858B790", VA = "0x18858D190")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x858CF80", Offset = "0x858B580", VA = "0x18858CF80")]
		public unsafe static void MJPLNPACNDN([NoAlias] ushort* EFCBGNMNILN, [In][NoAlias] float3* NFLGDOPNNDK, int PAHLOFNIDEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void IAKPBGFDLPO([NoAlias] float3* EEHIMCPHNEO, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class BIFNAAHLAGN
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85859B0", Offset = "0x8583FB0", VA = "0x1885859B0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8585DA0", Offset = "0x85843A0", VA = "0x188585DA0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8585CF0", Offset = "0x85842F0", VA = "0x188585CF0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8585AE0", Offset = "0x85840E0", VA = "0x188585AE0")]
		public unsafe static void MJPLNPACNDN([NoAlias] float3* EEHIMCPHNEO, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void NNDLDBLPAKD([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class IIAKLDEHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8596A00", Offset = "0x8595000", VA = "0x188596A00")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8596DF0", Offset = "0x85953F0", VA = "0x188596DF0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8596D40", Offset = "0x8595340", VA = "0x188596D40")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8596B30", Offset = "0x8595130", VA = "0x188596B30")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void LMIBOAFDBIO([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class FJIOMBJIDJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x858AE80", Offset = "0x8589480", VA = "0x18858AE80")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x858B360", Offset = "0x8589960", VA = "0x18858B360")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x858B2B0", Offset = "0x85898B0", VA = "0x18858B2B0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x858AFB0", Offset = "0x85895B0", VA = "0x18858AFB0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void CKFBOJCHKGF([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class OMMCNCFPMCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85A67D0", Offset = "0x85A4DD0", VA = "0x1885A67D0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85A6CB0", Offset = "0x85A52B0", VA = "0x1885A6CB0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85A6C00", Offset = "0x85A5200", VA = "0x1885A6C00")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x85A6900", Offset = "0x85A4F00", VA = "0x1885A6900")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void IFFFGIJFMOH([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class EEEPKIAGDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8589190", Offset = "0x8587790", VA = "0x188589190")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85896A0", Offset = "0x8587CA0", VA = "0x1885896A0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x85895F0", Offset = "0x8587BF0", VA = "0x1885895F0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85892C0", Offset = "0x85878C0", VA = "0x1885892C0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void INLFJNJBPMK([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class NEACMLFBAJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85A41B0", Offset = "0x85A27B0", VA = "0x1885A41B0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x85A46C0", Offset = "0x85A2CC0", VA = "0x1885A46C0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85A4610", Offset = "0x85A2C10", VA = "0x1885A4610")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85A42E0", Offset = "0x85A28E0", VA = "0x1885A42E0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void HHDMKKFBNGJ([NoAlias] uint* LNNHAGGKCKO, [Out] float2 MKLOJDBGALP, [Out] float2 ALMPJNHAKPD, [In][NoAlias] float2* GCLJDJHBBBP, int KCBGBOHCGPM, int PAHLOFNIDEF);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class NDJHKMOGHAC
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85A3C30", Offset = "0x85A2230", VA = "0x1885A3C30")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85A4050", Offset = "0x85A2650", VA = "0x1885A4050")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85A3FA0", Offset = "0x85A25A0", VA = "0x1885A3FA0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85A3D60", Offset = "0x85A2360", VA = "0x1885A3D60")]
		public unsafe static void MJPLNPACNDN([NoAlias] uint* LNNHAGGKCKO, [Out] float2 MKLOJDBGALP, [Out] float2 ALMPJNHAKPD, [In][NoAlias] float2* GCLJDJHBBBP, int KCBGBOHCGPM, int PAHLOFNIDEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void AMDKCNJKALA([Out] float2 FBGMDLDCCBP, uint OHCMCMMHDCB, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class CJLBKOBEKOM
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8586A30", Offset = "0x8585030", VA = "0x188586A30")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8586E70", Offset = "0x8585470", VA = "0x188586E70")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8586DC0", Offset = "0x85853C0", VA = "0x188586DC0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8586B60", Offset = "0x8585160", VA = "0x188586B60")]
		public static void MJPLNPACNDN([Out] float2 FBGMDLDCCBP, uint OHCMCMMHDCB, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void JKJCGEFDMHD([NoAlias] float2* LNNHAGGKCKO, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class JJGDMNADCHL
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8598E10", Offset = "0x8597410", VA = "0x188598E10")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85992E0", Offset = "0x85978E0", VA = "0x1885992E0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8599230", Offset = "0x8597830", VA = "0x188599230")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8598F40", Offset = "0x8597540", VA = "0x188598F40")]
		public unsafe static void MJPLNPACNDN([NoAlias] float2* LNNHAGGKCKO, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void FJJJEJAJLAO([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class ONOIMELKEPI
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E10", Offset = "0x85A5410", VA = "0x1885A6E10")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x85A7310", Offset = "0x85A5910", VA = "0x1885A7310")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x85A7260", Offset = "0x85A5860", VA = "0x1885A7260")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x85A6F40", Offset = "0x85A5540", VA = "0x1885A6F40")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void MHAGBBKDCGM([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class JDGKLLKNALD
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8597CC0", Offset = "0x85962C0", VA = "0x188597CC0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x85981C0", Offset = "0x85967C0", VA = "0x1885981C0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8598110", Offset = "0x8596710", VA = "0x188598110")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8597DF0", Offset = "0x85963F0", VA = "0x188597DF0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void BLFBFMIMBJL([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class BBFCBFMLCDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8584DC0", Offset = "0x85833C0", VA = "0x188584DC0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x85851D0", Offset = "0x85837D0", VA = "0x1885851D0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8585120", Offset = "0x8583720", VA = "0x188585120")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8584EF0", Offset = "0x85834F0", VA = "0x188584EF0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void MDOBDMCLLOO([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class KFIBCFOPCON
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8599440", Offset = "0x8597A40", VA = "0x188599440")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8599930", Offset = "0x8597F30", VA = "0x188599930")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8599880", Offset = "0x8597E80", VA = "0x188599880")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8599570", Offset = "0x8597B70", VA = "0x188599570")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void FHADEOHDCIA([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class MBKPKAOPKMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x859B180", Offset = "0x8599780", VA = "0x18859B180")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x859B680", Offset = "0x8599C80", VA = "0x18859B680")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x859B5D0", Offset = "0x8599BD0", VA = "0x18859B5D0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x859B2B0", Offset = "0x85998B0", VA = "0x18859B2B0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void FDOHDPGFLLH([NoAlias] ushort* GNJOJOGNKMM, [In][NoAlias] float4* OEOMMODNLCK, int KCBGBOHCGPM, int PAHLOFNIDEF);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class DOPPCHADHGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8587FC0", Offset = "0x85865C0", VA = "0x188587FC0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8588440", Offset = "0x8586A40", VA = "0x188588440")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8588390", Offset = "0x8586990", VA = "0x188588390")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x85880F0", Offset = "0x85866F0", VA = "0x1885880F0")]
		public unsafe static void MJPLNPACNDN([NoAlias] ushort* GNJOJOGNKMM, [In][NoAlias] float4* OEOMMODNLCK, int KCBGBOHCGPM, int PAHLOFNIDEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort NOLPKKDPOPN([In] float4 ADDPDDBMFBK);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class HJIJCLNGDFO
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x85958A0", Offset = "0x8593EA0", VA = "0x1885958A0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8595CE0", Offset = "0x85942E0", VA = "0x188595CE0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8595C30", Offset = "0x8594230", VA = "0x188595C30")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85959D0", Offset = "0x8593FD0", VA = "0x1885959D0")]
		public static ushort MJPLNPACNDN([In] float4 ADDPDDBMFBK)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void EOECNHFNMID([NoAlias] float4* GNJOJOGNKMM, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class OHMIDJGEJCD
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x85A5540", Offset = "0x85A3B40", VA = "0x1885A5540")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x85A59C0", Offset = "0x85A3FC0", VA = "0x1885A59C0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x85A5910", Offset = "0x85A3F10", VA = "0x1885A5910")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x85A5670", Offset = "0x85A3C70", VA = "0x1885A5670")]
		public unsafe static void MJPLNPACNDN([NoAlias] float4* GNJOJOGNKMM, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void KHJNFPFHJCC([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class MFOCLBBPPBN
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85A30F0", Offset = "0x85A16F0", VA = "0x1885A30F0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85A34E0", Offset = "0x85A1AE0", VA = "0x1885A34E0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x85A3430", Offset = "0x85A1A30", VA = "0x1885A3430")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85A3220", Offset = "0x85A1820", VA = "0x1885A3220")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void PKHHLHOFCEM([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class EFDDIMGDHPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8589800", Offset = "0x8587E00", VA = "0x188589800")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8589D10", Offset = "0x8588310", VA = "0x188589D10")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8589C60", Offset = "0x8588260", VA = "0x188589C60")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8589930", Offset = "0x8587F30", VA = "0x188589930")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void JPHFPLAJFIO([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class GAFNLFEOPCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x858BBB0", Offset = "0x858A1B0", VA = "0x18858BBB0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x858C0C0", Offset = "0x858A6C0", VA = "0x18858C0C0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x858C010", Offset = "0x858A610", VA = "0x18858C010")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x858BCE0", Offset = "0x858A2E0", VA = "0x18858BCE0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void COAENKOMDNA([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class NMCKGKPCFID
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x85A4820", Offset = "0x85A2E20", VA = "0x1885A4820")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x85A4D90", Offset = "0x85A3390", VA = "0x1885A4D90")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85A4CE0", Offset = "0x85A32E0", VA = "0x1885A4CE0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85A4950", Offset = "0x85A2F50", VA = "0x1885A4950")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void NLHLLOEJJIF([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class OMAEOAIBNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85A6100", Offset = "0x85A4700", VA = "0x1885A6100")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85A6670", Offset = "0x85A4C70", VA = "0x1885A6670")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x85A65C0", Offset = "0x85A4BC0", VA = "0x1885A65C0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85A6230", Offset = "0x85A4830", VA = "0x1885A6230")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void IDODBGENPIC([Out] float4 FAKHJBCPGHO, ushort OHCMCMMHDCB);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class OJHNHNFBGAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x85A5B20", Offset = "0x85A4120", VA = "0x1885A5B20")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85A5FA0", Offset = "0x85A45A0", VA = "0x1885A5FA0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85A5EF0", Offset = "0x85A44F0", VA = "0x1885A5EF0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x85A5C50", Offset = "0x85A4250", VA = "0x1885A5C50")]
		public static void MJPLNPACNDN([Out] float4 FAKHJBCPGHO, ushort OHCMCMMHDCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void FNOIAMPJELB([NoAlias] float4* JMCLGPDJANC, [NoAlias] byte* LJPILNCJAFN, [Out] int CJPKDLNGKBO, [Out] int DPGFDMBFIGF, [NoAlias] float4* DEMDLLGIEIH, [NoAlias] float4* KHMICDECFFM, int KCBGBOHCGPM, int PAHLOFNIDEF);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class COFIGIJGLNF
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8587A40", Offset = "0x8586040", VA = "0x188587A40")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8587E60", Offset = "0x8586460", VA = "0x188587E60")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8587DB0", Offset = "0x85863B0", VA = "0x188587DB0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8587B70", Offset = "0x8586170", VA = "0x188587B70")]
		public unsafe static void MJPLNPACNDN([NoAlias] float4* JMCLGPDJANC, [NoAlias] byte* LJPILNCJAFN, [Out] int CJPKDLNGKBO, [Out] int DPGFDMBFIGF, [NoAlias] float4* DEMDLLGIEIH, [NoAlias] float4* KHMICDECFFM, int KCBGBOHCGPM, int PAHLOFNIDEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void EEIBKMBABKA([NoAlias] float4* HBLPMCFJAHI, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class CKCMPHCJFAP
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8586FD0", Offset = "0x85855D0", VA = "0x188586FD0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x85874B0", Offset = "0x8585AB0", VA = "0x1885874B0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8587400", Offset = "0x8585A00", VA = "0x188587400")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8587100", Offset = "0x8585700", VA = "0x188587100")]
		public unsafe static void MJPLNPACNDN([NoAlias] float4* HBLPMCFJAHI, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void EABJHKEHINB([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class INDJCEFINFE
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8596F50", Offset = "0x8595550", VA = "0x188596F50")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x85974E0", Offset = "0x8595AE0", VA = "0x1885974E0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8597430", Offset = "0x8595A30", VA = "0x188597430")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8597080", Offset = "0x8595680", VA = "0x188597080")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void DKMHNILGFJC([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class HDENDDEEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85951A0", Offset = "0x85937A0", VA = "0x1885951A0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8595740", Offset = "0x8593D40", VA = "0x188595740")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8595690", Offset = "0x8593C90", VA = "0x188595690")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x85952D0", Offset = "0x85938D0", VA = "0x1885952D0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void IFGHCGFKOBH([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class GHPPIKDGAAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x858C760", Offset = "0x858AD60", VA = "0x18858C760")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x858CCF0", Offset = "0x858B2F0", VA = "0x18858CCF0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x858CC40", Offset = "0x858B240", VA = "0x18858CC40")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x858C890", Offset = "0x858AE90", VA = "0x18858C890")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void ABMGOIIGOKN([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class EAJCPJJFAFB
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8588C20", Offset = "0x8587220", VA = "0x188588C20")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8589030", Offset = "0x8587630", VA = "0x188589030")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8588F80", Offset = "0x8587580", VA = "0x188588F80")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8588D50", Offset = "0x8587350", VA = "0x188588D50")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void JAFCHNFJPNN([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class JHDGFPBKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x85988A0", Offset = "0x8596EA0", VA = "0x1885988A0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8598CB0", Offset = "0x85972B0", VA = "0x188598CB0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8598C00", Offset = "0x8597200", VA = "0x188598C00")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x85989D0", Offset = "0x8596FD0", VA = "0x1885989D0")]
		public unsafe static void MJPLNPACNDN([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int KIKEEJIEFNJ([NoAlias] byte* IIEMKNNIFFA, [In][NoAlias] int* PNALODEIKLP, int NCGOMHEECDM);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class KGFDAHJPDPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8599A90", Offset = "0x8598090", VA = "0x188599A90")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8599F10", Offset = "0x8598510", VA = "0x188599F10")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8599E60", Offset = "0x8598460", VA = "0x188599E60")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8599BC0", Offset = "0x85981C0", VA = "0x188599BC0")]
		public unsafe static int MJPLNPACNDN([NoAlias] byte* IIEMKNNIFFA, [In][NoAlias] int* PNALODEIKLP, int NCGOMHEECDM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void AALLBFFADPB([NoAlias] int* JLLCNBAMLFP, [In][NoAlias] byte* AIKABBBCPDJ, int EFENLDGOGPK);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class LACICJEAMME
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x859A170", Offset = "0x8598770", VA = "0x18859A170")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x859A5B0", Offset = "0x8598BB0", VA = "0x18859A5B0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x859A500", Offset = "0x8598B00", VA = "0x18859A500")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x859A2A0", Offset = "0x85988A0", VA = "0x18859A2A0")]
		public unsafe static void MJPLNPACNDN([NoAlias] int* JLLCNBAMLFP, [In][NoAlias] byte* AIKABBBCPDJ, int EFENLDGOGPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void MCIKNNIOLNP([NoAlias] ushort* JLLCNBAMLFP, [In][NoAlias] byte* AIKABBBCPDJ, int EFENLDGOGPK);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class BPCCJDALCJH
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8585F00", Offset = "0x8584500", VA = "0x188585F00")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8586350", Offset = "0x8584950", VA = "0x188586350")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x85862A0", Offset = "0x85848A0", VA = "0x1885862A0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8586030", Offset = "0x8584630", VA = "0x188586030")]
		public unsafe static void MJPLNPACNDN([NoAlias] ushort* JLLCNBAMLFP, [In][NoAlias] byte* AIKABBBCPDJ, int EFENLDGOGPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void NHDPNMFIMNK([Out] float3 FBGMDLDCCBP, ushort OHCMCMMHDCB);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class OFBPOIFELJP
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x85A4FF0", Offset = "0x85A35F0", VA = "0x1885A4FF0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85A53E0", Offset = "0x85A39E0", VA = "0x1885A53E0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x85A5330", Offset = "0x85A3930", VA = "0x1885A5330")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85A5120", Offset = "0x85A3720", VA = "0x1885A5120")]
		public static void MJPLNPACNDN([Out] float3 FBGMDLDCCBP, ushort OHCMCMMHDCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort OGAFGHIBIAO([In] float3 ADDPDDBMFBK);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class GCEEAGBMCOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x858C220", Offset = "0x858A820", VA = "0x18858C220")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x858C600", Offset = "0x858AC00", VA = "0x18858C600")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x858C550", Offset = "0x858AB50", VA = "0x18858C550")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x858C350", Offset = "0x858A950", VA = "0x18858C350")]
		public static ushort MJPLNPACNDN([In] float3 ADDPDDBMFBK)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker NECIMLANFEA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker OGHBIJGKHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int MENDNKMGKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int EFENLDGOGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> LMLKICDHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> IBCJGILIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> BEFJOCFHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> AEICOIIEHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<HJINBKGKIJF> HLFENNFMLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> IFLEKAHFANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> OBIBBENNFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 FPFJBDHGHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 JBPFEBGEDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 HDHBEICEDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 ALMPJNHAKPD;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long CODADFEIJJN;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long CEDOKPDIMDF;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float PEMGAOPDDDD;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool DNOPAGIPMID;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DEKPKOANCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x859E5A0", Offset = "0x859CBA0", VA = "0x18859E5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OONKEIMFJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85A2E60", Offset = "0x85A1460", VA = "0x1885A2E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x859DBE0", Offset = "0x859C1E0", VA = "0x18859DBE0")]
	public void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x859C070", Offset = "0x859A670", VA = "0x18859C070")]
	public static MDMMNAGODKB CEAHGFMKGJD(Allocator EEDCBHBBPKF, GKMCCFCPGAH OMNGABOEDEJ)
	{
		return default(MDMMNAGODKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x859C340", Offset = "0x859A940", VA = "0x18859C340")]
	public static MDMMNAGODKB CEAHGFMKGJD(Allocator EEDCBHBBPKF, NativeArray<float3> BAAFMIKAAEK, NativeArray<float3> NFLGDOPNNDK, NativeArray<float2> GCLJDJHBBBP, NativeArray<float4> KHMICDECFFM, bool NDLKEHPGABB, NativeArray<float4> OLDBECCMFPL, NativeArray<int> PNALODEIKLP, int MENDNKMGKGP, int CPNEOMLEMAP, int EFENLDGOGPK, int KCBGBOHCGPM)
	{
		return default(MDMMNAGODKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85A1810", Offset = "0x859FE10", VA = "0x1885A1810")]
	public void MHCPBIPOGJC(GKMCCFCPGAH FAKHJBCPGHO, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85A0BA0", Offset = "0x859F1A0", VA = "0x1885A0BA0")]
	public long LLJKBENNNNC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85A05D0", Offset = "0x859EBD0", VA = "0x1885A05D0")]
	public long KEGHCPBHFJG(GKMCCFCPGAH.DJLMDIAEFCE OFCLANOKPBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85A04A0", Offset = "0x859EAA0", VA = "0x1885A04A0")]
	private void KEBIFLKGLKF(int HDHJMLGDJCC, int PAHLOFNIDEF, Allocator EEDCBHBBPKF, bool FFJMFEOHINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85A2CD0", Offset = "0x85A12D0", VA = "0x1885A2CD0")]
	private void OLNHEFLCFPC(NativeArray<float3> EBHKBCADLJB, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85A2C50", Offset = "0x85A1250", VA = "0x1885A2C50")]
	[BurstCompile]
	private unsafe static void OLNHEFLCFPC([NoAlias] float3* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x859DEB0", Offset = "0x859C4B0", VA = "0x18859DEB0")]
	[BurstCompile]
	private unsafe static void FDINJPCIOAP([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x859EBE0", Offset = "0x859D1E0", VA = "0x18859EBE0")]
	[BurstCompile]
	private unsafe static void GHCJLFIEDOB([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x859F850", Offset = "0x859DE50", VA = "0x18859F850")]
	[BurstCompile]
	private unsafe static void IICGFEAMCLL([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85A02E0", Offset = "0x859E8E0", VA = "0x1885A02E0")]
	[BurstCompile]
	private unsafe static void KBFCBOGJKGC([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x859CC30", Offset = "0x859B230", VA = "0x18859CC30")]
	[BurstCompile]
	private unsafe static void DBABCEGJFEA([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85A09F0", Offset = "0x859EFF0", VA = "0x1885A09F0")]
	private void LIPJEAOGKGK(NativeArray<float3> BAAFMIKAAEK, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85A0B10", Offset = "0x859F110", VA = "0x1885A0B10")]
	[BurstCompile]
	private unsafe static void LIPJEAOGKGK([NoAlias] ushort* EBHKBCADLJB, [Out] float3 EDADINCFKFM, [Out] float3 JBPFEBGEDGP, [In][NoAlias] float3* BAAFMIKAAEK, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x859F5B0", Offset = "0x859DBB0", VA = "0x18859F5B0")]
	private void IDIFCBHFEMI(NativeArray<float3> NFLGDOPNNDK, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x859F360", Offset = "0x859D960", VA = "0x18859F360")]
	[BurstCompile]
	private unsafe static void IDIFCBHFEMI([NoAlias] ushort* EFCBGNMNILN, [In][NoAlias] float3* NFLGDOPNNDK, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x859DF30", Offset = "0x859C530", VA = "0x18859DF30")]
	private void FINIALHCEED(NativeArray<float3> EEHIMCPHNEO, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x859DFF0", Offset = "0x859C5F0", VA = "0x18859DFF0")]
	[BurstCompile]
	private unsafe static void FINIALHCEED([NoAlias] float3* EEHIMCPHNEO, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x859B8C0", Offset = "0x8599EC0", VA = "0x18859B8C0")]
	[BurstCompile]
	private unsafe static void BECAKFAGGKI([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x859C810", Offset = "0x859AE10", VA = "0x18859C810")]
	[BurstCompile]
	private unsafe static void CGKEKLGCOLL([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x859D9D0", Offset = "0x859BFD0", VA = "0x18859D9D0")]
	[BurstCompile]
	private unsafe static void EEAOELODHED([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85A0080", Offset = "0x859E680", VA = "0x1885A0080")]
	[BurstCompile]
	private unsafe static void JFHJBAPGAGH([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x859B850", Offset = "0x8599E50", VA = "0x18859B850")]
	[BurstCompile]
	private unsafe static void AEOFLOOKAJP([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x859DD90", Offset = "0x859C390", VA = "0x18859DD90")]
	private void ENCMBHPMENL(NativeArray<float2> GCLJDJHBBBP, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x859DD00", Offset = "0x859C300", VA = "0x18859DD00")]
	[BurstCompile]
	private unsafe static void ENCMBHPMENL([NoAlias] uint* LNNHAGGKCKO, [Out] float2 MKLOJDBGALP, [Out] float2 ALMPJNHAKPD, [In][NoAlias] float2* GCLJDJHBBBP, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85A0890", Offset = "0x859EE90", VA = "0x1885A0890")]
	[BurstCompile]
	private static void LEMILOAHGOM([Out] float2 FBGMDLDCCBP, uint OHCMCMMHDCB, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x859FB40", Offset = "0x859E140", VA = "0x18859FB40")]
	private void IOLJPCHDKAP(NativeArray<float2> LNNHAGGKCKO, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x859FC60", Offset = "0x859E260", VA = "0x18859FC60")]
	[BurstCompile]
	private unsafe static void IOLJPCHDKAP([NoAlias] float2* LNNHAGGKCKO, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x859E240", Offset = "0x859C840", VA = "0x18859E240")]
	[BurstCompile]
	private unsafe static void FLPDADAKEKN([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85A00F0", Offset = "0x859E6F0", VA = "0x1885A00F0")]
	[BurstCompile]
	private unsafe static void JGMPFFEAPJA([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85A2050", Offset = "0x85A0650", VA = "0x1885A2050")]
	[BurstCompile]
	private unsafe static void NGHIFAPMNKF([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x859BD30", Offset = "0x859A330", VA = "0x18859BD30")]
	[BurstCompile]
	private unsafe static void BHFNLGCHDKC([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x859C790", Offset = "0x859AD90", VA = "0x18859C790")]
	[BurstCompile]
	private unsafe static void CFNBCEOEFLI([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85A1530", Offset = "0x859FB30", VA = "0x1885A1530")]
	private void MEKGCBNDJIE(NativeArray<float4> OLDBECCMFPL, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85A14B0", Offset = "0x859FAB0", VA = "0x1885A14B0")]
	[BurstCompile]
	private unsafe static void MEKGCBNDJIE([NoAlias] ushort* GNJOJOGNKMM, [In][NoAlias] float4* OEOMMODNLCK, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x85A0030", Offset = "0x859E630", VA = "0x1885A0030")]
	[BurstCompile]
	private static ushort JFCELEAOLIF([In] float4 ADDPDDBMFBK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85A10D0", Offset = "0x859F6D0", VA = "0x1885A10D0")]
	private void MAJDOFIKOMJ(NativeArray<float4> GNJOJOGNKMM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85A1060", Offset = "0x859F660", VA = "0x1885A1060")]
	[BurstCompile]
	private unsafe static void MAJDOFIKOMJ([NoAlias] float4* GNJOJOGNKMM, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x859C9E0", Offset = "0x859AFE0", VA = "0x18859C9E0")]
	[BurstCompile]
	private unsafe static void CJJPCBDNCFF([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x859EB70", Offset = "0x859D170", VA = "0x18859EB70")]
	[BurstCompile]
	private unsafe static void GHCEBOOABLA([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85A2DF0", Offset = "0x85A13F0", VA = "0x1885A2DF0")]
	[BurstCompile]
	private unsafe static void PGKHKJACIOF([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x85A0FF0", Offset = "0x859F5F0", VA = "0x1885A0FF0")]
	[BurstCompile]
	private unsafe static void LNLPEJODCKN([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x85A2340", Offset = "0x85A0940", VA = "0x1885A2340")]
	[BurstCompile]
	private unsafe static void NJGNBJMOEAM([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x859DA40", Offset = "0x859C040", VA = "0x18859DA40")]
	[BurstCompile]
	private static void EEICCECJFAP([Out] float4 FAKHJBCPGHO, ushort OHCMCMMHDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x859D110", Offset = "0x859B710", VA = "0x18859D110")]
	private void DOBOMJBAGGG(Allocator EEDCBHBBPKF, NativeArray<float4> KHMICDECFFM, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x859D080", Offset = "0x859B680", VA = "0x18859D080")]
	[BurstCompile]
	private unsafe static void DOBOMJBAGGG([NoAlias] float4* JMCLGPDJANC, [NoAlias] byte* LJPILNCJAFN, [Out] int CJPKDLNGKBO, [Out] int DPGFDMBFIGF, [NoAlias] float4* DEMDLLGIEIH, [NoAlias] float4* KHMICDECFFM, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x859D8A0", Offset = "0x859BEA0", VA = "0x18859D8A0")]
	private static void ECLGHIPALMF(NativeArray<float4> HBLPMCFJAHI, NativeArray<HJINBKGKIJF> MHEDPFPLJMF, NativeArray<byte> MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x859D820", Offset = "0x859BE20", VA = "0x18859D820")]
	[BurstCompile]
	private unsafe static void ECLGHIPALMF([NoAlias] float4* HBLPMCFJAHI, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x859F2E0", Offset = "0x859D8E0", VA = "0x18859F2E0")]
	[BurstCompile]
	private unsafe static void HKOAHNBLOGJ([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x859BDB0", Offset = "0x859A3B0", VA = "0x18859BDB0")]
	[BurstCompile]
	private unsafe static void BKMLBBBOJOH([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x85A2660", Offset = "0x85A0C60", VA = "0x1885A2660")]
	[BurstCompile]
	private unsafe static void OFAFPNANGFG([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x859F8D0", Offset = "0x859DED0", VA = "0x18859F8D0")]
	[BurstCompile]
	private unsafe static void ILAHJLBMNGM([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85A20D0", Offset = "0x85A06D0", VA = "0x1885A20D0")]
	[BurstCompile]
	private unsafe static void NHHCDMFHKAB([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x859F690", Offset = "0x859DC90", VA = "0x18859F690")]
	private void IDNPHGJDJLG(Allocator EEDCBHBBPKF, NativeArray<int> PNALODEIKLP, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85A0CA0", Offset = "0x859F2A0", VA = "0x1885A0CA0")]
	private static NativeArray<byte> LNIJDDBCCLJ(Allocator EEDCBHBBPKF, NativeArray<int> PNALODEIKLP, int NCGOMHEECDM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85A0F80", Offset = "0x859F580", VA = "0x1885A0F80")]
	[BurstCompile]
	private unsafe static int LNIJDDBCCLJ([NoAlias] byte* IIEMKNNIFFA, [In][NoAlias] int* PNALODEIKLP, int NCGOMHEECDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x85A2F10", Offset = "0x85A1510", VA = "0x1885A2F10")]
	private static void POGOGHEGHAH(NativeArray<int> JLLCNBAMLFP, NativeArray<byte> AIKABBBCPDJ, int EFENLDGOGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85A2EA0", Offset = "0x85A14A0", VA = "0x1885A2EA0")]
	[BurstCompile]
	private unsafe static void POGOGHEGHAH([NoAlias] int* JLLCNBAMLFP, [In][NoAlias] byte* AIKABBBCPDJ, int EFENLDGOGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x859B7E0", Offset = "0x8599DE0", VA = "0x18859B7E0")]
	[BurstCompile]
	private unsafe static void ACIFKNDOAPL([NoAlias] ushort* JLLCNBAMLFP, [In][NoAlias] byte* AIKABBBCPDJ, int EFENLDGOGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x859EF60", Offset = "0x859D560", VA = "0x18859EF60")]
	[BurstCompile]
	private static void HCCFNEMLKAN([Out] float3 FBGMDLDCCBP, ushort OHCMCMMHDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85A1E20", Offset = "0x85A0420", VA = "0x1885A1E20")]
	[BurstCompile]
	private static ushort MMIPKJHBGFE([In] float3 ADDPDDBMFBK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8582750", Offset = "0x8580D50", VA = "0x188582750")]
	[BurstCompile]
	public unsafe static void JHIAMOONEFE([NoAlias] float3* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x859EEA0", Offset = "0x859D4A0", VA = "0x18859EEA0")]
	[BurstCompile]
	public unsafe static void HBLOIFENBAP([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x859CD40", Offset = "0x859B340", VA = "0x18859CD40")]
	[BurstCompile]
	public unsafe static void DIIKBKLKJDP([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x859E6E0", Offset = "0x859CCE0", VA = "0x18859E6E0")]
	[BurstCompile]
	public unsafe static void GAOABJPBGHJ([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x859E6E0", Offset = "0x859CCE0", VA = "0x18859E6E0")]
	[BurstCompile]
	public unsafe static void KFJNPJENCCO([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x859C880", Offset = "0x859AE80", VA = "0x18859C880")]
	[BurstCompile]
	public unsafe static void CJGJDAKNBJN([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* BAAFMIKAAEK, int MENDNKMGKGP, [In] float3 FPFJBDHGHKO, [In] float3 JBPFEBGEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x85829B0", Offset = "0x8580FB0", VA = "0x1885829B0")]
	[BurstCompile]
	public unsafe static void LLICMBOEGEF([NoAlias] ushort* EBHKBCADLJB, [Out] float3 EDADINCFKFM, [Out] float3 JBPFEBGEDGP, [In][NoAlias] float3* BAAFMIKAAEK, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85A26E0", Offset = "0x85A0CE0", VA = "0x1885A26E0")]
	[BurstCompile]
	public unsafe static void OFALKCMCOLK([NoAlias] ushort* EFCBGNMNILN, [In][NoAlias] float3* NFLGDOPNNDK, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x859E8D0", Offset = "0x859CED0", VA = "0x18859E8D0")]
	[BurstCompile]
	public unsafe static void GGNJOICPDFM([NoAlias] float3* EEHIMCPHNEO, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85A1BD0", Offset = "0x85A01D0", VA = "0x1885A1BD0")]
	[BurstCompile]
	public unsafe static void MHKOLAGPGIG([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x859DAA0", Offset = "0x859C0A0", VA = "0x18859DAA0")]
	[BurstCompile]
	public unsafe static void EJEPMCNMACA([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x859D6E0", Offset = "0x859BCE0", VA = "0x18859D6E0")]
	[BurstCompile]
	public unsafe static void ECLEBDCPCMK([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x859E430", Offset = "0x859CA30", VA = "0x18859E430")]
	[BurstCompile]
	public unsafe static void FNBECENMNIJ([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x859FEC0", Offset = "0x859E4C0", VA = "0x18859FEC0")]
	[BurstCompile]
	public unsafe static void JAINFOJIKDB([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* NFLGDOPNNDK, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8581730", Offset = "0x857FD30", VA = "0x188581730")]
	[BurstCompile]
	public unsafe static void DAMNFEEPGOE([NoAlias] uint* LNNHAGGKCKO, [Out] float2 MKLOJDBGALP, [Out] float2 ALMPJNHAKPD, [In][NoAlias] float2* GCLJDJHBBBP, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85A2450", Offset = "0x85A0A50", VA = "0x1885A2450")]
	[BurstCompile]
	public static void NMMGDOLIDGD([Out] float2 FBGMDLDCCBP, uint OHCMCMMHDCB, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85A0640", Offset = "0x859EC40", VA = "0x1885A0640")]
	[BurstCompile]
	public unsafe static void KEPBDNFBKOO([NoAlias] float2* LNNHAGGKCKO, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85A0750", Offset = "0x859ED50", VA = "0x1885A0750")]
	[BurstCompile]
	public unsafe static void LCPBLPLGJLM([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85A0360", Offset = "0x859E960", VA = "0x1885A0360")]
	[BurstCompile]
	public unsafe static void KCEPNIHGEPI([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x859BB10", Offset = "0x859A110", VA = "0x18859BB10")]
	[BurstCompile]
	public unsafe static void BFEFKEEBNNN([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x859D5B0", Offset = "0x859BBB0", VA = "0x18859D5B0")]
	[BurstCompile]
	public unsafe static void EADKDIGKPAF([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x859E7A0", Offset = "0x859CDA0", VA = "0x18859E7A0")]
	[BurstCompile]
	public unsafe static void GDNEODBLDOD([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [NoAlias] uint* GCLJDJHBBBP, int MENDNKMGKGP, [In] float2 HDHBEICEDJJ, [In] float2 ALMPJNHAKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85A2B70", Offset = "0x85A1170", VA = "0x1885A2B70")]
	[BurstCompile]
	public unsafe static void OLFAMEJBPID([NoAlias] ushort* GNJOJOGNKMM, [In][NoAlias] float4* OEOMMODNLCK, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x859CCB0", Offset = "0x859B2B0", VA = "0x18859CCB0")]
	[BurstCompile]
	public static ushort DBCHBPDGNJD([In] float4 ADDPDDBMFBK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85A0910", Offset = "0x859EF10", VA = "0x1885A0910")]
	[BurstCompile]
	public unsafe static void LHHFMJEKCDP([NoAlias] float4* GNJOJOGNKMM, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85A11C0", Offset = "0x859F7C0", VA = "0x1885A11C0")]
	[BurstCompile]
	public unsafe static void MCIDGAEMBBE([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x859E2C0", Offset = "0x859C8C0", VA = "0x18859E2C0")]
	[BurstCompile]
	public unsafe static void FMGACEBJFOC([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85A0170", Offset = "0x859E770", VA = "0x1885A0170")]
	[BurstCompile]
	public unsafe static void JIEEDCLOAKN([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85A2490", Offset = "0x85A0A90", VA = "0x1885A2490")]
	[BurstCompile]
	public unsafe static void OBCMBGBBDIM([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85A1640", Offset = "0x859FC40", VA = "0x1885A1640")]
	[BurstCompile]
	public unsafe static void MGOBGBHMJKO([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] ushort* OLDBECCMFPL, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x859F790", Offset = "0x859DD90", VA = "0x18859F790")]
	[BurstCompile]
	public static void IDOHGONJALP([Out] float4 FAKHJBCPGHO, ushort OHCMCMMHDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x85819F0", Offset = "0x857FFF0", VA = "0x1885819F0")]
	[BurstCompile]
	public unsafe static void DNIJIBHOAJL([NoAlias] float4* JMCLGPDJANC, [NoAlias] byte* LJPILNCJAFN, [Out] int CJPKDLNGKBO, [Out] int DPGFDMBFIGF, [NoAlias] float4* DEMDLLGIEIH, [NoAlias] float4* KHMICDECFFM, int KCBGBOHCGPM, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x859F1A0", Offset = "0x859D7A0", VA = "0x18859F1A0")]
	[BurstCompile]
	public unsafe static void HGGPHLIAMGH([NoAlias] float4* HBLPMCFJAHI, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x85A2990", Offset = "0x85A0F90", VA = "0x1885A2990")]
	[BurstCompile]
	public unsafe static void OHKLMHJPGBP([NoAlias] GKMCCFCPGAH.FGBDKAFJMEK* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x859FCE0", Offset = "0x859E2E0", VA = "0x18859FCE0")]
	[BurstCompile]
	public unsafe static void IPKBHCGBKAF([NoAlias] GKMCCFCPGAH.HPPBFIAFHFL* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x859CE00", Offset = "0x859B400", VA = "0x18859CE00")]
	[BurstCompile]
	public unsafe static void DILHMGPIOCE([NoAlias] GKMCCFCPGAH.ENMAFAOIGFO* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x859BE30", Offset = "0x859A430", VA = "0x18859BE30")]
	[BurstCompile]
	public unsafe static void BOFCMPMICIE([NoAlias] GKMCCFCPGAH.COEMOBKEIIG* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x859EC60", Offset = "0x859D260", VA = "0x18859EC60")]
	[BurstCompile]
	public unsafe static void HAMLNDOKIFC([NoAlias] GKMCCFCPGAH.MBCGHBDILOE* EBHKBCADLJB, [In][NoAlias] HJINBKGKIJF* MHEDPFPLJMF, [In][NoAlias] byte* MHGJKNMMMAM, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x859E5E0", Offset = "0x859CBE0", VA = "0x18859E5E0")]
	[BurstCompile]
	public unsafe static int GALLHOJINJH([NoAlias] byte* IIEMKNNIFFA, [In][NoAlias] int* PNALODEIKLP, int NCGOMHEECDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85A23B0", Offset = "0x85A09B0", VA = "0x1885A23B0")]
	[BurstCompile]
	public unsafe static void NLEENGFKEMG([NoAlias] int* JLLCNBAMLFP, [In][NoAlias] byte* AIKABBBCPDJ, int EFENLDGOGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x859CFE0", Offset = "0x859B5E0", VA = "0x18859CFE0")]
	[BurstCompile]
	public unsafe static void DJPAAHGPDHD([NoAlias] ushort* JLLCNBAMLFP, [In][NoAlias] byte* AIKABBBCPDJ, int EFENLDGOGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8582370", Offset = "0x8580970", VA = "0x188582370")]
	[BurstCompile]
	public static void GNCADCPPPDI([Out] float3 FBGMDLDCCBP, ushort OHCMCMMHDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8581F10", Offset = "0x8580510", VA = "0x188581F10")]
	[BurstCompile]
	public static ushort FGCOKPDLFNJ([In] float3 ADDPDDBMFBK)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class GKMCCFCPGAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum DJLMDIAEFCE
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
	public enum NACFLMJAKFA
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
	public struct COJLKDKHFNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DJLMDIAEFCE OFCLANOKPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public bool KGEMHKEHELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int KFGGOKOHKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public VertexAttributeDescriptor[] LPHPFKDPDPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct HKAFEJHCMAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 APHHGJIDDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float3 EPCDDFCHPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float4 BDLBKPEDGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float2 AFCMHEIEFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public float4 HLFENNFMLBE;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly VertexAttributeDescriptor[] LPHPFKDPDPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct FGBDKAFJMEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public float3 APHHGJIDDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 EPCDDFCHPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public half4 BDLBKPEDGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float2 AFCMHEIEFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public half4 HLFENNFMLBE;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly VertexAttributeDescriptor[] LPHPFKDPDPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct HPPBFIAFHFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public float3 APHHGJIDDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint EPCDDFCHPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public uint BDLBKPEDGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public float2 AFCMHEIEFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public half4 HLFENNFMLBE;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly VertexAttributeDescriptor[] LPHPFKDPDPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct ENMAFAOIGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float3 APHHGJIDDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint EPCDDFCHPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint BDLBKPEDGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half2 AFCMHEIEFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public half4 HLFENNFMLBE;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly VertexAttributeDescriptor[] LPHPFKDPDPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct COEMOBKEIIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float3 APHHGJIDDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public uint HPCFAAIOHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float2 AFCMHEIEFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint IGKENDFENEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public uint IHKHMPACMNB;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly VertexAttributeDescriptor[] LPHPFKDPDPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct MBCGHBDILOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public BCGGPDPLGLE.OELLOKJBFNE LJMBPEPPEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public uint HPCFAAIOHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public float2 AFCMHEIEFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public uint IGKENDFENEC;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly VertexAttributeDescriptor[] LPHPFKDPDPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public unsafe delegate void GJJMLNKFEDB([NoAlias] FGBDKAFJMEK* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class CDJIENNBNFB
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x85864B0", Offset = "0x8584AB0", VA = "0x1885864B0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x85868D0", Offset = "0x8584ED0", VA = "0x1885868D0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8586820", Offset = "0x8584E20", VA = "0x188586820")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x85865E0", Offset = "0x8584BE0", VA = "0x1885865E0")]
		public unsafe static void MJPLNPACNDN([NoAlias] FGBDKAFJMEK* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate int EMLJEMPOLCP(float GBNAKFLHCOE);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class PDBDPACPAJF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x85A7470", Offset = "0x85A5A70", VA = "0x1885A7470")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x85A78C0", Offset = "0x85A5EC0", VA = "0x1885A78C0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x85A7810", Offset = "0x85A5E10", VA = "0x1885A7810")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x85A75A0", Offset = "0x85A5BA0", VA = "0x1885A75A0")]
		public static int MJPLNPACNDN(float GBNAKFLHCOE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint MJACGGOKPDA([In] float4 KMDIJJMODFC);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class JANIHNKBBJI
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8597640", Offset = "0x8595C40", VA = "0x188597640")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8597B60", Offset = "0x8596160", VA = "0x188597B60")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8597AB0", Offset = "0x85960B0", VA = "0x188597AB0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8597770", Offset = "0x8595D70", VA = "0x188597770")]
		public static uint MJPLNPACNDN([In] float4 KMDIJJMODFC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public delegate uint IOONIHHODKN([In] float3 KMDIJJMODFC);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class LOAAFINPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x859A710", Offset = "0x8598D10", VA = "0x18859A710")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x859AB70", Offset = "0x8599170", VA = "0x18859AB70")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x859AAC0", Offset = "0x85990C0", VA = "0x18859AAC0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x859A840", Offset = "0x8598E40", VA = "0x18859A840")]
		public static uint MJPLNPACNDN([In] float3 KMDIJJMODFC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void IEEKBONHLDK([NoAlias] HPPBFIAFHFL* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class JGFIGJGAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8598320", Offset = "0x8596920", VA = "0x188598320")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8598740", Offset = "0x8596D40", VA = "0x188598740")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8598690", Offset = "0x8596C90", VA = "0x188598690")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8598450", Offset = "0x8596A50", VA = "0x188598450")]
		public unsafe static void MJPLNPACNDN([NoAlias] HPPBFIAFHFL* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void CLNEMNJPLBP([NoAlias] ENMAFAOIGFO* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class EHPMAHOOKAN
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8589E70", Offset = "0x8588470", VA = "0x188589E70")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x858A290", Offset = "0x8588890", VA = "0x18858A290")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x858A1E0", Offset = "0x85887E0", VA = "0x18858A1E0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8589FA0", Offset = "0x85885A0", VA = "0x188589FA0")]
		public unsafe static void MJPLNPACNDN([NoAlias] ENMAFAOIGFO* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void JJFJPJJENOM([NoAlias] COEMOBKEIIG* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class IBLDFMGGCJI
	{
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x85961D0", Offset = "0x85947D0", VA = "0x1885961D0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x85967A0", Offset = "0x8594DA0", VA = "0x1885967A0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x85966F0", Offset = "0x8594CF0", VA = "0x1885966F0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8596300", Offset = "0x8594900", VA = "0x188596300")]
		public unsafe static void MJPLNPACNDN([NoAlias] COEMOBKEIIG* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public unsafe delegate void BGPIAKNILND([NoAlias] MBCGHBDILOE* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE, [Out] float3 BMNJNNEGOFA, [Out] float3 JKOLECCCEIC);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class APOBNMGMIAA
	{
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8584520", Offset = "0x8582B20", VA = "0x188584520")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8584C60", Offset = "0x8583260", VA = "0x188584C60")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8584BB0", Offset = "0x85831B0", VA = "0x188584BB0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8584650", Offset = "0x8582C50", VA = "0x188584650")]
		public unsafe static void MJPLNPACNDN([NoAlias] MBCGHBDILOE* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE, [Out] float3 BMNJNNEGOFA, [Out] float3 JKOLECCCEIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public unsafe delegate void MGJJCECAEFF(int EFENLDGOGPK, [In][NoAlias] ushort* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB);

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class JDDPAAOAIIH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x85B3670", Offset = "0x85B1C70", VA = "0x1885B3670")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x85B3A70", Offset = "0x85B2070", VA = "0x1885B3A70")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x85B39C0", Offset = "0x85B1FC0", VA = "0x1885B39C0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x85B37A0", Offset = "0x85B1DA0", VA = "0x1885B37A0")]
		public unsafe static void MJPLNPACNDN(int EFENLDGOGPK, [In][NoAlias] ushort* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public unsafe delegate void HNJFONBAEJA(int NDMFOILAFKD, int EFENLDGOGPK, [In][NoAlias] ushort* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB);

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	internal static class NNDKFCJMHIO
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x85BEE60", Offset = "0x85BD460", VA = "0x1885BEE60")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x85BF290", Offset = "0x85BD890", VA = "0x1885BF290")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x85BF1E0", Offset = "0x85BD7E0", VA = "0x1885BF1E0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x85BEF90", Offset = "0x85BD590", VA = "0x1885BEF90")]
		public unsafe static void MJPLNPACNDN(int NDMFOILAFKD, int EFENLDGOGPK, [In][NoAlias] ushort* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public unsafe delegate void BPAIJIIBBPP(int EPGBAIPEEBK, int OEAMFPJLIOE, int LMLMFMNBOAL, [In][NoAlias] int* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	internal static class GPDKEJOIHNM
	{
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x85AF0A0", Offset = "0x85AD6A0", VA = "0x1885AF0A0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x85AF4D0", Offset = "0x85ADAD0", VA = "0x1885AF4D0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x85AF420", Offset = "0x85ADA20", VA = "0x1885AF420")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x85AF1D0", Offset = "0x85AD7D0", VA = "0x1885AF1D0")]
		public unsafe static void MJPLNPACNDN(int EPGBAIPEEBK, int OEAMFPJLIOE, int LMLMFMNBOAL, [In][NoAlias] int* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public unsafe delegate void GIOCEBOJMDH(int MENDNKMGKGP, [NoAlias] bool* LPNPAALPOLN, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE);

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	internal static class BJPFHPADILB
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD5B0", Offset = "0x85ABBB0", VA = "0x1885AD5B0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD9D0", Offset = "0x85ABFD0", VA = "0x1885AD9D0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD920", Offset = "0x85ABF20", VA = "0x1885AD920")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD6E0", Offset = "0x85ABCE0", VA = "0x1885AD6E0")]
		public unsafe static void MJPLNPACNDN(int MENDNKMGKGP, [NoAlias] bool* LPNPAALPOLN, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int PEOAKEJDNKP = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> LLDLECJOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> ECNCFIBLKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> OGIBBOIMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> MBDHILMIKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> KHDHFKNOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> PJOANHLJOHK;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] GHAGJOFNEKC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool IJOBLCLKFMI;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static COJLKDKHFNE[] GBACDAHHEGD;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static VertexAttributeDescriptor[] KAMCEPKIAIJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DEKPKOANCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8591BB0", Offset = "0x85901B0", VA = "0x188591BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NMNACDAMGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x858FEB0", Offset = "0x858E4B0", VA = "0x18858FEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CDBLMLKDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x858E4B0", Offset = "0x858CAB0", VA = "0x18858E4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OONKEIMFJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8594580", Offset = "0x8592B80", VA = "0x188594580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x8592B40", Offset = "0x8591140", VA = "0x188592B40")]
	public static NACFLMJAKFA IJKGEIPMLFO(DJLMDIAEFCE OFCLANOKPBA)
	{
		return default(NACFLMJAKFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8592A00", Offset = "0x8591000", VA = "0x188592A00")]
	public static void HHOKLMNLBAM(NACFLMJAKFA DJJGHDIMGHN, Material PFHPGDKJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x858F6C0", Offset = "0x858DCC0", VA = "0x18858F6C0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x8592D10", Offset = "0x8591310", VA = "0x188592D10")]
	public void KEBIFLKGLKF(int HDHJMLGDJCC, int PAHLOFNIDEF, Allocator EEDCBHBBPKF, bool CPJGCIPAKDP, bool FFJMFEOHINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x85924D0", Offset = "0x8590AD0", VA = "0x1885924D0")]
	public void GKOOPLCJKGO(int HDHJMLGDJCC, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x8592CF0", Offset = "0x85912F0", VA = "0x188592CF0", Slot = "6")]
	public bool IOHMEKMFNNG(Mesh KNHPHEPPGOL, bool JCLMCKNNFKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x858D8E0", Offset = "0x858BEE0", VA = "0x18858D8E0")]
	public bool BJFOLKCGALO(Mesh KNHPHEPPGOL, bool JCLMCKNNFKL, bool OMIJGAAEFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x858EA30", Offset = "0x858D030", VA = "0x18858EA30")]
	public bool CLPAHGAMGAC(Mesh KNHPHEPPGOL, GKMCCFCPGAH OKFKCGAJIKI, bool JCLMCKNNFKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8592550", Offset = "0x8590B50", VA = "0x188592550")]
	public bool GOODNKKLEEB(Mesh KNHPHEPPGOL, GKMCCFCPGAH OKFKCGAJIKI, DJLMDIAEFCE OFCLANOKPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8590CB0", Offset = "0x858F2B0", VA = "0x188590CB0")]
	private void FBOFMODGBLK(Mesh KNHPHEPPGOL, GKMCCFCPGAH OKFKCGAJIKI, bool OMIJGAAEFNC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x85909A0", Offset = "0x858EFA0", VA = "0x1885909A0")]
	public void FBOFMODGBLK(NativeArray<ushort> NLBPEBCKJCD, NativeArray<COEMOBKEIIG> JMKEHKDMKGK, Mesh KNHPHEPPGOL, GKMCCFCPGAH OKFKCGAJIKI, bool OMIJGAAEFNC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x85914D0", Offset = "0x858FAD0", VA = "0x1885914D0")]
	public void FFFLODMPOCB(Mesh KNHPHEPPGOL, bool OMIJGAAEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x85945C0", Offset = "0x8592BC0", VA = "0x1885945C0")]
	[BurstCompile]
	private unsafe static void POHNGHPCCGG([NoAlias] FGBDKAFJMEK* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x858D840", Offset = "0x858BE40", VA = "0x18858D840")]
	[BurstCompile]
	public static int AKMOEPLFPHK(float GBNAKFLHCOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x858D890", Offset = "0x858BE90", VA = "0x18858D890")]
	[BurstCompile]
	public static uint AKMOEPLFPHK([In] float4 KMDIJJMODFC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x858D7F0", Offset = "0x858BDF0", VA = "0x18858D7F0")]
	[BurstCompile]
	public static uint AKMOEPLFPHK([In] float3 KMDIJJMODFC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x858F7D0", Offset = "0x858DDD0", VA = "0x18858F7D0")]
	public void EBJDPBBCLND(Mesh KNHPHEPPGOL, bool OMIJGAAEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8592B90", Offset = "0x8591190", VA = "0x188592B90")]
	[BurstCompile]
	private unsafe static void IJPEEMJFDFJ([NoAlias] HPPBFIAFHFL* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8591DF0", Offset = "0x85903F0", VA = "0x188591DF0")]
	public void GJMBBIFIODO(Mesh KNHPHEPPGOL, bool OMIJGAAEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8594500", Offset = "0x8592B00", VA = "0x188594500")]
	[BurstCompile]
	private unsafe static void ODFOFDIPINC([NoAlias] ENMAFAOIGFO* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x858E090", Offset = "0x858C690", VA = "0x18858E090")]
	public void BJOHNLPFJJK(Mesh KNHPHEPPGOL, bool OMIJGAAEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x858DCE0", Offset = "0x858C2E0", VA = "0x18858DCE0")]
	public void BJOHNLPFJJK(NativeArray<ushort> ELBEIJOAGAP, NativeArray<COEMOBKEIIG> HJPGEMIKMGI, Mesh KNHPHEPPGOL, bool OMIJGAAEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x85930E0", Offset = "0x85916E0", VA = "0x1885930E0")]
	[BurstCompile]
	public unsafe static void KEOAHEKNBIK([NoAlias] COEMOBKEIIG* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x85934E0", Offset = "0x8591AE0", VA = "0x1885934E0")]
	public void MHHJNJCFGOP(Mesh KNHPHEPPGOL, bool OMIJGAAEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8594480", Offset = "0x8592A80", VA = "0x188594480")]
	[BurstCompile]
	private unsafe static void NNBFMELCDIM([NoAlias] MBCGHBDILOE* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE, [Out] float3 BMNJNNEGOFA, [Out] float3 JKOLECCCEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x858E9A0", Offset = "0x858CFA0", VA = "0x18858E9A0")]
	public void CFPCPKBDFHE(Mesh KNHPHEPPGOL, DJLMDIAEFCE OFCLANOKPBA, bool OMIJGAAEFNC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8593160", Offset = "0x8591760", VA = "0x188593160")]
	[BurstCompile]
	private unsafe static void KJGPALKAIDP(int EFENLDGOGPK, [In][NoAlias] ushort* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x85931D0", Offset = "0x85917D0", VA = "0x1885931D0")]
	[BurstCompile]
	private unsafe static void KJGPALKAIDP(int NDMFOILAFKD, int EFENLDGOGPK, [In][NoAlias] ushort* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x85926C0", Offset = "0x8590CC0", VA = "0x1885926C0")]
	public void HGBCLCOEBGB(GKMCCFCPGAH KNHPHEPPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8593060", Offset = "0x8591660", VA = "0x188593060")]
	[BurstCompile]
	private unsafe static void KEJEDHHOGHO(int EPGBAIPEEBK, int OEAMFPJLIOE, int LMLMFMNBOAL, [In][NoAlias] int* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x85908A0", Offset = "0x858EEA0", VA = "0x1885908A0")]
	public void EPNCFNJLEAF(GKMCCFCPGAH NGOJMGCIOHB, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x85932B0", Offset = "0x85918B0", VA = "0x1885932B0")]
	public long LLJKBENNNNC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8593400", Offset = "0x8591A00", VA = "0x188593400")]
	public static long LLJKBENNNNC(int GALOLIJNLKI, int EAPCKOPGNPH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8592FC0", Offset = "0x85915C0", VA = "0x188592FC0")]
	public static long KEGHCPBHFJG(int GALOLIJNLKI, int EAPCKOPGNPH, DJLMDIAEFCE OFCLANOKPBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8592F00", Offset = "0x8591500", VA = "0x188592F00")]
	public long KEGHCPBHFJG(DJLMDIAEFCE OFCLANOKPBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8592AE0", Offset = "0x85910E0", VA = "0x188592AE0")]
	public void IGILNBAKCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x858FEF0", Offset = "0x858E4F0", VA = "0x18858FEF0")]
	public static void EFHKCPFPJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x858EF30", Offset = "0x858D530", VA = "0x18858EF30")]
	public DJLMDIAEFCE DFCIOKIBFID()
	{
		return default(DJLMDIAEFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8593460", Offset = "0x8591A60", VA = "0x188593460")]
	[BurstCompile]
	private unsafe static void LOFPFENEEOL(int MENDNKMGKGP, [NoAlias] bool* LPNPAALPOLN, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x858E830", Offset = "0x858CE30", VA = "0x18858E830")]
	public static (int, int) CADJGCBMIPN(Mesh KNHPHEPPGOL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8592C10", Offset = "0x8591210", VA = "0x188592C10")]
	public static int IMKIOBJDPJD(Span<VertexAttributeDescriptor> CEJEFDIOOMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x858F650", Offset = "0x858DC50", VA = "0x18858F650")]
	public static long DGGMIGOILKF(Mesh KNHPHEPPGOL, int GMLGKOFCKBN, int EJDDEFCJEFO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x858F490", Offset = "0x858DA90", VA = "0x18858F490")]
	public static long DGGMIGOILKF(Mesh KNHPHEPPGOL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public GKMCCFCPGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8580C40", Offset = "0x857F240", VA = "0x188580C40")]
	[BurstCompile]
	public unsafe static void ICBFOGNLEJG([NoAlias] FGBDKAFJMEK* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8594200", Offset = "0x8592800", VA = "0x188594200")]
	[BurstCompile]
	public static int NDDOPIGBHGC(float GBNAKFLHCOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x85942A0", Offset = "0x85928A0", VA = "0x1885942A0")]
	[BurstCompile]
	public static uint NDDOPIGBHGC([In] float4 KMDIJJMODFC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8594150", Offset = "0x8592750", VA = "0x188594150")]
	[BurstCompile]
	public static uint NDDOPIGBHGC([In] float3 KMDIJJMODFC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x85904E0", Offset = "0x858EAE0", VA = "0x1885904E0")]
	[BurstCompile]
	public unsafe static void EKAANGMHNFK([NoAlias] HPPBFIAFHFL* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x858D3A0", Offset = "0x858B9A0", VA = "0x18858D3A0")]
	[BurstCompile]
	public unsafe static void ACDAMCFIFML([NoAlias] ENMAFAOIGFO* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8591BF0", Offset = "0x85901F0", VA = "0x188591BF0")]
	[BurstCompile]
	public unsafe static void GDCKLAIIOOM([NoAlias] COEMOBKEIIG* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x858E4F0", Offset = "0x858CAF0", VA = "0x18858E4F0")]
	[BurstCompile]
	public unsafe static void CABFKDNFJOF([NoAlias] MBCGHBDILOE* EBHKBCADLJB, int MENDNKMGKGP, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE, [Out] float3 BMNJNNEGOFA, [Out] float3 JKOLECCCEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8593280", Offset = "0x8591880", VA = "0x188593280")]
	[BurstCompile]
	public unsafe static void KLFPCHCMCPA(int EFENLDGOGPK, [In][NoAlias] ushort* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8593250", Offset = "0x8591850", VA = "0x188593250")]
	[BurstCompile]
	public unsafe static void KLFPCHCMCPA(int NDMFOILAFKD, int EFENLDGOGPK, [In][NoAlias] ushort* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8594430", Offset = "0x8592A30", VA = "0x188594430")]
	[BurstCompile]
	public unsafe static void NHHJOAKLPCJ(int EPGBAIPEEBK, int OEAMFPJLIOE, int LMLMFMNBOAL, [In][NoAlias] int* NLKIMPNBJJH, [In][NoAlias] int* NGOJMGCIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8593C80", Offset = "0x8592280", VA = "0x188593C80")]
	[BurstCompile]
	public unsafe static void MNPKDLPKHFK(int MENDNKMGKGP, [NoAlias] bool* LPNPAALPOLN, [In][NoAlias] float3* NKEMJOKCLBE, [In][NoAlias] float3* IBCJGILIPIO, [In][NoAlias] float4* BEFJOCFHEMC, [In][NoAlias] float2* AEICOIIEHIF, [In][NoAlias] float4* HLFENNFMLBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct HEPMAEAMJNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int GOFOJJFCLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3 KBMPJCAOJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public quaternion PHELDAGPCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3 CKDDFBMPFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public int GOHKLGDEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int CAPMFCMMIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public int NHHBFEFIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float OAIKINPPNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float3 EOCKFJJEBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public bool IJEIAIPCIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public JFMFOJBNGJD DFIMLEKHLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float3 DOJCILBJLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float AGEEINBJOLG;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class LDDJPFHOBHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static KPEHFCMMJBE MFFHFAFFIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public NativeList<HEPMAEAMJNB> EDHIFFBONHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public NativeList<NJGBBPHCGDN> JAKKLOLHLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public NativeList<PDDNFMNKBFD> NIPAOEDAEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NativeArray<KMFOEBEFONO> JONOEBIBKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NativeList<NJGBBPHCGDN> ANEAMKDLFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NativeList<ACMODPBIEMJ> JFIJCDOODDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private List<NativeArray<KMFOEBEFONO>> PPHMPOJPCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private NativeList<MBPPHLHLFNI> MAEIEOJEALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private NativeArray<int> FFKNHKHMIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NativeArray<int> CFFFKAPFCJN;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static NativeList<DIDLMADDJMG.OHKIDNIEPOA> KCOIKLJJJKM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NMNACDAMGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xAAD5D0", Offset = "0xAABBD0", VA = "0x180AAD5D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xAAD5E0", Offset = "0xAABBE0", VA = "0x180AAD5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int CDBLMLKDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xD8E760", Offset = "0xD8CD60", VA = "0x180D8E760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xD8E770", Offset = "0xD8CD70", VA = "0x180D8E770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x85BE080", Offset = "0x85BC680", VA = "0x1885BE080")]
	public LDDJPFHOBHE(int OKCIEHJBGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x85BC200", Offset = "0x85BA800", VA = "0x1885BC200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x85BC3E0", Offset = "0x85BA9E0", VA = "0x1885BC3E0")]
	public void ELCJDKMDHCB(JobHandle BJFLKGBEEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x85BBFE0", Offset = "0x85BA5E0", VA = "0x1885BBFE0")]
	public void ABIAJMNMDCK(HEPMAEAMJNB CDDIADBJAOB, MBPPHLHLFNI AGCPOFNEOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x85BD910", Offset = "0x85BBF10", VA = "0x1885BD910")]
	public void HLDNAMJAAJB(PDDNFMNKBFD CDDIADBJAOB, NativeArray<KMFOEBEFONO> PENJNMDIEGL, int MENDNKMGKGP, int EFENLDGOGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x85BD7F0", Offset = "0x85BBDF0", VA = "0x1885BD7F0")]
	public JobHandle FKGAMGJJMPK(GKMCCFCPGAH EJJHLIACHDJ, DDCEMAKIKNP JLEFCJKIJIH, float3 EPPEPAOIPHC, quaternion PNPEPDNENDI, float KBIKCAGHPKP, bool ELLLALBJLKI, int IPOMLPIDHDJ = 0, int FDHIDPMJDKC = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x85BC5D0", Offset = "0x85BABD0", VA = "0x1885BC5D0")]
	public JobHandle FKGAMGJJMPK(GKMCCFCPGAH EJJHLIACHDJ, DDCEMAKIKNP JLEFCJKIJIH, NativeList<DIDLMADDJMG.OHKIDNIEPOA> NLDLENIPCFM, float3 EPPEPAOIPHC, quaternion PNPEPDNENDI, float KBIKCAGHPKP, bool ELLLALBJLKI, bool GNBPCHIJMIL, int IPOMLPIDHDJ = 0, int FDHIDPMJDKC = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x85BDD00", Offset = "0x85BC300", VA = "0x1885BDD00")]
	public static JobHandle PJEGDDNALGF(IPNMKCPFHOJ NKCIIACHNBH, GKMCCFCPGAH EJJHLIACHDJ, NativeArray<int> CFFFKAPFCJN, HEPMAEAMJNB CDDIADBJAOB, JobHandle BJFLKGBEEDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x85BDA50", Offset = "0x85BC050", VA = "0x1885BDA50")]
	public static JobHandle JGAGCDDHJGJ(OEBKJMCPJBO NKCIIACHNBH, GKMCCFCPGAH EJJHLIACHDJ, PDDNFMNKBFD CDDIADBJAOB, NativeArray<KMFOEBEFONO> PENJNMDIEGL, int MENDNKMGKGP, int EFENLDGOGPK, JobHandle BJFLKGBEEDK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class JOPFHEODCBD
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	internal struct EFCIONJEMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public MeshRenderer MAFJPEPPLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ACECJNBDMCC.DPNBFHGGIFE CIECKOGKBKH;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x57B3170", Offset = "0x57B1770", VA = "0x1857B3170")]
		public EFCIONJEMHP(MeshRenderer MAFJPEPPLNH, ACECJNBDMCC.DPNBFHGGIFE CIECKOGKBKH)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x85AE400", Offset = "0x85ACA00", VA = "0x1885AE400")]
		public static EFCIONJEMHP HNGLNPFKABH((MeshRenderer, ACECJNBDMCC.DPNBFHGGIFE) COLOJJOBMEE)
		{
			return default(EFCIONJEMHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker IONCJGLKBJI;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker BMGAMGFOOEM;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker JHIOJBMKJOG;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ProfilerMarker DEJHCEDMADB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x85B3C00", Offset = "0x85B2200", VA = "0x1885B3C00")]
	internal void FLOLDBDBDIF(GameObject ONMNJMNGFLO, ACECJNBDMCC.HNCCLLEMPLC PPNONFOMAJG, List<EFCIONJEMHP> ADHFKKAKOCE, Material PFHPGDKJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x85B5340", Offset = "0x85B3940", VA = "0x1885B5340")]
	internal void KPLJMIIBPKP(GameObject ONMNJMNGFLO, ACECJNBDMCC.HNCCLLEMPLC PPNONFOMAJG, List<EFCIONJEMHP> ADHFKKAKOCE, List<LODGroup> OEPCLBANOAN, Material PFHPGDKJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x85B5B70", Offset = "0x85B4170", VA = "0x1885B5B70")]
	private MeshRenderer LINEKANACBP(ACECJNBDMCC.HNCCLLEMPLC PPNONFOMAJG, Material PFHPGDKJCCC, List<EFCIONJEMHP> ADHFKKAKOCE, bool GGKAPPIGBDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x85B65F0", Offset = "0x85B4BF0", VA = "0x1885B65F0")]
	private List<(List<EFCIONJEMHP>, float)> MCFABDMDBFG(ACECJNBDMCC.HNCCLLEMPLC PPNONFOMAJG, List<LODGroup> OEPCLBANOAN, Material PFHPGDKJCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x85B4470", Offset = "0x85B2A70", VA = "0x1885B4470")]
	private List<List<(List<EFCIONJEMHP>, float)>> GGIAFFPBACA(ACECJNBDMCC.HNCCLLEMPLC PPNONFOMAJG, List<LODGroup> OEPCLBANOAN, Material PFHPGDKJCCC, [Out] int KLHDBOOPCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JOPFHEODCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x85B51D0", Offset = "0x85B37D0", VA = "0x1885B51D0")]
	[CompilerGenerated]
	internal static (float, int) GLLPCCCNKIA(List<List<(List<EFCIONJEMHP> meshList, float lodTransition)>> EAMDPHAAFMC, int[] IMIJEGHBJJO)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KHFGHMMACIG
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker CPOGNDNJDFF;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker CCOABAJOMKC;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker OKHKOKAPNJI;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker JLKNNJAILMC;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker CJFMDJHGOBO;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker CEDEKADNONM;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker FPAOHENBLJD;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly IPHNFELODMJ FIONCOPNADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private ACECJNBDMCC DBAPBKILOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private JOPFHEODCBD DLAJJAMMDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Shader DLDOKOEOODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private MaterialPropertyBlock LBPJLBMOJPA;

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x85B9150", Offset = "0x85B7750", VA = "0x1885B9150")]
	public static void NFMNIPOPDGP(GameObject ONMNJMNGFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x85B7A00", Offset = "0x85B6000", VA = "0x1885B7A00")]
	public void BDBKJLHAGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x85B7640", Offset = "0x85B5C40", VA = "0x1885B7640")]
	public void ACGFLECGJDK(GameObject ONMNJMNGFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x85B7880", Offset = "0x85B5E80", VA = "0x1885B7880")]
	private bool BBCJBLGOIIN(MeshRenderer MAFJPEPPLNH, [Out] MeshFilter KMNHCMDEDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x85B94D0", Offset = "0x85B7AD0", VA = "0x1885B94D0")]
	private bool NNNAKHGKGKI(int PMIGBJGNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x85B8770", Offset = "0x85B6D70", VA = "0x1885B8770")]
	private void KADOPHPGNNB(GameObject ONMNJMNGFLO, int PMIGBJGNLLP, Material PFHPGDKJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x85B89A0", Offset = "0x85B6FA0", VA = "0x1885B89A0")]
	private List<JOPFHEODCBD.EFCIONJEMHP> NBNHBGFGOGA(int PMIGBJGNLLP, [Out] List<LODGroup> OEPCLBANOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x85B96F0", Offset = "0x85B7CF0", VA = "0x1885B96F0")]
	private List<(int, Material)> OLMAKPJIGAA(float HOPGDGCGLON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x85B8190", Offset = "0x85B6790", VA = "0x1885B8190")]
	public void CNCNJGCEOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x85B8240", Offset = "0x85B6840", VA = "0x1885B8240")]
	private bool FLDIEEDPLBK(GameObject JJEACKINPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x85B9EC0", Offset = "0x85B84C0", VA = "0x1885B9EC0")]
	public KHFGHMMACIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[BurstCompile]
public class ACECJNBDMCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[BurstCompatible]
	public struct HNCCLLEMPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public float3 GAEHKCHAJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public float3 KECGAHAPFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float JEHDNMDHAAJ;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x85B0F20", Offset = "0x85AF520", VA = "0x1885B0F20")]
		public HNCCLLEMPLC(Bounds KMJIOHGPLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x85B0E10", Offset = "0x85AF410", VA = "0x1885B0E10")]
		public HNCCLLEMPLC(float3 GAEHKCHAJDJ, float3 KECGAHAPFAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[BurstCompatible]
	public struct LCHPBDKEOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public HNCCLLEMPLC MBAHHNDJPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int GEKOGKMGDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int EGPNMEPOPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public float MPGBGCBLGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int HDHJMLGDJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int CLLJIPIKAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int LEGLPAFDAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int MBANCGGMDDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int AJEGDBFGMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool LFBPDPIFNMD;
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public struct DPNBFHGGIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Mesh PHFGECIDFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Matrix4x4 LIGFGKDFHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int ALNHDBBHKOE;
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[BurstCompile]
	private struct BDCCMOECEEK : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[ReadOnly]
		public NativeArray<LCHPBDKEOEN> OPHFLJEFDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[WriteOnly]
		public NativeArray<float> PCCGPNIJDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int IBPEOAPMNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public HNCCLLEMPLC KMJIOHGPLNH;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD480", Offset = "0x85ABA80", VA = "0x1885AD480")]
		private float FGCHJLHGDIO(HNCCLLEMPLC JGPEJMANNEB, HNCCLLEMPLC PDHHCOODKIC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x85AD260", Offset = "0x85AB860", VA = "0x1885AD260", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker JKNFHHFDKKE;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker BEAICCAGEIP;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker KCCDBGBMMEA;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly ProfilerMarker DGMIBFFGAGO;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker HEGNJGIMMGI;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker JMCOAIPCDGJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly ProfilerMarker HKCLBMOOCCK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker HFIKEGJGKOL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker BAKMFFPNDEE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker FGJMPPOAHHM;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker MIBNAOPLPEL;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly ProfilerMarker BLIGICAGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public NativeArray<LCHPBDKEOEN> OPHFLJEFDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public NativeQueue<int> GLEAGHDHMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public int BBDFFLHMAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Dictionary<Material, int> EHDBNHNLLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<DPNBFHGGIFE> BFBMBPFJDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public List<LODGroup> OEPCLBANOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Dictionary<int, MeshRenderer> CMGCEOJEDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private Queue<int> BDEFEECLFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Shader JLHLJCGPMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Shader JECHGKGHKMH;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x85AB860", Offset = "0x85A9E60", VA = "0x1885AB860")]
	public ACECJNBDMCC(int IMEJHLNCMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x85AB2A0", Offset = "0x85A98A0", VA = "0x1885AB2A0")]
	private void OAMNJMDFOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x85A9040", Offset = "0x85A7640", VA = "0x1885A9040")]
	public bool AMKLLJGDJJG(MeshRenderer MILFPGANEOF, MeshFilter PLCGOFGNGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x85A8380", Offset = "0x85A6980", VA = "0x1885A8380")]
	public bool AMKLLJGDJJG(LODGroup FDINJJEJPFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x85A94D0", Offset = "0x85A7AD0", VA = "0x1885A94D0")]
	private bool AOFBHNFGAFG(MeshRenderer MILFPGANEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x85A9550", Offset = "0x85A7B50", VA = "0x1885A9550")]
	private int BAPELGKIEIL(MeshRenderer MILFPGANEOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x85AA2C0", Offset = "0x85A88C0", VA = "0x1885AA2C0")]
	private int HJCOBKCOMLA(LODGroup FDINJJEJPFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x85AB410", Offset = "0x85A9A10", VA = "0x1885AB410")]
	private int OJOLOKLLAJE(MeshFilter PLCGOFGNGFD, int NBHCFOGKANE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x85A7BA0", Offset = "0x85A61A0", VA = "0x1885A7BA0")]
	private int AEGOEJICDFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x85AA780", Offset = "0x85A8D80", VA = "0x1885AA780")]
	private static HNCCLLEMPLC KPFDLFLJBLF(HNCCLLEMPLC JGPEJMANNEB, HNCCLLEMPLC PDHHCOODKIC)
	{
		return default(HNCCLLEMPLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x85A9670", Offset = "0x85A7C70", VA = "0x1885A9670")]
	private static float CBKOBEJFHIH(Vector3 GAEHKCHAJDJ, Vector3 KECGAHAPFAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x85AAF70", Offset = "0x85A9570", VA = "0x1885AAF70")]
	private int NHPEHADIKGA(int OBOLJIHKEIE, HNCCLLEMPLC LMGAFHDJBML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x85A97C0", Offset = "0x85A7DC0", VA = "0x1885A97C0")]
	private void CKNCDPLCFKE(HNCCLLEMPLC LMGAFHDJBML, int PMIGBJGNLLP, [Out] float LLDGOMOFAJC, [Out] float APHKKEABMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x85A7F00", Offset = "0x85A6500", VA = "0x1885A7F00")]
	private void AHHMBDOOCED(HNCCLLEMPLC LMGAFHDJBML, int GKBFCEIDEIB, Material PFHPGDKJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x85AA080", Offset = "0x85A8680", VA = "0x1885AA080")]
	private float FGCHJLHGDIO(HNCCLLEMPLC JGPEJMANNEB, HNCCLLEMPLC PDHHCOODKIC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x85AAB30", Offset = "0x85A9130", VA = "0x1885AAB30")]
	private void MDAKIHNMECL(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x85AA330", Offset = "0x85A8930", VA = "0x1885AA330")]
	private void KNGPDABKKOB(int AJPJCNFENLO, int AFANLGFLNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x85A9AD0", Offset = "0x85A80D0", VA = "0x1885A9AD0")]
	private void EKACNLAJPHE(int AJPJCNFENLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x85A9A20", Offset = "0x85A8020", VA = "0x1885A9A20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct HKNIPGMHCKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float2 CDOMHMKBDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public float2 PFCENHGJGMK;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class LBNBIELPHLO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<HKNIPGMHCKJ> KGOIMOGJPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> MODMPNJAAKK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NMNACDAMGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CDBLMLKDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x85BA6A0", Offset = "0x85B8CA0", VA = "0x1885BA6A0")]
	public LBNBIELPHLO(int HDHJMLGDJCC, int PAHLOFNIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x85BA560", Offset = "0x85B8B60", VA = "0x1885BA560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x85BA5C0", Offset = "0x85B8BC0", VA = "0x1885BA5C0")]
	public void HGBCLCOEBGB(LBNBIELPHLO NEMIGJKDECG, int HKKIPBICMMM, int NDMFOILAFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class HEHHGJHOKKJ
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static LBNBIELPHLO HEFHKMIMMFB;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static NativeList<NJGBBPHCGDN> DNOPCDFCKMP;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static int[] GAJNAEDGODN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static bool OBGPLHENIEE;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static Dictionary<int, LBNBIELPHLO> ODILFEHMCII;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static Dictionary<int, LBNBIELPHLO> CDFMFAMBGHA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool FLJIPJJIBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x85B0AE0", Offset = "0x85AF0E0", VA = "0x1885B0AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<NJGBBPHCGDN> CGMDGHDLOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x85B0C00", Offset = "0x85AF200", VA = "0x1885B0C00")]
		get
		{
			return default(NativeList<NJGBBPHCGDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LBNBIELPHLO LPDNNCFKOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x85B03F0", Offset = "0x85AE9F0", VA = "0x1885B03F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x85B04D0", Offset = "0x85AEAD0", VA = "0x1885B04D0")]
	private static void MBONJLBHGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x85AF7D0", Offset = "0x85ADDD0", VA = "0x1885AF7D0")]
	public static int DCCPKBHJIAM(bool HGLLBICNOMC, int FELPMICMBFI, bool PFGAPDNINBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x85B04B0", Offset = "0x85AEAB0", VA = "0x1885B04B0")]
	private static int LMLMENNFEHG(int FELPMICMBFI, bool PNPHMOBGLCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x85B03E0", Offset = "0x85AE9E0", VA = "0x1885B03E0")]
	private static int JFIPOMMDAKP(int FELPMICMBFI, bool PNPHMOBGLCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x85B0B60", Offset = "0x85AF160", VA = "0x1885B0B60")]
	public static int NIPDHBOPOHP(int OCNFNIGMAEF, int FELPMICMBFI, int IBANGIJEIAC, bool PNPHMOBGLCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x85AF630", Offset = "0x85ADC30", VA = "0x1885AF630")]
	public static int CIPDAMCBHCJ(int OCNFNIGMAEF, int FELPMICMBFI, int IBANGIJEIAC, bool PNPHMOBGLCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x85B0340", Offset = "0x85AE940", VA = "0x1885B0340")]
	public static int ILHPAMDLANH(int IBANGIJEIAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x85B0BF0", Offset = "0x85AF1F0", VA = "0x1885B0BF0")]
	private static int NNPKKMAKICO(int FELPMICMBFI, bool PNPHMOBGLCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x85B0490", Offset = "0x85AEA90", VA = "0x1885B0490")]
	private static int LHEKCNBIOOJ(int FELPMICMBFI, bool PNPHMOBGLCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x85AFEC0", Offset = "0x85AE4C0", VA = "0x1885AFEC0")]
	public static int GLIJEDHJEKH(int OCNFNIGMAEF, int FELPMICMBFI, int IBANGIJEIAC, bool PNPHMOBGLCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x85B0350", Offset = "0x85AE950", VA = "0x1885B0350")]
	public static int IMHKGOBEAFO(int OCNFNIGMAEF, int FELPMICMBFI, int IBANGIJEIAC, bool PNPHMOBGLCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x85AF7B0", Offset = "0x85ADDB0", VA = "0x1885AF7B0")]
	public static int DBEDOGAAILD(int IBANGIJEIAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x85AF6C0", Offset = "0x85ADCC0", VA = "0x1885AF6C0")]
	public static LBNBIELPHLO CMKLGJEGDLL(int FELPMICMBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x85AFB40", Offset = "0x85AE140", VA = "0x1885AFB40")]
	private static LBNBIELPHLO DJIKBHMMLBA(int FELPMICMBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x85AFDD0", Offset = "0x85AE3D0", VA = "0x1885AFDD0")]
	public static LBNBIELPHLO EKEEKOKECOP(int FELPMICMBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x85AF800", Offset = "0x85ADE00", VA = "0x1885AF800")]
	private static LBNBIELPHLO DICEPOFBCBG(int FELPMICMBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x85AFF30", Offset = "0x85AE530", VA = "0x1885AFF30")]
	public static void HBPFENEFPDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct PDDNFMNKBFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int HNKONIEPIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public float3 KBMPJCAOJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public quaternion PHELDAGPCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public float CKDDFBMPFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public float OEGHJPLFALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public int GOHKLGDEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public int CAPMFCMMIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public int NHHBFEFIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public bool POOMFODMDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public bool JPAFDJGHCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public float OAIKINPPNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public float3 EOCKFJJEBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool HBLIIGIEGIE;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct ACMODPBIEMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public int PFEKAEJLKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public int MGKOBDGCDMC;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct OEBKJMCPJBO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public NativeList<PDDNFMNKBFD> BLAMBBPNPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public NativeArray<KMFOEBEFONO> FOLHAPJLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public NativeArray<NJGBBPHCGDN> MOBNGHNLJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public NativeArray<ACMODPBIEMJ> HPGLNDDPKNE;

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x85BF4E0", Offset = "0x85BDAE0", VA = "0x1885BF4E0")]
	public OEBKJMCPJBO(NativeArray<KMFOEBEFONO> FOLHAPJLIIF, int KCJLCGFEBMJ = 1, Allocator EEDCBHBBPKF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x85BF3F0", Offset = "0x85BD9F0", VA = "0x1885BF3F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[BurstCompile]
public struct INBIEHMPPGA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private NativeArray<HKNIPGMHCKJ> AJHNJNGJLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[ReadOnly]
	private NativeArray<int> BJLBGINNLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[ReadOnly]
	private NativeList<NJGBBPHCGDN> JFIGMPODEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[ReadOnly]
	private NativeList<PDDNFMNKBFD> BLAMBBPNPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[ReadOnly]
	private NativeArray<KMFOEBEFONO> FOLHAPJLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[ReadOnly]
	private NativeArray<NJGBBPHCGDN> MOBNGHNLJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[ReadOnly]
	public NativeArray<ACMODPBIEMJ> HPGLNDDPKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ReadOnly]
	private int KOODDNFIGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[ReadOnly]
	private int OLACODDAHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[ReadOnly]
	private float3 PENDBPINKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private quaternion BAJEMILFABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private float3 JOGNEGCGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GAIGGDABJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CGEGBFLDMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FEKJMIGOMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FODPKHFHCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KAHKAECOMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NBMHGKCCHHB;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x85B3020", Offset = "0x85B1620", VA = "0x1885B3020")]
	public INBIEHMPPGA(LDDJPFHOBHE JOOMMHCLOOD, GKMCCFCPGAH KIHDAOIDDEP, float3 LDEBHNLIJEH, quaternion ELHNIFDDEAN, float PKBKEEHENAK, int IPOMLPIDHDJ = 0, int FDHIDPMJDKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x85B32B0", Offset = "0x85B18B0", VA = "0x1885B32B0")]
	public INBIEHMPPGA(OEBKJMCPJBO JOOMMHCLOOD, GKMCCFCPGAH KIHDAOIDDEP, float3 LDEBHNLIJEH, quaternion ELHNIFDDEAN, float3 PKBKEEHENAK, int IPOMLPIDHDJ = 0, int FDHIDPMJDKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x85B1190", Offset = "0x85AF790", VA = "0x1885B1190")]
	private float3 CCBJNIPLHFK(float3 HHEBPEFICKM, Matrix4x4 IHNMJAADMOA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x85B25E0", Offset = "0x85B0BE0", VA = "0x1885B25E0")]
	private float3x3 KMMALBFNKKC(float3x3 CIJFEGHEBBM, float3x3 DFMOLJKJLLM)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x85B1180", Offset = "0x85AF780", VA = "0x1885B1180")]
	private float BOFMCBHAJFB(float EAHAEIJNIMH, float DEGOGGIIJDL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x85B12D0", Offset = "0x85AF8D0", VA = "0x1885B12D0", Slot = "4")]
	public void Execute(int IFMKBBDLCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x85B2470", Offset = "0x85B0A70", VA = "0x1885B2470")]
	private void FBLFHGPBICF(int CNGEJEDCFJD, float3 APHHGJIDDCM, float3 EPCDDFCHPMD, float3 BDLBKPEDGPL, float JPNOJNLEGJO, bool AALLFIMEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x85B2660", Offset = "0x85B0C60", VA = "0x1885B2660")]
	private void LCCGCKJFAMK(PDDNFMNKBFD NLMHNFDAEII, float3 ALFMKPLFANJ, float3x3 LBDLDEPDKMC, float EAHAEIJNIMH, int OLFODKHFGLI, int NAJAHHKGEOE, int INMAMJLNDJL, float GLJBDGPDADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x85B2AA0", Offset = "0x85B10A0", VA = "0x1885B2AA0")]
	private void ODGMHKIHPBD(int CNGEJEDCFJD, int IHFNFBHFEGP, PDDNFMNKBFD NLMHNFDAEII, float3 ALFMKPLFANJ, float3x3 LBDLDEPDKMC, bool JFGIGOHGIBL, float EAHAEIJNIMH, int OOIPGFAHOOP, int NHGFPOHKFHA, int INMAMJLNDJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct IPNMKCPFHOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeList<HEPMAEAMJNB> LPONIKLOKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeList<NJGBBPHCGDN> OLJMJCAKIEO;

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x85B3580", Offset = "0x85B1B80", VA = "0x1885B3580")]
	public IPNMKCPFHOJ(int KCJLCGFEBMJ, Allocator EEDCBHBBPKF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x85B34E0", Offset = "0x85B1AE0", VA = "0x1885B34E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[BurstCompile]
public struct LCMMIJODKPA : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private enum IBGHGAPCHGE
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
	private NativeList<float3> MJMGPGBHHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private NativeArray<float3> BNFBIPKJMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private NativeList<int> GBOHKNJOFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	private NativeArray<int> NIECADCANJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[ReadOnly]
	private NativeArray<float4> KDMJCHKDKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[ReadOnly]
	private NativeArray<float4> GALEBLCHNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[ReadOnly]
	private NativeArray<float4> JOKJKOFIOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[ReadOnly]
	private NativeArray<int> OGJDNGAHFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[ReadOnly]
	private NativeList<float3> NDIACLKLDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[ReadOnly]
	private NativeList<NJGBBPHCGDN> EDLPPMIAEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private NativeList<HEPMAEAMJNB> LPONIKLOKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private NativeList<NJGBBPHCGDN> OLJMJCAKIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private int KOODDNFIGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[ReadOnly]
	private int OLACODDAHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GAIGGDABJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CGEGBFLDMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FEKJMIGOMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FODPKHFHCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KAHKAECOMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CFFFKAPFCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NBMHGKCCHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[ReadOnly]
	private float3 JOGNEGCGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	private quaternion BAJEMILFABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	private float3 PENDBPINKOL;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x85BBDD0", Offset = "0x85BA3D0", VA = "0x1885BBDD0")]
	public LCMMIJODKPA(LDDJPFHOBHE JOOMMHCLOOD, GKMCCFCPGAH KIHDAOIDDEP, NativeArray<int> DHAMBGOMIBP, float3 LDEBHNLIJEH, quaternion ELHNIFDDEAN, float PKBKEEHENAK, int IPOMLPIDHDJ = 0, int FDHIDPMJDKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x85BBBC0", Offset = "0x85BA1C0", VA = "0x1885BBBC0")]
	public LCMMIJODKPA(IPNMKCPFHOJ CDDIADBJAOB, GKMCCFCPGAH KIHDAOIDDEP, NativeArray<int> DHAMBGOMIBP, float3 LDEBHNLIJEH, quaternion ELHNIFDDEAN, float3 PKBKEEHENAK, int IPOMLPIDHDJ = 0, int FDHIDPMJDKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x85BA760", Offset = "0x85B8D60", VA = "0x1885BA760", Slot = "4")]
	public void Execute(int IFMKBBDLCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x85BB780", Offset = "0x85B9D80", VA = "0x1885BB780")]
	private void GJIJGBLEDNG(float4x4 BEAKBILFDLK, int IFMKBBDLCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x85BB710", Offset = "0x85B9D10", VA = "0x1885BB710")]
	private IBGHGAPCHGE FKNFIACOHMC(float3 EPCDDFCHPMD)
	{
		return default(IBGHGAPCHGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x85BBB70", Offset = "0x85BA170", VA = "0x1885BBB70")]
	private float4 OFAOPDILIBG(IBGHGAPCHGE EKLPAHMOAJJ, int PMIGBJGNLLP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x85BBB30", Offset = "0x85BA130", VA = "0x1885BBB30")]
	private float2 NNALKGEJMJM(IBGHGAPCHGE EKLPAHMOAJJ, float3 APHHGJIDDCM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct MBPPHLHLFNI
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public enum JFLFHLAMDIC
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public static MBPPHLHLFNI HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public float3 PGBNPPMBLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public float3x3 BGKDKGECOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public float3 FMLOJENFFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public JFLFHLAMDIC HIKNDMJOAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public float3 NPBNKMAELIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public float3 JGMGNKCAPFG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool GLJIKBGGLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x85BE760", Offset = "0x85BCD60", VA = "0x1885BE760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 NDCJNONEIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x85BE680", Offset = "0x85BCC80", VA = "0x1885BE680")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x85BED70", Offset = "0x85BD370", VA = "0x1885BED70")]
	public MBPPHLHLFNI(float3 APHHGJIDDCM, quaternion LDAEEKEKDJC, float3 KCJLCGFEBMJ, JFLFHLAMDIC GPEIAHGICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x85BE770", Offset = "0x85BCD70", VA = "0x1885BE770")]
	public float HHHGNHAMKKP(float3 ALFMKPLFANJ, float NGJMAENJOOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x85BE970", Offset = "0x85BCF70", VA = "0x1885BE970")]
	public bool HMDABPKOBDC(float3 EPCDDFCHPMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x85BEA60", Offset = "0x85BD060", VA = "0x1885BEA60")]
	public void JEIIJIHPELJ(float3 IEPGHIHEDIH, float3x3 KOLNODDGADG, float PGNBHDGJCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x85BEC10", Offset = "0x85BD210", VA = "0x1885BEC10")]
	private void OFGPAICPFMF(float3 IBBPDDHELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x85BE3F0", Offset = "0x85BC9F0", VA = "0x1885BE3F0")]
	public void FLDKCOFKKBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[BurstCompile]
public struct FCLMAMFHMPB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[ReadOnly]
	private NativeList<MBPPHLHLFNI> CDDIADBJAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[ReadOnly]
	private NativeList<float3> LMLKICDHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeList<int> OBIBBENNFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FFKNHKHMIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private NativeList<NJGBBPHCGDN> OLJMJCAKIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[ReadOnly]
	private int ONIPEMKJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[ReadOnly]
	private int IJMMFIMIBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[ReadOnly]
	private float NGJMAENJOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[ReadOnly]
	private float MANAMGGOLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> ECMGGBJNAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> EIDCHJDEGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> PIBKPEPLPMI;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x85AEF10", Offset = "0x85AD510", VA = "0x1885AEF10")]
	public FCLMAMFHMPB(GKMCCFCPGAH KNHPHEPPGOL, float DPBIMCECJOA, int NDMFOILAFKD, int OLFODKHFGLI, NativeList<MBPPHLHLFNI> CDDIADBJAOB, NativeArray<int> FFKNHKHMIOM, NativeList<NJGBBPHCGDN> OLJMJCAKIEO, DDCEMAKIKNP JLEFCJKIJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x85AE540", Offset = "0x85ACB40", VA = "0x1885AE540", Slot = "4")]
	public void Execute(int LMFGNMNGEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x85AE480", Offset = "0x85ACA80", VA = "0x1885AE480")]
	private bool DMNJFNGGOEM(MBPPHLHLFNI JGPEJMANNEB, MBPPHLHLFNI PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x85AEC80", Offset = "0x85AD280", VA = "0x1885AEC80")]
	private bool MGHOFFMAAAF(MBPPHLHLFNI COPABLGBACJ, int CDBJJKPGCCJ, int FJFDFNHELBB, int PMKBIKLJJFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[BurstCompile]
public struct JNPJHHBKNKE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<int> JMIAKDAMEOH;

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public JNPJHHBKNKE(NativeArray<int> JMIAKDAMEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x85B3BD0", Offset = "0x85B21D0", VA = "0x1885B3BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[BurstCompile]
public struct AMLLDFBMMLF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<DIDLMADDJMG.OHKIDNIEPOA> NLDLENIPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[ReadOnly]
	private NativeArray<int> IOIOILDHMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	[ReadOnly]
	private int IPOMLPIDHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private int FDHIDPMJDKC;

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x85AD240", Offset = "0x85AB840", VA = "0x1885AD240")]
	public AMLLDFBMMLF(NativeList<DIDLMADDJMG.OHKIDNIEPOA> NLDLENIPCFM, NativeArray<int> IOIOILDHMIP, int FDHIDPMJDKC = 0, int IPOMLPIDHDJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x85AD190", Offset = "0x85AB790", VA = "0x1885AD190", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class DDCEMAKIKNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NativeArray<bool> CNPPDLFIPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeArray<int> AJBKKNAEOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NativeArray<bool> PJHLGOJPHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public NativeArray<float> JDOJNBKNHLA;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x85AE2E0", Offset = "0x85AC8E0", VA = "0x1885AE2E0")]
	public void KEBIFLKGLKF(int HDHJMLGDJCC, int PAHLOFNIDEF, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x85AE0E0", Offset = "0x85AC6E0", VA = "0x1885AE0E0")]
	public static long AJMNOIBHHAM(int HDHJMLGDJCC, int PAHLOFNIDEF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x85AE100", Offset = "0x85AC700", VA = "0x1885AE100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x85AE1F0", Offset = "0x85AC7F0", VA = "0x1885AE1F0")]
	public void ELCJDKMDHCB(JobHandle BJFLKGBEEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DDCEMAKIKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[BurstCompile]
public struct BNJABNJCNHF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private NativeList<float3> LMLKICDHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private NativeArray<float3> IBCJGILIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private NativeArray<float4> HLFENNFMLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<float2> AEICOIIEHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NativeList<int> OBIBBENNFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BEFJOCFHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private NativeArray<int> MLAFPBKKHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[ReadOnly]
	private NativeArray<bool> ECMGGBJNAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[ReadOnly]
	private NativeArray<bool> EIDCHJDEGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[ReadOnly]
	private int IPOMLPIDHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[ReadOnly]
	private int FDHIDPMJDKC;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x85ADF70", Offset = "0x85AC570", VA = "0x1885ADF70")]
	public BNJABNJCNHF(GKMCCFCPGAH KNHPHEPPGOL, DDCEMAKIKNP JLEFCJKIJIH, int FDHIDPMJDKC = 0, int IPOMLPIDHDJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x85ADB90", Offset = "0x85AC190", VA = "0x1885ADB90", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x85ADB30", Offset = "0x85AC130", VA = "0x1885ADB30")]
	private void DKMIEAPHIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class DANNBBOMHEB
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CF10", Offset = "0x3C1B510", VA = "0x183C1CF10")]
	public static bool PNIDBEBHDLB<T>(NativeArray<T> GHKPAFFMJAO, int KCJLCGFEBMJ, Allocator EEDCBHBBPKF, NativeArrayOptions PLMLGIGGGNL = NativeArrayOptions.ClearMemory, int IEBFCBGNNKE = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D0E0", Offset = "0x3C1B6E0", VA = "0x183C1D0E0")]
	public static bool PNIDBEBHDLB<T>(NativeList<T> BBBJHCKNPGO, int KCJLCGFEBMJ, Allocator EEDCBHBBPKF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CFB0", Offset = "0x3C1B5B0", VA = "0x183C1CFB0")]
	public static bool PNIDBEBHDLB<T>(NativeQueue<T> HIOHIPLNPFI, Allocator EEDCBHBBPKF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public enum PEADBPGCBOF
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
public interface ECMILFBCNGB
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NMDDEKKCCME(PEADBPGCBOF OCNFNIGMAEF);

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IFAPMJBHDDD(PEADBPGCBOF OCNFNIGMAEF);

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EAKFAHMLPOO PLHLMDPAHCF();

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float AICGHANNLHN();

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKGFILLIHDI(PEADBPGCBOF OCNFNIGMAEF, LDDJPFHOBHE ICOFCHPJMOA, int AACEFHAGPHE = -1);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int ACFMBPDFAGK(int DGBKKHJPBED);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class LEFCMNAJNBH
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x85BE2A0", Offset = "0x85BC8A0", VA = "0x1885BE2A0")]
	public static void HBPFENEFPDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class AEOEFOMGKHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeList<float3> LLDLECJOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<float3> ECNCFIBLKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> DOKPMKNPECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<float4> KMLDGAFJAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<float4> OCAAPHKNABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<float4> BPLLGIGHMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> GAMMFGMADIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeList<float3> PDHEIDPFFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeList<int> PJOANHLJOHK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NMNACDAMGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x85ABDA0", Offset = "0x85AA3A0", VA = "0x1885ABDA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CDBLMLKDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x85ABC40", Offset = "0x85AA240", VA = "0x1885ABC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int GACOCIHJPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x85ABC00", Offset = "0x85AA200", VA = "0x1885ABC00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x85ACB10", Offset = "0x85AB110", VA = "0x1885ACB10")]
	public AEOEFOMGKHL(int HDHJMLGDJCC, int PAHLOFNIDEF, int JDIFLHGPKMH, Allocator EEDCBHBBPKF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x85ACE30", Offset = "0x85AB430", VA = "0x1885ACE30")]
	public AEOEFOMGKHL(Mesh KNHPHEPPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x85ABC80", Offset = "0x85AA280", VA = "0x1885ABC80", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x85ABDE0", Offset = "0x85AA3E0", VA = "0x1885ABDE0")]
	public void HGBCLCOEBGB(AEOEFOMGKHL KNHPHEPPGOL, bool HCPFGGJILIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x85AC680", Offset = "0x85AAC80", VA = "0x1885AC680")]
	private void PCAIEJNKMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x85AC110", Offset = "0x85AA710", VA = "0x1885AC110")]
	private void NGPJEHPFKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct NJGBBPHCGDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public int LIOGCGIKOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public int NMNACDAMGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public int JBENEKLBHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public int CDBLMLKDHEG;

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x22E1310", Offset = "0x22DF910", VA = "0x1822E1310")]
	public NJGBBPHCGDN(int OLFODKHFGLI, int MENDNKMGKGP, int NDMFOILAFKD, int EFENLDGOGPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class KPEHFCMMJBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<NJGBBPHCGDN> BDIMFHGPNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<NJGBBPHCGDN>);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xECC1C0", Offset = "0xECA7C0", VA = "0x180ECC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AEOEFOMGKHL PHFGECIDFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x85B9F90", Offset = "0x85B8590", VA = "0x1885B9F90")]
	public KPEHFCMMJBE(IEnumerable<AEOEFOMGKHL> CBLFOFKBKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x85B9F20", Offset = "0x85B8520", VA = "0x1885B9F20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public enum JFMFOJBNGJD
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class OFENCOFGCLE
{
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static NativeArray<float2> MGGEMMBMJFL;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static NativeArray<float3> MHGAJBAHGHA;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static NativeArray<float4> DLFBELIDJAH;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static NativeArray<int> BKLMILMJDAC;

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x85BF830", Offset = "0x85BDE30", VA = "0x1885BF830")]
	public static void HBPFENEFPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x85BFA60", Offset = "0x85BE060", VA = "0x1885BFA60")]
	public static NativeArray<float2> KIHNHAACLDI(NativeArray<float2> DGAANHLHION, int LJAIJOEBMLN, NativeArray<float2> NADELEKHKGH, int ELLEJEDHMJC)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x85BF610", Offset = "0x85BDC10", VA = "0x1885BF610")]
	public static NativeArray<float3> AOKHPKEMMGC(NativeArray<float3> DGAANHLHION, int LJAIJOEBMLN, NativeArray<float3> NADELEKHKGH, int ELLEJEDHMJC)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x85BF720", Offset = "0x85BDD20", VA = "0x1885BF720")]
	public static NativeArray<float4> BOPCDAPPAEF(NativeArray<float4> DGAANHLHION, int LJAIJOEBMLN, NativeArray<float4> NADELEKHKGH, int ELLEJEDHMJC)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x85BF950", Offset = "0x85BDF50", VA = "0x1885BF950")]
	public static NativeArray<int> HJIGHHKIIHD(NativeArray<int> DGAANHLHION, int LJAIJOEBMLN, NativeArray<int> NADELEKHKGH, int ELLEJEDHMJC)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CB50", Offset = "0x3F7B150", VA = "0x183F7CB50")]
	private static void OMBJLBBFKJF<T>(NativeArray<T> GHKPAFFMJAO, int NKFKJNLAOJA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CAA0", Offset = "0x3F7B0A0", VA = "0x183F7CAA0")]
	private static void GIIHBPDDCCE<T>(NativeArray<T> DGAANHLHION, int LJAIJOEBMLN, NativeArray<T> NADELEKHKGH, int ELLEJEDHMJC, NativeArray<T> FPFMAJNDFIF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[BurstCompile]
public class BCGGPDPLGLE
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public struct OELLOKJBFNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public ushort GBNAKFLHCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public ushort ODEKEFJCIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public ushort CNCKLOHMBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public ushort FGINDEFKIHC;
	}

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x85BFC90", Offset = "0x85BE290", VA = "0x1885BFC90")]
	public static uint DALOPBBMCPB(float GGPAOMEFMBA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x85C06A0", Offset = "0x85BECA0", VA = "0x1885C06A0")]
	public static void IJODLCNGAMP(float4 HLFENNFMLBE, float KPOHJAAKIKH, [Out] uint IGKENDFENEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x85C07B0", Offset = "0x85BEDB0", VA = "0x1885C07B0")]
	public static void IJODLCNGAMP(float4 HLFENNFMLBE, uint ADCIFMHIHLF, [Out] uint IGKENDFENEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x85BFF00", Offset = "0x85BE500", VA = "0x1885BFF00")]
	public static void DCLGKHNNHIL(float3 CHFDPPLLHEP, float3 EPIHOCCIEJH, float4 OPPFBMIMMLF, float2 GDAGDHJJCMI, float4 HLFENNFMLBE, [Out] GKMCCFCPGAH.COEMOBKEIIG IIIODEFAKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x85BFCA0", Offset = "0x85BE2A0", VA = "0x1885BFCA0")]
	public static void DCLGKHNNHIL(float3 CHFDPPLLHEP, float3 EPIHOCCIEJH, float4 OPPFBMIMMLF, float2 GDAGDHJJCMI, float4 HLFENNFMLBE, [Out] GKMCCFCPGAH.MBCGHBDILOE IIIODEFAKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x85C05D0", Offset = "0x85BEBD0", VA = "0x1885C05D0")]
	public static byte IAKGAPHJMMN(float KOPHBHGIACG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x85C0650", Offset = "0x85BEC50", VA = "0x1885C0650")]
	public static ushort IHNHFMMJLIB(float KOPHBHGIACG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x85C0620", Offset = "0x85BEC20", VA = "0x1885C0620")]
	public static uint IHHGEOIFHCA(float KOPHBHGIACG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x85C0150", Offset = "0x85BE750", VA = "0x1885C0150")]
	public static float2 DIOPDJNLGON(float2 KMDIJJMODFC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x85C0480", Offset = "0x85BEA80", VA = "0x1885C0480")]
	public static float2 FNHIMFHDFMJ(float3 FMCINJJNLDO)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x85C01D0", Offset = "0x85BE7D0", VA = "0x1885C01D0")]
	public static void DLEFEFENCDG(float3 KOPHBHGIACG, [Out] float3 BOIPCFAMEBO, [Out] uint3 FGINDEFKIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x85C0320", Offset = "0x85BE920", VA = "0x1885C0320")]
	public static OELLOKJBFNE EAFFAHELDAA(float3 APHHGJIDDCM)
	{
		return default(OELLOKJBFNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class HFMKNKCJIOJ
{
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly ProfilerMarker BOOELIAFOGE;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static float JBHJOKNHHDJ;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void BIGMPLCPBJA(bool CBILCFKDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x85D0000", Offset = "0x85CE600", VA = "0x1885D0000")]
	public static float AFCBFCCJEKP(float FIELKDICHHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x85D05D0", Offset = "0x85CEBD0", VA = "0x1885D05D0")]
	public static long PEHCNGMDHKB(float FIELKDICHHE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x85D0110", Offset = "0x85CE710", VA = "0x1885D0110")]
	public static void EKEPPJBJDHH(float FIELKDICHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public interface FKMHAEOBFFP
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKEPPJBJDHH(float BBBBDDHLFLC);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) HFHGNMGMFHO(float IBDHJOFKEPD);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class GHNFGPEODEI
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private enum LLHIJLIKBFC
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
	private class ONKKCLKIFBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public LLHIJLIKBFC GPEIAHGICNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public BatchedMeshRenderer MOGCMIDMHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public PNIKONNDFHB IIJKDNAEEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public DIDLMADDJMG POEHBMLBJGJ;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x85D0AB0", Offset = "0x85CF0B0", VA = "0x1885D0AB0")]
		public void ALBBNBAFAAF([Out] bool PFCHODJIDJB, [Out] bool CEDDGFCDOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ONKKCLKIFBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int OMGIKLCLENB;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static ObjectPool<ONKKCLKIFBH> GPGLGPLIPCE;

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x85CFAE0", Offset = "0x85CE0E0", VA = "0x1885CFAE0")]
	static GHNFGPEODEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x85CF270", Offset = "0x85CD870", VA = "0x1885CF270")]
	private static void FEMJABAMLEE(object IGBHFHKMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x85CF660", Offset = "0x85CDC60", VA = "0x1885CF660")]
	private static void KKAHFMNJFDJ([In] BGAPFACHMPA ANEBMPEOAPJ, [Out] bool PFCHODJIDJB, [Out] bool CEDDGFCDOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x85CF350", Offset = "0x85CD950", VA = "0x1885CF350")]
	public static void GJECBMHCAMA(DIDLMADDJMG POEHBMLBJGJ, BatchedMeshRenderer MOGCMIDMHBJ, long PHGCBAIDMLD, long FLIGFHPOKBM, float AMNDFEPOPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x85CF950", Offset = "0x85CDF50", VA = "0x1885CF950")]
	public static void PGPBBLKPAGK(DIDLMADDJMG POEHBMLBJGJ, BatchedMeshRenderer MOGCMIDMHBJ, long PHGCBAIDMLD, long FLIGFHPOKBM, float EMICMDNOKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x85CF4E0", Offset = "0x85CDAE0", VA = "0x1885CF4E0")]
	public static void HACCHBFCGCC(PNIKONNDFHB IIJKDNAEEDN, BatchedMeshRenderer MOGCMIDMHBJ, long FLIGFHPOKBM, float EMICMDNOKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x85CF0E0", Offset = "0x85CD6E0", VA = "0x1885CF0E0")]
	public static void AFHGJEABNOL(DIDLMADDJMG POEHBMLBJGJ, BatchedMeshRenderer MOGCMIDMHBJ, long PHGCBAIDMLD, long FLIGFHPOKBM, float EMICMDNOKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x85CF710", Offset = "0x85CDD10", VA = "0x1885CF710")]
	private static void LCNJDADCGEF(LLHIJLIKBFC GPEIAHGICNA, DIDLMADDJMG POEHBMLBJGJ, PNIKONNDFHB IIJKDNAEEDN, BatchedMeshRenderer MOGCMIDMHBJ, long PHGCBAIDMLD, long FLIGFHPOKBM, float FAOLJIPJMNP, bool ONMIKADILIH, bool PDDMHKNNDCG, float EOENKBEJCMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class COKPOLLKDFP
{
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker DGLAJEJBAJF;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker HMOPLEGBFLO;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker MLOLGNCMBHG;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly ProfilerMarker EIKEHAGLEOG;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int BFCGBADAGDP;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int FDOLGNDEPFO;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int FGEFEOBJDIE;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static long GKPHAAIEBDB;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static long PPDPNPKOADA;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static long PCDHJDAFJDP;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static long HDBHMOBIKOL;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int BFFKPGDPCPG;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static float HGBILCFCIKP;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static bool NKODMCDGNCO;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int IADBJCLEEKJ;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int BMMMKBFOMCO;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int FIFKNKJFIBH;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static long KDPDNNCPJBB;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static int CGHALILOFFL;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static bool GHKKMKACOHP;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static uint MLOJBBFECGG;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static CECHOOGJMJI FLBGPKCCPLO;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static List<uint> EOCDDJENEIL;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static List<(BGAPFACHMPA.DMDBKJGMKMF, BGAPFACHMPA.HEGHIGLAMFH)> ELHHAHJMDHD;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static FKMHAEOBFFP AFLGHEFFEOE;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static FKMHAEOBFFP IHELDHJIFLB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool ENKFFHDKPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x85C1480", Offset = "0x85BFA80", VA = "0x1885C1480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void EBEBFNFHOEI(bool CBILCFKDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void BIGMPLCPBJA(bool CBILCFKDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void EBEBFNFHOEI(bool CBILCFKDNJC, string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x85C4A50", Offset = "0x85C3050", VA = "0x1885C4A50")]
	public static void LCIOECLLFAM(FKMHAEOBFFP KHFPBOJLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x85C4F40", Offset = "0x85C3540", VA = "0x1885C4F40")]
	public static void MFKMOCPCBGM(FKMHAEOBFFP KHFPBOJLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x85C4380", Offset = "0x85C2980", VA = "0x1885C4380")]
	public static (long, long, long, int, int) GDMLFBOONBN(long PHBIIAHFACE)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x85C49D0", Offset = "0x85C2FD0", VA = "0x1885C49D0")]
	public static void IJPGPENKFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x85C14D0", Offset = "0x85BFAD0", VA = "0x1885C14D0")]
	public static void EKEPPJBJDHH(long PHBIIAHFACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x85C1260", Offset = "0x85BF860", VA = "0x1885C1260")]
	public static void AIDNLFBKKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x85C41D0", Offset = "0x85C27D0", VA = "0x1885C41D0")]
	public static long GCLFOHJGPDB(long JLONIHGKPBK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x85C4FC0", Offset = "0x85C35C0", VA = "0x1885C4FC0")]
	public static bool MLEJACANHMO(long AJHIOMHKADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x85C3BA0", Offset = "0x85C21A0", VA = "0x1885C3BA0")]
	public static bool EPGNLBHNLJN(long AJHIOMHKADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x85C4BE0", Offset = "0x85C31E0", VA = "0x1885C4BE0")]
	public static float LLIOOLMDGLA(long ANOAFLHIOLG, int AKACGMADIAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x85C4550", Offset = "0x85C2B50", VA = "0x1885C4550")]
	public static (long, long, int) HFHGNMGMFHO(float FIELKDICHHE)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x85C3D30", Offset = "0x85C2330", VA = "0x1885C3D30")]
	public static void FGEIKIFICEG(BGAPFACHMPA ANEBMPEOAPJ, int GNOCMMMGCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x85C4080", Offset = "0x85C2680", VA = "0x1885C4080")]
	public static int FNPJPBKKJGG(BGAPFACHMPA.DMDBKJGMKMF NHMHFNINOML, BGAPFACHMPA.HEGHIGLAMFH GPIAINLACIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x85C3C70", Offset = "0x85C2270", VA = "0x1885C3C70")]
	public static bool FAGFIPKNOAD(float OPECKBIOKAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x85C1400", Offset = "0x85BFA00", VA = "0x1885C1400")]
	public static void BOGLJIDBJFK(float OPECKBIOKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x85C4AD0", Offset = "0x85C30D0", VA = "0x1885C4AD0")]
	public static bool LHPBDCECLLO(float OPECKBIOKAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum PFKOJAEOPDA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Persistent
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct BGAPFACHMPA : IComparable<BGAPFACHMPA>, IEquatable<BGAPFACHMPA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public delegate void DMDBKJGMKMF([In] BGAPFACHMPA ANEBMPEOAPJ, [Out] bool PFCHODJIDJB, [Out] bool CEDDGFCDOJI);

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void HEGHIGLAMFH(object IGBHFHKMLJJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public PFKOJAEOPDA BCKOFLNEIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public long NNBMPBGJNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public long FLIGFHPOKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public float AEHADBNLFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public bool PDDMHKNNDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public bool ONMIKADILIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public object IGBHFHKMLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal uint NMILEMOAODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	internal int KHPPFDCFMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	internal HEGHIGLAMFH GPIAINLACIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public float KEBNPPLDLHH;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x85C0910", Offset = "0x85BEF10", VA = "0x1885C0910", Slot = "4")]
	private int System.IComparable<RecRoom.Core.Creation.Quartermaster.QuartermasterWorkItem>.CompareTo(BGAPFACHMPA AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x85C0930", Offset = "0x85BEF30", VA = "0x1885C0930", Slot = "5")]
	private bool System.IEquatable<RecRoom.Core.Creation.Quartermaster.QuartermasterWorkItem>.Equals(BGAPFACHMPA AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class CECHOOGJMJI
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public struct MHADFPBEHEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private List<BGAPFACHMPA> PELNGLIPFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private List<BGAPFACHMPA> GNDGFHCKCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private int KGNIJIHFAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int CFKFLLKDJMO;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BGAPFACHMPA MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x85D08F0", Offset = "0x85CEEF0", VA = "0x1885D08F0")]
			get
			{
				return default(BGAPFACHMPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x85D0A70", Offset = "0x85CF070", VA = "0x1885D0A70")]
		public MHADFPBEHEN(List<BGAPFACHMPA> PELNGLIPFJB, List<BGAPFACHMPA> GNDGFHCKCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x85D07A0", Offset = "0x85CEDA0", VA = "0x1885D07A0")]
		public bool DDPDBHDONME()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private List<BGAPFACHMPA> PELNGLIPFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private List<BGAPFACHMPA> GNDGFHCKCHL;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x85C1000", Offset = "0x85BF600", VA = "0x1885C1000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x85C1050", Offset = "0x85BF650", VA = "0x1885C1050")]
	public void MEFAAGOGBHI([In] BGAPFACHMPA NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x85C1140", Offset = "0x85BF740", VA = "0x1885C1140")]
	public void PBLOBOGDKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x85C0F60", Offset = "0x85BF560", VA = "0x1885C0F60")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x85C0B80", Offset = "0x85BF180", VA = "0x1885C0B80")]
	public void DHNDNBBCFFD(IEnumerable<uint> EOCDDJENEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x85C0AB0", Offset = "0x85BF0B0", VA = "0x1885C0AB0")]
	private static void CDCFDEICIND(List<BGAPFACHMPA> BBBJHCKNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x85C09A0", Offset = "0x85BEFA0", VA = "0x1885C09A0")]
	private void CBELOMAGFLH(uint NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x85C0940", Offset = "0x85BEF40", VA = "0x1885C0940")]
	public MHADFPBEHEN ABGODHCJODA()
	{
		return default(MHADFPBEHEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x85C11A0", Offset = "0x85BF7A0", VA = "0x1885C11A0")]
	public CECHOOGJMJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class PNIKONNDFHB
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal enum NKECCNCOMDM
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
	public static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly string DJBBOGGNAAB;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly string LEGEAPIONML;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly ProfilerMarker KCJMMMJEFBK;

	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private static readonly ProfilerMarker HEKENCFNNBP;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private static readonly ProfilerMarker BOOELIAFOGE;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static readonly ProfilerMarker HMDAGHBELIJ;

	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private static readonly ProfilerMarker IHCKJNOICKO;

	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private static readonly ProfilerMarker AHIIFGNIMDF;

	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private static readonly ProfilerMarker GKOMBOHCEIP;

	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private static readonly ProfilerMarker EHENDMGGAIC;

	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private static readonly ProfilerMarker KPCKBKMHPJK;

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly ProfilerMarker MNDNNGDFGLK;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly ProfilerMarker GENNJHGHMNK;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly ProfilerMarker MFHJJFHHGNL;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly ProfilerMarker HAKKMIHOCFK;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly ProfilerMarker AHELPFECFHO;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly ProfilerMarker AFOMDBAAPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly ProfilerMarker HHKNLBLJJGF;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly ProfilerMarker LNNHHBFPGOA;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static readonly ProfilerMarker MDJJHMBOGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	internal readonly List<DIDLMADDJMG> HLMEGKHOENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly BIMENMEPEPN ELNDMKJGJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private int NFOBDFPPNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private int BKDMEKGNAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private bool MBAELJMCPEH;

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public const bool GAOMPOMMGCE = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public bool KECAGGPJIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	internal NKECCNCOMDM OLCMICGJDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	internal int NJKHNKKIHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	internal int BCFOPBBDHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	internal int AGPALFNDDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	internal int BHGMMELFDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	internal long GFLJHCFDGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	internal long CPLKEFANMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	internal long LHKGLMONGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private GKMCCFCPGAH IKNPBNEKEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private GKMCCFCPGAH PLEEHEGLAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private GKMCCFCPGAH.DJLMDIAEFCE AGMBHPPBADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private bool DDPNEGIPHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private int CPHGLKAHJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private GDCIINPJMDA HPHIAAOOBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private float3 NHFEGGHPLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private float BGOKNIGOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float CNDPFLFOCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private float IGOPLGNOIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float HILCPLHFGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private float CJOJDGCDFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private float DBOHDMEMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float3 BPMABDLAHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private float LIDJMLECONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private float CIHKIBHGEFF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal Mesh PHFGECIDFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MeshFilter ECLPFDDOCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MeshRenderer BMAJJBFJGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public List<Material> LANOABEBOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EBDFCPOMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xC51180", Offset = "0xC4F780", VA = "0x180C51180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NMNACDAMGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x85D2F10", Offset = "0x85D1510", VA = "0x1885D2F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CDBLMLKDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x85D22A0", Offset = "0x85D08A0", VA = "0x1885D22A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x85D4810", Offset = "0x85D2E10", VA = "0x1885D4810")]
	public void IKNKKIDCGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x85D5710", Offset = "0x85D3D10", VA = "0x1885D5710")]
	public bool PMDIHHEOIDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x85D24A0", Offset = "0x85D0AA0", VA = "0x1885D24A0")]
	private void CLDJEMMDHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x85D42B0", Offset = "0x85D28B0", VA = "0x1885D42B0")]
	private void GEIKFMICILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x85D5EA0", Offset = "0x85D44A0", VA = "0x1885D5EA0")]
	public PNIKONNDFHB(string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x85D3970", Offset = "0x85D1F70", VA = "0x1885D3970")]
	public void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x85D2E70", Offset = "0x85D1470", VA = "0x1885D2E70")]
	private void EEIHIDKOLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x85D3BB0", Offset = "0x85D21B0", VA = "0x1885D3BB0")]
	private void FEDCJHLJKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x85D22C0", Offset = "0x85D08C0", VA = "0x1885D22C0")]
	private void CADCKPKHAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x85D3DC0", Offset = "0x85D23C0", VA = "0x1885D3DC0")]
	public Mesh FJCAFILLMFC(MeshFilter KMNHCMDEDKJ, Transform CCHLCEHOKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x85D2F30", Offset = "0x85D1530", VA = "0x1885D2F30")]
	public void EFKMBHLHHHB(bool MMHCJCLOEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x85D5220", Offset = "0x85D3820", VA = "0x1885D5220")]
	private void MIOCGNEGKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x85D2400", Offset = "0x85D0A00", VA = "0x1885D2400")]
	public void CIDDKIPJFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x85D43D0", Offset = "0x85D29D0", VA = "0x1885D43D0")]
	public void HFDCDKHCCMI(ECMILFBCNGB PBHEDNJEOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x85D57B0", Offset = "0x85D3DB0", VA = "0x1885D57B0")]
	public bool POGGJONPGAE(ECMILFBCNGB PBHEDNJEOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x85D1EF0", Offset = "0x85D04F0", VA = "0x1885D1EF0")]
	public bool AOFBHNFGAFG(ECMILFBCNGB PBHEDNJEOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x85D2540", Offset = "0x85D0B40", VA = "0x1885D2540", Slot = "4")]
	public virtual void DCDPGOGGLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x85D2870", Offset = "0x85D0E70", VA = "0x1885D2870")]
	public void DHCJOAALKIA(Transform IKBFOCBMIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x85D52E0", Offset = "0x85D38E0", VA = "0x1885D52E0")]
	public bool NDODNHELJGK(Transform IKBFOCBMIAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x85D2650", Offset = "0x85D0C50", VA = "0x1885D2650")]
	public bool DDIHFCGHEAF(bool OLOJCMMLIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x85D2360", Offset = "0x85D0960", VA = "0x1885D2360")]
	private void CECEEMENLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x85D3110", Offset = "0x85D1710", VA = "0x1885D3110")]
	public bool EKEPPJBJDHH([In] float4x4 PDIPPFLBMHH, BatchedMeshRenderer OPELEKFKFIH, bool MJFAGOMBDKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x85D2DC0", Offset = "0x85D13C0", VA = "0x1885D2DC0")]
	public bool DKDFJAHKFBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x85D13F0", Offset = "0x85CF9F0", VA = "0x1885D13F0")]
	public bool ANJLFCAEHGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x85D21B0", Offset = "0x85D07B0", VA = "0x1885D21B0")]
	public void BHBJADFDJHO(GKMCCFCPGAH KNHPHEPPGOL, int EDBPLMDOMFF, int NELGDHFJIHL, float HJCCAPOOGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x85D48B0", Offset = "0x85D2EB0", VA = "0x1885D48B0")]
	public (long, long, long) LLJKBENNNNC()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
	public long LMFPMDADFJH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x85D4020", Offset = "0x85D2620", VA = "0x1885D4020")]
	private void GDBHGLABODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x85D4600", Offset = "0x85D2C00", VA = "0x1885D4600")]
	public (long, long, int) HFHGNMGMFHO(float FIELKDICHHE, [In] float4x4 PDIPPFLBMHH)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1002BE0", Offset = "0x10011E0", VA = "0x181002BE0")]
	internal void GLOOKLGOEDB(NKECCNCOMDM LGECLDCIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x85D4A70", Offset = "0x85D3070", VA = "0x1885D4A70")]
	internal (float, float, float, float) MGJKJJOILPI(float HAEFFPGOPGD, [In] float4x4 PDIPPFLBMHH)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x85D5510", Offset = "0x85D3B10", VA = "0x1885D5510")]
	private void OFFLLFIGPGK(GKMCCFCPGAH ELHGBCIMEKJ, GKMCCFCPGAH.DJLMDIAEFCE CGKEBJAAGDK, bool OMIJGAAEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x85D4A50", Offset = "0x85D3050", VA = "0x1885D4A50")]
	private void LPHJHKAKMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x85D3AA0", Offset = "0x85D20A0", VA = "0x1885D3AA0")]
	internal bool FDCBKMFJNOH(bool OLOJCMMLIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x85D1030", Offset = "0x85CF630", VA = "0x1885D1030")]
	private void AGAENBDAIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x85D49B0", Offset = "0x85D2FB0", VA = "0x1885D49B0")]
	private void LLNANKKPOML(GKMCCFCPGAH.DJLMDIAEFCE CGKEBJAAGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x85D1FD0", Offset = "0x85D05D0", VA = "0x1885D1FD0")]
	private void BEILMOKCEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x85D3E30", Offset = "0x85D2430", VA = "0x1885D3E30")]
	public long GCLFOHJGPDB(long JLONIHGKPBK, int HADDPAIJJNM)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class DIDLMADDJMG
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal enum FOKHLDNAODC
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
	public struct OHKIDNIEPOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int AJBFKHLMPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int BNIHMOKPGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public float LLDGOMOFAJC;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public struct ONMBABFBAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public MDMMNAGODKB KNHPHEPPGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int KMKHBIEBDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int FEGONJIFDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public long KBAJLEALLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public long NPAHEHHDHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float GKIDGCELHLH;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x85E77F0", Offset = "0x85E5DF0", VA = "0x1885E77F0")]
		public void HAKAIDJFGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x85E7770", Offset = "0x85E5D70", VA = "0x1885E7770")]
		public void ELCJDKMDHCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly string DJBBOGGNAAB;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly string LEGEAPIONML;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly ProfilerMarker KCJMMMJEFBK;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly ProfilerMarker BPNBEKIDGJD;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly ProfilerMarker BOOELIAFOGE;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly ProfilerMarker FFBJGFLFPCI;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly ProfilerMarker HMDAGHBELIJ;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly ProfilerMarker IHCKJNOICKO;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly ProfilerMarker AHIIFGNIMDF;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly ProfilerMarker GKOMBOHCEIP;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static readonly ProfilerMarker EHENDMGGAIC;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly ProfilerMarker NHGMDOPACFA;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly ProfilerMarker KPCKBKMHPJK;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly ProfilerMarker BCFNKPHDBDH;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly ProfilerMarker BJJJCHKMCGA;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly ProfilerMarker OMHKAHBJPBM;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static readonly ProfilerMarker IBDJPODFBDK;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly ProfilerMarker MNDNNGDFGLK;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static readonly ProfilerMarker GENNJHGHMNK;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static readonly ProfilerMarker MFHJJFHHGNL;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly ProfilerMarker HAKKMIHOCFK;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static readonly ProfilerMarker AHELPFECFHO;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly ProfilerMarker AFOMDBAAPJJ;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static readonly ProfilerMarker HHKNLBLJJGF;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static readonly ProfilerMarker LNNHHBFPGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal readonly List<ECMILFBCNGB> GFNBOLMANDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal PNIKONNDFHB EDCBAOBFENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private readonly BIMENMEPEPN ELNDMKJGJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int MLHKJNNPKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal int PJBGPLNKIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal bool AALJPCIENKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal bool MHKDCAPNJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal FOKHLDNAODC MBCLGJOAMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal bool HAMKOPKCJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	internal float3 AOGDNCLEJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal float3 PGEMDMMAPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float MJCJPKLHMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal int MPNCFLODOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal int ABHJIIHFLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	internal int MCJBNCAEHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal float EBHGHMCNGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal int KLCNBAOGIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal float FBHEPCAOGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal float FOGDPJKKLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal int LENMDBFOICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal long CIPOKAFLEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public int FIHLFJNCKPL;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal const int DGGIPPIIEJG = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal float[] JAHPBMCKOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal int[] LJPEKPHAHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal long[] EDIOJHJCEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public List<ONMBABFBAFE> DELKFINIPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal GKMCCFCPGAH MIAFNIFNDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	internal long ENMDDOCLDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	internal int POHOGMFMKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	internal float EPLECNAKHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	internal GKMCCFCPGAH.DJLMDIAEFCE JPMJPKBOPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	internal MDMMNAGODKB GPMOHJEEOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	internal int IHLHBEEIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	internal float CECDIOJGLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	internal long GMBAPMFJBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	internal bool CEJMHPOJPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	internal AILKBJIALDN GBHEHDHONMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	internal JobHandle DCBPKLOKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	internal NativeList<OHKIDNIEPOA> EOKJKMKBAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	internal NativeArray<long> PHADHHDBANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	internal bool LKGILMGAFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	internal JobHandle FNDMKPBPIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	internal GKMCCFCPGAH NOHKDPBNJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	internal DDCEMAKIKNP NADAPKGFDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	internal NativeList<OHKIDNIEPOA> FFDIHJEGJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	internal Transform JBDEGNGHNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	internal PEADBPGCBOF JAEEJCEPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	internal long FMAAPLAEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	internal long ICBKKIFPEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	internal long CDMMLJGADAB;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private static bool KBGGGPPNNKP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<ECMILFBCNGB> OHMMAHKFLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal int NMNACDAMGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x85C9020", Offset = "0x85C7620", VA = "0x1885C9020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x85CC940", Offset = "0x85CAF40", VA = "0x1885CC940")]
	internal void IKNKKIDCGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x85C7690", Offset = "0x85C5C90", VA = "0x1885C7690")]
	internal void CLDJEMMDHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x85CED50", Offset = "0x85CD350", VA = "0x1885CED50")]
	internal DIDLMADDJMG(string NDIENANOGEK, PNIKONNDFHB BEBONNCPGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x85C9FC0", Offset = "0x85C85C0", VA = "0x1885C9FC0")]
	internal void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x85CD6B0", Offset = "0x85CBCB0", VA = "0x1885CD6B0")]
	internal void MIOCGNEGKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x85CDA10", Offset = "0x85CC010", VA = "0x1885CDA10")]
	internal void NEEFFLLDGEK(ECMILFBCNGB PBHEDNJEOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x85CC950", Offset = "0x85CAF50", VA = "0x1885CC950")]
	internal bool JHBNOPNHJOK(ECMILFBCNGB PBHEDNJEOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x85C6FD0", Offset = "0x85C55D0", VA = "0x1885C6FD0")]
	internal bool BKBNILCHKPL(ECMILFBCNGB PBHEDNJEOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x85C77D0", Offset = "0x85C5DD0", VA = "0x1885C77D0", Slot = "4")]
	internal virtual void DCDPGOGGLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x85CA400", Offset = "0x85C8A00", VA = "0x1885CA400")]
	public float FLKENABHFNC(float PDLJCOMNHAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x85CBBF0", Offset = "0x85CA1F0", VA = "0x1885CBBF0")]
	public bool GOFOLMCMEFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x85CC9D0", Offset = "0x85CAFD0", VA = "0x1885CC9D0")]
	public (MDMMNAGODKB, GKMCCFCPGAH.DJLMDIAEFCE) LHDHALCFLLI()
	{
		return default((MDMMNAGODKB, GKMCCFCPGAH.DJLMDIAEFCE));
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x85CD600", Offset = "0x85CBC00", VA = "0x1885CD600")]
	internal long MGMPDEMIHOB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x85CC7F0", Offset = "0x85CADF0", VA = "0x1885CC7F0")]
	internal long HJJGKPGBFCM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x85C5590", Offset = "0x85C3B90", VA = "0x1885C5590")]
	internal bool BAMMLDLANDB(Transform IKBFOCBMIAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x85C7850", Offset = "0x85C5E50", VA = "0x1885C7850")]
	internal bool DDIHFCGHEAF(bool OLOJCMMLIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x85C7030", Offset = "0x85C5630", VA = "0x1885C7030")]
	internal void CECEEMENLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x85C9040", Offset = "0x85C7640", VA = "0x1885C9040")]
	internal bool EKEPPJBJDHH([In] float4x4 PDIPPFLBMHH, BatchedMeshRenderer OPELEKFKFIH, bool MJFAGOMBDKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x85CB940", Offset = "0x85C9F40", VA = "0x1885CB940")]
	internal bool GLEGBOCPNFD(bool OLOJCMMLIJP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x85C8710", Offset = "0x85C6D10", VA = "0x1885C8710")]
	internal void DIGJOKABDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x85C6FA0", Offset = "0x85C55A0", VA = "0x1885C6FA0")]
	internal void BHBJADFDJHO(GKMCCFCPGAH KNHPHEPPGOL, int EDBPLMDOMFF, int NELGDHFJIHL, float HJCCAPOOGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x85C7400", Offset = "0x85C5A00", VA = "0x1885C7400")]
	internal void CKFLOLMGFIC(MDMMNAGODKB EJEOLFEJFJO, int EDBPLMDOMFF, int NELGDHFJIHL, float HJCCAPOOGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x85CB750", Offset = "0x85C9D50", VA = "0x1885CB750")]
	internal void GDBHGLABODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x85CBDF0", Offset = "0x85CA3F0", VA = "0x1885CBDF0")]
	internal (long, long, int) HFHGNMGMFHO(float FIELKDICHHE, [In] float4x4 PDIPPFLBMHH, float BOOFDIKPACE)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0xAAA0C0", Offset = "0xAA86C0", VA = "0x180AAA0C0")]
	internal void GLOOKLGOEDB(FOKHLDNAODC LGECLDCIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x85CD210", Offset = "0x85CB810", VA = "0x1885CD210")]
	public static (float, float, float, float) MGJKJJOILPI(float3 EOMJOCBFOBD, float3 LEHKHDNAAPO, float HAEFFPGOPGD, [In] float4x4 PDIPPFLBMHH, float BOOFDIKPACE)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x85CD000", Offset = "0x85CB600", VA = "0x1885CD000")]
	internal (float, float, float, float) MGJKJJOILPI(float HAEFFPGOPGD, [In] float4x4 PDIPPFLBMHH, float BOOFDIKPACE)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x85CC910", Offset = "0x85CAF10", VA = "0x1885CC910")]
	private float IBAFONEIHAE(float HAEFFPGOPGD, [In] float4x4 PDIPPFLBMHH, float BOOFDIKPACE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x85CC280", Offset = "0x85CA880", VA = "0x1885CC280")]
	private (int, int, float) HGMAHHLDAAD(float ILKKJECDNJA)
	{
		return default((int, int, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x85CA0F0", Offset = "0x85C86F0", VA = "0x1885CA0F0")]
	internal static float ELKKIJBAJKO(ECMILFBCNGB KNHPHEPPGOL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x85C60E0", Offset = "0x85C46E0", VA = "0x1885C60E0")]
	internal void BBMECAJGEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x85C6F10", Offset = "0x85C5510", VA = "0x1885C6F10")]
	internal void BEILMOKCEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x85C8E30", Offset = "0x85C7430", VA = "0x1885C8E30")]
	internal void ECMJNLMAHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x85CB170", Offset = "0x85C9770", VA = "0x1885CB170")]
	internal long GCLFOHJGPDB(long JLONIHGKPBK, int HADDPAIJJNM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x85CA4F0", Offset = "0x85C8AF0", VA = "0x1885CA4F0")]
	private void FPKNCIPFKAJ(GKMCCFCPGAH MMLDHJNIKBK, NativeList<OHKIDNIEPOA> NCMGMNJBJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x85CA1A0", Offset = "0x85C87A0", VA = "0x1885CA1A0")]
	internal void ENBNIEPMAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x85C8720", Offset = "0x85C6D20", VA = "0x1885C8720")]
	public static void DJMAAADGKBN(NativeList<OHKIDNIEPOA> JHPNLENAELO, GKMCCFCPGAH MMLDHJNIKBK, int OLOAKOEEFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x85C8DA0", Offset = "0x85C73A0", VA = "0x1885C8DA0")]
	private float DKENLFFNMCC(int IKDLKIANKGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x85CDC30", Offset = "0x85CC230", VA = "0x1885CDC30")]
	internal void PGMFLMMHHBC(GKMCCFCPGAH KNHPHEPPGOL, BIIDLGNKDOJ EJEOLFEJFJO, int EDBPLMDOMFF, int NELGDHFJIHL, float HJCCAPOOGFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[BurstCompile]
internal struct NFEFHCCPKGG : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal struct ECNEKFDMCHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int JHNJKNFBONI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int IEKEALKKKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int DBJLNDPDPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public float OKJBBOLMEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public float FGGOABCMHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public float BBPBPKGGEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float DBPLIGGKBIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	internal struct FOGLBOFOEPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int JHNJKNFBONI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int IEKEALKKKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int DBJLNDPDPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int HPKOHBENCGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public float OKJBBOLMEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public float FGGOABCMHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public float FNNAABNHOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public float NDNOMECFIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public float DBPLIGGKBIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public struct GOJALFGDOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int JKDOGCBIOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public int MIODIDDPMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public float IODODLCHOMF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public delegate void IDBIAOOBNAO(NFEFHCCPKGG ADPBPKAHKAD, [In] ECNEKFDMCHF CCLIGOMOHOP);

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	internal static class ENDJGADFPJE
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x85E1800", Offset = "0x85DFE00", VA = "0x1885E1800")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x85E1BD0", Offset = "0x85E01D0", VA = "0x1885E1BD0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x85E1B20", Offset = "0x85E0120", VA = "0x1885E1B20")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x85E1930", Offset = "0x85DFF30", VA = "0x1885E1930")]
		public static void MJPLNPACNDN(NFEFHCCPKGG ADPBPKAHKAD, [In] ECNEKFDMCHF CCLIGOMOHOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public delegate void LHMHDCCMBJA(NFEFHCCPKGG ADPBPKAHKAD, [In] FOGLBOFOEPG JCKPCOFJIFJ);

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	internal static class FEGNLPPABIM
	{
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x85E1D30", Offset = "0x85E0330", VA = "0x1885E1D30")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x85E2100", Offset = "0x85E0700", VA = "0x1885E2100")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x85E2050", Offset = "0x85E0650", VA = "0x1885E2050")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x85E1E60", Offset = "0x85E0460", VA = "0x1885E1E60")]
		public static void MJPLNPACNDN(NFEFHCCPKGG ADPBPKAHKAD, [In] FOGLBOFOEPG JCKPCOFJIFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public unsafe delegate void GLOLAAOHPEP(UnsafeList<int>* GKAONCGAOEP, UnsafeList<float3>* GEHEGNIKHCO, [NoAlias] float3* NDICFEBABGB, [NoAlias] float4* NNDDHFIABIO, [NoAlias] float2* MKOAMMIHIOL, [NoAlias] float4* BMIMBDFOHDB, UnsafeList<OCOGMIAPLEP>* MLLHGLGDJFE, UnsafeList<int>* BAOODHICLIC, UnsafeList<float3>* DAOIBJMIBIG, [NoAlias] float3* BKJMMONHEPF, [NoAlias] float4* BBDIKAGIFLF, [NoAlias] float2* AEGFNMGENGO, [NoAlias] float4* FMOFKGPBJGC, int PAHLOFNIDEF, int HDHJMLGDJCC);

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	internal static class FOPOCEFCIBE
	{
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x85E2260", Offset = "0x85E0860", VA = "0x1885E2260")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x85E2780", Offset = "0x85E0D80", VA = "0x1885E2780")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x85E26D0", Offset = "0x85E0CD0", VA = "0x1885E26D0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x85E2390", Offset = "0x85E0990", VA = "0x1885E2390")]
		public unsafe static void MJPLNPACNDN(UnsafeList<int>* GKAONCGAOEP, UnsafeList<float3>* GEHEGNIKHCO, [NoAlias] float3* NDICFEBABGB, [NoAlias] float4* NNDDHFIABIO, [NoAlias] float2* MKOAMMIHIOL, [NoAlias] float4* BMIMBDFOHDB, UnsafeList<OCOGMIAPLEP>* MLLHGLGDJFE, UnsafeList<int>* BAOODHICLIC, UnsafeList<float3>* DAOIBJMIBIG, [NoAlias] float3* BKJMMONHEPF, [NoAlias] float4* BBDIKAGIFLF, [NoAlias] float2* AEGFNMGENGO, [NoAlias] float4* FMOFKGPBJGC, int PAHLOFNIDEF, int HDHJMLGDJCC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public float3 NHFEGGHPLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public float CKHBNENKMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public float IPLHLBPLHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public float OPOLMJFHGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public FDBAAHMDGDF.GFDEJKKPPAO OBBBOHDCMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public bool IHCPLEHKGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<OCOGMIAPLEP>* MLLHGLGDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* BAOODHICLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<ECNEKFDMCHF>* BFJBFHJODDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<ECNEKFDMCHF>* ACMDHKNOKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<FOGLBOFOEPG>* MDJNIBEGKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<FOGLBOFOEPG>* LAFKDFBEPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public int PGNMLEIFGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public int JCOPGDHKJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public int PGMCLMHGGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe float3* DAOIBJMIBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe int* CFKJJFBHHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe GOJALFGDOCI* NDPLDEAJBHH;

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x85E65B0", Offset = "0x85E4BB0", VA = "0x1885E65B0")]
	private static float LJDPBDFOHGN([In] NFEFHCCPKGG ADPBPKAHKAD, [In] float3 OMKEHPNDKKP, float DBPLIGGKBIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x85E5FF0", Offset = "0x85E45F0", VA = "0x1885E5FF0")]
	private static int IPGFGAPHJNF(NFEFHCCPKGG ADPBPKAHKAD, [Out] OCOGMIAPLEP CJECDADIJJA, [In] OCOGMIAPLEP AMCDNKNPJIO, [In] OCOGMIAPLEP PGJANLBNJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x85E6170", Offset = "0x85E4770", VA = "0x1885E6170")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void KLGCBHBLHAF(NFEFHCCPKGG ADPBPKAHKAD, [In] ECNEKFDMCHF CCLIGOMOHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x85E6390", Offset = "0x85E4990", VA = "0x1885E6390")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void LAGLHDNJLIH(NFEFHCCPKGG ADPBPKAHKAD, [In] FOGLBOFOEPG JCKPCOFJIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x85E5760", Offset = "0x85E3D60", VA = "0x1885E5760", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x85E6630", Offset = "0x85E4C30", VA = "0x1885E6630")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal void MKLOFMMLPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x85E73A0", Offset = "0x85E59A0", VA = "0x1885E73A0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void OGOECFHPFIF(UnsafeList<int>* GKAONCGAOEP, UnsafeList<float3>* GEHEGNIKHCO, [NoAlias] float3* NDICFEBABGB, [NoAlias] float4* NNDDHFIABIO, [NoAlias] float2* MKOAMMIHIOL, [NoAlias] float4* BMIMBDFOHDB, UnsafeList<OCOGMIAPLEP>* MLLHGLGDJFE, UnsafeList<int>* BAOODHICLIC, UnsafeList<float3>* DAOIBJMIBIG, [NoAlias] float3* BKJMMONHEPF, [NoAlias] float4* BBDIKAGIFLF, [NoAlias] float2* AEGFNMGENGO, [NoAlias] float4* FMOFKGPBJGC, int PAHLOFNIDEF, int HDHJMLGDJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x85E46A0", Offset = "0x85E2CA0", VA = "0x1885E46A0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void ALHOBBFJEEL(NFEFHCCPKGG ADPBPKAHKAD, [In] ECNEKFDMCHF CCLIGOMOHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x85E5770", Offset = "0x85E3D70", VA = "0x1885E5770")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void GHHDBCCMPMA(NFEFHCCPKGG ADPBPKAHKAD, [In] FOGLBOFOEPG JCKPCOFJIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x85E5050", Offset = "0x85E3650", VA = "0x1885E5050")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void CEJLNOMLENI(UnsafeList<int>* GKAONCGAOEP, UnsafeList<float3>* GEHEGNIKHCO, [NoAlias] float3* NDICFEBABGB, [NoAlias] float4* NNDDHFIABIO, [NoAlias] float2* MKOAMMIHIOL, [NoAlias] float4* BMIMBDFOHDB, UnsafeList<OCOGMIAPLEP>* MLLHGLGDJFE, UnsafeList<int>* BAOODHICLIC, UnsafeList<float3>* DAOIBJMIBIG, [NoAlias] float3* BKJMMONHEPF, [NoAlias] float4* BBDIKAGIFLF, [NoAlias] float2* AEGFNMGENGO, [NoAlias] float4* FMOFKGPBJGC, int PAHLOFNIDEF, int HDHJMLGDJCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class GDCIINPJMDA
{
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private static readonly ProfilerMarker FICIJKIDKBI;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public const int JMCGELPDDJD = 2;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private const int LMHHPDLNMMO = 1;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private static int IOPOIBIDDLG;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private static Stack<GDCIINPJMDA> FMACADKEEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private GKMCCFCPGAH OMNGABOEDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private NativeList<OCOGMIAPLEP> MLLHGLGDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private NativeList<int> BAOODHICLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private NativeList<NFEFHCCPKGG.ECNEKFDMCHF> BFJBFHJODDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeList<NFEFHCCPKGG.ECNEKFDMCHF> ACMDHKNOKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NativeList<NFEFHCCPKGG.FOGLBOFOEPG> MDJNIBEGKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NativeList<NFEFHCCPKGG.FOGLBOFOEPG> LAFKDFBEPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private NFEFHCCPKGG ADPBPKAHKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private JobHandle BJFLKGBEEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private NFEFHCCPKGG.GOJALFGDOCI JAIILJNDLCN;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private const int PGMCLMHGGFB = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x85E3A90", Offset = "0x85E2090", VA = "0x1885E3A90")]
	private GDCIINPJMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x85E3230", Offset = "0x85E1830", VA = "0x1885E3230")]
	public void HCHIENKJDDM(GKMCCFCPGAH AIDNDHKCGGH, float3 JJABDNCBNMC, float EJEJLAIEPBO, float PGOEIEBAHGI, float DOGOFPNOEDA, List<DIDLMADDJMG.OHKIDNIEPOA> EJCHCPAMJFG, Allocator CLGPFGOKFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x85E2A40", Offset = "0x85E1040", VA = "0x1885E2A40")]
	public (bool, GKMCCFCPGAH, float) FJNBBGCGIMO(List<DIDLMADDJMG.OHKIDNIEPOA> EJCHCPAMJFG, Allocator CLGPFGOKFIO, bool OLOJCMMLIJP)
	{
		return default((bool, GKMCCFCPGAH, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x85E3640", Offset = "0x85E1C40", VA = "0x1885E3640")]
	public static bool HPIOGOELIPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x85E36D0", Offset = "0x85E1CD0", VA = "0x1885E36D0")]
	public static int JBMLKKIBDJI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x85E3930", Offset = "0x85E1F30", VA = "0x1885E3930")]
	public static int MAIAEHJINCC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x85E28E0", Offset = "0x85E0EE0", VA = "0x1885E28E0")]
	public static GDCIINPJMDA CKIAKAKNPCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x85E3720", Offset = "0x85E1D20", VA = "0x1885E3720")]
	internal static void JPHEHGGLGLJ(GDCIINPJMDA NDKIBGDDONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x85E37C0", Offset = "0x85E1DC0", VA = "0x1885E37C0")]
	public static void KLBKHIEMKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x85E3080", Offset = "0x85E1680", VA = "0x1885E3080")]
	[FEIBEOENFMF(CMFDNLPEHHP.ExitingPlayMode, 0)]
	public static void HBPFENEFPDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[BurstCompile]
internal struct OCOGMIAPLEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public float3 ALFMKPLFANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public int LICJBNPKAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public int GLELOBINPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public int EPIELEGNHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public float BDDMJMLFKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public float ECMOMDFPLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public int MAJOACCCIDG;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x85E7430", Offset = "0x85E5A30", VA = "0x1885E7430")]
	public static void CEAHGFMKGJD([Out] OCOGMIAPLEP FAKHJBCPGHO, int GGIMKPIFPNM, [In] float3 JPDFMIGNFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x85E7480", Offset = "0x85E5A80", VA = "0x1885E7480")]
	[IgnoreWarning(1371)]
	public static void CEAHGFMKGJD([Out] OCOGMIAPLEP FAKHJBCPGHO, [In] OCOGMIAPLEP BICCKJAFAJE, [In] OCOGMIAPLEP KDNOEJIFMBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[BurstCompile]
internal struct AILKBJIALDN : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private struct OJPIGBOIDAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int CINFOKGGKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int MNFGPOLEKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int HPKFJOEOGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int CCIMKFMIHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public int ODCBPACDGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public int FGINHEKKCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public int KMKHBIEBDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int FEGONJIFDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public float AJFDBCIJPBG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private struct DACOIBFLJKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public FDBAAHMDGDF.KNIADFPOMDG AEPIBKEHGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public float DOEDLEDJNDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public float KEBGHBOMKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public float KNGICJOHKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public float BHFGKBMOJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public float EHFKLPDNDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public float OGKDDMFIJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public float BCMGOHPLDJB;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private struct LPCGHLGAGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public NativeArray<float3> LLDLECJOBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public NativeArray<float3> ECNCFIBLKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public NativeArray<float4> OGIBBOIMDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public NativeArray<float4> MBDHILMIKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public NativeArray<float2> KHDHFKNOHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public NativeArray<int> PJOANHLJOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public bool NDLKEHPGABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int NMNACDAMGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int CDBLMLKDHEG;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x85E4410", Offset = "0x85E2A10", VA = "0x1885E4410")]
		public void KEBIFLKGLKF(int HDHJMLGDJCC, int PAHLOFNIDEF, Allocator EEDCBHBBPKF, bool FFJMFEOHINF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x85E3F10", Offset = "0x85E2510", VA = "0x1885E3F10")]
		public static LPCGHLGAGNO APPLPKBHJPF(GKMCCFCPGAH PPEFJKBNOEP)
		{
			return default(LPCGHLGAGNO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x44EAD90", Offset = "0x44E9390", VA = "0x1844EAD90")]
		private static void BEMBMBJJGAL<T>(NativeArray<T> PPEFJKBNOEP, NativeArray<T> DNPKCGAKHLK) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x85E4350", Offset = "0x85E2950", VA = "0x1885E4350")]
		public void ELCJDKMDHCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public unsafe delegate void LKHJDAAOGKM(int CAOONCMBIJO, [In][NoAlias] DIDLMADDJMG.OHKIDNIEPOA* NGOJMGCIOHB, [In][NoAlias] DIDLMADDJMG.OHKIDNIEPOA* NLKIMPNBJJH, int MENDNKMGKGP);

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	internal static class PEEBBIADHDO
	{
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x85E7820", Offset = "0x85E5E20", VA = "0x1885E7820")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x85E7C30", Offset = "0x85E6230", VA = "0x1885E7C30")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x85E7B80", Offset = "0x85E6180", VA = "0x1885E7B80")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x85E7950", Offset = "0x85E5F50", VA = "0x1885E7950")]
		public unsafe static void MJPLNPACNDN(int CAOONCMBIJO, [In][NoAlias] DIDLMADDJMG.OHKIDNIEPOA* NGOJMGCIOHB, [In][NoAlias] DIDLMADDJMG.OHKIDNIEPOA* NLKIMPNBJJH, int MENDNKMGKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private static readonly ProfilerMarker HFEMCPOODOH;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private static readonly ProfilerMarker IEHLIJBCHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private NativeArray<OJPIGBOIDAH> GONNBGMFELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private LPCGHLGAGNO PHAFOPCIGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private LPCGHLGAGNO MMLDHJNIKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private float3 DKGEMPMAGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private float3 BBFBIHIKMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private DACOIBFLJKF CAKGMMEMIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* AJPCFDEDBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private NativeArray<DIDLMADDJMG.OHKIDNIEPOA> DGHFEJEMPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private NativeList<DIDLMADDJMG.OHKIDNIEPOA> JMEAGKNNLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private NativeArray<int> BAOODHICLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private NativeArray<bool> EIDCHJDEGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private NativeArray<int> MLJLLAMAKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private NativeArray<int> DLMPCOMLPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private NativeArray<float> IDDNFAABLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private NativeArray<int> CLDENLPCDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private NativeArray<float> MIBLOHDLNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private NativeArray<int> HDDHDECBEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private NativeArray<int> DDLMFAOODPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private NativeArray<float> NJNFEBNDGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private NativeArray<float> PEOBCMPFBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private NativeArray<int> LCPPNBOIOKH;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x85DADA0", Offset = "0x85D93A0", VA = "0x1885DADA0")]
	public AILKBJIALDN([In] List<DIDLMADDJMG.ONMBABFBAFE> JHNFAEFFBLJ, NativeList<DIDLMADDJMG.OHKIDNIEPOA> OOBMGNDPIED, [In] GKMCCFCPGAH PDDKPMKNGOB, [In] NativeList<DIDLMADDJMG.OHKIDNIEPOA> NCMGMNJBJNH, [In] NativeArray<long> PHADHHDBANH, float3 DACLOKMHGAF, float3 JMHOLPOAODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x85D8700", Offset = "0x85D6D00", VA = "0x1885D8700")]
	[BurstCompile]
	private unsafe static void BBLKAHKHGKE(int CAOONCMBIJO, [In][NoAlias] DIDLMADDJMG.OHKIDNIEPOA* NGOJMGCIOHB, [In][NoAlias] DIDLMADDJMG.OHKIDNIEPOA* NLKIMPNBJJH, int MENDNKMGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x85DACE0", Offset = "0x85D92E0", VA = "0x1885DACE0")]
	public static long KHFGOGKFCOK(int HDHJMLGDJCC, int PAHLOFNIDEF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x85D9550", Offset = "0x85D7B50", VA = "0x1885D9550", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x85D7AC0", Offset = "0x85D60C0", VA = "0x1885D7AC0")]
	public void AHILLDKJELL(List<DIDLMADDJMG.ONMBABFBAFE> BAKEEOIHPMK, [In] DIDLMADDJMG EJFAGPDFMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x85D9530", Offset = "0x85D7B30", VA = "0x1885D9530")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private bool EMNEBJLMFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x85D8FE0", Offset = "0x85D75E0", VA = "0x1885D8FE0")]
	private MDMMNAGODKB COOJMOOJNPO(int NMFDGCABBCN, Allocator EEDCBHBBPKF)
	{
		return default(MDMMNAGODKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x85D95A0", Offset = "0x85D7BA0", VA = "0x1885D95A0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void FJABGODLHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x85D8970", Offset = "0x85D6F70", VA = "0x1885D8970")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float BCBPEAAJGHK(int FNEGHEBPNJB, int CIFONHANCBK, bool LMLEFNONABM, bool AAOKPIKOLJH, float NEAGDADLOCJ, float JEDPMNHDBLJ, float AAGHLKKKAJB, float CGIPFFAAABD, float JCBEOKGDEND, float MBFKGBFGIOB, float PJMMJDMCIEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x85D9210", Offset = "0x85D7810", VA = "0x1885D9210")]
	[IgnoreWarning(1371)]
	private OJPIGBOIDAH CPOFKJMABCM([In] OJPIGBOIDAH ECPIPKKCBLL, int ANMPJLPNILN, [In] NativeArray<int> OBIBBENNFHJ, [In] NativeArray<bool> EIDCHJDEGEJ, NativeArray<int> MLJLLAMAKIN)
	{
		return default(OJPIGBOIDAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x85D8520", Offset = "0x85D6B20", VA = "0x1885D8520")]
	public static int AIBLCLJEBCP(NativeArray<int> OBIBBENNFHJ, NativeArray<int> LCPPNBOIOKH, int GGAINBCGOFF, int BIOKPIDMFDJ, int DLDBIIMMMOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x85D6140", Offset = "0x85D4740", VA = "0x1885D6140")]
	[BurstCompile]
	public unsafe static void CEALHLKJDPJ(int CAOONCMBIJO, [In][NoAlias] DIDLMADDJMG.OHKIDNIEPOA* NGOJMGCIOHB, [In][NoAlias] DIDLMADDJMG.OHKIDNIEPOA* NLKIMPNBJJH, int MENDNKMGKGP)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class BatchedMeshRenderer : MonoBehaviour, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		private struct KCKGHDGFFCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public long ACHHBNALLIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public EAKFAHMLPOO KMJIOHGPLNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public ECMILFBCNGB KOJIMAFGDLP;

			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x85E3DF0", Offset = "0x85E23F0", VA = "0x1885E3DF0")]
			public KCKGHDGFFCP(EAKFAHMLPOO HMHNKDOJOIN, ECMILFBCNGB CMEPKEFDDNO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		private class MCAEABGIJMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public EAKFAHMLPOO KMJIOHGPLNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public int MENDNKMGKGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public float MJCJPKLHMJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public List<KCKGHDGFFCP> DEBLCIECHEI;

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x85E45F0", Offset = "0x85E2BF0", VA = "0x1885E45F0")]
			public MCAEABGIJMB(EAKFAHMLPOO HMHNKDOJOIN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private static readonly ProfilerMarker LAMLAANPHBD;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private static readonly ProfilerMarker JNMFGAKABCE;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private static readonly ProfilerMarker CFMGNHFJPJD;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private static readonly ProfilerMarker JIPJBFOJJLJ;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static readonly ProfilerMarker NEDNJMPKNBC;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private static readonly ProfilerMarker AHIIFGNIMDF;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private static readonly ProfilerMarker IDCCBBLOIDN;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		internal const int BEKIJJIOLJB = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		internal static Dictionary<Material, List<Material>> MPCJAGDJIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Dictionary<Material, List<PNIKONNDFHB>> EHNGJINDKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		internal List<PNIKONNDFHB> BFGKILPKBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private List<MeshRenderer> LMNOJDMFCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private Transform GKMKOPPOHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private bool JAIKLMJFOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private bool DFHKNOKGMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private int KJJAJNOMABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private PNIKONNDFHB HPEBAFICAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private Material LDKILKFCAAN;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private static bool? JEFGDGOBDFE;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private const int DNINFCDIJKG = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private static List<KCKGHDGFFCP> CPFNACFDAAO;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<MeshRenderer> KLEKKHCLLGB
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int NGPJHBOOFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x85E17B0", Offset = "0x85DFDB0", VA = "0x1885E17B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private static bool MFKMBOGEMCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x85DB7C0", Offset = "0x85D9DC0", VA = "0x1885DB7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private static void EBEBFNFHOEI(bool CBILCFKDNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private static void EBEBFNFHOEI(bool CBILCFKDNJC, string GKNICJPCIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private static void OAGLKELLJNO(string NDIENANOGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x85DBAF0", Offset = "0x85DA0F0", VA = "0x1885DBAF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x85DD260", Offset = "0x85DB860", VA = "0x1885DD260")]
		internal bool IAJPKGGKDHG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x85DD960", Offset = "0x85DBF60", VA = "0x1885DD960")]
		private Transform LPPECOMMOLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x85DE290", Offset = "0x85DC890", VA = "0x1885DE290")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x85DC4A0", Offset = "0x85DAAA0", VA = "0x1885DC4A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x85DB8F0", Offset = "0x85D9EF0", VA = "0x1885DB8F0")]
		public PNIKONNDFHB AddToBatchedMesh(ECMILFBCNGB FLFBNKEKKOP, Material PFHPGDKJCCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x85E1170", Offset = "0x85DF770", VA = "0x1885E1170")]
		public void RemoveFromBatchedMesh(ECMILFBCNGB KNHPHEPPGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x85DBCD0", Offset = "0x85DA2D0", VA = "0x1885DBCD0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x85DBB20", Offset = "0x85DA120", VA = "0x1885DBB20")]
		private void BMJEGNGKBHK(Renderer MAFJPEPPLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x85DD2D0", Offset = "0x85DB8D0", VA = "0x1885DD2D0")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x85DD2C0", Offset = "0x85DB8C0", VA = "0x1885DD2C0")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x85DD340", Offset = "0x85DB940", VA = "0x1885DD340")]
		private void JIOHHECGJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x85DDB40", Offset = "0x85DC140", VA = "0x1885DDB40")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x85DE070", Offset = "0x85DC670", VA = "0x1885DE070")]
		private PNIKONNDFHB OMFBLKJJLOH(ECMILFBCNGB KNHPHEPPGOL, Material PFHPGDKJCCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x85DCF80", Offset = "0x85DB580", VA = "0x1885DCF80")]
		private PNIKONNDFHB HIEAJPAJHFI(Material PFHPGDKJCCC, int NMEJJBBKCJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x85DBE00", Offset = "0x85DA400", VA = "0x1885DBE00")]
		private PNIKONNDFHB DDNKMIAMMKG(Material PFHPGDKJCCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x85DC890", Offset = "0x85DAE90", VA = "0x1885DC890")]
		internal void EGIDANLEEHC([Out] float4x4 PDIPPFLBMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x85DC920", Offset = "0x85DAF20", VA = "0x1885DC920")]
		public static List<Material> GenerateVertexFormatVariants(Material PFHPGDKJCCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x85E12B0", Offset = "0x85DF8B0", VA = "0x1885E12B0")]
		public static void UpdateMaterialVariants(Material BENACLKPEBD, Action<Material> JFHDLAFFHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x12AD750", Offset = "0x12ABD50", VA = "0x1812AD750")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x85DD9E0", Offset = "0x85DBFE0", VA = "0x1885DD9E0")]
		public void MarkDirty(ECMILFBCNGB KNHPHEPPGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x85DB6C0", Offset = "0x85D9CC0", VA = "0x1885DB6C0")]
		[Conditional("CHECK_STATE")]
		private void AHMCHDJIHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x85DDCA0", Offset = "0x85DC2A0", VA = "0x1885DDCA0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float FIELKDICHHE)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x85DBBA0", Offset = "0x85DA1A0", VA = "0x1885DBBA0")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x85DFEB0", Offset = "0x85DE4B0", VA = "0x1885DFEB0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x85DCA40", Offset = "0x85DB040", VA = "0x1885DCA40")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x85DE380", Offset = "0x85DC980", VA = "0x1885DE380")]
		public void RebatchOptimally(int LIECFOMOICC, int AEDOHCHBMNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x85DE2A0", Offset = "0x85DC8A0", VA = "0x1885DE2A0")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x85E1680", Offset = "0x85DFC80", VA = "0x1885E1680")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class PMDMEODPMNJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private struct DABHGDPKDOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public BatchedMeshRenderer MAFJPEPPLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public PNIKONNDFHB KNHPHEPPGOL;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1D41610", Offset = "0x1D3FC10", VA = "0x181D41610")]
		public void NMBCNGLDPJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private struct GAIOJODJJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public float HHPNPECICFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public PNIKONNDFHB OKLHGPDEDCC;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private sealed class KEHLHHMMNLJ : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x1342CD0", Offset = "0x13412D0", VA = "0x181342CD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x85ED9F0", Offset = "0x85EBFF0", VA = "0x1885ED9F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x15BD540", Offset = "0x15BBB40", VA = "0x1815BD540")]
		[DebuggerHidden]
		public KEHLHHMMNLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x85EDA40", Offset = "0x85EC040", VA = "0x1885EDA40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x85EC630", Offset = "0x85EAC30", VA = "0x1885EC630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x85EC5E0", Offset = "0x85EABE0", VA = "0x1885EC5E0")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x85EC590", Offset = "0x85EAB90", VA = "0x1885EC590")]
		private void FECGMFJNPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x85ED9A0", Offset = "0x85EBFA0", VA = "0x1885ED9A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x85ED8F0", Offset = "0x85EBEF0", VA = "0x1885ED8F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x85ED8F0", Offset = "0x85EBEF0", VA = "0x1885ED8F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private static readonly ProfilerMarker AHIIFGNIMDF;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private static readonly ProfilerMarker BIHPIHHICNB;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private static readonly ProfilerMarker CMDMKCHEDHP;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static readonly ProfilerMarker CJEIIJBLMPJ;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static float3 HNJMNMHLDPO;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static int FLEGBCGLIGC;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static int DEABIJLIIHN;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static int OGKCLDLFEDM;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static int NCEFBGPGIMI;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static int FHMEEEHJAGL;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static float NEKCHDDMMJB;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static float AAPOFHDBGAF;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static float IMLIEBBDKGM;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static float BKLLIEOCADO;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static float KAAGAGKCGEC;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static float IGOGADHLCBH;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static float LBMKLFIMJFD;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static float CDJCAILBMPG;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static List<BatchedMeshRenderer> LOPCCKEMMCE;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private static Stack<GKMCCFCPGAH> HEKOCGDBCIL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private static Stack<DDCEMAKIKNP> IPIBNJNNCLE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static DIBJFLJJFNO AMGDJGGJAOG;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static DABHGDPKDOE EJECFGLDNAO;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static int KKJDHLFDEHJ;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void EBEBFNFHOEI(bool CBILCFKDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void BIGMPLCPBJA(bool CBILCFKDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void EBEBFNFHOEI(bool CBILCFKDNJC, string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x85E9EE0", Offset = "0x85E84E0", VA = "0x1885E9EE0")]
	public static void HAKAIDJFGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x85E87E0", Offset = "0x85E6DE0", VA = "0x1885E87E0")]
	public static void DFIDGJNNMOG(BatchedMeshRenderer MIEBADEIFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x85EB070", Offset = "0x85E9670", VA = "0x1885EB070")]
	public static void LEJLNEHNAGL(BatchedMeshRenderer MIEBADEIFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x85E7D90", Offset = "0x85E6390", VA = "0x1885E7D90")]
	public static void ABDKHAPNKKF(ECMILFBCNGB PBHEDNJEOAG, bool MMHCJCLOEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x85EA1D0", Offset = "0x85E87D0", VA = "0x1885EA1D0")]
	public static void IIMBFHIFMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x85E8900", Offset = "0x85E6F00", VA = "0x1885E8900")]
	public static void EKEPPJBJDHH(float FIELKDICHHE, bool MNGPCFLMKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x85EAA30", Offset = "0x85E9030", VA = "0x1885EAA30")]
	private static void KIAEMJFFEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x85E9450", Offset = "0x85E7A50", VA = "0x1885E9450")]
	public static long GCLFOHJGPDB(int HADDPAIJJNM, long JLONIHGKPBK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F40", Offset = "0x85E8540", VA = "0x1885E9F40")]
	public static (long, long, int) HFHGNMGMFHO(float FIELKDICHHE)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x85EA150", Offset = "0x85E8750", VA = "0x1885EA150")]
	[IteratorStateMachine(typeof(KEHLHHMMNLJ))]
	public static IEnumerable<bool> HLLKNEHBEOM(long ANDEKEFEIPC, bool EPFLEKCKNOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x85EA7D0", Offset = "0x85E8DD0", VA = "0x1885EA7D0")]
	public static void JPJEKNMLFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x85E91B0", Offset = "0x85E77B0", VA = "0x1885E91B0")]
	public static void FPFKLMJJIFP(long ANDEKEFEIPC, bool EPFLEKCKNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x85E84E0", Offset = "0x85E6AE0", VA = "0x1885E84E0")]
	public static int BBBLFLMGJFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x85E8660", Offset = "0x85E6C60", VA = "0x1885E8660")]
	internal static GKMCCFCPGAH BEAPDAGBMDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x85EA690", Offset = "0x85E8C90", VA = "0x1885EA690")]
	internal static void JPHEHGGLGLJ(GKMCCFCPGAH NKBNCINEHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x85EA540", Offset = "0x85E8B40", VA = "0x1885EA540")]
	internal static DDCEMAKIKNP JCCNKGNHJKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x85EA740", Offset = "0x85E8D40", VA = "0x1885EA740")]
	internal static void JPHEHGGLGLJ(DDCEMAKIKNP JLEFCJKIJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x85EAEB0", Offset = "0x85E94B0", VA = "0x1885EAEB0")]
	public static void KLBKHIEMKHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class ELPCEDNAOPO<KeyType> : PNIKONNDFHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private readonly Dictionary<KeyType, ECMILFBCNGB> KJNFOPHOABA;

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x4B60C60", Offset = "0x4B5F260", VA = "0x184B60C60")]
	public ELPCEDNAOPO(string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x4B60C10", Offset = "0x4B5F210", VA = "0x184B60C10")]
	public void HFDCDKHCCMI(KeyType HAELBKGFDIJ, ECMILFBCNGB PBHEDNJEOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x4B608B0", Offset = "0x4B5EEB0", VA = "0x184B608B0")]
	public bool AAHMBNDEBJI(KeyType HAELBKGFDIJ, ECMILFBCNGB OEBGHLJLEHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4B60AB0", Offset = "0x4B5F0B0", VA = "0x184B60AB0")]
	public void HCIKHIDFDOE(KeyType HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x4B60A70", Offset = "0x4B5F070", VA = "0x184B60A70", Slot = "4")]
	public override void DCDPGOGGLBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class GGONFGGKADE
{
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly ProfilerCategory NIPDEPDOEME;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	internal static readonly ProfilerMarker LLIOOLMDGLA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	internal static readonly HJOOCOBMHDA EKEPPJBJDHH;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private static readonly NPMCMFPGHKD<float> EBBMIODNKKM;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private static readonly NPMCMFPGHKD<float> BJMFHEGEBAC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	private static readonly NPMCMFPGHKD<float> JLGFDPEEPGB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private static readonly NPMCMFPGHKD<double> DFGAKBLINGH;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private static readonly NPMCMFPGHKD<double> CBAGJLOBDNB;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private static readonly NPMCMFPGHKD<double> NBMMIMAKAGI;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private static readonly NPMCMFPGHKD<double> LJHGJKBCOAK;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private static readonly NPMCMFPGHKD<int> LPMKPIDHIIB;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private static readonly NPMCMFPGHKD<int> EEBOOJAIOGF;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private static readonly NPMCMFPGHKD<int> IJMDAADFMND;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private static readonly NPMCMFPGHKD<int> KHMFEKKEEFM;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private static readonly NPMCMFPGHKD<int> POIDKMNFCDH;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private static readonly NPMCMFPGHKD<int> JGLOAIAKEHA;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private static readonly NPMCMFPGHKD<int> ECECNEEIGCI;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private static readonly NPMCMFPGHKD<int> CBBEFNEMNDN;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private static readonly NPMCMFPGHKD<long> BLCNGFHMMCL;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private static readonly NPMCMFPGHKD<long> CPJCPFFPDGJ;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private static readonly NPMCMFPGHKD<long> BBNJFIPMNGC;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly NPMCMFPGHKD<long> ELLLEIANCNL;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly NPMCMFPGHKD<long> GHFOEGPKCLD;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly NPMCMFPGHKD<long> EOECBHNDDDJ;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x85EB6E0", Offset = "0x85E9CE0", VA = "0x1885EB6E0")]
	public static void OAGIAAJGHJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x85EDB60", Offset = "0x85EC160", VA = "0x1885EDB60")]
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
