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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7500F10", Offset = "0x7500310", VA = "0x187500F10", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class HLNOKJFBKLN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IBCMILIKEJG KLMIKHOCEAL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly IBCMILIKEJG ALJPIBGEMCN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly IBCMILIKEJG FHGIJJAANEC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly IBCMILIKEJG GKMKBNILMMM;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class EMDNKHMMFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ENJBAIDLEIF IBMFPHICBFA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EJENEKIJBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public EMDNKHMMFCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct ENJBAIDLEIF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BDFIANNKNGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public half NIFMCHEADLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ushort BOPDENJKHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public byte BIOAOOPLCML;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void FGBBKBMGCEG([NoAlias] float3* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class DGNEIOKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x74E6410", Offset = "0x74E5810", VA = "0x1874E6410")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x74E62B0", Offset = "0x74E56B0", VA = "0x1874E62B0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x74E6770", Offset = "0x74E5B70", VA = "0x1874E6770")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74E6540", Offset = "0x74E5940", VA = "0x1874E6540")]
		public unsafe static void CNDNDIPPKBE([NoAlias] float3* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void HCFHLNLBONN([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class FICEPEBJLPN
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74F7D80", Offset = "0x74F7180", VA = "0x1874F7D80")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74F7C20", Offset = "0x74F7020", VA = "0x1874F7C20")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x74F8160", Offset = "0x74F7560", VA = "0x1874F8160")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74F7EB0", Offset = "0x74F72B0", VA = "0x1874F7EB0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void HNMIEKDLPML([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class NNLMMBCBENL
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7501DE0", Offset = "0x75011E0", VA = "0x187501DE0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7501C80", Offset = "0x7501080", VA = "0x187501C80")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75021C0", Offset = "0x75015C0", VA = "0x1875021C0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7501F10", Offset = "0x7501310", VA = "0x187501F10")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void DFJAFCMKMPP([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class CCEIJCJLIMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74E4510", Offset = "0x74E3910", VA = "0x1874E4510")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x74E43B0", Offset = "0x74E37B0", VA = "0x1874E43B0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x74E48F0", Offset = "0x74E3CF0", VA = "0x1874E48F0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x74E4640", Offset = "0x74E3A40", VA = "0x1874E4640")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void MHKFMNJLPNB([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class ICMCEDBAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x74FB8A0", Offset = "0x74FACA0", VA = "0x1874FB8A0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x74FB740", Offset = "0x74FAB40", VA = "0x1874FB740")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74FBC80", Offset = "0x74FB080", VA = "0x1874FBC80")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x74FB9D0", Offset = "0x74FADD0", VA = "0x1874FB9D0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void KKGFFAFPKEP([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class HKKCEFNKDJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x74FA4B0", Offset = "0x74F98B0", VA = "0x1874FA4B0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x74FA350", Offset = "0x74F9750", VA = "0x1874FA350")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x74FA920", Offset = "0x74F9D20", VA = "0x1874FA920")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74FA5E0", Offset = "0x74F99E0", VA = "0x1874FA5E0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void PIJAHCMPDBC([NoAlias] ushort* OIMOPLDJCHO, [Out] float3 ODKPPILCFCJ, [Out] float3 MGNEECAKBAO, [In][NoAlias] float3* MDINJBMBKFJ, int OLPCPICADPM, int LMFBKOOOEDD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class MJEKMMPFNBK
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7501320", Offset = "0x7500720", VA = "0x187501320")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x75011C0", Offset = "0x75005C0", VA = "0x1875011C0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7501690", Offset = "0x7500A90", VA = "0x187501690")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7501450", Offset = "0x7500850", VA = "0x187501450")]
		public unsafe static void CNDNDIPPKBE([NoAlias] ushort* OIMOPLDJCHO, [Out] float3 ODKPPILCFCJ, [Out] float3 MGNEECAKBAO, [In][NoAlias] float3* MDINJBMBKFJ, int OLPCPICADPM, int LMFBKOOOEDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void DOBCCCJOPAB([NoAlias] ushort* APOLMDOKIKJ, [In][NoAlias] float3* HGLFOJPFINL, int LMFBKOOOEDD);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class AAIPMJFLAJM
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74E0210", Offset = "0x74DF610", VA = "0x1874E0210")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x74E00B0", Offset = "0x74DF4B0", VA = "0x1874E00B0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74E0550", Offset = "0x74DF950", VA = "0x1874E0550")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74E0340", Offset = "0x74DF740", VA = "0x1874E0340")]
		public unsafe static void CNDNDIPPKBE([NoAlias] ushort* APOLMDOKIKJ, [In][NoAlias] float3* HGLFOJPFINL, int LMFBKOOOEDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void PBFKNHHOKBP([NoAlias] float3* JEDGAOJKNLP, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class DDFNLDFCGDP
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x74E58E0", Offset = "0x74E4CE0", VA = "0x1874E58E0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74E5780", Offset = "0x74E4B80", VA = "0x1874E5780")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x74E5C20", Offset = "0x74E5020", VA = "0x1874E5C20")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x74E5A10", Offset = "0x74E4E10", VA = "0x1874E5A10")]
		public unsafe static void CNDNDIPPKBE([NoAlias] float3* JEDGAOJKNLP, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void KOPGDDODPEI([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class GCJNDGDELHO
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x74F8A50", Offset = "0x74F7E50", VA = "0x1874F8A50")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x74F88F0", Offset = "0x74F7CF0", VA = "0x1874F88F0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x74F8D90", Offset = "0x74F8190", VA = "0x1874F8D90")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x74F8B80", Offset = "0x74F7F80", VA = "0x1874F8B80")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void BCLLBIDOELB([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class BONLIEDFBMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x74E3ED0", Offset = "0x74E32D0", VA = "0x1874E3ED0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x74E3D70", Offset = "0x74E3170", VA = "0x1874E3D70")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x74E4300", Offset = "0x74E3700", VA = "0x1874E4300")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x74E4000", Offset = "0x74E3400", VA = "0x1874E4000")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void KOGEKJEGDPB([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class HEGOGAPMEPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x74F9790", Offset = "0x74F8B90", VA = "0x1874F9790")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x74F9630", Offset = "0x74F8A30", VA = "0x1874F9630")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x74F9BC0", Offset = "0x74F8FC0", VA = "0x1874F9BC0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x74F98C0", Offset = "0x74F8CC0", VA = "0x1874F98C0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void BMNLEDEOJAL([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class GFMLMCHJJOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x74F8FA0", Offset = "0x74F83A0", VA = "0x1874F8FA0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x74F8E40", Offset = "0x74F8240", VA = "0x1874F8E40")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74F9400", Offset = "0x74F8800", VA = "0x1874F9400")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x74F90D0", Offset = "0x74F84D0", VA = "0x1874F90D0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void ICEOMBBGACF([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class KMMOOOOCHPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74FE420", Offset = "0x74FD820", VA = "0x1874FE420")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x74FE2C0", Offset = "0x74FD6C0", VA = "0x1874FE2C0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74FE880", Offset = "0x74FDC80", VA = "0x1874FE880")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x74FE550", Offset = "0x74FD950", VA = "0x1874FE550")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void FLKCCJKKGOB([NoAlias] uint* HEPDMBKPKIJ, [Out] float2 AJKBDLJPNNB, [Out] float2 LNCPFBAGODO, [In][NoAlias] float2* MLNAKENDILN, int OLPCPICADPM, int LMFBKOOOEDD);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class HNIPIKIFLMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x74FB220", Offset = "0x74FA620", VA = "0x1874FB220")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x74FB0C0", Offset = "0x74FA4C0", VA = "0x1874FB0C0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x74FB590", Offset = "0x74FA990", VA = "0x1874FB590")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x74FB350", Offset = "0x74FA750", VA = "0x1874FB350")]
		public unsafe static void CNDNDIPPKBE([NoAlias] uint* HEPDMBKPKIJ, [Out] float2 AJKBDLJPNNB, [Out] float2 LNCPFBAGODO, [In][NoAlias] float2* MLNAKENDILN, int OLPCPICADPM, int LMFBKOOOEDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void IAHEGLACDGJ([Out] float2 KBMAJILDLKJ, uint FEOHOONOGAO, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class JBPBPEBDCFE
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x74FC6A0", Offset = "0x74FBAA0", VA = "0x1874FC6A0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x74FC540", Offset = "0x74FB940", VA = "0x1874FC540")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x74FCA30", Offset = "0x74FBE30", VA = "0x1874FCA30")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x74FC7D0", Offset = "0x74FBBD0", VA = "0x1874FC7D0")]
		public static void CNDNDIPPKBE([Out] float2 KBMAJILDLKJ, uint FEOHOONOGAO, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void FPBMHINPIGC([NoAlias] float2* HEPDMBKPKIJ, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class BGKBCJMHDEA
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x74E2680", Offset = "0x74E1A80", VA = "0x1874E2680")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x74E2520", Offset = "0x74E1920", VA = "0x1874E2520")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x74E2AA0", Offset = "0x74E1EA0", VA = "0x1874E2AA0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x74E27B0", Offset = "0x74E1BB0", VA = "0x1874E27B0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] float2* HEPDMBKPKIJ, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void HMIDGFNLKPH([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class BJLKHADPCKK
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x74E2CB0", Offset = "0x74E20B0", VA = "0x1874E2CB0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x74E2B50", Offset = "0x74E1F50", VA = "0x1874E2B50")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x74E3100", Offset = "0x74E2500", VA = "0x1874E3100")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x74E2DE0", Offset = "0x74E21E0", VA = "0x1874E2DE0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void JMEIIPGOHFP([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class ALLMKFBLPIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x74E0760", Offset = "0x74DFB60", VA = "0x1874E0760")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x74E0600", Offset = "0x74DFA00", VA = "0x1874E0600")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x74E0BB0", Offset = "0x74DFFB0", VA = "0x1874E0BB0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x74E0890", Offset = "0x74DFC90", VA = "0x1874E0890")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void BOBHBFFNCGN([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class OIGGKKKANFC
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x75023D0", Offset = "0x75017D0", VA = "0x1875023D0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7502270", Offset = "0x7501670", VA = "0x187502270")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7502730", Offset = "0x7501B30", VA = "0x187502730")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7502500", Offset = "0x7501900", VA = "0x187502500")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void HJNKIHBCDHG([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class KBFHJCGBJNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x74FD2B0", Offset = "0x74FC6B0", VA = "0x1874FD2B0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x74FD150", Offset = "0x74FC550", VA = "0x1874FD150")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x74FD6F0", Offset = "0x74FCAF0", VA = "0x1874FD6F0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x74FD3E0", Offset = "0x74FC7E0", VA = "0x1874FD3E0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void IFHKNKPAAPE([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class EIDAOGHFLBN
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x74E6A80", Offset = "0x74E5E80", VA = "0x1874E6A80")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x74E6920", Offset = "0x74E5D20", VA = "0x1874E6920")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x74E6ED0", Offset = "0x74E62D0", VA = "0x1874E6ED0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x74E6BB0", Offset = "0x74E5FB0", VA = "0x1874E6BB0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void PDBFMEIPBBB([NoAlias] ushort* LOOMOBPNAIP, [In][NoAlias] float4* IDHBGNHPKLL, int OLPCPICADPM, int LMFBKOOOEDD);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class BDCJKBBGPAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x74E15E0", Offset = "0x74E09E0", VA = "0x1874E15E0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x74E1480", Offset = "0x74E0880", VA = "0x1874E1480")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x74E19B0", Offset = "0x74E0DB0", VA = "0x1874E19B0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x74E1710", Offset = "0x74E0B10", VA = "0x1874E1710")]
		public unsafe static void CNDNDIPPKBE([NoAlias] ushort* LOOMOBPNAIP, [In][NoAlias] float4* IDHBGNHPKLL, int OLPCPICADPM, int LMFBKOOOEDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort BNPJOCNAMLN([In] float4 MGAHBPIPINI);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class PNCHCDLPIKB
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7502BC0", Offset = "0x7501FC0", VA = "0x187502BC0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7502A60", Offset = "0x7501E60", VA = "0x187502A60")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7502F50", Offset = "0x7502350", VA = "0x187502F50")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7502CF0", Offset = "0x75020F0", VA = "0x187502CF0")]
		public static ushort CNDNDIPPKBE([In] float4 MGAHBPIPINI)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void LNKHOPLKNOL([NoAlias] float4* LOOMOBPNAIP, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class FJAPFGHMPDN
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x74F8370", Offset = "0x74F7770", VA = "0x1874F8370")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x74F8210", Offset = "0x74F7610", VA = "0x1874F8210")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x74F8740", Offset = "0x74F7B40", VA = "0x1874F8740")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x74F84A0", Offset = "0x74F78A0", VA = "0x1874F84A0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] float4* LOOMOBPNAIP, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void HBCGFLHLBMO([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class BCLBBKKINAO
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x74E1090", Offset = "0x74E0490", VA = "0x1874E1090")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x74E0F30", Offset = "0x74E0330", VA = "0x1874E0F30")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x74E13D0", Offset = "0x74E07D0", VA = "0x1874E13D0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x74E11C0", Offset = "0x74E05C0", VA = "0x1874E11C0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void JLPINHFPCGG([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class LFCLDODGDOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x74FF160", Offset = "0x74FE560", VA = "0x1874FF160")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x74FF000", Offset = "0x74FE400", VA = "0x1874FF000")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x74FF5C0", Offset = "0x74FE9C0", VA = "0x1874FF5C0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x74FF290", Offset = "0x74FE690", VA = "0x1874FF290")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void DGMOPLAAJNP([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class JHJBDKFEOLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x74FCC40", Offset = "0x74FC040", VA = "0x1874FCC40")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x74FCAE0", Offset = "0x74FBEE0", VA = "0x1874FCAE0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x74FD0A0", Offset = "0x74FC4A0", VA = "0x1874FD0A0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x74FCD70", Offset = "0x74FC170", VA = "0x1874FCD70")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void DGPNAFCOPAC([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class LFCPKJGOAGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x74FF7D0", Offset = "0x74FEBD0", VA = "0x1874FF7D0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x74FF670", Offset = "0x74FEA70", VA = "0x1874FF670")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x74FFC90", Offset = "0x74FF090", VA = "0x1874FFC90")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x74FF900", Offset = "0x74FED00", VA = "0x1874FF900")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void APHBPELAKJO([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class LBHNJEOPNPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x74FEA90", Offset = "0x74FDE90", VA = "0x1874FEA90")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x74FE930", Offset = "0x74FDD30", VA = "0x1874FE930")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x74FEF50", Offset = "0x74FE350", VA = "0x1874FEF50")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x74FEBC0", Offset = "0x74FDFC0", VA = "0x1874FEBC0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void BMCJMEDFLNK([Out] float4 BIEIOPPGBOB, ushort FEOHOONOGAO);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class DEOEJAPCKGE
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x74E5E30", Offset = "0x74E5230", VA = "0x1874E5E30")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x74E5CD0", Offset = "0x74E50D0", VA = "0x1874E5CD0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x74E6200", Offset = "0x74E5600", VA = "0x1874E6200")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x74E5F60", Offset = "0x74E5360", VA = "0x1874E5F60")]
		public static void CNDNDIPPKBE([Out] float4 BIEIOPPGBOB, ushort FEOHOONOGAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void EFFLFIGEGBH([NoAlias] float4* ODCPGNMDEKP, [NoAlias] byte* HJKAHMPCAAB, [Out] int JGKEDJIFDPJ, [Out] int ODIGGFMJHDG, [NoAlias] float4* GKABEBKBPOJ, int OLPCPICADPM, int LMFBKOOOEDD);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class HLNEBNJMNMM
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x74FAB30", Offset = "0x74F9F30", VA = "0x1874FAB30")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x74FA9D0", Offset = "0x74F9DD0", VA = "0x1874FA9D0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x74FAEA0", Offset = "0x74FA2A0", VA = "0x1874FAEA0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x74FAC60", Offset = "0x74FA060", VA = "0x1874FAC60")]
		public unsafe static void CNDNDIPPKBE([NoAlias] float4* ODCPGNMDEKP, [NoAlias] byte* HJKAHMPCAAB, [Out] int JGKEDJIFDPJ, [Out] int ODIGGFMJHDG, [NoAlias] float4* GKABEBKBPOJ, int OLPCPICADPM, int LMFBKOOOEDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void FDKLOOBOHBN([NoAlias] float4* DBLNCMIDANK, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class IOBDFGHFMAC
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x74FC060", Offset = "0x74FB460", VA = "0x1874FC060")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x74FBF00", Offset = "0x74FB300", VA = "0x1874FBF00")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x74FC490", Offset = "0x74FB890", VA = "0x1874FC490")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x74FC190", Offset = "0x74FB590", VA = "0x1874FC190")]
		public unsafe static void CNDNDIPPKBE([NoAlias] float4* DBLNCMIDANK, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void CFINHFPPBOF([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class CKABAMEJODA
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x74E4B00", Offset = "0x74E3F00", VA = "0x1874E4B00")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x74E49A0", Offset = "0x74E3DA0", VA = "0x1874E49A0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x74E4FE0", Offset = "0x74E43E0", VA = "0x1874E4FE0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x74E4C30", Offset = "0x74E4030", VA = "0x1874E4C30")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void NOBLOOOKFOJ([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class BLNPLDKINMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x74E3310", Offset = "0x74E2710", VA = "0x1874E3310")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x74E31B0", Offset = "0x74E25B0", VA = "0x1874E31B0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x74E3800", Offset = "0x74E2C00", VA = "0x1874E3800")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x74E3440", Offset = "0x74E2840", VA = "0x1874E3440")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void AIJNEOLLKOL([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class CKHPBLPJHNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x74E51F0", Offset = "0x74E45F0", VA = "0x1874E51F0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x74E5090", Offset = "0x74E4490", VA = "0x1874E5090")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x74E56D0", Offset = "0x74E4AD0", VA = "0x1874E56D0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x74E5320", Offset = "0x74E4720", VA = "0x1874E5320")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void BPIAPAGNMDO([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class KCAFCAEMJIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x74FD900", Offset = "0x74FCD00", VA = "0x1874FD900")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x74FD7A0", Offset = "0x74FCBA0", VA = "0x1874FD7A0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x74FDC60", Offset = "0x74FD060", VA = "0x1874FDC60")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x74FDA30", Offset = "0x74FCE30", VA = "0x1874FDA30")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void CMHIFDOHAJF([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class BDJMBKAFDLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x74E1BC0", Offset = "0x74E0FC0", VA = "0x1874E1BC0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x74E1A60", Offset = "0x74E0E60", VA = "0x1874E1A60")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x74E1F20", Offset = "0x74E1320", VA = "0x1874E1F20")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x74E1CF0", Offset = "0x74E10F0", VA = "0x1874E1CF0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int HFPOGDFBPBK([NoAlias] byte* LPMBCLACJPB, [In][NoAlias] int* JPEGACICKGA, int GPBCHJIBNEA);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class HIPKJLALNNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x74F9ED0", Offset = "0x74F92D0", VA = "0x1874F9ED0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x74F9D70", Offset = "0x74F9170", VA = "0x1874F9D70")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x74FA2A0", Offset = "0x74F96A0", VA = "0x1874FA2A0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x74FA000", Offset = "0x74F9400", VA = "0x1874FA000")]
		public unsafe static int CNDNDIPPKBE([NoAlias] byte* LPMBCLACJPB, [In][NoAlias] int* JPEGACICKGA, int GPBCHJIBNEA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void HMBPIHELPNI([NoAlias] int* IEAABGGIGJB, [In][NoAlias] byte* PGOBAABAIKF, int BHEMEOKJHOM);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class LHHPMBFGIKD
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x74FFEA0", Offset = "0x74FF2A0", VA = "0x1874FFEA0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x74FFD40", Offset = "0x74FF140", VA = "0x1874FFD40")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7500230", Offset = "0x74FF630", VA = "0x187500230")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x74FFFD0", Offset = "0x74FF3D0", VA = "0x1874FFFD0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] int* IEAABGGIGJB, [In][NoAlias] byte* PGOBAABAIKF, int BHEMEOKJHOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void CNJOHGEFKFB([NoAlias] ushort* IEAABGGIGJB, [In][NoAlias] byte* PGOBAABAIKF, int BHEMEOKJHOM);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class LPBDIOCEOHO
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7500AC0", Offset = "0x74FFEC0", VA = "0x187500AC0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7500960", Offset = "0x74FFD60", VA = "0x187500960")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7500E60", Offset = "0x7500260", VA = "0x187500E60")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7500BF0", Offset = "0x74FFFF0", VA = "0x187500BF0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] ushort* IEAABGGIGJB, [In][NoAlias] byte* PGOBAABAIKF, int BHEMEOKJHOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void JOPANACIKAA([Out] float3 KBMAJILDLKJ, ushort FEOHOONOGAO);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class BDJMGCKAHDM
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x74E2130", Offset = "0x74E1530", VA = "0x1874E2130")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x74E1FD0", Offset = "0x74E13D0", VA = "0x1874E1FD0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x74E2470", Offset = "0x74E1870", VA = "0x1874E2470")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x74E2260", Offset = "0x74E1660", VA = "0x1874E2260")]
		public static void CNDNDIPPKBE([Out] float3 KBMAJILDLKJ, ushort FEOHOONOGAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort OFMNJAMCFJB([In] float3 MGAHBPIPINI);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class NFJPGLOLOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x75018A0", Offset = "0x7500CA0", VA = "0x1875018A0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7501740", Offset = "0x7500B40", VA = "0x187501740")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7501BD0", Offset = "0x7500FD0", VA = "0x187501BD0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x75019D0", Offset = "0x7500DD0", VA = "0x1875019D0")]
		public static ushort CNDNDIPPKBE([In] float3 MGAHBPIPINI)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker CIDACEKIFAB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker PBAGFPDKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int EJENEKIJBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int BHEMEOKJHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> KCNAIMLCPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<uint> NBOPCHOKEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<BDFIANNKNGG> EDEDDIPBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> NABDBDACGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> HKAJIOBOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 BFCACIBFOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 MGNEECAKBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 EJGMPPPNFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 LNCPFBAGODO;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long JKADLMPPJHA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long FEMOPHLLAIB;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static float JAIIBKMMEGK;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static bool NAAPACMJGHG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74E8340", Offset = "0x74E7740", VA = "0x1874E8340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHFMDEPIPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74EDC60", Offset = "0x74ED060", VA = "0x1874EDC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74EAE60", Offset = "0x74EA260", VA = "0x1874EAE60")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74EF4C0", Offset = "0x74EE8C0", VA = "0x1874EF4C0")]
	public static ENJBAIDLEIF OILMBKHFGKP(Allocator LEILKJFLDFN, NativeArray<float3> MDINJBMBKFJ, NativeArray<float3> HGLFOJPFINL, NativeArray<float2> MLNAKENDILN, NativeArray<float4> GKABEBKBPOJ, bool OBIFAFLIEAO, NativeArray<float4> EPFOAFDPIIK, NativeArray<int> JPEGACICKGA, int EJENEKIJBLE, int FMHMFGBFFJG, int BHEMEOKJHOM, int OLPCPICADPM)
	{
		return default(ENJBAIDLEIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74ED530", Offset = "0x74EC930", VA = "0x1874ED530")]
	public FBFDINCPKFI KMEKABJLIIE(Allocator LEILKJFLDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74EDCA0", Offset = "0x74ED0A0", VA = "0x1874EDCA0")]
	public void MBILLNFHDBP(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74EB150", Offset = "0x74EA550", VA = "0x1874EB150")]
	private void GIHOFKAFNJE(Mesh LCGHOEMEOEK, NativeArray<ushort> EEPKNOKHHND, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74EE800", Offset = "0x74EDC00", VA = "0x1874EE800")]
	public void NLKDJEIFNLJ(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74E7260", Offset = "0x74E6660", VA = "0x1874E7260")]
	public void ALELOKNCCMM(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74E9DE0", Offset = "0x74E91E0", VA = "0x1874E9DE0")]
	public void ELHDCCLDBBC(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74E8FB0", Offset = "0x74E83B0", VA = "0x1874E8FB0")]
	public void DNOHPKNOBLB(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74EF990", Offset = "0x74EED90", VA = "0x1874EF990")]
	public void PAGNLEMPCOD(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74EBD90", Offset = "0x74EB190", VA = "0x1874EBD90")]
	public void HNNBMHNMLBF(Mesh LCGHOEMEOEK, FBFDINCPKFI.KMIBOCLMOJF HGFLLJFOAAE, bool EAFFMHKKAHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74EC9B0", Offset = "0x74EBDB0", VA = "0x1874EC9B0")]
	public long JFHACJJLLHE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74EE660", Offset = "0x74EDA60", VA = "0x1874EE660")]
	public long NJLAALHOALG(FBFDINCPKFI.KMIBOCLMOJF HGFLLJFOAAE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x74EEDE0", Offset = "0x74EE1E0", VA = "0x1874EEDE0")]
	private void NLKPFDGIMDD(int NCNLMCPMFCK, int LMFBKOOOEDD, Allocator LEILKJFLDFN, bool IHKOBNPEFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74EDDC0", Offset = "0x74ED1C0", VA = "0x1874EDDC0")]
	private void MDKOCHGDCIA(NativeArray<float3> OIMOPLDJCHO, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74EDEE0", Offset = "0x74ED2E0", VA = "0x1874EDEE0")]
	[BurstCompile]
	private unsafe static void MDKOCHGDCIA([NoAlias] float3* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74EC750", Offset = "0x74EBB50", VA = "0x1874EC750")]
	[BurstCompile]
	private unsafe static void IPFGPDAMPEF([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74EA8D0", Offset = "0x74E9CD0", VA = "0x1874EA8D0")]
	[BurstCompile]
	private unsafe static void FOFIDDFJPLN([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74EA790", Offset = "0x74E9B90", VA = "0x1874EA790")]
	[BurstCompile]
	private unsafe static void FNAPNJGNOGL([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74E8380", Offset = "0x74E7780", VA = "0x1874E8380")]
	[BurstCompile]
	private unsafe static void CFKABBPAFNL([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74E8CC0", Offset = "0x74E80C0", VA = "0x1874E8CC0")]
	[BurstCompile]
	private unsafe static void DIKDJPLLGFI([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74EC0D0", Offset = "0x74EB4D0", VA = "0x1874EC0D0")]
	private void IAGKCCOKEJK(NativeArray<float3> MDINJBMBKFJ, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74EC1F0", Offset = "0x74EB5F0", VA = "0x1874EC1F0")]
	[BurstCompile]
	private unsafe static void IAGKCCOKEJK([NoAlias] ushort* OIMOPLDJCHO, [Out] float3 ODKPPILCFCJ, [Out] float3 MGNEECAKBAO, [In][NoAlias] float3* MDINJBMBKFJ, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74F05B0", Offset = "0x74EF9B0", VA = "0x1874F05B0")]
	private void PMEKOFKOKHC(NativeArray<float3> HGLFOJPFINL, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74F0690", Offset = "0x74EFA90", VA = "0x1874F0690")]
	[BurstCompile]
	private unsafe static void PMEKOFKOKHC([NoAlias] ushort* APOLMDOKIKJ, [In][NoAlias] float3* HGLFOJPFINL, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74EF2A0", Offset = "0x74EE6A0", VA = "0x1874EF2A0")]
	private void NPPJOFIJBNJ(NativeArray<float3> JEDGAOJKNLP, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74EF050", Offset = "0x74EE450", VA = "0x1874EF050")]
	[BurstCompile]
	private unsafe static void NPPJOFIJBNJ([NoAlias] float3* JEDGAOJKNLP, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74E9B90", Offset = "0x74E8F90", VA = "0x1874E9B90")]
	[BurstCompile]
	private unsafe static void EIBANCBMKKM([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74E7CB0", Offset = "0x74E70B0", VA = "0x1874E7CB0")]
	[BurstCompile]
	private unsafe static void BKNNDPHFGNE([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74EDB70", Offset = "0x74ECF70", VA = "0x1874EDB70")]
	[BurstCompile]
	private unsafe static void LIGMKGABLNM([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74EBD20", Offset = "0x74EB120", VA = "0x1874EBD20")]
	[BurstCompile]
	private unsafe static void HKAKBPJFJHN([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74E7BC0", Offset = "0x74E6FC0", VA = "0x1874E7BC0")]
	[BurstCompile]
	private unsafe static void BIJKOPKNDAJ([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74E7FE0", Offset = "0x74E73E0", VA = "0x1874E7FE0")]
	private void BPEGDBBKMIJ(NativeArray<float2> MLNAKENDILN, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74E8100", Offset = "0x74E7500", VA = "0x1874E8100")]
	[BurstCompile]
	private unsafe static void BPEGDBBKMIJ([NoAlias] uint* HEPDMBKPKIJ, [Out] float2 AJKBDLJPNNB, [Out] float2 LNCPFBAGODO, [In][NoAlias] float2* MLNAKENDILN, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74EA430", Offset = "0x74E9830", VA = "0x1874EA430")]
	[BurstCompile]
	private static void FDIONLPMCMD([Out] float2 KBMAJILDLKJ, uint FEOHOONOGAO, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74EBB80", Offset = "0x74EAF80", VA = "0x1874EBB80")]
	private void HILBKIFIEAB(NativeArray<float2> HEPDMBKPKIJ, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74EBCA0", Offset = "0x74EB0A0", VA = "0x1874EBCA0")]
	[BurstCompile]
	private unsafe static void HILBKIFIEAB([NoAlias] float2* HEPDMBKPKIJ, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74EE290", Offset = "0x74ED690", VA = "0x1874EE290")]
	[BurstCompile]
	private unsafe static void NCNFECJNHAK([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74EE110", Offset = "0x74ED510", VA = "0x1874EE110")]
	[BurstCompile]
	private unsafe static void MLOJIBNEHEN([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74E7AE0", Offset = "0x74E6EE0", VA = "0x1874E7AE0")]
	[BurstCompile]
	private unsafe static void BFMJBMFFMGI([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74EC280", Offset = "0x74EB680", VA = "0x1874EC280")]
	[BurstCompile]
	private unsafe static void IDIMNAPGHGE([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74EE090", Offset = "0x74ED490", VA = "0x1874EE090")]
	[BurstCompile]
	private unsafe static void MHOKCDBDOPG([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74F01E0", Offset = "0x74EF5E0", VA = "0x1874F01E0")]
	private void PKECADBNLGF(NativeArray<float4> EPFOAFDPIIK, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74F02F0", Offset = "0x74EF6F0", VA = "0x1874F02F0")]
	[BurstCompile]
	private unsafe static void PKECADBNLGF([NoAlias] ushort* LOOMOBPNAIP, [In][NoAlias] float4* IDHBGNHPKLL, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x74E78B0", Offset = "0x74E6CB0", VA = "0x1874E78B0")]
	[BurstCompile]
	private static ushort ANCFONFKCNF([In] float4 MGAHBPIPINI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x74EAB90", Offset = "0x74E9F90", VA = "0x1874EAB90")]
	private void GAANPLLCHLI(NativeArray<float4> LOOMOBPNAIP, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x74EAC80", Offset = "0x74EA080", VA = "0x1874EAC80")]
	[BurstCompile]
	private unsafe static void GAANPLLCHLI([NoAlias] float4* LOOMOBPNAIP, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x74E7D20", Offset = "0x74E7120", VA = "0x1874E7D20")]
	[BurstCompile]
	private unsafe static void BMIDOHNDNOP([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74E8C50", Offset = "0x74E8050", VA = "0x1874E8C50")]
	[BurstCompile]
	private unsafe static void DHMNEAPHFAD([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74EDF60", Offset = "0x74ED360", VA = "0x1874EDF60")]
	[BurstCompile]
	private unsafe static void MFJMEGMFNPD([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x74E7F70", Offset = "0x74E7370", VA = "0x1874E7F70")]
	[BurstCompile]
	private unsafe static void BPCJPMDOGEB([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74E82D0", Offset = "0x74E76D0", VA = "0x1874E82D0")]
	[BurstCompile]
	private unsafe static void CCOJBCCJODF([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74E7B60", Offset = "0x74E6F60", VA = "0x1874E7B60")]
	[BurstCompile]
	private static void BGFGNHBELGJ([Out] float4 BIEIOPPGBOB, ushort FEOHOONOGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74EB4F0", Offset = "0x74EA8F0", VA = "0x1874EB4F0")]
	private void GLBGHJADMGP(Allocator LEILKJFLDFN, NativeArray<float4> GKABEBKBPOJ, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74EB930", Offset = "0x74EAD30", VA = "0x1874EB930")]
	[BurstCompile]
	private unsafe static void GLBGHJADMGP([NoAlias] float4* ODCPGNMDEKP, [NoAlias] byte* HJKAHMPCAAB, [Out] int JGKEDJIFDPJ, [Out] int ODIGGFMJHDG, [NoAlias] float4* GKABEBKBPOJ, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74E88D0", Offset = "0x74E7CD0", VA = "0x1874E88D0")]
	private static void DELIOEIELIK(NativeArray<float4> DBLNCMIDANK, NativeArray<BDFIANNKNGG> LEMHIPNDEKF, NativeArray<byte> ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x74E8A00", Offset = "0x74E7E00", VA = "0x1874E8A00")]
	[BurstCompile]
	private unsafe static void DELIOEIELIK([NoAlias] float4* DBLNCMIDANK, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74EDBE0", Offset = "0x74ECFE0", VA = "0x1874EDBE0")]
	[BurstCompile]
	private unsafe static void LKOKADFMJHE([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74EF910", Offset = "0x74EED10", VA = "0x1874EF910")]
	[BurstCompile]
	private unsafe static void OMEGDNJHGBF([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x74E7C30", Offset = "0x74E7030", VA = "0x1874E7C30")]
	[BurstCompile]
	private unsafe static void BKKIAIGPLKJ([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74E8D40", Offset = "0x74E8140", VA = "0x1874E8D40")]
	[BurstCompile]
	private unsafe static void DIMPKABECKA([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74ECE00", Offset = "0x74EC200", VA = "0x1874ECE00")]
	[BurstCompile]
	private unsafe static void JOCMELFNCLK([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x74EE190", Offset = "0x74ED590", VA = "0x1874EE190")]
	private void MODAJMKCKCJ(Allocator LEILKJFLDFN, NativeArray<int> JPEGACICKGA, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74ED250", Offset = "0x74EC650", VA = "0x1874ED250")]
	private static NativeArray<byte> KJICPJKLCAK(Allocator LEILKJFLDFN, NativeArray<int> JPEGACICKGA, int GPBCHJIBNEA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74ED1E0", Offset = "0x74EC5E0", VA = "0x1874ED1E0")]
	[BurstCompile]
	private unsafe static int KJICPJKLCAK([NoAlias] byte* LPMBCLACJPB, [In][NoAlias] int* JPEGACICKGA, int GPBCHJIBNEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74EA4B0", Offset = "0x74E98B0", VA = "0x1874EA4B0")]
	private static void FEOPHPOOKKA(NativeArray<int> IEAABGGIGJB, NativeArray<byte> PGOBAABAIKF, int BHEMEOKJHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74EA5A0", Offset = "0x74E99A0", VA = "0x1874EA5A0")]
	[BurstCompile]
	private unsafe static void FEOPHPOOKKA([NoAlias] int* IEAABGGIGJB, [In][NoAlias] byte* PGOBAABAIKF, int BHEMEOKJHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x74EA720", Offset = "0x74E9B20", VA = "0x1874EA720")]
	[BurstCompile]
	private unsafe static void FKIGKIGPBNP([NoAlias] ushort* IEAABGGIGJB, [In][NoAlias] byte* PGOBAABAIKF, int BHEMEOKJHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x74F0370", Offset = "0x74EF770", VA = "0x1874F0370")]
	[BurstCompile]
	private static void PKHBKPMJMOL([Out] float3 KBMAJILDLKJ, ushort FEOHOONOGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74EFFB0", Offset = "0x74EF3B0", VA = "0x1874EFFB0")]
	[BurstCompile]
	private static ushort PBEJOAFGPHA([In] float3 MGAHBPIPINI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74DF560", Offset = "0x74DE960", VA = "0x1874DF560")]
	[BurstCompile]
	public unsafe static void OBBJDBOOLIJ([NoAlias] float3* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x74EA810", Offset = "0x74E9C10", VA = "0x1874EA810")]
	[BurstCompile]
	public unsafe static void FNOCNJEGDNE([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74EDFD0", Offset = "0x74ED3D0", VA = "0x1874EDFD0")]
	[BurstCompile]
	public unsafe static void MGJILJKLKNO([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74EB9C0", Offset = "0x74EADC0", VA = "0x1874EB9C0")]
	[BurstCompile]
	public unsafe static void NCCELPEEDAI([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74EB9C0", Offset = "0x74EADC0", VA = "0x1874EB9C0")]
	[BurstCompile]
	public unsafe static void GPNNKJFCHFN([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74EC300", Offset = "0x74EB700", VA = "0x1874EC300")]
	[BurstCompile]
	public unsafe static void IEALLPPOBBO([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* MDINJBMBKFJ, int EJENEKIJBLE, [In] float3 BFCACIBFOCP, [In] float3 MGNEECAKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74DF180", Offset = "0x74DE580", VA = "0x1874DF180")]
	[BurstCompile]
	public unsafe static void NHBDJLJKNNP([NoAlias] ushort* OIMOPLDJCHO, [Out] float3 ODKPPILCFCJ, [Out] float3 MGNEECAKBAO, [In][NoAlias] float3* MDINJBMBKFJ, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x74EE3B0", Offset = "0x74ED7B0", VA = "0x1874EE3B0")]
	[BurstCompile]
	public unsafe static void NGPIHMEFMPA([NoAlias] ushort* APOLMDOKIKJ, [In][NoAlias] float3* HGLFOJPFINL, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x74E98F0", Offset = "0x74E8CF0", VA = "0x1874E98F0")]
	[BurstCompile]
	public unsafe static void EFGDBDNJOKO([NoAlias] float3* JEDGAOJKNLP, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74ECA70", Offset = "0x74EBE70", VA = "0x1874ECA70")]
	[BurstCompile]
	public unsafe static void JJAJKLOHJMP([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x74EEF10", Offset = "0x74EE310", VA = "0x1874EEF10")]
	[BurstCompile]
	public unsafe static void NNHHIMAPHDF([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x74E95D0", Offset = "0x74E89D0", VA = "0x1874E95D0")]
	[BurstCompile]
	public unsafe static void DPJFOICHAJH([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74E6F80", Offset = "0x74E6380", VA = "0x1874E6F80")]
	[BurstCompile]
	public unsafe static void ABPHCGKOHIP([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74E70F0", Offset = "0x74E64F0", VA = "0x1874E70F0")]
	[BurstCompile]
	public unsafe static void AEPPNIOPNDN([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* HGLFOJPFINL, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74DE2D0", Offset = "0x74DD6D0", VA = "0x1874DE2D0")]
	[BurstCompile]
	public unsafe static void GGAEODDDKLL([NoAlias] uint* HEPDMBKPKIJ, [Out] float2 AJKBDLJPNNB, [Out] float2 LNCPFBAGODO, [In][NoAlias] float2* MLNAKENDILN, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74E8620", Offset = "0x74E7A20", VA = "0x1874E8620")]
	[BurstCompile]
	public static void CLNFKLHPCFA([Out] float2 KBMAJILDLKJ, uint FEOHOONOGAO, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74EA610", Offset = "0x74E9A10", VA = "0x1874EA610")]
	[BurstCompile]
	public unsafe static void FHEMFPKFLDP([NoAlias] float2* HEPDMBKPKIJ, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74E8190", Offset = "0x74E7590", VA = "0x1874E8190")]
	[BurstCompile]
	public unsafe static void CCGJDIFEPKP([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74ECCC0", Offset = "0x74EC0C0", VA = "0x1874ECCC0")]
	[BurstCompile]
	public unsafe static void JNCPFHAOCGB([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74E8400", Offset = "0x74E7800", VA = "0x1874E8400")]
	[BurstCompile]
	public unsafe static void CLGBGJFNFLB([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74E87A0", Offset = "0x74E7BA0", VA = "0x1874E87A0")]
	[BurstCompile]
	public unsafe static void DAOIIDOBBPN([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x74EE6D0", Offset = "0x74EDAD0", VA = "0x1874EE6D0")]
	[BurstCompile]
	public unsafe static void NKMOBOKIMIM([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [NoAlias] uint* MLNAKENDILN, int EJENEKIJBLE, [In] float2 EJGMPPPNFFA, [In] float2 LNCPFBAGODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74ED070", Offset = "0x74EC470", VA = "0x1874ED070")]
	[BurstCompile]
	public unsafe static void KBEOIJGNALG([NoAlias] ushort* LOOMOBPNAIP, [In][NoAlias] float4* IDHBGNHPKLL, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74ED150", Offset = "0x74EC550", VA = "0x1874ED150")]
	[BurstCompile]
	public static ushort KCAOGNMLKPO([In] float4 MGAHBPIPINI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74F08E0", Offset = "0x74EFCE0", VA = "0x1874F08E0")]
	[BurstCompile]
	public unsafe static void POIAHNKAGHC([NoAlias] float4* LOOMOBPNAIP, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74EC460", Offset = "0x74EB860", VA = "0x1874EC460")]
	[BurstCompile]
	public unsafe static void IFBAJNDJNOG([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74EACF0", Offset = "0x74EA0F0", VA = "0x1874EACF0")]
	[BurstCompile]
	public unsafe static void GAOOPDALCHC([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74EB380", Offset = "0x74EA780", VA = "0x1874EB380")]
	[BurstCompile]
	public unsafe static void GKJLILEDOCK([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74E8A80", Offset = "0x74E7E80", VA = "0x1874E8A80")]
	[BurstCompile]
	public unsafe static void DFIHHAKEDPN([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x74EAF80", Offset = "0x74EA380", VA = "0x1874EAF80")]
	[BurstCompile]
	public unsafe static void GIBGGJADIJD([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] ushort* EPFOAFDPIIK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x74EF360", Offset = "0x74EE760", VA = "0x1874EF360")]
	[BurstCompile]
	public static void OAHFOMJFHOH([Out] float4 BIEIOPPGBOB, ushort FEOHOONOGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74DE590", Offset = "0x74DD990", VA = "0x1874DE590")]
	[BurstCompile]
	public unsafe static void HGBMPIOOOIL([NoAlias] float4* ODCPGNMDEKP, [NoAlias] byte* HJKAHMPCAAB, [Out] int JGKEDJIFDPJ, [Out] int ODIGGFMJHDG, [NoAlias] float4* GKABEBKBPOJ, int OLPCPICADPM, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74E8660", Offset = "0x74E7A60", VA = "0x1874E8660")]
	[BurstCompile]
	public unsafe static void CNELEDONOGL([NoAlias] float4* DBLNCMIDANK, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74E9710", Offset = "0x74E8B10", VA = "0x1874E9710")]
	[BurstCompile]
	public unsafe static void EBOKNCHGPPO([NoAlias] FBFDINCPKFI.IDDEDPMCNND* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74E7900", Offset = "0x74E6D00", VA = "0x1874E7900")]
	[BurstCompile]
	public unsafe static void BDKMJLCNBEP([NoAlias] FBFDINCPKFI.AMHDPPPKJCD* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x74EC7D0", Offset = "0x74EBBD0", VA = "0x1874EC7D0")]
	[BurstCompile]
	public unsafe static void JFFOPLCDMDA([NoAlias] FBFDINCPKFI.FFJOEAHCGPL* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74EA950", Offset = "0x74E9D50", VA = "0x1874EA950")]
	[BurstCompile]
	public unsafe static void FPJIKCFKCEK([NoAlias] FBFDINCPKFI.GOCIBCNPJJK* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74ED930", Offset = "0x74ECD30", VA = "0x1874ED930")]
	[BurstCompile]
	public unsafe static void KMKCPDDLAOB([NoAlias] FBFDINCPKFI.OKMICELLMPH* OIMOPLDJCHO, [In][NoAlias] BDFIANNKNGG* LEMHIPNDEKF, [In][NoAlias] byte* ECDNGLDCKAK, int EJENEKIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74EBA80", Offset = "0x74EAE80", VA = "0x1874EBA80")]
	[BurstCompile]
	public unsafe static int HFOIJEMJBCN([NoAlias] byte* LPMBCLACJPB, [In][NoAlias] int* JPEGACICKGA, int GPBCHJIBNEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74EE310", Offset = "0x74ED710", VA = "0x1874EE310")]
	[BurstCompile]
	public unsafe static void NDLFIFJHAMF([NoAlias] int* IEAABGGIGJB, [In][NoAlias] byte* PGOBAABAIKF, int BHEMEOKJHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74EF420", Offset = "0x74EE820", VA = "0x1874EF420")]
	[BurstCompile]
	public unsafe static void OGCJGJAMLMG([NoAlias] ushort* IEAABGGIGJB, [In][NoAlias] byte* PGOBAABAIKF, int BHEMEOKJHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x74DDEF0", Offset = "0x74DD2F0", VA = "0x1874DDEF0")]
	[BurstCompile]
	public static void EOOGICPMNAD([Out] float3 KBMAJILDLKJ, ushort FEOHOONOGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74DF7C0", Offset = "0x74DEBC0", VA = "0x1874DF7C0")]
	[BurstCompile]
	public static ushort PLOCIKKJBJL([In] float3 MGAHBPIPINI)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class FBFDINCPKFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum KMIBOCLMOJF
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum FOGGDKNHLON
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		_,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		_VERTEX_FORMAT_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		_VERTEX_FORMAT_POSFIXED16_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct HFLEOPBJILK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KMIBOCLMOJF HGFLLJFOAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool NEIGFPNFJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int DICAHKBMNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public VertexAttributeDescriptor[] KJJAPDIMEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct BNGKHJGHFEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public float3 NDADPNJPMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 FGKLFPNFOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float4 OBJCIKCFCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float2 LKNALLJOHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float4 EDEDDIPBAKP;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly VertexAttributeDescriptor[] KJJAPDIMEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct IDDEDPMCNND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public float3 NDADPNJPMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public half4 FGKLFPNFOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 OBJCIKCFCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public float2 LKNALLJOHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public half4 EDEDDIPBAKP;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly VertexAttributeDescriptor[] KJJAPDIMEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct AMHDPPPKJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public float3 NDADPNJPMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public uint FGKLFPNFOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint OBJCIKCFCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public float2 LKNALLJOHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public half4 EDEDDIPBAKP;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly VertexAttributeDescriptor[] KJJAPDIMEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct FFJOEAHCGPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public float3 NDADPNJPMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public uint FGKLFPNFOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint OBJCIKCFCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public half2 LKNALLJOHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half4 EDEDDIPBAKP;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly VertexAttributeDescriptor[] KJJAPDIMEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct GOCIBCNPJJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public float3 NDADPNJPMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public uint HODNCBPKKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float2 LKNALLJOHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public uint HHIBMGMGHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint JCFEMBBMLPO;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly VertexAttributeDescriptor[] KJJAPDIMEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct OKMICELLMPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public ADMJKCABPGH.BAENJJCOPLK IAIGPADBEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public uint HODNCBPKKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float2 LKNALLJOHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public uint HHIBMGMGHKB;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly VertexAttributeDescriptor[] KJJAPDIMEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int CKDHMHPCNJN(float IKAEODCKAIP);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class KGAPFJGKGMC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x74FDE70", Offset = "0x74FD270", VA = "0x1874FDE70")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x74FDD10", Offset = "0x74FD110", VA = "0x1874FDD10")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x74FE210", Offset = "0x74FD610", VA = "0x1874FE210")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x74FDFA0", Offset = "0x74FD3A0", VA = "0x1874FDFA0")]
		public static int CNDNDIPPKBE(float IKAEODCKAIP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint DGCNNIHAFKL([In] float4 EFDAGALIIFI);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class LOBBFLFMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7500440", Offset = "0x74FF840", VA = "0x187500440")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x75002E0", Offset = "0x74FF6E0", VA = "0x1875002E0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x75008B0", Offset = "0x74FFCB0", VA = "0x1875008B0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7500570", Offset = "0x74FF970", VA = "0x187500570")]
		public static uint CNDNDIPPKBE([In] float4 EFDAGALIIFI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint ICFDLEEFHMD([In] float3 EFDAGALIIFI);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class AFBOCPOGIPF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7505130", Offset = "0x7504530", VA = "0x187505130")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7504FD0", Offset = "0x75043D0", VA = "0x187504FD0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x75054B0", Offset = "0x75048B0", VA = "0x1875054B0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7505260", Offset = "0x7504660", VA = "0x187505260")]
		public static uint CNDNDIPPKBE([In] float3 EFDAGALIIFI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void KKMLAEHGKMK([NoAlias] AMHDPPPKJCD* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class EKDKMANBHNC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x750F780", Offset = "0x750EB80", VA = "0x18750F780")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x750F620", Offset = "0x750EA20", VA = "0x18750F620")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x750FAF0", Offset = "0x750EEF0", VA = "0x18750FAF0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x750F8B0", Offset = "0x750ECB0", VA = "0x18750F8B0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] AMHDPPPKJCD* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void HHBNKBPJIFG([NoAlias] FFJOEAHCGPL* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class MLDDPNNDGOG
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x751A5C0", Offset = "0x75199C0", VA = "0x18751A5C0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x751A460", Offset = "0x7519860", VA = "0x18751A460")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x751A930", Offset = "0x7519D30", VA = "0x18751A930")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x751A6F0", Offset = "0x7519AF0", VA = "0x18751A6F0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] FFJOEAHCGPL* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void CMBAAEJPCBP([NoAlias] GOCIBCNPJJK* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class EPBHMLHIDDC
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7513D00", Offset = "0x7513100", VA = "0x187513D00")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7513BA0", Offset = "0x7512FA0", VA = "0x187513BA0")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7514220", Offset = "0x7513620", VA = "0x187514220")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7513E30", Offset = "0x7513230", VA = "0x187513E30")]
		public unsafe static void CNDNDIPPKBE([NoAlias] GOCIBCNPJJK* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void BLEMMBPBJLI([NoAlias] OKMICELLMPH* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP, [Out] float3 KEKCJBFJPPL, [Out] float3 GMBLKOBEHEN);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class PMBNLJPMJPL
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x751B670", Offset = "0x751AA70", VA = "0x18751B670")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x751B510", Offset = "0x751A910", VA = "0x18751B510")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x751BD00", Offset = "0x751B100", VA = "0x18751BD00")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x751B7A0", Offset = "0x751ABA0", VA = "0x18751B7A0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] OKMICELLMPH* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP, [Out] float3 KEKCJBFJPPL, [Out] float3 GMBLKOBEHEN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public const int KOEFMKBAALL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<float3> BLEBKCPGMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<float3> LLOIIOBGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float4> OIEPNGPMGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> KAGJJOCEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float2> KHGMOPNBFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<int> EPLKJIAFONN;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly VertexAttributeDescriptor[][] EOOKCCCDCHK;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static bool EDAAMNHEIIO;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static HFLEOPBJILK[] APJCNNFOHAH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x74F1620", Offset = "0x74F0A20", VA = "0x1874F1620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DHJENKIBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x74F2380", Offset = "0x74F1780", VA = "0x1874F2380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DILBJJMOMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x74F45B0", Offset = "0x74F39B0", VA = "0x1874F45B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AHFMDEPIPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x74F45F0", Offset = "0x74F39F0", VA = "0x1874F45F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x74F1210", Offset = "0x74F0610", VA = "0x1874F1210")]
	public static FOGGDKNHLON BNBOLAOOCIL(KMIBOCLMOJF HGFLLJFOAAE)
	{
		return default(FOGGDKNHLON);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x74F34B0", Offset = "0x74F28B0", VA = "0x1874F34B0")]
	public static void GGFJOODBCND(FOGGDKNHLON NNLDECDLHMC, Material HJCEHLILOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x74F2BA0", Offset = "0x74F1FA0", VA = "0x1874F2BA0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x74F5C20", Offset = "0x74F5020", VA = "0x1874F5C20")]
	public void NLKPFDGIMDD(int NCNLMCPMFCK, int LMFBKOOOEDD, Allocator LEILKJFLDFN, bool FNGHJBMCEAD, bool IHKOBNPEFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x74F5E10", Offset = "0x74F5210", VA = "0x1874F5E10")]
	public void OCIMONOCOND(int NCNLMCPMFCK, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x74F3830", Offset = "0x74F2C30", VA = "0x1874F3830", Slot = "6")]
	public bool JMNEMPFIKNO(Mesh LCGHOEMEOEK, bool PJNLBFDNBAI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x74F4A80", Offset = "0x74F3E80", VA = "0x1874F4A80")]
	public bool MBILLNFHDBP(Mesh LCGHOEMEOEK, bool PJNLBFDNBAI, bool EAFFMHKKAHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x74F3930", Offset = "0x74F2D30", VA = "0x1874F3930")]
	public bool KCGNEFEFMGO(Mesh LCGHOEMEOEK, FBFDINCPKFI JHLLFBMECMK, bool PJNLBFDNBAI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x74F5E90", Offset = "0x74F5290", VA = "0x1874F5E90")]
	public bool OHJKHDGIOHG(Mesh LCGHOEMEOEK, FBFDINCPKFI JHLLFBMECMK, KMIBOCLMOJF HGFLLJFOAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x74F6270", Offset = "0x74F5670", VA = "0x1874F6270")]
	private void ONFGCGCKOCF(Mesh LCGHOEMEOEK, FBFDINCPKFI JHLLFBMECMK, bool EAFFMHKKAHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x74F5F60", Offset = "0x74F5360", VA = "0x1874F5F60")]
	public void ONFGCGCKOCF(NativeArray<ushort> KNADDHPHBKK, NativeArray<GOCIBCNPJJK> IFMGBJPNCCB, Mesh LCGHOEMEOEK, FBFDINCPKFI JHLLFBMECMK, bool EAFFMHKKAHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x74F51E0", Offset = "0x74F45E0", VA = "0x1874F51E0")]
	public void NLKDJEIFNLJ(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x74F3460", Offset = "0x74F2860", VA = "0x1874F3460")]
	[BurstCompile]
	public static int FJCOMPLHFLF(float IKAEODCKAIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74F33C0", Offset = "0x74F27C0", VA = "0x1874F33C0")]
	[BurstCompile]
	public static uint FJCOMPLHFLF([In] float4 EFDAGALIIFI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x74F3410", Offset = "0x74F2810", VA = "0x1874F3410")]
	[BurstCompile]
	public static uint FJCOMPLHFLF([In] float3 EFDAGALIIFI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x74F0B80", Offset = "0x74EFF80", VA = "0x1874F0B80")]
	public void ALELOKNCCMM(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x74F3600", Offset = "0x74F2A00", VA = "0x1874F3600")]
	[BurstCompile]
	private unsafe static void HOOKLIBNJHO([NoAlias] AMHDPPPKJCD* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x74F2CB0", Offset = "0x74F20B0", VA = "0x1874F2CB0")]
	public void ELHDCCLDBBC(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x74F4E80", Offset = "0x74F4280", VA = "0x1874F4E80")]
	[BurstCompile]
	private unsafe static void MOFPPDHHMGL([NoAlias] FFJOEAHCGPL* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x74F2420", Offset = "0x74F1820", VA = "0x1874F2420")]
	public void DNOHPKNOBLB(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x74F27F0", Offset = "0x74F1BF0", VA = "0x1874F27F0")]
	public void DNOHPKNOBLB(NativeArray<ushort> EEPKNOKHHND, NativeArray<GOCIBCNPJJK> PHDCDBDEDFM, Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x74F3340", Offset = "0x74F2740", VA = "0x1874F3340")]
	[BurstCompile]
	public unsafe static void FEAPMHOBKDO([NoAlias] GOCIBCNPJJK* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x74F6A00", Offset = "0x74F5E00", VA = "0x1874F6A00")]
	public void PAGNLEMPCOD(Mesh LCGHOEMEOEK, bool EAFFMHKKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x74F5000", Offset = "0x74F4400", VA = "0x1874F5000")]
	[BurstCompile]
	private unsafe static void NDJBKKFLOPF([NoAlias] OKMICELLMPH* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP, [Out] float3 KEKCJBFJPPL, [Out] float3 GMBLKOBEHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x74F3570", Offset = "0x74F2970", VA = "0x1874F3570")]
	public void HNNBMHNMLBF(Mesh LCGHOEMEOEK, KMIBOCLMOJF HGFLLJFOAAE, bool EAFFMHKKAHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x74F1C30", Offset = "0x74F1030", VA = "0x1874F1C30")]
	public void CGDLHICEKJD(FBFDINCPKFI LCGHOEMEOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x74F4F00", Offset = "0x74F4300", VA = "0x1874F4F00")]
	public void NBCMBLIAOFF(FBFDINCPKFI MBDLAJMBAIN, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x74F36E0", Offset = "0x74F2AE0", VA = "0x1874F36E0")]
	public long JFHACJJLLHE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x74F3680", Offset = "0x74F2A80", VA = "0x1874F3680")]
	public static long JFHACJJLLHE(int HCCAGFNBGED, int LDBOBINCOLC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x74F5140", Offset = "0x74F4540", VA = "0x1874F5140")]
	public static long NJLAALHOALG(int HCCAGFNBGED, int LDBOBINCOLC, KMIBOCLMOJF HGFLLJFOAAE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x74F5080", Offset = "0x74F4480", VA = "0x1874F5080")]
	public long NJLAALHOALG(KMIBOCLMOJF HGFLLJFOAAE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x74F23C0", Offset = "0x74F17C0", VA = "0x1874F23C0")]
	public void DKJKNGIMBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x74F1660", Offset = "0x74F0A60", VA = "0x1874F1660")]
	public static void CGANJONEAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x74F3E30", Offset = "0x74F3230", VA = "0x1874F3E30")]
	public KMIBOCLMOJF LACAIBBKNFH()
	{
		return default(KMIBOCLMOJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x74F0AB0", Offset = "0x74EFEB0", VA = "0x1874F0AB0")]
	public static (int, int) AHKCPGOHEHM(Mesh LCGHOEMEOEK)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x74F3850", Offset = "0x74F2C50", VA = "0x1874F3850")]
	public static int JMOHNBGAHPC(VertexAttributeDescriptor[] LLLOEEDEFGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x74F7480", Offset = "0x74F6880", VA = "0x1874F7480")]
	public static long POPPJFIAIAJ(Mesh LCGHOEMEOEK, int ONEGPPHFPHL, int GGKNCJKHMFH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x74F74F0", Offset = "0x74F68F0", VA = "0x1874F74F0")]
	public static long POPPJFIAIAJ(Mesh LCGHOEMEOEK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public FBFDINCPKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x74F2150", Offset = "0x74F1550", VA = "0x1874F2150")]
	[BurstCompile]
	public static int DEILJIMCEPE(float IKAEODCKAIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x74F21F0", Offset = "0x74F15F0", VA = "0x1874F21F0")]
	[BurstCompile]
	public static uint DEILJIMCEPE([In] float4 EFDAGALIIFI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x74F20A0", Offset = "0x74F14A0", VA = "0x1874F20A0")]
	[BurstCompile]
	public static uint DEILJIMCEPE([In] float3 EFDAGALIIFI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x74F1260", Offset = "0x74F0660", VA = "0x1874F1260")]
	[BurstCompile]
	public unsafe static void BOIMFMLPHJJ([NoAlias] AMHDPPPKJCD* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x74F4630", Offset = "0x74F3A30", VA = "0x1874F4630")]
	[BurstCompile]
	public unsafe static void LPHIOEENNLH([NoAlias] FFJOEAHCGPL* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x74F1EA0", Offset = "0x74F12A0", VA = "0x1874F1EA0")]
	[BurstCompile]
	public unsafe static void DDJMLOOMPIE([NoAlias] GOCIBCNPJJK* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x74F7140", Offset = "0x74F6540", VA = "0x1874F7140")]
	[BurstCompile]
	public unsafe static void PIJNCKHKBKD([NoAlias] OKMICELLMPH* OIMOPLDJCHO, int EJENEKIJBLE, [In][NoAlias] float3* JHJNMCGMILB, [In][NoAlias] float3* MFHDKAJNHGA, [In][NoAlias] float4* EAGILGGDNGD, [In][NoAlias] float2* NBOPCHOKEEB, [In][NoAlias] float4* EDEDDIPBAKP, [Out] float3 KEKCJBFJPPL, [Out] float3 GMBLKOBEHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct NKJHBIHLOIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public int JJILNPACNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 JLKNCBIIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public quaternion ILOMAGGOBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public float3 NBMPINCCDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int IAODGAIPHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int GKMLNPEPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int LDHGIKPHDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public float INBIAHCDOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float3 HDHBKBDNLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public bool APHCPCFEGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public EKABDFAIFNM DOGFMGFMBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public float3 FPMHLPJNMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float PPAOJEAOGHL;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class AIIDIKHPDOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static LHIMPKGNCEC MPFICALBOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public NativeList<NKJHBIHLOIK> KLNANCOBEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<JGLCOCGAPMH> DCOPFLAGBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<MNHBMAKPPKN> JPLCLCKFMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeArray<MJHFHLJEIGI> AMHDEODBDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeList<JGLCOCGAPMH> LEJFJBJADJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<FKDLPCCHFPC> NLPJMMKFMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private List<NativeArray<MJHFHLJEIGI>> LNBMAJMCICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private NativeList<MKCHKHONKEK> JNGPNHCBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeArray<int> HFBNGDEGLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> MEIKIMANGEG;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static NativeList<DDFIFOHEEBL.FJHJGNPHLIN> OBLNIAPIJPE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DHJENKIBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x94F5D0", Offset = "0x94E9D0", VA = "0x18094F5D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x94F5C0", Offset = "0x94E9C0", VA = "0x18094F5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DILBJJMOMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xAA5940", Offset = "0xAA4D40", VA = "0x180AA5940")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5950", Offset = "0xAA4D50", VA = "0x180AA5950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x75075B0", Offset = "0x75069B0", VA = "0x1875075B0")]
	public AIIDIKHPDOL(int BHHDLNAKPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7505810", Offset = "0x7504C10", VA = "0x187505810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7505D70", Offset = "0x7505170", VA = "0x187505D70")]
	public void GDCMIOJAIMJ(JobHandle NIJHHKONNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7505F60", Offset = "0x7505360", VA = "0x187505F60")]
	public void IDGPMNHFJPC(NKJHBIHLOIK GIDGOODJFLJ, MKCHKHONKEK EAAPKHLJOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7506180", Offset = "0x7505580", VA = "0x187506180")]
	public void MHIODBIACKH(MNHBMAKPPKN GIDGOODJFLJ, NativeArray<MJHFHLJEIGI> OOJPHCJDFEK, int EJENEKIJBLE, int BHEMEOKJHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7507490", Offset = "0x7506890", VA = "0x187507490")]
	public JobHandle MJCAFBLJCJE(FBFDINCPKFI NFLOPGDKNJF, NFBJNLMOOIN GBAGKPNELCL, float3 LHLDFPILEDA, quaternion HCPPKCNDHMI, float GOEHHCADAHF, bool ECNCDFHAOOO, int OOOPLLCOICL = 0, int FEGFPJLJNGN = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x75062E0", Offset = "0x75056E0", VA = "0x1875062E0")]
	public JobHandle MJCAFBLJCJE(FBFDINCPKFI NFLOPGDKNJF, NFBJNLMOOIN GBAGKPNELCL, NativeList<DDFIFOHEEBL.FJHJGNPHLIN> PHHJHIHELAN, float3 LHLDFPILEDA, quaternion HCPPKCNDHMI, float GOEHHCADAHF, bool ECNCDFHAOOO, bool CNLDNJPNGNH, int OOOPLLCOICL = 0, int FEGFPJLJNGN = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x75059F0", Offset = "0x7504DF0", VA = "0x1875059F0")]
	public static JobHandle EAEFFBDOEJM(GFIHIHGEMHO OFNDGACAHPN, FBFDINCPKFI NFLOPGDKNJF, NativeArray<int> MEIKIMANGEG, NKJHBIHLOIK GIDGOODJFLJ, JobHandle NIJHHKONNDH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7505560", Offset = "0x7504960", VA = "0x187505560")]
	public static JobHandle ALNHFJOLGCJ(CDMFKIAEDKP OFNDGACAHPN, FBFDINCPKFI NFLOPGDKNJF, MNHBMAKPPKN GIDGOODJFLJ, NativeArray<MJHFHLJEIGI> OOJPHCJDFEK, int EJENEKIJBLE, int BHEMEOKJHOM, JobHandle NIJHHKONNDH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class BLKGCPJCEME
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct FLDLEOBHJMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public MeshRenderer EHMEICJAGNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public EMCPLJJJIOC.OBFJJIPGFKD PCOEENEIHAD;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x55FC990", Offset = "0x55FBD90", VA = "0x1855FC990")]
		public FLDLEOBHJMO(MeshRenderer EHMEICJAGNO, EMCPLJJJIOC.OBFJJIPGFKD PCOEENEIHAD)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x75142D0", Offset = "0x75136D0", VA = "0x1875142D0")]
		public static FLDLEOBHJMO HEGJABMHLEC((MeshRenderer, EMCPLJJJIOC.OBFJJIPGFKD) IEFMBDGJEHE)
		{
			return default(FLDLEOBHJMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ProfilerMarker NMDJAHJOBCA;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker OFJLCCIIHDF;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker CFNLFOPOJNE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker IAFCPNJMBFC;

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x750B480", Offset = "0x750A880", VA = "0x18750B480")]
	internal void LAGLHEEIHLA(EMCPLJJJIOC.MBKIHLAEMHJ HNIOPAHNAHP, List<FLDLEOBHJMO> NIDCHMBGOBI, Material HJCEHLILOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x750BCA0", Offset = "0x750B0A0", VA = "0x18750BCA0")]
	internal void OEALMMDNHPK(EMCPLJJJIOC.MBKIHLAEMHJ HNIOPAHNAHP, List<FLDLEOBHJMO> NIDCHMBGOBI, List<LODGroup> KEKNLHJOKCM, Material HJCEHLILOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x750A890", Offset = "0x7509C90", VA = "0x18750A890")]
	private MeshRenderer BNOGOGBJKGC(EMCPLJJJIOC.MBKIHLAEMHJ HNIOPAHNAHP, Material HJCEHLILOIG, List<FLDLEOBHJMO> NIDCHMBGOBI, bool LMMOEGNPBLC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7509990", Offset = "0x7508D90", VA = "0x187509990")]
	private List<(List<FLDLEOBHJMO>, float)> AEJDLIMLIGF(EMCPLJJJIOC.MBKIHLAEMHJ HNIOPAHNAHP, List<LODGroup> KEKNLHJOKCM, Material HJCEHLILOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x750C490", Offset = "0x750B890", VA = "0x18750C490")]
	private List<List<(List<FLDLEOBHJMO>, float)>> PCBLJFNBGGF(EMCPLJJJIOC.MBKIHLAEMHJ HNIOPAHNAHP, List<LODGroup> KEKNLHJOKCM, Material HJCEHLILOIG, [Out] int JABFOAEJJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public BLKGCPJCEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x750B310", Offset = "0x750A710", VA = "0x18750B310")]
	[CompilerGenerated]
	internal static (float, int) EJAOGBIMOPF(List<List<(List<FLDLEOBHJMO> meshList, float lodTransition)>> GEPDFFFONPM, int[] CFAHHMDBJAG)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KHPGJKBIFFH
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly ProfilerMarker ACNKDHGDGJJ;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly ProfilerMarker KHBBIIPEDFM;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker NFLHKPBEJJD;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker GFKKEEEIEFD;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker BHBKADKNLAE;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker HKAGCIDCIBK;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker EDIKPEHLHOF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IBCMILIKEJG FMFIIECMJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private EMCPLJJJIOC AKGNILPCIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private BLKGCPJCEME FOFCJMGKHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Shader ABCMFNFJJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private MaterialPropertyBlock MIIKODIKKMH;

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x75144E0", Offset = "0x75138E0", VA = "0x1875144E0")]
	public static void EPHFBIANDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7514F10", Offset = "0x7514310", VA = "0x187514F10")]
	public void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7515840", Offset = "0x7514C40", VA = "0x187515840")]
	public void KNBPPHCOECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x75147C0", Offset = "0x7513BC0", VA = "0x1875147C0")]
	private bool HCGBMDPKHDD(int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x75167C0", Offset = "0x7515BC0", VA = "0x1875167C0")]
	private void OOCLDIIMHDI(int EAHKFAJBNDN, Material HJCEHLILOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7515A90", Offset = "0x7514E90", VA = "0x187515A90")]
	private List<BLKGCPJCEME.FLDLEOBHJMO> MABCHFHLBIP(int EAHKFAJBNDN, [Out] List<LODGroup> KEKNLHJOKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7516250", Offset = "0x7515650", VA = "0x187516250")]
	private List<(int, Material)> NMPEOHNBPGE(float BDOOCJOFMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7515790", Offset = "0x7514B90", VA = "0x187515790")]
	public void IHILNAOKAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x75149E0", Offset = "0x7513DE0", VA = "0x1875149E0")]
	private bool HNLHJCKOLMA(GameObject HHDLNMHBJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7516C40", Offset = "0x7516040", VA = "0x187516C40")]
	public KHPGJKBIFFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[BurstCompile]
public class EMCPLJJJIOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[BurstCompatible]
	public struct MBKIHLAEMHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float3 HCEBABCAMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public float3 CDIPILBCKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float MEIJBDNBDDP;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7519770", Offset = "0x7518B70", VA = "0x187519770")]
		public MBKIHLAEMHJ(Bounds LMEMOMNCOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x75198E0", Offset = "0x7518CE0", VA = "0x1875198E0")]
		public MBKIHLAEMHJ(float3 HCEBABCAMLE, float3 CDIPILBCKFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct PPDCHFOPECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public MBKIHLAEMHJ IBKFDMFCDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int FANAMEGOGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int NBOMCKFMGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float GEAAELINOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int NCNLMCPMFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int BEGMLAKCLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int BPCIFGDCBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int FBCBINKNGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int PIDPMJDKMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public bool POEOKBMABCP;
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public struct OBFJJIPGFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Mesh HBCKFNLBLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Matrix4x4 NIBNHBJIIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int NPHBNMLAHON;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[BurstCompile]
	private struct MMCBFHGKEAC : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[ReadOnly]
		public NativeArray<PPDCHFOPECM> IHMOLBABGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[WriteOnly]
		public NativeArray<float> IBAFMNIDEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public int NDBCBFICMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public MBKIHLAEMHJ LMEMOMNCOOO;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x751AC00", Offset = "0x751A000", VA = "0x18751AC00")]
		private float OHMOPFNBEMF(MBKIHLAEMHJ AMGCKABOOPF, MBKIHLAEMHJ PPCFCAEIJMM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x751A9E0", Offset = "0x7519DE0", VA = "0x18751A9E0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker AHEAFAEBEBD;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker GOKIFLAONJO;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker BNAFOGMGMFD;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker GIEJOPIBJDP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker GDFDDPCDLDI;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker BOMKHCJMPOM;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker NNLJDOLLHPG;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker ECEDDCNPGBA;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker IELAINPJNGH;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker KDLIOPACCMP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker KOEMNFNBLFA;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker KFFLNMJDKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public NativeArray<PPDCHFOPECM> IHMOLBABGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeQueue<int> FJOOBCIFGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int FFGLMKAIMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Dictionary<Material, int> AFFDEENFOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public List<OBFJJIPGFKD> COKFMKOMJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public List<LODGroup> KEKNLHJOKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Dictionary<int, MeshRenderer> ECIPKLDOFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Queue<int> MPNEBCJKGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Shader CCHIGBCGDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Shader KCGPOJFHKKO;

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7513860", Offset = "0x7512C60", VA = "0x187513860")]
	public EMCPLJJJIOC(int FOJEFEGJNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7513400", Offset = "0x7512800", VA = "0x187513400")]
	private void PBFGBJEGDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x75113C0", Offset = "0x75107C0", VA = "0x1875113C0")]
	public bool KJEKMLGFMKE(MeshRenderer IBNPBKKMILL, MeshFilter LJDJFNCLEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7511850", Offset = "0x7510C50", VA = "0x187511850")]
	public bool KJEKMLGFMKE(LODGroup PBGCBFHCIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7511220", Offset = "0x7510620", VA = "0x187511220")]
	private bool HBIAGPPOPJF(MeshRenderer IBNPBKKMILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x75112A0", Offset = "0x75106A0", VA = "0x1875112A0")]
	private int IDCPHEPBHJO(MeshRenderer IBNPBKKMILL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7512AC0", Offset = "0x7511EC0", VA = "0x187512AC0")]
	private int NJDAPAGPJCL(LODGroup PBGCBFHCIGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7510B90", Offset = "0x750FF90", VA = "0x187510B90")]
	private int DCBHFKHNDOH(MeshFilter LJDJFNCLEJF, int MFCLFEPKGAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x75130A0", Offset = "0x75124A0", VA = "0x1875130A0")]
	private int OJKIALHKMGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x75107E0", Offset = "0x750FBE0", VA = "0x1875107E0")]
	private static MBKIHLAEMHJ CJDCIEKNEKD(MBKIHLAEMHJ AMGCKABOOPF, MBKIHLAEMHJ PPCFCAEIJMM)
	{
		return default(MBKIHLAEMHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7510690", Offset = "0x750FA90", VA = "0x187510690")]
	private static float CEHGMHEONIA(Vector3 HCEBABCAMLE, Vector3 CDIPILBCKFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7512B30", Offset = "0x7511F30", VA = "0x187512B30")]
	private int OCDHPLJDALH(int DBKPMLLNJMC, MBKIHLAEMHJ ANLHBGCPEFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x750FBA0", Offset = "0x750EFA0", VA = "0x18750FBA0")]
	private void BEGIMCHOCFE(MBKIHLAEMHJ ANLHBGCPEFB, int EAHKFAJBNDN, [Out] float OIKCKMHNIIJ, [Out] float EFHLBKBLOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7510DA0", Offset = "0x75101A0", VA = "0x187510DA0")]
	private void GBGNIKGEGED(MBKIHLAEMHJ ANLHBGCPEFB, int NMGAEEJOGCA, Material HJCEHLILOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7512E60", Offset = "0x7512260", VA = "0x187512E60")]
	private float OHMOPFNBEMF(MBKIHLAEMHJ AMGCKABOOPF, MBKIHLAEMHJ PPCFCAEIJMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x750FE00", Offset = "0x750F200", VA = "0x18750FE00")]
	private void BGLCNMEPOMP(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7510240", Offset = "0x750F640", VA = "0x187510240")]
	private void CAIIMNNDJLK(int DOEDICBKPCK, int JAEOJHGOKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7512510", Offset = "0x7511910", VA = "0x187512510")]
	private void NIKKCDMLLGM(int DOEDICBKPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7510CF0", Offset = "0x75100F0", VA = "0x187510CF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct NOIJFDBFCOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float2 MBLKEEKGIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public float2 CEPDBDAPIFF;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class CPDOMABMCIF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public NativeArray<NOIJFDBFCOG> BCECFMJFKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public NativeArray<int> JDDIOKMELPF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DHJENKIBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DILBJJMOMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x94D460", Offset = "0x94C860", VA = "0x18094D460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x750F490", Offset = "0x750E890", VA = "0x18750F490")]
	public CPDOMABMCIF(int NCNLMCPMFCK, int LMFBKOOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x750F430", Offset = "0x750E830", VA = "0x18750F430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x750F350", Offset = "0x750E750", VA = "0x18750F350")]
	public void CGDLHICEKJD(CPDOMABMCIF PGAMPBJNAGE, int OBCLAFPKHKD, int EKDINNHMJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class CGIMADIJNED
{
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static CPDOMABMCIF JIGDBJKEOHL;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static NativeList<JGLCOCGAPMH> PNIBBNBEFKK;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static int[] JLKPPLCKFLL;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static bool BMBGHJMKBOJ;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static Dictionary<int, CPDOMABMCIF> IDDFCJPKAHO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static Dictionary<int, CPDOMABMCIF> KIGEFCAMFFP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool BIDHFAMCONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x750E500", Offset = "0x750D900", VA = "0x18750E500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<JGLCOCGAPMH> MCJKCBPEBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x750DD10", Offset = "0x750D110", VA = "0x18750DD10")]
		get
		{
			return default(NativeList<JGLCOCGAPMH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static CPDOMABMCIF IBHHGDHINCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x750E460", Offset = "0x750D860", VA = "0x18750E460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x750D570", Offset = "0x750C970", VA = "0x18750D570")]
	private static void BJNPILDIOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x750D520", Offset = "0x750C920", VA = "0x18750D520")]
	public static int AHHEDKHDBCJ(bool NACAINHGGHA, int BANPPKLLOLC, bool LOMACABDFAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x750D550", Offset = "0x750C950", VA = "0x18750D550")]
	private static int BCPBCHHFFJK(int BANPPKLLOLC, bool KPJDJHGBJNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x750E450", Offset = "0x750D850", VA = "0x18750E450")]
	private static int JOOMHECEPCK(int BANPPKLLOLC, bool KPJDJHGBJNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x750DB90", Offset = "0x750CF90", VA = "0x18750DB90")]
	public static int EKBPLDFKJDP(int GNAJNFCKONF, int BANPPKLLOLC, int KEOKIIGECLE, bool KPJDJHGBJNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x750DDB0", Offset = "0x750D1B0", VA = "0x18750DDB0")]
	public static int HHIJKOOMCMI(int GNAJNFCKONF, int BANPPKLLOLC, int KEOKIIGECLE, bool KPJDJHGBJNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x750DB80", Offset = "0x750CF80", VA = "0x18750DB80")]
	public static int CMNBMFOLGFL(int KEOKIIGECLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x750D510", Offset = "0x750C910", VA = "0x18750D510")]
	private static int AELPKOBDFFA(int BANPPKLLOLC, bool KPJDJHGBJNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x750E0D0", Offset = "0x750D4D0", VA = "0x18750E0D0")]
	private static int IGPMLPKLBGK(int BANPPKLLOLC, bool KPJDJHGBJNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x750E990", Offset = "0x750DD90", VA = "0x18750E990")]
	public static int OOMPKKDGION(int GNAJNFCKONF, int BANPPKLLOLC, int KEOKIIGECLE, bool KPJDJHGBJNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x750EA00", Offset = "0x750DE00", VA = "0x18750EA00")]
	public static int PCCLNEHIHJG(int GNAJNFCKONF, int BANPPKLLOLC, int KEOKIIGECLE, bool KPJDJHGBJNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x750E0F0", Offset = "0x750D4F0", VA = "0x18750E0F0")]
	public static int JBOPBADJJOC(int KEOKIIGECLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x750EA90", Offset = "0x750DE90", VA = "0x18750EA90")]
	public static CPDOMABMCIF PFAPLCLIELF(int BANPPKLLOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x750DE40", Offset = "0x750D240", VA = "0x18750DE40")]
	private static CPDOMABMCIF HJEDANBPLKN(int BANPPKLLOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x750DC20", Offset = "0x750D020", VA = "0x18750DC20")]
	public static CPDOMABMCIF GHJMIILMCMK(int BANPPKLLOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x750E110", Offset = "0x750D510", VA = "0x18750E110")]
	private static CPDOMABMCIF JLAKHLLGCPC(int BANPPKLLOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x750E580", Offset = "0x750D980", VA = "0x18750E580")]
	public static void ONKGPPOKPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct MNHBMAKPPKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public int GOEMOBCNDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public float3 JLKNCBIIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public quaternion ILOMAGGOBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public float NBMPINCCDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public float OMKEOMHLKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public int IAODGAIPHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public int GKMLNPEPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public int LDHGIKPHDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool BFJCNMBOKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool MKNMKDCLMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public float INBIAHCDOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public float3 HDHBKBDNLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool IIAOKFHEHAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct FKDLPCCHFPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public int KENBOBAMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int DDEAECAGNJB;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct CDMFKIAEDKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public NativeList<MNHBMAKPPKN> NDHBCDBCOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public NativeArray<MJHFHLJEIGI> NIFFDBCBALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public NativeArray<JGLCOCGAPMH> GFKNOEBNKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public NativeArray<FKDLPCCHFPC> FJMINAIKEKE;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x750D3E0", Offset = "0x750C7E0", VA = "0x18750D3E0")]
	public CDMFKIAEDKP(NativeArray<MJHFHLJEIGI> NIFFDBCBALN, int IBMHAIHIDJJ = 1, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x750D2F0", Offset = "0x750C6F0", VA = "0x18750D2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[BurstCompile]
public struct KJJFGDEALEH : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	private NativeArray<NOIJFDBFCOG> JJANOFDCLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	private NativeArray<int> FOHGKKJBFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[ReadOnly]
	private NativeList<JGLCOCGAPMH> HFHDILDPPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[ReadOnly]
	private NativeList<MNHBMAKPPKN> NDHBCDBCOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<MJHFHLJEIGI> NIFFDBCBALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<JGLCOCGAPMH> GFKNOEBNKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	public NativeArray<FKDLPCCHFPC> FJMINAIKEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private int PAEGKKCIPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private int BAOCAHKCLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private float3 LKDHGOLEDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	private quaternion BGMPPCDNKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private float3 FGELKJJAOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FHOMHJONJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CKFFABGBDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MKJJCOEMPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BJBCLDDKDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NFNHHKJACDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NEBMBDKJDFH;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7518D70", Offset = "0x7518170", VA = "0x187518D70")]
	public KJJFGDEALEH(AIIDIKHPDOL GOKNGDDLCCB, FBFDINCPKFI HIBNFLMDEPG, float3 EFOMBHELPPK, quaternion AKKODFJGDGC, float FGLGAADJJAN, int OOOPLLCOICL = 0, int FEGFPJLJNGN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7518B40", Offset = "0x7517F40", VA = "0x187518B40")]
	public KJJFGDEALEH(CDMFKIAEDKP GOKNGDDLCCB, FBFDINCPKFI HIBNFLMDEPG, float3 EFOMBHELPPK, quaternion AKKODFJGDGC, float3 FGLGAADJJAN, int OOOPLLCOICL = 0, int FEGFPJLJNGN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x75170F0", Offset = "0x75164F0", VA = "0x1875170F0")]
	private float3 BODKAJBLHGM(float3 ENIAPEGPKEH, Matrix4x4 FAJDMAFIGEG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7518950", Offset = "0x7517D50", VA = "0x187518950")]
	private float3x3 JKBPJBLENHF(float3x3 AGGALMIGFIC, float3x3 KGADGOJAHIF)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x75170E0", Offset = "0x75164E0", VA = "0x1875170E0")]
	private float BGOBJNKECCI(float JJCKONKIIAI, float LHPBCIGKADH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x75177B0", Offset = "0x7516BB0", VA = "0x1875177B0", Slot = "4")]
	public void Execute(int MKNOLMMOIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x75189D0", Offset = "0x7517DD0", VA = "0x1875189D0")]
	private void KAMKPFIJCKG(int DFLKPGBONDC, float3 NDADPNJPMFO, float3 FGKLFPNFOKI, float3 OBJCIKCFCIL, float PMGAIALCDAG, bool NIGBFPMNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7516CA0", Offset = "0x75160A0", VA = "0x187516CA0")]
	private void ANDOBFMAEDJ(MNHBMAKPPKN NABPHNEDBPD, float3 MIGPGADKMKK, float3x3 PPMLNGGNBKE, float JJCKONKIIAI, int LPCGKGGDNDB, int ECKCJKLHFLK, int OLKJNFLGPBA, float IBMIGPFMPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7517230", Offset = "0x7516630", VA = "0x187517230")]
	private void EKAKLLAMCEP(int DFLKPGBONDC, int FDLHNKBAJJA, MNHBMAKPPKN NABPHNEDBPD, float3 MIGPGADKMKK, float3x3 PPMLNGGNBKE, bool DKLMAKDLLGM, float JJCKONKIIAI, int DDDMBLNFLPB, int FBBPJKLFPJF, int OLKJNFLGPBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct GFIHIHGEMHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public NativeList<NKJHBIHLOIK> AKGNINIGDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public NativeList<JGLCOCGAPMH> KAEMFBPFFGF;

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x75143F0", Offset = "0x75137F0", VA = "0x1875143F0")]
	public GFIHIHGEMHO(int IBMHAIHIDJJ, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7514350", Offset = "0x7513750", VA = "0x187514350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[BurstCompile]
public struct ADLMKGCJOPL : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private enum FBLFICLNAFB
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[ReadOnly]
	private NativeList<float3> NMKIMLKCIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[ReadOnly]
	private NativeArray<float3> AJABMJFFOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ReadOnly]
	private NativeList<int> BIDPDAFGBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[ReadOnly]
	private NativeArray<int> FHFMOJCGBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[ReadOnly]
	private NativeArray<float4> CNGPIJEHAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float4> KJFJHJCCCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeArray<float4> OBAHAKOCPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> AGBAPGCHDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeList<float3> GDGNCAGIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeList<JGLCOCGAPMH> CICAFGKMHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeList<NKJHBIHLOIK> AKGNINIGDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeList<JGLCOCGAPMH> KAEMFBPFFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private int PAEGKKCIPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private int BAOCAHKCLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FHOMHJONJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CKFFABGBDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MKJJCOEMPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BJBCLDDKDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NFNHHKJACDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MEIKIMANGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NEBMBDKJDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[ReadOnly]
	private float3 FGELKJJAOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[ReadOnly]
	private quaternion BGMPPCDNKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[ReadOnly]
	private float3 LKDHGOLEDPL;

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7504DC0", Offset = "0x75041C0", VA = "0x187504DC0")]
	public ADLMKGCJOPL(AIIDIKHPDOL GOKNGDDLCCB, FBFDINCPKFI HIBNFLMDEPG, NativeArray<int> FLKLFNCDDKD, float3 EFOMBHELPPK, quaternion AKKODFJGDGC, float FGLGAADJJAN, int OOOPLLCOICL = 0, int FEGFPJLJNGN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7504BB0", Offset = "0x7503FB0", VA = "0x187504BB0")]
	public ADLMKGCJOPL(GFIHIHGEMHO GIDGOODJFLJ, FBFDINCPKFI HIBNFLMDEPG, NativeArray<int> FLKLFNCDDKD, float3 EFOMBHELPPK, quaternion AKKODFJGDGC, float3 FGLGAADJJAN, int OOOPLLCOICL = 0, int FEGFPJLJNGN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7503B90", Offset = "0x7502F90", VA = "0x187503B90", Slot = "4")]
	public void Execute(int MKNOLMMOIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x75037E0", Offset = "0x7502BE0", VA = "0x1875037E0")]
	private void EOMNDLMCFPK(float4x4 PMGPLDJAOKP, int MKNOLMMOIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7504B40", Offset = "0x7503F40", VA = "0x187504B40")]
	private FBLFICLNAFB KFFIPFBCOCF(float3 FGKLFPNFOKI)
	{
		return default(FBLFICLNAFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7503750", Offset = "0x7502B50", VA = "0x187503750")]
	private float4 BBBBOEAKLBK(FBLFICLNAFB KKAMPHCBAHE, int EAHKFAJBNDN)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x75037A0", Offset = "0x7502BA0", VA = "0x1875037A0")]
	private float2 EDLJNPDFPEH(FBLFICLNAFB KKAMPHCBAHE, float3 NDADPNJPMFO)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct MKCHKHONKEK
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum MEGPDPPEEHC
	{
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public static MKCHKHONKEK DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public float3 NAMOIOBECGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public float3x3 KGCMOGJCFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public float3 NGPEAGCEMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public MEGPDPPEEHC LNMDBHDAJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 DJBJJCAOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3 DFPKGCKKKOE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7519AE0", Offset = "0x7518EE0", VA = "0x187519AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 IOLANELHHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7519F80", Offset = "0x7519380", VA = "0x187519F80")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x751A370", Offset = "0x7519770", VA = "0x18751A370")]
	public MKCHKHONKEK(float3 NDADPNJPMFO, quaternion MLMNPOCKAAE, float3 IBMHAIHIDJJ, MEGPDPPEEHC BMIPLDLMPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7519D80", Offset = "0x7519180", VA = "0x187519D80")]
	public float IMINGGJNKMF(float3 MIGPGADKMKK, float LHGHNCDCDIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x75199F0", Offset = "0x7518DF0", VA = "0x1875199F0")]
	public bool AAFOKLLMHFB(float3 FGKLFPNFOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x751A150", Offset = "0x7519550", VA = "0x18751A150")]
	public void PBLAGGLCFAN(float3 NBJMCPHECLN, float3x3 NGHDDEGIBJA, float GNMNIFCFCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x751A060", Offset = "0x7519460", VA = "0x18751A060")]
	private void MMGMMBAGCLK(float3 ILGJMEDBDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7519AF0", Offset = "0x7518EF0", VA = "0x187519AF0")]
	public void ANOLMEBOPBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[BurstCompile]
public struct BKDKKABPIDC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[ReadOnly]
	private NativeList<MKCHKHONKEK> GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[ReadOnly]
	private NativeList<float3> KCNAIMLCPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[ReadOnly]
	private NativeList<int> HKAJIOBOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HFBNGDEGLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<JGLCOCGAPMH> KAEMFBPFFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private int AFJJDFIGIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private int ACMLMCHLMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[ReadOnly]
	private float LHGHNCDCDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private float LBJFNAMAHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> LJCICLBMAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GKFCJAJDEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> GCIOBCHMLID;

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x75097F0", Offset = "0x7508BF0", VA = "0x1875097F0")]
	public BKDKKABPIDC(FBFDINCPKFI LCGHOEMEOEK, float FLMPFEGLJFA, int EKDINNHMJFC, int LPCGKGGDNDB, NativeList<MKCHKHONKEK> GIDGOODJFLJ, NativeArray<int> HFBNGDEGLFF, NativeList<JGLCOCGAPMH> KAEMFBPFFGF, NFBJNLMOOIN GBAGKPNELCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7508D60", Offset = "0x7508160", VA = "0x187508D60", Slot = "4")]
	public void Execute(int LEBJIPHDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7509730", Offset = "0x7508B30", VA = "0x187509730")]
	private bool JNFEPNECGAP(MKCHKHONKEK AMGCKABOOPF, MKCHKHONKEK PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x75094A0", Offset = "0x75088A0", VA = "0x1875094A0")]
	private bool FENDBFGBIMK(MKCHKHONKEK CAADECGPKHD, int LAPJPBODJNE, int IAEDFOPLMLA, int KPAHBOKLIBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct DONIKNBBFME : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private NativeList<DDFIFOHEEBL.FJHJGNPHLIN> PHHJHIHELAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[ReadOnly]
	private NativeArray<int> GFHKNCKHIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[ReadOnly]
	private int OOOPLLCOICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[ReadOnly]
	private int FEGFPJLJNGN;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x750F600", Offset = "0x750EA00", VA = "0x18750F600")]
	public DONIKNBBFME(NativeList<DDFIFOHEEBL.FJHJGNPHLIN> PHHJHIHELAN, NativeArray<int> GFHKNCKHIEB, int FEGFPJLJNGN = 0, int OOOPLLCOICL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x750F550", Offset = "0x750E950", VA = "0x18750F550", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class NFBJNLMOOIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeArray<bool> JJMFODPAOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeArray<int> OMHCADCACIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeArray<bool> LMEIFNDDPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeArray<float> OJFJGLIBDIN;

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x751AF30", Offset = "0x751A330", VA = "0x18751AF30")]
	public void NLKPFDGIMDD(int NCNLMCPMFCK, int LMFBKOOOEDD, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x751AF10", Offset = "0x751A310", VA = "0x18751AF10")]
	public static long JHNLDCJIICJ(int NCNLMCPMFCK, int LMFBKOOOEDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x751AD30", Offset = "0x751A130", VA = "0x18751AD30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x751AE20", Offset = "0x751A220", VA = "0x18751AE20")]
	public void GDCMIOJAIMJ(JobHandle NIJHHKONNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public NFBJNLMOOIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[BurstCompile]
public struct OENHNMIPODK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeList<float3> KCNAIMLCPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float3> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<float4> EDEDDIPBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private NativeArray<float2> NBOPCHOKEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<int> HKAJIOBOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<int> MPKPJGDGGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[ReadOnly]
	private NativeArray<bool> LJCICLBMAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[ReadOnly]
	private NativeArray<bool> GKFCJAJDEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[ReadOnly]
	private int OOOPLLCOICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	[ReadOnly]
	private int FEGFPJLJNGN;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x751B490", Offset = "0x751A890", VA = "0x18751B490")]
	public OENHNMIPODK(FBFDINCPKFI LCGHOEMEOEK, NFBJNLMOOIN GBAGKPNELCL, int FEGFPJLJNGN = 0, int OOOPLLCOICL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x751B050", Offset = "0x751A450", VA = "0x18751B050", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x751B430", Offset = "0x751A830", VA = "0x18751B430")]
	private void MPAAPCNFIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class NOCKPKAPLPJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3540380", Offset = "0x353F780", VA = "0x183540380")]
	public static bool CANFNLHFDFB<T>(NativeArray<T> CJFOOLJEHLK, int IBMHAIHIDJJ, Allocator LEILKJFLDFN, NativeArrayOptions DCEHMKPFEJH = NativeArrayOptions.ClearMemory, int GCEDJLIKKME = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3540590", Offset = "0x353F990", VA = "0x183540590")]
	public static bool CANFNLHFDFB<T>(NativeList<T> BHMKCPLLJPF, int IBMHAIHIDJJ, Allocator LEILKJFLDFN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x3540440", Offset = "0x353F840", VA = "0x183540440")]
	public static bool CANFNLHFDFB<T>(NativeQueue<T> CAPLBJNMICN, Allocator LEILKJFLDFN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public enum NNLGOHCCLAH
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Force2,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	AllOfThem
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public interface LOFFCANAFML
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OOONHBLCKPL(NNLGOHCCLAH GNAJNFCKONF);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IMAMFLJKHIL(NNLGOHCCLAH GNAJNFCKONF);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DJOEGFIEAIG IICEDMGKFFF();

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float LLOMFPLMHGG();

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OOEKFELFHKF(NNLGOHCCLAH GNAJNFCKONF, AIIDIKHPDOL EALLMICPGEN, int NILELNIMHMO = -1);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int AJDBIFDLPLB(int EDNGGDPGAJN);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class LBAILEJMPNK
{
	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7519000", Offset = "0x7518400", VA = "0x187519000")]
	public static void ONKGPPOKPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class BFKPFEOEFPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeList<float3> BLEBKCPGMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<float3> LLOIIOBGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<int> PGGEHKMFFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<float4> ODNBFFONJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<float4> EECKBCIOPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float4> EPJEFOGLBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> NELOFKINPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeList<float3> OENOMLBMDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeList<int> EPLKJIAFONN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DHJENKIBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7507F90", Offset = "0x7507390", VA = "0x187507F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DILBJJMOMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7508130", Offset = "0x7507530", VA = "0x187508130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EKMGBKHANGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x75080F0", Offset = "0x75074F0", VA = "0x1875080F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x75086E0", Offset = "0x7507AE0", VA = "0x1875086E0")]
	public BFKPFEOEFPC(int NCNLMCPMFCK, int LMFBKOOOEDD, int PCMAEAGCCEL, Allocator LEILKJFLDFN = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7508A00", Offset = "0x7507E00", VA = "0x187508A00")]
	public BFKPFEOEFPC(Mesh LCGHOEMEOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7507FD0", Offset = "0x75073D0", VA = "0x187507FD0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x75077D0", Offset = "0x7506BD0", VA = "0x1875077D0")]
	public void CGDLHICEKJD(BFKPFEOEFPC LCGHOEMEOEK, bool OMLHILEIAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7507B00", Offset = "0x7506F00", VA = "0x187507B00")]
	private void CPBKAOPMAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7508170", Offset = "0x7507570", VA = "0x187508170")]
	private void PIJEKGKEHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct JGLCOCGAPMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public int MCMKHEONKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public int DHJENKIBIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public int NPDGPNHKJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public int DILBJJMOMGG;

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8140", Offset = "0x1CE7540", VA = "0x181CE8140")]
	public JGLCOCGAPMH(int LPCGKGGDNDB, int EJENEKIJBLE, int EKDINNHMJFC, int BHEMEOKJHOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class LHIMPKGNCEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<JGLCOCGAPMH> BCHCLHHCCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xACB980", Offset = "0xACAD80", VA = "0x180ACB980")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<JGLCOCGAPMH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xACB990", Offset = "0xACAD90", VA = "0x180ACB990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BFKPFEOEFPC HBCKFNLBLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x75191C0", Offset = "0x75185C0", VA = "0x1875191C0")]
	public LHIMPKGNCEC(IEnumerable<BFKPFEOEFPC> MEDHCPCLFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7519150", Offset = "0x7518550", VA = "0x187519150", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum EKABDFAIFNM
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class CMBONKEBBJK
{
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static NativeArray<float2> HOPMKJNBNGG;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static NativeArray<float3> DCNLOJNDEHL;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static NativeArray<float4> AFDLPGEIKOL;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static NativeArray<int> POKHMGNFAPM;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x750F230", Offset = "0x750E630", VA = "0x18750F230")]
	public static void ONKGPPOKPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x750EF00", Offset = "0x750E300", VA = "0x18750EF00")]
	public static NativeArray<float2> FDNBLIABJGB(NativeArray<float2> IABLMKIGCIA, int KGBOCPILLKI, NativeArray<float2> AMFIBIIADAC, int PCONOLBOMJM)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x750EDF0", Offset = "0x750E1F0", VA = "0x18750EDF0")]
	public static NativeArray<float3> FAMPLDLMIIB(NativeArray<float3> IABLMKIGCIA, int KGBOCPILLKI, NativeArray<float3> AMFIBIIADAC, int PCONOLBOMJM)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x750F120", Offset = "0x750E520", VA = "0x18750F120")]
	public static NativeArray<float4> NPMFIJCILBL(NativeArray<float4> IABLMKIGCIA, int KGBOCPILLKI, NativeArray<float4> AMFIBIIADAC, int PCONOLBOMJM)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x750F010", Offset = "0x750E410", VA = "0x18750F010")]
	public static NativeArray<int> KKGPBDFEECO(NativeArray<int> IABLMKIGCIA, int KGBOCPILLKI, NativeArray<int> AMFIBIIADAC, int PCONOLBOMJM)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x31C5970", Offset = "0x31C4D70", VA = "0x1831C5970")]
	private static void NPCOPNAEFIL<T>(NativeArray<T> CJFOOLJEHLK, int PGMGHNILLNL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x31C5B70", Offset = "0x31C4F70", VA = "0x1831C5B70")]
	private static void OEKNKBHLAIB<T>(NativeArray<T> IABLMKIGCIA, int KGBOCPILLKI, NativeArray<T> AMFIBIIADAC, int PCONOLBOMJM, NativeArray<T> ONPLKPALBKN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[BurstCompile]
public class ADMJKCABPGH
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct BAENJJCOPLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public ushort IKAEODCKAIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public ushort ACCJFOPIMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public ushort FOPBNJBIBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public ushort ECFCIIJCPFA;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x751CE20", Offset = "0x751C220", VA = "0x18751CE20")]
	public static uint PAKFOEKFPAE(float FCMENGJCBPJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x751C790", Offset = "0x751BB90", VA = "0x18751C790")]
	public static void OBGBOMJNPML(float4 EDEDDIPBAKP, float OJCMDFJAANA, [Out] uint HHIBMGMGHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x751C8A0", Offset = "0x751BCA0", VA = "0x18751C8A0")]
	public static void OBGBOMJNPML(float4 EDEDDIPBAKP, uint PKHCDEFMDNC, [Out] uint HHIBMGMGHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x751CBD0", Offset = "0x751BFD0", VA = "0x18751CBD0")]
	public static void OOGAEAOALOC(float3 LMMNENJFGLO, float3 CFAOOHDAFGO, float4 HPHOBOOCAEJ, float2 ALODLBEKEAO, float4 EDEDDIPBAKP, [Out] FBFDINCPKFI.GOCIBCNPJJK BEKKIODJCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x751C970", Offset = "0x751BD70", VA = "0x18751C970")]
	public static void OOGAEAOALOC(float3 LMMNENJFGLO, float3 CFAOOHDAFGO, float4 HPHOBOOCAEJ, float2 ALODLBEKEAO, float4 EDEDDIPBAKP, [Out] FBFDINCPKFI.OKMICELLMPH BEKKIODJCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x751C440", Offset = "0x751B840", VA = "0x18751C440")]
	public static byte FOHNFDNLGJK(float KBGCCIOIGBD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x751C490", Offset = "0x751B890", VA = "0x18751C490")]
	public static ushort HAKGGOOGMMK(float KBGCCIOIGBD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x751C410", Offset = "0x751B810", VA = "0x18751C410")]
	public static uint EGFHIBLNPOA(float KBGCCIOIGBD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x751CE30", Offset = "0x751C230", VA = "0x18751CE30")]
	public static float2 PCEDLOKAPIE(float2 EFDAGALIIFI)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x751C2C0", Offset = "0x751B6C0", VA = "0x18751C2C0")]
	public static float2 CJJHEABHCKO(float3 EOJJAMCHAEH)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x751C4E0", Offset = "0x751B8E0", VA = "0x18751C4E0")]
	public static void MIFNPHCBNCF(float3 KBGCCIOIGBD, [Out] float3 GDOKIFLICIF, [Out] uint3 ECFCIIJCPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x751C630", Offset = "0x751BA30", VA = "0x18751C630")]
	public static BAENJJCOPLK NFAPDIGBENB(float3 NDADPNJPMFO)
	{
		return default(BAENJJCOPLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class HMHPEBHABPE
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly ProfilerMarker OOOJJCEMHED;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static float ELKCOGDNJEK;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void HPNHJBKKPAI(bool CEBKCIEMAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x752F6D0", Offset = "0x752EAD0", VA = "0x18752F6D0")]
	public static float LJFIDLILEDB(float MOKFPBHGJJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x752F5E0", Offset = "0x752E9E0", VA = "0x18752F5E0")]
	public static long FOMGKEIHDHA(float MOKFPBHGJJD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x752F8C0", Offset = "0x752ECC0", VA = "0x18752F8C0")]
	public static void LMMEJOBNNCA(float MOKFPBHGJJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface DAIMDEJFAEN
{
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMMEJOBNNCA(float GKCPEEJDGAC);

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) HMLJIABAFDB(float KJCBAPBLLEE);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class GKOLHJBNCMD
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public enum ALOBPLDBIMN
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		ShapesStartTreeGeneration,
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		ShapesTreeRefresh,
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		ShapesTreeError,
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		ShapesLod012Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private struct NBDLACPNCDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public ALOBPLDBIMN BMIPLDLMPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public float DKBNIPNLNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public BatchedMeshRenderer BPCBEOKEMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public DDFIFOHEEBL OMHFDNIFDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public long DPCFOBFEPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public long JOGBLOJKJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public float DCLOJJDEHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public bool KECMIIGPJJK;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private static readonly ProfilerMarker CPJBBINLCOF;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker GNDJNILOCIB;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static int EPLNHEFKLNL;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static int PJEIFEOADGB;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int PCMMDFIMONC;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static long JLOOHBCMEIB;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static long ANMHODOFKMN;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long DMBNHJHMLMB;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long GJIDBAGBLAN;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static int ONFNDCCEJAI;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static float BIMFEGNGMKG;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static bool LIHEJBDNDOL;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int BIILLOJLLLN;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int PEBDCDAECKJ;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static long DBAHPEEGMKM;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int OPNPIGEAKNP;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static bool ADFOCOJNHAJ;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static List<NBDLACPNCDP> DNDLBNNJOGA;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static DAIMDEJFAEN JFCPPCDGLGG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool DBLGDIBNONN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x752B0C0", Offset = "0x752A4C0", VA = "0x18752B0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void INCFJHLNCOM(bool CEBKCIEMAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void HPNHJBKKPAI(bool CEBKCIEMAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void INCFJHLNCOM(bool CEBKCIEMAIG, string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x752C820", Offset = "0x752BC20", VA = "0x18752C820")]
	public static void KEEJGNILPCB(DAIMDEJFAEN ALPMEAHKILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x752B6B0", Offset = "0x752AAB0", VA = "0x18752B6B0")]
	public static (long, long, long, int, int) FOGONAKOKFH(long OGKGOFEIELG)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x752F130", Offset = "0x752E530", VA = "0x18752F130")]
	public static void OHGCGNNLLCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x752C890", Offset = "0x752BC90", VA = "0x18752C890")]
	public static void LMMEJOBNNCA(long OGKGOFEIELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x752AEC0", Offset = "0x752A2C0", VA = "0x18752AEC0")]
	public static void ABEDFKJAOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x752C260", Offset = "0x752B660", VA = "0x18752C260")]
	public static long HMNCLPECODL(long GJOIBCLAMFC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x752F260", Offset = "0x752E660", VA = "0x18752F260")]
	public static bool PEJJBFICEAM(long INMFMDGCNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x752BD00", Offset = "0x752B100", VA = "0x18752BD00")]
	public static bool HBIPBMIBOEO(long INMFMDGCNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x752B980", Offset = "0x752AD80", VA = "0x18752B980")]
	public static float GEEJHCNLIIP(long OKKAOIBEDID, int CAPKHGEJBAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x752BDD0", Offset = "0x752B1D0", VA = "0x18752BDD0")]
	public static (long, long, int) HMLJIABAFDB(float MOKFPBHGJJD)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x752B540", Offset = "0x752A940", VA = "0x18752B540")]
	public static void EPBMJNFIBKC(DDFIFOHEEBL OMHFDNIFDBK, BatchedMeshRenderer BPCBEOKEMNO, long FHKJBIIIBFK, long JOGBLOJKJBO, float DKBNIPNLNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x752C6B0", Offset = "0x752BAB0", VA = "0x18752C6B0")]
	public static void JCDONMNCDHF(DDFIFOHEEBL OMHFDNIFDBK, BatchedMeshRenderer BPCBEOKEMNO, long FHKJBIIIBFK, long JOGBLOJKJBO, float FFJIDKHEAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x752C530", Offset = "0x752B930", VA = "0x18752C530")]
	public static void IKILIMMBNGO(DDFIFOHEEBL OMHFDNIFDBK, BatchedMeshRenderer BPCBEOKEMNO, long JOGBLOJKJBO, float FFJIDKHEAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x752C3C0", Offset = "0x752B7C0", VA = "0x18752C3C0")]
	public static void HNBAEDJADIO(DDFIFOHEEBL OMHFDNIFDBK, BatchedMeshRenderer BPCBEOKEMNO, long FHKJBIIIBFK, long JOGBLOJKJBO, float FFJIDKHEAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x752B150", Offset = "0x752A550", VA = "0x18752B150")]
	public static void DAKBNBGKGOO(ALOBPLDBIMN BMIPLDLMPCD, DDFIFOHEEBL OMHFDNIFDBK, BatchedMeshRenderer BPCBEOKEMNO, long FHKJBIIIBFK, long JOGBLOJKJBO, float AADFDDPNONF, bool KECMIIGPJJK, float DKBNIPNLNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x752F070", Offset = "0x752E470", VA = "0x18752F070")]
	public static bool NDOKHNHILFG(float LKGOMFBEDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x752F1E0", Offset = "0x752E5E0", VA = "0x18752F1E0")]
	public static void OONNHIOPLNG(float LKGOMFBEDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x752B430", Offset = "0x752A830", VA = "0x18752B430")]
	public static bool ELHKMBDOILJ(float LKGOMFBEDGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class DDFIFOHEEBL
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	internal enum HOIBABGHGKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public struct FJHJGNPHLIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public int AFANAFIDJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public int DGMCFDFIOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public float OIKCKMHNIIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public struct NEOJJIGKOJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public ENJBAIDLEIF LCGHOEMEOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int CDLOMPJNODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int GDAHJFODICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public long IJMFNKDIMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public long MCLBFKJKDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public float JGGGOIDNDEA;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7530F50", Offset = "0x7530350", VA = "0x187530F50")]
		public void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7530F80", Offset = "0x7530380", VA = "0x187530F80")]
		public void GDCMIOJAIMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static readonly string GCGBFEECBKG;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly string BMHLPNCFHIA;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static readonly ProfilerMarker EELNIDAPBDP;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly ProfilerMarker MFJGNFLIGDH;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private static readonly ProfilerMarker OOOJJCEMHED;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly ProfilerMarker BGLBPNECNFD;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly ProfilerMarker IHEPKPKGHIA;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly ProfilerMarker KHHGBKDMJBC;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static readonly ProfilerMarker CPJBBINLCOF;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static readonly ProfilerMarker NKDJCBHFFEJ;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private static readonly ProfilerMarker GAHBBJOGCLC;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly ProfilerMarker FKHOIIDJNBB;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly ProfilerMarker KIDIMICFGGJ;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly ProfilerMarker JMHGLHMIONB;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly ProfilerMarker DJGGDPCLECH;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly ProfilerMarker IAKOMIFAGFE;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ProfilerMarker DJGAAOPBJLE;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly ProfilerMarker AFIAHADPPAF;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly ProfilerMarker LFFLHNMIHMJ;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly ProfilerMarker IPBHMMONEIM;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly ProfilerMarker AFCONLEMGNG;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker EJGIPFFKLEM;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker GDJOOAHIDOP;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker NEHHGOFGIBG;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker LGHFPNCDAII;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker KKLDBMKMDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly List<LOFFCANAFML> ONOIJFJJLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly ANEFDAMIPJL PHKMPCNAEDC;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public const bool NLDEAKODFMH = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private int EJENEKIJBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private int BHEMEOKJHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private bool KJCEICAODCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal bool DCHIKKEFHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public bool CGOFNDLMCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	internal HOIBABGHGKF CEGAGHAOIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	internal bool GJHFJOABPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal float3 PINCMGHIBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal float3 DDDNIKDOFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	internal float MIKEEHMNDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	internal int HCMPLNKLADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	internal int EJIGDDMLBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal int OMBLDIHMPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private int ILAFMKAEEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private int OCPBOODMNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private float FKFCKMKEKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	internal float ODOLMLAFJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private int EDBHCLDKGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private int PMDCJCIJPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private long CFBONKBNCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private long BJKHAIFBBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private long JIMMPJOKKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public int JLJGDDKDNPM;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private const int FJBCEODJDFH = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private float[] PDMMJLEECKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private int[] EIOMCJNDFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private long[] CHKDCDBIKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public List<NEOJJIGKOJP> HDMMHCLHALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private FBFDINCPKFI FHLAOEDKJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private long BBLJNJLFCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private long HAOEILOPHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private int MDBEADAOGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	internal float IBGINDILKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	internal FBFDINCPKFI.KMIBOCLMOJF MGEMKLDFLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private bool BAJCOJNPMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private KDEOKCDFBEK MDFHPGMAEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private JobHandle LLFIHALMOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private NativeList<FJHJGNPHLIN> PPMIDLBLGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	internal NativeArray<long> JANDAJMDNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private bool DDBPPMBDCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private JobHandle LFKHAGKFMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private FBFDINCPKFI GDPEBLPNLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private NFBJNLMOOIN MJPOKPJLEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private NativeList<FJHJGNPHLIN> PDMPJBIAJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private Transform JCBOAMBMNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private NNLGOHCCLAH JJEBDPKENNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private float3 AFHPCEMDMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private float JBOLCLIFBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private float JMHKLNMBEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private float FGOJCEBHLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private float NJFIPHKAOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private float KPIPIAFMNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private float HFLHJBKBPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private float3 LMIBCAOJBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private float FCIHNJMIMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private float OJOBMBCFBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private long PLAANOCLBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private long KKFNINGNJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private long NGOKNGIJCEA;

	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private static int HMLMEHKOAFO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal Mesh HBCKFNLBLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshFilter INAJJKBEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MeshRenderer DKKKINOMNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x94FAD0", Offset = "0x94EED0", VA = "0x18094FAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public List<Material> GMNHOHPKNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x94B7F0", Offset = "0x94ABF0", VA = "0x18094B7F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int MFCGJPFHNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xCD8B40", Offset = "0xCD7F40", VA = "0x180CD8B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int EMPMDFNOJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xAE0340", Offset = "0xADF740", VA = "0x180AE0340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int DHJENKIBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7521070", Offset = "0x7520470", VA = "0x187521070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<LOFFCANAFML> DJAGLGPBIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void NJLEBBDPDPI(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x751FAE0", Offset = "0x751EEE0", VA = "0x18751FAE0")]
	public void ANJGNOBPJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7522B30", Offset = "0x7521F30", VA = "0x187522B30")]
	private void FMHMLHKLMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x752ABA0", Offset = "0x7529FA0", VA = "0x18752ABA0")]
	public DDFIFOHEEBL(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7522F50", Offset = "0x7522350", VA = "0x187522F50")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7527050", Offset = "0x7526450", VA = "0x187527050")]
	private void MGJCPPPJGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x752A280", Offset = "0x7529680", VA = "0x18752A280")]
	private void PLFNCLCEFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x75230B0", Offset = "0x75224B0", VA = "0x1875230B0")]
	public Mesh GLAMOAPNBMK(MeshFilter KOGBGLOGAFE, Transform EJNLPEDOMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x751FAF0", Offset = "0x751EEF0", VA = "0x18751FAF0")]
	private void ANKLDCGPNEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7520A80", Offset = "0x751FE80", VA = "0x187520A80")]
	public void BMFCBKCPPJP(LOFFCANAFML JGNHDNDKMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7526FD0", Offset = "0x75263D0", VA = "0x187526FD0")]
	public bool MCAPJPHCCGL(LOFFCANAFML JGNHDNDKMED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7523210", Offset = "0x7522610", VA = "0x187523210")]
	public bool HBIAGPPOPJF(LOFFCANAFML JGNHDNDKMED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7523120", Offset = "0x7522520", VA = "0x187523120", Slot = "4")]
	public virtual void GMCFBBCEPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7521F50", Offset = "0x7521350", VA = "0x187521F50")]
	public void DOAALOHHNEB(Transform JCKCCIGACED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x751FA30", Offset = "0x751EE30", VA = "0x18751FA30")]
	private long ANAOFJBLNDD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7525860", Offset = "0x7524C60", VA = "0x187525860")]
	private long LKJOJMAICKA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7528160", Offset = "0x7527560", VA = "0x187528160")]
	public bool OAPPIEOENIN(Transform JCKCCIGACED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7524CB0", Offset = "0x75240B0", VA = "0x187524CB0")]
	public bool LHKDPCGHLLI(bool NCLGGPODHMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7523270", Offset = "0x7522670", VA = "0x187523270")]
	private void HCGONIAJBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x75259F0", Offset = "0x7524DF0", VA = "0x1875259F0")]
	public bool LMMEJOBNNCA(float4x4 EJDKLMAIDCF, BatchedMeshRenderer HHNIJPLMAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7522D40", Offset = "0x7522140", VA = "0x187522D40")]
	public bool FOAFLPJGBEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7528DF0", Offset = "0x75281F0", VA = "0x187528DF0")]
	public void ODCJLDMBFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x75270F0", Offset = "0x75264F0", VA = "0x1875270F0")]
	public bool MPKHGPAJIGN(bool NCLGGPODHMG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x75221A0", Offset = "0x75215A0", VA = "0x1875221A0")]
	public void EKJPCCDBOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7527330", Offset = "0x7526730", VA = "0x187527330")]
	public void NHFEPEIIPLH(FBFDINCPKFI LCGHOEMEOEK, int BIFIPJDLIOL, int EANFEKNONMI, float HLPBGIIFOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7520DC0", Offset = "0x75201C0", VA = "0x187520DC0")]
	public void BOBOEHDHEBB(ENJBAIDLEIF IKCIJFHGNDE, int BIFIPJDLIOL, int EANFEKNONMI, float HLPBGIIFOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7524C40", Offset = "0x7524040", VA = "0x187524C40")]
	public (long, long, long) JFHACJJLLHE()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0xB83C50", Offset = "0xB83050", VA = "0x180B83C50")]
	public long LKEGIILIHGN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x75247A0", Offset = "0x7523BA0", VA = "0x1875247A0")]
	private void IKIHGOIEMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7523810", Offset = "0x7522C10", VA = "0x187523810")]
	public (long, long, int) HMLJIABAFDB(float MOKFPBHGJJD, float4x4 EJDKLMAIDCF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0xCEFDC0", Offset = "0xCEF1C0", VA = "0x180CEFDC0")]
	internal void OMKOKAKLMBF(HOIBABGHGKF DNIICHOJIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7521090", Offset = "0x7520490", VA = "0x187521090")]
	internal (float, float, float, float) DGHEJLOAGNB(float NGJEBNCLAFD, float4x4 EJDKLMAIDCF)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x75231B0", Offset = "0x75225B0", VA = "0x1875231B0")]
	private float GOMMFKJHDFE(float NGJEBNCLAFD, float4x4 EJDKLMAIDCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x751FD80", Offset = "0x751F180", VA = "0x18751FD80")]
	private (int, int) BIGACKCKLKG(float FIIBNNEKDDC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x75220F0", Offset = "0x75214F0", VA = "0x1875220F0")]
	public static float EBPIOAIONBJ(LOFFCANAFML LCGHOEMEOEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7527360", Offset = "0x7526760", VA = "0x187527360")]
	public void NMKJJLCCFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7520710", Offset = "0x751FB10", VA = "0x187520710")]
	private (int, long) BKABLJBMECG(FBFDINCPKFI PGLOKGEKLDI, FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA, bool EAFFMHKKAHN)
	{
		return default((int, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7520310", Offset = "0x751F710", VA = "0x187520310")]
	private (int, long) BKABLJBMECG([In] ENJBAIDLEIF PGLOKGEKLDI, FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA, bool EAFFMHKKAHN)
	{
		return default((int, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7524BA0", Offset = "0x7523FA0", VA = "0x187524BA0")]
	private void JCIHNBJMMKK(FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7528130", Offset = "0x7527530", VA = "0x187528130")]
	private void NNIOCIPBNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7521C30", Offset = "0x7521030", VA = "0x187521C30")]
	private void DLNLJINEBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7523CA0", Offset = "0x75230A0", VA = "0x187523CA0")]
	public long HMNCLPECODL(long GJOIBCLAMFC, int FEJPMIGCGIC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7528E60", Offset = "0x7528260", VA = "0x187528E60")]
	private void OPGGJAMEHKE(FBFDINCPKFI NJDBCEKLGCO, NativeList<FJHJGNPHLIN> HDKNOMAGMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x75243C0", Offset = "0x75237C0", VA = "0x1875243C0")]
	private void IIKEAMLOGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7529BF0", Offset = "0x7528FF0", VA = "0x187529BF0")]
	public static void PAEPLILMIMK(NativeList<FJHJGNPHLIN> NKCGDGAHKJP, FBFDINCPKFI NJDBCEKLGCO, int MOLCMGACLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7520D30", Offset = "0x7520130", VA = "0x187520D30")]
	private float BNDHFCMCHCH(int CIKKMIENJPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x75221B0", Offset = "0x75215B0", VA = "0x1875221B0")]
	private void FMFFGLJJJBK(FBFDINCPKFI LCGHOEMEOEK, EMDNKHMMFCL IKCIJFHGNDE, int BIFIPJDLIOL, int EANFEKNONMI, float HLPBGIIFOGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[BurstCompile]
public struct CGMNFOAGCCJ
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	internal struct ENOCLBCGOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int HFPOKDPAJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int NOMJIFJGFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int OGDPHEGNDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public float IJPJFNNNOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public float ACFGKJGNMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public float EEKJEBCENEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public float JIKAFAHMDCG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal struct ALBKGEHENAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int HFPOKDPAJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int NOMJIFJGFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public int OGDPHEGNDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int LGFEAGPNGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public float IJPJFNNNOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public float ACFGKJGNMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public float HGPLBIAOAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public float GJBHANANKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public float JIKAFAHMDCG;
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public struct MGPOIKCIBJM
	{
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private static readonly ProfilerMarker FLEBKECJPKF;

		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private static NativeList<NOHPBCDNDPO> HAAAAGEOMCI;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private static NativeList<int> NIKNDNIKPGE;

		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private static NativeList<ENOCLBCGOPH> DLNIDDNGNLG;

		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private static NativeList<ENOCLBCGOPH> IDKICHLGIEE;

		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private static NativeList<ALBKGEHENAE> NGAGDGFDOJD;

		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private static NativeList<ALBKGEHENAE> KLJBBLGLKDK;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x752FEE0", Offset = "0x752F2E0", VA = "0x18752FEE0")]
		public static (FBFDINCPKFI, float) BMFJLMKKKCB(FBFDINCPKFI DJFBEHKKDAJ, float3 NGDPBNJBIHN, float FJOJPKIGGOE, float AIBBHDPMJPL, float NHAOBNKBAED, List<DDFIFOHEEBL.FJHJGNPHLIN> JHLOPOOPPJN, Allocator ENFGEOPJNIP)
		{
			return default((FBFDINCPKFI, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7530A80", Offset = "0x752FE80", VA = "0x187530A80")]
		public static void HCKEPGGEHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7530C00", Offset = "0x7530000", VA = "0x187530C00")]
		[JBPLEELDMPC(GALPNODIPPP.ExitingPlayMode, 0)]
		public static void ONKGPPOKPJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public unsafe delegate void CCFLLLEHJOD(CGMNFOAGCCJ NDBGDEAOMOK, int CKKMIBPHGAF, int MDCEIBBPIJI, int CKGFAHKLJLG, [NoAlias] float3* NLHFAHHFAHF, [NoAlias] int* OLCDGGCICDD, [Out] int FPLBECGAFEM, [Out] int PLMBCENLPEF, [Out] float BGMMHJPODPI);

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	internal static class CKFKCKPKEDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7539390", Offset = "0x7538790", VA = "0x187539390")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7539230", Offset = "0x7538630", VA = "0x187539230")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x75396E0", Offset = "0x7538AE0", VA = "0x1875396E0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x75394C0", Offset = "0x75388C0", VA = "0x1875394C0")]
		public unsafe static void CNDNDIPPKBE(CGMNFOAGCCJ NDBGDEAOMOK, int CKKMIBPHGAF, int MDCEIBBPIJI, int CKGFAHKLJLG, [NoAlias] float3* NLHFAHHFAHF, [NoAlias] int* OLCDGGCICDD, [Out] int FPLBECGAFEM, [Out] int PLMBCENLPEF, [Out] float BGMMHJPODPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public unsafe delegate void HNFPEKGJIHG(UnsafeList<int>* MFCCEHJBMAN, UnsafeList<float3>* POKACBEBNLA, [NoAlias] float3* MDBDLAEHHDK, [NoAlias] float4* MKKDNAHIDNI, [NoAlias] float2* CLJGDJOMNEF, [NoAlias] float4* JFKPMOGAEEL, UnsafeList<NOHPBCDNDPO>* HAAAAGEOMCI, UnsafeList<int>* NIKNDNIKPGE, UnsafeList<float3>* NLHFAHHFAHF, [NoAlias] float3* JBCLLDGKPNP, [NoAlias] float4* FMEPDLJCKFI, [NoAlias] float2* KAGLFFDFICJ, [NoAlias] float4* HHBCPJLKPML, int LMFBKOOOEDD, int NCNLMCPMFCK);

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	internal static class AOLJLIJGGFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x75328B0", Offset = "0x7531CB0", VA = "0x1875328B0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7532750", Offset = "0x7531B50", VA = "0x187532750")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7532D20", Offset = "0x7532120", VA = "0x187532D20")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x75329E0", Offset = "0x7531DE0", VA = "0x1875329E0")]
		public unsafe static void CNDNDIPPKBE(UnsafeList<int>* MFCCEHJBMAN, UnsafeList<float3>* POKACBEBNLA, [NoAlias] float3* MDBDLAEHHDK, [NoAlias] float4* MKKDNAHIDNI, [NoAlias] float2* CLJGDJOMNEF, [NoAlias] float4* JFKPMOGAEEL, UnsafeList<NOHPBCDNDPO>* HAAAAGEOMCI, UnsafeList<int>* NIKNDNIKPGE, UnsafeList<float3>* NLHFAHHFAHF, [NoAlias] float3* JBCLLDGKPNP, [NoAlias] float4* FMEPDLJCKFI, [NoAlias] float2* KAGLFFDFICJ, [NoAlias] float4* HHBCPJLKPML, int LMFBKOOOEDD, int NCNLMCPMFCK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public float3 AFHPCEMDMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public float HOGMDKHBGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public float HGHAKDKDAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public float MANFLPEBMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public BHONJIJNCEC.ANHBABFLDDK DKGCLAEMAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public bool FPMDHBFOJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal unsafe UnsafeList<NOHPBCDNDPO>* HAAAAGEOMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal unsafe UnsafeList<int>* NIKNDNIKPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal unsafe UnsafeList<ENOCLBCGOPH>* DLNIDDNGNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal unsafe UnsafeList<ENOCLBCGOPH>* IDKICHLGIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal unsafe UnsafeList<ALBKGEHENAE>* NGAGDGFDOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal unsafe UnsafeList<ALBKGEHENAE>* KLJBBLGLKDK;

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x751EE80", Offset = "0x751E280", VA = "0x18751EE80")]
	private static float MAFEKNLIJFB([In] CGMNFOAGCCJ NDBGDEAOMOK, [In] float3 DBGIMGNLDFE, float JIKAFAHMDCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x751EF00", Offset = "0x751E300", VA = "0x18751EF00")]
	private static int MAPMEJBIOCC(CGMNFOAGCCJ NDBGDEAOMOK, [Out] NOHPBCDNDPO OOCPEAOIFNH, [In] NOHPBCDNDPO AGIMCMHKJEA, [In] NOHPBCDNDPO KMNJHLFKCEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x751E3F0", Offset = "0x751D7F0", VA = "0x18751E3F0")]
	private static void LDCCCAINBMP(CGMNFOAGCCJ NDBGDEAOMOK, [In] ENOCLBCGOPH GBAPBOOMLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x751F080", Offset = "0x751E480", VA = "0x18751F080")]
	private static void NEJOPMGJHNO(CGMNFOAGCCJ NDBGDEAOMOK, [In] ALBKGEHENAE EBIJFNIPALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x751F9B0", Offset = "0x751EDB0", VA = "0x18751F9B0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal unsafe static void OLLNBMIANLL(CGMNFOAGCCJ NDBGDEAOMOK, int CKKMIBPHGAF, int MDCEIBBPIJI, int CKGFAHKLJLG, [NoAlias] float3* NLHFAHHFAHF, [NoAlias] int* OLCDGGCICDD, [Out] int FPLBECGAFEM, [Out] int PLMBCENLPEF, [Out] float BGMMHJPODPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x751D650", Offset = "0x751CA50", VA = "0x18751D650")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal unsafe static void ICEJAAMOPNN(UnsafeList<int>* MFCCEHJBMAN, UnsafeList<float3>* POKACBEBNLA, [NoAlias] float3* MDBDLAEHHDK, [NoAlias] float4* MKKDNAHIDNI, [NoAlias] float2* CLJGDJOMNEF, [NoAlias] float4* JFKPMOGAEEL, UnsafeList<NOHPBCDNDPO>* HAAAAGEOMCI, UnsafeList<int>* NIKNDNIKPGE, UnsafeList<float3>* NLHFAHHFAHF, [NoAlias] float3* JBCLLDGKPNP, [NoAlias] float4* FMEPDLJCKFI, [NoAlias] float2* KAGLFFDFICJ, [NoAlias] float4* HHBCPJLKPML, int LMFBKOOOEDD, int NCNLMCPMFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x751D6E0", Offset = "0x751CAE0", VA = "0x18751D6E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void JAHLJJCOGMA(CGMNFOAGCCJ NDBGDEAOMOK, int CKKMIBPHGAF, int MDCEIBBPIJI, int CKGFAHKLJLG, [NoAlias] float3* NLHFAHHFAHF, [NoAlias] int* OLCDGGCICDD, [Out] int FPLBECGAFEM, [Out] int PLMBCENLPEF, [Out] float BGMMHJPODPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x751CF40", Offset = "0x751C340", VA = "0x18751CF40")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public unsafe static void ELHMMMKEGBI(UnsafeList<int>* MFCCEHJBMAN, UnsafeList<float3>* POKACBEBNLA, [NoAlias] float3* MDBDLAEHHDK, [NoAlias] float4* MKKDNAHIDNI, [NoAlias] float2* CLJGDJOMNEF, [NoAlias] float4* JFKPMOGAEEL, UnsafeList<NOHPBCDNDPO>* HAAAAGEOMCI, UnsafeList<int>* NIKNDNIKPGE, UnsafeList<float3>* NLHFAHHFAHF, [NoAlias] float3* JBCLLDGKPNP, [NoAlias] float4* FMEPDLJCKFI, [NoAlias] float2* KAGLFFDFICJ, [NoAlias] float4* HHBCPJLKPML, int LMFBKOOOEDD, int NCNLMCPMFCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[BurstCompile]
internal struct NOHPBCDNDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public float3 MIGPGADKMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public int ALACGFCGPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public int CJCOCDEFGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public int PHEDBPKOJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public float OHLBKEKJPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public float KAPGKOMFFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public int GNBNOAIPBEJ;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7541FB0", Offset = "0x75413B0", VA = "0x187541FB0")]
	public static void OILMBKHFGKP([Out] NOHPBCDNDPO BIEIOPPGBOB, int OKKMAAAKMBN, [In] float3 HGIGDKLFJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7542000", Offset = "0x7541400", VA = "0x187542000")]
	public static void OILMBKHFGKP([Out] NOHPBCDNDPO BIEIOPPGBOB, [In] NOHPBCDNDPO OLMIKPCCIFF, [In] NOHPBCDNDPO FEJLIJOHCGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[BurstCompile]
internal struct KDEOKCDFBEK : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private struct DMOAGJPFALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int HKLKFLACICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int IDMMMHDKPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int MKLOMNFOFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int IKPEECNOEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int FONILOLBPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int DOMEDLAEDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int CDLOMPJNODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int GDAHJFODICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public float JGGGOIDNDEA;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct CJPFJOBIFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public BHONJIJNCEC.DPOMBGNFBEC BNIBJGDOGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public float PIOLLDBBCGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public float LOMIEEOHANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public float OMPHHLOGIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public float PENGHPNFPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public float PBGGIPPMELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public float ENFHOHGMHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public float FEABIMDGIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private struct PEFMMBMNIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public NativeArray<float3> BLEBKCPGMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public NativeArray<float3> LLOIIOBGMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public NativeArray<float4> OIEPNGPMGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public NativeArray<float4> KAGJJOCEJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public NativeArray<float2> KHGMOPNBFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public NativeArray<int> EPLKJIAFONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public bool OBIFAFLIEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int DHJENKIBIAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int DILBJJMOMGG;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7542600", Offset = "0x7541A00", VA = "0x187542600")]
		public void NLKPFDGIMDD(int NCNLMCPMFCK, int LMFBKOOOEDD, Allocator LEILKJFLDFN, bool IHKOBNPEFAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x75422F0", Offset = "0x75416F0", VA = "0x1875422F0")]
		public static PEFMMBMNIMG DEKGLIPNELN(FBFDINCPKFI MOEBIEOOLFC)
		{
			return default(PEFMMBMNIMG);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7542540", Offset = "0x7541940", VA = "0x187542540")]
		public void GDCMIOJAIMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static readonly ProfilerMarker OADNGKFGBJE;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private static readonly ProfilerMarker BCJJGJNHAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private NativeArray<DMOAGJPFALA> FEMLDELEOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private PEFMMBMNIMG ALBEALMJEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private PEFMMBMNIMG NJDBCEKLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private float3 JHFFGIOCCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private float3 EHFDLHFHKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private CJPFJOBIFPG MMDMCPEDGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* CFKFNEDCBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private NativeArray<DDFIFOHEEBL.FJHJGNPHLIN> PGBBJAAFMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private NativeList<DDFIFOHEEBL.FJHJGNPHLIN> LHFMPPDAJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private NativeArray<int> NIKNDNIKPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private NativeArray<bool> GKFCJAJDEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private NativeArray<int> OINCBPGMFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private NativeArray<int> OJKFGHMBEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private NativeArray<float> DEJDHFDCMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private NativeArray<int> HJGDDNNKHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private NativeArray<float> IFMPJFCEOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private NativeArray<int> HOACDGKCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private NativeArray<int> GCIAMOBJOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private NativeArray<float> KPIAEBDLDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private NativeArray<float> CGELIKHPHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private NativeArray<int> CDIKACBOLIG;

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x753C9A0", Offset = "0x753BDA0", VA = "0x18753C9A0")]
	public KDEOKCDFBEK([In] List<DDFIFOHEEBL.NEOJJIGKOJP> JKIGJKOIHBA, NativeList<DDFIFOHEEBL.FJHJGNPHLIN> JKBOPKEHNEG, [In] FBFDINCPKFI NJIILNKNLJM, [In] NativeList<DDFIFOHEEBL.FJHJGNPHLIN> HDKNOMAGMJM, [In] NativeArray<long> JANDAJMDNHM, float3 CBCBNNMKHCJ, float3 IMGOFOPHALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x753AF70", Offset = "0x753A370", VA = "0x18753AF70")]
	public static long KFIKMEBCDEP(int NCNLMCPMFCK, int LMFBKOOOEDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x753A890", Offset = "0x7539C90", VA = "0x18753A890", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7539C70", Offset = "0x7539070", VA = "0x187539C70")]
	public void AKMIJIICENO(List<DDFIFOHEEBL.NEOJJIGKOJP> FJKMJGOIPHC, [In] DDFIFOHEEBL OALOJMNDABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x753AF50", Offset = "0x753A350", VA = "0x18753AF50")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool IGMMLOBHBPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x753C6D0", Offset = "0x753BAD0", VA = "0x18753C6D0")]
	private ENJBAIDLEIF OKDOPKAFOIB(int NHMPBAPFNAK, Allocator LEILKJFLDFN)
	{
		return default(ENJBAIDLEIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x753AF90", Offset = "0x753A390", VA = "0x18753AF90")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void OHHMKCPAAKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x753A8E0", Offset = "0x7539CE0", VA = "0x18753A8E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private float FOHBCADANNC(int GAOBEJAJOFI, int DFPBLCILMIH, bool BDBBLKPDKCN, bool GDPOJGENCEI, float BHFHPCKIHKP, float MIEJENDNBBL, float MPFKNICANLC, float AGAFIOKDBAK, float BEGNFGCABDI, float CMHDJBBDHHO, float AEBOEPKBLMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7539950", Offset = "0x7538D50", VA = "0x187539950")]
	[IgnoreWarning(1371)]
	private DMOAGJPFALA AINCJDKPNAN([In] DMOAGJPFALA PGLPLHHGCCE, int FMCHIGKCNFJ, [In] NativeArray<int> HKAJIOBOKII, [In] NativeArray<bool> GKFCJAJDEIO, NativeArray<int> OINCBPGMFJE)
	{
		return default(DMOAGJPFALA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x753A6B0", Offset = "0x7539AB0", VA = "0x18753A6B0")]
	public static int DJGILMLLEGE(NativeArray<int> HKAJIOBOKII, NativeArray<int> CDIKACBOLIG, int HHMDEGGJGHF, int CFLCDBPHGNP, int IAHCEKHNNOC)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class BatchedMeshRenderer : MonoBehaviour, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		private struct KLFGLJNDIIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public long PFFBHDJJIMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public DJOEGFIEAIG LMEMOMNCOOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			public LOFFCANAFML LCGHOEMEOEK;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x753E740", Offset = "0x753DB40", VA = "0x18753E740")]
			public KLFGLJNDIIJ(DJOEGFIEAIG MPKAGCCBFDG, LOFFCANAFML HGIPDKNGEON)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		private class BFPMJHLGCEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			public DJOEGFIEAIG LMEMOMNCOOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			public int EJENEKIJBLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			public float MIKEEHMNDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			public List<KLFGLJNDIIJ> MEDHCPCLFFL;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7532DD0", Offset = "0x75321D0", VA = "0x187532DD0")]
			public BFPMJHLGCEL(DJOEGFIEAIG MPKAGCCBFDG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static readonly ProfilerMarker NFPNJICCDFJ;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static readonly ProfilerMarker PFOKNEMCMPO;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static readonly ProfilerMarker JOODICMHPFJ;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static readonly ProfilerMarker KKJFDGEMIMF;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static readonly ProfilerMarker MOPAAHIAMCC;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private static readonly ProfilerMarker CPJBBINLCOF;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private static readonly ProfilerMarker PALAMIBAMGI;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		internal const int JNFOIGPHIFM = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		internal static Dictionary<Material, List<Material>> GAPGIENHLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private Dictionary<Material, List<DDFIFOHEEBL>> BFJEDAPMGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		internal List<DDFIFOHEEBL> ICJLKCDAKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private List<MeshRenderer> GGFBACJKBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private Transform JFBBGIKFOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private bool FBCJILJJNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private bool GBFLFMMLHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private int JBOILPOBIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private DDFIFOHEEBL NCOEIEEMOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private Material EFLNDBOBIKH;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private static bool? DKFAAKOJJEM;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private const int PIEJDJFFCOO = 1024;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private static List<KLFGLJNDIIJ> FFPMDIOANHE;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IReadOnlyList<MeshRenderer> DDOJPAOCHLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int GCNBKMOHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x75390C0", Offset = "0x75384C0", VA = "0x1875390C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private static bool HJPCDHHJLDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x75348E0", Offset = "0x7533CE0", VA = "0x1875348E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		private static void INCFJHLNCOM(bool CEBKCIEMAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		private static void INCFJHLNCOM(bool CEBKCIEMAIG, string MIALAMIFNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		private static void NJLEBBDPDPI(string OMOOEGOLALI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7533100", Offset = "0x7532500", VA = "0x187533100")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7532E80", Offset = "0x7532280", VA = "0x187532E80")]
		internal bool ABJGPNKMMLO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x75347B0", Offset = "0x7533BB0", VA = "0x1875347B0")]
		private Transform IIGLKJKLKAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7535350", Offset = "0x7534750", VA = "0x187535350")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7533770", Offset = "0x7532B70", VA = "0x187533770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7532EE0", Offset = "0x75322E0", VA = "0x187532EE0")]
		public DDFIFOHEEBL AddToBatchedMesh(LOFFCANAFML IAGABAEDJMD, Material HJCEHLILOIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7538B80", Offset = "0x7537F80", VA = "0x187538B80")]
		public void RemoveFromBatchedMesh(LOFFCANAFML LCGHOEMEOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7533640", Offset = "0x7532A40", VA = "0x187533640")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x75350B0", Offset = "0x75344B0", VA = "0x1875350B0")]
		private void NIAMFKBIDJK(Renderer EHMEICJAGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7534840", Offset = "0x7533C40", VA = "0x187534840")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7534830", Offset = "0x7533C30", VA = "0x187534830")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7534200", Offset = "0x7533600", VA = "0x187534200")]
		private void HGIJEOOBHFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7534B70", Offset = "0x7533F70", VA = "0x187534B70")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7535130", Offset = "0x7534530", VA = "0x187535130")]
		private DDFIFOHEEBL ODPNACIKOPL(LOFFCANAFML LCGHOEMEOEK, Material HJCEHLILOIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7533130", Offset = "0x7532530", VA = "0x187533130")]
		private DDFIFOHEEBL BAEJMKAICMJ(Material HJCEHLILOIG, int ANMNILNJFKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7535360", Offset = "0x7534760", VA = "0x187535360")]
		private DDFIFOHEEBL PDFNHHKCLLM(Material HJCEHLILOIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7534710", Offset = "0x7533B10", VA = "0x187534710")]
		internal float4x4 HJHIJPLKIEG()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7533B80", Offset = "0x7532F80", VA = "0x187533B80")]
		public static List<Material> GenerateVertexFormatVariants(Material HJCEHLILOIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1134990", Offset = "0x1133D90", VA = "0x181134990")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7534A10", Offset = "0x7533E10", VA = "0x187534A10")]
		public void MarkDirty(LOFFCANAFML LCGHOEMEOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7533410", Offset = "0x7532810", VA = "0x187533410")]
		[Conditional("CHECK_STATE")]
		private void CDLILEJLDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7534CD0", Offset = "0x75340D0", VA = "0x187534CD0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float MOKFPBHGJJD)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7533510", Offset = "0x7532910", VA = "0x187533510")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7537920", Offset = "0x7536D20", VA = "0x187537920")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7533CA0", Offset = "0x75330A0", VA = "0x187533CA0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7535C70", Offset = "0x7535070", VA = "0x187535C70")]
		public void RebatchOptimally(int KLPKDPEEMPB, int EMMEPGOJIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7535B90", Offset = "0x7534F90", VA = "0x187535B90")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7538F90", Offset = "0x7538390", VA = "0x187538F90")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class MOFGJOPNAGG
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private struct OMDHIDIDKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public BatchedMeshRenderer EHMEICJAGNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public DDFIFOHEEBL LCGHOEMEOEK;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x177F1D0", Offset = "0x177E5D0", VA = "0x18177F1D0")]
		public void GBNLLEDCFPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private struct GIKIGAPLIDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public float MKFEBODAODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public DDFIFOHEEBL OKJBLLFAIND;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class KECJPBJNIFN : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private int <batchesPerYield>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private int <countdownBeforeYield>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private int <batchSizeNaughty>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private int <batchSizeNice>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xF518C0", Offset = "0xF50CC0", VA = "0x180F518C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x753E5D0", Offset = "0x753D9D0", VA = "0x18753E5D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1091580", Offset = "0x1090980", VA = "0x181091580")]
		[DebuggerHidden]
		public KECJPBJNIFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x753E620", Offset = "0x753DA20", VA = "0x18753E620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x753D500", Offset = "0x753C900", VA = "0x18753D500", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x753D460", Offset = "0x753C860", VA = "0x18753D460")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x753D4B0", Offset = "0x753C8B0", VA = "0x18753D4B0")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x753E580", Offset = "0x753D980", VA = "0x18753E580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x753E4D0", Offset = "0x753D8D0", VA = "0x18753E4D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x753E4D0", Offset = "0x753D8D0", VA = "0x18753E4D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private static readonly ProfilerMarker CPJBBINLCOF;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private static readonly ProfilerMarker INFIEKFDNNI;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private static readonly ProfilerMarker CEJDPJPAAPB;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private static readonly ProfilerMarker OJNPPJLOBAF;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static float3 ELOAFDAMKMP;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static int FDKPPEMLCAN;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static int CAGDOPEADON;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static int GIHAOJMMFEG;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static int PBPIDGNIFGB;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static int INFAFAMACLF;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static float LOKJILBNMFI;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static float IDNGLIFNKEK;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static float MDAAFKMEGNN;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static float DHAAOFPODLF;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static float LMAIMCFJIGM;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static float PKFONEKEMAF;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static float HBJBLHIGKGD;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static float LGIIBNECMJI;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private static List<BatchedMeshRenderer> EACAIMMILNH;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private static Stack<FBFDINCPKFI> JJKPOOKAFOO;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private static Stack<NFBJNLMOOIN> LDAOOMKNOKM;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static LNJLGFCNCEA CNPKAHOGCNH;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private static OMDHIDIDKGA GMICGNKKMEL;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static int JAJIDGMHJGK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool DBLGDIBNONN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x753EBC0", Offset = "0x753DFC0", VA = "0x18753EBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void INCFJHLNCOM(bool CEBKCIEMAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void HPNHJBKKPAI(bool CEBKCIEMAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void INCFJHLNCOM(bool CEBKCIEMAIG, string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x753EA10", Offset = "0x753DE10", VA = "0x18753EA10")]
	public static void CIDIOEOELJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x75416D0", Offset = "0x7540AD0", VA = "0x1875416D0")]
	public static void NOLEHKNELFC(BatchedMeshRenderer OMAJNMGGNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x753EA90", Offset = "0x753DE90", VA = "0x18753EA90")]
	public static void CMKPICEJBGJ(BatchedMeshRenderer OMAJNMGGNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x753FE30", Offset = "0x753F230", VA = "0x18753FE30")]
	public static void KBAECGGIGBE(LOFFCANAFML JGNHDNDKMED, bool AMGEMOJAODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7541810", Offset = "0x7540C10", VA = "0x187541810")]
	public static void POKDGHEKJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7540D30", Offset = "0x7540130", VA = "0x187540D30")]
	public static void LMMEJOBNNCA(float MOKFPBHGJJD, bool LBBGLBCNNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7540830", Offset = "0x753FC30", VA = "0x187540830")]
	private static void LJDICMDLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x753F410", Offset = "0x753E810", VA = "0x18753F410")]
	public static long HMNCLPECODL(int FEJPMIGCGIC, long GJOIBCLAMFC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x753F200", Offset = "0x753E600", VA = "0x18753F200")]
	public static (long, long, int) HMLJIABAFDB(float MOKFPBHGJJD)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x75405F0", Offset = "0x753F9F0", VA = "0x1875405F0")]
	[IteratorStateMachine(typeof(KECJPBJNIFN))]
	public static IEnumerable<bool> KLEBOFLHMHH(long KAFLGHKJPKH, bool HEBDMJDJGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x753E770", Offset = "0x753DB70", VA = "0x18753E770")]
	public static void CFODEJBLDLL(long KAFLGHKJPKH, bool HEBDMJDJGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7540680", Offset = "0x753FA80", VA = "0x187540680")]
	public static int KPDJDOLAKNA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x753EEA0", Offset = "0x753E2A0", VA = "0x18753EEA0")]
	internal static FBFDINCPKFI EKGPLIHFBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x753ED60", Offset = "0x753E160", VA = "0x18753ED60")]
	internal static void DINBOIJBJDP(FBFDINCPKFI KCLIAJAONIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x753EC10", Offset = "0x753E010", VA = "0x18753EC10")]
	internal static NFBJNLMOOIN DEAMMLGCNBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x753EE10", Offset = "0x753E210", VA = "0x18753EE10")]
	internal static void DINBOIJBJDP(NFBJNLMOOIN GBAGKPNELCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x753F020", Offset = "0x753E420", VA = "0x18753F020")]
	public static void HCKEPGGEHBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public class CKDKINEBKLB<KeyType> : DDFIFOHEEBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly Dictionary<KeyType, LOFFCANAFML> CHPBDGIEOBP;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B28D00", Offset = "0x5B28100", VA = "0x185B28D00")]
	public CKDKINEBKLB(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B288B0", Offset = "0x5B27CB0", VA = "0x185B288B0")]
	public void BMFCBKCPPJP(KeyType LKMGECEEGEE, LOFFCANAFML JGNHDNDKMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B28AC0", Offset = "0x5B27EC0", VA = "0x185B28AC0")]
	public bool FNOLMBNFLDG(KeyType LKMGECEEGEE, LOFFCANAFML KDICDHKNLNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5B289F0", Offset = "0x5B27DF0", VA = "0x185B289F0")]
	public void DNDOLNBIJJI(KeyType LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5B28CA0", Offset = "0x5B280A0", VA = "0x185B28CA0", Slot = "4")]
	public override void GMCFBBCEPNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x75427E0", Offset = "0x7541BE0", VA = "0x1875427E0")]
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
