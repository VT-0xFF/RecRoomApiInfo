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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85044C0", Offset = "0x8502AC0", VA = "0x1885044C0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class LMGPHBNIECK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IDGHEFJHGEI HCAGCHBIAIO;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly IDGHEFJHGEI MALEOOBECJG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly IDGHEFJHGEI IKHJOFFHFDC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly IDGHEFJHGEI EDGHGODLOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly IDGHEFJHGEI KBAKCPMEBOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class DJFJNPGBIKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public GKDOCEBGLOE BOKKEFJOAFD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GAELDOPGMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DJFJNPGBIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct GKDOCEBGLOE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct JFCHLDDLPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half EAPOLCIBCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort INKMPOKGOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte MCFGNCOBMBI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void GLMDMDECNBL([NoAlias] float3* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class OEGBELGJLDH
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x850A090", Offset = "0x8508690", VA = "0x18850A090")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8509C50", Offset = "0x8508250", VA = "0x188509C50")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8509FE0", Offset = "0x85085E0", VA = "0x188509FE0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8509DB0", Offset = "0x85083B0", VA = "0x188509DB0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] float3* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void CJLPIOHANLA([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class JJHKPJPNEKE
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84F9F00", Offset = "0x84F8500", VA = "0x1884F9F00")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84F9A40", Offset = "0x84F8040", VA = "0x1884F9A40")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84F9E50", Offset = "0x84F8450", VA = "0x1884F9E50")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84F9BA0", Offset = "0x84F81A0", VA = "0x1884F9BA0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void EIMEJGGDJIJ([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class LEKJDBDOINJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8503190", Offset = "0x8501790", VA = "0x188503190")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8502CD0", Offset = "0x85012D0", VA = "0x188502CD0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85030E0", Offset = "0x85016E0", VA = "0x1885030E0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8502E30", Offset = "0x8501430", VA = "0x188502E30")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void MMCIPBFKHON([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class JGKCPDIIFGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84F9810", Offset = "0x84F7E10", VA = "0x1884F9810")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84F9350", Offset = "0x84F7950", VA = "0x1884F9350")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84F9760", Offset = "0x84F7D60", VA = "0x1884F9760")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84F94B0", Offset = "0x84F7AB0", VA = "0x1884F94B0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void JHBDFJALAAM([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class HMBJCNPMKHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84F74A0", Offset = "0x84F5AA0", VA = "0x1884F74A0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84F6FE0", Offset = "0x84F55E0", VA = "0x1884F6FE0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x84F73F0", Offset = "0x84F59F0", VA = "0x1884F73F0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x84F7140", Offset = "0x84F5740", VA = "0x1884F7140")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void KCFNMEPELKE([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class IHODBLCDNDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84F8470", Offset = "0x84F6A70", VA = "0x1884F8470")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x84F7F20", Offset = "0x84F6520", VA = "0x1884F7F20")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x84F83C0", Offset = "0x84F69C0", VA = "0x1884F83C0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84F8080", Offset = "0x84F6680", VA = "0x1884F8080")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void JHJPJACKGBP([NoAlias] ushort* DPHNEGIHDHH, [Out] float3 LIFIHEMKAMI, [Out] float3 AEBGKMDPEBA, [In][NoAlias] float3* JHPGCKNNIJG, int MPNCAKFENGE, int MCHFPDKIKIK);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class BEHJOOGHMDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84E7940", Offset = "0x84E5F40", VA = "0x1884E7940")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84E74F0", Offset = "0x84E5AF0", VA = "0x1884E74F0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84E7890", Offset = "0x84E5E90", VA = "0x1884E7890")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84E7650", Offset = "0x84E5C50", VA = "0x1884E7650")]
		public unsafe static void JKGEGDFKKNG([NoAlias] ushort* DPHNEGIHDHH, [Out] float3 LIFIHEMKAMI, [Out] float3 AEBGKMDPEBA, [In][NoAlias] float3* JHPGCKNNIJG, int MPNCAKFENGE, int MCHFPDKIKIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void JAFEJIBOBFN([NoAlias] ushort* GKJBPDPDCGO, [In][NoAlias] float3* BKLOAGCOPFL, int MCHFPDKIKIK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class PNGKGKOLNFI
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x850BAB0", Offset = "0x850A0B0", VA = "0x18850BAB0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x850B690", Offset = "0x8509C90", VA = "0x18850B690")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x850BA00", Offset = "0x850A000", VA = "0x18850BA00")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x850B7F0", Offset = "0x8509DF0", VA = "0x18850B7F0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] ushort* GKJBPDPDCGO, [In][NoAlias] float3* BKLOAGCOPFL, int MCHFPDKIKIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void LLJDDCANDOP([NoAlias] float3* MDHFPPIOCEB, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class JKLGBGGHHKL
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x84FA450", Offset = "0x84F8A50", VA = "0x1884FA450")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84FA030", Offset = "0x84F8630", VA = "0x1884FA030")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x84FA3A0", Offset = "0x84F89A0", VA = "0x1884FA3A0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84FA190", Offset = "0x84F8790", VA = "0x1884FA190")]
		public unsafe static void JKGEGDFKKNG([NoAlias] float3* MDHFPPIOCEB, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void MJGAEOKFOND([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class CDAOFFAPDND
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x84E9BD0", Offset = "0x84E81D0", VA = "0x1884E9BD0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84E97B0", Offset = "0x84E7DB0", VA = "0x1884E97B0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84E9B20", Offset = "0x84E8120", VA = "0x1884E9B20")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84E9910", Offset = "0x84E7F10", VA = "0x1884E9910")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void EPDPNAADLKO([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class DCNLNDDJPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84EB420", Offset = "0x84E9A20", VA = "0x1884EB420")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x84EAF10", Offset = "0x84E9510", VA = "0x1884EAF10")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x84EB370", Offset = "0x84E9970", VA = "0x1884EB370")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x84EB070", Offset = "0x84E9670", VA = "0x1884EB070")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void HDFGGKCAKCP([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class IIMPNLJOLDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84F8AB0", Offset = "0x84F70B0", VA = "0x1884F8AB0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84F85A0", Offset = "0x84F6BA0", VA = "0x1884F85A0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84F8A00", Offset = "0x84F7000", VA = "0x1884F8A00")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84F8700", Offset = "0x84F6D00", VA = "0x1884F8700")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void ABGLEJDGDJF([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class JDGNECFANOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84F9220", Offset = "0x84F7820", VA = "0x1884F9220")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x84F8CE0", Offset = "0x84F72E0", VA = "0x1884F8CE0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x84F9170", Offset = "0x84F7770", VA = "0x1884F9170")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84F8E40", Offset = "0x84F7440", VA = "0x1884F8E40")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void BLLEPBLJJAN([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class CAMICNPGEPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84E9580", Offset = "0x84E7B80", VA = "0x1884E9580")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84E9040", Offset = "0x84E7640", VA = "0x1884E9040")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x84E94D0", Offset = "0x84E7AD0", VA = "0x1884E94D0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84E91A0", Offset = "0x84E77A0", VA = "0x1884E91A0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void MBIMGOHGCPL([NoAlias] uint* HHBAHAHPJKB, [Out] float2 LFPBPCFABAM, [Out] float2 BDGPOIHFPOM, [In][NoAlias] float2* PJPKDAPLGBK, int MPNCAKFENGE, int MCHFPDKIKIK);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class EIBJBMDBHIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x84ED570", Offset = "0x84EBB70", VA = "0x1884ED570")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x84ED120", Offset = "0x84EB720", VA = "0x1884ED120")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x84ED4C0", Offset = "0x84EBAC0", VA = "0x1884ED4C0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x84ED280", Offset = "0x84EB880", VA = "0x1884ED280")]
		public unsafe static void JKGEGDFKKNG([NoAlias] uint* HHBAHAHPJKB, [Out] float2 LFPBPCFABAM, [Out] float2 BDGPOIHFPOM, [In][NoAlias] float2* PJPKDAPLGBK, int MPNCAKFENGE, int MCHFPDKIKIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void BFDDKAMOHGB([Out] float2 KDFDHHEOIEB, uint NGIFHNNNGLP, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class BFNFDLDLDFN
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x84E7FE0", Offset = "0x84E65E0", VA = "0x1884E7FE0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84E7B70", Offset = "0x84E6170", VA = "0x1884E7B70")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84E7F30", Offset = "0x84E6530", VA = "0x1884E7F30")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84E7CD0", Offset = "0x84E62D0", VA = "0x1884E7CD0")]
		public static void JKGEGDFKKNG([Out] float2 KDFDHHEOIEB, uint NGIFHNNNGLP, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void HNFFNGBLLGP([NoAlias] float2* HHBAHAHPJKB, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class AJPPBNHGAPB
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x84E73C0", Offset = "0x84E59C0", VA = "0x1884E73C0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x84E6EC0", Offset = "0x84E54C0", VA = "0x1884E6EC0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84E7310", Offset = "0x84E5910", VA = "0x1884E7310")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84E7020", Offset = "0x84E5620", VA = "0x1884E7020")]
		public unsafe static void JKGEGDFKKNG([NoAlias] float2* HHBAHAHPJKB, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void MMKGJPOEFFI([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class GEDEJKEFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84EF4A0", Offset = "0x84EDAA0", VA = "0x1884EF4A0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x84EEF70", Offset = "0x84ED570", VA = "0x1884EEF70")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x84EF3F0", Offset = "0x84ED9F0", VA = "0x1884EF3F0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84EF0D0", Offset = "0x84ED6D0", VA = "0x1884EF0D0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void NPODCCNCJAJ([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class NNENKJMHNIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8508EE0", Offset = "0x85074E0", VA = "0x188508EE0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x85089B0", Offset = "0x8506FB0", VA = "0x1885089B0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8508E30", Offset = "0x8507430", VA = "0x188508E30")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8508B10", Offset = "0x8507110", VA = "0x188508B10")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void CCONKBFGKGE([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class CLDAIMCJNDE
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84EA720", Offset = "0x84E8D20", VA = "0x1884EA720")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84EA2E0", Offset = "0x84E88E0", VA = "0x1884EA2E0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84EA670", Offset = "0x84E8C70", VA = "0x1884EA670")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x84EA440", Offset = "0x84E8A40", VA = "0x1884EA440")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void PNGIBCGFDFP([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class NINIINCEHPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x85082D0", Offset = "0x85068D0", VA = "0x1885082D0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8507DB0", Offset = "0x85063B0", VA = "0x188507DB0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8508220", Offset = "0x8506820", VA = "0x188508220")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8507F10", Offset = "0x8506510", VA = "0x188507F10")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void NGJNDEHFIFE([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class OCNAHDADJGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8509B20", Offset = "0x8508120", VA = "0x188509B20")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85095F0", Offset = "0x8507BF0", VA = "0x1885095F0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8509A70", Offset = "0x8508070", VA = "0x188509A70")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8509750", Offset = "0x8507D50", VA = "0x188509750")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void EMKDFCABLDL([NoAlias] ushort* NBMKOHKDKFC, [In][NoAlias] float4* LGMOAFBCKML, int MPNCAKFENGE, int MCHFPDKIKIK);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class OBBDCFCIEEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x85094C0", Offset = "0x8507AC0", VA = "0x1885094C0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8509010", Offset = "0x8507610", VA = "0x188509010")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8509410", Offset = "0x8507A10", VA = "0x188509410")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8509170", Offset = "0x8507770", VA = "0x188509170")]
		public unsafe static void JKGEGDFKKNG([NoAlias] ushort* NBMKOHKDKFC, [In][NoAlias] float4* LGMOAFBCKML, int MPNCAKFENGE, int MCHFPDKIKIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort CPMKHALKIGB([In] float4 MDCCBPAHKHC);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class EFAGDIAHPDB
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x84EC980", Offset = "0x84EAF80", VA = "0x1884EC980")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84EC510", Offset = "0x84EAB10", VA = "0x1884EC510")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x84EC8D0", Offset = "0x84EAED0", VA = "0x1884EC8D0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x84EC670", Offset = "0x84EAC70", VA = "0x1884EC670")]
		public static ushort JKGEGDFKKNG([In] float4 MDCCBPAHKHC)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void BMCILAHBGKP([NoAlias] float4* NBMKOHKDKFC, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class MKGBGPJCOCO
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x85052E0", Offset = "0x85038E0", VA = "0x1885052E0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8504E30", Offset = "0x8503430", VA = "0x188504E30")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8505230", Offset = "0x8503830", VA = "0x188505230")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8504F90", Offset = "0x8503590", VA = "0x188504F90")]
		public unsafe static void JKGEGDFKKNG([NoAlias] float4* NBMKOHKDKFC, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void HLCIPDKNJNA([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class LOLKCGDDJID
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8504390", Offset = "0x8502990", VA = "0x188504390")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8503F70", Offset = "0x8502570", VA = "0x188503F70")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x85042E0", Offset = "0x85028E0", VA = "0x1885042E0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85040D0", Offset = "0x85026D0", VA = "0x1885040D0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void OBADIHCANFC([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class FPJODPBCLKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x84EEE40", Offset = "0x84ED440", VA = "0x1884EEE40")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x84EE900", Offset = "0x84ECF00", VA = "0x1884EE900")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x84EED90", Offset = "0x84ED390", VA = "0x1884EED90")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA60", Offset = "0x84ED060", VA = "0x1884EEA60")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void DFCNAFHHDKF([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class FNGHJNEHPMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x84EE7D0", Offset = "0x84ECDD0", VA = "0x1884EE7D0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x84EE290", Offset = "0x84EC890", VA = "0x1884EE290")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x84EE720", Offset = "0x84ECD20", VA = "0x1884EE720")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x84EE3F0", Offset = "0x84EC9F0", VA = "0x1884EE3F0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void PJGMLECOCEK([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class KINHJKHLKBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8502800", Offset = "0x8500E00", VA = "0x188502800")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8502260", Offset = "0x8500860", VA = "0x188502260")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8502750", Offset = "0x8500D50", VA = "0x188502750")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85023C0", Offset = "0x85009C0", VA = "0x1885023C0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void IGGAODMHIPH([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class IEFJGPCJKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84F7DF0", Offset = "0x84F63F0", VA = "0x1884F7DF0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x84F7850", Offset = "0x84F5E50", VA = "0x1884F7850")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x84F7D40", Offset = "0x84F6340", VA = "0x1884F7D40")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84F79B0", Offset = "0x84F5FB0", VA = "0x1884F79B0")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void BOBFLJJBPEH([Out] float4 CENCPMGPALN, ushort NGIFHNNNGLP);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class JNOEDOBMJOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x84FAF80", Offset = "0x84F9580", VA = "0x1884FAF80")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x84FAAD0", Offset = "0x84F90D0", VA = "0x1884FAAD0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x84FAED0", Offset = "0x84F94D0", VA = "0x1884FAED0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x84FAC30", Offset = "0x84F9230", VA = "0x1884FAC30")]
		public static void JKGEGDFKKNG([Out] float4 CENCPMGPALN, ushort NGIFHNNNGLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void EHNKIKDPMAN([NoAlias] float4* NGPCNOLHHCI, [NoAlias] byte* LCLNICEJHBD, [Out] int GNPFHDMNNOJ, [Out] int PHLCMBDKLEL, [NoAlias] float4* MGCNBAEBMBB, [NoAlias] float4* NDMPNNJCMBG, int MPNCAKFENGE, int MCHFPDKIKIK);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class LOBFLFEIALF
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8503E40", Offset = "0x8502440", VA = "0x188503E40")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x85039F0", Offset = "0x8501FF0", VA = "0x1885039F0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8503D90", Offset = "0x8502390", VA = "0x188503D90")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8503B50", Offset = "0x8502150", VA = "0x188503B50")]
		public unsafe static void JKGEGDFKKNG([NoAlias] float4* NGPCNOLHHCI, [NoAlias] byte* LCLNICEJHBD, [Out] int GNPFHDMNNOJ, [Out] int PHLCMBDKLEL, [NoAlias] float4* MGCNBAEBMBB, [NoAlias] float4* NDMPNNJCMBG, int MPNCAKFENGE, int MCHFPDKIKIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void GGNFOKPPJHM([NoAlias] float4* OMOIKLFCELL, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class MCGKBMIFDMA
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8504D00", Offset = "0x8503300", VA = "0x188504D00")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x85047F0", Offset = "0x8502DF0", VA = "0x1885047F0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8504C50", Offset = "0x8503250", VA = "0x188504C50")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8504950", Offset = "0x8502F50", VA = "0x188504950")]
		public unsafe static void JKGEGDFKKNG([NoAlias] float4* OMOIKLFCELL, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void BNEOMDLFNAJ([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class PJJMODEGCGK
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x850B560", Offset = "0x8509B60", VA = "0x18850B560")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x850AFA0", Offset = "0x85095A0", VA = "0x18850AFA0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x850B4B0", Offset = "0x8509AB0", VA = "0x18850B4B0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x850B100", Offset = "0x8509700", VA = "0x18850B100")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void ENDEFGKFHDD([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class BLGOIHNNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84E86E0", Offset = "0x84E6CE0", VA = "0x1884E86E0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x84E8110", Offset = "0x84E6710", VA = "0x1884E8110")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x84E8630", Offset = "0x84E6C30", VA = "0x1884E8630")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x84E8270", Offset = "0x84E6870", VA = "0x1884E8270")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void MKGLPHCMPPM([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class NHIJCANFHNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8507C80", Offset = "0x8506280", VA = "0x188507C80")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x85076C0", Offset = "0x8505CC0", VA = "0x1885076C0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8507BD0", Offset = "0x85061D0", VA = "0x188507BD0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8507820", Offset = "0x8505E20", VA = "0x188507820")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void IKFNNADNIOC([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class EGILGGHBHGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x84ECEF0", Offset = "0x84EB4F0", VA = "0x1884ECEF0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x84ECAB0", Offset = "0x84EB0B0", VA = "0x1884ECAB0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x84ECE40", Offset = "0x84EB440", VA = "0x1884ECE40")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x84ECC10", Offset = "0x84EB210", VA = "0x1884ECC10")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void BGPMIHIHKAK([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class FJGPINKIHPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x84EE160", Offset = "0x84EC760", VA = "0x1884EE160")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x84EDD20", Offset = "0x84EC320", VA = "0x1884EDD20")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x84EE0B0", Offset = "0x84EC6B0", VA = "0x1884EE0B0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x84EDE80", Offset = "0x84EC480", VA = "0x1884EDE80")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int HEPDMBOMAFL([NoAlias] byte* ODMKCKELJFO, [In][NoAlias] int* FOEDMAPFMKP, int LMDENKLHJKA);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class CHNFKKBOCOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x84EA1B0", Offset = "0x84E87B0", VA = "0x1884EA1B0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x84E9D00", Offset = "0x84E8300", VA = "0x1884E9D00")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x84EA100", Offset = "0x84E8700", VA = "0x1884EA100")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x84E9E60", Offset = "0x84E8460", VA = "0x1884E9E60")]
		public unsafe static int JKGEGDFKKNG([NoAlias] byte* ODMKCKELJFO, [In][NoAlias] int* FOEDMAPFMKP, int LMDENKLHJKA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void GPGPIPACAIE([NoAlias] int* OIONPFHADIO, [In][NoAlias] byte* APGILCGGACM, int JLMPMKKMHPL);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class AECMNMOHOHM
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x84E6D90", Offset = "0x84E5390", VA = "0x1884E6D90")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x84E6920", Offset = "0x84E4F20", VA = "0x1884E6920")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x84E6CE0", Offset = "0x84E52E0", VA = "0x1884E6CE0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x84E6A80", Offset = "0x84E5080", VA = "0x1884E6A80")]
		public unsafe static void JKGEGDFKKNG([NoAlias] int* OIONPFHADIO, [In][NoAlias] byte* APGILCGGACM, int JLMPMKKMHPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void BFLANAJODGB([NoAlias] ushort* OIONPFHADIO, [In][NoAlias] byte* APGILCGGACM, int JLMPMKKMHPL);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class NLMAFMBCGPP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8508880", Offset = "0x8506E80", VA = "0x188508880")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8508400", Offset = "0x8506A00", VA = "0x188508400")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x85087D0", Offset = "0x8506DD0", VA = "0x1885087D0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8508560", Offset = "0x8506B60", VA = "0x188508560")]
		public unsafe static void JKGEGDFKKNG([NoAlias] ushort* OIONPFHADIO, [In][NoAlias] byte* APGILCGGACM, int JLMPMKKMHPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void IOEEMPBLNNA([Out] float3 KDFDHHEOIEB, ushort NGIFHNNNGLP);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class JLAPHKBIKEL
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x84FA9A0", Offset = "0x84F8FA0", VA = "0x1884FA9A0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x84FA580", Offset = "0x84F8B80", VA = "0x1884FA580")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x84FA8F0", Offset = "0x84F8EF0", VA = "0x1884FA8F0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x84FA6E0", Offset = "0x84F8CE0", VA = "0x1884FA6E0")]
		public static void JKGEGDFKKNG([Out] float3 KDFDHHEOIEB, ushort NGIFHNNNGLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort KIJDPDCGJIB([In] float3 MDCCBPAHKHC);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class PDEJHNPFGKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x850AE70", Offset = "0x8509470", VA = "0x18850AE70")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x850AA60", Offset = "0x8509060", VA = "0x18850AA60")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x850ADC0", Offset = "0x85093C0", VA = "0x18850ADC0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x850ABC0", Offset = "0x85091C0", VA = "0x18850ABC0")]
		public static ushort JKGEGDFKKNG([In] float3 MDCCBPAHKHC)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker LPCHGFNOGLD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker KJIFIHDNPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int GAELDOPGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int JLMPMKKMHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> MNNAHDCEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> AFNAJNLLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> KDNCCNPNEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> PMCOCPLIFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<JFCHLDDLPIG> GCAMDFBELJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> MCKJHIENILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> IFAGBCNDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 JFGLGIPDJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 AEBGKMDPEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 OGHIFLOKKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 BDGPOIHFPOM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long NHLENLAIIPD;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long MHGJJIIAJBO;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float DFNFCPABCLO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool KNPIDDKIDNM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ACEIOKDFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84F06D0", Offset = "0x84EECD0", VA = "0x1884F06D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HKHGNKHBIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84F28E0", Offset = "0x84F0EE0", VA = "0x1884F28E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84F0270", Offset = "0x84EE870", VA = "0x1884F0270")]
	public void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84F10A0", Offset = "0x84EF6A0", VA = "0x1884F10A0")]
	public static GKDOCEBGLOE EEPJBIPIECL(Allocator EKNOCGFFMAE, KGBENKDOKKC IOADIOBFAEM)
	{
		return default(GKDOCEBGLOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84F1370", Offset = "0x84EF970", VA = "0x1884F1370")]
	public static GKDOCEBGLOE EEPJBIPIECL(Allocator EKNOCGFFMAE, NativeArray<float3> JHPGCKNNIJG, NativeArray<float3> BKLOAGCOPFL, NativeArray<float2> PJPKDAPLGBK, NativeArray<float4> NDMPNNJCMBG, bool IJGKJPPBJKD, NativeArray<float4> CCIKKGCGEEM, NativeArray<int> FOEDMAPFMKP, int GAELDOPGMHO, int NIKHFKNLMMN, int JLMPMKKMHPL, int MPNCAKFENGE)
	{
		return default(GKDOCEBGLOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84F6620", Offset = "0x84F4C20", VA = "0x1884F6620")]
	public void ONFLJNMAFMO(KGBENKDOKKC CENCPMGPALN, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84F51E0", Offset = "0x84F37E0", VA = "0x1884F51E0")]
	public long MMJILDBGJFP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84F25B0", Offset = "0x84F0BB0", VA = "0x1884F25B0")]
	public long HBJJFILCHJA(KGBENKDOKKC.GHJDECIPEEC IENFMLICFPK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84F4480", Offset = "0x84F2A80", VA = "0x1884F4480")]
	private void LKNCAMJABCH(int KOOADCCLMIG, int MCHFPDKIKIK, Allocator EKNOCGFFMAE, bool DCBFFDICCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84F4710", Offset = "0x84F2D10", VA = "0x1884F4710")]
	private void LONJMFMGJEC(NativeArray<float3> DPHNEGIHDHH, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x84F4690", Offset = "0x84F2C90", VA = "0x1884F4690")]
	[BurstCompile]
	private unsafe static void LONJMFMGJEC([NoAlias] float3* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x84F5160", Offset = "0x84F3760", VA = "0x1884F5160")]
	[BurstCompile]
	private unsafe static void MJLLIFBMBCB([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84F35D0", Offset = "0x84F1BD0", VA = "0x1884F35D0")]
	[BurstCompile]
	private unsafe static void JHECKNGODKC([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84F21A0", Offset = "0x84F07A0", VA = "0x1884F21A0")]
	[BurstCompile]
	private unsafe static void GCBIIBPENOM([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84F4120", Offset = "0x84F2720", VA = "0x1884F4120")]
	[BurstCompile]
	private unsafe static void LHJGABBCINA([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84F2220", Offset = "0x84F0820", VA = "0x1884F2220")]
	[BurstCompile]
	private unsafe static void GDMINEFBLFM([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84F1DC0", Offset = "0x84F03C0", VA = "0x1884F1DC0")]
	private void FMMOBEGCPCM(NativeArray<float3> JHPGCKNNIJG, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84F1D30", Offset = "0x84F0330", VA = "0x1884F1D30")]
	[BurstCompile]
	private unsafe static void FMMOBEGCPCM([NoAlias] ushort* DPHNEGIHDHH, [Out] float3 LIFIHEMKAMI, [Out] float3 AEBGKMDPEBA, [In][NoAlias] float3* JHPGCKNNIJG, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84F2DC0", Offset = "0x84F13C0", VA = "0x1884F2DC0")]
	private void IBBOBCOPPFB(NativeArray<float3> BKLOAGCOPFL, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84F2B70", Offset = "0x84F1170", VA = "0x1884F2B70")]
	[BurstCompile]
	private unsafe static void IBBOBCOPPFB([NoAlias] ushort* GKJBPDPDCGO, [In][NoAlias] float3* BKLOAGCOPFL, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84F4060", Offset = "0x84F2660", VA = "0x1884F4060")]
	private void LCEHOJNEMBO(NativeArray<float3> MDHFPPIOCEB, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84F3E10", Offset = "0x84F2410", VA = "0x1884F3E10")]
	[BurstCompile]
	private unsafe static void LCEHOJNEMBO([NoAlias] float3* MDHFPPIOCEB, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84F5F30", Offset = "0x84F4530", VA = "0x1884F5F30")]
	[BurstCompile]
	private unsafe static void OFMHDLPKPFK([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84EF8F0", Offset = "0x84EDEF0", VA = "0x1884EF8F0")]
	[BurstCompile]
	private unsafe static void AHEALHGHEIJ([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84F1EE0", Offset = "0x84F04E0", VA = "0x1884F1EE0")]
	[BurstCompile]
	private unsafe static void FMOKJFGGLAP([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84F2620", Offset = "0x84F0C20", VA = "0x1884F2620")]
	[BurstCompile]
	private unsafe static void HCECJCBGJCM([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84F4620", Offset = "0x84F2C20", VA = "0x1884F4620")]
	[BurstCompile]
	private unsafe static void LMHNKHLJBNC([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84F22A0", Offset = "0x84F08A0", VA = "0x1884F22A0")]
	private void GGIMLKMHBAN(NativeArray<float2> PJPKDAPLGBK, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84F23C0", Offset = "0x84F09C0", VA = "0x1884F23C0")]
	[BurstCompile]
	private unsafe static void GGIMLKMHBAN([NoAlias] uint* HHBAHAHPJKB, [Out] float2 LFPBPCFABAM, [Out] float2 BDGPOIHFPOM, [In][NoAlias] float2* PJPKDAPLGBK, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84F50E0", Offset = "0x84F36E0", VA = "0x1884F50E0")]
	[BurstCompile]
	private static void MHPANPPBBCN([Out] float2 KDFDHHEOIEB, uint NGIFHNNNGLP, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84F36D0", Offset = "0x84F1CD0", VA = "0x1884F36D0")]
	private void JPCOGLCJFCD(NativeArray<float2> HHBAHAHPJKB, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84F3650", Offset = "0x84F1C50", VA = "0x1884F3650")]
	[BurstCompile]
	private unsafe static void JPCOGLCJFCD([NoAlias] float2* HHBAHAHPJKB, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84F1020", Offset = "0x84EF620", VA = "0x1884F1020")]
	[BurstCompile]
	private unsafe static void EAKDGHCONJF([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84F58C0", Offset = "0x84F3EC0", VA = "0x1884F58C0")]
	[BurstCompile]
	private unsafe static void NNGHNFCFFKK([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84F4830", Offset = "0x84F2E30", VA = "0x1884F4830")]
	[BurstCompile]
	private unsafe static void LPMILCHEBGI([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84F2920", Offset = "0x84F0F20", VA = "0x1884F2920")]
	[BurstCompile]
	private unsafe static void HIBLAIKANGD([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84F01F0", Offset = "0x84EE7F0", VA = "0x1884F01F0")]
	[BurstCompile]
	private unsafe static void CCAEFMCFGCN([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84F1C20", Offset = "0x84F0220", VA = "0x1884F1C20")]
	private void FMBBFLPJJJF(NativeArray<float4> CCIKKGCGEEM, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84F1BA0", Offset = "0x84F01A0", VA = "0x1884F1BA0")]
	[BurstCompile]
	private unsafe static void FMBBFLPJJJF([NoAlias] ushort* NBMKOHKDKFC, [In][NoAlias] float4* LGMOAFBCKML, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84F33B0", Offset = "0x84F19B0", VA = "0x1884F33B0")]
	[BurstCompile]
	private static ushort IOFFLBDNCOM([In] float4 MDCCBPAHKHC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84F24C0", Offset = "0x84F0AC0", VA = "0x1884F24C0")]
	private void GPBDCHOJKNP(NativeArray<float4> NBMKOHKDKFC, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84F2450", Offset = "0x84F0A50", VA = "0x1884F2450")]
	[BurstCompile]
	private unsafe static void GPBDCHOJKNP([NoAlias] float4* NBMKOHKDKFC, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84F1F50", Offset = "0x84F0550", VA = "0x1884F1F50")]
	[BurstCompile]
	private unsafe static void GAFMANNJHHP([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84F5EC0", Offset = "0x84F44C0", VA = "0x1884F5EC0")]
	[BurstCompile]
	private unsafe static void ODAIHPHLGIM([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84F5540", Offset = "0x84F3B40", VA = "0x1884F5540")]
	[BurstCompile]
	private unsafe static void NENFBAGKCFN([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84F45B0", Offset = "0x84F2BB0", VA = "0x1884F45B0")]
	[BurstCompile]
	private unsafe static void LLEDMEFEGOB([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84F3970", Offset = "0x84F1F70", VA = "0x1884F3970")]
	[BurstCompile]
	private unsafe static void KCFHKNBOAOC([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84F52E0", Offset = "0x84F38E0", VA = "0x1884F52E0")]
	[BurstCompile]
	private static void NBBHEPMCDFD([Out] float4 CENCPMGPALN, ushort NGIFHNNNGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84F0B80", Offset = "0x84EF180", VA = "0x1884F0B80")]
	private void EAAADIDCEOL(Allocator EKNOCGFFMAE, NativeArray<float4> NDMPNNJCMBG, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84F0AF0", Offset = "0x84EF0F0", VA = "0x1884F0AF0")]
	[BurstCompile]
	private unsafe static void EAAADIDCEOL([NoAlias] float4* NGPCNOLHHCI, [NoAlias] byte* LCLNICEJHBD, [Out] int GNPFHDMNNOJ, [Out] int PHLCMBDKLEL, [NoAlias] float4* MGCNBAEBMBB, [NoAlias] float4* NDMPNNJCMBG, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84F2EA0", Offset = "0x84F14A0", VA = "0x1884F2EA0")]
	private static void IHIMNHHHPKI(NativeArray<float4> OMOIKLFCELL, NativeArray<JFCHLDDLPIG> ODLDCBBJIMN, NativeArray<byte> HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84F2FD0", Offset = "0x84F15D0", VA = "0x1884F2FD0")]
	[BurstCompile]
	private unsafe static void IHIMNHHHPKI([NoAlias] float4* OMOIKLFCELL, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84F18D0", Offset = "0x84EFED0", VA = "0x1884F18D0")]
	[BurstCompile]
	private unsafe static void FHPGLMBLNOD([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84F0030", Offset = "0x84EE630", VA = "0x1884F0030")]
	[BurstCompile]
	private unsafe static void BNBJMCJHMMB([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84F3330", Offset = "0x84F1930", VA = "0x1884F3330")]
	[BurstCompile]
	private unsafe static void IMFPGKOKNLM([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84F5650", Offset = "0x84F3C50", VA = "0x1884F5650")]
	[BurstCompile]
	private unsafe static void NNDFPGOGBIJ([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84EFDC0", Offset = "0x84EE3C0", VA = "0x1884EFDC0")]
	[BurstCompile]
	private unsafe static void BFDPFFJOJBJ([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84F05D0", Offset = "0x84EEBD0", VA = "0x1884F05D0")]
	private void DBCDAJOCNKL(Allocator EKNOCGFFMAE, NativeArray<int> FOEDMAPFMKP, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84F59B0", Offset = "0x84F3FB0", VA = "0x1884F59B0")]
	private static NativeArray<byte> OAODOEKGAMI(Allocator EKNOCGFFMAE, NativeArray<int> FOEDMAPFMKP, int LMDENKLHJKA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84F5940", Offset = "0x84F3F40", VA = "0x1884F5940")]
	[BurstCompile]
	private unsafe static int OAODOEKGAMI([NoAlias] byte* ODMKCKELJFO, [In][NoAlias] int* FOEDMAPFMKP, int LMDENKLHJKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84F48B0", Offset = "0x84F2EB0", VA = "0x1884F48B0")]
	private static void MBIOPEINGMP(NativeArray<int> OIONPFHADIO, NativeArray<byte> APGILCGGACM, int JLMPMKKMHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84F49A0", Offset = "0x84F2FA0", VA = "0x1884F49A0")]
	[BurstCompile]
	private unsafe static void MBIOPEINGMP([NoAlias] int* OIONPFHADIO, [In][NoAlias] byte* APGILCGGACM, int JLMPMKKMHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84F6B40", Offset = "0x84F5140", VA = "0x1884F6B40")]
	[BurstCompile]
	private unsafe static void PJIHBGDCHPM([NoAlias] ushort* OIONPFHADIO, [In][NoAlias] byte* APGILCGGACM, int JLMPMKKMHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x84F0390", Offset = "0x84EE990", VA = "0x1884F0390")]
	[BurstCompile]
	private static void CMGBFFCJGPF([Out] float3 KDFDHHEOIEB, ushort NGIFHNNNGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C90", Offset = "0x84F4290", VA = "0x1884F5C90")]
	[BurstCompile]
	private static ushort OCMHPGOJLAH([In] float3 MDCCBPAHKHC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84E49E0", Offset = "0x84E2FE0", VA = "0x1884E49E0")]
	[BurstCompile]
	public unsafe static void IMALPKDCGLG([NoAlias] float3* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84F5340", Offset = "0x84F3940", VA = "0x1884F5340")]
	[BurstCompile]
	public unsafe static void NEAJNKEKIFC([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84F4EF0", Offset = "0x84F34F0", VA = "0x1884F4EF0")]
	[BurstCompile]
	public unsafe static void MGBGKGOMLGP([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84F3270", Offset = "0x84F1870", VA = "0x1884F3270")]
	[BurstCompile]
	public unsafe static void ILOOFOIBKJC([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84F3270", Offset = "0x84F1870", VA = "0x1884F3270")]
	[BurstCompile]
	public unsafe static void LMHHEMODOGJ([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84F3A70", Offset = "0x84F2070", VA = "0x1884F3A70")]
	[BurstCompile]
	public unsafe static void KIAEALFCMAN([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* JHPGCKNNIJG, int GAELDOPGMHO, [In] float3 JFGLGIPDJPA, [In] float3 AEBGKMDPEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84E4E80", Offset = "0x84E3480", VA = "0x1884E4E80")]
	[BurstCompile]
	public unsafe static void MBMGCJIDNHP([NoAlias] ushort* DPHNEGIHDHH, [Out] float3 LIFIHEMKAMI, [Out] float3 AEBGKMDPEBA, [In][NoAlias] float3* JHPGCKNNIJG, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84F0710", Offset = "0x84EED10", VA = "0x1884F0710")]
	[BurstCompile]
	public unsafe static void DFGEMPCAJMD([NoAlias] ushort* GKJBPDPDCGO, [In][NoAlias] float3* BKLOAGCOPFL, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84F4C50", Offset = "0x84F3250", VA = "0x1884F4C50")]
	[BurstCompile]
	public unsafe static void MFNMGHDBHBP([NoAlias] float3* MDHFPPIOCEB, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84F2690", Offset = "0x84F0C90", VA = "0x1884F2690")]
	[BurstCompile]
	public unsafe static void HDAJCJKKNOM([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84EF5D0", Offset = "0x84EDBD0", VA = "0x1884EF5D0")]
	[BurstCompile]
	public unsafe static void ABBMKPJNECJ([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84F00B0", Offset = "0x84EE6B0", VA = "0x1884F00B0")]
	[BurstCompile]
	public unsafe static void BODNJBEEAOP([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84F41A0", Offset = "0x84F27A0", VA = "0x1884F41A0")]
	[BurstCompile]
	public unsafe static void LJGFOELGPOG([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84F1950", Offset = "0x84EFF50", VA = "0x1884F1950")]
	[BurstCompile]
	public unsafe static void FJOBDODAFLA([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* BKLOAGCOPFL, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x84E3920", Offset = "0x84E1F20", VA = "0x1884E3920")]
	[BurstCompile]
	public unsafe static void BKHCMDOOHPK([NoAlias] uint* HHBAHAHPJKB, [Out] float2 LFPBPCFABAM, [Out] float2 BDGPOIHFPOM, [In][NoAlias] float2* PJPKDAPLGBK, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84F3930", Offset = "0x84F1F30", VA = "0x1884F3930")]
	[BurstCompile]
	public static void KBDFKCBAJFO([Out] float2 KDFDHHEOIEB, uint NGIFHNNNGLP, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x84F17C0", Offset = "0x84EFDC0", VA = "0x1884F17C0")]
	[BurstCompile]
	public unsafe static void EJNOPOEEDFK([NoAlias] float2* HHBAHAHPJKB, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84F37F0", Offset = "0x84F1DF0", VA = "0x1884F37F0")]
	[BurstCompile]
	public unsafe static void KAOHHHOHKCB([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84F6BB0", Offset = "0x84F51B0", VA = "0x1884F6BB0")]
	[BurstCompile]
	public unsafe static void PMKDBBPNMEM([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84F3050", Offset = "0x84F1650", VA = "0x1884F3050")]
	[BurstCompile]
	public unsafe static void IIKCMDOKNNI([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84F09C0", Offset = "0x84EEFC0", VA = "0x1884F09C0")]
	[BurstCompile]
	public unsafe static void DNMNHALLOBI([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84F4FB0", Offset = "0x84F35B0", VA = "0x1884F4FB0")]
	[BurstCompile]
	public unsafe static void MHDGIGMIAFO([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [NoAlias] uint* PJPKDAPLGBK, int GAELDOPGMHO, [In] float2 OGHIFLOKKEP, [In] float2 BDGPOIHFPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84F6180", Offset = "0x84F4780", VA = "0x1884F6180")]
	[BurstCompile]
	public unsafe static void OGFDGOOIGNG([NoAlias] ushort* NBMKOHKDKFC, [In][NoAlias] float4* LGMOAFBCKML, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84F39E0", Offset = "0x84F1FE0", VA = "0x1884F39E0")]
	[BurstCompile]
	public static ushort KHDCOEEBCOO([In] float4 MDCCBPAHKHC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84F1AC0", Offset = "0x84F00C0", VA = "0x1884F1AC0")]
	[BurstCompile]
	public unsafe static void FLNGJHLPHKM([NoAlias] float4* NBMKOHKDKFC, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84EFAD0", Offset = "0x84EE0D0", VA = "0x1884EFAD0")]
	[BurstCompile]
	public unsafe static void AMKHNNMBFFP([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x84EF960", Offset = "0x84EDF60", VA = "0x1884EF960")]
	[BurstCompile]
	public unsafe static void AHKKBOEAEGM([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84F4310", Offset = "0x84F2910", VA = "0x1884F4310")]
	[BurstCompile]
	public unsafe static void LKDOGJEPCKE([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84F29A0", Offset = "0x84F0FA0", VA = "0x1884F29A0")]
	[BurstCompile]
	public unsafe static void HJAFOAKKABF([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84F3400", Offset = "0x84F1A00", VA = "0x1884F3400")]
	[BurstCompile]
	public unsafe static void JBIOOPNACEC([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] ushort* CCIKKGCGEEM, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84F6A80", Offset = "0x84F5080", VA = "0x1884F6A80")]
	[BurstCompile]
	public static void PIMPMGJOAGD([Out] float4 CENCPMGPALN, ushort NGIFHNNNGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84E3E90", Offset = "0x84E2490", VA = "0x1884E3E90")]
	[BurstCompile]
	public unsafe static void FJFIPIBHICC([NoAlias] float4* NGPCNOLHHCI, [NoAlias] byte* LCLNICEJHBD, [Out] int GNPFHDMNNOJ, [Out] int PHLCMBDKLEL, [NoAlias] float4* MGCNBAEBMBB, [NoAlias] float4* NDMPNNJCMBG, int MPNCAKFENGE, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x84F5400", Offset = "0x84F3A00", VA = "0x1884F5400")]
	[BurstCompile]
	public unsafe static void NEDJNEAGELM([NoAlias] float4* OMOIKLFCELL, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84F6440", Offset = "0x84F4A40", VA = "0x1884F6440")]
	[BurstCompile]
	public unsafe static void OLJNOLOEJKF([NoAlias] KGBENKDOKKC.ECINIIMNPBG* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84EF710", Offset = "0x84EDD10", VA = "0x1884EF710")]
	[BurstCompile]
	public unsafe static void ABEPGLEFCIB([NoAlias] KGBENKDOKKC.LAJEAPGMHKM* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84F6260", Offset = "0x84F4860", VA = "0x1884F6260")]
	[BurstCompile]
	public unsafe static void OGHBPDECGLB([NoAlias] KGBENKDOKKC.LDJOKECMKMJ* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84F3BD0", Offset = "0x84F21D0", VA = "0x1884F3BD0")]
	[BurstCompile]
	public unsafe static void KMILLNPJHHH([NoAlias] KGBENKDOKKC.KCGIACMKGFH* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84F4A10", Offset = "0x84F3010", VA = "0x1884F4A10")]
	[BurstCompile]
	public unsafe static void MDENNHOBMJE([NoAlias] KGBENKDOKKC.HOPDLMOOBGO* DPHNEGIHDHH, [In][NoAlias] JFCHLDDLPIG* ODLDCBBJIMN, [In][NoAlias] byte* HLBBPLAPKGK, int GAELDOPGMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84F6CF0", Offset = "0x84F52F0", VA = "0x1884F6CF0")]
	[BurstCompile]
	public unsafe static int POACLDMAGDG([NoAlias] byte* ODMKCKELJFO, [In][NoAlias] int* FOEDMAPFMKP, int LMDENKLHJKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84F55B0", Offset = "0x84F3BB0", VA = "0x1884F55B0")]
	[BurstCompile]
	public unsafe static void NJOHJGAIPGK([NoAlias] int* OIONPFHADIO, [In][NoAlias] byte* APGILCGGACM, int JLMPMKKMHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84F69E0", Offset = "0x84F4FE0", VA = "0x1884F69E0")]
	[BurstCompile]
	public unsafe static void ONMKFLLMOOI([NoAlias] ushort* OIONPFHADIO, [In][NoAlias] byte* APGILCGGACM, int JLMPMKKMHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84E5740", Offset = "0x84E3D40", VA = "0x1884E5740")]
	[BurstCompile]
	public static void OADFHNCCHKI([Out] float3 KDFDHHEOIEB, ushort NGIFHNNNGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84E43B0", Offset = "0x84E29B0", VA = "0x1884E43B0")]
	[BurstCompile]
	public static ushort GCJFGPKHKDG([In] float3 MDCCBPAHKHC)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class KGBENKDOKKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum GHJDECIPEEC
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
	public enum ACMJFNCMBDE
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
	public struct CJEEIMCDJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GHJDECIPEEC IENFMLICFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool MCOHOGCJFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int OAOPOBFDIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] IGDMHPMPGLN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct DMMMJAMOBHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 AANGPKCDGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 NNMAALGIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 KDCHPNLBIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 HDCDEMCMEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 GCAMDFBELJG;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] IGDMHPMPGLN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct ECINIIMNPBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 AANGPKCDGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 NNMAALGIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 KDCHPNLBIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 HDCDEMCMEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 GCAMDFBELJG;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] IGDMHPMPGLN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct LAJEAPGMHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 AANGPKCDGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint NNMAALGIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint KDCHPNLBIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 HDCDEMCMEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 GCAMDFBELJG;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] IGDMHPMPGLN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct LDJOKECMKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 AANGPKCDGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint NNMAALGIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint KDCHPNLBIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 HDCDEMCMEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 GCAMDFBELJG;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] IGDMHPMPGLN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct KCGIACMKGFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 AANGPKCDGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint GIDFLKIFKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 HDCDEMCMEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint CMDPFPCFLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint HBEBNIGOHHM;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] IGDMHPMPGLN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct HOPDLMOOBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public KCFOLGMJIJP.MJAMEJDFIEO KBCJIDFAHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint GIDFLKIFKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 HDCDEMCMEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint CMDPFPCFLHI;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] IGDMHPMPGLN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int PFDFFMJMKDM(float POMPNNDHCKO);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class EAGAPANDAPE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x84EC210", Offset = "0x84EA810", VA = "0x1884EC210")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x84EBD90", Offset = "0x84EA390", VA = "0x1884EBD90")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x84EC160", Offset = "0x84EA760", VA = "0x1884EC160")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x84EBEF0", Offset = "0x84EA4F0", VA = "0x1884EBEF0")]
		public static int JKGEGDFKKNG(float POMPNNDHCKO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint JCPAKGDPHOB([In] float4 EFGJHINBPCN);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class DHEFCAHBLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x84EBAA0", Offset = "0x84EA0A0", VA = "0x1884EBAA0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x84EB550", Offset = "0x84E9B50", VA = "0x1884EB550")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x84EB9F0", Offset = "0x84E9FF0", VA = "0x1884EB9F0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x84EB6B0", Offset = "0x84E9CB0", VA = "0x1884EB6B0")]
		public static uint JKGEGDFKKNG([In] float4 EFGJHINBPCN)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint LNFKLNAAKDI([In] float3 EFGJHINBPCN);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class CPGOMBHMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x84EACE0", Offset = "0x84E92E0", VA = "0x1884EACE0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x84EA850", Offset = "0x84E8E50", VA = "0x1884EA850")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x84EAC30", Offset = "0x84E9230", VA = "0x1884EAC30")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x84EA9B0", Offset = "0x84E8FB0", VA = "0x1884EA9B0")]
		public static uint JKGEGDFKKNG([In] float3 EFGJHINBPCN)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void INDBMDMHLPJ([NoAlias] LAJEAPGMHKM* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class LJKLBOPBMJC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8503710", Offset = "0x8501D10", VA = "0x188503710")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x85032C0", Offset = "0x85018C0", VA = "0x1885032C0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8503660", Offset = "0x8501C60", VA = "0x188503660")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8503420", Offset = "0x8501A20", VA = "0x188503420")]
		public unsafe static void JKGEGDFKKNG([NoAlias] LAJEAPGMHKM* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void NNNKIPLGBFM([NoAlias] LDJOKECMKMJ* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class FDLHHCGOGFH
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x84EDBF0", Offset = "0x84EC1F0", VA = "0x1884EDBF0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x84ED7A0", Offset = "0x84EBDA0", VA = "0x1884ED7A0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x84EDB40", Offset = "0x84EC140", VA = "0x1884EDB40")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x84ED900", Offset = "0x84EBF00", VA = "0x1884ED900")]
		public unsafe static void JKGEGDFKKNG([NoAlias] LDJOKECMKMJ* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void KEPKKHGDAPF([NoAlias] KCGIACMKGFH* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class BOPJOJIHHOH
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x84E8F10", Offset = "0x84E7510", VA = "0x1884E8F10")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x84E8910", Offset = "0x84E6F10", VA = "0x1884E8910")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x84E8E60", Offset = "0x84E7460", VA = "0x1884E8E60")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x84E8A70", Offset = "0x84E7070", VA = "0x1884E8A70")]
		public unsafe static void JKGEGDFKKNG([NoAlias] KCGIACMKGFH* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void HPMHGBKFDKF([NoAlias] HOPDLMOOBGO* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG, [Out] float3 HELECJGBDNO, [Out] float3 EACIJPKFPOE);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class OMBBGEMOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x850A930", Offset = "0x8508F30", VA = "0x18850A930")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x850A1C0", Offset = "0x85087C0", VA = "0x18850A1C0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x850A880", Offset = "0x8508E80", VA = "0x18850A880")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x850A320", Offset = "0x8508920", VA = "0x18850A320")]
		public unsafe static void JKGEGDFKKNG([NoAlias] HOPDLMOOBGO* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG, [Out] float3 HELECJGBDNO, [Out] float3 EACIJPKFPOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int NBAAEEFEOJL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> KMOFPFFJFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> MICGNOBMLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> PKHILEILDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> NKKLIONHANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> BBBDHIHCGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> JEAGFLJKHDB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] LEKPBECFFPG;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool DIDJDKNIPNC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static CJEEIMCDJME[] AGMLGDJMKBG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool ACEIOKDFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x84FD160", Offset = "0x84FB760", VA = "0x1884FD160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x84FC050", Offset = "0x84FA650", VA = "0x1884FC050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EDNLPJDMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x84FB310", Offset = "0x84F9910", VA = "0x1884FB310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HKHGNKHBIFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x84FE180", Offset = "0x84FC780", VA = "0x1884FE180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x84FDFD0", Offset = "0x84FC5D0", VA = "0x1884FDFD0")]
	public static ACMJFNCMBDE GLGJGFGFHIA(GHJDECIPEEC IENFMLICFPK)
	{
		return default(ACMJFNCMBDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x84FB230", Offset = "0x84F9830", VA = "0x1884FB230")]
	public static void AJOKLOCBCJM(ACMJFNCMBDE HFCCLNFKOBM, Material JKDFAJLFBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x84FD1A0", Offset = "0x84FB7A0", VA = "0x1884FD1A0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x84FFA20", Offset = "0x84FE020", VA = "0x1884FFA20")]
	public void LKNCAMJABCH(int KOOADCCLMIG, int MCHFPDKIKIK, Allocator EKNOCGFFMAE, bool CGFFKCEDGMO, bool DCBFFDICCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x84FFF50", Offset = "0x84FE550", VA = "0x1884FFF50")]
	public void MBKJDMPGLMF(int KOOADCCLMIG, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x84FE500", Offset = "0x84FCB00", VA = "0x1884FE500", Slot = "6")]
	public bool INIACLLMLAA(Mesh LJNJDNJBNIE, bool PHEAOKACDFL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8500BD0", Offset = "0x84FF1D0", VA = "0x188500BD0")]
	public bool NJAJLCAIFOD(Mesh LJNJDNJBNIE, bool PHEAOKACDFL, bool GMLGENLNDJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x84FE520", Offset = "0x84FCB20", VA = "0x1884FE520")]
	public bool JCFIEPOOFHF(Mesh LJNJDNJBNIE, KGBENKDOKKC GEEKJCLDNFB, bool PHEAOKACDFL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x84FE2A0", Offset = "0x84FC8A0", VA = "0x1884FE2A0")]
	public bool IEBMJHPCEKM(Mesh LJNJDNJBNIE, KGBENKDOKKC GEEKJCLDNFB, GHJDECIPEEC IENFMLICFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8501240", Offset = "0x84FF840", VA = "0x188501240")]
	private void PBPBPBDFMFH(Mesh LJNJDNJBNIE, KGBENKDOKKC GEEKJCLDNFB, bool GMLGENLNDJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x85019D0", Offset = "0x84FFFD0", VA = "0x1885019D0")]
	public void PBPBPBDFMFH(NativeArray<ushort> GMBAPAGOKJI, NativeArray<KCGIACMKGFH> ODNMFDDOBLP, Mesh LJNJDNJBNIE, KGBENKDOKKC GEEKJCLDNFB, bool GMLGENLNDJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x84FC720", Offset = "0x84FAD20", VA = "0x1884FC720")]
	public void DCLDKAOECPG(Mesh LJNJDNJBNIE, bool GMLGENLNDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x84FE4B0", Offset = "0x84FCAB0", VA = "0x1884FE4B0")]
	[BurstCompile]
	public static int IFANJCMFEFM(float POMPNNDHCKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x84FE460", Offset = "0x84FCA60", VA = "0x1884FE460")]
	[BurstCompile]
	public static uint IFANJCMFEFM([In] float4 EFGJHINBPCN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x84FE410", Offset = "0x84FCA10", VA = "0x1884FE410")]
	[BurstCompile]
	public static uint IFANJCMFEFM([In] float3 EFGJHINBPCN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8500030", Offset = "0x84FE630", VA = "0x188500030")]
	public void MDDEOCLDNOC(Mesh LJNJDNJBNIE, bool GMLGENLNDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8501CE0", Offset = "0x85002E0", VA = "0x188501CE0")]
	[BurstCompile]
	private unsafe static void PJEIEBFODLO([NoAlias] LAJEAPGMHKM* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x84FC090", Offset = "0x84FA690", VA = "0x1884FC090")]
	public void CIMBMBKFNAN(Mesh LJNJDNJBNIE, bool GMLGENLNDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x84FD2B0", Offset = "0x84FB8B0", VA = "0x1884FD2B0")]
	[BurstCompile]
	private unsafe static void FIOMOLOOLKC([NoAlias] LDJOKECMKMJ* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x84FEA20", Offset = "0x84FD020", VA = "0x1884FEA20")]
	public void JEOEHCENGJH(Mesh LJNJDNJBNIE, bool GMLGENLNDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x84FEDF0", Offset = "0x84FD3F0", VA = "0x1884FEDF0")]
	public void JEOEHCENGJH(NativeArray<ushort> MIEKPHIDELH, NativeArray<KCGIACMKGFH> AFAAEBBPFPC, Mesh LJNJDNJBNIE, bool GMLGENLNDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x84FF3D0", Offset = "0x84FD9D0", VA = "0x1884FF3D0")]
	[BurstCompile]
	public unsafe static void LGDDPBLIGBH([NoAlias] KCGIACMKGFH* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x84FB350", Offset = "0x84F9950", VA = "0x1884FB350")]
	public void BCGNKBIMEJN(Mesh LJNJDNJBNIE, bool GMLGENLNDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x85009A0", Offset = "0x84FEFA0", VA = "0x1885009A0")]
	[BurstCompile]
	private unsafe static void MGCAFCPCOAM([NoAlias] HOPDLMOOBGO* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG, [Out] float3 HELECJGBDNO, [Out] float3 EACIJPKFPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x84FF340", Offset = "0x84FD940", VA = "0x1884FF340")]
	public void KPKEGJBMCJE(Mesh LJNJDNJBNIE, GHJDECIPEEC IENFMLICFPK, bool GMLGENLNDJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8500FD0", Offset = "0x84FF5D0", VA = "0x188500FD0")]
	public void OBHFLNAIMDF(KGBENKDOKKC LJNJDNJBNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x84FDED0", Offset = "0x84FC4D0", VA = "0x1884FDED0")]
	public void GHHAANCCGLH(KGBENKDOKKC LBHNPIBFMBH, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8500A20", Offset = "0x84FF020", VA = "0x188500A20")]
	public long MMJILDBGJFP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8500B70", Offset = "0x84FF170", VA = "0x188500B70")]
	public static long MMJILDBGJFP(int KPCHCAELKFA, int CAFFBLLJLOC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x84FE0E0", Offset = "0x84FC6E0", VA = "0x1884FE0E0")]
	public static long HBJJFILCHJA(int KPCHCAELKFA, int CAFFBLLJLOC, GHJDECIPEEC IENFMLICFPK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x84FE020", Offset = "0x84FC620", VA = "0x1884FE020")]
	public long HBJJFILCHJA(GHJDECIPEEC IENFMLICFPK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x84FFFD0", Offset = "0x84FE5D0", VA = "0x1884FFFD0")]
	public void MBLNMAFLBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x84FF450", Offset = "0x84FDA50", VA = "0x1884FF450")]
	public static void LJBEMGKMDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x84FD330", Offset = "0x84FB930", VA = "0x1884FD330")]
	public GHJDECIPEEC FJKEOHJLPBF()
	{
		return default(GHJDECIPEEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8501D60", Offset = "0x8500360", VA = "0x188501D60")]
	public static (int, int) PKMFIFPGKAA(Mesh LJNJDNJBNIE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x84FE1C0", Offset = "0x84FC7C0", VA = "0x1884FE1C0")]
	public static int HFGPOKDNJBL(VertexAttributeDescriptor[] BBKFJBMHGLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x84FF1A0", Offset = "0x84FD7A0", VA = "0x1884FF1A0")]
	public static long JGNLIGDDJNB(Mesh LJNJDNJBNIE, int AFKACEIEFDL, int DPFMGCFBIIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x84FF210", Offset = "0x84FD810", VA = "0x1884FF210")]
	public static long JGNLIGDDJNB(Mesh LJNJDNJBNIE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KGBENKDOKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8500770", Offset = "0x84FED70", VA = "0x188500770")]
	[BurstCompile]
	public static int MFFPCPBDDEA(float POMPNNDHCKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8500810", Offset = "0x84FEE10", VA = "0x188500810")]
	[BurstCompile]
	public static uint MFFPCPBDDEA([In] float4 EFGJHINBPCN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x85006C0", Offset = "0x84FECC0", VA = "0x1885006C0")]
	[BurstCompile]
	public static uint MFFPCPBDDEA([In] float3 EFGJHINBPCN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x84FBC90", Offset = "0x84FA290", VA = "0x1884FBC90")]
	[BurstCompile]
	public unsafe static void CAEJBMDLGGL([NoAlias] LAJEAPGMHKM* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x84FDA80", Offset = "0x84FC080", VA = "0x1884FDA80")]
	[BurstCompile]
	public unsafe static void FNLIFPFIEDD([NoAlias] LDJOKECMKMJ* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x84FBA90", Offset = "0x84FA090", VA = "0x1884FBA90")]
	[BurstCompile]
	public unsafe static void BPFCDLNGJFJ([NoAlias] KCGIACMKGFH* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x84FFC10", Offset = "0x84FE210", VA = "0x1884FFC10")]
	[BurstCompile]
	public unsafe static void LPGKOCNHOKH([NoAlias] HOPDLMOOBGO* DPHNEGIHDHH, int GAELDOPGMHO, [In][NoAlias] float3* EAJHPIDHJNB, [In][NoAlias] float3* AFNAJNLLECP, [In][NoAlias] float4* KDNCCNPNEMO, [In][NoAlias] float2* PMCOCPLIFOL, [In][NoAlias] float4* GCAMDFBELJG, [Out] float3 HELECJGBDNO, [Out] float3 EACIJPKFPOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BDPLLEDHDEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int NLNGLADGNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 JBPLNDJKLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion MMMLGJECMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 OCBEACHHGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int OHJGNAFEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int JIIKHGGPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int GBACDPLFFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float BALIPDKKMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 FHCKALKBBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool PKOFEHGBPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public EBALBEPPDDF JJGFEIHFODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 NACALGMGBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float FCNCOLEHDFG;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class NFHBMFGADGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static KFHJFFDPCKK CDJCOPPIOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<BDPLLEDHDEK> IGNHFMAPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<IKBGEGNCPKM> DIKAMCBIJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<DPMIKCACNHG> LCIACDFKPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<ONPFMKLHPJO> AKKDDDHKCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<IKBGEGNCPKM> NMHNLNHMHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<FNCPCNIICII> MDMBAFJFIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<ONPFMKLHPJO>> MLFIOFMAMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<DMHDLBKHGBK> JOEEGKJAEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> DABBFLEHGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> NKHMIOFNDPC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<IMKEGNCFDHD.AHFEFOFKAHD> MLPPBHILKEN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA9EBE0", Offset = "0xA9D1E0", VA = "0x180A9EBE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA9EB80", Offset = "0xA9D180", VA = "0x180A9EB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EDNLPJDMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xD70A20", Offset = "0xD6F020", VA = "0x180D70A20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xD70A30", Offset = "0xD6F030", VA = "0x180D70A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x85074A0", Offset = "0x8505AA0", VA = "0x1885074A0")]
	public NFHBMFGADGC(int MECHCJBGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8505600", Offset = "0x8503C00", VA = "0x188505600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x8505410", Offset = "0x8503A10", VA = "0x188505410")]
	public void CKBKAMMKCLJ(JobHandle ELCAJJNPFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8505CA0", Offset = "0x85042A0", VA = "0x188505CA0")]
	public void LDFKKLCMFAF(BDPLLEDHDEK DAJAOHIJHHL, DMHDLBKHGBK CNFAJAMLOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x85057E0", Offset = "0x8503DE0", VA = "0x1885057E0")]
	public void ELIGFFJCPJP(DPMIKCACNHG DAJAOHIJHHL, NativeArray<ONPFMKLHPJO> GJDHMAILIBP, int GAELDOPGMHO, int JLMPMKKMHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x8506180", Offset = "0x8504780", VA = "0x188506180")]
	public JobHandle OFIEMHOLKOF(KGBENKDOKKC DAILFHEJEFB, LFLKEFBIKOE FLIGBOGNEFN, float3 FJNOHNJNJHF, quaternion LJIHPOCBKGE, float AHFLBJBDNOB, bool FMIMLDHJNKM, int DNEOOIDAECP = 0, int AHMBMKIFJPH = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x85062A0", Offset = "0x85048A0", VA = "0x1885062A0")]
	public JobHandle OFIEMHOLKOF(KGBENKDOKKC DAILFHEJEFB, LFLKEFBIKOE FLIGBOGNEFN, NativeList<IMKEGNCFDHD.AHFEFOFKAHD> APCDCGHGCGN, float3 FJNOHNJNJHF, quaternion LJIHPOCBKGE, float AHFLBJBDNOB, bool FMIMLDHJNKM, bool JHBDAFBFBLN, int DNEOOIDAECP = 0, int AHMBMKIFJPH = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8505920", Offset = "0x8503F20", VA = "0x188505920")]
	public static JobHandle JKDEDFPBIAI(EDKJGEHIKFD PDINMCPKHOG, KGBENKDOKKC DAILFHEJEFB, NativeArray<int> NKHMIOFNDPC, BDPLLEDHDEK DAJAOHIJHHL, JobHandle ELCAJJNPFBB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x8505ED0", Offset = "0x85044D0", VA = "0x188505ED0")]
	public static JobHandle NHNJLGIMJLI(LHPBPADBCFL PDINMCPKHOG, KGBENKDOKKC DAILFHEJEFB, DPMIKCACNHG DAJAOHIJHHL, NativeArray<ONPFMKLHPJO> GJDHMAILIBP, int GAELDOPGMHO, int JLMPMKKMHPL, JobHandle ELCAJJNPFBB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JAPNCIAFHON
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct MHPKIMBOIAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer PHHDHBAFNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public DBKCMPDOMKL.PJILONPMFDM OPHIJEJDLOF;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x56851F0", Offset = "0x56837F0", VA = "0x1856851F0")]
		public MHPKIMBOIAC(MeshRenderer PHHDHBAFNEH, DBKCMPDOMKL.PJILONPMFDM OPHIJEJDLOF)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x85229E0", Offset = "0x8520FE0", VA = "0x1885229E0")]
		public static MHPKIMBOIAC HPNBGLLBBBG((MeshRenderer, DBKCMPDOMKL.PJILONPMFDM) EJHLMFPEOAB)
		{
			return default(MHPKIMBOIAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker MJEPBNGJLGH;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker IODPAFIABEF;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker DJEPHGLFBOL;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker BDEGNNNAIIC;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x851BE90", Offset = "0x851A490", VA = "0x18851BE90")]
	internal void PEHGJLEGGAI(GameObject PIILKPKPMGD, DBKCMPDOMKL.ABJFHJDBLPP BFLIBFLJJKF, List<MHPKIMBOIAC> KJALALPGBHM, Material JKDFAJLFBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8518FA0", Offset = "0x85175A0", VA = "0x188518FA0")]
	internal void FDKFHOIMDHE(GameObject PIILKPKPMGD, DBKCMPDOMKL.ABJFHJDBLPP BFLIBFLJJKF, List<MHPKIMBOIAC> KJALALPGBHM, List<LODGroup> JCMDFGBMNKP, Material JKDFAJLFBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x85197D0", Offset = "0x8517DD0", VA = "0x1885197D0")]
	private MeshRenderer FPBPGBHICKI(DBKCMPDOMKL.ABJFHJDBLPP BFLIBFLJJKF, Material JKDFAJLFBEL, List<MHPKIMBOIAC> KJALALPGBHM, bool OEPKFIKCLHG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x851AFB0", Offset = "0x85195B0", VA = "0x18851AFB0")]
	private List<(List<MHPKIMBOIAC>, float)> LIEMNDIAIOB(DBKCMPDOMKL.ABJFHJDBLPP BFLIBFLJJKF, List<LODGroup> JCMDFGBMNKP, Material JKDFAJLFBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x851A250", Offset = "0x8518850", VA = "0x18851A250")]
	private List<List<(List<MHPKIMBOIAC>, float)>> LCMCMDNKOOF(DBKCMPDOMKL.ABJFHJDBLPP BFLIBFLJJKF, List<LODGroup> JCMDFGBMNKP, Material JKDFAJLFBEL, [Out] int FFKGLGKAOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JAPNCIAFHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8518E30", Offset = "0x8517430", VA = "0x188518E30")]
	[CompilerGenerated]
	internal static (float, int) BIGCNBOFABI(List<List<(List<MHPKIMBOIAC> meshList, float lodTransition)>> HPGIGBICABG, int[] CPHBIDNBKCK)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class NNCGILFLMCB
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker FFOCCBHHEBA;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker AJOIKBHFMLG;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker JOLJBAILKAG;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker IKJPKDCJLAK;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker BGBBIJAFKGN;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker HDMNAEOMCGN;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker NPLCFANPGNN;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly IDGHEFJHGEI FKEFAKLKNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private DBKCMPDOMKL FJFFNHMMFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JAPNCIAFHON NMFFHPNOLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader GLOBJEPIPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock COOGDBIALGO;

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8522A60", Offset = "0x8521060", VA = "0x188522A60")]
	public static void DLNNBJBIOOO(GameObject PIILKPKPMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8524380", Offset = "0x8522980", VA = "0x188524380")]
	public void LJDCNOCKLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8522DE0", Offset = "0x85213E0", VA = "0x188522DE0")]
	public void EENIFMCBCML(GameObject PIILKPKPMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8523FD0", Offset = "0x85225D0", VA = "0x188523FD0")]
	private bool KEHHKDGDAMJ(MeshRenderer PHHDHBAFNEH, [Out] MeshFilter ENFFJMMKAAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8523020", Offset = "0x8521620", VA = "0x188523020")]
	private bool FMHMKFGAGEC(int LEPAEEGOBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8524150", Offset = "0x8522750", VA = "0x188524150")]
	private void LDCBLONEHCK(GameObject PIILKPKPMGD, int LEPAEEGOBDO, Material JKDFAJLFBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8523770", Offset = "0x8521D70", VA = "0x188523770")]
	private List<JAPNCIAFHON.MHPKIMBOIAC> JGDCPJDJBLN(int LEPAEEGOBDO, [Out] List<LODGroup> JCMDFGBMNKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8524B10", Offset = "0x8523110", VA = "0x188524B10")]
	private List<(int, Material)> OPOCELNJOLM(float CKPCBKDLPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8523F20", Offset = "0x8522520", VA = "0x188523F20")]
	public void JKHFIKONJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8523240", Offset = "0x8521840", VA = "0x188523240")]
	private bool GANCADELCLD(GameObject EGMHLHLEIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x85252E0", Offset = "0x85238E0", VA = "0x1885252E0")]
	public NNCGILFLMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class DBKCMPDOMKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct ABJFHJDBLPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 BHCLOJJFNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 AJNNFOKDGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float DLPHPBMDHCP;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x850BDD0", Offset = "0x850A3D0", VA = "0x18850BDD0")]
		public ABJFHJDBLPP(Bounds FBDMHHADOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x850BF40", Offset = "0x850A540", VA = "0x18850BF40")]
		public ABJFHJDBLPP(float3 BHCLOJJFNGO, float3 AJNNFOKDGKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct DOLJCGNCJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public ABJFHJDBLPP GMACNOOMNMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int EPGILLAJIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int BLAFJHGGKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float OIFJLBADKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int KOOADCCLMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int AGPLJLNDFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int FEODLINKNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int FEFJOEFAKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int OIGJBPEOKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool LIAHBGOHNFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct PJILONPMFDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh AMIAAEAIPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 BOJAPGJIBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int FHLHBPBAFAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct DCAHGDAHPJF : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<DOLJCGNCJOF> MIGDPMAMOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> KAGGBDPGCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int HCMEDIEOMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ABJFHJDBLPP FBDMHHADOPD;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8511CA0", Offset = "0x85102A0", VA = "0x188511CA0")]
		private float GHCOHOHPIEO(ABJFHJDBLPP IAFDMJDNHDH, ABJFHJDBLPP DFKKOPOBCBA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8511A80", Offset = "0x8510080", VA = "0x188511A80", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker PHLKAHEPMIB;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker PGFCLJMOJOF;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker MPMDEPCNCOH;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker GJGCEHAMIJB;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker KAALDEOGNEG;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker POIIGBHANJH;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker CNPFDIAJLFH;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker HGJIJLHFIMJ;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker EONJOKLDIAA;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker PANJBCJPMGL;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker EMBBPCENHKO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker OKFBFMCEDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<DOLJCGNCJOF> MIGDPMAMOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> CHJBHMCBNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int EMFIOCJMEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> IGOCPOPNENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<PJILONPMFDM> DMBGOEADBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> JCMDFGBMNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> PPDLPDKJDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> FCDOCPDACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader EAOJEAPHCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader MFODKBLAAOP;

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x85116E0", Offset = "0x850FCE0", VA = "0x1885116E0")]
	public DBKCMPDOMKL(int GDPFAEIGPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x850DD80", Offset = "0x850C380", VA = "0x18850DD80")]
	private void COGPOPNNEPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x850FEF0", Offset = "0x850E4F0", VA = "0x18850FEF0")]
	public bool NJNBPCLALCI(MeshRenderer EEGAAOLALGH, MeshFilter LFEGJANNLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8510380", Offset = "0x850E980", VA = "0x188510380")]
	public bool NJNBPCLALCI(LODGroup NCFHCGEEIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x850E590", Offset = "0x850CB90", VA = "0x18850E590")]
	private bool DIIFLEHJKPJ(MeshRenderer EEGAAOLALGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x850F940", Offset = "0x850DF40", VA = "0x18850F940")]
	private int LNHDAKAMOIM(MeshRenderer EEGAAOLALGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x850EEA0", Offset = "0x850D4A0", VA = "0x18850EEA0")]
	private int IOLHFADGHHA(LODGroup NCFHCGEEIPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x850FD90", Offset = "0x850E390", VA = "0x18850FD90")]
	private int MHMIJKOIPLE(MeshFilter LFEGJANNLOE, int COFJHONJGIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x850DA20", Offset = "0x850C020", VA = "0x18850DA20")]
	private int BAEKHMGBEKA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8511040", Offset = "0x850F640", VA = "0x188511040")]
	private static ABJFHJDBLPP OKDOMFCGKJP(ABJFHJDBLPP IAFDMJDNHDH, ABJFHJDBLPP DFKKOPOBCBA)
	{
		return default(ABJFHJDBLPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x850E6C0", Offset = "0x850CCC0", VA = "0x18850E6C0")]
	private static float FJOODMLKHMD(Vector3 BHCLOJJFNGO, Vector3 AJNNFOKDGKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x850FA60", Offset = "0x850E060", VA = "0x18850FA60")]
	private int MELOIHLELMP(int FFDDIALKKFI, ABJFHJDBLPP DACEGECGMIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x850E330", Offset = "0x850C930", VA = "0x18850E330")]
	private void DICAJJMKBIJ(ABJFHJDBLPP DACEGECGMIP, int LEPAEEGOBDO, [Out] float KNFJBPOKNOM, [Out] float CNJGEOBDBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x850EF10", Offset = "0x850D510", VA = "0x18850EF10")]
	private void KHLEKIBCHHK(ABJFHJDBLPP DACEGECGMIP, int ACKONEOPDOK, Material JKDFAJLFBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x850E810", Offset = "0x850CE10", VA = "0x18850E810")]
	private float GHCOHOHPIEO(ABJFHJDBLPP IAFDMJDNHDH, ABJFHJDBLPP DFKKOPOBCBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x850DEF0", Offset = "0x850C4F0", VA = "0x18850DEF0")]
	private void DGJOGBJBPJN(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x850EA50", Offset = "0x850D050", VA = "0x18850EA50")]
	private void GNGPFAODONG(int BAKMHGELNCE, int GFFHLLNHALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x850F390", Offset = "0x850D990", VA = "0x18850F390")]
	private void KNGMDCPOOCO(int BAKMHGELNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x850E610", Offset = "0x850CC10", VA = "0x18850E610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct EMAEIEALEKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 IDBKJPJKELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 DHACPNNANII;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class DCOGBPIMOAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<EMAEIEALEKG> FPJDBPKPFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> KLPJJGCNBME;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EDNLPJDMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x8511F10", Offset = "0x8510510", VA = "0x188511F10")]
	public DCOGBPIMOAF(int KOOADCCLMIG, int MCHFPDKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x8511DD0", Offset = "0x85103D0", VA = "0x188511DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x8511E30", Offset = "0x8510430", VA = "0x188511E30")]
	public void OBHFLNAIMDF(DCOGBPIMOAF BAMGCANCGAE, int GFAPJIAKPGA, int JNIDLJHCIED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class JHBHGFCJFKC
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static DCOGBPIMOAF HACHICMONDP;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<IKBGEGNCPKM> MKJKKDKJDMB;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] EPPNADCDFKO;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool ENLNINIIGLO;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, DCOGBPIMOAF> KBLELFFNNGB;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, DCOGBPIMOAF> PHADJEEIGCD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool GCABONPHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x851DD90", Offset = "0x851C390", VA = "0x18851DD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<IKBGEGNCPKM> AHAJJGEPPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x851D310", Offset = "0x851B910", VA = "0x18851D310")]
		get
		{
			return default(NativeList<IKBGEGNCPKM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DCOGBPIMOAF AKMOCDNHPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x851CE90", Offset = "0x851B490", VA = "0x18851CE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x851D3B0", Offset = "0x851B9B0", VA = "0x18851D3B0")]
	private static void IKIANNKOPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x851DF00", Offset = "0x851C500", VA = "0x18851DF00")]
	public static int NEBGPABCJDC(bool NGEJHKLOGBF, int CLPMJKPKBNI, bool FBFNPDEJHKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x851D2F0", Offset = "0x851B8F0", VA = "0x18851D2F0")]
	private static int IJNFNCCHLPF(int CLPMJKPKBNI, bool GMFLMHMGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x851CDD0", Offset = "0x851B3D0", VA = "0x18851CDD0")]
	private static int AEKAMNGPCBE(int CLPMJKPKBNI, bool GMFLMHMGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x851CF30", Offset = "0x851B530", VA = "0x18851CF30")]
	public static int DIIFHOEFKFN(int EEPEOPEEIMF, int CLPMJKPKBNI, int ENEPJCEOAKC, bool GMFLMHMGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x851CDE0", Offset = "0x851B3E0", VA = "0x18851CDE0")]
	public static int APLINNBENCP(int EEPEOPEEIMF, int CLPMJKPKBNI, int ENEPJCEOAKC, bool GMFLMHMGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x851E430", Offset = "0x851CA30", VA = "0x18851E430")]
	public static int PCOMCBMPDLE(int ENEPJCEOAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x851D2E0", Offset = "0x851B8E0", VA = "0x18851D2E0")]
	private static int GCKBPOPICEJ(int CLPMJKPKBNI, bool GMFLMHMGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x851CE70", Offset = "0x851B470", VA = "0x18851CE70")]
	private static int BFJAJIPPLGP(int CLPMJKPKBNI, bool GMFLMHMGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x851DD20", Offset = "0x851C320", VA = "0x18851DD20")]
	public static int KHIFPBMAMML(int EEPEOPEEIMF, int CLPMJKPKBNI, int ENEPJCEOAKC, bool GMFLMHMGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x851CFC0", Offset = "0x851B5C0", VA = "0x18851CFC0")]
	public static int DNCPEEJNDND(int EEPEOPEEIMF, int CLPMJKPKBNI, int ENEPJCEOAKC, bool GMFLMHMGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x851DD00", Offset = "0x851C300", VA = "0x18851DD00")]
	public static int JOBCCHLBCOM(int ENEPJCEOAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x851DE10", Offset = "0x851C410", VA = "0x18851DE10")]
	public static DCOGBPIMOAF MDAPBGOJAEC(int CLPMJKPKBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x851D050", Offset = "0x851B650", VA = "0x18851D050")]
	private static DCOGBPIMOAF FAHLPODPEEN(int CLPMJKPKBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x851E340", Offset = "0x851C940", VA = "0x18851E340")]
	public static DCOGBPIMOAF OHDKKBIMKDC(int CLPMJKPKBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x851D9C0", Offset = "0x851BFC0", VA = "0x18851D9C0")]
	private static DCOGBPIMOAF JEMMOEKOBNA(int CLPMJKPKBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x851DF30", Offset = "0x851C530", VA = "0x18851DF30")]
	public static void NHDIFLHDBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct DPMIKCACNHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int GNGLFPFIADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 JBPLNDJKLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion MMMLGJECMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float OCBEACHHGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float IGBAOMPJADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int OHJGNAFEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int JIIKHGGPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int GBACDPLFFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool ODKKJCJIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool JDGELNKIMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float BALIPDKKMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 FHCKALKBBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool EIEGIMOGNLD;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct FNCPCNIICII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int BAHMDBBEGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int LIMMNPDDGNK;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct LHPBPADBCFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<DPMIKCACNHG> HKCMIPIIGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<ONPFMKLHPJO> AFOGLHFEFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<IKBGEGNCPKM> FOCJAOLNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<FNCPCNIICII> NGPDABMFMFA;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8520480", Offset = "0x851EA80", VA = "0x188520480")]
	public LHPBPADBCFL(NativeArray<ONPFMKLHPJO> AFOGLHFEFOO, int MLMBLBFOLPC = 1, Allocator EKNOCGFFMAE = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8520390", Offset = "0x851E990", VA = "0x188520390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct MBKJOMJPNBM : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<EMAEIEALEKG> IGMHKLGNGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> IMMDNAIDFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<IKBGEGNCPKM> FLDICHDCJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<DPMIKCACNHG> HKCMIPIIGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<ONPFMKLHPJO> AFOGLHFEFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<IKBGEGNCPKM> FOCJAOLNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<FNCPCNIICII> NGPDABMFMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int CHIBAEFFJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int LMENKAHOKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 HDBOGHCJOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion OBPPHAKGEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 NMCNCGBOBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JDJFPLNKCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> APLCFLPBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DILGCEMPPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CAIIMILAFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> BMFFJLCFKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MAEFJLLEJAD;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8522520", Offset = "0x8520B20", VA = "0x188522520")]
	public MBKJOMJPNBM(NFHBMFGADGC ELDGLAJLAPJ, KGBENKDOKKC BLHHHOFHKFA, float3 HLGKGLFCEIN, quaternion HPALIKDLKFD, float IPKGCECHEFG, int DNEOOIDAECP = 0, int AHMBMKIFJPH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x85227B0", Offset = "0x8520DB0", VA = "0x1885227B0")]
	public MBKJOMJPNBM(LHPBPADBCFL ELDGLAJLAPJ, KGBENKDOKKC BLHHHOFHKFA, float3 HLGKGLFCEIN, quaternion HPALIKDLKFD, float3 IPKGCECHEFG, int DNEOOIDAECP = 0, int AHMBMKIFJPH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x85223E0", Offset = "0x85209E0", VA = "0x1885223E0")]
	private float3 JCLOLEPHKNB(float3 POKNCEFGGFG, Matrix4x4 JPEADHLNOLB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8520C00", Offset = "0x851F200", VA = "0x188520C00")]
	private float3x3 APKBGFKOIIM(float3x3 OLIAADOLOHO, float3x3 IGPKCEKKKAM)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x8520C80", Offset = "0x851F280", VA = "0x188520C80")]
	private float CBCILDGAJAC(float ILFCOODFNFF, float NNPFEGELCOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x8520C90", Offset = "0x851F290", VA = "0x188520C90", Slot = "4")]
	public void Execute(int IEODBGLFEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8521E30", Offset = "0x8520430", VA = "0x188521E30")]
	private void FBPDDIIPGIB(int DDLMDEDNHOI, float3 AANGPKCDGHO, float3 NNMAALGIDJM, float3 KDCHPNLBIGB, float OFHHJJPMNHK, bool KEEDOBJBCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8521FA0", Offset = "0x85205A0", VA = "0x188521FA0")]
	private void ICAHAIFPCAC(DPMIKCACNHG EFLGDOKAEKA, float3 DPLNHDFCMOI, float3x3 LNFJGJBDGFN, float ILFCOODFNFF, int KMFFPOLILIP, int MJGJAPCOIDH, int GPNDDIAMBBC, float IENFLKPPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8520680", Offset = "0x851EC80", VA = "0x188520680")]
	private void AAMFBHMEMFJ(int DDLMDEDNHOI, int PHBCPDKJCFH, DPMIKCACNHG EFLGDOKAEKA, float3 DPLNHDFCMOI, float3x3 LNFJGJBDGFN, bool PEMDKFHLHEI, float ILFCOODFNFF, int HLNECACPLJJ, int FCCEBMNHGIG, int GPNDDIAMBBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct EDKJGEHIKFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<BDPLLEDHDEK> NGLJEHHFAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<IKBGEGNCPKM> LAOPLOOHKHO;

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x8512AE0", Offset = "0x85110E0", VA = "0x188512AE0")]
	public EDKJGEHIKFD(int MLMBLBFOLPC, Allocator EKNOCGFFMAE = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8512A40", Offset = "0x8511040", VA = "0x188512A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct BLHGLOJJKEG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum KHJDMDPOOJN
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
	private NativeList<float3> PBAPOCDLOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> PIFHEMJCCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> JKNOGKMFNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> ECILJFIAJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> KOHIOHBAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> BNGKOPHLCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> MJLCDIDNDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> KPOFMJJPIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> FFNAHBIDFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<IKBGEGNCPKM> INNBCFLNPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<BDPLLEDHDEK> NGLJEHHFAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<IKBGEGNCPKM> LAOPLOOHKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int CHIBAEFFJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int LMENKAHOKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JDJFPLNKCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> APLCFLPBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DILGCEMPPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CAIIMILAFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> BMFFJLCFKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NKHMIOFNDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MAEFJLLEJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 NMCNCGBOBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion OBPPHAKGEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 HDBOGHCJOID;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x850D810", Offset = "0x850BE10", VA = "0x18850D810")]
	public BLHGLOJJKEG(NFHBMFGADGC ELDGLAJLAPJ, KGBENKDOKKC BLHHHOFHKFA, NativeArray<int> GKDJIIJAIKF, float3 HLGKGLFCEIN, quaternion HPALIKDLKFD, float IPKGCECHEFG, int DNEOOIDAECP = 0, int AHMBMKIFJPH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x850D600", Offset = "0x850BC00", VA = "0x18850D600")]
	public BLHGLOJJKEG(EDKJGEHIKFD DAJAOHIJHHL, KGBENKDOKKC BLHHHOFHKFA, NativeArray<int> GKDJIIJAIKF, float3 HLGKGLFCEIN, quaternion HPALIKDLKFD, float3 IPKGCECHEFG, int DNEOOIDAECP = 0, int AHMBMKIFJPH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x850C1A0", Offset = "0x850A7A0", VA = "0x18850C1A0", Slot = "4")]
	public void Execute(int IEODBGLFEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x850D150", Offset = "0x850B750", VA = "0x18850D150")]
	private void INBCADADLDD(float4x4 ONMGGJNFMFI, int IEODBGLFEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x850D540", Offset = "0x850BB40", VA = "0x18850D540")]
	private KHJDMDPOOJN JNHACLOGHGP(float3 NNMAALGIDJM)
	{
		return default(KHJDMDPOOJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x850D5B0", Offset = "0x850BBB0", VA = "0x18850D5B0")]
	private float4 LLIBHFIDGHL(KHJDMDPOOJN CLDNMPAEIGK, int LEPAEEGOBDO)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x850D500", Offset = "0x850BB00", VA = "0x18850D500")]
	private float2 JFAMLALLHGC(KHJDMDPOOJN CLDNMPAEIGK, float3 AANGPKCDGHO)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct DMHDLBKHGBK
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum CHBKIMHNIFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static DMHDLBKHGBK KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 IIKJNDDFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 NEMGOCEHIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 OJPHAFPPPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public CHBKIMHNIFE MONFNOPPPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 BHEDFOBBGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 FEDNIGPGBHA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool EJBELALFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x85125E0", Offset = "0x8510BE0", VA = "0x1885125E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 LLIBJLCEILF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8512500", Offset = "0x8510B00", VA = "0x188512500")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x8512950", Offset = "0x8510F50", VA = "0x188512950")]
	public DMHDLBKHGBK(float3 AANGPKCDGHO, quaternion NEOIPHFFLHF, float3 MLMBLBFOLPC, CHBKIMHNIFE EHLAHNIAPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x85125F0", Offset = "0x8510BF0", VA = "0x1885125F0")]
	public float PBEIBKOGECD(float3 DPLNHDFCMOI, float BLELDLHOHBM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x8512260", Offset = "0x8510860", VA = "0x188512260")]
	public bool CNPCGOPDJPA(float3 NNMAALGIDJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x8512350", Offset = "0x8510950", VA = "0x188512350")]
	public void DGALKKOGNKC(float3 HNHDBGPEAON, float3x3 MNOPLNMLHKF, float NOPCKOAICLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x85127F0", Offset = "0x8510DF0", VA = "0x1885127F0")]
	private void PENMEIINHBF(float3 MALCLFCGIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8511FD0", Offset = "0x85105D0", VA = "0x188511FD0")]
	public void CJDODODJHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct EOKJFHLJIED : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<DMHDLBKHGBK> DAJAOHIJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> MNNAHDCEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> IFAGBCNDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DABBFLEHGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<IKBGEGNCPKM> LAOPLOOHKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int GLHGOCNHLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int HPABOJPIFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float BLELDLHOHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float JLFGMDGBGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> IMJDJKAIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FOCOOOBFCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> AMNAKHPFFII;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8513660", Offset = "0x8511C60", VA = "0x188513660")]
	public EOKJFHLJIED(KGBENKDOKKC LJNJDNJBNIE, float PCCIMNKKALA, int JNIDLJHCIED, int KMFFPOLILIP, NativeList<DMHDLBKHGBK> DAJAOHIJHHL, NativeArray<int> DABBFLEHGCF, NativeList<IKBGEGNCPKM> LAOPLOOHKHO, LFLKEFBIKOE FLIGBOGNEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8512F20", Offset = "0x8511520", VA = "0x188512F20", Slot = "4")]
	public void Execute(int HFCCKCGPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8512BD0", Offset = "0x85111D0", VA = "0x188512BD0")]
	private bool AOFHPMCPGPG(DMHDLBKHGBK IAFDMJDNHDH, DMHDLBKHGBK DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8512C90", Offset = "0x8511290", VA = "0x188512C90")]
	private bool BMMAFFPDBBJ(DMHDLBKHGBK BBJNPAEMBIM, int AALGJILABPG, int CCKEBAKGKKN, int BAODCNDEMPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct LIODCPHOPGK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<IMKEGNCFDHD.AHFEFOFKAHD> APCDCGHGCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> PGHCIJOOICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int DNEOOIDAECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int AHMBMKIFJPH;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8520660", Offset = "0x851EC60", VA = "0x188520660")]
	public LIODCPHOPGK(NativeList<IMKEGNCFDHD.AHFEFOFKAHD> APCDCGHGCGN, NativeArray<int> PGHCIJOOICA, int AHMBMKIFJPH = 0, int DNEOOIDAECP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x85205B0", Offset = "0x851EBB0", VA = "0x1885205B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class LFLKEFBIKOE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> NOCIIMPGPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> LKHCPGEKJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> EEAMKPOHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> LHLKHPAPEKM;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8520270", Offset = "0x851E870", VA = "0x188520270")]
	public void LKNCAMJABCH(int KOOADCCLMIG, int MCHFPDKIKIK, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8520250", Offset = "0x851E850", VA = "0x188520250")]
	public static long HBINFCBIDEJ(int KOOADCCLMIG, int MCHFPDKIKIK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8520160", Offset = "0x851E760", VA = "0x188520160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8520070", Offset = "0x851E670", VA = "0x188520070")]
	public void CKBKAMMKCLJ(JobHandle ELCAJJNPFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LFLKEFBIKOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct POAKAJLMBDP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> MNNAHDCEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> AFNAJNLLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> GCAMDFBELJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> PMCOCPLIFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> IFAGBCNDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KDNCCNPNEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> NNENKPCPHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> IMJDJKAIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> FOCOOOBFCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int DNEOOIDAECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int AHMBMKIFJPH;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8525780", Offset = "0x8523D80", VA = "0x188525780")]
	public POAKAJLMBDP(KGBENKDOKKC LJNJDNJBNIE, LFLKEFBIKOE FLIGBOGNEFN, int AHMBMKIFJPH = 0, int DNEOOIDAECP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8525340", Offset = "0x8523940", VA = "0x188525340", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8525720", Offset = "0x8523D20", VA = "0x188525720")]
	private void GOPJCKLABGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class KFAAGIAIGEP
{
	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3E63F60", Offset = "0x3E62560", VA = "0x183E63F60")]
	public static bool KGLCJHLBNDI<T>(NativeArray<T> OHHBFAGELLA, int MLMBLBFOLPC, Allocator EKNOCGFFMAE, NativeArrayOptions EEPOAHLOJPI = NativeArrayOptions.ClearMemory, int KOKJHPJNAKF = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3E641D0", Offset = "0x3E627D0", VA = "0x183E641D0")]
	public static bool KGLCJHLBNDI<T>(NativeList<T> AHJLBOEGGKN, int MLMBLBFOLPC, Allocator EKNOCGFFMAE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E640A0", Offset = "0x3E626A0", VA = "0x183E640A0")]
	public static bool KGLCJHLBNDI<T>(NativeQueue<T> GPJGBKHIBFO, Allocator EKNOCGFFMAE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum ICFDOFGDKLP
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
public interface EFJMOLMIFDJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CJGPHCCPIEA(ICFDOFGDKLP EEPEOPEEIMF);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OBHAKBCDEKD(ICFDOFGDKLP EEPEOPEEIMF);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GLGFFNDJOPA ACBAGFKJEHC();

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float DIDCKMEMGLJ();

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCKEJCDHPAA(ICFDOFGDKLP EEPEOPEEIMF, NFHBMFGADGC LHLGMDKHPPH, int FFODKKIHDLN = -1);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int LHHANFMHICJ(int KNPMCOLDHNF);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class BGJMBMMJOFB
{
	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x850C050", Offset = "0x850A650", VA = "0x18850C050")]
	public static void NHDIFLHDBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class FPPJEGJEEIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> KMOFPFFJFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> MICGNOBMLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> OPJCMCOCDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> HNEAEEPANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> ALPMLHOPGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> DJKKHDEDGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> AKNELKIOOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> JCBMDJEHIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> JEAGFLJKHDB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8518320", Offset = "0x8516920", VA = "0x188518320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EDNLPJDMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x85182A0", Offset = "0x85168A0", VA = "0x1885182A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EOMNMEAPAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x85182E0", Offset = "0x85168E0", VA = "0x1885182E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x85187B0", Offset = "0x8516DB0", VA = "0x1885187B0")]
	public FPPJEGJEEIP(int KOOADCCLMIG, int MCHFPDKIKIK, int PIMACNMNELN, Allocator EKNOCGFFMAE = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8518AD0", Offset = "0x85170D0", VA = "0x188518AD0")]
	public FPPJEGJEEIP(Mesh LJNJDNJBNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8518360", Offset = "0x8516960", VA = "0x188518360", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8518480", Offset = "0x8516A80", VA = "0x188518480")]
	public void OBHFLNAIMDF(FPPJEGJEEIP LJNJDNJBNIE, bool CDMBBEDIMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8517E10", Offset = "0x8516410", VA = "0x188517E10")]
	private void AJJIBPJJOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x85178A0", Offset = "0x8515EA0", VA = "0x1885178A0")]
	private void AIOBGCMALKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct IKBGEGNCPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int LIIBNIKGNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int MHODMACGMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int IFJBJAFBHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int EDNLPJDMDPL;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x228A2A0", Offset = "0x22888A0", VA = "0x18228A2A0")]
	public IKBGEGNCPKM(int KMFFPOLILIP, int GAELDOPGMHO, int JNIDLJHCIED, int JLMPMKKMHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class KFHJFFDPCKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<IKBGEGNCPKM> FHGFHLJDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<IKBGEGNCPKM>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FPPJEGJEEIP AMIAAEAIPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x851F2A0", Offset = "0x851D8A0", VA = "0x18851F2A0")]
	public KFHJFFDPCKK(IEnumerable<FPPJEGJEEIP> AFMMHMEHFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x851F230", Offset = "0x851D830", VA = "0x18851F230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum EBALBEPPDDF
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class JGCJGIGLBEO
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> IFIGDCHJNGD;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> NPPJHIFGDBJ;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> KIBKJLFMBAC;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> OJOCIEAIBOJ;

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x851CA90", Offset = "0x851B090", VA = "0x18851CA90")]
	public static void NHDIFLHDBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x851C980", Offset = "0x851AF80", VA = "0x18851C980")]
	public static NativeArray<float2> NCLKGBFLEJF(NativeArray<float2> ECLLHMLONOP, int FJGPDLBGMBA, NativeArray<float2> MLMFJLOGGKL, int FECMILHBCCN)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x851C870", Offset = "0x851AE70", VA = "0x18851C870")]
	public static NativeArray<float3> IBGHCECFGJP(NativeArray<float3> ECLLHMLONOP, int FJGPDLBGMBA, NativeArray<float3> MLMFJLOGGKL, int FECMILHBCCN)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x851CCC0", Offset = "0x851B2C0", VA = "0x18851CCC0")]
	public static NativeArray<float4> POBBDFBAMGE(NativeArray<float4> ECLLHMLONOP, int FJGPDLBGMBA, NativeArray<float4> MLMFJLOGGKL, int FECMILHBCCN)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x851CBB0", Offset = "0x851B1B0", VA = "0x18851CBB0")]
	public static NativeArray<int> NJNLODNGMPM(NativeArray<int> ECLLHMLONOP, int FJGPDLBGMBA, NativeArray<int> MLMFJLOGGKL, int FECMILHBCCN)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E34F10", Offset = "0x3E33510", VA = "0x183E34F10")]
	private static void EENFOAJIJHF<T>(NativeArray<T> OHHBFAGELLA, int BFKHNMJOOEB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E34E60", Offset = "0x3E33460", VA = "0x183E34E60")]
	private static void CCEMPCCGGPI<T>(NativeArray<T> ECLLHMLONOP, int FJGPDLBGMBA, NativeArray<T> MLMFJLOGGKL, int FECMILHBCCN, NativeArray<T> KPANBGNCDMJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class KCFOLGMJIJP
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct MJAMEJDFIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort POMPNNDHCKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort JLAHKMCOIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort GFIJDJGEMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort CMODIHDPDMF;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x851EF90", Offset = "0x851D590", VA = "0x18851EF90")]
	public static uint GLKDLCFODOG(float LDFCNCAALNA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x851E700", Offset = "0x851CD00", VA = "0x18851E700")]
	public static void DJNKGPLHHJN(float4 GCAMDFBELJG, float CLBINMJIICK, [Out] uint CMDPFPCFLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x851E630", Offset = "0x851CC30", VA = "0x18851E630")]
	public static void DJNKGPLHHJN(float4 GCAMDFBELJG, uint PMKHCCBNNNA, [Out] uint CMDPFPCFLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x851ED40", Offset = "0x851D340", VA = "0x18851ED40")]
	public static void GLIKILOCMFF(float3 KGGEHKDBFDD, float3 FEPLAMADJBF, float4 KPKININHLDG, float2 NIADOHFPFMP, float4 GCAMDFBELJG, [Out] KGBENKDOKKC.KCGIACMKGFH JJIPMANEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x851EAE0", Offset = "0x851D0E0", VA = "0x18851EAE0")]
	public static void GLIKILOCMFF(float3 KGGEHKDBFDD, float3 FEPLAMADJBF, float4 KPKININHLDG, float2 NIADOHFPFMP, float4 GCAMDFBELJG, [Out] KGBENKDOKKC.HOPDLMOOBGO JJIPMANEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x851EFF0", Offset = "0x851D5F0", VA = "0x18851EFF0")]
	public static byte NOHLPMGBMOD(float FKMNCAKIOFK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x851EFA0", Offset = "0x851D5A0", VA = "0x18851EFA0")]
	public static ushort LOKOJMHNFCF(float FKMNCAKIOFK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x851E810", Offset = "0x851CE10", VA = "0x18851E810")]
	public static uint DMDKMLEJMAK(float FKMNCAKIOFK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x851E5B0", Offset = "0x851CBB0", VA = "0x18851E5B0")]
	public static float2 BJLIPJNGPFJ(float2 EFGJHINBPCN)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x851E990", Offset = "0x851CF90", VA = "0x18851E990")]
	public static float2 ECEDKDJKGNC(float3 IODKHMMPFHJ)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x851E840", Offset = "0x851CE40", VA = "0x18851E840")]
	public static void DOHGGOBOHIB(float3 FKMNCAKIOFK, [Out] float3 NMPCJJHECGG, [Out] uint3 CMODIHDPDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x851F040", Offset = "0x851D640", VA = "0x18851F040")]
	public static MJAMEJDFIEO PFIJECEGJGN(float3 AANGPKCDGHO)
	{
		return default(MJAMEJDFIEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class KPPEPJJPLEI
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker BLJPPAMEJHK;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float OPAMDMJMMCO;

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void CGCICMOHIIG(bool MHNNEIDGMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x851F860", Offset = "0x851DE60", VA = "0x18851F860")]
	public static float DKGHOPHKPDO(float DHFNBEBIIMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x851F9C0", Offset = "0x851DFC0", VA = "0x18851F9C0")]
	public static long HLACNHGDHJM(float DHFNBEBIIMF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x851FAB0", Offset = "0x851E0B0", VA = "0x18851FAB0")]
	public static void OEPPOMDFEMD(float DHFNBEBIIMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface OCHFNOKBKCB
{
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEPPOMDFEMD(float DAOGDJNABFI);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) CDKCCEOELAL(float OPAPCAPCAHB);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class FEAJHBFJFDJ
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum PPINNBJFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		ShapesStartTreeGeneration,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		ShapesTreeRefresh,
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		ShapesUploadMesh,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		ShapesLod012Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class DBKPKMKCGME : MADDCBPHNCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public PPINNBJFDPL EHLAHNIAPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public BatchedMeshRenderer KNAALFKGIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public KOBHAJKIGLO LGMDHIKKGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public IMKEGNCFDHD NFBFNKJLJNM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override float LFLEHKJBBGP
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x128CC90", Offset = "0x128B290", VA = "0x18128CC90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x1A5AFC0", Offset = "0x1A595C0", VA = "0x181A5AFC0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x85258B0", Offset = "0x8523EB0", VA = "0x1885258B0", Slot = "7")]
		public override void MGDMFNNFPNM([Out] bool PHEDBDCOGFM, [Out] bool AKJPIPAGAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public DBKPKMKCGME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int FHOPAAPMDGI;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int KKAJADIPKGD;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int DGOLIHGGFLN;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long IPIDPBFECAC;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long PGAJFFKEPFF;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long JKNFIEKHLCA;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long NNAHPDGHNLP;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int IJKJDEKMOPI;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float NLNLEKKBNLE;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool KKKMLEMFFMI;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int PINJJKBNCJI;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int DKIGBEEDENE;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int PKCAOAHAAGO;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long OKJLELGMIHH;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int MJFLFBNDNLO;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool GHFHAEMCENI;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static uint DMOFCCEIFEK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static OCFGLFDFLIO MPPIDIMCMHC;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static List<uint> ALAIKPONFBE;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static OCHFNOKBKCB KHIEENKIOPK;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static OCHFNOKBKCB NPPOPGIBHBG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool OFJLNJJJLGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8514C80", Offset = "0x8513280", VA = "0x188514C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void OMAKILKAJDG(bool MHNNEIDGMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void CGCICMOHIIG(bool MHNNEIDGMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void OMAKILKAJDG(bool MHNNEIDGMOP, string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x85144A0", Offset = "0x8512AA0", VA = "0x1885144A0")]
	public static void JABKLOOBLPP(OCHFNOKBKCB BLOABFGPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x8514870", Offset = "0x8512E70", VA = "0x188514870")]
	public static void KBEFAALDCFJ(OCHFNOKBKCB BLOABFGPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x85149E0", Offset = "0x8512FE0", VA = "0x1885149E0")]
	public static (long, long, long, int, int) LOALNCADFHP(long DABPEAAEPPG)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8514960", Offset = "0x8512F60", VA = "0x188514960")]
	public static void LNFCGCMFNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8514CD0", Offset = "0x85132D0", VA = "0x188514CD0")]
	public static void OEPPOMDFEMD(long DABPEAAEPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8513700", Offset = "0x8511D00", VA = "0x188513700")]
	public static void AFHFHKLHMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8513F70", Offset = "0x8512570", VA = "0x188513F70")]
	public static long DMBFCFJPCNC(long BAKBAMCNEGI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8513EA0", Offset = "0x85124A0", VA = "0x188513EA0")]
	public static bool DFNOACMIJPD(long NDNMDMDMDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8514BB0", Offset = "0x85131B0", VA = "0x188514BB0")]
	public static bool MBLHOPBLGKG(long NDNMDMDMDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8514510", Offset = "0x8512B10", VA = "0x188514510")]
	public static float JAJPLDMLJOF(long PFGJJHCAEHK, int EBNJGOBEKEG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8513A30", Offset = "0x8512030", VA = "0x188513A30")]
	public static (long, long, int) CDKCCEOELAL(float DHFNBEBIIMF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8517100", Offset = "0x8515700", VA = "0x188517100")]
	public static void OFEPLNCFMBE(IMKEGNCFDHD NFBFNKJLJNM, BatchedMeshRenderer KNAALFKGIHF, long IPBMGMNFMLB, long PCAIMALMIFI, float EPKIHHHCOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8517440", Offset = "0x8515A40", VA = "0x188517440")]
	public static void PJBMEKLMKGN(IMKEGNCFDHD NFBFNKJLJNM, BatchedMeshRenderer KNAALFKGIHF, long IPBMGMNFMLB, long PCAIMALMIFI, float EJLMHPHPHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8517290", Offset = "0x8515890", VA = "0x188517290")]
	public static void ONKCDHHMPAJ(KOBHAJKIGLO LGMDHIKKGJL, BatchedMeshRenderer KNAALFKGIHF, long PCAIMALMIFI, float EJLMHPHPHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x85141E0", Offset = "0x85127E0", VA = "0x1885141E0")]
	public static void FPFAGJIHCDK(IMKEGNCFDHD NFBFNKJLJNM, BatchedMeshRenderer KNAALFKGIHF, long IPBMGMNFMLB, long PCAIMALMIFI, float EJLMHPHPHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8513810", Offset = "0x8511E10", VA = "0x188513810")]
	private static void ANEECFJBICN(PPINNBJFDPL EHLAHNIAPLD, IMKEGNCFDHD NFBFNKJLJNM, KOBHAJKIGLO LGMDHIKKGJL, BatchedMeshRenderer KNAALFKGIHF, long IPBMGMNFMLB, long PCAIMALMIFI, float DOELIGGOGBA, bool ONHJACINCJA, bool KDHIKDGPBJH, float DLELGMMBCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8514120", Offset = "0x8512720", VA = "0x188514120")]
	public static bool ENAGJIKKGHI(float COBMKPDFOBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x85148E0", Offset = "0x8512EE0", VA = "0x1885148E0")]
	public static void KDEAKEGBCKJ(float COBMKPDFOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8514390", Offset = "0x8512990", VA = "0x188514390")]
	public static bool IPLHPJKOHEO(float COBMKPDFOBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class MADDCBPHNCH : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum JBLFKHNKIEI : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		Instant,
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		Persistent
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public JBLFKHNKIEI GALLFKGMIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public long CGNONDAIDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public long PCAIMALMIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public float CCPAIANKFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool KDHIKDGPBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public bool ONHJACINCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	internal uint JIEJOKBHEMF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract float LFLEHKJBBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void MGDMFNNFPNM([Out] bool PHEDBDCOGFM, [Out] bool AKJPIPAGAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x85395F0", Offset = "0x8537BF0", VA = "0x1885395F0", Slot = "4")]
	public int CompareTo(object NDBJJGOPOFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected MADDCBPHNCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class OCFGLFDFLIO : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private List<MADDCBPHNCH> PMCILBODMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private List<MADDCBPHNCH> KDCGJHFAJAD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8539720", Offset = "0x8537D20", VA = "0x188539720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x85398F0", Offset = "0x8537EF0", VA = "0x1885398F0")]
	public void KMLBEHGKDFG(MADDCBPHNCH KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8539890", Offset = "0x8537E90", VA = "0x188539890")]
	public void HKBDNAIICJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8539D00", Offset = "0x8538300", VA = "0x188539D00")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x85399C0", Offset = "0x8537FC0", VA = "0x1885399C0")]
	public void MIGKNOPDHMI(IEnumerable<uint> ALAIKPONFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x85397D0", Offset = "0x8537DD0", VA = "0x1885397D0")]
	private void HCDNAOEAAEJ(uint JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x8539D90", Offset = "0x8538390", VA = "0x188539D90", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8539770", Offset = "0x8537D70", VA = "0x188539770")]
	public DPJAKPJPFGO DKMCAGKLCHH()
	{
		return default(DPJAKPJPFGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x8539E30", Offset = "0x8538430", VA = "0x188539E30")]
	public OCFGLFDFLIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct DPJAKPJPFGO : IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private List<MADDCBPHNCH> PMCILBODMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private List<MADDCBPHNCH> KDCGJHFAJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private int GKBEIDOBPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private int EKBHFLIDNCP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8526660", Offset = "0x8524C60", VA = "0x188526660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MADDCBPHNCH MKKCMPLEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8526340", Offset = "0x8524940", VA = "0x188526340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8526670", Offset = "0x8524C70", VA = "0x188526670")]
	public DPJAKPJPFGO(List<MADDCBPHNCH> PMCILBODMGN, List<MADDCBPHNCH> KDCGJHFAJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x85264C0", Offset = "0x8524AC0", VA = "0x1885264C0", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8526650", Offset = "0x8524C50", VA = "0x188526650", Slot = "6")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class KOBHAJKIGLO
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal enum KJMMMIDKLCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		NoMeshRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		Mesh,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		MeshFrozen,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		MeshRefresh,
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly string PKIEJFKGAPH;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly string DPPELBJOILP;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker NEJKICNGBDK;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker CDAPDJCPEEL;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker BLJPPAMEJHK;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker MEADMHDCBGG;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker PKDDCFCAFIK;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker GMKENCIECCK;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker KAHOFEFBCKO;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker ELCMLDICKDH;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker CHEMGEFDAJP;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker MBGNDJOCGBC;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker AKAOKLBDCHH;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker BIEPOABHDHB;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker NCNNLGBEPKA;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker GKOMNIIEGBN;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker JNJPPCEIOBF;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker CCDJHAGGGLE;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker HKLFHAOIGLN;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly ProfilerMarker LGIGDOPECHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal readonly List<IMKEGNCFDHD> BDCENJCGNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly EDAJBCAFGNC OEFCEIMHNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private int FGDJEJMNFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private int IAJAHDHBHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private bool EDDNDCLCFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public const bool EELCCCMOFEN = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public bool CFEAHDJKJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	internal KJMMMIDKLCC EGDONMKCNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	internal int DJBOIPOFLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	internal int CEHHNJBEKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	internal int PHGLHOIIFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	internal int BJBAGECKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	internal long NJAEDBPBEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	internal long GMGKAAADJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	internal long IFCEIIJICNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private KGBENKDOKKC NIDFCDLGEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private KGBENKDOKKC JOJCGENCIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private KGBENKDOKKC.GHJDECIPEEC BDHOAAMNPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private bool MICKANPGAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private int CKLMGKNEHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private CACGEFAJBJE JFBOBDPBOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private float3 ENCMOPHHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private float COLOJIAAGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private float PEKBBABIKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private float PPJPFIOCAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private float OIAMPGFIOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private float GNNMGDMPCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float OINKKBBFLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private float3 FCHCIAIOCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float BGKACOLBCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private float LBAIGDODMOL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal Mesh AMIAAEAIPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MeshFilter KIBOBCOGHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MeshRenderer FHCMHJCPMBN
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<Material> IEMDDMGLBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int PNGCNMJNACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xAF9970", Offset = "0xAF7F70", VA = "0x180AF9970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8534400", Offset = "0x8532A00", VA = "0x188534400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int EDNLPJDMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8533D70", Offset = "0x8532370", VA = "0x188533D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x85377A0", Offset = "0x8535DA0", VA = "0x1885377A0")]
	public void MGKHJNPFAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8533950", Offset = "0x8531F50", VA = "0x188533950")]
	public bool ALFAOCFMJBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8533600", Offset = "0x8531C00", VA = "0x188533600")]
	private void ACALODHDFMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8537A70", Offset = "0x8536070", VA = "0x188537A70")]
	private void NJKLGHKGGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x85394D0", Offset = "0x8537AD0", VA = "0x1885394D0")]
	public KOBHAJKIGLO(string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8534420", Offset = "0x8532A20", VA = "0x188534420")]
	public void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8537700", Offset = "0x8535D00", VA = "0x188537700")]
	private void LOLBMDOOLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8535DC0", Offset = "0x85343C0", VA = "0x188535DC0")]
	private void FEBEHMDJOBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x85338B0", Offset = "0x8531EB0", VA = "0x1885338B0")]
	private void AILJIFDLHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x85367D0", Offset = "0x8534DD0", VA = "0x1885367D0")]
	public Mesh HKEGLHLGFKH(MeshFilter ENFFJMMKAAC, Transform JAHKFPBBGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8533D90", Offset = "0x8532390", VA = "0x188533D90")]
	public void BFAKNGPFBMB(bool FAPBNHEBFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8534EB0", Offset = "0x85334B0", VA = "0x188534EB0")]
	private void EHPIEOKHPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8537490", Offset = "0x8535A90", VA = "0x188537490")]
	public void LBOCHCONJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x85345D0", Offset = "0x8532BD0", VA = "0x1885345D0")]
	public void DEJDNKOJJPA(EFJMOLMIFDJ MGMEFHAFOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x8536840", Offset = "0x8534E40", VA = "0x188536840")]
	public bool HLCAMINODHN(EFJMOLMIFDJ MGMEFHAFOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x8534800", Offset = "0x8532E00", VA = "0x188534800")]
	public bool DIIFLEHJKPJ(EFJMOLMIFDJ MGMEFHAFOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x8533720", Offset = "0x8531D20", VA = "0x188533720", Slot = "4")]
	public virtual void AGKINELFJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x8535FD0", Offset = "0x85345D0", VA = "0x188535FD0")]
	public void FIBJHKEMEHO(Transform EPBCOOIGAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x8533A70", Offset = "0x8532070", VA = "0x188533A70")]
	public bool AOLNJDNAIDM(Transform EPBCOOIGAEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x8538B90", Offset = "0x8537190", VA = "0x188538B90")]
	public bool OPAAGEOKONC(bool AKHIMJBDLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x8537C30", Offset = "0x8536230", VA = "0x188537C30")]
	private void NPKLGNALHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x8537D50", Offset = "0x8536350", VA = "0x188537D50")]
	public bool OEPPOMDFEMD(float4x4 CDOMFLOAMJF, BatchedMeshRenderer EMEJIFHGFEB, bool LOLJLFNICFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x8538E90", Offset = "0x8537490", VA = "0x188538E90")]
	public bool PIAGNBPDJCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x8535000", Offset = "0x8533600", VA = "0x188535000")]
	public bool EKODIOAMHHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x85375A0", Offset = "0x8535BA0", VA = "0x1885375A0")]
	public void LKCBKHLCHKE(KGBENKDOKKC LJNJDNJBNIE, int NCDGIIGKKOB, int IDOECCKDGLJ, float PGAIKFAJHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x85378D0", Offset = "0x8535ED0", VA = "0x1885378D0")]
	public (long, long, long) MMJILDBGJFP()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0")]
	public long EPCNJKMGEKO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x8535C90", Offset = "0x8534290", VA = "0x188535C90")]
	private void EPPIFLCJMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x8534150", Offset = "0x8532750", VA = "0x188534150")]
	public (long, long, int) CDKCCEOELAL(float DHFNBEBIIMF, float4x4 CDOMFLOAMJF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xFD8610", Offset = "0xFD6C10", VA = "0x180FD8610")]
	internal void CIELEGCDDFO(KJMMMIDKLCC KGILCHBPJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8536A40", Offset = "0x8535040", VA = "0x188536A40")]
	internal (float, float, float, float) KEPDAAFNIOH(float IDPOGACGLCD, float4x4 CDOMFLOAMJF)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x8534CB0", Offset = "0x85332B0", VA = "0x188534CB0")]
	private void DNJAJLDBPDG(KGBENKDOKKC FEDLIKGDELB, KGBENKDOKKC.GHJDECIPEEC GOGAJJAABDK, bool GMLGENLNDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8535DA0", Offset = "0x85343A0", VA = "0x188535DA0")]
	private void FCLFKDCGMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x8537380", Offset = "0x8535980", VA = "0x188537380")]
	internal bool LBHKNMIPNFK(bool AKHIMJBDLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8536400", Offset = "0x8534A00", VA = "0x188536400")]
	private void GBFOLBKIMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x85340B0", Offset = "0x85326B0", VA = "0x1885340B0")]
	private void BNAKJANHIGJ(KGBENKDOKKC.GHJDECIPEEC GOGAJJAABDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x85389C0", Offset = "0x8536FC0", VA = "0x1885389C0")]
	private void OIGNGOGLMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x8534980", Offset = "0x8532F80", VA = "0x188534980")]
	public long DMBFCFJPCNC(long BAKBAMCNEGI, int NIHGELCDOFD)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class IMKEGNCFDHD
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum PBBIADGNHBC
	{
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public struct AHFEFOFKAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int BEDGCBJMDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int IKOPHEOIONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public float KNFJBPOKNOM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct OPPJJAADFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public GKDOCEBGLOE LJNJDNJBNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public int FOJNKKNMMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int GGIIDBHIIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public long EDIFJILFAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public long IAJNFBHBAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public float DIIBIMCAIOO;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8539F70", Offset = "0x8538570", VA = "0x188539F70")]
		public void PNHKIAJGEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8539EF0", Offset = "0x85384F0", VA = "0x188539EF0")]
		public void CKBKAMMKCLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private static readonly string PKIEJFKGAPH;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private static readonly string DPPELBJOILP;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private static readonly ProfilerMarker NEJKICNGBDK;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private static readonly ProfilerMarker EPFIJNAEPBP;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private static readonly ProfilerMarker BLJPPAMEJHK;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private static readonly ProfilerMarker HGALMMKCJGG;

	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private static readonly ProfilerMarker MEADMHDCBGG;

	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private static readonly ProfilerMarker PKDDCFCAFIK;

	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private static readonly ProfilerMarker GMKENCIECCK;

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private static readonly ProfilerMarker KAHOFEFBCKO;

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly ProfilerMarker ELCMLDICKDH;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly ProfilerMarker MIPKBNLPJIN;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly ProfilerMarker CHEMGEFDAJP;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly ProfilerMarker PLGPKJFEODK;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly ProfilerMarker FIJGKOKDDFO;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker EJDFJHOEFGI;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker FHHFKJLGFNK;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker MBGNDJOCGBC;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker AKAOKLBDCHH;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker BIEPOABHDHB;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker NCNNLGBEPKA;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker GKOMNIIEGBN;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker JNJPPCEIOBF;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker CCDJHAGGGLE;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker HKLFHAOIGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	internal readonly List<EFJMOLMIFDJ> OJKALEKNNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	internal KOBHAJKIGLO EBPGCGCEFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private readonly EDAJBCAFGNC OEFCEIMHNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	internal int AGJBBCDOIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	internal int CEKDNBMOLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	internal bool AIHPAHNAKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	internal bool BMHLHGOKKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	internal PBBIADGNHBC NNBKKNNLKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	internal bool EMPLKBDHEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	internal float3 GDKOBBGKPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal float3 LMCEAGEBIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal float IHCAJJNDJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal int GKHBHEKPCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal int JMIAIOPPEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal int BKMEMONOOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal float JKMHACBEPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	internal int NNIOLHFNGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal float FIIIHALFFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal float LJNAGABHLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal int BOINHIOILLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal long DMMBOAFENOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public int JNFPMHDIIEG;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal const int ADFGKDJJKIE = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal float[] JDDOIBBOKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal int[] DANKOBFPIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal long[] EANOJILHDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public List<OPPJJAADFKL> CJPIBKFJGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal KGBENKDOKKC OFDPOBKEPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal long LBDFIIAFBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal int PBMCCHHGEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal float KBGKKOHJLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal KGBENKDOKKC.GHJDECIPEEC LOGFMMINMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	internal GKDOCEBGLOE JOOIGANIINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal int ONBKDNADOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float JPMGJEGEPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal long CJNPBGOMEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal bool JOHHCEMAIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	internal GPPGNIDLGMM PECMFBEBBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal JobHandle HCJGNHGMBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal NativeList<AHFEFOFKAHD> LFLKOHMDBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal NativeArray<long> NIHBJGNFKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal bool NIHKBFFHEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal JobHandle NFGFJKAHLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal KGBENKDOKKC AKHEAIFAGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	internal LFLKEFBIKOE JLBLGIDFIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal NativeList<AHFEFOFKAHD> NJHLKEJNHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal Transform CBPADPKENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal ICFDOFGDKLP AEAECGJBJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal long NLGDNNGGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	internal long JAPBFKHIGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal long KMIJNMDPFCO;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private static bool LFFGGPKLBHE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public List<EFJMOLMIFDJ> NIDNPIJAIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	internal int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x852A520", Offset = "0x8528B20", VA = "0x18852A520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x852EC00", Offset = "0x852D200", VA = "0x18852EC00")]
	internal void MGKHJNPFAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8529570", Offset = "0x8527B70", VA = "0x188529570")]
	internal void ACALODHDFMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8533270", Offset = "0x8531870", VA = "0x188533270")]
	internal IMKEGNCFDHD(string DJFMCHMDHGK, KOBHAJKIGLO IGDHFGFJBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x852A540", Offset = "0x8528B40", VA = "0x18852A540")]
	internal void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x852C060", Offset = "0x852A660", VA = "0x18852C060")]
	internal void EHPIEOKHPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x852B0B0", Offset = "0x85296B0", VA = "0x18852B0B0")]
	internal void DBFMAOMBPGJ(EFJMOLMIFDJ MGMEFHAFOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x852D620", Offset = "0x852BC20", VA = "0x18852D620")]
	internal bool JABNKJJBGEA(EFJMOLMIFDJ MGMEFHAFOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8529730", Offset = "0x8527D30", VA = "0x188529730")]
	internal bool BDAGELPEHAC(EFJMOLMIFDJ MGMEFHAFOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x85296B0", Offset = "0x8527CB0", VA = "0x1885296B0", Slot = "4")]
	internal virtual void AGKINELFJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x852EF40", Offset = "0x852D540", VA = "0x18852EF40")]
	public float NDNLNPDDBLF(float COBGABNAGIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x8532930", Offset = "0x8530F30", VA = "0x188532930")]
	public bool PBEOGLDOIHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8529EF0", Offset = "0x85284F0", VA = "0x188529EF0")]
	public (GKDOCEBGLOE, KGBENKDOKKC.GHJDECIPEEC) CGFEMMFAPKB()
	{
		return default((GKDOCEBGLOE, KGBENKDOKKC.GHJDECIPEEC));
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x852D6A0", Offset = "0x852BCA0", VA = "0x18852D6A0")]
	internal long JDBMLBJEIHA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x852D4F0", Offset = "0x852BAF0", VA = "0x18852D4F0")]
	internal long HBIGLLEADGG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x852C840", Offset = "0x852AE40", VA = "0x18852C840")]
	internal bool FFMJGCMAFIH(Transform EPBCOOIGAEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x8531AC0", Offset = "0x85300C0", VA = "0x188531AC0")]
	internal bool OPAAGEOKONC(bool AKHIMJBDLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x8530040", Offset = "0x852E640", VA = "0x188530040")]
	internal void NPKLGNALHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8530A70", Offset = "0x852F070", VA = "0x188530A70")]
	internal bool OEPPOMDFEMD(float4x4 CDOMFLOAMJF, BatchedMeshRenderer EMEJIFHGFEB, bool LOLJLFNICFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x8529790", Offset = "0x8527D90", VA = "0x188529790")]
	internal bool BOEMJJHBDHA(bool AKHIMJBDLIC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x852D610", Offset = "0x852BC10", VA = "0x18852D610")]
	internal void HCOGFHCLDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x852E940", Offset = "0x852CF40", VA = "0x18852E940")]
	internal void LKCBKHLCHKE(KGBENKDOKKC LJNJDNJBNIE, int NCDGIIGKKOB, int IDOECCKDGLJ, float PGAIKFAJHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x852E970", Offset = "0x852CF70", VA = "0x18852E970")]
	internal void LPPENNHFPHP(GKDOCEBGLOE FCMFIMEEPDA, int NCDGIIGKKOB, int IDOECCKDGLJ, float PGAIKFAJHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x852C440", Offset = "0x852AA40", VA = "0x18852C440")]
	internal void EPPIFLCJMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x8529A40", Offset = "0x8528040", VA = "0x188529A40")]
	internal (long, long, int) CDKCCEOELAL(float DHFNBEBIIMF, float4x4 CDOMFLOAMJF, float JCHEGCAHAJG)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xAA2490", Offset = "0xAA0A90", VA = "0x180AA2490")]
	internal void CIELEGCDDFO(PBBIADGNHBC KGILCHBPJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x852D750", Offset = "0x852BD50", VA = "0x18852D750")]
	public static (float, float, float, float) KEPDAAFNIOH(float3 NFJAMANCLGK, float3 GNLPBMPHCIA, float IDPOGACGLCD, float4x4 CDOMFLOAMJF, float JCHEGCAHAJG)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x852DB40", Offset = "0x852C140", VA = "0x18852DB40")]
	internal (float, float, float, float) KEPDAAFNIOH(float IDPOGACGLCD, float4x4 CDOMFLOAMJF, float JCHEGCAHAJG)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x8532B30", Offset = "0x8531130", VA = "0x188532B30")]
	private float PENJEDFAPJA(float IDPOGACGLCD, float4x4 CDOMFLOAMJF, float JCHEGCAHAJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x8529000", Offset = "0x8527600", VA = "0x188529000")]
	private (int, int, float) AANINIEAHOL(float KOBOJMODLHG)
	{
		return default((int, int, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x852FF90", Offset = "0x852E590", VA = "0x18852FF90")]
	internal static float NMINPIJFCIK(EFJMOLMIFDJ LJNJDNJBNIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x852F030", Offset = "0x852D630", VA = "0x18852F030")]
	internal void NEMICHFFGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8531A30", Offset = "0x8530030", VA = "0x188531A30")]
	internal void OIGNGOGLMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x852EC10", Offset = "0x852D210", VA = "0x18852EC10")]
	internal void MJDIPNBPLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x852B960", Offset = "0x8529F60", VA = "0x18852B960")]
	internal long DMBFCFJPCNC(long BAKBAMCNEGI, int NIHGELCDOFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x852DD80", Offset = "0x852C380", VA = "0x18852DD80")]
	private void LJCCDHAKDJP(KGBENKDOKKC GEDMJFIHBCF, NativeList<AHFEFOFKAHD> JEOFLKCPCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8530690", Offset = "0x852EC90", VA = "0x188530690")]
	internal void OEDAHGLCADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x852B2D0", Offset = "0x85298D0", VA = "0x18852B2D0")]
	public static void DHHLALOHDBD(NativeList<AHFEFOFKAHD> HCANIIALFEB, KGBENKDOKKC GEDMJFIHBCF, int JLMKBBEFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8530600", Offset = "0x852EC00", VA = "0x188530600")]
	private float ODJLCGOGCBH(int MIHJAOCGNMG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x852A670", Offset = "0x8528C70", VA = "0x18852A670")]
	internal void CPLMBCAMDOH(KGBENKDOKKC LJNJDNJBNIE, DJFJNPGBIKP FCMFIMEEPDA, int NCDGIIGKKOB, int IDOECCKDGLJ, float PGAIKFAJHND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BurstCompile]
internal struct EDMDHAOGPGC : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal struct BEJLOGGJHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int GICLIPMADBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int NGIJEDEHHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int MGLPDFAIFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public float OPFGCDBONHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float ILJDFNDAHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float GHFIOFDJNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public float AGMOBCKBKMH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	internal struct LKLADLKIPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int GICLIPMADBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int NGIJEDEHHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int MGLPDFAIFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int DKDCIBCIGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float OPFGCDBONHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public float ILJDFNDAHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public float PIKBHJBGBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public float FJHCDFGKIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public float AGMOBCKBKMH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public struct GHCKFCBLJPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int MNLHDBHFLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int GDNFNEOCBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public float LNJLJHGLPIO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public delegate void EPELDGPBLHF(EDMDHAOGPGC AJNNFPKOAJN, [In] BEJLOGGJHPG MIFBELIBBGM);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class ONCCPFANECD
	{
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x854AFC0", Offset = "0x85495C0", VA = "0x18854AFC0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x854ABC0", Offset = "0x85491C0", VA = "0x18854ABC0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x854AF10", Offset = "0x8549510", VA = "0x18854AF10")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x854AD20", Offset = "0x8549320", VA = "0x18854AD20")]
		public static void JKGEGDFKKNG(EDMDHAOGPGC AJNNFPKOAJN, [In] BEJLOGGJHPG MIFBELIBBGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void LCLLIHACEEJ(EDMDHAOGPGC AJNNFPKOAJN, [In] LKLADLKIPKN MMGKCBHCELA);

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal static class IGEBICBCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8549550", Offset = "0x8547B50", VA = "0x188549550")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8549150", Offset = "0x8547750", VA = "0x188549150")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x85494A0", Offset = "0x8547AA0", VA = "0x1885494A0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x85492B0", Offset = "0x85478B0", VA = "0x1885492B0")]
		public static void JKGEGDFKKNG(EDMDHAOGPGC AJNNFPKOAJN, [In] LKLADLKIPKN MMGKCBHCELA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public unsafe delegate void BEHBGCMDEEK(UnsafeList<int>* KLKIKAFHAFL, UnsafeList<float3>* OOJBEABCGHK, [NoAlias] float3* DCJCPGMMJBL, [NoAlias] float4* JMEEABJKEHL, [NoAlias] float2* MDOMICLIGOJ, [NoAlias] float4* BJAPPHEFIEJ, UnsafeList<HCPKEPDEOID>* ALAEOFBMBOE, UnsafeList<int>* DJHIMJOMDBG, UnsafeList<float3>* GJJOONIMBKL, [NoAlias] float3* ANNIEKLOHLK, [NoAlias] float4* BJILKGLIPCD, [NoAlias] float2* NHOLJFIJIOF, [NoAlias] float4* DJKKNPCFIOK, int MCHFPDKIKIK, int KOOADCCLMIG);

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal static class HNIIHPNAIBB
	{
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x8549020", Offset = "0x8547620", VA = "0x188549020")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8548AD0", Offset = "0x85470D0", VA = "0x188548AD0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8548F70", Offset = "0x8547570", VA = "0x188548F70")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8548C30", Offset = "0x8547230", VA = "0x188548C30")]
		public unsafe static void JKGEGDFKKNG(UnsafeList<int>* KLKIKAFHAFL, UnsafeList<float3>* OOJBEABCGHK, [NoAlias] float3* DCJCPGMMJBL, [NoAlias] float4* JMEEABJKEHL, [NoAlias] float2* MDOMICLIGOJ, [NoAlias] float4* BJAPPHEFIEJ, UnsafeList<HCPKEPDEOID>* ALAEOFBMBOE, UnsafeList<int>* DJHIMJOMDBG, UnsafeList<float3>* GJJOONIMBKL, [NoAlias] float3* ANNIEKLOHLK, [NoAlias] float4* BJILKGLIPCD, [NoAlias] float2* NHOLJFIJIOF, [NoAlias] float4* DJKKNPCFIOK, int MCHFPDKIKIK, int KOOADCCLMIG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public float3 ENCMOPHHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public float KHEOIJHDAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public float LMIMPAPGKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public float NLDILLCOMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public HLLPFHAANOG.ADPEMKOKFJO JAIAIOLALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public bool AEIMCHOMMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<HCPKEPDEOID>* ALAEOFBMBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* DJHIMJOMDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<BEJLOGGJHPG>* JNDEEFIIPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<BEJLOGGJHPG>* NFHMFMJKFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<LKLADLKIPKN>* CKJAJOIJBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<LKLADLKIPKN>* DEOCOHLALKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public int GHKALNBMCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public int LKODDFJGDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public int IIJLMJGELAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe float3* GJJOONIMBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe int* AMHELMKCBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe GHCKFCBLJPP* CJDAJOJGDLD;

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x85279C0", Offset = "0x8525FC0", VA = "0x1885279C0")]
	private static float MLKKLBKGGJN([In] EDMDHAOGPGC AJNNFPKOAJN, [In] float3 FMIHOAGGDLL, float AGMOBCKBKMH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x8528E80", Offset = "0x8527480", VA = "0x188528E80")]
	private static int PCCNHJHAKGA(EDMDHAOGPGC AJNNFPKOAJN, [Out] HCPKEPDEOID HFELLLCMOCC, [In] HCPKEPDEOID NPGFOLHJFKO, [In] HCPKEPDEOID KALCLPKKMLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8526EC0", Offset = "0x85254C0", VA = "0x188526EC0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void CDCAFLAKMKP(EDMDHAOGPGC AJNNFPKOAJN, [In] BEJLOGGJHPG MIFBELIBBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x85278D0", Offset = "0x8525ED0", VA = "0x1885278D0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void IPCLLPDABMD(EDMDHAOGPGC AJNNFPKOAJN, [In] LKLADLKIPKN MMGKCBHCELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x8526F20", Offset = "0x8525520", VA = "0x188526F20", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x8527A40", Offset = "0x8526040", VA = "0x188527A40")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal void NGJNAIKDHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8527930", Offset = "0x8525F30", VA = "0x188527930")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void JJPHEKBLCOP(UnsafeList<int>* KLKIKAFHAFL, UnsafeList<float3>* OOJBEABCGHK, [NoAlias] float3* DCJCPGMMJBL, [NoAlias] float4* JMEEABJKEHL, [NoAlias] float2* MDOMICLIGOJ, [NoAlias] float4* BJAPPHEFIEJ, UnsafeList<HCPKEPDEOID>* ALAEOFBMBOE, UnsafeList<int>* DJHIMJOMDBG, UnsafeList<float3>* GJJOONIMBKL, [NoAlias] float3* ANNIEKLOHLK, [NoAlias] float4* BJILKGLIPCD, [NoAlias] float2* NHOLJFIJIOF, [NoAlias] float4* DJKKNPCFIOK, int MCHFPDKIKIK, int KOOADCCLMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x8526F30", Offset = "0x8525530", VA = "0x188526F30")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void HLGLKJCHDHE(EDMDHAOGPGC AJNNFPKOAJN, [In] BEJLOGGJHPG MIFBELIBBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x85266B0", Offset = "0x8524CB0", VA = "0x1885266B0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void ALNIHIGOFEK(EDMDHAOGPGC AJNNFPKOAJN, [In] LKLADLKIPKN MMGKCBHCELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x8528770", Offset = "0x8526D70", VA = "0x188528770")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void NIGGJCDCOEE(UnsafeList<int>* KLKIKAFHAFL, UnsafeList<float3>* OOJBEABCGHK, [NoAlias] float3* DCJCPGMMJBL, [NoAlias] float4* JMEEABJKEHL, [NoAlias] float2* MDOMICLIGOJ, [NoAlias] float4* BJAPPHEFIEJ, UnsafeList<HCPKEPDEOID>* ALAEOFBMBOE, UnsafeList<int>* DJHIMJOMDBG, UnsafeList<float3>* GJJOONIMBKL, [NoAlias] float3* ANNIEKLOHLK, [NoAlias] float4* BJILKGLIPCD, [NoAlias] float2* NHOLJFIJIOF, [NoAlias] float4* DJKKNPCFIOK, int MCHFPDKIKIK, int KOOADCCLMIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class CACGEFAJBJE
{
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private static readonly ProfilerMarker ODDJHBGABKD;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public const int LKCOCFEHMJO = 2;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private const int JJEJKJONLOB = 1;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private static int EMIHOCPIPGA;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private static Stack<CACGEFAJBJE> PHBJPKCAIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private KGBENKDOKKC IOADIOBFAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private NativeList<HCPKEPDEOID> ALAEOFBMBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private NativeList<int> DJHIMJOMDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private NativeList<EDMDHAOGPGC.BEJLOGGJHPG> JNDEEFIIPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private NativeList<EDMDHAOGPGC.BEJLOGGJHPG> NFHMFMJKFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private NativeList<EDMDHAOGPGC.LKLADLKIPKN> CKJAJOIJBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private NativeList<EDMDHAOGPGC.LKLADLKIPKN> DEOCOHLALKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private EDMDHAOGPGC AJNNFPKOAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private JobHandle ELCAJJNPFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private EDMDHAOGPGC.GHCKFCBLJPP LHECGJEGBLM;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private const int IIJLMJGELAI = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x85447D0", Offset = "0x8542DD0", VA = "0x1885447D0")]
	private CACGEFAJBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x8543E60", Offset = "0x8542460", VA = "0x188543E60")]
	public void IFPGKIINEBP(KGBENKDOKKC OFIMOHALJBC, float3 IECDGBJIPPM, float OFGPHLHBOIK, float NPHAGJLLNHK, float OFJCFGHEKHE, List<IMKEGNCFDHD.AHFEFOFKAHD> EEPGMNALHMD, Allocator MFLJKOKHKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8543620", Offset = "0x8541C20", VA = "0x188543620")]
	public (bool, KGBENKDOKKC, float) BKCDGICEDAP(List<IMKEGNCFDHD.AHFEFOFKAHD> EEPGMNALHMD, Allocator MFLJKOKHKKH, bool AKHIMJBDLIC)
	{
		return default((bool, KGBENKDOKKC, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x85442C0", Offset = "0x85428C0", VA = "0x1885442C0")]
	public static bool LJEIPKBOFFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8544270", Offset = "0x8542870", VA = "0x188544270")]
	public static int LGPNKIHCCMD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8544670", Offset = "0x8542C70", VA = "0x188544670")]
	public static int OJGHAGJOHKC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8543D00", Offset = "0x8542300", VA = "0x188543D00")]
	public static CACGEFAJBJE DNGHIBLHEHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8543C60", Offset = "0x8542260", VA = "0x188543C60")]
	internal static void DCDMOJCENBM(CACGEFAJBJE MDIJAHOILEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8544500", Offset = "0x8542B00", VA = "0x188544500")]
	public static void ODGJCPFNKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x8544350", Offset = "0x8542950", VA = "0x188544350")]
	[FGLGCOAFHPJ(DAODBNEOINB.ExitingPlayMode, 0)]
	public static void NHDIFLHDBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BurstCompile]
internal struct HCPKEPDEOID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public float3 DPLNHDFCMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public int MMGCDCABNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public int PGACOHBGGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public int IJGFPIOPMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public float PAIAKGGDJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public float AEJODCKMMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public int FCHADEOOLGC;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x8548790", Offset = "0x8546D90", VA = "0x188548790")]
	public static void EEPJBIPIECL([Out] HCPKEPDEOID CENCPMGPALN, int NHIFFJBBLNI, [In] float3 LDFLGECLFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x85487E0", Offset = "0x8546DE0", VA = "0x1885487E0")]
	[IgnoreWarning(1371)]
	public static void EEPJBIPIECL([Out] HCPKEPDEOID CENCPMGPALN, [In] HCPKEPDEOID HPDACPPDBNC, [In] HCPKEPDEOID EGPNAPLBFFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BurstCompile]
internal struct GPPGNIDLGMM : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct BFCDEFILLFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int FCIPDPEDAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public int LGAPCPJFOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int KEPLEDAKPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int EHMBALKKHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int BCCEPNAJHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int GCNOCPHEIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public int FOJNKKNMMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int GGIIDBHIIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public float EKMECICLMAO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private struct FOEPFIEPMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public HLLPFHAANOG.CPAGPJNKKGH CALONPNAFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public float NDOKMOMKJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public float DFFCBJHEEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public float DCPNNAKDAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public float NDDCGMANHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public float FCHHHCLKPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public float FGKNLMBAGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public float MGLNNLLHHJP;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private struct GAEGOALAJBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeArray<float3> KMOFPFFJFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeArray<float3> MICGNOBMLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeArray<float4> PKHILEILDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeArray<float4> NKKLIONHANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public NativeArray<float2> BBBDHIHCGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public NativeArray<int> JEAGFLJKHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public bool IJGKJPPBJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int MHODMACGMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int EDNLPJDMDPL;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8544C80", Offset = "0x8543280", VA = "0x188544C80")]
		public void LKNCAMJABCH(int KOOADCCLMIG, int MCHFPDKIKIK, Allocator EKNOCGFFMAE, bool DCBFFDICCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8544970", Offset = "0x8542F70", VA = "0x188544970")]
		public static GAEGOALAJBD BNPCCNOBFGN(KGBENKDOKKC JHGKHIGHBBL)
		{
			return default(GAEGOALAJBD);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8544BC0", Offset = "0x85431C0", VA = "0x188544BC0")]
		public void CKBKAMMKCLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private static readonly ProfilerMarker GJNFBFKGFJI;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private static readonly ProfilerMarker LFPLEPDHNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private NativeArray<BFCDEFILLFF> AMEAAJDMPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private GAEGOALAJBD FLHMHAPAIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private GAEGOALAJBD GEDMJFIHBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private float3 GDPGNOGPANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private float3 CINHMHPEHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private FOEPFIEPMLL JKDKBNOLNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* ONJBKNCJIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<IMKEGNCFDHD.AHFEFOFKAHD> IBELFCPMEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NativeList<IMKEGNCFDHD.AHFEFOFKAHD> JCLMDPKCPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NativeArray<int> DJHIMJOMDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private NativeArray<bool> FOCOOOBFCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private NativeArray<int> JMGBOLKGJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private NativeArray<int> MHJMNEPAIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private NativeArray<float> DHKPLJPPHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private NativeArray<int> PLJBGFJDIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NativeArray<float> FDDIEFDLEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NativeArray<int> GOKMOEHAAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NativeArray<int> IKIBFCJKAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private NativeArray<float> NIGPBICNFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private NativeArray<float> AFHCGJDJJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private NativeArray<int> CBGMDDGODAL;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x8547EC0", Offset = "0x85464C0", VA = "0x188547EC0")]
	public GPPGNIDLGMM([In] List<IMKEGNCFDHD.OPPJJAADFKL> DAJJHALFAIN, NativeList<IMKEGNCFDHD.AHFEFOFKAHD> GIGNGNKIFPE, [In] KGBENKDOKKC INABPIAIDCC, [In] NativeList<IMKEGNCFDHD.AHFEFOFKAHD> JEOFLKCPCAJ, [In] NativeArray<long> NIHBJGNFKMD, float3 NHKGCLJGMNF, float3 AJOJKIMIKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x8547BB0", Offset = "0x85461B0", VA = "0x188547BB0")]
	public static long NCBDOFABBOA(int KOOADCCLMIG, int MCHFPDKIKIK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8545360", Offset = "0x8543960", VA = "0x188545360", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x8547160", Offset = "0x8545760", VA = "0x188547160")]
	public void LCBBKKKHHLG(List<IMKEGNCFDHD.OPPJJAADFKL> BEPFDMJBFFO, [In] IMKEGNCFDHD ILCLDLMHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x8547E00", Offset = "0x8546400", VA = "0x188547E00")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private bool NPDEHCLBMEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x8547BD0", Offset = "0x85461D0", VA = "0x188547BD0")]
	private GKDOCEBGLOE NFKAOKHBOKJ(int AMPGGGCNMFL, Allocator EKNOCGFFMAE)
	{
		return default(GKDOCEBGLOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x8545A20", Offset = "0x8544020", VA = "0x188545A20")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void IFCKNAPEBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x85453B0", Offset = "0x85439B0", VA = "0x1885453B0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float GPHIIOPOHLH(int PLOBIOAGNKJ, int EMCBIOIABFE, bool OFLEDPKDDGL, bool GEBGHMNBPND, float FKPIJGDKEIJ, float GDKMDAOBOOB, float FFKAFDCKLMK, float JCGBEJGOGNJ, float LPCMOFBNLBJ, float OGHHEHKNLFG, float JKCGBJKMPNI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x8544E60", Offset = "0x8543460", VA = "0x188544E60")]
	[IgnoreWarning(1371)]
	private BFCDEFILLFF CLHHCDJLEBB([In] BFCDEFILLFF GCLKGNPCGNO, int GNNCIDOGMJK, [In] NativeArray<int> IFAGBCNDJLL, [In] NativeArray<bool> FOCOOOBFCCD, NativeArray<int> JMGBOLKGJIF)
	{
		return default(BFCDEFILLFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x8545180", Offset = "0x8543780", VA = "0x188545180")]
	public static int EJNNGINNOHD(NativeArray<int> IFAGBCNDJLL, NativeArray<int> CBGMDDGODAL, int CEFNIDJCHED, int HHHJIIHEBKG, int GKDHFGPHIML)
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
		private struct JNDJDGIGLMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public long IKDOIPGFDEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public GLGFFNDJOPA FBDMHHADOPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public EFJMOLMIFDJ NDLHPLKACFL;

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x8549680", Offset = "0x8547C80", VA = "0x188549680")]
			public JNDJDGIGLMJ(GLGFFNDJOPA OPACONIPADF, EFJMOLMIFDJ IPEELMOHBOP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		private class BJBKOOONALB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public GLGFFNDJOPA FBDMHHADOPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public int GAELDOPGMHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public float IHCAJJNDJMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public List<JNDJDGIGLMJ> IIAOGHHEBMG;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x853C930", Offset = "0x853AF30", VA = "0x18853C930")]
			public BJBKOOONALB(GLGFFNDJOPA OPACONIPADF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private static readonly ProfilerMarker EFOBIADHLCB;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private static readonly ProfilerMarker PKICMAJLEOO;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private static readonly ProfilerMarker OAJEALAOAIG;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private static readonly ProfilerMarker LGKHNMIKBIJ;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private static readonly ProfilerMarker LIJEOMCPIPM;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private static readonly ProfilerMarker GMKENCIECCK;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private static readonly ProfilerMarker INGCNDADAJN;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		internal const int LDFOFIEINEJ = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		internal static Dictionary<Material, List<Material>> LPLGIHFFJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private Dictionary<Material, List<KOBHAJKIGLO>> PEGFPIJLBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		internal List<KOBHAJKIGLO> KHGDCEDKFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private List<MeshRenderer> GHCHGLBIHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private Transform HNGLPJEGNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private bool LEIIOEINFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private bool EOCHNOBOLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private int LKIPIEEEPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private KOBHAJKIGLO FIFOLNECEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private Material JJNNHFGMMHG;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static bool? FFNDNJMAMDO;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private const int FKJNHKOKMGK = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private static List<JNDJDGIGLMJ> AMEBFPKIJIK;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyList<MeshRenderer> GBKPINKAJCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int PJKBDFMGLCE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x85435D0", Offset = "0x8541BD0", VA = "0x1885435D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private static bool GNKBPECILMF
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x853F000", Offset = "0x853D600", VA = "0x18853F000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private static void OMAKILKAJDG(bool MHNNEIDGMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private static void OMAKILKAJDG(bool MHNNEIDGMOP, string IFEHDCDCFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private static void KCCDBIPOEPF(string DJFMCHMDHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x853CEE0", Offset = "0x853B4E0", VA = "0x18853CEE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x853CF10", Offset = "0x853B510", VA = "0x18853CF10")]
		internal bool BADNBKKMFDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x853EE80", Offset = "0x853D480", VA = "0x18853EE80")]
		private Transform IGPCLOICOJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x853F9F0", Offset = "0x853DFF0", VA = "0x18853F9F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x853D8F0", Offset = "0x853BEF0", VA = "0x18853D8F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x853CCC0", Offset = "0x853B2C0", VA = "0x18853CCC0")]
		public KOBHAJKIGLO AddToBatchedMesh(EFJMOLMIFDJ CNBEJCGNBKM, Material JKDFAJLFBEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8542F90", Offset = "0x8541590", VA = "0x188542F90")]
		public void RemoveFromBatchedMesh(EFJMOLMIFDJ LJNJDNJBNIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x853D7C0", Offset = "0x853BDC0", VA = "0x18853D7C0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x853EF80", Offset = "0x853D580", VA = "0x18853EF80")]
		private void JCGIDLLOILJ(Renderer PHHDHBAFNEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x853EF10", Offset = "0x853D510", VA = "0x18853EF10")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x853EF00", Offset = "0x853D500", VA = "0x18853EF00")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x853CF70", Offset = "0x853B570", VA = "0x18853CF70")]
		private void CKHBHMCCAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x853F290", Offset = "0x853D890", VA = "0x18853F290")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x853F7D0", Offset = "0x853DDD0", VA = "0x18853F7D0")]
		private KOBHAJKIGLO ONLONJOOJMO(EFJMOLMIFDJ LJNJDNJBNIE, Material JKDFAJLFBEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x853C9E0", Offset = "0x853AFE0", VA = "0x18853C9E0")]
		private KOBHAJKIGLO AFIKMCOOEMI(Material JKDFAJLFBEL, int DMKHNFIAJLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x853DD00", Offset = "0x853C300", VA = "0x18853DD00")]
		private KOBHAJKIGLO EIJKMGJDHKA(Material JKDFAJLFBEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x853EDE0", Offset = "0x853D3E0", VA = "0x18853EDE0")]
		internal float4x4 HACHMFIDFKO()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x853E630", Offset = "0x853CC30", VA = "0x18853E630")]
		public static List<Material> GenerateVertexFormatVariants(Material JKDFAJLFBEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x85430D0", Offset = "0x85416D0", VA = "0x1885430D0")]
		public static void UpdateMaterialVariants(Material NFJJOEDBHLH, Action<Material> CPPMGJEJBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1279570", Offset = "0x1277B70", VA = "0x181279570")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x853F130", Offset = "0x853D730", VA = "0x18853F130")]
		public void MarkDirty(EFJMOLMIFDJ LJNJDNJBNIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x853E530", Offset = "0x853CB30", VA = "0x18853E530")]
		[Conditional("CHECK_STATE")]
		private void EIOPCONPKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x853F3F0", Offset = "0x853D9F0", VA = "0x18853F3F0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float DHFNBEBIIMF)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x853D690", Offset = "0x853BC90", VA = "0x18853D690")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x85419B0", Offset = "0x853FFB0", VA = "0x1885419B0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x853E750", Offset = "0x853CD50", VA = "0x18853E750")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x853FAE0", Offset = "0x853E0E0", VA = "0x18853FAE0")]
		public void RebatchOptimally(int EBKFMKHIJJN, int JGHAPMHBJBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x853FA00", Offset = "0x853E000", VA = "0x18853FA00")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x85434A0", Offset = "0x8541AA0", VA = "0x1885434A0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class PHIFEHFKBCP
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct EMFBCDGJPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public BatchedMeshRenderer PHHDHBAFNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public KOBHAJKIGLO LJNJDNJBNIE;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1CE8E40", Offset = "0x1CE7440", VA = "0x181CE8E40")]
		public void JDFHFKEGAEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct KHNCCDOLOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public float BCKKKIFNJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public KOBHAJKIGLO AAHGDDMIOAA;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class OKHDHLMNJCN : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <batchesPerYield>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private int <countdownBeforeYield>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private int <batchSizeNaughty>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private int <batchSizeNice>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x130DD00", Offset = "0x130C300", VA = "0x18130DD00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x854AA50", Offset = "0x8549050", VA = "0x18854AA50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x154FAF0", Offset = "0x154E0F0", VA = "0x18154FAF0")]
		[DebuggerHidden]
		public OKHDHLMNJCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x854AAA0", Offset = "0x85490A0", VA = "0x18854AAA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8549700", Offset = "0x8547D00", VA = "0x188549700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x854A900", Offset = "0x8548F00", VA = "0x18854A900")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x85496B0", Offset = "0x8547CB0", VA = "0x1885496B0")]
		private void LGNDDFAIONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x854AA00", Offset = "0x8549000", VA = "0x18854AA00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x854A950", Offset = "0x8548F50", VA = "0x18854A950", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x854A950", Offset = "0x8548F50", VA = "0x18854A950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private static readonly ProfilerMarker GMKENCIECCK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private static readonly ProfilerMarker LCPNDIFKOOB;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly ProfilerMarker MLFMCCIEJIG;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly ProfilerMarker EIJIAOKCHBH;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static float3 JHODJDPJBIE;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static int PGHPDEPABOG;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static int MHBDLKOLOOI;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static int NHACEEDDKIB;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static int GICEOIADPNH;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static int KJBPJJINIGJ;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static float CJAPINMLIAF;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static float FLNCADIIKJA;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static float LDLMPHDNCEC;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static float DGHNFADCKLF;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static float PCKBPDHGAIM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static float ODECCGBOLGL;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static float HCPCPENCLJH;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static float PBLCNPBPNML;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static List<BatchedMeshRenderer> MGNAIIFHMID;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static Stack<KGBENKDOKKC> PIFMGAJDPPB;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static Stack<LFLKEFBIKOE> CECLMEPMPIH;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static KPOKAGBLPPC PHMACIMNIMG;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private static EMFBCDGJPKM MKLHBMOIBDD;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static int IPFPIDBPAJO;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void OMAKILKAJDG(bool MHNNEIDGMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void CGCICMOHIIG(bool MHNNEIDGMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void OMAKILKAJDG(bool MHNNEIDGMOP, string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x854E630", Offset = "0x854CC30", VA = "0x18854E630")]
	public static void PNHKIAJGEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x854D420", Offset = "0x854BA20", VA = "0x18854D420")]
	public static void KIBAEMFAPDE(BatchedMeshRenderer EIKAAGNBHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x854B0F0", Offset = "0x85496F0", VA = "0x18854B0F0")]
	public static void BEHFFGNBONF(BatchedMeshRenderer EIKAAGNBHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x854CCB0", Offset = "0x854B2B0", VA = "0x18854CCB0")]
	public static void JLFPNEDIEBO(EFJMOLMIFDJ MGMEFHAFOOD, bool FAPBNHEBFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x854E000", Offset = "0x854C600", VA = "0x18854E000")]
	public static void OGFJAHAOHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x854D740", Offset = "0x854BD40", VA = "0x18854D740")]
	public static void OEPPOMDFEMD(float DHFNBEBIIMF, bool DCKDEGOIPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x854C630", Offset = "0x854AC30", VA = "0x18854C630")]
	private static void GENNALBDGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x854B6F0", Offset = "0x8549CF0", VA = "0x18854B6F0")]
	public static long DMBFCFJPCNC(int NIHGELCDOFD, long BAKBAMCNEGI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x854B3A0", Offset = "0x85499A0", VA = "0x18854B3A0")]
	public static (long, long, int) CDKCCEOELAL(float DHFNBEBIIMF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x854C5A0", Offset = "0x854ABA0", VA = "0x18854C5A0")]
	[IteratorStateMachine(typeof(OKHDHLMNJCN))]
	public static IEnumerable<bool> FIFNJJJMDDL(long NNHDNLKJCFC, bool IOLNPICENFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x854C340", Offset = "0x854A940", VA = "0x18854C340")]
	public static void EPCBOMDCEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x854E380", Offset = "0x854C980", VA = "0x18854E380")]
	public static void OJJNENJCGHA(long NNHDNLKJCFC, bool IOLNPICENFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x854CB30", Offset = "0x854B130", VA = "0x18854CB30")]
	public static int GJJKJGADHNF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x854B220", Offset = "0x8549820", VA = "0x18854B220")]
	internal static KGBENKDOKKC CBMFGEAIELF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x854B5B0", Offset = "0x8549BB0", VA = "0x18854B5B0")]
	internal static void DCDMOJCENBM(KGBENKDOKKC BIEPLCJMKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x854C1F0", Offset = "0x854A7F0", VA = "0x18854C1F0")]
	internal static LFLKEFBIKOE EIBFGOIOKKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x854B660", Offset = "0x8549C60", VA = "0x18854B660")]
	internal static void DCDMOJCENBM(LFLKEFBIKOE FLIGBOGNEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x854D560", Offset = "0x854BB60", VA = "0x18854D560")]
	public static void ODGJCPFNKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class KNILPDPOFCI<KeyType> : KOBHAJKIGLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly Dictionary<KeyType, EFJMOLMIFDJ> NBDIJHANFFP;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x560A830", Offset = "0x5608E30", VA = "0x18560A830")]
	public KNILPDPOFCI(string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x560A4C0", Offset = "0x5608AC0", VA = "0x18560A4C0")]
	public void DEJDNKOJJPA(KeyType HFLDIIIPBCG, EFJMOLMIFDJ MGMEFHAFOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x560A670", Offset = "0x5608C70", VA = "0x18560A670")]
	public bool OIHEOMDGAPO(KeyType HFLDIIIPBCG, EFJMOLMIFDJ CKNKDLIPEDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x560A5C0", Offset = "0x5608BC0", VA = "0x18560A5C0")]
	public void KIGFHNOIBOL(KeyType HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x560A480", Offset = "0x5608A80", VA = "0x18560A480", Slot = "4")]
	public override void AGKINELFJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class AGCMKEHCGBB
{
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly ProfilerCategory EKIPHOEFEIF;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	internal static readonly ProfilerMarker JAJPLDMLJOF;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	internal static readonly PHIBLNCDEGC OEPPOMDFEMD;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly AFPMEIHEKKD<float> ODFHGPDINLH;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly AFPMEIHEKKD<float> LLICABJIOEK;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly AFPMEIHEKKD<float> HLGGMNDHCJM;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static readonly AFPMEIHEKKD<double> NNEAKHLINKI;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly AFPMEIHEKKD<double> BGLIEGPEAEF;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly AFPMEIHEKKD<double> LGJEIIACPMM;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly AFPMEIHEKKD<int> CGIHMPDMEJA;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly AFPMEIHEKKD<int> FPEEAHKABDA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly AFPMEIHEKKD<int> EJKPJPGBFAN;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly AFPMEIHEKKD<int> GEKKPPMLLPB;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private static readonly AFPMEIHEKKD<int> FDNDKHCAHBD;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly AFPMEIHEKKD<int> JIIFCLKEHCI;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private static readonly AFPMEIHEKKD<int> CPGNHPLKNLF;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly AFPMEIHEKKD<int> AGMGCGOFIBM;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly AFPMEIHEKKD<long> MEOEHGBMGHK;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly AFPMEIHEKKD<long> PAMKJMLIDEP;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private static readonly AFPMEIHEKKD<long> DKNDGPEKDGI;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly AFPMEIHEKKD<long> ILPEDPHPKJL;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private static readonly AFPMEIHEKKD<long> KDDGGNCDFAF;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private static readonly AFPMEIHEKKD<long> IDGJDFOAFHO;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x853B9D0", Offset = "0x8539FD0", VA = "0x18853B9D0")]
	public static void KDDJGDKGCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x854EAD0", Offset = "0x854D0D0", VA = "0x18854EAD0")]
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
