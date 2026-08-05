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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
	public class LogRegistrationIndex : NNAGAKKCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A465A0", Offset = "0x6A451A0", VA = "0x186A465A0", Slot = "4")]
		public override void NGMFPPEDCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NEHBKPADDIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int KFDFDNBKPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 BHEOLFKIENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion FNOFIAKGHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 MOHCDBHEANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int HGAKPOFCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int LNDJCPFPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int HBEKOIDAFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float BLDNNLCIHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 BIMKJEINADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool NEONFFFJHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public OIDJADAGJLJ HLEBAOKFODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 EAGGLMLLHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float CBNBDILEEFH;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HMDGCEHBKLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static FEKGMEHFPDL IPKJDJCAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<NEHBKPADDIP> OKAGBFJJNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<AEHODIEIPAO> CKKPHJGFMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<EGJLDJMNHPN> ONEIBNGKOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<KHHNONIILDN> MIADLNNMJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<AEHODIEIPAO> FCAKAOHCGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<GGLPGFLEEKG> INJBFJDBPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<KHHNONIILDN>> NODBECLENDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<EIJCLCCPLFP> MNBEMOLJBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> DNBHALCAPPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IIDHCPMGDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDCB360", Offset = "0xDC9F60", VA = "0x180DCB360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDC9CA0", Offset = "0xDC88A0", VA = "0x180DC9CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HMFFBCMKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA80AD0", Offset = "0xA7F6D0", VA = "0x180A80AD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDCACD0", Offset = "0xDC98D0", VA = "0x180DCACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A41D60", Offset = "0x6A40960", VA = "0x186A41D60")]
	public HMDGCEHBKLI(int BAIHDOOMPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A40050", Offset = "0x6A3EC50", VA = "0x186A40050", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A414D0", Offset = "0x6A400D0", VA = "0x186A414D0")]
	public void JPLCCCCJMFH(JobHandle HDLKHHLCLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A41B40", Offset = "0x6A40740", VA = "0x186A41B40")]
	public void MCGJJFBIJFM(NEHBKPADDIP JGFKFMMOAJO, EIJCLCCPLFP IJMLDDGOKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A419E0", Offset = "0x6A405E0", VA = "0x186A419E0")]
	public void LKODIMEJGAP(EGJLDJMNHPN JGFKFMMOAJO, NativeArray<KHHNONIILDN> EEPOCKPJILL, int CHFINOAHILG, int EIONMLMCMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A40210", Offset = "0x6A3EE10", VA = "0x186A40210")]
	public JobHandle GPJOPKDPBKC(CDNBEALFEJM IKOBPBONPJO, AFOONMEPKGI GCCNCOHLDFK, float3 EMNCCCAGBHE, quaternion CBFAPBNFFAG, float OJAKNHDOGLL, bool KIBMKIDPFLO, int HHEPFABPGDO = 0, int JIKFIOHFLHM = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A416A0", Offset = "0x6A402A0", VA = "0x186A416A0")]
	public static JobHandle KNGCIAOCMDL(FFMKBBCCNAD GCDACHJFIGK, CDNBEALFEJM IKOBPBONPJO, NEHBKPADDIP JGFKFMMOAJO, JobHandle HDLKHHLCLHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A41220", Offset = "0x6A3FE20", VA = "0x186A41220")]
	public static JobHandle HDMIPIOOPJC(BONDIJCFHPA GCDACHJFIGK, CDNBEALFEJM IKOBPBONPJO, EGJLDJMNHPN JGFKFMMOAJO, NativeArray<KHHNONIILDN> EEPOCKPJILL, int CHFINOAHILG, int EIONMLMCMLD, JobHandle HDLKHHLCLHJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class DHGELDLIMNE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct FFNNDPCMKCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half JKFJPAOPGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort NKCEDAEJJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte LOLLCNLBEJC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void EIHJHJLCBMB([NoAlias] float3* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class EPBCIMJOOLF
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A970", Offset = "0x6A39570", VA = "0x186A3A970")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A3AD60", Offset = "0x6A39960", VA = "0x186A3AD60")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A3AAA0", Offset = "0x6A396A0", VA = "0x186A3AAA0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A3AB50", Offset = "0x6A39750", VA = "0x186A3AB50")]
		public unsafe static void HEONFGBJNMF([NoAlias] float3* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void FOGDLFMPCBK([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class KLCLCODCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A440F0", Offset = "0x6A42CF0", VA = "0x186A440F0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A44560", Offset = "0x6A43160", VA = "0x186A44560")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A44220", Offset = "0x6A42E20", VA = "0x186A44220")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A442D0", Offset = "0x6A42ED0", VA = "0x186A442D0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void DDHMFEMHAFI([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class OBDEMAEAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A48F20", Offset = "0x6A47B20", VA = "0x186A48F20")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A49390", Offset = "0x6A47F90", VA = "0x186A49390")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A49050", Offset = "0x6A47C50", VA = "0x186A49050")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A49100", Offset = "0x6A47D00", VA = "0x186A49100")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void BBPGAIALHKO([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class MCDLLADAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A466F0", Offset = "0x6A452F0", VA = "0x186A466F0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A46B60", Offset = "0x6A45760", VA = "0x186A46B60")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A46820", Offset = "0x6A45420", VA = "0x186A46820")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6A468D0", Offset = "0x6A454D0", VA = "0x186A468D0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void IGOBNACGKNJ([NoAlias] ushort* MILPOLGFMKB, [Out] float3 JBNICEKNOGA, [Out] float3 KAOEEBPLGHC, [In][NoAlias] float3* LEOCCJEAGFC, int GAOHIAANHOH, int LBNGFGNJGNL);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class NCCMIAENJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A48460", Offset = "0x6A47060", VA = "0x186A48460")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A48860", Offset = "0x6A47460", VA = "0x186A48860")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A48590", Offset = "0x6A47190", VA = "0x186A48590")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A48640", Offset = "0x6A47240", VA = "0x186A48640")]
		public unsafe static void HEONFGBJNMF([NoAlias] ushort* MILPOLGFMKB, [Out] float3 JBNICEKNOGA, [Out] float3 KAOEEBPLGHC, [In][NoAlias] float3* LEOCCJEAGFC, int GAOHIAANHOH, int LBNGFGNJGNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void BEFFKDGDDDI([NoAlias] ushort* JPOKBJHMNIE, [In][NoAlias] float3* PIAHELLMEJB, int LBNGFGNJGNL);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class POFPGEKPDBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C690", Offset = "0x6A4B290", VA = "0x186A4C690")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4CA60", Offset = "0x6A4B660", VA = "0x186A4CA60")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C7C0", Offset = "0x6A4B3C0", VA = "0x186A4C7C0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C870", Offset = "0x6A4B470", VA = "0x186A4C870")]
		public unsafe static void HEONFGBJNMF([NoAlias] ushort* JPOKBJHMNIE, [In][NoAlias] float3* PIAHELLMEJB, int LBNGFGNJGNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void PAJCBHNJEHP([NoAlias] float3* JMKODELFHAN, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class PHODANLJHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A49BC0", Offset = "0x6A487C0", VA = "0x186A49BC0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A49FF0", Offset = "0x6A48BF0", VA = "0x186A49FF0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A49CF0", Offset = "0x6A488F0", VA = "0x186A49CF0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A49DA0", Offset = "0x6A489A0", VA = "0x186A49DA0")]
		public unsafe static void HEONFGBJNMF([NoAlias] float3* JMKODELFHAN, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void EDGICBLAJIO([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class ADFJHCKHBCE
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A30580", Offset = "0x6A2F180", VA = "0x186A30580")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A30950", Offset = "0x6A2F550", VA = "0x186A30950")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A306B0", Offset = "0x6A2F2B0", VA = "0x186A306B0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A30760", Offset = "0x6A2F360", VA = "0x186A30760")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void HNFPAONEFMP([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class FNKCOCLMJJH
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B760", Offset = "0x6A3A360", VA = "0x186A3B760")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BC00", Offset = "0x6A3A800", VA = "0x186A3BC00")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B890", Offset = "0x6A3A490", VA = "0x186A3B890")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B940", Offset = "0x6A3A540", VA = "0x186A3B940")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void FJFPHGEJGPB([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class IAOFBJHIJEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A42070", Offset = "0x6A40C70", VA = "0x186A42070")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A42500", Offset = "0x6A41100", VA = "0x186A42500")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A421A0", Offset = "0x6A40DA0", VA = "0x186A421A0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A42250", Offset = "0x6A40E50", VA = "0x186A42250")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void HMGKLEDJJOO([NoAlias] ushort* LBFMJGFLLJL, [Out] float2 DPLLKKABOOK, [Out] float2 HJJLIEMBCMI, [In][NoAlias] float2* KOAIFCJGPPK, int GAOHIAANHOH, int LBNGFGNJGNL);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class NFOPLJHBFOE
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A489C0", Offset = "0x6A475C0", VA = "0x186A489C0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A48DC0", Offset = "0x6A479C0", VA = "0x186A48DC0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A48AF0", Offset = "0x6A476F0", VA = "0x186A48AF0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A48BA0", Offset = "0x6A477A0", VA = "0x186A48BA0")]
		public unsafe static void HEONFGBJNMF([NoAlias] ushort* LBFMJGFLLJL, [Out] float2 DPLLKKABOOK, [Out] float2 HJJLIEMBCMI, [In][NoAlias] float2* KOAIFCJGPPK, int GAOHIAANHOH, int LBNGFGNJGNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void FLCDPKHGAPE([Out] float2 ODDNJGIBGEG, ushort IPDFPMGEIHK, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class MMCEBMKAIHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A47360", Offset = "0x6A45F60", VA = "0x186A47360")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A47780", Offset = "0x6A46380", VA = "0x186A47780")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A47490", Offset = "0x6A46090", VA = "0x186A47490")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A47540", Offset = "0x6A46140", VA = "0x186A47540")]
		public static void HEONFGBJNMF([Out] float2 ODDNJGIBGEG, ushort IPDFPMGEIHK, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void LGAKICPGBNG([NoAlias] float2* LBFMJGFLLJL, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class OKJBKPCGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A494F0", Offset = "0x6A480F0", VA = "0x186A494F0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A49960", Offset = "0x6A48560", VA = "0x186A49960")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A49620", Offset = "0x6A48220", VA = "0x186A49620")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A496D0", Offset = "0x6A482D0", VA = "0x186A496D0")]
		public unsafe static void HEONFGBJNMF([NoAlias] float2* LBFMJGFLLJL, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void NINAAKHHEGP([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class CODGIPHMLDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A32610", Offset = "0x6A31210", VA = "0x186A32610")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A32AC0", Offset = "0x6A316C0", VA = "0x186A32AC0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A32740", Offset = "0x6A31340", VA = "0x186A32740")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A327F0", Offset = "0x6A313F0", VA = "0x186A327F0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void CNLJIOILBJG([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class CGJFFLHOLHG
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A32000", Offset = "0x6A30C00", VA = "0x186A32000")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6A324B0", Offset = "0x6A310B0", VA = "0x186A324B0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A32130", Offset = "0x6A30D30", VA = "0x186A32130")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A321E0", Offset = "0x6A30DE0", VA = "0x186A321E0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void GFBPDMJBCMF([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class KNOLPEJNNIP
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A446C0", Offset = "0x6A432C0", VA = "0x186A446C0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A44C50", Offset = "0x6A43850", VA = "0x186A44C50")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A447F0", Offset = "0x6A433F0", VA = "0x186A447F0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A448A0", Offset = "0x6A434A0", VA = "0x186A448A0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void FGBHDBDHDCK([NoAlias] ushort* AAAOMKPEKHJ, [In][NoAlias] float4* ODAOAIAGNHG, int GAOHIAANHOH, int LBNGFGNJGNL);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class IMADDCNHHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A42B20", Offset = "0x6A41720", VA = "0x186A42B20")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A42F50", Offset = "0x6A41B50", VA = "0x186A42F50")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A42C50", Offset = "0x6A41850", VA = "0x186A42C50")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A42D00", Offset = "0x6A41900", VA = "0x186A42D00")]
		public unsafe static void HEONFGBJNMF([NoAlias] ushort* AAAOMKPEKHJ, [In][NoAlias] float4* ODAOAIAGNHG, int GAOHIAANHOH, int LBNGFGNJGNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort JDHLJPCDKDD([In] float4 MPEGLOLDJBC);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class JGHNDAPPONN
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A43670", Offset = "0x6A42270", VA = "0x186A43670")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A43A60", Offset = "0x6A42660", VA = "0x186A43A60")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A437A0", Offset = "0x6A423A0", VA = "0x186A437A0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A43850", Offset = "0x6A42450", VA = "0x186A43850")]
		public static ushort HEONFGBJNMF([In] float4 MPEGLOLDJBC)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void FPPOMIIEEDD([NoAlias] float4* AAAOMKPEKHJ, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class GOILMJEJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E7A0", Offset = "0x6A3D3A0", VA = "0x186A3E7A0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EBD0", Offset = "0x6A3D7D0", VA = "0x186A3EBD0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E8D0", Offset = "0x6A3D4D0", VA = "0x186A3E8D0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E980", Offset = "0x6A3D580", VA = "0x186A3E980")]
		public unsafe static void HEONFGBJNMF([NoAlias] float4* AAAOMKPEKHJ, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void CGPHJLOKNAE([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class JPJPIHOKADE
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A43BC0", Offset = "0x6A427C0", VA = "0x186A43BC0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A43F90", Offset = "0x6A42B90", VA = "0x186A43F90")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A43CF0", Offset = "0x6A428F0", VA = "0x186A43CF0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A43DA0", Offset = "0x6A429A0", VA = "0x186A43DA0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void ICCGJCFOBDO([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class MPIIGGOIENE
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A478E0", Offset = "0x6A464E0", VA = "0x186A478E0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A47D80", Offset = "0x6A46980", VA = "0x186A47D80")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A47A10", Offset = "0x6A46610", VA = "0x186A47A10")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A47AC0", Offset = "0x6A466C0", VA = "0x186A47AC0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void ODEHECMAKFH([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class AEAKFCIKDFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A30AB0", Offset = "0x6A2F6B0", VA = "0x186A30AB0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A30F40", Offset = "0x6A2FB40", VA = "0x186A30F40")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A30BE0", Offset = "0x6A2F7E0", VA = "0x186A30BE0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6A30C90", Offset = "0x6A2F890", VA = "0x186A30C90")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void JACAFBJBJCG([Out] float4 KKIOBLFFGJH, ushort IPDFPMGEIHK);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class JABHPAAOJII
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6A430B0", Offset = "0x6A41CB0", VA = "0x186A430B0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6A43510", Offset = "0x6A42110", VA = "0x186A43510")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A431E0", Offset = "0x6A41DE0", VA = "0x186A431E0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6A43290", Offset = "0x6A41E90", VA = "0x186A43290")]
		public static void HEONFGBJNMF([Out] float4 KKIOBLFFGJH, ushort IPDFPMGEIHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void PLCIJPDHPDN([NoAlias] float4* KHCBCGFGCMB, [NoAlias] byte* GKNJIJALJIH, [Out] int DOLIOMNFAAH, [Out] int MLLEGPKOFEA, [NoAlias] float4* GCADNDFKBKB, int GAOHIAANHOH, int LBNGFGNJGNL);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class EIPJLOCEMFA
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A410", Offset = "0x6A39010", VA = "0x186A3A410")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A810", Offset = "0x6A39410", VA = "0x186A3A810")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A540", Offset = "0x6A39140", VA = "0x186A3A540")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A5F0", Offset = "0x6A391F0", VA = "0x186A3A5F0")]
		public unsafe static void HEONFGBJNMF([NoAlias] float4* KHCBCGFGCMB, [NoAlias] byte* GKNJIJALJIH, [Out] int DOLIOMNFAAH, [Out] int MLLEGPKOFEA, [NoAlias] float4* GCADNDFKBKB, int GAOHIAANHOH, int LBNGFGNJGNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void MBNCEFOCFEJ([NoAlias] float4* LBDNECHDBNF, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class CDIEJDHCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A319E0", Offset = "0x6A305E0", VA = "0x186A319E0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A31EA0", Offset = "0x6A30AA0", VA = "0x186A31EA0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A31B10", Offset = "0x6A30710", VA = "0x186A31B10")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A31BC0", Offset = "0x6A307C0", VA = "0x186A31BC0")]
		public unsafe static void HEONFGBJNMF([NoAlias] float4* LBDNECHDBNF, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void BFPIMEJFIMB([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class HEBMJLGLNCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6A3ED30", Offset = "0x6A3D930", VA = "0x186A3ED30")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F2A0", Offset = "0x6A3DEA0", VA = "0x186A3F2A0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EE60", Offset = "0x6A3DA60", VA = "0x186A3EE60")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EF10", Offset = "0x6A3DB10", VA = "0x186A3EF10")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void GDDBDIAAILE([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class GGPNOILLGIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E0C0", Offset = "0x6A3CCC0", VA = "0x186A3E0C0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E640", Offset = "0x6A3D240", VA = "0x186A3E640")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E1F0", Offset = "0x6A3CDF0", VA = "0x186A3E1F0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E2A0", Offset = "0x6A3CEA0", VA = "0x186A3E2A0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void PCALPPOIAPE([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class HJHGCGFCPKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F400", Offset = "0x6A3E000", VA = "0x186A3F400")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F970", Offset = "0x6A3E570", VA = "0x186A3F970")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F530", Offset = "0x6A3E130", VA = "0x186A3F530")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F5E0", Offset = "0x6A3E1E0", VA = "0x186A3F5E0")]
		public unsafe static void HEONFGBJNMF([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int PHNJJCGBMPM([NoAlias] byte* ICMNFMKFNAM, [In][NoAlias] int* CBDDHLNDHFN, int APABJEFFIFJ);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class DNKNAINJDDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6A393D0", Offset = "0x6A37FD0", VA = "0x186A393D0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6A39830", Offset = "0x6A38430", VA = "0x186A39830")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6A39500", Offset = "0x6A38100", VA = "0x186A39500")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6A395B0", Offset = "0x6A381B0", VA = "0x186A395B0")]
		public unsafe static int HEONFGBJNMF([NoAlias] byte* ICMNFMKFNAM, [In][NoAlias] int* CBDDHLNDHFN, int APABJEFFIFJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void NMHHKHKJGLM([NoAlias] int* CILKGHDPDKE, [In][NoAlias] byte* APAINDDPAPG, int EIONMLMCMLD);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class NALICCMBOBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6A47EE0", Offset = "0x6A46AE0", VA = "0x186A47EE0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6A48300", Offset = "0x6A46F00", VA = "0x186A48300")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6A48010", Offset = "0x6A46C10", VA = "0x186A48010")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6A480C0", Offset = "0x6A46CC0", VA = "0x186A480C0")]
		public unsafe static void HEONFGBJNMF([NoAlias] int* CILKGHDPDKE, [In][NoAlias] byte* APAINDDPAPG, int EIONMLMCMLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void PFCHEFGEPFP([NoAlias] ushort* CILKGHDPDKE, [In][NoAlias] byte* APAINDDPAPG, int EIONMLMCMLD);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class HJKDPGACCPI
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FAD0", Offset = "0x6A3E6D0", VA = "0x186A3FAD0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FEF0", Offset = "0x6A3EAF0", VA = "0x186A3FEF0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FC00", Offset = "0x6A3E800", VA = "0x186A3FC00")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FCB0", Offset = "0x6A3E8B0", VA = "0x186A3FCB0")]
		public unsafe static void HEONFGBJNMF([NoAlias] ushort* CILKGHDPDKE, [In][NoAlias] byte* APAINDDPAPG, int EIONMLMCMLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void PHJIFAOCNBP([Out] float3 ODDNJGIBGEG, ushort IPDFPMGEIHK);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class MCEAHJINENB
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6A46CC0", Offset = "0x6A458C0", VA = "0x186A46CC0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6A47200", Offset = "0x6A45E00", VA = "0x186A47200")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6A46DF0", Offset = "0x6A459F0", VA = "0x186A46DF0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6A46EA0", Offset = "0x6A45AA0", VA = "0x186A46EA0")]
		public static void HEONFGBJNMF([Out] float3 ODDNJGIBGEG, ushort IPDFPMGEIHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort GOGOMGJANLN([In] float3 MPEGLOLDJBC);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class FFDCPBOKDGN
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6A3AEC0", Offset = "0x6A39AC0", VA = "0x186A3AEC0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B270", Offset = "0x6A39E70", VA = "0x186A3B270")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6A3AFF0", Offset = "0x6A39BF0", VA = "0x186A3AFF0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B0A0", Offset = "0x6A39CA0", VA = "0x186A3B0A0")]
		public static ushort HEONFGBJNMF([In] float3 MPEGLOLDJBC)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int CHFINOAHILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int EIONMLMCMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> DEIJPBFFJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> DLDPCHMBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> JGOLKFPHFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> BAOIFICJNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<FFNNDPCMKCO> PHJGOMGKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> OBPNHDELMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> FLCNPAEHCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 LIHPJBMPJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 KAOEEBPLGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 AEHPLHDMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 HJJLIEMBCMI;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long OHLJLGIMHKH;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long OCAELKPCBHC;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float LMEIDLDJIEE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool HLENMELOCLH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MFOFAMGPGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6A34E80", Offset = "0x6A33A80", VA = "0x186A34E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A35ED0", Offset = "0x6A34AD0", VA = "0x186A35ED0")]
	public void JPLCCCCJMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A378A0", Offset = "0x6A364A0", VA = "0x186A378A0")]
	public static DHGELDLIMNE NCPDNLLGMJA(Allocator MJBDBDLLDBK, CDNBEALFEJM OOEEGPBHPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A373B0", Offset = "0x6A35FB0", VA = "0x186A373B0")]
	public static DHGELDLIMNE NCPDNLLGMJA(Allocator MJBDBDLLDBK, NativeArray<float3> LEOCCJEAGFC, NativeArray<float3> PIAHELLMEJB, NativeArray<float2> KOAIFCJGPPK, NativeArray<float4> GCADNDFKBKB, bool HGOEKDCLFAM, NativeArray<float4> FEDGACMMJAE, NativeArray<int> CBDDHLNDHFN, int CHFINOAHILG, int JPBBINJJMAM, int EIONMLMCMLD, int GAOHIAANHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A36DD0", Offset = "0x6A359D0", VA = "0x186A36DD0")]
	public CDNBEALFEJM MNNKFDKHJMA(Allocator MJBDBDLLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A39170", Offset = "0x6A37D70", VA = "0x186A39170")]
	public void PKGJAFNMMEA(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A37D80", Offset = "0x6A36980", VA = "0x186A37D80")]
	private void NEPHLHMIKHB(Mesh KBGHMNKGJFA, NativeArray<ushort> PDIAFNIGLJC, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A342C0", Offset = "0x6A32EC0", VA = "0x186A342C0")]
	public void DHLGABELDDK(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A33CE0", Offset = "0x6A328E0", VA = "0x186A33CE0")]
	public void CIAHHNPMNBE(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A38340", Offset = "0x6A36F40", VA = "0x186A38340")]
	public void OONECANODGA(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A39270", Offset = "0x6A37E70", VA = "0x186A39270")]
	public void POAJOBLDAKF(Mesh KBGHMNKGJFA, CDNBEALFEJM.KCNGLIBKFBP HCFPFEPBAJC, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A390E0", Offset = "0x6A37CE0", VA = "0x186A390E0")]
	public long PJEFMLLINJE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A380E0", Offset = "0x6A36CE0", VA = "0x186A380E0")]
	public long NJIBEDNNNDC(CDNBEALFEJM.KCNGLIBKFBP HCFPFEPBAJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A36AC0", Offset = "0x6A356C0", VA = "0x186A36AC0")]
	private void MHHJAOMFNPH(int AEJDPIGCGMA, int LBNGFGNJGNL, Allocator MJBDBDLLDBK, bool NLJLLMFKBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A35C10", Offset = "0x6A34810", VA = "0x186A35C10")]
	private void JIGODELEHGM(NativeArray<float3> MILPOLGFMKB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A35B90", Offset = "0x6A34790", VA = "0x186A35B90")]
	[BurstCompile]
	private unsafe static void JIGODELEHGM([NoAlias] float3* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A35E50", Offset = "0x6A34A50", VA = "0x186A35E50")]
	[BurstCompile]
	private unsafe static void JLPCBDHNNCH([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A359D0", Offset = "0x6A345D0", VA = "0x186A359D0")]
	[BurstCompile]
	private unsafe static void IOKDGNGOBIL([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A34EC0", Offset = "0x6A33AC0", VA = "0x186A34EC0")]
	[BurstCompile]
	private unsafe static void FIKBNGNPLLB([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A363A0", Offset = "0x6A34FA0", VA = "0x186A363A0")]
	private void LEECFLNMBBB(NativeArray<float3> LEOCCJEAGFC, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A36310", Offset = "0x6A34F10", VA = "0x186A36310")]
	[BurstCompile]
	private unsafe static void LEECFLNMBBB([NoAlias] ushort* MILPOLGFMKB, [Out] float3 JBNICEKNOGA, [Out] float3 KAOEEBPLGHC, [In][NoAlias] float3* LEOCCJEAGFC, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A32DA0", Offset = "0x6A319A0", VA = "0x186A32DA0")]
	private void BDCPCJMAKJH(NativeArray<float3> PIAHELLMEJB, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A32E60", Offset = "0x6A31A60", VA = "0x186A32E60")]
	[BurstCompile]
	private unsafe static void BDCPCJMAKJH([NoAlias] ushort* JPOKBJHMNIE, [In][NoAlias] float3* PIAHELLMEJB, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A35D80", Offset = "0x6A34980", VA = "0x186A35D80")]
	private void JJILJDDNDFP(NativeArray<float3> JMKODELFHAN, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A35D10", Offset = "0x6A34910", VA = "0x186A35D10")]
	[BurstCompile]
	private unsafe static void JJILJDDNDFP([NoAlias] float3* JMKODELFHAN, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A36560", Offset = "0x6A35160", VA = "0x186A36560")]
	[BurstCompile]
	private unsafe static void LLMLJDEANFM([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A351C0", Offset = "0x6A33DC0", VA = "0x186A351C0")]
	[BurstCompile]
	private unsafe static void FOJAGBGJACJ([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A34D90", Offset = "0x6A33990", VA = "0x186A34D90")]
	[BurstCompile]
	private unsafe static void ELJALHKLBEO([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A33470", Offset = "0x6A32070", VA = "0x186A33470")]
	private void BJHBKLCCKFI(NativeArray<float2> KOAIFCJGPPK, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A33540", Offset = "0x6A32140", VA = "0x186A33540")]
	[BurstCompile]
	private unsafe static void BJHBKLCCKFI([NoAlias] ushort* LBFMJGFLLJL, [Out] float2 DPLLKKABOOK, [Out] float2 HJJLIEMBCMI, [In][NoAlias] float2* KOAIFCJGPPK, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A35540", Offset = "0x6A34140", VA = "0x186A35540")]
	[BurstCompile]
	private static void GNJFKJDPMKJ([Out] float2 ODDNJGIBGEG, ushort IPDFPMGEIHK, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A32CA0", Offset = "0x6A318A0", VA = "0x186A32CA0")]
	private void AGEBCBLJJIF(NativeArray<float2> LBFMJGFLLJL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A32C20", Offset = "0x6A31820", VA = "0x186A32C20")]
	[BurstCompile]
	private unsafe static void AGEBCBLJJIF([NoAlias] float2* LBFMJGFLLJL, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A34FC0", Offset = "0x6A33BC0", VA = "0x186A34FC0")]
	[BurstCompile]
	private unsafe static void FMILKKFPFPE([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A34F40", Offset = "0x6A33B40", VA = "0x186A34F40")]
	[BurstCompile]
	private unsafe static void FMDLFMBDNGF([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A33790", Offset = "0x6A32390", VA = "0x186A33790")]
	[BurstCompile]
	private unsafe static void BLPIKPPCGIL([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A37F80", Offset = "0x6A36B80", VA = "0x186A37F80")]
	private void NGACLJOIAOK(NativeArray<float4> FEDGACMMJAE, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A37F00", Offset = "0x6A36B00", VA = "0x186A37F00")]
	[BurstCompile]
	private unsafe static void NGACLJOIAOK([NoAlias] ushort* AAAOMKPEKHJ, [In][NoAlias] float4* ODAOAIAGNHG, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A33360", Offset = "0x6A31F60", VA = "0x186A33360")]
	[BurstCompile]
	private static ushort BHBBDOPFIKK([In] float4 MPEGLOLDJBC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A36930", Offset = "0x6A35530", VA = "0x186A36930")]
	private void LPCDHFHJEFA(NativeArray<float4> AAAOMKPEKHJ, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A368C0", Offset = "0x6A354C0", VA = "0x186A368C0")]
	[BurstCompile]
	private unsafe static void LPCDHFHJEFA([NoAlias] float4* AAAOMKPEKHJ, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A349D0", Offset = "0x6A335D0", VA = "0x186A349D0")]
	[BurstCompile]
	private unsafe static void EDOIGKIJLAA([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A354D0", Offset = "0x6A340D0", VA = "0x186A354D0")]
	[BurstCompile]
	private unsafe static void GKDLGICCHNN([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A35230", Offset = "0x6A33E30", VA = "0x186A35230")]
	[BurstCompile]
	private unsafe static void GFIBKOLDAED([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A36860", Offset = "0x6A35460", VA = "0x186A36860")]
	[BurstCompile]
	private static void LOKJKMHIGOK([Out] float4 KKIOBLFFGJH, ushort IPDFPMGEIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A38AB0", Offset = "0x6A376B0", VA = "0x186A38AB0")]
	private void PFLIJAGLHMN(Allocator MJBDBDLLDBK, NativeArray<float4> GCADNDFKBKB, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A38E90", Offset = "0x6A37A90", VA = "0x186A38E90")]
	[BurstCompile]
	private unsafe static void PFLIJAGLHMN([NoAlias] float4* KHCBCGFGCMB, [NoAlias] byte* GKNJIJALJIH, [Out] int DOLIOMNFAAH, [Out] int MLLEGPKOFEA, [NoAlias] float4* GCADNDFKBKB, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A389A0", Offset = "0x6A375A0", VA = "0x186A389A0")]
	private static void PBIDHBGPMBM(NativeArray<float4> LBDNECHDBNF, NativeArray<FFNNDPCMKCO> OMOKGINFCKM, NativeArray<byte> JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A38920", Offset = "0x6A37520", VA = "0x186A38920")]
	[BurstCompile]
	private unsafe static void PBIDHBGPMBM([NoAlias] float4* LBDNECHDBNF, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A34E00", Offset = "0x6A33A00", VA = "0x186A34E00")]
	[BurstCompile]
	private unsafe static void EOFABABELGE([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A35660", Offset = "0x6A34260", VA = "0x186A35660")]
	[BurstCompile]
	private unsafe static void ICBLBEHGDOH([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A34950", Offset = "0x6A33550", VA = "0x186A34950")]
	[BurstCompile]
	private unsafe static void DMMAMLHNLBE([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A35040", Offset = "0x6A33C40", VA = "0x186A35040")]
	private void FNLJIEALBLE(Allocator MJBDBDLLDBK, NativeArray<int> CBDDHLNDHFN, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A33080", Offset = "0x6A31C80", VA = "0x186A33080")]
	private static NativeArray<byte> BEJLFINJMEA(Allocator MJBDBDLLDBK, NativeArray<int> CBDDHLNDHFN, int APABJEFFIFJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A332F0", Offset = "0x6A31EF0", VA = "0x186A332F0")]
	[BurstCompile]
	private unsafe static int BEJLFINJMEA([NoAlias] byte* ICMNFMKFNAM, [In][NoAlias] int* CBDDHLNDHFN, int APABJEFFIFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A36C90", Offset = "0x6A35890", VA = "0x186A36C90")]
	private static void MIEOACANFID(NativeArray<int> CILKGHDPDKE, NativeArray<byte> APAINDDPAPG, int EIONMLMCMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A36D60", Offset = "0x6A35960", VA = "0x186A36D60")]
	[BurstCompile]
	private unsafe static void MIEOACANFID([NoAlias] int* CILKGHDPDKE, [In][NoAlias] byte* APAINDDPAPG, int EIONMLMCMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A38070", Offset = "0x6A36C70", VA = "0x186A38070")]
	[BurstCompile]
	private unsafe static void NIMPFMBFMKI([NoAlias] ushort* CILKGHDPDKE, [In][NoAlias] byte* APAINDDPAPG, int EIONMLMCMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A37EA0", Offset = "0x6A36AA0", VA = "0x186A37EA0")]
	[BurstCompile]
	private static void NFCBLMEPIML([Out] float3 ODDNJGIBGEG, ushort IPDFPMGEIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A33AD0", Offset = "0x6A326D0", VA = "0x186A33AD0")]
	[BurstCompile]
	private static ushort CHNDACLLAEL([In] float3 MPEGLOLDJBC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public DHGELDLIMNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F450", Offset = "0x6A2E050", VA = "0x186A2F450")]
	[BurstCompile]
	public unsafe static void JFPJFFGLGEL([NoAlias] float3* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A364A0", Offset = "0x6A350A0", VA = "0x186A364A0")]
	[BurstCompile]
	public unsafe static void LICMLNMIOJF([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A36250", Offset = "0x6A34E50", VA = "0x186A36250")]
	[BurstCompile]
	public unsafe static void LAOAECDJHOC([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A36A00", Offset = "0x6A35600", VA = "0x186A36A00")]
	[BurstCompile]
	public unsafe static void MFKGGLDENPE([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* LEOCCJEAGFC, int CHFINOAHILG, [In] float3 LIHPJBMPJFJ, [In] float3 KAOEEBPLGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F6A0", Offset = "0x6A2E2A0", VA = "0x186A2F6A0")]
	[BurstCompile]
	public unsafe static void MDBCKBKAFPD([NoAlias] ushort* MILPOLGFMKB, [Out] float3 JBNICEKNOGA, [Out] float3 KAOEEBPLGHC, [In][NoAlias] float3* LEOCCJEAGFC, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FD40", Offset = "0x6A2E940", VA = "0x186A2FD40")]
	[BurstCompile]
	public unsafe static void PKEPCMHEPMB([NoAlias] ushort* JPOKBJHMNIE, [In][NoAlias] float3* PIAHELLMEJB, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A34BF0", Offset = "0x6A337F0", VA = "0x186A34BF0")]
	[BurstCompile]
	public unsafe static void EEBFMBKFBJM([NoAlias] float3* JMKODELFHAN, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F210", Offset = "0x6A2DE10", VA = "0x186A2F210")]
	[BurstCompile]
	public unsafe static void JAIELBMFKJD([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A339B0", Offset = "0x6A325B0", VA = "0x186A339B0")]
	[BurstCompile]
	public unsafe static void CGDJIJLHLGL([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A34840", Offset = "0x6A33440", VA = "0x186A34840")]
	[BurstCompile]
	public unsafe static void DKBJDMNGKDD([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* PIAHELLMEJB, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FA80", Offset = "0x6A2E680", VA = "0x186A2FA80")]
	[BurstCompile]
	public unsafe static void OJHEJIDEOGN([NoAlias] ushort* LBFMJGFLLJL, [Out] float2 DPLLKKABOOK, [Out] float2 HJJLIEMBCMI, [In][NoAlias] float2* KOAIFCJGPPK, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A352A0", Offset = "0x6A33EA0", VA = "0x186A352A0")]
	[BurstCompile]
	public static void GIKPLHACDFD([Out] float2 ODDNJGIBGEG, ushort IPDFPMGEIHK, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A36780", Offset = "0x6A35380", VA = "0x186A36780")]
	[BurstCompile]
	public unsafe static void LOGMLNNNKLB([NoAlias] float2* LBFMJGFLLJL, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A38150", Offset = "0x6A36D50", VA = "0x186A38150")]
	[BurstCompile]
	public unsafe static void NOADCAEMGFF([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A34C90", Offset = "0x6A33890", VA = "0x186A34C90")]
	[BurstCompile]
	public unsafe static void EJLLEDGHALK([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A352F0", Offset = "0x6A33EF0", VA = "0x186A352F0")]
	[BurstCompile]
	public unsafe static void GJEFKIJEGMN([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [NoAlias] ushort* KOAIFCJGPPK, int CHFINOAHILG, [In] float2 AEHPLHDMBEH, [In] float2 HJJLIEMBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A35FD0", Offset = "0x6A34BD0", VA = "0x186A35FD0")]
	[BurstCompile]
	public unsafe static void KJBAMEHCJAH([NoAlias] ushort* AAAOMKPEKHJ, [In][NoAlias] float4* ODAOAIAGNHG, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A33950", Offset = "0x6A32550", VA = "0x186A33950")]
	[BurstCompile]
	public static ushort CFMHOIJFKKD([In] float4 MPEGLOLDJBC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A35120", Offset = "0x6A33D20", VA = "0x186A35120")]
	[BurstCompile]
	public unsafe static void FOCKEIDDDPH([NoAlias] float4* AAAOMKPEKHJ, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EF60", Offset = "0x6A2DB60", VA = "0x186A2EF60")]
	[BurstCompile]
	public unsafe static void IHMHOLPIPKL([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A37C60", Offset = "0x6A36860", VA = "0x186A37C60")]
	[BurstCompile]
	public unsafe static void NEJIGFBICKE([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A356E0", Offset = "0x6A342E0", VA = "0x186A356E0")]
	[BurstCompile]
	public unsafe static void INIAKBMKNMC([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] ushort* FEDGACMMJAE, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A333B0", Offset = "0x6A31FB0", VA = "0x186A333B0")]
	[BurstCompile]
	public static void BHIPJMFHLAC([Out] float4 KKIOBLFFGJH, ushort IPDFPMGEIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EBE0", Offset = "0x6A2D7E0", VA = "0x186A2EBE0")]
	[BurstCompile]
	public unsafe static void BKJAOBAENMA([NoAlias] float4* KHCBCGFGCMB, [NoAlias] byte* GKNJIJALJIH, [Out] int DOLIOMNFAAH, [Out] int MLLEGPKOFEA, [NoAlias] float4* GCADNDFKBKB, int GAOHIAANHOH, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A33810", Offset = "0x6A32410", VA = "0x186A33810")]
	[BurstCompile]
	public unsafe static void BMCGOEGPPLI([NoAlias] float4* LBDNECHDBNF, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A36070", Offset = "0x6A34C70", VA = "0x186A36070")]
	[BurstCompile]
	public unsafe static void KONCOFLKKEP([NoAlias] CDNBEALFEJM.GCFNHEDLJNL* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A357F0", Offset = "0x6A343F0", VA = "0x186A357F0")]
	[BurstCompile]
	public unsafe static void INOFKBIBDAH([NoAlias] CDNBEALFEJM.PFDJEGKHEIP* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A37A80", Offset = "0x6A36680", VA = "0x186A37A80")]
	[BurstCompile]
	public unsafe static void NDGNBGPKDJP([NoAlias] CDNBEALFEJM.NIABMGAPGGG* MILPOLGFMKB, [In][NoAlias] FFNNDPCMKCO* OMOKGINFCKM, [In][NoAlias] byte* JIOHJBDKLNL, int CHFINOAHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A38240", Offset = "0x6A36E40", VA = "0x186A38240")]
	[BurstCompile]
	public unsafe static int ONOMJGKBLEB([NoAlias] byte* ICMNFMKFNAM, [In][NoAlias] int* CBDDHLNDHFN, int APABJEFFIFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A36BF0", Offset = "0x6A357F0", VA = "0x186A36BF0")]
	[BurstCompile]
	public unsafe static void MIAMCHDKNDI([NoAlias] int* CILKGHDPDKE, [In][NoAlias] byte* APAINDDPAPG, int EIONMLMCMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A355C0", Offset = "0x6A341C0", VA = "0x186A355C0")]
	[BurstCompile]
	public unsafe static void IBNJJPMAILF([NoAlias] ushort* CILKGHDPDKE, [In][NoAlias] byte* APAINDDPAPG, int EIONMLMCMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A35A50", Offset = "0x6A34650", VA = "0x186A35A50")]
	[BurstCompile]
	public static void JFBBOEIMJDA([Out] float3 ODDNJGIBGEG, ushort IPDFPMGEIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EDA0", Offset = "0x6A2D9A0", VA = "0x186A2EDA0")]
	[BurstCompile]
	public static ushort BOJKDKPHFPA([In] float3 MPEGLOLDJBC)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct KGEGIFCFGPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 IKFOCKOFOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 LMJIJFLGJLE;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class CDCFJNEIBHH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<KGEGIFCFGPH> FFOMHMNFAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> ENDKEFNMMFF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IIDHCPMGDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HMFFBCMKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x867CE0", Offset = "0x8668E0", VA = "0x180867CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A31920", Offset = "0x6A30520", VA = "0x186A31920")]
	public CDCFJNEIBHH(int AEJDPIGCGMA, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A317E0", Offset = "0x6A303E0", VA = "0x186A317E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6A31840", Offset = "0x6A30440", VA = "0x186A31840")]
	public void OGNDIGPFEIJ(CDCFJNEIBHH NCCPIOEHDGM, int DMIGMFPOLGF, int IPBPNCHALEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FOABEHICGPC
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static CDCFJNEIBHH LPFHPOAJKBO;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<AEHODIEIPAO> IANGJJMJHAO;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] OCBLDLCNEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool JOOADLHOFIL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, CDCFJNEIBHH> JNFDDJMADBB;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, CDCFJNEIBHH> GELDHJFODNG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool FPPILJPPKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C890", Offset = "0x6A3B490", VA = "0x186A3C890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<AEHODIEIPAO> LCCMEJDBJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C2E0", Offset = "0x6A3AEE0", VA = "0x186A3C2E0")]
		get
		{
			return default(NativeList<AEHODIEIPAO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static CDCFJNEIBHH KECPEKIFABC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C240", Offset = "0x6A3AE40", VA = "0x186A3C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C910", Offset = "0x6A3B510", VA = "0x186A3C910")]
	private static void NFKHMDBCBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BEF0", Offset = "0x6A3AAF0", VA = "0x186A3BEF0")]
	public static int HPHGLAMPKLK(bool PCFIAMAHFPI, int EFANHPFMDGB, bool GAHHMMDFNNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C440", Offset = "0x6A3B040", VA = "0x186A3C440")]
	private static int LJAOGMOJCJH(int EFANHPFMDGB, bool FLKEOOLMLIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BE70", Offset = "0x6A3AA70", VA = "0x186A3BE70")]
	private static int FIHJMMODGCK(int EFANHPFMDGB, bool FLKEOOLMLIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C3A0", Offset = "0x6A3AFA0", VA = "0x186A3C3A0")]
	public static int KGOONDKOBAH(int CIFJEOHPONH, int EFANHPFMDGB, int FLPLCPABKPD, bool FLKEOOLMLIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CF70", Offset = "0x6A3BB70", VA = "0x186A3CF70")]
	public static int OEGKDMIIPFN(int CIFJEOHPONH, int EFANHPFMDGB, int FLPLCPABKPD, bool FLKEOOLMLIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C430", Offset = "0x6A3B030", VA = "0x186A3C430")]
	public static int KKJAIGCPHFD(int FLPLCPABKPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CF60", Offset = "0x6A3BB60", VA = "0x186A3CF60")]
	private static int NOFACJLGDDE(int EFANHPFMDGB, bool FLKEOOLMLIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C380", Offset = "0x6A3AF80", VA = "0x186A3C380")]
	private static int KAGCNMBAMLI(int EFANHPFMDGB, bool FLKEOOLMLIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BE80", Offset = "0x6A3AA80", VA = "0x186A3BE80")]
	public static int GKNIBIJNJMK(int CIFJEOHPONH, int EFANHPFMDGB, int FLPLCPABKPD, bool FLKEOOLMLIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C1B0", Offset = "0x6A3ADB0", VA = "0x186A3C1B0")]
	public static int JBPFONFDEDE(int CIFJEOHPONH, int EFANHPFMDGB, int FLPLCPABKPD, bool FLKEOOLMLIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BE50", Offset = "0x6A3AA50", VA = "0x186A3BE50")]
	public static int EDJLPDKOOLL(int FLPLCPABKPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C460", Offset = "0x6A3B060", VA = "0x186A3C460")]
	public static CDCFJNEIBHH LJECFMOGIEL(int EFANHPFMDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BF20", Offset = "0x6A3AB20", VA = "0x186A3BF20")]
	private static CDCFJNEIBHH IBHGANCPFLC(int EFANHPFMDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BD60", Offset = "0x6A3A960", VA = "0x186A3BD60")]
	public static CDCFJNEIBHH CCNCJIEFOLO(int EFANHPFMDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C550", Offset = "0x6A3B150", VA = "0x186A3C550")]
	private static CDCFJNEIBHH MKCFDJDNCMF(int EFANHPFMDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D000", Offset = "0x6A3BC00", VA = "0x186A3D000")]
	public static void OLIEFEFFPFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct EGJLDJMNHPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int ONDCDFILHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 BHEOLFKIENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion FNOFIAKGHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float MOHCDBHEANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float FKKBMFGIPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int HGAKPOFCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int LNDJCPFPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int HBEKOIDAFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool EEJCOGIMPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool DJPIMOHGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float BLDNNLCIHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 BIMKJEINADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool JDBMCCLHAFJ;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct GGLPGFLEEKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int HLHNLLKPEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int IKODAFBMNCB;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct BONDIJCFHPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<EGJLDJMNHPN> EKEPINENKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<KHHNONIILDN> AHANNDBDHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<AEHODIEIPAO> KPBJJAOGBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<GGLPGFLEEKG> FLAFEDLMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A316B0", Offset = "0x6A302B0", VA = "0x186A316B0")]
	public BONDIJCFHPA(NativeArray<KHHNONIILDN> AHANNDBDHAO, int INGCLKPLIOP = 1, Allocator MJBDBDLLDBK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6A315C0", Offset = "0x6A301C0", VA = "0x186A315C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct PNJCBNKBCIP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<KGEGIFCFGPH> CABFCMDJCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> AHGGENAFGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<AEHODIEIPAO> BFMDEIHDGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<EGJLDJMNHPN> EKEPINENKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<KHHNONIILDN> AHANNDBDHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<AEHODIEIPAO> KPBJJAOGBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<GGLPGFLEEKG> FLAFEDLMHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int EDBLHEHDFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int GJIBHIGHLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 JCIEDKJODHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion OLFBLOOAGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 DMDHKECJFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MNBNBOHGNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JNGKKFCAMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> OFMKLFIEPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NMAOPMDNMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MOCNNOAFPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> ODKLCFICLJL;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C1D0", Offset = "0x6A4ADD0", VA = "0x186A4C1D0")]
	public PNJCBNKBCIP(HMDGCEHBKLI HKIGHGKNAPI, CDNBEALFEJM MLCNBDAPMLE, float3 LCFIPFPJAKN, quaternion NLEAMKMEKAL, float NGFEIEPCFEE, int HHEPFABPGDO = 0, int JIKFIOHFLHM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C460", Offset = "0x6A4B060", VA = "0x186A4C460")]
	public PNJCBNKBCIP(BONDIJCFHPA HKIGHGKNAPI, CDNBEALFEJM MLCNBDAPMLE, float3 LCFIPFPJAKN, quaternion NLEAMKMEKAL, float3 NGFEIEPCFEE, int HHEPFABPGDO = 0, int JIKFIOHFLHM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C020", Offset = "0x6A4AC20", VA = "0x186A4C020")]
	private float3 INMLOHGAIOG(float3 ONNGNCFEFNL, Matrix4x4 EFCELGCGOPA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C150", Offset = "0x6A4AD50", VA = "0x186A4C150")]
	private float3x3 KPMCDEAHJON(float3x3 IAHIEPMKDJK, float3x3 ENDABALJPOK)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A250", Offset = "0x6A48E50", VA = "0x186A4A250")]
	private float CBPOFBKAFPC(float DANMJNNJDHD, float LEOGPBNGCPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6A4AD10", Offset = "0x6A49910", VA = "0x186A4AD10", Slot = "4")]
	public void Execute(int BBKKKIFBKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BEB0", Offset = "0x6A4AAB0", VA = "0x186A4BEB0")]
	private void FFIJKBOADML(int FILKKBFKOKG, float3 DCDKACDAEIJ, float3 BCLJLGDCOIN, float3 EOHCNGJBAGC, float KBOADMDLFLD, bool JEKHLHAFFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A8B0", Offset = "0x6A494B0", VA = "0x186A4A8B0")]
	private void EIPKHKGFDOF(EGJLDJMNHPN IKAJPADJKMM, float3 DEKDOALHJMJ, float3x3 CPJEMABJFPA, float DANMJNNJDHD, int MHFJJMCMEMG, int HPALFCNPMPJ, int EMGKDAAMFAI, float MKKFBPKDMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A260", Offset = "0x6A48E60", VA = "0x186A4A260")]
	private void CELEKCLPJBF(int FILKKBFKOKG, int KOBDHKDFGJC, EGJLDJMNHPN IKAJPADJKMM, float3 DEKDOALHJMJ, float3x3 CPJEMABJFPA, bool FACGONCFBLB, float DANMJNNJDHD, int LJKHNMBCDHC, int OHDHJFNAIIC, int EMGKDAAMFAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct FFMKBBCCNAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<NEHBKPADDIP> GDHFFLFBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<AEHODIEIPAO> FDNFKADABOO;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B470", Offset = "0x6A3A070", VA = "0x186A3B470")]
	public FFMKBBCCNAD(int INGCLKPLIOP, Allocator MJBDBDLLDBK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B3D0", Offset = "0x6A39FD0", VA = "0x186A3B3D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct LMANBFNOJEG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum MFMGHFHMHNN
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		X,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<float3> HPHKJDMMEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> CAADBNLLEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> NBKOGHGELEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> NIHBDFKKBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> CKHMBDHOGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> AAKDHCOPBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> EHKHNIPCOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> DLNBFBHCAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<AEHODIEIPAO> COMAEEMPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<NEHBKPADDIP> GDHFFLFBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<AEHODIEIPAO> FDNFKADABOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int EDBLHEHDFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int GJIBHIGHLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MNBNBOHGNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JNGKKFCAMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> OFMKLFIEPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NMAOPMDNMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MOCNNOAFPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> ODKLCFICLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 DMDHKECJFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion OLFBLOOAGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 JCIEDKJODHP;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6A463B0", Offset = "0x6A44FB0", VA = "0x186A463B0")]
	public LMANBFNOJEG(HMDGCEHBKLI HKIGHGKNAPI, CDNBEALFEJM MLCNBDAPMLE, float3 LCFIPFPJAKN, quaternion NLEAMKMEKAL, float NGFEIEPCFEE, int HHEPFABPGDO = 0, int JIKFIOHFLHM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6A461C0", Offset = "0x6A44DC0", VA = "0x186A461C0")]
	public LMANBFNOJEG(FFMKBBCCNAD JGFKFMMOAJO, CDNBEALFEJM MLCNBDAPMLE, float3 LCFIPFPJAKN, quaternion NLEAMKMEKAL, float3 NGFEIEPCFEE, int HHEPFABPGDO = 0, int JIKFIOHFLHM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A44DB0", Offset = "0x6A439B0", VA = "0x186A44DB0", Slot = "4")]
	public void Execute(int BBKKKIFBKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A45D10", Offset = "0x6A44910", VA = "0x186A45D10")]
	private void FNFBBLMCLOL(float4x4 BPDOKMNIFOK, int BBKKKIFBKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A460C0", Offset = "0x6A44CC0", VA = "0x186A460C0")]
	private MFMGHFHMHNN IELKKHLLBIC(float3 BCLJLGDCOIN)
	{
		return default(MFMGHFHMHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A46130", Offset = "0x6A44D30", VA = "0x186A46130")]
	private float4 IFADNABPPMD(MFMGHFHMHNN ECLHPGAGHPP, int BAEBMIBABAE)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A46180", Offset = "0x6A44D80", VA = "0x186A46180")]
	private float2 KCHCLMCOJJP(MFMGHFHMHNN ECLHPGAGHPP, float3 DCDKACDAEIJ)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct EIJCLCCPLFP
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum GDELLCCMNDC
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static EIJCLCCPLFP ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 MMKDAECKHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 BHKKDEGOAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 FODIPBCKAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public GDELLCCMNDC DOJGHAOJFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 KLNNJEIBKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 PGJFJMMEGCP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PHIOAAOKLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A1C0", Offset = "0x6A38DC0", VA = "0x186A3A1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 IFNMGPODDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A1D0", Offset = "0x6A38DD0", VA = "0x186A3A1D0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A320", Offset = "0x6A38F20", VA = "0x186A3A320")]
	public EIJCLCCPLFP(float3 DCDKACDAEIJ, quaternion GPEICHFGELO, float3 INGCLKPLIOP, GDELLCCMNDC HGPIKDLKBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A39C20", Offset = "0x6A38820", VA = "0x186A39C20")]
	public float LANNMPFCOAJ(float3 DEKDOALHJMJ, float GHBGPOCFCIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A39FD0", Offset = "0x6A38BD0", VA = "0x186A39FD0")]
	public bool MMELMMGJJDO(float3 BCLJLGDCOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A39E20", Offset = "0x6A38A20", VA = "0x186A39E20")]
	public void LNIIAJJJGNB(float3 NFNDNAKCMHK, float3x3 HIFIMFCNODL, float FPIOOKIKFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A0C0", Offset = "0x6A38CC0", VA = "0x186A3A0C0")]
	private void MOHFKCDJFPD(float3 HCMICLBLHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A39990", Offset = "0x6A38590", VA = "0x186A39990")]
	public void CPDAIMIGGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct GCBDOMNOLND : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<EIJCLCCPLFP> JGFKFMMOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> DEIJPBFFJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> FLCNPAEHCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DNBHALCAPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<AEHODIEIPAO> FDNFKADABOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int ANMBHOGMKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int FHEHPMJPPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float GHBGPOCFCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float FMNLLKBEMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> DJMDAIFLJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> BIKBLLGACIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> BENGHNCOGKH;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E020", Offset = "0x6A3CC20", VA = "0x186A3E020")]
	public GCBDOMNOLND(CDNBEALFEJM KBGHMNKGJFA, float CINBALDKJDE, int IPBPNCHALEF, int MHFJJMCMEMG, NativeList<EIJCLCCPLFP> JGFKFMMOAJO, NativeArray<int> DNBHALCAPPF, NativeList<AEHODIEIPAO> FDNFKADABOO, AFOONMEPKGI GCCNCOHLDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D640", Offset = "0x6A3C240", VA = "0x186A3D640", Slot = "4")]
	public void Execute(int EIFOKFLMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D580", Offset = "0x6A3C180", VA = "0x186A3D580")]
	private bool CBHEALOJKGM(EIJCLCCPLFP PFJBMEMCGDE, EIJCLCCPLFP GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DD80", Offset = "0x6A3C980", VA = "0x186A3DD80")]
	private bool LPOLLDCNHBC(EIJCLCCPLFP JBCGPIDEDFO, int ADMKEIDNMLG, int HIFJMACMHIC, int NLHCMOIMOHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class AFOONMEPKGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> DOPCEOIJPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> OIIDHHJGNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> PLKDGFBDBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> DAENBGHAGAM;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A312A0", Offset = "0x6A2FEA0", VA = "0x186A312A0")]
	public void MHHJAOMFNPH(int AEJDPIGCGMA, int LBNGFGNJGNL, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A31280", Offset = "0x6A2FE80", VA = "0x186A31280")]
	public static long KAMDOCHKFFA(int AEJDPIGCGMA, int LBNGFGNJGNL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A310A0", Offset = "0x6A2FCA0", VA = "0x186A310A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A31190", Offset = "0x6A2FD90", VA = "0x186A31190")]
	public void JPLCCCCJMFH(JobHandle HDLKHHLCLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public AFOONMEPKGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct IELDLEDCIIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> DEIJPBFFJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> DLDPCHMBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> PHJGOMGKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> BAOIFICJNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> FLCNPAEHCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JGOLKFPHFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> FEFBLFBAPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> DJMDAIFLJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> BIKBLLGACIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int HHEPFABPGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int JIKFIOHFLHM;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A42AA0", Offset = "0x6A416A0", VA = "0x186A42AA0")]
	public IELDLEDCIIJ(CDNBEALFEJM KBGHMNKGJFA, AFOONMEPKGI GCCNCOHLDFK, int JIKFIOHFLHM = 0, int HHEPFABPGDO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A42660", Offset = "0x6A41260", VA = "0x186A42660", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A42A40", Offset = "0x6A41640", VA = "0x186A42A40")]
	private void NFAIMAGNOOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class JPLGHGBHKLH
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1D70", Offset = "0x2BA0970", VA = "0x182BA1D70")]
	public static bool ACLLEHENKJG<T>(NativeArray<T> DKCMKELIAPN, int INGCLKPLIOP, Allocator MJBDBDLLDBK, NativeArrayOptions GAANPFIMDCL = NativeArrayOptions.ClearMemory, int NNBGHGDMPOH = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1ED0", Offset = "0x2BA0AD0", VA = "0x182BA1ED0")]
	public static bool ACLLEHENKJG<T>(NativeList<T> ELBBNOKMNCJ, int INGCLKPLIOP, Allocator MJBDBDLLDBK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum OHPKDEMKBHA
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface FOABFEINJNH
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int APMEBKDJIHK(OHPKDEMKBHA CIFJEOHPONH);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LOKCHGBPCEG(OHPKDEMKBHA CIFJEOHPONH);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds IOMPEMCEKBG();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float JCFNGGNOEGB();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLFJKBEHNHK(OHPKDEMKBHA CIFJEOHPONH, HMDGCEHBKLI ILNKLMEOCKH, int JFKAJJHHHAL = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class CDNBEALFEJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum KCNGLIBKFBP
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		NormTanF16MatUi8,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct FPCGPKEGFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public KCNGLIBKFBP HCFPFEPBAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool FDEOICIFFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int CKIGJHHBBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] CGGMFHCDPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct AEBNGOOMABH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 DCDKACDAEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 BCLJLGDCOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 EOHCNGJBAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 IILFIADBJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 PHJGOMGKOHI;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] CGGMFHCDPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct GCFNHEDLJNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 DCDKACDAEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 BCLJLGDCOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 EOHCNGJBAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 IILFIADBJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 PHJGOMGKOHI;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] CGGMFHCDPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct MDLLHGHFFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 DCDKACDAEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 BCLJLGDCOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 EOHCNGJBAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 IILFIADBJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint PHJGOMGKOHI;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] CGGMFHCDPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct PFDJEGKHEIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 DCDKACDAEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint BCLJLGDCOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint EOHCNGJBAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 IILFIADBJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 PHJGOMGKOHI;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] CGGMFHCDPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct NIABMGAPGGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 DCDKACDAEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint BCLJLGDCOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint EOHCNGJBAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 IILFIADBJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 PHJGOMGKOHI;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] CGGMFHCDPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int APAAENCLENF(float KIGIELEFAKI);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class JIJPADGEGOL
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A60710", Offset = "0x6A5F310", VA = "0x186A60710")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A60B60", Offset = "0x6A5F760", VA = "0x186A60B60")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A60840", Offset = "0x6A5F440", VA = "0x186A60840")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A608F0", Offset = "0x6A5F4F0", VA = "0x186A608F0")]
		public static int HEONFGBJNMF(float KIGIELEFAKI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint DOLPBKAODFE([In] float4 CCBJGKKCAKF);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class LPKDPHHDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A62160", Offset = "0x6A60D60", VA = "0x186A62160")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A62680", Offset = "0x6A61280", VA = "0x186A62680")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A62290", Offset = "0x6A60E90", VA = "0x186A62290")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A62340", Offset = "0x6A60F40", VA = "0x186A62340")]
		public static uint HEONFGBJNMF([In] float4 CCBJGKKCAKF)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint CIGBAFGIAGK([In] float3 CCBJGKKCAKF);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class IHEIPMLILAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6A60150", Offset = "0x6A5ED50", VA = "0x186A60150")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6A605B0", Offset = "0x6A5F1B0", VA = "0x186A605B0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6A60280", Offset = "0x6A5EE80", VA = "0x186A60280")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6A60330", Offset = "0x6A5EF30", VA = "0x186A60330")]
		public static uint HEONFGBJNMF([In] float3 CCBJGKKCAKF)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void DNANFOHBACI([NoAlias] PFDJEGKHEIP* MILPOLGFMKB, int CHFINOAHILG, [In][NoAlias] float3* ONOJCPMFEIG, [In][NoAlias] float3* DLDPCHMBJID, [In][NoAlias] float4* JGOLKFPHFMH, [In][NoAlias] float2* BAOIFICJNJM, [In][NoAlias] float4* PHJGOMGKOHI);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class MGFJMFDBGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6A62990", Offset = "0x6A61590", VA = "0x186A62990")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6A62DB0", Offset = "0x6A619B0", VA = "0x186A62DB0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6A62AC0", Offset = "0x6A616C0", VA = "0x186A62AC0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A62B70", Offset = "0x6A61770", VA = "0x186A62B70")]
		public unsafe static void HEONFGBJNMF([NoAlias] PFDJEGKHEIP* MILPOLGFMKB, int CHFINOAHILG, [In][NoAlias] float3* ONOJCPMFEIG, [In][NoAlias] float3* DLDPCHMBJID, [In][NoAlias] float4* JGOLKFPHFMH, [In][NoAlias] float2* BAOIFICJNJM, [In][NoAlias] float4* PHJGOMGKOHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void AFHMINIHHJL([NoAlias] NIABMGAPGGG* MILPOLGFMKB, int CHFINOAHILG, [In][NoAlias] float3* ONOJCPMFEIG, [In][NoAlias] float3* DLDPCHMBJID, [In][NoAlias] float4* JGOLKFPHFMH, [In][NoAlias] float2* BAOIFICJNJM, [In][NoAlias] float4* PHJGOMGKOHI);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class NPFHPDEAHFF
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6A630C0", Offset = "0x6A61CC0", VA = "0x186A630C0")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6A634E0", Offset = "0x6A620E0", VA = "0x186A634E0")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6A631F0", Offset = "0x6A61DF0", VA = "0x186A631F0")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6A632A0", Offset = "0x6A61EA0", VA = "0x186A632A0")]
		public unsafe static void HEONFGBJNMF([NoAlias] NIABMGAPGGG* MILPOLGFMKB, int CHFINOAHILG, [In][NoAlias] float3* ONOJCPMFEIG, [In][NoAlias] float3* DLDPCHMBJID, [In][NoAlias] float4* JGOLKFPHFMH, [In][NoAlias] float2* BAOIFICJNJM, [In][NoAlias] float4* PHJGOMGKOHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int IANEFNCLNPC = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> FKACKIFLHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> IJHNMMFJHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> PBBOLFPCDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> HOIGHFKCLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> GOPIEPDJMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> HOEMNGHEIMC;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] DKIBEENLCND;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool OEBAMADBBJH;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static FPCGPKEGFBF[] MBADCNMPDEC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IEKHLJNNNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A9A0", Offset = "0x6A595A0", VA = "0x186A5A9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IIDHCPMGDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B5C0", Offset = "0x6A5A1C0", VA = "0x186A5B5C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HMFFBCMKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A9E0", Offset = "0x6A595E0", VA = "0x186A5A9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MFOFAMGPGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A740", Offset = "0x6A59340", VA = "0x186A5A740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void BGNILLCIDCI(bool MAINCFMHGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void FHNHFCNCIEA(bool MAINCFMHGMP, string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A59F30", Offset = "0x6A58B30", VA = "0x186A59F30", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B680", Offset = "0x6A5A280", VA = "0x186A5B680")]
	public void MHHJAOMFNPH(int AEJDPIGCGMA, int LBNGFGNJGNL, Allocator MJBDBDLLDBK, bool LAPILBALLCA, bool NLJLLMFKBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BEF0", Offset = "0x6A5AAF0", VA = "0x186A5BEF0")]
	public void ODEDONKIMIA(int AEJDPIGCGMA, int LBNGFGNJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B5B0", Offset = "0x6A5A1B0", VA = "0x186A5B5B0", Slot = "6")]
	public bool MDHFBNBGPMC(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C9B0", Offset = "0x6A5B5B0", VA = "0x186A5C9B0")]
	public bool PKGJAFNMMEA(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A040", Offset = "0x6A58C40", VA = "0x186A5A040")]
	public bool EGIDCEGHDBB(Mesh KBGHMNKGJFA, CDNBEALFEJM DOCLCBLNGEO, bool HBMCHBCDLPM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A594E0", Offset = "0x6A580E0", VA = "0x186A594E0")]
	public void DHLGABELDDK(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A57DC0", Offset = "0x6A569C0", VA = "0x186A57DC0")]
	public void BGLHEGINCGP(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B130", Offset = "0x6A59D30", VA = "0x186A5B130")]
	[BurstCompile]
	public static int JFPOKCAPJPO(float KIGIELEFAKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B1D0", Offset = "0x6A59DD0", VA = "0x186A5B1D0")]
	[BurstCompile]
	public static uint JFPOKCAPJPO([In] float4 CCBJGKKCAKF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B180", Offset = "0x6A59D80", VA = "0x186A5B180")]
	[BurstCompile]
	public static uint JFPOKCAPJPO([In] float3 CCBJGKKCAKF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A58840", Offset = "0x6A57440", VA = "0x186A58840")]
	public void CIAHHNPMNBE(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B0B0", Offset = "0x6A59CB0", VA = "0x186A5B0B0")]
	[BurstCompile]
	private unsafe static void HCNCCEOODEL([NoAlias] PFDJEGKHEIP* MILPOLGFMKB, int CHFINOAHILG, [In][NoAlias] float3* ONOJCPMFEIG, [In][NoAlias] float3* DLDPCHMBJID, [In][NoAlias] float4* JGOLKFPHFMH, [In][NoAlias] float2* BAOIFICJNJM, [In][NoAlias] float4* PHJGOMGKOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C1E0", Offset = "0x6A5ADE0", VA = "0x186A5C1E0")]
	public void OONECANODGA(Mesh KBGHMNKGJFA, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B600", Offset = "0x6A5A200", VA = "0x186A5B600")]
	[BurstCompile]
	private unsafe static void MGNPIEHINJH([NoAlias] NIABMGAPGGG* MILPOLGFMKB, int CHFINOAHILG, [In][NoAlias] float3* ONOJCPMFEIG, [In][NoAlias] float3* DLDPCHMBJID, [In][NoAlias] float4* JGOLKFPHFMH, [In][NoAlias] float2* BAOIFICJNJM, [In][NoAlias] float4* PHJGOMGKOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CD90", Offset = "0x6A5B990", VA = "0x186A5CD90")]
	public void POAJOBLDAKF(Mesh KBGHMNKGJFA, KCNGLIBKFBP HCFPFEPBAJC, bool HBMCHBCDLPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BF70", Offset = "0x6A5AB70", VA = "0x186A5BF70")]
	public void OGNDIGPFEIJ(CDNBEALFEJM KBGHMNKGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A860", Offset = "0x6A59460", VA = "0x186A5A860")]
	public CDNBEALFEJM FEPLHPFJIDG(Allocator MJBDBDLLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C820", Offset = "0x6A5B420", VA = "0x186A5C820")]
	public long PJEFMLLINJE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C950", Offset = "0x6A5B550", VA = "0x186A5C950")]
	public static long PJEFMLLINJE(int NGLGDCBADLB, int DKFNDLBEKMM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BDF0", Offset = "0x6A5A9F0", VA = "0x186A5BDF0")]
	public static long NJIBEDNNNDC(int NGLGDCBADLB, int DKFNDLBEKMM, KCNGLIBKFBP HCFPFEPBAJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BD30", Offset = "0x6A5A930", VA = "0x186A5BD30")]
	public long NJIBEDNNNDC(KCNGLIBKFBP HCFPFEPBAJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BE90", Offset = "0x6A5AA90", VA = "0x186A5BE90")]
	public void OBNPIKBNLHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B220", Offset = "0x6A59E20", VA = "0x186A5B220")]
	public static void JHGFJMIANLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A58E80", Offset = "0x6A57A80", VA = "0x186A58E80")]
	public KCNGLIBKFBP CKBANIKIJPE()
	{
		return default(KCNGLIBKFBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A670", Offset = "0x6A59270", VA = "0x186A5A670")]
	public static (int, int) EKHGPOCFEIO(Mesh KBGHMNKGJFA)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A780", Offset = "0x6A59380", VA = "0x186A5A780")]
	public static int FELFANAPGCG(VertexAttributeDescriptor[] GOBIMFAJION)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BCC0", Offset = "0x6A5A8C0", VA = "0x186A5BCC0")]
	public static long NFIMGHCOAGM(Mesh KBGHMNKGJFA, int JAEGAPGPNBD, int FCKADCGAPHG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public CDNBEALFEJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AA20", Offset = "0x6A59620", VA = "0x186A5AA20")]
	[BurstCompile]
	public static int FONPCOEGGFN(float KIGIELEFAKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AAC0", Offset = "0x6A596C0", VA = "0x186A5AAC0")]
	[BurstCompile]
	public static uint FONPCOEGGFN([In] float4 CCBJGKKCAKF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AC50", Offset = "0x6A59850", VA = "0x186A5AC50")]
	[BurstCompile]
	public static uint FONPCOEGGFN([In] float3 CCBJGKKCAKF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AD00", Offset = "0x6A59900", VA = "0x186A5AD00")]
	[BurstCompile]
	public unsafe static void GAFJLDBAELP([NoAlias] PFDJEGKHEIP* MILPOLGFMKB, int CHFINOAHILG, [In][NoAlias] float3* ONOJCPMFEIG, [In][NoAlias] float3* DLDPCHMBJID, [In][NoAlias] float4* JGOLKFPHFMH, [In][NoAlias] float2* BAOIFICJNJM, [In][NoAlias] float4* PHJGOMGKOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B870", Offset = "0x6A5A470", VA = "0x186A5B870")]
	[BurstCompile]
	public unsafe static void MLCGOOMECHH([NoAlias] NIABMGAPGGG* MILPOLGFMKB, int CHFINOAHILG, [In][NoAlias] float3* ONOJCPMFEIG, [In][NoAlias] float3* DLDPCHMBJID, [In][NoAlias] float4* JGOLKFPHFMH, [In][NoAlias] float2* BAOIFICJNJM, [In][NoAlias] float4* PHJGOMGKOHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class HICDDFKLKFH
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6A60000", Offset = "0x6A5EC00", VA = "0x186A60000")]
	public static void OLIEFEFFPFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class LLMDDIBLCDA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> FKACKIFLHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> IJHNMMFJHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> EJDCHEJBJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> MKOEPHBNBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> ENJIIHECKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> PCGHAJBCOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> NKMNKAMCCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> HOEMNGHEIMC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IIDHCPMGDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6A61860", Offset = "0x6A60460", VA = "0x186A61860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HMFFBCMKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6A60E10", Offset = "0x6A5FA10", VA = "0x186A60E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NIOIEKFMHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6A60CC0", Offset = "0x6A5F8C0", VA = "0x186A60CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6A61BA0", Offset = "0x6A607A0", VA = "0x186A61BA0")]
	public LLMDDIBLCDA(int AEJDPIGCGMA, int LBNGFGNJGNL, int FIGPAIHBMGC, Allocator MJBDBDLLDBK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6A61E70", Offset = "0x6A60A70", VA = "0x186A61E70")]
	public LLMDDIBLCDA(Mesh KBGHMNKGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6A60D00", Offset = "0x6A5F900", VA = "0x186A60D00", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6A618A0", Offset = "0x6A604A0", VA = "0x186A618A0")]
	public void OGNDIGPFEIJ(LLMDDIBLCDA KBGHMNKGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6A613D0", Offset = "0x6A5FFD0", VA = "0x186A613D0")]
	private void KMKJKPNHEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6A60E50", Offset = "0x6A5FA50", VA = "0x186A60E50")]
	private void GDNKDEIILCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct AEHODIEIPAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int KOPBNHKNGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int IIDHCPMGDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int HOFGAFEJMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int HMFFBCMKPHB;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x1413370", Offset = "0x1411F70", VA = "0x181413370")]
	public AEHODIEIPAO(int MHFJJMCMEMG, int CHFINOAHILG, int IPBPNCHALEF, int EIONMLMCMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class FEKGMEHFPDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<AEHODIEIPAO> OHBHAMABICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8DA100", Offset = "0x8D8D00", VA = "0x1808DA100")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<AEHODIEIPAO>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9B60E0", Offset = "0x9B4CE0", VA = "0x1809B60E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LLMDDIBLCDA MFPFLGKFAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F8B0", Offset = "0x6A5E4B0", VA = "0x186A5F8B0")]
	public FEKGMEHFPDL(IEnumerable<LLMDDIBLCDA> AIPKFIAODKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F840", Offset = "0x6A5E440", VA = "0x186A5F840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum OIDJADAGJLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class BHENDECIMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> CEPACDHLPCA;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> MPEPJLKMMNK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> KGBDANHBNJK;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> PPENDCAKKDB;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6A57B00", Offset = "0x6A56700", VA = "0x186A57B00")]
	public static void OLIEFEFFPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6A57C20", Offset = "0x6A56820", VA = "0x186A57C20")]
	public static NativeArray<float2> POEGJNFLHAH(NativeArray<float2> NAJJLNPGPNA, int GDMPCDBOLKD, NativeArray<float2> NONNGPLCFKC, int JOCEHOGBDOD)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6A578E0", Offset = "0x6A564E0", VA = "0x186A578E0")]
	public static NativeArray<float3> HICLDPKOAKJ(NativeArray<float3> NAJJLNPGPNA, int GDMPCDBOLKD, NativeArray<float3> NONNGPLCFKC, int JOCEHOGBDOD)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6A577D0", Offset = "0x6A563D0", VA = "0x186A577D0")]
	public static NativeArray<float4> DPFMCNLPKBK(NativeArray<float4> NAJJLNPGPNA, int GDMPCDBOLKD, NativeArray<float4> NONNGPLCFKC, int JOCEHOGBDOD)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6A579F0", Offset = "0x6A565F0", VA = "0x186A579F0")]
	public static NativeArray<int> NLINHCCNCOF(NativeArray<int> NAJJLNPGPNA, int GDMPCDBOLKD, NativeArray<int> NONNGPLCFKC, int JOCEHOGBDOD)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x28F54F0", Offset = "0x28F40F0", VA = "0x1828F54F0")]
	private static void PGJBGDAMFBN<T>(NativeArray<T> DKCMKELIAPN, int AIOBHJLEKMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x28F5410", Offset = "0x28F4010", VA = "0x1828F5410")]
	private static void NFEHDLDNLLJ<T>(NativeArray<T> NAJJLNPGPNA, int GDMPCDBOLKD, NativeArray<T> NONNGPLCFKC, int JOCEHOGBDOD, NativeArray<T> EMPHMBNALKN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class AJFDPJLJBEO
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum EJMJIAFBIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class CDJHKDDLEAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public DHGELDLIMNE KBGHMNKGJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int FAGMNKBMIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int CMFLEMFKMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long GFDINFPJFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long KLEGELHLMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float DGODILGHFKK;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6A57D70", Offset = "0x6A56970", VA = "0x186A57D70")]
		public CDJHKDDLEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6A57D30", Offset = "0x6A56930", VA = "0x186A57D30")]
		public void JPLCCCCJMFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string KNEFAOJNLPA;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string IBCNNBIODAM;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker DNAGIHHGJFA;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker FBLKOJLDFBC;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker DONJKNNPEKG;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker HOAPDNLHJBO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker HIMMIFMMHOF;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker AJLMEABLNNJ;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker ELEHHLGKGMD;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker CHCPOPOJMLL;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker HKHPDDDGBCB;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker MGPJKJFGGOM;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker KJLBPCKPNKK;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker FPGFJHCGAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<FOABFEINJNH> MMKCOHHNKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly BLCDLKBIDPC DLHNGALBBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int CHFINOAHILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int EIONMLMCMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool MMNNKCDEJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool BDFMICOLIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal EJMJIAFBIHM FFBJIDDDHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool FNOICAHNGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 DHLHJMHABLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 PAAPAKBGGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float BDGNCMGMICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float MENAGDHNMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int NBBIBIKMNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int HKKGKLMOGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int JNFBNECMJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int HDBCGDJAFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float PNNDFOEBGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float HNHGKCLPPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int NLAJPNEAIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long KEAJDEPECDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long FGAKKLLJBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long GJDNCICKJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int AGKMCJKHGPF;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int KAOGHNPPGIC = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] FCNJNIGGIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] FDBFENCBION;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] IHLFKPHGELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private CDNBEALFEJM IJGHBENBDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long DPIAEHGGLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long NPGNHOALDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int MBPGOEKOMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<CDJHKDDLEAO> KDCCPBFDKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float GEFNBFOCFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal CDNBEALFEJM.KCNGLIBKFBP BLKDPAGDKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool ABFJOECNEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private DJDKLLBLIEI BNGACDJGMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle ILNINACHEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> CMDJDNMEOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool IENAKJALEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle GABPOGPAKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private CDNBEALFEJM DKMDHGFGIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform BKACFCNFBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private OHPKDEMKBHA MCNNGOEMCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long NPOPJFODMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long LEJPINHPHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long LDJCLBODBAA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh MFPFLGKFAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x869EF0", Offset = "0x868AF0", VA = "0x180869EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer POIHODFFGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x867CC0", Offset = "0x8668C0", VA = "0x180867CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int FIEMPAEEJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D00", Offset = "0x8D0900", VA = "0x1808D1D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EOGNCFCPCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xC487E0", Offset = "0xC473E0", VA = "0x180C487E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int IIDHCPMGDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6A54520", Offset = "0x6A53120", VA = "0x186A54520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<FOABFEINJNH> GJMJAGMOGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void FHNHFCNCIEA(bool MAINCFMHGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void BGNILLCIDCI(bool MAINCFMHGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void FHNHFCNCIEA(bool MAINCFMHGMP, string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6A54300", Offset = "0x6A52F00", VA = "0x186A54300")]
	public void LEEACIJHKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6A56830", Offset = "0x6A55430", VA = "0x186A56830")]
	private void OGLELCJOGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6A574F0", Offset = "0x6A560F0", VA = "0x186A574F0")]
	public AJFDPJLJBEO(string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6A541D0", Offset = "0x6A52DD0", VA = "0x186A541D0")]
	public void JPLCCCCJMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6A54110", Offset = "0x6A52D10", VA = "0x186A54110")]
	public void JHIBBIEFALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6A56E60", Offset = "0x6A55A60", VA = "0x186A56E60")]
	private void PJOLHJANPDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FA60", Offset = "0x6A4E660", VA = "0x186A4FA60")]
	public void BOBHMHJADND(FOABFEINJNH MMOIPPPJMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DE60", Offset = "0x6A4CA60", VA = "0x186A4DE60")]
	public bool BBIKIGHPHAJ(FOABFEINJNH MMOIPPPJMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6A50070", Offset = "0x6A4EC70", VA = "0x186A50070")]
	public bool CPEFJACKAGC(FOABFEINJNH MMOIPPPJMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6A522C0", Offset = "0x6A50EC0", VA = "0x186A522C0", Slot = "4")]
	public virtual void GKDCJPIEEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6A53420", Offset = "0x6A52020", VA = "0x186A53420")]
	public void ILBCKECIBPO(Transform IFGLEMAFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6A51E10", Offset = "0x6A50A10", VA = "0x186A51E10")]
	private long GILJMPIENGD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6A52EF0", Offset = "0x6A51AF0", VA = "0x186A52EF0")]
	private long HKJOBOCCKDG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6A556E0", Offset = "0x6A542E0", VA = "0x186A556E0")]
	public bool NDKEMEPADBJ(Transform IFGLEMAFOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DF00", Offset = "0x6A4CB00", VA = "0x186A4DF00")]
	public bool BCJJKNIAIMM(bool BFHDLHEKMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A56C70", Offset = "0x6A55870", VA = "0x186A56C70")]
	public void ONHJKMJALAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6A500D0", Offset = "0x6A4ECD0", VA = "0x186A500D0")]
	public bool DJPJOHFHPJB(float4x4 GFONEHJLJDG, BatchedMeshRenderer HGJLMMKNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6A513C0", Offset = "0x6A4FFC0", VA = "0x186A513C0")]
	public void DKEFPPAOHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DB90", Offset = "0x6A4C790", VA = "0x186A4DB90")]
	public bool ABOGMDCJEKJ(bool BFHDLHEKMOO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A542F0", Offset = "0x6A52EF0", VA = "0x186A542F0")]
	public void KPCOBFHGNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A52370", Offset = "0x6A50F70", VA = "0x186A52370")]
	public void HBHNIHNDDHF(CDNBEALFEJM KBGHMNKGJFA, int JBHEKGPKMPI, int JKFLOBEDHAC, float IOBIILBJJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A54540", Offset = "0x6A53140", VA = "0x186A54540")]
	public void MEJAJIGJLOJ(DHGELDLIMNE ELNOGNHJNBP, int JBHEKGPKMPI, int JKFLOBEDHAC, float IOBIILBJJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A56DF0", Offset = "0x6A559F0", VA = "0x186A56DF0")]
	public (long, long, long) PJEFMLLINJE()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x9D34F0", Offset = "0x9D20F0", VA = "0x1809D34F0")]
	public long MINCGEAGCHG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FC30", Offset = "0x6A4E830", VA = "0x186A4FC30")]
	private void CBIHNIINENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A51EF0", Offset = "0x6A50AF0", VA = "0x186A51EF0")]
	public (long, long) GJMAHKIOEGB(float JJMDDDBBDKN, float4x4 GFONEHJLJDG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	public void NOOKFPJPLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A56710", Offset = "0x6A55310", VA = "0x186A56710")]
	internal void NFMBOEOIINE(EJMJIAFBIHM CEKIMGDAOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A53630", Offset = "0x6A52230", VA = "0x186A53630")]
	private (float, float, float) IMFCINMMBFO(float KHEMIIBLBAE, float4x4 GFONEHJLJDG)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6A53070", Offset = "0x6A51C70", VA = "0x186A53070")]
	private (int, int) IFDMILMNJIP(float DGGPIIKJFMB)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6A54570", Offset = "0x6A53170", VA = "0x186A54570")]
	public void MLINIIMGBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6A54310", Offset = "0x6A52F10", VA = "0x186A54310")]
	private void LGABEPGPDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6A54340", Offset = "0x6A52F40", VA = "0x186A54340")]
	private void LMICIBOIFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6A51630", Offset = "0x6A50230", VA = "0x186A51630")]
	public long EHODHNALABP(long BPBLPGMAAGP, int GGNHKOHGNAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F180", Offset = "0x6A4DD80", VA = "0x186A4F180")]
	private void BMDFHJEHBAL(CDNBEALFEJM HEPMEAPOAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FDD0", Offset = "0x6A4E9D0", VA = "0x186A4FDD0")]
	private void CPCFDNHKGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6A523A0", Offset = "0x6A50FA0", VA = "0x186A523A0")]
	private void HEKNGEBFEFL(CDNBEALFEJM KBGHMNKGJFA, DHGELDLIMNE ELNOGNHJNBP, int JBHEKGPKMPI, int JKFLOBEDHAC, float IOBIILBJJHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct DJDKLLBLIEI : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct GGBKFFDJJBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int DNEPIPJODAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int EIIHADLEKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int OJMMGEINNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int GMLHPKFONGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int HPCHDADONAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int IBCCLANICDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int FAGMNKBMIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int CMFLEMFKMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float DGODILGHFKK;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct PPDDOBFIDNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public OGOHJELPOMC.BDPECHFNOAE AFPDOCIOEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float BOLFIOENKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float NPOOKEHCDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float AOODHCBJNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float EOMEKGNGNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float NANPAJPAKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float JLFLBDLEBDP;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct CALEKOELLBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> FKACKIFLHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> IJHNMMFJHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> PBBOLFPCDHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> HOIGHFKCLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> GOPIEPDJMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> HOEMNGHEIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool HGOEKDCLFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int IIDHCPMGDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int HMFFBCMKPHB;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6A696B0", Offset = "0x6A682B0", VA = "0x186A696B0")]
		public void MHHJAOMFNPH(int AEJDPIGCGMA, int LBNGFGNJGNL, Allocator MJBDBDLLDBK, bool NLJLLMFKBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6A693A0", Offset = "0x6A67FA0", VA = "0x186A693A0")]
		public static CALEKOELLBF GCJGKLCCKNA(CDNBEALFEJM IOFJKAICIIH)
		{
			return default(CALEKOELLBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6A695F0", Offset = "0x6A681F0", VA = "0x186A695F0")]
		public void JPLCCCCJMFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker NHANBPNAAPF;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker COGAHGDCKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<GGBKFFDJJBA> PAOMAMFJLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private CALEKOELLBF FHCPCOMHJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private CALEKOELLBF HEPMEAPOAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 AIJCPFJGHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 LJOBDFCIKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private PPDDOBFIDNI IANCHOOFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* FCFPNNEGNFG;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	[BurstDiscard]
	private static void FHNHFCNCIEA(bool MAINCFMHGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	[BurstDiscard]
	private static void BGNILLCIDCI(bool MAINCFMHGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	[BurstDiscard]
	private static void FHNHFCNCIEA(bool MAINCFMHGMP, string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F250", Offset = "0x6A5DE50", VA = "0x186A5F250")]
	public DJDKLLBLIEI([In] List<AJFDPJLJBEO.CDJHKDDLEAO> NIDBKMFHABP, [In] CDNBEALFEJM LLNOIONMNAD, [In] AJFDPJLJBEO LJJBDCBFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D8D0", Offset = "0x6A5C4D0", VA = "0x186A5D8D0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D250", Offset = "0x6A5BE50", VA = "0x186A5D250")]
	public void BLHAHHKHNMH(List<AJFDPJLJBEO.CDJHKDDLEAO> PHMDDKEKHIG, [In] AJFDPJLJBEO LJJBDCBFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D230", Offset = "0x6A5BE30", VA = "0x186A5D230")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool BEFOGMLMGFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D920", Offset = "0x6A5C520", VA = "0x186A5D920")]
	private DHGELDLIMNE FEDHFMBOLMP(int PPKDCEBHHCB, Allocator MJBDBDLLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DD60", Offset = "0x6A5C960", VA = "0x186A5DD60")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void LMBNBMMPAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D9F0", Offset = "0x6A5C5F0", VA = "0x186A5D9F0")]
	[IgnoreWarning(1371)]
	private GGBKFFDJJBA FODAAFIBHBC([In] GGBKFFDJJBA COMHKJHBFDD, int PHFLDHOMJGO, [In] NativeArray<int> FLCNPAEHCMG, [In] NativeArray<bool> BIKBLLGACIP, NativeArray<int> ENGGJOFGOKI)
	{
		return default(GGBKFFDJJBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5F0B0", Offset = "0x6A5DCB0", VA = "0x186A5F0B0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int PINLGMOCHGP(NativeArray<int> FLCNPAEHCMG, int KDNNABCJNGH, int KGADKAOBIMM, int OHFBPOCCFCA)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly EEGEMFOKJOP log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker FLKFOKCDIGA;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker AHBBLALJGAA;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker KCKIGIDCEHN;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker EDLCEHFGOFK;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker OPICBHAKMDF;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker HIMMIFMMHOF;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker EDKELEOLKHG;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int PLNJDGNDAPH = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Dictionary<Material, List<AJFDPJLJBEO>> NOMMJKGMHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<AJFDPJLJBEO> NCAFJAHEDNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> JBBCAHIPBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool JLKEFPKCJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool GPPDMJBOBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int MAMFDBFBGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> ENCHHJFIGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> JHIPDPBIJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> HELABLICEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> KCOAJBMAHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private AJFDPJLJBEO EKDHKOGANCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material EGMEPPJBFBJ;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int DJEHDIPEPLC = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, FOABFEINJNH)> AIFCEINADBP;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> ONMFLNMIHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int OOODOPHFHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x6A69350", Offset = "0x6A67F50", VA = "0x186A69350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		private static void FHNHFCNCIEA(bool MAINCFMHGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		private static void FHNHFCNCIEA(bool MAINCFMHGMP, string NKAJDDICLFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6A65D30", Offset = "0x6A64930", VA = "0x186A65D30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6A64A80", Offset = "0x6A63680", VA = "0x186A64A80")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6A63F80", Offset = "0x6A62B80", VA = "0x186A63F80")]
		public AJFDPJLJBEO AddToBatchedMesh(FOABFEINJNH ODLMBHGNMKD, Material DMGEDCGOKIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6A68470", Offset = "0x6A67070", VA = "0x186A68470")]
		public void RemoveFromBatchedMesh(FOABFEINJNH KBGHMNKGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6A64950", Offset = "0x6A63550", VA = "0x186A64950")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6A68C40", Offset = "0x6A67840", VA = "0x186A68C40")]
		public void SetMaterialProperty(int OJLGEGJAMDH, Color NMMFNOOBBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6A68810", Offset = "0x6A67410", VA = "0x186A68810")]
		public void SetMaterialProperty(int OJLGEGJAMDH, float IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6A68A20", Offset = "0x6A67620", VA = "0x186A68A20")]
		public void SetMaterialProperty(int OJLGEGJAMDH, Vector4 GELKPFPPBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6A685B0", Offset = "0x6A671B0", VA = "0x186A685B0")]
		public void SetMaterialProperty(int OJLGEGJAMDH, Matrix4x4 AEANLAKOGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6A64360", Offset = "0x6A62F60", VA = "0x186A64360")]
		private void CGOJNLLADFA(Renderer PFFACGHHFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6A64C50", Offset = "0x6A63850", VA = "0x186A64C50")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6A64C40", Offset = "0x6A63840", VA = "0x186A64C40")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6A63A60", Offset = "0x6A62660", VA = "0x186A63A60")]
		private void APFDFIBFDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6A65B10", Offset = "0x6A64710", VA = "0x186A65B10")]
		private AJFDPJLJBEO NDNBNOOCELK(FOABFEINJNH KBGHMNKGJFA, Material DMGEDCGOKIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6A64080", Offset = "0x6A62C80", VA = "0x186A64080")]
		private AJFDPJLJBEO CDHJGHOJDMI(Material DMGEDCGOKIM, int OKJDOGIPHGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6A65230", Offset = "0x6A63E30", VA = "0x186A65230")]
		private AJFDPJLJBEO MOJGOAJLLMB(Material DMGEDCGOKIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x18DD8D0", Offset = "0x18DC4D0", VA = "0x1818DD8D0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6A65630", Offset = "0x6A64230", VA = "0x186A65630")]
		public void MarkDirty(FOABFEINJNH KBGHMNKGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6A65790", Offset = "0x6A64390", VA = "0x186A65790")]
		public (long, long) MemorySizeInBytesForChosenDetail(float JJMDDDBBDKN)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6A67500", Offset = "0x6A66100", VA = "0x186A67500")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6A64CF0", Offset = "0x6A638F0", VA = "0x186A64CF0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6A66020", Offset = "0x6A64C20", VA = "0x186A66020")]
		public void RebatchOptimally(int GBDONOEKAEH, int FKHLDPIAODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6A690E0", Offset = "0x6A67CE0", VA = "0x186A690E0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class OGLOLMOGGLH
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct BMDLGAMMDJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float BOCMOELLFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer DDENKBLCNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AJFDPJLJBEO BJHGDPPFJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long JGNBBBJKPNB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class EOPEEAFBGGC : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private int <batchSizeNaughty>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private int <batchSizeNice>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private int <countdownBeforeYield>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x933860", Offset = "0x932460", VA = "0x180933860", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x6A6A680", Offset = "0x6A69280", VA = "0x186A6A680", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA84B40", Offset = "0xA83740", VA = "0x180A84B40")]
		[DebuggerHidden]
		public EOPEEAFBGGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A6D0", Offset = "0x6A692D0", VA = "0x186A6A6D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A698E0", Offset = "0x6A684E0", VA = "0x186A698E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A530", Offset = "0x6A69130", VA = "0x186A6A530")]
		private void OPGOEIKMBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A69890", Offset = "0x6A68490", VA = "0x186A69890")]
		private void JMPEPBOJIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A630", Offset = "0x6A69230", VA = "0x186A6A630", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A580", Offset = "0x6A69180", VA = "0x186A6A580", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A580", Offset = "0x6A69180", VA = "0x186A6A580", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker HIMMIFMMHOF;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker BJALMLNOELF;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker OJLLFGDJGGM;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker BGFODOJHLGE;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 GFKAJHHILJI;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int NOLGGGDFJFB;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int NMMKPPAFELA;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int LBGBINCEHJE;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int KFEAAKMDALB;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int OKNKOLNOFJG;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int DPKIICMGHCC;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int DPMDCJGAPNN;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int NCJLMMOPIAG;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int HPOAJODPGOK;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int NMAELJODHIG;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int EDLKHADGFAO;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int AKIHKHLJCOL;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int PCPOPKIDBNN;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int KPJFGOOABLH;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long GJDEPNGHEOC;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long GDJGAFEMFAI;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int JGGDBFFOFOP;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int JPMBBBOBBCO;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int CHIDCFPKJPB;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long EONANMGHLKP;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool HJOBFAHJCOF;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> FDICPENHLEK;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<BMDLGAMMDJM> LLLKLIMCEFF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool OIHCEIOOOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DEE0", Offset = "0x6A6CAE0", VA = "0x186A6DEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void FHNHFCNCIEA(bool MAINCFMHGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void BGNILLCIDCI(bool MAINCFMHGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void FHNHFCNCIEA(bool MAINCFMHGMP, string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DD30", Offset = "0x6A6C930", VA = "0x186A6DD30")]
	public static void KCBMKHLALEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D980", Offset = "0x6A6C580", VA = "0x186A6D980")]
	public static void HLALLJDBGOK(BatchedMeshRenderer DFIDPLJJBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AB70", Offset = "0x6A69770", VA = "0x186A6AB70")]
	public static void DFGLGFJJJIB(BatchedMeshRenderer DFIDPLJJBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D6A0", Offset = "0x6A6C2A0", VA = "0x186A6D6A0")]
	private static (long, long, long) GHFNLKDEFJO(long PLJNGHIFIMG)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AC20", Offset = "0x6A69820", VA = "0x186A6AC20")]
	public static void DJPJOHFHPJB(long PLJNGHIFIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D300", Offset = "0x6A6BF00", VA = "0x186A6D300")]
	public static long EHODHNALABP(long BPBLPGMAAGP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E480", Offset = "0x6A6D080", VA = "0x186A6E480")]
	public static void OIOFGNAICAP(AJFDPJLJBEO BJHGDPPFJGM, BatchedMeshRenderer DDENKBLCNBJ, long JGNBBBJKPNB, float BOCMOELLFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A960", Offset = "0x6A69560", VA = "0x186A6A960")]
	public static void CEFONMMCPIJ(AJFDPJLJBEO BJHGDPPFJGM, BatchedMeshRenderer DDENKBLCNBJ, long JGNBBBJKPNB, float HPOPKHHJMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AA60", Offset = "0x6A69660", VA = "0x186A6AA60")]
	public static void DEKAPOIBFCG(AJFDPJLJBEO BJHGDPPFJGM, BatchedMeshRenderer DDENKBLCNBJ, long JGNBBBJKPNB, float HPOPKHHJMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E2D0", Offset = "0x6A6CED0", VA = "0x186A6E2D0")]
	public static void NBKDJHABJPM(AJFDPJLJBEO BJHGDPPFJGM, BatchedMeshRenderer DDENKBLCNBJ, long JGNBBBJKPNB, float BOCMOELLFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DF70", Offset = "0x6A6CB70", VA = "0x186A6DF70")]
	public static float KEBIIIGJNKG(long BKAFMNHPGEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D7B0", Offset = "0x6A6C3B0", VA = "0x186A6D7B0")]
	public static (long, long) GJMAHKIOEGB(float JJMDDDBBDKN)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E590", Offset = "0x6A6D190", VA = "0x186A6E590")]
	[IteratorStateMachine(typeof(EOPEEAFBGGC))]
	public static IEnumerable<bool> PABOJPMKFJP(long AFACPLPBGNE, bool BOFFONMEFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A7F0", Offset = "0x6A693F0", VA = "0x186A6A7F0")]
	public static void ALAAPFIPGLJ(long AFACPLPBGNE, bool BOFFONMEFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DBF0", Offset = "0x6A6C7F0", VA = "0x186A6DBF0")]
	public static int JKFPLMOKNLF()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class LFPDCGNJACB<KeyType> : AJFDPJLJBEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, FOABFEINJNH> ACBIDGIEPBD;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4258650", Offset = "0x4257250", VA = "0x184258650")]
	public LFPDCGNJACB(string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x42582D0", Offset = "0x4256ED0", VA = "0x1842582D0")]
	public void BOBHMHJADND(KeyType NCMHANGAILD, FOABFEINJNH MMOIPPPJMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x42580D0", Offset = "0x4256CD0", VA = "0x1842580D0")]
	public bool BFHKAKDCPLO(KeyType NCMHANGAILD, FOABFEINJNH ODJMICJJLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x42583A0", Offset = "0x4256FA0", VA = "0x1842583A0")]
	public void JMEEKOGJHPB(KeyType NCMHANGAILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4258340", Offset = "0x4256F40", VA = "0x184258340", Slot = "4")]
	public override void GKDCJPIEEDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E990", Offset = "0x6A6D590", VA = "0x186A6E990")]
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
