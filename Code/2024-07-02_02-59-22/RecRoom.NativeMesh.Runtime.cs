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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
	public class LogRegistrationIndex : DAMGOKPKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69E9440", Offset = "0x69E8440", VA = "0x1869E9440", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MLEKJJLPPBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int GOAMBPEJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 MHCNNPNLCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion DAGJLEEBCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 IDOHEGKKEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int BOCAFGJDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int POKBFINKFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int FMPOBLJGOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float JGNKNIABCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 FPCJOADJMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool MIMOIHDLAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public ICCDOOKLDAK JLPDLIPNKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 NBOELOFMHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float AMNMCIJIAJL;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NOPNHHMHLEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static GDGOCJIGEDJ EMELJENJCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<MLEKJJLPPBG> JCCBFNIBCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<ENOMGJJDCNC> FCEPGIKBFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<IJNABGLBBPB> INNNIFJKIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<FEGDHMAPLDK> CBGELJHBNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<ENOMGJJDCNC> MCNFHHGPFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<OEPACADIJGK> KLBFFKOFEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<FEGDHMAPLDK>> KIGCIMJHEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<KBHNBLOBCGL> MIFJNPOEEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> BKJOLKKFNKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GHEDKGOGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDC6CB0", Offset = "0xDC5CB0", VA = "0x180DC6CB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDC5600", Offset = "0xDC4600", VA = "0x180DC5600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF00", Offset = "0xA7CF00", VA = "0x180A7DF00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDC55F0", Offset = "0xDC45F0", VA = "0x180DC55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69EC3A0", Offset = "0x69EB3A0", VA = "0x1869EC3A0")]
	public NOPNHHMHLEP(int DBEGMBDLKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69EA690", Offset = "0x69E9690", VA = "0x1869EA690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69EBF20", Offset = "0x69EAF20", VA = "0x1869EBF20")]
	public void NNOPBDMPMBK(JobHandle OPKPNABHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69EBD00", Offset = "0x69EAD00", VA = "0x1869EBD00")]
	public void MFICNAFJHIM(MLEKJJLPPBG FHNKDHIILBL, KBHNBLOBCGL KJOOJPONKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69EBBA0", Offset = "0x69EABA0", VA = "0x1869EBBA0")]
	public void MBHMAMEHLMC(IJNABGLBBPB FHNKDHIILBL, NativeArray<FEGDHMAPLDK> CHPAHJONLEG, int PKIBPAHFPLK, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x69EAB90", Offset = "0x69E9B90", VA = "0x1869EAB90")]
	public JobHandle LFDBHHCAOLP(JEJBOBIDBPC JBBBIKDPABP, GHPIIHCLOKF GANMOBPECHM, float3 COEHKDCGGHK, quaternion EKCEGBNOFLE, float FILPOAJBJGN, bool BHPPMDIMEKO, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69EA850", Offset = "0x69E9850", VA = "0x1869EA850")]
	public static JobHandle IGKNDDDPDMG(EJFDPLIAJPB DMMAFGOOFGK, JEJBOBIDBPC JBBBIKDPABP, MLEKJJLPPBG FHNKDHIILBL, JobHandle OPKPNABHNJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69EC0F0", Offset = "0x69EB0F0", VA = "0x1869EC0F0")]
	public static JobHandle PPBPFOBDHBA(KJOIGFJGHJJ DMMAFGOOFGK, JEJBOBIDBPC JBBBIKDPABP, IJNABGLBBPB FHNKDHIILBL, NativeArray<FEGDHMAPLDK> CHPAHJONLEG, int PKIBPAHFPLK, int OPOFHOEKKOD, JobHandle OPKPNABHNJC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class ECKOAIDMBHO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BJAAJDPHBMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half MFIJCGPCDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort CMPPDIGNMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte ABMDMHIKFME;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void FBDAPCAGHDK([NoAlias] float3* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class GKMEJFABCPB
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69E25C0", Offset = "0x69E15C0", VA = "0x1869E25C0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69E21A0", Offset = "0x69E11A0", VA = "0x1869E21A0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69E2300", Offset = "0x69E1300", VA = "0x1869E2300")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69E23B0", Offset = "0x69E13B0", VA = "0x1869E23B0")]
		public unsafe static void NGOOLELHLHP([NoAlias] float3* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void BMKOLJJAMFD([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class BOAEPLALBHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69D5790", Offset = "0x69D4790", VA = "0x1869D5790")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69D52F0", Offset = "0x69D42F0", VA = "0x1869D52F0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69D5450", Offset = "0x69D4450", VA = "0x1869D5450")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69D5500", Offset = "0x69D4500", VA = "0x1869D5500")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void MLIPMPPBIEL([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class JCBDDKKBGME
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69E48B0", Offset = "0x69E38B0", VA = "0x1869E48B0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69E4410", Offset = "0x69E3410", VA = "0x1869E4410")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69E4570", Offset = "0x69E3570", VA = "0x1869E4570")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69E4620", Offset = "0x69E3620", VA = "0x1869E4620")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void CHDELBEHGBK([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class ONCNELDIOMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69ED5D0", Offset = "0x69EC5D0", VA = "0x1869ED5D0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69ED130", Offset = "0x69EC130", VA = "0x1869ED130")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69ED290", Offset = "0x69EC290", VA = "0x1869ED290")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69ED340", Offset = "0x69EC340", VA = "0x1869ED340")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void FGDAMICMCPF([NoAlias] ushort* JFKBJHPGAMG, [Out] float3 HFHJMPLEMEK, [Out] float3 FJEPEOOFHFH, [In][NoAlias] float3* EDGPFEDAAFF, int JJFNDHOPKLA, int AGAKJAKDDAP);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class KGMAOEJKHFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69E5FA0", Offset = "0x69E4FA0", VA = "0x1869E5FA0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69E5B70", Offset = "0x69E4B70", VA = "0x1869E5B70")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69E5CD0", Offset = "0x69E4CD0", VA = "0x1869E5CD0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69E5D80", Offset = "0x69E4D80", VA = "0x1869E5D80")]
		public unsafe static void NGOOLELHLHP([NoAlias] ushort* JFKBJHPGAMG, [Out] float3 HFHJMPLEMEK, [Out] float3 FJEPEOOFHFH, [In][NoAlias] float3* EDGPFEDAAFF, int JJFNDHOPKLA, int AGAKJAKDDAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void HAGFMFBIAAD([NoAlias] ushort* ANOKGEJHKEM, [In][NoAlias] float3* BLHIFFJLDMB, int AGAKJAKDDAP);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class FPPDHBAJGIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69E1680", Offset = "0x69E0680", VA = "0x1869E1680")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69E1280", Offset = "0x69E0280", VA = "0x1869E1280")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69E13E0", Offset = "0x69E03E0", VA = "0x1869E13E0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69E1490", Offset = "0x69E0490", VA = "0x1869E1490")]
		public unsafe static void NGOOLELHLHP([NoAlias] ushort* ANOKGEJHKEM, [In][NoAlias] float3* BLHIFFJLDMB, int AGAKJAKDDAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void EOAAECKEKFN([NoAlias] float3* NDBKOJHGPDL, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class BFCIIBGOBLD
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x69D4BD0", Offset = "0x69D3BD0", VA = "0x1869D4BD0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69D4770", Offset = "0x69D3770", VA = "0x1869D4770")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69D48D0", Offset = "0x69D38D0", VA = "0x1869D48D0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69D4980", Offset = "0x69D3980", VA = "0x1869D4980")]
		public unsafe static void NGOOLELHLHP([NoAlias] float3* NDBKOJHGPDL, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void OLIPHOCJMNG([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class AAOBLJPMGPK
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69D2580", Offset = "0x69D1580", VA = "0x1869D2580")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69D2180", Offset = "0x69D1180", VA = "0x1869D2180")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69D22E0", Offset = "0x69D12E0", VA = "0x1869D22E0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69D2390", Offset = "0x69D1390", VA = "0x1869D2390")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void MKONEAEPFLA([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class AKLODLEIEHC
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x69D3EA0", Offset = "0x69D2EA0", VA = "0x1869D3EA0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69D39D0", Offset = "0x69D29D0", VA = "0x1869D39D0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x69D3B30", Offset = "0x69D2B30", VA = "0x1869D3B30")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69D3BE0", Offset = "0x69D2BE0", VA = "0x1869D3BE0")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void IHAHBLJKMOG([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class CPPKPCBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69D8810", Offset = "0x69D7810", VA = "0x1869D8810")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69D8350", Offset = "0x69D7350", VA = "0x1869D8350")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69D84B0", Offset = "0x69D74B0", VA = "0x1869D84B0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x69D8560", Offset = "0x69D7560", VA = "0x1869D8560")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void MCDEGNGAKKH([NoAlias] ushort* EBHAIPICNJH, [Out] float2 KADBOKJLOPC, [Out] float2 CMMGDJGCDKF, [In][NoAlias] float2* JMBKEBHHGPD, int JJFNDHOPKLA, int AGAKJAKDDAP);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class DFKGKKKBDIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69D9300", Offset = "0x69D8300", VA = "0x1869D9300")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69D8ED0", Offset = "0x69D7ED0", VA = "0x1869D8ED0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69D9030", Offset = "0x69D8030", VA = "0x1869D9030")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x69D90E0", Offset = "0x69D80E0", VA = "0x1869D90E0")]
		public unsafe static void NGOOLELHLHP([NoAlias] ushort* EBHAIPICNJH, [Out] float2 KADBOKJLOPC, [Out] float2 CMMGDJGCDKF, [In][NoAlias] float2* JMBKEBHHGPD, int JJFNDHOPKLA, int AGAKJAKDDAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void MIMENDMPBIK([Out] float2 JJJOOHEBOMO, ushort FOEHGGELLGK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class PGLLHAPINLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x69EE690", Offset = "0x69ED690", VA = "0x1869EE690")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x69EE240", Offset = "0x69ED240", VA = "0x1869EE240")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x69EE3A0", Offset = "0x69ED3A0", VA = "0x1869EE3A0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69EE450", Offset = "0x69ED450", VA = "0x1869EE450")]
		public static void NGOOLELHLHP([Out] float2 JJJOOHEBOMO, ushort FOEHGGELLGK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void EODEEOLPACP([NoAlias] float2* EBHAIPICNJH, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class GEMHLKLKOKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x69E1C50", Offset = "0x69E0C50", VA = "0x1869E1C50")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69E17B0", Offset = "0x69E07B0", VA = "0x1869E17B0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69E1910", Offset = "0x69E0910", VA = "0x1869E1910")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x69E19C0", Offset = "0x69E09C0", VA = "0x1869E19C0")]
		public unsafe static void NGOOLELHLHP([NoAlias] float2* EBHAIPICNJH, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void FPEOLPHAFIC([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class DGIDCFPOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x69D9910", Offset = "0x69D8910", VA = "0x1869D9910")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69D9430", Offset = "0x69D8430", VA = "0x1869D9430")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x69D9590", Offset = "0x69D8590", VA = "0x1869D9590")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x69D9640", Offset = "0x69D8640", VA = "0x1869D9640")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void DGOCFAPMBPF([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class KFLEIOCMFHI
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x69E5A40", Offset = "0x69E4A40", VA = "0x1869E5A40")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x69E5560", Offset = "0x69E4560", VA = "0x1869E5560")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x69E56C0", Offset = "0x69E46C0", VA = "0x1869E56C0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x69E5770", Offset = "0x69E4770", VA = "0x1869E5770")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void AOBKJNKEJAC([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class ABMLIAGJFFG
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x69D2C70", Offset = "0x69D1C70", VA = "0x1869D2C70")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x69D26B0", Offset = "0x69D16B0", VA = "0x1869D26B0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x69D2810", Offset = "0x69D1810", VA = "0x1869D2810")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x69D28C0", Offset = "0x69D18C0", VA = "0x1869D28C0")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void JGMLPAPHBAO([NoAlias] ushort* DPHIFJHGMNM, [In][NoAlias] float4* EGEFFIIDCMM, int JJFNDHOPKLA, int AGAKJAKDDAP);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class LBFBAMOOJFA
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x69E7F70", Offset = "0x69E6F70", VA = "0x1869E7F70")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x69E7B10", Offset = "0x69E6B10", VA = "0x1869E7B10")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69E7C70", Offset = "0x69E6C70", VA = "0x1869E7C70")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D20", Offset = "0x69E6D20", VA = "0x1869E7D20")]
		public unsafe static void NGOOLELHLHP([NoAlias] ushort* DPHIFJHGMNM, [In][NoAlias] float4* EGEFFIIDCMM, int JJFNDHOPKLA, int AGAKJAKDDAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort GGDIMJJMGPF([In] float4 KHEJBBCBNNK);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class CNBIKLMDFFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x69D8220", Offset = "0x69D7220", VA = "0x1869D8220")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x69D7E00", Offset = "0x69D6E00", VA = "0x1869D7E00")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69D7F60", Offset = "0x69D6F60", VA = "0x1869D7F60")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69D8010", Offset = "0x69D7010", VA = "0x1869D8010")]
		public static ushort NGOOLELHLHP([In] float4 KHEJBBCBNNK)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void LHOIHMNDNBC([NoAlias] float4* DPHIFJHGMNM, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class DEIOBPBKDBA
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x69D8DA0", Offset = "0x69D7DA0", VA = "0x1869D8DA0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x69D8940", Offset = "0x69D7940", VA = "0x1869D8940")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x69D8AA0", Offset = "0x69D7AA0", VA = "0x1869D8AA0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x69D8B50", Offset = "0x69D7B50", VA = "0x1869D8B50")]
		public unsafe static void NGOOLELHLHP([NoAlias] float4* DPHIFJHGMNM, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void EBAGONDFDEJ([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class HIHCKJKGPHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x69E2AF0", Offset = "0x69E1AF0", VA = "0x1869E2AF0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x69E26F0", Offset = "0x69E16F0", VA = "0x1869E26F0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x69E2850", Offset = "0x69E1850", VA = "0x1869E2850")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69E2900", Offset = "0x69E1900", VA = "0x1869E2900")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void LEFBEOEONJL([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class NPEJINPMCIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x69ECA80", Offset = "0x69EBA80", VA = "0x1869ECA80")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69EC5B0", Offset = "0x69EB5B0", VA = "0x1869EC5B0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x69EC710", Offset = "0x69EB710", VA = "0x1869EC710")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x69EC7C0", Offset = "0x69EB7C0", VA = "0x1869EC7C0")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void IKKPIMJBLNL([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class BJJINFAFKGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x69D51C0", Offset = "0x69D41C0", VA = "0x1869D51C0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x69D4D00", Offset = "0x69D3D00", VA = "0x1869D4D00")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x69D4E60", Offset = "0x69D3E60", VA = "0x1869D4E60")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x69D4F10", Offset = "0x69D3F10", VA = "0x1869D4F10")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void LBJFOEMKMMA([Out] float4 HJBJAPKPPFA, ushort FOEHGGELLGK);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class LOMAPGONFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x69E9310", Offset = "0x69E8310", VA = "0x1869E9310")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x69E8E80", Offset = "0x69E7E80", VA = "0x1869E8E80")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x69E8FE0", Offset = "0x69E7FE0", VA = "0x1869E8FE0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x69E9090", Offset = "0x69E8090", VA = "0x1869E9090")]
		public static void NGOOLELHLHP([Out] float4 HJBJAPKPPFA, ushort FOEHGGELLGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void CGJNELJHFID([NoAlias] float4* OLGGBKFNAEF, [NoAlias] byte* PKDGCAIBGOC, [Out] int PDBJHIFLKKO, [Out] int EIJKELBOLJH, [NoAlias] float4* HNDBCJANMCI, int JJFNDHOPKLA, int AGAKJAKDDAP);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class ADGGLCLFEMC
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x69D31D0", Offset = "0x69D21D0", VA = "0x1869D31D0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x69D2DA0", Offset = "0x69D1DA0", VA = "0x1869D2DA0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x69D2F00", Offset = "0x69D1F00", VA = "0x1869D2F00")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x69D2FB0", Offset = "0x69D1FB0", VA = "0x1869D2FB0")]
		public unsafe static void NGOOLELHLHP([NoAlias] float4* OLGGBKFNAEF, [NoAlias] byte* PKDGCAIBGOC, [Out] int PDBJHIFLKKO, [Out] int EIJKELBOLJH, [NoAlias] float4* HNDBCJANMCI, int JJFNDHOPKLA, int AGAKJAKDDAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void HPNFCCNDBJH([NoAlias] float4* FGBJBPMAFEK, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class DOJDKHEKGAE
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x69D9F30", Offset = "0x69D8F30", VA = "0x1869D9F30")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x69D9A40", Offset = "0x69D8A40", VA = "0x1869D9A40")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x69D9BA0", Offset = "0x69D8BA0", VA = "0x1869D9BA0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x69D9C50", Offset = "0x69D8C50", VA = "0x1869D9C50")]
		public unsafe static void NGOOLELHLHP([NoAlias] float4* FGBJBPMAFEK, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void OALHPMHDDLE([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class LDNNGKLLDJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x69E8B50", Offset = "0x69E7B50", VA = "0x1869E8B50")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x69E85B0", Offset = "0x69E75B0", VA = "0x1869E85B0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x69E8710", Offset = "0x69E7710", VA = "0x1869E8710")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x69E87C0", Offset = "0x69E77C0", VA = "0x1869E87C0")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void MJCNHAOLKHK([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class EPHKHHCDBHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x69E1050", Offset = "0x69E0050", VA = "0x1869E1050")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x69E0AA0", Offset = "0x69DFAA0", VA = "0x1869E0AA0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x69E0C00", Offset = "0x69DFC00", VA = "0x1869E0C00")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x69E0CB0", Offset = "0x69DFCB0", VA = "0x1869E0CB0")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void NDFHEDADNNL([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class AJBPMCKCPMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x69D38A0", Offset = "0x69D28A0", VA = "0x1869D38A0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x69D3300", Offset = "0x69D2300", VA = "0x1869D3300")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x69D3460", Offset = "0x69D2460", VA = "0x1869D3460")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x69D3510", Offset = "0x69D2510", VA = "0x1869D3510")]
		public unsafe static void NGOOLELHLHP([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int GHPGEGAIFGB([NoAlias] byte* MDMEFCIOLGE, [In][NoAlias] int* LKKNPKMPFHN, int LGEGKNBBNAC);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class NJKONPFICBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x69EA0A0", Offset = "0x69E90A0", VA = "0x1869EA0A0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x69E9C10", Offset = "0x69E8C10", VA = "0x1869E9C10")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x69E9D70", Offset = "0x69E8D70", VA = "0x1869E9D70")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x69E9E20", Offset = "0x69E8E20", VA = "0x1869E9E20")]
		public unsafe static int NGOOLELHLHP([NoAlias] byte* MDMEFCIOLGE, [In][NoAlias] int* LKKNPKMPFHN, int LGEGKNBBNAC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void EFDFMAONIMA([NoAlias] int* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class MGBHMDFEAJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x69E99E0", Offset = "0x69E89E0", VA = "0x1869E99E0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x69E9590", Offset = "0x69E8590", VA = "0x1869E9590")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x69E96F0", Offset = "0x69E86F0", VA = "0x1869E96F0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x69E97A0", Offset = "0x69E87A0", VA = "0x1869E97A0")]
		public unsafe static void NGOOLELHLHP([NoAlias] int* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void PEMOAKLONGA([NoAlias] ushort* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class OBODMEPDBEL
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x69ED000", Offset = "0x69EC000", VA = "0x1869ED000")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x69ECBB0", Offset = "0x69EBBB0", VA = "0x1869ECBB0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x69ECD10", Offset = "0x69EBD10", VA = "0x1869ECD10")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x69ECDC0", Offset = "0x69EBDC0", VA = "0x1869ECDC0")]
		public unsafe static void NGOOLELHLHP([NoAlias] ushort* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void PHCHBCOPEMG([Out] float3 JJJOOHEBOMO, ushort FOEHGGELLGK);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class BEHGEBBGOHF
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x69D4640", Offset = "0x69D3640", VA = "0x1869D4640")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x69D40D0", Offset = "0x69D30D0", VA = "0x1869D40D0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x69D4230", Offset = "0x69D3230", VA = "0x1869D4230")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x69D42E0", Offset = "0x69D32E0", VA = "0x1869D42E0")]
		public static void NGOOLELHLHP([Out] float3 JJJOOHEBOMO, ushort FOEHGGELLGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort JJMEBALIJBH([In] float3 KHEJBBCBNNK);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class LBMNCCFGGIP
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x69E8480", Offset = "0x69E7480", VA = "0x1869E8480")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x69E80A0", Offset = "0x69E70A0", VA = "0x1869E80A0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x69E8200", Offset = "0x69E7200", VA = "0x1869E8200")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x69E82B0", Offset = "0x69E72B0", VA = "0x1869E82B0")]
		public static ushort NGOOLELHLHP([In] float3 KHEJBBCBNNK)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int PKIBPAHFPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int OPOFHOEKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> AEMLGNPCMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> DPOANBHKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> JKIIIELNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> OPOGKFKMMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<BJAAJDPHBMF> FOKAPEBHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> GMJFCAPCPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> DGLAKPCPOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 HOEHFPMPMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 FJEPEOOFHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 HEFHNDLCKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 CMMGDJGCDKF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long BKEFOKNOBCO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long JNNKBFMIGPH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float EEAFPMPKBBL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool DGKGBKGOLOM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GEJFPJEEKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69DF530", Offset = "0x69DE530", VA = "0x1869DF530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69DFF70", Offset = "0x69DEF70", VA = "0x1869DFF70")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69DD210", Offset = "0x69DC210", VA = "0x1869DD210")]
	public static ECKOAIDMBHO GIGNPOIHFIA(Allocator IDMGOAKOEDG, JEJBOBIDBPC CPJANCBBPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69DD3F0", Offset = "0x69DC3F0", VA = "0x1869DD3F0")]
	public static ECKOAIDMBHO GIGNPOIHFIA(Allocator IDMGOAKOEDG, NativeArray<float3> EDGPFEDAAFF, NativeArray<float3> BLHIFFJLDMB, NativeArray<float2> JMBKEBHHGPD, NativeArray<float4> HNDBCJANMCI, bool HCAAIKOCKDP, NativeArray<float4> ANMLDFBBOKD, NativeArray<int> LKKNPKMPFHN, int PKIBPAHFPLK, int PPKLMNAPBHF, int OPOFHOEKKOD, int JJFNDHOPKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69DCC30", Offset = "0x69DBC30", VA = "0x1869DCC30")]
	public JEJBOBIDBPC GICNANALPNF(Allocator IDMGOAKOEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69E04F0", Offset = "0x69DF4F0", VA = "0x1869E04F0")]
	public void OMNFHIEFOAK(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69DB990", Offset = "0x69DA990", VA = "0x1869DB990")]
	private void DLCKIBNLAFH(Mesh NKIMIKOLCFE, NativeArray<ushort> FBCPOFHPDCF, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69DA720", Offset = "0x69D9720", VA = "0x1869DA720")]
	public void BMDKJPNJILE(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69DE9F0", Offset = "0x69DD9F0", VA = "0x1869DE9F0")]
	public void KDMMNICIBHI(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69DAFB0", Offset = "0x69D9FB0", VA = "0x1869DAFB0")]
	public void CKEOBCJHBBI(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69E07B0", Offset = "0x69DF7B0", VA = "0x1869E07B0")]
	public void PJAFKONOMOB(Mesh NKIMIKOLCFE, JEJBOBIDBPC.LDJNLICPPEM JFOBPJMAIKI, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69DC920", Offset = "0x69DB920", VA = "0x1869DC920")]
	public long GFBBBIOJFNL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69DBAB0", Offset = "0x69DAAB0", VA = "0x1869DBAB0")]
	public long DMGKNCFBLKL(JEJBOBIDBPC.LDJNLICPPEM JFOBPJMAIKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69DACA0", Offset = "0x69D9CA0", VA = "0x1869DACA0")]
	private void BOIAAEDKCNB(int HKDBBJIOGFB, int AGAKJAKDDAP, Allocator IDMGOAKOEDG, bool DHLODGNGFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69DBD30", Offset = "0x69DAD30", VA = "0x1869DBD30")]
	private void ECIBMABIOAE(NativeArray<float3> JFKBJHPGAMG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69DBE30", Offset = "0x69DAE30", VA = "0x1869DBE30")]
	[BurstCompile]
	private unsafe static void ECIBMABIOAE([NoAlias] float3* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69DB890", Offset = "0x69DA890", VA = "0x1869DB890")]
	[BurstCompile]
	private unsafe static void DGOGBHBCNMI([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69DBB20", Offset = "0x69DAB20", VA = "0x1869DBB20")]
	[BurstCompile]
	private unsafe static void DMLOBKEEBOB([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69DA2D0", Offset = "0x69D92D0", VA = "0x1869DA2D0")]
	[BurstCompile]
	private unsafe static void AGJOBNPKEFM([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69DCAA0", Offset = "0x69DBAA0", VA = "0x1869DCAA0")]
	private void GHFAMOHDOOK(NativeArray<float3> EDGPFEDAAFF, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69DCBA0", Offset = "0x69DBBA0", VA = "0x1869DCBA0")]
	[BurstCompile]
	private unsafe static void GHFAMOHDOOK([NoAlias] ushort* JFKBJHPGAMG, [Out] float3 HFHJMPLEMEK, [Out] float3 FJEPEOOFHFH, [In][NoAlias] float3* EDGPFEDAAFF, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69DF470", Offset = "0x69DE470", VA = "0x1869DF470")]
	private void LFJFAHNFLFK(NativeArray<float3> BLHIFFJLDMB, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69DF250", Offset = "0x69DE250", VA = "0x1869DF250")]
	[BurstCompile]
	private unsafe static void LFJFAHNFLFK([NoAlias] ushort* ANOKGEJHKEM, [In][NoAlias] float3* BLHIFFJLDMB, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69DF110", Offset = "0x69DE110", VA = "0x1869DF110")]
	private void KKOONPBBNAO(NativeArray<float3> NDBKOJHGPDL, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69DF1E0", Offset = "0x69DE1E0", VA = "0x1869DF1E0")]
	[BurstCompile]
	private unsafe static void KKOONPBBNAO([NoAlias] float3* NDBKOJHGPDL, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69DC490", Offset = "0x69DB490", VA = "0x1869DC490")]
	[BurstCompile]
	private unsafe static void EPLIOPHLHAI([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69DE980", Offset = "0x69DD980", VA = "0x1869DE980")]
	[BurstCompile]
	private unsafe static void JPMICHJHACL([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69DF5D0", Offset = "0x69DE5D0", VA = "0x1869DF5D0")]
	[BurstCompile]
	private unsafe static void MABNMHEDABF([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69DC3C0", Offset = "0x69DB3C0", VA = "0x1869DC3C0")]
	private void EOGIKJCIMPK(NativeArray<float2> JMBKEBHHGPD, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69DC170", Offset = "0x69DB170", VA = "0x1869DC170")]
	[BurstCompile]
	private unsafe static void EOGIKJCIMPK([NoAlias] ushort* EBHAIPICNJH, [Out] float2 KADBOKJLOPC, [Out] float2 CMMGDJGCDKF, [In][NoAlias] float2* JMBKEBHHGPD, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69DB910", Offset = "0x69DA910", VA = "0x1869DB910")]
	[BurstCompile]
	private static void DJPACNOKKGL([Out] float2 JJJOOHEBOMO, ushort FOEHGGELLGK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69E0070", Offset = "0x69DF070", VA = "0x1869E0070")]
	private void NPFAPOKJOHL(NativeArray<float2> EBHAIPICNJH, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69E0170", Offset = "0x69DF170", VA = "0x1869E0170")]
	[BurstCompile]
	private unsafe static void NPFAPOKJOHL([NoAlias] float2* EBHAIPICNJH, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69E0730", Offset = "0x69DF730", VA = "0x1869E0730")]
	[BurstCompile]
	private unsafe static void PFKMHAOPFBI([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69DA6A0", Offset = "0x69D96A0", VA = "0x1869DA6A0")]
	[BurstCompile]
	private unsafe static void BKLCDECDFNE([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69DE900", Offset = "0x69DD900", VA = "0x1869DE900")]
	[BurstCompile]
	private unsafe static void JIBHGEDLMEJ([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69DE510", Offset = "0x69DD510", VA = "0x1869DE510")]
	private void HOJFDFCFEKM(NativeArray<float4> ANMLDFBBOKD, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69DE600", Offset = "0x69DD600", VA = "0x1869DE600")]
	[BurstCompile]
	private unsafe static void HOJFDFCFEKM([NoAlias] ushort* DPHIFJHGMNM, [In][NoAlias] float4* EGEFFIIDCMM, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69DE2A0", Offset = "0x69DD2A0", VA = "0x1869DE2A0")]
	[BurstCompile]
	private static ushort HGECBJDBIGP([In] float4 KHEJBBCBNNK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x69DF040", Offset = "0x69DE040", VA = "0x1869DF040")]
	private void KJLLECEOMMG(NativeArray<float4> DPHIFJHGMNM, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69DEFD0", Offset = "0x69DDFD0", VA = "0x1869DEFD0")]
	[BurstCompile]
	private unsafe static void KJLLECEOMMG([NoAlias] float4* DPHIFJHGMNM, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69DBF50", Offset = "0x69DAF50", VA = "0x1869DBF50")]
	[BurstCompile]
	private unsafe static void ENGOIEFEADG([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69DA260", Offset = "0x69D9260", VA = "0x1869DA260")]
	[BurstCompile]
	private unsafe static void AGFPLJPABOJ([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69DDF10", Offset = "0x69DCF10", VA = "0x1869DDF10")]
	[BurstCompile]
	private unsafe static void GNEMELKBJLI([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69DE780", Offset = "0x69DD780", VA = "0x1869DE780")]
	[BurstCompile]
	private static void IMFJILPJPJK([Out] float4 HJBJAPKPPFA, ushort FOEHGGELLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69DD8E0", Offset = "0x69DC8E0", VA = "0x1869DD8E0")]
	private void GMNONJBKAOO(Allocator IDMGOAKOEDG, NativeArray<float4> HNDBCJANMCI, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69DDCC0", Offset = "0x69DCCC0", VA = "0x1869DDCC0")]
	[BurstCompile]
	private unsafe static void GMNONJBKAOO([NoAlias] float4* OLGGBKFNAEF, [NoAlias] byte* PKDGCAIBGOC, [Out] int PDBJHIFLKKO, [Out] int EIJKELBOLJH, [NoAlias] float4* HNDBCJANMCI, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69DA350", Offset = "0x69D9350", VA = "0x1869DA350")]
	private static void AHAJAOCPINJ(NativeArray<float4> FGBJBPMAFEK, NativeArray<BJAAJDPHBMF> NEIPNMNDENL, NativeArray<byte> POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69DA460", Offset = "0x69D9460", VA = "0x1869DA460")]
	[BurstCompile]
	private unsafe static void AHAJAOCPINJ([NoAlias] float4* FGBJBPMAFEK, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69DA620", Offset = "0x69D9620", VA = "0x1869DA620")]
	[BurstCompile]
	private unsafe static void BDKKJOOKIHM([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69DA5A0", Offset = "0x69D95A0", VA = "0x1869DA5A0")]
	[BurstCompile]
	private unsafe static void APMJFAJOHAC([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69DBBA0", Offset = "0x69DABA0", VA = "0x1869DBBA0")]
	[BurstCompile]
	private unsafe static void DMPHNPBEEKG([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69DE430", Offset = "0x69DD430", VA = "0x1869DE430")]
	private void HMLDHFDOIAI(Allocator IDMGOAKOEDG, NativeArray<int> LKKNPKMPFHN, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69DF740", Offset = "0x69DE740", VA = "0x1869DF740")]
	private static NativeArray<byte> NFINELFDMEB(Allocator IDMGOAKOEDG, NativeArray<int> LKKNPKMPFHN, int LGEGKNBBNAC)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69DF9B0", Offset = "0x69DE9B0", VA = "0x1869DF9B0")]
	[BurstCompile]
	private unsafe static int NFINELFDMEB([NoAlias] byte* MDMEFCIOLGE, [In][NoAlias] int* LKKNPKMPFHN, int LGEGKNBBNAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69DC850", Offset = "0x69DB850", VA = "0x1869DC850")]
	private static void GCLPNJBLEHN(NativeArray<int> IEEBFDLOEBO, NativeArray<byte> EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69DC7E0", Offset = "0x69DB7E0", VA = "0x1869DC7E0")]
	[BurstCompile]
	private unsafe static void GCLPNJBLEHN([NoAlias] int* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69DC6B0", Offset = "0x69DB6B0", VA = "0x1869DC6B0")]
	[BurstCompile]
	private unsafe static void FIHBMNHOAHO([NoAlias] ushort* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69DF570", Offset = "0x69DE570", VA = "0x1869DF570")]
	[BurstCompile]
	private static void LIABCEIHHBD([Out] float3 JJJOOHEBOMO, ushort FOEHGGELLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69E01F0", Offset = "0x69DF1F0", VA = "0x1869E01F0")]
	[BurstCompile]
	private static ushort OFOFFLDPPBH([In] float3 KHEJBBCBNNK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public ECKOAIDMBHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69D16F0", Offset = "0x69D06F0", VA = "0x1869D16F0")]
	[BurstCompile]
	public unsafe static void MEPEMGONAEG([NoAlias] float3* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69DA4E0", Offset = "0x69D94E0", VA = "0x1869DA4E0")]
	[BurstCompile]
	public unsafe static void AKJJEDPGKLO([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69DC720", Offset = "0x69DB720", VA = "0x1869DC720")]
	[BurstCompile]
	public unsafe static void FKDGGEFNAJB([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69DFC00", Offset = "0x69DEC00", VA = "0x1869DFC00")]
	[BurstCompile]
	public unsafe static void NHKMGDNHJCE([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69D1310", Offset = "0x69D0310", VA = "0x1869D1310")]
	[BurstCompile]
	public unsafe static void KGGCIMBMELO([NoAlias] ushort* JFKBJHPGAMG, [Out] float3 HFHJMPLEMEK, [Out] float3 FJEPEOOFHFH, [In][NoAlias] float3* EDGPFEDAAFF, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69D1940", Offset = "0x69D0940", VA = "0x1869D1940")]
	[BurstCompile]
	public unsafe static void NBIDKJKBIPE([NoAlias] ushort* ANOKGEJHKEM, [In][NoAlias] float3* BLHIFFJLDMB, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69E0400", Offset = "0x69DF400", VA = "0x1869E0400")]
	[BurstCompile]
	public unsafe static void OGLMAHFEDHP([NoAlias] float3* NDBKOJHGPDL, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x69D0C50", Offset = "0x69CFC50", VA = "0x1869D0C50")]
	[BurstCompile]
	public unsafe static void GCIKCLJFDHN([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69DB590", Offset = "0x69DA590", VA = "0x1869DB590")]
	[BurstCompile]
	public unsafe static void CNKOGJKFLFC([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69DFE60", Offset = "0x69DEE60", VA = "0x1869DFE60")]
	[BurstCompile]
	public unsafe static void NNCHFIPFKNC([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69D1050", Offset = "0x69D0050", VA = "0x1869D1050")]
	[BurstCompile]
	public unsafe static void HINPMDMGAOD([NoAlias] ushort* EBHAIPICNJH, [Out] float2 KADBOKJLOPC, [Out] float2 CMMGDJGCDKF, [In][NoAlias] float2* JMBKEBHHGPD, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69E04A0", Offset = "0x69DF4A0", VA = "0x1869E04A0")]
	[BurstCompile]
	public static void OJHPOOGLGPN([Out] float2 JJJOOHEBOMO, ushort FOEHGGELLGK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69DFD80", Offset = "0x69DED80", VA = "0x1869DFD80")]
	[BurstCompile]
	public unsafe static void NMEANCENNMC([NoAlias] float2* EBHAIPICNJH, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69DC9B0", Offset = "0x69DB9B0", VA = "0x1869DC9B0")]
	[BurstCompile]
	public unsafe static void GFKEGBJMHAK([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69DF640", Offset = "0x69DE640", VA = "0x1869DF640")]
	[BurstCompile]
	public unsafe static void MKHILIFBNAN([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69DADD0", Offset = "0x69D9DD0", VA = "0x1869DADD0")]
	[BurstCompile]
	public unsafe static void CHDOCHAFINB([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69E0690", Offset = "0x69DF690", VA = "0x1869E0690")]
	[BurstCompile]
	public unsafe static void PCJKMNIHOJB([NoAlias] ushort* DPHIFJHGMNM, [In][NoAlias] float4* EGEFFIIDCMM, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69DE680", Offset = "0x69DD680", VA = "0x1869DE680")]
	[BurstCompile]
	public static ushort HPKOHCPMNDI([In] float4 KHEJBBCBNNK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69DE6E0", Offset = "0x69DD6E0", VA = "0x1869DE6E0")]
	[BurstCompile]
	public unsafe static void IHMIILAKFPM([NoAlias] float4* DPHIFJHGMNM, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69D09A0", Offset = "0x69CF9A0", VA = "0x1869D09A0")]
	[BurstCompile]
	public unsafe static void FFMLOAPBONI([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69DE7E0", Offset = "0x69DD7E0", VA = "0x1869DE7E0")]
	[BurstCompile]
	public unsafe static void JAILFIPENGG([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69DBC20", Offset = "0x69DAC20", VA = "0x1869DBC20")]
	[BurstCompile]
	public unsafe static void DNKGBFFFHEH([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69DFCC0", Offset = "0x69DECC0", VA = "0x1869DFCC0")]
	[BurstCompile]
	public static void NHMJFABMPJP([Out] float4 HJBJAPKPPFA, ushort FOEHGGELLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69D07E0", Offset = "0x69CF7E0", VA = "0x1869D07E0")]
	[BurstCompile]
	public unsafe static void ECDEKHNBINK([NoAlias] float4* OLGGBKFNAEF, [NoAlias] byte* PKDGCAIBGOC, [Out] int PDBJHIFLKKO, [Out] int EIJKELBOLJH, [NoAlias] float4* HNDBCJANMCI, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69DE160", Offset = "0x69DD160", VA = "0x1869DE160")]
	[BurstCompile]
	public unsafe static void HGBCFDPHNGK([NoAlias] float4* FGBJBPMAFEK, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69DDF80", Offset = "0x69DCF80", VA = "0x1869DDF80")]
	[BurstCompile]
	public unsafe static void HFLCNJJGCMA([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69DB6B0", Offset = "0x69DA6B0", VA = "0x1869DB6B0")]
	[BurstCompile]
	public unsafe static void CNPECPNILAL([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x69DFA20", Offset = "0x69DEA20", VA = "0x1869DFA20")]
	[BurstCompile]
	public unsafe static void NHECJIIJPMH([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69DA160", Offset = "0x69D9160", VA = "0x1869DA160")]
	[BurstCompile]
	public unsafe static int AEIPBJPNLLP([NoAlias] byte* MDMEFCIOLGE, [In][NoAlias] int* LKKNPKMPFHN, int LGEGKNBBNAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69E05F0", Offset = "0x69DF5F0", VA = "0x1869E05F0")]
	[BurstCompile]
	public unsafe static void PBHIHJDNBON([NoAlias] int* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69DBEB0", Offset = "0x69DAEB0", VA = "0x1869DBEB0")]
	[BurstCompile]
	public unsafe static void EDCPNDIFJCP([NoAlias] ushort* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69DE2F0", Offset = "0x69DD2F0", VA = "0x1869DE2F0")]
	[BurstCompile]
	public static void HHEPNFLDLDP([Out] float3 JJJOOHEBOMO, ushort FOEHGGELLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69D0E90", Offset = "0x69CFE90", VA = "0x1869D0E90")]
	[BurstCompile]
	public static ushort HFCLCHOEHMJ([In] float3 KHEJBBCBNNK)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct HHEMGENFINP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 IFJJLDMODPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 CGIMAKCEEKH;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class LMEJFJKKBOE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<HHEMGENFINP> IHBAJBONCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> MDLDBFEFHJM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GHEDKGOGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x868830", Offset = "0x867830", VA = "0x180868830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x69E8DC0", Offset = "0x69E7DC0", VA = "0x1869E8DC0")]
	public LMEJFJKKBOE(int HKDBBJIOGFB, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x69E8C80", Offset = "0x69E7C80", VA = "0x1869E8C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x69E8CE0", Offset = "0x69E7CE0", VA = "0x1869E8CE0")]
	public void LFJDNNPAPPK(LMEJFJKKBOE LKOGGOAGDEG, int ELEPNNOANJH, int GEIGDPFELPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class KHAKJLIAKDM
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static LMEJFJKKBOE NAEANLMLNGE;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<ENOMGJJDCNC> CEHIBEJNBKB;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] NOIPLKHAEKF;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool CBIPHNOGOCN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, LMEJFJKKBOE> GGMOJJKIPKN;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, LMEJFJKKBOE> FKJJIDLHBEE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool DMENOLECGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x69E7700", Offset = "0x69E6700", VA = "0x1869E7700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<ENOMGJJDCNC> AJFJKMDFKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x69E6800", Offset = "0x69E5800", VA = "0x1869E6800")]
		get
		{
			return default(NativeList<ENOMGJJDCNC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static LMEJFJKKBOE LJFFFHIEDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x69E7660", Offset = "0x69E6660", VA = "0x1869E7660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x69E6D80", Offset = "0x69E5D80", VA = "0x1869E6D80")]
	private static void JBJPDNDCOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x69E7470", Offset = "0x69E6470", VA = "0x1869E7470")]
	public static int LOEGOFFBDBB(bool OPBPJBOLAEL, int BINIOKIHNDM, bool JJLNOGIMBHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x69E6140", Offset = "0x69E5140", VA = "0x1869E6140")]
	private static int BIGEBOECJBD(int BINIOKIHNDM, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x69E7540", Offset = "0x69E6540", VA = "0x1869E7540")]
	private static int MLFNMGPBOML(int BINIOKIHNDM, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x69E73D0", Offset = "0x69E63D0", VA = "0x1869E73D0")]
	public static int KADAKAGIABE(int KEAEHEPAPAH, int BINIOKIHNDM, int BIAGKLHEIMO, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x69E74A0", Offset = "0x69E64A0", VA = "0x1869E74A0")]
	public static int MDFHELMDJHJ(int KEAEHEPAPAH, int BINIOKIHNDM, int BIAGKLHEIMO, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6530", VA = "0x1869E7530")]
	public static int MKGEMIAFLII(int BIAGKLHEIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x69E7460", Offset = "0x69E6460", VA = "0x1869E7460")]
	private static int KCJHFLOLDJE(int BINIOKIHNDM, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x69E7550", Offset = "0x69E6550", VA = "0x1869E7550")]
	private static int MMLGCBICDHP(int BINIOKIHNDM, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x69E60D0", Offset = "0x69E50D0", VA = "0x1869E60D0")]
	public static int ADGJFOMKODL(int KEAEHEPAPAH, int BINIOKIHNDM, int BIAGKLHEIMO, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x69E68A0", Offset = "0x69E58A0", VA = "0x1869E68A0")]
	public static int HBAFAKPIFEG(int KEAEHEPAPAH, int BINIOKIHNDM, int BIAGKLHEIMO, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x69E6D60", Offset = "0x69E5D60", VA = "0x1869E6D60")]
	public static int IACDEICAMBC(int BIAGKLHEIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x69E7570", Offset = "0x69E6570", VA = "0x1869E7570")]
	public static LMEJFJKKBOE NGLMMBCIPDE(int BINIOKIHNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x69E6570", Offset = "0x69E5570", VA = "0x1869E6570")]
	private static LMEJFJKKBOE CNJMKGBDNEO(int BINIOKIHNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x69E6C70", Offset = "0x69E5C70", VA = "0x1869E6C70")]
	public static LMEJFJKKBOE HIOMGINOEMB(int BINIOKIHNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x69E6930", Offset = "0x69E5930", VA = "0x1869E6930")]
	private static LMEJFJKKBOE HHFEFJKKONL(int BINIOKIHNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x69E6160", Offset = "0x69E5160", VA = "0x1869E6160")]
	public static void CFAPHJJKPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct IJNABGLBBPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int OMMODMHHJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 MHCNNPNLCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion DAGJLEEBCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float IDOHEGKKEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float DPBKIMLIIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int BOCAFGJDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int POKBFINKFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int FMPOBLJGOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool OMNNGAHCFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool JBGDCIBOIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float JGNKNIABCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 FPCJOADJMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool BAJGBFIIJNA;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct OEPACADIJGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int KNLKADFFFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int OEKINECELBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KJOIGFJGHJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<IJNABGLBBPB> CMHEKNANJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<FEGDHMAPLDK> LLCCIFKNMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<ENOMGJJDCNC> CKMIBCFGPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<OEPACADIJGK> BOFAEOALCCK;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x69E79E0", Offset = "0x69E69E0", VA = "0x1869E79E0")]
	public KJOIGFJGHJJ(NativeArray<FEGDHMAPLDK> LLCCIFKNMCA, int ENCFHCJIMBE = 1, Allocator IDMGOAKOEDG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x69E78F0", Offset = "0x69E68F0", VA = "0x1869E78F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct CLPEFMJCKAB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<HHEMGENFINP> CDAEIIBGEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> CLPDGPNGNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<ENOMGJJDCNC> DADKDLIAMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<IJNABGLBBPB> CMHEKNANJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<FEGDHMAPLDK> LLCCIFKNMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<ENOMGJJDCNC> CKMIBCFGPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<OEPACADIJGK> BOFAEOALCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int NFMOEJJKOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int KOJOIOJPABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 DNHICGOKHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion CEALGBNBNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 JMNNLKELODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PPJMKILKGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GHKEBLIBKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BONIEMHOOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> ACCLBFECJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NCHLMKKICIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JDDEHBNMOMK;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x69D7940", Offset = "0x69D6940", VA = "0x1869D7940")]
	public CLPEFMJCKAB(NOPNHHMHLEP KPNFINGJNEK, JEJBOBIDBPC NGENPPMBGHN, float3 KJGKFMJNDMA, quaternion KLLFKBECAGD, float DMBHPKECOAB, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x69D7BD0", Offset = "0x69D6BD0", VA = "0x1869D7BD0")]
	public CLPEFMJCKAB(KJOIGFJGHJJ KPNFINGJNEK, JEJBOBIDBPC NGENPPMBGHN, float3 KJGKFMJNDMA, quaternion KLLFKBECAGD, float3 DMBHPKECOAB, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x69D7240", Offset = "0x69D6240", VA = "0x1869D7240")]
	private float3 MFKOGFDNFEH(float3 HOPBOPIFFKK, Matrix4x4 OMPOJIFAKLI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x69D59D0", Offset = "0x69D49D0", VA = "0x1869D59D0")]
	private float3x3 EONAMBLOBBF(float3x3 KCLNIOKABBM, float3x3 AJHNLGKGPAE)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x69D59C0", Offset = "0x69D49C0", VA = "0x1869D59C0")]
	private float AOFIFHEOPNE(float GNMLLHFGICG, float EKHGJBOMMLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x69D5A50", Offset = "0x69D4A50", VA = "0x1869D5A50", Slot = "4")]
	public void Execute(int JPMDPHGDIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x69D77D0", Offset = "0x69D67D0", VA = "0x1869D77D0")]
	private void OPNNFBMLMNN(int ENPFGOBIHKI, float3 MOIICCIPACK, float3 FFJHDFACBIE, float3 EKBJDPFKMAM, float AMCMIGCLHDD, bool PIMPIKCFJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x69D7370", Offset = "0x69D6370", VA = "0x1869D7370")]
	private void OCDDFMMFONC(IJNABGLBBPB PGJMPKMCFHM, float3 OGNOLJCMDMP, float3x3 NACDGIDELJO, float GNMLLHFGICG, int IOKPFNHCNGL, int IOEMCCIKKGM, int FMMJOHDMJFE, float KPCGDJJONPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x69D6BF0", Offset = "0x69D5BF0", VA = "0x1869D6BF0")]
	private void HFHDHAOEFBL(int ENPFGOBIHKI, int HLBFIANHDJI, IJNABGLBBPB PGJMPKMCFHM, float3 OGNOLJCMDMP, float3x3 NACDGIDELJO, bool PDMDEJMLHKE, float GNMLLHFGICG, int EHLCBGPJFAG, int NNJDHBNCCKD, int FMMJOHDMJFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct EJFDPLIAJPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<MLEKJJLPPBG> CBKHDBEPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<ENOMGJJDCNC> IPPHLBMKDLM;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x69E09B0", Offset = "0x69DF9B0", VA = "0x1869E09B0")]
	public EJFDPLIAJPB(int ENCFHCJIMBE, Allocator IDMGOAKOEDG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x69E0910", Offset = "0x69DF910", VA = "0x1869E0910", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct IHCIGIPGKBB : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum AADHNHKNECO
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
	private NativeList<float3> JKONAANDFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> CNNIPCPKPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> FFDLEPLFIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> ODOHGMACCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> LBFIFKKAECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> AHLOLINJBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> FHGPAAKJKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> HGODAKPHOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<ENOMGJJDCNC> PBLLNOAJOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<MLEKJJLPPBG> CBKHDBEPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<ENOMGJJDCNC> IPPHLBMKDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int NFMOEJJKOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int KOJOIOJPABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PPJMKILKGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GHKEBLIBKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BONIEMHOOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> ACCLBFECJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NCHLMKKICIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JDDEHBNMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 JMNNLKELODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion CEALGBNBNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 DNHICGOKHAA;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x69E4220", Offset = "0x69E3220", VA = "0x1869E4220")]
	public IHCIGIPGKBB(NOPNHHMHLEP KPNFINGJNEK, JEJBOBIDBPC NGENPPMBGHN, float3 KJGKFMJNDMA, quaternion KLLFKBECAGD, float DMBHPKECOAB, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x69E4030", Offset = "0x69E3030", VA = "0x1869E4030")]
	public IHCIGIPGKBB(EJFDPLIAJPB FHNKDHIILBL, JEJBOBIDBPC NGENPPMBGHN, float3 KJGKFMJNDMA, quaternion KLLFKBECAGD, float3 DMBHPKECOAB, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x69E2FD0", Offset = "0x69E1FD0", VA = "0x1869E2FD0", Slot = "4")]
	public void Execute(int JPMDPHGDIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x69E2C20", Offset = "0x69E1C20", VA = "0x1869E2C20")]
	private void CFLMDNGIGNE(float4x4 MMBLFGFELMD, int JPMDPHGDIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x69E3F30", Offset = "0x69E2F30", VA = "0x1869E3F30")]
	private AADHNHKNECO LNIFIPOCEGC(float3 FFJHDFACBIE)
	{
		return default(AADHNHKNECO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x69E3FA0", Offset = "0x69E2FA0", VA = "0x1869E3FA0")]
	private float4 OINDCKHCPGE(AADHNHKNECO AFBNALEMNLO, int LLPJHIPCNFD)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x69E3FF0", Offset = "0x69E2FF0", VA = "0x1869E3FF0")]
	private float2 PGNAGIBKEFD(AADHNHKNECO AFBNALEMNLO, float3 MOIICCIPACK)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KBHNBLOBCGL
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum EPAHFFCPOCH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static KBHNBLOBCGL BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 KBHBDHIEKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 JAFLFHHIBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 PMILGDKKIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public EPAHFFCPOCH MDBCEFGBENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 OMKAADBHGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 MHIFLGGKPJA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DJDJJCHPPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x69E4E50", Offset = "0x69E3E50", VA = "0x1869E4E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 PGGBDIGHJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x69E4D70", Offset = "0x69E3D70", VA = "0x1869E4D70")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x69E5470", Offset = "0x69E4470", VA = "0x1869E5470")]
	public KBHNBLOBCGL(float3 MOIICCIPACK, quaternion ADNGPFKNGFI, float3 ENCFHCJIMBE, EPAHFFCPOCH PBLNJHEPKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x69E4F50", Offset = "0x69E3F50", VA = "0x1869E4F50")]
	public float LKPOIMHGGHD(float3 OGNOLJCMDMP, float BNDBPNFJNIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x69E4E60", Offset = "0x69E3E60", VA = "0x1869E4E60")]
	public bool JMPLPDLPODF(float3 FFJHDFACBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x69E5150", Offset = "0x69E4150", VA = "0x1869E5150")]
	public void MDHFPHHAFPO(float3 IOGKFELDEIF, float3x3 EFLPFLMANDF, float POEKJGODHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x69E5300", Offset = "0x69E4300", VA = "0x1869E5300")]
	private void NILCEJNEIMO(float3 BJEINPMOICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x69E4AE0", Offset = "0x69E3AE0", VA = "0x1869E4AE0")]
	public void BNKOAKEMFAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct PDDNHBBGKBJ : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<KBHNBLOBCGL> FHNKDHIILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> AEMLGNPCMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> DGLAKPCPOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BKJOLKKFNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<ENOMGJJDCNC> IPPHLBMKDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int DJBOLBCBOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int EKDJEHICBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float BNDBPNFJNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float HOJLNPJJHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> IOBBPAFMFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FNEHMGAAEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> DLALHMLKGGJ;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x69EE1A0", Offset = "0x69ED1A0", VA = "0x1869EE1A0")]
	public PDDNHBBGKBJ(JEJBOBIDBPC NKIMIKOLCFE, float GKKNEINMIIE, int GEIGDPFELPO, int IOKPFNHCNGL, NativeList<KBHNBLOBCGL> FHNKDHIILBL, NativeArray<int> BKJOLKKFNKP, NativeList<ENOMGJJDCNC> IPPHLBMKDLM, GHPIIHCLOKF GANMOBPECHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x69ED700", Offset = "0x69EC700", VA = "0x1869ED700", Slot = "4")]
	public void Execute(int PGPKMKINHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x69EE0E0", Offset = "0x69ED0E0", VA = "0x1869EE0E0")]
	private bool JIJOJNFNDFI(KBHNBLOBCGL FAGKOOGCGBH, KBHNBLOBCGL HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x69EDE40", Offset = "0x69ECE40", VA = "0x1869EDE40")]
	private bool GHCFLJHIALA(KBHNBLOBCGL EDKCHBPCEOI, int LAKFNLBDKBN, int PFHCAJMNLKM, int EDEMMBFAGBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GHPIIHCLOKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> LFOCAMLPDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> JFIINCJELLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> EEJGPKDPOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> GEFDGKAOFOG;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x69E1E80", Offset = "0x69E0E80", VA = "0x1869E1E80")]
	public void BOIAAEDKCNB(int HKDBBJIOGFB, int AGAKJAKDDAP, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x69E2090", Offset = "0x69E1090", VA = "0x1869E2090")]
	public static long LAHECLHAOLN(int HKDBBJIOGFB, int AGAKJAKDDAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x69E1FA0", Offset = "0x69E0FA0", VA = "0x1869E1FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x69E20B0", Offset = "0x69E10B0", VA = "0x1869E20B0")]
	public void NNOPBDMPMBK(JobHandle OPKPNABHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public GHPIIHCLOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct NMIJGEPLCDC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> AEMLGNPCMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> DPOANBHKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> FOKAPEBHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> OPOGKFKMMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> DGLAKPCPOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JKIIIELNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> IIINHNNKNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> IOBBPAFMFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> FNEHMGAAEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int HFBKEMINOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int CBHPLEBEDKE;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x69EA610", Offset = "0x69E9610", VA = "0x1869EA610")]
	public NMIJGEPLCDC(JEJBOBIDBPC NKIMIKOLCFE, GHPIIHCLOKF GANMOBPECHM, int CBHPLEBEDKE = 0, int HFBKEMINOAI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x69EA230", Offset = "0x69E9230", VA = "0x1869EA230", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x69EA1D0", Offset = "0x69E91D0", VA = "0x1869EA1D0")]
	private void DOBKNLFDGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CEMDIPPNIBJ
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x292ACC0", Offset = "0x2929CC0", VA = "0x18292ACC0")]
	public static bool FGNBMMPFDHD<T>(NativeArray<T> GGEMIJICFPG, int ENCFHCJIMBE, Allocator IDMGOAKOEDG, NativeArrayOptions HEBGDGGBJPN = NativeArrayOptions.ClearMemory, int ALAAGAAHHAK = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x292AE40", Offset = "0x2929E40", VA = "0x18292AE40")]
	public static bool FGNBMMPFDHD<T>(NativeList<T> DNOAHHGKGFF, int ENCFHCJIMBE, Allocator IDMGOAKOEDG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum POIDHJJPEDL
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
public interface POHKOOHALBH
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MMHJCICOBOG(POIDHJJPEDL KEAEHEPAPAH);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LKDCHMIJKND(POIDHJJPEDL KEAEHEPAPAH);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds CPMEIAMONLG();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float PLPMNIICCHI();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAKKJAMDDMB(POIDHJJPEDL KEAEHEPAPAH, NOPNHHMHLEP IJOPFJKNHEJ, int CPGOOLGAFHI = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class JEJBOBIDBPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum LDJNLICPPEM
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
	public struct OJLPCEEFOKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public LDJNLICPPEM JFOBPJMAIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool FBFAJBOLIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int MMGINODMMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] LPCCBAKPCAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct NFEJALFPOGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 MOIICCIPACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 FFJHDFACBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 EKBJDPFKMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 DLLKJLHPGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 FOKAPEBHHIG;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] LPCCBAKPCAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct GIPJPHHALKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 MOIICCIPACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 FFJHDFACBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 EKBJDPFKMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 DLLKJLHPGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 FOKAPEBHHIG;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] LPCCBAKPCAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct DMIODOAKCNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 MOIICCIPACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 FFJHDFACBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 EKBJDPFKMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 DLLKJLHPGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint FOKAPEBHHIG;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] LPCCBAKPCAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct NIIBFBAPMHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 MOIICCIPACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint FFJHDFACBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint EKBJDPFKMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 DLLKJLHPGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 FOKAPEBHHIG;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] LPCCBAKPCAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct IKJFGLFEJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 MOIICCIPACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint FFJHDFACBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint EKBJDPFKMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 DLLKJLHPGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 FOKAPEBHHIG;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] LPCCBAKPCAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int KGALDBOLLOC(float OOALEDCPNBJ);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class BBHDLECKHGP
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x69EF960", Offset = "0x69EE960", VA = "0x1869EF960")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x69EF4E0", Offset = "0x69EE4E0", VA = "0x1869EF4E0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x69EF640", Offset = "0x69EE640", VA = "0x1869EF640")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69EF6F0", Offset = "0x69EE6F0", VA = "0x1869EF6F0")]
		public static int NGOOLELHLHP(float OOALEDCPNBJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint GLELOHOJCBD([In] float4 DCMJEJAEEHK);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class PJNJIEJHIEA
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A052E0", Offset = "0x6A042E0", VA = "0x186A052E0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A04D90", Offset = "0x6A03D90", VA = "0x186A04D90")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A04EF0", Offset = "0x6A03EF0", VA = "0x186A04EF0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A04FA0", Offset = "0x6A03FA0", VA = "0x186A04FA0")]
		public static uint NGOOLELHLHP([In] float4 DCMJEJAEEHK)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint GBBHHJKKNBH([In] float3 DCMJEJAEEHK);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class CBEBPPNACFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x69EFF20", Offset = "0x69EEF20", VA = "0x1869EFF20")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x69EFA90", Offset = "0x69EEA90", VA = "0x1869EFA90")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x69EFBF0", Offset = "0x69EEBF0", VA = "0x1869EFBF0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x69EFCA0", Offset = "0x69EECA0", VA = "0x1869EFCA0")]
		public static uint NGOOLELHLHP([In] float3 DCMJEJAEEHK)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void GCJBPOHLNML([NoAlias] NIIBFBAPMHJ* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class PJCMBMGNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6A04C60", Offset = "0x6A03C60", VA = "0x186A04C60")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6A04810", Offset = "0x6A03810", VA = "0x186A04810")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6A04970", Offset = "0x6A03970", VA = "0x186A04970")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A04A20", Offset = "0x6A03A20", VA = "0x186A04A20")]
		public unsafe static void NGOOLELHLHP([NoAlias] NIIBFBAPMHJ* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void PIFJHCKGIIA([NoAlias] IKJFGLFEJFP* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class COJOMHKAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x69F0A00", Offset = "0x69EFA00", VA = "0x1869F0A00")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x69F05B0", Offset = "0x69EF5B0", VA = "0x1869F05B0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x69F0710", Offset = "0x69EF710", VA = "0x1869F0710")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x69F07C0", Offset = "0x69EF7C0", VA = "0x1869F07C0")]
		public unsafe static void NGOOLELHLHP([NoAlias] IKJFGLFEJFP* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int OFAEILJCPPB = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> HJOPBFHGEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> HDMGLNKDBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> KKPECFEDOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> NLKOJOOOMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> EMFJNPIDLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> PHCKJPMBIJH;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] ELNJCOEAECP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool MHDOPAFILGH;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static OJLPCEEFOKB[] FJBIAFFGFFK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DFLAHLKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x69F7980", Offset = "0x69F6980", VA = "0x1869F7980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GHEDKGOGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x69F91D0", Offset = "0x69F81D0", VA = "0x1869F91D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x69F9250", Offset = "0x69F8250", VA = "0x1869F9250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GEJFPJEEKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69F9210", Offset = "0x69F8210", VA = "0x1869F9210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void IHKOHAPGNJE(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x69F7240", Offset = "0x69F6240", VA = "0x1869F7240", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x69F6180", Offset = "0x69F5180", VA = "0x1869F6180")]
	public void BOIAAEDKCNB(int HKDBBJIOGFB, int AGAKJAKDDAP, Allocator IDMGOAKOEDG, bool PNCCPGHDBCD, bool DHLODGNGFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x69F9300", Offset = "0x69F8300", VA = "0x1869F9300")]
	public void OGNKAFAHLEF(int HKDBBJIOGFB, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x69FA1E0", Offset = "0x69F91E0", VA = "0x1869FA1E0", Slot = "6")]
	public bool PEBJGOJALEP(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x69F9380", Offset = "0x69F8380", VA = "0x1869F9380")]
	public bool OMNFHIEFOAK(Mesh NKIMIKOLCFE, bool APHCFPDNDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x69F7350", Offset = "0x69F6350", VA = "0x1869F7350")]
	public bool ECEHJOCHEIK(Mesh NKIMIKOLCFE, JEJBOBIDBPC BAKFKOANHAF, bool APHCFPDNDMK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x69F5730", Offset = "0x69F4730", VA = "0x1869F5730")]
	public void BMDKJPNJILE(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x69F9760", Offset = "0x69F8760", VA = "0x1869F9760")]
	public void PDAIOJBAMPD(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x69F8880", Offset = "0x69F7880", VA = "0x1869F8880")]
	[BurstCompile]
	public static int KCOJOLCFODI(float OOALEDCPNBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x69F88D0", Offset = "0x69F78D0", VA = "0x1869F88D0")]
	[BurstCompile]
	public static uint KCOJOLCFODI([In] float4 DCMJEJAEEHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x69F8830", Offset = "0x69F7830", VA = "0x1869F8830")]
	[BurstCompile]
	public static uint KCOJOLCFODI([In] float3 DCMJEJAEEHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x69F8920", Offset = "0x69F7920", VA = "0x1869F8920")]
	public void KDMMNICIBHI(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x69F56B0", Offset = "0x69F46B0", VA = "0x1869F56B0")]
	[BurstCompile]
	private unsafe static void BKDOAOAHGBB([NoAlias] NIIBFBAPMHJ* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x69F6AA0", Offset = "0x69F5AA0", VA = "0x1869F6AA0")]
	public void CKEOBCJHBBI(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x69F7A20", Offset = "0x69F6A20", VA = "0x1869F7A20")]
	[BurstCompile]
	private unsafe static void FODCMHGBJPO([NoAlias] IKJFGLFEJFP* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x69FA1F0", Offset = "0x69F91F0", VA = "0x1869FA1F0")]
	public void PJAFKONOMOB(Mesh NKIMIKOLCFE, LDJNLICPPEM JFOBPJMAIKI, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x69F8F60", Offset = "0x69F7F60", VA = "0x1869F8F60")]
	public void LFJDNNPAPPK(JEJBOBIDBPC NKIMIKOLCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69F7F10", Offset = "0x69F6F10", VA = "0x1869F7F10")]
	public JEJBOBIDBPC IELCMBBNHEG(Allocator IDMGOAKOEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x69F7AA0", Offset = "0x69F6AA0", VA = "0x1869F7AA0")]
	public long GFBBBIOJFNL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x69F7BD0", Offset = "0x69F6BD0", VA = "0x1869F7BD0")]
	public static long GFBBBIOJFNL(int NAFLLFOCPHI, int BECBBKCEMMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x69F70E0", Offset = "0x69F60E0", VA = "0x1869F70E0")]
	public static long DMGKNCFBLKL(int NAFLLFOCPHI, int BECBBKCEMMP, LDJNLICPPEM JFOBPJMAIKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x69F7180", Offset = "0x69F6180", VA = "0x1869F7180")]
	public long DMGKNCFBLKL(LDJNLICPPEM JFOBPJMAIKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69F79C0", Offset = "0x69F69C0", VA = "0x1869F79C0")]
	public void EPPCMOHCPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x69F84A0", Offset = "0x69F74A0", VA = "0x1869F84A0")]
	public static void KBPCCOAHDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x69F6370", Offset = "0x69F5370", VA = "0x1869F6370")]
	public LDJNLICPPEM CCLMLNIFDCM()
	{
		return default(LDJNLICPPEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x69F69D0", Offset = "0x69F59D0", VA = "0x1869F69D0")]
	public static (int, int) CDJKBIPPKEH(Mesh NKIMIKOLCFE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x69F55D0", Offset = "0x69F45D0", VA = "0x1869F55D0")]
	public static int BEJNLEOCOAD(VertexAttributeDescriptor[] JBICPLNDIFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69F9290", Offset = "0x69F8290", VA = "0x1869F9290")]
	public static long NILEHOPHCEL(Mesh NKIMIKOLCFE, int FEBDIALBBDA, int FONLIBCGKLP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public JEJBOBIDBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69F7C30", Offset = "0x69F6C30", VA = "0x1869F7C30")]
	[BurstCompile]
	public static int HODMBLCMKPL(float OOALEDCPNBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x69F7D80", Offset = "0x69F6D80", VA = "0x1869F7D80")]
	[BurstCompile]
	public static uint HODMBLCMKPL([In] float4 DCMJEJAEEHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x69F7CD0", Offset = "0x69F6CD0", VA = "0x1869F7CD0")]
	[BurstCompile]
	public static uint HODMBLCMKPL([In] float3 DCMJEJAEEHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69F5220", Offset = "0x69F4220", VA = "0x1869F5220")]
	[BurstCompile]
	public unsafe static void AGNLJCHAHJN([NoAlias] NIIBFBAPMHJ* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69F8050", Offset = "0x69F7050", VA = "0x1869F8050")]
	[BurstCompile]
	public unsafe static void IFNLFCEHOHO([NoAlias] IKJFGLFEJFP* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class JHEDIHABFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x69FA680", Offset = "0x69F9680", VA = "0x1869FA680")]
	public static void CFAPHJJKPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DIGJAFDICOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> HJOPBFHGEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> HDMGLNKDBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> JGHEKOIKBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> HKICJFMOIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> MLJHOIELAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> BKKFCJDGFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> GADIADPJPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> PHCKJPMBIJH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int GHEDKGOGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x69F1410", Offset = "0x69F0410", VA = "0x1869F1410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x69F19D0", Offset = "0x69F09D0", VA = "0x1869F19D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IAJNFKDDCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x69F0C40", Offset = "0x69EFC40", VA = "0x1869F0C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x69F1A10", Offset = "0x69F0A10", VA = "0x1869F1A10")]
	public DIGJAFDICOI(int HKDBBJIOGFB, int AGAKJAKDDAP, int HOMIIEJNOMC, Allocator IDMGOAKOEDG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x69F1CE0", Offset = "0x69F0CE0", VA = "0x1869F1CE0")]
	public DIGJAFDICOI(Mesh NKIMIKOLCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x69F0B30", Offset = "0x69EFB30", VA = "0x1869F0B30", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x69F1110", Offset = "0x69F0110", VA = "0x1869F1110")]
	public void LFJDNNPAPPK(DIGJAFDICOI NKIMIKOLCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x69F0C80", Offset = "0x69EFC80", VA = "0x1869F0C80")]
	private void JAKOPEEJMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x69F1450", Offset = "0x69F0450", VA = "0x1869F1450")]
	private void MEBKKKJECGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct ENOMGJJDCNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int CLPIDBHNNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int GHEDKGOGFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int ANCLEFBJLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int JPOJGPBPILN;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x14124B0", Offset = "0x14114B0", VA = "0x1814124B0")]
	public ENOMGJJDCNC(int IOKPFNHCNGL, int PKIBPAHFPLK, int GEIGDPFELPO, int OPOFHOEKKOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class GDGOCJIGEDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<ENOMGJJDCNC> KAIMKANIPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8D74E0", Offset = "0x8D64E0", VA = "0x1808D74E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<ENOMGJJDCNC>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x99F070", Offset = "0x99E070", VA = "0x18099F070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DIGJAFDICOI CMNIIPEGNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x867E00", Offset = "0x866E00", VA = "0x180867E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x69F22F0", Offset = "0x69F12F0", VA = "0x1869F22F0")]
	public GDGOCJIGEDJ(IEnumerable<DIGJAFDICOI> FNHFCNOOFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x69F2280", Offset = "0x69F1280", VA = "0x1869F2280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum ICCDOOKLDAK
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class CDGKOOHGHEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> GBPKAIBBAFB;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> LFLAMEBPGEP;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> EHEDOIFJJJJ;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> LKMCEFGPCAH;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x69F0050", Offset = "0x69EF050", VA = "0x1869F0050")]
	public static void CFAPHJJKPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x69F04A0", Offset = "0x69EF4A0", VA = "0x1869F04A0")]
	public static NativeArray<float2> MGEOAJFFDGF(NativeArray<float2> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<float2> HHBFKHNLEFB, int IHMDNFDGMJB)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x69F0170", Offset = "0x69EF170", VA = "0x1869F0170")]
	public static NativeArray<float3> CNCCDPKENLK(NativeArray<float3> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<float3> HHBFKHNLEFB, int IHMDNFDGMJB)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x69F0390", Offset = "0x69EF390", VA = "0x1869F0390")]
	public static NativeArray<float4> FOBMAKLFKBO(NativeArray<float4> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<float4> HHBFKHNLEFB, int IHMDNFDGMJB)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x69F0280", Offset = "0x69EF280", VA = "0x1869F0280")]
	public static NativeArray<int> EAMEJGKDIIF(NativeArray<int> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<int> HHBFKHNLEFB, int IHMDNFDGMJB)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2929170", Offset = "0x2928170", VA = "0x182929170")]
	private static void EAEFAEGHFBE<T>(NativeArray<T> GGEMIJICFPG, int FJDBHJEKJDP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2929370", Offset = "0x2928370", VA = "0x182929370")]
	private static void KKMOKKHBICP<T>(NativeArray<T> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<T> HHBFKHNLEFB, int IHMDNFDGMJB, NativeArray<T> EGDECODLBMH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class ONKFDHMAIIN
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum MJAMOLEIMMK
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
	public class OFKHHKFBIHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public ECKOAIDMBHO NKIMIKOLCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int HOJEADLMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int MNDKIPNDDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long DCBCGJBJLNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long FLDIIDOPPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float FOLGDEGALMM;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x69FAB70", Offset = "0x69F9B70", VA = "0x1869FAB70")]
		public OFKHHKFBIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x69FAB30", Offset = "0x69F9B30", VA = "0x1869FAB30")]
		public void NNOPBDMPMBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string PNNKLLPFDLB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string ICMEEEFCEJB;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker HHHLLKHLPGL;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker NMAAAMGGBEF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker BNOMOACMMFC;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker NMNDKCJCICO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker DHGBGHPCKIC;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker OCNJGLFHENP;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker LCFLPFCHNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker LGIGGNGAOMF;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker FENMBCEHGFE;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker KFHNAKLPCKK;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker DPAAPECLLCH;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker LGFIELDENJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<POHKOOHALBH> LCIJAGELCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly AJJOLPGOGOH KCABPILHDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int PKIBPAHFPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int OPOFHOEKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool JFCCKMBOKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool BIFOJAEFEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal MJAMOLEIMMK NGHALOPECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool NDJPDGCCICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 DPGPMOHGBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 GJDOAJKFJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float EAGLEOCCODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float LPAFGLAFGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int JJDCLPEMEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int PNKAOGMMOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int DDKGBIPFKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int GNPJPNHNAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float FBAOBPEMLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float FLHKEBINKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int KGPLMLHPNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long KPFEBBBAGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long COBFFFHMIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long EOCBOOAHJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int HGBKMAAFKNE;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int ELOKKACFCNK = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] PPODCOIBOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] CAOMBDMNMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] DKBNMPGPIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private JEJBOBIDBPC OKCADMOIDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long MGKDEMNKIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long BMJMNGPBBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int CMDGPGKIHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<OFKHHKFBIHN> IKHEIDGOMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float NIOBPEHIJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal JEJBOBIDBPC.LDJNLICPPEM NCFAGBMKDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool JIOIGHEPIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private HNGDEFMNKBD POEOCDJJLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle ENMEPINLMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> DCKKHFKPEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool CBLABJCAOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle AKJHPEBNFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private JEJBOBIDBPC PKFANNMKOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform PFJIMBBJCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private POIDHJJPEDL GFIFIJGDHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long OPHCEJOJJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long AFCJNFGLKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long MENNJINHFDL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh CMNIIPEGNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x869500", Offset = "0x868500", VA = "0x180869500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer KCNCKOHPLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x868800", Offset = "0x867800", VA = "0x180868800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LHDBJCGEHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8D12A0", Offset = "0x8D02A0", VA = "0x1808D12A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MONPLMKLHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xC43BF0", Offset = "0xC42BF0", VA = "0x180C43BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GHEDKGOGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6A018A0", Offset = "0x6A008A0", VA = "0x186A018A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<POHKOOHALBH> BIECLPJFEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void IHKOHAPGNJE(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6A04090", Offset = "0x6A03090", VA = "0x186A04090")]
	public void PLAJIDGPHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6A00A10", Offset = "0x69FFA10", VA = "0x186A00A10")]
	private void IKOENGPNLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6A04530", Offset = "0x6A03530", VA = "0x186A04530")]
	public ONKFDHMAIIN(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6A02630", Offset = "0x6A01630", VA = "0x186A02630")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x69FAD40", Offset = "0x69F9D40", VA = "0x1869FAD40")]
	public void BJHOKGKGHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6A018C0", Offset = "0x6A008C0", VA = "0x186A018C0")]
	private void NANJHIABDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x69FBF70", Offset = "0x69FAF70", VA = "0x1869FBF70")]
	public void DANDGJIFFLG(POHKOOHALBH AJBLINEBFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6A032A0", Offset = "0x6A022A0", VA = "0x186A032A0")]
	public bool OJDLIBEPFNE(POHKOOHALBH AJBLINEBFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6A040A0", Offset = "0x6A030A0", VA = "0x186A040A0")]
	public bool PMELAKIMKGE(POHKOOHALBH AJBLINEBFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6A00E50", Offset = "0x69FFE50", VA = "0x186A00E50", Slot = "4")]
	public virtual void JAHPHEMLLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6A00800", Offset = "0x69FF800", VA = "0x186A00800")]
	public void IEPKGLPHCEA(Transform DAOJLEMLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6A03FB0", Offset = "0x6A02FB0", VA = "0x186A03FB0")]
	private long PKMIMDGCFFH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x69FABC0", Offset = "0x69F9BC0", VA = "0x1869FABC0")]
	private long BFLHIAMDKKN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69FE220", Offset = "0x69FD220", VA = "0x1869FE220")]
	public bool HEEDODHLALF(Transform DAOJLEMLDIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x69FF260", Offset = "0x69FE260", VA = "0x1869FF260")]
	public bool IAKLEKPCPEI(bool JMPKKIBNOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A00680", Offset = "0x69FF680", VA = "0x186A00680")]
	public void IDOBAKGJKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x69FCEC0", Offset = "0x69FBEC0", VA = "0x1869FCEC0")]
	public bool FHFKMBIPFPE(float4x4 HEHKKIOOIIG, BatchedMeshRenderer ANKNKBHMPGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6A03030", Offset = "0x6A02030", VA = "0x186A03030")]
	public void OHDNEEBMKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x69FC140", Offset = "0x69FB140", VA = "0x1869FC140")]
	public bool DFIDLCBKEAE(bool JMPKKIBNOPE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A01300", Offset = "0x6A00300", VA = "0x186A01300")]
	public void KHNPNKDHDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x69FC410", Offset = "0x69FB410", VA = "0x1869FC410")]
	public void DNMNEOINKHK(JEJBOBIDBPC NKIMIKOLCFE, int ENFPFMIMCHI, int LHKAOEMGPFE, float NIOHMEJKMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A04100", Offset = "0x6A03100", VA = "0x186A04100")]
	public void POGGOBJMMOL(ECKOAIDMBHO FHENONGMFDP, int ENFPFMIMCHI, int LHKAOEMGPFE, float NIOHMEJKMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x69FE1B0", Offset = "0x69FD1B0", VA = "0x1869FE1B0")]
	public (long, long, long) GFBBBIOJFNL()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x9CF6F0", Offset = "0x9CE6F0", VA = "0x1809CF6F0")]
	public long CKMMJFMAOGE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A004E0", Offset = "0x69FF4E0", VA = "0x186A004E0")]
	private void ICPBBMNBFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A00F30", Offset = "0x69FFF30", VA = "0x186A00F30")]
	public (long, long) JPPGOHFBPOA(float CCNLHLMBGCC, float4x4 HEHKKIOOIIG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	public void ELCOFDBINIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A03340", Offset = "0x6A02340", VA = "0x186A03340")]
	internal void OJIKGGHDJBA(MJAMOLEIMMK LCPPMNDMONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A01B50", Offset = "0x6A00B50", VA = "0x186A01B50")]
	private (float, float, float) NHNKPPGDPDF(float BLLFKDCEIDJ, float4x4 HEHKKIOOIIG)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6A01310", Offset = "0x6A00310", VA = "0x186A01310")]
	private (int, int) KLGAAPHHOND(float MJCFGOHHEFE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69FAE00", Offset = "0x69F9E00", VA = "0x1869FAE00")]
	public void CPBCFDCKPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6A00F00", Offset = "0x69FFF00", VA = "0x186A00F00")]
	private void JKLKOMANEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6A016C0", Offset = "0x6A006C0", VA = "0x186A016C0")]
	private void KNGKCMBMACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x69FC440", Offset = "0x69FB440", VA = "0x1869FC440")]
	public long EFGLDOBDHOK(long NMOCEJNFPII, int MGONNNALIJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A02750", Offset = "0x6A01750", VA = "0x186A02750")]
	private void OGJDDNMNAPJ(JEJBOBIDBPC PIEKIAEPNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x69FCC20", Offset = "0x69FBC20", VA = "0x1869FCC20")]
	private void FFPCCEBMPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6A03460", Offset = "0x6A02460", VA = "0x186A03460")]
	private void PKAJNMPAONH(JEJBOBIDBPC NKIMIKOLCFE, ECKOAIDMBHO FHENONGMFDP, int ENFPFMIMCHI, int LHKAOEMGPFE, float NIOHMEJKMIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct HNGDEFMNKBD : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct CCODEHBPJNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int JHMPKJKFEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int FDMDFJLOFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int DGKJMHKGJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int BJHMACBHMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int CJPAOPGNJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int PGBJOHKPIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int HOJEADLMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int MNDKIPNDDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float FOLGDEGALMM;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct MGLINAPLKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public MBJMEEJFJOD.KHLEPCALIHD LBBPPEDCDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float HIHNINAFKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float HPNBOGEANPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float CJCABDAIIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float DBLBHPIEJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float GEHCBMOPGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float BMKLLPAMACP;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct KENOLFJBHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> HJOPBFHGEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> HDMGLNKDBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> KKPECFEDOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> NLKOJOOOMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> EMFJNPIDLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> PHCKJPMBIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool HCAAIKOCKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int GHEDKGOGFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int JPOJGPBPILN;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6A0BF50", Offset = "0x6A0AF50", VA = "0x186A0BF50")]
		public void BOIAAEDKCNB(int HKDBBJIOGFB, int AGAKJAKDDAP, Allocator IDMGOAKOEDG, bool DHLODGNGFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6A0C130", Offset = "0x6A0B130", VA = "0x186A0C130")]
		public static KENOLFJBHFE NICDEOAIIGB(JEJBOBIDBPC LPPNOBMEEDD)
		{
			return default(KENOLFJBHFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6A0C380", Offset = "0x6A0B380", VA = "0x186A0C380")]
		public void NNOPBDMPMBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker AFJGNMPHPLP;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker OKMDMMHBCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<CCODEHBPJNL> CONBHBFGFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private KENOLFJBHFE HGFPHAEJGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private KENOLFJBHFE PIEKIAEPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 DFCOBDNBNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 KBKJFJKNAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private MGLINAPLKDK IOADBOEJOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* FPFNKPJMOBC;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	[BurstDiscard]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	[BurstDiscard]
	private static void IHKOHAPGNJE(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	[BurstDiscard]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x69F4A80", Offset = "0x69F3A80", VA = "0x1869F4A80")]
	public HNGDEFMNKBD([In] List<ONKFDHMAIIN.OFKHHKFBIHN> JCCMEPBMPDE, [In] JEJBOBIDBPC GMLGALJIDLC, [In] ONKFDHMAIIN AACBMICJDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x69F2B80", Offset = "0x69F1B80", VA = "0x1869F2B80", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x69F3FF0", Offset = "0x69F2FF0", VA = "0x1869F3FF0")]
	public void IABFMGFJMNJ(List<ONKFDHMAIIN.OFKHHKFBIHN> KFGFOILILIN, [In] ONKFDHMAIIN AACBMICJDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69F2A60", Offset = "0x69F1A60", VA = "0x1869F2A60")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool DNPIKMBBIBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x69F2BD0", Offset = "0x69F1BD0", VA = "0x1869F2BD0")]
	private ECKOAIDMBHO FADAEHBACLH(int MEJKDFIOMHG, Allocator IDMGOAKOEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x69F2CA0", Offset = "0x69F1CA0", VA = "0x1869F2CA0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void GPOELGLGPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x69F4670", Offset = "0x69F3670", VA = "0x1869F4670")]
	[IgnoreWarning(1371)]
	private CCODEHBPJNL KHLJPIANJFI([In] CCODEHBPJNL LGADAIFEHPJ, int KDECKBDBDOE, [In] NativeArray<int> DGLAKPCPOIA, [In] NativeArray<bool> FNEHMGAAEKB, NativeArray<int> MACPCALBJAN)
	{
		return default(CCODEHBPJNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x69F2A80", Offset = "0x69F1A80", VA = "0x1869F2A80")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int ECBIFEKIJAF(NativeArray<int> DGLAKPCPOIA, int BMDMINEAEID, int CADOMKMPEFA, int LJNHLHLIPFF)
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
		public static readonly ICJNMGNJFIN log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker MHHBIFDHCLF;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker HAPEFBFLCEB;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker LDDGLHMEGKK;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker BOADIDCAGKF;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker CKMABJIMDMG;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker DHGBGHPCKIC;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker CJIFGPLJNDI;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int DCEDOHFHPMJ = 65000;

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
		private Dictionary<Material, List<ONKFDHMAIIN>> HDABMABJJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<ONKFDHMAIIN> NIKIMMFEPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> EDKFFKMFBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool HEEMKJBCPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool DOPLMMNDNNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int JKHALAIFLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> MJKPBEFPIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> JKOPIAHCDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> AAOJAJJODAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> OGHPAHCKDJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private ONKFDHMAIIN FHBDEOIPBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material NPOFKOIOJEC;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int JKAPGPFLIBD = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, POHKOOHALBH)> ENOACAONFLK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> GEKHJILKDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int OBKCFNDCKKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x6A0AFA0", Offset = "0x6A09FA0", VA = "0x186A0AFA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		private static void FKBMKAFPBLJ(bool JJJOOLPIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6A07950", Offset = "0x6A06950", VA = "0x186A07950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6A05B90", Offset = "0x6A04B90", VA = "0x186A05B90")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6A05680", Offset = "0x6A04680", VA = "0x186A05680")]
		public ONKFDHMAIIN AddToBatchedMesh(POHKOOHALBH JOMCODKFHCC, Material EGLABJPOFKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A090", Offset = "0x6A09090", VA = "0x186A0A090")]
		public void RemoveFromBatchedMesh(POHKOOHALBH NKIMIKOLCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6A05A60", Offset = "0x6A04A60", VA = "0x186A05A60")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A880", Offset = "0x6A09880", VA = "0x186A0A880")]
		public void SetMaterialProperty(int JEKFLJBJJDA, Color MKAJENPGJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A430", Offset = "0x6A09430", VA = "0x186A0A430")]
		public void SetMaterialProperty(int JEKFLJBJJDA, float CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A650", Offset = "0x6A09650", VA = "0x186A0A650")]
		public void SetMaterialProperty(int JEKFLJBJJDA, Vector4 AAFAHPMPGPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A1D0", Offset = "0x6A091D0", VA = "0x186A0A1D0")]
		public void SetMaterialProperty(int JEKFLJBJJDA, Matrix4x4 PAMNOGPCJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6A06320", Offset = "0x6A05320", VA = "0x186A06320")]
		private void GKBGOMJMIII(Renderer APJGPLFHDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6A06280", Offset = "0x6A05280", VA = "0x186A06280")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6A06270", Offset = "0x6A05270", VA = "0x186A06270")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6A05D50", Offset = "0x6A04D50", VA = "0x186A05D50")]
		private void FCOOAOJPPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6A06E50", Offset = "0x6A05E50", VA = "0x186A06E50")]
		private ONKFDHMAIIN KNEFIIFEFBD(POHKOOHALBH NKIMIKOLCFE, Material EGLABJPOFKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6A05780", Offset = "0x6A04780", VA = "0x186A05780")]
		private ONKFDHMAIIN BKFAFPNFGLD(Material EGLABJPOFKK, int HLMDBCMIEFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6A07550", Offset = "0x6A06550", VA = "0x186A07550")]
		private ONKFDHMAIIN OMHDOPPACAF(Material EGLABJPOFKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x18D3FD0", Offset = "0x18D2FD0", VA = "0x1818D3FD0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6A07070", Offset = "0x6A06070", VA = "0x186A07070")]
		public void MarkDirty(POHKOOHALBH NKIMIKOLCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6A071D0", Offset = "0x6A061D0", VA = "0x186A071D0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float CCNLHLMBGCC)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6A09120", Offset = "0x6A08120", VA = "0x186A09120")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6A06910", Offset = "0x6A05910", VA = "0x186A06910")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6A07C40", Offset = "0x6A06C40", VA = "0x186A07C40")]
		public void RebatchOptimally(int DDCOJJJDPPD, int ADGDCFFFGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6A0AD30", Offset = "0x6A09D30", VA = "0x186A0AD30")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class OBMDKMHPNAD
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct CMPGDPKFFJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float NPMDLCEJBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer NMAAGALGDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public ONKFDHMAIIN OOPJBFHMCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long MHGAPOLJPGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class EPIJPNNLNKH : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x932C40", Offset = "0x931C40", VA = "0x180932C40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A0BDE0", Offset = "0x6A0ADE0", VA = "0x186A0BDE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA82910", Offset = "0xA81910", VA = "0x180A82910")]
		[DebuggerHidden]
		public EPIJPNNLNKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A0BE30", Offset = "0x6A0AE30", VA = "0x186A0BE30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B040", Offset = "0x6A0A040", VA = "0x186A0B040", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A0BC90", Offset = "0x6A0AC90", VA = "0x186A0BC90")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A0AFF0", Offset = "0x6A09FF0", VA = "0x186A0AFF0")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A0BD90", Offset = "0x6A0AD90", VA = "0x186A0BD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A0BCE0", Offset = "0x6A0ACE0", VA = "0x186A0BCE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A0BCE0", Offset = "0x6A0ACE0", VA = "0x186A0BCE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker DHGBGHPCKIC;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker JLNCCEEEHMA;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker EFMNDENHMKG;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker PJLAPBDHPME;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 PIAPKIOJGCC;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int LANMHOGGDBK;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int POBEDHMGNLM;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int GLACIHKEGAA;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int KPMCJNBMDGC;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int IKOMKMFCNBN;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int PBCMCODLAJE;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int DDNJMDCMJFC;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int OCIIPNGJMCF;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int GMFDNGNHDMA;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int LHINLPEGKKF;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int CDFGHCMEGAO;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int FELCOHDPJCO;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int LIJEHDAGMLA;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int DFGDPOEMADD;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long KFCPDDBCGOO;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long FHBBGJLGFBH;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int DDDFOHDNAKK;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int ACPFIAJADLC;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int LKLHGCJEAGA;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long OJINACJBFBM;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool PJGEOHHODAH;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> OEPEGNCEJAA;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<CMPGDPKFFJL> HGMNEPKIFLO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool BDOGIGEGDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F6B0", Offset = "0x6A0E6B0", VA = "0x186A0F6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void IHKOHAPGNJE(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F9F0", Offset = "0x6A0E9F0", VA = "0x186A0F9F0")]
	public static void IPJLDPAJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F440", Offset = "0x6A0E440", VA = "0x186A0F440")]
	public static void FMHFNHCEAMC(BatchedMeshRenderer BADKLJEBFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6A10020", Offset = "0x6A0F020", VA = "0x186A10020")]
	public static void MMAJHBMKOJB(BatchedMeshRenderer BADKLJEBFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C8B0", Offset = "0x6A0B8B0", VA = "0x186A0C8B0")]
	private static (long, long, long) EDKFFOANDCM(long AHGIIKDFBAC)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CD60", Offset = "0x6A0BD60", VA = "0x186A0CD60")]
	public static void FHFKMBIPFPE(long AHGIIKDFBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C9C0", Offset = "0x6A0B9C0", VA = "0x186A0C9C0")]
	public static long EFGLDOBDHOK(long NMOCEJNFPII)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C7A0", Offset = "0x6A0B7A0", VA = "0x186A0C7A0")]
	public static void CCALKLMGPBM(ONKFDHMAIIN OOPJBFHMCHB, BatchedMeshRenderer NMAAGALGDJH, long MHGAPOLJPGF, float NPMDLCEJBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FF20", Offset = "0x6A0EF20", VA = "0x186A0FF20")]
	public static void MFIHFJLECHO(ONKFDHMAIIN OOPJBFHMCHB, BatchedMeshRenderer NMAAGALGDJH, long MHGAPOLJPGF, float CMMGEOJCFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A100D0", Offset = "0x6A0F0D0", VA = "0x186A100D0")]
	public static void NGALAGILODA(ONKFDHMAIIN OOPJBFHMCHB, BatchedMeshRenderer NMAAGALGDJH, long MHGAPOLJPGF, float CMMGEOJCFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FD70", Offset = "0x6A0ED70", VA = "0x186A0FD70")]
	public static void LADFCDJDFHE(ONKFDHMAIIN OOPJBFHMCHB, BatchedMeshRenderer NMAAGALGDJH, long MHGAPOLJPGF, float NPMDLCEJBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C440", Offset = "0x6A0B440", VA = "0x186A0C440")]
	public static float APNFPIMBECJ(long IHPLCCDMJBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FBA0", Offset = "0x6A0EBA0", VA = "0x186A0FBA0")]
	public static (long, long) JPPGOHFBPOA(float CCNLHLMBGCC)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A101E0", Offset = "0x6A0F1E0", VA = "0x186A101E0")]
	[IteratorStateMachine(typeof(EPIJPNNLNKH))]
	public static IEnumerable<bool> PGEBPGDODKD(long CHOLJPDPFEH, bool IJHDKMHNAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F880", Offset = "0x6A0E880", VA = "0x186A0F880")]
	public static void HJALPJJNKLK(long CHOLJPDPFEH, bool IJHDKMHNAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F740", Offset = "0x6A0E740", VA = "0x186A0F740")]
	public static int GNKIMEEGNDI()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class KDCLDKMLCBE<KeyType> : ONKFDHMAIIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, POHKOOHALBH> KIECNPEEOOH;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x41F0820", Offset = "0x41EF820", VA = "0x1841F0820")]
	public KDCLDKMLCBE(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x41F0660", Offset = "0x41EF660", VA = "0x1841F0660")]
	public void DANDGJIFFLG(KeyType BHEIPBKEDLG, POHKOOHALBH AJBLINEBFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x41F02A0", Offset = "0x41EF2A0", VA = "0x1841F02A0")]
	public bool AADJGEKMDGI(KeyType BHEIPBKEDLG, POHKOOHALBH KDANDBLPKIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x41F04A0", Offset = "0x41EF4A0", VA = "0x1841F04A0")]
	public void AOAMDEDFDFA(KeyType BHEIPBKEDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x41F06D0", Offset = "0x41EF6D0", VA = "0x1841F06D0", Slot = "4")]
	public override void JAHPHEMLLBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A105E0", Offset = "0x6A0F5E0", VA = "0x186A105E0")]
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
