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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
	public class LogRegistrationIndex : MHGCIIOBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A27B50", Offset = "0x6A26150", VA = "0x186A27B50", Slot = "4")]
		public override void OOMCOBOGONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HGAKGMLOGGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int DMHHEHCOJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 PFBFBGCIMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion PCCOKCOFHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 FKPFMKOFLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CNCBBBNCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int JPJGHOKCIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int AGNNHDOPOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float CAADFLOJOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 NHILMGNJLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool LENDGIEICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public MPAMKPKAOII GIIBKNDOHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 KAKBLGCLHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float LEEBHLJLNGK;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PEKPLCGGHFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static FBGABEHDBDE KHCEAOJAPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<HGAKGMLOGGD> MGGPGJGLBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<NGBNIJNLBKN> JDHFLCLMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<INKFNNAJEHO> KBBCIPLKOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<GDLIEPHPIEN> ABHFOJDGILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<NGBNIJNLBKN> JPCEJOHLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<PCOJMFIKJNH> GKFNLFNLOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<GDLIEPHPIEN>> OOEHMLNFDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<AIAGMIIBJAF> FKEIOMFCKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> HFEBGJDHJLF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AFEJIIOFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEC19A0", Offset = "0xEBFFA0", VA = "0x180EC19A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEC11C0", Offset = "0xEBF7C0", VA = "0x180EC11C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DDMELFPJCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEC19B0", Offset = "0xEBFFB0", VA = "0x180EC19B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEC1310", Offset = "0xEBF910", VA = "0x180EC1310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C500", Offset = "0x6A2AB00", VA = "0x186A2C500")]
	public PEKPLCGGHFL(int NNDIIDFOFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BD50", Offset = "0x6A2A350", VA = "0x186A2BD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A7F0", Offset = "0x6A28DF0", VA = "0x186A2A7F0")]
	public void BEBGJICOPHM(JobHandle JKHDOKLDIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A9C0", Offset = "0x6A28FC0", VA = "0x186A2A9C0")]
	public void COAMNPBMLAA(HGAKGMLOGGD JHLEMCFOEMF, AIAGMIIBJAF LKPMOOGIKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BBF0", Offset = "0x6A2A1F0", VA = "0x186A2BBF0")]
	public void DNMDGCOOOFN(INKFNNAJEHO JHLEMCFOEMF, NativeArray<GDLIEPHPIEN> KENGEMLIBDP, int FAHHAAGBGJO, int LMAHIFIDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A2ABE0", Offset = "0x6A291E0", VA = "0x186A2ABE0")]
	public JobHandle DDAJINLGOIN(DJMGOGABOMJ BPALONMHDON, KBGBOEOKOAC NBNHMAAGAFF, float3 EPKKEPJFNHN, quaternion MBHEBKIGGPP, float KFJJPKBDBNM, bool DNEGEMGFFCA, int OKOIJGILEOD = 0, int HKCMNPJPGKO = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BF10", Offset = "0x6A2A510", VA = "0x186A2BF10")]
	public static JobHandle GEIFNJNPGBH(HDLMNLFHPKJ LCMPCHJEPMN, DJMGOGABOMJ BPALONMHDON, HGAKGMLOGGD JHLEMCFOEMF, JobHandle JKHDOKLDIHM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C250", Offset = "0x6A2A850", VA = "0x186A2C250")]
	public static JobHandle LLMOKFNDOOE(PNODLPKEJDK LCMPCHJEPMN, DJMGOGABOMJ BPALONMHDON, INKFNNAJEHO JHLEMCFOEMF, NativeArray<GDLIEPHPIEN> KENGEMLIBDP, int FAHHAAGBGJO, int LMAHIFIDCDO, JobHandle JKHDOKLDIHM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class FOJKGPNIEMD
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct LHHBIEMHNKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half MEGPJMNGFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort AELLEMMMOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte NDDDLJALHCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void DNFHMJPCLAE([NoAlias] float3* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class EGKJNGIBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A15740", Offset = "0x6A13D40", VA = "0x186A15740")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A15B00", Offset = "0x6A14100", VA = "0x186A15B00")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A15A60", Offset = "0x6A14060", VA = "0x186A15A60")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A15860", Offset = "0x6A13E60", VA = "0x186A15860")]
		public unsafe static void DFDLGJKGLOI([NoAlias] float3* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void ICNMAGJLMNN([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class JHDOLADLNOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A23540", Offset = "0x6A21B40", VA = "0x186A23540")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A23980", Offset = "0x6A21F80", VA = "0x186A23980")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A238E0", Offset = "0x6A21EE0", VA = "0x186A238E0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A23660", Offset = "0x6A21C60", VA = "0x186A23660")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void MICKLNNBKKG([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class LDPDIOFMABF
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A27030", Offset = "0x6A25630", VA = "0x186A27030")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A27470", Offset = "0x6A25A70", VA = "0x186A27470")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A273D0", Offset = "0x6A259D0", VA = "0x186A273D0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A27150", Offset = "0x6A25750", VA = "0x186A27150")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void NIGEPPPAMJK([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class CIJMGHOJNPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A12F30", Offset = "0x6A11530", VA = "0x186A12F30")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A13370", Offset = "0x6A11970", VA = "0x186A13370")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A132D0", Offset = "0x6A118D0", VA = "0x186A132D0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6A13050", Offset = "0x6A11650", VA = "0x186A13050")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void GGLPPAAAJMO([NoAlias] ushort* DFDNLBBDNHN, [Out] float3 PMCGPGMKAKK, [Out] float3 PKAPEKLCDDM, [In][NoAlias] float3* EEJFFOFFHDA, int DKNPIGHNGCL, int GGOJGFOPPLP);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class MJDMAMBJCDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A27CA0", Offset = "0x6A262A0", VA = "0x186A27CA0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A28070", Offset = "0x6A26670", VA = "0x186A28070")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A27FD0", Offset = "0x6A265D0", VA = "0x186A27FD0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A27DC0", Offset = "0x6A263C0", VA = "0x186A27DC0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] ushort* DFDNLBBDNHN, [Out] float3 PMCGPGMKAKK, [Out] float3 PKAPEKLCDDM, [In][NoAlias] float3* EEJFFOFFHDA, int DKNPIGHNGCL, int GGOJGFOPPLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void GPLNAAPPAOL([NoAlias] ushort* BDENIJIEJKG, [In][NoAlias] float3* ODJCCENBKDK, int GGOJGFOPPLP);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class FONFGIOIEGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C3A0", Offset = "0x6A1A9A0", VA = "0x186A1C3A0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C740", Offset = "0x6A1AD40", VA = "0x186A1C740")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C6A0", Offset = "0x6A1ACA0", VA = "0x186A1C6A0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C4C0", Offset = "0x6A1AAC0", VA = "0x186A1C4C0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] ushort* BDENIJIEJKG, [In][NoAlias] float3* ODJCCENBKDK, int GGOJGFOPPLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void ELGIPIBEJHG([NoAlias] float3* MFNMOOPJLBA, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class JINJHIEAJIB
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A23AD0", Offset = "0x6A220D0", VA = "0x186A23AD0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A23ED0", Offset = "0x6A224D0", VA = "0x186A23ED0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A23E30", Offset = "0x6A22430", VA = "0x186A23E30")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A23BF0", Offset = "0x6A221F0", VA = "0x186A23BF0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] float3* MFNMOOPJLBA, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void MDDLFJNCGBD([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class KMCHAPFHADO
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A25F40", Offset = "0x6A24540", VA = "0x186A25F40")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A262E0", Offset = "0x6A248E0", VA = "0x186A262E0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A26240", Offset = "0x6A24840", VA = "0x186A26240")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A26060", Offset = "0x6A24660", VA = "0x186A26060")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void ODHHLDKJAML([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class ALMNFEIEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A11CA0", Offset = "0x6A102A0", VA = "0x186A11CA0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A12120", Offset = "0x6A10720", VA = "0x186A12120")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A12080", Offset = "0x6A10680", VA = "0x186A12080")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A11DC0", Offset = "0x6A103C0", VA = "0x186A11DC0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void HDDODCGOKCH([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class NGFDHLMMHFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A28F20", Offset = "0x6A27520", VA = "0x186A28F20")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A29380", Offset = "0x6A27980", VA = "0x186A29380")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A292E0", Offset = "0x6A278E0", VA = "0x186A292E0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A29040", Offset = "0x6A27640", VA = "0x186A29040")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void KACPPDMGJFO([NoAlias] ushort* DJKPPDEOPEM, [Out] float2 OLADNNAIHDN, [Out] float2 KCHIPHPGPKO, [In][NoAlias] float2* ENIELAHFLPD, int DKNPIGHNGCL, int GGOJGFOPPLP);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class GLCIBPLFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FAE0", Offset = "0x6A1E0E0", VA = "0x186A1FAE0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FEB0", Offset = "0x6A1E4B0", VA = "0x186A1FEB0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FE10", Offset = "0x6A1E410", VA = "0x186A1FE10")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FC00", Offset = "0x6A1E200", VA = "0x186A1FC00")]
		public unsafe static void DFDLGJKGLOI([NoAlias] ushort* DJKPPDEOPEM, [Out] float2 OLADNNAIHDN, [Out] float2 KCHIPHPGPKO, [In][NoAlias] float2* ENIELAHFLPD, int DKNPIGHNGCL, int GGOJGFOPPLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void GBCJCKBJMGM([Out] float2 GNHDJDMJLFG, ushort MGFNICPOIII, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class ABFFLDFPDJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A10CF0", Offset = "0x6A0F2F0", VA = "0x186A10CF0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A110E0", Offset = "0x6A0F6E0", VA = "0x186A110E0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A11040", Offset = "0x6A0F640", VA = "0x186A11040")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A10E10", Offset = "0x6A0F410", VA = "0x186A10E10")]
		public static void DFDLGJKGLOI([Out] float2 GNHDJDMJLFG, ushort MGFNICPOIII, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void HJLPGHJPMLC([NoAlias] float2* DJKPPDEOPEM, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class LIFOMPDPMEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A275C0", Offset = "0x6A25BC0", VA = "0x186A275C0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A27A00", Offset = "0x6A26000", VA = "0x186A27A00")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A27960", Offset = "0x6A25F60", VA = "0x186A27960")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A276E0", Offset = "0x6A25CE0", VA = "0x186A276E0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] float2* DJKPPDEOPEM, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void NEJOAKIICIJ([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class OGFDADPCILC
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A220", Offset = "0x6A28820", VA = "0x186A2A220")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A6A0", Offset = "0x6A28CA0", VA = "0x186A2A6A0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A600", Offset = "0x6A28C00", VA = "0x186A2A600")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A340", Offset = "0x6A28940", VA = "0x186A2A340")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void DJPEGJGOMFM([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class DBJFJIGMMJI
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A13A10", Offset = "0x6A12010", VA = "0x186A13A10")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6A13E90", Offset = "0x6A12490", VA = "0x186A13E90")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A13DF0", Offset = "0x6A123F0", VA = "0x186A13DF0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A13B30", Offset = "0x6A12130", VA = "0x186A13B30")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void OLKCFAFCAII([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class LDCKFGKPKAI
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A26980", Offset = "0x6A24F80", VA = "0x186A26980")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A26EE0", Offset = "0x6A254E0", VA = "0x186A26EE0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A26E40", Offset = "0x6A25440", VA = "0x186A26E40")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A26AA0", Offset = "0x6A250A0", VA = "0x186A26AA0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void NAPOKECOOFA([NoAlias] ushort* LOEMBHIFPJH, [In][NoAlias] float4* NLHBDFCFAPM, int DKNPIGHNGCL, int GGOJGFOPPLP);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class DBIOBGBJIDD
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A134C0", Offset = "0x6A11AC0", VA = "0x186A134C0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A138C0", Offset = "0x6A11EC0", VA = "0x186A138C0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A13820", Offset = "0x6A11E20", VA = "0x186A13820")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A135E0", Offset = "0x6A11BE0", VA = "0x186A135E0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] ushort* LOEMBHIFPJH, [In][NoAlias] float4* NLHBDFCFAPM, int DKNPIGHNGCL, int GGOJGFOPPLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort BKNDECAMAHP([In] float4 KBNDGIBNMOI);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class HJAKOGFKBBB
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A23030", Offset = "0x6A21630", VA = "0x186A23030")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A233F0", Offset = "0x6A219F0", VA = "0x186A233F0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A23350", Offset = "0x6A21950", VA = "0x186A23350")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A23150", Offset = "0x6A21750", VA = "0x186A23150")]
		public static ushort DFDLGJKGLOI([In] float4 KBNDGIBNMOI)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void EAMOPBCMIID([NoAlias] float4* LOEMBHIFPJH, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class EGAMBBEOJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A151F0", Offset = "0x6A137F0", VA = "0x186A151F0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6A155F0", Offset = "0x6A13BF0", VA = "0x186A155F0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6A15550", Offset = "0x6A13B50", VA = "0x186A15550")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A15310", Offset = "0x6A13910", VA = "0x186A15310")]
		public unsafe static void DFDLGJKGLOI([NoAlias] float4* LOEMBHIFPJH, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void ELNDFOPPEEK([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class BHHHMGINEEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A12270", Offset = "0x6A10870", VA = "0x186A12270")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A12610", Offset = "0x6A10C10", VA = "0x186A12610")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A12570", Offset = "0x6A10B70", VA = "0x186A12570")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A12390", Offset = "0x6A10990", VA = "0x186A12390")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void IBIDGINNDCN([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class NAGJGPECDEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A281C0", Offset = "0x6A267C0", VA = "0x186A281C0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A28630", Offset = "0x6A26C30", VA = "0x186A28630")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A28590", Offset = "0x6A26B90", VA = "0x186A28590")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A282E0", Offset = "0x6A268E0", VA = "0x186A282E0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void DEPKLGLOPPG([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class GOFAECIKDCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A20000", Offset = "0x6A1E600", VA = "0x186A20000")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A20460", Offset = "0x6A1EA60", VA = "0x186A20460")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A203C0", Offset = "0x6A1E9C0", VA = "0x186A203C0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6A20120", Offset = "0x6A1E720", VA = "0x186A20120")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void JOBJPMNCDBA([Out] float4 JKLHKLABFHH, ushort MGFNICPOIII);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class JPICNPIBONG
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6A250B0", Offset = "0x6A236B0", VA = "0x186A250B0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6A254E0", Offset = "0x6A23AE0", VA = "0x186A254E0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A25440", Offset = "0x6A23A40", VA = "0x186A25440")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6A251D0", Offset = "0x6A237D0", VA = "0x186A251D0")]
		public static void DFDLGJKGLOI([Out] float4 JKLHKLABFHH, ushort MGFNICPOIII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void BMOALHMAMHI([NoAlias] float4* PCBHNCDJHIC, [NoAlias] byte* DAOBPAJCCMC, [Out] int NPJGNFOGMIF, [Out] int OMDBJCEEFKA, [NoAlias] float4* EDMMJICLOKG, int DKNPIGHNGCL, int GGOJGFOPPLP);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class DODHCIGKDOI
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6A140E0", Offset = "0x6A126E0", VA = "0x186A140E0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6A144B0", Offset = "0x6A12AB0", VA = "0x186A144B0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6A14410", Offset = "0x6A12A10", VA = "0x186A14410")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A14200", Offset = "0x6A12800", VA = "0x186A14200")]
		public unsafe static void DFDLGJKGLOI([NoAlias] float4* PCBHNCDJHIC, [NoAlias] byte* DAOBPAJCCMC, [Out] int NPJGNFOGMIF, [Out] int OMDBJCEEFKA, [NoAlias] float4* EDMMJICLOKG, int DKNPIGHNGCL, int GGOJGFOPPLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void HANBGHCEGGH([NoAlias] float4* LFFPEPCBAGJ, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class KBFMPLLFOIP
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A25630", Offset = "0x6A23C30", VA = "0x186A25630")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A25AD0", Offset = "0x6A240D0", VA = "0x186A25AD0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A25A30", Offset = "0x6A24030", VA = "0x186A25A30")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A25750", Offset = "0x6A23D50", VA = "0x186A25750")]
		public unsafe static void DFDLGJKGLOI([NoAlias] float4* LFFPEPCBAGJ, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void KBFLBBLAEIB([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class NMHNFNFJCID
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6A29B80", Offset = "0x6A28180", VA = "0x186A29B80")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A0D0", Offset = "0x6A286D0", VA = "0x186A2A0D0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A030", Offset = "0x6A28630", VA = "0x186A2A030")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6A29CA0", Offset = "0x6A282A0", VA = "0x186A29CA0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void HEJHGILAJMA([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class NIGBOLKABNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6A294D0", Offset = "0x6A27AD0", VA = "0x186A294D0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6A29A30", Offset = "0x6A28030", VA = "0x186A29A30")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A29990", Offset = "0x6A27F90", VA = "0x186A29990")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6A295F0", Offset = "0x6A27BF0", VA = "0x186A295F0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void KCDCPOJODFK([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class NBCCKLGAKIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6A28880", Offset = "0x6A26E80", VA = "0x186A28880")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6A28DD0", Offset = "0x6A273D0", VA = "0x186A28DD0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6A28D30", Offset = "0x6A27330", VA = "0x186A28D30")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6A289A0", Offset = "0x6A26FA0", VA = "0x186A289A0")]
		public unsafe static void DFDLGJKGLOI([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int CAKHOKNKCIO([NoAlias] byte* FCKCBKGOFBI, [In][NoAlias] int* KBANJPJCOMJ, int HGBJMIGIIDG);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class DOHCCCDBIDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6A14600", Offset = "0x6A12C00", VA = "0x186A14600")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6A14A40", Offset = "0x6A13040", VA = "0x186A14A40")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6A149A0", Offset = "0x6A12FA0", VA = "0x186A149A0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6A14720", Offset = "0x6A12D20", VA = "0x186A14720")]
		public unsafe static int DFDLGJKGLOI([NoAlias] byte* FCKCBKGOFBI, [In][NoAlias] int* KBANJPJCOMJ, int HGBJMIGIIDG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void BNOBCFIKGNP([NoAlias] int* GOGNNEHKELI, [In][NoAlias] byte* INKPOBDEFIO, int LMAHIFIDCDO);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class KPONCDCFGMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6A26430", Offset = "0x6A24A30", VA = "0x186A26430")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6A26830", Offset = "0x6A24E30", VA = "0x186A26830")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6A26790", Offset = "0x6A24D90", VA = "0x186A26790")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6A26550", Offset = "0x6A24B50", VA = "0x186A26550")]
		public unsafe static void DFDLGJKGLOI([NoAlias] int* GOGNNEHKELI, [In][NoAlias] byte* INKPOBDEFIO, int LMAHIFIDCDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void CONMABKCOHJ([NoAlias] ushort* GOGNNEHKELI, [In][NoAlias] byte* INKPOBDEFIO, int LMAHIFIDCDO);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class JLIPPOEJJAC
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6A24B60", Offset = "0x6A23160", VA = "0x186A24B60")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6A24F60", Offset = "0x6A23560", VA = "0x186A24F60")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6A24EC0", Offset = "0x6A234C0", VA = "0x186A24EC0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6A24C80", Offset = "0x6A23280", VA = "0x186A24C80")]
		public unsafe static void DFDLGJKGLOI([NoAlias] ushort* GOGNNEHKELI, [In][NoAlias] byte* INKPOBDEFIO, int LMAHIFIDCDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void ELCHHHOJKNG([Out] float3 GNHDJDMJLFG, ushort MGFNICPOIII);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class ECHAGPFHNOM
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6A14B90", Offset = "0x6A13190", VA = "0x186A14B90")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6A150A0", Offset = "0x6A136A0", VA = "0x186A150A0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6A15000", Offset = "0x6A13600", VA = "0x186A15000")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6A14CB0", Offset = "0x6A132B0", VA = "0x186A14CB0")]
		public static void DFDLGJKGLOI([Out] float3 GNHDJDMJLFG, ushort MGFNICPOIII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort MLADEKNMLBN([In] float3 KBNDGIBNMOI);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class CBNBCGHKILN
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6A12A60", Offset = "0x6A11060", VA = "0x186A12A60")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6A12DE0", Offset = "0x6A113E0", VA = "0x186A12DE0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6A12D40", Offset = "0x6A11340", VA = "0x186A12D40")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6A12B80", Offset = "0x6A11180", VA = "0x186A12B80")]
		public static ushort DFDLGJKGLOI([In] float3 KBNDGIBNMOI)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int FAHHAAGBGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int LMAHIFIDCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> LJLDLDOINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> JDHABOMIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> CMOHCJFAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> PEBBEDAOPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<LHHBIEMHNKA> OFIJEGLHMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> COMAGLLPFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> APHCOANLCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 GEJLFEDKFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 PKAPEKLCDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 DLINDKDCDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 KCHIPHPGPKO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long JNGMPINEOPM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long JBAMPPGNAOI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float FKAANEJEJFD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool POJILNJLGNJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CPJCGPAHDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B600", Offset = "0x6A19C00", VA = "0x186A1B600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A16010", Offset = "0x6A14610", VA = "0x186A16010")]
	public void BEBGJICOPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A6E0", Offset = "0x6A18CE0", VA = "0x186A1A6E0")]
	public static FOJKGPNIEMD KKJEMJBKDLP(Allocator JKHEKCINHDP, DJMGOGABOMJ ALADDOPMBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A1F0", Offset = "0x6A187F0", VA = "0x186A1A1F0")]
	public static FOJKGPNIEMD KKJEMJBKDLP(Allocator JKHEKCINHDP, NativeArray<float3> EEJFFOFFHDA, NativeArray<float3> ODJCCENBKDK, NativeArray<float2> ENIELAHFLPD, NativeArray<float4> EDMMJICLOKG, bool APECHNJIIGF, NativeArray<float4> DJPAJCBFJMA, NativeArray<int> KBANJPJCOMJ, int FAHHAAGBGJO, int KBEJKOKCAGK, int LMAHIFIDCDO, int DKNPIGHNGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A18370", Offset = "0x6A16970", VA = "0x186A18370")]
	public DJMGOGABOMJ EOACINNIHPJ(Allocator JKHEKCINHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A19790", Offset = "0x6A17D90", VA = "0x186A19790")]
	public void HFPKFMIHFEL(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A19C70", Offset = "0x6A18270", VA = "0x186A19C70")]
	private void IJEEGLHAKGH(Mesh GOBEKKOCOLP, NativeArray<ushort> EEOJLGLLHLI, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A16C60", Offset = "0x6A15260", VA = "0x186A16C60")]
	public void DIGMMHJBDOO(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B9B0", Offset = "0x6A19FB0", VA = "0x186A1B9B0")]
	public void NFJCDJJPDDB(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1AAC0", Offset = "0x6A190C0", VA = "0x186A1AAC0")]
	public void LAAKNLKOCMI(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A17740", Offset = "0x6A15D40", VA = "0x186A17740")]
	public void DLFAMGKEBNO(Mesh GOBEKKOCOLP, DJMGOGABOMJ.CKFJLIODADD GCFIDHFGDMF, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C310", Offset = "0x6A1A910", VA = "0x186A1C310")]
	public long PLGJBOMFIKE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B940", Offset = "0x6A19F40", VA = "0x186A1B940")]
	public long NCPDLKOOJHG(DJMGOGABOMJ.CKFJLIODADD GCFIDHFGDMF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A19E90", Offset = "0x6A18490", VA = "0x186A19E90")]
	private void JCIAKJHFOHL(int NMFJOEOKFMG, int GGOJGFOPPLP, Allocator JKHEKCINHDP, bool EJOIHPCHLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A19220", Offset = "0x6A17820", VA = "0x186A19220")]
	private void GKOHJKINPMK(NativeArray<float3> DFDNLBBDNHN, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A19320", Offset = "0x6A17920", VA = "0x186A19320")]
	[BurstCompile]
	private unsafe static void GKOHJKINPMK([NoAlias] float3* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C1D0", Offset = "0x6A1A7D0", VA = "0x186A1C1D0")]
	[BurstCompile]
	private unsafe static void OLPKBFJBJOI([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A182F0", Offset = "0x6A168F0", VA = "0x186A182F0")]
	[BurstCompile]
	private unsafe static void ELGFDAEBLPF([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A15C50", Offset = "0x6A14250", VA = "0x186A15C50")]
	[BurstCompile]
	private unsafe static void ABOAJIMOLKE([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A19430", Offset = "0x6A17A30", VA = "0x186A19430")]
	private void GNAHCGLFJLF(NativeArray<float3> EEJFFOFFHDA, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A193A0", Offset = "0x6A179A0", VA = "0x186A193A0")]
	[BurstCompile]
	private unsafe static void GNAHCGLFJLF([NoAlias] ushort* DFDNLBBDNHN, [Out] float3 PMCGPGMKAKK, [Out] float3 PKAPEKLCDDM, [In][NoAlias] float3* EEJFFOFFHDA, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A17F00", Offset = "0x6A16500", VA = "0x186A17F00")]
	private void DMOKANPHNKP(NativeArray<float3> ODJCCENBKDK, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A17CF0", Offset = "0x6A162F0", VA = "0x186A17CF0")]
	[BurstCompile]
	private unsafe static void DMOKANPHNKP([NoAlias] ushort* BDENIJIEJKG, [In][NoAlias] float3* ODJCCENBKDK, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A17BB0", Offset = "0x6A161B0", VA = "0x186A17BB0")]
	private void DMBCGKAAOIF(NativeArray<float3> MFNMOOPJLBA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A17C80", Offset = "0x6A16280", VA = "0x186A17C80")]
	[BurstCompile]
	private unsafe static void DMBCGKAAOIF([NoAlias] float3* MFNMOOPJLBA, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B1A0", Offset = "0x6A197A0", VA = "0x186A1B1A0")]
	[BurstCompile]
	private unsafe static void LEABDIFHFAG([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A040", Offset = "0x6A18640", VA = "0x186A1A040")]
	[BurstCompile]
	private unsafe static void JGEFEHDIJHO([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A9D0", Offset = "0x6A18FD0", VA = "0x186A1A9D0")]
	[BurstCompile]
	private unsafe static void KNFLCBAIGKF([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A17AE0", Offset = "0x6A160E0", VA = "0x186A17AE0")]
	private void DLHPHCFFABA(NativeArray<float2> ENIELAHFLPD, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A178A0", Offset = "0x6A15EA0", VA = "0x186A178A0")]
	[BurstCompile]
	private unsafe static void DLHPHCFFABA([NoAlias] ushort* DJKPPDEOPEM, [Out] float2 OLADNNAIHDN, [Out] float2 KCHIPHPGPKO, [In][NoAlias] float2* ENIELAHFLPD, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1AA40", Offset = "0x6A19040", VA = "0x186A1AA40")]
	[BurstCompile]
	private static void KPKMJONIEGJ([Out] float2 GNHDJDMJLFG, ushort MGFNICPOIII, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B6C0", Offset = "0x6A19CC0", VA = "0x186A1B6C0")]
	private void MBEEFFIJFNN(NativeArray<float2> DJKPPDEOPEM, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B640", Offset = "0x6A19C40", VA = "0x186A1B640")]
	[BurstCompile]
	private unsafe static void MBEEFFIJFNN([NoAlias] float2* DJKPPDEOPEM, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BF90", Offset = "0x6A1A590", VA = "0x186A1BF90")]
	[BurstCompile]
	private unsafe static void NIJFOBLOMEI([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A16900", Offset = "0x6A14F00", VA = "0x186A16900")]
	[BurstCompile]
	private unsafe static void CEPEHLLBBKG([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A18270", Offset = "0x6A16870", VA = "0x186A18270")]
	[BurstCompile]
	private unsafe static void EKBMPEFEKPB([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A175D0", Offset = "0x6A15BD0", VA = "0x186A175D0")]
	private void DJGKAEPJFNC(NativeArray<float4> DJPAJCBFJMA, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A176C0", Offset = "0x6A15CC0", VA = "0x186A176C0")]
	[BurstCompile]
	private unsafe static void DJGKAEPJFNC([NoAlias] ushort* LOEMBHIFPJH, [In][NoAlias] float4* NLHBDFCFAPM, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A19B00", Offset = "0x6A18100", VA = "0x186A19B00")]
	[BurstCompile]
	private static ushort IGANKGIAKJP([In] float4 KBNDGIBNMOI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A15ED0", Offset = "0x6A144D0", VA = "0x186A15ED0")]
	private void AKLEIGNGECA(NativeArray<float4> LOEMBHIFPJH, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A15FA0", Offset = "0x6A145A0", VA = "0x186A15FA0")]
	[BurstCompile]
	private unsafe static void AKLEIGNGECA([NoAlias] float4* LOEMBHIFPJH, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A173C0", Offset = "0x6A159C0", VA = "0x186A173C0")]
	[BurstCompile]
	private unsafe static void DIPGDACFLNE([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A19890", Offset = "0x6A17E90", VA = "0x186A19890")]
	[BurstCompile]
	private unsafe static void HJBGHMMMPFA([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B3B0", Offset = "0x6A199B0", VA = "0x186A1B3B0")]
	[BurstCompile]
	private unsafe static void LHKPJAKKGBP([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A16980", Offset = "0x6A14F80", VA = "0x186A16980")]
	[BurstCompile]
	private static void CKCACCABPLJ([Out] float4 JKLHKLABFHH, ushort MGFNICPOIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A16350", Offset = "0x6A14950", VA = "0x186A16350")]
	private void BKKHJJFDDAL(Allocator JKHEKCINHDP, NativeArray<float4> EDMMJICLOKG, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A16110", Offset = "0x6A14710", VA = "0x186A16110")]
	[BurstCompile]
	private unsafe static void BKKHJJFDDAL([NoAlias] float4* PCBHNCDJHIC, [NoAlias] byte* DAOBPAJCCMC, [Out] int NPJGNFOGMIF, [Out] int OMDBJCEEFKA, [NoAlias] float4* EDMMJICLOKG, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A19090", Offset = "0x6A17690", VA = "0x186A19090")]
	private static void GEBNAIFMICA(NativeArray<float4> LFFPEPCBAGJ, NativeArray<LHHBIEMHNKA> JKDFBJJJONC, NativeArray<byte> LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A191A0", Offset = "0x6A177A0", VA = "0x186A191A0")]
	[BurstCompile]
	private unsafe static void GEBNAIFMICA([NoAlias] float4* LFFPEPCBAGJ, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A19710", Offset = "0x6A17D10", VA = "0x186A19710")]
	[BurstCompile]
	private unsafe static void HEOAGCNGBPM([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A180B0", Offset = "0x6A166B0", VA = "0x186A180B0")]
	[BurstCompile]
	private unsafe static void EAGNHDKNNFC([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A19FC0", Offset = "0x6A185C0", VA = "0x186A19FC0")]
	[BurstCompile]
	private unsafe static void JDMCCFFNCIK([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A19960", Offset = "0x6A17F60", VA = "0x186A19960")]
	private void IACOMEMCJLB(Allocator JKHEKCINHDP, NativeArray<int> KBANJPJCOMJ, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A18BD0", Offset = "0x6A171D0", VA = "0x186A18BD0")]
	private static NativeArray<byte> FLLBIFGKFEO(Allocator JKHEKCINHDP, NativeArray<int> KBANJPJCOMJ, int HGBJMIGIIDG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A18B60", Offset = "0x6A17160", VA = "0x186A18B60")]
	[BurstCompile]
	private unsafe static int FLLBIFGKFEO([NoAlias] byte* FCKCBKGOFBI, [In][NoAlias] int* KBANJPJCOMJ, int HGBJMIGIIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A19640", Offset = "0x6A17C40", VA = "0x186A19640")]
	private static void HDHIMHCHHCN(NativeArray<int> GOGNNEHKELI, NativeArray<byte> INKPOBDEFIO, int LMAHIFIDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A195D0", Offset = "0x6A17BD0", VA = "0x186A195D0")]
	[BurstCompile]
	private unsafe static void HDHIMHCHHCN([NoAlias] int* GOGNNEHKELI, [In][NoAlias] byte* INKPOBDEFIO, int LMAHIFIDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A19020", Offset = "0x6A17620", VA = "0x186A19020")]
	[BurstCompile]
	private unsafe static void GCMDPOMNIKL([NoAlias] ushort* GOGNNEHKELI, [In][NoAlias] byte* INKPOBDEFIO, int LMAHIFIDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A19900", Offset = "0x6A17F00", VA = "0x186A19900")]
	[BurstCompile]
	private static void HMHNMHBHLMJ([Out] float3 GNHDJDMJLFG, ushort MGFNICPOIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A15CD0", Offset = "0x6A142D0", VA = "0x186A15CD0")]
	[BurstCompile]
	private static ushort AFLJHBJGGKM([In] float3 KBNDGIBNMOI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public FOJKGPNIEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A10200", Offset = "0x6A0E800", VA = "0x186A10200")]
	[BurstCompile]
	public unsafe static void NJELMBBJKEL([NoAlias] float3* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A16730", Offset = "0x6A14D30", VA = "0x186A16730")]
	[BurstCompile]
	public unsafe static void BLKOFDDJJOA([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A19A40", Offset = "0x6A18040", VA = "0x186A19A40")]
	[BurstCompile]
	public unsafe static void IENMNJBLGPJ([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A910", Offset = "0x6A18F10", VA = "0x186A1A910")]
	[BurstCompile]
	public unsafe static void KMONGBFAGCI([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* EEJFFOFFHDA, int FAHHAAGBGJO, [In] float3 GEJLFEDKFAJ, [In] float3 PKAPEKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F360", Offset = "0x6A0D960", VA = "0x186A0F360")]
	[BurstCompile]
	public unsafe static void AJAPBOMIPAD([NoAlias] ushort* DFDNLBBDNHN, [Out] float3 PMCGPGMKAKK, [Out] float3 PKAPEKLCDDM, [In][NoAlias] float3* EEJFFOFFHDA, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FB40", Offset = "0x6A0E140", VA = "0x186A0FB40")]
	[BurstCompile]
	public unsafe static void HKDHOPHAAPC([NoAlias] ushort* BDENIJIEJKG, [In][NoAlias] float3* ODJCCENBKDK, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C130", Offset = "0x6A1A730", VA = "0x186A1C130")]
	[BurstCompile]
	public unsafe static void OGFFDCKOOGP([NoAlias] float3* MFNMOOPJLBA, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F900", Offset = "0x6A0DF00", VA = "0x186A0F900")]
	[BurstCompile]
	public unsafe static void CPBCPMNIJLN([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A19B50", Offset = "0x6A18150", VA = "0x186A19B50")]
	[BurstCompile]
	public unsafe static void IGGFJFJHMOC([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A167F0", Offset = "0x6A14DF0", VA = "0x186A167F0")]
	[BurstCompile]
	public unsafe static void BPMDIOKJBKA([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* ODJCCENBKDK, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A10450", Offset = "0x6A0EA50", VA = "0x186A10450")]
	[BurstCompile]
	public unsafe static void NNFBJGLHFEH([NoAlias] ushort* DJKPPDEOPEM, [Out] float2 OLADNNAIHDN, [Out] float2 KCHIPHPGPKO, [In][NoAlias] float2* ENIELAHFLPD, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A8C0", Offset = "0x6A18EC0", VA = "0x186A1A8C0")]
	[BurstCompile]
	public static void KMLICDMFJLP([Out] float2 GNHDJDMJLFG, ushort MGFNICPOIII, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B860", Offset = "0x6A19E60", VA = "0x186A1B860")]
	[BurstCompile]
	public unsafe static void NBDBMCMPEDI([NoAlias] float2* DJKPPDEOPEM, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A17FC0", Offset = "0x6A165C0", VA = "0x186A17FC0")]
	[BurstCompile]
	public unsafe static void DOPLPNJDNIC([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A18950", Offset = "0x6A16F50", VA = "0x186A18950")]
	[BurstCompile]
	public unsafe static void FHIEMEFOAAE([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A18E40", Offset = "0x6A17440", VA = "0x186A18E40")]
	[BurstCompile]
	public unsafe static void GAPDAHLAHFG([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [NoAlias] ushort* ENIELAHFLPD, int FAHHAAGBGJO, [In] float2 DLINDKDCDAJ, [In] float2 KCHIPHPGPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A16BC0", Offset = "0x6A151C0", VA = "0x186A16BC0")]
	[BurstCompile]
	public unsafe static void DFOPLABFJKJ([NoAlias] ushort* LOEMBHIFPJH, [In][NoAlias] float4* NLHBDFCFAPM, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A19D90", Offset = "0x6A18390", VA = "0x186A19D90")]
	[BurstCompile]
	public static ushort IPEAGDFLKCE([In] float4 KBNDGIBNMOI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A19530", Offset = "0x6A17B30", VA = "0x186A19530")]
	[BurstCompile]
	public unsafe static void GOIHMBLEBGJ([NoAlias] float4* LOEMBHIFPJH, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FD90", Offset = "0x6A0E390", VA = "0x186A0FD90")]
	[BurstCompile]
	public unsafe static void MLOOJGNIELO([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C010", Offset = "0x6A1A610", VA = "0x186A1C010")]
	[BurstCompile]
	public unsafe static void NLGOLAAIJPA([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A18A50", Offset = "0x6A17050", VA = "0x186A18A50")]
	[BurstCompile]
	public unsafe static void FHMFEDIDOMO([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] ushort* DJPAJCBFJMA, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C250", Offset = "0x6A1A850", VA = "0x186A1C250")]
	[BurstCompile]
	public static void PLFIKGNBJOL([Out] float4 JKLHKLABFHH, ushort MGFNICPOIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F740", Offset = "0x6A0DD40", VA = "0x186A0F740")]
	[BurstCompile]
	public unsafe static void COOJGDIHBLC([NoAlias] float4* PCBHNCDJHIC, [NoAlias] byte* DAOBPAJCCMC, [Out] int NPJGNFOGMIF, [Out] int OMDBJCEEFKA, [NoAlias] float4* EDMMJICLOKG, int DKNPIGHNGCL, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A18130", Offset = "0x6A16730", VA = "0x186A18130")]
	[BurstCompile]
	public unsafe static void EIHABIGMFKM([NoAlias] float4* LFFPEPCBAGJ, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A169E0", Offset = "0x6A14FE0", VA = "0x186A169E0")]
	[BurstCompile]
	public unsafe static void DFCBIFNJJDK([NoAlias] DJMGOGABOMJ.OLGPBMCKHIK* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B420", Offset = "0x6A19A20", VA = "0x186A1B420")]
	[BurstCompile]
	public unsafe static void LKIGCFCAMFL([NoAlias] DJMGOGABOMJ.FPKFMDKIHMB* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A171E0", Offset = "0x6A157E0", VA = "0x186A171E0")]
	[BurstCompile]
	public unsafe static void DINPMDIMGIL([NoAlias] DJMGOGABOMJ.HKJHCFFMJCB* DFDNLBBDNHN, [In][NoAlias] LHHBIEMHNKA* JKDFBJJJONC, [In][NoAlias] byte* LFMANICGNPL, int FAHHAAGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B0A0", Offset = "0x6A196A0", VA = "0x186A1B0A0")]
	[BurstCompile]
	public unsafe static int LBMDJPNBAND([NoAlias] byte* FCKCBKGOFBI, [In][NoAlias] int* KBANJPJCOMJ, int HGBJMIGIIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B7C0", Offset = "0x6A19DC0", VA = "0x186A1B7C0")]
	[BurstCompile]
	public unsafe static void MFKOJELHFII([NoAlias] int* GOGNNEHKELI, [In][NoAlias] byte* INKPOBDEFIO, int LMAHIFIDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A19DF0", Offset = "0x6A183F0", VA = "0x186A19DF0")]
	[BurstCompile]
	public unsafe static void IPJCIGDNHHH([NoAlias] ushort* GOGNNEHKELI, [In][NoAlias] byte* INKPOBDEFIO, int LMAHIFIDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A0B0", Offset = "0x6A186B0", VA = "0x186A1A0B0")]
	[BurstCompile]
	public static void KBEAENMEHAB([Out] float3 GNHDJDMJLFG, ushort MGFNICPOIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A10040", Offset = "0x6A0E640", VA = "0x186A10040")]
	[BurstCompile]
	public static ushort MOPABKJOAIL([In] float3 KBNDGIBNMOI)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GBCCGOJKACF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 AMCGEKKJOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 OALBAJHBHJJ;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class POPFJLDLDCB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<GBCCGOJKACF> CLGCJGCCMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> BCIMBEHJKNK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AFEJIIOFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DDMELFPJCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x85F440", Offset = "0x85DA40", VA = "0x18085F440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CA70", Offset = "0x6A2B070", VA = "0x186A2CA70")]
	public POPFJLDLDCB(int NMFJOEOKFMG, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C930", Offset = "0x6A2AF30", VA = "0x186A2C930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C990", Offset = "0x6A2AF90", VA = "0x186A2C990")]
	public void MHNGNGPDOJG(POPFJLDLDCB JNGDDADMPFF, int DCCMICHPAID, int CHEJIFFIDLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GFMOIMLMNDG
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static POPFJLDLDCB FCLOCCFNCJD;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<NGBNIJNLBKN> MFGCOELGAGM;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] ODIHBDMDHHM;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool BGLJIBKBALJ;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, POPFJLDLDCB> HOPCBCDMPAJ;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, POPFJLDLDCB> MBHJKKCHKIN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool DMBDOBFMPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DFA0", Offset = "0x6A1C5A0", VA = "0x186A1DFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<NGBNIJNLBKN> GLBMIEDABDM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E020", Offset = "0x6A1C620", VA = "0x186A1E020")]
		get
		{
			return default(NativeList<NGBNIJNLBKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static POPFJLDLDCB JMDPKJMKODI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DEA0", Offset = "0x6A1C4A0", VA = "0x186A1DEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C990", Offset = "0x6A1AF90", VA = "0x186A1C990")]
	private static void AFNCNDJBCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D9A0", Offset = "0x6A1BFA0", VA = "0x186A1D9A0")]
	public static int JFAKHJNPGFG(bool IEAIKJEPOKC, int LFMMNCPANMG, bool GKNEHMOBMKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D960", Offset = "0x6A1BF60", VA = "0x186A1D960")]
	private static int IOGFFMFHOPP(int LFMMNCPANMG, bool AAGMAPHIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D950", Offset = "0x6A1BF50", VA = "0x186A1D950")]
	private static int IEIDHMDOHAD(int LFMMNCPANMG, bool AAGMAPHIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DAC0", Offset = "0x6A1C0C0", VA = "0x186A1DAC0")]
	public static int KBMPDNPGMHK(int FALHCGACGOI, int LFMMNCPANMG, int FAFHLGBLOIN, bool AAGMAPHIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DE10", Offset = "0x6A1C410", VA = "0x186A1DE10")]
	public static int LCAAAKFPADC(int FALHCGACGOI, int LFMMNCPANMG, int FAFHLGBLOIN, bool AAGMAPHIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D3C0", Offset = "0x6A1B9C0", VA = "0x186A1D3C0")]
	public static int CGHFCIAEALM(int FAFHLGBLOIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DB50", Offset = "0x6A1C150", VA = "0x186A1DB50")]
	private static int KHKIOELPHDG(int LFMMNCPANMG, bool AAGMAPHIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D980", Offset = "0x6A1BF80", VA = "0x186A1D980")]
	private static int JAMNAFKDJNL(int LFMMNCPANMG, bool AAGMAPHIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DF30", Offset = "0x6A1C530", VA = "0x186A1DF30")]
	public static int MDHALHLGFKF(int FALHCGACGOI, int LFMMNCPANMG, int FAFHLGBLOIN, bool AAGMAPHIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D4C0", Offset = "0x6A1BAC0", VA = "0x186A1D4C0")]
	public static int FOPMEHODPDN(int FALHCGACGOI, int LFMMNCPANMG, int FAFHLGBLOIN, bool AAGMAPHIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DB60", Offset = "0x6A1C160", VA = "0x186A1DB60")]
	public static int KJEHKFNHCIJ(int FAFHLGBLOIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D9D0", Offset = "0x6A1BFD0", VA = "0x186A1D9D0")]
	public static POPFJLDLDCB JIEFKJEDDEJ(int LFMMNCPANMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DB80", Offset = "0x6A1C180", VA = "0x186A1DB80")]
	private static POPFJLDLDCB KPCPPDFMPPO(int LFMMNCPANMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D3D0", Offset = "0x6A1B9D0", VA = "0x186A1D3D0")]
	public static POPFJLDLDCB FGAANFJJGFG(int LFMMNCPANMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D080", Offset = "0x6A1B680", VA = "0x186A1D080")]
	private static POPFJLDLDCB BMAMAKEPKLB(int LFMMNCPANMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D550", Offset = "0x6A1BB50", VA = "0x186A1D550")]
	public static void GMBCHGJGFOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct INKFNNAJEHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int OPMDKCDPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 PFBFBGCIMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion PCCOKCOFHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float FKPFMKOFLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float HJNHNOBCMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int CNCBBBNCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int JPJGHOKCIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int AGNNHDOPOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool NENLDJOBNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool CGGHNMFMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float CAADFLOJOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 NHILMGNJLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool CNJIKIOMNAA;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct PCOJMFIKJNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int AHJCPMDEMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int EOBCIDHJECA;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct PNODLPKEJDK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<INKFNNAJEHO> FNMOFHFLCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<GDLIEPHPIEN> ECNONNGFBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<NGBNIJNLBKN> HLJPIOBHPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<PCOJMFIKJNH> JIBNFBNINEI;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C800", Offset = "0x6A2AE00", VA = "0x186A2C800")]
	public PNODLPKEJDK(NativeArray<GDLIEPHPIEN> ECNONNGFBKP, int PPOFLGDKIBE = 1, Allocator JKHEKCINHDP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C710", Offset = "0x6A2AD10", VA = "0x186A2C710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct HDEANPKOMNE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<GBCCGOJKACF> HHOEGKIJCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> PAABGNPPACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<NGBNIJNLBKN> KLNMIKFMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<INKFNNAJEHO> FNMOFHFLCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<GDLIEPHPIEN> ECNONNGFBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<NGBNIJNLBKN> HLJPIOBHPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<PCOJMFIKJNH> JIBNFBNINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int KFILPIJJGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int NPJCOGPIJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 AJGLCKGKBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion NMHLDAJKKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 EDLINDJBCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BPALIMKHEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FMABHEKOAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EEMPLFDGOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LKFEEBBPABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FPBKLCCCFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MDLGBOPIKIN;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6A229F0", Offset = "0x6A20FF0", VA = "0x186A229F0")]
	public HDEANPKOMNE(PEKPLCGGHFL CEENOLEBPMH, DJMGOGABOMJ ANICBJIKLDJ, float3 DHGMFBFMNLM, quaternion AJLDOODDDPI, float AMGFMJAAPKL, int OKOIJGILEOD = 0, int HKCMNPJPGKO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6A22C70", Offset = "0x6A21270", VA = "0x186A22C70")]
	public HDEANPKOMNE(PNODLPKEJDK CEENOLEBPMH, DJMGOGABOMJ ANICBJIKLDJ, float3 DHGMFBFMNLM, quaternion AJLDOODDDPI, float3 AMGFMJAAPKL, int OKOIJGILEOD = 0, int HKCMNPJPGKO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6A20BE0", Offset = "0x6A1F1E0", VA = "0x186A20BE0")]
	private float3 EDECPLAEBMK(float3 HEEHIBGOCNH, Matrix4x4 GFHBGGMHBMA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6A20D10", Offset = "0x6A1F310", VA = "0x186A20D10")]
	private float3x3 ELELNGAGLHO(float3x3 MHLLDAGKOPH, float3x3 JGIMLPAGLDH)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A229E0", Offset = "0x6A20FE0", VA = "0x186A229E0")]
	private float MBAHPICPOBE(float JAGNHLKKADJ, float BBOMGAAGIGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6A20D90", Offset = "0x6A1F390", VA = "0x186A20D90", Slot = "4")]
	public void Execute(int HCFIMDJDENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6A20A70", Offset = "0x6A1F070", VA = "0x186A20A70")]
	private void EALNEIHMKOJ(int DDMOLKDLNDC, float3 LPBGBJBIAOJ, float3 FKPHICIEEGL, float3 KJNPDPIAHBA, float PIBBFIKNNCO, bool KBMNPAJOMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6A22580", Offset = "0x6A20B80", VA = "0x186A22580")]
	private void LDEHOMNGJNB(INKFNNAJEHO NOACFMLFGIC, float3 MBNBKCOEPAH, float3x3 PCAJHGOJOKB, float JAGNHLKKADJ, int IIEIJMEHMME, int LGKBMLJNHAI, int AEBIPBNEGDB, float MPPEEPOGFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6A21F30", Offset = "0x6A20530", VA = "0x186A21F30")]
	private void FIMAJMHBCCD(int DDMOLKDLNDC, int OCKLDCFKCCJ, INKFNNAJEHO NOACFMLFGIC, float3 MBNBKCOEPAH, float3x3 PCAJHGOJOKB, bool AIBEGNIOGFH, float JAGNHLKKADJ, int BJOBJNGPNGD, int LLCAGFKOLFM, int AEBIPBNEGDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct HDLMNLFHPKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<HGAKGMLOGGD> OJJMDIHKILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<NGBNIJNLBKN> OMICEMFBNMM;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6A22F40", Offset = "0x6A21540", VA = "0x186A22F40")]
	public HDLMNLFHPKJ(int PPOFLGDKIBE, Allocator JKHEKCINHDP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6A22EA0", Offset = "0x6A214A0", VA = "0x186A22EA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct GGKFBDAFCIN : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum GIGKBNPCNEJ
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
	private NativeList<float3> CMFMIKGGBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> DIALJELOINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> EKKBNPIGJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> JALHLJADJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> KDLGDEFOCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> FLKFIMFKIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> PHMIGPNEADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> LNDICHPGKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<NGBNIJNLBKN> AGPCDNIDKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<HGAKGMLOGGD> OJJMDIHKILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<NGBNIJNLBKN> OMICEMFBNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int KFILPIJJGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int NPJCOGPIJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BPALIMKHEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FMABHEKOAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EEMPLFDGOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LKFEEBBPABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FPBKLCCCFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MDLGBOPIKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 EDLINDJBCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion NMHLDAJKKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 AJGLCKGKBMM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F7F0", Offset = "0x6A1DDF0", VA = "0x186A1F7F0")]
	public GGKFBDAFCIN(PEKPLCGGHFL CEENOLEBPMH, DJMGOGABOMJ ANICBJIKLDJ, float3 DHGMFBFMNLM, quaternion AJLDOODDDPI, float AMGFMJAAPKL, int OKOIJGILEOD = 0, int HKCMNPJPGKO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F610", Offset = "0x6A1DC10", VA = "0x186A1F610")]
	public GGKFBDAFCIN(HDLMNLFHPKJ JHLEMCFOEMF, DJMGOGABOMJ ANICBJIKLDJ, float3 DHGMFBFMNLM, quaternion AJLDOODDDPI, float3 AMGFMJAAPKL, int OKOIJGILEOD = 0, int HKCMNPJPGKO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E270", Offset = "0x6A1C870", VA = "0x186A1E270", Slot = "4")]
	public void Execute(int HCFIMDJDENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F1D0", Offset = "0x6A1D7D0", VA = "0x186A1F1D0")]
	private void JBLHELFKPJH(float4x4 HAANBCCCMHC, int HCFIMDJDENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E200", Offset = "0x6A1C800", VA = "0x186A1E200")]
	private GIGKBNPCNEJ BDGIPNBBPDF(float3 FKPHICIEEGL)
	{
		return default(GIGKBNPCNEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F5C0", Offset = "0x6A1DBC0", VA = "0x186A1F5C0")]
	private float4 PGHJAHBGPGE(GIGKBNPCNEJ KDCLOEJMACI, int EBDMAJMOJLN)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F580", Offset = "0x6A1DB80", VA = "0x186A1F580")]
	private float2 NABHNFHMPLG(GIGKBNPCNEJ KDCLOEJMACI, float3 LPBGBJBIAOJ)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct AIAGMIIBJAF
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum LMEFEHGPFNA
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static AIAGMIIBJAF IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 MCOMLLJHBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 EAHANMKDOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 BONHNBEOKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public LMEFEHGPFNA FJKMPMDCIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 JLDOEEBOIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 LJELBALAFBE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NEEAOKHHHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A11960", Offset = "0x6A0FF60", VA = "0x186A11960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 LKNPMDMPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A11970", Offset = "0x6A0FF70", VA = "0x186A11970")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A11BB0", Offset = "0x6A101B0", VA = "0x186A11BB0")]
	public AIAGMIIBJAF(float3 LPBGBJBIAOJ, quaternion CNNBBFFJNHM, float3 PPOFLGDKIBE, LMEFEHGPFNA BDKLEMDNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A11230", Offset = "0x6A0F830", VA = "0x186A11230")]
	public float DHKFPNNNCJD(float3 MBNBKCOEPAH, float OMICHLEINKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A115E0", Offset = "0x6A0FBE0", VA = "0x186A115E0")]
	public bool HJCOEIILKLE(float3 FKPHICIEEGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A11430", Offset = "0x6A0FA30", VA = "0x186A11430")]
	public void EJHKDGMNAFF(float3 MGHIIGHFJID, float3x3 EGBIOANHICA, float GGALHAPFELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A11A50", Offset = "0x6A10050", VA = "0x186A11A50")]
	private void NHODMEBAOFF(float3 CBJGMPIDMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A116D0", Offset = "0x6A0FCD0", VA = "0x186A116D0")]
	public void HMGFLPMLBEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct JKFOMBLBEID : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<AIAGMIIBJAF> JHLEMCFOEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> LJLDLDOINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> APHCOANLCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HFEBGJDHJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<NGBNIJNLBKN> OMICEMFBNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int AGLPOOGMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int GPLKODEOOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float OMICHLEINKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float PLKEKLLKLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> NIMHKECJALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> PLPAHNIBLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> BMIBFCKMNMA;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A24AC0", Offset = "0x6A230C0", VA = "0x186A24AC0")]
	public JKFOMBLBEID(DJMGOGABOMJ GOBEKKOCOLP, float ANALPGMIMHB, int CHEJIFFIDLB, int IIEIJMEHMME, NativeList<AIAGMIIBJAF> JHLEMCFOEMF, NativeArray<int> HFEBGJDHJLF, NativeList<NGBNIJNLBKN> OMICEMFBNMM, KBGBOEOKOAC NBNHMAAGAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A24020", Offset = "0x6A22620", VA = "0x186A24020", Slot = "4")]
	public void Execute(int ABGCPPAGAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A24760", Offset = "0x6A22D60", VA = "0x186A24760")]
	private bool ODFFMNBKFKL(AIAGMIIBJAF EJHDJMODPJO, AIAGMIIBJAF PNLANOPNMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A24820", Offset = "0x6A22E20", VA = "0x186A24820")]
	private bool PAEKOLADLBK(AIAGMIIBJAF PJNNEBIEMCE, int INJFHHNEMFI, int KKCJOGMENHA, int ONCJGELNLPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class KBGBOEOKOAC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> EFINKDIMCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> GBPKJDLAPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> HJDDLIHLLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> IIIFJPKMENB;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A25E20", Offset = "0x6A24420", VA = "0x186A25E20")]
	public void JCIAKJHFOHL(int NMFJOEOKFMG, int GGOJGFOPPLP, Allocator JKHEKCINHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A25E00", Offset = "0x6A24400", VA = "0x186A25E00")]
	public static long HHLKPMGHNNM(int NMFJOEOKFMG, int GGOJGFOPPLP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A25D10", Offset = "0x6A24310", VA = "0x186A25D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A25C20", Offset = "0x6A24220", VA = "0x186A25C20")]
	public void BEBGJICOPHM(JobHandle JKHDOKLDIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public KBGBOEOKOAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct HCLFHHLOHOI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> LJLDLDOINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> JDHABOMIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> OFIJEGLHMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> PEBBEDAOPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> APHCOANLCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CMOHCJFAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> GDPFGHDINMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> NIMHKECJALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> PLPAHNIBLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int OKOIJGILEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int HKCMNPJPGKO;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A209F0", Offset = "0x6A1EFF0", VA = "0x186A209F0")]
	public HCLFHHLOHOI(DJMGOGABOMJ GOBEKKOCOLP, KBGBOEOKOAC NBNHMAAGAFF, int HKCMNPJPGKO = 0, int OKOIJGILEOD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A205B0", Offset = "0x6A1EBB0", VA = "0x186A205B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A20990", Offset = "0x6A1EF90", VA = "0x186A20990")]
	private void IGKLNIDJCCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CIDAMKHBOLI
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x296F120", Offset = "0x296D720", VA = "0x18296F120")]
	public static bool IPGNIMIBMAI<T>(NativeArray<T> NMHOKLPDKBK, int PPOFLGDKIBE, Allocator JKHEKCINHDP, NativeArrayOptions KMKBHLMADIH = NativeArrayOptions.ClearMemory, int COOLNPIGHHM = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x296F1E0", Offset = "0x296D7E0", VA = "0x18296F1E0")]
	public static bool IPGNIMIBMAI<T>(NativeList<T> MNNCEMFBNNK, int PPOFLGDKIBE, Allocator JKHEKCINHDP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum NHHHNHFBJDC
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
public interface CGJEKNFHMIM
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IGLPCLNENOA(NHHHNHFBJDC FALHCGACGOI);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CLIHPPPABCB(NHHHNHFBJDC FALHCGACGOI);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds CMBIBLNNMED();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float CFCOJGDPHLO();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAPFIHJAHGA(NHHHNHFBJDC FALHCGACGOI, PEKPLCGGHFL NNDMCMIEFGH, int ACPCPLJAAHC = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class DJMGOGABOMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum CKFJLIODADD
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
	public struct JAMFJPFHGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CKFJLIODADD GCFIDHFGDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool CGFLFKIOHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int BLAKIBOKMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] FMIGJHEPBPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct JFGAFEFLACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 LPBGBJBIAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 FKPHICIEEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 KJNPDPIAHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 NIMMFOEFLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 OFIJEGLHMCI;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] FMIGJHEPBPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct OLGPBMCKHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 LPBGBJBIAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 FKPHICIEEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 KJNPDPIAHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 NIMMFOEFLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 OFIJEGLHMCI;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] FMIGJHEPBPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct KNMGONKJDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 LPBGBJBIAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 FKPHICIEEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 KJNPDPIAHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 NIMMFOEFLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint OFIJEGLHMCI;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] FMIGJHEPBPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct FPKFMDKIHMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 LPBGBJBIAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint FKPHICIEEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint KJNPDPIAHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 NIMMFOEFLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 OFIJEGLHMCI;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] FMIGJHEPBPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct HKJHCFFMJCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 LPBGBJBIAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint FKPHICIEEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint KJNPDPIAHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 NIMMFOEFLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 OFIJEGLHMCI;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] FMIGJHEPBPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int LAPGJECPHML(float OEMFOJFNECE);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class EMLOHBJNOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A359D0", Offset = "0x6A33FD0", VA = "0x186A359D0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A35DF0", Offset = "0x6A343F0", VA = "0x186A35DF0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A35D50", Offset = "0x6A34350", VA = "0x186A35D50")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A35AF0", Offset = "0x6A340F0", VA = "0x186A35AF0")]
		public static int DFDLGJKGLOI(float OEMFOJFNECE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint MLCJMCOJOKK([In] float4 ONOKCMNNMGN);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class NFEAHEBNEIA
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A430A0", Offset = "0x6A416A0", VA = "0x186A430A0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A43590", Offset = "0x6A41B90", VA = "0x186A43590")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A434F0", Offset = "0x6A41AF0", VA = "0x186A434F0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A431C0", Offset = "0x6A417C0", VA = "0x186A431C0")]
		public static uint DFDLGJKGLOI([In] float4 ONOKCMNNMGN)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint BDCPKAGDHBK([In] float3 ONOKCMNNMGN);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class BGOIGDHJABG
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6A2D750", Offset = "0x6A2BD50", VA = "0x186A2D750")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6A2DB80", Offset = "0x6A2C180", VA = "0x186A2DB80")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6A2DAE0", Offset = "0x6A2C0E0", VA = "0x186A2DAE0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6A2D870", Offset = "0x6A2BE70", VA = "0x186A2D870")]
		public static uint DFDLGJKGLOI([In] float3 ONOKCMNNMGN)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void DDLKDDIDGCG([NoAlias] FPKFMDKIHMB* DFDNLBBDNHN, int FAHHAAGBGJO, [In][NoAlias] float3* EPEMDDHEPAK, [In][NoAlias] float3* JDHABOMIFGO, [In][NoAlias] float4* CMOHCJFAEON, [In][NoAlias] float2* PEBBEDAOPHO, [In][NoAlias] float4* OFIJEGLHMCI);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class JOKPKGMNCJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6A36F70", Offset = "0x6A35570", VA = "0x186A36F70")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6A37360", Offset = "0x6A35960", VA = "0x186A37360")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6A372C0", Offset = "0x6A358C0", VA = "0x186A372C0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A37090", Offset = "0x6A35690", VA = "0x186A37090")]
		public unsafe static void DFDLGJKGLOI([NoAlias] FPKFMDKIHMB* DFDNLBBDNHN, int FAHHAAGBGJO, [In][NoAlias] float3* EPEMDDHEPAK, [In][NoAlias] float3* JDHABOMIFGO, [In][NoAlias] float4* CMOHCJFAEON, [In][NoAlias] float2* PEBBEDAOPHO, [In][NoAlias] float4* OFIJEGLHMCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void GCFPEIOKGHN([NoAlias] HKJHCFFMJCB* DFDNLBBDNHN, int FAHHAAGBGJO, [In][NoAlias] float3* EPEMDDHEPAK, [In][NoAlias] float3* JDHABOMIFGO, [In][NoAlias] float4* CMOHCJFAEON, [In][NoAlias] float2* PEBBEDAOPHO, [In][NoAlias] float4* OFIJEGLHMCI);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class NGEHBINIIIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6A436E0", Offset = "0x6A41CE0", VA = "0x186A436E0")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6A43AD0", Offset = "0x6A420D0", VA = "0x186A43AD0")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6A43A30", Offset = "0x6A42030", VA = "0x186A43A30")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6A43800", Offset = "0x6A41E00", VA = "0x186A43800")]
		public unsafe static void DFDLGJKGLOI([NoAlias] HKJHCFFMJCB* DFDNLBBDNHN, int FAHHAAGBGJO, [In][NoAlias] float3* EPEMDDHEPAK, [In][NoAlias] float3* JDHABOMIFGO, [In][NoAlias] float4* CMOHCJFAEON, [In][NoAlias] float2* PEBBEDAOPHO, [In][NoAlias] float4* OFIJEGLHMCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int PMIDHGCBAJO = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> HNJCAHJIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> DJPPLOCKAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> JFBKPKKPBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> BPJCIMOKJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> HNNNHCHMJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> NIKEKKNAHPK;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] BBNGICCHEJF;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool HIPCIGDLICP;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static JAMFJPFHGIA[] DFJJHAOPINA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BNJOFFCHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A355B0", Offset = "0x6A33BB0", VA = "0x186A355B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AFEJIIOFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A32BF0", Offset = "0x6A311F0", VA = "0x186A32BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int DDMELFPJCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A307B0", Offset = "0x6A2EDB0", VA = "0x186A307B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CPJCGPAHDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A33260", Offset = "0x6A31860", VA = "0x186A33260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void LGPCDNGKEEH(bool NJKKBBHAKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void HMKBPPKGJLA(bool NJKKBBHAKPC, string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A313B0", Offset = "0x6A2F9B0", VA = "0x186A313B0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A31B30", Offset = "0x6A30130", VA = "0x186A31B30")]
	public void JCIAKJHFOHL(int NMFJOEOKFMG, int GGOJGFOPPLP, Allocator JKHEKCINHDP, bool OFBNDOJAOEK, bool EJOIHPCHLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A314C0", Offset = "0x6A2FAC0", VA = "0x186A314C0")]
	public void FPMOFIBBEBM(int NMFJOEOKFMG, int GGOJGFOPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A342F0", Offset = "0x6A328F0", VA = "0x186A342F0", Slot = "6")]
	public bool NHGIJENIJNH(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A31750", Offset = "0x6A2FD50", VA = "0x186A31750")]
	public bool HFPKFMIHFEL(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A34C10", Offset = "0x6A33210", VA = "0x186A34C10")]
	public bool PLDLEILNEFH(Mesh GOBEKKOCOLP, DJMGOGABOMJ INGLLNLGECG, bool PHBFEHNGLJJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A30870", Offset = "0x6A2EE70", VA = "0x186A30870")]
	public void DIGMMHJBDOO(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A31E00", Offset = "0x6A30400", VA = "0x186A31E00")]
	public void KCBHHPPPEPC(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A34B50", Offset = "0x6A33150", VA = "0x186A34B50")]
	[BurstCompile]
	public static int OLBAOLFIBAP(float OEMFOJFNECE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A34AB0", Offset = "0x6A330B0", VA = "0x186A34AB0")]
	[BurstCompile]
	public static uint OLBAOLFIBAP([In] float4 ONOKCMNNMGN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A34B00", Offset = "0x6A33100", VA = "0x186A34B00")]
	[BurstCompile]
	public static uint OLBAOLFIBAP([In] float3 ONOKCMNNMGN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A33CC0", Offset = "0x6A322C0", VA = "0x186A33CC0")]
	public void NFJCDJJPDDB(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A345E0", Offset = "0x6A32BE0", VA = "0x186A345E0")]
	[BurstCompile]
	private unsafe static void NMPEPEKMNCC([NoAlias] FPKFMDKIHMB* DFDNLBBDNHN, int FAHHAAGBGJO, [In][NoAlias] float3* EPEMDDHEPAK, [In][NoAlias] float3* JDHABOMIFGO, [In][NoAlias] float4* CMOHCJFAEON, [In][NoAlias] float2* PEBBEDAOPHO, [In][NoAlias] float4* OFIJEGLHMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A32C30", Offset = "0x6A31230", VA = "0x186A32C30")]
	public void LAAKNLKOCMI(Mesh GOBEKKOCOLP, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A307F0", Offset = "0x6A2EDF0", VA = "0x186A307F0")]
	[BurstCompile]
	private unsafe static void BOFFJCGNEMO([NoAlias] HKJHCFFMJCB* DFDNLBBDNHN, int FAHHAAGBGJO, [In][NoAlias] float3* EPEMDDHEPAK, [In][NoAlias] float3* JDHABOMIFGO, [In][NoAlias] float4* CMOHCJFAEON, [In][NoAlias] float2* PEBBEDAOPHO, [In][NoAlias] float4* OFIJEGLHMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A312C0", Offset = "0x6A2F8C0", VA = "0x186A312C0")]
	public void DLFAMGKEBNO(Mesh GOBEKKOCOLP, CKFJLIODADD GCFIDHFGDMF, bool PHBFEHNGLJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A332A0", Offset = "0x6A318A0", VA = "0x186A332A0")]
	public void MHNGNGPDOJG(DJMGOGABOMJ GOBEKKOCOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A31610", Offset = "0x6A2FC10", VA = "0x186A31610")]
	public DJMGOGABOMJ GOBEFKIIDAP(Allocator JKHEKCINHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A35420", Offset = "0x6A33A20", VA = "0x186A35420")]
	public long PLGJBOMFIKE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A35550", Offset = "0x6A33B50", VA = "0x186A35550")]
	public static long PLGJBOMFIKE(int MNOIBGNGGCD, int ALPIEBPCJMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A33B60", Offset = "0x6A32160", VA = "0x186A33B60")]
	public static long NCPDLKOOJHG(int MNOIBGNGGCD, int ALPIEBPCJMA, CKFJLIODADD GCFIDHFGDMF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A33C00", Offset = "0x6A32200", VA = "0x186A33C00")]
	public long NCPDLKOOJHG(CKFJLIODADD GCFIDHFGDMF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A355F0", Offset = "0x6A33BF0", VA = "0x186A355F0")]
	public void POOCBMGAGDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A32880", Offset = "0x6A30E80", VA = "0x186A32880")]
	public static void KHFLGBFODEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A33510", Offset = "0x6A31B10", VA = "0x186A33510")]
	public CKFJLIODADD MPDEKIHLLOH()
	{
		return default(CKFJLIODADD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A31540", Offset = "0x6A2FB40", VA = "0x186A31540")]
	public static (int, int) GAKMEOGLMEC(Mesh GOBEKKOCOLP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A31D20", Offset = "0x6A30320", VA = "0x186A31D20")]
	public static int JJEDOFLBDCP(VertexAttributeDescriptor[] MAPIJLHOANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A34BA0", Offset = "0x6A331A0", VA = "0x186A34BA0")]
	public static long PHGHGKAFHJM(Mesh GOBEKKOCOLP, int FJEDDOMKBLI, int CJMJINCHPCC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DJMGOGABOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A34540", Offset = "0x6A32B40", VA = "0x186A34540")]
	[BurstCompile]
	public static int NJCEAEMFOJO(float OEMFOJFNECE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A34300", Offset = "0x6A32900", VA = "0x186A34300")]
	[BurstCompile]
	public static uint NJCEAEMFOJO([In] float4 ONOKCMNNMGN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A34490", Offset = "0x6A32A90", VA = "0x186A34490")]
	[BurstCompile]
	public static uint NJCEAEMFOJO([In] float3 ONOKCMNNMGN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A30400", Offset = "0x6A2EA00", VA = "0x186A30400")]
	[BurstCompile]
	public unsafe static void BGFFPJGJDLJ([NoAlias] FPKFMDKIHMB* DFDNLBBDNHN, int FAHHAAGBGJO, [In][NoAlias] float3* EPEMDDHEPAK, [In][NoAlias] float3* JDHABOMIFGO, [In][NoAlias] float4* CMOHCJFAEON, [In][NoAlias] float2* PEBBEDAOPHO, [In][NoAlias] float4* OFIJEGLHMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A34660", Offset = "0x6A32C60", VA = "0x186A34660")]
	[BurstCompile]
	public unsafe static void ODOAPLPCGBL([NoAlias] HKJHCFFMJCB* DFDNLBBDNHN, int FAHHAAGBGJO, [In][NoAlias] float3* EPEMDDHEPAK, [In][NoAlias] float3* JDHABOMIFGO, [In][NoAlias] float4* CMOHCJFAEON, [In][NoAlias] float2* PEBBEDAOPHO, [In][NoAlias] float4* OFIJEGLHMCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class PPHDALJONJC
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6A43DD0", Offset = "0x6A423D0", VA = "0x186A43DD0")]
	public static void GMBCHGJGFOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MAKAHNEAGMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> HNJCAHJIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> DJPPLOCKAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> EFMOIJBHFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> IJMFFHDOAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> BCFBGDCKJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> HCGHDDACEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> OPJCKBOKPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> NIKEKKNAHPK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int AFEJIIOFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6A426D0", Offset = "0x6A40CD0", VA = "0x186A426D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int DDMELFPJCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6A41B70", Offset = "0x6A40170", VA = "0x186A41B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BMPLBFBDHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6A42A10", Offset = "0x6A41010", VA = "0x186A42A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6A42D40", Offset = "0x6A41340", VA = "0x186A42D40")]
	public MAKAHNEAGMG(int NMFJOEOKFMG, int GGOJGFOPPLP, int DDGAFAHLNII, Allocator JKHEKCINHDP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6A42A50", Offset = "0x6A41050", VA = "0x186A42A50")]
	public MAKAHNEAGMG(Mesh GOBEKKOCOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6A41BB0", Offset = "0x6A401B0", VA = "0x186A41BB0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6A42710", Offset = "0x6A40D10", VA = "0x186A42710")]
	public void MHNGNGPDOJG(MAKAHNEAGMG GOBEKKOCOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6A42240", Offset = "0x6A40840", VA = "0x186A42240")]
	private void GMNPFNMNMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6A41CC0", Offset = "0x6A402C0", VA = "0x186A41CC0")]
	private void FENDHCBCNKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct NGBNIJNLBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int EODEFGNHAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int AFEJIIOFHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int DLODIBNHDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int DDMELFPJCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x14D3690", Offset = "0x14D1C90", VA = "0x1814D3690")]
	public NGBNIJNLBKN(int IIEIJMEHMME, int FAHHAAGBGJO, int CHEJIFFIDLB, int LMAHIFIDCDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class FBGABEHDBDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<NGBNIJNLBKN> CGCJCPOOJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x9B1620", Offset = "0x9AFC20", VA = "0x1809B1620")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<NGBNIJNLBKN>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA94580", Offset = "0xA92B80", VA = "0x180A94580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MAKAHNEAGMG GIOEAFGNOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6A35FB0", Offset = "0x6A345B0", VA = "0x186A35FB0")]
	public FBGABEHDBDE(IEnumerable<MAKAHNEAGMG> OEALEMPBMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6A35F40", Offset = "0x6A34540", VA = "0x186A35F40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum MPAMKPKAOII
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class FCIMEOBFHHC
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> INLNPODHGNL;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> BPHFBPHFLLB;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> IOFEABONAAH;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> FDMGJFAIDFC;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6A36660", Offset = "0x6A34C60", VA = "0x186A36660")]
	public static void GMBCHGJGFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6A36970", Offset = "0x6A34F70", VA = "0x186A36970")]
	public static NativeArray<float2> OLPMPNNCLIM(NativeArray<float2> ANHDPMLOHAJ, int PFDNOPNOAAO, NativeArray<float2> LAFLEGKPNMA, int BBOAJFAJBDK)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6A36560", Offset = "0x6A34B60", VA = "0x186A36560")]
	public static NativeArray<float3> AHNBPDLKBLE(NativeArray<float3> ANHDPMLOHAJ, int PFDNOPNOAAO, NativeArray<float3> LAFLEGKPNMA, int BBOAJFAJBDK)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6A36870", Offset = "0x6A34E70", VA = "0x186A36870")]
	public static NativeArray<float4> IBLJOMLFJLG(NativeArray<float4> ANHDPMLOHAJ, int PFDNOPNOAAO, NativeArray<float4> LAFLEGKPNMA, int BBOAJFAJBDK)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6A36770", Offset = "0x6A34D70", VA = "0x186A36770")]
	public static NativeArray<int> HPHBMLBMLHL(NativeArray<int> ANHDPMLOHAJ, int PFDNOPNOAAO, NativeArray<int> LAFLEGKPNMA, int BBOAJFAJBDK)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CA00", Offset = "0x2B4B000", VA = "0x182B4CA00")]
	private static void ODNHDJBNHJO<T>(NativeArray<T> NMHOKLPDKBK, int EGJPFNLBEDP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C920", Offset = "0x2B4AF20", VA = "0x182B4C920")]
	private static void EJHCHCJGOOA<T>(NativeArray<T> ANHDPMLOHAJ, int PFDNOPNOAAO, NativeArray<T> LAFLEGKPNMA, int BBOAJFAJBDK, NativeArray<T> LGADPNDLANG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class KADMODPOMOL
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum DBAMBPACMII
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
	public class MHAJJFIPJBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public FOJKGPNIEMD GOBEKKOCOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int EOANHDIHIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int EBIPGDADNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long JLANLDPEGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long OICAMFONHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float LDNOCPOLOEG;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6A43050", Offset = "0x6A41650", VA = "0x186A43050")]
		public MHAJJFIPJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6A43010", Offset = "0x6A41610", VA = "0x186A43010")]
		public void BEBGJICOPHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string DBMABPDIHLI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string CFCFNGKLPLJ;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker GNAEMONANGG;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker LFFHDGLOFNE;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker FOHPLDCDCPM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker CPFDFIHJODI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker KPMOHLBNFME;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker CPGNIEGIDDK;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker GFAJIBAHIAN;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker FLFNCIONPPO;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker ECPPHJPBDCH;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker FHEHMEAMGFH;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker OEKGJAHKFGC;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker CGPNBKHLHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<CGJEKNFHMIM> PFDOCCGACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly DHCKKIGFMDM JAFDGNJPBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int FAHHAAGBGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int LMAHIFIDCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool ODKJKLPFFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool DBKPHFJHFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal DBAMBPACMII HJBEGIDNCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool MFMJPDBJNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 GFKHMJOEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 PPFOGLILFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float NDIONHEDFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float OKKLIGILKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int HBGNBKJEALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int AEKGFOKEION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int LLHPMLLMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int IIDKOIIBMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float EEBADENJDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float MLPHPAKOGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int KOIMOOPMJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long IOCMGBIFLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long DINPEAFBGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long ABJFAAIIPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int BJGIJPCMKII;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int IHHFIAODFOM = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] CNLAKEAADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] NKOEAIHFMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] PIAFCCNFINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private DJMGOGABOMJ AONLFBCBBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long IGFOJGIBEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long IGHEDDNMCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int KHCKHFBBHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<MHAJJFIPJBL> ANNPKNIPMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float GHHDNMNHOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal DJMGOGABOMJ.CKFJLIODADD NNOEOHJDHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool ENNMMAAIHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private BILNOBINGCI MBLNGKBKADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle KKILHODJEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> HLMOJLIECAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool PKCFFBAOEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle JODNHKKNDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private DJMGOGABOMJ NIBGFNNOFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform IKLAENLPBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private NHHHNHFBJDC LGCAHKAFMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long NMDONPJKFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long MJBLADKJELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long JLEFPIGJCGM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh GIOEAFGNOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x860CF0", Offset = "0x85F2F0", VA = "0x180860CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer PMEDNLCGMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x860D10", Offset = "0x85F310", VA = "0x180860D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EIMDJPIMMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9A5350", Offset = "0x9A3950", VA = "0x1809A5350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int NPEHCIFBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x95F480", Offset = "0x95DA80", VA = "0x18095F480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int AFEJIIOFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EA90", Offset = "0x6A3D090", VA = "0x186A3EA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<CGJEKNFHMIM> EDFOFLLMALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void HMKBPPKGJLA(bool NJKKBBHAKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void LGPCDNGKEEH(bool NJKKBBHAKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void HMKBPPKGJLA(bool NJKKBBHAKPC, string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F850", Offset = "0x6A3DE50", VA = "0x186A3F850")]
	public void MNHKLMBBIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D5A0", Offset = "0x6A3BBA0", VA = "0x186A3D5A0")]
	private void GABCADKLJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6A416E0", Offset = "0x6A3FCE0", VA = "0x186A416E0")]
	public KADMODPOMOL(string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6A39010", Offset = "0x6A37610", VA = "0x186A39010")]
	public void BEBGJICOPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6A40F60", Offset = "0x6A3F560", VA = "0x186A40F60")]
	public void OMEHJCAPICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D230", Offset = "0x6A3B830", VA = "0x186A3D230")]
	private void EEBDACKMMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F680", Offset = "0x6A3DC80", VA = "0x186A3F680")]
	public void MDMMLBIOPGC(CGJEKNFHMIM HMIBIEKANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6A41200", Offset = "0x6A3F800", VA = "0x186A41200")]
	public bool PEALNJIBMPG(CGJEKNFHMIM HMIBIEKANJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DA00", Offset = "0x6A3C000", VA = "0x186A3DA00")]
	public bool GJJPBLIIILJ(CGJEKNFHMIM HMIBIEKANJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6A40D10", Offset = "0x6A3F310", VA = "0x186A40D10", Slot = "4")]
	public virtual void OCBMFHAPIKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E840", Offset = "0x6A3CE40", VA = "0x186A3E840")]
	public void KADOPLMNGPI(Transform GEJNFOBHGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D4C0", Offset = "0x6A3BAC0", VA = "0x186A3D4C0")]
	private long FKFNBAKFCEK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6A37860", Offset = "0x6A35E60", VA = "0x186A37860")]
	private long AFBHJNHMCLN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FBE0", Offset = "0x6A3E1E0", VA = "0x186A3FBE0")]
	public bool NHOFJBEPBCA(Transform GEJNFOBHGNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6A39B80", Offset = "0x6A38180", VA = "0x186A39B80")]
	public bool COAPJAGKMMA(bool PAKFOILEOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C430", Offset = "0x6A3AA30", VA = "0x186A3C430")]
	public void DPPDBPNHBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6A37A10", Offset = "0x6A36010", VA = "0x186A37A10")]
	public bool AOAAFMELFMB(float4x4 FNMJLMPIBAK, BatchedMeshRenderer NPHDEJBNIIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E5E0", Offset = "0x6A3CBE0", VA = "0x186A3E5E0")]
	public void JNDFNGPALFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F860", Offset = "0x6A3DE60", VA = "0x186A3F860")]
	public bool MPDNHIHCPNB(bool PAKFOILEOHM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A37A00", Offset = "0x6A36000", VA = "0x186A37A00")]
	public void ANONHAHODCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A39130", Offset = "0x6A37730", VA = "0x186A39130")]
	public void BGCMFINMMHH(DJMGOGABOMJ GOBEKKOCOLP, int BFANOKHBCJC, int HJJGKEDGCDK, float ALHOAIFMGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D9D0", Offset = "0x6A3BFD0", VA = "0x186A3D9D0")]
	public void GEPMJBJECKB(FOJKGPNIEMD MCMIBGOIKEG, int BFANOKHBCJC, int HJJGKEDGCDK, float ALHOAIFMGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A412A0", Offset = "0x6A3F8A0", VA = "0x186A412A0")]
	public (long, long, long) PLGJBOMFIKE()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xAC1500", Offset = "0xABFB00", VA = "0x180AC1500")]
	public long FGLALKLAIDE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A40DC0", Offset = "0x6A3F3C0", VA = "0x186A40DC0")]
	private void OGFPABJJJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E220", Offset = "0x6A3C820", VA = "0x186A3E220")]
	public (long, long) HMCAHJKFFFH(float FIDLNFFOKJE, float4x4 FNMJLMPIBAK)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	public void FOCJOKDMFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A39A60", Offset = "0x6A38060", VA = "0x186A39A60")]
	internal void CBPNCCIDCJG(DBAMBPACMII GKOJOJGKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EAB0", Offset = "0x6A3D0B0", VA = "0x186A3EAB0")]
	private (float, float, float) LBEPAKDEKHO(float LJJPMINCCGN, float4x4 FNMJLMPIBAK)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6A374B0", Offset = "0x6A35AB0", VA = "0x186A374B0")]
	private (int, int) ADDGBNEFEML(float IJGJBFKJIOF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AEE0", Offset = "0x6A394E0", VA = "0x186A3AEE0")]
	public void DKBNFBDEGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6A379D0", Offset = "0x6A35FD0", VA = "0x186A379D0")]
	private void AGMGJDGJAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6A41020", Offset = "0x6A3F620", VA = "0x186A41020")]
	private void OOICEBECELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DA60", Offset = "0x6A3C060", VA = "0x186A3DA60")]
	public long GNDDDBEANKC(long HELHKDAINPA, int BHLKGHECMCO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A39160", Offset = "0x6A37760", VA = "0x186A39160")]
	private void CAFDHHFNOMO(DJMGOGABOMJ FJJEAGOIEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C100", Offset = "0x6A3A700", VA = "0x186A3C100")]
	private void DMENMNCLANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C620", Offset = "0x6A3AC20", VA = "0x186A3C620")]
	private void ECNOMANIKGI(DJMGOGABOMJ GOBEKKOCOLP, FOJKGPNIEMD MCMIBGOIKEG, int BFANOKHBCJC, int HJJGKEDGCDK, float ALHOAIFMGGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct BILNOBINGCI : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct JALLDEINLKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int KKEKAAAOAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int AODHPIKJEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int MDNCGMNLGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int BDIBLFMAOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int NGFAPHHDKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int HBOAFBEFGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int EOANHDIHIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int EBIPGDADNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float LDNOCPOLOEG;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct GLNMIMJOOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CNBDAFCPLGE.IPMKAOPECOE PMFMCGJBGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float BKHJKIENHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float MOLCIKAMMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float KHJPBMCBEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float NHBDCLINIJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float NJAPKAJDBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float OKBFOKBJACE;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct PJFEIBHIOIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> HNJCAHJIDBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> DJPPLOCKAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> JFBKPKKPBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> BPJCIMOKJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> HNNNHCHMJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> NIKEKKNAHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool APECHNJIIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int AFEJIIOFHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int DDMELFPJCAJ;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EE90", Offset = "0x6A4D490", VA = "0x186A4EE90")]
		public void JCIAKJHFOHL(int NMFJOEOKFMG, int GGOJGFOPPLP, Allocator JKHEKCINHDP, bool EJOIHPCHLKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EC40", Offset = "0x6A4D240", VA = "0x186A4EC40")]
		public static PJFEIBHIOIB ECEGKCODJDO(DJMGOGABOMJ BOIMHPNGCKI)
		{
			return default(PJFEIBHIOIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB80", Offset = "0x6A4D180", VA = "0x186A4EB80")]
		public void BEBGJICOPHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker PPHPDCKCIIF;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker IJOMNAOPPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<JALLDEINLKE> PPCHBGNCABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private PJFEIBHIOIB FEIDIILNKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private PJFEIBHIOIB FJJEAGOIEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 NCLBHOGDALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 KAKOAKBHFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private GLNMIMJOOGJ DELFFJFFLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* LNPPHIDIIIL;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	[BurstDiscard]
	private static void HMKBPPKGJLA(bool NJKKBBHAKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	[BurstDiscard]
	private static void LGPCDNGKEEH(bool NJKKBBHAKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	[BurstDiscard]
	private static void HMKBPPKGJLA(bool NJKKBBHAKPC, string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FD20", Offset = "0x6A2E320", VA = "0x186A2FD20")]
	public BILNOBINGCI([In] List<KADMODPOMOL.MHAJJFIPJBL> PEKKBPCHMNP, [In] DJMGOGABOMJ JEEBHHEOIME, [In] KADMODPOMOL GKFNHPKEIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E040", Offset = "0x6A2C640", VA = "0x186A2E040", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F5D0", Offset = "0x6A2DBD0", VA = "0x186A2F5D0")]
	public void KMPJFBHNCHJ(List<KADMODPOMOL.MHAJJFIPJBL> OLHBLKNMEPM, [In] KADMODPOMOL GKFNHPKEIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E090", Offset = "0x6A2C690", VA = "0x186A2E090")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool FBFCGNBGKBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F500", Offset = "0x6A2DB00", VA = "0x186A2F500")]
	private FOJKGPNIEMD JGKACDFLOCD(int IBAGDMCAJOF, Allocator JKHEKCINHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E1B0", Offset = "0x6A2C7B0", VA = "0x186A2E1B0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void IFKJJLPMMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DCD0", Offset = "0x6A2C2D0", VA = "0x186A2DCD0")]
	[IgnoreWarning(1371)]
	private JALLDEINLKE CNEKJNDEOGI([In] JALLDEINLKE CECAAHOFFOD, int IEKMPOKHKNG, [In] NativeArray<int> APHCOANLCOE, [In] NativeArray<bool> PLPAHNIBLPD, NativeArray<int> HDIIEIDDKIB)
	{
		return default(JALLDEINLKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E0B0", Offset = "0x6A2C6B0", VA = "0x186A2E0B0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int FEOBFNDIGHK(NativeArray<int> APHCOANLCOE, int IGCJANKLBNP, int NCIPFAJOHBB, int NPHHPDGEGCE)
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
		public static readonly CHNLCLDOCNE log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker IFAJAFFIBBF;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker GIJOMHGMPMI;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker ABJKKIFPEKI;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker PEKBJJNHFGO;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker GECCMBPBKHJ;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker KPMOHLBNFME;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker PAHDBDPHPPK;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int LEHCFJOPOHH = 65000;

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
		private Dictionary<Material, List<KADMODPOMOL>> DPIKGFLCIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<KADMODPOMOL> KANMLKHJKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> LKGMHPIKAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool KMGPPOHHGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool LPGNDPGIKJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int IIHGICNBHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> MIKGCAIEILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> FCBBNFMDIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> LMIHMEENIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> ONEPODOHDJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private KADMODPOMOL BLCFJHJPBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material BOBDEENEPGC;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int DLNELFMBBED = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, CGJEKNFHMIM)> JONNCCNAILH;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> DNLOJMIIDMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int NMHMHNNJMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x6A49BD0", Offset = "0x6A481D0", VA = "0x186A49BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		private static void HMKBPPKGJLA(bool NJKKBBHAKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		private static void HMKBPPKGJLA(bool NJKKBBHAKPC, string DICMABMCPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6A465B0", Offset = "0x6A44BB0", VA = "0x186A465B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6A44350", Offset = "0x6A42950", VA = "0x186A44350")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6A44120", Offset = "0x6A42720", VA = "0x186A44120")]
		public KADMODPOMOL AddToBatchedMesh(CGJEKNFHMIM OFKIOKDPIFH, Material JFOAGNGANHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6A48D10", Offset = "0x6A47310", VA = "0x186A48D10")]
		public void RemoveFromBatchedMesh(CGJEKNFHMIM GOBEKKOCOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6A44220", Offset = "0x6A42820", VA = "0x186A44220")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6A494E0", Offset = "0x6A47AE0", VA = "0x186A494E0")]
		public void SetMaterialProperty(int NLDMBEEEBGH, Color KOEHPNBNNJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6A490B0", Offset = "0x6A476B0", VA = "0x186A490B0")]
		public void SetMaterialProperty(int NLDMBEEEBGH, float FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6A492C0", Offset = "0x6A478C0", VA = "0x186A492C0")]
		public void SetMaterialProperty(int NLDMBEEEBGH, Vector4 ONNMCJGKOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6A48E50", Offset = "0x6A47450", VA = "0x186A48E50")]
		public void SetMaterialProperty(int NLDMBEEEBGH, Matrix4x4 HOGBHILGLBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6A445C0", Offset = "0x6A42BC0", VA = "0x186A445C0")]
		private void GNEHOGMHKEO(Renderer AEAIBJINKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6A44520", Offset = "0x6A42B20", VA = "0x186A44520")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6A44510", Offset = "0x6A42B10", VA = "0x186A44510")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6A453B0", Offset = "0x6A439B0", VA = "0x186A453B0")]
		private void KHIIDPHAAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6A44BB0", Offset = "0x6A431B0", VA = "0x186A44BB0")]
		private KADMODPOMOL GOOADGOPOLJ(CGJEKNFHMIM GOBEKKOCOLP, Material JFOAGNGANHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6A45D30", Offset = "0x6A44330", VA = "0x186A45D30")]
		private KADMODPOMOL KKBHOMHCKKI(Material JFOAGNGANHG, int JPNJFGEFJKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6A45900", Offset = "0x6A43F00", VA = "0x186A45900")]
		private KADMODPOMOL KJEDEOMOKOD(Material JFOAGNGANHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1980C50", Offset = "0x197F250", VA = "0x181980C50")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6A46090", Offset = "0x6A44690", VA = "0x186A46090")]
		public void MarkDirty(CGJEKNFHMIM GOBEKKOCOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6A461F0", Offset = "0x6A447F0", VA = "0x186A461F0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float FIDLNFFOKJE)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6A47DB0", Offset = "0x6A463B0", VA = "0x186A47DB0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6A44E40", Offset = "0x6A43440", VA = "0x186A44E40")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6A468A0", Offset = "0x6A44EA0", VA = "0x186A468A0")]
		public void RebatchOptimally(int EPBOLPALLNL, int FMLCOHMFABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6A49960", Offset = "0x6A47F60", VA = "0x186A49960")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class HAOJKKHECAN
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct LDKKFGGIGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float EDPFBBHDDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer FMHMOKPDFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public KADMODPOMOL PBHFJCIAHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long HCHJCFJJNNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class KJELJMJKCKH : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA08B20", Offset = "0xA07120", VA = "0x180A08B20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A4EA10", Offset = "0x6A4D010", VA = "0x186A4EA10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xB64A30", Offset = "0xB63030", VA = "0x180B64A30")]
		[DebuggerHidden]
		public KJELJMJKCKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA60", Offset = "0x6A4D060", VA = "0x186A4EA60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DC70", Offset = "0x6A4C270", VA = "0x186A4DC70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E8C0", Offset = "0x6A4CEC0", VA = "0x186A4E8C0")]
		private void OGHBNIPNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DC20", Offset = "0x6A4C220", VA = "0x186A4DC20")]
		private void MKLBAOAGFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E9C0", Offset = "0x6A4CFC0", VA = "0x186A4E9C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E910", Offset = "0x6A4CF10", VA = "0x186A4E910", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E910", Offset = "0x6A4CF10", VA = "0x186A4E910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker KPMOHLBNFME;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker POLGJOOLIDC;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker GCLMGKDHLGO;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker LJCNDCGEHIA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 OHDIBIHHBFF;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int OBKOFMMMHKL;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int LOMEJLLLDLC;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int EEKKBONAGMK;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int BNNNMCAMMGL;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int IEJJPDMBFFO;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int FIHIPFGLNAH;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int JIOMHKMJNLN;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int CKILJCLFMLB;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int DDIDCKLEKHE;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int KKPOMICPBPB;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int GGDJAPKDDDN;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int BNOAACLMHHM;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int CDCMICBBMGF;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int HEPJOAFGBGP;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long EMEPPLBGKAJ;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long PGNOJNGCFON;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int PONCJFAGEBJ;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int LMMAMOIAIEA;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int NHKEOMGNBEK;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long AGHNIHBBEJM;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool EFNIPAENIEM;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> PIFLGJJNJFJ;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<LDKKFGGIGNC> IPMLFGBNLIH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool LCHCBFIFHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D770", Offset = "0x6A4BD70", VA = "0x186A4D770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void HMKBPPKGJLA(bool NJKKBBHAKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void LGPCDNGKEEH(bool NJKKBBHAKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void HMKBPPKGJLA(bool NJKKBBHAKPC, string DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CEB0", Offset = "0x6A4B4B0", VA = "0x186A4CEB0")]
	public static void HACFLNNNDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D490", Offset = "0x6A4BA90", VA = "0x186A4D490")]
	public static void KDCNHMEIGFA(BatchedMeshRenderer LNFBIEGLMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C6C0", Offset = "0x6A4ACC0", VA = "0x186A4C6C0")]
	public static void CPNAIHKDCIB(BatchedMeshRenderer LNFBIEGLMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CDA0", Offset = "0x6A4B3A0", VA = "0x186A4CDA0")]
	private static (long, long, long) GOFCLGIJMDK(long CPOPGEKNNCP)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6A49C20", Offset = "0x6A48220", VA = "0x186A49C20")]
	public static void AOAAFMELFMB(long CPOPGEKNNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CA10", Offset = "0x6A4B010", VA = "0x186A4CA10")]
	public static long GNDDDBEANKC(long HELHKDAINPA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D800", Offset = "0x6A4BE00", VA = "0x186A4D800")]
	public static void PODLMGNGCKE(KADMODPOMOL PBHFJCIAHNF, BatchedMeshRenderer FMHMOKPDFGM, long HCHJCFJJNNJ, float EDPFBBHDDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D390", Offset = "0x6A4B990", VA = "0x186A4D390")]
	public static void JECHEHGNBEI(KADMODPOMOL PBHFJCIAHNF, BatchedMeshRenderer FMHMOKPDFGM, long HCHJCFJJNNJ, float DOCCHMMANHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C900", Offset = "0x6A4AF00", VA = "0x186A4C900")]
	public static void GIOBKJGEAAJ(KADMODPOMOL PBHFJCIAHNF, BatchedMeshRenderer FMHMOKPDFGM, long HCHJCFJJNNJ, float DOCCHMMANHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C760", Offset = "0x6A4AD60", VA = "0x186A4C760")]
	public static void EAFLCGAGLAG(KADMODPOMOL PBHFJCIAHNF, BatchedMeshRenderer FMHMOKPDFGM, long HCHJCFJJNNJ, float EDPFBBHDDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C1A0", Offset = "0x6A4A7A0", VA = "0x186A4C1A0")]
	public static float BCOIJLPGHBC(long NCALJABGLIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D050", Offset = "0x6A4B650", VA = "0x186A4D050")]
	public static (long, long) HMCAHJKFFFH(float FIDLNFFOKJE)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D6E0", Offset = "0x6A4BCE0", VA = "0x186A4D6E0")]
	[IteratorStateMachine(typeof(KJELJMJKCKH))]
	public static IEnumerable<bool> KIFOPJJHKDA(long EIHFMBOPPBJ, bool OOMNHAJNDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D220", Offset = "0x6A4B820", VA = "0x186A4D220")]
	public static void IGFJEBLLOMB(long EIHFMBOPPBJ, bool OOMNHAJNDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C580", Offset = "0x6A4AB80", VA = "0x186A4C580")]
	public static int BFFIMOJCJNO()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class BFPKMGLHIFB<KeyType> : KADMODPOMOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, CGJEKNFHMIM> IOAEDNLNKLH;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4F091A0", Offset = "0x4F077A0", VA = "0x184F091A0")]
	public BFPKMGLHIFB(string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4F08D10", Offset = "0x4F07310", VA = "0x184F08D10")]
	public void MDMMLBIOPGC(KeyType MNBFPOFIDHA, CGJEKNFHMIM HMIBIEKANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4F090A0", Offset = "0x4F076A0", VA = "0x184F090A0")]
	public bool OIPEJPDGDGO(KeyType MNBFPOFIDHA, CGJEKNFHMIM DFCIMDMJOBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4F08DE0", Offset = "0x4F073E0", VA = "0x184F08DE0")]
	public void ODEHNELLCGP(KeyType MNBFPOFIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4F08D80", Offset = "0x4F07380", VA = "0x184F08D80", Slot = "4")]
	public override void OCBMFHAPIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F070", Offset = "0x6A4D670", VA = "0x186A4F070")]
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
