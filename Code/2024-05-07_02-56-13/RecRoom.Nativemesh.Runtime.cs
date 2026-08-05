using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AJJINNLHJBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int HJGMGEHKLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 JNMPOPHLKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion AFMMEDKKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 HPJLAKEANCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int OHGAACDKLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int MKJPAJDIBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int APDNHOFOCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float GFKKLLNGKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 OGNPHEFGJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool FNPMJFNDCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public POOEFICLNNK CGEKNGNLALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 PELNHCJAKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float HFGEOFBILKF;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GKFKJFIDCKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static KDKOIMIEKCD NLOIIDFEFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<AJJINNLHJBJ> CBGHFIFDIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<LEKDGNCNAOB> JDPLFMBLNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<JBHKEMFLPOK> CAIODKIEEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<LBGPNLGBJGE> BIHDCNOJAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<LEKDGNCNAOB> OOJONLOGICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<NNNFMEMPIHE> DPKPOPKDNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<LBGPNLGBJGE>> ALDKKLBFHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<KPBGIKAEPIJ> PHDLGLGGEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> NNPLMJGBKOE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ALHCGDDKPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC78E10", Offset = "0xC78010", VA = "0x180C78E10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC78520", Offset = "0xC77720", VA = "0x180C78520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EPECIFGNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC78E20", Offset = "0xC78020", VA = "0x180C78E20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC767A0", VA = "0x180C775A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x625C870", Offset = "0x625BA70", VA = "0x18625C870")]
	public GKFKJFIDCKD(int LHGDLDDEAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x625B280", Offset = "0x625A480", VA = "0x18625B280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x625B690", Offset = "0x625A890", VA = "0x18625B690")]
	public void OAIFEIHHKBN(JobHandle FMIOCBOJMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x625B060", Offset = "0x625A260", VA = "0x18625B060")]
	public void CIPGNLAPPOH(AJJINNLHJBJ FODGEDCJIDC, KPBGIKAEPIJ GMAOHGFGHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x625B550", Offset = "0x625A750", VA = "0x18625B550")]
	public void IMKLFONANAG(JBHKEMFLPOK FODGEDCJIDC, NativeArray<LBGPNLGBJGE> ONDOPFCKJHD, int ILFCMJPICCH, int MANLMKKLAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x625B860", Offset = "0x625AA60", VA = "0x18625B860")]
	public JobHandle OKLBFPOPMNG(HLHCPFCIGJP CGINOJEINMH, BOONEENEDJA OCECGAJFAOK, float3 KKDDMKFFDOO, quaternion KCJNEOCFNMF, float MFGBNBBEKII, bool NPMPBGFIGFH, int DIKHLMOGACB = 0, int KAIBCBPOEKC = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x625AD20", Offset = "0x6259F20", VA = "0x18625AD20")]
	public static JobHandle CGMDIEPBPMN(CGBLBJAPNNG CJHBLHJPKJF, HLHCPFCIGJP CGINOJEINMH, AJJINNLHJBJ FODGEDCJIDC, JobHandle FMIOCBOJMFC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x625B2A0", Offset = "0x625A4A0", VA = "0x18625B2A0")]
	public static JobHandle GHCEKEHNGFM(BBNPBHPECAI CJHBLHJPKJF, HLHCPFCIGJP CGINOJEINMH, JBHKEMFLPOK FODGEDCJIDC, NativeArray<LBGPNLGBJGE> ONDOPFCKJHD, int ILFCMJPICCH, int MANLMKKLAMO, JobHandle FMIOCBOJMFC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class EEHGDDAFAPA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CHIMIMADPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half MPGFKAFOEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort BCILNGHOODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte FMLHMKLIOHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public unsafe delegate void HLPLBAJIIKD(float3* MKFCMJAJFIG, [In] ushort* ANFDBINHPEK, int ILFCMJPICCH, [In] float3 EPCDBOKNGFN, [In] float3 KHGNCJCEAAF);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class EODJMEIEIKF
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6250480", Offset = "0x624F680", VA = "0x186250480")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6250130", Offset = "0x624F330", VA = "0x186250130")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62505A0", Offset = "0x624F7A0", VA = "0x1862505A0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6250280", Offset = "0x624F480", VA = "0x186250280")]
		public unsafe static void DPCEAIGMMMP(float3* MKFCMJAJFIG, [In] ushort* ANFDBINHPEK, int ILFCMJPICCH, [In] float3 EPCDBOKNGFN, [In] float3 KHGNCJCEAAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public unsafe delegate void FALAELOPKPL(ushort* MKFCMJAJFIG, [Out] float3 OJKFLHAFPLF, [Out] float3 KHGNCJCEAAF, [In] float3* ANFDBINHPEK, int CDEFNHHBCHK, int CIBFDIDKKEM);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class AGOBOHACPDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6248EA0", Offset = "0x62480A0", VA = "0x186248EA0")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6248B40", Offset = "0x6247D40", VA = "0x186248B40")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6248FC0", Offset = "0x62481C0", VA = "0x186248FC0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6248C90", Offset = "0x6247E90", VA = "0x186248C90")]
		public unsafe static void DPCEAIGMMMP(ushort* MKFCMJAJFIG, [Out] float3 OJKFLHAFPLF, [Out] float3 KHGNCJCEAAF, [In] float3* ANFDBINHPEK, int CDEFNHHBCHK, int CIBFDIDKKEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public unsafe delegate void FGAJFEMAGCG(ushort* PGMJAPAOOOD, [In] float3* DEHDBCNCFEP, int CIBFDIDKKEM);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal static class GDJOKNBIKGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6259340", Offset = "0x6258540", VA = "0x186259340")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6259010", Offset = "0x6258210", VA = "0x186259010")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6259460", Offset = "0x6258660", VA = "0x186259460")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6259160", Offset = "0x6258360", VA = "0x186259160")]
		public unsafe static void DPCEAIGMMMP(ushort* PGMJAPAOOOD, [In] float3* DEHDBCNCFEP, int CIBFDIDKKEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public unsafe delegate void HJKPFDILPFI(float3* CMLBHJMHNDL, [In] ushort* DEHDBCNCFEP, int ILFCMJPICCH);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class HBILILJEFLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x625D400", Offset = "0x625C600", VA = "0x18625D400")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x625D070", Offset = "0x625C270", VA = "0x18625D070")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x625D520", Offset = "0x625C720", VA = "0x18625D520")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x625D1C0", Offset = "0x625C3C0", VA = "0x18625D1C0")]
		public unsafe static void DPCEAIGMMMP(float3* CMLBHJMHNDL, [In] ushort* DEHDBCNCFEP, int ILFCMJPICCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public unsafe delegate void MCJALNHEPIC(ushort* NBDLEEJMFBN, [Out] float2 GLGMGCHEELB, [Out] float2 MNOPOJJJBED, [In] float2* AJKIPJGDBFL, int CDEFNHHBCHK, int CIBFDIDKKEM);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class HPFOEBCDCGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x625EEC0", Offset = "0x625E0C0", VA = "0x18625EEC0")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x625EB60", Offset = "0x625DD60", VA = "0x18625EB60")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x625EFE0", Offset = "0x625E1E0", VA = "0x18625EFE0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x625ECB0", Offset = "0x625DEB0", VA = "0x18625ECB0")]
		public unsafe static void DPCEAIGMMMP(ushort* NBDLEEJMFBN, [Out] float2 GLGMGCHEELB, [Out] float2 MNOPOJJJBED, [In] float2* AJKIPJGDBFL, int CDEFNHHBCHK, int CIBFDIDKKEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void BLOMAELJJGJ([Out] float2 FOLDICALLGP, ushort EOJLBCNMBNM, [In] float2 GCMOIEEEOFK, [In] float2 MNOPOJJJBED);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class MJOAFFDKILE
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6263580", Offset = "0x6262780", VA = "0x186263580")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6263200", Offset = "0x6262400", VA = "0x186263200")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62636A0", Offset = "0x62628A0", VA = "0x1862636A0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6263350", Offset = "0x6262550", VA = "0x186263350")]
		public static void DPCEAIGMMMP([Out] float2 FOLDICALLGP, ushort EOJLBCNMBNM, [In] float2 GCMOIEEEOFK, [In] float2 MNOPOJJJBED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public unsafe delegate void EJOMMDGEJBF(float2* NBDLEEJMFBN, ushort* AJKIPJGDBFL, int ILFCMJPICCH, [In] float2 GCMOIEEEOFK, [In] float2 MNOPOJJJBED);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal static class AMECADLJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6249430", Offset = "0x6248630", VA = "0x186249430")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6249060", Offset = "0x6248260", VA = "0x186249060")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6249550", Offset = "0x6248750", VA = "0x186249550")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62491B0", Offset = "0x62483B0", VA = "0x1862491B0")]
		public unsafe static void DPCEAIGMMMP(float2* NBDLEEJMFBN, ushort* AJKIPJGDBFL, int ILFCMJPICCH, [In] float2 GCMOIEEEOFK, [In] float2 MNOPOJJJBED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public unsafe delegate void APBKNHFHFEI(ushort* LPPLAPPKPFB, [In] float4* KGHDAKJGKBB, int CDEFNHHBCHK, int CIBFDIDKKEM);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal static class JEPCLACPHCE
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x625F410", Offset = "0x625E610", VA = "0x18625F410")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x625F080", Offset = "0x625E280", VA = "0x18625F080")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x625F530", Offset = "0x625E730", VA = "0x18625F530")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x625F1D0", Offset = "0x625E3D0", VA = "0x18625F1D0")]
		public unsafe static void DPCEAIGMMMP(ushort* LPPLAPPKPFB, [In] float4* KGHDAKJGKBB, int CDEFNHHBCHK, int CIBFDIDKKEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate ushort OOINMBMBODO([In] float4 ICKHHPAKKOF);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal static class FFMAAAIMIKN
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6250A90", Offset = "0x624FC90", VA = "0x186250A90")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6250740", Offset = "0x624F940", VA = "0x186250740")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6250BB0", Offset = "0x624FDB0", VA = "0x186250BB0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6250890", Offset = "0x624FA90", VA = "0x186250890")]
		public static ushort DPCEAIGMMMP([In] float4 ICKHHPAKKOF)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public unsafe delegate void OOPCIIBFLFA(float4* LPPLAPPKPFB, [In] ushort* ENLHJGIFGBD, int ILFCMJPICCH);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal static class DJBBIIDIPPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x624B200", Offset = "0x624A400", VA = "0x18624B200")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x624AE70", Offset = "0x624A070", VA = "0x18624AE70")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x624B320", Offset = "0x624A520", VA = "0x18624B320")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x624AFC0", Offset = "0x624A1C0", VA = "0x18624AFC0")]
		public unsafe static void DPCEAIGMMMP(float4* LPPLAPPKPFB, [In] ushort* ENLHJGIFGBD, int ILFCMJPICCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void NCPIOKDDJNP([Out] float4 HCIDHCBMOPD, ushort EOJLBCNMBNM);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class KIFOCKGHJAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62617A0", Offset = "0x62609A0", VA = "0x1862617A0")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62613E0", Offset = "0x62605E0", VA = "0x1862613E0")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x62618C0", Offset = "0x6260AC0", VA = "0x1862618C0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6261530", Offset = "0x6260730", VA = "0x186261530")]
		public static void DPCEAIGMMMP([Out] float4 HCIDHCBMOPD, ushort EOJLBCNMBNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public unsafe delegate void MJAGMLHFEOB(float4* OFNDHBCFIAM, byte* LLGKFHNPKJL, [Out] int KEJEHLAGOOM, [Out] int MPCFKBNKPEL, float4* BENDIBICEKH, int CDEFNHHBCHK, int CIBFDIDKKEM);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class KNMKMNBBHBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6261CC0", Offset = "0x6260EC0", VA = "0x186261CC0")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6261960", Offset = "0x6260B60", VA = "0x186261960")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6261DE0", Offset = "0x6260FE0", VA = "0x186261DE0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6261AB0", Offset = "0x6260CB0", VA = "0x186261AB0")]
		public unsafe static void DPCEAIGMMMP(float4* OFNDHBCFIAM, byte* LLGKFHNPKJL, [Out] int KEJEHLAGOOM, [Out] int MPCFKBNKPEL, float4* BENDIBICEKH, int CDEFNHHBCHK, int CIBFDIDKKEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public unsafe delegate void MKONEGKCMPE(float4* JGIDNGGDEAD, [In] CHIMIMADPFN* PCLFDNONBON, [In] byte* IILNJIPCMMF, int ILFCMJPICCH);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class GMBGEIIKKCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x625CEB0", Offset = "0x625C0B0", VA = "0x18625CEB0")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x625CA80", Offset = "0x625BC80", VA = "0x18625CA80")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x625CFD0", Offset = "0x625C1D0", VA = "0x18625CFD0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x625CBD0", Offset = "0x625BDD0", VA = "0x18625CBD0")]
		public unsafe static void DPCEAIGMMMP(float4* JGIDNGGDEAD, [In] CHIMIMADPFN* PCLFDNONBON, [In] byte* IILNJIPCMMF, int ILFCMJPICCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public unsafe delegate int MCMNJAEDFLC(byte* ONMCMEDHIOK, [In] int* OIAEPCPPDLN, int FMDFOHFCBKI);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class CJGOJAKBKNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x624ACB0", Offset = "0x6249EB0", VA = "0x18624ACB0")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x624A8E0", Offset = "0x6249AE0", VA = "0x18624A8E0")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x624ADD0", Offset = "0x6249FD0", VA = "0x18624ADD0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x624AA30", Offset = "0x6249C30", VA = "0x18624AA30")]
		public unsafe static int DPCEAIGMMMP(byte* ONMCMEDHIOK, [In] int* OIAEPCPPDLN, int FMDFOHFCBKI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public unsafe delegate void HBOBCNJAPLK(int* NJLIAGNNPFJ, [In] byte* GMDPKNNOJFC, int MANLMKKLAMO);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class POKJNMACCBP
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6266610", Offset = "0x6265810", VA = "0x186266610")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6266280", Offset = "0x6265480", VA = "0x186266280")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6266730", Offset = "0x6265930", VA = "0x186266730")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x62663D0", Offset = "0x62655D0", VA = "0x1862663D0")]
		public unsafe static void DPCEAIGMMMP(int* NJLIAGNNPFJ, [In] byte* GMDPKNNOJFC, int MANLMKKLAMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void CKHAFLKADPK([Out] float3 FOLDICALLGP, ushort EOJLBCNMBNM);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class BNOOPGMPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6249EB0", Offset = "0x62490B0", VA = "0x186249EB0")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6249A10", Offset = "0x6248C10", VA = "0x186249A10")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6249FD0", Offset = "0x62491D0", VA = "0x186249FD0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6249B60", Offset = "0x6248D60", VA = "0x186249B60")]
		public static void DPCEAIGMMMP([Out] float3 FOLDICALLGP, ushort EOJLBCNMBNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate ushort MEFAMLOOGPG([In] float3 ICKHHPAKKOF);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class CBIMNPKPDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr PPNMCFGBNLA;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr NKGHDOPEPFD;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x624A590", Offset = "0x6249790", VA = "0x18624A590")]
		[BurstDiscard]
		private static void KGLNEMOBJNF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x624A280", Offset = "0x6249480", VA = "0x18624A280")]
		private static IntPtr DEONBJCOLFL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x624A6B0", Offset = "0x62498B0", VA = "0x18624A6B0")]
		public static void OJCPKMDCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x624A3D0", Offset = "0x62495D0", VA = "0x18624A3D0")]
		public static ushort DPCEAIGMMMP([In] float3 ICKHHPAKKOF)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int ILFCMJPICCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int MANLMKKLAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> NMBBHODJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> CNBJMFKBOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> FLEAMMBNHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> BACMMCOJBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<CHIMIMADPFN> IKNJAEJEMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> DNONIJFPGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> GKAIENLANNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 EPCDBOKNGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 KHGNCJCEAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 GCMOIEEEOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 MNOPOJJJBED;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long PJBAJCBNJDM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long NKLPEBHFFMO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float OEEIKOCFPAB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool IGHLNNONFEN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool POOBEFCHBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x624DFC0", Offset = "0x624D1C0", VA = "0x18624DFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x624F570", Offset = "0x624E770", VA = "0x18624F570")]
	public void OAIFEIHHKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x624E820", Offset = "0x624DA20", VA = "0x18624E820")]
	public static EEHGDDAFAPA LAFNMEJJDLL(Allocator ILEAEEDKNCF, HLHCPFCIGJP AHKFEIHENGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x624E350", Offset = "0x624D550", VA = "0x18624E350")]
	public static EEHGDDAFAPA LAFNMEJJDLL(Allocator ILEAEEDKNCF, NativeArray<float3> ANFDBINHPEK, NativeArray<float3> DEHDBCNCFEP, NativeArray<float2> AJKIPJGDBFL, NativeArray<float4> BENDIBICEKH, bool ACMCLEPFABD, NativeArray<float4> ENLHJGIFGBD, NativeArray<int> OIAEPCPPDLN, int ILFCMJPICCH, int NFMKCKIAPDE, int MANLMKKLAMO, int CDEFNHHBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x624F8D0", Offset = "0x624EAD0", VA = "0x18624F8D0")]
	public HLHCPFCIGJP PHDGEIBOAHL(Allocator ILEAEEDKNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x624F390", Offset = "0x624E590", VA = "0x18624F390")]
	public void NLLDPHDIKIB(Mesh PGNOHIOKGKO, bool IPCBCHHOHLO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x624D940", Offset = "0x624CB40", VA = "0x18624D940")]
	public long DOGHDLIBPME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x624D240", Offset = "0x624C440", VA = "0x18624D240")]
	public static long DFNLEPHDPDC(int MEBCFIPKCBO, int DKMDOJGDCLL, bool HDELDIJCAFE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x624D290", Offset = "0x624C490", VA = "0x18624D290")]
	public long DFNLEPHDPDC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x624DD40", Offset = "0x624CF40", VA = "0x18624DD40")]
	private void GIOPEGMNBGI(int BKCCKPKDJJL, int CIBFDIDKKEM, Allocator ILEAEEDKNCF, bool NMBMKECLMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x624FF30", Offset = "0x624F130", VA = "0x18624FF30")]
	private void PJCIJGMABJP(NativeArray<float3> MKFCMJAJFIG, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x624FEB0", Offset = "0x624F0B0", VA = "0x18624FEB0")]
	[BurstCompile]
	private unsafe static void PJCIJGMABJP(float3* MKFCMJAJFIG, [In] ushort* ANFDBINHPEK, int ILFCMJPICCH, [In] float3 EPCDBOKNGFN, [In] float3 KHGNCJCEAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x624DB10", Offset = "0x624CD10", VA = "0x18624DB10")]
	private void FADAENDHFFF(NativeArray<float3> ANFDBINHPEK, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x624DC10", Offset = "0x624CE10", VA = "0x18624DC10")]
	[BurstCompile]
	private unsafe static void FADAENDHFFF(ushort* MKFCMJAJFIG, [Out] float3 OJKFLHAFPLF, [Out] float3 KHGNCJCEAAF, [In] float3* ANFDBINHPEK, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x624EC70", Offset = "0x624DE70", VA = "0x18624EC70")]
	private void LCDPHCLHDBH(NativeArray<float3> DEHDBCNCFEP, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x624EA60", Offset = "0x624DC60", VA = "0x18624EA60")]
	[BurstCompile]
	private unsafe static void LCDPHCLHDBH(ushort* PGMJAPAOOOD, [In] float3* DEHDBCNCFEP, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x624F0C0", Offset = "0x624E2C0", VA = "0x18624F0C0")]
	private void MEGKHMIDKCE(NativeArray<float3> CMLBHJMHNDL, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x624F050", Offset = "0x624E250", VA = "0x18624F050")]
	[BurstCompile]
	private unsafe static void MEGKHMIDKCE(float3* CMLBHJMHNDL, [In] ushort* DEHDBCNCFEP, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x624CC20", Offset = "0x624BE20", VA = "0x18624CC20")]
	private void DADDMIKJFCA(NativeArray<float2> AJKIPJGDBFL, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x624C9E0", Offset = "0x624BBE0", VA = "0x18624C9E0")]
	[BurstCompile]
	private unsafe static void DADDMIKJFCA(ushort* NBDLEEJMFBN, [Out] float2 GLGMGCHEELB, [Out] float2 MNOPOJJJBED, [In] float2* AJKIPJGDBFL, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x624D1C0", Offset = "0x624C3C0", VA = "0x18624D1C0")]
	[BurstCompile]
	private static void DDLNFKPLABH([Out] float2 FOLDICALLGP, ushort EOJLBCNMBNM, [In] float2 GCMOIEEEOFK, [In] float2 MNOPOJJJBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x624F6F0", Offset = "0x624E8F0", VA = "0x18624F6F0")]
	private void OOOALHLIIBN(NativeArray<float2> NBDLEEJMFBN, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x624F670", Offset = "0x624E870", VA = "0x18624F670")]
	[BurstCompile]
	private unsafe static void OOOALHLIIBN(float2* NBDLEEJMFBN, ushort* AJKIPJGDBFL, int ILFCMJPICCH, [In] float2 GCMOIEEEOFK, [In] float2 MNOPOJJJBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x624DED0", Offset = "0x624D0D0", VA = "0x18624DED0")]
	private void HADPFJBPMAA(NativeArray<float4> ENLHJGIFGBD, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x624DE50", Offset = "0x624D050", VA = "0x18624DE50")]
	[BurstCompile]
	private unsafe static void HADPFJBPMAA(ushort* LPPLAPPKPFB, [In] float4* KGHDAKJGKBB, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x624C8B0", Offset = "0x624BAB0", VA = "0x18624C8B0")]
	[BurstCompile]
	private static ushort BNBEMLKEPFE([In] float4 ICKHHPAKKOF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x624D9D0", Offset = "0x624CBD0", VA = "0x18624D9D0")]
	private void EFCKNJGGEMJ(NativeArray<float4> LPPLAPPKPFB, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x624DAA0", Offset = "0x624CCA0", VA = "0x18624DAA0")]
	[BurstCompile]
	private unsafe static void EFCKNJGGEMJ(float4* LPPLAPPKPFB, [In] ushort* ENLHJGIFGBD, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x624F510", Offset = "0x624E710", VA = "0x18624F510")]
	[BurstCompile]
	private static void OACKOHDJJCG([Out] float4 HCIDHCBMOPD, ushort EOJLBCNMBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x624D560", Offset = "0x624C760", VA = "0x18624D560")]
	private void DKFPEOCKOCJ(Allocator ILEAEEDKNCF, NativeArray<float4> BENDIBICEKH, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x624D320", Offset = "0x624C520", VA = "0x18624D320")]
	[BurstCompile]
	private unsafe static void DKFPEOCKOCJ(float4* OFNDHBCFIAM, byte* LLGKFHNPKJL, [Out] int KEJEHLAGOOM, [Out] int MPCFKBNKPEL, float4* BENDIBICEKH, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x624CD70", Offset = "0x624BF70", VA = "0x18624CD70")]
	private static void DBOEEGPCPNC(NativeArray<float4> JGIDNGGDEAD, NativeArray<CHIMIMADPFN> PCLFDNONBON, NativeArray<byte> IILNJIPCMMF, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x624CCF0", Offset = "0x624BEF0", VA = "0x18624CCF0")]
	[BurstCompile]
	private unsafe static void DBOEEGPCPNC(float4* JGIDNGGDEAD, [In] CHIMIMADPFN* PCLFDNONBON, [In] byte* IILNJIPCMMF, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x624F7F0", Offset = "0x624E9F0", VA = "0x18624F7F0")]
	private void PEIPOMCGDLH(Allocator ILEAEEDKNCF, NativeArray<int> OIAEPCPPDLN, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x624CF50", Offset = "0x624C150", VA = "0x18624CF50")]
	private static NativeArray<byte> DDBIKMOJBKC(Allocator ILEAEEDKNCF, NativeArray<int> OIAEPCPPDLN, int FMDFOHFCBKI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x624CEE0", Offset = "0x624C0E0", VA = "0x18624CEE0")]
	[BurstCompile]
	private unsafe static int DDBIKMOJBKC(byte* ONMCMEDHIOK, [In] int* OIAEPCPPDLN, int FMDFOHFCBKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x624E220", Offset = "0x624D420", VA = "0x18624E220")]
	private static void JIFGALNLIAA(NativeArray<int> NJLIAGNNPFJ, NativeArray<byte> GMDPKNNOJFC, int MANLMKKLAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x624E1B0", Offset = "0x624D3B0", VA = "0x18624E1B0")]
	[BurstCompile]
	private unsafe static void JIFGALNLIAA(int* NJLIAGNNPFJ, [In] byte* GMDPKNNOJFC, int MANLMKKLAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x624CE80", Offset = "0x624C080", VA = "0x18624CE80")]
	[BurstCompile]
	private static void DCMNNDKNCOF([Out] float3 FOLDICALLGP, ushort EOJLBCNMBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x624F190", Offset = "0x624E390", VA = "0x18624F190")]
	[BurstCompile]
	private static ushort MOIFMHDIJDM([In] float3 ICKHHPAKKOF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EEHGDDAFAPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6247CB0", Offset = "0x6246EB0", VA = "0x186247CB0")]
	[BurstCompile]
	public unsafe static void DKMEOGFPHFH(float3* MKFCMJAJFIG, [In] ushort* ANFDBINHPEK, int ILFCMJPICCH, [In] float3 EPCDBOKNGFN, [In] float3 KHGNCJCEAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62480C0", Offset = "0x62472C0", VA = "0x1862480C0")]
	[BurstCompile]
	public unsafe static void MMADCIJGCEF(ushort* MKFCMJAJFIG, [Out] float3 OJKFLHAFPLF, [Out] float3 KHGNCJCEAAF, [In] float3* ANFDBINHPEK, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6248660", Offset = "0x6247860", VA = "0x186248660")]
	[BurstCompile]
	public unsafe static void NLHGCNBLECK(ushort* PGMJAPAOOOD, [In] float3* DEHDBCNCFEP, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x624F470", Offset = "0x624E670", VA = "0x18624F470")]
	[BurstCompile]
	public unsafe static void NNAHIIJPLHB(float3* CMLBHJMHNDL, [In] ushort* DEHDBCNCFEP, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62479F0", Offset = "0x6246BF0", VA = "0x1862479F0")]
	[BurstCompile]
	public unsafe static void APJKKMKCNHB(ushort* NBDLEEJMFBN, [Out] float2 GLGMGCHEELB, [Out] float2 MNOPOJJJBED, [In] float2* AJKIPJGDBFL, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x624E160", Offset = "0x624D360", VA = "0x18624E160")]
	[BurstCompile]
	public static void HOHIAMNDKHO([Out] float2 FOLDICALLGP, ushort EOJLBCNMBNM, [In] float2 GCMOIEEEOFK, [In] float2 MNOPOJJJBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x624C900", Offset = "0x624BB00", VA = "0x18624C900")]
	[BurstCompile]
	public unsafe static void CEEDNMMJMDA(float2* NBDLEEJMFBN, ushort* AJKIPJGDBFL, int ILFCMJPICCH, [In] float2 GCMOIEEEOFK, [In] float2 MNOPOJJJBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x624DCA0", Offset = "0x624CEA0", VA = "0x18624DCA0")]
	[BurstCompile]
	public unsafe static void FMAOBJGMNBO(ushort* LPPLAPPKPFB, [In] float4* KGHDAKJGKBB, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x624E2F0", Offset = "0x624D4F0", VA = "0x18624E2F0")]
	[BurstCompile]
	public static ushort JNNPNGALMLB([In] float4 ICKHHPAKKOF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x624EE70", Offset = "0x624E070", VA = "0x18624EE70")]
	[BurstCompile]
	public unsafe static void LOCLNKHDBNK(float4* LPPLAPPKPFB, [In] ushort* ENLHJGIFGBD, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x624E000", Offset = "0x624D200", VA = "0x18624E000")]
	[BurstCompile]
	public static void HDHFMFLNILC([Out] float4 HCIDHCBMOPD, ushort EOJLBCNMBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62484A0", Offset = "0x62476A0", VA = "0x1862484A0")]
	[BurstCompile]
	public unsafe static void NDLEFPEMMGN(float4* OFNDHBCFIAM, byte* LLGKFHNPKJL, [Out] int KEJEHLAGOOM, [Out] int MPCFKBNKPEL, float4* BENDIBICEKH, int CDEFNHHBCHK, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x624ED30", Offset = "0x624DF30", VA = "0x18624ED30")]
	[BurstCompile]
	public unsafe static void LFOJEGINLCG(float4* JGIDNGGDEAD, [In] CHIMIMADPFN* PCLFDNONBON, [In] byte* IILNJIPCMMF, int ILFCMJPICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x624C7B0", Offset = "0x624B9B0", VA = "0x18624C7B0")]
	[BurstCompile]
	public unsafe static int AKFPMHJBFAC(byte* ONMCMEDHIOK, [In] int* OIAEPCPPDLN, int FMDFOHFCBKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x624E0C0", Offset = "0x624D2C0", VA = "0x18624E0C0")]
	[BurstCompile]
	public unsafe static void HIDABFJIFID(int* NJLIAGNNPFJ, [In] byte* GMDPKNNOJFC, int MANLMKKLAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x624EF10", Offset = "0x624E110", VA = "0x18624EF10")]
	[BurstCompile]
	public static void MCOJKFKAMIP([Out] float3 FOLDICALLGP, ushort EOJLBCNMBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6247F00", Offset = "0x6247100", VA = "0x186247F00")]
	[BurstCompile]
	public static ushort KONAPGMCGOB([In] float3 ICKHHPAKKOF)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct ALMKDAOKOJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float2 OIGLMMJODMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float2 GDFBIKCODFE;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LMJGIFMGGNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<ALMKDAOKOJN> FOMGDLFLAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<int> HNJDNLBEHIA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ALHCGDDKPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EPECIFGNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B9980", Offset = "0x7B8B80", VA = "0x1807B9980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6262A30", Offset = "0x6261C30", VA = "0x186262A30")]
	public LMJGIFMGGNP(int BKCCKPKDJJL, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62628F0", Offset = "0x6261AF0", VA = "0x1862628F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6262950", Offset = "0x6261B50", VA = "0x186262950")]
	public void PHDFONJIJLP(LMJGIFMGGNP EDEEBLMBFII, int OHINAAFDNOO, int LCKACGDGBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GGBFPEPGCIA
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static LMJGIFMGGNP HMCAGGIGBAN;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static NativeList<LEKDGNCNAOB> GNENMLFAGBF;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static int[] KFGONNFOAPO;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static bool EMCNLOHIECB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, LMJGIFMGGNP> DMBDPJIIMGH;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, LMJGIFMGGNP> NGHDOFPAOCI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool NDGONCAGBFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x625A700", Offset = "0x6259900", VA = "0x18625A700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<LEKDGNCNAOB> DMICEIPGMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x625A940", Offset = "0x6259B40", VA = "0x18625A940")]
		get
		{
			return default(NativeList<LEKDGNCNAOB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static LMJGIFMGGNP ECFCKIOBIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x625A300", Offset = "0x6259500", VA = "0x18625A300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6259BC0", Offset = "0x6258DC0", VA = "0x186259BC0")]
	private static void BFMLBOOECDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6259500", Offset = "0x6258700", VA = "0x186259500")]
	public static int ACJKBJHOJJI(bool NPOFGOHMDHO, int DOMBNOBIEPC, bool NPLPHGICDLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x625A3A0", Offset = "0x62595A0", VA = "0x18625A3A0")]
	private static int HHFBDPEOOMB(int DOMBNOBIEPC, bool JKICLFAHPHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x625AAD0", Offset = "0x6259CD0", VA = "0x18625AAD0")]
	private static int ONIGMAGPDOF(int DOMBNOBIEPC, bool JKICLFAHPHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x625AA40", Offset = "0x6259C40", VA = "0x18625AA40")]
	public static int OFPOACLNMAF(int DKNFDKCGOLD, int DOMBNOBIEPC, int COKHJIDMOIN, bool JKICLFAHPHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x625A270", Offset = "0x6259470", VA = "0x18625A270")]
	public static int HCKPKFCCDDB(int DKNFDKCGOLD, int DOMBNOBIEPC, int COKHJIDMOIN, bool JKICLFAHPHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x625A260", Offset = "0x6259460", VA = "0x18625A260")]
	public static int GPEIKFMKNMK(int COKHJIDMOIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x625A390", Offset = "0x6259590", VA = "0x18625A390")]
	private static int HGEGMKDMNAP(int DOMBNOBIEPC, bool JKICLFAHPHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x625A780", Offset = "0x6259980", VA = "0x18625A780")]
	private static int JAPBDGAPJDB(int DOMBNOBIEPC, bool JKICLFAHPHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x625A9D0", Offset = "0x6259BD0", VA = "0x18625A9D0")]
	public static int NIGKBOOBKLB(int DKNFDKCGOLD, int DOMBNOBIEPC, int COKHJIDMOIN, bool JKICLFAHPHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x625A890", Offset = "0x6259A90", VA = "0x18625A890")]
	public static int LHMCACMAKJL(int DKNFDKCGOLD, int DOMBNOBIEPC, int COKHJIDMOIN, bool JKICLFAHPHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x625A920", Offset = "0x6259B20", VA = "0x18625A920")]
	public static int MNFHNIFEJGB(int COKHJIDMOIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x625A7A0", Offset = "0x62599A0", VA = "0x18625A7A0")]
	public static LMJGIFMGGNP KBPECNLEBOK(int DOMBNOBIEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6259530", Offset = "0x6258730", VA = "0x186259530")]
	private static LMJGIFMGGNP AOCGHAFCGEE(int DOMBNOBIEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x625AAE0", Offset = "0x6259CE0", VA = "0x18625AAE0")]
	public static LMJGIFMGGNP PGNHLHKNGAO(int DOMBNOBIEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x625A3C0", Offset = "0x62595C0", VA = "0x18625A3C0")]
	private static LMJGIFMGGNP IKPJGIDOOKP(int DOMBNOBIEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x62597C0", Offset = "0x62589C0", VA = "0x1862597C0")]
	public static void BBCOKHNJDAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JBHKEMFLPOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int NDKGLNHMPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 JNMPOPHLKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion AFMMEDKKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float HPJLAKEANCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float CKHEGFMBIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int OHGAACDKLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int MKJPAJDIBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int APDNHOFOCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool CCLFEIGMHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool NGFBFHJNLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float GFKKLLNGKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 OGNPHEFGJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool KPDNPFHEDAO;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct NNNFMEMPIHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int NIBJDAOKPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int FEEMFOBPOCL;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct BBNPBHPECAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NativeList<JBHKEMFLPOK> NFFOGPJBIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeArray<LBGPNLGBJGE> EAFKKJMMABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<LEKDGNCNAOB> LNICNFDOJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<NNNFMEMPIHE> MLJLPAIBADH;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x62497E0", Offset = "0x62489E0", VA = "0x1862497E0")]
	public BBNPBHPECAI(NativeArray<LBGPNLGBJGE> EAFKKJMMABA, int MKJBDDDPMKM = 1, Allocator ILEAEEDKNCF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x62496F0", Offset = "0x62488F0", VA = "0x1862496F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
public struct OPDDDPCIBCK : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<ALMKDAOKOJN> HLJFLENIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<int> GOFMHNIMDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeList<LEKDGNCNAOB> KNDCKKBNIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<JBHKEMFLPOK> NFFOGPJBIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<LBGPNLGBJGE> EAFKKJMMABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<LEKDGNCNAOB> LNICNFDOJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<NNNFMEMPIHE> MLJLPAIBADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private int ECJKHGALCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int PPNPEPLNBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float3 NMLIKEGKAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private quaternion FNIKNMLNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 CMJNJPBJKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FCIFNHIONMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ODOHPMAPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> APKKAAPKPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DDJGJINPKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> CKCDNKOODLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> POJEEMBOBPG;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6265DD0", Offset = "0x6264FD0", VA = "0x186265DD0")]
	public OPDDDPCIBCK(GKFKJFIDCKD EHMIIMPODFP, HLHCPFCIGJP NBOLBFJEOCD, float3 PLBBLEABDPL, quaternion OECHNAENBPC, float EIJJNOGJLBG, int DIKHLMOGACB = 0, int KAIBCBPOEKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6266050", Offset = "0x6265250", VA = "0x186266050")]
	public OPDDDPCIBCK(BBNPBHPECAI EHMIIMPODFP, HLHCPFCIGJP NBOLBFJEOCD, float3 PLBBLEABDPL, quaternion OECHNAENBPC, float3 EIJJNOGJLBG, int DIKHLMOGACB = 0, int KAIBCBPOEKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x62651F0", Offset = "0x62643F0", VA = "0x1862651F0")]
	private float3 KOLPFFOBGHA(float3 KLBJHAIAFEK, Matrix4x4 COMPPBHBJJO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6265000", Offset = "0x6264200", VA = "0x186265000")]
	private float3x3 GEBACNEEMGA(float3x3 IGCKEKEFBHJ, float3x3 AEPKMDGAJOM)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6264FF0", Offset = "0x62641F0", VA = "0x186264FF0")]
	private float FPDEAOBEBJB(float EKCHLHLGOBO, float HNMJJBMBDAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6263E50", Offset = "0x6263050", VA = "0x186263E50", Slot = "4")]
	public void Execute(int HPIPPKAMAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6265080", Offset = "0x6264280", VA = "0x186265080")]
	private void KHOOAMOGIDH(int GENNNFLJOGF, float3 DHMMMGDKPCG, float3 IAAOFHLOLIL, float3 JNJKKJAIGBM, float LJCANJNBLMD, bool PLALKFKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6265970", Offset = "0x6264B70", VA = "0x186265970")]
	private void OJIOEBCMJPC(JBHKEMFLPOK NJOOICMFFDA, float3 CNJLCEDOCCB, float3x3 AFBNOBHGJDB, float EKCHLHLGOBO, int DAJJGAAANFA, int MADBJANEGMG, int KAGPPCBPBKD, float KDFJHNDMMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6265320", Offset = "0x6264520", VA = "0x186265320")]
	private void OHHIOBNFGPF(int GENNNFLJOGF, int CGJFEDJOFDO, JBHKEMFLPOK NJOOICMFFDA, float3 CNJLCEDOCCB, float3x3 AFBNOBHGJDB, bool JFLODIGEPMD, float EKCHLHLGOBO, int PFDLBMGBMHA, int CAPCEBGNCIH, int KAGPPCBPBKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CGBLBJAPNNG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeList<AJJINNLHJBJ> AEHEKJNCIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeList<LEKDGNCNAOB> HODIDHBAKIH;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x624A7F0", Offset = "0x62499F0", VA = "0x18624A7F0")]
	public CGBLBJAPNNG(int MKJBDDDPMKM, Allocator ILEAEEDKNCF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x624A750", Offset = "0x6249950", VA = "0x18624A750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
public struct JHPGHOOINJI : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private enum JBLLFOMPHOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private NativeList<float3> BLINFKPEBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private NativeArray<float3> PMDMGKDDJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private NativeList<int> PKMFAGMDEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeArray<int> ABABLOIBNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeArray<float4> CNCOIJDOGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeArray<float4> CKCAPNJFMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<float4> JOIAEHENHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<float3> PGLBJFGBMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private NativeList<LEKDGNCNAOB> LKKCPKEIMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private NativeList<AJJINNLHJBJ> AEHEKJNCIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private NativeList<LEKDGNCNAOB> HODIDHBAKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private int ECJKHGALCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private int PPNPEPLNBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FCIFNHIONMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ODOHPMAPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> APKKAAPKPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DDJGJINPKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> CKCDNKOODLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> POJEEMBOBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private float3 CMJNJPBJKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private quaternion FNIKNMLNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 NMLIKEGKAJL;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x62609E0", Offset = "0x625FBE0", VA = "0x1862609E0")]
	public JHPGHOOINJI(GKFKJFIDCKD EHMIIMPODFP, HLHCPFCIGJP NBOLBFJEOCD, float3 PLBBLEABDPL, quaternion OECHNAENBPC, float EIJJNOGJLBG, int DIKHLMOGACB = 0, int KAIBCBPOEKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6260BD0", Offset = "0x625FDD0", VA = "0x186260BD0")]
	public JHPGHOOINJI(CGBLBJAPNNG FODGEDCJIDC, HLHCPFCIGJP NBOLBFJEOCD, float3 PLBBLEABDPL, quaternion OECHNAENBPC, float3 EIJJNOGJLBG, int DIKHLMOGACB = 0, int KAIBCBPOEKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x625FA40", Offset = "0x625EC40", VA = "0x18625FA40", Slot = "4")]
	public void Execute(int HPIPPKAMAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x625F690", Offset = "0x625E890", VA = "0x18625F690")]
	private void CNFJHPAGBGK(float4x4 ODOPCMMDNBA, int HPIPPKAMAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x625F620", Offset = "0x625E820", VA = "0x18625F620")]
	private JBLLFOMPHOO CHLNIGDPPGL(float3 IAAOFHLOLIL)
	{
		return default(JBLLFOMPHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x625F5D0", Offset = "0x625E7D0", VA = "0x18625F5D0")]
	private float4 BDNHFLCJNFG(JBLLFOMPHOO BMGJNCNCMME, int HMFNCGHECPG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x62609A0", Offset = "0x625FBA0", VA = "0x1862609A0")]
	private float2 GCOBMEOPEFE(JBLLFOMPHOO BMGJNCNCMME, float3 DHMMMGDKPCG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KPBGIKAEPIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum CBFHHCJEHHF
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static KPBGIKAEPIJ CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public float3 MFDMLPFPBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public float3x3 HMKNDOIICKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public float3 JPOIEEJJKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public CBFHHCJEHHF DIOCHMJOOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 EIBCPHAAHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 CLFGEJEAMDA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KMIBCIBKNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6262500", Offset = "0x6261700", VA = "0x186262500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 OIHICKOEEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6262510", Offset = "0x6261710", VA = "0x186262510")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6262800", Offset = "0x6261A00", VA = "0x186262800")]
	public KPBGIKAEPIJ(float3 DHMMMGDKPCG, quaternion HBCECKEGCGH, float3 MKJBDDDPMKM, CBFHHCJEHHF FLPJMDMACMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6262300", Offset = "0x6261500", VA = "0x186262300")]
	public float DJBNDKAAIHM(float3 CNJLCEDOCCB, float BCNEGIOKFEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6262110", Offset = "0x6261310", VA = "0x186262110")]
	public bool BBADPHFKCIG(float3 IAAOFHLOLIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x62625F0", Offset = "0x62617F0", VA = "0x1862625F0")]
	public void OPKDHOIHMDB(float3 CDMLHLIPJJN, float3x3 ILMKAANBJGH, float JMGABEGABLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6262200", Offset = "0x6261400", VA = "0x186262200")]
	private void CDNLMNGMACA(float3 LJBCIKIPLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6261E80", Offset = "0x6261080", VA = "0x186261E80")]
	public void AMBDFAMEPHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
public struct GBOCBMBOGAC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeList<KPBGIKAEPIJ> FODGEDCJIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeList<float3> NMBBHODJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<int> GKAIENLANNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NNPLMJGBKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<LEKDGNCNAOB> HODIDHBAKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private int IBBJCGAMGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int KHLHOGLGDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private float BCNEGIOKFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private float MHFGBNLKGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> EKEELDPJANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> OMOLDAIMIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> HLENKHCCOKN;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x62516F0", Offset = "0x62508F0", VA = "0x1862516F0")]
	public GBOCBMBOGAC(HLHCPFCIGJP PGNOHIOKGKO, float JCILELPNODG, int LCKACGDGBMN, int DAJJGAAANFA, NativeList<KPBGIKAEPIJ> FODGEDCJIDC, NativeArray<int> NNPLMJGBKOE, NativeList<LEKDGNCNAOB> HODIDHBAKIH, BOONEENEDJA OCECGAJFAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6250C50", Offset = "0x624FE50", VA = "0x186250C50", Slot = "4")]
	public void Execute(int KIAHHCNMCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6251390", Offset = "0x6250590", VA = "0x186251390")]
	private bool IEFKMKMLKJA(KPBGIKAEPIJ JPEEHDCLFEK, KPBGIKAEPIJ HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6251450", Offset = "0x6250650", VA = "0x186251450")]
	private bool LNOALHGAKIA(KPBGIKAEPIJ IDBHAEBCELK, int NDCEPKMMHBL, int PNCCNJLLBMJ, int DMPFJLONMJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BOONEENEDJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<bool> FGEJLFANIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<int> DAADLAKNCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<bool> INGACGBIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float> AGCMNNGEIBD;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x624A090", Offset = "0x6249290", VA = "0x18624A090")]
	public void GIOPEGMNBGI(int BKCCKPKDJJL, int CIBFDIDKKEM, Allocator ILEAEEDKNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x624A070", Offset = "0x6249270", VA = "0x18624A070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x624A190", Offset = "0x6249390", VA = "0x18624A190")]
	public void OAIFEIHHKBN(JobHandle FMIOCBOJMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public BOONEENEDJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
public struct NLEFINFICLA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NativeList<float3> NMBBHODJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NativeArray<float3> CNBJMFKBOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private NativeArray<float4> IKNJAEJEMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeArray<float2> BACMMCOJBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private NativeList<int> GKAIENLANNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FLEAMMBNHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<int> KIKJIMAHICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeArray<bool> EKEELDPJANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<bool> OMOLDAIMIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private int DIKHLMOGACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private int KAIBCBPOEKC;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6263DD0", Offset = "0x6262FD0", VA = "0x186263DD0")]
	public NLEFINFICLA(HLHCPFCIGJP PGNOHIOKGKO, BOONEENEDJA OCECGAJFAOK, int KAIBCBPOEKC = 0, int DIKHLMOGACB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6263990", Offset = "0x6262B90", VA = "0x186263990", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6263D70", Offset = "0x6262F70", VA = "0x186263D70")]
	private void PLNIKABEICO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class LMDBCFFAPOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x298B740", Offset = "0x298A940", VA = "0x18298B740")]
	public static bool PAFOJOEGABB<T>(NativeArray<T> GEHAOEPMDJB, int MKJBDDDPMKM, Allocator ILEAEEDKNCF, NativeArrayOptions LDPJIDDAJGB = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x298B7E0", Offset = "0x298A9E0", VA = "0x18298B7E0")]
	public static bool PAFOJOEGABB<T>(NativeList<T> JLCIFHJMGPA, int MKJBDDDPMKM, Allocator ILEAEEDKNCF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum ICBLPECKFFH
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FHPCBDOPFEE
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GOKKCIGOCBL(ICBLPECKFFH DKNFDKCGOLD);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JKIPFJGHMHD(ICBLPECKFFH DKNFDKCGOLD);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds FHDDCADKCFN();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float CDBJCFAKEIC();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJKMNAMJPBE(ICBLPECKFFH DKNFDKCGOLD, GKFKJFIDCKD CPEIMEBAMDB, int JPDBCCHKGCE = -1);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HLHCPFCIGJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const int NBBIKGIJBMO = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NativeList<float3> NFFGDCDOFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public NativeArray<float3> KBNEJCGKDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public NativeArray<float4> CPCOIEOJLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public NativeArray<float4> KFGJLMNHGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeArray<float2> EGFBOKCBCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<int> POGIHACJGCE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PPFMDOGEELH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x625DCF0", Offset = "0x625CEF0", VA = "0x18625DCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ALHCGDDKPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x625D5C0", Offset = "0x625C7C0", VA = "0x18625D5C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EPECIFGNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x625DCB0", Offset = "0x625CEB0", VA = "0x18625DCB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool POOBEFCHBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x625E040", Offset = "0x625D240", VA = "0x18625E040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x625DBA0", Offset = "0x625CDA0", VA = "0x18625DBA0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x625DD30", Offset = "0x625CF30", VA = "0x18625DD30")]
	public void GIOPEGMNBGI(int BKCCKPKDJJL, int CIBFDIDKKEM, Allocator ILEAEEDKNCF, bool CKBNAEFEHJM, bool NMBMKECLMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x625D600", Offset = "0x625C800", VA = "0x18625D600")]
	public void BAOAGIDCNDG(int BKCCKPKDJJL, int CIBFDIDKKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x625D680", Offset = "0x625C880", VA = "0x18625D680", Slot = "6")]
	public bool DLHGKBCJEPN(Mesh PGNOHIOKGKO, bool IPCBCHHOHLO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x625E0E0", Offset = "0x625D2E0", VA = "0x18625E0E0")]
	public bool NPHBPGIMHCG(Mesh PGNOHIOKGKO, HLHCPFCIGJP BNBBGDMIILC, bool IPCBCHHOHLO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x625E8F0", Offset = "0x625DAF0", VA = "0x18625E8F0")]
	public void PHDFONJIJLP(HLHCPFCIGJP PGNOHIOKGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x625DF00", Offset = "0x625D100", VA = "0x18625DF00")]
	public HLHCPFCIGJP GMJOKEELPME(Allocator ILEAEEDKNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x625DA60", Offset = "0x625CC60", VA = "0x18625DA60")]
	public long DOGHDLIBPME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x625E080", Offset = "0x625D280", VA = "0x18625E080")]
	public void NCIHGPPFJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HLHCPFCIGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NADPHPBGCFN
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6263840", Offset = "0x6262A40", VA = "0x186263840")]
	public static void BBCOKHNJDAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class ECOOEHPOKEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<float3> NFFGDCDOFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<float3> KBNEJCGKDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<int> DLAMMGPKENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<float4> AFLHMOJJKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<float4> DOKEFFOFMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float4> DIIDICNLBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public NativeList<float3> NIBJNFHEJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public NativeList<int> POGIHACJGCE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int ALHCGDDKPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x624B3C0", Offset = "0x624A5C0", VA = "0x18624B3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EPECIFGNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x624B550", Offset = "0x624A750", VA = "0x18624B550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FIHHGCDDMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x624B400", Offset = "0x624A600", VA = "0x18624B400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x624C2A0", Offset = "0x624B4A0", VA = "0x18624C2A0")]
	public ECOOEHPOKEH(int BKCCKPKDJJL, int CIBFDIDKKEM, int HIIHLAAECIA, Allocator ILEAEEDKNCF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x624C4C0", Offset = "0x624B6C0", VA = "0x18624C4C0")]
	public ECOOEHPOKEH(Mesh PGNOHIOKGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x624B440", Offset = "0x624A640", VA = "0x18624B440", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x624BA20", Offset = "0x624AC20", VA = "0x18624BA20")]
	public void PHDFONJIJLP(ECOOEHPOKEH PGNOHIOKGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x624B590", Offset = "0x624A790", VA = "0x18624B590")]
	private void IOOPDDKOPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x624BD20", Offset = "0x624AF20", VA = "0x18624BD20")]
	private void PPOOMDHHMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct LEKDGNCNAOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public int FDPOCCNOFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public int ALHCGDDKPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public int OPHNKLDKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public int EPECIFGNGCP;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x12890B0", Offset = "0x12882B0", VA = "0x1812890B0")]
	public LEKDGNCNAOB(int DAJJGAAANFA, int ILFCMJPICCH, int LCKACGDGBMN, int MANLMKKLAMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class KDKOIMIEKCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<LEKDGNCNAOB> AGDMIDHHPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LEKDGNCNAOB>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8439E0", Offset = "0x842BE0", VA = "0x1808439E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ECOOEHPOKEH JHMIODLCHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6260E20", Offset = "0x6260020", VA = "0x186260E20")]
	public KDKOIMIEKCD(IEnumerable<ECOOEHPOKEH> KNCBGEONBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6260DB0", Offset = "0x625FFB0", VA = "0x186260DB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum POOEFICLNNK
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class MEDCJDHLFPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static NativeArray<float2> MFDEADLBFKB;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static NativeArray<float3> GDIIHEEBLHK;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static NativeArray<float4> FEJHPPDLDHF;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static NativeArray<int> ABPAHOKEGNP;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6262DF0", Offset = "0x6261FF0", VA = "0x186262DF0")]
	public static void BBCOKHNJDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6262CF0", Offset = "0x6261EF0", VA = "0x186262CF0")]
	public static NativeArray<float2> AHFPDKMDMNF(NativeArray<float2> PELNBLPNMJJ, int DIMADNMDMGK, NativeArray<float2> DOJGOFDBIHO, int AIKOFEKDMPG)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6262BF0", Offset = "0x6261DF0", VA = "0x186262BF0")]
	public static NativeArray<float3> AGOKJLPHIGO(NativeArray<float3> PELNBLPNMJJ, int DIMADNMDMGK, NativeArray<float3> DOJGOFDBIHO, int AIKOFEKDMPG)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6263000", Offset = "0x6262200", VA = "0x186263000")]
	public static NativeArray<float4> LLJHCAMGGIP(NativeArray<float4> PELNBLPNMJJ, int DIMADNMDMGK, NativeArray<float4> DOJGOFDBIHO, int AIKOFEKDMPG)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6262F00", Offset = "0x6262100", VA = "0x186262F00")]
	public static NativeArray<int> EJBGJCBLCMI(NativeArray<int> PELNBLPNMJJ, int DIMADNMDMGK, NativeArray<int> DOJGOFDBIHO, int AIKOFEKDMPG)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x29B4A20", Offset = "0x29B3C20", VA = "0x1829B4A20")]
	private static void IGGKIFBHGMM<T>(NativeArray<T> GEHAOEPMDJB, int DMHHDCADFJF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x29B4970", Offset = "0x29B3B70", VA = "0x1829B4970")]
	private static void GIPGCMHHLIP<T>(NativeArray<T> PELNBLPNMJJ, int DIMADNMDMGK, NativeArray<T> DOJGOFDBIHO, int AIKOFEKDMPG, NativeArray<T> BEHGPAAJAEG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DebuggerStepThrough]
public static class GEHNCINCDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	public static void FDNKCMPAGII(bool PMBMOONGPPJ, string LIOOLHCFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	public static void FDNKCMPAGII(bool PMBMOONGPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class GDFECINMGNF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal enum FHNGJIPMCCG
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class PGAAIBHGMJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public EEHGDDAFAPA PGNOHIOKGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int GNMHMPMGBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int HECBMGONCFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long MGPNEMBAKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public long ABICKGNHJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float EIFIHLNOJOG;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6272EA0", Offset = "0x62720A0", VA = "0x186272EA0")]
		public PGAAIBHGMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6272E60", Offset = "0x6272060", VA = "0x186272E60")]
		public void OAIFEIHHKBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly string CDMDLKALHDO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly string GGJPDBPHJCK;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker KEBADCMCJEC;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ProfilerMarker GPFBEKKBGAF;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker JKAHGNKJOCK;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker JBHPKDLNBOG;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly ProfilerMarker FENMAKHKGEJ;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker LJNLJLKJKAG;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker COEIHNDCHDK;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker JOEAFMNGJNB;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker KFKFEAIABPJ;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker PBHGPFLKPNH;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker BECCMGEMMDK;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker OFBHKPHMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<FHPCBDOPFEE> EGFAOPNPDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly HNAEADEHOKP MBGFIKALOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int ILFCMJPICCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int MANLMKKLAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool JDMKBCMLKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	internal bool JACPJFGEHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	internal FHNGJIPMCCG OAODOPKGJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	internal bool AMOFAJHPPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal float3 OHBBNNIHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal float3 GCNIDDOLCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal float GEMENFBKJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	internal float INPJEBFHMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	internal int KELFLGLIALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	internal int GBGDEJLCNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int POODLKKLDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float EPDCNMOHKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float EOBPDFFGCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int GLJJMINKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private long CINIGBLOBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long FFGGPCBFNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private long MEMHCNGBCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public int NMOCOGFFMON;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int BNICAJBALLF = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float[] DLIDMFEDFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private int[] POAOCEMDGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private long[] PBEODKOHLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private HLHCPFCIGJP APHDCNIJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private long PJLIDKIAKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private long GLAPFJLLNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int EGCFPEFLLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private List<PGAAIBHGMJM> DGHIELEPDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	internal float KLMCDNLPBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool GPEKKOBCKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private KCOCNOCBGGF EAEGLJCDAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private JobHandle NNKPLKEHEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal NativeArray<long> EDFJAMKMEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool IAMBFEEDEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private JobHandle BMKOOJPMJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private HLHCPFCIGJP DFHPMIGDCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Transform JDEAGPALLJL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh JHMIODLCHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer IBJHICOBIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EIJGFPKCMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAEBD70", Offset = "0xAEAF70", VA = "0x180AEBD70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PIPDGCJMBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7DC210", Offset = "0x7DB410", VA = "0x1807DC210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int ALHCGDDKPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6251790", Offset = "0x6250990", VA = "0x186251790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<FHPCBDOPFEE> BPFCKMABAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x62517F0", Offset = "0x62509F0", VA = "0x1862517F0")]
	public void CDAPFOJENIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6256370", Offset = "0x6255570", VA = "0x186256370")]
	private void NLKJKHEPKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6258D60", Offset = "0x6257F60", VA = "0x186258D60")]
	public GDFECINMGNF(string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6256550", Offset = "0x6255750", VA = "0x186256550")]
	public void OAIFEIHHKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6252A50", Offset = "0x6251C50", VA = "0x186252A50")]
	public void HJNLICGIIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6256690", Offset = "0x6255890", VA = "0x186256690")]
	private void OIBMBLINGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6256900", Offset = "0x6255B00", VA = "0x186256900")]
	public void OJCBJDHMBMB(FHPCBDOPFEE PBGDFCFGABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6255FF0", Offset = "0x62551F0", VA = "0x186255FF0")]
	public bool MNPLOMFMNJN(FHPCBDOPFEE PBGDFCFGABP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x62529F0", Offset = "0x6251BF0", VA = "0x1862529F0")]
	public bool GIIBKAKCCGO(FHPCBDOPFEE PBGDFCFGABP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6252400", Offset = "0x6251600", VA = "0x186252400", Slot = "4")]
	public virtual void DOMNKINCFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x62554A0", Offset = "0x62546A0", VA = "0x1862554A0")]
	public void LOJDFJCAKIK(Transform EBJHBCOGOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6252AE0", Offset = "0x6251CE0", VA = "0x186252AE0")]
	public bool IAOAOKPFFMJ(Transform EBJHBCOGOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6254000", Offset = "0x6253200", VA = "0x186254000")]
	public bool IHIDANPKKIN(bool BGNJNPOLJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6252800", Offset = "0x6251A00", VA = "0x186252800")]
	public void GCGAILABENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6257B50", Offset = "0x6256D50", VA = "0x186257B50")]
	public bool ONNFKEHCGOB(float4x4 OABAOAEABAB, BatchedMeshRenderer OEAGMHIMEHN, bool EALAPOLEBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x62524B0", Offset = "0x62516B0", VA = "0x1862524B0")]
	public void EBKMLHJAJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6256090", Offset = "0x6255290", VA = "0x186256090")]
	public bool NACDMLAJDKJ(bool BGNJNPOLJJM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x62517E0", Offset = "0x62509E0", VA = "0x1862517E0")]
	public void BGNBIOBDGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x62517B0", Offset = "0x62509B0", VA = "0x1862517B0")]
	public void AMMIJFCFJHO(HLHCPFCIGJP PGNOHIOKGKO, int PDMFDLHHHCA, float GCIMJOEPLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x62589C0", Offset = "0x6257BC0", VA = "0x1862589C0")]
	public void PAFAHDDMFJN(EEHGDDAFAPA GNEFBCDCGML, int PDMFDLHHHCA, float GCIMJOEPLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x62523F0", Offset = "0x62515F0", VA = "0x1862523F0")]
	public long DOGHDLIBPME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F60", Offset = "0x7C0160", VA = "0x1807C0F60")]
	public long LGCNJIGMCJL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6255020", Offset = "0x6254220", VA = "0x186255020")]
	private void JPDBLKEBLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6252080", Offset = "0x6251280", VA = "0x186252080")]
	public (long, long) CPLDHANLEGJ(float ICJDGMEMHLE, float4x4 OABAOAEABAB)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xA90540", Offset = "0xA8F740", VA = "0x180A90540")]
	internal void BOKCCDOPHLP(FHNGJIPMCCG CHHLAMMKOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6251800", Offset = "0x6250A00", VA = "0x186251800")]
	private (float, float, float) CDJBLHDPOMO(float FMJNJJPBJNI, float4x4 OABAOAEABAB)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6252580", Offset = "0x6251780", VA = "0x186252580")]
	private (int, int) EOKDDEMAIGG(float OEMLJOMOHCL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6256A60", Offset = "0x6255C60", VA = "0x186256A60")]
	public void OJHIJKMMDKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6256660", Offset = "0x6255860", VA = "0x186256660")]
	private void OIBLPBMELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6254E60", Offset = "0x6254060", VA = "0x186254E60")]
	private void JDMCNDJJFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x62536F0", Offset = "0x62528F0", VA = "0x1862536F0")]
	private void IEGJOFNDPCF(HLHCPFCIGJP BHKFNLDNDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6255190", Offset = "0x6254390", VA = "0x186255190")]
	private void KOOKBFBDFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6255620", Offset = "0x6254820", VA = "0x186255620")]
	private void MFBMAAMBMKB(HLHCPFCIGJP PGNOHIOKGKO, EEHGDDAFAPA GNEFBCDCGML, int PDMFDLHHHCA, float GCIMJOEPLIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[BurstCompile]
internal struct KCOCNOCBGGF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct CENKHMEAEDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int JPHCOMNPMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int KFDFBLAOPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int PCAMCOLANEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int LHOEAOPANJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int CLPEBAFLEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int LFCPFKBNDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int GNMHMPMGBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int HECBMGONCFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float EIFIHLNOJOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct AIMMIGEBMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public IOLNBMACAGE.NJDKIHLBDDH OALIDFKJEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float EICEBDDBEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float DEEFNHHCAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float CLMKDIAGABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float KONEJCBHDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float JNNBEGIFJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float HBDFJDBNBBF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct KCEIDEKJNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NativeArray<float3> NFFGDCDOFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public NativeArray<float3> KBNEJCGKDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public NativeArray<float4> CPCOIEOJLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public NativeArray<float4> KFGJLMNHGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public NativeArray<float2> EGFBOKCBCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NativeArray<int> POGIHACJGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool ACMCLEPFABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int ALHCGDDKPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int EPECIFGNGCP;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6270160", Offset = "0x626F360", VA = "0x186270160")]
		public void GIOPEGMNBGI(int BKCCKPKDJJL, int CIBFDIDKKEM, Allocator ILEAEEDKNCF, bool NMBMKECLMKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x62702B0", Offset = "0x626F4B0", VA = "0x1862702B0")]
		public static KCEIDEKJNHK MPHNKPCKJKG(HLHCPFCIGJP LHCBCAKMNGO)
		{
			return default(KCEIDEKJNHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6270500", Offset = "0x626F700", VA = "0x186270500")]
		public void OAIFEIHHKBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly ProfilerMarker PGPPNKDOAPM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly ProfilerMarker JGDDFAAOJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private NativeArray<CENKHMEAEDP> EALJNCLJBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private KCEIDEKJNHK AMMBIPGGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private KCEIDEKJNHK BHKFNLDNDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private float3 KJLIFAKCHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private float3 LGPEKNEFJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private AIMMIGEBMHP EPIPMCEPJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* CJLFFFJLEHN;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6272830", Offset = "0x6271A30", VA = "0x186272830")]
	public KCOCNOCBGGF([In] List<GDFECINMGNF.PGAAIBHGMJM> LNCBPHCMECI, [In] HLHCPFCIGJP GLDOFFOCOJP, [In] GDFECINMGNF HAHOMIPAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x62722F0", Offset = "0x62714F0", VA = "0x1862722F0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x62705C0", Offset = "0x626F7C0", VA = "0x1862705C0")]
	public void BLHNBFELDCA(List<GDFECINMGNF.PGAAIBHGMJM> NBAEPDNLAMF, [In] GDFECINMGNF HAHOMIPAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6272780", Offset = "0x6271980", VA = "0x186272780")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool GJFNDDCDFJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6272220", Offset = "0x6271420", VA = "0x186272220")]
	private EEHGDDAFAPA CNEMIPGDFBE(int OLNBBFAIKPL, Allocator ILEAEEDKNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6270C70", Offset = "0x626FE70", VA = "0x186270C70")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void BOHPILHEMKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6272340", Offset = "0x6271540", VA = "0x186272340")]
	[IgnoreWarning(1371)]
	private CENKHMEAEDP FHIEJJNJPDN([In] CENKHMEAEDP FBHAAPCIHHH, int DPFLHELIPFB, [In] NativeArray<int> GKAIENLANNJ, [In] NativeArray<bool> OMOLDAIMIJL, NativeArray<int> ALGGDGLFCAF)
	{
		return default(CENKHMEAEDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6272120", Offset = "0x6271320", VA = "0x186272120")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int CDIGHFKHOGE(NativeArray<int> GKAIENLANNJ, int AKKALEEIPDP, int MCNHMAALFCL, int DGGGDHCOMDJ)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly ProfilerMarker DJIBLLIOPNK;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly ProfilerMarker LBMOEMMHLEP;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly ProfilerMarker PEJDFOMBKNL;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly ProfilerMarker EDIBADJBJGH;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly ProfilerMarker FENMAKHKGEJ;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly ProfilerMarker NGMCOGAACFB;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly ProfilerMarker MDMGGGDHCII;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal const int OILKAHENJBD = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Dictionary<Material, List<GDFECINMGNF>> FBDDNOFJAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		internal List<GDFECINMGNF> LDMKJPMGFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private List<MeshRenderer> EDKBBCKKBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool EACMEDFBMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool LJONAPNMJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int PMLODCMBALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Dictionary<int, float> EOFJAJOCGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Dictionary<int, Color> FELHOALABCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Dictionary<int, Vector4> KMLCKACAMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Dictionary<int, Matrix4x4> MBKLFOJIKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private GDFECINMGNF BHDHHKMCHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private Material FODIKPNJIGO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> ELAGIBJHFEP
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int FDIPFBCMJNA
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x626C2F0", Offset = "0x626B4F0", VA = "0x18626C2F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6268C40", Offset = "0x6267E40", VA = "0x186268C40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6266E20", Offset = "0x6266020", VA = "0x186266E20")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6266BF0", Offset = "0x6265DF0", VA = "0x186266BF0")]
		public GDFECINMGNF AddToBatchedMesh(FHPCBDOPFEE KLNEOHPAPIP, Material PEGNOKKFPLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x626B4C0", Offset = "0x626A6C0", VA = "0x18626B4C0")]
		public void RemoveFromBatchedMesh(FHPCBDOPFEE PGNOHIOKGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6266CF0", Offset = "0x6265EF0", VA = "0x186266CF0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x626B600", Offset = "0x626A800", VA = "0x18626B600")]
		public void SetMaterialProperty(int ECGHOPLJMLM, Color NHDAKDKKMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x626BA90", Offset = "0x626AC90", VA = "0x18626BA90")]
		public void SetMaterialProperty(int ECGHOPLJMLM, float NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x626BCB0", Offset = "0x626AEB0", VA = "0x18626BCB0")]
		public void SetMaterialProperty(int ECGHOPLJMLM, Vector4 FLPDINIBANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x626B830", Offset = "0x626AA30", VA = "0x18626B830")]
		public void SetMaterialProperty(int ECGHOPLJMLM, Matrix4x4 FEAAHMGJJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x62680E0", Offset = "0x62672E0", VA = "0x1862680E0")]
		private void OCBIDKOCECC(Renderer CPHKADKGBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6266FF0", Offset = "0x62661F0", VA = "0x186266FF0")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6266FE0", Offset = "0x62661E0", VA = "0x186266FE0")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x62686D0", Offset = "0x62678D0", VA = "0x1862686D0")]
		private void ODFAJONJPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6266960", Offset = "0x6265B60", VA = "0x186266960")]
		private GDFECINMGNF ADCBHCMGHHJ(FHPCBDOPFEE PGNOHIOKGKO, Material PEGNOKKFPLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6268F30", Offset = "0x6268130", VA = "0x186268F30")]
		private GDFECINMGNF PHFPANCDFJJ(Material PEGNOKKFPLO, int GFOMOFLOMBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6267090", Offset = "0x6266290", VA = "0x186267090")]
		private GDFECINMGNF GLBCGKJKDIF(Material PEGNOKKFPLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1773A90", Offset = "0x1772C90", VA = "0x181773A90")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6267BC0", Offset = "0x6266DC0", VA = "0x186267BC0")]
		public void MarkDirty(FHPCBDOPFEE PGNOHIOKGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6267D20", Offset = "0x6266F20", VA = "0x186267D20")]
		public (long, long) MemorySizeInBytesForChosenDetail(float ICJDGMEMHLE)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x626A610", Offset = "0x6269810", VA = "0x18626A610")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6267600", Offset = "0x6266800", VA = "0x186267600")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6269130", Offset = "0x6268330", VA = "0x186269130")]
		public void RebatchOptimally(int HEAPOALMNDE, int KBMBJBCNMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x626C080", Offset = "0x626B280", VA = "0x18626C080")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class HHPNMIHONOP
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct APCEAGLLKDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public float GFPJHDGNEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BatchedMeshRenderer HGPAOOKIDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public GDFECINMGNF EFPOHIGKIGK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly ProfilerMarker FENMAKHKGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly ProfilerMarker KPEEBJHANPC;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly ProfilerMarker PJIHFLENPDD;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly ProfilerMarker HHDELHJCPCD;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public static float3 BGKEFFHHJHH;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public static int BCIPFDECOAL;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public static int KHFFMNIHHML;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public static int HDKIIPLGLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public static int FNKNCKMEBEM;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public static int IJFODNECCEK;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static int POBNEFHIJEG;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static int LKIHIGHJHMF;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static int LAAFCAIBFLO;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public static int JBDIFMPAABC;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public static int KJJEDCDAMBE;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public static int LLNOAGJPFAH;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public static int HJPBCFBDOPM;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public static int GKNOJDCOBGN;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public static int HMKNKBHKDKA;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public static int IIHLCNDHEGE;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public static int NJEHIHPJIDN;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public static long BKJHBGANEHM;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public static bool IBAFBNGAFFL;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static List<BatchedMeshRenderer> JNLKIACKJLG;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static List<APCEAGLLKDO> EBGEPGBAEKB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool FNACAGKEIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x626C340", Offset = "0x626B540", VA = "0x18626C340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x626DBC0", Offset = "0x626CDC0", VA = "0x18626DBC0")]
	public static void KBPFNBLAFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x626CA40", Offset = "0x626BC40", VA = "0x18626CA40")]
	public static void DLACLAGHNFC(BatchedMeshRenderer LLPAIADCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x626E230", Offset = "0x626D430", VA = "0x18626E230")]
	public static void OIALJOBGKEP(BatchedMeshRenderer LLPAIADCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x626C380", Offset = "0x626B580", VA = "0x18626C380")]
	private static void BEKPKCHNOJL([Out] long NIHHGBFEOHM, [Out] long CNDKJNNPEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x626E2D0", Offset = "0x626D4D0", VA = "0x18626E2D0")]
	public static void ONNFKEHCGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x626DB20", Offset = "0x626CD20", VA = "0x18626DB20")]
	public static void HPMCHMOIOON(GDFECINMGNF EFPOHIGKIGK, BatchedMeshRenderer HGPAOOKIDKK, float GFPJHDGNEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x626CD20", Offset = "0x626BF20", VA = "0x18626CD20")]
	public static void EMHOGIPINND(GDFECINMGNF EFPOHIGKIGK, BatchedMeshRenderer HGPAOOKIDKK, float MPCLBCKNEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x626DA80", Offset = "0x626CC80", VA = "0x18626DA80")]
	public static void HBEGFJCEDGC(GDFECINMGNF EFPOHIGKIGK, BatchedMeshRenderer HGPAOOKIDKK, float MPCLBCKNEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x626C8E0", Offset = "0x626BAE0", VA = "0x18626C8E0")]
	public static void DKDJJHNHALP(GDFECINMGNF EFPOHIGKIGK, BatchedMeshRenderer HGPAOOKIDKK, float GFPJHDGNEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x626CDC0", Offset = "0x626BFC0", VA = "0x18626CDC0")]
	public static void FKEDBGGJOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x626C520", Offset = "0x626B720", VA = "0x18626C520")]
	public static void CHNMJDBMBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x626DD90", Offset = "0x626CF90", VA = "0x18626DD90")]
	public static float LCMBPKLCOEB(long KFIMLHOBGML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x626C710", Offset = "0x626B910", VA = "0x18626C710")]
	public static (long, long) CPLDHANLEGJ(float ICJDGMEMHLE)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x626CF90", Offset = "0x626C190", VA = "0x18626CF90")]
	public static void GMOLFNOALBB(bool KJIEFPJEEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x626E110", Offset = "0x626D310", VA = "0x18626E110")]
	public static int LMFFHLNMHDL()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class LCHPGLKPBOE<KeyType> : GDFECINMGNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly Dictionary<KeyType, FHPCBDOPFEE> HONBPHICFKF;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FBE0", Offset = "0x3D1EDE0", VA = "0x183D1FBE0")]
	public LCHPGLKPBOE(string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FAC0", Offset = "0x3D1ECC0", VA = "0x183D1FAC0")]
	public void OJCBJDHMBMB(KeyType GOBGGNLGONA, FHPCBDOPFEE PBGDFCFGABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F9F0", Offset = "0x3D1EBF0", VA = "0x183D1F9F0")]
	public bool KFJPAHCPIBE(KeyType GOBGGNLGONA, FHPCBDOPFEE EFGLLLHIAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F7E0", Offset = "0x3D1E9E0", VA = "0x183D1F7E0")]
	public void HMHHAGACHEO(KeyType GOBGGNLGONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F7A0", Offset = "0x3D1E9A0", VA = "0x183D1F7A0", Slot = "4")]
	public override void DOMNKINCFNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6272EF0", Offset = "0x62720F0", VA = "0x186272EF0")]
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
