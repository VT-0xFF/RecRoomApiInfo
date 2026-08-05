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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E36B40", Offset = "0x7E35940", VA = "0x187E36B40", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class IPHGPBBBNGD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IEBEPMGFCGH HPGCBOFLGLE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly IEBEPMGFCGH AHJKKAFIAJD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly IEBEPMGFCGH KFMOFDLFKEF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly IEBEPMGFCGH GMOGJJHDKOO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly IEBEPMGFCGH PMHCFLKLGPF;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class OKMIALHLADD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public GNJKBDAPAAO MOOAPBNCPIN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GFBHKKJANIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OKMIALHLADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct GNJKBDAPAAO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct FNJLOBGOJHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half CMFEGOODLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort LMKMEACCDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte CDPEGKCOGKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void CAEPDKODIIC([NoAlias] float3* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class HMNJKBKHGGM
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7E313F0", Offset = "0x7E301F0", VA = "0x187E313F0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E31290", Offset = "0x7E30090", VA = "0x187E31290")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7E31750", Offset = "0x7E30550", VA = "0x187E31750")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E31520", Offset = "0x7E30320", VA = "0x187E31520")]
		public unsafe static void HDKOJPGLKCE([NoAlias] float3* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void AOFNHBKPKHP([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class NDFEMBIGMLK
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E38DA0", Offset = "0x7E37BA0", VA = "0x187E38DA0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E38C40", Offset = "0x7E37A40", VA = "0x187E38C40")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E39180", Offset = "0x7E37F80", VA = "0x187E39180")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7E38ED0", Offset = "0x7E37CD0", VA = "0x187E38ED0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void FEPGKOFAABC([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class KJBBOKBFFDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E353B0", Offset = "0x7E341B0", VA = "0x187E353B0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7E35250", Offset = "0x7E34050", VA = "0x187E35250")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7E35790", Offset = "0x7E34590", VA = "0x187E35790")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E354E0", Offset = "0x7E342E0", VA = "0x187E354E0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void IALCMPANICA([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class AAKKOHOMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7E20F50", Offset = "0x7E1FD50", VA = "0x187E20F50")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7E20DF0", Offset = "0x7E1FBF0", VA = "0x187E20DF0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7E21330", Offset = "0x7E20130", VA = "0x187E21330")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7E21080", Offset = "0x7E1FE80", VA = "0x187E21080")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void HLKBFOJBHAC([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class PDHGBLAACJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7E41AB0", Offset = "0x7E408B0", VA = "0x187E41AB0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E41950", Offset = "0x7E40750", VA = "0x187E41950")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E41E90", Offset = "0x7E40C90", VA = "0x187E41E90")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E41BE0", Offset = "0x7E409E0", VA = "0x187E41BE0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void GNNDDHLPCEO([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class JNFDGMEPIIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E34D30", Offset = "0x7E33B30", VA = "0x187E34D30")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7E34BD0", Offset = "0x7E339D0", VA = "0x187E34BD0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E351A0", Offset = "0x7E33FA0", VA = "0x187E351A0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E34E60", Offset = "0x7E33C60", VA = "0x187E34E60")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void DMGGGPBGDJC([NoAlias] ushort* PDGDGLKOFNO, [Out] float3 PJCLMMNNNOE, [Out] float3 AIJFLELHBIJ, [In][NoAlias] float3* ODOJKNKEJHB, int IMBIKGBCAEE, int JNCGHNJOHFD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class ADJHKEJFEFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E21D30", Offset = "0x7E20B30", VA = "0x187E21D30")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E21BD0", Offset = "0x7E209D0", VA = "0x187E21BD0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E220A0", Offset = "0x7E20EA0", VA = "0x187E220A0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E21E60", Offset = "0x7E20C60", VA = "0x187E21E60")]
		public unsafe static void HDKOJPGLKCE([NoAlias] ushort* PDGDGLKOFNO, [Out] float3 PJCLMMNNNOE, [Out] float3 AIJFLELHBIJ, [In][NoAlias] float3* ODOJKNKEJHB, int IMBIKGBCAEE, int JNCGHNJOHFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void PFGDPLDJFOL([NoAlias] ushort* FBELPLNDKPD, [In][NoAlias] float3* DIGBONDOCOL, int JNCGHNJOHFD);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class BLDEKGCGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E23780", Offset = "0x7E22580", VA = "0x187E23780")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E23620", Offset = "0x7E22420", VA = "0x187E23620")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E23AC0", Offset = "0x7E228C0", VA = "0x187E23AC0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E238B0", Offset = "0x7E226B0", VA = "0x187E238B0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] ushort* FBELPLNDKPD, [In][NoAlias] float3* DIGBONDOCOL, int JNCGHNJOHFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void DJLADLJMDFD([NoAlias] float3* OEFMHACGLNE, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class NONKFBNCKGO
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E39F30", Offset = "0x7E38D30", VA = "0x187E39F30")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E39DD0", Offset = "0x7E38BD0", VA = "0x187E39DD0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A270", Offset = "0x7E39070", VA = "0x187E3A270")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A060", Offset = "0x7E38E60", VA = "0x187E3A060")]
		public unsafe static void HDKOJPGLKCE([NoAlias] float3* OEFMHACGLNE, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void LCDOFAFNALL([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class AJLLMPCLJGF
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E22F60", Offset = "0x7E21D60", VA = "0x187E22F60")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E22E00", Offset = "0x7E21C00", VA = "0x187E22E00")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E232A0", Offset = "0x7E220A0", VA = "0x187E232A0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E23090", Offset = "0x7E21E90", VA = "0x187E23090")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void HDPOEHODJMC([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class FMODNIHAHPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E26460", Offset = "0x7E25260", VA = "0x187E26460")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E26300", Offset = "0x7E25100", VA = "0x187E26300")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E26890", Offset = "0x7E25690", VA = "0x187E26890")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E26590", Offset = "0x7E25390", VA = "0x187E26590")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void DHCEKPNJDPE([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class LAHFMIKOPFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E35FF0", Offset = "0x7E34DF0", VA = "0x187E35FF0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E35E90", Offset = "0x7E34C90", VA = "0x187E35E90")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E36420", Offset = "0x7E35220", VA = "0x187E36420")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E36120", Offset = "0x7E34F20", VA = "0x187E36120")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void GGFGMNAOAPN([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class LAJELNOAHDE
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E36630", Offset = "0x7E35430", VA = "0x187E36630")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E364D0", Offset = "0x7E352D0", VA = "0x187E364D0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E36A90", Offset = "0x7E35890", VA = "0x187E36A90")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E36760", Offset = "0x7E35560", VA = "0x187E36760")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void INJPKBOFGCI([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class AGEIKFNCFLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E228F0", Offset = "0x7E216F0", VA = "0x187E228F0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E22790", Offset = "0x7E21590", VA = "0x187E22790")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7E22D50", Offset = "0x7E21B50", VA = "0x187E22D50")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7E22A20", Offset = "0x7E21820", VA = "0x187E22A20")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void LIGHHBMKKPI([NoAlias] uint* PNEFINNLCPH, [Out] float2 NKBOKBOOCHD, [Out] float2 MGKFNAJLFPM, [In][NoAlias] float2* KIPFFCALHDB, int IMBIKGBCAEE, int JNCGHNJOHFD);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class EKCOPBGEEAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7E25790", Offset = "0x7E24590", VA = "0x187E25790")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E25630", Offset = "0x7E24430", VA = "0x187E25630")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E25B00", Offset = "0x7E24900", VA = "0x187E25B00")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E258C0", Offset = "0x7E246C0", VA = "0x187E258C0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] uint* PNEFINNLCPH, [Out] float2 NKBOKBOOCHD, [Out] float2 MGKFNAJLFPM, [In][NoAlias] float2* KIPFFCALHDB, int IMBIKGBCAEE, int JNCGHNJOHFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void OCIMMLANEBC([Out] float2 DBKMAAFJPHE, uint MEAFLAEHIEL, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class HPBPCPJDLFL
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E31960", Offset = "0x7E30760", VA = "0x187E31960")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E31800", Offset = "0x7E30600", VA = "0x187E31800")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E31CF0", Offset = "0x7E30AF0", VA = "0x187E31CF0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E31A90", Offset = "0x7E30890", VA = "0x187E31A90")]
		public static void HDKOJPGLKCE([Out] float2 DBKMAAFJPHE, uint MEAFLAEHIEL, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void AOEBFJABKEB([NoAlias] float2* PNEFINNLCPH, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class MNIJKJBPAGG
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E37B20", Offset = "0x7E36920", VA = "0x187E37B20")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7E379C0", Offset = "0x7E367C0", VA = "0x187E379C0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E37F40", Offset = "0x7E36D40", VA = "0x187E37F40")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C50", Offset = "0x7E36A50", VA = "0x187E37C50")]
		public unsafe static void HDKOJPGLKCE([NoAlias] float2* PNEFINNLCPH, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void HGCFDEGJPFE([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class GIFCBBNHMNA
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E26AA0", Offset = "0x7E258A0", VA = "0x187E26AA0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7E26940", Offset = "0x7E25740", VA = "0x187E26940")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7E26EF0", Offset = "0x7E25CF0", VA = "0x187E26EF0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7E26BD0", Offset = "0x7E259D0", VA = "0x187E26BD0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void KEALILJNNIG([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class HCIHHCCCFFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7E30D90", Offset = "0x7E2FB90", VA = "0x187E30D90")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7E30C30", Offset = "0x7E2FA30", VA = "0x187E30C30")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7E311E0", Offset = "0x7E2FFE0", VA = "0x187E311E0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7E30EC0", Offset = "0x7E2FCC0", VA = "0x187E30EC0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void LLDIHOKDIDE([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class DEEFCAACGEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7E244D0", Offset = "0x7E232D0", VA = "0x187E244D0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7E24370", Offset = "0x7E23170", VA = "0x187E24370")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7E24830", Offset = "0x7E23630", VA = "0x187E24830")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7E24600", Offset = "0x7E23400", VA = "0x187E24600")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void CNPGFLFMNHC([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class NIEBNIFLMHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7E39390", Offset = "0x7E38190", VA = "0x187E39390")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7E39230", Offset = "0x7E38030", VA = "0x187E39230")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7E397D0", Offset = "0x7E385D0", VA = "0x187E397D0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7E394C0", Offset = "0x7E382C0", VA = "0x187E394C0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void KMIILGHONEO([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class JGCHHCABACE
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7E334B0", Offset = "0x7E322B0", VA = "0x187E334B0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7E33350", Offset = "0x7E32150", VA = "0x187E33350")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7E33900", Offset = "0x7E32700", VA = "0x187E33900")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7E335E0", Offset = "0x7E323E0", VA = "0x187E335E0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void AFEIAONCHNL([NoAlias] ushort* AMPPABIPHAB, [In][NoAlias] float4* IMOEMGLIGPP, int IMBIKGBCAEE, int JNCGHNJOHFD);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class OGMCMLAKHIM
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7E414D0", Offset = "0x7E402D0", VA = "0x187E414D0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7E41370", Offset = "0x7E40170", VA = "0x187E41370")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7E418A0", Offset = "0x7E406A0", VA = "0x187E418A0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7E41600", Offset = "0x7E40400", VA = "0x187E41600")]
		public unsafe static void HDKOJPGLKCE([NoAlias] ushort* AMPPABIPHAB, [In][NoAlias] float4* IMOEMGLIGPP, int IMBIKGBCAEE, int JNCGHNJOHFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort POPKKHHEAIK([In] float4 CGNDNCIDLKO);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class PNFKJLKGJGP
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7E42C80", Offset = "0x7E41A80", VA = "0x187E42C80")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7E42B20", Offset = "0x7E41920", VA = "0x187E42B20")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7E43010", Offset = "0x7E41E10", VA = "0x187E43010")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7E42DB0", Offset = "0x7E41BB0", VA = "0x187E42DB0")]
		public static ushort HDKOJPGLKCE([In] float4 CGNDNCIDLKO)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void GJOJMEPJAGI([NoAlias] float4* AMPPABIPHAB, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class NABNOPBFCMB
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7E38150", Offset = "0x7E36F50", VA = "0x187E38150")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7E37FF0", Offset = "0x7E36DF0", VA = "0x187E37FF0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7E38520", Offset = "0x7E37320", VA = "0x187E38520")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7E38280", Offset = "0x7E37080", VA = "0x187E38280")]
		public unsafe static void HDKOJPGLKCE([NoAlias] float4* AMPPABIPHAB, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void FICMPFAGAIO([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class NLLHMIJOOCH
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7E399E0", Offset = "0x7E387E0", VA = "0x187E399E0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7E39880", Offset = "0x7E38680", VA = "0x187E39880")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7E39D20", Offset = "0x7E38B20", VA = "0x187E39D20")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7E39B10", Offset = "0x7E38910", VA = "0x187E39B10")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void DGKPPMFCLCG([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class PLCOJIGPEKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7E42610", Offset = "0x7E41410", VA = "0x187E42610")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7E424B0", Offset = "0x7E412B0", VA = "0x187E424B0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7E42A70", Offset = "0x7E41870", VA = "0x187E42A70")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7E42740", Offset = "0x7E41540", VA = "0x187E42740")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void JMBPCHKIJIF([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class NBGNMCIMLFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E38730", Offset = "0x7E37530", VA = "0x187E38730")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E385D0", Offset = "0x7E373D0", VA = "0x187E385D0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7E38B90", Offset = "0x7E37990", VA = "0x187E38B90")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7E38860", Offset = "0x7E37660", VA = "0x187E38860")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void CEJAHLLHDMP([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class JIAJGPKMPPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E34080", Offset = "0x7E32E80", VA = "0x187E34080")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7E33F20", Offset = "0x7E32D20", VA = "0x187E33F20")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7E34540", Offset = "0x7E33340", VA = "0x187E34540")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7E341B0", Offset = "0x7E32FB0", VA = "0x187E341B0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void EABENJCLJNB([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class AACOBNCJFHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7E20880", Offset = "0x7E1F680", VA = "0x187E20880")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7E20720", Offset = "0x7E1F520", VA = "0x187E20720")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7E20D40", Offset = "0x7E1FB40", VA = "0x187E20D40")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7E209B0", Offset = "0x7E1F7B0", VA = "0x187E209B0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void HHOHHEPNOJI([Out] float4 BPINCJLADGC, ushort MEAFLAEHIEL);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class JKLMIHLMLDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7E34750", Offset = "0x7E33550", VA = "0x187E34750")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7E345F0", Offset = "0x7E333F0", VA = "0x187E345F0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7E34B20", Offset = "0x7E33920", VA = "0x187E34B20")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7E34880", Offset = "0x7E33680", VA = "0x187E34880")]
		public static void HDKOJPGLKCE([Out] float4 BPINCJLADGC, ushort MEAFLAEHIEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void GKBOMPLENIL([NoAlias] float4* JFMKDOLLJMN, [NoAlias] byte* AGMGKDDNJGO, [Out] int LGLKGDLMFBN, [Out] int HPMOMHBHGDA, [NoAlias] float4* EKAHOHMNGDD, int IMBIKGBCAEE, int JNCGHNJOHFD);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class FFGNPJDBMDM
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7E25EE0", Offset = "0x7E24CE0", VA = "0x187E25EE0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7E25D80", Offset = "0x7E24B80", VA = "0x187E25D80")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7E26250", Offset = "0x7E25050", VA = "0x187E26250")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7E26010", Offset = "0x7E24E10", VA = "0x187E26010")]
		public unsafe static void HDKOJPGLKCE([NoAlias] float4* JFMKDOLLJMN, [NoAlias] byte* AGMGKDDNJGO, [Out] int LGLKGDLMFBN, [Out] int HPMOMHBHGDA, [NoAlias] float4* EKAHOHMNGDD, int IMBIKGBCAEE, int JNCGHNJOHFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void CGKFJGGKFMB([NoAlias] float4* IOOGFMPNDLK, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class EJFMBOFJCPD
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7E25150", Offset = "0x7E23F50", VA = "0x187E25150")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7E24FF0", Offset = "0x7E23DF0", VA = "0x187E24FF0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7E25580", Offset = "0x7E24380", VA = "0x187E25580")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7E25280", Offset = "0x7E24080", VA = "0x187E25280")]
		public unsafe static void HDKOJPGLKCE([NoAlias] float4* IOOGFMPNDLK, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void MCMAOIIGFPH([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class ABCPPBFMBNM
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7E21540", Offset = "0x7E20340", VA = "0x187E21540")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7E213E0", Offset = "0x7E201E0", VA = "0x187E213E0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7E21A20", Offset = "0x7E20820", VA = "0x187E21A20")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7E21670", Offset = "0x7E20470", VA = "0x187E21670")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void HPNGLJJKOCE([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class COEPMDPCOMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7E23DD0", Offset = "0x7E22BD0", VA = "0x187E23DD0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7E23C70", Offset = "0x7E22A70", VA = "0x187E23C70")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7E242C0", Offset = "0x7E230C0", VA = "0x187E242C0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7E23F00", Offset = "0x7E22D00", VA = "0x187E23F00")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void FNCEGGJPFOG([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class JDEAOBENEJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7E32690", Offset = "0x7E31490", VA = "0x187E32690")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7E32530", Offset = "0x7E31330", VA = "0x187E32530")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7E32B70", Offset = "0x7E31970", VA = "0x187E32B70")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7E327C0", Offset = "0x7E315C0", VA = "0x187E327C0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void KKJLDKMBPJP([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class PFBMPKHMBCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7E420A0", Offset = "0x7E40EA0", VA = "0x187E420A0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E41F40", Offset = "0x7E40D40", VA = "0x187E41F40")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E42400", Offset = "0x7E41200", VA = "0x187E42400")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E421D0", Offset = "0x7E40FD0", VA = "0x187E421D0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void LJCLMAFNOLO([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class JHJDGDKEHEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E33B10", Offset = "0x7E32910", VA = "0x187E33B10")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7E339B0", Offset = "0x7E327B0", VA = "0x187E339B0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E33E70", Offset = "0x7E32C70", VA = "0x187E33E70")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E33C40", Offset = "0x7E32A40", VA = "0x187E33C40")]
		public unsafe static void HDKOJPGLKCE([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int KKCCNAAJKBI([NoAlias] byte* MJHMNMINEKH, [In][NoAlias] int* OLFABNIEEKG, int KBFEMCFGCHH);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class IFEJGEEPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E31F00", Offset = "0x7E30D00", VA = "0x187E31F00")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E31DA0", Offset = "0x7E30BA0", VA = "0x187E31DA0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E322D0", Offset = "0x7E310D0", VA = "0x187E322D0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E32030", Offset = "0x7E30E30", VA = "0x187E32030")]
		public unsafe static int HDKOJPGLKCE([NoAlias] byte* MJHMNMINEKH, [In][NoAlias] int* OLFABNIEEKG, int KBFEMCFGCHH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void MNGEOMHDIDO([NoAlias] int* IOONLDDNABC, [In][NoAlias] byte* NDGPIAFHBOM, int MCCEBKGMOBA);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class MHBNHAGOMOF
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E36FD0", Offset = "0x7E35DD0", VA = "0x187E36FD0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E36E70", Offset = "0x7E35C70", VA = "0x187E36E70")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E37360", Offset = "0x7E36160", VA = "0x187E37360")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E37100", Offset = "0x7E35F00", VA = "0x187E37100")]
		public unsafe static void HDKOJPGLKCE([NoAlias] int* IOONLDDNABC, [In][NoAlias] byte* NDGPIAFHBOM, int MCCEBKGMOBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void JFABIFCMEFG([NoAlias] ushort* IOONLDDNABC, [In][NoAlias] byte* NDGPIAFHBOM, int MCCEBKGMOBA);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class JFIPNJPBCME
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E32F00", Offset = "0x7E31D00", VA = "0x187E32F00")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E32DA0", Offset = "0x7E31BA0", VA = "0x187E32DA0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E332A0", Offset = "0x7E320A0", VA = "0x187E332A0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E33030", Offset = "0x7E31E30", VA = "0x187E33030")]
		public unsafe static void HDKOJPGLKCE([NoAlias] ushort* IOONLDDNABC, [In][NoAlias] byte* NDGPIAFHBOM, int MCCEBKGMOBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void DPPFDMDICJI([Out] float3 DBKMAAFJPHE, ushort MEAFLAEHIEL);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class KNDEBEJFBMB
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E35AA0", Offset = "0x7E348A0", VA = "0x187E35AA0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E35940", Offset = "0x7E34740", VA = "0x187E35940")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E35DE0", Offset = "0x7E34BE0", VA = "0x187E35DE0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E35BD0", Offset = "0x7E349D0", VA = "0x187E35BD0")]
		public static void HDKOJPGLKCE([Out] float3 DBKMAAFJPHE, ushort MEAFLAEHIEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort ACGKAELHBAA([In] float3 CGNDNCIDLKO);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class AFDLPDINHLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E222B0", Offset = "0x7E210B0", VA = "0x187E222B0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E22150", Offset = "0x7E20F50", VA = "0x187E22150")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E225E0", Offset = "0x7E213E0", VA = "0x187E225E0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E223E0", Offset = "0x7E211E0", VA = "0x187E223E0")]
		public static ushort HDKOJPGLKCE([In] float3 CGNDNCIDLKO)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker MLLDMPFLJBE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker JADDBDDBEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int GFBHKKJANIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int MCCEBKGMOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> PBHBGPOCIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> FKFBMOPPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> EKNIDIEOBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> IPPCDFJEOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<FNJLOBGOJHM> FDALPPCBFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> HIIDPLHIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> PECKHJOFPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 HLCODOGDGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 AIJFLELHBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 AKMHEDLJBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 MGKFNAJLFPM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long FLDDIDCLIEJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long IAPBNAHLMPF;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float IMKOMDMIKCB;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool PCIHOHAIKPO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DAEKNHIBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E30650", Offset = "0x7E2F450", VA = "0x187E30650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KEMDKMNBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E2F000", Offset = "0x7E2DE00", VA = "0x187E2F000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E670", Offset = "0x7E2D470", VA = "0x187E2E670")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E28080", Offset = "0x7E26E80", VA = "0x187E28080")]
	public static GNJKBDAPAAO BHEMCOAOOEF(Allocator LNMGNHHGHLL, NativeArray<float3> ODOJKNKEJHB, NativeArray<float3> DIGBONDOCOL, NativeArray<float2> KIPFFCALHDB, NativeArray<float4> EKAHOHMNGDD, bool IOCGAOLKFBH, NativeArray<float4> IEFOHCAIJDG, NativeArray<int> OLFABNIEEKG, int GFBHKKJANIO, int MPELKIBGFGJ, int MCCEBKGMOBA, int IMBIKGBCAEE)
	{
		return default(GNJKBDAPAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E2EF60", Offset = "0x7E2DD60", VA = "0x187E2EF60")]
	public NONOJJJJOHD NAOHDOLJNIC(Allocator LNMGNHHGHLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E2EBA0", Offset = "0x7E2D9A0", VA = "0x187E2EBA0")]
	public void NAOHDOLJNIC(NONOJJJJOHD BPINCJLADGC, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B670", Offset = "0x7E2A470", VA = "0x187E2B670")]
	public void HANGLNDNHDI(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E2BB70", Offset = "0x7E2A970", VA = "0x187E2BB70")]
	private void HMAEGMLPAGO(Mesh JIEGCDEFFGO, NativeArray<ushort> CAIEFFKNDIL, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E27990", Offset = "0x7E26790", VA = "0x187E27990")]
	public void ANNAMOLEHKL(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E2FAB0", Offset = "0x7E2E8B0", VA = "0x187E2FAB0")]
	public void OKINKPFCDJE(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D2A0", Offset = "0x7E2C0A0", VA = "0x187E2D2A0")]
	public void KHKBINJMIPB(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AF30", Offset = "0x7E29D30", VA = "0x187E2AF30")]
	public void GNLPKKPOEDO(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E2CC80", Offset = "0x7E2BA80", VA = "0x187E2CC80")]
	public void KACBACIHAHB(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E27390", Offset = "0x7E26190", VA = "0x187E27390")]
	public void AHKMINMCGAA(Mesh JIEGCDEFFGO, NONOJJJJOHD.KCBJFHLHBFC HONGJHADKJH, bool CECFHMMDNFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C5F0", Offset = "0x7E2B3F0", VA = "0x187E2C5F0")]
	public long IMCJCDKNIOE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E28CA0", Offset = "0x7E27AA0", VA = "0x187E28CA0")]
	public long CILHOBIFKHJ(NONOJJJJOHD.KCBJFHLHBFC HONGJHADKJH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E29540", Offset = "0x7E28340", VA = "0x187E29540")]
	private void DFOACHHADOO(int JDEAPLOGHMI, int JNCGHNJOHFD, Allocator LNMGNHHGHLL, bool BHDJMMKCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A040", Offset = "0x7E28E40", VA = "0x187E2A040")]
	private void EGJMCBMMBEC(NativeArray<float3> PDGDGLKOFNO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A160", Offset = "0x7E28F60", VA = "0x187E2A160")]
	[BurstCompile]
	private unsafe static void EGJMCBMMBEC([NoAlias] float3* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A5F0", Offset = "0x7E293F0", VA = "0x187E2A5F0")]
	[BurstCompile]
	private unsafe static void FIDIFKHOOGD([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E790", Offset = "0x7E2D590", VA = "0x187E2E790")]
	[BurstCompile]
	private unsafe static void MHHCMKHJLHB([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E28920", Offset = "0x7E27720", VA = "0x187E28920")]
	[BurstCompile]
	private unsafe static void CBNDDOJGLOM([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F6B0", Offset = "0x7E2E4B0", VA = "0x187E2F6B0")]
	[BurstCompile]
	private unsafe static void NPLHCOMPMEL([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E28F60", Offset = "0x7E27D60", VA = "0x187E28F60")]
	[BurstCompile]
	private unsafe static void CLEJNGCNJAG([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E29420", Offset = "0x7E28220", VA = "0x187E29420")]
	private void DFKKDOMJPCO(NativeArray<float3> ODOJKNKEJHB, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E29390", Offset = "0x7E28190", VA = "0x187E29390")]
	[BurstCompile]
	private unsafe static void DFKKDOMJPCO([NoAlias] ushort* PDGDGLKOFNO, [Out] float3 PJCLMMNNNOE, [Out] float3 AIJFLELHBIJ, [In][NoAlias] float3* ODOJKNKEJHB, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E2BDA0", Offset = "0x7E2ABA0", VA = "0x187E2BDA0")]
	private void HNEOEDMCGIE(NativeArray<float3> DIGBONDOCOL, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E2BE80", Offset = "0x7E2AC80", VA = "0x187E2BE80")]
	[BurstCompile]
	private unsafe static void HNEOEDMCGIE([NoAlias] ushort* FBELPLNDKPD, [In][NoAlias] float3* DIGBONDOCOL, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E2EAE0", Offset = "0x7E2D8E0", VA = "0x187E2EAE0")]
	private void MNECNMLAICP(NativeArray<float3> OEFMHACGLNE, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E890", Offset = "0x7E2D690", VA = "0x187E2E890")]
	[BurstCompile]
	private unsafe static void MNECNMLAICP([NoAlias] float3* OEFMHACGLNE, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E28D10", Offset = "0x7E27B10", VA = "0x187E28D10")]
	[BurstCompile]
	private unsafe static void CJOMOILHENK([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E310", Offset = "0x7E2D110", VA = "0x187E2E310")]
	[BurstCompile]
	private unsafe static void LJBCIAJNNAF([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E30AD0", Offset = "0x7E2F8D0", VA = "0x187E30AD0")]
	[BurstCompile]
	private unsafe static void PKNHHIEHBCO([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E29670", Offset = "0x7E28470", VA = "0x187E29670")]
	[BurstCompile]
	private unsafe static void DIFNGGNFFGN([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A670", Offset = "0x7E29470", VA = "0x187E2A670")]
	[BurstCompile]
	private unsafe static void FIGNLOBLOIF([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E304B0", Offset = "0x7E2F2B0", VA = "0x187E304B0")]
	private void PCOJJGIMNEG(NativeArray<float2> KIPFFCALHDB, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E30420", Offset = "0x7E2F220", VA = "0x187E30420")]
	[BurstCompile]
	private unsafe static void PCOJJGIMNEG([NoAlias] uint* PNEFINNLCPH, [Out] float2 NKBOKBOOCHD, [Out] float2 MGKFNAJLFPM, [In][NoAlias] float2* KIPFFCALHDB, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E27310", Offset = "0x7E26110", VA = "0x187E27310")]
	[BurstCompile]
	private static void ACMHPKCJMBG([Out] float2 DBKMAAFJPHE, uint MEAFLAEHIEL, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E29BA0", Offset = "0x7E289A0", VA = "0x187E29BA0")]
	private void EDDKAANLFAF(NativeArray<float2> PNEFINNLCPH, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E29CC0", Offset = "0x7E28AC0", VA = "0x187E29CC0")]
	[BurstCompile]
	private unsafe static void EDDKAANLFAF([NoAlias] float2* PNEFINNLCPH, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A4F0", Offset = "0x7E292F0", VA = "0x187E2A4F0")]
	[BurstCompile]
	private unsafe static void FBAKDAPAMDC([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E810", Offset = "0x7E2D610", VA = "0x187E2E810")]
	[BurstCompile]
	private unsafe static void MMNPJIGFACL([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E30170", Offset = "0x7E2EF70", VA = "0x187E30170")]
	[BurstCompile]
	private unsafe static void PAOFPJONPLD([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DD00", Offset = "0x7E2CB00", VA = "0x187E2DD00")]
	[BurstCompile]
	private unsafe static void LDIIAEBNEMJ([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E305D0", Offset = "0x7E2F3D0", VA = "0x187E305D0")]
	[BurstCompile]
	private unsafe static void PHADDEKECLB([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E29EB0", Offset = "0x7E28CB0", VA = "0x187E29EB0")]
	private void EGFOMCGDEDP(NativeArray<float4> IEFOHCAIJDG, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E29FC0", Offset = "0x7E28DC0", VA = "0x187E29FC0")]
	[BurstCompile]
	private unsafe static void EGFOMCGDEDP([NoAlias] ushort* AMPPABIPHAB, [In][NoAlias] float4* IMOEMGLIGPP, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A850", Offset = "0x7E29650", VA = "0x187E2A850")]
	[BurstCompile]
	private static ushort GEKJHCKNIMK([In] float4 CGNDNCIDLKO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AE40", Offset = "0x7E29C40", VA = "0x187E2AE40")]
	private void GKMMJIHFMML(NativeArray<float4> AMPPABIPHAB, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E2ADD0", Offset = "0x7E29BD0", VA = "0x187E2ADD0")]
	[BurstCompile]
	private unsafe static void GKMMJIHFMML([NoAlias] float4* AMPPABIPHAB, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A2A0", Offset = "0x7E290A0", VA = "0x187E2A2A0")]
	[BurstCompile]
	private unsafe static void ELHBGNGLMPI([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E27F70", Offset = "0x7E26D70", VA = "0x187E27F70")]
	[BurstCompile]
	private unsafe static void BGEJGCHHGCB([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E28FE0", Offset = "0x7E27DE0", VA = "0x187E28FE0")]
	[BurstCompile]
	private unsafe static void CLJLKJBGHDN([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F220", Offset = "0x7E2E020", VA = "0x187E2F220")]
	[BurstCompile]
	private unsafe static void NHJHHGJIPFK([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E30100", Offset = "0x7E2EF00", VA = "0x187E30100")]
	[BurstCompile]
	private unsafe static void OKNEMNMCFDC([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C590", Offset = "0x7E2B390", VA = "0x187E2C590")]
	[BurstCompile]
	private static void IGDEHDBMDHG([Out] float4 BPINCJLADGC, ushort MEAFLAEHIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DED0", Offset = "0x7E2CCD0", VA = "0x187E2DED0")]
	private void LIIICMLHPOA(Allocator LNMGNHHGHLL, NativeArray<float4> EKAHOHMNGDD, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DE40", Offset = "0x7E2CC40", VA = "0x187E2DE40")]
	[BurstCompile]
	private unsafe static void LIIICMLHPOA([NoAlias] float4* JFMKDOLLJMN, [NoAlias] byte* AGMGKDDNJGO, [Out] int LGLKGDLMFBN, [Out] int HPMOMHBHGDA, [NoAlias] float4* EKAHOHMNGDD, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E27860", Offset = "0x7E26660", VA = "0x187E27860")]
	private static void ANEIIJCBLGK(NativeArray<float4> IOOGFMPNDLK, NativeArray<FNJLOBGOJHM> FKOKJEMCHKJ, NativeArray<byte> GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E277E0", Offset = "0x7E265E0", VA = "0x187E277E0")]
	[BurstCompile]
	private unsafe static void ANEIIJCBLGK([NoAlias] float4* IOOGFMPNDLK, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A570", Offset = "0x7E29370", VA = "0x187E2A570")]
	[BurstCompile]
	private unsafe static void FBCNCDBNMEP([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E2CC00", Offset = "0x7E2BA00", VA = "0x187E2CC00")]
	[BurstCompile]
	private unsafe static void JOKMDJLNKJF([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B5F0", Offset = "0x7E2A3F0", VA = "0x187E2B5F0")]
	[BurstCompile]
	private unsafe static void HAFKOPGIPHP([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E30690", Offset = "0x7E2F490", VA = "0x187E30690")]
	[BurstCompile]
	private unsafe static void PIEEAKJBDHO([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E270A0", Offset = "0x7E25EA0", VA = "0x187E270A0")]
	[BurstCompile]
	private unsafe static void ABHHIECBHBA([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C8B0", Offset = "0x7E2B6B0", VA = "0x187E2C8B0")]
	private void JKLHCIMBDDL(Allocator LNMGNHHGHLL, NativeArray<int> OLFABNIEEKG, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A910", Offset = "0x7E29710", VA = "0x187E2A910")]
	private static NativeArray<byte> GFLLLCEBNAE(Allocator LNMGNHHGHLL, NativeArray<int> OLFABNIEEKG, int KBFEMCFGCHH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A8A0", Offset = "0x7E296A0", VA = "0x187E2A8A0")]
	[BurstCompile]
	private unsafe static int GFLLLCEBNAE([NoAlias] byte* MJHMNMINEKH, [In][NoAlias] int* OLFABNIEEKG, int KBFEMCFGCHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B800", Offset = "0x7E2A600", VA = "0x187E2B800")]
	private static void HCDODENCLBH(NativeArray<int> IOONLDDNABC, NativeArray<byte> NDGPIAFHBOM, int MCCEBKGMOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B790", Offset = "0x7E2A590", VA = "0x187E2B790")]
	[BurstCompile]
	private unsafe static void HCDODENCLBH([NoAlias] int* IOONLDDNABC, [In][NoAlias] byte* NDGPIAFHBOM, int MCCEBKGMOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F640", Offset = "0x7E2E440", VA = "0x187E2F640")]
	[BurstCompile]
	private unsafe static void NNMIJICCGFK([NoAlias] ushort* IOONLDDNABC, [In][NoAlias] byte* NDGPIAFHBOM, int MCCEBKGMOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DAC0", Offset = "0x7E2C8C0", VA = "0x187E2DAC0")]
	[BurstCompile]
	private static void KMONNLNNCIK([Out] float3 DBKMAAFJPHE, ushort MEAFLAEHIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E301F0", Offset = "0x7E2EFF0", VA = "0x187E301F0")]
	[BurstCompile]
	private static ushort PBBIPALLNAJ([In] float3 CGNDNCIDLKO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FAD0", Offset = "0x7E1E8D0", VA = "0x187E1FAD0")]
	[BurstCompile]
	public unsafe static void PEJKLPFIBDM([NoAlias] float3* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E296E0", Offset = "0x7E284E0", VA = "0x187E296E0")]
	[BurstCompile]
	public unsafe static void DKGFOCEDPML([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E28860", Offset = "0x7E27660", VA = "0x187E28860")]
	[BurstCompile]
	public unsafe static void BKNIDAFHKAG([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A1E0", Offset = "0x7E28FE0", VA = "0x187E2A1E0")]
	[BurstCompile]
	public unsafe static void PIGCBIPDGDI([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A1E0", Offset = "0x7E28FE0", VA = "0x187E2A1E0")]
	[BurstCompile]
	public unsafe static void ELAKJIFMKMN([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E29A40", Offset = "0x7E28840", VA = "0x187E29A40")]
	[BurstCompile]
	public unsafe static void DPHBPOLMGFK([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* ODOJKNKEJHB, int GFBHKKJANIO, [In] float3 HLCODOGDGFL, [In] float3 AIJFLELHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EB10", Offset = "0x7E1D910", VA = "0x187E1EB10")]
	[BurstCompile]
	public unsafe static void EDFJFOLJEBL([NoAlias] ushort* PDGDGLKOFNO, [Out] float3 PJCLMMNNNOE, [Out] float3 AIJFLELHBIJ, [In][NoAlias] float3* ODOJKNKEJHB, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E285B0", Offset = "0x7E273B0", VA = "0x187E285B0")]
	[BurstCompile]
	public unsafe static void BKLKGMGJCOO([NoAlias] ushort* FBELPLNDKPD, [In][NoAlias] float3* DIGBONDOCOL, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C0D0", Offset = "0x7E2AED0", VA = "0x187E2C0D0")]
	[BurstCompile]
	public unsafe static void HPPOCICKLBN([NoAlias] float3* OEFMHACGLNE, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C9B0", Offset = "0x7E2B7B0", VA = "0x187E2C9B0")]
	[BurstCompile]
	public unsafe static void JMBHLKAFIMB([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B8F0", Offset = "0x7E2A6F0", VA = "0x187E2B8F0")]
	[BurstCompile]
	public unsafe static void HELPDMJDEFJ([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F500", Offset = "0x7E2E300", VA = "0x187E2F500")]
	[BurstCompile]
	public unsafe static void NKOEAHFGFOB([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A6E0", Offset = "0x7E294E0", VA = "0x187E2A6E0")]
	[BurstCompile]
	public unsafe static void FILDFHPHJKE([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E29D40", Offset = "0x7E28B40", VA = "0x187E29D40")]
	[BurstCompile]
	public unsafe static void EFCPMNCJPJB([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* DIGBONDOCOL, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FD30", Offset = "0x7E1EB30", VA = "0x187E1FD30")]
	[BurstCompile]
	public unsafe static void PFPGECLFHBM([NoAlias] uint* PNEFINNLCPH, [Out] float2 NKBOKBOOCHD, [Out] float2 MGKFNAJLFPM, [In][NoAlias] float2* KIPFFCALHDB, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C550", Offset = "0x7E2B350", VA = "0x187E2C550")]
	[BurstCompile]
	public static void IGBLIKFLBGI([Out] float2 DBKMAAFJPHE, uint MEAFLAEHIEL, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E276D0", Offset = "0x7E264D0", VA = "0x187E276D0")]
	[BurstCompile]
	public unsafe static void AIOKEFNCKGA([NoAlias] float2* PNEFINNLCPH, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F3C0", Offset = "0x7E2E1C0", VA = "0x187E2F3C0")]
	[BurstCompile]
	public unsafe static void NJPCKCDCHLJ([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F970", Offset = "0x7E2E770", VA = "0x187E2F970")]
	[BurstCompile]
	public unsafe static void OJAGIKNCMHO([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E28A80", Offset = "0x7E27880", VA = "0x187E28A80")]
	[BurstCompile]
	public unsafe static void CHMMJAMEMMJ([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7E29910", Offset = "0x7E28710", VA = "0x187E29910")]
	[BurstCompile]
	public unsafe static void DOPIDKAJPEI([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F290", Offset = "0x7E2E090", VA = "0x187E2F290")]
	[BurstCompile]
	public unsafe static void NJLMPNLNDCC([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [NoAlias] uint* KIPFFCALHDB, int GFBHKKJANIO, [In] float2 AKMHEDLJBMA, [In] float2 MGKFNAJLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E284D0", Offset = "0x7E272D0", VA = "0x187E284D0")]
	[BurstCompile]
	public unsafe static void BHLOINKFNOD([NoAlias] ushort* AMPPABIPHAB, [In][NoAlias] float4* IMOEMGLIGPP, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C6B0", Offset = "0x7E2B4B0", VA = "0x187E2C6B0")]
	[BurstCompile]
	public static ushort JDDHPMIJDHP([In] float4 CGNDNCIDLKO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7E289A0", Offset = "0x7E277A0", VA = "0x187E289A0")]
	[BurstCompile]
	public unsafe static void CGKGEAIDMHI([NoAlias] float4* AMPPABIPHAB, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E380", Offset = "0x7E2D180", VA = "0x187E2E380")]
	[BurstCompile]
	public unsafe static void LLMGPCLAGBF([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7E297A0", Offset = "0x7E285A0", VA = "0x187E297A0")]
	[BurstCompile]
	public unsafe static void DKLNCNODDDN([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C740", Offset = "0x7E2B540", VA = "0x187E2C740")]
	[BurstCompile]
	public unsafe static void JJPFINHFBLF([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D8F0", Offset = "0x7E2C6F0", VA = "0x187E2D8F0")]
	[BurstCompile]
	public unsafe static void KILGKNEPHME([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7E30900", Offset = "0x7E2F700", VA = "0x187E30900")]
	[BurstCompile]
	public unsafe static void PJGAANKCJCN([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] ushort* IEFOHCAIJDG, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DD80", Offset = "0x7E2CB80", VA = "0x187E2DD80")]
	[BurstCompile]
	public static void LFKCOCJELDD([Out] float4 BPINCJLADGC, ushort MEAFLAEHIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EEF0", Offset = "0x7E1DCF0", VA = "0x187E1EEF0")]
	[BurstCompile]
	public unsafe static void HDGADMDKJOA([NoAlias] float4* JFMKDOLLJMN, [NoAlias] byte* AGMGKDDNJGO, [Out] int LGLKGDLMFBN, [Out] int HPMOMHBHGDA, [NoAlias] float4* EKAHOHMNGDD, int IMBIKGBCAEE, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E2BA30", Offset = "0x7E2A830", VA = "0x187E2BA30")]
	[BurstCompile]
	public unsafe static void HKHHLOBACMC([NoAlias] float4* IOOGFMPNDLK, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E2ABF0", Offset = "0x7E299F0", VA = "0x187E2ABF0")]
	[BurstCompile]
	public unsafe static void GKLBLEHNHLC([NoAlias] NONOJJJJOHD.EGCGCNFEOPN* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F040", Offset = "0x7E2DE40", VA = "0x187E2F040")]
	[BurstCompile]
	public unsafe static void NGMDNAJJHEA([NoAlias] NONOJJJJOHD.EOHCKLHJNBF* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C370", Offset = "0x7E2B170", VA = "0x187E2C370")]
	[BurstCompile]
	public unsafe static void ICPDEOBLGFN([NoAlias] NONOJJJJOHD.BDBEAMBIIJB* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E29050", Offset = "0x7E27E50", VA = "0x187E29050")]
	[BurstCompile]
	public unsafe static void CNOBMEPAGPC([NoAlias] NONOJJJJOHD.JDPBBHAIPDI* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F730", Offset = "0x7E2E530", VA = "0x187E2F730")]
	[BurstCompile]
	public unsafe static void OAGIJOLIJHJ([NoAlias] NONOJJJJOHD.DHBLCPJOLBD* PDGDGLKOFNO, [In][NoAlias] FNJLOBGOJHM* FKOKJEMCHKJ, [In][NoAlias] byte* GHOKMPLJJLO, int GFBHKKJANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E29290", Offset = "0x7E28090", VA = "0x187E29290")]
	[BurstCompile]
	public unsafe static int DEJEKBPJEIP([NoAlias] byte* MJHMNMINEKH, [In][NoAlias] int* OLFABNIEEKG, int KBFEMCFGCHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B550", Offset = "0x7E2A350", VA = "0x187E2B550")]
	[BurstCompile]
	public unsafe static void GPIMCFMELNN([NoAlias] int* IOONLDDNABC, [In][NoAlias] byte* NDGPIAFHBOM, int MCCEBKGMOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E27FE0", Offset = "0x7E26DE0", VA = "0x187E27FE0")]
	[BurstCompile]
	public unsafe static void BHDDIPDGCEC([NoAlias] ushort* IOONLDDNABC, [In][NoAlias] byte* NDGPIAFHBOM, int MCCEBKGMOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E510", Offset = "0x7E1D310", VA = "0x187E1E510")]
	[BurstCompile]
	public static void BMPDFBDCJMM([Out] float3 DBKMAAFJPHE, ushort MEAFLAEHIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E0A0", Offset = "0x7E1CEA0", VA = "0x187E1E0A0")]
	[BurstCompile]
	public static ushort AIIMCLEOEKD([In] float3 CGNDNCIDLKO)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class NONOJJJJOHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum KCBJFHLHBFC
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
	public enum OEMNHGMCKKI
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
	public struct DEAKCECJNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public KCBJFHLHBFC HONGJHADKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool FHPHICDKDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int DELFBKBKOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] NOONDBKOKDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct EBAFKKEFBLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 NPJPCFKLMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 KODPDAPHGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 PLJNDIABGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 MOEAEMGNIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 FDALPPCBFML;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] NOONDBKOKDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct EGCGCNFEOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 NPJPCFKLMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 KODPDAPHGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 PLJNDIABGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 MOEAEMGNIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 FDALPPCBFML;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] NOONDBKOKDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct EOHCKLHJNBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 NPJPCFKLMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint KODPDAPHGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint PLJNDIABGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 MOEAEMGNIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 FDALPPCBFML;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] NOONDBKOKDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct BDBEAMBIIJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 NPJPCFKLMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint KODPDAPHGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint PLJNDIABGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 MOEAEMGNIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 FDALPPCBFML;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] NOONDBKOKDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct JDPBBHAIPDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 NPJPCFKLMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint EJAOOJHKALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 MOEAEMGNIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint MDPHBONMPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint FKPAPPADGNF;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] NOONDBKOKDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct DHBLCPJOLBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CMEPLEIJGAP.CJADLPOLEHE PMBHPMBJDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint EJAOOJHKALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 MOEAEMGNIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint MDPHBONMPAL;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] NOONDBKOKDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int ABMCABOMGOP(float AJEEBBBAOKG);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class MJLELIIBJKL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7E37570", Offset = "0x7E36370", VA = "0x187E37570")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7E37410", Offset = "0x7E36210", VA = "0x187E37410")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7E37910", Offset = "0x7E36710", VA = "0x187E37910")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7E376A0", Offset = "0x7E364A0", VA = "0x187E376A0")]
		public static int HDKOJPGLKCE(float AJEEBBBAOKG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint OLDHNPDHLJE([In] float4 LCFJFNFOMKB);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class FAEKFAPADCE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EC00", Offset = "0x7E4DA00", VA = "0x187E4EC00")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EAA0", Offset = "0x7E4D8A0", VA = "0x187E4EAA0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EFB0", Offset = "0x7E4DDB0", VA = "0x187E4EFB0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4ED30", Offset = "0x7E4DB30", VA = "0x187E4ED30")]
		public static uint HDKOJPGLKCE([In] float4 LCFJFNFOMKB)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint ACNCAMPDJAC([In] float3 LCFJFNFOMKB);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class MFEAPJPIEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7E530E0", Offset = "0x7E51EE0", VA = "0x187E530E0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7E52F80", Offset = "0x7E51D80", VA = "0x187E52F80")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7E53460", Offset = "0x7E52260", VA = "0x187E53460")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7E53210", Offset = "0x7E52010", VA = "0x187E53210")]
		public static uint HDKOJPGLKCE([In] float3 LCFJFNFOMKB)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void EOBGCMDLCAK([NoAlias] EOHCKLHJNBF* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class NFAFCEECFBD
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7E58840", Offset = "0x7E57640", VA = "0x187E58840")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7E586E0", Offset = "0x7E574E0", VA = "0x187E586E0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7E58BB0", Offset = "0x7E579B0", VA = "0x187E58BB0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7E58970", Offset = "0x7E57770", VA = "0x187E58970")]
		public unsafe static void HDKOJPGLKCE([NoAlias] EOHCKLHJNBF* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void NGAKDGLHLID([NoAlias] BDBEAMBIIJB* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class NECLMLOOPMA
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7E582C0", Offset = "0x7E570C0", VA = "0x187E582C0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7E58160", Offset = "0x7E56F60", VA = "0x187E58160")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7E58630", Offset = "0x7E57430", VA = "0x187E58630")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7E583F0", Offset = "0x7E571F0", VA = "0x187E583F0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] BDBEAMBIIJB* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void NNGGPFCIJFF([NoAlias] JDPBBHAIPDI* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class DEJHKADCFNE
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D7C0", Offset = "0x7E4C5C0", VA = "0x187E4D7C0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D660", Offset = "0x7E4C460", VA = "0x187E4D660")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4DCE0", Offset = "0x7E4CAE0", VA = "0x187E4DCE0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D8F0", Offset = "0x7E4C6F0", VA = "0x187E4D8F0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] JDPBBHAIPDI* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void GNKBFLDIEKK([NoAlias] DHBLCPJOLBD* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML, [Out] float3 IIPCLFOLIMB, [Out] float3 GDNNBDMMNFL);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class FHKOCEGFHDN
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F290", Offset = "0x7E4E090", VA = "0x187E4F290")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F130", Offset = "0x7E4DF30", VA = "0x187E4F130")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F920", Offset = "0x7E4E720", VA = "0x187E4F920")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F3C0", Offset = "0x7E4E1C0", VA = "0x187E4F3C0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] DHBLCPJOLBD* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML, [Out] float3 IIPCLFOLIMB, [Out] float3 GDNNBDMMNFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int FPLACMJEDOB = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> GFKNFMMCGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> PJBBHJCMOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> BEIEKBIGJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> KMGGHGJHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> PJNIHDBBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> EOGOOIEPPGK;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] BLNOOMPFKIE;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool MJFDNHGMJAH;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static DEAKCECJNNB[] IIMIANBPJHN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DAEKNHIBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E402A0", Offset = "0x7E3F0A0", VA = "0x187E402A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GEMKIIKMKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A360", Offset = "0x7E39160", VA = "0x187E3A360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LHHALMFLOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A320", Offset = "0x7E39120", VA = "0x187E3A320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KEMDKMNBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F120", Offset = "0x7E3DF20", VA = "0x187E3F120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D660", Offset = "0x7E3C460", VA = "0x187E3D660")]
	public static OEMNHGMCKKI IJDMIEHLNGG(KCBJFHLHBFC HONGJHADKJH)
	{
		return default(OEMNHGMCKKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D5A0", Offset = "0x7E3C3A0", VA = "0x187E3D5A0")]
	public static void IHOBPNLDGPH(OEMNHGMCKKI PONBCODBBDC, Material EFCBJICGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E3BD70", Offset = "0x7E3AB70", VA = "0x187E3BD70", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E3BB80", Offset = "0x7E3A980", VA = "0x187E3BB80")]
	public void DFOACHHADOO(int JDEAPLOGHMI, int JNCGHNJOHFD, Allocator LNMGNHHGHLL, bool BHLODPJPGKE, bool BHDJMMKCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F160", Offset = "0x7E3DF60", VA = "0x187E3F160")]
	public void NMIHBMALNOL(int JDEAPLOGHMI, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3EF90", Offset = "0x7E3DD90", VA = "0x187E3EF90", Slot = "6")]
	public bool MDLNAFOAKEN(Mesh JIEGCDEFFGO, bool OGOFDNLPOHN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E3CA20", Offset = "0x7E3B820", VA = "0x187E3CA20")]
	public bool HANGLNDNHDI(Mesh JIEGCDEFFGO, bool OGOFDNLPOHN, bool CECFHMMDNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D0A0", Offset = "0x7E3BEA0", VA = "0x187E3D0A0")]
	public bool IELDKMMDBAF(Mesh JIEGCDEFFGO, NONOJJJJOHD LDGPAOJKGNK, bool OGOFDNLPOHN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E402E0", Offset = "0x7E3F0E0", VA = "0x187E402E0")]
	public bool PLFPLBANGKL(Mesh JIEGCDEFFGO, NONOJJJJOHD LDGPAOJKGNK, KCBJFHLHBFC HONGJHADKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E403B0", Offset = "0x7E3F1B0", VA = "0x187E403B0")]
	private void PNMJOIBEJBI(Mesh JIEGCDEFFGO, NONOJJJJOHD LDGPAOJKGNK, bool CECFHMMDNFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E40B40", Offset = "0x7E3F940", VA = "0x187E40B40")]
	public void PNMJOIBEJBI(NativeArray<ushort> ICJPNCDIBBL, NativeArray<JDPBBHAIPDI> CKCOPBEKLGA, Mesh JIEGCDEFFGO, NONOJJJJOHD LDGPAOJKGNK, bool CECFHMMDNFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A430", Offset = "0x7E39230", VA = "0x187E3A430")]
	public void ANNAMOLEHKL(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F000", Offset = "0x7E3DE00", VA = "0x187E3F000")]
	[BurstCompile]
	public static int MEPPLNACFBD(float AJEEBBBAOKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E3EFB0", Offset = "0x7E3DDB0", VA = "0x187E3EFB0")]
	[BurstCompile]
	public static uint MEPPLNACFBD([In] float4 LCFJFNFOMKB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F050", Offset = "0x7E3DE50", VA = "0x187E3F050")]
	[BurstCompile]
	public static uint MEPPLNACFBD([In] float3 LCFJFNFOMKB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FC10", Offset = "0x7E3EA10", VA = "0x187E3FC10")]
	public void OKINKPFCDJE(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E730", Offset = "0x7E3D530", VA = "0x187E3E730")]
	[BurstCompile]
	private unsafe static void KMODGIAIBIF([NoAlias] EOHCKLHJNBF* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E0A0", Offset = "0x7E3CEA0", VA = "0x187E3E0A0")]
	public void KHKBINJMIPB(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E3CE20", Offset = "0x7E3BC20", VA = "0x187E3CE20")]
	[BurstCompile]
	private unsafe static void HKLIHEJAEBN([NoAlias] BDBEAMBIIJB* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C2A0", Offset = "0x7E3B0A0", VA = "0x187E3C2A0")]
	public void GNLPKKPOEDO(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C670", Offset = "0x7E3B470", VA = "0x187E3C670")]
	public void GNLPKKPOEDO(NativeArray<ushort> CAIEFFKNDIL, NativeArray<JDPBBHAIPDI> NPKGPEMIEKO, Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3BE80", Offset = "0x7E3AC80", VA = "0x187E3BE80")]
	[BurstCompile]
	public unsafe static void FBNPDHBCLAO([NoAlias] JDPBBHAIPDI* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D860", Offset = "0x7E3C660", VA = "0x187E3D860")]
	public void KACBACIHAHB(Mesh JIEGCDEFFGO, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F0A0", Offset = "0x7E3DEA0", VA = "0x187E3F0A0")]
	[BurstCompile]
	private unsafe static void MHBJLAONGNE([NoAlias] DHBLCPJOLBD* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML, [Out] float3 IIPCLFOLIMB, [Out] float3 GDNNBDMMNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A3A0", Offset = "0x7E391A0", VA = "0x187E3A3A0")]
	public void AHKMINMCGAA(Mesh JIEGCDEFFGO, KCBJFHLHBFC HONGJHADKJH, bool CECFHMMDNFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E3BF00", Offset = "0x7E3AD00", VA = "0x187E3BF00")]
	public void FHLMBJOLLCJ(NONOJJJJOHD JIEGCDEFFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DFA0", Offset = "0x7E3CDA0", VA = "0x187E3DFA0")]
	public void KBLMHOOEFKP(NONOJJJJOHD EEDJPELJDDE, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D6B0", Offset = "0x7E3C4B0", VA = "0x187E3D6B0")]
	public long IMCJCDKNIOE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D800", Offset = "0x7E3C600", VA = "0x187E3D800")]
	public static long IMCJCDKNIOE(int ELNAKECNAKO, int KHNHDJAMDAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7E3BAE0", Offset = "0x7E3A8E0", VA = "0x187E3BAE0")]
	public static long CILHOBIFKHJ(int ELNAKECNAKO, int KHNHDJAMDAL, KCBJFHLHBFC HONGJHADKJH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7E3BA20", Offset = "0x7E3A820", VA = "0x187E3BA20")]
	public long CILHOBIFKHJ(KCBJFHLHBFC HONGJHADKJH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C170", Offset = "0x7E3AF70", VA = "0x187E3C170")]
	public void FIMHLMDCGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B460", Offset = "0x7E3A260", VA = "0x187E3B460")]
	public static void BNIJAPJDGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F4C0", Offset = "0x7E3E2C0", VA = "0x187E3F4C0")]
	public KCBJFHLHBFC OBODFPPNJJP()
	{
		return default(KCBJFHLHBFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7E3C1D0", Offset = "0x7E3AFD0", VA = "0x187E3C1D0")]
	public static (int, int) GLBOKMJLBMK(Mesh JIEGCDEFFGO)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7E3EB70", Offset = "0x7E3D970", VA = "0x187E3EB70")]
	public static int LMLMFHLDOAP(VertexAttributeDescriptor[] JKDHLMGGGBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B3F0", Offset = "0x7E3A1F0", VA = "0x187E3B3F0")]
	public static long BLPEDJCCOIL(Mesh JIEGCDEFFGO, int AIKJLMMLMFP, int CAGKDDBLLEI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B2C0", Offset = "0x7E3A0C0", VA = "0x187E3B2C0")]
	public static long BLPEDJCCOIL(Mesh JIEGCDEFFGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public NONOJJJJOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F1E0", Offset = "0x7E3DFE0", VA = "0x187E3F1E0")]
	[BurstCompile]
	public static int NNHNKFHLAOH(float AJEEBBBAOKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F280", Offset = "0x7E3E080", VA = "0x187E3F280")]
	[BurstCompile]
	public static uint NNHNKFHLAOH([In] float4 LCFJFNFOMKB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F410", Offset = "0x7E3E210", VA = "0x187E3F410")]
	[BurstCompile]
	public static uint NNHNKFHLAOH([In] float3 LCFJFNFOMKB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E7B0", Offset = "0x7E3D5B0", VA = "0x187E3E7B0")]
	[BurstCompile]
	public unsafe static void LDIEFJGDJLE([NoAlias] EOHCKLHJNBF* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7E3AE70", Offset = "0x7E39C70", VA = "0x187E3AE70")]
	[BurstCompile]
	public unsafe static void APNHIBFNKGA([NoAlias] BDBEAMBIIJB* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7E3CEA0", Offset = "0x7E3BCA0", VA = "0x187E3CEA0")]
	[BurstCompile]
	public unsafe static void IBIGOHCOIND([NoAlias] JDPBBHAIPDI* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7E3EC50", Offset = "0x7E3DA50", VA = "0x187E3EC50")]
	[BurstCompile]
	public unsafe static void LOAGJBCBBOM([NoAlias] DHBLCPJOLBD* PDGDGLKOFNO, int GFBHKKJANIO, [In][NoAlias] float3* LKDOKAHHNCE, [In][NoAlias] float3* FKFBMOPPFGF, [In][NoAlias] float4* EKNIDIEOBKA, [In][NoAlias] float2* IPPCDFJEOAF, [In][NoAlias] float4* FDALPPCBFML, [Out] float3 IIPCLFOLIMB, [Out] float3 GDNNBDMMNFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct PEDGPBLEJDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int CMHNFHENJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 MLDDKPAIKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion PNPJAMDECAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 MPOHGHLPKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int HCJHJANFJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int KEMFIGNEAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int LIKPJKOAIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float DCFNGINFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 BBGPGAAGFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool HHAJHLEFOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public MICJMPBPOBO FDHIIANJMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 FEFBMJDKEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float HKCNEMNDFEP;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class AOEBHBIJBCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static DKMDJENKPNF JIBECHDJODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<PEDGPBLEJDC> EPCMBECMDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<CNJAJGPNEJB> AIJDIKBHIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<APEEIJKLEPN> CLBNDJBOOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<CCHLCODHAON> DCPNMDGGOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<CNJAJGPNEJB> AKKEMIIALPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<DJFBJHIFBHK> DHEOLBLJFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<CCHLCODHAON>> PMDEMNGDIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<HPHGBMKCHHO> OEOOEBHAIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> LNHEDNDOKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> KHDHLLIMDCD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<CLHOIMBKGBI.EBEFJAKPHKO> HAPFGICEJNB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GEMKIIKMKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA08240", Offset = "0xA07040", VA = "0x180A08240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA08290", Offset = "0xA07090", VA = "0x180A08290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LHHALMFLOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xC39420", Offset = "0xC38220", VA = "0x180C39420")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xC39430", Offset = "0xC38230", VA = "0x180C39430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7E459E0", Offset = "0x7E447E0", VA = "0x187E459E0")]
	public AOEBHBIJBCB(int CJHNINLLDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7E43BB0", Offset = "0x7E429B0", VA = "0x187E43BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7E457F0", Offset = "0x7E445F0", VA = "0x187E457F0")]
	public void LNJEMOCDJGL(JobHandle JAAMMEMKHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7E43990", Offset = "0x7E42790", VA = "0x187E43990")]
	public void APBBHGOLELJ(PEDGPBLEJDC FFEMKICJPKP, HPHGBMKCHHO BHIMEHGMCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7E45690", Offset = "0x7E44490", VA = "0x187E45690")]
	public void LHNJBODKCCO(APEEIJKLEPN FFEMKICJPKP, NativeArray<CCHLCODHAON> BCOCCKNHKNN, int GFBHKKJANIO, int MCCEBKGMOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7E43D90", Offset = "0x7E42B90", VA = "0x187E43D90")]
	public JobHandle EPBFOLAIKMK(NONOJJJJOHD LCFOGFNHIAO, HNPDPDLCLDJ HGPPEIKEKFO, float3 MAHNACEJAGP, quaternion FBHGHPOJALK, float IMLCJJMNGPF, bool PFPJMBAHIBG, int OMCOLCOGEGE = 0, int HECIBPFHNAM = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7E43EB0", Offset = "0x7E42CB0", VA = "0x187E43EB0")]
	public JobHandle EPBFOLAIKMK(NONOJJJJOHD LCFOGFNHIAO, HNPDPDLCLDJ HGPPEIKEKFO, NativeList<CLHOIMBKGBI.EBEFJAKPHKO> MGGEEBMDBKI, float3 MAHNACEJAGP, quaternion FBHGHPOJALK, float IMLCJJMNGPF, bool PFPJMBAHIBG, bool HNIBOADLMDC, int OMCOLCOGEGE = 0, int HECIBPFHNAM = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7E45310", Offset = "0x7E44110", VA = "0x187E45310")]
	public static JobHandle LAAFPDNDJMO(FOMCKKHJCPF JBDKOFJMKBE, NONOJJJJOHD LCFOGFNHIAO, NativeArray<int> KHDHLLIMDCD, PEDGPBLEJDC FFEMKICJPKP, JobHandle JAAMMEMKHCH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7E45060", Offset = "0x7E43E60", VA = "0x187E45060")]
	public static JobHandle FMHJDMFJJOD(OILOIICGDLG JBDKOFJMKBE, NONOJJJJOHD LCFOGFNHIAO, APEEIJKLEPN FFEMKICJPKP, NativeArray<CCHLCODHAON> BCOCCKNHKNN, int GFBHKKJANIO, int MCCEBKGMOBA, JobHandle JAAMMEMKHCH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class CBLGHLJIPBD
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct IBNGBKJIOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer NHLDFAAJMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public BDMPFDNHJDC.EIJIDKILKHL OFPDGGHOEMF;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C690", Offset = "0x5D7B490", VA = "0x185D7C690")]
		public IBNGBKJIOFN(MeshRenderer NHLDFAAJMGK, BDMPFDNHJDC.EIJIDKILKHL OFPDGGHOEMF)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7E509F0", Offset = "0x7E4F7F0", VA = "0x187E509F0")]
		public static IBNGBKJIOFN HEKJAOMNHLJ((MeshRenderer, BDMPFDNHJDC.EIJIDKILKHL) IHKPNNLPJHN)
		{
			return default(IBNGBKJIOFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker ELEADKCBAMM;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker ILOCPFJJMDI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker ONAOJFHHCDD;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker GKHEPKLAKHB;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B860", Offset = "0x7E4A660", VA = "0x187E4B860")]
	internal void EBGLLDLABLO(GameObject ACKGPIBFKOB, BDMPFDNHJDC.EKMAFEMLEOL HLECLPNHNHM, List<IBNGBKJIOFN> PFFDFBCPKLN, Material EFCBJICGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C240", Offset = "0x7E4B040", VA = "0x187E4C240")]
	internal void LMDCOKBFCLC(GameObject ACKGPIBFKOB, BDMPFDNHJDC.EKMAFEMLEOL HLECLPNHNHM, List<IBNGBKJIOFN> PFFDFBCPKLN, List<LODGroup> IBPKABOAOKC, Material EFCBJICGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CA70", Offset = "0x7E4B870", VA = "0x187E4CA70")]
	private MeshRenderer MLHKGPNNEPC(BDMPFDNHJDC.EKMAFEMLEOL HLECLPNHNHM, Material EFCBJICGDPB, List<IBNGBKJIOFN> PFFDFBCPKLN, bool OHKCKHIIBMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A960", Offset = "0x7E49760", VA = "0x187E4A960")]
	private List<(List<IBNGBKJIOFN>, float)> CICENNMCJJL(BDMPFDNHJDC.EKMAFEMLEOL HLECLPNHNHM, List<LODGroup> IBPKABOAOKC, Material EFCBJICGDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7E49C00", Offset = "0x7E48A00", VA = "0x187E49C00")]
	private List<List<(List<IBNGBKJIOFN>, float)>> BECBCCCMFIA(BDMPFDNHJDC.EKMAFEMLEOL HLECLPNHNHM, List<LODGroup> IBPKABOAOKC, Material EFCBJICGDPB, [Out] int BEBOPIJIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CBLGHLJIPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C0D0", Offset = "0x7E4AED0", VA = "0x187E4C0D0")]
	[CompilerGenerated]
	internal static (float, int) JAAKBCHNLPM(List<List<(List<IBNGBKJIOFN> meshList, float lodTransition)>> EBMIFMLEKLF, int[] PBKNCJHDPCH)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MIPHIEMMJGP
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker ANKLKIJOOON;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker EIAGEODOBLA;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker DDNOGOKEJGA;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker FFFJGFJMPJM;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker JAJFHADKLFJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker OIBMINIBCGP;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker AMIDNCJNIEH;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly IEBEPMGFCGH HILDPNHGOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private BDMPFDNHJDC IJKGNBGFEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CBLGHLJIPBD IALBAMFCNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader ADLNKJGELBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock EHKGIDDJICP;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7E53F00", Offset = "0x7E52D00", VA = "0x187E53F00")]
	public static void BLHHFKLFIMH(GameObject ACKGPIBFKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7E55170", Offset = "0x7E53F70", VA = "0x187E55170")]
	public void IANLJFINMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7E55900", Offset = "0x7E54700", VA = "0x187E55900")]
	public void KIDOJEGHMGB(GameObject ACKGPIBFKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7E54AC0", Offset = "0x7E538C0", VA = "0x187E54AC0")]
	private bool EKAGPLIHFBL(MeshRenderer NHLDFAAJMGK, [Out] MeshFilter DBOLKDLBKGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7E54330", Offset = "0x7E53130", VA = "0x187E54330")]
	private bool DABCNABKMJK(int GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7E53510", Offset = "0x7E52310", VA = "0x187E53510")]
	private void AAMOEGDOAGC(GameObject ACKGPIBFKOB, int GLAOLHCPLLG, Material EFCBJICGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7E53740", Offset = "0x7E52540", VA = "0x187E53740")]
	private List<CBLGHLJIPBD.IBNGBKJIOFN> ABKLMNALHAH(int GLAOLHCPLLG, [Out] List<LODGroup> IBPKABOAOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7E54550", Offset = "0x7E53350", VA = "0x187E54550")]
	private List<(int, Material)> DLMJKJABMNI(float BADCPPILCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7E54280", Offset = "0x7E53080", VA = "0x187E54280")]
	public void BPDAHNLNAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7E54C40", Offset = "0x7E53A40", VA = "0x187E54C40")]
	private bool GDEOANJEDAA(GameObject MMMAEDGEACA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7E55DA0", Offset = "0x7E54BA0", VA = "0x187E55DA0")]
	public MIPHIEMMJGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class BDMPFDNHJDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct EKMAFEMLEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 CEDDBAAAIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 JJLOIPCKCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float GPAJMJAPBNJ;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E830", Offset = "0x7E4D630", VA = "0x187E4E830")]
		public EKMAFEMLEOL(Bounds ECBLDOPKHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E720", Offset = "0x7E4D520", VA = "0x187E4E720")]
		public EKMAFEMLEOL(float3 CEDDBAAAIGH, float3 JJLOIPCKCEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct GPOBKIDJIHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public EKMAFEMLEOL HHCMFJNAMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int KEBKCILMJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int FDHHMEPNKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float MNJIBDPCMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int JDEAPLOGHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int OMHCFBDMGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int IIDDOAFKBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int BDNNOHANENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int JBBEJAMCIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool FPJNBHPMDGA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct EIJIDKILKHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh NCJJOMJEBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 GEDGHOPKDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int LOILDIKIJIA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct DMMBLDPNHHJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<GPOBKIDJIHP> DCLDOFEODBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> HDPPHEBDPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int KINPDPJEMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public EKMAFEMLEOL ECBLDOPKHPL;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E5F0", Offset = "0x7E4D3F0", VA = "0x187E4E5F0")]
		private float JFBFEJPAGAI(EKMAFEMLEOL CHIPBNNCPBF, EKMAFEMLEOL MDEAIGKHMKE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E3D0", Offset = "0x7E4D1D0", VA = "0x187E4E3D0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker DIKEOOJONIP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker BLGEFPKEKAG;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker CGGCPDMCPJL;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker FNCCCMGKJGO;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker CFALEJOPFPD;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker ONKIOLOCHMM;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker GNCFMEDNIOP;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker MHMFOCMKDMG;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker KHLABAPEAOA;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker HLHLMOKOABA;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker DKJDMIDGJMK;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker DCNHNAMHKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<GPOBKIDJIHP> DCLDOFEODBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> EJMGFFFMCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int FFOPAGGNOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> PBBGJANINFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<EIJIDKILKHL> ONEGLFPPBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> IBPKABOAOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> PACLKONGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> IHCCHGEBEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader BMFLPKEAOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader LBEKJKFEFIB;

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7E498C0", Offset = "0x7E486C0", VA = "0x187E498C0")]
	public BDMPFDNHJDC(int BNAGFKGLFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7E46710", Offset = "0x7E45510", VA = "0x187E46710")]
	private void FLEPBDCMBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7E488F0", Offset = "0x7E476F0", VA = "0x187E488F0")]
	public bool MFODKCOMMJB(MeshRenderer PIJGINHOMLD, MeshFilter BPAJBOPCLFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7E47C30", Offset = "0x7E46A30", VA = "0x187E47C30")]
	public bool MFODKCOMMJB(LODGroup EADIKCJDNIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7E46050", Offset = "0x7E44E50", VA = "0x187E46050")]
	private bool CIMEKDDIMAF(MeshRenderer PIJGINHOMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7E47600", Offset = "0x7E46400", VA = "0x187E47600")]
	private int JKGFGKODKME(MeshRenderer PIJGINHOMLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7E48D80", Offset = "0x7E47B80", VA = "0x187E48D80")]
	private int MNLHCBGHDCM(LODGroup EADIKCJDNIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7E47AD0", Offset = "0x7E468D0", VA = "0x187E47AD0")]
	private int LGMJAABDOIO(MeshFilter BPAJBOPCLFF, int NIFJNECFBGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7E49270", Offset = "0x7E48070", VA = "0x187E49270")]
	private int PNPKEOEIDAD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7E47720", Offset = "0x7E46520", VA = "0x187E47720")]
	private static EKMAFEMLEOL LADDIOAGKNL(EKMAFEMLEOL CHIPBNNCPBF, EKMAFEMLEOL MDEAIGKHMKE)
	{
		return default(EKMAFEMLEOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7E465C0", Offset = "0x7E453C0", VA = "0x187E465C0")]
	private static float EPPNCHPDBLB(Vector3 CEDDBAAAIGH, Vector3 JJLOIPCKCEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7E47090", Offset = "0x7E45E90", VA = "0x187E47090")]
	private int IKIMIFLIFNB(int GDJPDCMAFMH, EKMAFEMLEOL GBAKPJLEGAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7E46880", Offset = "0x7E45680", VA = "0x187E46880")]
	private void HFGFFJNFGNO(EKMAFEMLEOL GBAKPJLEGAE, int GLAOLHCPLLG, [Out] float ILFKFKLJIMJ, [Out] float IOHLCJACBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7E48DF0", Offset = "0x7E47BF0", VA = "0x187E48DF0")]
	private void OJJLIDLLLKP(EKMAFEMLEOL GBAKPJLEGAE, int EGCDHPKPBCK, Material EFCBJICGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7E473C0", Offset = "0x7E461C0", VA = "0x187E473C0")]
	private float JFBFEJPAGAI(EKMAFEMLEOL CHIPBNNCPBF, EKMAFEMLEOL MDEAIGKHMKE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7E460D0", Offset = "0x7E44ED0", VA = "0x187E460D0")]
	private void CININDMJCPN(int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7E45C00", Offset = "0x7E44A00", VA = "0x187E45C00")]
	private void CFJNAPEOLFD(int KGNKFPBDPOL, int HFHMBCPFDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7E46AE0", Offset = "0x7E458E0", VA = "0x187E46AE0")]
	private void IFADEKOCFEF(int KGNKFPBDPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7E46510", Offset = "0x7E45310", VA = "0x187E46510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct CAGEDHIBNFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 KJACMEPEAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 OFCMOEKBANG;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class LNOPJHOEFDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<CAGEDHIBNFH> IFGNIGNNIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> GCBAJPKEHPN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GEMKIIKMKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LHHALMFLOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7E52EC0", Offset = "0x7E51CC0", VA = "0x187E52EC0")]
	public LNOPJHOEFDF(int JDEAPLOGHMI, int JNCGHNJOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7E52D80", Offset = "0x7E51B80", VA = "0x187E52D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7E52DE0", Offset = "0x7E51BE0", VA = "0x187E52DE0")]
	public void FHLMBJOLLCJ(LNOPJHOEFDF PFCOGNKFPHL, int FKCBDFMJNMP, int AJOJFAFFHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class KCLLHMNEBBL
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static LNOPJHOEFDF FKFAIDEKMKH;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<CNJAJGPNEJB> DCAIGKEBEJM;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] HMABDLHEIDI;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool FIABGGPJEJB;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, LNOPJHOEFDF> LIINFJNIDBL;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, LNOPJHOEFDF> DGNILAEPLGJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool GIENOBOAFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7E51C60", Offset = "0x7E50A60", VA = "0x187E51C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<CNJAJGPNEJB> BKHBNAGJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7E51700", Offset = "0x7E50500", VA = "0x187E51700")]
		get
		{
			return default(NativeList<CNJAJGPNEJB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LNOPJHOEFDF JNDBJKKCEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7E50F60", Offset = "0x7E4FD60", VA = "0x187E50F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7E510F0", Offset = "0x7E4FEF0", VA = "0x187E510F0")]
	private static void JKLJFKPOIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7E51000", Offset = "0x7E4FE00", VA = "0x187E51000")]
	public static int GLPOPFNJMBK(bool IPFACGEDNKF, int LPPFHHBBBBH, bool CKKAGOJCAEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7E50A70", Offset = "0x7E4F870", VA = "0x187E50A70")]
	private static int CPCMHCDMGAJ(int LPPFHHBBBBH, bool ILNFFGCHNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7E50B20", Offset = "0x7E4F920", VA = "0x187E50B20")]
	private static int FDFILNLCOKJ(int LPPFHHBBBBH, bool ILNFFGCHNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7E517A0", Offset = "0x7E505A0", VA = "0x187E517A0")]
	public static int KGIEJEDMBME(int JGJKFDFMJDO, int LPPFHHBBBBH, int OFPPJKBNODM, bool ILNFFGCHNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7E50A90", Offset = "0x7E4F890", VA = "0x187E50A90")]
	public static int DLPHEDIKBNI(int JGJKFDFMJDO, int LPPFHHBBBBH, int OFPPJKBNODM, bool ILNFFGCHNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7E52060", Offset = "0x7E50E60", VA = "0x187E52060")]
	public static int OAJFOIEHMBE(int OFPPJKBNODM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7E510C0", Offset = "0x7E4FEC0", VA = "0x187E510C0")]
	private static int IGAOODEJJHF(int LPPFHHBBBBH, bool ILNFFGCHNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7E510D0", Offset = "0x7E4FED0", VA = "0x187E510D0")]
	private static int JEBOCNIEMHK(int LPPFHHBBBBH, bool ILNFFGCHNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7E52070", Offset = "0x7E50E70", VA = "0x187E52070")]
	public static int ODGFLIODPID(int JGJKFDFMJDO, int LPPFHHBBBBH, int OFPPJKBNODM, bool ILNFFGCHNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7E51030", Offset = "0x7E4FE30", VA = "0x187E51030")]
	public static int HJFHKIMICFL(int JGJKFDFMJDO, int LPPFHHBBBBH, int OFPPJKBNODM, bool ILNFFGCHNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7E51C40", Offset = "0x7E50A40", VA = "0x187E51C40")]
	public static int LIGDANDJCNE(int OFPPJKBNODM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7E50B30", Offset = "0x7E4F930", VA = "0x187E50B30")]
	public static LNOPJHOEFDF GBHPFIADCKI(int LPPFHHBBBBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7E51DD0", Offset = "0x7E50BD0", VA = "0x187E51DD0")]
	private static LNOPJHOEFDF MMKAFPDNCKN(int LPPFHHBBBBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7E51CE0", Offset = "0x7E50AE0", VA = "0x187E51CE0")]
	public static LNOPJHOEFDF MIJMPPIBFOH(int LPPFHHBBBBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7E50C20", Offset = "0x7E4FA20", VA = "0x187E50C20")]
	private static LNOPJHOEFDF GGDFFJCNONO(int LPPFHHBBBBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7E51830", Offset = "0x7E50630", VA = "0x187E51830")]
	public static void LEOIPKKBJIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct APEEIJKLEPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int BCJLODKKPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 MLDDKPAIKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion PNPJAMDECAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float MPOHGHLPKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float PKFJBPEOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int HCJHJANFJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int KEMFIGNEAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int LIKPJKOAIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool AENNBOKIMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool HOMLLNBIJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float DCFNGINFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 BBGPGAAGFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool PLOLLJPNMMF;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct DJFBJHIFBHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int DLIBLPFOIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int EGLPIHOENCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct OILOIICGDLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<APEEIJKLEPN> OPEDKLHFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<CCHLCODHAON> KFDFLAGKCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<CNJAJGPNEJB> AGEABLPJKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<DJFBJHIFBHK> LPDLLFMMGFI;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7E58D50", Offset = "0x7E57B50", VA = "0x187E58D50")]
	public OILOIICGDLG(NativeArray<CCHLCODHAON> KFDFLAGKCNO, int ACINDEOBNPO = 1, Allocator LNMGNHHGHLL = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7E58C60", Offset = "0x7E57A60", VA = "0x187E58C60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct MKBDOOPOKAB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<CAGEDHIBNFH> DEBBLEHMEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> NHPEELNJJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<CNJAJGPNEJB> PNDEDDIPOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<APEEIJKLEPN> OPEDKLHFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<CCHLCODHAON> KFDFLAGKCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<CNJAJGPNEJB> AGEABLPJKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<DJFBJHIFBHK> LPDLLFMMGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int MKDHKLOHHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int JHGDBAELLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 JABAOJJJJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion FPGHKPHCMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 HHEPJMPBPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NFNKEFLOACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MJOAHFDFCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EJAGBOANJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CCIOPLGHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MOJFLHJDLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EHMPJMLFEML;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7E57ED0", Offset = "0x7E56CD0", VA = "0x187E57ED0")]
	public MKBDOOPOKAB(AOEBHBIJBCB GDEJHMHAOJL, NONOJJJJOHD BKLLJPNAMOM, float3 MDKKJCBGOAB, quaternion HCAJPJCJGCB, float POADGBDAGKO, int OMCOLCOGEGE = 0, int HECIBPFHNAM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E57CA0", Offset = "0x7E56AA0", VA = "0x187E57CA0")]
	public MKBDOOPOKAB(OILOIICGDLG GDEJHMHAOJL, NONOJJJJOHD BKLLJPNAMOM, float3 MDKKJCBGOAB, quaternion HCAJPJCJGCB, float3 POADGBDAGKO, int OMCOLCOGEGE = 0, int HECIBPFHNAM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E57AD0", Offset = "0x7E568D0", VA = "0x187E57AD0")]
	private float3 LPIDJMMFAON(float3 ICDJIIHCPGP, Matrix4x4 PDNAAIPEOAK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7E57C10", Offset = "0x7E56A10", VA = "0x187E57C10")]
	private float3x3 MJOPDLKOCLK(float3x3 FIKPLGMFEPN, float3x3 GGNKACBJGHJ)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E57C90", Offset = "0x7E56A90", VA = "0x187E57C90")]
	private float OLEDPLPPDJD(float JCGDFDLNFJA, float MGHOKMMEGAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E55F70", Offset = "0x7E54D70", VA = "0x187E55F70", Slot = "4")]
	public void Execute(int KILCKNBNPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E55E00", Offset = "0x7E54C00", VA = "0x187E55E00")]
	private void BMALNJLANJH(int KKMMNGBKLOI, float3 NPJPCFKLMHD, float3 KODPDAPHGHG, float3 PLJNDIABGEJ, float MEHMJKKFJEH, bool AMDPEEFJGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E57110", Offset = "0x7E55F10", VA = "0x187E57110")]
	private void IEFCDJOBKIF(APEEIJKLEPN PNGKCMCAHGH, float3 HAMOKFILEGG, float3x3 NHBCDKIJGAO, float JCGDFDLNFJA, int DPOHMFFEBBI, int GKOJEMJIHNO, int GLNKFJGBFIJ, float FCCPCHEBIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E57550", Offset = "0x7E56350", VA = "0x187E57550")]
	private void ILMKPLFAHLO(int KKMMNGBKLOI, int ANNGBPPNBLN, APEEIJKLEPN PNGKCMCAHGH, float3 HAMOKFILEGG, float3x3 NHBCDKIJGAO, bool PMCDFGJJLBA, float JCGDFDLNFJA, int AFCFOLENLLP, int DJFNPOKNGEC, int GLNKFJGBFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FOMCKKHJCPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<PEDGPBLEJDC> KKKBLGCDOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<CNJAJGPNEJB> IHPMHDDGKDB;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FA70", Offset = "0x7E4E870", VA = "0x187E4FA70")]
	public FOMCKKHJCPF(int ACINDEOBNPO, Allocator LNMGNHHGHLL = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F9D0", Offset = "0x7E4E7D0", VA = "0x187E4F9D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct OPJJOELAPGF : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum CAONKAJHKNJ
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
	private NativeList<float3> HDIODJKEEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> DBIGOJNIGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> JEEEHHHHDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> HOEGCBGOADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> FGDLODKNMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> JMNDEOIAIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> MFDAAGLIFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> JKEABLHINCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> BGOEPKJFEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<CNJAJGPNEJB> DLBCPKPONDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<PEDGPBLEJDC> KKKBLGCDOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<CNJAJGPNEJB> IHPMHDDGKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int MKDHKLOHHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int JHGDBAELLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NFNKEFLOACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MJOAHFDFCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EJAGBOANJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CCIOPLGHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MOJFLHJDLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KHDHLLIMDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EHMPJMLFEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 HHEPJMPBPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion FPGHKPHCMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 JABAOJJJJNL;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BF40", Offset = "0x7E5AD40", VA = "0x187E5BF40")]
	public OPJJOELAPGF(AOEBHBIJBCB GDEJHMHAOJL, NONOJJJJOHD BKLLJPNAMOM, NativeArray<int> NNFHPHOLENN, float3 MDKKJCBGOAB, quaternion HCAJPJCJGCB, float POADGBDAGKO, int OMCOLCOGEGE = 0, int HECIBPFHNAM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BD30", Offset = "0x7E5AB30", VA = "0x187E5BD30")]
	public OPJJOELAPGF(FOMCKKHJCPF FFEMKICJPKP, NONOJJJJOHD BKLLJPNAMOM, NativeArray<int> NNFHPHOLENN, float3 MDKKJCBGOAB, quaternion HCAJPJCJGCB, float3 POADGBDAGKO, int OMCOLCOGEGE = 0, int HECIBPFHNAM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A920", Offset = "0x7E59720", VA = "0x187E5A920", Slot = "4")]
	public void Execute(int KILCKNBNPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B980", Offset = "0x7E5A780", VA = "0x187E5B980")]
	private void INKEMKIAACP(float4x4 JBJBDEAAAHH, int KILCKNBNPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B910", Offset = "0x7E5A710", VA = "0x187E5B910")]
	private CAONKAJHKNJ FKMMHOJKPML(float3 KODPDAPHGHG)
	{
		return default(CAONKAJHKNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A8D0", Offset = "0x7E596D0", VA = "0x187E5A8D0")]
	private float4 EILOPNDMDMO(CAONKAJHKNJ AFBNIALGAIO, int GLAOLHCPLLG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B8D0", Offset = "0x7E5A6D0", VA = "0x187E5B8D0")]
	private float2 FIBFICGGCHD(CAONKAJHKNJ AFBNIALGAIO, float3 NPJPCFKLMHD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct HPHGBMKCHHO
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum NLBKFAAFJAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static HPHGBMKCHHO LJAJAMKHAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 HKMBNCFKKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 PHNPMAOBIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 KBBILNDKGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NLBKFAAFJAF KDNIOMEAELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 EAGKHKNLIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 GMOEDMJOIEH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool JOCIPIGBAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E506D0", Offset = "0x7E4F4D0", VA = "0x187E506D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 GAICJEHBFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E50500", Offset = "0x7E4F300", VA = "0x187E50500")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E50900", Offset = "0x7E4F700", VA = "0x187E50900")]
	public HPHGBMKCHHO(float3 NPJPCFKLMHD, quaternion LJIHJJKHDDH, float3 ACINDEOBNPO, NLBKFAAFJAF AAFMBEEMJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E50300", Offset = "0x7E4F100", VA = "0x187E50300")]
	public float IDCIKDCHBLD(float3 HAMOKFILEGG, float MKEPFDMBLLD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E505E0", Offset = "0x7E4F3E0", VA = "0x187E505E0")]
	public bool LCLFPABLDEJ(float3 KODPDAPHGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E506E0", Offset = "0x7E4F4E0", VA = "0x187E506E0")]
	public void PMJDGJFAONG(float3 DOFPDCHPLGI, float3x3 LIJOMNPMDBO, float LNHFEOIFEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E50210", Offset = "0x7E4F010", VA = "0x187E50210")]
	private void EJGDBNGCCGD(float3 PLKCLDLMLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FF80", Offset = "0x7E4ED80", VA = "0x187E4FF80")]
	public void APBEONNNNGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct KKEIOOOIMOD : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<HPHGBMKCHHO> FFEMKICJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> PBHBGPOCIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> PECKHJOFPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LNHEDNDOKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<CNJAJGPNEJB> IHPMHDDGKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int MOCKMHDMMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int NMEOJEECHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float MKEPFDMBLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float CFOAIMLMKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FKFJALDHJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> DLNPIPBKBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> LBNEPEMBBNG;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E52CE0", Offset = "0x7E51AE0", VA = "0x187E52CE0")]
	public KKEIOOOIMOD(NONOJJJJOHD JIEGCDEFFGO, float LAJJKFNGLJO, int AJOJFAFFHHF, int DPOHMFFEBBI, NativeList<HPHGBMKCHHO> FFEMKICJPKP, NativeArray<int> LNHEDNDOKCO, NativeList<CNJAJGPNEJB> IHPMHDDGKDB, HNPDPDLCLDJ HGPPEIKEKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E52250", Offset = "0x7E51050", VA = "0x187E52250", Slot = "4")]
	public void Execute(int FNHJEEHOPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E52C20", Offset = "0x7E51A20", VA = "0x187E52C20")]
	private bool OAENHEMIMPK(HPHGBMKCHHO CHIPBNNCPBF, HPHGBMKCHHO MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E52990", Offset = "0x7E51790", VA = "0x187E52990")]
	private bool KIBEJICOKFC(HPHGBMKCHHO MCJGCJPDJFH, int OMELBEGKNDE, int KEDKEHHPCBI, int BPCOLPHBDFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct FGLPICANFCE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<CLHOIMBKGBI.EBEFJAKPHKO> MGGEEBMDBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> FEKCENKPHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int OMCOLCOGEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int HECIBPFHNAM;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F110", Offset = "0x7E4DF10", VA = "0x187E4F110")]
	public FGLPICANFCE(NativeList<CLHOIMBKGBI.EBEFJAKPHKO> MGGEEBMDBKI, NativeArray<int> FEKCENKPHJL, int HECIBPFHNAM = 0, int OMCOLCOGEGE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F060", Offset = "0x7E4DE60", VA = "0x187E4F060", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class HNPDPDLCLDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> EPHOFHCHMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> JGKPEAEPNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> CFCEJJADMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> JIHBHPDJBOD;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FC60", Offset = "0x7E4EA60", VA = "0x187E4FC60")]
	public void DFOACHHADOO(int JDEAPLOGHMI, int JNCGHNJOHFD, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FE70", Offset = "0x7E4EC70", VA = "0x187E4FE70")]
	public static long JHHHNEIKJGO(int JDEAPLOGHMI, int JNCGHNJOHFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FD80", Offset = "0x7E4EB80", VA = "0x187E4FD80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FE90", Offset = "0x7E4EC90", VA = "0x187E4FE90")]
	public void LNJEMOCDJGL(JobHandle JAAMMEMKHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HNPDPDLCLDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct ONKPJHBPCCM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> PBHBGPOCIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> FKFBMOPPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> FDALPPCBFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> IPPCDFJEOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> PECKHJOFPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EKNIDIEOBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> OEJOFGKNMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> FKFJALDHJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> DLNPIPBKBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int OMCOLCOGEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int HECIBPFHNAM;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A850", Offset = "0x7E59650", VA = "0x187E5A850")]
	public ONKPJHBPCCM(NONOJJJJOHD JIEGCDEFFGO, HNPDPDLCLDJ HGPPEIKEKFO, int HECIBPFHNAM = 0, int OMCOLCOGEGE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A410", Offset = "0x7E59210", VA = "0x187E5A410", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A7F0", Offset = "0x7E595F0", VA = "0x187E5A7F0")]
	private void HEHPENHFGCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class AJJMGNBJDAC
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x414AB60", Offset = "0x4149960", VA = "0x18414AB60")]
	public static bool FOGJEPMKNIA<T>(NativeArray<T> KNDCNOIHMGO, int ACINDEOBNPO, Allocator LNMGNHHGHLL, NativeArrayOptions FMKKHOLMGDF = NativeArrayOptions.ClearMemory, int DJELJAHLPKC = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x414ADA0", Offset = "0x4149BA0", VA = "0x18414ADA0")]
	public static bool FOGJEPMKNIA<T>(NativeList<T> COKPAJOONAO, int ACINDEOBNPO, Allocator LNMGNHHGHLL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x414AE60", Offset = "0x4149C60", VA = "0x18414AE60")]
	public static bool FOGJEPMKNIA<T>(NativeQueue<T> LGLHOLCLMEN, Allocator LNMGNHHGHLL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum PBEPDBDEIBA
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
public interface GAHBFAGALGI
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MDLEDDPPGDF(PBEPDBDEIBA JGJKFDFMJDO);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FCPCHKPKODK(PBEPDBDEIBA JGJKFDFMJDO);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GEDLKILBCJI DMFGHHEAJPK();

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float IHFMEAAKNIB();

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIPBAGDCPJE(PBEPDBDEIBA JGJKFDFMJDO, AOEBHBIJBCB JFAEDAJNLMJ, int FMHBCCCILMO = -1);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int HDDANLCIAPC(int KMEGMGHDGJB);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class PCMAAMDAGAL
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C150", Offset = "0x7E5AF50", VA = "0x187E5C150")]
	public static void LEOIPKKBJIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class ONJNMFJJCNA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> GFKNFMMCGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> PJBBHJCMOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> JMMKEFAHEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> DDACJLAFHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> DFLEIGIJIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> JEPALJOCLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> FNHPNKBBGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> CBDGHJCCPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> EOGOOIEPPGK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GEMKIIKMKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E58EC0", Offset = "0x7E57CC0", VA = "0x187E58EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LHHALMFLOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E58E80", Offset = "0x7E57C80", VA = "0x187E58E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ACCEHLLDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E59390", Offset = "0x7E58190", VA = "0x187E59390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E59D90", Offset = "0x7E58B90", VA = "0x187E59D90")]
	public ONJNMFJJCNA(int JDEAPLOGHMI, int JNCGHNJOHFD, int OLGFENICKHG, Allocator LNMGNHHGHLL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A0B0", Offset = "0x7E58EB0", VA = "0x187E5A0B0")]
	public ONJNMFJJCNA(Mesh JIEGCDEFFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E593D0", Offset = "0x7E581D0", VA = "0x187E593D0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E594F0", Offset = "0x7E582F0", VA = "0x187E594F0")]
	public void FHLMBJOLLCJ(ONJNMFJJCNA JIEGCDEFFGO, bool BCJEAFPCKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E58F00", Offset = "0x7E57D00", VA = "0x187E58F00")]
	private void APGNCLKINAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E59820", Offset = "0x7E58620", VA = "0x187E59820")]
	private void KKHGCEBGHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct CNJAJGPNEJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int MIOMFBBGLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int GEMKIIKMKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int AJFDPEEACPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int LHHALMFLOOI;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE410", Offset = "0x1FAD210", VA = "0x181FAE410")]
	public CNJAJGPNEJB(int DPOHMFFEBBI, int GFBHKKJANIO, int AJOJFAFFHHF, int MCCEBKGMOBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class DKMDJENKPNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<CNJAJGPNEJB> ILPBLOOKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<CNJAJGPNEJB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ONJNMFJJCNA NCJJOMJEBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DE00", Offset = "0x7E4CC00", VA = "0x187E4DE00")]
	public DKMDJENKPNF(IEnumerable<ONJNMFJJCNA> LPILIBFAFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DD90", Offset = "0x7E4CB90", VA = "0x187E4DD90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum MICJMPBPOBO
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class EGLOCHJNMBD
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> JHLEHMIDKJK;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> BBKPENAKPNL;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> KMLPCDLIAFH;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> FEGJOKBKHLM;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E67360", Offset = "0x7E66160", VA = "0x187E67360")]
	public static void LEOIPKKBJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E67250", Offset = "0x7E66050", VA = "0x187E67250")]
	public static NativeArray<float2> HGAPIBOPKJK(NativeArray<float2> LNALNFMBFFG, int OCGIBCPGADI, NativeArray<float2> BDAOOEOPDFK, int FCHMJGBGCEM)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E67030", Offset = "0x7E65E30", VA = "0x187E67030")]
	public static NativeArray<float3> BKMKIEIPIGL(NativeArray<float3> LNALNFMBFFG, int OCGIBCPGADI, NativeArray<float3> BDAOOEOPDFK, int FCHMJGBGCEM)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E67140", Offset = "0x7E65F40", VA = "0x187E67140")]
	public static NativeArray<float4> DAAIMEHNMKO(NativeArray<float4> LNALNFMBFFG, int OCGIBCPGADI, NativeArray<float4> BDAOOEOPDFK, int FCHMJGBGCEM)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E67480", Offset = "0x7E66280", VA = "0x187E67480")]
	public static NativeArray<int> NGDKIBDPACD(NativeArray<int> LNALNFMBFFG, int OCGIBCPGADI, NativeArray<int> BDAOOEOPDFK, int FCHMJGBGCEM)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x37770A0", Offset = "0x3775EA0", VA = "0x1837770A0")]
	private static void EBFDMGCAIHG<T>(NativeArray<T> KNDCNOIHMGO, int ODBLMMJGDOD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x37772A0", Offset = "0x37760A0", VA = "0x1837772A0")]
	private static void OBADHCOMPAK<T>(NativeArray<T> LNALNFMBFFG, int OCGIBCPGADI, NativeArray<T> BDAOOEOPDFK, int FCHMJGBGCEM, NativeArray<T> BPEKFBIIHBJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class CMEPLEIJGAP
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct CJADLPOLEHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort AJEEBBBAOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort GJPKMHAOJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort ECFKHEFHOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort OPCLBKLFHCC;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E66A90", Offset = "0x7E65890", VA = "0x187E66A90")]
	public static uint JIAMGDEPKCD(float DMGBKANCIHM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E66980", Offset = "0x7E65780", VA = "0x187E66980")]
	public static void JGOAAGCAKOC(float4 FDALPPCBFML, float NBEOFEOOCNO, [Out] uint MDPHBONMPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E668B0", Offset = "0x7E656B0", VA = "0x187E668B0")]
	public static void JGOAAGCAKOC(float4 FDALPPCBFML, uint JIBGBDIDDAN, [Out] uint MDPHBONMPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E66AA0", Offset = "0x7E658A0", VA = "0x187E66AA0")]
	public static void OALPJGLBNID(float3 HNFHEPGEPFA, float3 BLEBDMIOIHD, float4 DCNIHJAMHPJ, float2 BMNMGNJHNDE, float4 FDALPPCBFML, [Out] NONOJJJJOHD.JDPBBHAIPDI DMPNNPEFFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E66CF0", Offset = "0x7E65AF0", VA = "0x187E66CF0")]
	public static void OALPJGLBNID(float3 HNFHEPGEPFA, float3 BLEBDMIOIHD, float4 DCNIHJAMHPJ, float2 BMNMGNJHNDE, float4 FDALPPCBFML, [Out] NONOJJJJOHD.DHBLCPJOLBD DMPNNPEFFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E663B0", Offset = "0x7E651B0", VA = "0x187E663B0")]
	public static byte ALMONFIBGNP(float OAIIHELJHLG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E66F50", Offset = "0x7E65D50", VA = "0x187E66F50")]
	public static ushort OKMIOMJDNIE(float OAIIHELJHLG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E66400", Offset = "0x7E65200", VA = "0x187E66400")]
	public static uint CJNDDFENIGD(float OAIIHELJHLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E66430", Offset = "0x7E65230", VA = "0x187E66430")]
	public static float2 DCPGNIGJGCE(float2 LCFJFNFOMKB)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E66760", Offset = "0x7E65560", VA = "0x187E66760")]
	public static float2 IKGCJFMFOAN(float3 KACKFEMGFCF)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E66610", Offset = "0x7E65410", VA = "0x187E66610")]
	public static void HBEDGOPCDCG(float3 OAIIHELJHLG, [Out] float3 MKONGGGDHPL, [Out] uint3 OPCLBKLFHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7E664B0", Offset = "0x7E652B0", VA = "0x187E664B0")]
	public static CJADLPOLEHE DIINNPLNEGM(float3 NPJPCFKLMHD)
	{
		return default(CJADLPOLEHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class JAGKDNIJDKP
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker MLGDKPPGLHJ;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float JCHOAODHDAD;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void CLCEOLMCJAA(bool LEDDKLJEFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FAB0", Offset = "0x7E6E8B0", VA = "0x187E6FAB0")]
	public static float APEMKAFGEHI(float IMGDPDNJABP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FBC0", Offset = "0x7E6E9C0", VA = "0x187E6FBC0")]
	public static long KCDKNKHFHKE(float IMGDPDNJABP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F5D0", Offset = "0x7E6E3D0", VA = "0x187E6F5D0")]
	public static void AFNHEHEJHBF(float IMGDPDNJABP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface EEFIIJACHDH
{
	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFNHEHEJHBF(float IDFNLILNODM);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) DKLONFAEOGJ(float PMJNBDHENCH);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class PEEICDBIOAO
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum AJIGJJKNCLG
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
	private class HPHKBAPLPMJ : IECLMJKCHKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public AJIGJJKNCLG AAFMBEEMJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public BatchedMeshRenderer FLMGEMALOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public EMOHNCJKAII JHLDFNIDIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public CLHOIMBKGBI JACEMHOFKMN;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override float JIMKPCCKHFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x1111400", Offset = "0x1110200", VA = "0x181111400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x17AE490", Offset = "0x17AD290", VA = "0x1817AE490", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7E6C6F0", Offset = "0x7E6B4F0", VA = "0x187E6C6F0", Slot = "7")]
		public override void FNJHBOGPDPJ([Out] bool HHBDPDLNJEK, [Out] bool MKPBJLCBDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public HPHKBAPLPMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int CKPKNBNHEGJ;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int LDFMPHKIOJE;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int LKJGNFLCEEF;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long DFNFEKCJFGI;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long MONCANHKEBB;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long ICDHJICGODE;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long AFMCIIHMFGO;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int BMHGGMLDAMB;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float KMMOFGIJAOA;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool IBEKHHKPMJN;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int MKKHFEPAFAE;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int BBMBMBDDEHG;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int PGHICMFHAFC;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long LJJAEPFPPCH;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int CFLPJPDDJKA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool OLDDKECDIIO;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static uint JPNAHHIBMIL;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static LEBJEHGPOJG ENMLGEOIONM;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static List<uint> MEJHPLPGDAN;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static EEFIIJACHDH KOPLIIHCLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool JDDILOHPFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7E73B10", Offset = "0x7E72910", VA = "0x187E73B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void OHPBLIBIGLI(bool LEDDKLJEFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void CLCEOLMCJAA(bool LEDDKLJEFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void OHPBLIBIGLI(bool LEDDKLJEFNK, string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7E74710", Offset = "0x7E73510", VA = "0x187E74710")]
	public static void PMPEMBJLNMP(EEFIIJACHDH DJEDIPLICAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7E73550", Offset = "0x7E72350", VA = "0x187E73550")]
	public static (long, long, long, int, int) DKMBEGMMLHE(long HIIIGIALJOE)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7E74690", Offset = "0x7E73490", VA = "0x187E74690")]
	public static void OHDGOLOLIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7E70950", Offset = "0x7E6F750", VA = "0x187E70950")]
	public static void AFNHEHEJHBF(long HIIIGIALJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7E74440", Offset = "0x7E73240", VA = "0x187E74440")]
	public static void LJOMBLJFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7E74290", Offset = "0x7E73090", VA = "0x187E74290")]
	public static long KOOFNCAFJNB(long POGLDBGJLAC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7E72C80", Offset = "0x7E71A80", VA = "0x187E72C80")]
	public static bool CBDOCNPNAAP(long BOBEOMCFDDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7E745C0", Offset = "0x7E733C0", VA = "0x187E745C0")]
	public static bool OGGGCDLAGKF(long BOBEOMCFDDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7E73C20", Offset = "0x7E72A20", VA = "0x187E73C20")]
	public static float IJOEAPIHADL(long LCMMMAOKFEP, int DELMDJIPAMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7E73140", Offset = "0x7E71F40", VA = "0x187E73140")]
	public static (long, long, int) DKLONFAEOGJ(float IMGDPDNJABP)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7E74100", Offset = "0x7E72F00", VA = "0x187E74100")]
	public static void KHINENIEFIM(CLHOIMBKGBI JACEMHOFKMN, BatchedMeshRenderer FLMGEMALOMH, long EMLBBGGAHFP, long NMAJPIEEBHK, float LAAEJAGOGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7E73F80", Offset = "0x7E72D80", VA = "0x187E73F80")]
	public static void KCNBDFPADBD(CLHOIMBKGBI JACEMHOFKMN, BatchedMeshRenderer FLMGEMALOMH, long EMLBBGGAHFP, long NMAJPIEEBHK, float DGBHFCGCEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7E72DD0", Offset = "0x7E71BD0", VA = "0x187E72DD0")]
	public static void CKPJBGKEKBA(CLHOIMBKGBI JACEMHOFKMN, BatchedMeshRenderer FLMGEMALOMH, long NMAJPIEEBHK, float DGBHFCGCEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7E72F90", Offset = "0x7E71D90", VA = "0x187E72F90")]
	public static void CLDKHKPGLCM(CLHOIMBKGBI JACEMHOFKMN, BatchedMeshRenderer FLMGEMALOMH, long EMLBBGGAHFP, long NMAJPIEEBHK, float DGBHFCGCEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7E73820", Offset = "0x7E72620", VA = "0x187E73820")]
	private static void EBHLNGGBPLF(AJIGJJKNCLG AAFMBEEMJAC, CLHOIMBKGBI JACEMHOFKMN, EMOHNCJKAII JHLDFNIDIFH, BatchedMeshRenderer FLMGEMALOMH, long EMLBBGGAHFP, long NMAJPIEEBHK, float EPFOBEDKNJJ, bool NHKCLMJENML, bool OONKBKAKENK, float FBACJIPNPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7E73B60", Offset = "0x7E72960", VA = "0x187E73B60")]
	public static bool IJIIICKNEFH(float CCHFJJDFMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7E72D50", Offset = "0x7E71B50", VA = "0x187E72D50")]
	public static void CFAFNNPFNGE(float CCHFJJDFMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7E73710", Offset = "0x7E72510", VA = "0x187E73710")]
	public static bool DNIBLAKKKDD(float CCHFJJDFMHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class IECLMJKCHKE : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum EENEDJIOFMB : byte
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
	public EENEDJIOFMB AHNGIMLOFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public long NILJJLBIEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public long NMAJPIEEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public float NIAHEIPDGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public bool OONKBKAKENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool NHKCLMJENML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	internal uint FONJFDCCINO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract float JIMKPCCKHFP
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
	public abstract void FNJHBOGPDPJ([Out] bool HHBDPDLNJEK, [Out] bool MKPBJLCBDMP);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6CB60", Offset = "0x7E6B960", VA = "0x187E6CB60", Slot = "4")]
	public int CompareTo(object GLEBGNJJOHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected IECLMJKCHKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class LEBJEHGPOJG : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private List<IECLMJKCHKE> FKJMLJIHBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private List<IECLMJKCHKE> FACOCPNJFMJ;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FDF0", Offset = "0x7E6EBF0", VA = "0x187E6FDF0")]
	public void AIKICPLLADB(IECLMJKCHKE HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FD90", Offset = "0x7E6EB90", VA = "0x187E6FD90")]
	public void ABILIENNHFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FEC0", Offset = "0x7E6ECC0", VA = "0x187E6FEC0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7E70010", Offset = "0x7E6EE10", VA = "0x187E70010")]
	public void JHJLBEEPGBL(IEnumerable<uint> MEJHPLPGDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FF50", Offset = "0x7E6ED50", VA = "0x187E6FF50")]
	private void FKCGDELNEED(uint FONJFDCCINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7E703D0", Offset = "0x7E6F1D0", VA = "0x187E703D0", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7E70370", Offset = "0x7E6F170", VA = "0x187E70370")]
	public NMDKFIDFDCF PHEMDOOJNPF()
	{
		return default(NMDKFIDFDCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7E70470", Offset = "0x7E6F270", VA = "0x187E70470")]
	public LEBJEHGPOJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct NMDKFIDFDCF : IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private List<IECLMJKCHKE> FKJMLJIHBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private List<IECLMJKCHKE> FACOCPNJFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int LJDBIJPECGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private int IOKMEGCDBPL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7E70900", Offset = "0x7E6F700", VA = "0x187E70900", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IECLMJKCHKE CKHLHELFBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7E705E0", Offset = "0x7E6F3E0", VA = "0x187E705E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7E70910", Offset = "0x7E6F710", VA = "0x187E70910")]
	public NMDKFIDFDCF(List<IECLMJKCHKE> FKJMLJIHBAI, List<IECLMJKCHKE> FACOCPNJFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7E70760", Offset = "0x7E6F560", VA = "0x187E70760", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7E708F0", Offset = "0x7E6F6F0", VA = "0x187E708F0", Slot = "6")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class EMOHNCJKAII
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal enum ANGFJBODBDO
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
	public static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly string PIDHJAKBIHE;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly string OGPCBLAKMDC;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker PDIKLECNLGE;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker AAEEHHKNAOI;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker MLGDKPPGLHJ;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker KJFEFLJLHCP;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker CEONBMADBBB;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker ALLEJHFFPID;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker FPANFJJJKAK;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker CKKNCMHGJEL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker MKMNAFLLPPA;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker JBNGGPEACIH;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker BDIMLPDFKNL;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker DJPLMAJMBNK;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker IMPOGOLPGMF;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker DKJFIBNECGD;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker MPMEAJANOCC;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker BHAHHAIPFGK;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker MPOAIDFGJGD;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker MFDEPCEMIBM;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly ProfilerMarker PKMGLHLEJCG;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly ProfilerMarker GMPBGGHLJIK;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly ProfilerMarker JMCDPGMDHIM;

	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static readonly ProfilerMarker GEOCMPAMCDE;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly ProfilerMarker IHGFNEEPPID;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly ProfilerMarker INLEFFBAGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal readonly List<CLHOIMBKGBI> NHCDMHPEFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	internal CLHOIMBKGBI LAAMIJNBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly KPBNFJAGDEP BJEJMAIIKBN;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public const bool CEFGAKMAMCG = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public bool MOIPKMJCBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	internal ANGFJBODBDO NDPDCPHBLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	internal int AKOLJBHEIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	internal int DCNIJPLIMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	internal int NJOOEKAGMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	internal int HMIGDCANDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	internal long MDOIHGHIEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	internal long ALDCGPEENCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	internal long ODJMEGCDPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private NONOJJJJOHD BLMGFOGJNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private NONOJJJJOHD NFBODMGBGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private NONOJJJJOHD.KCBJFHLHBFC JFGPGNKJGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private bool NFMMKHPKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private int JMFJHJBOGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private PKJKAMKIEAF JPCAMOOBNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private float3 GOGNJCMDOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private float BCEAPOFILFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private float NIABMFMGOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float NMAGAGGEENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private float COJJEMBILJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float BINFFDFHGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private float IDNDFPMFEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private float3 PJCNCNGNHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float AALIOKOFAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private float DLKMAILLMJJ;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal Mesh NCJJOMJEBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MeshFilter PCGLAPLOGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MeshRenderer ACGDOILJGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<Material> ICBLMFGHEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int EAAKKCFHEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7E68230", Offset = "0x7E67030", VA = "0x187E68230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int JKABMHMCCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xD99670", Offset = "0xD98470", VA = "0x180D99670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int GEMKIIKMKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7E67590", Offset = "0x7E66390", VA = "0x187E67590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7E69EB0", Offset = "0x7E68CB0", VA = "0x187E69EB0")]
	public void GJCGJAHOLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B470", Offset = "0x7E6A270", VA = "0x187E6B470")]
	public bool OFPPCBLOAPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A590", Offset = "0x7E69390", VA = "0x187E6A590")]
	private void IOKCNABLGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7E680E0", Offset = "0x7E66EE0", VA = "0x187E680E0")]
	private void ANOKNHBJLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6C550", Offset = "0x7E6B350", VA = "0x187E6C550")]
	public EMOHNCJKAII(string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B090", Offset = "0x7E69E90", VA = "0x187E6B090")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7E68D80", Offset = "0x7E67B80", VA = "0x187E68D80")]
	private void DINBDMDEPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7E68A70", Offset = "0x7E67870", VA = "0x187E68A70")]
	private void CNLOLIFABOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7E68050", Offset = "0x7E66E50", VA = "0x187E68050")]
	public Mesh AGPJHBDFKHO(MeshFilter DBOLKDLBKGI, Transform MAAFBDAKBJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7E68C80", Offset = "0x7E67A80", VA = "0x187E68C80")]
	private void DFMPDALCBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7E69FE0", Offset = "0x7E68DE0", VA = "0x187E69FE0")]
	public void GNBMLOPAJID(GAHBFAGALGI BEHPIMAHFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7E690B0", Offset = "0x7E67EB0", VA = "0x187E690B0")]
	public bool EAHMAFBDGCK(GAHBFAGALGI BEHPIMAHFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7E68960", Offset = "0x7E67760", VA = "0x187E68960")]
	public bool CIMEKDDIMAF(GAHBFAGALGI BEHPIMAHFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7E69D90", Offset = "0x7E68B90", VA = "0x187E69D90", Slot = "4")]
	public virtual void GHGGEOCFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7E69180", Offset = "0x7E67F80", VA = "0x187E69180")]
	public void EGJNNAJPIOO(Transform MGHHALJBECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7E699C0", Offset = "0x7E687C0", VA = "0x187E699C0")]
	public bool FGCOFOEAPCN(Transform MGHHALJBECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7E69480", Offset = "0x7E68280", VA = "0x187E69480")]
	public bool FFDKCPINEHK(bool EHDJGDIMDPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7E689F0", Offset = "0x7E677F0", VA = "0x187E689F0")]
	private void CLDLDNIABKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7E675C0", Offset = "0x7E663C0", VA = "0x187E675C0")]
	public bool AFNHEHEJHBF(float4x4 JGDALGAMEBL, BatchedMeshRenderer GCMAKEFEJCA, bool ELLNPGBIAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A8A0", Offset = "0x7E696A0", VA = "0x187E6A8A0")]
	public bool KJACNBAFCPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A6B0", Offset = "0x7E694B0", VA = "0x187E6A6B0")]
	public void JPCMJAIENLJ(NONOJJJJOHD JIEGCDEFFGO, int OKFENPAFJJA, int PHAOHPFCOEO, float POHAOJGPJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A510", Offset = "0x7E69310", VA = "0x187E6A510")]
	public (long, long, long) IMCJCDKNIOE()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040")]
	public long IJPMEIFJNOC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B970", Offset = "0x7E6A770", VA = "0x187E6B970")]
	private void PEFMLJIEAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7E68E40", Offset = "0x7E67C40", VA = "0x187E68E40")]
	public (long, long, int) DKLONFAEOGJ(float IMGDPDNJABP, float4x4 JGDALGAMEBL)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7E68250", Offset = "0x7E67050", VA = "0x187E68250")]
	internal void BCGDEOHOGMC(ANGFJBODBDO PNLIABINBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7E68270", Offset = "0x7E67070", VA = "0x187E68270")]
	internal (float, float, float, float) BNDALCNGPBM(float AHPLLLBGDHF, float4x4 JGDALGAMEBL)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B790", Offset = "0x7E6A590", VA = "0x187E6B790")]
	public void OOALJCMLAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B590", Offset = "0x7E6A390", VA = "0x187E6B590")]
	private void OGDOLPOBAFC(NONOJJJJOHD AJJLOBIDAIG, NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7E68E20", Offset = "0x7E67C20", VA = "0x187E68E20")]
	private void DJLLBLBAOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A790", Offset = "0x7E69590", VA = "0x187E6A790")]
	internal bool KFHHIFNMPHI(bool EHDJGDIMDPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7E6BBD0", Offset = "0x7E6A9D0", VA = "0x187E6BBD0")]
	private void PLJLOHOJNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A120", Offset = "0x7E68F20", VA = "0x187E6A120")]
	private void IGLCKCOILNO([In] GNJKBDAPAAO AJJLOBIDAIG, NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE, bool CECFHMMDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B3D0", Offset = "0x7E6A1D0", VA = "0x187E6B3D0")]
	private void MMMAGGDGPPD(NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A6F0", Offset = "0x7E694F0", VA = "0x187E6A6F0")]
	private void KBFADIELPMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6BA90", Offset = "0x7E6A890", VA = "0x187E6BA90")]
	private void PJEOKLDCPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7E6ADB0", Offset = "0x7E69BB0", VA = "0x187E6ADB0")]
	public long KOOFNCAFJNB(long POGLDBGJLAC, int NELMGIEDHDP)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class CLHOIMBKGBI
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum LHJDENOHLFO
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
	public struct EBEFJAKPHKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int HLHNGKLKCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int GJCHJCHAFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public float ILFKFKLJIMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct MDKBBMFNEGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public GNJKBDAPAAO JIEGCDEFFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int FGFALLFPJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int PJCBKPLFMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public long FGMOENEENAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public long BJKGDFNAGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public float ACFJIEDOENK;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7E70530", Offset = "0x7E6F330", VA = "0x187E70530")]
		public void HLJFBNEKAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7E70560", Offset = "0x7E6F360", VA = "0x187E70560")]
		public void LNJEMOCDJGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly string PIDHJAKBIHE;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly string OGPCBLAKMDC;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker PDIKLECNLGE;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker AAEEHHKNAOI;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker MLGDKPPGLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker KJFEFLJLHCP;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker CEONBMADBBB;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker ALLEJHFFPID;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker FPANFJJJKAK;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker CKKNCMHGJEL;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker MKMNAFLLPPA;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker JBNGGPEACIH;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly ProfilerMarker BDIMLPDFKNL;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly ProfilerMarker DJPLMAJMBNK;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly ProfilerMarker IMPOGOLPGMF;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly ProfilerMarker DKJFIBNECGD;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly ProfilerMarker MPMEAJANOCC;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly ProfilerMarker BHAHHAIPFGK;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly ProfilerMarker MPOAIDFGJGD;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly ProfilerMarker MFDEPCEMIBM;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static readonly ProfilerMarker PKMGLHLEJCG;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly ProfilerMarker GMPBGGHLJIK;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly ProfilerMarker JMCDPGMDHIM;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly ProfilerMarker GEOCMPAMCDE;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly ProfilerMarker IHGFNEEPPID;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly ProfilerMarker INLEFFBAGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal readonly List<GAHBFAGALGI> AKAPGMCKHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal EMOHNCJKAII EAANPNCBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private readonly KPBNFJAGDEP BJEJMAIIKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal int CABOHJKCNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal int DKOOMJOHHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal bool LFJPEBJPENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal bool EPPALBIEMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal LHJDENOHLFO PIICEGLFPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal bool JCJAEIAEBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal float3 ANGDPEBADHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal float3 IJCCKIOLILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal float NKOIENEMBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int ACEOHGGIKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal int GIBOIKEEFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal float PJPDLCKNGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal float OLIDOFOBOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal int OGHDFONDGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal long JHLAAPNGCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public int OGGKDHCDIMI;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal const int AEDGPFKCFAN = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float[] KBJEGKCLAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal int[] FLCGHKLPONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal long[] IIBJIFCMKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public List<MDKBBMFNEGL> NPDOPMKNPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal NONOJJJJOHD POPKAIEEFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal long PDCDPLPKLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal int JGIAPOKHDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal float MKIOEFIHIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal NONOJJJJOHD.KCBJFHLHBFC CNLLCHCMNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal bool LGHLGHPJPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	internal PAMDOPCHMOH ICEOGHPHPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal JobHandle APEMJFHICMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal NativeList<EBEFJAKPHKO> BJENCFJDIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal NativeArray<long> EOFDHHGNJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal bool CCOPDEOPFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	internal JobHandle HOKPOLOMDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal NONOJJJJOHD CNHHNMJPNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	internal HNPDPDLCLDJ BDCHFLJGCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	internal NativeList<EBEFJAKPHKO> CHLNHPNDHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	internal Transform HDPOCIHNECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	internal PBEPDBDEIBA CIPBOJGOPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	internal long PEKNNBPODAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	internal long GKEJKGJAFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	internal long GADIEPJFNEC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<GAHBFAGALGI> CEKGKDGDFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal int GEMKIIKMKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C3C0", Offset = "0x7E5B1C0", VA = "0x187E5C3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7E60CB0", Offset = "0x7E5FAB0", VA = "0x187E60CB0")]
	internal void GJCGJAHOLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7E61AC0", Offset = "0x7E608C0", VA = "0x187E61AC0")]
	internal void IOKCNABLGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7E66090", Offset = "0x7E64E90", VA = "0x187E66090")]
	internal CLHOIMBKGBI(string IHGFMOMOADA, EMOHNCJKAII BOGJJGPKPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7E62870", Offset = "0x7E61670", VA = "0x187E62870")]
	internal void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7E5ECE0", Offset = "0x7E5DAE0", VA = "0x187E5ECE0")]
	internal void DFMPDALCBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7E60CC0", Offset = "0x7E5FAC0", VA = "0x187E60CC0")]
	internal void GNBMLOPAJID(GAHBFAGALGI BEHPIMAHFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F3E0", Offset = "0x7E5E1E0", VA = "0x187E5F3E0")]
	internal bool EAHMAFBDGCK(GAHBFAGALGI BEHPIMAHFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E5E0", Offset = "0x7E5D3E0", VA = "0x187E5E5E0")]
	internal bool CIMEKDDIMAF(GAHBFAGALGI BEHPIMAHFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7E60C20", Offset = "0x7E5FA20", VA = "0x187E60C20", Slot = "4")]
	internal virtual void GHGGEOCFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7E629C0", Offset = "0x7E617C0", VA = "0x187E629C0")]
	internal long MFEMIHJPMAG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7E60F00", Offset = "0x7E5FD00", VA = "0x187E60F00")]
	internal long HEMEGCBLEFN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7E5FFC0", Offset = "0x7E5EDC0", VA = "0x187E5FFC0")]
	internal bool FGCOFOEAPCN(Transform MGHHALJBECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F460", Offset = "0x7E5E260", VA = "0x187E5F460")]
	internal (bool, NONOJJJJOHD) FFDKCPINEHK(bool EHDJGDIMDPJ)
	{
		return default((bool, NONOJJJJOHD));
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E640", Offset = "0x7E5D440", VA = "0x187E5E640")]
	internal void CLDLDNIABKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C3E0", Offset = "0x7E5B1E0", VA = "0x187E5C3E0")]
	internal bool AFNHEHEJHBF(float4x4 JGDALGAMEBL, BatchedMeshRenderer GCMAKEFEJCA, bool ELLNPGBIAGF, bool KLANAOCBAKA, float NIABMFMGOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7E61DE0", Offset = "0x7E60BE0", VA = "0x187E61DE0")]
	public (bool, GNJKBDAPAAO) KJACNBAFCPO()
	{
		return default((bool, GNJKBDAPAAO));
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7E61990", Offset = "0x7E60790", VA = "0x187E61990")]
	internal void HFPPOBCOBHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7E62A80", Offset = "0x7E61880", VA = "0x187E62A80")]
	internal bool OEMLHGOKLHL(bool EHDJGDIMDPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7E62A70", Offset = "0x7E61870", VA = "0x187E62A70")]
	internal void MFJLHFHJJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7E61D80", Offset = "0x7E60B80", VA = "0x187E61D80")]
	internal void JPCMJAIENLJ(NONOJJJJOHD JIEGCDEFFGO, int OKFENPAFJJA, int PHAOHPFCOEO, float POHAOJGPJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E350", Offset = "0x7E5D150", VA = "0x187E5E350")]
	internal void CFINCIKLMAL(GNJKBDAPAAO HMPPBLDHOCP, int OKFENPAFJJA, int PHAOHPFCOEO, float POHAOJGPJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7E64C00", Offset = "0x7E63A00", VA = "0x187E64C00")]
	internal void PEFMLJIEAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7E5EF70", Offset = "0x7E5DD70", VA = "0x187E5EF70")]
	internal (long, long, int) DKLONFAEOGJ(float IMGDPDNJABP, float4x4 JGDALGAMEBL)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D830", Offset = "0x7E5C630", VA = "0x187E5D830")]
	internal void BCGDEOHOGMC(LHJDENOHLFO PNLIABINBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DC60", Offset = "0x7E5CA60", VA = "0x187E5DC60")]
	internal (float, float, float, float) BNDALCNGPBM(float AHPLLLBGDHF, float4x4 JGDALGAMEBL)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7E61C90", Offset = "0x7E60A90", VA = "0x187E61C90")]
	private float IPDFNGLLMDJ(float AHPLLLBGDHF, float4x4 JGDALGAMEBL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7E64740", Offset = "0x7E63540", VA = "0x187E64740")]
	private (int, int) PEDJMMCFDDL(float GMPAFIGJHLH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7E61A10", Offset = "0x7E60810", VA = "0x187E61A10")]
	internal static float HJBAGCJALIG(GAHBFAGALGI JIEGCDEFFGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7E638F0", Offset = "0x7E626F0", VA = "0x187E638F0")]
	internal void OOALJCMLAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7E61DB0", Offset = "0x7E60BB0", VA = "0x187E61DB0")]
	internal void KBFADIELPMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7E64FF0", Offset = "0x7E63DF0", VA = "0x187E64FF0")]
	internal void PJEOKLDCPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7E62130", Offset = "0x7E60F30", VA = "0x187E62130")]
	internal long KOOFNCAFJNB(long POGLDBGJLAC, int NELMGIEDHDP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7E62CF0", Offset = "0x7E61AF0", VA = "0x187E62CF0")]
	private void ONMEMMJJOGM(NONOJJJJOHD FAHDFLGEGCP, NativeList<EBEFJAKPHKO> FOOGMPGIBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D880", Offset = "0x7E5C680", VA = "0x187E5D880")]
	internal void BLMBNCMFGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7E65310", Offset = "0x7E64110", VA = "0x187E65310")]
	public static void PPJBCPDIGHO(NativeList<EBEFJAKPHKO> CAAHFBBHCLB, NONOJJJJOHD FAHDFLGEGCP, int HHMGDAPOKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7E61CF0", Offset = "0x7E60AF0", VA = "0x187E61CF0")]
	private float JDHHHIABDCJ(int JKPJNOIJECL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7E61020", Offset = "0x7E5FE20", VA = "0x187E61020")]
	internal void HEOCHFKBGEN(NONOJJJJOHD JIEGCDEFFGO, OKMIALHLADD HMPPBLDHOCP, int OKFENPAFJJA, int PHAOHPFCOEO, float POHAOJGPJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BurstCompile]
internal struct IFACIBBPBDO : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal struct OFECBNAKDDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int FGFFBJNBLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int PCIAAJKEFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int LMNHLHKKHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public float EKLPPOBPKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float LKIHBLNDFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public float OIIAKKKPOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public float MCNMCLEGDGH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	internal struct HNHAGHNKMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int FGFFBJNBLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int PCIAAJKEFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int LMNHLHKKHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int CJOJOHFPGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public float EKLPPOBPKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public float LKIHBLNDFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public float KNCBKCPENME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public float JEAMAMKOLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public float MCNMCLEGDGH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public struct PNAMBMOHOPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int CMGLOOKCGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int DCNLCLKHPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public float NFHPHFELAOG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public delegate void ONBJPOIBHCK(IFACIBBPBDO CPAKDPAHGHB, [In] OFECBNAKDDD BKLBILPNCAF);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class CFNKKHIHIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7E7CB60", Offset = "0x7E7B960", VA = "0x187E7CB60")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7E7CA00", Offset = "0x7E7B800", VA = "0x187E7CA00")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7E7CE80", Offset = "0x7E7BC80", VA = "0x187E7CE80")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7E7CC90", Offset = "0x7E7BA90", VA = "0x187E7CC90")]
		public static void HDKOJPGLKCE(IFACIBBPBDO CPAKDPAHGHB, [In] OFECBNAKDDD BKLBILPNCAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void KPECNHGLDBN(IFACIBBPBDO CPAKDPAHGHB, [In] HNHAGHNKMNE JHCNLOKIEDJ);

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal static class PCIBAEKNDBP
	{
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7E86DC0", Offset = "0x7E85BC0", VA = "0x187E86DC0")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7E86C60", Offset = "0x7E85A60", VA = "0x187E86C60")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7E870E0", Offset = "0x7E85EE0", VA = "0x187E870E0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E86EF0", Offset = "0x7E85CF0", VA = "0x187E86EF0")]
		public static void HDKOJPGLKCE(IFACIBBPBDO CPAKDPAHGHB, [In] HNHAGHNKMNE JHCNLOKIEDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public unsafe delegate void CODPMDEAJEO(UnsafeList<int>* FNHIBMLECJC, UnsafeList<float3>* EAAEPPNPHOF, [NoAlias] float3* PKDDILEOIDC, [NoAlias] float4* EMBIGJAAIKF, [NoAlias] float2* IOGGLOIIPFB, [NoAlias] float4* OMMOJALPIGN, UnsafeList<MFNGBOEOHGO>* LJABNIGNPHE, UnsafeList<int>* EPFMBJPBCLF, UnsafeList<float3>* KDIGIAMDPHJ, [NoAlias] float3* BCDHCBABOPO, [NoAlias] float4* FCHFOCFJFBE, [NoAlias] float2* HJEMBLGMIEG, [NoAlias] float4* NEOAMAKFPPG, int JNCGHNJOHFD, int JDEAPLOGHMI);

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal static class MPGNFBIPKJC
	{
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E82D60", Offset = "0x7E81B60", VA = "0x187E82D60")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E82C00", Offset = "0x7E81A00", VA = "0x187E82C00")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E831D0", Offset = "0x7E81FD0", VA = "0x187E831D0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E82E90", Offset = "0x7E81C90", VA = "0x187E82E90")]
		public unsafe static void HDKOJPGLKCE(UnsafeList<int>* FNHIBMLECJC, UnsafeList<float3>* EAAEPPNPHOF, [NoAlias] float3* PKDDILEOIDC, [NoAlias] float4* EMBIGJAAIKF, [NoAlias] float2* IOGGLOIIPFB, [NoAlias] float4* OMMOJALPIGN, UnsafeList<MFNGBOEOHGO>* LJABNIGNPHE, UnsafeList<int>* EPFMBJPBCLF, UnsafeList<float3>* KDIGIAMDPHJ, [NoAlias] float3* BCDHCBABOPO, [NoAlias] float4* FCHFOCFJFBE, [NoAlias] float2* HJEMBLGMIEG, [NoAlias] float4* NEOAMAKFPPG, int JNCGHNJOHFD, int JDEAPLOGHMI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public float3 GOGNJCMDOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public float MPNKOHCMCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public float IFIIALPMFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public float FOJECCHGKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public JACOPDBFINC.CCGEMCAHKAI DJBPPGKGNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public bool JEHIFOBPBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<MFNGBOEOHGO>* LJABNIGNPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* EPFMBJPBCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<OFECBNAKDDD>* GGDMOONMKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<OFECBNAKDDD>* AJOFNLCEFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<HNHAGHNKMNE>* IBHKFOEDCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<HNHAGHNKMNE>* PFAKIIDFPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public int HANHMCEIIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public int ACIAGADNJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public int MFKPGCJABPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe float3* KDIGIAMDPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe int* AMLLJNGMGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe PNAMBMOHOPI* NPDCNNDIODA;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x7E6D670", Offset = "0x7E6C470", VA = "0x187E6D670")]
	private static float JPEEPKPANIK([In] IFACIBBPBDO CPAKDPAHGHB, [In] float3 APCEONMJNKP, float MCNMCLEGDGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7E6D450", Offset = "0x7E6C250", VA = "0x187E6D450")]
	private static int DPJJKEHPONB(IFACIBBPBDO CPAKDPAHGHB, [Out] MFNGBOEOHGO GIHLPKONIIC, [In] MFNGBOEOHGO CAEKLLPGBJO, [In] MFNGBOEOHGO EMEJLBFLOCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7E6CC80", Offset = "0x7E6BA80", VA = "0x187E6CC80")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void BDCCDCDFACM(IFACIBBPBDO CPAKDPAHGHB, [In] OFECBNAKDDD BKLBILPNCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6CCE0", Offset = "0x7E6BAE0", VA = "0x187E6CCE0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void DHFBHDPODBG(IFACIBBPBDO CPAKDPAHGHB, [In] HNHAGHNKMNE JHCNLOKIEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7E6D5D0", Offset = "0x7E6C3D0", VA = "0x187E6D5D0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6D6F0", Offset = "0x7E6C4F0", VA = "0x187E6D6F0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal void NHOIJGCIAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6D5E0", Offset = "0x7E6C3E0", VA = "0x187E6D5E0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void FPHLHEDIEBN(UnsafeList<int>* FNHIBMLECJC, UnsafeList<float3>* EAAEPPNPHOF, [NoAlias] float3* PKDDILEOIDC, [NoAlias] float4* EMBIGJAAIKF, [NoAlias] float2* IOGGLOIIPFB, [NoAlias] float4* OMMOJALPIGN, UnsafeList<MFNGBOEOHGO>* LJABNIGNPHE, UnsafeList<int>* EPFMBJPBCLF, UnsafeList<float3>* KDIGIAMDPHJ, [NoAlias] float3* BCDHCBABOPO, [NoAlias] float4* FCHFOCFJFBE, [NoAlias] float2* HJEMBLGMIEG, [NoAlias] float4* NEOAMAKFPPG, int JNCGHNJOHFD, int JDEAPLOGHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7E6EC30", Offset = "0x7E6DA30", VA = "0x187E6EC30")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void PDNFEHNOODE(IFACIBBPBDO CPAKDPAHGHB, [In] OFECBNAKDDD BKLBILPNCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7E6E420", Offset = "0x7E6D220", VA = "0x187E6E420")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void PDBOMABPFLJ(IFACIBBPBDO CPAKDPAHGHB, [In] HNHAGHNKMNE JHCNLOKIEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7E6CD40", Offset = "0x7E6BB40", VA = "0x187E6CD40")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void DIDDNFKKCKD(UnsafeList<int>* FNHIBMLECJC, UnsafeList<float3>* EAAEPPNPHOF, [NoAlias] float3* PKDDILEOIDC, [NoAlias] float4* EMBIGJAAIKF, [NoAlias] float2* IOGGLOIIPFB, [NoAlias] float4* OMMOJALPIGN, UnsafeList<MFNGBOEOHGO>* LJABNIGNPHE, UnsafeList<int>* EPFMBJPBCLF, UnsafeList<float3>* KDIGIAMDPHJ, [NoAlias] float3* BCDHCBABOPO, [NoAlias] float4* FCHFOCFJFBE, [NoAlias] float2* HJEMBLGMIEG, [NoAlias] float4* NEOAMAKFPPG, int JNCGHNJOHFD, int JDEAPLOGHMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class PKJKAMKIEAF
{
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly ProfilerMarker MDHCBEFPLIE;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public const int OIPPCCPBCFF = 2;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private const int ILECOBDACDK = 1;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private static int HOFABDFPKBI;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private static Stack<PKJKAMKIEAF> DPFOINMCBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private NONOJJJJOHD DHCNCDEFBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private NativeList<MFNGBOEOHGO> LJABNIGNPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private NativeList<int> EPFMBJPBCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private NativeList<IFACIBBPBDO.OFECBNAKDDD> GGDMOONMKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private NativeList<IFACIBBPBDO.OFECBNAKDDD> AJOFNLCEFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private NativeList<IFACIBBPBDO.HNHAGHNKMNE> IBHKFOEDCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private NativeList<IFACIBBPBDO.HNHAGHNKMNE> PFAKIIDFPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private IFACIBBPBDO CPAKDPAHGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private JobHandle JAAMMEMKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private IFACIBBPBDO.PNAMBMOHOPI BGALOMMCODF;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private const int MFKPGCJABPC = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E882C0", Offset = "0x7E870C0", VA = "0x187E882C0")]
	private PKJKAMKIEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E87A10", Offset = "0x7E86810", VA = "0x187E87A10")]
	public void KEACIPDIJFL(NONOJJJJOHD KAHKIOENOMF, float3 DAKMADPNDIN, float ECCNPOIHAGN, float GDGLNBABCNJ, float BAFOFHOOIIF, List<CLHOIMBKGBI.EBEFJAKPHKO> EFKGPFHNCLK, Allocator NHLPIJAGJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E87360", Offset = "0x7E86160", VA = "0x187E87360")]
	public (bool, NONOJJJJOHD, float) JJGIHLNCPBD(List<CLHOIMBKGBI.EBEFJAKPHKO> EFKGPFHNCLK, Allocator NHLPIJAGJIL, bool EHDJGDIMDPJ)
	{
		return default((bool, NONOJJJJOHD, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E87300", Offset = "0x7E86100", VA = "0x187E87300")]
	public static bool EJFAPDAKHCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E879A0", Offset = "0x7E867A0", VA = "0x187E879A0")]
	public static int JPBOKGELFPA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E87FD0", Offset = "0x7E86DD0", VA = "0x187E87FD0")]
	public static PKJKAMKIEAF MLCLOMIOHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E88130", Offset = "0x7E86F30", VA = "0x187E88130")]
	internal static void PONOGEDLELK(PKJKAMKIEAF ODBJPHKEDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E87190", Offset = "0x7E85F90", VA = "0x187E87190")]
	public static void DBLBKAHLGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E87E20", Offset = "0x7E86C20", VA = "0x187E87E20")]
	[OHEKCAPHOOO(LHBMPOBGEAI.ExitingPlayMode, 0)]
	public static void LEOIPKKBJIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BurstCompile]
internal struct MFNGBOEOHGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public float3 HAMOKFILEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public int BAFONDLNCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public int JACJDPCJHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public int DJEKIAKKJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public float GCBAIHCLLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public float OAKCEPNCGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public int MFENAHCHDBD;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E828C0", Offset = "0x7E816C0", VA = "0x187E828C0")]
	public static void BHEMCOAOOEF([Out] MFNGBOEOHGO BPINCJLADGC, int OJCDFAMCBBJ, [In] float3 IGAAAABDJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E82910", Offset = "0x7E81710", VA = "0x187E82910")]
	[IgnoreWarning(1371)]
	public static void BHEMCOAOOEF([Out] MFNGBOEOHGO BPINCJLADGC, [In] MFNGBOEOHGO IGCCFPDANIF, [In] MFNGBOEOHGO GDBJOGNPNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BurstCompile]
internal struct PAMDOPCHMOH : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct LIGLGKNGIPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int EHCGNPIPBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int FJFJCNDBMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int MKPBAGCFKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int EFELICIMACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int CBLPJHANPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int IHDHNFOHLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int FGFALLFPJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public int PJCBKPLFMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public float ACFJIEDOENK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private struct HPJGEIGPFEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public JACOPDBFINC.NLNOHFKHNON AKKIJGJJLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public float PKMLGFOOADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public float MGEKHDBLPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public float HNGLFCJDFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public float EKFEDAOJDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public float MPLPBNBJNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public float PCICFOBJLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public float GLHCDNACOJO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private struct GPDOIJLBACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public NativeArray<float3> GFKNFMMCGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public NativeArray<float3> PJBBHJCMOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public NativeArray<float4> BEIEKBIGJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeArray<float4> KMGGHGJHKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public NativeArray<float2> PJNIHDBBALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public NativeArray<int> EOGOOIEPPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public bool IOCGAOLKFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int GEMKIIKMKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public int LHHALMFLOOI;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E7DB90", Offset = "0x7E7C990", VA = "0x187E7DB90")]
		public void DFOACHHADOO(int JDEAPLOGHMI, int JNCGHNJOHFD, Allocator LNMGNHHGHLL, bool BHDJMMKCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E7DE30", Offset = "0x7E7CC30", VA = "0x187E7DE30")]
		public static GPDOIJLBACO MLIBAKOGDMG(NONOJJJJOHD KHJEADFMOJM)
		{
			return default(GPDOIJLBACO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E7DD70", Offset = "0x7E7CB70", VA = "0x187E7DD70")]
		public void LNJEMOCDJGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private static readonly ProfilerMarker PGFDLCLLACL;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private static readonly ProfilerMarker GEEEHJCOJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<LIGLGKNGIPH> MJLHKNHCHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private GPDOIJLBACO FKAIANLFFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private GPDOIJLBACO FAHDFLGEGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private float3 GAKHGFEHLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private float3 BKDAAJLNIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private HPJGEIGPFEG INDCPAJFNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* CHLOAKEGPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private NativeArray<CLHOIMBKGBI.EBEFJAKPHKO> JMGPMGHJPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NativeList<CLHOIMBKGBI.EBEFJAKPHKO> HIEJLCPKAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NativeArray<int> EPFMBJPBCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NativeArray<bool> DLNPIPBKBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private NativeArray<int> KIDNPOECJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private NativeArray<int> CIPNOOMKPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private NativeArray<float> LDGOEBECDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private NativeArray<int> HCNFCPAEPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private NativeArray<float> IPFNDDPKCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private NativeArray<int> OLBPGJBDDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private NativeArray<int> GFDMLNGMICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private NativeArray<float> OMFFPHCNAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private NativeArray<float> LEGMBHEEGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private NativeArray<int> MBEHGLCCJFE;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E86390", Offset = "0x7E85190", VA = "0x187E86390")]
	public PAMDOPCHMOH([In] List<CLHOIMBKGBI.MDKBBMFNEGL> EFMLIFKALEA, NativeList<CLHOIMBKGBI.EBEFJAKPHKO> HNBMBFEMOHB, [In] NONOJJJJOHD OBODKELMFNC, [In] NativeList<CLHOIMBKGBI.EBEFJAKPHKO> FOOGMPGIBBG, [In] NativeArray<long> EOFDHHGNJCI, float3 IOALCCPILLP, float3 PEPDLLGAFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E836A0", Offset = "0x7E824A0", VA = "0x187E836A0")]
	public static long HDEEKFKJLIP(int JDEAPLOGHMI, int JNCGHNJOHFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E83330", Offset = "0x7E82130", VA = "0x187E83330", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E85050", Offset = "0x7E83E50", VA = "0x187E85050")]
	public void KFLAIJLGEOL(List<CLHOIMBKGBI.MDKBBMFNEGL> NMGHNNBOAGN, [In] CLHOIMBKGBI OLLGGKABCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E836C0", Offset = "0x7E824C0", VA = "0x187E836C0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool HLHPDHJAEHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E84E20", Offset = "0x7E83C20", VA = "0x187E84E20")]
	private GNJKBDAPAAO KCFKPFNMFLK(int CPPCGLOAEPD, Allocator LNMGNHHGHLL)
	{
		return default(GNJKBDAPAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E836E0", Offset = "0x7E824E0", VA = "0x187E836E0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void INLGMEKCFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E85C80", Offset = "0x7E84A80", VA = "0x187E85C80")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float NIAPCPLNGPP(int ABCFDGEFFAM, int JOEOANHDKJE, bool GJPMBBKLPNG, bool IOHMCDFPGNE, float LPNKBCANIJD, float NBFMBOGBNFD, float IBJDAPOOIJM, float PNELBMIHOAE, float ANANKFHIHDH, float KJMDKACCFBD, float FNAMADKDADI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E83380", Offset = "0x7E82180", VA = "0x187E83380")]
	[IgnoreWarning(1371)]
	private LIGLGKNGIPH FOLIIGBPNHP([In] LIGLGKNGIPH FAKKKBPCDED, int MFJGLCGEOHA, [In] NativeArray<int> PECKHJOFPCH, [In] NativeArray<bool> DLNPIPBKBHL, NativeArray<int> KIDNPOECJPG)
	{
		return default(LIGLGKNGIPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E85AA0", Offset = "0x7E848A0", VA = "0x187E85AA0")]
	public static int LJPHHMAAGHI(NativeArray<int> PECKHJOFPCH, NativeArray<int> MBEHGLCCJFE, int NMMDANADJNB, int IBFJAIADDLH, int HNOEGDHAFOB)
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
		private struct IKELKNBNLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public long JOHBNEKPGEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public GEDLKILBCJI ECBLDOPKHPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public GAHBFAGALGI JIEGCDEFFGO;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7E7E080", Offset = "0x7E7CE80", VA = "0x187E7E080")]
			public IKELKNBNLPE(GEDLKILBCJI KNFAHDJCBKK, GAHBFAGALGI BNPOFFHJGDJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		private class OKNPAFBIMEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public GEDLKILBCJI ECBLDOPKHPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public int GFBHKKJANIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public float NKOIENEMBNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public List<IKELKNBNLPE> LPILIBFAFBD;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x7E83280", Offset = "0x7E82080", VA = "0x187E83280")]
			public OKNPAFBIMEF(GEDLKILBCJI KNFAHDJCBKK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private static readonly ProfilerMarker NBGGCJMIKDP;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private static readonly ProfilerMarker NEPBJIKGPJD;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private static readonly ProfilerMarker FHIGBDKEIKJ;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private static readonly ProfilerMarker JCBNOANJBFI;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private static readonly ProfilerMarker OAMAKKAOBAG;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly ProfilerMarker FPANFJJJKAK;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker BAMDHMMMPJG;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		internal const int LIOEHMLGPBM = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		internal static Dictionary<Material, List<Material>> AIENEGDPAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Dictionary<Material, List<EMOHNCJKAII>> ONLKCGMBLAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		internal List<EMOHNCJKAII> KOBNBCJBAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private List<MeshRenderer> HAOHALOPCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private Transform DDLGHMMPBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private bool AJMEKGGELBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private bool OENDLBLJDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private int DLNGCAJJMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private EMOHNCJKAII ELGGMDOPFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private Material LLCEHKGBBHC;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static bool? GONPHHNLFJP;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private const int ODKEOADGKPI = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private static List<IKELKNBNLPE> EAJAIFPEBCP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<MeshRenderer> EJJBKJMOPAA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int BEMHFCEFKCE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7E7C9B0", Offset = "0x7E7B7B0", VA = "0x187E7C9B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private static bool EMOPMDPDBDK
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7E76E40", Offset = "0x7E75C40", VA = "0x187E76E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		private static void OHPBLIBIGLI(bool LEDDKLJEFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		private static void OHPBLIBIGLI(bool LEDDKLJEFNK, string NJJDPBHNDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		private static void DOLBNIPBGGH(string IHGFMOMOADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E76910", Offset = "0x7E75710", VA = "0x187E76910")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E77E90", Offset = "0x7E76C90", VA = "0x187E77E90")]
		internal bool KOGPMNENCGO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E78B20", Offset = "0x7E77920", VA = "0x187E78B20")]
		private Transform NHGDDGBDMHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E793D0", Offset = "0x7E781D0", VA = "0x187E793D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E771D0", Offset = "0x7E75FD0", VA = "0x187E771D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E766F0", Offset = "0x7E754F0", VA = "0x187E766F0")]
		public EMOHNCJKAII AddToBatchedMesh(GAHBFAGALGI GNIAEPEGGNN, Material EFCBJICGDPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E7C470", Offset = "0x7E7B270", VA = "0x187E7C470")]
		public void RemoveFromBatchedMesh(GAHBFAGALGI JIEGCDEFFGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E770A0", Offset = "0x7E75EA0", VA = "0x187E770A0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E775E0", Offset = "0x7E763E0", VA = "0x187E775E0")]
		private void EEEPNHKNGMD(Renderer NHLDFAAJMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E77E20", Offset = "0x7E76C20", VA = "0x187E77E20")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E77E10", Offset = "0x7E76C10", VA = "0x187E77E10")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E77EF0", Offset = "0x7E76CF0", VA = "0x187E77EF0")]
		private void LGLEBBFMJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E785C0", Offset = "0x7E773C0", VA = "0x187E785C0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E76C20", Offset = "0x7E75A20", VA = "0x187E76C20")]
		private EMOHNCJKAII CHCGCOKBEJO(GAHBFAGALGI JIEGCDEFFGO, Material EFCBJICGDPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E76940", Offset = "0x7E75740", VA = "0x187E76940")]
		private EMOHNCJKAII BNFPFKAIEIF(Material EFCBJICGDPB, int GDJJMBLMHIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E78BA0", Offset = "0x7E779A0", VA = "0x187E78BA0")]
		private EMOHNCJKAII NPCHIFIDBLB(Material EFCBJICGDPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7E76650", Offset = "0x7E75450", VA = "0x187E76650")]
		internal float4x4 ACOPJJDKNNK()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E77660", Offset = "0x7E76460", VA = "0x187E77660")]
		public static List<Material> GenerateVertexFormatVariants(Material EFCBJICGDPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x13833C0", Offset = "0x13821C0", VA = "0x1813833C0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7E78460", Offset = "0x7E77260", VA = "0x187E78460")]
		public void MarkDirty(GAHBFAGALGI JIEGCDEFFGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E76550", Offset = "0x7E75350", VA = "0x187E76550")]
		[Conditional("CHECK_STATE")]
		private void AAOPCEFCFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E78740", Offset = "0x7E77540", VA = "0x187E78740")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float IMGDPDNJABP)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E76F70", Offset = "0x7E75D70", VA = "0x187E76F70")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E7B2D0", Offset = "0x7E7A0D0", VA = "0x187E7B2D0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E77780", Offset = "0x7E76580", VA = "0x187E77780")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7E794C0", Offset = "0x7E782C0", VA = "0x187E794C0")]
		public void RebatchOptimally(int FCHPELDAHJH, int DENIJJPEDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E793E0", Offset = "0x7E781E0", VA = "0x187E793E0")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E7C880", Offset = "0x7E7B680", VA = "0x187E7C880")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class IKKEMIENKAA
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct KJEKCDKDGBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public BatchedMeshRenderer NHLDFAAJMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public EMOHNCJKAII JIEGCDEFFGO;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1A5E290", Offset = "0x1A5D090", VA = "0x181A5E290")]
		public void EIEBKEDCELH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct KJFGGNJLAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public float IMCKIOLCNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public EMOHNCJKAII LENGHJILEPI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class LODOJMNKOLD : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x1173110", Offset = "0x1171F10", VA = "0x181173110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E82750", Offset = "0x7E81550", VA = "0x187E82750", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x12F1100", Offset = "0x12EFF00", VA = "0x1812F1100")]
		[DebuggerHidden]
		public LODOJMNKOLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7E827A0", Offset = "0x7E815A0", VA = "0x187E827A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7E81770", Offset = "0x7E80570", VA = "0x187E81770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7E82600", Offset = "0x7E81400", VA = "0x187E82600")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7E81720", Offset = "0x7E80520", VA = "0x187E81720")]
		private void IMLDEFFNBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7E82700", Offset = "0x7E81500", VA = "0x187E82700", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7E82650", Offset = "0x7E81450", VA = "0x187E82650", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7E82650", Offset = "0x7E81450", VA = "0x187E82650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private static readonly ProfilerMarker FPANFJJJKAK;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly ProfilerMarker JLAIEABGIAC;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly ProfilerMarker NDFLEEMGCFE;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private static readonly ProfilerMarker LPNMGLJCAIL;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static float3 PGJKCJLPFLF;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static int PKJAPCLAMML;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static int PAFCBIHGPGI;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static int GAOJGJIOKCE;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static int MPPPCOBEONK;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static int OILLMGJPALD;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static float GHJKAONGPCJ;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static float FLFALCGLCAN;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static float MEDFJDJNLGP;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static float PCBKAECJCLP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static float EPKHMLDMFJE;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static float OKDJIBCIKGG;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static float JMPOJIAFNLG;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static float ICNACDMNOAL;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private static List<BatchedMeshRenderer> OBIIDKONJJH;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private static Stack<NONOJJJJOHD> BKLIPNEGCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static Stack<HNPDPDLCLDJ> FKPEJCFIPAH;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static GDJLPLLNOFP CJGOHNIPOAJ;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private static KJEKCDKDGBG FNNBBEHDDDD;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static int DOPAPIIEOAD;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void OHPBLIBIGLI(bool LEDDKLJEFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void CLCEOLMCJAA(bool LEDDKLJEFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void OHPBLIBIGLI(bool LEDDKLJEFNK, string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F850", Offset = "0x7E7E650", VA = "0x187E7F850")]
	public static void HLJFBNEKAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E80620", Offset = "0x7E7F420", VA = "0x187E80620")]
	public static void LOFMDJAEJMF(BatchedMeshRenderer LLDAMCONGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E7E970", Offset = "0x7E7D770", VA = "0x187E7E970")]
	public static void AJIOPAMOAIF(BatchedMeshRenderer LLDAMCONGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E80760", Offset = "0x7E7F560", VA = "0x187E80760")]
	public static void NCEPOFEBOHB(GAHBFAGALGI BEHPIMAHFNO, bool JBMENNDDDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F8D0", Offset = "0x7E7E6D0", VA = "0x187E7F8D0")]
	public static void IIHPIBJEPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7E7E0B0", Offset = "0x7E7CEB0", VA = "0x187E7E0B0")]
	public static void AFNHEHEJHBF(float IMGDPDNJABP, bool NBEFDJDDFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EED0", Offset = "0x7E7DCD0", VA = "0x187E7EED0")]
	private static void CNBCMHPGDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7E7FC50", Offset = "0x7E7EA50", VA = "0x187E7FC50")]
	public static long KOOFNCAFJNB(int NELMGIEDHDP, long POGLDBGJLAC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F5B0", Offset = "0x7E7E3B0", VA = "0x187E7F5B0")]
	public static (long, long, int) DKLONFAEOGJ(float IMGDPDNJABP)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F7C0", Offset = "0x7E7E5C0", VA = "0x187E7F7C0")]
	[IteratorStateMachine(typeof(LODOJMNKOLD))]
	public static IEnumerable<bool> FAEMBMCDPAO(long GHCKIDCFJBN, bool APPCHCGMLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EC20", Offset = "0x7E7DA20", VA = "0x187E7EC20")]
	public static void CBLJOELKEAN(long GHCKIDCFJBN, bool APPCHCGMLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7E80EF0", Offset = "0x7E7FCF0", VA = "0x187E80EF0")]
	public static int PDMIMACCAEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EAA0", Offset = "0x7E7D8A0", VA = "0x187E7EAA0")]
	internal static NONOJJJJOHD BLKPNBHLEGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E81250", Offset = "0x7E80050", VA = "0x187E81250")]
	internal static void PONOGEDLELK(NONOJJJJOHD FENHOBLEBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7E81070", Offset = "0x7E7FE70", VA = "0x187E81070")]
	internal static HNPDPDLCLDJ PNEEDLOOINB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7E811C0", Offset = "0x7E7FFC0", VA = "0x187E811C0")]
	internal static void PONOGEDLELK(HNPDPDLCLDJ HGPPEIKEKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F3D0", Offset = "0x7E7E1D0", VA = "0x187E7F3D0")]
	public static void DBLBKAHLGDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class ELIMNJENEJG<KeyType> : EMOHNCJKAII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly Dictionary<KeyType, GAHBFAGALGI> JNNBGHJOKNC;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x46110A0", Offset = "0x460FEA0", VA = "0x1846110A0")]
	public ELIMNJENEJG(string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4610BB0", Offset = "0x460F9B0", VA = "0x184610BB0")]
	public void GNBMLOPAJID(KeyType MAKJJJECHHB, GAHBFAGALGI BEHPIMAHFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4610D10", Offset = "0x460FB10", VA = "0x184610D10")]
	public bool IHHMNDJKDFJ(KeyType MAKJJJECHHB, GAHBFAGALGI DCCEFAEKCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4610E00", Offset = "0x460FC00", VA = "0x184610E00")]
	public void NCFFFLDCOAO(KeyType MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4610B50", Offset = "0x460F950", VA = "0x184610B50", Slot = "4")]
	public override void GHGGEOCFEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class ELKIOGDBMJC
{
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly ProfilerCategory EOGBIGNGGDK;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	internal static readonly ProfilerMarker IJOEAPIHADL;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	internal static readonly LJJLJNIKDGF AFNHEHEJHBF;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly KCCNKDELGKM<float> BLNOPDCJOIH;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly KCCNKDELGKM<float> DAJMIDKOMCM;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly KCCNKDELGKM<double> GJDFIJGGGOA;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private static readonly KCCNKDELGKM<double> GLCFHFFDIDE;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly KCCNKDELGKM<double> KKGBLJJKCEO;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private static readonly KCCNKDELGKM<int> FLBJKFNLBAN;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly KCCNKDELGKM<int> OBFEJEKFMLG;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly KCCNKDELGKM<int> EDGCLBEMOIB;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly KCCNKDELGKM<int> KMEBNGOEMBE;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private static readonly KCCNKDELGKM<int> DMEEDKNKCGA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly KCCNKDELGKM<long> MGLLPKOAJOO;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private static readonly KCCNKDELGKM<long> IMFMIHKLCLK;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private static readonly KCCNKDELGKM<long> FBEECLCJOBP;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private static readonly KCCNKDELGKM<long> JKHLOJAFHMK;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private static readonly KCCNKDELGKM<long> GKHLNMOBNAM;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D0F0", Offset = "0x7E7BEF0", VA = "0x187E7D0F0")]
	public static void AMOLOLKFCLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7E88460", Offset = "0x7E87260", VA = "0x187E88460")]
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
