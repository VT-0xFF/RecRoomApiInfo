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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x834F640", Offset = "0x834EA40", VA = "0x18834F640", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class PJJCOGKFJEM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly AKNCNLDICPO OJJCGCBIBIM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly AKNCNLDICPO AMMACKKCINH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly AKNCNLDICPO LHLIOICINPB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly AKNCNLDICPO JKCMDPNAOEK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly AKNCNLDICPO KEFGKCHHHBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class PJAMNHHCFMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public HKPCMJIDKMO FHEMIGFOAKF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JIHFJOICEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PJAMNHHCFMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct HKPCMJIDKMO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct AAAJDNBEBJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half NAGGHCCFKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort MDJMNKAGEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte FIMMMHIOKPH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void HLAOGMKOPEP([NoAlias] float3* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class MCJKNOFHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x834FCA0", Offset = "0x834F0A0", VA = "0x18834FCA0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x834FDD0", Offset = "0x834F1D0", VA = "0x18834FDD0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x834FF30", Offset = "0x834F330", VA = "0x18834FF30")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x834FA70", Offset = "0x834EE70", VA = "0x18834FA70")]
		public unsafe static void COEOEEINBLF([NoAlias] float3* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void HBHEPCIGFOB([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class OFKOBGJIDIL
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8353570", Offset = "0x8352970", VA = "0x188353570")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83536A0", Offset = "0x8352AA0", VA = "0x1883536A0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8353800", Offset = "0x8352C00", VA = "0x188353800")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83532C0", Offset = "0x83526C0", VA = "0x1883532C0")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void PMLPIOOLGID([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class DLMNKNLNACJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x833CB70", Offset = "0x833BF70", VA = "0x18833CB70")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x833CCA0", Offset = "0x833C0A0", VA = "0x18833CCA0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x833CE00", Offset = "0x833C200", VA = "0x18833CE00")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x833C8C0", Offset = "0x833BCC0", VA = "0x18833C8C0")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void JBHLHHEBCIM([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class KNFHJKKEIHH
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x834E0D0", Offset = "0x834D4D0", VA = "0x18834E0D0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x834E200", Offset = "0x834D600", VA = "0x18834E200")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x834E360", Offset = "0x834D760", VA = "0x18834E360")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x834DE20", Offset = "0x834D220", VA = "0x18834DE20")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void BMACDOOMANI([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class IIBPLAIMNCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x834B7D0", Offset = "0x834ABD0", VA = "0x18834B7D0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x834B900", Offset = "0x834AD00", VA = "0x18834B900")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x834BA60", Offset = "0x834AE60", VA = "0x18834BA60")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x834B520", Offset = "0x834A920", VA = "0x18834B520")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void FFJIBHCIEBH([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class OPNCGLPFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8354F00", Offset = "0x8354300", VA = "0x188354F00")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8355030", Offset = "0x8354430", VA = "0x188355030")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8355190", Offset = "0x8354590", VA = "0x188355190")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8354BC0", Offset = "0x8353FC0", VA = "0x188354BC0")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void KMNKMCODHED([NoAlias] ushort* EGBMNAKMGNM, [Out] float3 FDFPJEIHOBA, [Out] float3 JNENPIGMGEC, [In][NoAlias] float3* KOPMJDJDNMD, int CLDLACMHBKF, int PFPBLIFJJFD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class AJKMKNIPDBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8331B50", Offset = "0x8330F50", VA = "0x188331B50")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8331C80", Offset = "0x8331080", VA = "0x188331C80")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8331DE0", Offset = "0x83311E0", VA = "0x188331DE0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8331910", Offset = "0x8330D10", VA = "0x188331910")]
		public unsafe static void COEOEEINBLF([NoAlias] ushort* EGBMNAKMGNM, [Out] float3 FDFPJEIHOBA, [Out] float3 JNENPIGMGEC, [In][NoAlias] float3* KOPMJDJDNMD, int CLDLACMHBKF, int PFPBLIFJJFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void ELCBGHKFPFA([NoAlias] ushort* BKMMKADNIKI, [In][NoAlias] float3* FHJFAFBKNHB, int PFPBLIFJJFD);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class DLAKEIKKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x833C580", Offset = "0x833B980", VA = "0x18833C580")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x833C6B0", Offset = "0x833BAB0", VA = "0x18833C6B0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x833C810", Offset = "0x833BC10", VA = "0x18833C810")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x833C370", Offset = "0x833B770", VA = "0x18833C370")]
		public unsafe static void COEOEEINBLF([NoAlias] ushort* BKMMKADNIKI, [In][NoAlias] float3* FHJFAFBKNHB, int PFPBLIFJJFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void BLBFCAKBFKK([NoAlias] float3* CEPHBCHCLKP, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class GADHIOGNFCK
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x833ECA0", Offset = "0x833E0A0", VA = "0x18833ECA0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x833EDD0", Offset = "0x833E1D0", VA = "0x18833EDD0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x833EF30", Offset = "0x833E330", VA = "0x18833EF30")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x833EA90", Offset = "0x833DE90", VA = "0x18833EA90")]
		public unsafe static void COEOEEINBLF([NoAlias] float3* CEPHBCHCLKP, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void PIHEEMIMGOC([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class OCMCGDACEDL
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8352F80", Offset = "0x8352380", VA = "0x188352F80")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x83530B0", Offset = "0x83524B0", VA = "0x1883530B0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8353210", Offset = "0x8352610", VA = "0x188353210")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8352D70", Offset = "0x8352170", VA = "0x188352D70")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void IHAFILKJCOK([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class NBFKHAMOFFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83514A0", Offset = "0x83508A0", VA = "0x1883514A0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83515D0", Offset = "0x83509D0", VA = "0x1883515D0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8351730", Offset = "0x8350B30", VA = "0x188351730")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83511A0", Offset = "0x83505A0", VA = "0x1883511A0")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void DMOKNOKHDMN([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class FOCONBGCOHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x833E750", Offset = "0x833DB50", VA = "0x18833E750")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x833E880", Offset = "0x833DC80", VA = "0x18833E880")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x833E9E0", Offset = "0x833DDE0", VA = "0x18833E9E0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x833E450", Offset = "0x833D850", VA = "0x18833E450")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void PIMGJMMCCIA([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class GHBOICFCDHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8341CC0", Offset = "0x83410C0", VA = "0x188341CC0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8341DF0", Offset = "0x83411F0", VA = "0x188341DF0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8341F50", Offset = "0x8341350", VA = "0x188341F50")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8341990", Offset = "0x8340D90", VA = "0x188341990")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void EHJDHIGMLBK([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class LFGLBNKPOBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x834ECB0", Offset = "0x834E0B0", VA = "0x18834ECB0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x834EDE0", Offset = "0x834E1E0", VA = "0x18834EDE0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x834EF40", Offset = "0x834E340", VA = "0x18834EF40")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x834E980", Offset = "0x834DD80", VA = "0x18834E980")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void AJLEHDKHKJG([NoAlias] uint* FGKLBLOIKJK, [Out] float2 OJODLAALILM, [Out] float2 ADLMLIEOCMK, [In][NoAlias] float2* KOIHBDOLKGH, int CLDLACMHBKF, int PFPBLIFJJFD);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class CCGOAOKMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x83338D0", Offset = "0x8332CD0", VA = "0x1883338D0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8333A00", Offset = "0x8332E00", VA = "0x188333A00")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8333B60", Offset = "0x8332F60", VA = "0x188333B60")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8333690", Offset = "0x8332A90", VA = "0x188333690")]
		public unsafe static void COEOEEINBLF([NoAlias] uint* FGKLBLOIKJK, [Out] float2 OJODLAALILM, [Out] float2 ADLMLIEOCMK, [In][NoAlias] float2* KOIHBDOLKGH, int CLDLACMHBKF, int PFPBLIFJJFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void INEJKFNILNA([Out] float2 MFIKIHEJCNP, uint PCJLMFHHJKO, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class ICKHPDOHKOD
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x834B1E0", Offset = "0x834A5E0", VA = "0x18834B1E0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x834B310", Offset = "0x834A710", VA = "0x18834B310")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x834B470", Offset = "0x834A870", VA = "0x18834B470")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x834AF80", Offset = "0x834A380", VA = "0x18834AF80")]
		public static void COEOEEINBLF([Out] float2 MFIKIHEJCNP, uint PCJLMFHHJKO, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void JEKEINMMGIA([NoAlias] float2* FGKLBLOIKJK, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class EBMHAIHODDL
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x833D1A0", Offset = "0x833C5A0", VA = "0x18833D1A0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x833D2D0", Offset = "0x833C6D0", VA = "0x18833D2D0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x833D430", Offset = "0x833C830", VA = "0x18833D430")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x833CEB0", Offset = "0x833C2B0", VA = "0x18833CEB0")]
		public unsafe static void COEOEEINBLF([NoAlias] float2* FGKLBLOIKJK, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void LOHCMOEMLPJ([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class BOFGBLEKGIH
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8332DE0", Offset = "0x83321E0", VA = "0x188332DE0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8332F10", Offset = "0x8332310", VA = "0x188332F10")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8333070", Offset = "0x8332470", VA = "0x188333070")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8332AC0", Offset = "0x8331EC0", VA = "0x188332AC0")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void JOGHFBHMOGK([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class OIBLHCNPNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8353BD0", Offset = "0x8352FD0", VA = "0x188353BD0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8353D00", Offset = "0x8353100", VA = "0x188353D00")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8353E60", Offset = "0x8353260", VA = "0x188353E60")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83538B0", Offset = "0x8352CB0", VA = "0x1883538B0")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void NHANICMKEEG([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class KPAGMNKIFIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x834E640", Offset = "0x834DA40", VA = "0x18834E640")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x834E770", Offset = "0x834DB70", VA = "0x18834E770")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x834E8D0", Offset = "0x834DCD0", VA = "0x18834E8D0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x834E410", Offset = "0x834D810", VA = "0x18834E410")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void KLFMFIGAEPC([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class LLKHLBPAMMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x834F300", Offset = "0x834E700", VA = "0x18834F300")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x834F430", Offset = "0x834E830", VA = "0x18834F430")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x834F590", Offset = "0x834E990", VA = "0x18834F590")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x834EFF0", Offset = "0x834E3F0", VA = "0x18834EFF0")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void MOGJOACEDMP([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class BLGMIPEGJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8332680", Offset = "0x8331A80", VA = "0x188332680")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x83327B0", Offset = "0x8331BB0", VA = "0x1883327B0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8332910", Offset = "0x8331D10", VA = "0x188332910")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8332360", Offset = "0x8331760", VA = "0x188332360")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void MBIPDCJLGHE([NoAlias] ushort* LEMOMKKGHIM, [In][NoAlias] float4* HECIBBKHOFJ, int CLDLACMHBKF, int PFPBLIFJJFD);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class AAKLDDGDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8331020", Offset = "0x8330420", VA = "0x188331020")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8331150", Offset = "0x8330550", VA = "0x188331150")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x83312B0", Offset = "0x83306B0", VA = "0x1883312B0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8330D80", Offset = "0x8330180", VA = "0x188330D80")]
		public unsafe static void COEOEEINBLF([NoAlias] ushort* LEMOMKKGHIM, [In][NoAlias] float4* HECIBBKHOFJ, int CLDLACMHBKF, int PFPBLIFJJFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort NCEPGGGGCKD([In] float4 AJPKNAENLHN);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class PJJGFLBDIDP
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8355750", Offset = "0x8354B50", VA = "0x188355750")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8355880", Offset = "0x8354C80", VA = "0x188355880")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x83559E0", Offset = "0x8354DE0", VA = "0x1883559E0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x83554F0", Offset = "0x83548F0", VA = "0x1883554F0")]
		public static ushort COEOEEINBLF([In] float4 AJPKNAENLHN)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void JNDPLNMNBPK([NoAlias] float4* LEMOMKKGHIM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class OPADIKNAOAI
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8354880", Offset = "0x8353C80", VA = "0x188354880")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x83549B0", Offset = "0x8353DB0", VA = "0x1883549B0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8354B10", Offset = "0x8353F10", VA = "0x188354B10")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x83545E0", Offset = "0x83539E0", VA = "0x1883545E0")]
		public unsafe static void COEOEEINBLF([NoAlias] float4* LEMOMKKGHIM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void DCFDHHCNCHD([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class CGOONMAOINO
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x833AE50", Offset = "0x833A250", VA = "0x18833AE50")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x833AF80", Offset = "0x833A380", VA = "0x18833AF80")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x833B0E0", Offset = "0x833A4E0", VA = "0x18833B0E0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x833AC40", Offset = "0x833A040", VA = "0x18833AC40")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void PLFHMHOODFH([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class EPFHHBGPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x833DF50", Offset = "0x833D350", VA = "0x18833DF50")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x833E080", Offset = "0x833D480", VA = "0x18833E080")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x833E1E0", Offset = "0x833D5E0", VA = "0x18833E1E0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x833DC20", Offset = "0x833D020", VA = "0x18833DC20")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void MNHJFLLFCIF([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class NCGAKFKFBDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83523B0", Offset = "0x83517B0", VA = "0x1883523B0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x83524E0", Offset = "0x83518E0", VA = "0x1883524E0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8352640", Offset = "0x8351A40", VA = "0x188352640")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8352080", Offset = "0x8351480", VA = "0x188352080")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void EFJDJOJACOO([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class KFGDLHFKFKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x834D790", Offset = "0x834CB90", VA = "0x18834D790")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x834D8C0", Offset = "0x834CCC0", VA = "0x18834D8C0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x834DA20", Offset = "0x834CE20", VA = "0x18834DA20")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x834D400", Offset = "0x834C800", VA = "0x18834D400")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void KGIEJGELFKB([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class OMBBJFGPNKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x83542A0", Offset = "0x83536A0", VA = "0x1883542A0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x83543D0", Offset = "0x83537D0", VA = "0x1883543D0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8354530", Offset = "0x8353930", VA = "0x188354530")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8353F10", Offset = "0x8353310", VA = "0x188353F10")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void CKLHMIKGILO([Out] float4 HJBCDFKDKBA, ushort PCJLMFHHJKO);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class GLFDGNFIACK
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8342840", Offset = "0x8341C40", VA = "0x188342840")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8342970", Offset = "0x8341D70", VA = "0x188342970")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8342AD0", Offset = "0x8341ED0", VA = "0x188342AD0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x83425A0", Offset = "0x83419A0", VA = "0x1883425A0")]
		public static void COEOEEINBLF([Out] float4 HJBCDFKDKBA, ushort PCJLMFHHJKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void PGCPCLFHKPN([NoAlias] float4* MCGHLDHAJDD, [NoAlias] byte* PHKBKBBKPCK, [Out] int JHKALILKFIH, [Out] int CBIFDCHNKBI, [NoAlias] float4* BEOEPBADNGJ, [NoAlias] float4* AGOCLPINAHI, int CLDLACMHBKF, int PFPBLIFJJFD);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class JFFKMLNKNEA
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x834C020", Offset = "0x834B420", VA = "0x18834C020")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x834C150", Offset = "0x834B550", VA = "0x18834C150")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x834C2B0", Offset = "0x834B6B0", VA = "0x18834C2B0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x834BDE0", Offset = "0x834B1E0", VA = "0x18834BDE0")]
		public unsafe static void COEOEEINBLF([NoAlias] float4* MCGHLDHAJDD, [NoAlias] byte* PHKBKBBKPCK, [Out] int JHKALILKFIH, [Out] int CBIFDCHNKBI, [NoAlias] float4* BEOEPBADNGJ, [NoAlias] float4* AGOCLPINAHI, int CLDLACMHBKF, int PFPBLIFJJFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void CFHFNNCDAMC([NoAlias] float4* MADMDPFALMH, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class EOEKLPKOOOL
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x833D7E0", Offset = "0x833CBE0", VA = "0x18833D7E0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x833D910", Offset = "0x833CD10", VA = "0x18833D910")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x833DA70", Offset = "0x833CE70", VA = "0x18833DA70")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x833D4E0", Offset = "0x833C8E0", VA = "0x18833D4E0")]
		public unsafe static void COEOEEINBLF([NoAlias] float4* MADMDPFALMH, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void EODMAMLFICL([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class JKFIPKOAKPL
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x834C710", Offset = "0x834BB10", VA = "0x18834C710")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x834C840", Offset = "0x834BC40", VA = "0x18834C840")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x834C9A0", Offset = "0x834BDA0", VA = "0x18834C9A0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x834C360", Offset = "0x834B760", VA = "0x18834C360")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void CEGOLELKBEO([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class GEIGNLAFAAE
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8341650", Offset = "0x8340A50", VA = "0x188341650")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8341780", Offset = "0x8340B80", VA = "0x188341780")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x83418E0", Offset = "0x8340CE0", VA = "0x1883418E0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8341290", Offset = "0x8340690", VA = "0x188341290")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void CDGOKKHBMOG([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class MMFPPHCGLMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x83508E0", Offset = "0x834FCE0", VA = "0x1883508E0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8350A10", Offset = "0x834FE10", VA = "0x188350A10")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8350B70", Offset = "0x834FF70", VA = "0x188350B70")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8350530", Offset = "0x834F930", VA = "0x188350530")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void GDIOKKGBJAA([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class BPMLKJEFLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8333350", Offset = "0x8332750", VA = "0x188333350")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8333480", Offset = "0x8332880", VA = "0x188333480")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x83335E0", Offset = "0x83329E0", VA = "0x1883335E0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8333120", Offset = "0x8332520", VA = "0x188333120")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void DKHBGOPFDGA([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class HMAGIDKGJAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x834A6C0", Offset = "0x8349AC0", VA = "0x18834A6C0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x834A7F0", Offset = "0x8349BF0", VA = "0x18834A7F0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x834A950", Offset = "0x8349D50", VA = "0x18834A950")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x834A490", Offset = "0x8349890", VA = "0x18834A490")]
		public unsafe static void COEOEEINBLF([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int PKKGENDFAHH([NoAlias] byte* FPDFJJGECIK, [In][NoAlias] int* PGEJCEOMNNI, int PJCECBOOLJO);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class DAFPHEHECDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x833B530", Offset = "0x833A930", VA = "0x18833B530")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x833B660", Offset = "0x833AA60", VA = "0x18833B660")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x833B7C0", Offset = "0x833ABC0", VA = "0x18833B7C0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x833B290", Offset = "0x833A690", VA = "0x18833B290")]
		public unsafe static int COEOEEINBLF([NoAlias] byte* FPDFJJGECIK, [In][NoAlias] int* PGEJCEOMNNI, int PJCECBOOLJO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void DBMEBEKJMMH([NoAlias] int* NKPFPMAMNBF, [In][NoAlias] byte* BPFHPKHLMGG, int MFOAPNHFCLN);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class GKMEEEJCOGK
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8342260", Offset = "0x8341660", VA = "0x188342260")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8342390", Offset = "0x8341790", VA = "0x188342390")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x83424F0", Offset = "0x83418F0", VA = "0x1883424F0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8342000", Offset = "0x8341400", VA = "0x188342000")]
		public unsafe static void COEOEEINBLF([NoAlias] int* NKPFPMAMNBF, [In][NoAlias] byte* BPFHPKHLMGG, int MFOAPNHFCLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void ANFGHHNEEJP([NoAlias] ushort* NKPFPMAMNBF, [In][NoAlias] byte* BPFHPKHLMGG, int MFOAPNHFCLN);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class PMJCAAIONIE
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8355E00", Offset = "0x8355200", VA = "0x188355E00")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8355F30", Offset = "0x8355330", VA = "0x188355F30")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8356090", Offset = "0x8355490", VA = "0x188356090")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8355B90", Offset = "0x8354F90", VA = "0x188355B90")]
		public unsafe static void COEOEEINBLF([NoAlias] ushort* NKPFPMAMNBF, [In][NoAlias] byte* BPFHPKHLMGG, int MFOAPNHFCLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void DEHBHBKPICH([Out] float3 MFIKIHEJCNP, ushort PCJLMFHHJKO);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class MDMLIJFMLIK
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x83501F0", Offset = "0x834F5F0", VA = "0x1883501F0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8350320", Offset = "0x834F720", VA = "0x188350320")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8350480", Offset = "0x834F880", VA = "0x188350480")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x834FFE0", Offset = "0x834F3E0", VA = "0x18834FFE0")]
		public static void COEOEEINBLF([Out] float3 MFIKIHEJCNP, ushort PCJLMFHHJKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort JKJPJFCHPJL([In] float3 AJPKNAENLHN);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class DAOCBDJDOFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x833BA70", Offset = "0x833AE70", VA = "0x18833BA70")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x833BBA0", Offset = "0x833AFA0", VA = "0x18833BBA0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x833BD00", Offset = "0x833B100", VA = "0x18833BD00")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x833B870", Offset = "0x833AC70", VA = "0x18833B870")]
		public static ushort COEOEEINBLF([In] float3 AJPKNAENLHN)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker FJCELEIHGFC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker DOBFFPLIAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int JIHFJOICEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int MFOAPNHFCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> COEMHJPINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> FPBLMJNFMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> BAAJHGLBFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> LGKCJPAPOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<AAAJDNBEBJM> FBOGEDHOCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> DJFNGLJBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> PCCEEKOEHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 AMLLINBCMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 JNENPIGMGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 CPCCEFEBEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 ADLMLIEOCMK;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long KHMKOIGAAJI;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long MILOJICIMPG;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float IMPEMPFMDAN;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool PHMCFBJFAMF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GAGDCLONJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8348810", Offset = "0x8347C10", VA = "0x188348810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KNLINMHLOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83450B0", Offset = "0x83444B0", VA = "0x1883450B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8346230", Offset = "0x8345630", VA = "0x188346230")]
	public void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83439F0", Offset = "0x8342DF0", VA = "0x1883439F0")]
	public static HKPCMJIDKMO CEOONNIFPHP(Allocator KCEIEKBPKNP, CGCDLCFCEHB EGECIHHCNJB)
	{
		return default(HKPCMJIDKMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8343CC0", Offset = "0x83430C0", VA = "0x188343CC0")]
	public static HKPCMJIDKMO CEOONNIFPHP(Allocator KCEIEKBPKNP, NativeArray<float3> KOPMJDJDNMD, NativeArray<float3> FHJFAFBKNHB, NativeArray<float2> KOIHBDOLKGH, NativeArray<float4> AGOCLPINAHI, bool JCKNFPCCBOH, NativeArray<float4> HMLOAGCEFLP, NativeArray<int> PGEJCEOMNNI, int JIHFJOICEPE, int AFMNJHHMEDF, int MFOAPNHFCLN, int CLDLACMHBKF)
	{
		return default(HKPCMJIDKMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8348F50", Offset = "0x8348350", VA = "0x188348F50")]
	public void NFPDAEHPPHD(CGCDLCFCEHB HJBCDFKDKBA, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8349B00", Offset = "0x8348F00", VA = "0x188349B00")]
	public long PFNBKNKJCCO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8349310", Offset = "0x8348710", VA = "0x188349310")]
	public long NHGKJPAIINB(CGCDLCFCEHB.EDHPDAAIBDC LKPDHLBCOHA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x83432B0", Offset = "0x83426B0", VA = "0x1883432B0")]
	private void AMHAEEMOGAM(int IHNMIEEEPLH, int PFPBLIFJJFD, Allocator KCEIEKBPKNP, bool IKLBOFELHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8348D00", Offset = "0x8348100", VA = "0x188348D00")]
	private void NEJCJJFNLNI(NativeArray<float3> EGBMNAKMGNM, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8348C80", Offset = "0x8348080", VA = "0x188348C80")]
	[BurstCompile]
	private unsafe static void NEJCJJFNLNI([NoAlias] float3* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83457D0", Offset = "0x8344BD0", VA = "0x1883457D0")]
	[BurstCompile]
	private unsafe static void FILCELJFBCD([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83495B0", Offset = "0x83489B0", VA = "0x1883495B0")]
	[BurstCompile]
	private unsafe static void NKJDGJOBNOF([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8349970", Offset = "0x8348D70", VA = "0x188349970")]
	[BurstCompile]
	private unsafe static void OJCIDEEPBMN([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8348290", Offset = "0x8347690", VA = "0x188348290")]
	[BurstCompile]
	private unsafe static void LHEIJLFACNL([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8347770", Offset = "0x8346B70", VA = "0x188347770")]
	[BurstCompile]
	private unsafe static void JNNPJDLJNBM([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83475C0", Offset = "0x83469C0", VA = "0x1883475C0")]
	private void JKLEHDJKDAF(NativeArray<float3> KOPMJDJDNMD, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83476E0", Offset = "0x8346AE0", VA = "0x1883476E0")]
	[BurstCompile]
	private unsafe static void JKLEHDJKDAF([NoAlias] ushort* EGBMNAKMGNM, [Out] float3 FDFPJEIHOBA, [Out] float3 JNENPIGMGEC, [In][NoAlias] float3* KOPMJDJDNMD, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8342C00", Offset = "0x8342000", VA = "0x188342C00")]
	private void AEAEKAOCLFB(NativeArray<float3> FHJFAFBKNHB, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8342CE0", Offset = "0x83420E0", VA = "0x188342CE0")]
	[BurstCompile]
	private unsafe static void AEAEKAOCLFB([NoAlias] ushort* BKMMKADNIKI, [In][NoAlias] float3* FHJFAFBKNHB, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8342F30", Offset = "0x8342330", VA = "0x188342F30")]
	private void AGAKIDKIBJG(NativeArray<float3> CEPHBCHCLKP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8342FF0", Offset = "0x83423F0", VA = "0x188342FF0")]
	[BurstCompile]
	private unsafe static void AGAKIDKIBJG([NoAlias] float3* CEPHBCHCLKP, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8346970", Offset = "0x8345D70", VA = "0x188346970")]
	[BurstCompile]
	private unsafe static void IHBJEENLCLO([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8349630", Offset = "0x8348A30", VA = "0x188349630")]
	[BurstCompile]
	private unsafe static void NOJNAFLMKNC([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83487A0", Offset = "0x8347BA0", VA = "0x1883487A0")]
	[BurstCompile]
	private unsafe static void LNNFILMJLNC([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8349800", Offset = "0x8348C00", VA = "0x188349800")]
	[BurstCompile]
	private unsafe static void OGBFMDKHCAE([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8346140", Offset = "0x8345540", VA = "0x188346140")]
	[BurstCompile]
	private unsafe static void HLAELFDOJDJ([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8347C30", Offset = "0x8347030", VA = "0x188347C30")]
	private void KIDKPJAGLLL(NativeArray<float2> KOIHBDOLKGH, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8347BA0", Offset = "0x8346FA0", VA = "0x188347BA0")]
	[BurstCompile]
	private unsafe static void KIDKPJAGLLL([NoAlias] uint* FGKLBLOIKJK, [Out] float2 OJODLAALILM, [Out] float2 ADLMLIEOCMK, [In][NoAlias] float2* KOIHBDOLKGH, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x834A320", Offset = "0x8349720", VA = "0x18834A320")]
	[BurstCompile]
	private static void PNGLJOAGKBG([Out] float2 MFIKIHEJCNP, uint PCJLMFHHJKO, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8347170", Offset = "0x8346570", VA = "0x188347170")]
	private void JBCCILMONNF(NativeArray<float2> FGKLBLOIKJK, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83470F0", Offset = "0x83464F0", VA = "0x1883470F0")]
	[BurstCompile]
	private unsafe static void JBCCILMONNF([NoAlias] float2* FGKLBLOIKJK, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8349780", Offset = "0x8348B80", VA = "0x188349780")]
	[BurstCompile]
	private unsafe static void ODEOMHDKOED([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8345930", Offset = "0x8344D30", VA = "0x188345930")]
	[BurstCompile]
	private unsafe static void FMPEKAAHLAI([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83453D0", Offset = "0x83447D0", VA = "0x1883453D0")]
	[BurstCompile]
	private unsafe static void FDBFNOIFNHI([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8342B80", Offset = "0x8341F80", VA = "0x188342B80")]
	[BurstCompile]
	private unsafe static void AABMHDPJCBD([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8347540", Offset = "0x8346940", VA = "0x188347540")]
	[BurstCompile]
	private unsafe static void JIPGHDNNKCP([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83436B0", Offset = "0x8342AB0", VA = "0x1883436B0")]
	private void BNPIKIDHBLI(NativeArray<float4> HMLOAGCEFLP, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83437C0", Offset = "0x8342BC0", VA = "0x1883437C0")]
	[BurstCompile]
	private unsafe static void BNPIKIDHBLI([NoAlias] ushort* LEMOMKKGHIM, [In][NoAlias] float4* HECIBBKHOFJ, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8349560", Offset = "0x8348960", VA = "0x188349560")]
	[BurstCompile]
	private static ushort NHIMMOFEHAO([In] float4 AJPKNAENLHN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8347AB0", Offset = "0x8346EB0", VA = "0x188347AB0")]
	private void KEOPGGBCEAM(NativeArray<float4> LEMOMKKGHIM, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8347A40", Offset = "0x8346E40", VA = "0x188347A40")]
	[BurstCompile]
	private unsafe static void KEOPGGBCEAM([NoAlias] float4* LEMOMKKGHIM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8348550", Offset = "0x8347950", VA = "0x188348550")]
	[BurstCompile]
	private unsafe static void LNHPDCCBLBM([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8343240", Offset = "0x8342640", VA = "0x188343240")]
	[BurstCompile]
	private unsafe static void ALJKCPAKKBN([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83450F0", Offset = "0x83444F0", VA = "0x1883450F0")]
	[BurstCompile]
	private unsafe static void EEKIALBBIIO([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8345E30", Offset = "0x8345230", VA = "0x188345E30")]
	[BurstCompile]
	private unsafe static void HCEMKOCOLNM([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83435D0", Offset = "0x83429D0", VA = "0x1883435D0")]
	[BurstCompile]
	private unsafe static void BGOFIKJLEOF([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8345050", Offset = "0x8344450", VA = "0x188345050")]
	[BurstCompile]
	private static void DJKBLEOPJOL([Out] float4 HJBCDFKDKBA, ushort PCJLMFHHJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8346C50", Offset = "0x8346050", VA = "0x188346C50")]
	private void INFGMFKPKDM(Allocator KCEIEKBPKNP, NativeArray<float4> AGOCLPINAHI, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8346BC0", Offset = "0x8345FC0", VA = "0x188346BC0")]
	[BurstCompile]
	private unsafe static void INFGMFKPKDM([NoAlias] float4* MCGHLDHAJDD, [NoAlias] byte* PHKBKBBKPCK, [Out] int JHKALILKFIH, [Out] int CBIFDCHNKBI, [NoAlias] float4* BEOEPBADNGJ, [NoAlias] float4* AGOCLPINAHI, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8343840", Offset = "0x8342C40", VA = "0x188343840")]
	private static void CCGACPCLHHM(NativeArray<float4> MADMDPFALMH, NativeArray<AAAJDNBEBJM> IGHFJGAAJJJ, NativeArray<byte> FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8343970", Offset = "0x8342D70", VA = "0x188343970")]
	[BurstCompile]
	private unsafe static void CCGACPCLHHM([NoAlias] float4* MADMDPFALMH, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83433E0", Offset = "0x83427E0", VA = "0x1883433E0")]
	[BurstCompile]
	private unsafe static void BFACILNCFDN([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83461B0", Offset = "0x83455B0", VA = "0x1883461B0")]
	[BurstCompile]
	private unsafe static void HLKMJCPJJCK([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8349A80", Offset = "0x8348E80", VA = "0x188349A80")]
	[BurstCompile]
	private unsafe static void PCHCLFJHNLE([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8346700", Offset = "0x8345B00", VA = "0x188346700")]
	[BurstCompile]
	private unsafe static void IHBAIDMPPLG([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8345160", Offset = "0x8344560", VA = "0x188345160")]
	[BurstCompile]
	private unsafe static void EFNAMLCHCNB([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8344690", Offset = "0x8343A90", VA = "0x188344690")]
	private void DAMEODPOBKP(Allocator KCEIEKBPKNP, NativeArray<int> PGEJCEOMNNI, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8348850", Offset = "0x8347C50", VA = "0x188348850")]
	private static NativeArray<byte> MMOBIGHIKHN(Allocator KCEIEKBPKNP, NativeArray<int> PGEJCEOMNNI, int PJCECBOOLJO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8348B30", Offset = "0x8347F30", VA = "0x188348B30")]
	[BurstCompile]
	private unsafe static int MMOBIGHIKHN([NoAlias] byte* FPDFJJGECIK, [In][NoAlias] int* PGEJCEOMNNI, int PJCECBOOLJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8345450", Offset = "0x8344850", VA = "0x188345450")]
	private static void FFAIDFHGFCF(NativeArray<int> NKPFPMAMNBF, NativeArray<byte> BPFHPKHLMGG, int MFOAPNHFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8345540", Offset = "0x8344940", VA = "0x188345540")]
	[BurstCompile]
	private unsafe static void FFAIDFHGFCF([NoAlias] int* NKPFPMAMNBF, [In][NoAlias] byte* BPFHPKHLMGG, int MFOAPNHFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8343640", Offset = "0x8342A40", VA = "0x188343640")]
	[BurstCompile]
	private unsafe static void BINMOGNKEFE([NoAlias] ushort* NKPFPMAMNBF, [In][NoAlias] byte* BPFHPKHLMGG, int MFOAPNHFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x834A0E0", Offset = "0x83494E0", VA = "0x18834A0E0")]
	[BurstCompile]
	private static void PGMBJHICOIB([Out] float3 MFIKIHEJCNP, ushort PCJLMFHHJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8349D40", Offset = "0x8349140", VA = "0x188349D40")]
	[BurstCompile]
	private static ushort PGCANIACHKJ([In] float3 AJPKNAENLHN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x832FCD0", Offset = "0x832F0D0", VA = "0x18832FCD0")]
	[BurstCompile]
	public unsafe static void LFJDJBLLKJD([NoAlias] float3* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x83445D0", Offset = "0x83439D0", VA = "0x1883445D0")]
	[BurstCompile]
	public unsafe static void CPGANNHMMEE([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8344280", Offset = "0x8343680", VA = "0x188344280")]
	[BurstCompile]
	public unsafe static void CFBHNGGGNMK([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8344340", Offset = "0x8343740", VA = "0x188344340")]
	[BurstCompile]
	public unsafe static void CJKPGMKFPFO([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8344340", Offset = "0x8343740", VA = "0x188344340")]
	[BurstCompile]
	public unsafe static void FEHEFLBNLMF([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8345CD0", Offset = "0x83450D0", VA = "0x188345CD0")]
	[BurstCompile]
	public unsafe static void GFGGBDGNFJD([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* KOPMJDJDNMD, int JIHFJOICEPE, [In] float3 AMLLINBCMKE, [In] float3 JNENPIGMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8330170", Offset = "0x832F570", VA = "0x188330170")]
	[BurstCompile]
	public unsafe static void ONCAMHNPLAC([NoAlias] ushort* EGBMNAKMGNM, [Out] float3 FDFPJEIHOBA, [Out] float3 JNENPIGMGEC, [In][NoAlias] float3* KOPMJDJDNMD, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8344790", Offset = "0x8343B90", VA = "0x188344790")]
	[BurstCompile]
	public unsafe static void DECBHNDJAMO([NoAlias] ushort* BKMMKADNIKI, [In][NoAlias] float3* FHJFAFBKNHB, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8346350", Offset = "0x8345750", VA = "0x188346350")]
	[BurstCompile]
	public unsafe static void HPMAKKKFEIJ([NoAlias] float3* CEPHBCHCLKP, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x83477F0", Offset = "0x8346BF0", VA = "0x1883477F0")]
	[BurstCompile]
	public unsafe static void JNPDBLGLLCC([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x83459B0", Offset = "0x8344DB0", VA = "0x1883459B0")]
	[BurstCompile]
	public unsafe static void FOKEAMNKLIF([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8347400", Offset = "0x8346800", VA = "0x188347400")]
	[BurstCompile]
	public unsafe static void JIJBMEIHJKG([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8343460", Offset = "0x8342860", VA = "0x188343460")]
	[BurstCompile]
	public unsafe static void BGCKJLINPHE([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8347290", Offset = "0x8346690", VA = "0x188347290")]
	[BurstCompile]
	public unsafe static void JBCOEKBJOAJ([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* FHJFAFBKNHB, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x832E460", Offset = "0x832D860", VA = "0x18832E460")]
	[BurstCompile]
	public unsafe static void BMBEKGEIEIP([NoAlias] uint* FGKLBLOIKJK, [Out] float2 OJODLAALILM, [Out] float2 ADLMLIEOCMK, [In][NoAlias] float2* KOIHBDOLKGH, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x83458F0", Offset = "0x8344CF0", VA = "0x1883458F0")]
	[BurstCompile]
	public static void FMBMCFHEOMA([Out] float2 MFIKIHEJCNP, uint PCJLMFHHJKO, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83465F0", Offset = "0x83459F0", VA = "0x1883465F0")]
	[BurstCompile]
	public unsafe static void IGHCCLGIEOM([NoAlias] float2* FGKLBLOIKJK, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8344A40", Offset = "0x8343E40", VA = "0x188344A40")]
	[BurstCompile]
	public unsafe static void DEJODNFBAKJ([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8345F40", Offset = "0x8345340", VA = "0x188345F40")]
	[BurstCompile]
	public unsafe static void HHOLMKJJJPD([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83455B0", Offset = "0x83449B0", VA = "0x1883455B0")]
	[BurstCompile]
	public unsafe static void FHEIOJFIIPM([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8347D50", Offset = "0x8347150", VA = "0x188347D50")]
	[BurstCompile]
	public unsafe static void LAKNIKBHCLE([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8348E20", Offset = "0x8348220", VA = "0x188348E20")]
	[BurstCompile]
	public unsafe static void NFIIAOPFMFF([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [NoAlias] uint* KOIHBDOLKGH, int JIHFJOICEPE, [In] float2 CPCCEFEBEGG, [In] float2 ADLMLIEOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x83496A0", Offset = "0x8348AA0", VA = "0x1883496A0")]
	[BurstCompile]
	public unsafe static void OBIBDEMNOHB([NoAlias] ushort* LEMOMKKGHIM, [In][NoAlias] float4* HECIBBKHOFJ, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x83499F0", Offset = "0x8348DF0", VA = "0x1883499F0")]
	[BurstCompile]
	public static ushort PAANOJEPLMA([In] float4 AJPKNAENLHN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8348BA0", Offset = "0x8347FA0", VA = "0x188348BA0")]
	[BurstCompile]
	public unsafe static void NDLMBLAIBGP([NoAlias] float4* LEMOMKKGHIM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8344B80", Offset = "0x8343F80", VA = "0x188344B80")]
	[BurstCompile]
	public unsafe static void DEMNGMHGOFH([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8344110", Offset = "0x8343510", VA = "0x188344110")]
	[BurstCompile]
	public unsafe static void CFADAKHFOGG([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8349F70", Offset = "0x8349370", VA = "0x188349F70")]
	[BurstCompile]
	public unsafe static void PGKFFJIBJGG([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8344400", Offset = "0x8343800", VA = "0x188344400")]
	[BurstCompile]
	public unsafe static void CNACHIACOBJ([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8347E80", Offset = "0x8347280", VA = "0x188347E80")]
	[BurstCompile]
	public unsafe static void LCEFBPMDOCI([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] ushort* HMLOAGCEFLP, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8346080", Offset = "0x8345480", VA = "0x188346080")]
	[BurstCompile]
	public static void HKEEPJIIGFN([Out] float4 HJBCDFKDKBA, ushort PCJLMFHHJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x832F080", Offset = "0x832E480", VA = "0x18832F080")]
	[BurstCompile]
	public unsafe static void GBBJGFJIAJK([NoAlias] float4* MCGHLDHAJDD, [NoAlias] byte* PHKBKBBKPCK, [Out] int JHKALILKFIH, [Out] int CBIFDCHNKBI, [NoAlias] float4* BEOEPBADNGJ, [NoAlias] float4* AGOCLPINAHI, int CLDLACMHBKF, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8349C00", Offset = "0x8349000", VA = "0x188349C00")]
	[BurstCompile]
	public unsafe static void PGBHFNGNLKO([NoAlias] float4* MADMDPFALMH, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8345AF0", Offset = "0x8344EF0", VA = "0x188345AF0")]
	[BurstCompile]
	public unsafe static void FPNPOJNGDCJ([NoAlias] CGCDLCFCEHB.AMCCGDMHEIL* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8349380", Offset = "0x8348780", VA = "0x188349380")]
	[BurstCompile]
	public unsafe static void NHHPFKLNOEA([NoAlias] CGCDLCFCEHB.JDHJIENAKIL* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8344E70", Offset = "0x8344270", VA = "0x188344E70")]
	[BurstCompile]
	public unsafe static void DGLCJBPJIME([NoAlias] CGCDLCFCEHB.KJLDOIPLKNK* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8348050", Offset = "0x8347450", VA = "0x188348050")]
	[BurstCompile]
	public unsafe static void LCFJKCLCEKF([NoAlias] CGCDLCFCEHB.KMKHIHCKCPI* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8348310", Offset = "0x8347710", VA = "0x188348310")]
	[BurstCompile]
	public unsafe static void LIPIIPGJKPO([NoAlias] CGCDLCFCEHB.KDBPPEKOKAM* EGBMNAKMGNM, [In][NoAlias] AAAJDNBEBJM* IGHFJGAAJJJ, [In][NoAlias] byte* FEOKMEOGOBA, int JIHFJOICEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8349870", Offset = "0x8348C70", VA = "0x188349870")]
	[BurstCompile]
	public unsafe static int OHMCJDKKCAF([NoAlias] byte* FPDFJJGECIK, [In][NoAlias] int* PGEJCEOMNNI, int PJCECBOOLJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8345850", Offset = "0x8344C50", VA = "0x188345850")]
	[BurstCompile]
	public unsafe static void FILJFIKKGDD([NoAlias] int* NKPFPMAMNBF, [In][NoAlias] byte* BPFHPKHLMGG, int MFOAPNHFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8345EA0", Offset = "0x83452A0", VA = "0x188345EA0")]
	[BurstCompile]
	public unsafe static void HEEIECAJMLN([NoAlias] ushort* NKPFPMAMNBF, [In][NoAlias] byte* BPFHPKHLMGG, int MFOAPNHFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x832ECC0", Offset = "0x832E0C0", VA = "0x18832ECC0")]
	[BurstCompile]
	public static void EKALJIFMILJ([Out] float3 MFIKIHEJCNP, ushort PCJLMFHHJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x832E2A0", Offset = "0x832D6A0", VA = "0x18832E2A0")]
	[BurstCompile]
	public static ushort BGBFHBKEPDN([In] float3 AJPKNAENLHN)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class CGCDLCFCEHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum EDHPDAAIBDC
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
	public enum LMBBPKGHPBG
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
	public struct FPPNBLOJPNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EDHPDAAIBDC LKPDHLBCOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool CJIMEGOHCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int NGFEOFDJEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] IGMILMCPEPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct FBCBBDPLBLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 LBCFHLNAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 KIAHAFCJEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 NJGCOCEOHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 HKFACICMAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 FBOGEDHOCIA;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] IGMILMCPEPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct AMCCGDMHEIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 LBCFHLNAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 KIAHAFCJEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 NJGCOCEOHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 HKFACICMAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 FBOGEDHOCIA;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] IGMILMCPEPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct JDHJIENAKIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 LBCFHLNAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint KIAHAFCJEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint NJGCOCEOHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 HKFACICMAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 FBOGEDHOCIA;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] IGMILMCPEPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct KJLDOIPLKNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 LBCFHLNAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint KIAHAFCJEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint NJGCOCEOHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 HKFACICMAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 FBOGEDHOCIA;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] IGMILMCPEPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct KMKHIHCKCPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 LBCFHLNAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint JMFGKOPPLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 HKFACICMAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint KOCIOHFNGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint BFEPODFMALD;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] IGMILMCPEPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct KDBPPEKOKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AHFNABHDBIE.KDBLFJLOHMM OBNIBAMDBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint JMFGKOPPLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 HKFACICMAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint KOCIOHFNGJE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] IGMILMCPEPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int COPMPFOFJFM(float FNBJHADJBNG);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class ADAAOHIOAGM
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x83315D0", Offset = "0x83309D0", VA = "0x1883315D0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8331700", Offset = "0x8330B00", VA = "0x188331700")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8331860", Offset = "0x8330C60", VA = "0x188331860")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8331360", Offset = "0x8330760", VA = "0x188331360")]
		public static int COEOEEINBLF(float FNBJHADJBNG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint ACANFBIICGI([In] float4 EMOJJIEJAKM);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class NHKDMJLMMKE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8352A30", Offset = "0x8351E30", VA = "0x188352A30")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8352B60", Offset = "0x8351F60", VA = "0x188352B60")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8352CC0", Offset = "0x83520C0", VA = "0x188352CC0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x83526F0", Offset = "0x8351AF0", VA = "0x1883526F0")]
		public static uint COEOEEINBLF([In] float4 EMOJJIEJAKM)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint ONJIDEDKDPB([In] float3 EMOJJIEJAKM);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class DEPNGPJJOPH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x833C030", Offset = "0x833B430", VA = "0x18833C030")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x833C160", Offset = "0x833B560", VA = "0x18833C160")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x833C2C0", Offset = "0x833B6C0", VA = "0x18833C2C0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x833BDB0", Offset = "0x833B1B0", VA = "0x18833BDB0")]
		public static uint COEOEEINBLF([In] float3 EMOJJIEJAKM)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void HOHGFCAAEJK([NoAlias] JDHJIENAKIL* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class MOIONBNNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8350E60", Offset = "0x8350260", VA = "0x188350E60")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8350F90", Offset = "0x8350390", VA = "0x188350F90")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x83510F0", Offset = "0x83504F0", VA = "0x1883510F0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8350C20", Offset = "0x8350020", VA = "0x188350C20")]
		public unsafe static void COEOEEINBLF([NoAlias] JDHJIENAKIL* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void FMAILCDGMGH([NoAlias] KJLDOIPLKNK* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class HOEKIGHPPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x834AC40", Offset = "0x834A040", VA = "0x18834AC40")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x834AD70", Offset = "0x834A170", VA = "0x18834AD70")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x834AED0", Offset = "0x834A2D0", VA = "0x18834AED0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x834AA00", Offset = "0x8349E00", VA = "0x18834AA00")]
		public unsafe static void COEOEEINBLF([NoAlias] KJLDOIPLKNK* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void EPANCPKHCBA([NoAlias] KMKHIHCKCPI* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class KAFLDAIFHEP
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x834CF40", Offset = "0x834C340", VA = "0x18834CF40")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x834D070", Offset = "0x834C470", VA = "0x18834D070")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x834D1D0", Offset = "0x834C5D0", VA = "0x18834D1D0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x834CB50", Offset = "0x834BF50", VA = "0x18834CB50")]
		public unsafe static void COEOEEINBLF([NoAlias] KMKHIHCKCPI* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void BGGJIGBLENO([NoAlias] KDBPPEKOKAM* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA, [Out] float3 NMHBDDJACNG, [Out] float3 FPAANPBNPKI);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class NBKIMBGFCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8351D40", Offset = "0x8351140", VA = "0x188351D40")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8351E70", Offset = "0x8351270", VA = "0x188351E70")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8351FD0", Offset = "0x83513D0", VA = "0x188351FD0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x83517E0", Offset = "0x8350BE0", VA = "0x1883517E0")]
		public unsafe static void COEOEEINBLF([NoAlias] KDBPPEKOKAM* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA, [Out] float3 NMHBDDJACNG, [Out] float3 FPAANPBNPKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int LDFIMOECHCG = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> AFGJFLOMCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> GGJILDJKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> BPCJMPHJINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> FFHKMANAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> ENHKABHMDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> DBPEDIFKMCF;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] JLIBLLFDHIC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool AGDKLJDMJJG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static FPPNBLOJPNN[] DDFLPMAFLMP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool GAGDCLONJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8338F00", Offset = "0x8338300", VA = "0x188338F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FDPLHEOFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8336B20", Offset = "0x8335F20", VA = "0x188336B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AGCIPFOFBBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8336B60", Offset = "0x8335F60", VA = "0x188336B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KNLINMHLOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8335BD0", Offset = "0x8334FD0", VA = "0x188335BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x8337450", Offset = "0x8336850", VA = "0x188337450")]
	public static LMBBPKGHPBG IKFINAEADCI(EDHPDAAIBDC LKPDHLBCOHA)
	{
		return default(LMBBPKGHPBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8335210", Offset = "0x8334610", VA = "0x188335210")]
	public static void CMBNNKGGBKF(LMBBPKGHPBG KNFLHKDHGNG, Material GMFBEMFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x8336650", Offset = "0x8335A50", VA = "0x188336650", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x8334560", Offset = "0x8333960", VA = "0x188334560")]
	public void AMHAEEMOGAM(int IHNMIEEEPLH, int PFPBLIFJJFD, Allocator KCEIEKBPKNP, bool INJKFKMLMCC, bool IKLBOFELHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8339BF0", Offset = "0x8338FF0", VA = "0x188339BF0")]
	public void OENJOIKADKF(int IHNMIEEEPLH, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x83351F0", Offset = "0x83345F0", VA = "0x1883351F0", Slot = "6")]
	public bool CBHGCABIDPI(Mesh NIKBNBLEJEO, bool MIDCJBDNNGO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8336BA0", Offset = "0x8335FA0", VA = "0x188336BA0")]
	public bool GKPEGAPLAKA(Mesh NIKBNBLEJEO, bool MIDCJBDNNGO, bool KEGHODJLCMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8337B50", Offset = "0x8336F50", VA = "0x188337B50")]
	public bool JCLAOBBDKLB(Mesh NIKBNBLEJEO, CGCDLCFCEHB NGHMKIMLEHN, bool MIDCJBDNNGO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8338D90", Offset = "0x8338190", VA = "0x188338D90")]
	public bool LPPMEKGAMKO(Mesh NIKBNBLEJEO, CGCDLCFCEHB NGHMKIMLEHN, EDHPDAAIBDC LKPDHLBCOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8334750", Offset = "0x8333B50", VA = "0x188334750")]
	private void BAJDFEBPJMK(Mesh NIKBNBLEJEO, CGCDLCFCEHB NGHMKIMLEHN, bool KEGHODJLCMK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8334EE0", Offset = "0x83342E0", VA = "0x188334EE0")]
	public void BAJDFEBPJMK(NativeArray<ushort> LMKABGDNEGL, NativeArray<KMKHIHCKCPI> AJCGGJDMBGG, Mesh NIKBNBLEJEO, CGCDLCFCEHB NGHMKIMLEHN, bool KEGHODJLCMK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x8335C10", Offset = "0x8335010", VA = "0x188335C10")]
	public void DNAMMKFAHMO(Mesh NIKBNBLEJEO, bool KEGHODJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8338980", Offset = "0x8337D80", VA = "0x188338980")]
	[BurstCompile]
	public static int LFINKPNDGFC(float FNBJHADJBNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x83388E0", Offset = "0x8337CE0", VA = "0x1883388E0")]
	[BurstCompile]
	public static uint LFINKPNDGFC([In] float4 EMOJJIEJAKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8338930", Offset = "0x8337D30", VA = "0x188338930")]
	[BurstCompile]
	public static uint LFINKPNDGFC([In] float3 EMOJJIEJAKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8339C70", Offset = "0x8339070", VA = "0x188339C70")]
	public void PCIIJPBICHP(Mesh NIKBNBLEJEO, bool KEGHODJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8339B70", Offset = "0x8338F70", VA = "0x188339B70")]
	[BurstCompile]
	private unsafe static void OAFKOFOCLMC([NoAlias] JDHJIENAKIL* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8339280", Offset = "0x8338680", VA = "0x188339280")]
	public void NEPOIIDMIEB(Mesh NIKBNBLEJEO, bool KEGHODJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8336760", Offset = "0x8335B60", VA = "0x188336760")]
	[BurstCompile]
	private unsafe static void ECBAABBLJGK([NoAlias] KJLDOIPLKNK* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x83380E0", Offset = "0x83374E0", VA = "0x1883380E0")]
	public void KIGPLMGFKNF(Mesh NIKBNBLEJEO, bool KEGHODJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x83384B0", Offset = "0x83378B0", VA = "0x1883384B0")]
	public void KIGPLMGFKNF(NativeArray<ushort> NKEIMBHPNJH, NativeArray<KMKHIHCKCPI> JHLBEFNIFND, Mesh NIKBNBLEJEO, bool KEGHODJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x833A790", Offset = "0x8339B90", VA = "0x18833A790")]
	[BurstCompile]
	public unsafe static void PJOJLHDICNO([NoAlias] KMKHIHCKCPI* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x83352F0", Offset = "0x83346F0", VA = "0x1883352F0")]
	public void CMFLPNDHEMD(Mesh NIKBNBLEJEO, bool KEGHODJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8338860", Offset = "0x8337C60", VA = "0x188338860")]
	[BurstCompile]
	private unsafe static void LEODCPIMKBM([NoAlias] KDBPPEKOKAM* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA, [Out] float3 NMHBDDJACNG, [Out] float3 FPAANPBNPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8338050", Offset = "0x8337450", VA = "0x188338050")]
	public void JJPGMOHBGPM(Mesh NIKBNBLEJEO, EDHPDAAIBDC LKPDHLBCOHA, bool KEGHODJLCMK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x83368B0", Offset = "0x8335CB0", VA = "0x1883368B0")]
	public void GHNFBMEEMFD(CGCDLCFCEHB NIKBNBLEJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8339910", Offset = "0x8338D10", VA = "0x188339910")]
	public void NGOGPBMEMJB(CGCDLCFCEHB NHDOFIDIKGL, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x833A640", Offset = "0x8339A40", VA = "0x18833A640")]
	public long PFNBKNKJCCO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x833A5E0", Offset = "0x83399E0", VA = "0x18833A5E0")]
	public static long PFNBKNKJCCO(int EAHOLKAMOOL, int HJLLBJNNGNM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8339AD0", Offset = "0x8338ED0", VA = "0x188339AD0")]
	public static long NHGKJPAIINB(int EAHOLKAMOOL, int HJLLBJNNGNM, EDHPDAAIBDC LKPDHLBCOHA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x8339A10", Offset = "0x8338E10", VA = "0x188339A10")]
	public long NHGKJPAIINB(EDHPDAAIBDC LKPDHLBCOHA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x83373F0", Offset = "0x83367F0", VA = "0x1883373F0")]
	public void HDBFGACPJOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x83374A0", Offset = "0x83368A0", VA = "0x1883374A0")]
	public static void IOIACJKDMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8333E10", Offset = "0x8333210", VA = "0x188333E10")]
	public EDHPDAAIBDC AMEFNPJAFLB()
	{
		return default(EDHPDAAIBDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x83367E0", Offset = "0x8335BE0", VA = "0x1883367E0")]
	public static (int, int) FGONLGGLDIA(Mesh NIKBNBLEJEO)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8337A70", Offset = "0x8336E70", VA = "0x188337A70")]
	public static int JCIDJHKMFMC(VertexAttributeDescriptor[] CHKGOBAKPBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8335A30", Offset = "0x8334E30", VA = "0x188335A30")]
	public static long DDFNIOKKFFK(Mesh NIKBNBLEJEO, int EADIIKLBIDH, int FPHHAJOGOLN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8335AA0", Offset = "0x8334EA0", VA = "0x188335AA0")]
	public static long DDFNIOKKFFK(Mesh NIKBNBLEJEO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CGCDLCFCEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x833A300", Offset = "0x8339700", VA = "0x18833A300")]
	[BurstCompile]
	public static int PEILCNCBCGN(float FNBJHADJBNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x833A3A0", Offset = "0x83397A0", VA = "0x18833A3A0")]
	[BurstCompile]
	public static uint PEILCNCBCGN([In] float4 EMOJJIEJAKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x833A530", Offset = "0x8339930", VA = "0x18833A530")]
	[BurstCompile]
	public static uint PEILCNCBCGN([In] float3 EMOJJIEJAKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x83389D0", Offset = "0x8337DD0", VA = "0x1883389D0")]
	[BurstCompile]
	public unsafe static void LKDOEILPJHD([NoAlias] JDHJIENAKIL* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8336FA0", Offset = "0x83363A0", VA = "0x188336FA0")]
	[BurstCompile]
	public unsafe static void GMLNBGFACMK([NoAlias] KJLDOIPLKNK* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8333C10", Offset = "0x8333010", VA = "0x188333C10")]
	[BurstCompile]
	public unsafe static void AFLIPLHOJDH([NoAlias] KMKHIHCKCPI* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8338F40", Offset = "0x8338340", VA = "0x188338F40")]
	[BurstCompile]
	public unsafe static void MMJCLAHNHLH([NoAlias] KDBPPEKOKAM* EGBMNAKMGNM, int JIHFJOICEPE, [In][NoAlias] float3* LNGOJOBDGLC, [In][NoAlias] float3* FPBLMJNFMKO, [In][NoAlias] float4* BAAJHGLBFBI, [In][NoAlias] float2* LGKCJPAPOGO, [In][NoAlias] float4* FBOGEDHOCIA, [Out] float3 NMHBDDJACNG, [Out] float3 FPAANPBNPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct OEIOIKANJGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int ELHFGECGAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 EMJOAFAPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion FMBHBNGBLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 BKMJLPFIGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int NOKPIKBDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int LEHEPOAPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int CHPFCFCJBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float MEODOKMAJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 NJLDOKPPBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool FKAGGEIDIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public LFMODOJCHOJ NEKJHMEAEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 ANFNDFOACIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float EFGNECFCNKC;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class GCHCCBCGNIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static NEAPFKDAPIL MPCEOGICDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<OEIOIKANJGF> LPNEKKODDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<LEDLOPLKBIA> GFNPKKEBACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<BNDGLDMGFKK> BMJBNEHFMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<ABIKCOMHDNG> JECOKBPJCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<LEDLOPLKBIA> HBKBNGCPNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<OKLEOMCFHFD> BAFAHDHIJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<ABIKCOMHDNG>> DJOPFAGNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<GAJLNDDHAMD> HBDONINNGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> JFOPFMFHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> PBNLIIIKKKF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<LLMIHCNJBEG.BIEGKJCMMPI> HJFMGOMPGMC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FDPLHEOFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA714C0", Offset = "0xA708C0", VA = "0x180A714C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA71470", Offset = "0xA70870", VA = "0x180A71470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int AGCIPFOFBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xD30720", Offset = "0xD2FB20", VA = "0x180D30720")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xD30730", Offset = "0xD2FB30", VA = "0x180D30730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8341070", Offset = "0x8340470", VA = "0x188341070")]
	public GCHCCBCGNIE(int BODNMDFAIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x833F840", Offset = "0x833EC40", VA = "0x18833F840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x8340D40", Offset = "0x8340140", VA = "0x188340D40")]
	public void HNJLALOFPOG(JobHandle EDPKGAKIIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x833EFE0", Offset = "0x833E3E0", VA = "0x18833EFE0")]
	public void AHKCAEKHEFG(OEIOIKANJGF NGIAGNLBILI, GAJLNDDHAMD NIBMFKPEBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x8340F30", Offset = "0x8340330", VA = "0x188340F30")]
	public void IMCPDCMOLND(BNDGLDMGFKK NGIAGNLBILI, NativeArray<ABIKCOMHDNG> OILKBPHFMHH, int JIHFJOICEPE, int MFOAPNHFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x8340C20", Offset = "0x8340020", VA = "0x188340C20")]
	public JobHandle FHABFJLNOLF(CGCDLCFCEHB EGEIBNCOEKP, BGBHELJOJCI HIEBDEGGHJI, float3 DEILJGHCLME, quaternion HHPPBJCCFMM, float LECPBIPLOBJ, bool DHIPJEHHKFI, int DDCHDGINHCP = 0, int AEGJAENAFOB = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x833FA20", Offset = "0x833EE20", VA = "0x18833FA20")]
	public JobHandle FHABFJLNOLF(CGCDLCFCEHB EGEIBNCOEKP, BGBHELJOJCI HIEBDEGGHJI, NativeList<LLMIHCNJBEG.BIEGKJCMMPI> KGCGIBHJCLJ, float3 DEILJGHCLME, quaternion HHPPBJCCFMM, float LECPBIPLOBJ, bool DHIPJEHHKFI, bool LCHADIJANPO, int DDCHDGINHCP = 0, int AEGJAENAFOB = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x833F210", Offset = "0x833E610", VA = "0x18833F210")]
	public static JobHandle APEOGEFGGHN(BEAAMFKKPCJ BOLNCNKLLPI, CGCDLCFCEHB EGEIBNCOEKP, NativeArray<int> PBNLIIIKKKF, OEIOIKANJGF NGIAGNLBILI, JobHandle EDPKGAKIIHD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x833F590", Offset = "0x833E990", VA = "0x18833F590")]
	public static JobHandle DCHCFLEFDJB(MCCDJOJOLBF BOLNCNKLLPI, CGCDLCFCEHB EGEIBNCOEKP, BNDGLDMGFKK NGIAGNLBILI, NativeArray<ABIKCOMHDNG> OILKBPHFMHH, int JIHFJOICEPE, int MFOAPNHFCLN, JobHandle EDPKGAKIIHD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HCBOOLEMPFA
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct FGOFJAFGLOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer FOGLHINMCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public OLDEIKMHKBC.OFNDNKLEBCD KNLIMECLJJH;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x54E1CF0", Offset = "0x54E10F0", VA = "0x1854E1CF0")]
		public FGOFJAFGLOI(MeshRenderer FOGLHINMCEC, OLDEIKMHKBC.OFNDNKLEBCD KNLIMECLJJH)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x835B880", Offset = "0x835AC80", VA = "0x18835B880")]
		public static FGOFJAFGLOI GKKMDDPCKIG((MeshRenderer, OLDEIKMHKBC.OFNDNKLEBCD) GGKKDFMIENI)
		{
			return default(FGOFJAFGLOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker DGAPOBJMFGL;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker OMPFOILJGBO;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker OMODBJJLNEC;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker KKMDBDELKIH;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x835D6F0", Offset = "0x835CAF0", VA = "0x18835D6F0")]
	internal void HCHGNAAKHJI(GameObject GCLLIPFLMCN, OLDEIKMHKBC.OKCAGDCIMPB EPMIIFEGCKA, List<FGOFJAFGLOI> KBFMDIBJOCA, Material GMFBEMFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x835C440", Offset = "0x835B840", VA = "0x18835C440")]
	internal void DGJMEEKLKFB(GameObject GCLLIPFLMCN, OLDEIKMHKBC.OKCAGDCIMPB EPMIIFEGCKA, List<FGOFJAFGLOI> KBFMDIBJOCA, List<LODGroup> DIDALLFAANB, Material GMFBEMFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x835CC70", Offset = "0x835C070", VA = "0x18835CC70")]
	private MeshRenderer ELMEMNPNJMK(OLDEIKMHKBC.OKCAGDCIMPB EPMIIFEGCKA, Material GMFBEMFEGJH, List<FGOFJAFGLOI> KBFMDIBJOCA, bool FJHIDINOFNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x835E0D0", Offset = "0x835D4D0", VA = "0x18835E0D0")]
	private List<(List<FGOFJAFGLOI>, float)> ILEDEBHDCJC(OLDEIKMHKBC.OKCAGDCIMPB EPMIIFEGCKA, List<LODGroup> DIDALLFAANB, Material GMFBEMFEGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x835EFB0", Offset = "0x835E3B0", VA = "0x18835EFB0")]
	private List<List<(List<FGOFJAFGLOI>, float)>> JMGIEMFKPMA(OLDEIKMHKBC.OKCAGDCIMPB EPMIIFEGCKA, List<LODGroup> DIDALLFAANB, Material GMFBEMFEGJH, [Out] int PBFAHJMDFGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HCBOOLEMPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x835DF60", Offset = "0x835D360", VA = "0x18835DF60")]
	[CompilerGenerated]
	internal static (float, int) HEDHMIHNHOM(List<List<(List<FGOFJAFGLOI> meshList, float lodTransition)>> MAJLLPMJGAH, int[] MMFCEEFIBLL)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KNKANHNGHAD
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker OLHLDDKFMHO;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker GCGNDCPOHJC;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker PFAABJMIKCO;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker NBMMONLFMDH;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker AMCIAILDHHF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker MOEJGJDCOOH;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker AOIHHJMCGFJ;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly AKNCNLDICPO IENHCGLANFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private OLDEIKMHKBC AMFPNNIJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private HCBOOLEMPFA GIICMONPAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader MANPBIMCEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock FECMKIOPDBE;

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x83631C0", Offset = "0x83625C0", VA = "0x1883631C0")]
	public static void EFHKPLACEJM(GameObject GCLLIPFLMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8364890", Offset = "0x8363C90", VA = "0x188364890")]
	public void PJOFCLDPLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x83629A0", Offset = "0x8361DA0", VA = "0x1883629A0")]
	public void AIAMNCJMCDA(GameObject GCLLIPFLMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8364710", Offset = "0x8363B10", VA = "0x188364710")]
	private bool JMKLLNAKMKG(MeshRenderer FOGLHINMCEC, [Out] MeshFilter NIKABFAIENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8363CE0", Offset = "0x83630E0", VA = "0x188363CE0")]
	private bool HBDABJIKHGE(int NOEININIMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8363540", Offset = "0x8362940", VA = "0x188363540")]
	private void FEHBGJBJOHJ(GameObject GCLLIPFLMCN, int NOEININIMIL, Material GMFBEMFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8363F00", Offset = "0x8363300", VA = "0x188363F00")]
	private List<HCBOOLEMPFA.FGOFJAFGLOI> IMLABBIDANJ(int NOEININIMIL, [Out] List<LODGroup> DIDALLFAANB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8363770", Offset = "0x8362B70", VA = "0x188363770")]
	private List<(int, Material)> GIOOMDFLEPM(float DKNNBEJKIJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8363110", Offset = "0x8362510", VA = "0x188363110")]
	public void ECACKBMHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8362BE0", Offset = "0x8361FE0", VA = "0x188362BE0")]
	private bool BNNELDJPGHH(GameObject JBJNKCGNJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8365280", Offset = "0x8364680", VA = "0x188365280")]
	public KNKANHNGHAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class OLDEIKMHKBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct OKCAGDCIMPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 IDCCLFDFCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 FELPICHHHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float GGCAKLIBABK;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x836A280", Offset = "0x8369680", VA = "0x18836A280")]
		public OKCAGDCIMPB(Bounds EFDPEDFEFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x836A170", Offset = "0x8369570", VA = "0x18836A170")]
		public OKCAGDCIMPB(float3 IDCCLFDFCEL, float3 FELPICHHHLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct AIDCAAAKINA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public OKCAGDCIMPB COGHEOBJDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int EJPMBFEJLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int DEOALOKOACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float OIELFPFJJAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int IHNMIEEEPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int JEHCCNMMJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int DNPNGJFDBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int MLCNECMHPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int EHOEOLFPLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool ELKKEGNGJDF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct OFNDNKLEBCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh GEGAOALOAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 LKMGHHPAHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int HLPNOKHIDJO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct PFEKKLMLDJC : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<AIDCAAAKINA> HOEGHOMABBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> AHGBOFMNHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int BMIGHAMJHBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public OKCAGDCIMPB EFDPEDFEFJK;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x836FCB0", Offset = "0x836F0B0", VA = "0x18836FCB0")]
		private float HBFLNKOBGPM(OKCAGDCIMPB HCFCOMCPJPA, OKCAGDCIMPB JOCIBENNGKI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x836FA90", Offset = "0x836EE90", VA = "0x18836FA90", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker ANHIBEOILPA;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker NMFBMOLKGAN;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker BBDNGABDAPI;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker BINJDLLAIIC;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker MLLHPNDAMNH;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker GMDPJIPCGDN;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker GGLAGNICHJI;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker PBFMEGFIKNM;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker EBFPCMEHCEL;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker LLBEBHMGFHE;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker MDCLDHLNMKH;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker GIOEDBEPHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<AIDCAAAKINA> HOEGHOMABBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> IAJIEIPJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int GAKIBGONLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> HFCOBJLOFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<OFNDNKLEBCD> PCLOMBNJMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> DIDALLFAANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> IEEMFFMPIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> CLKFPKOPGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader BGKEDNCKJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader EKCGFAEGIEB;

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x836E170", Offset = "0x836D570", VA = "0x18836E170")]
	public OLDEIKMHKBC(int FCADNGDBHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x836BED0", Offset = "0x836B2D0", VA = "0x18836BED0")]
	private void HKBOLNCPEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x836D9F0", Offset = "0x836CDF0", VA = "0x18836D9F0")]
	public bool PMMFKJFCDIH(MeshRenderer JPDMLMONOAH, MeshFilter HKPKJCMMBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x836CCC0", Offset = "0x836C0C0", VA = "0x18836CCC0")]
	public bool PMMFKJFCDIH(LODGroup DJOGAPDAIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x836AC20", Offset = "0x836A020", VA = "0x18836AC20")]
	private bool BIEHLJBGGLM(MeshRenderer JPDMLMONOAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x836A650", Offset = "0x8369A50", VA = "0x18836A650")]
	private int AKLFEMPLIKI(MeshRenderer JPDMLMONOAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x836ACA0", Offset = "0x836A0A0", VA = "0x18836ACA0")]
	private int DOJMHDGIGNI(LODGroup DJOGAPDAIPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x836C7B0", Offset = "0x836BBB0", VA = "0x18836C7B0")]
	private int OEBKKMCDAOK(MeshFilter HKPKJCMMBBH, int MNNPIADPAEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x836A8C0", Offset = "0x8369CC0", VA = "0x18836A8C0")]
	private int BAHHDOKKOEH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x836C910", Offset = "0x836BD10", VA = "0x18836C910")]
	private static OKCAGDCIMPB PLIJENBKHNN(OKCAGDCIMPB HCFCOMCPJPA, OKCAGDCIMPB JOCIBENNGKI)
	{
		return default(OKCAGDCIMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x836A770", Offset = "0x8369B70", VA = "0x18836A770")]
	private static float ALPPDEMBOBP(Vector3 IDCCLFDFCEL, Vector3 FELPICHHHLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x836C040", Offset = "0x836B440", VA = "0x18836C040")]
	private int IKEGADDKKCD(int DIKACKFGDCL, OKCAGDCIMPB FFBJBBLPLMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x836A3F0", Offset = "0x83697F0", VA = "0x18836A3F0")]
	private void ADNCNFBEBDB(OKCAGDCIMPB FFBJBBLPLMD, int NOEININIMIL, [Out] float DOEMPECIDDM, [Out] float BCPMJBODGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x836AE10", Offset = "0x836A210", VA = "0x18836AE10")]
	private void FAJEKKBDEPF(OKCAGDCIMPB FFBJBBLPLMD, int MBFPOPKHFNN, Material GMFBEMFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x836B6E0", Offset = "0x836AAE0", VA = "0x18836B6E0")]
	private float HBFLNKOBGPM(OKCAGDCIMPB HCFCOMCPJPA, OKCAGDCIMPB JOCIBENNGKI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x836C370", Offset = "0x836B770", VA = "0x18836C370")]
	private void NLBJMENBNOP(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x836B290", Offset = "0x836A690", VA = "0x18836B290")]
	private void GDDCNCOKABO(int KLIIPFJJGGE, int GBIMMKJPIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x836B920", Offset = "0x836AD20", VA = "0x18836B920")]
	private void HCKHAJIMLFA(int KLIIPFJJGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x836AD60", Offset = "0x836A160", VA = "0x18836AD60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct DDIHBNKNLBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 JDOCBDPHMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 OCPLAMENOME;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class AEIDPOJLIKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<DDIHBNKNLBB> NHKBGPKLJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> AIMIKAKDKCL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FDPLHEOFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AGCIPFOFBBK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x8356400", Offset = "0x8355800", VA = "0x188356400")]
	public AEIDPOJLIKI(int IHNMIEEEPLH, int PFPBLIFJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x83562C0", Offset = "0x83556C0", VA = "0x1883562C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x8356320", Offset = "0x8355720", VA = "0x188356320")]
	public void GHNFBMEEMFD(AEIDPOJLIKI LNJINPLJCOD, int INPMMIPLAOF, int FDIBAFEDFOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class JCGPPBFMJHP
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static AEIDPOJLIKI EOJFHANIHDB;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<LEDLOPLKBIA> ADJFLNLAKBO;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] OHJKJMANPMD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool KHJJANMCANK;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, AEIDPOJLIKI> MMGAAMNGHLH;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, AEIDPOJLIKI> DHOKGMNBLJB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool GFMHJPAEDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x83611C0", Offset = "0x83605C0", VA = "0x1883611C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<LEDLOPLKBIA> CDJPNCCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8361A00", Offset = "0x8360E00", VA = "0x188361A00")]
		get
		{
			return default(NativeList<LEDLOPLKBIA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static AEIDPOJLIKI LDOHKJOAMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8362430", Offset = "0x8361830", VA = "0x188362430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x83613C0", Offset = "0x83607C0", VA = "0x1883613C0")]
	private static void FOMMNJDCFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x8361AC0", Offset = "0x8360EC0", VA = "0x188361AC0")]
	public static int JBJJJCOOECE(bool KGHJOMACNHD, int GOFNLIBBGCP, bool GKBNGMIHCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x83619D0", Offset = "0x8360DD0", VA = "0x1883619D0")]
	private static int GBCEPIIJNLC(int GOFNLIBBGCP, bool LHPCAEKNDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x83619F0", Offset = "0x8360DF0", VA = "0x1883619F0")]
	private static int GHJEACPHDMM(int GOFNLIBBGCP, bool LHPCAEKNDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x8361240", Offset = "0x8360640", VA = "0x188361240")]
	public static int CNHBGPAAKLM(int BFGBMBMPPGG, int GOFNLIBBGCP, int NIBPGJFGEFJ, bool LHPCAEKNDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8362380", Offset = "0x8361780", VA = "0x188362380")]
	public static int MAEJKIMJLPP(int BFGBMBMPPGG, int GOFNLIBBGCP, int NIBPGJFGEFJ, bool LHPCAEKNDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x83624D0", Offset = "0x83618D0", VA = "0x1883624D0")]
	public static int NGNAKDOJEMM(int NIBPGJFGEFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x8362820", Offset = "0x8361C20", VA = "0x188362820")]
	private static int PFOPKCIHKDD(int GOFNLIBBGCP, bool LHPCAEKNDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x8361AA0", Offset = "0x8360EA0", VA = "0x188361AA0")]
	private static int HPNADLIEAMI(int GOFNLIBBGCP, bool LHPCAEKNDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x8362080", Offset = "0x8361480", VA = "0x188362080")]
	public static int KMCFNPHKAGL(int BFGBMBMPPGG, int GOFNLIBBGCP, int NIBPGJFGEFJ, bool LHPCAEKNDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x8361F00", Offset = "0x8361300", VA = "0x188361F00")]
	public static int KGHLOFFAMDC(int BFGBMBMPPGG, int GOFNLIBBGCP, int NIBPGJFGEFJ, bool LHPCAEKNDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8362410", Offset = "0x8361810", VA = "0x188362410")]
	public static int MGGCCFODNDD(int NIBPGJFGEFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8361F90", Offset = "0x8361390", VA = "0x188361F90")]
	public static AEIDPOJLIKI KKENBDFDEFD(int GOFNLIBBGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x83620F0", Offset = "0x83614F0", VA = "0x1883620F0")]
	private static AEIDPOJLIKI LMACBCONLBG(int GOFNLIBBGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x83612D0", Offset = "0x83606D0", VA = "0x1883612D0")]
	public static AEIDPOJLIKI FHKECEFKIGM(int GOFNLIBBGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x83624E0", Offset = "0x83618E0", VA = "0x1883624E0")]
	private static AEIDPOJLIKI OMKMBPIIALK(int GOFNLIBBGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8361AF0", Offset = "0x8360EF0", VA = "0x188361AF0")]
	public static void JMKKMHLEPLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct BNDGLDMGFKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int AFPDLOCKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 EMJOAFAPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion FMBHBNGBLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float BKMJLPFIGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float ANPGLCKIHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int NOKPIKBDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int LEHEPOAPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int CHPFCFCJBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool GGJONBDFDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool AJHDGHHILBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float MEODOKMAJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 NJLDOKPPBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool GGBCGHEGKGG;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct OKLEOMCFHFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int HIMABKNFLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int CKLHKBGOHGA;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MCCDJOJOLBF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<BNDGLDMGFKK> JELHELGDPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<ABIKCOMHDNG> CGHABGNGCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<LEDLOPLKBIA> JMHBLIEAGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<OKLEOMCFHFD> EIICOKBFGEM;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8369570", Offset = "0x8368970", VA = "0x188369570")]
	public MCCDJOJOLBF(NativeArray<ABIKCOMHDNG> CGHABGNGCGL, int MPDDFCCPIOM = 1, Allocator KCEIEKBPKNP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8369480", Offset = "0x8368880", VA = "0x188369480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct EKIFCKHHEGA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<DDIHBNKNLBB> HHLHJAHLFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> AHFDIAMHDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<LEDLOPLKBIA> BJLLCGKDJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<BNDGLDMGFKK> JELHELGDPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<ABIKCOMHDNG> CGHABGNGCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<LEDLOPLKBIA> JMHBLIEAGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<OKLEOMCFHFD> EIICOKBFGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int OJEMLJGDEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int OHOPOLFEJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 PPEJLKPONFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion HJNIHOOAKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 OBKDEGKGMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KGCJAGJLJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CKENOKHDLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GJOKADINLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AEALCKMKCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KFPIDFAHOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DNDKPMDAMJK;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x835B3C0", Offset = "0x835A7C0", VA = "0x18835B3C0")]
	public EKIFCKHHEGA(GCHCCBCGNIE GDAOKEKAOJD, CGCDLCFCEHB GGBDLKBOOBA, float3 PBDBBOPFDHO, quaternion IGAEGDPNCLF, float NLICJHELLOI, int DDCHDGINHCP = 0, int AEGJAENAFOB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x835B650", Offset = "0x835AA50", VA = "0x18835B650")]
	public EKIFCKHHEGA(MCCDJOJOLBF GDAOKEKAOJD, CGCDLCFCEHB GGBDLKBOOBA, float3 PBDBBOPFDHO, quaternion IGAEGDPNCLF, float3 NLICJHELLOI, int DDCHDGINHCP = 0, int AEGJAENAFOB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x835B100", Offset = "0x835A500", VA = "0x18835B100")]
	private float3 LBMBFIHDCJF(float3 HIPEJAGCIHJ, Matrix4x4 DILKFGKKMJE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x835B080", Offset = "0x835A480", VA = "0x18835B080")]
	private float3x3 JLOFDEIKDGC(float3x3 PLEHOKPAKNE, float3x3 HLHLNAFNJEC)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x835B240", Offset = "0x835A640", VA = "0x18835B240")]
	private float LNOPMIGKMGM(float MJHAIBCGLLD, float IBPAPAJEPGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x8359960", Offset = "0x8358D60", VA = "0x188359960", Slot = "4")]
	public void Execute(int PFKMHLGKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x835B250", Offset = "0x835A650", VA = "0x18835B250")]
	private void MMOHDLPKLPL(int IBCKEBLBGKD, float3 LBCFHLNAPLC, float3 KIAHAFCJEPK, float3 NJGCOCEOHFP, float FLMDAOGEKMO, bool GMBJFGHEBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8359520", Offset = "0x8358920", VA = "0x188359520")]
	private void BBAEPLJCEJC(BNDGLDMGFKK PLDFDKIPFKP, float3 DPIFCOHCFGC, float3x3 AOLCBAKAICF, float MJHAIBCGLLD, int EMAFKACLAEJ, int ODDAGKBPICB, int HMBIDFEHCLL, float BPMHPMIGOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x835AB00", Offset = "0x8359F00", VA = "0x18835AB00")]
	private void GOBKFLCABNC(int IBCKEBLBGKD, int MJELINODGCM, BNDGLDMGFKK PLDFDKIPFKP, float3 DPIFCOHCFGC, float3x3 AOLCBAKAICF, bool LFIEBPPBBKD, float MJHAIBCGLLD, int BHNMPMOBLPP, int BDKGFNMNLMM, int HMBIDFEHCLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct BEAAMFKKPCJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<OEIOIKANJGF> PGAPEFPDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<LEDLOPLKBIA> LENFJFCABJK;

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x8357330", Offset = "0x8356730", VA = "0x188357330")]
	public BEAAMFKKPCJ(int MPDDFCCPIOM, Allocator KCEIEKBPKNP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8357290", Offset = "0x8356690", VA = "0x188357290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct BKMLJEBNIMM : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum ANMLAOOOOBI
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
	private NativeList<float3> IBGFIBEEHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> PMEMKFKLJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> JJLPEDPNHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> BCHFONEFALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> CHLDHEMLLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> HNDALNKBBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> MOPJOMDAJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> IFMJDFFDOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> KCCENHAHBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<LEDLOPLKBIA> PPCGEIOCENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<OEIOIKANJGF> PGAPEFPDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<LEDLOPLKBIA> LENFJFCABJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int OJEMLJGDEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int OHOPOLFEJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KGCJAGJLJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CKENOKHDLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GJOKADINLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AEALCKMKCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KFPIDFAHOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> PBNLIIIKKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DNDKPMDAMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 OBKDEGKGMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion HJNIHOOAKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 PPEJLKPONFP;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8358BA0", Offset = "0x8357FA0", VA = "0x188358BA0")]
	public BKMLJEBNIMM(GCHCCBCGNIE GDAOKEKAOJD, CGCDLCFCEHB GGBDLKBOOBA, NativeArray<int> AFAFIFPBDKN, float3 PBDBBOPFDHO, quaternion IGAEGDPNCLF, float NLICJHELLOI, int DDCHDGINHCP = 0, int AEGJAENAFOB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8358DB0", Offset = "0x83581B0", VA = "0x188358DB0")]
	public BKMLJEBNIMM(BEAAMFKKPCJ NGIAGNLBILI, CGCDLCFCEHB GGBDLKBOOBA, NativeArray<int> AFAFIFPBDKN, float3 PBDBBOPFDHO, quaternion IGAEGDPNCLF, float3 NLICJHELLOI, int DDCHDGINHCP = 0, int AEGJAENAFOB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8357780", Offset = "0x8356B80", VA = "0x188357780", Slot = "4")]
	public void Execute(int PFKMHLGKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x83587F0", Offset = "0x8357BF0", VA = "0x1883587F0")]
	private void NBLEDMCPLLM(float4x4 AMAOJDGFJIG, int PFKMHLGKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8358730", Offset = "0x8357B30", VA = "0x188358730")]
	private ANMLAOOOOBI JADPLFNNJHA(float3 KIAHAFCJEPK)
	{
		return default(ANMLAOOOOBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x83587A0", Offset = "0x8357BA0", VA = "0x1883587A0")]
	private float4 LNDFFOMDGNE(ANMLAOOOOBI OKIMNNOOLBB, int NOEININIMIL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x8357740", Offset = "0x8356B40", VA = "0x188357740")]
	private float2 DNIAGKLPFNK(ANMLAOOOOBI OKIMNNOOLBB, float3 LBCFHLNAPLC)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct GAJLNDDHAMD
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum DLOJECFNAHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static GAJLNDDHAMD BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 BKPAIEKHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 GGEGPGBJIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 GDGDNNAMJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public DLOJECFNAHE GBFFBDIJNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 LBCOCIJLIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 DBHIAMPHPHO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool JDPJAANKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x835BE10", Offset = "0x835B210", VA = "0x18835BE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 EBCOKCFFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x835C000", Offset = "0x835B400", VA = "0x18835C000")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x835C350", Offset = "0x835B750", VA = "0x18835C350")]
	public GAJLNDDHAMD(float3 LBCFHLNAPLC, quaternion EMLGDFFEJED, float3 MPDDFCCPIOM, DLOJECFNAHE IIHAKBEOLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x835C0E0", Offset = "0x835B4E0", VA = "0x18835C0E0")]
	public float PHCFIOFGJJF(float3 DPIFCOHCFGC, float CHOOCBAALLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x835BF10", Offset = "0x835B310", VA = "0x18835BF10")]
	public bool JHELCHGBNFI(float3 KIAHAFCJEPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x835B9D0", Offset = "0x835ADD0", VA = "0x18835B9D0")]
	public void BGBMIICMCBH(float3 HHEFLHFEFNF, float3x3 PJBBOAEGDKI, float KBKKHINPCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x835BE20", Offset = "0x835B220", VA = "0x18835BE20")]
	private void GKBAKMPLBNP(float3 NABBPIDAGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x835BB80", Offset = "0x835AF80", VA = "0x18835BB80")]
	public void CAFGKFGDBMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct IJHADEMNOGE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<GAJLNDDHAMD> NGIAGNLBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> COEMHJPINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> PCCEEKOEHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JFOPFMFHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<LEDLOPLKBIA> LENFJFCABJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int NBDIEEDIMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int IGOOEBNHHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float CHOOCBAALLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float PMHHIIAIHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> OPFEJCGAAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MJLHFDPLMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> CCIMPAJPNEC;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8361120", Offset = "0x8360520", VA = "0x188361120")]
	public IJHADEMNOGE(CGCDLCFCEHB NIKBNBLEJEO, float CKICOIAHFFE, int FDIBAFEDFOG, int EMAFKACLAEJ, NativeList<GAJLNDDHAMD> NGIAGNLBILI, NativeArray<int> JFOPFMFHOKA, NativeList<LEDLOPLKBIA> LENFJFCABJK, BGBHELJOJCI HIEBDEGGHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8360690", Offset = "0x835FA90", VA = "0x188360690", Slot = "4")]
	public void Execute(int IDHIDFEKDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8361060", Offset = "0x8360460", VA = "0x188361060")]
	private bool OOGHNLNJPON(GAJLNDDHAMD HCFCOMCPJPA, GAJLNDDHAMD JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8360DD0", Offset = "0x83601D0", VA = "0x188360DD0")]
	private bool KNKFPOFGMFC(GAJLNDDHAMD EODODMDCONG, int CHBGLJEIKKM, int BJKHFEJOFOM, int KLAPKDEENIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct FKKMCOABIPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<LLMIHCNJBEG.BIEGKJCMMPI> KGCGIBHJCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> GAGHMIFBNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int DDCHDGINHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int AEGJAENAFOB;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x835B9B0", Offset = "0x835ADB0", VA = "0x18835B9B0")]
	public FKKMCOABIPI(NativeList<LLMIHCNJBEG.BIEGKJCMMPI> KGCGIBHJCLJ, NativeArray<int> GAGHMIFBNJI, int AEGJAENAFOB = 0, int DDCHDGINHCP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x835B900", Offset = "0x835AD00", VA = "0x18835B900", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class BGBHELJOJCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> DLLJJPCDNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> NGKHPGAENND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> PAMPDNJKJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> CMNGAEIGNEE;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8357440", Offset = "0x8356840", VA = "0x188357440")]
	public void AMHAEEMOGAM(int IHNMIEEEPLH, int PFPBLIFJJFD, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8357420", Offset = "0x8356820", VA = "0x188357420")]
	public static long ADFFEHOCDDI(int IHNMIEEEPLH, int PFPBLIFJJFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8357560", Offset = "0x8356960", VA = "0x188357560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8357650", Offset = "0x8356A50", VA = "0x188357650")]
	public void HNJLALOFPOG(JobHandle EDPKGAKIIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BGBHELJOJCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct OAEAGPGAGAJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> COEMHJPINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> FPBLMJNFMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> FBOGEDHOCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> LGKCJPAPOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> PCCEEKOEHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BAAJHGLBFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> DBAPAFOAABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> OPFEJCGAAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> MJLHFDPLMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int DDCHDGINHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int AEGJAENAFOB;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x836A0F0", Offset = "0x83694F0", VA = "0x18836A0F0")]
	public OAEAGPGAGAJ(CGCDLCFCEHB NIKBNBLEJEO, BGBHELJOJCI HIEBDEGGHJI, int AEGJAENAFOB = 0, int DDCHDGINHCP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8369D10", Offset = "0x8369110", VA = "0x188369D10", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8369CB0", Offset = "0x83690B0", VA = "0x188369CB0")]
	private void DIMGABFFBLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class ACONEJGFGCI
{
	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x31E62E0", Offset = "0x31E56E0", VA = "0x1831E62E0")]
	public static bool ADDOFGCNACB<T>(NativeArray<T> LMLCJEFLFMP, int MPDDFCCPIOM, Allocator KCEIEKBPKNP, NativeArrayOptions LFFPIIDBFOJ = NativeArrayOptions.ClearMemory, int KFIGDPFIFHP = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x31E6380", Offset = "0x31E5780", VA = "0x1831E6380")]
	public static bool ADDOFGCNACB<T>(NativeList<T> KIGLENMLJCP, int MPDDFCCPIOM, Allocator KCEIEKBPKNP) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x31E6440", Offset = "0x31E5840", VA = "0x1831E6440")]
	public static bool ADDOFGCNACB<T>(NativeQueue<T> CFNBPDBGKJF, Allocator KCEIEKBPKNP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum FOBJPMBJJIL
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
public interface AHNPBENMMNA
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JIKCBGILJOG(FOBJPMBJJIL BFGBMBMPPGG);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int EIHFJLPNLDP(FOBJPMBJJIL BFGBMBMPPGG);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NNCAMIFAKGI NOGOPDADBKF();

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float BFAFBAMHNJF();

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FBFKBOPNCGO(FOBJPMBJJIL BFGBMBMPPGG, GCHCCBCGNIE DCHKOPDBDFH, int INMODPJCNEO = -1);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KDABMFPALJP(int APEKMEJFELE);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class ALJGOHMBMHH
{
	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8357140", Offset = "0x8356540", VA = "0x188357140")]
	public static void JMKKMHLEPLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class PEIGJKKLNNK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> AFGJFLOMCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> GGJILDJKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> IODBLBBFBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> IGEHGHBOABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> GDECDGIJCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> KDCCJAHOHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> FIIHJMMHOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> PCBFIJEPCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> DBPEDIFKMCF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FDPLHEOFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x836E990", Offset = "0x836DD90", VA = "0x18836E990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AGCIPFOFBBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x836E9D0", Offset = "0x836DDD0", VA = "0x18836E9D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BJFDLHPMIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x836E500", Offset = "0x836D900", VA = "0x18836E500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x836F410", Offset = "0x836E810", VA = "0x18836F410")]
	public PEIGJKKLNNK(int IHNMIEEEPLH, int PFPBLIFJJFD, int AJEBEOKNDBG, Allocator KCEIEKBPKNP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x836F730", Offset = "0x836EB30", VA = "0x18836F730")]
	public PEIGJKKLNNK(Mesh NIKBNBLEJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x836E540", Offset = "0x836D940", VA = "0x18836E540", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x836E660", Offset = "0x836DA60", VA = "0x18836E660")]
	public void GHNFBMEEMFD(PEIGJKKLNNK NIKBNBLEJEO, bool KGDGPHIEJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x836EF80", Offset = "0x836E380", VA = "0x18836EF80")]
	private void LHKODHNEILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x836EA10", Offset = "0x836DE10", VA = "0x18836EA10")]
	private void KHNFFFJMINJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct LEDLOPLKBIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int JJIBLFINNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int FDPLHEOFKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int POGCDEGAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int AGCIPFOFBBK;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2238F70", Offset = "0x2238370", VA = "0x182238F70")]
	public LEDLOPLKBIA(int EMAFKACLAEJ, int JIHFJOICEPE, int FDIBAFEDFOG, int MFOAPNHFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class NEAPFKDAPIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<LEDLOPLKBIA> BGIDAOGCNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LEDLOPLKBIA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PEIGJKKLNNK GEGAOALOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8369710", Offset = "0x8368B10", VA = "0x188369710")]
	public NEAPFKDAPIL(IEnumerable<PEIGJKKLNNK> LCOEDLEMBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x83696A0", Offset = "0x8368AA0", VA = "0x1883696A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum LFMODOJCHOJ
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class EJLKDHGGCGC
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> CDMJKGFHGJC;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> ADGOJCKJLCJ;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> IGHFEPLIFBE;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> PNOEACFOMJK;

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x83592F0", Offset = "0x83586F0", VA = "0x1883592F0")]
	public static void JMKKMHLEPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x83590D0", Offset = "0x83584D0", VA = "0x1883590D0")]
	public static NativeArray<float2> IBNJJPHBMMN(NativeArray<float2> DEPAIOJPNPJ, int NECDGJBLCMO, NativeArray<float2> HOENBLBOKOL, int BDDNACANNAK)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x8359410", Offset = "0x8358810", VA = "0x188359410")]
	public static NativeArray<float3> NECNALNNCMD(NativeArray<float3> DEPAIOJPNPJ, int NECDGJBLCMO, NativeArray<float3> HOENBLBOKOL, int BDDNACANNAK)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8358FC0", Offset = "0x83583C0", VA = "0x188358FC0")]
	public static NativeArray<float4> CPPMCBGCHFP(NativeArray<float4> DEPAIOJPNPJ, int NECDGJBLCMO, NativeArray<float4> HOENBLBOKOL, int BDDNACANNAK)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x83591E0", Offset = "0x83585E0", VA = "0x1883591E0")]
	public static NativeArray<int> IFGAMPLFKAO(NativeArray<int> DEPAIOJPNPJ, int NECDGJBLCMO, NativeArray<int> HOENBLBOKOL, int BDDNACANNAK)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B39BD0", Offset = "0x3B38FD0", VA = "0x183B39BD0")]
	private static void NAAEDMHNNLE<T>(NativeArray<T> LMLCJEFLFMP, int IPMGDBCGFMM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3B39B20", Offset = "0x3B38F20", VA = "0x183B39B20")]
	private static void IHLCJNNJHAG<T>(NativeArray<T> DEPAIOJPNPJ, int NECDGJBLCMO, NativeArray<T> HOENBLBOKOL, int BDDNACANNAK, NativeArray<T> FFLDMILBNBM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class AHFNABHDBIE
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct KDBLFJLOHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort FNBJHADJBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort MODFPFNICHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort CACADFINDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort JHGGPBHIHKA;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x83570A0", Offset = "0x83564A0", VA = "0x1883570A0")]
	public static uint OPMEGOKMLHF(float PGNABADOGGM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8356F10", Offset = "0x8356310", VA = "0x188356F10")]
	public static void IIHKJIPFDHH(float4 FBOGEDHOCIA, float APCFEGEMDLE, [Out] uint KOCIOHFNGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8356E40", Offset = "0x8356240", VA = "0x188356E40")]
	public static void IIHKJIPFDHH(float4 FBOGEDHOCIA, uint AKFLAMHFDBO, [Out] uint KOCIOHFNGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8356540", Offset = "0x8355940", VA = "0x188356540")]
	public static void FAOKGCIEKAN(float3 JHIJIKKIAFC, float3 PLBOHAILMKC, float4 GKFBBPLGMAB, float2 FCHNAMJMMGC, float4 FBOGEDHOCIA, [Out] CGCDLCFCEHB.KMKHIHCKCPI EPDDHIIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8356790", Offset = "0x8355B90", VA = "0x188356790")]
	public static void FAOKGCIEKAN(float3 JHIJIKKIAFC, float3 PLBOHAILMKC, float4 GKFBBPLGMAB, float2 FCHNAMJMMGC, float4 FBOGEDHOCIA, [Out] CGCDLCFCEHB.KDBPPEKOKAM EPDDHIIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x8356CA0", Offset = "0x83560A0", VA = "0x188356CA0")]
	public static byte HAFLIBCOCOL(float CBMEHPPMEEA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x8357050", Offset = "0x8356450", VA = "0x188357050")]
	public static ushort OIABGJEPNNF(float CBMEHPPMEEA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x8357020", Offset = "0x8356420", VA = "0x188357020")]
	public static uint JOFANPEPKGC(float CBMEHPPMEEA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x83564C0", Offset = "0x83558C0", VA = "0x1883564C0")]
	public static float2 ECLCFHBOGDK(float2 EMOJJIEJAKM)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8356B50", Offset = "0x8355F50", VA = "0x188356B50")]
	public static float2 GONEFKHGLBK(float3 FFIGKKPMMAC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x8356CF0", Offset = "0x83560F0", VA = "0x188356CF0")]
	public static void HKMOPGODGPK(float3 CBMEHPPMEEA, [Out] float3 GIGCNHJPBOJ, [Out] uint3 JHGGPBHIHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x83569F0", Offset = "0x8355DF0", VA = "0x1883569F0")]
	public static KDBLFJLOHMM FNNOMMPFIME(float3 LBCFHLNAPLC)
	{
		return default(KDBLFJLOHMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class ICFPFFFIEIE
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker PPDHCGIENOA;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float LIOFCGDNAMD;

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void FNCICACPEDO(bool EFCFKBANEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8360450", Offset = "0x835F850", VA = "0x188360450")]
	public static float NCEKIGDMGJA(float JMHMFDDOBBF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x835FE80", Offset = "0x835F280", VA = "0x18835FE80")]
	public static long BPDMGKHIKHF(float JMHMFDDOBBF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x835FF70", Offset = "0x835F370", VA = "0x18835FF70")]
	public static void CCOOKNDPBCM(float JMHMFDDOBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface DFHBHLJAJMD
{
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCOOKNDPBCM(float FAEALDDGKDA);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) JEPNHIKBBDK(float KHCPIPDBLPG);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class LKFDMBMMNCD
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum OLBJOCCNDAN
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
	private class LGPKKMHGJPA : HBFHKLDAHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public OLBJOCCNDAN IIHAKBEOLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public BatchedMeshRenderer HJBHAHPDKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public AOEIODPHEPO ADIBCKOPFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public LLMIHCNJBEG KIIOIDPJOFG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override float GGCGBFNNIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x1246840", Offset = "0x1245C40", VA = "0x181246840", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x19ED750", Offset = "0x19ECB50", VA = "0x1819ED750", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x83790A0", Offset = "0x83784A0", VA = "0x1883790A0", Slot = "7")]
		public override void KMBBCCKJAHA([Out] bool JOMGNBIDNCC, [Out] bool LMKDNAEMHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LGPKKMHGJPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int KGKCMNOPKOI;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int MJLHGEJCLKL;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int BAIHLFBFDAJ;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long DEGOPDGGPAP;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long JPDMKDGDEIB;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long OCHGILINPMJ;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long CDFCFLHECKJ;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int JHHBAHHCMON;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float HHFFAJBJFLC;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool BKLLHIMACHE;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int IMJGOEBPBEK;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int DIHEHPHBCBJ;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int HLNKJGGJAFJ;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long OKHNPOEIPFN;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int MOOIIDFLDBE;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool MHGABCHHJKP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static uint EBBNDBBBAOB;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static GKHAKDHJPOE KNCIMKBLBCF;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static List<uint> EHBEBBDMBKA;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static DFHBHLJAJMD LJKNGFFFKIF;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static DFHBHLJAJMD DCKPOBFFHCF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool IACAHNCECJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8367EA0", Offset = "0x83672A0", VA = "0x188367EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void BDKIFIDAEEK(bool EFCFKBANEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void FNCICACPEDO(bool EFCFKBANEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void BDKIFIDAEEK(bool EFCFKBANEMM, string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x8367B10", Offset = "0x8366F10", VA = "0x188367B10")]
	public static void CDMGBECGMHJ(DFHBHLJAJMD NLLFNOONAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x8368B30", Offset = "0x8367F30", VA = "0x188368B30")]
	public static void LHKILDKIAHI(DFHBHLJAJMD NLLFNOONAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x8368DC0", Offset = "0x83681C0", VA = "0x188368DC0")]
	public static (long, long, long, int, int) LPLIGJGBADB(long CAKMGAKLHPH)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8368F90", Offset = "0x8368390", VA = "0x188368F90")]
	public static void OMONLNCNECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x83656E0", Offset = "0x8364AE0", VA = "0x1883656E0")]
	public static void CCOOKNDPBCM(long CAKMGAKLHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8367EF0", Offset = "0x83672F0", VA = "0x188367EF0")]
	public static void ILJHAKMPCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x83653B0", Offset = "0x83647B0", VA = "0x1883653B0")]
	public static long BLHNJBMFGKA(long AKAOLGODGBD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x83690D0", Offset = "0x83684D0", VA = "0x1883690D0")]
	public static bool PJCDPACBPDB(long FBPLAEHKIPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x83652E0", Offset = "0x83646E0", VA = "0x1883652E0")]
	public static bool ACBBAEOAAJJ(long FBPLAEHKIPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8368000", Offset = "0x8367400", VA = "0x188368000")]
	public static float JAGDMDKBOLO(long GLBHCPLLEDN, int OCJCLHHKGKI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8368510", Offset = "0x8367910", VA = "0x188368510")]
	public static (long, long, int) JEPNHIKBBDK(float JMHMFDDOBBF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8367D10", Offset = "0x8367110", VA = "0x188367D10")]
	public static void FFGNIFNPGFL(LLMIHCNJBEG KIIOIDPJOFG, BatchedMeshRenderer HJBHAHPDKCC, long HDCMOEKNIMC, long OLMOIBNHHGJ, float NFJAFKFGGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8365560", Offset = "0x8364960", VA = "0x188365560")]
	public static void BMJFMFPMLKO(LLMIHCNJBEG KIIOIDPJOFG, BatchedMeshRenderer HJBHAHPDKCC, long HDCMOEKNIMC, long OLMOIBNHHGJ, float KGIFNGDEAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8368980", Offset = "0x8367D80", VA = "0x188368980")]
	public static void JJAGFCJHJBN(AOEIODPHEPO ADIBCKOPFGF, BatchedMeshRenderer HJBHAHPDKCC, long OLMOIBNHHGJ, float KGIFNGDEAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8368360", Offset = "0x8367760", VA = "0x188368360")]
	public static void JBOMCDOGONC(LLMIHCNJBEG KIIOIDPJOFG, BatchedMeshRenderer HJBHAHPDKCC, long HDCMOEKNIMC, long OLMOIBNHHGJ, float KGIFNGDEAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8368BA0", Offset = "0x8367FA0", VA = "0x188368BA0")]
	private static void LIHHANLAHBE(OLBJOCCNDAN IIHAKBEOLJD, LLMIHCNJBEG KIIOIDPJOFG, AOEIODPHEPO ADIBCKOPFGF, BatchedMeshRenderer HJBHAHPDKCC, long HDCMOEKNIMC, long OLMOIBNHHGJ, float INKIHDKOADJ, bool DGOEBDMLBGG, bool HLDMEIOMKJG, float ODFIJNEMHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8369010", Offset = "0x8368410", VA = "0x188369010")]
	public static bool PBCJCMKOLGL(float MFKECIAHHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8367C90", Offset = "0x8367090", VA = "0x188367C90")]
	public static void EKFOCNMMGEI(float MFKECIAHHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8367B80", Offset = "0x8366F80", VA = "0x188367B80")]
	public static bool CEOADCMDALO(float MFKECIAHHEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class HBFHKLDAHEB : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum NADALAFPCAC : byte
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
	public NADALAFPCAC ODHCJJALNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public long JFFDNDAIPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public long OLMOIBNHHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public float EGFIDMGDFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool HLDMEIOMKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public bool DGOEBDMLBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	internal uint CLNGGGMIBPI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract float GGCGBFNNIDJ
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
	public abstract void KMBBCCKJAHA([Out] bool JOMGNBIDNCC, [Out] bool LMKDNAEMHPD);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8376620", Offset = "0x8375A20", VA = "0x188376620", Slot = "4")]
	public int CompareTo(object DEJGDIIDCDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected HBFHKLDAHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class GKHAKDHJPOE : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private List<HBFHKLDAHEB> FGLJLPHOBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private List<HBFHKLDAHEB> GHFNGPODMAB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8376250", Offset = "0x8375650", VA = "0x188376250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8376390", Offset = "0x8375790", VA = "0x188376390")]
	public void KOBMLIBBKBO(HBFHKLDAHEB GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8376330", Offset = "0x8375730", VA = "0x188376330")]
	public void KDBPIKMBPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x83762A0", Offset = "0x83756A0", VA = "0x1883762A0")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8375F20", Offset = "0x8375320", VA = "0x188375F20")]
	public void DBAFFOLKJHN(IEnumerable<uint> EHBEBBDMBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8375E60", Offset = "0x8375260", VA = "0x188375E60")]
	private void CBDHBFLGDII(uint CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x83764C0", Offset = "0x83758C0", VA = "0x1883764C0", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8376460", Offset = "0x8375860", VA = "0x188376460")]
	public MKGPLMKGIFM OJAPBOKMMBI()
	{
		return default(MKGPLMKGIFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x8376560", Offset = "0x8375960", VA = "0x188376560")]
	public GKHAKDHJPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct MKGPLMKGIFM : IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private List<HBFHKLDAHEB> FGLJLPHOBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private List<HBFHKLDAHEB> GHFNGPODMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private int JNFFALDDOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private int LKFPIGABMJG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x83844E0", Offset = "0x83838E0", VA = "0x1883844E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public HBFHKLDAHEB FEIHGLOFMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x83841C0", Offset = "0x83835C0", VA = "0x1883841C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x83844F0", Offset = "0x83838F0", VA = "0x1883844F0")]
	public MKGPLMKGIFM(List<HBFHKLDAHEB> FGLJLPHOBFE, List<HBFHKLDAHEB> GHFNGPODMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8384340", Offset = "0x8383740", VA = "0x188384340", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x83844D0", Offset = "0x83838D0", VA = "0x1883844D0", Slot = "6")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class AOEIODPHEPO
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal enum IMJOODALPJP
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
	public static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly string GGGFLEHIMJH;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly string LHJBNCJLJLN;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker LEHPEFAEOJO;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker LJAEIBKABKC;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker PPDHCGIENOA;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker MIKFKKHAEBG;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker LPPJFEHAHKH;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker NPGBBHFNEPC;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker HINIOHKFGKN;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker HBJONCIAMAM;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker HNHAPPHIPKH;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker KMCKJFDMBHN;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker PCOCBLMBANI;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker BKNNJHHNKFH;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker JOFCGGLLNLA;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker CFOFCBDMHBM;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker ABEPKOFOIGD;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker OBPAMMIGCIN;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker HPMLKDLEJPK;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly ProfilerMarker BOABOFBPBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal readonly List<LLMIHCNJBEG> OFHNIEJNNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly NMFBOPDALLH BPMHIGNEEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	internal int EIDLEIMJALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	internal int DGKMMDBOAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	internal bool BNEILBKPOJB;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public const bool BOFDMFENKGH = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public bool NJAHIDBFOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	internal IMJOODALPJP FNFIGCEJOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	internal int AJFPHAILPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	internal int FMJFIKNOHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	internal int LNNKBIHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	internal int CGEDHJFKNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	internal long PIGAFKDMNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	internal long KILAMPLGFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	internal long NKLLLINPDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private CGCDLCFCEHB NOJFGPHDNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private CGCDLCFCEHB LGIFAAJCGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private CGCDLCFCEHB.EDHPDAAIBDC KFPLPHLCJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private bool PGMJLOCBEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private int CPFPHDEEIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private JAPDIDCBEON EBBFGDMELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private float3 OLMAMELBEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private float FLIIAIKFHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private float FIFKNKLCGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private float PGKLFPBAPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private float KILGPDDDDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private float KLODHNHPKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float EPEHEBDHOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private float3 OCHFCLNDKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float MBJFMDFBBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private float OMHMBFMMPCI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal Mesh GEGAOALOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MeshFilter EHILAPMHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MeshRenderer LHGJFDGFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<Material> ANDLNCOKLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BIJADOGALBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xAD29F0", Offset = "0xAD1DF0", VA = "0x180AD29F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int FDPLHEOFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8372940", Offset = "0x8371D40", VA = "0x188372940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8372810", Offset = "0x8371C10", VA = "0x188372810")]
	public void GGCIALFKOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8373360", Offset = "0x8372760", VA = "0x188373360")]
	public bool JJOLAMECJGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8370130", Offset = "0x836F530", VA = "0x188370130")]
	private void BHLKKJGBGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x83731A0", Offset = "0x83725A0", VA = "0x1883731A0")]
	private void JGCJPFODBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8375D40", Offset = "0x8375140", VA = "0x188375D40")]
	public AOEIODPHEPO(string HDNPPEBJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8372B90", Offset = "0x8371F90", VA = "0x188372B90")]
	public void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8372E50", Offset = "0x8372250", VA = "0x188372E50")]
	private void JDBKMPAPAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8370810", Offset = "0x836FC10", VA = "0x188370810")]
	private void BOEMNECCBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x836FE90", Offset = "0x836F290", VA = "0x18836FE90")]
	private void ADCEGIBGONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x83742F0", Offset = "0x83736F0", VA = "0x1883742F0")]
	public Mesh NKHEIGAMMKF(MeshFilter NIKABFAIENA, Transform GANAIKEBLIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8371B20", Offset = "0x8370F20", VA = "0x188371B20")]
	public void CMJFOIFONIE(bool HBMFPAOEIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x83718C0", Offset = "0x8370CC0", VA = "0x1883718C0")]
	private void CGPNAPIOBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8371A10", Offset = "0x8370E10", VA = "0x188371A10")]
	public void CIBLFJEDMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8372960", Offset = "0x8371D60", VA = "0x188372960")]
	public void HFEDMCKFDCJ(AHNPBENMMNA OPLLFEHGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8373480", Offset = "0x8372880", VA = "0x188373480")]
	public bool KGCEGFGOEJN(AHNPBENMMNA OPLLFEHGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x8370250", Offset = "0x836F650", VA = "0x188370250")]
	public bool BIEHLJBGGLM(AHNPBENMMNA OPLLFEHGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x8371730", Offset = "0x8370B30", VA = "0x188371730", Slot = "4")]
	public virtual void CEGJFAIHGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x8371E40", Offset = "0x8371240", VA = "0x188371E40")]
	public void DENKEKDOEIA(Transform MKODIMHMJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x8374360", Offset = "0x8373760", VA = "0x188374360")]
	public bool OOFCDKBPCCK(Transform MKODIMHMJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x83752F0", Offset = "0x83746F0", VA = "0x1883752F0")]
	public bool PEPNLAGGNMH(bool JPCKEMBNILO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x8372270", Offset = "0x8371670", VA = "0x188372270")]
	private void DFNPKOGLIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x8370AC0", Offset = "0x836FEC0", VA = "0x188370AC0")]
	public bool CCOOKNDPBCM(float4x4 MMPBDMLMPGJ, BatchedMeshRenderer KEEHIMNBLEH, bool OGJAPHJMMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x8372760", Offset = "0x8371B60", VA = "0x188372760")]
	public bool FOPPHEOBGEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x8374660", Offset = "0x8373A60", VA = "0x188374660")]
	public bool PBKKDBDDMMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x8373850", Offset = "0x8372C50", VA = "0x188373850")]
	public void MKFHKFPMKLN(CGCDLCFCEHB NIKBNBLEJEO, int EOGDAHDNKDB, int MPNJGIHLJLH, float GECIODLMLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x83755F0", Offset = "0x83749F0", VA = "0x1883755F0")]
	public (long, long, long) PFNBKNKJCCO()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440")]
	public long KJHNLCDBLJH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x8370700", Offset = "0x836FB00", VA = "0x188370700")]
	private void BMDHOOIENJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x8372EF0", Offset = "0x83722F0", VA = "0x188372EF0")]
	public (long, long, int) JEPNHIKBBDK(float JMHMFDDOBBF, float4x4 MMPBDMLMPGJ)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xF92FE0", Offset = "0xF923E0", VA = "0x180F92FE0")]
	internal void OCCJNGHOOLD(IMJOODALPJP PMANLCOLFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x83739B0", Offset = "0x8372DB0", VA = "0x1883739B0")]
	internal (float, float, float, float) NCDFFLNECEG(float FPNEODBGKFI, float4x4 MMPBDMLMPGJ)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x836FF30", Offset = "0x836F330", VA = "0x18836FF30")]
	private void AKHOGOILBHO(CGCDLCFCEHB OLENFNKNFIC, CGCDLCFCEHB.EDHPDAAIBDC NKKJBACDLKC, bool KEGHODJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x8375790", Offset = "0x8374B90", VA = "0x188375790")]
	private void PFPFOMJEBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8372D40", Offset = "0x8372140", VA = "0x188372D40")]
	internal bool JBGCJENMLIC(bool JPCKEMBNILO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x8372390", Offset = "0x8371790", VA = "0x188372390")]
	private void EJADDHBIKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8370A20", Offset = "0x836FE20", VA = "0x188370A20")]
	private void CBPNNHGJCMH(CGCDLCFCEHB.EDHPDAAIBDC NKKJBACDLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8373680", Offset = "0x8372A80", VA = "0x188373680")]
	private void LMLLCFKODGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x83703D0", Offset = "0x836F7D0", VA = "0x1883703D0")]
	public long BLHNJBMFGKA(long AKAOLGODGBD, int IFKFDOKJJJJ)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class LLMIHCNJBEG
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum HLOHHEDBGBM
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
	public struct BIEGKJCMMPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int EOHGCIHCMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int BEKKFILOPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public float DOEMPECIDDM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct NJGNLPACMFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public HKPCMJIDKMO NIKBNBLEJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public int OGNILFLHJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int HOEJLDLHNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public long KLHKHBKANNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public long IOJEIHBHIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public float NMGLBIPMDBD;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x83845B0", Offset = "0x83839B0", VA = "0x1883845B0")]
		public void IPJPKJAMFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8384530", Offset = "0x8383930", VA = "0x188384530")]
		public void HNJLALOFPOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private static readonly string GGGFLEHIMJH;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private static readonly string LHJBNCJLJLN;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private static readonly ProfilerMarker LEHPEFAEOJO;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private static readonly ProfilerMarker NGHCEGNNCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private static readonly ProfilerMarker PPDHCGIENOA;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private static readonly ProfilerMarker PECHPAEBCEO;

	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private static readonly ProfilerMarker MIKFKKHAEBG;

	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private static readonly ProfilerMarker LPPJFEHAHKH;

	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private static readonly ProfilerMarker NPGBBHFNEPC;

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private static readonly ProfilerMarker HINIOHKFGKN;

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly ProfilerMarker HBJONCIAMAM;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly ProfilerMarker AKIECFIDBNP;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly ProfilerMarker HNHAPPHIPKH;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly ProfilerMarker NCCONPKEKDD;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly ProfilerMarker KNIBPGEKMFM;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker HABMPOPGHLM;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker CGAPKBKNNDC;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker KMCKJFDMBHN;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker PCOCBLMBANI;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker BKNNJHHNKFH;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker JOFCGGLLNLA;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker CFOFCBDMHBM;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker ABEPKOFOIGD;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker OBPAMMIGCIN;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker HPMLKDLEJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	internal readonly List<AHNPBENMMNA> NMFJIONMIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	internal AOEIODPHEPO DPNGFOECOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private readonly NMFBOPDALLH BPMHIGNEEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	internal int KDOKODCKDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	internal int KEFCLFPCAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	internal bool GJPHLBMICFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	internal bool FOJIIPGAAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	internal HLOHHEDBGBM CJAPACCGCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	internal bool LICHONKPNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	internal float3 FFCMBEOMNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal float3 GHLCDCHNAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal float GJGNLOPMBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal int LCIPIHMEHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal int DHNIJPFOJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal int GIKFPONNFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal float IAMKFHGMMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	internal int CMGHEMDDFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal float GEDHIGAEHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal float BHCKFANNPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal int INPCGOOBHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal long DCOGDMPMNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public int FPNKHJGHIOK;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal const int DAGJOCAPFFC = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal float[] MLFMKGPAIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal int[] PBEAOJIDLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal long[] FHBHGBDAKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public List<NJGNLPACMFD> CKNKOGJIAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal CGCDLCFCEHB GBPBNGNGDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal long JJPIBJGEBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal int FKDNEEAKCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal float MELIEGGOPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal CGCDLCFCEHB.EDHPDAAIBDC IFNKAHNLHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	internal HKPCMJIDKMO FMKEGHLHODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal int IEIHBHLPEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float NNCHPCNIHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal long EIHACOHPPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal bool GMLFLAHFIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	internal JFPGEAIDPHA PKBKBMFNHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal JobHandle ADBACLJDCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal NativeList<BIEGKJCMMPI> FELFFBJFNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal NativeArray<long> MNBANHINGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal bool FDKGNOOJDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal JobHandle MOPDGCDMLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal CGCDLCFCEHB IFLOEKMLIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	internal BGBHELJOJCI PPNDCCJNEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal NativeList<BIEGKJCMMPI> MCMFMJNCGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal Transform DGEBNAFHAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal FOBJPMBJJIL PMBKCEJIOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal long CHFDHKCJPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	internal long DEOBHDJNEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal long KJLIOEBELKO;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private static bool HOHLFBCKJBA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<AHNPBENMMNA> DFINCKOJPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal int FDPLHEOFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x837E580", Offset = "0x837D980", VA = "0x18837E580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x837E480", Offset = "0x837D880", VA = "0x18837E480")]
	internal void GGCIALFKOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x837A7A0", Offset = "0x8379BA0", VA = "0x18837A7A0")]
	internal void BHLKKJGBGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8383DE0", Offset = "0x83831E0", VA = "0x188383DE0")]
	internal LLMIHCNJBEG(string HDNPPEBJPAE, AOEIODPHEPO JIECBJMGMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x837FC60", Offset = "0x837F060", VA = "0x18837FC60")]
	internal void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x837C420", Offset = "0x837B820", VA = "0x18837C420")]
	internal void CGPNAPIOBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8381050", Offset = "0x8380450", VA = "0x188381050")]
	internal void LEFLBAGNPNA(AHNPBENMMNA OPLLFEHGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x837C800", Offset = "0x837BC00", VA = "0x18837C800")]
	internal bool DBHMLJJPHCB(AHNPBENMMNA OPLLFEHGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x83819C0", Offset = "0x8380DC0", VA = "0x1883819C0")]
	internal bool NGPLHICIIKA(AHNPBENMMNA OPLLFEHGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x837C3A0", Offset = "0x837B7A0", VA = "0x18837C3A0", Slot = "4")]
	internal virtual void CEGJFAIHGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x837E490", Offset = "0x837D890", VA = "0x18837E490")]
	public float GHIKJEOIJNK(float BHJNMGDICJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x83807D0", Offset = "0x837FBD0", VA = "0x1883807D0")]
	public bool JEIOJBDGOEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x837F630", Offset = "0x837EA30", VA = "0x18837F630")]
	public (HKPCMJIDKMO, CGCDLCFCEHB.EDHPDAAIBDC) HAJEKJDNGDL()
	{
		return default((HKPCMJIDKMO, CGCDLCFCEHB.EDHPDAAIBDC));
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8380E80", Offset = "0x8380280", VA = "0x188380E80")]
	internal long KGGDPEJPPOC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x8380F30", Offset = "0x8380330", VA = "0x188380F30")]
	internal long KOENMCHKKAE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x837E980", Offset = "0x837DD80", VA = "0x18837E980")]
	internal bool GPJBNIIGADO(Transform MKODIMHMJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x8382890", Offset = "0x8381C90", VA = "0x188382890")]
	internal bool PEPNLAGGNMH(bool JPCKEMBNILO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x837C880", Offset = "0x837BC80", VA = "0x18837C880")]
	internal void DFNPKOGLIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x837B3E0", Offset = "0x837A7E0", VA = "0x18837B3E0")]
	internal bool CCOOKNDPBCM(float4x4 MMPBDMLMPGJ, BatchedMeshRenderer KEEHIMNBLEH, bool OGJAPHJMMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x83822C0", Offset = "0x83816C0", VA = "0x1883822C0")]
	internal bool OLIJKOHHJGH(bool JPCKEMBNILO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x837A6E0", Offset = "0x8379AE0", VA = "0x18837A6E0")]
	internal void AMAPCJJHJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x8381360", Offset = "0x8380760", VA = "0x188381360")]
	internal void MKFHKFPMKLN(CGCDLCFCEHB NIKBNBLEJEO, int EOGDAHDNKDB, int MPNJGIHLJLH, float GECIODLMLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x8382600", Offset = "0x8381A00", VA = "0x188382600")]
	internal void PDHGMJBEMBH(HKPCMJIDKMO KINKAPDOHPM, int EOGDAHDNKDB, int MPNJGIHLJLH, float GECIODLMLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x837AFE0", Offset = "0x837A3E0", VA = "0x18837AFE0")]
	internal void BMDHOOIENJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x83809D0", Offset = "0x837FDD0", VA = "0x1883809D0")]
	internal (long, long, int) JEPNHIKBBDK(float JMHMFDDOBBF, float4x4 MMPBDMLMPGJ, float NHODHOPLCHN)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0xA7BA10", Offset = "0xA7AE10", VA = "0x180A7BA10")]
	internal void OCCJNGHOOLD(HLOHHEDBGBM PMANLCOLFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x8381390", Offset = "0x8380790", VA = "0x188381390")]
	public static (float, float, float, float) NCDFFLNECEG(float3 ELENMEMNJLI, float3 KHIGCCJENID, float FPNEODBGKFI, float4x4 MMPBDMLMPGJ, float NHODHOPLCHN)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x8381780", Offset = "0x8380B80", VA = "0x188381780")]
	internal (float, float, float, float) NCDFFLNECEG(float FPNEODBGKFI, float4x4 MMPBDMLMPGJ, float NHODHOPLCHN)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x837CE40", Offset = "0x837C240", VA = "0x18837CE40")]
	private float DNMENOKEBPM(float FPNEODBGKFI, float4x4 MMPBDMLMPGJ, float NHODHOPLCHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x8381A20", Offset = "0x8380E20", VA = "0x188381A20")]
	private (int, int, float) NPFGBOBDIDA(float EMIELBGGEPI)
	{
		return default((int, int, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x837A6F0", Offset = "0x8379AF0", VA = "0x18837A6F0")]
	internal static float AONNFEFPOGL(AHNPBENMMNA NIKBNBLEJEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x837D530", Offset = "0x837C930", VA = "0x18837D530")]
	internal void GEBEIPKNJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x83812D0", Offset = "0x83806D0", VA = "0x1883812D0")]
	internal void LMLLCFKODGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8381F90", Offset = "0x8381390", VA = "0x188381F90")]
	internal void NPNJJFOHAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x837A8E0", Offset = "0x8379CE0", VA = "0x18837A8E0")]
	internal long BLHNJBMFGKA(long AKAOLGODGBD, int IFKFDOKJJJJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x8379B30", Offset = "0x8378F30", VA = "0x188379B30")]
	private void ADLALDCGMMB(CGCDLCFCEHB FACGPHOFIJA, NativeList<BIEGKJCMMPI> FNIBJJNJIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x837E5A0", Offset = "0x837D9A0", VA = "0x18837E5A0")]
	internal void GLECAAJMENM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x837CEA0", Offset = "0x837C2A0", VA = "0x18837CEA0")]
	public static void FHFJLNOKBAP(NativeList<BIEGKJCMMPI> CAPKODJICOB, CGCDLCFCEHB FACGPHOFIJA, int JNAPPDFHGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x8382570", Offset = "0x8381970", VA = "0x188382570")]
	private float OMFHEELHMIJ(int CKCOFICGKCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x837FD90", Offset = "0x837F190", VA = "0x18837FD90")]
	internal void IDGCJHGLBCD(CGCDLCFCEHB NIKBNBLEJEO, PJAMNHHCFMP KINKAPDOHPM, int EOGDAHDNKDB, int MPNJGIHLJLH, float GECIODLMLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BurstCompile]
internal struct LALKFIHNAMB : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal struct AFEAHBIEGAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int HGHPDDFKPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int FMILIIOGPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int HEECBPPGODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public float EAPMFJDJGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float EGKLPIKGJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float GMJGHNDJJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public float JBNCBMOJMLL;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	internal struct DIHKPDFCMPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int HGHPDDFKPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int FMILIIOGPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int HEECBPPGODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int CGFENCPJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float EAPMFJDJGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public float EGKLPIKGJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public float NENOMOMPDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public float ODLLJKGCJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public float JBNCBMOJMLL;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public struct KALAJIDHAEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int CKFFKJCHING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int BECBEJJEOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public float PONAJJLPOPA;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public delegate void EMFEFHJMJEE(LALKFIHNAMB CMKFNCBIMAI, [In] AFEAHBIEGAJ KJMIGMNGGIA);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class CPJJELICNKD
	{
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x838D0E0", Offset = "0x838C4E0", VA = "0x18838D0E0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x838D210", Offset = "0x838C610", VA = "0x18838D210")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x838D370", Offset = "0x838C770", VA = "0x18838D370")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x838CEF0", Offset = "0x838C2F0", VA = "0x18838CEF0")]
		public static void COEOEEINBLF(LALKFIHNAMB CMKFNCBIMAI, [In] AFEAHBIEGAJ KJMIGMNGGIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void KLMICNNDKLI(LALKFIHNAMB CMKFNCBIMAI, [In] DIHKPDFCMPP EEFDKMEEKAO);

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal static class ECPMFNBEEOB
	{
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x838D610", Offset = "0x838CA10", VA = "0x18838D610")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x838D740", Offset = "0x838CB40", VA = "0x18838D740")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x838D8A0", Offset = "0x838CCA0", VA = "0x18838D8A0")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x838D420", Offset = "0x838C820", VA = "0x18838D420")]
		public static void COEOEEINBLF(LALKFIHNAMB CMKFNCBIMAI, [In] DIHKPDFCMPP EEFDKMEEKAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public unsafe delegate void NHADKGMNANL(UnsafeList<int>* KIJPJKILJJD, UnsafeList<float3>* ODLKKDPKICA, [NoAlias] float3* FNAMHLOCAEA, [NoAlias] float4* JKDDNHEGGML, [NoAlias] float2* OAOHPCAJMDB, [NoAlias] float4* DOAHAKCHBNK, UnsafeList<HOPIKKLNGMB>* NMJFHGOENHA, UnsafeList<int>* GMLHAPNODJJ, UnsafeList<float3>* FAMHEEGJBHO, [NoAlias] float3* FLCFCILDAIM, [NoAlias] float4* OPJBBCHEHFG, [NoAlias] float2* AGIHKBNMAJB, [NoAlias] float4* APONLEINBOE, int PFPBLIFJJFD, int IHNMIEEEPLH);

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal static class EDPIEKBIONO
	{
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x838DC90", Offset = "0x838D090", VA = "0x18838DC90")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x838DDC0", Offset = "0x838D1C0", VA = "0x18838DDC0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x838DF20", Offset = "0x838D320", VA = "0x18838DF20")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x838D950", Offset = "0x838CD50", VA = "0x18838D950")]
		public unsafe static void COEOEEINBLF(UnsafeList<int>* KIJPJKILJJD, UnsafeList<float3>* ODLKKDPKICA, [NoAlias] float3* FNAMHLOCAEA, [NoAlias] float4* JKDDNHEGGML, [NoAlias] float2* OAOHPCAJMDB, [NoAlias] float4* DOAHAKCHBNK, UnsafeList<HOPIKKLNGMB>* NMJFHGOENHA, UnsafeList<int>* GMLHAPNODJJ, UnsafeList<float3>* FAMHEEGJBHO, [NoAlias] float3* FLCFCILDAIM, [NoAlias] float4* OPJBBCHEHFG, [NoAlias] float2* AGIHKBNMAJB, [NoAlias] float4* APONLEINBOE, int PFPBLIFJJFD, int IHNMIEEEPLH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public float3 OLMAMELBEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public float PPKMCCCIEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public float JBAOLOCFMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public float BBFNNKCAEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public IINGJHHDOOJ.LILCJCMGJBN PMKOICEAGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public bool DEFKDJCCJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<HOPIKKLNGMB>* NMJFHGOENHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* GMLHAPNODJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<AFEAHBIEGAJ>* KIAPONLALFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<AFEAHBIEGAJ>* IJJPBKJHNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<DIHKPDFCMPP>* BGIKFEMNJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<DIHKPDFCMPP>* BFGPMHHMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public int BKBKFOPBKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public int KKCIEOFNLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public int POBMBILMIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe float3* FAMHEEGJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe int* LBOAEDCDJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe KALAJIDHAEH* LJLNHEOADNE;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8378690", Offset = "0x8377A90", VA = "0x188378690")]
	private static float KEBCJMLNALJ([In] LALKFIHNAMB CMKFNCBIMAI, [In] float3 FOLEHLKGMHO, float JBNCBMOJMLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x8378710", Offset = "0x8377B10", VA = "0x188378710")]
	private static int KGLBNPHDJEA(LALKFIHNAMB CMKFNCBIMAI, [Out] HOPIKKLNGMB KLMCIAKGBNJ, [In] HOPIKKLNGMB JFEDPDOBGOC, [In] HOPIKKLNGMB CKAKDMIENKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x8376750", Offset = "0x8375B50", VA = "0x188376750")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private static void AMHBNDIOMJO(LALKFIHNAMB CMKFNCBIMAI, [In] AFEAHBIEGAJ KJMIGMNGGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x83771F0", Offset = "0x83765F0", VA = "0x1883771F0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void ICMCILLOEOB(LALKFIHNAMB CMKFNCBIMAI, [In] DIHKPDFCMPP EEFDKMEEKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x83767B0", Offset = "0x8375BB0", VA = "0x1883767B0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x8377250", Offset = "0x8376650", VA = "0x188377250")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal void IJLAADAPBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x83767C0", Offset = "0x8375BC0", VA = "0x1883767C0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void GKKEBBAGNKD(UnsafeList<int>* KIJPJKILJJD, UnsafeList<float3>* ODLKKDPKICA, [NoAlias] float3* FNAMHLOCAEA, [NoAlias] float4* JKDDNHEGGML, [NoAlias] float2* OAOHPCAJMDB, [NoAlias] float4* DOAHAKCHBNK, UnsafeList<HOPIKKLNGMB>* NMJFHGOENHA, UnsafeList<int>* GMLHAPNODJJ, UnsafeList<float3>* FAMHEEGJBHO, [NoAlias] float3* FLCFCILDAIM, [NoAlias] float4* OPJBBCHEHFG, [NoAlias] float2* AGIHKBNMAJB, [NoAlias] float4* APONLEINBOE, int PFPBLIFJJFD, int IHNMIEEEPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8376850", Offset = "0x8375C50", VA = "0x188376850")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void HJHIBAIPOHB(LALKFIHNAMB CMKFNCBIMAI, [In] AFEAHBIEGAJ KJMIGMNGGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x8378890", Offset = "0x8377C90", VA = "0x188378890")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void OMNMEHNDAJD(LALKFIHNAMB CMKFNCBIMAI, [In] DIHKPDFCMPP EEFDKMEEKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x8377F80", Offset = "0x8377380", VA = "0x188377F80")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void JGODNDFDKPG(UnsafeList<int>* KIJPJKILJJD, UnsafeList<float3>* ODLKKDPKICA, [NoAlias] float3* FNAMHLOCAEA, [NoAlias] float4* JKDDNHEGGML, [NoAlias] float2* OAOHPCAJMDB, [NoAlias] float4* DOAHAKCHBNK, UnsafeList<HOPIKKLNGMB>* NMJFHGOENHA, UnsafeList<int>* GMLHAPNODJJ, UnsafeList<float3>* FAMHEEGJBHO, [NoAlias] float3* FLCFCILDAIM, [NoAlias] float4* OPJBBCHEHFG, [NoAlias] float2* AGIHKBNMAJB, [NoAlias] float4* APONLEINBOE, int PFPBLIFJJFD, int IHNMIEEEPLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class JAPDIDCBEON
{
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private static readonly ProfilerMarker HEICJBBLNFH;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public const int OMBIBEDAJJN = 2;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private const int EIOPMGMLAJP = 1;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private static int PNOFIALFHBP;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private static Stack<JAPDIDCBEON> KEAPIKCPCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private CGCDLCFCEHB EGECIHHCNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private NativeList<HOPIKKLNGMB> NMJFHGOENHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private NativeList<int> GMLHAPNODJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private NativeList<LALKFIHNAMB.AFEAHBIEGAJ> KIAPONLALFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private NativeList<LALKFIHNAMB.AFEAHBIEGAJ> IJJPBKJHNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private NativeList<LALKFIHNAMB.DIHKPDFCMPP> BGIKFEMNJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private NativeList<LALKFIHNAMB.DIHKPDFCMPP> BFGPMHHMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private LALKFIHNAMB CMKFNCBIMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private JobHandle EDPKGAKIIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private LALKFIHNAMB.KALAJIDHAEH AKDOECKMCMM;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private const int POBMBILMIKM = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x83950A0", Offset = "0x83944A0", VA = "0x1883950A0")]
	private JAPDIDCBEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x8394A30", Offset = "0x8393E30", VA = "0x188394A30")]
	public void PDECPBDCCBJ(CGCDLCFCEHB MLJLJOIIOFA, float3 EAAPJLBIKAK, float CHBHBHLDEHJ, float BKDDNAIAIEP, float JBPAIELBPPC, List<LLMIHCNJBEG.BIEGKJCMMPI> DLELKFNMFON, Allocator CBKIAFHAJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x83943F0", Offset = "0x83937F0", VA = "0x1883943F0")]
	public (bool, CGCDLCFCEHB, float) OKBIOMLGPEP(List<LLMIHCNJBEG.BIEGKJCMMPI> DLELKFNMFON, Allocator CBKIAFHAJFC, bool JPCKEMBNILO)
	{
		return default((bool, CGCDLCFCEHB, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x83942A0", Offset = "0x83936A0", VA = "0x1883942A0")]
	public static bool LAMDEMCADPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x8394330", Offset = "0x8393730", VA = "0x188394330")]
	public static int MHDDGHHJJFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8394380", Offset = "0x8393780", VA = "0x188394380")]
	public static int MIFNOMOHPLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8393F90", Offset = "0x8393390", VA = "0x188393F90")]
	public static JAPDIDCBEON DLADBGEEODF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8393EF0", Offset = "0x83932F0", VA = "0x188393EF0")]
	internal static void AMEJCGCFHLN(JAPDIDCBEON FMBICFIEHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8394E40", Offset = "0x8394240", VA = "0x188394E40")]
	public static void PGKEFIFIOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x83940F0", Offset = "0x83934F0", VA = "0x1883940F0")]
	[DIELKDJGIPF(LDIDCMPDDMG.ExitingPlayMode, 0)]
	public static void JMKKMHLEPLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BurstCompile]
internal struct HOPIKKLNGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public float3 DPIFCOHCFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public int NFKPIOHFKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public int BBPBBDOLMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public int AFGGDJEFMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public float KFILAKLCOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public float NDJMLGCJNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public int BJDBHPBEOCK;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x83919A0", Offset = "0x8390DA0", VA = "0x1883919A0")]
	public static void CEOONNIFPHP([Out] HOPIKKLNGMB HJBCDFKDKBA, int DLEDHAFEBMN, [In] float3 CCBKFFDHHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x83919F0", Offset = "0x8390DF0", VA = "0x1883919F0")]
	[IgnoreWarning(1371)]
	public static void CEOONNIFPHP([Out] HOPIKKLNGMB HJBCDFKDKBA, [In] HOPIKKLNGMB ICANJDFAIKK, [In] HOPIKKLNGMB EAGHDKDLMHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BurstCompile]
internal struct JFPGEAIDPHA : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct NIEMBAMIHGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int FIKLIHLAOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public int FNOMOLNMEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int DMIBJDEPPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int AFIJPGOCFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int NHPMCHALPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int IKHFDHJBFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public int OGNILFLHJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int HOEJLDLHNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public float JLLNLFPOPHO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private struct BOHAFIFBGKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public IINGJHHDOOJ.NDGOLPMNFPC FJMIKFGICLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public float KODNGDGOIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public float BHEBNOCNBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public float PMAILGEIFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public float HBINOADEKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public float JFCBKCDDPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public float PJAHBMKADBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public float EJMANAIPPGK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private struct OIKBBDMPAKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeArray<float3> AFGJFLOMCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeArray<float3> GGJILDJKAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeArray<float4> BPCJMPHJINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeArray<float4> FFHKMANAPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public NativeArray<float2> ENHKABHMDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public NativeArray<int> DBPEDIFKMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public bool JCKNFPCCBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int FDPLHEOFKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int AGCIPFOFBBK;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8398FB0", Offset = "0x83983B0", VA = "0x188398FB0")]
		public void AMHAEEMOGAM(int IHNMIEEEPLH, int PFPBLIFJJFD, Allocator KCEIEKBPKNP, bool IKLBOFELHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8398D60", Offset = "0x8398160", VA = "0x188398D60")]
		public static OIKBBDMPAKO ALEPAFLGLEL(CGCDLCFCEHB BEOBAPANJHO)
		{
			return default(OIKBBDMPAKO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8399190", Offset = "0x8398590", VA = "0x188399190")]
		public void HNJLALOFPOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private static readonly ProfilerMarker KKHIMJDDNPF;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private static readonly ProfilerMarker AHCMEEJNOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private NativeArray<NIEMBAMIHGK> JHDDPEKOLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private OIKBBDMPAKO AJIANDGODGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private OIKBBDMPAKO FACGPHOFIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private float3 BBKIEOKPCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private float3 MPLLHJKNBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private BOHAFIFBGKA HLBFGENPCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* CMHHJOLCHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<LLMIHCNJBEG.BIEGKJCMMPI> LAPJILJJCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NativeList<LLMIHCNJBEG.BIEGKJCMMPI> MFNNAAOBLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NativeArray<int> GMLHAPNODJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private NativeArray<bool> MJLHFDPLMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private NativeArray<int> IPDIBGLCBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private NativeArray<int> BMGLPANNBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private NativeArray<float> KIPKHINHOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private NativeArray<int> EBPMNFPBKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NativeArray<float> GHDIFGFDADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NativeArray<int> PHAAMBMAOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NativeArray<int> LODPAFFFFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private NativeArray<float> LFJIMPMEOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private NativeArray<float> NIMPOAPIHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private NativeArray<int> BAGLFDNLFFL;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x83982A0", Offset = "0x83976A0", VA = "0x1883982A0")]
	public JFPGEAIDPHA([In] List<LLMIHCNJBEG.NJGNLPACMFD> PPKEOEHEMBE, NativeList<LLMIHCNJBEG.BIEGKJCMMPI> MNGLOCOAPJC, [In] CGCDLCFCEHB ODGANNKOIOF, [In] NativeList<LLMIHCNJBEG.BIEGKJCMMPI> FNIBJJNJIFE, [In] NativeArray<long> MNBANHINGKK, float3 KKKNDIBPEHE, float3 MLIEAJBLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x83957E0", Offset = "0x8394BE0", VA = "0x1883957E0")]
	public static long GCEGNNDJAHD(int IHNMIEEEPLH, int PFPBLIFJJFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x8395470", Offset = "0x8394870", VA = "0x188395470", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8397790", Offset = "0x8396B90", VA = "0x188397790")]
	public void OBOFKNFBPAG(List<LLMIHCNJBEG.NJGNLPACMFD> HEPHOFOKOEF, [In] LLMIHCNJBEG AHBJPONNOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x83981E0", Offset = "0x83975E0", VA = "0x1883981E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private bool PCHFCMPKNLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x8395240", Offset = "0x8394640", VA = "0x188395240")]
	private HKPCMJIDKMO AMPJMAOPCKP(int GDGNPFIEJKD, Allocator KCEIEKBPKNP)
	{
		return default(HKPCMJIDKMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x8395800", Offset = "0x8394C00", VA = "0x188395800")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void GPFCONLHONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x8396F40", Offset = "0x8396340", VA = "0x188396F40")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float KMJMBOCMDBN(int EJPFKACKMII, int HOBHHOCICLE, bool EABIDEHBIAO, bool OKIIFEDEFLJ, float OHCKIIBMCAF, float OKPPANLHDAF, float MGCAFGBODIC, float NIHFEJNBEIJ, float GEEJLFMKLDH, float OBEFOPHGCJH, float GGBMICOCPME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x83954C0", Offset = "0x83948C0", VA = "0x1883954C0")]
	[IgnoreWarning(1371)]
	private NIEMBAMIHGK FMGNGOJPEKK([In] NIEMBAMIHGK PNGFPLGGOEM, int PADMIDCLMCM, [In] NativeArray<int> PCCEEKOEHBF, [In] NativeArray<bool> MJLHFDPLMHN, NativeArray<int> IPDIBGLCBCJ)
	{
		return default(NIEMBAMIHGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x83975B0", Offset = "0x83969B0", VA = "0x1883975B0")]
	public static int NEEAMBCKPJE(NativeArray<int> PCCEEKOEHBF, NativeArray<int> BAGLFDNLFFL, int OCKCIHFAMHA, int HDIMCIABDDG, int FMKFELAHACC)
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
		private struct JKCPFJNPPDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public long BBIMEAGEBHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public NNCAMIFAKGI EFDPEDFEFJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public AHNPBENMMNA PDPKIFONADM;

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x8398B70", Offset = "0x8397F70", VA = "0x188398B70")]
			public JKCPFJNPPDJ(NNCAMIFAKGI JDKNNJKNBBP, AHNPBENMMNA LPAPDHHNHKD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		private class CENGFJAFEKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NNCAMIFAKGI EFDPEDFEFJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public int JIHFJOICEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public float GJGNLOPMBNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public List<JKCPFJNPPDJ> KHANGDIOHCO;

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x838CE40", Offset = "0x838C240", VA = "0x18838CE40")]
			public CENGFJAFEKA(NNCAMIFAKGI JDKNNJKNBBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private static readonly ProfilerMarker EJOHAEKNNFE;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private static readonly ProfilerMarker NKPNPFLGKNF;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private static readonly ProfilerMarker JJDEIPDAIAC;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private static readonly ProfilerMarker LAMGAMOKKFM;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private static readonly ProfilerMarker GANJNMEGAPL;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private static readonly ProfilerMarker NPGBBHFNEPC;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private static readonly ProfilerMarker OCPAGOCDBJO;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		internal const int OPHLIEJIHFL = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		internal static Dictionary<Material, List<Material>> HEJKFKOEPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private Dictionary<Material, List<AOEIODPHEPO>> LCJOPNLDLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		internal List<AOEIODPHEPO> IANOOLIDPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private List<MeshRenderer> NOGJOFKLLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private Transform IHGGOBCKNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private bool NIMIOBLIJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private bool NBIOMOILGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private int BJEOBDADDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private AOEIODPHEPO NAOOJAFCMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private Material OODNJNOIEKC;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static bool? GCPPPONDIEE;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private const int GDINNLDPLDH = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private static List<JKCPFJNPPDJ> BGEMGCAIJIO;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<MeshRenderer> KNNHEFNDIHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int MMFHDMBBEEK
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x838CDF0", Offset = "0x838C1F0", VA = "0x18838CDF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private static bool DKPLBCGPIOI
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x8386010", Offset = "0x8385410", VA = "0x188386010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		private static void BDKIFIDAEEK(bool EFCFKBANEMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		private static void BDKIFIDAEEK(bool EFCFKBANEMM, string AFDNIPHJHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		private static void DNGGBJENLLI(string HDNPPEBJPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8386460", Offset = "0x8385860", VA = "0x188386460")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x83887C0", Offset = "0x8387BC0", VA = "0x1883887C0")]
		internal bool LKOHJPBIAFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x83874E0", Offset = "0x83868E0", VA = "0x1883874E0")]
		private Transform EFCJGKPHPII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x83891A0", Offset = "0x83885A0", VA = "0x1883891A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x83870D0", Offset = "0x83864D0", VA = "0x1883870D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x8386240", Offset = "0x8385640", VA = "0x188386240")]
		public AOEIODPHEPO AddToBatchedMesh(AHNPBENMMNA FNIMMCNNGMG, Material GMFBEMFEGJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x838C7B0", Offset = "0x838BBB0", VA = "0x18838C7B0")]
		public void RemoveFromBatchedMesh(AHNPBENMMNA NIKBNBLEJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8386FA0", Offset = "0x83863A0", VA = "0x188386FA0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x83891B0", Offset = "0x83885B0", VA = "0x1883891B0")]
		private void PFLFBJPBAEI(Renderer FOGLHINMCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8388490", Offset = "0x8387890", VA = "0x188388490")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8388480", Offset = "0x8387880", VA = "0x188388480")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8387D60", Offset = "0x8387160", VA = "0x188387D60")]
		private void HJIHAALHCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8388C60", Offset = "0x8388060", VA = "0x188388C60")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8388500", Offset = "0x8387900", VA = "0x188388500")]
		private AOEIODPHEPO KHHKLMPKKBM(AHNPBENMMNA NIKBNBLEJEO, Material GMFBEMFEGJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8388820", Offset = "0x8387C20", VA = "0x188388820")]
		private AOEIODPHEPO LNPGFIFKHNO(Material GMFBEMFEGJH, int PBPJDMBGBKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8386490", Offset = "0x8385890", VA = "0x188386490")]
		private AOEIODPHEPO BIGDCJPEHLM(Material GMFBEMFEGJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8388720", Offset = "0x8387B20", VA = "0x188388720")]
		internal float4x4 LIBNHFHHNIP()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8387560", Offset = "0x8386960", VA = "0x188387560")]
		public static List<Material> GenerateVertexFormatVariants(Material GMFBEMFEGJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x838C8F0", Offset = "0x838BCF0", VA = "0x18838C8F0")]
		public static void UpdateMaterialVariants(Material KBENCAFHPPG, Action<Material> DBGKPIKFMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x11FB0E0", Offset = "0x11FA4E0", VA = "0x1811FB0E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8388B00", Offset = "0x8387F00", VA = "0x188388B00")]
		public void MarkDirty(AHNPBENMMNA NIKBNBLEJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8386140", Offset = "0x8385540", VA = "0x188386140")]
		[Conditional("CHECK_STATE")]
		private void APCLDPBGLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8388DC0", Offset = "0x83881C0", VA = "0x188388DC0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float JMHMFDDOBBF)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8386E70", Offset = "0x8386270", VA = "0x188386E70")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x838B1E0", Offset = "0x838A5E0", VA = "0x18838B1E0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x83876D0", Offset = "0x8386AD0", VA = "0x1883876D0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8389310", Offset = "0x8388710", VA = "0x188389310")]
		public void RebatchOptimally(int OKHKDNHBBAJ, int ALPANPFGDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8389230", Offset = "0x8388630", VA = "0x188389230")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x838CCC0", Offset = "0x838C0C0", VA = "0x18838CCC0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class EFIGFFGBEFL
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct MAPBDJDNGEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public BatchedMeshRenderer FOGLHINMCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AOEIODPHEPO NIKBNBLEJEO;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1C95950", Offset = "0x1C94D50", VA = "0x181C95950")]
		public void MDMMCDOMCJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct FLLLGMHCAHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public float PCBDLFHAKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public AOEIODPHEPO KCAJKMALOIC;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class JADNDNPBMAI : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x12CA5C0", Offset = "0x12C99C0", VA = "0x1812CA5C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x8393D80", Offset = "0x8393180", VA = "0x188393D80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1515760", Offset = "0x1514B60", VA = "0x181515760")]
		[DebuggerHidden]
		public JADNDNPBMAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8393DD0", Offset = "0x83931D0", VA = "0x188393DD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x8392A80", Offset = "0x8391E80", VA = "0x188392A80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8392A30", Offset = "0x8391E30", VA = "0x188392A30")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x83929E0", Offset = "0x8391DE0", VA = "0x1883929E0")]
		private void AIFLPGLABJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8393D30", Offset = "0x8393130", VA = "0x188393D30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8393C80", Offset = "0x8393080", VA = "0x188393C80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8393C80", Offset = "0x8393080", VA = "0x188393C80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private static readonly ProfilerMarker NPGBBHFNEPC;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private static readonly ProfilerMarker PDJPNJGMKFM;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly ProfilerMarker EFGHPLLMINM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly ProfilerMarker NGNKJBDALKF;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static float3 JEJLBFGGMKF;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static int BMOAMKJCLHG;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static int BOAHEGMDDGF;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static int CAJCKFAOFKI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static int JEAKBFBHMEH;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static int BENKBCLHBFB;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static float JLKCBOEMKDA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static float LBAPABKKEOI;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static float GCBCMIEMKMC;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static float EJIJBBPOEMA;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static float CGJEFHHNKOI;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static float AFLOKBMAAAI;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static float HEKPOGEHPEO;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static float MMCAHCAEEEF;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static List<BatchedMeshRenderer> DMLOAPAHOFH;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static Stack<CGCDLCFCEHB> ODBAEFBKBIC;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static Stack<BGBHELJOJCI> MGFPJGCJAOK;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static IEKGCOIIEHP JIGKMBOLPNH;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private static MAPBDJDNGEP NCMMPAOGEMI;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static int GCOECJJAIMB;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void BDKIFIDAEEK(bool EFCFKBANEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void FNCICACPEDO(bool EFCFKBANEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void BDKIFIDAEEK(bool EFCFKBANEMM, string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8390370", Offset = "0x838F770", VA = "0x188390370")]
	public static void IPJPKJAMFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x838F7A0", Offset = "0x838EBA0", VA = "0x18838F7A0")]
	public static void EPODHNHGFMM(BatchedMeshRenderer HEGGKJEDGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8391010", Offset = "0x8390410", VA = "0x188391010")]
	public static void OMABGDKMJLA(BatchedMeshRenderer HEGGKJEDGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x83908A0", Offset = "0x838FCA0", VA = "0x1883908A0")]
	public static void MFAGKNALJDB(AHNPBENMMNA OPLLFEHGPKN, bool HBMFPAOEIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x838F8E0", Offset = "0x838ECE0", VA = "0x18838F8E0")]
	public static void FAJNBAGGEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x838ED90", Offset = "0x838E190", VA = "0x18838ED90")]
	public static void CCOOKNDPBCM(float JMHMFDDOBBF, bool GMHAKKKDADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x838FE70", Offset = "0x838F270", VA = "0x18838FE70")]
	private static void HDNPICLCEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x838E290", Offset = "0x838D690", VA = "0x18838E290")]
	public static long BLHNJBMFGKA(int IFKFDOKJJJJ, long AKAOLGODGBD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x83903F0", Offset = "0x838F7F0", VA = "0x1883903F0")]
	public static (long, long, int) JEPNHIKBBDK(float JMHMFDDOBBF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x838FDE0", Offset = "0x838F1E0", VA = "0x18838FDE0")]
	[IteratorStateMachine(typeof(JADNDNPBMAI))]
	public static IEnumerable<bool> HCDNKFDBOLK(long ABCFIMIBELK, bool JDIDEDAPLJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8391320", Offset = "0x8390720", VA = "0x188391320")]
	public static void PLDEGCBLBHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x8390600", Offset = "0x838FA00", VA = "0x188390600")]
	public static void LAGCMJMEJLC(long ABCFIMIBELK, bool JDIDEDAPLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x838FC60", Offset = "0x838F060", VA = "0x18838FC60")]
	public static int FFKGBFBFCKN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x838E110", Offset = "0x838D510", VA = "0x18838E110")]
	internal static CGCDLCFCEHB BFDHDGBOHLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x838DFD0", Offset = "0x838D3D0", VA = "0x18838DFD0")]
	internal static void AMEJCGCFHLN(CGCDLCFCEHB IGCDEJFLLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x838F650", Offset = "0x838EA50", VA = "0x18838F650")]
	internal static BGBHELJOJCI CPHCFDNGGKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x838E080", Offset = "0x838D480", VA = "0x18838E080")]
	internal static void AMEJCGCFHLN(BGBHELJOJCI HIEBDEGGHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x8391140", Offset = "0x8390540", VA = "0x188391140")]
	public static void PGKEFIFIOJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class GALEIMIIDFB<KeyType> : AOEIODPHEPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly Dictionary<KeyType, AHNPBENMMNA> HJDFGMDNDAP;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x4F3BFD0", Offset = "0x4F3B3D0", VA = "0x184F3BFD0")]
	public GALEIMIIDFB(string HDNPPEBJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4F3BDE0", Offset = "0x4F3B1E0", VA = "0x184F3BDE0")]
	public void HFEDMCKFDCJ(KeyType PEENICAIFOP, AHNPBENMMNA OPLLFEHGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4F3BF00", Offset = "0x4F3B300", VA = "0x184F3BF00")]
	public bool IFAPBMAPKLF(KeyType PEENICAIFOP, AHNPBENMMNA BADEEDLCEIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4F3BCA0", Offset = "0x4F3B0A0", VA = "0x184F3BCA0")]
	public void EPFPAPGMKJH(KeyType PEENICAIFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4F3BC60", Offset = "0x4F3B060", VA = "0x184F3BC60", Slot = "4")]
	public override void CEGJFAIHGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class IEAGOFBBEEF
{
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly ProfilerCategory LEGACEIJLDC;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	internal static readonly ProfilerMarker JAGDMDKBOLO;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	internal static readonly KGFPKNLNNPO CCOOKNDPBCM;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly ENONOAAJJON<float> LLHECDGJHIK;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly ENONOAAJJON<float> BBGKHECIJBF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly ENONOAAJJON<double> PFFPMMFPJML;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static readonly ENONOAAJJON<double> PFNIIPAJKII;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly ENONOAAJJON<double> BPLCCPCMNNA;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly ENONOAAJJON<int> FAHPIBDBMGC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly ENONOAAJJON<int> ECEOGKDBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly ENONOAAJJON<int> CCKHGNCNEIG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly ENONOAAJJON<int> GBPIAGNDBFP;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly ENONOAAJJON<int> LFDOODICPIM;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private static readonly ENONOAAJJON<int> DHBLJPECMLL;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly ENONOAAJJON<int> DEDEDPPLLJE;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private static readonly ENONOAAJJON<int> NBMIDENLHKK;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly ENONOAAJJON<long> FKFIOJNNPAP;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly ENONOAAJJON<long> ENKOLMCEPGB;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly ENONOAAJJON<long> DKHMDIEEGDD;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private static readonly ENONOAAJJON<long> CGPFHDEFIFL;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly ENONOAAJJON<long> EOJEDEELJOF;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private static readonly ENONOAAJJON<long> CLIGHAJBPGH;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8391CE0", Offset = "0x83910E0", VA = "0x188391CE0")]
	public static void ENMCMLOPKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8399250", Offset = "0x8398650", VA = "0x188399250")]
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
