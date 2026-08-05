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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B53A0", Offset = "0x69B39A0", VA = "0x1869B53A0", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDD2770", Offset = "0xDD0D70", VA = "0x180DD2770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDD1070", Offset = "0xDCF670", VA = "0x180DD1070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA794A0", Offset = "0xA77AA0", VA = "0x180A794A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDD1060", Offset = "0xDCF660", VA = "0x180DD1060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69B8300", Offset = "0x69B6900", VA = "0x1869B8300")]
	public NOPNHHMHLEP(int DBEGMBDLKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69B65F0", Offset = "0x69B4BF0", VA = "0x1869B65F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69B7E80", Offset = "0x69B6480", VA = "0x1869B7E80")]
	public void NNOPBDMPMBK(JobHandle OPKPNABHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69B7C60", Offset = "0x69B6260", VA = "0x1869B7C60")]
	public void MFICNAFJHIM(MLEKJJLPPBG FHNKDHIILBL, KBHNBLOBCGL KJOOJPONKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69B7B00", Offset = "0x69B6100", VA = "0x1869B7B00")]
	public void MBHMAMEHLMC(IJNABGLBBPB FHNKDHIILBL, NativeArray<FEGDHMAPLDK> CHPAHJONLEG, int PKIBPAHFPLK, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x69B6AF0", Offset = "0x69B50F0", VA = "0x1869B6AF0")]
	public JobHandle LFDBHHCAOLP(JEJBOBIDBPC JBBBIKDPABP, GHPIIHCLOKF GANMOBPECHM, float3 COEHKDCGGHK, quaternion EKCEGBNOFLE, float FILPOAJBJGN, bool BHPPMDIMEKO, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69B67B0", Offset = "0x69B4DB0", VA = "0x1869B67B0")]
	public static JobHandle IGKNDDDPDMG(EJFDPLIAJPB DMMAFGOOFGK, JEJBOBIDBPC JBBBIKDPABP, MLEKJJLPPBG FHNKDHIILBL, JobHandle OPKPNABHNJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69B8050", Offset = "0x69B6650", VA = "0x1869B8050")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AE520", Offset = "0x69ACB20", VA = "0x1869AE520")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69AE100", Offset = "0x69AC700", VA = "0x1869AE100")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69AE260", Offset = "0x69AC860", VA = "0x1869AE260")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69AE310", Offset = "0x69AC910", VA = "0x1869AE310")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A16F0", Offset = "0x699FCF0", VA = "0x1869A16F0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69A1250", Offset = "0x699F850", VA = "0x1869A1250")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69A13B0", Offset = "0x699F9B0", VA = "0x1869A13B0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69A1460", Offset = "0x699FA60", VA = "0x1869A1460")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B0810", Offset = "0x69AEE10", VA = "0x1869B0810")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69B0370", Offset = "0x69AE970", VA = "0x1869B0370")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69B04D0", Offset = "0x69AEAD0", VA = "0x1869B04D0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69B0580", Offset = "0x69AEB80", VA = "0x1869B0580")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B9530", Offset = "0x69B7B30", VA = "0x1869B9530")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69B9090", Offset = "0x69B7690", VA = "0x1869B9090")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69B91F0", Offset = "0x69B77F0", VA = "0x1869B91F0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69B92A0", Offset = "0x69B78A0", VA = "0x1869B92A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B1F00", Offset = "0x69B0500", VA = "0x1869B1F00")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69B1AD0", Offset = "0x69B00D0", VA = "0x1869B1AD0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69B1C30", Offset = "0x69B0230", VA = "0x1869B1C30")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69B1CE0", Offset = "0x69B02E0", VA = "0x1869B1CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AD5E0", Offset = "0x69ABBE0", VA = "0x1869AD5E0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69AD1E0", Offset = "0x69AB7E0", VA = "0x1869AD1E0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69AD340", Offset = "0x69AB940", VA = "0x1869AD340")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69AD3F0", Offset = "0x69AB9F0", VA = "0x1869AD3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A0B30", Offset = "0x699F130", VA = "0x1869A0B30")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69A06D0", Offset = "0x699ECD0", VA = "0x1869A06D0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69A0830", Offset = "0x699EE30", VA = "0x1869A0830")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69A08E0", Offset = "0x699EEE0", VA = "0x1869A08E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x699E4E0", Offset = "0x699CAE0", VA = "0x18699E4E0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x699E0E0", Offset = "0x699C6E0", VA = "0x18699E0E0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x699E240", Offset = "0x699C840", VA = "0x18699E240")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x699E2F0", Offset = "0x699C8F0", VA = "0x18699E2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x699FE00", Offset = "0x699E400", VA = "0x18699FE00")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x699F930", Offset = "0x699DF30", VA = "0x18699F930")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x699FA90", Offset = "0x699E090", VA = "0x18699FA90")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x699FB40", Offset = "0x699E140", VA = "0x18699FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A4770", Offset = "0x69A2D70", VA = "0x1869A4770")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69A42B0", Offset = "0x69A28B0", VA = "0x1869A42B0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69A4410", Offset = "0x69A2A10", VA = "0x1869A4410")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x69A44C0", Offset = "0x69A2AC0", VA = "0x1869A44C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A5260", Offset = "0x69A3860", VA = "0x1869A5260")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69A4E30", Offset = "0x69A3430", VA = "0x1869A4E30")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69A4F90", Offset = "0x69A3590", VA = "0x1869A4F90")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x69A5040", Offset = "0x69A3640", VA = "0x1869A5040")]
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
		[Cpp2IlInjected.Address(RVA = "0x69BA5F0", Offset = "0x69B8BF0", VA = "0x1869BA5F0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x69BA1A0", Offset = "0x69B87A0", VA = "0x1869BA1A0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x69BA300", Offset = "0x69B8900", VA = "0x1869BA300")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69BA3B0", Offset = "0x69B89B0", VA = "0x1869BA3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69ADBB0", Offset = "0x69AC1B0", VA = "0x1869ADBB0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69AD710", Offset = "0x69ABD10", VA = "0x1869AD710")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69AD870", Offset = "0x69ABE70", VA = "0x1869AD870")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x69AD920", Offset = "0x69ABF20", VA = "0x1869AD920")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A5870", Offset = "0x69A3E70", VA = "0x1869A5870")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69A5390", Offset = "0x69A3990", VA = "0x1869A5390")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x69A54F0", Offset = "0x69A3AF0", VA = "0x1869A54F0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x69A55A0", Offset = "0x69A3BA0", VA = "0x1869A55A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B19A0", Offset = "0x69AFFA0", VA = "0x1869B19A0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x69B14C0", Offset = "0x69AFAC0", VA = "0x1869B14C0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x69B1620", Offset = "0x69AFC20", VA = "0x1869B1620")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x69B16D0", Offset = "0x69AFCD0", VA = "0x1869B16D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x699EBD0", Offset = "0x699D1D0", VA = "0x18699EBD0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x699E610", Offset = "0x699CC10", VA = "0x18699E610")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x699E770", Offset = "0x699CD70", VA = "0x18699E770")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x699E820", Offset = "0x699CE20", VA = "0x18699E820")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B3ED0", Offset = "0x69B24D0", VA = "0x1869B3ED0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x69B3A70", Offset = "0x69B2070", VA = "0x1869B3A70")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69B3BD0", Offset = "0x69B21D0", VA = "0x1869B3BD0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x69B3C80", Offset = "0x69B2280", VA = "0x1869B3C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A4180", Offset = "0x69A2780", VA = "0x1869A4180")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x69A3D60", Offset = "0x69A2360", VA = "0x1869A3D60")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69A3EC0", Offset = "0x69A24C0", VA = "0x1869A3EC0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69A3F70", Offset = "0x69A2570", VA = "0x1869A3F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A4D00", Offset = "0x69A3300", VA = "0x1869A4D00")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x69A48A0", Offset = "0x69A2EA0", VA = "0x1869A48A0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x69A4A00", Offset = "0x69A3000", VA = "0x1869A4A00")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x69A4AB0", Offset = "0x69A30B0", VA = "0x1869A4AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AEA50", Offset = "0x69AD050", VA = "0x1869AEA50")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x69AE650", Offset = "0x69ACC50", VA = "0x1869AE650")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x69AE7B0", Offset = "0x69ACDB0", VA = "0x1869AE7B0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69AE860", Offset = "0x69ACE60", VA = "0x1869AE860")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B89E0", Offset = "0x69B6FE0", VA = "0x1869B89E0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69B8510", Offset = "0x69B6B10", VA = "0x1869B8510")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x69B8670", Offset = "0x69B6C70", VA = "0x1869B8670")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x69B8720", Offset = "0x69B6D20", VA = "0x1869B8720")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A1120", Offset = "0x699F720", VA = "0x1869A1120")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x69A0C60", Offset = "0x699F260", VA = "0x1869A0C60")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x69A0DC0", Offset = "0x699F3C0", VA = "0x1869A0DC0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x69A0E70", Offset = "0x699F470", VA = "0x1869A0E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B5270", Offset = "0x69B3870", VA = "0x1869B5270")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x69B4DE0", Offset = "0x69B33E0", VA = "0x1869B4DE0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x69B4F40", Offset = "0x69B3540", VA = "0x1869B4F40")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x69B4FF0", Offset = "0x69B35F0", VA = "0x1869B4FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x699F130", Offset = "0x699D730", VA = "0x18699F130")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x699ED00", Offset = "0x699D300", VA = "0x18699ED00")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x699EE60", Offset = "0x699D460", VA = "0x18699EE60")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x699EF10", Offset = "0x699D510", VA = "0x18699EF10")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A5E90", Offset = "0x69A4490", VA = "0x1869A5E90")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x69A59A0", Offset = "0x69A3FA0", VA = "0x1869A59A0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x69A5B00", Offset = "0x69A4100", VA = "0x1869A5B00")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x69A5BB0", Offset = "0x69A41B0", VA = "0x1869A5BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B4AB0", Offset = "0x69B30B0", VA = "0x1869B4AB0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x69B4510", Offset = "0x69B2B10", VA = "0x1869B4510")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x69B4670", Offset = "0x69B2C70", VA = "0x1869B4670")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x69B4720", Offset = "0x69B2D20", VA = "0x1869B4720")]
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
		[Cpp2IlInjected.Address(RVA = "0x69ACFB0", Offset = "0x69AB5B0", VA = "0x1869ACFB0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x69ACA00", Offset = "0x69AB000", VA = "0x1869ACA00")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x69ACB60", Offset = "0x69AB160", VA = "0x1869ACB60")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x69ACC10", Offset = "0x69AB210", VA = "0x1869ACC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x699F800", Offset = "0x699DE00", VA = "0x18699F800")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x699F260", Offset = "0x699D860", VA = "0x18699F260")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x699F3C0", Offset = "0x699D9C0", VA = "0x18699F3C0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x699F470", Offset = "0x699DA70", VA = "0x18699F470")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B6000", Offset = "0x69B4600", VA = "0x1869B6000")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x69B5B70", Offset = "0x69B4170", VA = "0x1869B5B70")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x69B5CD0", Offset = "0x69B42D0", VA = "0x1869B5CD0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x69B5D80", Offset = "0x69B4380", VA = "0x1869B5D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B5940", Offset = "0x69B3F40", VA = "0x1869B5940")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x69B54F0", Offset = "0x69B3AF0", VA = "0x1869B54F0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x69B5650", Offset = "0x69B3C50", VA = "0x1869B5650")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x69B5700", Offset = "0x69B3D00", VA = "0x1869B5700")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B8F60", Offset = "0x69B7560", VA = "0x1869B8F60")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x69B8B10", Offset = "0x69B7110", VA = "0x1869B8B10")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x69B8C70", Offset = "0x69B7270", VA = "0x1869B8C70")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x69B8D20", Offset = "0x69B7320", VA = "0x1869B8D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A05A0", Offset = "0x699EBA0", VA = "0x1869A05A0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x69A0030", Offset = "0x699E630", VA = "0x1869A0030")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x69A0190", Offset = "0x699E790", VA = "0x1869A0190")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x69A0240", Offset = "0x699E840", VA = "0x1869A0240")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B43E0", Offset = "0x69B29E0", VA = "0x1869B43E0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x69B4000", Offset = "0x69B2600", VA = "0x1869B4000")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x69B4160", Offset = "0x69B2760", VA = "0x1869B4160")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x69B4210", Offset = "0x69B2810", VA = "0x1869B4210")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AB490", Offset = "0x69A9A90", VA = "0x1869AB490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69ABED0", Offset = "0x69AA4D0", VA = "0x1869ABED0")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69A9170", Offset = "0x69A7770", VA = "0x1869A9170")]
	public static ECKOAIDMBHO GIGNPOIHFIA(Allocator IDMGOAKOEDG, JEJBOBIDBPC CPJANCBBPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69A9350", Offset = "0x69A7950", VA = "0x1869A9350")]
	public static ECKOAIDMBHO GIGNPOIHFIA(Allocator IDMGOAKOEDG, NativeArray<float3> EDGPFEDAAFF, NativeArray<float3> BLHIFFJLDMB, NativeArray<float2> JMBKEBHHGPD, NativeArray<float4> HNDBCJANMCI, bool HCAAIKOCKDP, NativeArray<float4> ANMLDFBBOKD, NativeArray<int> LKKNPKMPFHN, int PKIBPAHFPLK, int PPKLMNAPBHF, int OPOFHOEKKOD, int JJFNDHOPKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69A8B90", Offset = "0x69A7190", VA = "0x1869A8B90")]
	public JEJBOBIDBPC GICNANALPNF(Allocator IDMGOAKOEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69AC450", Offset = "0x69AAA50", VA = "0x1869AC450")]
	public void OMNFHIEFOAK(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69A78F0", Offset = "0x69A5EF0", VA = "0x1869A78F0")]
	private void DLCKIBNLAFH(Mesh NKIMIKOLCFE, NativeArray<ushort> FBCPOFHPDCF, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69A6680", Offset = "0x69A4C80", VA = "0x1869A6680")]
	public void BMDKJPNJILE(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69AA950", Offset = "0x69A8F50", VA = "0x1869AA950")]
	public void KDMMNICIBHI(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69A6F10", Offset = "0x69A5510", VA = "0x1869A6F10")]
	public void CKEOBCJHBBI(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69AC710", Offset = "0x69AAD10", VA = "0x1869AC710")]
	public void PJAFKONOMOB(Mesh NKIMIKOLCFE, JEJBOBIDBPC.LDJNLICPPEM JFOBPJMAIKI, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69A8880", Offset = "0x69A6E80", VA = "0x1869A8880")]
	public long GFBBBIOJFNL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69A7A10", Offset = "0x69A6010", VA = "0x1869A7A10")]
	public long DMGKNCFBLKL(JEJBOBIDBPC.LDJNLICPPEM JFOBPJMAIKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69A6C00", Offset = "0x69A5200", VA = "0x1869A6C00")]
	private void BOIAAEDKCNB(int HKDBBJIOGFB, int AGAKJAKDDAP, Allocator IDMGOAKOEDG, bool DHLODGNGFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69A7C90", Offset = "0x69A6290", VA = "0x1869A7C90")]
	private void ECIBMABIOAE(NativeArray<float3> JFKBJHPGAMG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69A7D90", Offset = "0x69A6390", VA = "0x1869A7D90")]
	[BurstCompile]
	private unsafe static void ECIBMABIOAE([NoAlias] float3* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69A77F0", Offset = "0x69A5DF0", VA = "0x1869A77F0")]
	[BurstCompile]
	private unsafe static void DGOGBHBCNMI([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69A7A80", Offset = "0x69A6080", VA = "0x1869A7A80")]
	[BurstCompile]
	private unsafe static void DMLOBKEEBOB([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69A6230", Offset = "0x69A4830", VA = "0x1869A6230")]
	[BurstCompile]
	private unsafe static void AGJOBNPKEFM([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69A8A00", Offset = "0x69A7000", VA = "0x1869A8A00")]
	private void GHFAMOHDOOK(NativeArray<float3> EDGPFEDAAFF, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69A8B00", Offset = "0x69A7100", VA = "0x1869A8B00")]
	[BurstCompile]
	private unsafe static void GHFAMOHDOOK([NoAlias] ushort* JFKBJHPGAMG, [Out] float3 HFHJMPLEMEK, [Out] float3 FJEPEOOFHFH, [In][NoAlias] float3* EDGPFEDAAFF, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69AB3D0", Offset = "0x69A99D0", VA = "0x1869AB3D0")]
	private void LFJFAHNFLFK(NativeArray<float3> BLHIFFJLDMB, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69AB1B0", Offset = "0x69A97B0", VA = "0x1869AB1B0")]
	[BurstCompile]
	private unsafe static void LFJFAHNFLFK([NoAlias] ushort* ANOKGEJHKEM, [In][NoAlias] float3* BLHIFFJLDMB, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69AB070", Offset = "0x69A9670", VA = "0x1869AB070")]
	private void KKOONPBBNAO(NativeArray<float3> NDBKOJHGPDL, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69AB140", Offset = "0x69A9740", VA = "0x1869AB140")]
	[BurstCompile]
	private unsafe static void KKOONPBBNAO([NoAlias] float3* NDBKOJHGPDL, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69A83F0", Offset = "0x69A69F0", VA = "0x1869A83F0")]
	[BurstCompile]
	private unsafe static void EPLIOPHLHAI([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69AA8E0", Offset = "0x69A8EE0", VA = "0x1869AA8E0")]
	[BurstCompile]
	private unsafe static void JPMICHJHACL([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69AB530", Offset = "0x69A9B30", VA = "0x1869AB530")]
	[BurstCompile]
	private unsafe static void MABNMHEDABF([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69A8320", Offset = "0x69A6920", VA = "0x1869A8320")]
	private void EOGIKJCIMPK(NativeArray<float2> JMBKEBHHGPD, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69A80D0", Offset = "0x69A66D0", VA = "0x1869A80D0")]
	[BurstCompile]
	private unsafe static void EOGIKJCIMPK([NoAlias] ushort* EBHAIPICNJH, [Out] float2 KADBOKJLOPC, [Out] float2 CMMGDJGCDKF, [In][NoAlias] float2* JMBKEBHHGPD, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69A7870", Offset = "0x69A5E70", VA = "0x1869A7870")]
	[BurstCompile]
	private static void DJPACNOKKGL([Out] float2 JJJOOHEBOMO, ushort FOEHGGELLGK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69ABFD0", Offset = "0x69AA5D0", VA = "0x1869ABFD0")]
	private void NPFAPOKJOHL(NativeArray<float2> EBHAIPICNJH, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69AC0D0", Offset = "0x69AA6D0", VA = "0x1869AC0D0")]
	[BurstCompile]
	private unsafe static void NPFAPOKJOHL([NoAlias] float2* EBHAIPICNJH, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69AC690", Offset = "0x69AAC90", VA = "0x1869AC690")]
	[BurstCompile]
	private unsafe static void PFKMHAOPFBI([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69A6600", Offset = "0x69A4C00", VA = "0x1869A6600")]
	[BurstCompile]
	private unsafe static void BKLCDECDFNE([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69AA860", Offset = "0x69A8E60", VA = "0x1869AA860")]
	[BurstCompile]
	private unsafe static void JIBHGEDLMEJ([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69AA470", Offset = "0x69A8A70", VA = "0x1869AA470")]
	private void HOJFDFCFEKM(NativeArray<float4> ANMLDFBBOKD, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69AA560", Offset = "0x69A8B60", VA = "0x1869AA560")]
	[BurstCompile]
	private unsafe static void HOJFDFCFEKM([NoAlias] ushort* DPHIFJHGMNM, [In][NoAlias] float4* EGEFFIIDCMM, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69AA200", Offset = "0x69A8800", VA = "0x1869AA200")]
	[BurstCompile]
	private static ushort HGECBJDBIGP([In] float4 KHEJBBCBNNK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x69AAFA0", Offset = "0x69A95A0", VA = "0x1869AAFA0")]
	private void KJLLECEOMMG(NativeArray<float4> DPHIFJHGMNM, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69AAF30", Offset = "0x69A9530", VA = "0x1869AAF30")]
	[BurstCompile]
	private unsafe static void KJLLECEOMMG([NoAlias] float4* DPHIFJHGMNM, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69A7EB0", Offset = "0x69A64B0", VA = "0x1869A7EB0")]
	[BurstCompile]
	private unsafe static void ENGOIEFEADG([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69A61C0", Offset = "0x69A47C0", VA = "0x1869A61C0")]
	[BurstCompile]
	private unsafe static void AGFPLJPABOJ([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69A9E70", Offset = "0x69A8470", VA = "0x1869A9E70")]
	[BurstCompile]
	private unsafe static void GNEMELKBJLI([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69AA6E0", Offset = "0x69A8CE0", VA = "0x1869AA6E0")]
	[BurstCompile]
	private static void IMFJILPJPJK([Out] float4 HJBJAPKPPFA, ushort FOEHGGELLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69A9840", Offset = "0x69A7E40", VA = "0x1869A9840")]
	private void GMNONJBKAOO(Allocator IDMGOAKOEDG, NativeArray<float4> HNDBCJANMCI, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69A9C20", Offset = "0x69A8220", VA = "0x1869A9C20")]
	[BurstCompile]
	private unsafe static void GMNONJBKAOO([NoAlias] float4* OLGGBKFNAEF, [NoAlias] byte* PKDGCAIBGOC, [Out] int PDBJHIFLKKO, [Out] int EIJKELBOLJH, [NoAlias] float4* HNDBCJANMCI, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69A62B0", Offset = "0x69A48B0", VA = "0x1869A62B0")]
	private static void AHAJAOCPINJ(NativeArray<float4> FGBJBPMAFEK, NativeArray<BJAAJDPHBMF> NEIPNMNDENL, NativeArray<byte> POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69A63C0", Offset = "0x69A49C0", VA = "0x1869A63C0")]
	[BurstCompile]
	private unsafe static void AHAJAOCPINJ([NoAlias] float4* FGBJBPMAFEK, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69A6580", Offset = "0x69A4B80", VA = "0x1869A6580")]
	[BurstCompile]
	private unsafe static void BDKKJOOKIHM([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69A6500", Offset = "0x69A4B00", VA = "0x1869A6500")]
	[BurstCompile]
	private unsafe static void APMJFAJOHAC([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69A7B00", Offset = "0x69A6100", VA = "0x1869A7B00")]
	[BurstCompile]
	private unsafe static void DMPHNPBEEKG([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69AA390", Offset = "0x69A8990", VA = "0x1869AA390")]
	private void HMLDHFDOIAI(Allocator IDMGOAKOEDG, NativeArray<int> LKKNPKMPFHN, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69AB6A0", Offset = "0x69A9CA0", VA = "0x1869AB6A0")]
	private static NativeArray<byte> NFINELFDMEB(Allocator IDMGOAKOEDG, NativeArray<int> LKKNPKMPFHN, int LGEGKNBBNAC)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69AB910", Offset = "0x69A9F10", VA = "0x1869AB910")]
	[BurstCompile]
	private unsafe static int NFINELFDMEB([NoAlias] byte* MDMEFCIOLGE, [In][NoAlias] int* LKKNPKMPFHN, int LGEGKNBBNAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69A87B0", Offset = "0x69A6DB0", VA = "0x1869A87B0")]
	private static void GCLPNJBLEHN(NativeArray<int> IEEBFDLOEBO, NativeArray<byte> EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69A8740", Offset = "0x69A6D40", VA = "0x1869A8740")]
	[BurstCompile]
	private unsafe static void GCLPNJBLEHN([NoAlias] int* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69A8610", Offset = "0x69A6C10", VA = "0x1869A8610")]
	[BurstCompile]
	private unsafe static void FIHBMNHOAHO([NoAlias] ushort* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69AB4D0", Offset = "0x69A9AD0", VA = "0x1869AB4D0")]
	[BurstCompile]
	private static void LIABCEIHHBD([Out] float3 JJJOOHEBOMO, ushort FOEHGGELLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69AC150", Offset = "0x69AA750", VA = "0x1869AC150")]
	[BurstCompile]
	private static ushort OFOFFLDPPBH([In] float3 KHEJBBCBNNK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public ECKOAIDMBHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x699D650", Offset = "0x699BC50", VA = "0x18699D650")]
	[BurstCompile]
	public unsafe static void MEPEMGONAEG([NoAlias] float3* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69A6440", Offset = "0x69A4A40", VA = "0x1869A6440")]
	[BurstCompile]
	public unsafe static void AKJJEDPGKLO([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69A8680", Offset = "0x69A6C80", VA = "0x1869A8680")]
	[BurstCompile]
	public unsafe static void FKDGGEFNAJB([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69ABB60", Offset = "0x69AA160", VA = "0x1869ABB60")]
	[BurstCompile]
	public unsafe static void NHKMGDNHJCE([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* EDGPFEDAAFF, int PKIBPAHFPLK, [In] float3 HOEHFPMPMCH, [In] float3 FJEPEOOFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x699D270", Offset = "0x699B870", VA = "0x18699D270")]
	[BurstCompile]
	public unsafe static void KGGCIMBMELO([NoAlias] ushort* JFKBJHPGAMG, [Out] float3 HFHJMPLEMEK, [Out] float3 FJEPEOOFHFH, [In][NoAlias] float3* EDGPFEDAAFF, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x699D8A0", Offset = "0x699BEA0", VA = "0x18699D8A0")]
	[BurstCompile]
	public unsafe static void NBIDKJKBIPE([NoAlias] ushort* ANOKGEJHKEM, [In][NoAlias] float3* BLHIFFJLDMB, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69AC360", Offset = "0x69AA960", VA = "0x1869AC360")]
	[BurstCompile]
	public unsafe static void OGLMAHFEDHP([NoAlias] float3* NDBKOJHGPDL, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x699CBB0", Offset = "0x699B1B0", VA = "0x18699CBB0")]
	[BurstCompile]
	public unsafe static void GCIKCLJFDHN([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69A74F0", Offset = "0x69A5AF0", VA = "0x1869A74F0")]
	[BurstCompile]
	public unsafe static void CNKOGJKFLFC([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69ABDC0", Offset = "0x69AA3C0", VA = "0x1869ABDC0")]
	[BurstCompile]
	public unsafe static void NNCHFIPFKNC([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* BLHIFFJLDMB, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x699CFB0", Offset = "0x699B5B0", VA = "0x18699CFB0")]
	[BurstCompile]
	public unsafe static void HINPMDMGAOD([NoAlias] ushort* EBHAIPICNJH, [Out] float2 KADBOKJLOPC, [Out] float2 CMMGDJGCDKF, [In][NoAlias] float2* JMBKEBHHGPD, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69AC400", Offset = "0x69AAA00", VA = "0x1869AC400")]
	[BurstCompile]
	public static void OJHPOOGLGPN([Out] float2 JJJOOHEBOMO, ushort FOEHGGELLGK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69ABCE0", Offset = "0x69AA2E0", VA = "0x1869ABCE0")]
	[BurstCompile]
	public unsafe static void NMEANCENNMC([NoAlias] float2* EBHAIPICNJH, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69A8910", Offset = "0x69A6F10", VA = "0x1869A8910")]
	[BurstCompile]
	public unsafe static void GFKEGBJMHAK([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69AB5A0", Offset = "0x69A9BA0", VA = "0x1869AB5A0")]
	[BurstCompile]
	public unsafe static void MKHILIFBNAN([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69A6D30", Offset = "0x69A5330", VA = "0x1869A6D30")]
	[BurstCompile]
	public unsafe static void CHDOCHAFINB([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [NoAlias] ushort* JMBKEBHHGPD, int PKIBPAHFPLK, [In] float2 HEFHNDLCKCD, [In] float2 CMMGDJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69AC5F0", Offset = "0x69AABF0", VA = "0x1869AC5F0")]
	[BurstCompile]
	public unsafe static void PCJKMNIHOJB([NoAlias] ushort* DPHIFJHGMNM, [In][NoAlias] float4* EGEFFIIDCMM, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69AA5E0", Offset = "0x69A8BE0", VA = "0x1869AA5E0")]
	[BurstCompile]
	public static ushort HPKOHCPMNDI([In] float4 KHEJBBCBNNK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69AA640", Offset = "0x69A8C40", VA = "0x1869AA640")]
	[BurstCompile]
	public unsafe static void IHMIILAKFPM([NoAlias] float4* DPHIFJHGMNM, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x699C900", Offset = "0x699AF00", VA = "0x18699C900")]
	[BurstCompile]
	public unsafe static void FFMLOAPBONI([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69AA740", Offset = "0x69A8D40", VA = "0x1869AA740")]
	[BurstCompile]
	public unsafe static void JAILFIPENGG([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69A7B80", Offset = "0x69A6180", VA = "0x1869A7B80")]
	[BurstCompile]
	public unsafe static void DNKGBFFFHEH([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] ushort* ANMLDFBBOKD, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69ABC20", Offset = "0x69AA220", VA = "0x1869ABC20")]
	[BurstCompile]
	public static void NHMJFABMPJP([Out] float4 HJBJAPKPPFA, ushort FOEHGGELLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x699C740", Offset = "0x699AD40", VA = "0x18699C740")]
	[BurstCompile]
	public unsafe static void ECDEKHNBINK([NoAlias] float4* OLGGBKFNAEF, [NoAlias] byte* PKDGCAIBGOC, [Out] int PDBJHIFLKKO, [Out] int EIJKELBOLJH, [NoAlias] float4* HNDBCJANMCI, int JJFNDHOPKLA, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69AA0C0", Offset = "0x69A86C0", VA = "0x1869AA0C0")]
	[BurstCompile]
	public unsafe static void HGBCFDPHNGK([NoAlias] float4* FGBJBPMAFEK, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69A9EE0", Offset = "0x69A84E0", VA = "0x1869A9EE0")]
	[BurstCompile]
	public unsafe static void HFLCNJJGCMA([NoAlias] JEJBOBIDBPC.GIPJPHHALKN* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69A7610", Offset = "0x69A5C10", VA = "0x1869A7610")]
	[BurstCompile]
	public unsafe static void CNPECPNILAL([NoAlias] JEJBOBIDBPC.NIIBFBAPMHJ* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x69AB980", Offset = "0x69A9F80", VA = "0x1869AB980")]
	[BurstCompile]
	public unsafe static void NHECJIIJPMH([NoAlias] JEJBOBIDBPC.IKJFGLFEJFP* JFKBJHPGAMG, [In][NoAlias] BJAAJDPHBMF* NEIPNMNDENL, [In][NoAlias] byte* POHDFKOKBPG, int PKIBPAHFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69A60C0", Offset = "0x69A46C0", VA = "0x1869A60C0")]
	[BurstCompile]
	public unsafe static int AEIPBJPNLLP([NoAlias] byte* MDMEFCIOLGE, [In][NoAlias] int* LKKNPKMPFHN, int LGEGKNBBNAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69AC550", Offset = "0x69AAB50", VA = "0x1869AC550")]
	[BurstCompile]
	public unsafe static void PBHIHJDNBON([NoAlias] int* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69A7E10", Offset = "0x69A6410", VA = "0x1869A7E10")]
	[BurstCompile]
	public unsafe static void EDCPNDIFJCP([NoAlias] ushort* IEEBFDLOEBO, [In][NoAlias] byte* EFKPIMONPCO, int OPOFHOEKKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69AA250", Offset = "0x69A8850", VA = "0x1869AA250")]
	[BurstCompile]
	public static void HHEPNFLDLDP([Out] float3 JJJOOHEBOMO, ushort FOEHGGELLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x699CDF0", Offset = "0x699B3F0", VA = "0x18699CDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x865830", Offset = "0x863E30", VA = "0x180865830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x69B4D20", Offset = "0x69B3320", VA = "0x1869B4D20")]
	public LMEJFJKKBOE(int HKDBBJIOGFB, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x69B4BE0", Offset = "0x69B31E0", VA = "0x1869B4BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x69B4C40", Offset = "0x69B3240", VA = "0x1869B4C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B3660", Offset = "0x69B1C60", VA = "0x1869B3660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<ENOMGJJDCNC> AJFJKMDFKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x69B2760", Offset = "0x69B0D60", VA = "0x1869B2760")]
		get
		{
			return default(NativeList<ENOMGJJDCNC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static LMEJFJKKBOE LJFFFHIEDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x69B35C0", Offset = "0x69B1BC0", VA = "0x1869B35C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x69B2CE0", Offset = "0x69B12E0", VA = "0x1869B2CE0")]
	private static void JBJPDNDCOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x69B33D0", Offset = "0x69B19D0", VA = "0x1869B33D0")]
	public static int LOEGOFFBDBB(bool OPBPJBOLAEL, int BINIOKIHNDM, bool JJLNOGIMBHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x69B20A0", Offset = "0x69B06A0", VA = "0x1869B20A0")]
	private static int BIGEBOECJBD(int BINIOKIHNDM, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x69B34A0", Offset = "0x69B1AA0", VA = "0x1869B34A0")]
	private static int MLFNMGPBOML(int BINIOKIHNDM, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x69B3330", Offset = "0x69B1930", VA = "0x1869B3330")]
	public static int KADAKAGIABE(int KEAEHEPAPAH, int BINIOKIHNDM, int BIAGKLHEIMO, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x69B3400", Offset = "0x69B1A00", VA = "0x1869B3400")]
	public static int MDFHELMDJHJ(int KEAEHEPAPAH, int BINIOKIHNDM, int BIAGKLHEIMO, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x69B3490", Offset = "0x69B1A90", VA = "0x1869B3490")]
	public static int MKGEMIAFLII(int BIAGKLHEIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x69B33C0", Offset = "0x69B19C0", VA = "0x1869B33C0")]
	private static int KCJHFLOLDJE(int BINIOKIHNDM, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x69B34B0", Offset = "0x69B1AB0", VA = "0x1869B34B0")]
	private static int MMLGCBICDHP(int BINIOKIHNDM, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x69B2030", Offset = "0x69B0630", VA = "0x1869B2030")]
	public static int ADGJFOMKODL(int KEAEHEPAPAH, int BINIOKIHNDM, int BIAGKLHEIMO, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x69B2800", Offset = "0x69B0E00", VA = "0x1869B2800")]
	public static int HBAFAKPIFEG(int KEAEHEPAPAH, int BINIOKIHNDM, int BIAGKLHEIMO, bool LMINACBGCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x69B2CC0", Offset = "0x69B12C0", VA = "0x1869B2CC0")]
	public static int IACDEICAMBC(int BIAGKLHEIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x69B34D0", Offset = "0x69B1AD0", VA = "0x1869B34D0")]
	public static LMEJFJKKBOE NGLMMBCIPDE(int BINIOKIHNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x69B24D0", Offset = "0x69B0AD0", VA = "0x1869B24D0")]
	private static LMEJFJKKBOE CNJMKGBDNEO(int BINIOKIHNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x69B2BD0", Offset = "0x69B11D0", VA = "0x1869B2BD0")]
	public static LMEJFJKKBOE HIOMGINOEMB(int BINIOKIHNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x69B2890", Offset = "0x69B0E90", VA = "0x1869B2890")]
	private static LMEJFJKKBOE HHFEFJKKONL(int BINIOKIHNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x69B20C0", Offset = "0x69B06C0", VA = "0x1869B20C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69B3940", Offset = "0x69B1F40", VA = "0x1869B3940")]
	public KJOIGFJGHJJ(NativeArray<FEGDHMAPLDK> LLCCIFKNMCA, int ENCFHCJIMBE = 1, Allocator IDMGOAKOEDG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x69B3850", Offset = "0x69B1E50", VA = "0x1869B3850", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69A38A0", Offset = "0x69A1EA0", VA = "0x1869A38A0")]
	public CLPEFMJCKAB(NOPNHHMHLEP KPNFINGJNEK, JEJBOBIDBPC NGENPPMBGHN, float3 KJGKFMJNDMA, quaternion KLLFKBECAGD, float DMBHPKECOAB, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x69A3B30", Offset = "0x69A2130", VA = "0x1869A3B30")]
	public CLPEFMJCKAB(KJOIGFJGHJJ KPNFINGJNEK, JEJBOBIDBPC NGENPPMBGHN, float3 KJGKFMJNDMA, quaternion KLLFKBECAGD, float3 DMBHPKECOAB, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x69A31A0", Offset = "0x69A17A0", VA = "0x1869A31A0")]
	private float3 MFKOGFDNFEH(float3 HOPBOPIFFKK, Matrix4x4 OMPOJIFAKLI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x69A1930", Offset = "0x699FF30", VA = "0x1869A1930")]
	private float3x3 EONAMBLOBBF(float3x3 KCLNIOKABBM, float3x3 AJHNLGKGPAE)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x69A1920", Offset = "0x699FF20", VA = "0x1869A1920")]
	private float AOFIFHEOPNE(float GNMLLHFGICG, float EKHGJBOMMLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x69A19B0", Offset = "0x699FFB0", VA = "0x1869A19B0", Slot = "4")]
	public void Execute(int JPMDPHGDIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x69A3730", Offset = "0x69A1D30", VA = "0x1869A3730")]
	private void OPNNFBMLMNN(int ENPFGOBIHKI, float3 MOIICCIPACK, float3 FFJHDFACBIE, float3 EKBJDPFKMAM, float AMCMIGCLHDD, bool PIMPIKCFJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x69A32D0", Offset = "0x69A18D0", VA = "0x1869A32D0")]
	private void OCDDFMMFONC(IJNABGLBBPB PGJMPKMCFHM, float3 OGNOLJCMDMP, float3x3 NACDGIDELJO, float GNMLLHFGICG, int IOKPFNHCNGL, int IOEMCCIKKGM, int FMMJOHDMJFE, float KPCGDJJONPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x69A2B50", Offset = "0x69A1150", VA = "0x1869A2B50")]
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
	[Cpp2IlInjected.Address(RVA = "0x69AC910", Offset = "0x69AAF10", VA = "0x1869AC910")]
	public EJFDPLIAJPB(int ENCFHCJIMBE, Allocator IDMGOAKOEDG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x69AC870", Offset = "0x69AAE70", VA = "0x1869AC870", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69B0180", Offset = "0x69AE780", VA = "0x1869B0180")]
	public IHCIGIPGKBB(NOPNHHMHLEP KPNFINGJNEK, JEJBOBIDBPC NGENPPMBGHN, float3 KJGKFMJNDMA, quaternion KLLFKBECAGD, float DMBHPKECOAB, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x69AFF90", Offset = "0x69AE590", VA = "0x1869AFF90")]
	public IHCIGIPGKBB(EJFDPLIAJPB FHNKDHIILBL, JEJBOBIDBPC NGENPPMBGHN, float3 KJGKFMJNDMA, quaternion KLLFKBECAGD, float3 DMBHPKECOAB, int HFBKEMINOAI = 0, int CBHPLEBEDKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x69AEF30", Offset = "0x69AD530", VA = "0x1869AEF30", Slot = "4")]
	public void Execute(int JPMDPHGDIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x69AEB80", Offset = "0x69AD180", VA = "0x1869AEB80")]
	private void CFLMDNGIGNE(float4x4 MMBLFGFELMD, int JPMDPHGDIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x69AFE90", Offset = "0x69AE490", VA = "0x1869AFE90")]
	private AADHNHKNECO LNIFIPOCEGC(float3 FFJHDFACBIE)
	{
		return default(AADHNHKNECO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x69AFF00", Offset = "0x69AE500", VA = "0x1869AFF00")]
	private float4 OINDCKHCPGE(AADHNHKNECO AFBNALEMNLO, int LLPJHIPCNFD)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x69AFF50", Offset = "0x69AE550", VA = "0x1869AFF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B0DB0", Offset = "0x69AF3B0", VA = "0x1869B0DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 PGGBDIGHJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x69B0CD0", Offset = "0x69AF2D0", VA = "0x1869B0CD0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x69B13D0", Offset = "0x69AF9D0", VA = "0x1869B13D0")]
	public KBHNBLOBCGL(float3 MOIICCIPACK, quaternion ADNGPFKNGFI, float3 ENCFHCJIMBE, EPAHFFCPOCH PBLNJHEPKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x69B0EB0", Offset = "0x69AF4B0", VA = "0x1869B0EB0")]
	public float LKPOIMHGGHD(float3 OGNOLJCMDMP, float BNDBPNFJNIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x69B0DC0", Offset = "0x69AF3C0", VA = "0x1869B0DC0")]
	public bool JMPLPDLPODF(float3 FFJHDFACBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x69B10B0", Offset = "0x69AF6B0", VA = "0x1869B10B0")]
	public void MDHFPHHAFPO(float3 IOGKFELDEIF, float3x3 EFLPFLMANDF, float POEKJGODHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x69B1260", Offset = "0x69AF860", VA = "0x1869B1260")]
	private void NILCEJNEIMO(float3 BJEINPMOICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x69B0A40", Offset = "0x69AF040", VA = "0x1869B0A40")]
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
	[Cpp2IlInjected.Address(RVA = "0x69BA100", Offset = "0x69B8700", VA = "0x1869BA100")]
	public PDDNHBBGKBJ(JEJBOBIDBPC NKIMIKOLCFE, float GKKNEINMIIE, int GEIGDPFELPO, int IOKPFNHCNGL, NativeList<KBHNBLOBCGL> FHNKDHIILBL, NativeArray<int> BKJOLKKFNKP, NativeList<ENOMGJJDCNC> IPPHLBMKDLM, GHPIIHCLOKF GANMOBPECHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x69B9660", Offset = "0x69B7C60", VA = "0x1869B9660", Slot = "4")]
	public void Execute(int PGPKMKINHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x69BA040", Offset = "0x69B8640", VA = "0x1869BA040")]
	private bool JIJOJNFNDFI(KBHNBLOBCGL FAGKOOGCGBH, KBHNBLOBCGL HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x69B9DA0", Offset = "0x69B83A0", VA = "0x1869B9DA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69ADDE0", Offset = "0x69AC3E0", VA = "0x1869ADDE0")]
	public void BOIAAEDKCNB(int HKDBBJIOGFB, int AGAKJAKDDAP, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x69ADFF0", Offset = "0x69AC5F0", VA = "0x1869ADFF0")]
	public static long LAHECLHAOLN(int HKDBBJIOGFB, int AGAKJAKDDAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x69ADF00", Offset = "0x69AC500", VA = "0x1869ADF00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x69AE010", Offset = "0x69AC610", VA = "0x1869AE010")]
	public void NNOPBDMPMBK(JobHandle OPKPNABHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
	[Cpp2IlInjected.Address(RVA = "0x69B6570", Offset = "0x69B4B70", VA = "0x1869B6570")]
	public NMIJGEPLCDC(JEJBOBIDBPC NKIMIKOLCFE, GHPIIHCLOKF GANMOBPECHM, int CBHPLEBEDKE = 0, int HFBKEMINOAI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x69B6190", Offset = "0x69B4790", VA = "0x1869B6190", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x69B6130", Offset = "0x69B4730", VA = "0x1869B6130")]
	private void DOBKNLFDGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CEMDIPPNIBJ
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x291A3C0", Offset = "0x29189C0", VA = "0x18291A3C0")]
	public static bool FGNBMMPFDHD<T>(NativeArray<T> GGEMIJICFPG, int ENCFHCJIMBE, Allocator IDMGOAKOEDG, NativeArrayOptions HEBGDGGBJPN = NativeArrayOptions.ClearMemory, int ALAAGAAHHAK = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x291A540", Offset = "0x2918B40", VA = "0x18291A540")]
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
		[Cpp2IlInjected.Address(RVA = "0x69BB8C0", Offset = "0x69B9EC0", VA = "0x1869BB8C0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x69BB440", Offset = "0x69B9A40", VA = "0x1869BB440")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x69BB5A0", Offset = "0x69B9BA0", VA = "0x1869BB5A0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69BB650", Offset = "0x69B9C50", VA = "0x1869BB650")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D1240", Offset = "0x69CF840", VA = "0x1869D1240")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x69D0CF0", Offset = "0x69CF2F0", VA = "0x1869D0CF0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x69D0E50", Offset = "0x69CF450", VA = "0x1869D0E50")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x69D0F00", Offset = "0x69CF500", VA = "0x1869D0F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x69BBE80", Offset = "0x69BA480", VA = "0x1869BBE80")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x69BB9F0", Offset = "0x69B9FF0", VA = "0x1869BB9F0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x69BBB50", Offset = "0x69BA150", VA = "0x1869BBB50")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x69BBC00", Offset = "0x69BA200", VA = "0x1869BBC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D0BC0", Offset = "0x69CF1C0", VA = "0x1869D0BC0")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x69D0770", Offset = "0x69CED70", VA = "0x1869D0770")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x69D08D0", Offset = "0x69CEED0", VA = "0x1869D08D0")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x69D0980", Offset = "0x69CEF80", VA = "0x1869D0980")]
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
		[Cpp2IlInjected.Address(RVA = "0x69BC960", Offset = "0x69BAF60", VA = "0x1869BC960")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x69BC510", Offset = "0x69BAB10", VA = "0x1869BC510")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x69BC670", Offset = "0x69BAC70", VA = "0x1869BC670")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x69BC720", Offset = "0x69BAD20", VA = "0x1869BC720")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C38E0", Offset = "0x69C1EE0", VA = "0x1869C38E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GHEDKGOGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x69C5130", Offset = "0x69C3730", VA = "0x1869C5130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x69C51B0", Offset = "0x69C37B0", VA = "0x1869C51B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GEJFPJEEKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69C5170", Offset = "0x69C3770", VA = "0x1869C5170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void IHKOHAPGNJE(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x69C31A0", Offset = "0x69C17A0", VA = "0x1869C31A0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x69C20E0", Offset = "0x69C06E0", VA = "0x1869C20E0")]
	public void BOIAAEDKCNB(int HKDBBJIOGFB, int AGAKJAKDDAP, Allocator IDMGOAKOEDG, bool PNCCPGHDBCD, bool DHLODGNGFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x69C5260", Offset = "0x69C3860", VA = "0x1869C5260")]
	public void OGNKAFAHLEF(int HKDBBJIOGFB, int AGAKJAKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x69C6140", Offset = "0x69C4740", VA = "0x1869C6140", Slot = "6")]
	public bool PEBJGOJALEP(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x69C52E0", Offset = "0x69C38E0", VA = "0x1869C52E0")]
	public bool OMNFHIEFOAK(Mesh NKIMIKOLCFE, bool APHCFPDNDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x69C32B0", Offset = "0x69C18B0", VA = "0x1869C32B0")]
	public bool ECEHJOCHEIK(Mesh NKIMIKOLCFE, JEJBOBIDBPC BAKFKOANHAF, bool APHCFPDNDMK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x69C1690", Offset = "0x69BFC90", VA = "0x1869C1690")]
	public void BMDKJPNJILE(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x69C56C0", Offset = "0x69C3CC0", VA = "0x1869C56C0")]
	public void PDAIOJBAMPD(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x69C47E0", Offset = "0x69C2DE0", VA = "0x1869C47E0")]
	[BurstCompile]
	public static int KCOJOLCFODI(float OOALEDCPNBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x69C4830", Offset = "0x69C2E30", VA = "0x1869C4830")]
	[BurstCompile]
	public static uint KCOJOLCFODI([In] float4 DCMJEJAEEHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x69C4790", Offset = "0x69C2D90", VA = "0x1869C4790")]
	[BurstCompile]
	public static uint KCOJOLCFODI([In] float3 DCMJEJAEEHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x69C4880", Offset = "0x69C2E80", VA = "0x1869C4880")]
	public void KDMMNICIBHI(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x69C1610", Offset = "0x69BFC10", VA = "0x1869C1610")]
	[BurstCompile]
	private unsafe static void BKDOAOAHGBB([NoAlias] NIIBFBAPMHJ* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x69C2A00", Offset = "0x69C1000", VA = "0x1869C2A00")]
	public void CKEOBCJHBBI(Mesh NKIMIKOLCFE, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x69C3980", Offset = "0x69C1F80", VA = "0x1869C3980")]
	[BurstCompile]
	private unsafe static void FODCMHGBJPO([NoAlias] IKJFGLFEJFP* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x69C6150", Offset = "0x69C4750", VA = "0x1869C6150")]
	public void PJAFKONOMOB(Mesh NKIMIKOLCFE, LDJNLICPPEM JFOBPJMAIKI, bool APHCFPDNDMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x69C4EC0", Offset = "0x69C34C0", VA = "0x1869C4EC0")]
	public void LFJDNNPAPPK(JEJBOBIDBPC NKIMIKOLCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69C3E70", Offset = "0x69C2470", VA = "0x1869C3E70")]
	public JEJBOBIDBPC IELCMBBNHEG(Allocator IDMGOAKOEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x69C3A00", Offset = "0x69C2000", VA = "0x1869C3A00")]
	public long GFBBBIOJFNL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x69C3B30", Offset = "0x69C2130", VA = "0x1869C3B30")]
	public static long GFBBBIOJFNL(int NAFLLFOCPHI, int BECBBKCEMMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x69C3040", Offset = "0x69C1640", VA = "0x1869C3040")]
	public static long DMGKNCFBLKL(int NAFLLFOCPHI, int BECBBKCEMMP, LDJNLICPPEM JFOBPJMAIKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x69C30E0", Offset = "0x69C16E0", VA = "0x1869C30E0")]
	public long DMGKNCFBLKL(LDJNLICPPEM JFOBPJMAIKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69C3920", Offset = "0x69C1F20", VA = "0x1869C3920")]
	public void EPPCMOHCPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x69C4400", Offset = "0x69C2A00", VA = "0x1869C4400")]
	public static void KBPCCOAHDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x69C22D0", Offset = "0x69C08D0", VA = "0x1869C22D0")]
	public LDJNLICPPEM CCLMLNIFDCM()
	{
		return default(LDJNLICPPEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x69C2930", Offset = "0x69C0F30", VA = "0x1869C2930")]
	public static (int, int) CDJKBIPPKEH(Mesh NKIMIKOLCFE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x69C1530", Offset = "0x69BFB30", VA = "0x1869C1530")]
	public static int BEJNLEOCOAD(VertexAttributeDescriptor[] JBICPLNDIFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69C51F0", Offset = "0x69C37F0", VA = "0x1869C51F0")]
	public static long NILEHOPHCEL(Mesh NKIMIKOLCFE, int FEBDIALBBDA, int FONLIBCGKLP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public JEJBOBIDBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69C3B90", Offset = "0x69C2190", VA = "0x1869C3B90")]
	[BurstCompile]
	public static int HODMBLCMKPL(float OOALEDCPNBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x69C3CE0", Offset = "0x69C22E0", VA = "0x1869C3CE0")]
	[BurstCompile]
	public static uint HODMBLCMKPL([In] float4 DCMJEJAEEHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x69C3C30", Offset = "0x69C2230", VA = "0x1869C3C30")]
	[BurstCompile]
	public static uint HODMBLCMKPL([In] float3 DCMJEJAEEHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69C1180", Offset = "0x69BF780", VA = "0x1869C1180")]
	[BurstCompile]
	public unsafe static void AGNLJCHAHJN([NoAlias] NIIBFBAPMHJ* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69C3FB0", Offset = "0x69C25B0", VA = "0x1869C3FB0")]
	[BurstCompile]
	public unsafe static void IFNLFCEHOHO([NoAlias] IKJFGLFEJFP* JFKBJHPGAMG, int PKIBPAHFPLK, [In][NoAlias] float3* DELJCEKPCIN, [In][NoAlias] float3* DPOANBHKPCC, [In][NoAlias] float4* JKIIIELNJIB, [In][NoAlias] float2* OPOGKFKMMIA, [In][NoAlias] float4* FOKAPEBHHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class JHEDIHABFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x69C65E0", Offset = "0x69C4BE0", VA = "0x1869C65E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69BD370", Offset = "0x69BB970", VA = "0x1869BD370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x69BD930", Offset = "0x69BBF30", VA = "0x1869BD930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IAJNFKDDCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x69BCBA0", Offset = "0x69BB1A0", VA = "0x1869BCBA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x69BD970", Offset = "0x69BBF70", VA = "0x1869BD970")]
	public DIGJAFDICOI(int HKDBBJIOGFB, int AGAKJAKDDAP, int HOMIIEJNOMC, Allocator IDMGOAKOEDG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x69BDC40", Offset = "0x69BC240", VA = "0x1869BDC40")]
	public DIGJAFDICOI(Mesh NKIMIKOLCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x69BCA90", Offset = "0x69BB090", VA = "0x1869BCA90", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x69BD070", Offset = "0x69BB670", VA = "0x1869BD070")]
	public void LFJDNNPAPPK(DIGJAFDICOI NKIMIKOLCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x69BCBE0", Offset = "0x69BB1E0", VA = "0x1869BCBE0")]
	private void JAKOPEEJMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x69BD3B0", Offset = "0x69BB9B0", VA = "0x1869BD3B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x140A4D0", Offset = "0x1408AD0", VA = "0x18140A4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4790", Offset = "0x8D2D90", VA = "0x1808D4790")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<ENOMGJJDCNC>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x99AFD0", Offset = "0x9995D0", VA = "0x18099AFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DIGJAFDICOI CMNIIPEGNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x69BE250", Offset = "0x69BC850", VA = "0x1869BE250")]
	public GDGOCJIGEDJ(IEnumerable<DIGJAFDICOI> FNHFCNOOFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x69BE1E0", Offset = "0x69BC7E0", VA = "0x1869BE1E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69BBFB0", Offset = "0x69BA5B0", VA = "0x1869BBFB0")]
	public static void CFAPHJJKPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x69BC400", Offset = "0x69BAA00", VA = "0x1869BC400")]
	public static NativeArray<float2> MGEOAJFFDGF(NativeArray<float2> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<float2> HHBFKHNLEFB, int IHMDNFDGMJB)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x69BC0D0", Offset = "0x69BA6D0", VA = "0x1869BC0D0")]
	public static NativeArray<float3> CNCCDPKENLK(NativeArray<float3> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<float3> HHBFKHNLEFB, int IHMDNFDGMJB)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x69BC2F0", Offset = "0x69BA8F0", VA = "0x1869BC2F0")]
	public static NativeArray<float4> FOBMAKLFKBO(NativeArray<float4> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<float4> HHBFKHNLEFB, int IHMDNFDGMJB)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x69BC1E0", Offset = "0x69BA7E0", VA = "0x1869BC1E0")]
	public static NativeArray<int> EAMEJGKDIIF(NativeArray<int> JJLBPOIIEGF, int FMPFCGMFAIG, NativeArray<int> HHBFKHNLEFB, int IHMDNFDGMJB)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2918870", Offset = "0x2916E70", VA = "0x182918870")]
	private static void EAEFAEGHFBE<T>(NativeArray<T> GGEMIJICFPG, int FJDBHJEKJDP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2918A70", Offset = "0x2917070", VA = "0x182918A70")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C6AD0", Offset = "0x69C50D0", VA = "0x1869C6AD0")]
		public OFKHHKFBIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x69C6A90", Offset = "0x69C5090", VA = "0x1869C6A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x866500", Offset = "0x864B00", VA = "0x180866500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer KCNCKOHPLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x865800", Offset = "0x863E00", VA = "0x180865800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LHDBJCGEHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8CE550", Offset = "0x8CCB50", VA = "0x1808CE550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MONPLMKLHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xC3DD10", Offset = "0xC3C310", VA = "0x180C3DD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GHEDKGOGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x69CD800", Offset = "0x69CBE00", VA = "0x1869CD800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<POHKOOHALBH> BIECLPJFEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void IHKOHAPGNJE(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x69CFFF0", Offset = "0x69CE5F0", VA = "0x1869CFFF0")]
	public void PLAJIDGPHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x69CC970", Offset = "0x69CAF70", VA = "0x1869CC970")]
	private void IKOENGPNLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x69D0490", Offset = "0x69CEA90", VA = "0x1869D0490")]
	public ONKFDHMAIIN(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x69CE590", Offset = "0x69CCB90", VA = "0x1869CE590")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x69C6CA0", Offset = "0x69C52A0", VA = "0x1869C6CA0")]
	public void BJHOKGKGHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x69CD820", Offset = "0x69CBE20", VA = "0x1869CD820")]
	private void NANJHIABDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x69C7ED0", Offset = "0x69C64D0", VA = "0x1869C7ED0")]
	public void DANDGJIFFLG(POHKOOHALBH AJBLINEBFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x69CF200", Offset = "0x69CD800", VA = "0x1869CF200")]
	public bool OJDLIBEPFNE(POHKOOHALBH AJBLINEBFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x69D0000", Offset = "0x69CE600", VA = "0x1869D0000")]
	public bool PMELAKIMKGE(POHKOOHALBH AJBLINEBFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x69CCDB0", Offset = "0x69CB3B0", VA = "0x1869CCDB0", Slot = "4")]
	public virtual void JAHPHEMLLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x69CC760", Offset = "0x69CAD60", VA = "0x1869CC760")]
	public void IEPKGLPHCEA(Transform DAOJLEMLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x69CFF10", Offset = "0x69CE510", VA = "0x1869CFF10")]
	private long PKMIMDGCFFH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x69C6B20", Offset = "0x69C5120", VA = "0x1869C6B20")]
	private long BFLHIAMDKKN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69CA180", Offset = "0x69C8780", VA = "0x1869CA180")]
	public bool HEEDODHLALF(Transform DAOJLEMLDIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x69CB1C0", Offset = "0x69C97C0", VA = "0x1869CB1C0")]
	public bool IAKLEKPCPEI(bool JMPKKIBNOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x69CC5E0", Offset = "0x69CABE0", VA = "0x1869CC5E0")]
	public void IDOBAKGJKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x69C8E20", Offset = "0x69C7420", VA = "0x1869C8E20")]
	public bool FHFKMBIPFPE(float4x4 HEHKKIOOIIG, BatchedMeshRenderer ANKNKBHMPGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x69CEF90", Offset = "0x69CD590", VA = "0x1869CEF90")]
	public void OHDNEEBMKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x69C80A0", Offset = "0x69C66A0", VA = "0x1869C80A0")]
	public bool DFIDLCBKEAE(bool JMPKKIBNOPE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x69CD260", Offset = "0x69CB860", VA = "0x1869CD260")]
	public void KHNPNKDHDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x69C8370", Offset = "0x69C6970", VA = "0x1869C8370")]
	public void DNMNEOINKHK(JEJBOBIDBPC NKIMIKOLCFE, int ENFPFMIMCHI, int LHKAOEMGPFE, float NIOHMEJKMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x69D0060", Offset = "0x69CE660", VA = "0x1869D0060")]
	public void POGGOBJMMOL(ECKOAIDMBHO FHENONGMFDP, int ENFPFMIMCHI, int LHKAOEMGPFE, float NIOHMEJKMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x69CA110", Offset = "0x69C8710", VA = "0x1869CA110")]
	public (long, long, long) GFBBBIOJFNL()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x9CB870", Offset = "0x9C9E70", VA = "0x1809CB870")]
	public long CKMMJFMAOGE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x69CC440", Offset = "0x69CAA40", VA = "0x1869CC440")]
	private void ICPBBMNBFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x69CCE90", Offset = "0x69CB490", VA = "0x1869CCE90")]
	public (long, long) JPPGOHFBPOA(float CCNLHLMBGCC, float4x4 HEHKKIOOIIG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	public void ELCOFDBINIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x69CF2A0", Offset = "0x69CD8A0", VA = "0x1869CF2A0")]
	internal void OJIKGGHDJBA(MJAMOLEIMMK LCPPMNDMONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x69CDAB0", Offset = "0x69CC0B0", VA = "0x1869CDAB0")]
	private (float, float, float) NHNKPPGDPDF(float BLLFKDCEIDJ, float4x4 HEHKKIOOIIG)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x69CD270", Offset = "0x69CB870", VA = "0x1869CD270")]
	private (int, int) KLGAAPHHOND(float MJCFGOHHEFE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69C6D60", Offset = "0x69C5360", VA = "0x1869C6D60")]
	public void CPBCFDCKPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x69CCE60", Offset = "0x69CB460", VA = "0x1869CCE60")]
	private void JKLKOMANEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x69CD620", Offset = "0x69CBC20", VA = "0x1869CD620")]
	private void KNGKCMBMACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x69C83A0", Offset = "0x69C69A0", VA = "0x1869C83A0")]
	public long EFGLDOBDHOK(long NMOCEJNFPII, int MGONNNALIJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x69CE6B0", Offset = "0x69CCCB0", VA = "0x1869CE6B0")]
	private void OGJDDNMNAPJ(JEJBOBIDBPC PIEKIAEPNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x69C8B80", Offset = "0x69C7180", VA = "0x1869C8B80")]
	private void FFPCCEBMPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x69CF3C0", Offset = "0x69CD9C0", VA = "0x1869CF3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D7EB0", Offset = "0x69D64B0", VA = "0x1869D7EB0")]
		public void BOIAAEDKCNB(int HKDBBJIOGFB, int AGAKJAKDDAP, Allocator IDMGOAKOEDG, bool DHLODGNGFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69D8090", Offset = "0x69D6690", VA = "0x1869D8090")]
		public static KENOLFJBHFE NICDEOAIIGB(JEJBOBIDBPC LPPNOBMEEDD)
		{
			return default(KENOLFJBHFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x69D82E0", Offset = "0x69D68E0", VA = "0x1869D82E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	[BurstDiscard]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	[BurstDiscard]
	private static void IHKOHAPGNJE(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	[BurstDiscard]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x69C09E0", Offset = "0x69BEFE0", VA = "0x1869C09E0")]
	public HNGDEFMNKBD([In] List<ONKFDHMAIIN.OFKHHKFBIHN> JCCMEPBMPDE, [In] JEJBOBIDBPC GMLGALJIDLC, [In] ONKFDHMAIIN AACBMICJDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x69BEAE0", Offset = "0x69BD0E0", VA = "0x1869BEAE0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x69BFF50", Offset = "0x69BE550", VA = "0x1869BFF50")]
	public void IABFMGFJMNJ(List<ONKFDHMAIIN.OFKHHKFBIHN> KFGFOILILIN, [In] ONKFDHMAIIN AACBMICJDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69BE9C0", Offset = "0x69BCFC0", VA = "0x1869BE9C0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool DNPIKMBBIBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x69BEB30", Offset = "0x69BD130", VA = "0x1869BEB30")]
	private ECKOAIDMBHO FADAEHBACLH(int MEJKDFIOMHG, Allocator IDMGOAKOEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x69BEC00", Offset = "0x69BD200", VA = "0x1869BEC00")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void GPOELGLGPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x69C05D0", Offset = "0x69BEBD0", VA = "0x1869C05D0")]
	[IgnoreWarning(1371)]
	private CCODEHBPJNL KHLJPIANJFI([In] CCODEHBPJNL LGADAIFEHPJ, int KDECKBDBDOE, [In] NativeArray<int> DGLAKPCPOIA, [In] NativeArray<bool> FNEHMGAAEKB, NativeArray<int> MACPCALBJAN)
	{
		return default(CCODEHBPJNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x69BE9E0", Offset = "0x69BCFE0", VA = "0x1869BE9E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int OBKCFNDCKKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x69D6F00", Offset = "0x69D5500", VA = "0x1869D6F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		private static void FKBMKAFPBLJ(bool JJJOOLPIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x69D38B0", Offset = "0x69D1EB0", VA = "0x1869D38B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x69D1AF0", Offset = "0x69D00F0", VA = "0x1869D1AF0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x69D15E0", Offset = "0x69CFBE0", VA = "0x1869D15E0")]
		public ONKFDHMAIIN AddToBatchedMesh(POHKOOHALBH JOMCODKFHCC, Material EGLABJPOFKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x69D5FF0", Offset = "0x69D45F0", VA = "0x1869D5FF0")]
		public void RemoveFromBatchedMesh(POHKOOHALBH NKIMIKOLCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x69D19C0", Offset = "0x69CFFC0", VA = "0x1869D19C0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x69D67E0", Offset = "0x69D4DE0", VA = "0x1869D67E0")]
		public void SetMaterialProperty(int JEKFLJBJJDA, Color MKAJENPGJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x69D6390", Offset = "0x69D4990", VA = "0x1869D6390")]
		public void SetMaterialProperty(int JEKFLJBJJDA, float CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x69D65B0", Offset = "0x69D4BB0", VA = "0x1869D65B0")]
		public void SetMaterialProperty(int JEKFLJBJJDA, Vector4 AAFAHPMPGPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x69D6130", Offset = "0x69D4730", VA = "0x1869D6130")]
		public void SetMaterialProperty(int JEKFLJBJJDA, Matrix4x4 PAMNOGPCJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x69D2280", Offset = "0x69D0880", VA = "0x1869D2280")]
		private void GKBGOMJMIII(Renderer APJGPLFHDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x69D21E0", Offset = "0x69D07E0", VA = "0x1869D21E0")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x69D21D0", Offset = "0x69D07D0", VA = "0x1869D21D0")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x69D1CB0", Offset = "0x69D02B0", VA = "0x1869D1CB0")]
		private void FCOOAOJPPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x69D2DB0", Offset = "0x69D13B0", VA = "0x1869D2DB0")]
		private ONKFDHMAIIN KNEFIIFEFBD(POHKOOHALBH NKIMIKOLCFE, Material EGLABJPOFKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x69D16E0", Offset = "0x69CFCE0", VA = "0x1869D16E0")]
		private ONKFDHMAIIN BKFAFPNFGLD(Material EGLABJPOFKK, int HLMDBCMIEFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x69D34B0", Offset = "0x69D1AB0", VA = "0x1869D34B0")]
		private ONKFDHMAIIN OMHDOPPACAF(Material EGLABJPOFKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x18C1D60", Offset = "0x18C0360", VA = "0x1818C1D60")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x69D2FD0", Offset = "0x69D15D0", VA = "0x1869D2FD0")]
		public void MarkDirty(POHKOOHALBH NKIMIKOLCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x69D3130", Offset = "0x69D1730", VA = "0x1869D3130")]
		public (long, long) MemorySizeInBytesForChosenDetail(float CCNLHLMBGCC)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x69D5080", Offset = "0x69D3680", VA = "0x1869D5080")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x69D2870", Offset = "0x69D0E70", VA = "0x1869D2870")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x69D3BA0", Offset = "0x69D21A0", VA = "0x1869D3BA0")]
		public void RebatchOptimally(int DDCOJJJDPPD, int ADGDCFFFGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x69D6C90", Offset = "0x69D5290", VA = "0x1869D6C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x92FCB0", Offset = "0x92E2B0", VA = "0x18092FCB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x69D7D40", Offset = "0x69D6340", VA = "0x1869D7D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA7D830", Offset = "0xA7BE30", VA = "0x180A7D830")]
		[DebuggerHidden]
		public EPIJPNNLNKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D90", Offset = "0x69D6390", VA = "0x1869D7D90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x69D6FA0", Offset = "0x69D55A0", VA = "0x1869D6FA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x69D7BF0", Offset = "0x69D61F0", VA = "0x1869D7BF0")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x69D6F50", Offset = "0x69D5550", VA = "0x1869D6F50")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x69D7CF0", Offset = "0x69D62F0", VA = "0x1869D7CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x69D7C40", Offset = "0x69D6240", VA = "0x1869D7C40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x69D7C40", Offset = "0x69D6240", VA = "0x1869D7C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x69DB610", Offset = "0x69D9C10", VA = "0x1869DB610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void IHKOHAPGNJE(bool JJJOOLPIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void FKBMKAFPBLJ(bool JJJOOLPIIIL, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x69DB950", Offset = "0x69D9F50", VA = "0x1869DB950")]
	public static void IPJLDPAJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x69DB3A0", Offset = "0x69D99A0", VA = "0x1869DB3A0")]
	public static void FMHFNHCEAMC(BatchedMeshRenderer BADKLJEBFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x69DBF80", Offset = "0x69DA580", VA = "0x1869DBF80")]
	public static void MMAJHBMKOJB(BatchedMeshRenderer BADKLJEBFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x69D8810", Offset = "0x69D6E10", VA = "0x1869D8810")]
	private static (long, long, long) EDKFFOANDCM(long AHGIIKDFBAC)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x69D8CC0", Offset = "0x69D72C0", VA = "0x1869D8CC0")]
	public static void FHFKMBIPFPE(long AHGIIKDFBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x69D8920", Offset = "0x69D6F20", VA = "0x1869D8920")]
	public static long EFGLDOBDHOK(long NMOCEJNFPII)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x69D8700", Offset = "0x69D6D00", VA = "0x1869D8700")]
	public static void CCALKLMGPBM(ONKFDHMAIIN OOPJBFHMCHB, BatchedMeshRenderer NMAAGALGDJH, long MHGAPOLJPGF, float NPMDLCEJBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x69DBE80", Offset = "0x69DA480", VA = "0x1869DBE80")]
	public static void MFIHFJLECHO(ONKFDHMAIIN OOPJBFHMCHB, BatchedMeshRenderer NMAAGALGDJH, long MHGAPOLJPGF, float CMMGEOJCFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x69DC030", Offset = "0x69DA630", VA = "0x1869DC030")]
	public static void NGALAGILODA(ONKFDHMAIIN OOPJBFHMCHB, BatchedMeshRenderer NMAAGALGDJH, long MHGAPOLJPGF, float CMMGEOJCFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69DBCD0", Offset = "0x69DA2D0", VA = "0x1869DBCD0")]
	public static void LADFCDJDFHE(ONKFDHMAIIN OOPJBFHMCHB, BatchedMeshRenderer NMAAGALGDJH, long MHGAPOLJPGF, float NPMDLCEJBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x69D83A0", Offset = "0x69D69A0", VA = "0x1869D83A0")]
	public static float APNFPIMBECJ(long IHPLCCDMJBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x69DBB00", Offset = "0x69DA100", VA = "0x1869DBB00")]
	public static (long, long) JPPGOHFBPOA(float CCNLHLMBGCC)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x69DC140", Offset = "0x69DA740", VA = "0x1869DC140")]
	[IteratorStateMachine(typeof(EPIJPNNLNKH))]
	public static IEnumerable<bool> PGEBPGDODKD(long CHOLJPDPFEH, bool IJHDKMHNAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x69DB7E0", Offset = "0x69D9DE0", VA = "0x1869DB7E0")]
	public static void HJALPJJNKLK(long CHOLJPDPFEH, bool IJHDKMHNAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x69DB6A0", Offset = "0x69D9CA0", VA = "0x1869DB6A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x41D4170", Offset = "0x41D2770", VA = "0x1841D4170")]
	public KDCLDKMLCBE(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x41D3FB0", Offset = "0x41D25B0", VA = "0x1841D3FB0")]
	public void DANDGJIFFLG(KeyType BHEIPBKEDLG, POHKOOHALBH AJBLINEBFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x41D3BF0", Offset = "0x41D21F0", VA = "0x1841D3BF0")]
	public bool AADJGEKMDGI(KeyType BHEIPBKEDLG, POHKOOHALBH KDANDBLPKIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x41D3DF0", Offset = "0x41D23F0", VA = "0x1841D3DF0")]
	public void AOAMDEDFDFA(KeyType BHEIPBKEDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x41D4020", Offset = "0x41D2620", VA = "0x1841D4020", Slot = "4")]
	public override void JAHPHEMLLBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x69DC540", Offset = "0x69DAB40", VA = "0x1869DC540")]
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
