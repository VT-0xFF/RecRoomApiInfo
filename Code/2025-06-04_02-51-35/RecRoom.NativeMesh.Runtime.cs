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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8040A40", Offset = "0x803F240", VA = "0x188040A40", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class FNIBIDCBMFO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly BMELPJIFPCL NIPBMCBMFPM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly BMELPJIFPCL AIGDAAFMCMI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly BMELPJIFPCL NEMFMBPCFCM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly BMELPJIFPCL DOBMAIHMOAE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly BMELPJIFPCL LBAAIJMBELF;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class EALNNBFFPDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public BMIINENNNOF LMNKBMBBAAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GDOBIAAONDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public EALNNBFFPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct BMIINENNNOF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NFKALPLNGCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half OMMMPKADJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort GECEFCNADDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte CNEMLEJHBIL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void CIBANDHKLGF([NoAlias] float3* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class FMMKAGNGHKL
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8032C00", Offset = "0x8031400", VA = "0x188032C00")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8032FE0", Offset = "0x80317E0", VA = "0x188032FE0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8032F40", Offset = "0x8031740", VA = "0x188032F40")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8032D20", Offset = "0x8031520", VA = "0x188032D20")]
		public unsafe static void DMJBMMIBENB([NoAlias] float3* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void KAJIFHPFPEF([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class OEHCDDBGBNI
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8044290", Offset = "0x8042A90", VA = "0x188044290")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80446F0", Offset = "0x8042EF0", VA = "0x1880446F0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8044650", Offset = "0x8042E50", VA = "0x188044650")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x80443B0", Offset = "0x8042BB0", VA = "0x1880443B0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void KMPFEOMFEEH([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class NBJABEMLFEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8042050", Offset = "0x8040850", VA = "0x188042050")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x80424B0", Offset = "0x8040CB0", VA = "0x1880424B0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8042410", Offset = "0x8040C10", VA = "0x188042410")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8042170", Offset = "0x8040970", VA = "0x188042170")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void FINGLGMFDBA([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class HIANNHCEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x80356F0", Offset = "0x8033EF0", VA = "0x1880356F0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8035B50", Offset = "0x8034350", VA = "0x188035B50")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8035AB0", Offset = "0x80342B0", VA = "0x188035AB0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8035810", Offset = "0x8034010", VA = "0x188035810")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void LBBBMOMKKKG([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class AJODLKCCPNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8023FE0", Offset = "0x80227E0", VA = "0x188023FE0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8024440", Offset = "0x8022C40", VA = "0x188024440")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80243A0", Offset = "0x8022BA0", VA = "0x1880243A0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8024100", Offset = "0x8022900", VA = "0x188024100")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void DNBKDJHFOPG([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class MJHGJMLIKDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8041A10", Offset = "0x8040210", VA = "0x188041A10")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8041F00", Offset = "0x8040700", VA = "0x188041F00")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8041E60", Offset = "0x8040660", VA = "0x188041E60")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8041B30", Offset = "0x8040330", VA = "0x188041B30")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void FCKGKDAOJDJ([NoAlias] ushort* LGPDHMFNAAB, [Out] float3 BLOGJGENBKI, [Out] float3 LJJBKBPMFGE, [In][NoAlias] float3* LJBMLLPNDDK, int IIANICAFCPH, int FJNBBBLENEH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class AHCCLGCBIDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8023AA0", Offset = "0x80222A0", VA = "0x188023AA0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8023E90", Offset = "0x8022690", VA = "0x188023E90")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8023DF0", Offset = "0x80225F0", VA = "0x188023DF0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8023BC0", Offset = "0x80223C0", VA = "0x188023BC0")]
		public unsafe static void DMJBMMIBENB([NoAlias] ushort* LGPDHMFNAAB, [Out] float3 BLOGJGENBKI, [Out] float3 LJJBKBPMFGE, [In][NoAlias] float3* LJBMLLPNDDK, int IIANICAFCPH, int FJNBBBLENEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void DPEHGLGEDGN([NoAlias] ushort* LNIHJBKIDLL, [In][NoAlias] float3* GHAMOBMIBHP, int FJNBBBLENEH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class OGEAMGANCAK
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8044840", Offset = "0x8043040", VA = "0x188044840")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8044C00", Offset = "0x8043400", VA = "0x188044C00")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8044B60", Offset = "0x8043360", VA = "0x188044B60")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8044960", Offset = "0x8043160", VA = "0x188044960")]
		public unsafe static void DMJBMMIBENB([NoAlias] ushort* LNIHJBKIDLL, [In][NoAlias] float3* GHAMOBMIBHP, int FJNBBBLENEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void OBPDDAEGEII([NoAlias] float3* DLENGFOJBOD, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class FBIGHDMEOCM
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x80319C0", Offset = "0x80301C0", VA = "0x1880319C0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8031D80", Offset = "0x8030580", VA = "0x188031D80")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8031CE0", Offset = "0x80304E0", VA = "0x188031CE0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8031AE0", Offset = "0x80302E0", VA = "0x188031AE0")]
		public unsafe static void DMJBMMIBENB([NoAlias] float3* DLENGFOJBOD, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void IBJNOPJBAIH([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class AKNKGJEJNLD
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8024590", Offset = "0x8022D90", VA = "0x188024590")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8024950", Offset = "0x8023150", VA = "0x188024950")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x80248B0", Offset = "0x80230B0", VA = "0x1880248B0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x80246B0", Offset = "0x8022EB0", VA = "0x1880246B0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void LFMAOEIJJHG([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class FCNEMDINOAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8031FD0", Offset = "0x80307D0", VA = "0x188031FD0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8032480", Offset = "0x8030C80", VA = "0x188032480")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x80323E0", Offset = "0x8030BE0", VA = "0x1880323E0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80320F0", Offset = "0x80308F0", VA = "0x1880320F0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void HCJNPFBIIKB([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class JOIOILALIAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8037C80", Offset = "0x8036480", VA = "0x188037C80")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8038130", Offset = "0x8036930", VA = "0x188038130")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8038090", Offset = "0x8036890", VA = "0x188038090")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8037DA0", Offset = "0x80365A0", VA = "0x188037DA0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void GHKMJKONLFK([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class HLAPMHFFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8035CA0", Offset = "0x80344A0", VA = "0x188035CA0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8036180", Offset = "0x8034980", VA = "0x188036180")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x80360E0", Offset = "0x80348E0", VA = "0x1880360E0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8035DC0", Offset = "0x80345C0", VA = "0x188035DC0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void APIPODDNLFN([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class HCLLPNGEPAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8034A00", Offset = "0x8033200", VA = "0x188034A00")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8034EE0", Offset = "0x80336E0", VA = "0x188034EE0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8034E40", Offset = "0x8033640", VA = "0x188034E40")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8034B20", Offset = "0x8033320", VA = "0x188034B20")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void NAMMPECHJBL([NoAlias] uint* AIGKIBLMMDK, [Out] float2 CDNDBJBAJDI, [Out] float2 BJBPNGPOJFB, [In][NoAlias] float2* ECBFJHOMBFE, int IIANICAFCPH, int FJNBBBLENEH);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class OEALKPJFJNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8043820", Offset = "0x8042020", VA = "0x188043820")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8043C10", Offset = "0x8042410", VA = "0x188043C10")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8043B70", Offset = "0x8042370", VA = "0x188043B70")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8043940", Offset = "0x8042140", VA = "0x188043940")]
		public unsafe static void DMJBMMIBENB([NoAlias] uint* AIGKIBLMMDK, [Out] float2 CDNDBJBAJDI, [Out] float2 BJBPNGPOJFB, [In][NoAlias] float2* ECBFJHOMBFE, int IIANICAFCPH, int FJNBBBLENEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void DAJCGCPPJHJ([Out] float2 KEHDKFJPKHP, uint BAIGLMEDELP, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class OBJHEIMKBCP
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x80432C0", Offset = "0x8041AC0", VA = "0x1880432C0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x80436D0", Offset = "0x8041ED0", VA = "0x1880436D0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8043630", Offset = "0x8041E30", VA = "0x188043630")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x80433E0", Offset = "0x8041BE0", VA = "0x1880433E0")]
		public static void DMJBMMIBENB([Out] float2 KEHDKFJPKHP, uint BAIGLMEDELP, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void JEGEHBPIMFM([NoAlias] float2* AIGKIBLMMDK, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class LMIJBCJOOBG
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x803FF20", Offset = "0x803E720", VA = "0x18803FF20")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x80403C0", Offset = "0x803EBC0", VA = "0x1880403C0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8040320", Offset = "0x803EB20", VA = "0x188040320")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8040040", Offset = "0x803E840", VA = "0x188040040")]
		public unsafe static void DMJBMMIBENB([NoAlias] float2* AIGKIBLMMDK, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void FDEDMBNIEKB([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class PFFDJKNJIBL
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8045260", Offset = "0x8043A60", VA = "0x188045260")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8045740", Offset = "0x8043F40", VA = "0x188045740")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x80456A0", Offset = "0x8043EA0", VA = "0x1880456A0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8045380", Offset = "0x8043B80", VA = "0x188045380")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void PPCCOJBOFAA([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class GJLBCFKJEJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8033820", Offset = "0x8032020", VA = "0x188033820")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8033D00", Offset = "0x8032500", VA = "0x188033D00")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8033C60", Offset = "0x8032460", VA = "0x188033C60")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8033940", Offset = "0x8032140", VA = "0x188033940")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void HAKCIKEEKLI([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class JKBNAPEEDKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8037750", Offset = "0x8035F50", VA = "0x188037750")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8037B30", Offset = "0x8036330", VA = "0x188037B30")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8037A90", Offset = "0x8036290", VA = "0x188037A90")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8037870", Offset = "0x8036070", VA = "0x188037870")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void NJBGFODJCAG([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class NKNBFFDEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8042CA0", Offset = "0x80414A0", VA = "0x188042CA0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8043170", Offset = "0x8041970", VA = "0x188043170")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x80430D0", Offset = "0x80418D0", VA = "0x1880430D0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8042DC0", Offset = "0x80415C0", VA = "0x188042DC0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void KAGPILJAKNA([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class BALHENCOECD
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8024AA0", Offset = "0x80232A0", VA = "0x188024AA0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8024F70", Offset = "0x8023770", VA = "0x188024F70")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8024ED0", Offset = "0x80236D0", VA = "0x188024ED0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8024BC0", Offset = "0x80233C0", VA = "0x188024BC0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void NDAKMMHOLGP([NoAlias] ushort* KFKHLAKEPOH, [In][NoAlias] float4* EHOJNFKDEEP, int IIANICAFCPH, int FJNBBBLENEH);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class DFCPBFCDPJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8030980", Offset = "0x802F180", VA = "0x188030980")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8030DD0", Offset = "0x802F5D0", VA = "0x188030DD0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8030D30", Offset = "0x802F530", VA = "0x188030D30")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8030AA0", Offset = "0x802F2A0", VA = "0x188030AA0")]
		public unsafe static void DMJBMMIBENB([NoAlias] ushort* KFKHLAKEPOH, [In][NoAlias] float4* EHOJNFKDEEP, int IIANICAFCPH, int FJNBBBLENEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort BMGDJMCPCMA([In] float4 DHGAPNBAHMA);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class GCIKNFGMBOI
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x80332C0", Offset = "0x8031AC0", VA = "0x1880332C0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x80336D0", Offset = "0x8031ED0", VA = "0x1880336D0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8033630", Offset = "0x8031E30", VA = "0x188033630")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x80333E0", Offset = "0x8031BE0", VA = "0x1880333E0")]
		public static ushort DMJBMMIBENB([In] float4 DHGAPNBAHMA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void LAPAPDBEBBF([NoAlias] float4* KFKHLAKEPOH, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class NHJOGOABLGI
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8042700", Offset = "0x8040F00", VA = "0x188042700")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8042B50", Offset = "0x8041350", VA = "0x188042B50")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8042AB0", Offset = "0x80412B0", VA = "0x188042AB0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8042820", Offset = "0x8041020", VA = "0x188042820")]
		public unsafe static void DMJBMMIBENB([NoAlias] float4* KFKHLAKEPOH, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void OHEMCFJJAND([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class OMNHKMODGGC
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8044D50", Offset = "0x8043550", VA = "0x188044D50")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8045110", Offset = "0x8043910", VA = "0x188045110")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8045070", Offset = "0x8043870", VA = "0x188045070")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8044E70", Offset = "0x8043670", VA = "0x188044E70")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void DKKAMOAICAP([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class JICEDCCNCEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8037120", Offset = "0x8035920", VA = "0x188037120")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8037600", Offset = "0x8035E00", VA = "0x188037600")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8037560", Offset = "0x8035D60", VA = "0x188037560")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8037240", Offset = "0x8035A40", VA = "0x188037240")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void EFIHDNFLEMF([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class FMAEHEMKCMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x80325D0", Offset = "0x8030DD0", VA = "0x1880325D0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8032AB0", Offset = "0x80312B0", VA = "0x188032AB0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8032A10", Offset = "0x8031210", VA = "0x188032A10")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x80326F0", Offset = "0x8030EF0", VA = "0x1880326F0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void PJIHFIFALGH([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class GMHOBHBMGNB
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8033E50", Offset = "0x8032650", VA = "0x188033E50")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x80343A0", Offset = "0x8032BA0", VA = "0x1880343A0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8034300", Offset = "0x8032B00", VA = "0x188034300")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8033F70", Offset = "0x8032770", VA = "0x188033F70")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void AEFKJKJLJDD([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class CJHJHCPEGIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x802FA10", Offset = "0x802E210", VA = "0x18802FA10")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x802FF60", Offset = "0x802E760", VA = "0x18802FF60")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x802FEC0", Offset = "0x802E6C0", VA = "0x18802FEC0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x802FB30", Offset = "0x802E330", VA = "0x18802FB30")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void ACGIDAMDJFI([Out] float4 KJCFPPKBAOB, ushort BAIGLMEDELP);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class EKBEGIPPKDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8031420", Offset = "0x802FC20", VA = "0x188031420")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8031870", Offset = "0x8030070", VA = "0x188031870")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x80317D0", Offset = "0x802FFD0", VA = "0x1880317D0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8031540", Offset = "0x802FD40", VA = "0x188031540")]
		public static void DMJBMMIBENB([Out] float4 KJCFPPKBAOB, ushort BAIGLMEDELP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void CMAIABNBGOP([NoAlias] float4* GNLDBFNJNEM, [NoAlias] byte* HEFKJGOEGOE, [Out] int LOONBDIGJGG, [Out] int HKLOMHONMCN, [NoAlias] float4* IGPPKPMDEDB, int IIANICAFCPH, int FJNBBBLENEH);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class MDOKBNHCLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8040D70", Offset = "0x803F570", VA = "0x188040D70")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8041160", Offset = "0x803F960", VA = "0x188041160")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x80410C0", Offset = "0x803F8C0", VA = "0x1880410C0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8040E90", Offset = "0x803F690", VA = "0x188040E90")]
		public unsafe static void DMJBMMIBENB([NoAlias] float4* GNLDBFNJNEM, [NoAlias] byte* HEFKJGOEGOE, [Out] int LOONBDIGJGG, [Out] int HKLOMHONMCN, [NoAlias] float4* IGPPKPMDEDB, int IIANICAFCPH, int FJNBBBLENEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void FLLLDJOPCEF([NoAlias] float4* MDIAKLIBFGL, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class JEICHHJAAGE
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8036B10", Offset = "0x8035310", VA = "0x188036B10")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8036FD0", Offset = "0x80357D0", VA = "0x188036FD0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8036F30", Offset = "0x8035730", VA = "0x188036F30")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8036C30", Offset = "0x8035430", VA = "0x188036C30")]
		public unsafe static void DMJBMMIBENB([NoAlias] float4* MDIAKLIBFGL, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void KHGHOFHHNMD([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class HEHMLHFCKLH
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8035030", Offset = "0x8033830", VA = "0x188035030")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x80355A0", Offset = "0x8033DA0", VA = "0x1880355A0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8035500", Offset = "0x8033D00", VA = "0x188035500")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8035150", Offset = "0x8033950", VA = "0x188035150")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void EHMHKOAPGCE([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class DBMHMADEHDB
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x80302B0", Offset = "0x802EAB0", VA = "0x1880302B0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8030830", Offset = "0x802F030", VA = "0x188030830")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8030790", Offset = "0x802EF90", VA = "0x188030790")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x80303D0", Offset = "0x802EBD0", VA = "0x1880303D0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void LLFNHKKHEKG([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class ILAOMJGKMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x80362D0", Offset = "0x8034AD0", VA = "0x1880362D0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8036840", Offset = "0x8035040", VA = "0x188036840")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x80367A0", Offset = "0x8034FA0", VA = "0x1880367A0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x80363F0", Offset = "0x8034BF0", VA = "0x1880363F0")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void NFIEHAHBGOK([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class LNBFNOOMEDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8040510", Offset = "0x803ED10", VA = "0x188040510")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x80408F0", Offset = "0x803F0F0", VA = "0x1880408F0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8040850", Offset = "0x803F050", VA = "0x188040850")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8040630", Offset = "0x803EE30", VA = "0x188040630")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void GMFLFDIHJFJ([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class OEDCBCBBOBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8043D60", Offset = "0x8042560", VA = "0x188043D60")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8044140", Offset = "0x8042940", VA = "0x188044140")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x80440A0", Offset = "0x80428A0", VA = "0x1880440A0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8043E80", Offset = "0x8042680", VA = "0x188043E80")]
		public unsafe static void DMJBMMIBENB([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int KFJMPLMMGJO([NoAlias] byte* NHJJPKJFNFE, [In][NoAlias] int* DPGPNCFIAJA, int JOFMJFEGHGM);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class MIBIHOPBFHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8041470", Offset = "0x803FC70", VA = "0x188041470")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x80418C0", Offset = "0x80400C0", VA = "0x1880418C0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8041820", Offset = "0x8040020", VA = "0x188041820")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8041590", Offset = "0x803FD90", VA = "0x188041590")]
		public unsafe static int DMJBMMIBENB([NoAlias] byte* NHJJPKJFNFE, [In][NoAlias] int* DPGPNCFIAJA, int JOFMJFEGHGM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void PAPPCHAOJMH([NoAlias] int* FPALCEBJLFP, [In][NoAlias] byte* FPLHCEEOHMI, int KIHBHAHLAAI);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class LJNPBHMBAAB
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x803F9B0", Offset = "0x803E1B0", VA = "0x18803F9B0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x803FDD0", Offset = "0x803E5D0", VA = "0x18803FDD0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x803FD30", Offset = "0x803E530", VA = "0x18803FD30")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x803FAD0", Offset = "0x803E2D0", VA = "0x18803FAD0")]
		public unsafe static void DMJBMMIBENB([NoAlias] int* FPALCEBJLFP, [In][NoAlias] byte* FPLHCEEOHMI, int KIHBHAHLAAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void PGDBEBKBGDL([NoAlias] ushort* FPALCEBJLFP, [In][NoAlias] byte* FPLHCEEOHMI, int KIHBHAHLAAI);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class KNKIHAMDMFF
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8038380", Offset = "0x8036B80", VA = "0x188038380")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x80387A0", Offset = "0x8036FA0", VA = "0x1880387A0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8038700", Offset = "0x8036F00", VA = "0x188038700")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x80384A0", Offset = "0x8036CA0", VA = "0x1880384A0")]
		public unsafe static void DMJBMMIBENB([NoAlias] ushort* FPALCEBJLFP, [In][NoAlias] byte* FPLHCEEOHMI, int KIHBHAHLAAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void NIMPLIFCKCE([Out] float3 KEHDKFJPKHP, ushort BAIGLMEDELP);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class HANLFLDFFNF
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x80344F0", Offset = "0x8032CF0", VA = "0x1880344F0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x80348B0", Offset = "0x80330B0", VA = "0x1880348B0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8034810", Offset = "0x8033010", VA = "0x188034810")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8034610", Offset = "0x8032E10", VA = "0x188034610")]
		public static void DMJBMMIBENB([Out] float3 KEHDKFJPKHP, ushort BAIGLMEDELP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort IDCGCDOGCCJ([In] float3 DHGAPNBAHMA);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class CBOCKLKENCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x802EEA0", Offset = "0x802D6A0", VA = "0x18802EEA0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x802F250", Offset = "0x802DA50", VA = "0x18802F250")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x802F1B0", Offset = "0x802D9B0", VA = "0x18802F1B0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x802EFC0", Offset = "0x802D7C0", VA = "0x18802EFC0")]
		public static ushort DMJBMMIBENB([In] float3 DHGAPNBAHMA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker KNLHCMFHJOA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker HNOLGKKKPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int GDOBIAAONDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int KIHBHAHLAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> MMNNEEJPNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> NEBBAAMKBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> CIJLIHGKMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> GAGFGMJKDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<NFKALPLNGCF> CMAFOJOGEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> ENJCDMCMIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> NDLIBHEDOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 LINDPFPPCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 LJJBKBPMFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 NJEBDKAGEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 BJBPNGPOJFB;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long IEKOHHMBPEL;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long ONCLNPKKALO;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float BPDAEBPGBAI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool AGIKKBDJKEF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KBMDKILMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x802BD70", Offset = "0x802A570", VA = "0x18802BD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GIHNHCPMODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80290C0", Offset = "0x80278C0", VA = "0x1880290C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x802B1F0", Offset = "0x80299F0", VA = "0x18802B1F0")]
	public void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x802A980", Offset = "0x8029180", VA = "0x18802A980")]
	public static BMIINENNNOF INHDMBAMCNE(Allocator GFNKGIEEHMD, NativeArray<float3> LJBMLLPNDDK, NativeArray<float3> GHAMOBMIBHP, NativeArray<float2> ECBFJHOMBFE, NativeArray<float4> IGPPKPMDEDB, bool EKBGFJNMALF, NativeArray<float4> FHEPGAMILEI, NativeArray<int> DPGPNCFIAJA, int GDOBIAAONDM, int LDPAMIAMAPP, int KIHBHAHLAAI, int IIANICAFCPH)
	{
		return default(BMIINENNNOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x802E6D0", Offset = "0x802CED0", VA = "0x18802E6D0")]
	public LFBDKLHLLEO PGAIBJKLJLO(Allocator GFNKGIEEHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x802E770", Offset = "0x802CF70", VA = "0x18802E770")]
	public void PGAIBJKLJLO(LFBDKLHLLEO KJCFPPKBAOB, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x802E290", Offset = "0x802CA90", VA = "0x18802E290")]
	public void OOFNBMEDHDC(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x802BAD0", Offset = "0x802A2D0", VA = "0x18802BAD0")]
	private void JLMOCBGDGJE(Mesh MLCGFPJFGFN, NativeArray<ushort> OHHIFKBJOGG, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8026030", Offset = "0x8024830", VA = "0x188026030")]
	public void BIICFHMPEHE(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x802B480", Offset = "0x8029C80", VA = "0x18802B480")]
	public void JHJBJNMCNPP(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x80251C0", Offset = "0x80239C0", VA = "0x1880251C0")]
	public void ABJNFIEJPNI(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x802C000", Offset = "0x802A800", VA = "0x18802C000")]
	public void KIAEAJKKJCE(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x802A1C0", Offset = "0x80289C0", VA = "0x18802A1C0")]
	public void IJFJPBFIJOF(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8029520", Offset = "0x8027D20", VA = "0x188029520")]
	public void HBJOCLGGHKK(Mesh MLCGFPJFGFN, LFBDKLHLLEO.OAAKKIKOAJE HKOGDKBPFKC, bool HAGAJDFPLBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x802EB30", Offset = "0x802D330", VA = "0x18802EB30")]
	public long PJNOPFHKAJF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x802BDB0", Offset = "0x802A5B0", VA = "0x18802BDB0")]
	public long JPPMANNAICH(LFBDKLHLLEO.OAAKKIKOAJE HKOGDKBPFKC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8028970", Offset = "0x8027170", VA = "0x188028970")]
	private void FJNOLPEALIM(int CHDNAOHPMCH, int FJNBBBLENEH, Allocator GFNKGIEEHMD, bool CHIKJLGDAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x802D620", Offset = "0x802BE20", VA = "0x18802D620")]
	private void NOCHACGJPMB(NativeArray<float3> LGPDHMFNAAB, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x802D740", Offset = "0x802BF40", VA = "0x18802D740")]
	[BurstCompile]
	private unsafe static void NOCHACGJPMB([NoAlias] float3* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x802CEB0", Offset = "0x802B6B0", VA = "0x18802CEB0")]
	[BurstCompile]
	private unsafe static void KOLGAJDJGCP([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8027C10", Offset = "0x8026410", VA = "0x188027C10")]
	[BurstCompile]
	private unsafe static void EILHEPEKJBN([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x802BE20", Offset = "0x802A620", VA = "0x18802BE20")]
	[BurstCompile]
	private unsafe static void KBBBOGHNFNH([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x802CF30", Offset = "0x802B730", VA = "0x18802CF30")]
	[BurstCompile]
	private unsafe static void LAFIFIIFKEG([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8026710", Offset = "0x8024F10", VA = "0x188026710")]
	[BurstCompile]
	private unsafe static void BKODLEEMFGC([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80275C0", Offset = "0x8025DC0", VA = "0x1880275C0")]
	private void DLMGHCFFPHI(NativeArray<float3> LJBMLLPNDDK, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8027530", Offset = "0x8025D30", VA = "0x188027530")]
	[BurstCompile]
	private unsafe static void DLMGHCFFPHI([NoAlias] ushort* LGPDHMFNAAB, [Out] float3 BLOGJGENBKI, [Out] float3 LJJBKBPMFGE, [In][NoAlias] float3* LJBMLLPNDDK, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8025DD0", Offset = "0x80245D0", VA = "0x188025DD0")]
	private void AKBMNMGHEDC(NativeArray<float3> GHAMOBMIBHP, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8025B90", Offset = "0x8024390", VA = "0x188025B90")]
	[BurstCompile]
	private unsafe static void AKBMNMGHEDC([NoAlias] ushort* LNIHJBKIDLL, [In][NoAlias] float3* GHAMOBMIBHP, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8028670", Offset = "0x8026E70", VA = "0x188028670")]
	private void FGODCPMHKPG(NativeArray<float3> DLENGFOJBOD, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8028730", Offset = "0x8026F30", VA = "0x188028730")]
	[BurstCompile]
	private unsafe static void FGODCPMHKPG([NoAlias] float3* DLENGFOJBOD, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x802DD10", Offset = "0x802C510", VA = "0x18802DD10")]
	[BurstCompile]
	private unsafe static void OHJHBENGPEN([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8029180", Offset = "0x8027980", VA = "0x188029180")]
	[BurstCompile]
	private unsafe static void GKPOJKMHCFP([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8027880", Offset = "0x8026080", VA = "0x188027880")]
	[BurstCompile]
	private unsafe static void DPMECFJCHLH([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x802D330", Offset = "0x802BB30", VA = "0x18802D330")]
	[BurstCompile]
	private unsafe static void LJKBGFKKJHJ([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80276E0", Offset = "0x8025EE0", VA = "0x1880276E0")]
	[BurstCompile]
	private unsafe static void DMPFBODHPFH([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8029B20", Offset = "0x8028320", VA = "0x188029B20")]
	private void HGFCIMCNDDA(NativeArray<float2> ECBFJHOMBFE, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8029A90", Offset = "0x8028290", VA = "0x188029A90")]
	[BurstCompile]
	private unsafe static void HGFCIMCNDDA([NoAlias] uint* AIGKIBLMMDK, [Out] float2 CDNDBJBAJDI, [Out] float2 BJBPNGPOJFB, [In][NoAlias] float2* ECBFJHOMBFE, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8026CB0", Offset = "0x80254B0", VA = "0x188026CB0")]
	[BurstCompile]
	private static void CGJDADJEIDI([Out] float2 KEHDKFJPKHP, uint BAIGLMEDELP, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8026B90", Offset = "0x8025390", VA = "0x188026B90")]
	private void CFNGBNIJBML(NativeArray<float2> AIGKIBLMMDK, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8026B10", Offset = "0x8025310", VA = "0x188026B10")]
	[BurstCompile]
	private unsafe static void CFNGBNIJBML([NoAlias] float2* AIGKIBLMMDK, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8029100", Offset = "0x8027900", VA = "0x188029100")]
	[BurstCompile]
	private unsafe static void GKLKCDOKLNI([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8025EB0", Offset = "0x80246B0", VA = "0x188025EB0")]
	[BurstCompile]
	private unsafe static void AKGIDOKHCEG([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x802D440", Offset = "0x802BC40", VA = "0x18802D440")]
	[BurstCompile]
	private unsafe static void MJOJPHHIDHG([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8029A10", Offset = "0x8028210", VA = "0x188029A10")]
	[BurstCompile]
	private unsafe static void HGAAAFCPLIJ([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x802E3B0", Offset = "0x802CBB0", VA = "0x18802E3B0")]
	[BurstCompile]
	private unsafe static void OPECDFMIHLH([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x802D8B0", Offset = "0x802C0B0", VA = "0x18802D8B0")]
	private void OCDJECAIIEH(NativeArray<float4> FHEPGAMILEI, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x802D830", Offset = "0x802C030", VA = "0x18802D830")]
	[BurstCompile]
	private unsafe static void OCDJECAIIEH([NoAlias] ushort* KFKHLAKEPOH, [In][NoAlias] float4* EHOJNFKDEEP, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x802B1A0", Offset = "0x80299A0", VA = "0x18802B1A0")]
	[BurstCompile]
	private static ushort JCOCHGNPMAA([In] float4 DHGAPNBAHMA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x802BEA0", Offset = "0x802A6A0", VA = "0x18802BEA0")]
	private void KCJBFDHEKHM(NativeArray<float4> KFKHLAKEPOH, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x802BF90", Offset = "0x802A790", VA = "0x18802BF90")]
	[BurstCompile]
	private unsafe static void KCJBFDHEKHM([NoAlias] float4* KFKHLAKEPOH, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x802CFB0", Offset = "0x802B7B0", VA = "0x18802CFB0")]
	[BurstCompile]
	private unsafe static void LAPNAKDDDIH([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8026AA0", Offset = "0x80252A0", VA = "0x188026AA0")]
	[BurstCompile]
	private unsafe static void CEDPMAKKMMD([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x802BD00", Offset = "0x802A500", VA = "0x18802BD00")]
	[BurstCompile]
	private unsafe static void JPAEAJOKILL([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8026EA0", Offset = "0x80256A0", VA = "0x188026EA0")]
	[BurstCompile]
	private unsafe static void CNJGBKAPNNP([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x802DA80", Offset = "0x802C280", VA = "0x18802DA80")]
	[BurstCompile]
	private unsafe static void ODFPGLOOCDC([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8025F30", Offset = "0x8024730", VA = "0x188025F30")]
	[BurstCompile]
	private static void AMONICKCLIN([Out] float4 KJCFPPKBAOB, ushort BAIGLMEDELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80280C0", Offset = "0x80268C0", VA = "0x1880280C0")]
	private void EPDBNIENIHL(Allocator GFNKGIEEHMD, NativeArray<float4> IGPPKPMDEDB, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8028030", Offset = "0x8026830", VA = "0x188028030")]
	[BurstCompile]
	private unsafe static void EPDBNIENIHL([NoAlias] float4* GNLDBFNJNEM, [NoAlias] byte* HEFKJGOEGOE, [Out] int LOONBDIGJGG, [Out] int HKLOMHONMCN, [NoAlias] float4* IGPPKPMDEDB, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x802A850", Offset = "0x8029050", VA = "0x18802A850")]
	private static void IKHKGJGFFCA(NativeArray<float4> MDIAKLIBFGL, NativeArray<NFKALPLNGCF> NJPCHEIHPHA, NativeArray<byte> MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x802A7D0", Offset = "0x8028FD0", VA = "0x18802A7D0")]
	[BurstCompile]
	private unsafe static void IKHKGJGFFCA([NoAlias] float4* MDIAKLIBFGL, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x802A140", Offset = "0x8028940", VA = "0x18802A140")]
	[BurstCompile]
	private unsafe static void IGMLFNNMOAH([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8027FB0", Offset = "0x80267B0", VA = "0x188027FB0")]
	[BurstCompile]
	private unsafe static void EKNOOCGHDJC([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8029EE0", Offset = "0x80286E0", VA = "0x188029EE0")]
	[BurstCompile]
	private unsafe static void HPIFKMADLJO([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x802DF50", Offset = "0x802C750", VA = "0x18802DF50")]
	[BurstCompile]
	private unsafe static void OKPDKPBGDHA([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x802C610", Offset = "0x802AE10", VA = "0x18802C610")]
	[BurstCompile]
	private unsafe static void KKHAKGBNOAG([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x802A040", Offset = "0x8028840", VA = "0x18802A040")]
	private void IADDGILCJML(Allocator GFNKGIEEHMD, NativeArray<int> DPGPNCFIAJA, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80271F0", Offset = "0x80259F0", VA = "0x1880271F0")]
	private static NativeArray<byte> DFIPMIFELBF(Allocator GFNKGIEEHMD, NativeArray<int> DPGPNCFIAJA, int JOFMJFEGHGM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80274C0", Offset = "0x8025CC0", VA = "0x1880274C0")]
	[BurstCompile]
	private unsafe static int DFIPMIFELBF([NoAlias] byte* NHJJPKJFNFE, [In][NoAlias] int* DPGPNCFIAJA, int JOFMJFEGHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x802E570", Offset = "0x802CD70", VA = "0x18802E570")]
	private static void PCOAPFMHFHM(NativeArray<int> FPALCEBJLFP, NativeArray<byte> FPLHCEEOHMI, int KIHBHAHLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x802E660", Offset = "0x802CE60", VA = "0x18802E660")]
	[BurstCompile]
	private unsafe static void PCOAPFMHFHM([NoAlias] int* FPALCEBJLFP, [In][NoAlias] byte* FPLHCEEOHMI, int KIHBHAHLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x802D7C0", Offset = "0x802BFC0", VA = "0x18802D7C0")]
	[BurstCompile]
	private unsafe static void OAHBOHFKGFH([NoAlias] ushort* FPALCEBJLFP, [In][NoAlias] byte* FPLHCEEOHMI, int KIHBHAHLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8028AA0", Offset = "0x80272A0", VA = "0x188028AA0")]
	[BurstCompile]
	private static void FKDHHMLECNL([Out] float3 KEHDKFJPKHP, ushort BAIGLMEDELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8028CD0", Offset = "0x80274D0", VA = "0x188028CD0")]
	[BurstCompile]
	private static ushort FPEGINANJOC([In] float3 DHGAPNBAHMA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80217F0", Offset = "0x801FFF0", VA = "0x1880217F0")]
	[BurstCompile]
	public unsafe static void CCCAKFCFHOE([NoAlias] float3* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x802B0E0", Offset = "0x80298E0", VA = "0x18802B0E0")]
	[BurstCompile]
	public unsafe static void JCKNEANDGHH([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x802D9C0", Offset = "0x802C1C0", VA = "0x18802D9C0")]
	[BurstCompile]
	public unsafe static void OCKBDDHGGIC([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8026790", Offset = "0x8024F90", VA = "0x188026790")]
	[BurstCompile]
	public unsafe static void BLPLELOGNKP([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8026790", Offset = "0x8024F90", VA = "0x188026790")]
	[BurstCompile]
	public unsafe static void NCILNNPEKIF([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x802D4C0", Offset = "0x802BCC0", VA = "0x18802D4C0")]
	[BurstCompile]
	public unsafe static void MMBMLHIFNPE([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* LJBMLLPNDDK, int GDOBIAAONDM, [In] float3 LINDPFPPCJJ, [In] float3 LJJBKBPMFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80228B0", Offset = "0x80210B0", VA = "0x1880228B0")]
	[BurstCompile]
	public unsafe static void KNACKBCLCID([NoAlias] ushort* LGPDHMFNAAB, [Out] float3 BLOGJGENBKI, [Out] float3 LJJBKBPMFGE, [In][NoAlias] float3* LJBMLLPNDDK, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8029C40", Offset = "0x8028440", VA = "0x188029C40")]
	[BurstCompile]
	public unsafe static void HJNLMCCDPHC([NoAlias] ushort* LNIHJBKIDLL, [In][NoAlias] float3* GHAMOBMIBHP, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8029280", Offset = "0x8027A80", VA = "0x188029280")]
	[BurstCompile]
	public unsafe static void GPBAOCFHIKP([NoAlias] float3* DLENGFOJBOD, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8026850", Offset = "0x8025050", VA = "0x188026850")]
	[BurstCompile]
	public unsafe static void CCFIHOELAKE([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80278F0", Offset = "0x80260F0", VA = "0x1880278F0")]
	[BurstCompile]
	public unsafe static void EGDGPPMNIHP([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x802D1F0", Offset = "0x802B9F0", VA = "0x18802D1F0")]
	[BurstCompile]
	public unsafe static void LCHLIIPONMN([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x802B310", Offset = "0x8029B10", VA = "0x18802B310")]
	[BurstCompile]
	public unsafe static void JGHLGGNEKOF([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8028500", Offset = "0x8026D00", VA = "0x188028500")]
	[BurstCompile]
	public unsafe static void FFGFGPBMALP([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* GHAMOBMIBHP, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8022C90", Offset = "0x8021490", VA = "0x188022C90")]
	[BurstCompile]
	public unsafe static void LMEHHOPMAKI([NoAlias] uint* AIGKIBLMMDK, [Out] float2 CDNDBJBAJDI, [Out] float2 BJBPNGPOJFB, [In][NoAlias] float2* ECBFJHOMBFE, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80271B0", Offset = "0x80259B0", VA = "0x1880271B0")]
	[BurstCompile]
	public static void DCOKIHHMNHI([Out] float2 KEHDKFJPKHP, uint BAIGLMEDELP, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x802CDA0", Offset = "0x802B5A0", VA = "0x18802CDA0")]
	[BurstCompile]
	public unsafe static void KNAONKHNDJD([NoAlias] float2* AIGKIBLMMDK, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8027E70", Offset = "0x8026670", VA = "0x188027E70")]
	[BurstCompile]
	public unsafe static void EKMJFBBNNGJ([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x802E430", Offset = "0x802CC30", VA = "0x18802E430")]
	[BurstCompile]
	public unsafe static void PBINIJNAPJN([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x802DAF0", Offset = "0x802C2F0", VA = "0x18802DAF0")]
	[BurstCompile]
	public unsafe static void OFDEKMKGCAP([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8027750", Offset = "0x8025F50", VA = "0x188027750")]
	[BurstCompile]
	public unsafe static void DOCEEDJLJEE([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8026F10", Offset = "0x8025710", VA = "0x188026F10")]
	[BurstCompile]
	public unsafe static void CNOLIJHAEKC([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [NoAlias] uint* ECBFJHOMBFE, int GDOBIAAONDM, [In] float2 NJEBDKAGEPC, [In] float2 BJBPNGPOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8029F60", Offset = "0x8028760", VA = "0x188029F60")]
	[BurstCompile]
	public unsafe static void IABPPPMPOBP([NoAlias] ushort* KFKHLAKEPOH, [In][NoAlias] float4* EHOJNFKDEEP, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80291F0", Offset = "0x80279F0", VA = "0x1880291F0")]
	[BurstCompile]
	public static ushort GNEHBFCAJBI([In] float4 DHGAPNBAHMA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x802E1B0", Offset = "0x802C9B0", VA = "0x18802E1B0")]
	[BurstCompile]
	public unsafe static void OOCOPIAGGOP([NoAlias] float4* KFKHLAKEPOH, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x802CAB0", Offset = "0x802B2B0", VA = "0x18802CAB0")]
	[BurstCompile]
	public unsafe static void KLHJHBBJLCB([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8027040", Offset = "0x8025840", VA = "0x188027040")]
	[BurstCompile]
	public unsafe static void DADHKOIHIMF([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8026D30", Offset = "0x8025530", VA = "0x188026D30")]
	[BurstCompile]
	public unsafe static void CLJGBABOBJM([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x802EBF0", Offset = "0x802D3F0", VA = "0x18802EBF0")]
	[BurstCompile]
	public unsafe static void PNKCPJOFIJK([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8028EF0", Offset = "0x80276F0", VA = "0x188028EF0")]
	[BurstCompile]
	public unsafe static void GIHIJACFEKG([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] ushort* FHEPGAMILEI, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x802AE40", Offset = "0x8029640", VA = "0x18802AE40")]
	[BurstCompile]
	public static void JANGGCEGKOP([Out] float4 KJCFPPKBAOB, ushort BAIGLMEDELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8021470", Offset = "0x801FC70", VA = "0x188021470")]
	[BurstCompile]
	public unsafe static void ANFKGJCJKKG([NoAlias] float4* GNLDBFNJNEM, [NoAlias] byte* HEFKJGOEGOE, [Out] int LOONBDIGJGG, [Out] int HKLOMHONMCN, [NoAlias] float4* IGPPKPMDEDB, int IIANICAFCPH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8025810", Offset = "0x8024010", VA = "0x188025810")]
	[BurstCompile]
	public unsafe static void AEMCEEAGGGE([NoAlias] float4* MDIAKLIBFGL, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x802AF00", Offset = "0x8029700", VA = "0x18802AF00")]
	[BurstCompile]
	public unsafe static void JAOFCHOAGCC([NoAlias] LFBDKLHLLEO.LIHDFDPBNIH* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8027A30", Offset = "0x8026230", VA = "0x188027A30")]
	[BurstCompile]
	public unsafe static void EHCCEELGEGK([NoAlias] LFBDKLHLLEO.EJJAHOOPILN* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8027C90", Offset = "0x8026490", VA = "0x188027C90")]
	[BurstCompile]
	public unsafe static void EKDPNGHPIDN([NoAlias] LFBDKLHLLEO.DFHDIKHBEJD* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8025950", Offset = "0x8024150", VA = "0x188025950")]
	[BurstCompile]
	public unsafe static void AJABGGBDLGG([NoAlias] LFBDKLHLLEO.INIOOBKFFMI* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x802C870", Offset = "0x802B070", VA = "0x18802C870")]
	[BurstCompile]
	public unsafe static void KLCJBJIHMBM([NoAlias] LFBDKLHLLEO.DMODPHFANDL* LGPDHMFNAAB, [In][NoAlias] NFKALPLNGCF* NJPCHEIHPHA, [In][NoAlias] byte* MOGHFLGNFCO, int GDOBIAAONDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8026610", Offset = "0x8024E10", VA = "0x188026610")]
	[BurstCompile]
	public unsafe static int BINEHLAFIED([NoAlias] byte* NHJJPKJFNFE, [In][NoAlias] int* DPGPNCFIAJA, int JOFMJFEGHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8025F90", Offset = "0x8024790", VA = "0x188025F90")]
	[BurstCompile]
	public unsafe static void BGBDAEAIGCP([NoAlias] int* FPALCEBJLFP, [In][NoAlias] byte* FPLHCEEOHMI, int KIHBHAHLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x802D3A0", Offset = "0x802BBA0", VA = "0x18802D3A0")]
	[BurstCompile]
	public unsafe static void MGEAIEMOKBE([NoAlias] ushort* FPALCEBJLFP, [In][NoAlias] byte* FPLHCEEOHMI, int KIHBHAHLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8021CA0", Offset = "0x80204A0", VA = "0x188021CA0")]
	[BurstCompile]
	public static void DKPHODFBCFM([Out] float3 KEHDKFJPKHP, ushort BAIGLMEDELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8021630", Offset = "0x801FE30", VA = "0x188021630")]
	[BurstCompile]
	public static ushort BKLJFDBKIPC([In] float3 DHGAPNBAHMA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class LFBDKLHLLEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum OAAKKIKOAJE
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
	public enum NOMBJLGIFGL
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
	public struct MPFMKCPADID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OAAKKIKOAJE HKOGDKBPFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool NKDBNNGODGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int IOCECJDLIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] EEDANEALCLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct MELKOJNOBHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 KKEEFCOJJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 IILAMILCBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 GENEBLLECDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 GDEMHADOPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 CMAFOJOGEIH;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] EEDANEALCLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct LIHDFDPBNIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 KKEEFCOJJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 IILAMILCBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 GENEBLLECDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 GDEMHADOPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 CMAFOJOGEIH;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] EEDANEALCLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct EJJAHOOPILN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 KKEEFCOJJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint IILAMILCBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint GENEBLLECDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 GDEMHADOPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 CMAFOJOGEIH;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] EEDANEALCLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct DFHDIKHBEJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 KKEEFCOJJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint IILAMILCBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint GENEBLLECDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 GDEMHADOPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 CMAFOJOGEIH;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] EEDANEALCLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct INIOOBKFFMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 KKEEFCOJJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint PMFJJPINFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 GDEMHADOPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint HAKOPAECCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint MLKJJEMGGBP;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] EEDANEALCLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct DMODPHFANDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public IJCKDOKJEDE.LNAJGPKJJLM KIFNHHPNDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint PMFJJPINFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 GDEMHADOPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint HAKOPAECCJD;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] EEDANEALCLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int GGJODNGLPPE(float BDGPJOKJNIL);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class CGJFHCILDJM
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x802F3A0", Offset = "0x802DBA0", VA = "0x18802F3A0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x802F7C0", Offset = "0x802DFC0", VA = "0x18802F7C0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x802F720", Offset = "0x802DF20", VA = "0x18802F720")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x802F4C0", Offset = "0x802DCC0", VA = "0x18802F4C0")]
		public static int DMJBMMIBENB(float BDGPJOKJNIL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint BEKODKMHKCJ([In] float4 KENANDNBOGI);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class JLBKNCJAEGN
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8052100", Offset = "0x8050900", VA = "0x188052100")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8052530", Offset = "0x8050D30", VA = "0x188052530")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8052490", Offset = "0x8050C90", VA = "0x188052490")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8052220", Offset = "0x8050A20", VA = "0x188052220")]
		public static uint DMJBMMIBENB([In] float4 KENANDNBOGI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint GCBIMLPCBAK([In] float3 KENANDNBOGI);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class MBGNNHHOGPK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8053B10", Offset = "0x8052310", VA = "0x188053B10")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8053F10", Offset = "0x8052710", VA = "0x188053F10")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8053E70", Offset = "0x8052670", VA = "0x188053E70")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8053C30", Offset = "0x8052430", VA = "0x188053C30")]
		public static uint DMJBMMIBENB([In] float3 KENANDNBOGI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void DGNMDOEGIHG([NoAlias] EJJAHOOPILN* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class FELBPPAFPBD
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x804ABE0", Offset = "0x80493E0", VA = "0x18804ABE0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x804AFD0", Offset = "0x80497D0", VA = "0x18804AFD0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x804AF30", Offset = "0x8049730", VA = "0x18804AF30")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x804AD00", Offset = "0x8049500", VA = "0x18804AD00")]
		public unsafe static void DMJBMMIBENB([NoAlias] EJJAHOOPILN* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void FLPAPKBACAK([NoAlias] DFHDIKHBEJD* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class LLGEPNIMGFG
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8052AA0", Offset = "0x80512A0", VA = "0x188052AA0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8052E90", Offset = "0x8051690", VA = "0x188052E90")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8052DF0", Offset = "0x80515F0", VA = "0x188052DF0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8052BC0", Offset = "0x80513C0", VA = "0x188052BC0")]
		public unsafe static void DMJBMMIBENB([NoAlias] DFHDIKHBEJD* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void FBBCJNKILJM([NoAlias] INIOOBKFFMI* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class ICJKHFIBENI
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x804D550", Offset = "0x804BD50", VA = "0x18804D550")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x804DAF0", Offset = "0x804C2F0", VA = "0x18804DAF0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x804DA50", Offset = "0x804C250", VA = "0x18804DA50")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x804D670", Offset = "0x804BE70", VA = "0x18804D670")]
		public unsafe static void DMJBMMIBENB([NoAlias] INIOOBKFFMI* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void GPBGECAPDNG([NoAlias] DMODPHFANDL* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH, [Out] float3 IMODLDPFOOL, [Out] float3 MLHMOGJGEDC);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class ELBJCBFKIAP
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x804A100", Offset = "0x8048900", VA = "0x18804A100")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x804A810", Offset = "0x8049010", VA = "0x18804A810")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x804A770", Offset = "0x8048F70", VA = "0x18804A770")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x804A220", Offset = "0x8048A20", VA = "0x18804A220")]
		public unsafe static void DMJBMMIBENB([NoAlias] DMODPHFANDL* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH, [Out] float3 IMODLDPFOOL, [Out] float3 MLHMOGJGEDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int HDABHDIKFAE = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> OJOEJNDGPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> MEAKDPMPCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> IHAJLGGJNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> IABIIPPBOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> ALBHBIKMHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> AMAJJFAGHKC;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] CBDIJEGDJKJ;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool GKFGGANBHPK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static MPFMKCPADID[] BNMHFKPEJDA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KBMDKILMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x803D6D0", Offset = "0x803BED0", VA = "0x18803D6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x803AAB0", Offset = "0x80392B0", VA = "0x18803AAB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HLNAFGKHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x803AA70", Offset = "0x8039270", VA = "0x18803AA70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GIHNHCPMODK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x803C0A0", Offset = "0x803A8A0", VA = "0x18803C0A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x803EF60", Offset = "0x803D760", VA = "0x18803EF60")]
	public static NOMBJLGIFGL PKPCFFMJCMM(OAAKKIKOAJE HKOGDKBPFKC)
	{
		return default(NOMBJLGIFGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x803AF90", Offset = "0x8039790", VA = "0x18803AF90")]
	public static void ELHLNKNDIBB(NOMBJLGIFGL DPHCIMOLLHC, Material IPKNLMFNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x803ABE0", Offset = "0x80393E0", VA = "0x18803ABE0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x803BEB0", Offset = "0x803A6B0", VA = "0x18803BEB0")]
	public void FJNOLPEALIM(int CHDNAOHPMCH, int FJNBBBLENEH, Allocator GFNKGIEEHMD, bool PFNHJHDMAMK, bool CHIKJLGDAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x803C7B0", Offset = "0x803AFB0", VA = "0x18803C7B0")]
	public void IICAHHNHIPM(int CHDNAOHPMCH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x803C350", Offset = "0x803AB50", VA = "0x18803C350", Slot = "6")]
	public bool GLFMLPEJLFD(Mesh MLCGFPJFGFN, bool LEHPGFJEMFL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x803E9B0", Offset = "0x803D1B0", VA = "0x18803E9B0")]
	public bool OOFNBMEDHDC(Mesh MLCGFPJFGFN, bool LEHPGFJEMFL, bool HAGAJDFPLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x803E1D0", Offset = "0x803C9D0", VA = "0x18803E1D0")]
	public bool NOGLNONMODG(Mesh MLCGFPJFGFN, LFBDKLHLLEO APOCOEGFLMP, bool LEHPGFJEMFL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x803C830", Offset = "0x803B030", VA = "0x18803C830")]
	public bool IIKKLJCBFOE(Mesh MLCGFPJFGFN, LFBDKLHLLEO APOCOEGFLMP, OAAKKIKOAJE HKOGDKBPFKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x803B410", Offset = "0x8039C10", VA = "0x18803B410")]
	private void FGLKEPIPJHA(Mesh MLCGFPJFGFN, LFBDKLHLLEO APOCOEGFLMP, bool HAGAJDFPLBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x803BBA0", Offset = "0x803A3A0", VA = "0x18803BBA0")]
	public void FGLKEPIPJHA(NativeArray<ushort> LFMPBOGBENP, NativeArray<INIOOBKFFMI> OJLEOGPCLFD, Mesh MLCGFPJFGFN, LFBDKLHLLEO APOCOEGFLMP, bool HAGAJDFPLBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x803A030", Offset = "0x8038830", VA = "0x18803A030")]
	public void BIICFHMPEHE(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x803AAF0", Offset = "0x80392F0", VA = "0x18803AAF0")]
	[BurstCompile]
	public static int DMGEGAKODFD(float BDGPJOKJNIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x803AB90", Offset = "0x8039390", VA = "0x18803AB90")]
	[BurstCompile]
	public static uint DMGEGAKODFD([In] float4 KENANDNBOGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x803AB40", Offset = "0x8039340", VA = "0x18803AB40")]
	[BurstCompile]
	public static uint DMGEGAKODFD([In] float3 KENANDNBOGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x803D040", Offset = "0x803B840", VA = "0x18803D040")]
	public void JHJBJNMCNPP(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x803DFF0", Offset = "0x803C7F0", VA = "0x18803DFF0")]
	[BurstCompile]
	private unsafe static void LELNLPMAMBO([NoAlias] EJJAHOOPILN* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x80388F0", Offset = "0x80370F0", VA = "0x1880388F0")]
	public void ABJNFIEJPNI(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x803E150", Offset = "0x803C950", VA = "0x18803E150")]
	[BurstCompile]
	private unsafe static void NNKMHDNLCHJ([NoAlias] DFHDIKHBEJD* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x803DC20", Offset = "0x803C420", VA = "0x18803DC20")]
	public void KIAEAJKKJCE(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x803D870", Offset = "0x803C070", VA = "0x18803D870")]
	public void KIAEAJKKJCE(NativeArray<ushort> OHHIFKBJOGG, NativeArray<INIOOBKFFMI> NNGLNBDMOEH, Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8039C70", Offset = "0x8038470", VA = "0x188039C70")]
	[BurstCompile]
	public unsafe static void BFFHMMKBLEI([NoAlias] INIOOBKFFMI* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x803C900", Offset = "0x803B100", VA = "0x18803C900")]
	public void IJFJPBFIJOF(Mesh MLCGFPJFGFN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x803E070", Offset = "0x803C870", VA = "0x18803E070")]
	[BurstCompile]
	private unsafe static void MAJAFNJPLJK([NoAlias] DMODPHFANDL* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH, [Out] float3 IMODLDPFOOL, [Out] float3 MLHMOGJGEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x803C370", Offset = "0x803AB70", VA = "0x18803C370")]
	public void HBJOCLGGHKK(Mesh MLCGFPJFGFN, OAAKKIKOAJE HKOGDKBPFKC, bool HAGAJDFPLBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x803C0E0", Offset = "0x803A8E0", VA = "0x18803C0E0")]
	public void GJNOLKEIEHM(LFBDKLHLLEO MLCGFPJFGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x803AE90", Offset = "0x8039690", VA = "0x18803AE90")]
	public void EIKPCCJLMEB(LFBDKLHLLEO BJNLPCOGDLM, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x803EDB0", Offset = "0x803D5B0", VA = "0x18803EDB0")]
	public long PJNOPFHKAJF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x803EF00", Offset = "0x803D700", VA = "0x18803EF00")]
	public static long PJNOPFHKAJF(int EIDHABNOODM, int KOMBFDMAHOG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x803D7D0", Offset = "0x803BFD0", VA = "0x18803D7D0")]
	public static long JPPMANNAICH(int EIDHABNOODM, int KOMBFDMAHOG, OAAKKIKOAJE HKOGDKBPFKC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x803D710", Offset = "0x803BF10", VA = "0x18803D710")]
	public long JPPMANNAICH(OAAKKIKOAJE HKOGDKBPFKC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x803E0F0", Offset = "0x803C8F0", VA = "0x18803E0F0")]
	public void MHBLPLJGPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8038F80", Offset = "0x8037780", VA = "0x188038F80")]
	public static void AJANDDPFJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8039530", Offset = "0x8037D30", VA = "0x188039530")]
	public OAAKKIKOAJE AODPHMNKBMH()
	{
		return default(OAAKKIKOAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x803C400", Offset = "0x803AC00", VA = "0x18803C400")]
	public static (int, int) HEMEKBFOMIF(Mesh MLCGFPJFGFN)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x803E8D0", Offset = "0x803D0D0", VA = "0x18803E8D0")]
	public static int OOAIMIBHIGH(VertexAttributeDescriptor[] IPPFOJNBJFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x803ACF0", Offset = "0x80394F0", VA = "0x18803ACF0")]
	public static long EEBOJBHPJGI(Mesh MLCGFPJFGFN, int PHAIOAGNINA, int DNPCFKFNBCB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x803AD60", Offset = "0x8039560", VA = "0x18803AD60")]
	public static long EEBOJBHPJGI(Mesh MLCGFPJFGFN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LFBDKLHLLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x803C660", Offset = "0x803AE60", VA = "0x18803C660")]
	[BurstCompile]
	public static int IFIHLOKHLJP(float BDGPJOKJNIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x803C4D0", Offset = "0x803ACD0", VA = "0x18803C4D0")]
	[BurstCompile]
	public static uint IFIHLOKHLJP([In] float4 KENANDNBOGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x803C700", Offset = "0x803AF00", VA = "0x18803C700")]
	[BurstCompile]
	public static uint IFIHLOKHLJP([In] float3 KENANDNBOGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x803B050", Offset = "0x8039850", VA = "0x18803B050")]
	[BurstCompile]
	public unsafe static void FCCHGAHDONN([NoAlias] EJJAHOOPILN* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x803EFB0", Offset = "0x803D7B0", VA = "0x18803EFB0")]
	[BurstCompile]
	public unsafe static void PLKCCDMEFGK([NoAlias] DFHDIKHBEJD* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x803E6D0", Offset = "0x803CED0", VA = "0x18803E6D0")]
	[BurstCompile]
	public unsafe static void ODHHHPEJMNJ([NoAlias] INIOOBKFFMI* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8039CF0", Offset = "0x80384F0", VA = "0x188039CF0")]
	[BurstCompile]
	public unsafe static void BHJJPOFPFLO([NoAlias] DMODPHFANDL* LGPDHMFNAAB, int GDOBIAAONDM, [In][NoAlias] float3* OEDPAJNKFEN, [In][NoAlias] float3* NEBBAAMKBDP, [In][NoAlias] float4* CIJLIHGKMBB, [In][NoAlias] float2* GAGFGMJKDJP, [In][NoAlias] float4* CMAFOJOGEIH, [Out] float3 IMODLDPFOOL, [Out] float3 MLHMOGJGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct JEGGAKHBOFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int EGILNJMJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 PMPAIEBJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion MAAOGDDIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 PCAJKMOKDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int CCOKKNAJIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int NOCIFGGBANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int CGDNKENIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float DEKMHJAIAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 EGLNFLGEBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool ALINNBHJGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public GIIAOJCFHJA GFPACONBKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 PPBCBBEBLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float KAHHOOIGHPI;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HOIEJGKPIBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static JJIEIPFPHNJ NKOLECDPDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<JEGGAKHBOFC> LKCDHLEJIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<LGIOMKNOMGM> KCHOPBOAMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<CKPAMBEDPCJ> LDOCFDILMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<KKEDALOMPGI> DAOCBNIGICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<LGIOMKNOMGM> MJLAEMMDDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<FOAGNFHNMJI> DHGCGEJKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<KKEDALOMPGI>> HPGNDDPNKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<DPCBJCHLGNC> KHMFDEEFHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> DGCJOGGNJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> PEGCLHHOPBI;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<HIGEDJNCICA.FABNLJLAMPJ> OFMBIKOKEPE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA2E5C0", Offset = "0xA2CDC0", VA = "0x180A2E5C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA2E5A0", Offset = "0xA2CDA0", VA = "0x180A2E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int HLNAFGKHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xC9AA80", Offset = "0xC99280", VA = "0x180C9AA80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xC9AA90", Offset = "0xC99290", VA = "0x180C9AA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x804D330", Offset = "0x804BB30", VA = "0x18804D330")]
	public HOIEJGKPIBK(int KEAGJJGJEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x804C720", Offset = "0x804AF20", VA = "0x18804C720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x804CB20", Offset = "0x804B320", VA = "0x18804CB20")]
	public void JGAHMDKPFDK(JobHandle GGAIACICGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x804C900", Offset = "0x804B100", VA = "0x18804C900")]
	public void HOEHGAMBHGF(JEGGAKHBOFC IMINNNCPCJF, DPCBJCHLGNC GKMHJLLOKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x804C5C0", Offset = "0x804ADC0", VA = "0x18804C5C0")]
	public void DEDHPIODCPL(CKPAMBEDPCJ IMINNNCPCJF, NativeArray<KKEDALOMPGI> BHOGBFBKIHB, int GDOBIAAONDM, int KIHBHAHLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x804C4A0", Offset = "0x804ACA0", VA = "0x18804C4A0")]
	public JobHandle APMCBLPHOLC(LFBDKLHLLEO FICNBEIKJJC, IJDKMPAABAF EGCIHGALNKK, float3 NPHNBMGEHPB, quaternion OILMOJFMEMG, float ONPEHAIHPBE, bool APCJMDOKHFK, int CEGIJNJPLLP = 0, int OJAEAGPLFHN = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x804B2F0", Offset = "0x8049AF0", VA = "0x18804B2F0")]
	public JobHandle APMCBLPHOLC(LFBDKLHLLEO FICNBEIKJJC, IJDKMPAABAF EGCIHGALNKK, NativeList<HIGEDJNCICA.FABNLJLAMPJ> HGGPMIDILLK, float3 NPHNBMGEHPB, quaternion OILMOJFMEMG, float ONPEHAIHPBE, bool APCJMDOKHFK, bool HPBFKGCJACI, int CEGIJNJPLLP = 0, int OJAEAGPLFHN = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x804CD10", Offset = "0x804B510", VA = "0x18804CD10")]
	public static JobHandle MGLLCOKNMOE(DGEFADOOKID HGFBDDACOMN, LFBDKLHLLEO FICNBEIKJJC, NativeArray<int> PEGCLHHOPBI, JEGGAKHBOFC IMINNNCPCJF, JobHandle GGAIACICGIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x804D080", Offset = "0x804B880", VA = "0x18804D080")]
	public static JobHandle NIAPINBFMJC(KMEMBGCHGEP HGFBDDACOMN, LFBDKLHLLEO FICNBEIKJJC, CKPAMBEDPCJ IMINNNCPCJF, NativeArray<KKEDALOMPGI> BHOGBFBKIHB, int GDOBIAAONDM, int KIHBHAHLAAI, JobHandle GGAIACICGIO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JHEFDLEOFBE
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct NKNIOKIJAFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer FKGIDFBJGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public OIDIBCFEABG.LMOHFNCNCMJ DCHLEJEKMIE;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C520", Offset = "0x5E9AD20", VA = "0x185E9C520")]
		public NKNIOKIJAFD(MeshRenderer FKGIDFBJGGD, OIDIBCFEABG.LMOHFNCNCMJ DCHLEJEKMIE)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8057BE0", Offset = "0x80563E0", VA = "0x188057BE0")]
		public static NKNIOKIJAFD KEINEINMKGA((MeshRenderer, OIDIBCFEABG.LMOHFNCNCMJ) MLFPMFCIJCE)
		{
			return default(NKNIOKIJAFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker AJPKLDFOBME;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker PHFMEEMIIPO;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker BOJFADDMKHE;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker MFDIEOPNAPP;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8050F30", Offset = "0x804F730", VA = "0x188050F30")]
	internal void HHFOLIHPNKM(GameObject FKLKGIOAAFH, OIDIBCFEABG.FCHCBAPOEAJ FECOEILKDOO, List<NKNIOKIJAFD> JOIHPEIKCGH, Material IPKNLMFNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x804DF60", Offset = "0x804C760", VA = "0x18804DF60")]
	internal void ACGNEPNEJLB(GameObject FKLKGIOAAFH, OIDIBCFEABG.FCHCBAPOEAJ FECOEILKDOO, List<NKNIOKIJAFD> JOIHPEIKCGH, List<LODGroup> BFNBDONMFIF, Material IPKNLMFNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x804F540", Offset = "0x804DD40", VA = "0x18804F540")]
	private MeshRenderer GBNGAPNBKDB(OIDIBCFEABG.FCHCBAPOEAJ FECOEILKDOO, Material IPKNLMFNGIO, List<NKNIOKIJAFD> JOIHPEIKCGH, bool FCNENPGIJOK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x804FFF0", Offset = "0x804E7F0", VA = "0x18804FFF0")]
	private List<(List<NKNIOKIJAFD>, float)> GPPCHPHFLMK(OIDIBCFEABG.FCHCBAPOEAJ FECOEILKDOO, List<LODGroup> BFNBDONMFIF, Material IPKNLMFNGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x804E7E0", Offset = "0x804CFE0", VA = "0x18804E7E0")]
	private List<List<(List<NKNIOKIJAFD>, float)>> ECBHOMDJONK(OIDIBCFEABG.FCHCBAPOEAJ FECOEILKDOO, List<LODGroup> BFNBDONMFIF, Material IPKNLMFNGIO, [Out] int LOCHFONIONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public JHEFDLEOFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8051820", Offset = "0x8050020", VA = "0x188051820")]
	[CompilerGenerated]
	internal static (float, int) HOCGGAKHEJJ(List<List<(List<NKNIOKIJAFD> meshList, float lodTransition)>> BNGPNGGMINO, int[] HPKEBJGDLAD)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class OANGJBCCMLL
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker IBMLOPHJPDM;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker OPPDLOAGGGA;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker KHIGJDPOMLE;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker IAELMFBBGLM;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker JAKJMJIFDJE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker JLBCAMFIKGC;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker OPOPKKPLOJI;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly BMELPJIFPCL EIDCHDBKGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private OIDIBCFEABG CMNNGPOPBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JHEFDLEOFBE FIDKOBLOONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader FGEFDIIBLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock ONFBIGDNHOO;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x80591B0", Offset = "0x80579B0", VA = "0x1880591B0")]
	public static void HMKLHNGMCBD(GameObject FKLKGIOAAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8059AD0", Offset = "0x80582D0", VA = "0x188059AD0")]
	public void IEAMPCKAMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8058C60", Offset = "0x8057460", VA = "0x188058C60")]
	public void GOOOPJLIIOD(GameObject FKLKGIOAAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x8057C60", Offset = "0x8056460", VA = "0x188057C60")]
	private bool ADGLPNMCEEK(MeshRenderer FKGIDFBJGGD, [Out] MeshFilter EBOCNBPJGFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x805A2B0", Offset = "0x8058AB0", VA = "0x18805A2B0")]
	private bool JOGHKJJHCLE(int PNJCJGEIDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8058ED0", Offset = "0x80576D0", VA = "0x188058ED0")]
	private void HGIEGIIPONL(GameObject FKLKGIOAAFH, int PNJCJGEIDHG, Material IPKNLMFNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8058470", Offset = "0x8056C70", VA = "0x188058470")]
	private List<JHEFDLEOFBE.NKNIOKIJAFD> DIJJPGEIGGC(int PNJCJGEIDHG, [Out] List<LODGroup> BFNBDONMFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8059510", Offset = "0x8057D10", VA = "0x188059510")]
	private List<(int, Material)> IDDGJHPFFJE(float ABNILILPKEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x805A510", Offset = "0x8058D10", VA = "0x18805A510")]
	public void PBPOAHLKNMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x8057DE0", Offset = "0x80565E0", VA = "0x188057DE0")]
	private bool ALDOLFNCPJO(GameObject EMOLHEPHCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x805A800", Offset = "0x8059000", VA = "0x18805A800")]
	public OANGJBCCMLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class OIDIBCFEABG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct FCHCBAPOEAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 PIMEBNLNKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 EDBIKCGPICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float EHHBDJHAEDN;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x804A960", Offset = "0x8049160", VA = "0x18804A960")]
		public FCHCBAPOEAJ(Bounds PDEEGEAEBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x804AAD0", Offset = "0x80492D0", VA = "0x18804AAD0")]
		public FCHCBAPOEAJ(float3 PIMEBNLNKIL, float3 EDBIKCGPICF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct DOKOAHBLGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public FCHCBAPOEAJ AJDIMNEPKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int HMNJNAGJLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int PBICKKJKLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float DCKJPJJAFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int CHDNAOHPMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int LCOALAPOLPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int DABNOLIINPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int JFEFHMCACBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int HEKJPFAMJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool FNJMNFEIINA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct LMOHFNCNCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh AJICNCIPKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 NJMIDHHHLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int ONBJOKNDJDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct PJAAIFMHLLB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<DOKOAHBLGLG> BLCKOOKMFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> ECOCMLPNFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int AEBGPDPPOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FCHCBAPOEAJ PDEEGEAEBNP;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x805ECA0", Offset = "0x805D4A0", VA = "0x18805ECA0")]
		private float EPBKNJGBIKK(FCHCBAPOEAJ HBMOFOICGEH, FCHCBAPOEAJ LDEEDNGKJOE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x805EDD0", Offset = "0x805D5D0", VA = "0x18805EDD0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker FEPMGCILMGJ;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker MICPOKLFIOK;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker OFMOMLEMOGD;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker OPAOJPOMENJ;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker AAAHCPDEFMG;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker EJHMGDHIJOE;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker EGKKNOGDEDP;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker KLNBKKDGPIC;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker GMLCOLFEGLA;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker HJBEOICDAAF;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker NIIKJJLBHOL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker FGDKJNFBHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<DOKOAHBLGLG> BLCKOOKMFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> HHKBIOBIEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int LFJEFIEIFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> BCMBAGEBFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<LMOHFNCNCMJ> HNMPJKOGIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> BFNBDONMFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> MIAAKOOFEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> CMJCPGBPHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader HKMEFHHFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader CLNFPDNCFLI;

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x805E960", Offset = "0x805D160", VA = "0x18805E960")]
	public OIDIBCFEABG(int DJGKNMABHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x805B7F0", Offset = "0x8059FF0", VA = "0x18805B7F0")]
	private void DCMDMOGCPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x805C690", Offset = "0x805AE90", VA = "0x18805C690")]
	public bool DHEMFJIMEKN(MeshRenderer BNMEJFOCEHM, MeshFilter CJGPACFMOLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x805B960", Offset = "0x805A160", VA = "0x18805B960")]
	public bool DHEMFJIMEKN(LODGroup FNNBDKHDGKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x805E120", Offset = "0x805C920", VA = "0x18805E120")]
	private bool HKLOAKDICEJ(MeshRenderer BNMEJFOCEHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x805B6D0", Offset = "0x8059ED0", VA = "0x18805B6D0")]
	private int DBLNEGBHPCP(MeshRenderer BNMEJFOCEHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x805A8B0", Offset = "0x80590B0", VA = "0x18805A8B0")]
	private int ABKKGHLOOCI(LODGroup FNNBDKHDGKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x805E1A0", Offset = "0x805C9A0", VA = "0x18805E1A0")]
	private int OBBELCFIDFG(MeshFilter CJGPACFMOLK, int ALCDHADGBBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x805E300", Offset = "0x805CB00", VA = "0x18805E300")]
	private int OEBMCKEGKAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x805AE20", Offset = "0x8059620", VA = "0x18805AE20")]
	private static FCHCBAPOEAJ CMOHLDLELKO(FCHCBAPOEAJ HBMOFOICGEH, FCHCBAPOEAJ LDEEDNGKJOE)
	{
		return default(FCHCBAPOEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x805A920", Offset = "0x8059120", VA = "0x18805A920")]
	private static float APPPEFNNCCN(Vector3 PIMEBNLNKIL, Vector3 EDBIKCGPICF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x805AAB0", Offset = "0x80592B0", VA = "0x18805AAB0")]
	private int BEPNDICBIDL(int NPGDNGMIIMC, FCHCBAPOEAJ MAEPMPMDEBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x805DE90", Offset = "0x805C690", VA = "0x18805DE90")]
	private void GOHKOJFPKHJ(FCHCBAPOEAJ MAEPMPMDEBI, int PNJCJGEIDHG, [Out] float CKKHPFPKMIF, [Out] float NJCIGMDADKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x805D710", Offset = "0x805BF10", VA = "0x18805D710")]
	private void EJMKCPNCFHF(FCHCBAPOEAJ MAEPMPMDEBI, int MLCHPGBHIBL, Material IPKNLMFNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x805DC10", Offset = "0x805C410", VA = "0x18805DC10")]
	private float EPBKNJGBIKK(FCHCBAPOEAJ HBMOFOICGEH, FCHCBAPOEAJ LDEEDNGKJOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x805B210", Offset = "0x8059A10", VA = "0x18805B210")]
	private void CNAJEPAOKFL(int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x805CC50", Offset = "0x805B450", VA = "0x18805CC50")]
	private void EDBPDKJKCGM(int FNMNHKJKJIJ, int BHGFMOOCKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x805D0E0", Offset = "0x805B8E0", VA = "0x18805D0E0")]
	private void EJGFPNNHPLB(int FNMNHKJKJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x805CBA0", Offset = "0x805B3A0", VA = "0x18805CBA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct GHLDOADGHIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 DNFFEFMJBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 EAOKBEELIFC;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class LBNADCOGKII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<GHLDOADGHIF> EBFNGAMIFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> GGOEIMMPIFA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HLNAFGKHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x80529E0", Offset = "0x80511E0", VA = "0x1880529E0")]
	public LBNADCOGKII(int CHDNAOHPMCH, int FJNBBBLENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x80528A0", Offset = "0x80510A0", VA = "0x1880528A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x8052900", Offset = "0x8051100", VA = "0x188052900")]
	public void GJNOLKEIEHM(LBNADCOGKII KMCEJIKBAJG, int JBOBLBNDCNO, int COEFDMIBPJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class NKFMECJADOM
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static LBNADCOGKII PDKMMBIGKIE;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<LGIOMKNOMGM> HANOCJIBDIA;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] FOPOKBGKJKF;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool LAONGJECBDN;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, LBNADCOGKII> HIJEDOAGBFM;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, LBNADCOGKII> NJALHMDABGL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool ADEGNIIHBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x80563B0", Offset = "0x8054BB0", VA = "0x1880563B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<LGIOMKNOMGM> GPKKMOKCIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8057510", Offset = "0x8055D10", VA = "0x188057510")]
		get
		{
			return default(NativeList<LGIOMKNOMGM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LBNADCOGKII MNHKCAACFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8057480", Offset = "0x8055C80", VA = "0x188057480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x8056710", Offset = "0x8054F10", VA = "0x188056710")]
	private static void FKNMKCDKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x8056430", Offset = "0x8054C30", VA = "0x188056430")]
	public static int BBPODAFIEPC(bool NGEEELLEEEM, int MKALGDDONOC, bool GCEDDDOCNJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x80579C0", Offset = "0x80561C0", VA = "0x1880579C0")]
	private static int OPKNBDCCNEG(int MKALGDDONOC, bool JGIBACDIEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8057170", Offset = "0x8055970", VA = "0x188057170")]
	private static int IDMNKLOLMAK(int MKALGDDONOC, bool JGIBACDIEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8057300", Offset = "0x8055B00", VA = "0x188057300")]
	public static int KCJPGEAKFNH(int MBAOJAPNLMO, int MKALGDDONOC, int AMNIBLMPINO, bool JGIBACDIEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8057180", Offset = "0x8055980", VA = "0x188057180")]
	public static int JBFKDOBHKFB(int MBAOJAPNLMO, int MKALGDDONOC, int AMNIBLMPINO, bool JGIBACDIEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8056470", Offset = "0x8054C70", VA = "0x188056470")]
	public static int DENBDHGPGIJ(int AMNIBLMPINO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8056460", Offset = "0x8054C60", VA = "0x188056460")]
	private static int DCDPNABKIOJ(int MKALGDDONOC, bool JGIBACDIEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8057A70", Offset = "0x8056270", VA = "0x188057A70")]
	private static int PGPPCIMHKMB(int MKALGDDONOC, bool JGIBACDIEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8057100", Offset = "0x8055900", VA = "0x188057100")]
	public static int GPMGPFKAFCJ(int MBAOJAPNLMO, int MKALGDDONOC, int AMNIBLMPINO, bool JGIBACDIEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x80579E0", Offset = "0x80561E0", VA = "0x1880579E0")]
	public static int PGILDLCJPJN(int MBAOJAPNLMO, int MKALGDDONOC, int AMNIBLMPINO, bool JGIBACDIEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x80579A0", Offset = "0x80561A0", VA = "0x1880579A0")]
	public static int OHAOKLLMDBJ(int AMNIBLMPINO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8057390", Offset = "0x8055B90", VA = "0x188057390")]
	public static LBNADCOGKII KHDODKDEHHJ(int MKALGDDONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8056480", Offset = "0x8054C80", VA = "0x188056480")]
	private static LBNADCOGKII DFKBAOKEDDN(int MKALGDDONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8057210", Offset = "0x8055A10", VA = "0x188057210")]
	public static LBNADCOGKII JODCPCPKFNE(int MKALGDDONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8056DC0", Offset = "0x80555C0", VA = "0x188056DC0")]
	private static LBNADCOGKII GBKCMEGHKHN(int MKALGDDONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x80575A0", Offset = "0x8055DA0", VA = "0x1880575A0")]
	public static void NIKNJLKBDOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct CKPAMBEDPCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int GKJKIMBJICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 PMPAIEBJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion MAAOGDDIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float PCAJKMOKDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float DNEJDABCBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int CCOKKNAJIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int NOCIFGGBANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int CGDNKENIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool CDMCAMANPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool DHNJIIOEPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float DEKMHJAIAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 EGLNFLGEBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool APCLGLPLEJP;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct FOAGNFHNMJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int GBPHLOIKNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int CHEMJOFFLOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct KMEMBGCHGEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<CKPAMBEDPCJ> INCLEFJCEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<KKEDALOMPGI> MPEJBAFEHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<LGIOMKNOMGM> NENHEKJJAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<FOAGNFHNMJI> CNGEGKLHKMH;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8052770", Offset = "0x8050F70", VA = "0x188052770")]
	public KMEMBGCHGEP(NativeArray<KKEDALOMPGI> MPEJBAFEHDO, int GGIJOHIPOOO = 1, Allocator GFNKGIEEHMD = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8052680", Offset = "0x8050E80", VA = "0x188052680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct NJMIIBNLFGN : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<GHLDOADGHIF> GKNJIFGAJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> CBAMPCDAKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<LGIOMKNOMGM> CKAHMHKKIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<CKPAMBEDPCJ> INCLEFJCEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<KKEDALOMPGI> MPEJBAFEHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<LGIOMKNOMGM> NENHEKJJAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<FOAGNFHNMJI> CNGEGKLHKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int ODJLGGDNDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int ALDKFINHIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 LOEMHGELAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion PFOGCBFPNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 MOGCPMIOBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MPJAEDMNODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MNNJJDBLJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IBDLCNJBDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DBCPBJICBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> ACGGNBJPILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JGNDGJKNJIK;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8055F00", Offset = "0x8054700", VA = "0x188055F00")]
	public NJMIIBNLFGN(HOIEJGKPIBK NJMCEACLONO, LFBDKLHLLEO FKMDBOKHOMH, float3 PBLAJNMIDCF, quaternion PGJOHNCMNLJ, float DHPPCBADNHH, int CEGIJNJPLLP = 0, int OJAEAGPLFHN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x8056180", Offset = "0x8054980", VA = "0x188056180")]
	public NJMIIBNLFGN(KMEMBGCHGEP NJMCEACLONO, LFBDKLHLLEO FKMDBOKHOMH, float3 PBLAJNMIDCF, quaternion PGJOHNCMNLJ, float3 DHPPCBADNHH, int CEGIJNJPLLP = 0, int OJAEAGPLFHN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8054060", Offset = "0x8052860", VA = "0x188054060")]
	private float3 BDONLMJBBLL(float3 CDOPPJMPELH, Matrix4x4 NBOEJKKBAJM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x80541A0", Offset = "0x80529A0", VA = "0x1880541A0")]
	private float3x3 BLHJKPJJAGJ(float3x3 OBNAHEBFBIO, float3x3 EIANHAGLPJK)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8055EF0", Offset = "0x80546F0", VA = "0x188055EF0")]
	private float KCLBFNFNDOG(float DKMKOJPHLDD, float MAKAELBIAID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8054660", Offset = "0x8052E60", VA = "0x188054660", Slot = "4")]
	public void Execute(int BIJFLLMPINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x8055800", Offset = "0x8054000", VA = "0x188055800")]
	private void ICGGDODFEIK(int DOPAAKBPBGJ, float3 KKEEFCOJJFM, float3 IILAMILCBNH, float3 GENEBLLECDJ, float ANIHENNGJAL, bool KNLHPMPHCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8054220", Offset = "0x8052A20", VA = "0x188054220")]
	private void DMAKCJIPGAI(CKPAMBEDPCJ EOMJNCDDHFI, float3 HFIBPPGFFAG, float3x3 KHAMCCGPNHN, float DKMKOJPHLDD, int CLDDLINECGI, int LLOJFHEGNMJ, int GGPDDHJHJLA, float DOGJEIPGHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8055970", Offset = "0x8054170", VA = "0x188055970")]
	private void JJGDKACAIIJ(int DOPAAKBPBGJ, int OJHGGEKLBHG, CKPAMBEDPCJ EOMJNCDDHFI, float3 HFIBPPGFFAG, float3x3 KHAMCCGPNHN, bool KPNCPBCAPOM, float DKMKOJPHLDD, int KLHCNGPJKJB, int LMFKBEBBCHD, int GGPDDHJHJLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct DGEFADOOKID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<JEGGAKHBOFC> CMNPLEOPFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<LGIOMKNOMGM> AKOHFHMMNLF;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x8047C40", Offset = "0x8046440", VA = "0x188047C40")]
	public DGEFADOOKID(int GGIJOHIPOOO, Allocator GFNKGIEEHMD = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x8047BA0", Offset = "0x80463A0", VA = "0x188047BA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct EFBPLBOELLD : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum NABCPJPFEAM
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
	private NativeList<float3> JPDIGJIOLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> MBECGMALCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> EOFBHOILMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> MGINNMIIKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> GHJEKBOCLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> ENMNMFDMHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> GMJFIJFPLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> BNHMNKALIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> KNPAECJLKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<LGIOMKNOMGM> AIHDHKNBLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<JEGGAKHBOFC> CMNPLEOPFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<LGIOMKNOMGM> AKOHFHMMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int ODJLGGDNDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int ALDKFINHIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MPJAEDMNODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MNNJJDBLJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IBDLCNJBDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DBCPBJICBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> ACGGNBJPILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> PEGCLHHOPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JGNDGJKNJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 MOGCPMIOBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion PFOGCBFPNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 LOEMHGELAAE;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x8049EF0", Offset = "0x80486F0", VA = "0x188049EF0")]
	public EFBPLBOELLD(HOIEJGKPIBK NJMCEACLONO, LFBDKLHLLEO FKMDBOKHOMH, NativeArray<int> PFEPCMGIFNL, float3 PBLAJNMIDCF, quaternion PGJOHNCMNLJ, float DHPPCBADNHH, int CEGIJNJPLLP = 0, int OJAEAGPLFHN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x8049CF0", Offset = "0x80484F0", VA = "0x188049CF0")]
	public EFBPLBOELLD(DGEFADOOKID IMINNNCPCJF, LFBDKLHLLEO FKMDBOKHOMH, NativeArray<int> PFEPCMGIFNL, float3 PBLAJNMIDCF, quaternion PGJOHNCMNLJ, float3 DHPPCBADNHH, int CEGIJNJPLLP = 0, int OJAEAGPLFHN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x80488D0", Offset = "0x80470D0", VA = "0x1880488D0", Slot = "4")]
	public void Execute(int BIJFLLMPINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x80498D0", Offset = "0x80480D0", VA = "0x1880498D0")]
	private void GBMNCJDHGAA(float4x4 ENFFOMMHILM, int BIJFLLMPINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x8049C80", Offset = "0x8048480", VA = "0x188049C80")]
	private NABCPJPFEAM LAGEMMGBEFF(float3 IILAMILCBNH)
	{
		return default(NABCPJPFEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8049880", Offset = "0x8048080", VA = "0x188049880")]
	private float4 FNGLPKOBGDN(NABCPJPFEAM CGPPJPLPLHH, int PNJCJGEIDHG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8048890", Offset = "0x8047090", VA = "0x188048890")]
	private float2 BIEFEBPCGHI(NABCPJPFEAM CGPPJPLPLHH, float3 KKEEFCOJJFM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct DPCBJCHLGNC
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum CJGCKFCNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static DPCBJCHLGNC EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 EOALAOOGNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 FAABMGBBECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 AMAGOKKEMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public CJGCKFCNJBF PBNBGAHIAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 HHOKFILJOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 BOFLGIBNDKN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KBFIABEIPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8047F20", Offset = "0x8046720", VA = "0x188047F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 DNFBPGDDNLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x80483C0", Offset = "0x8046BC0", VA = "0x1880483C0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x80487A0", Offset = "0x8046FA0", VA = "0x1880487A0")]
	public DPCBJCHLGNC(float3 KKEEFCOJJFM, quaternion FENAGHBAFHI, float3 GGIJOHIPOOO, CJGCKFCNJBF CEPGAJKBPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x80481C0", Offset = "0x80469C0", VA = "0x1880481C0")]
	public float MMCMEEEOHPA(float3 HFIBPPGFFAG, float KJAHONCOOFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8047E30", Offset = "0x8046630", VA = "0x188047E30")]
	public bool GDKBOCBLEOF(float3 IILAMILCBNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8048590", Offset = "0x8046D90", VA = "0x188048590")]
	public void PDEGEPJFPIM(float3 OFGCPLBANNM, float3x3 PJGICLFAHBK, float OIMKAELDBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x80484A0", Offset = "0x8046CA0", VA = "0x1880484A0")]
	private void PCAPOHDJDFJ(float3 CLKNAHDABLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8047F30", Offset = "0x8046730", VA = "0x188047F30")]
	public void LFBDCFCLKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct LLNHMDHDJJF : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<DPCBJCHLGNC> IMINNNCPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> MMNNEEJPNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> NDLIBHEDOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DGCJOGGNJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<LGIOMKNOMGM> AKOHFHMMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int DILMMCIGEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int ANKONOCFHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float KJAHONCOOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float CAIHMPKGAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FDFIOAMNFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FLPIMGENNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> PFDIBDNPPAL;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8053A70", Offset = "0x8052270", VA = "0x188053A70")]
	public LLNHMDHDJJF(LFBDKLHLLEO MLCGFPJFGFN, float DMMCJOHCABK, int COEFDMIBPJJ, int CLDDLINECGI, NativeList<DPCBJCHLGNC> IMINNNCPCJF, NativeArray<int> DGCJOGGNJMH, NativeList<LGIOMKNOMGM> AKOHFHMMNLF, IJDKMPAABAF EGCIHGALNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8052FE0", Offset = "0x80517E0", VA = "0x188052FE0", Slot = "4")]
	public void Execute(int BPLCFEGDDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8053720", Offset = "0x8051F20", VA = "0x188053720")]
	private bool LMMLJFFGJOG(DPCBJCHLGNC HBMOFOICGEH, DPCBJCHLGNC LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x80537E0", Offset = "0x8051FE0", VA = "0x1880537E0")]
	private bool MHIHJMCKGBF(DPCBJCHLGNC ABKKFEKEEMG, int MCIIPEHGOHG, int GDPILBFOCLA, int NLHLBFBIFFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct HIPBLHCHABE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<HIGEDJNCICA.FABNLJLAMPJ> HGGPMIDILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> DHHCOMHLEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int CEGIJNJPLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int OJAEAGPLFHN;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x804B2D0", Offset = "0x8049AD0", VA = "0x18804B2D0")]
	public HIPBLHCHABE(NativeList<HIGEDJNCICA.FABNLJLAMPJ> HGGPMIDILLK, NativeArray<int> DHHCOMHLEAI, int OJAEAGPLFHN = 0, int CEGIJNJPLLP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x804B220", Offset = "0x8049A20", VA = "0x18804B220", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class IJDKMPAABAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> LDGOFFKIBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> LAONOGOCMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> ANNBCDKCEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> HHBFOEHNLMA;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x804DD30", Offset = "0x804C530", VA = "0x18804DD30")]
	public void FJNOLPEALIM(int CHDNAOHPMCH, int FJNBBBLENEH, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x804DF40", Offset = "0x804C740", VA = "0x18804DF40")]
	public static long KJJGPHNLCDA(int CHDNAOHPMCH, int FJNBBBLENEH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x804DC40", Offset = "0x804C440", VA = "0x18804DC40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x804DE50", Offset = "0x804C650", VA = "0x18804DE50")]
	public void JGAHMDKPFDK(JobHandle GGAIACICGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IJDKMPAABAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct DEBFNDAMHKM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> MMNNEEJPNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> NEBBAAMKBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> CMAFOJOGEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> GAGFGMJKDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> NDLIBHEDOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CIJLIHGKMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> BIKHDMBMGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> FDFIOAMNFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> FLPIMGENNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int CEGIJNJPLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int OJAEAGPLFHN;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8047B20", Offset = "0x8046320", VA = "0x188047B20")]
	public DEBFNDAMHKM(LFBDKLHLLEO MLCGFPJFGFN, IJDKMPAABAF EGCIHGALNKK, int OJAEAGPLFHN = 0, int CEGIJNJPLLP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8047740", Offset = "0x8045F40", VA = "0x188047740", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x80476E0", Offset = "0x8045EE0", VA = "0x1880476E0")]
	private void EJGJAHFDEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class CLBAOJGNGMJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x37B9160", Offset = "0x37B7960", VA = "0x1837B9160")]
	public static bool MPDFKLAOPPK<T>(NativeArray<T> LPBOBEPEKNH, int GGIJOHIPOOO, Allocator GFNKGIEEHMD, NativeArrayOptions OJJIDCCJBBN = NativeArrayOptions.ClearMemory, int MOMGACDKPPF = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x37B92E0", Offset = "0x37B7AE0", VA = "0x1837B92E0")]
	public static bool MPDFKLAOPPK<T>(NativeList<T> NFJJCCDFOPE, int GGIJOHIPOOO, Allocator GFNKGIEEHMD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x37B9460", Offset = "0x37B7C60", VA = "0x1837B9460")]
	public static bool MPDFKLAOPPK<T>(NativeQueue<T> JPJPDMBLMLB, Allocator GFNKGIEEHMD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum MINHAAENPPC
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
public interface MGCOKLMPKHE
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NCDJJGEGGIE(MINHAAENPPC MBAOJAPNLMO);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DNMANGEJIPF(MINHAAENPPC MBAOJAPNLMO);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJKAECFHIHL ABLCOOHIHFO();

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float BPGCHGEMJMM();

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GHDNNMCFGGP(MINHAAENPPC MBAOJAPNLMO, HOIEJGKPIBK DNKMHAFNFJD, int IJPPMNMDMLO = -1);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KFGIEOMGMDL(int JPDMNMILEBF);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class OCBMLPNFLMM
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x805A860", Offset = "0x8059060", VA = "0x18805A860")]
	public static void NIKNJLKBDOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class BMMALOLOKAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> OJOEJNDGPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> MEAKDPMPCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> MCNCCCJDJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> ILOCBCIEHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> KPPHCCCGJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> DCKFCOIJPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> NMHJKJAKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> MPEJBDGIOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> AMAJJFAGHKC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8046190", Offset = "0x8044990", VA = "0x188046190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HLNAFGKHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8046150", Offset = "0x8044950", VA = "0x188046150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ODFEACMLMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x80462F0", Offset = "0x8044AF0", VA = "0x1880462F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8047060", Offset = "0x8045860", VA = "0x188047060")]
	public BMMALOLOKAO(int CHDNAOHPMCH, int FJNBBBLENEH, int JJMDBFGPDKD, Allocator GFNKGIEEHMD = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8047380", Offset = "0x8045B80", VA = "0x188047380")]
	public BMMALOLOKAO(Mesh MLCGFPJFGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x80461D0", Offset = "0x80449D0", VA = "0x1880461D0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8046330", Offset = "0x8044B30", VA = "0x188046330")]
	public void GJNOLKEIEHM(BMMALOLOKAO MLCGFPJFGFN, bool BLALAMCOMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x8046660", Offset = "0x8044E60", VA = "0x188046660")]
	private void HHAKHABEPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x8046AF0", Offset = "0x80452F0", VA = "0x188046AF0")]
	private void IEIBFIHODHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct LGIOMKNOMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int KFBNAEHFHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int KICNGCGAMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int EDOOEJMFEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int HLNAFGKHLJP;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2066F00", Offset = "0x2065700", VA = "0x182066F00")]
	public LGIOMKNOMGM(int CLDDLINECGI, int GDOBIAAONDM, int COEFDMIBPJJ, int KIHBHAHLAAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class JJIEIPFPHNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<LGIOMKNOMGM> MFHOLCPHCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LGIOMKNOMGM>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BMMALOLOKAO AJICNCIPKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8051B60", Offset = "0x8050360", VA = "0x188051B60")]
	public JJIEIPFPHNJ(IEnumerable<BMMALOLOKAO> IEIEGKJHFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8051AF0", Offset = "0x80502F0", VA = "0x188051AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum GIIAOJCFHJA
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class BHHMBGLPDJO
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> CMJMJAEELAF;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> JACGIIDANEG;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> MBGNBNMKANH;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> OCNGBPOHHPB;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x805F500", Offset = "0x805DD00", VA = "0x18805F500")]
	public static void NIKNJLKBDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x805F300", Offset = "0x805DB00", VA = "0x18805F300")]
	public static NativeArray<float2> FCKIFACMNIL(NativeArray<float2> BHNLANBLNCI, int MLPBOBGDNBA, NativeArray<float2> GPABIBOBAPC, int CJLOPPLLJHA)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x805F200", Offset = "0x805DA00", VA = "0x18805F200")]
	public static NativeArray<float3> CALBOPJJGHM(NativeArray<float3> BHNLANBLNCI, int MLPBOBGDNBA, NativeArray<float3> GPABIBOBAPC, int CJLOPPLLJHA)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x805F400", Offset = "0x805DC00", VA = "0x18805F400")]
	public static NativeArray<float4> MAGBOFDJCND(NativeArray<float4> BHNLANBLNCI, int MLPBOBGDNBA, NativeArray<float4> GPABIBOBAPC, int CJLOPPLLJHA)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x805F610", Offset = "0x805DE10", VA = "0x18805F610")]
	public static NativeArray<int> NMECHHJAOGO(NativeArray<int> BHNLANBLNCI, int MLPBOBGDNBA, NativeArray<int> GPABIBOBAPC, int CJLOPPLLJHA)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x372C620", Offset = "0x372AE20", VA = "0x18372C620")]
	private static void FIPNGLBNNMI<T>(NativeArray<T> LPBOBEPEKNH, int IJNGFKPEMMI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x372C540", Offset = "0x372AD40", VA = "0x18372C540")]
	private static void CEAIODKDCNC<T>(NativeArray<T> BHNLANBLNCI, int MLPBOBGDNBA, NativeArray<T> GPABIBOBAPC, int CJLOPPLLJHA, NativeArray<T> NDKDFNJIDIP) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class IJCKDOKJEDE
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct LNAJGPKJJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort BDGPJOKJNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort HDAFCDJNHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort GJHIHKIOKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort OINMFMCIDBM;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x8073120", Offset = "0x8071920", VA = "0x188073120")]
	public static uint GLMLPANAAMD(float EANGIJEJPFO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x80734B0", Offset = "0x8071CB0", VA = "0x1880734B0")]
	public static void MGAIKNINPFC(float4 CMAFOJOGEIH, float ICGIHDKHADC, [Out] uint HAKOPAECCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x80733E0", Offset = "0x8071BE0", VA = "0x1880733E0")]
	public static void MGAIKNINPFC(float4 CMAFOJOGEIH, uint NFKLGKGCBPE, [Out] uint HAKOPAECCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8072B50", Offset = "0x8071350", VA = "0x188072B50")]
	public static void DBEILLMIJFN(float3 HPDIJDOKJGJ, float3 ABKACIEMIMI, float4 OFDIOGCAHND, float2 AFFHJGKJDJJ, float4 CMAFOJOGEIH, [Out] LFBDKLHLLEO.INIOOBKFFMI OPJEDCKPPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8072DA0", Offset = "0x80715A0", VA = "0x188072DA0")]
	public static void DBEILLMIJFN(float3 HPDIJDOKJGJ, float3 ABKACIEMIMI, float4 OFDIOGCAHND, float2 AFFHJGKJDJJ, float4 CMAFOJOGEIH, [Out] LFBDKLHLLEO.DMODPHFANDL OPJEDCKPPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8073000", Offset = "0x8071800", VA = "0x188073000")]
	public static byte DELOOODNMNM(float MGONBEDEDON)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8073050", Offset = "0x8071850", VA = "0x188073050")]
	public static ushort EAHEJAMNKPB(float MGONBEDEDON)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x80735C0", Offset = "0x8071DC0", VA = "0x1880735C0")]
	public static uint OFLHBOLOLJF(float MGONBEDEDON)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x80730A0", Offset = "0x80718A0", VA = "0x1880730A0")]
	public static float2 GFIJAAPMIJE(float2 KENANDNBOGI)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x8073290", Offset = "0x8071A90", VA = "0x188073290")]
	public static float2 KCHJIAFBMBO(float3 IHGBDKLNHAA)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x80735F0", Offset = "0x8071DF0", VA = "0x1880735F0")]
	public static void PLBCACNAABO(float3 MGONBEDEDON, [Out] float3 EMOFFOCFCDP, [Out] uint3 OINMFMCIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8073130", Offset = "0x8071930", VA = "0x188073130")]
	public static LNAJGPKJJLM HNIDHFNMFFC(float3 KKEEFCOJJFM)
	{
		return default(LNAJGPKJJLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class PKNCHAHLMOL
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker JKIJLNFOAAO;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float OMLNKAJCOMF;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void KFGHJCCBILC(bool OMKHCMPGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x8077BE0", Offset = "0x80763E0", VA = "0x188077BE0")]
	public static float ALLPIPEDINH(float BAFGEOGMJCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x8077CF0", Offset = "0x80764F0", VA = "0x188077CF0")]
	public static long GMGCGKLMHCJ(float BAFGEOGMJCN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x8077DE0", Offset = "0x80765E0", VA = "0x188077DE0")]
	public static void OOAEEHHIBLD(float BAFGEOGMJCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface DFHGHKEHNOH
{
	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOAEEHHIBLD(float BNGDALPJGFJ);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) NLNENBBLDIF(float JAGEMKOFNJB);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class OIJGCOMFABA
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum FFHMNCEMCGM
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
	private class EMPJENBJNGO : LGLOPKBBHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public FFHMNCEMCGM CEPGAJKBPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public BatchedMeshRenderer CAEBJAMALMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public GNOFDELNAPC GCIENLGHNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public HIGEDJNCICA BEHJDJLPNMA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override float EKKGHIIFODE
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x1122AD0", Offset = "0x11212D0", VA = "0x181122AD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x1885970", Offset = "0x1884170", VA = "0x181885970", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x805FF30", Offset = "0x805E730", VA = "0x18805FF30", Slot = "7")]
		public override void BFIONFFGJIC([Out] bool EOPCAGCCHFC, [Out] bool CDHCDCGBBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EMPJENBJNGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int IGDLCLOBJNC;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int PLIPLOMCFHO;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int DCEGFNPEKOO;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long IBABJPJBLIF;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long MNLKOAAHBBI;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long CLCKCKKHPMF;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long MKEEOGJPEMB;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int HABBABEONOG;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float JDGPAJEFBIC;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool CCNBIPJDPDJ;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int CFNEADNFNEB;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int HOLICACEFGH;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int CLMJCHDNKCF;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long FENNIPKPBMA;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int KLLNDOHLGBP;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool PCMKGDIDCFE;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static uint NFDLCPOIJIJ;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static DPNIAPJLGMP KEINPIKJDCG;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static List<uint> FPIBKDIBHJO;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static DFHGHKEHNOH BGMLEPFFGHK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool JAFHOAKOEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8077510", Offset = "0x8075D10", VA = "0x188077510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void LJOCEDLABNK(bool OMKHCMPGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void KFGHJCCBILC(bool OMKHCMPGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void LJOCEDLABNK(bool OMKHCMPGIAL, string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8074D10", Offset = "0x8073510", VA = "0x188074D10")]
	public static void MLGBJKDLOEH(DFHGHKEHNOH DILKKEAKNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8077350", Offset = "0x8075B50", VA = "0x188077350")]
	public static (long, long, long, int, int) PCPJLCCABAC(long NMONOKGAFDL)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8074D80", Offset = "0x8073580", VA = "0x188074D80")]
	public static void MPNKGABBHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8075200", Offset = "0x8073A00", VA = "0x188075200")]
	public static void OOAEEHHIBLD(long NMONOKGAFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8073B30", Offset = "0x8072330", VA = "0x188073B30")]
	public static void CBPOMBENKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8073CB0", Offset = "0x80724B0", VA = "0x188073CB0")]
	public static long CDDBEJOHMNB(long BHAIICEJJPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8074AB0", Offset = "0x80732B0", VA = "0x188074AB0")]
	public static bool IPICBCMLAHF(long KONKMDLEIFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8073950", Offset = "0x8072150", VA = "0x188073950")]
	public static bool BCEJAMDLJOM(long KONKMDLEIFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8073F00", Offset = "0x8072700", VA = "0x188073F00")]
	public static float FKIIBONFGPB(long MJOLFMOFKHJ, int OFMHBMNNDIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8074E00", Offset = "0x8073600", VA = "0x188074E00")]
	public static (long, long, int) NLNENBBLDIF(float BAFGEOGMJCN)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8074B80", Offset = "0x8073380", VA = "0x188074B80")]
	public static void JNMDDCJCLKE(HIGEDJNCICA BEHJDJLPNMA, BatchedMeshRenderer CAEBJAMALMN, long NBPCIKOEPAH, long IAMECCFEAGL, float JKOELGCNICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8074640", Offset = "0x8072E40", VA = "0x188074640")]
	public static void INFKKKONPPC(HIGEDJNCICA BEHJDJLPNMA, BatchedMeshRenderer CAEBJAMALMN, long NBPCIKOEPAH, long IAMECCFEAGL, float NFHALIKBAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8074490", Offset = "0x8072C90", VA = "0x188074490")]
	public static void ICDMEFOEBCI(HIGEDJNCICA BEHJDJLPNMA, BatchedMeshRenderer CAEBJAMALMN, long IAMECCFEAGL, float NFHALIKBAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x80742E0", Offset = "0x8072AE0", VA = "0x1880742E0")]
	public static void GPLEHLMPJJA(HIGEDJNCICA BEHJDJLPNMA, BatchedMeshRenderer CAEBJAMALMN, long NBPCIKOEPAH, long IAMECCFEAGL, float NFHALIKBAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x80747C0", Offset = "0x8072FC0", VA = "0x1880747C0")]
	private static void IOIPBIGNELO(FFHMNCEMCGM CEPGAJKBPDM, HIGEDJNCICA BEHJDJLPNMA, GNOFDELNAPC GCIENLGHNHB, BatchedMeshRenderer CAEBJAMALMN, long NBPCIKOEPAH, long IAMECCFEAGL, float LOFJBHLGGMB, bool IMCKOKAMJDD, bool FBNJPGOHHAN, float IAOOMFIBPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8073E50", Offset = "0x8072650", VA = "0x188073E50")]
	public static bool CKBBKIDAIOI(float BIAAPOMMDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x80738E0", Offset = "0x80720E0", VA = "0x1880738E0")]
	public static void AJEMIPOPIIK(float BIAAPOMMDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8073A20", Offset = "0x8072220", VA = "0x188073A20")]
	public static bool BEJDOAHBCBF(float BIAAPOMMDPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class LGLOPKBBHAJ : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum GLDFEDAGAII : byte
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
	public GLDFEDAGAII AHMJPMPNIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public long EAJAOCBGAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public long IAMECCFEAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public float NPOAMFLDEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public bool FBNJPGOHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool IMCKOKAMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	internal uint EBHOIBHGECB;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract float EKKGHIIFODE
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
	public abstract void BFIONFFGJIC([Out] bool EOPCAGCCHFC, [Out] bool CDHCDCGBBJG);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x80737C0", Offset = "0x8071FC0", VA = "0x1880737C0", Slot = "4")]
	public int CompareTo(object HPLLAPMNIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected LGLOPKBBHAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class DPNIAPJLGMP : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private List<LGLOPKBBHAJ> NGOBADEAEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private List<LGLOPKBBHAJ> BEIFLCOMFDB;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x805F8B0", Offset = "0x805E0B0", VA = "0x18805F8B0")]
	public void GGGBGBDKNKJ(LGLOPKBBHAJ NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x805F850", Offset = "0x805E050", VA = "0x18805F850")]
	public void DCCHDFOHILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x805F7C0", Offset = "0x805DFC0", VA = "0x18805F7C0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x805FAA0", Offset = "0x805E2A0", VA = "0x18805FAA0")]
	public void MKAFGDFPMHM(IEnumerable<uint> FPIBKDIBHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x805F980", Offset = "0x805E180", VA = "0x18805F980")]
	private void HKOLMKDGPPH(uint EBHOIBHGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x805FDD0", Offset = "0x805E5D0", VA = "0x18805FDD0", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x805FA40", Offset = "0x805E240", VA = "0x18805FA40")]
	public PAHBEDIGFKG KFPOPIJHFBP()
	{
		return default(PAHBEDIGFKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x805FE70", Offset = "0x805E670", VA = "0x18805FE70")]
	public DPNIAPJLGMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct PAHBEDIGFKG : IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private List<LGLOPKBBHAJ> NGOBADEAEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private List<LGLOPKBBHAJ> BEIFLCOMFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int JEBBCHNGOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private int NBFJDCCPDOG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8077B90", Offset = "0x8076390", VA = "0x188077B90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LGLOPKBBHAJ EBPBANINJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8077870", Offset = "0x8076070", VA = "0x188077870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8077BA0", Offset = "0x80763A0", VA = "0x188077BA0")]
	public PAHBEDIGFKG(List<LGLOPKBBHAJ> NGOBADEAEKO, List<LGLOPKBBHAJ> BEIFLCOMFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x80779F0", Offset = "0x80761F0", VA = "0x1880779F0", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8077B80", Offset = "0x8076380", VA = "0x188077B80", Slot = "6")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class GNOFDELNAPC
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal enum JFCEMNCKNHI
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
	public static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly string MMDDGMMJHMB;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly string HNOEOPLKFJM;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker BDALPOEDBDN;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker MHOFBNEOFCK;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker JKIJLNFOAAO;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker PJNHFCEDEHK;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker IDLBKKJHOJH;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker KKBKKLLLMNL;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker PCOAJPNOKKJ;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker NCEAICJLPDK;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker EMPMBNKEMLD;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker OCMCOODAOMJ;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker DGKJKIHCHJC;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker IGGIFMNPMGG;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker HPKLBEAONHM;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker KGIKLLLGNND;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker DOEIBJMLPJI;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker DAOJOHAKFDK;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker NHAJFEEALEJ;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker ABEEEHCLCAP;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly ProfilerMarker POCKHFBPJLG;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly ProfilerMarker KIADLMACJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly ProfilerMarker BEKJOLEEJMP;

	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static readonly ProfilerMarker NANDIDDABCO;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly ProfilerMarker JECGKKPFAPD;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly ProfilerMarker HBAHNOACIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal readonly List<HIGEDJNCICA> ODPLDFPOBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	internal HIGEDJNCICA HKGIIEGPCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly IJJNNKCGKIG BKMLBNKIOFI;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public const bool NHOPGMABMDC = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public bool OHAPFAKHDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	internal JFCEMNCKNHI AFKBPIKHEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	internal int KOPAKDJDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	internal int PJEFLGNHDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	internal int ICBCNDEJLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	internal int CNLPNJPKHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	internal long LMIBCIDOKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	internal long BPCGNOFGFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	internal long JLIEHBHODHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private LFBDKLHLLEO GDLKJIDDDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private LFBDKLHLLEO DKFHPDDLKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private LFBDKLHLLEO.OAAKKIKOAJE MPOCICOPFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private bool MLMFIBPOCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private int NBCICPLDKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private LHKNFDAMOFF FAKAENPGJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private float3 PDBBIOFPFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private float ILDPELPIBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private float FNCKAMLHABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float JJFONALDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private float ANGGEGHNOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float PIAMPKNGNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private float PLFNFKPCELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private float3 IAMPDJBKOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float IGNGABODFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private float KPMIHPNAPIF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal Mesh AJICNCIPKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MeshFilter LHAKHNEIIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MeshRenderer IEIKLJNEJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<Material> GGPAPGBALNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int OEDMHPLDFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x80612A0", Offset = "0x805FAA0", VA = "0x1880612A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HKMFIMGHPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA877D0", Offset = "0xA85FD0", VA = "0x180A877D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x80611E0", Offset = "0x805F9E0", VA = "0x1880611E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8061DC0", Offset = "0x80605C0", VA = "0x188061DC0")]
	public void HJHGINHEIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x80627A0", Offset = "0x8060FA0", VA = "0x1880627A0")]
	public bool NEAIEFNBCHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8064AE0", Offset = "0x80632E0", VA = "0x188064AE0")]
	private void PEPFCDNKJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x80616C0", Offset = "0x805FEC0", VA = "0x1880616C0")]
	private void DOGODLDLGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8065820", Offset = "0x8064020", VA = "0x188065820")]
	public GNOFDELNAPC(string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x80623C0", Offset = "0x8060BC0", VA = "0x1880623C0")]
	public void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8062700", Offset = "0x8060F00", VA = "0x188062700")]
	private void MIIKHDGKDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x80637A0", Offset = "0x8061FA0", VA = "0x1880637A0")]
	private void OANHMPFFHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8061210", Offset = "0x805FA10", VA = "0x188061210")]
	public Mesh DFBNMODBPIG(MeshFilter EBOCNBPJGFB, Transform KCODNJGBFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x80620C0", Offset = "0x80608C0", VA = "0x1880620C0")]
	private void IKNEDBDOIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x8061930", Offset = "0x8060130", VA = "0x188061930")]
	public void EPDPODEMOHI(MGCOKLMPKHE CLLPKCGDMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x8061AB0", Offset = "0x80602B0", VA = "0x188061AB0")]
	public bool FGAPAMCFJOI(MGCOKLMPKHE CLLPKCGDMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x8061EF0", Offset = "0x80606F0", VA = "0x188061EF0")]
	public bool HKLOAKDICEJ(MGCOKLMPKHE CLLPKCGDMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x8060830", Offset = "0x805F030", VA = "0x188060830", Slot = "4")]
	public virtual void CABFCBMPENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x8064770", Offset = "0x8062F70", VA = "0x188064770")]
	public void PCNFLGHIEEK(Transform IDAPFNDMOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x8062C40", Offset = "0x8061440", VA = "0x188062C40")]
	public bool NNMBEBGGJOL(Transform IDAPFNDMOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x8060950", Offset = "0x805F150", VA = "0x188060950")]
	public bool CCCJLMPJEND(bool PNPIJJKLPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x8061810", Offset = "0x8060010", VA = "0x188061810")]
	private void EHPHFJLHNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x8063A30", Offset = "0x8062230", VA = "0x188063A30")]
	public bool OOAEEHHIBLD(float4x4 IPFGPMNNMGF, BatchedMeshRenderer OHGGPIHOFEO, bool MMLBGHBPNDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x8064C80", Offset = "0x8063480", VA = "0x188064C80")]
	public bool PLLHENGNNJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x8064730", Offset = "0x8062F30", VA = "0x188064730")]
	public void PCHFJJOKFNM(LFBDKLHLLEO MLCGFPJFGFN, int FNKLMBCPNKP, int AKHOJNBPIDP, float AKOHEEGBADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x8064C00", Offset = "0x8063400", VA = "0x188064C00")]
	public (long, long, long) PJNOPFHKAJF()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
	public long GNONBDFHFJC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x80612C0", Offset = "0x805FAC0", VA = "0x1880612C0")]
	private void DOEIANONDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x80629D0", Offset = "0x80611D0", VA = "0x1880629D0")]
	public (long, long, int) NLNENBBLDIF(float BAFGEOGMJCN, float4x4 IPFGPMNNMGF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x8060390", Offset = "0x805EB90", VA = "0x188060390")]
	internal void BACEFKEHAHD(JFCEMNCKNHI MDEIKAOMPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8063090", Offset = "0x8061890", VA = "0x188063090")]
	internal (float, float, float, float) NNOFMKKMIIL(float PFNHEBCJLOP, float4x4 IPFGPMNNMGF)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x8061BA0", Offset = "0x80603A0", VA = "0x188061BA0")]
	public void GFKOFNLLKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x80621C0", Offset = "0x80609C0", VA = "0x1880621C0")]
	private void JFOKEPIPPMI(LFBDKLHLLEO IEBCBIEHAMC, LFBDKLHLLEO.OAAKKIKOAJE GHLNOPDKPAN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8061B80", Offset = "0x8060380", VA = "0x188061B80")]
	private void FNGAPJLMMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x80628C0", Offset = "0x80610C0", VA = "0x1880628C0")]
	internal bool NLCGDGLNPDK(bool PNPIJJKLPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x80613E0", Offset = "0x805FBE0", VA = "0x1880613E0")]
	private void DOGNIHPDKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8060450", Offset = "0x805EC50", VA = "0x188060450")]
	private void BLPAHMHAICK([In] BMIINENNNOF IEBCBIEHAMC, LFBDKLHLLEO.OAAKKIKOAJE GHLNOPDKPAN, bool HAGAJDFPLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x80603B0", Offset = "0x805EBB0", VA = "0x1880603B0")]
	private void BKDPIMBADNJ(LFBDKLHLLEO.OAAKKIKOAJE GHLNOPDKPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8061890", Offset = "0x8060090", VA = "0x188061890")]
	private void EKJODGBGNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8061F80", Offset = "0x8060780", VA = "0x188061F80")]
	private void IKBMDDONKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8060F00", Offset = "0x805F700", VA = "0x188060F00")]
	public long CDDBEJOHMNB(long BHAIICEJJPL, int AFOHIPJDLCA)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class HIGEDJNCICA
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum DDDAMBGMIKH
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
	public struct FABNLJLAMPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int JPGKLKLGGMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int OOGMCHHLIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public float CKKHPFPKMIF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct DDGCAFCEANA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public BMIINENNNOF MLCGFPJFGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int ALHIJDNGFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int HFODNNAJHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public long MADMHBFLPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public long BGHNODPICNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public float EGCJHHAGOAO;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x805F710", Offset = "0x805DF10", VA = "0x18805F710")]
		public void HNPKBJNJFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x805F740", Offset = "0x805DF40", VA = "0x18805F740")]
		public void JGAHMDKPFDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly string MMDDGMMJHMB;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly string HNOEOPLKFJM;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker BDALPOEDBDN;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker MHOFBNEOFCK;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker JKIJLNFOAAO;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker PJNHFCEDEHK;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker IDLBKKJHOJH;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker KKBKKLLLMNL;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker PCOAJPNOKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker NCEAICJLPDK;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker EMPMBNKEMLD;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker OCMCOODAOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly ProfilerMarker DGKJKIHCHJC;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly ProfilerMarker IGGIFMNPMGG;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly ProfilerMarker HPKLBEAONHM;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly ProfilerMarker KGIKLLLGNND;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly ProfilerMarker DOEIBJMLPJI;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly ProfilerMarker DAOJOHAKFDK;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly ProfilerMarker NHAJFEEALEJ;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly ProfilerMarker ABEEEHCLCAP;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static readonly ProfilerMarker POCKHFBPJLG;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly ProfilerMarker KIADLMACJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly ProfilerMarker BEKJOLEEJMP;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly ProfilerMarker NANDIDDABCO;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly ProfilerMarker JECGKKPFAPD;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly ProfilerMarker HBAHNOACIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal readonly List<MGCOKLMPKHE> GDNAPNPEGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal GNOFDELNAPC IONEJHEPOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private readonly IJJNNKCGKIG BKMLBNKIOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal int GCAPGANNPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal int KBDOMFEMBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal bool PPEAAKLKEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal bool DKGPKKPEEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal DDDAMBGMIKH MNDFFMMIHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal bool KHIDJACLAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal float3 BDAJLLMMEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal float3 CEFEDIELECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal float FELLKGEGPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int NJBOFPNCNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal int GMCEGGHENNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal float LKIDCOIDNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal float LHFIHCCKFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal int MKGLJPGGNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal long NMJFECJPAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public int HDJPAAGNCFG;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal const int NIHMCODKADG = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float[] NNLIMAIGDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal int[] ECCBFICAIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal long[] NCBKIFLIOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public List<DDGCAFCEANA> NPNNEIFPJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal LFBDKLHLLEO GOCNFOLJDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal long HBPMGMIOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal int EDECALJICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal float JBGHBKLDDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal LFBDKLHLLEO.OAAKKIKOAJE JJHCCAKCCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal bool DAINBCLHMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	internal GOHNAPMFMCK INFIELKNLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal JobHandle EBONIGJLGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal NativeList<FABNLJLAMPJ> BIONJFKHJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal NativeArray<long> KFBGBCEGNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal bool JIMCNMMEFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	internal JobHandle NHBMCECLPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal LFBDKLHLLEO BKEKNMGJJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	internal IJDKMPAABAF EMOIOGAPLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	internal NativeList<FABNLJLAMPJ> DGIPMGNJADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	internal Transform APEGGKPODCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	internal MINHAAENPPC OFDEFAFOIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	internal long PPMOBDLJDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	internal long CIFJEKONJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	internal long KHMEGEKOMLN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<MGCOKLMPKHE> NHODGFONCMF
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x806A810", Offset = "0x8069010", VA = "0x18806A810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x806CB00", Offset = "0x806B300", VA = "0x18806CB00")]
	internal void HJHGINHEIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x8071BE0", Offset = "0x80703E0", VA = "0x188071BE0")]
	internal void PEPFCDNKJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x8072830", Offset = "0x8071030", VA = "0x188072830")]
	internal HIGEDJNCICA(string HPANEBBHGAC, GNOFDELNAPC MJNLMOPPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x806D900", Offset = "0x806C100", VA = "0x18806D900")]
	internal void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x806D670", Offset = "0x806BE70", VA = "0x18806D670")]
	internal void IKNEDBDOIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x806B8D0", Offset = "0x806A0D0", VA = "0x18806B8D0")]
	internal void EPDPODEMOHI(MGCOKLMPKHE CLLPKCGDMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x806BB40", Offset = "0x806A340", VA = "0x18806BB40")]
	internal bool FGAPAMCFJOI(MGCOKLMPKHE CLLPKCGDMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x806CB10", Offset = "0x806B310", VA = "0x18806CB10")]
	internal bool HKLOAKDICEJ(MGCOKLMPKHE CLLPKCGDMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8069410", Offset = "0x8067C10", VA = "0x188069410", Slot = "4")]
	internal virtual void CABFCBMPENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x80720F0", Offset = "0x80708F0", VA = "0x1880720F0")]
	internal long PPDHIEBNDKE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x806D240", Offset = "0x806BA40", VA = "0x18806D240")]
	internal long IIMHIPGBEKM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x806EF80", Offset = "0x806D780", VA = "0x18806EF80")]
	internal bool NNMBEBGGJOL(Transform IDAPFNDMOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x80694A0", Offset = "0x8067CA0", VA = "0x1880694A0")]
	internal (bool, LFBDKLHLLEO) CCCJLMPJEND(bool PNPIJJKLPBK)
	{
		return default((bool, LFBDKLHLLEO));
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x806B170", Offset = "0x8069970", VA = "0x18806B170")]
	internal void EHPHFJLHNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x8070480", Offset = "0x806EC80", VA = "0x188070480")]
	internal bool OOAEEHHIBLD(float4x4 IPFGPMNNMGF, BatchedMeshRenderer OHGGPIHOFEO, bool MMLBGHBPNDM, bool FIJDGGAJFCP, float FNCKAMLHABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x8071DA0", Offset = "0x80705A0", VA = "0x188071DA0")]
	public (bool, BMIINENNNOF) PLLHENGNNJJ()
	{
		return default((bool, BMIINENNNOF));
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x8070400", Offset = "0x806EC00", VA = "0x188070400")]
	internal void OCLLDAGPHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x806DA50", Offset = "0x806C250", VA = "0x18806DA50")]
	internal bool JHHAIPHJFKN(bool PNPIJJKLPBK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x806BBC0", Offset = "0x806A3C0", VA = "0x18806BBC0")]
	internal void FJKMKMCJCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x8071BB0", Offset = "0x80703B0", VA = "0x188071BB0")]
	internal void PCHFJJOKFNM(LFBDKLHLLEO MLCGFPJFGFN, int FNKLMBCPNKP, int AKHOJNBPIDP, float AKOHEEGBADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x806DDE0", Offset = "0x806C5E0", VA = "0x18806DDE0")]
	internal void KKNBHBJGDBK(BMIINENNNOF FCCINODJDFM, int FNKLMBCPNKP, int AKHOJNBPIDP, float AKOHEEGBADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x806AD80", Offset = "0x8069580", VA = "0x18806AD80")]
	internal void DOEIANONDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x806EB20", Offset = "0x806D320", VA = "0x18806EB20")]
	internal (long, long, int) NLNENBBLDIF(float BAFGEOGMJCN, float4x4 IPFGPMNNMGF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x80693C0", Offset = "0x8067BC0", VA = "0x1880693C0")]
	internal void BACEFKEHAHD(DDDAMBGMIKH MDEIKAOMPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x806FC20", Offset = "0x806E420", VA = "0x18806FC20")]
	internal (float, float, float, float) NNOFMKKMIIL(float PFNHEBCJLOP, float4x4 IPFGPMNNMGF)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x806DD80", Offset = "0x806C580", VA = "0x18806DD80")]
	private float KBHMFPHNMLA(float PFNHEBCJLOP, float4x4 IPFGPMNNMGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x806A830", Offset = "0x8069030", VA = "0x18806A830")]
	private (int, int) CPLAIEGIJHD(float PPLBKOMDOGP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x806ACE0", Offset = "0x80694E0", VA = "0x18806ACE0")]
	internal static float DDOFIBAPCLJ(MGCOKLMPKHE MLCGFPJFGFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x806BBD0", Offset = "0x806A3D0", VA = "0x18806BBD0")]
	internal void GFKOFNLLKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x806B8A0", Offset = "0x806A0A0", VA = "0x18806B8A0")]
	internal void EKJODGBGNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x806D350", Offset = "0x806BB50", VA = "0x18806D350")]
	internal void IKBMDDONKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x806A0D0", Offset = "0x80688D0", VA = "0x18806A0D0")]
	internal long CDDBEJOHMNB(long BHAIICEJJPL, int AFOHIPJDLCA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8068310", Offset = "0x8066B10", VA = "0x188068310")]
	private void AIDCFLIMHEN(LFBDKLHLLEO ODHHAOIMFNJ, NativeList<FABNLJLAMPJ> KCCPKIHFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8068F50", Offset = "0x8067750", VA = "0x188068F50")]
	internal void ANOOPHDHLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x806CB70", Offset = "0x806B370", VA = "0x18806CB70")]
	public static void IDMLJACAOCO(NativeList<FABNLJLAMPJ> KBCIFGNLCPO, LFBDKLHLLEO ODHHAOIMFNJ, int NPGNMJFHMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x806E060", Offset = "0x806C860", VA = "0x18806E060")]
	private float MFFGNNOPMLA(int KOHPDOJFCJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x806E0F0", Offset = "0x806C8F0", VA = "0x18806E0F0")]
	internal void MOCEOHEMLHC(LFBDKLHLLEO MLCGFPJFGFN, EALNNBFFPDP FCCINODJDFM, int FNKLMBCPNKP, int AKHOJNBPIDP, float AKOHEEGBADD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BurstCompile]
internal struct HEPNDIEMHLK : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal struct ICNIMOHLLMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int OCCMNOMOGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int BGGFGNMIDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int PKIAJEBOKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public float LBAICGBNLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float KFMMIPGLDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public float DJHLJJIEPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public float BKFNHIJCJLK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	internal struct DBCMCICNPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int OCCMNOMOGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int BGGFGNMIDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int PKIAJEBOKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int OHLPOJBBBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public float LBAICGBNLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public float KFMMIPGLDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public float JGLCJHGODEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public float GKPGBBCBACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public float BKFNHIJCJLK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public struct NFHLCDJOEEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int CHLIIBOCEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int BDCEDJMHLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public float CPNNDHHLPNO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public delegate void NFCCFFMLDCK(HEPNDIEMHLK EIJBAJHFNNM, [In] ICNIMOHLLMM IDBIHMECOJN);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class IBPGFPGPDBA
	{
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8088B10", Offset = "0x8087310", VA = "0x188088B10")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8088EB0", Offset = "0x80876B0", VA = "0x188088EB0")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8088E10", Offset = "0x8087610", VA = "0x188088E10")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8088C30", Offset = "0x8087430", VA = "0x188088C30")]
		public static void DMJBMMIBENB(HEPNDIEMHLK EIJBAJHFNNM, [In] ICNIMOHLLMM IDBIHMECOJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void EOFBOCHNJCA(HEPNDIEMHLK EIJBAJHFNNM, [In] DBCMCICNPKP LHGMLEPHLJA);

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal static class MGIBJMKHJBG
	{
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x808A790", Offset = "0x8088F90", VA = "0x18808A790")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x808AB30", Offset = "0x8089330", VA = "0x18808AB30")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x808AA90", Offset = "0x8089290", VA = "0x18808AA90")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x808A8B0", Offset = "0x80890B0", VA = "0x18808A8B0")]
		public static void DMJBMMIBENB(HEPNDIEMHLK EIJBAJHFNNM, [In] DBCMCICNPKP LHGMLEPHLJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public unsafe delegate void CGKBHMJMAOI(UnsafeList<int>* BEBOAJEIICM, UnsafeList<float3>* PCPLKHEOPNL, [NoAlias] float3* DDLOGBPOAOD, [NoAlias] float4* JAMBKHABEFC, [NoAlias] float2* HOPCMNFHNNH, [NoAlias] float4* BJDFDPGIDHO, UnsafeList<CPBFELIEAMG>* KPADIFGNCAI, UnsafeList<int>* DOMAIKLDJIB, UnsafeList<float3>* JMDPGKFOPMA, [NoAlias] float3* IOKAODOMGEJ, [NoAlias] float4* IGPKPKCEIHD, [NoAlias] float2* LFHBGHHEHHD, [NoAlias] float4* OGAGPLHOIFD, int FJNBBBLENEH, int CHDNAOHPMCH);

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal static class MIIFDPGGOLM
	{
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x808AC80", Offset = "0x8089480", VA = "0x18808AC80")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x808B170", Offset = "0x8089970", VA = "0x18808B170")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x808B0D0", Offset = "0x80898D0", VA = "0x18808B0D0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x808ADA0", Offset = "0x80895A0", VA = "0x18808ADA0")]
		public unsafe static void DMJBMMIBENB(UnsafeList<int>* BEBOAJEIICM, UnsafeList<float3>* PCPLKHEOPNL, [NoAlias] float3* DDLOGBPOAOD, [NoAlias] float4* JAMBKHABEFC, [NoAlias] float2* HOPCMNFHNNH, [NoAlias] float4* BJDFDPGIDHO, UnsafeList<CPBFELIEAMG>* KPADIFGNCAI, UnsafeList<int>* DOMAIKLDJIB, UnsafeList<float3>* JMDPGKFOPMA, [NoAlias] float3* IOKAODOMGEJ, [NoAlias] float4* IGPKPKCEIHD, [NoAlias] float2* LFHBGHHEHHD, [NoAlias] float4* OGAGPLHOIFD, int FJNBBBLENEH, int CHDNAOHPMCH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public float3 PDBBIOFPFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public float NLPPDOOMJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public float LJCFDJNBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public float LOLMIFBLHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public GMHCDHCFFAJ.AGANFFFJNLN MADCIGPKKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public bool NEBEMBPLMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<CPBFELIEAMG>* KPADIFGNCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* DOMAIKLDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<ICNIMOHLLMM>* DMEBEIAPFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<ICNIMOHLLMM>* GAKALEDPOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<DBCMCICNPKP>* OCDMHBOAEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<DBCMCICNPKP>* EMFBPHAPKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public int PJKMMGDLLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public int FJHAIIPEDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public int HFPDKCONMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe float3* JMDPGKFOPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe int* HDADHKIIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe NFHLCDJOEEE* EBAHALBPMDD;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8067B80", Offset = "0x8066380", VA = "0x188067B80")]
	private static float MCEIPHMPDOO([In] HEPNDIEMHLK EIJBAJHFNNM, [In] float3 FFJELMKIPON, float BKFNHIJCJLK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x8067A00", Offset = "0x8066200", VA = "0x188067A00")]
	private static int LOHAFICIDIF(HEPNDIEMHLK EIJBAJHFNNM, [Out] CPBFELIEAMG HDAJIMKGGND, [In] CPBFELIEAMG AFHFCDMPBCA, [In] CPBFELIEAMG GABDMMMACFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x80679A0", Offset = "0x80661A0", VA = "0x1880679A0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void LNLNAEJAEIJ(HEPNDIEMHLK EIJBAJHFNNM, [In] ICNIMOHLLMM IDBIHMECOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8067940", Offset = "0x8066140", VA = "0x188067940")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void LEOJHIKCMCC(HEPNDIEMHLK EIJBAJHFNNM, [In] DBCMCICNPKP LHGMLEPHLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x8066B70", Offset = "0x8065370", VA = "0x188066B70", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x8066C10", Offset = "0x8065410", VA = "0x188066C10")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal void KHCIGKLHIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x8066B80", Offset = "0x8065380", VA = "0x188066B80")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void FDCNLBNGLAM(UnsafeList<int>* BEBOAJEIICM, UnsafeList<float3>* PCPLKHEOPNL, [NoAlias] float3* DDLOGBPOAOD, [NoAlias] float4* JAMBKHABEFC, [NoAlias] float2* HOPCMNFHNNH, [NoAlias] float4* BJDFDPGIDHO, UnsafeList<CPBFELIEAMG>* KPADIFGNCAI, UnsafeList<int>* DOMAIKLDJIB, UnsafeList<float3>* JMDPGKFOPMA, [NoAlias] float3* IOKAODOMGEJ, [NoAlias] float4* IGPKPKCEIHD, [NoAlias] float2* LFHBGHHEHHD, [NoAlias] float4* OGAGPLHOIFD, int FJNBBBLENEH, int CHDNAOHPMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x80659C0", Offset = "0x80641C0", VA = "0x1880659C0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void AFOIDKJPNOK(HEPNDIEMHLK EIJBAJHFNNM, [In] ICNIMOHLLMM IDBIHMECOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x8066360", Offset = "0x8064B60", VA = "0x188066360")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void CBEJLLHIMMM(HEPNDIEMHLK EIJBAJHFNNM, [In] DBCMCICNPKP LHGMLEPHLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x8067C00", Offset = "0x8066400", VA = "0x188067C00")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void OALOKBLBPDC(UnsafeList<int>* BEBOAJEIICM, UnsafeList<float3>* PCPLKHEOPNL, [NoAlias] float3* DDLOGBPOAOD, [NoAlias] float4* JAMBKHABEFC, [NoAlias] float2* HOPCMNFHNNH, [NoAlias] float4* BJDFDPGIDHO, UnsafeList<CPBFELIEAMG>* KPADIFGNCAI, UnsafeList<int>* DOMAIKLDJIB, UnsafeList<float3>* JMDPGKFOPMA, [NoAlias] float3* IOKAODOMGEJ, [NoAlias] float4* IGPKPKCEIHD, [NoAlias] float2* LFHBGHHEHHD, [NoAlias] float4* OGAGPLHOIFD, int FJNBBBLENEH, int CHDNAOHPMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class LHKNFDAMOFF
{
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly ProfilerMarker KFKIGBAMKEM;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public const int PMGKCICOJLF = 2;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private const int EHLLPEIKKJB = 1;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private static int JGAMFJFAPEL;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private static Stack<LHKNFDAMOFF> OMGNCGLLMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private LFBDKLHLLEO NBDEKMJMNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private NativeList<CPBFELIEAMG> KPADIFGNCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private NativeList<int> DOMAIKLDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private NativeList<HEPNDIEMHLK.ICNIMOHLLMM> DMEBEIAPFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private NativeList<HEPNDIEMHLK.ICNIMOHLLMM> GAKALEDPOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private NativeList<HEPNDIEMHLK.DBCMCICNPKP> OCDMHBOAEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private NativeList<HEPNDIEMHLK.DBCMCICNPKP> EMFBPHAPKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private HEPNDIEMHLK EIJBAJHFNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private JobHandle GGAIACICGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private HEPNDIEMHLK.NFHLCDJOEEE GECCBHGFCHB;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private const int HFPDKCONMEF = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x808A5F0", Offset = "0x8088DF0", VA = "0x18808A5F0")]
	private LHKNFDAMOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8089870", Offset = "0x8088070", VA = "0x188089870")]
	public void KMABFDLNMKG(LFBDKLHLLEO HFLMBEMDHGE, float3 GMJNMGFGIBO, float IAFAKEFACJA, float OBKHIPMCCBJ, float DCEOOBONEEA, List<HIGEDJNCICA.FABNLJLAMPJ> HLIKEHAOJMI, Allocator KCGADAABIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8089CB0", Offset = "0x80884B0", VA = "0x188089CB0")]
	public (bool, LFBDKLHLLEO, float) NCNCODFLNGD(List<HIGEDJNCICA.FABNLJLAMPJ> HLIKEHAOJMI, Allocator KCGADAABIKF, bool PNPIJJKLPBK)
	{
		return default((bool, LFBDKLHLLEO, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x80896C0", Offset = "0x8087EC0", VA = "0x1880896C0")]
	public static bool JFDEPLKOMKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8089650", Offset = "0x8087E50", VA = "0x188089650")]
	public static int FDDIAEGFHPF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8089710", Offset = "0x8087F10", VA = "0x188089710")]
	public static LHKNFDAMOFF JKNKDOHNDMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x808A2E0", Offset = "0x8088AE0", VA = "0x18808A2E0")]
	internal static void NDGEOICLLAG(LHKNFDAMOFF JKGPFJLKFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x80894F0", Offset = "0x8087CF0", VA = "0x1880894F0")]
	public static void BPCELGKGPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x808A370", Offset = "0x8088B70", VA = "0x18808A370")]
	[IDECILCAMBG(GNJLFMHIMOJ.ExitingPlayMode, 0)]
	public static void NIKNJLKBDOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BurstCompile]
internal struct CPBFELIEAMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public float3 HFIBPPGFFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public int GAPGJBOAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public int LFMPHICKFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public int FFIEFPLNAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public float GIKEDJEJNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public float FBDBEHPBGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public int PHFFKFMNBKJ;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x8081760", Offset = "0x807FF60", VA = "0x188081760")]
	public static void INHDMBAMCNE([Out] CPBFELIEAMG KJCFPPKBAOB, int MDINEGNIDPC, [In] float3 IJCMONMMEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x80817B0", Offset = "0x807FFB0", VA = "0x1880817B0")]
	[IgnoreWarning(1371)]
	public static void INHDMBAMCNE([Out] CPBFELIEAMG KJCFPPKBAOB, [In] CPBFELIEAMG ANPHCPJJGOJ, [In] CPBFELIEAMG MPMMLNOGKFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BurstCompile]
internal struct GOHNAPMFMCK : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct ONJFOGEGOOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int NHBFIDKPPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int IFMDCIFOOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int NJKBHOJLIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int JJGECIGDINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int CHPHFBLNCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int GDMPKLFGAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int ALHIJDNGFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public int HFODNNAJHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public float EGCJHHAGOAO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private struct BECBIGJMFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public GMHCDHCFFAJ.EAJKEJDGOIP ALCFEDIOHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public float KAJCOEMHAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public float JICPFCLCDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public float JLFFELLHECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public float PGPDALEONFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public float DOIGKGNNPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public float GPJAFBDOJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public float NILHGCEENKO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private struct IPJHFLPHOHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public NativeArray<float3> OJOEJNDGPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public NativeArray<float3> MEAKDPMPCNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public NativeArray<float4> IHAJLGGJNNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeArray<float4> IABIIPPBOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public NativeArray<float2> ALBHBIKMHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public NativeArray<int> AMAJJFAGHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public bool EKBGFJNMALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int KICNGCGAMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public int HLNAFGKHLJP;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8089000", Offset = "0x8087800", VA = "0x188089000")]
		public void FJNOLPEALIM(int CHDNAOHPMCH, int FJNBBBLENEH, Allocator GFNKGIEEHMD, bool CHIKJLGDAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x80892A0", Offset = "0x8087AA0", VA = "0x1880892A0")]
		public static IPJHFLPHOHB LJFAENFPIEL(LFBDKLHLLEO GJKNNKIANJJ)
		{
			return default(IPJHFLPHOHB);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x80891E0", Offset = "0x80879E0", VA = "0x1880891E0")]
		public void JGAHMDKPFDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private static readonly ProfilerMarker EFBGEHHADHP;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private static readonly ProfilerMarker KGOJLFDGLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<ONJFOGEGOOF> KKHAEOJDLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private IPJHFLPHOHB KNBPDNJPONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private IPJHFLPHOHB ODHHAOIMFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private float3 GPIHDLDOKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private float3 NKCBCPHHEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private BECBIGJMFBK AMDNIONLBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* PFGOJIOBCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private NativeArray<HIGEDJNCICA.FABNLJLAMPJ> PACCEIKHBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NativeList<HIGEDJNCICA.FABNLJLAMPJ> OOEMDBCAHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NativeArray<int> DOMAIKLDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NativeArray<bool> FLPIMGENNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private NativeArray<int> OJHODJGCNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private NativeArray<int> FAAFNDKEKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private NativeArray<float> OENNBLMKLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private NativeArray<int> CHNCKEBOMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private NativeArray<float> BBMMFEELIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private NativeArray<int> BHAPNJMFFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private NativeArray<int> FHFJLJPHLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private NativeArray<float> CFEFHOBOECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private NativeArray<float> KBBLCMEDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private NativeArray<int> NCEMDNBKNIK;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8088240", Offset = "0x8086A40", VA = "0x188088240")]
	public GOHNAPMFMCK([In] List<HIGEDJNCICA.DDGCAFCEANA> NNGEPIJNLLD, NativeList<HIGEDJNCICA.FABNLJLAMPJ> JOMCBPBFBGD, [In] LFBDKLHLLEO NFBMFFFFNPF, [In] NativeList<HIGEDJNCICA.FABNLJLAMPJ> KCCPKIHFGOA, [In] NativeArray<long> KFBGBCEGNEH, float3 PJMELCDLPDE, float3 BLMOCCFHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x8088180", Offset = "0x8086980", VA = "0x188088180")]
	public static long MGLGDBPOEAK(int CHDNAOHPMCH, int FJNBBBLENEH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x8085150", Offset = "0x8083950", VA = "0x188085150", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x8086CF0", Offset = "0x80854F0", VA = "0x188086CF0")]
	public void KALHIHHHIOI(List<HIGEDJNCICA.DDGCAFCEANA> NJEJBAIOMGN, [In] HIGEDJNCICA JPPFLJKPKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x8085130", Offset = "0x8083930", VA = "0x188085130")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool DNJEPGAOIDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x8086AC0", Offset = "0x80852C0", VA = "0x188086AC0")]
	private BMIINENNNOF JAEMHPPGKCN(int CENACKMIOEJ, Allocator GFNKGIEEHMD)
	{
		return default(BMIINENNNOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x80851A0", Offset = "0x80839A0", VA = "0x1880851A0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void FCEGCNAEAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x8087B10", Offset = "0x8086310", VA = "0x188087B10")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float LDAPBGFNCJE(int MKIFIMPLGKO, int GKFBIOLANLO, bool BLIILMHOJKC, bool BMDHKHAAFAJ, float DBNGPAIKNJH, float HPOFJNMEDNI, float GPMAOMHEJOO, float KLMFMDIJKNH, float HJECKAIFPAD, float MACALNLJOEO, float MKELEKEJOCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x80877F0", Offset = "0x8085FF0", VA = "0x1880877F0")]
	[IgnoreWarning(1371)]
	private ONJFOGEGOOF KFNDJNECLDP([In] ONJFOGEGOOF DIJDENCNOIP, int OLMOKNGKAPC, [In] NativeArray<int> NDLIBHEDOED, [In] NativeArray<bool> FLPIMGENNFP, NativeArray<int> OJHODJGCNGD)
	{
		return default(ONJFOGEGOOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x80868E0", Offset = "0x80850E0", VA = "0x1880868E0")]
	public static int FDOJJGBGAAM(NativeArray<int> NDLIBHEDOED, NativeArray<int> NCEMDNBKNIK, int ANBFBJEPPOB, int CFPHBEBGJJB, int FLMCEDDPAKL)
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
		private struct OEFMAHFDGKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public long KEIJELFMDDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public IJKAECFHIHL PDEEGEAEBNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public MGCOKLMPKHE MLCGFPJFGFN;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x808BC90", Offset = "0x808A490", VA = "0x18808BC90")]
			public OEFMAHFDGKE(IJKAECFHIHL JJLJAHHCIDE, MGCOKLMPKHE IPPCJMNBNJA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		private class APNIPBLDGEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public IJKAECFHIHL PDEEGEAEBNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public int GDOBIAAONDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public float FELLKGEGPMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public List<OEFMAHFDGKE> IEIEGKJHFNE;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x807AEE0", Offset = "0x80796E0", VA = "0x18807AEE0")]
			public APNIPBLDGEP(IJKAECFHIHL JJLJAHHCIDE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private static readonly ProfilerMarker PHGCOOLDOFE;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private static readonly ProfilerMarker AIAEBGKKPJO;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private static readonly ProfilerMarker OJCKLLCOKCO;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private static readonly ProfilerMarker MACICBCLBKC;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private static readonly ProfilerMarker LGCNKNHIOBC;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly ProfilerMarker PCOAJPNOKKJ;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker IDMFOBMGPIF;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		internal const int NOFNFHANJAF = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		internal static Dictionary<Material, List<Material>> LOLADBBECPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Dictionary<Material, List<GNOFDELNAPC>> OGKKFDMLGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		internal List<GNOFDELNAPC> FEAMCNPPMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private List<MeshRenderer> OCDHDIEFNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private Transform KIDGNKPGBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private bool FKLEMMENCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private bool OHFBLIHCEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private int LKEEBGDMHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private GNOFDELNAPC JOBGNDDBPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private Material NGBJBMEFPKB;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static bool? KCMBENAEHEL;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private const int JKIHMFEPAJD = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private static List<OEFMAHFDGKE> AGKFAHBKMGL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<MeshRenderer> OBCHJAFLCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int GMOMDFANMFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8081550", Offset = "0x807FD50", VA = "0x188081550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private static bool DIJDFKHMKEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x807C650", Offset = "0x807AE50", VA = "0x18807C650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private static void LJOCEDLABNK(bool OMKHCMPGIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private static void LJOCEDLABNK(bool OMKHCMPGIAL, string ILBALOOKKCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private static void CDAHHKPEBDI(string HPANEBBHGAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x807B1A0", Offset = "0x80799A0", VA = "0x18807B1A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x807CFD0", Offset = "0x807B7D0", VA = "0x18807CFD0")]
		internal bool HCNAANMJAAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x807C770", Offset = "0x807AF70", VA = "0x18807C770")]
		private Transform FKKJFMOGPEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x807DC00", Offset = "0x807C400", VA = "0x18807DC00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x807C240", Offset = "0x807AA40", VA = "0x18807C240", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x807AF90", Offset = "0x8079790", VA = "0x18807AF90")]
		public GNOFDELNAPC AddToBatchedMesh(MGCOKLMPKHE ACOOEAJOHPD, Material IPKNLMFNGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8081030", Offset = "0x807F830", VA = "0x188081030")]
		public void RemoveFromBatchedMesh(MGCOKLMPKHE MLCGFPJFGFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x807C110", Offset = "0x807A910", VA = "0x18807C110")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x807DCB0", Offset = "0x807C4B0", VA = "0x18807DCB0")]
		private void PFMJHNMHENF(Renderer FKGIDFBJGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x807D040", Offset = "0x807B840", VA = "0x18807D040")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x807D030", Offset = "0x807B830", VA = "0x18807D030")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x807BA20", Offset = "0x807A220", VA = "0x18807BA20")]
		private void CNDCHHDGJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x807D310", Offset = "0x807BB10", VA = "0x18807D310")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x807DD30", Offset = "0x807C530", VA = "0x18807DD30")]
		private GNOFDELNAPC PLOGLLCOOLH(MGCOKLMPKHE MLCGFPJFGFN, Material IPKNLMFNGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x807D8A0", Offset = "0x807C0A0", VA = "0x18807D8A0")]
		private GNOFDELNAPC OGOLAAKFLIL(Material IPKNLMFNGIO, int MPCIBJIKKMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x807B1D0", Offset = "0x80799D0", VA = "0x18807B1D0")]
		private GNOFDELNAPC BEDNGGIAJHF(Material IPKNLMFNGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x807DC10", Offset = "0x807C410", VA = "0x18807DC10")]
		internal float4x4 PCOHJMMDOMF()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x807C7F0", Offset = "0x807AFF0", VA = "0x18807C7F0")]
		public static List<Material> GenerateVertexFormatVariants(Material IPKNLMFNGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1415340", Offset = "0x1413B40", VA = "0x181415340")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x807D1B0", Offset = "0x807B9B0", VA = "0x18807D1B0")]
		public void MarkDirty(MGCOKLMPKHE MLCGFPJFGFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x807D0B0", Offset = "0x807B8B0", VA = "0x18807D0B0")]
		[Conditional("CHECK_STATE")]
		private void JDMANLJLBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x807D490", Offset = "0x807BC90", VA = "0x18807D490")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float BAFGEOGMJCN)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x807BFE0", Offset = "0x807A7E0", VA = "0x18807BFE0")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x807FED0", Offset = "0x807E6D0", VA = "0x18807FED0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x807C910", Offset = "0x807B110", VA = "0x18807C910")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x807E090", Offset = "0x807C890", VA = "0x18807E090")]
		public void RebatchOptimally(int CMMLHMIPNDJ, int FDNOJBBCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x807DFC0", Offset = "0x807C7C0", VA = "0x18807DFC0")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x8081420", Offset = "0x807FC20", VA = "0x188081420")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class FJCBOHHKHIF
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct DIEGEPCKLBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public BatchedMeshRenderer FKGIDFBJGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public GNOFDELNAPC MLCGFPJFGFN;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1AED9D0", Offset = "0x1AEC1D0", VA = "0x181AED9D0")]
		public void OFEFEEAGGBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct JLKEDPFNCLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public float EFBAKFFENGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public GNOFDELNAPC NEADAHOBOLM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class ANDLFFPKALP : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x11A4EE0", Offset = "0x11A36E0", VA = "0x1811A4EE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x807AD70", Offset = "0x8079570", VA = "0x18807AD70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x139A8E0", Offset = "0x13990E0", VA = "0x18139A8E0")]
		[DebuggerHidden]
		public ANDLFFPKALP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x807ADC0", Offset = "0x80795C0", VA = "0x18807ADC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8079E10", Offset = "0x8078610", VA = "0x188079E10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8079DC0", Offset = "0x80785C0", VA = "0x188079DC0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8079D70", Offset = "0x8078570", VA = "0x188079D70")]
		private void CLFKDHFELPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x807AD20", Offset = "0x8079520", VA = "0x18807AD20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x807AC70", Offset = "0x8079470", VA = "0x18807AC70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x807AC70", Offset = "0x8079470", VA = "0x18807AC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private static readonly ProfilerMarker PCOAJPNOKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly ProfilerMarker CCMMKFBDBMP;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly ProfilerMarker GMFNIGOPKAC;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private static readonly ProfilerMarker LLLLNGLNKOF;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static float3 BNECGJEKELO;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static int DCKJDDNOCLF;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static int MNPMCIBAGNA;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static int NEAHNGBPKLN;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static int FKCNCNKAGCB;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static int GOBHAEJJHMH;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static float CBGDJBDFJFK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static float GKLMIOLCHMA;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static float DPAPIOAAFOM;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static float KDGMANFDEPL;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static float FEDLHJKDELH;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static float NPHEPIABJBD;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static float OACCLMOLOIL;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static float GKKEEOLPBOH;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private static List<BatchedMeshRenderer> CLAJPIEAEFD;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private static Stack<LFBDKLHLLEO> NAOIDNGKJJL;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static Stack<IJDKMPAABAF> EOALECCPGDL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static DBFFJCHPNOI NBMGFOGPGII;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private static DIEGEPCKLBK KMHBBBHFMMD;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static int JKJGGJAFNEH;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void LJOCEDLABNK(bool OMKHCMPGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void KFGHJCCBILC(bool OMKHCMPGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void LJOCEDLABNK(bool OMKHCMPGIAL, string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x80830C0", Offset = "0x80818C0", VA = "0x1880830C0")]
	public static void HNPKBJNJFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8082AB0", Offset = "0x80812B0", VA = "0x188082AB0")]
	public static void HENCDHCGHKO(BatchedMeshRenderer BNIAGEKOOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8084C50", Offset = "0x8083450", VA = "0x188084C50")]
	public static void PGDONCODDIP(BatchedMeshRenderer BNIAGEKOOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8083140", Offset = "0x8081940", VA = "0x188083140")]
	public static void LGOFOAANLCK(MGCOKLMPKHE CLLPKCGDMKH, bool GMGELGLLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8083FC0", Offset = "0x80827C0", VA = "0x188083FC0")]
	public static void OHKELFCMGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8084340", Offset = "0x8082B40", VA = "0x188084340")]
	public static void OOAEEHHIBLD(float BAFGEOGMJCN, bool PDLHBJCPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x8082BF0", Offset = "0x80813F0", VA = "0x188082BF0")]
	private static void HIIEPLGKBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8081FD0", Offset = "0x80807D0", VA = "0x188081FD0")]
	public static long CDDBEJOHMNB(int AFOHIPJDLCA, long BHAIICEJJPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8083DB0", Offset = "0x80825B0", VA = "0x188083DB0")]
	public static (long, long, int) NLNENBBLDIF(float BAFGEOGMJCN)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x8081D80", Offset = "0x8080580", VA = "0x188081D80")]
	[IteratorStateMachine(typeof(ANDLFFPKALP))]
	public static IEnumerable<bool> AOPMKEIDNAK(long EEMKPPIBMEN, bool PEMGOEPLKEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x8081AA0", Offset = "0x80802A0", VA = "0x188081AA0")]
	public static void AJIJBECOKEC(long EEMKPPIBMEN, bool PEMGOEPLKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8083B10", Offset = "0x8082310", VA = "0x188083B10")]
	public static int MLOHKIEOBHH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x8083990", Offset = "0x8082190", VA = "0x188083990")]
	internal static LFBDKLHLLEO MHGMDIJFNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x8083D10", Offset = "0x8082510", VA = "0x188083D10")]
	internal static void NDGEOICLLAG(LFBDKLHLLEO OPECHNFNIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x8082970", Offset = "0x8081170", VA = "0x188082970")]
	internal static IJDKMPAABAF HBJFJPFPEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x8083C80", Offset = "0x8082480", VA = "0x188083C80")]
	internal static void NDGEOICLLAG(IJDKMPAABAF EGCIHGALNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x8081E10", Offset = "0x8080610", VA = "0x188081E10")]
	public static void BPCELGKGPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class HKENNNDHEGI<KeyType> : GNOFDELNAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly Dictionary<KeyType, MGCOKLMPKHE> POIKCIHCDEC;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AF50", Offset = "0x4D09750", VA = "0x184D0AF50")]
	public HKENNNDHEGI(string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AD20", Offset = "0x4D09520", VA = "0x184D0AD20")]
	public void EPDPODEMOHI(KeyType MNMCNOJCKAF, MGCOKLMPKHE CLLPKCGDMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AC20", Offset = "0x4D09420", VA = "0x184D0AC20")]
	public bool EICELLJEMEF(KeyType MNMCNOJCKAF, MGCOKLMPKHE HFIHIBCGHBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AD90", Offset = "0x4D09590", VA = "0x184D0AD90")]
	public void MKMLLDIMLKG(KeyType MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AAC0", Offset = "0x4D092C0", VA = "0x184D0AAC0", Slot = "4")]
	public override void CABFCBMPENC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class NDPEIOCJJDE
{
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly ProfilerCategory JGOPEONDGLG;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	internal static readonly ProfilerMarker FKIIBONFGPB;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	internal static readonly GLMECNBMNJC OOAEEHHIBLD;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly GPEAFJAPIME<float> GBOPHNDKJOJ;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly GPEAFJAPIME<float> JDPGIOPDADB;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly GPEAFJAPIME<double> DGNDOPDANPB;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private static readonly GPEAFJAPIME<double> KMDMALCAMED;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly GPEAFJAPIME<double> HFCNPFGCOEP;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private static readonly GPEAFJAPIME<int> AKLGBBBJDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly GPEAFJAPIME<int> DCKDCDLCNLB;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly GPEAFJAPIME<int> BKMALOKCGFH;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly GPEAFJAPIME<int> BKIBAKKNBMF;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private static readonly GPEAFJAPIME<int> PNJFMDCGAHO;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly GPEAFJAPIME<long> JPFNKJLDEOO;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private static readonly GPEAFJAPIME<long> AHANONAPJGJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private static readonly GPEAFJAPIME<long> HIBCGAHDCKN;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private static readonly GPEAFJAPIME<long> PCODHHPDBPD;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private static readonly GPEAFJAPIME<long> EKLHIIOEICG;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x808B2C0", Offset = "0x8089AC0", VA = "0x18808B2C0")]
	public static void GDHFIDDACLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x808BCC0", Offset = "0x808A4C0", VA = "0x18808BCC0")]
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
