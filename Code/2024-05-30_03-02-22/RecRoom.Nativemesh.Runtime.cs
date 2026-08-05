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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NMACKCLOFPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int KAKFLKOCNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 GEMMEBAPPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion PJLJFJOKKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 AIJCJLNADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int COFJHALALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int HJNOELOMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int HBANHKNKADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float FGCOLKCDJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 LGCLCIJLPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool NKEDDINMDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public MKBOGCCPOLF OJDBJHENGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 FOIDJHFJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float LBKJGEKAABL;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BLKDECCMDKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static MLAOPFGOPGA DOHADPPOFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<NMACKCLOFPM> PEINDDCHGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<NMOEIHLKOJB> MCCIPPFMOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<OAGNFIDNGBF> MDPJMFFNECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<LIEHKAGFPDJ> IOJJJNMFFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<NMOEIHLKOJB> KGBBMHMJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<ONKKJHMOOPE> LAHDECBKHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<LIEHKAGFPDJ>> BNNCEIMMFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<KANKNAPODKJ> KDPOAOGFPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> CJPGDNEHEEC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HOBAKICFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD10540", Offset = "0xD0F740", VA = "0x180D10540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD0F0D0", Offset = "0xD0E2D0", VA = "0x180D0F0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BOGJAJJGCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD10550", Offset = "0xD0F750", VA = "0x180D10550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD0ECD0", Offset = "0xD0DED0", VA = "0x180D0ECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6462AC0", Offset = "0x6461CC0", VA = "0x186462AC0")]
	public BLKDECCMDKP(int ODKDNHODGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64621A0", Offset = "0x64613A0", VA = "0x1864621A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64628F0", Offset = "0x6461AF0", VA = "0x1864628F0")]
	public void PGPPPADIAAB(JobHandle KNINPPAAPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6460F70", Offset = "0x6460170", VA = "0x186460F70")]
	public void CHFMGFLKOLL(NMACKCLOFPM JLJKEBMIIPF, KANKNAPODKJ CFKFBPFOFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64621C0", Offset = "0x64613C0", VA = "0x1864621C0")]
	public void JGAHDIPHDHC(OAGNFIDNGBF JLJKEBMIIPF, NativeArray<LIEHKAGFPDJ> ADEDPDCBGPJ, int KLFJEECIELH, int NMJAALBACJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6461190", Offset = "0x6460390", VA = "0x186461190")]
	public JobHandle DKCHGJOKGEH(FBPCJNPPGNE GNPGAKLPEJE, PNFCDLKODPA DFNNDJIPMKE, float3 PGBDJNKBJHF, quaternion JAOPMEJKBHP, float BCAEDIHFIJO, bool MJKMPNLEJGE, int DAMHMHLHCMM = 0, int MDDALKLCGEK = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6462300", Offset = "0x6461500", VA = "0x186462300")]
	public static JobHandle KEJBMGGMLPL(CBNCKLDOBNI LKJDALBNOAL, FBPCJNPPGNE GNPGAKLPEJE, NMACKCLOFPM JLJKEBMIIPF, JobHandle KNINPPAAPPF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6462640", Offset = "0x6461840", VA = "0x186462640")]
	public static JobHandle MCNFEPKMHKP(GHOBBGFBFAA LKJDALBNOAL, FBPCJNPPGNE GNPGAKLPEJE, OAGNFIDNGBF JLJKEBMIIPF, NativeArray<LIEHKAGFPDJ> ADEDPDCBGPJ, int KLFJEECIELH, int NMJAALBACJK, JobHandle KNINPPAAPPF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class CIMFJBKGKCL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct NEGHODLIFNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half JNPHEIMJIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort KMKKEPCLHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte HOONFNPALNA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public unsafe delegate void APGNJNMKFLG(float3* CBPDEIMGCIG, [In] ushort* JFDJGKCOOCC, int KLFJEECIELH, [In] float3 IICIEPKAAIF, [In] float3 BBHOKHMEMGL);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class DINOOANEOCO
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6467500", Offset = "0x6466700", VA = "0x186467500")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x64676E0", Offset = "0x64668E0", VA = "0x1864676E0")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6467630", Offset = "0x6466830", VA = "0x186467630")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6467840", Offset = "0x6466A40", VA = "0x186467840")]
		public unsafe static void IPKFGEDDFJP(float3* CBPDEIMGCIG, [In] ushort* JFDJGKCOOCC, int KLFJEECIELH, [In] float3 IICIEPKAAIF, [In] float3 BBHOKHMEMGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public unsafe delegate void GECJPFCGGCB(ushort* CBPDEIMGCIG, [Out] float3 PJHIIIBMJFI, [Out] float3 BBHOKHMEMGL, [In] float3* JFDJGKCOOCC, int NFMAHABOEGE, int CMBOPJALLLC);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class IGPEIBNFBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x646CA80", Offset = "0x646BC80", VA = "0x18646CA80")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x646CC60", Offset = "0x646BE60", VA = "0x18646CC60")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x646CBB0", Offset = "0x646BDB0", VA = "0x18646CBB0")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x646CDC0", Offset = "0x646BFC0", VA = "0x18646CDC0")]
		public unsafe static void IPKFGEDDFJP(ushort* CBPDEIMGCIG, [Out] float3 PJHIIIBMJFI, [Out] float3 BBHOKHMEMGL, [In] float3* JFDJGKCOOCC, int NFMAHABOEGE, int CMBOPJALLLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public unsafe delegate void LKIDBPMHCEK(ushort* CMAJGLEKHHN, [In] float3* PNNNFDMFIFP, int CMBOPJALLLC);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal static class ALPHNCPPGCB
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6460640", Offset = "0x645F840", VA = "0x186460640")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6460820", Offset = "0x645FA20", VA = "0x186460820")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6460770", Offset = "0x645F970", VA = "0x186460770")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6460980", Offset = "0x645FB80", VA = "0x186460980")]
		public unsafe static void IPKFGEDDFJP(ushort* CMAJGLEKHHN, [In] float3* PNNNFDMFIFP, int CMBOPJALLLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public unsafe delegate void LFAEGPIJKAE(float3* EMEGEHNMJOG, [In] ushort* PNNNFDMFIFP, int KLFJEECIELH);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class JDPNIIEAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x646F2C0", Offset = "0x646E4C0", VA = "0x18646F2C0")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x646F4A0", Offset = "0x646E6A0", VA = "0x18646F4A0")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x646F3F0", Offset = "0x646E5F0", VA = "0x18646F3F0")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x646F600", Offset = "0x646E800", VA = "0x18646F600")]
		public unsafe static void IPKFGEDDFJP(float3* EMEGEHNMJOG, [In] ushort* PNNNFDMFIFP, int KLFJEECIELH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public unsafe delegate void GNPFFDCOCEJ(ushort* NFAKOBDBIML, [Out] float2 HKLJOONHEMD, [Out] float2 DJBCABFODEO, [In] float2* BAGALGIJAJE, int NFMAHABOEGE, int CMBOPJALLLC);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class PAOKMGJAILL
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64760A0", Offset = "0x64752A0", VA = "0x1864760A0")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6476280", Offset = "0x6475480", VA = "0x186476280")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x64761D0", Offset = "0x64753D0", VA = "0x1864761D0")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x64763E0", Offset = "0x64755E0", VA = "0x1864763E0")]
		public unsafe static void IPKFGEDDFJP(ushort* NFAKOBDBIML, [Out] float2 HKLJOONHEMD, [Out] float2 DJBCABFODEO, [In] float2* BAGALGIJAJE, int NFMAHABOEGE, int CMBOPJALLLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void DHMIONAJLGN([Out] float2 IGNKINGMAIB, ushort INOKKCNGMGM, [In] float2 HKNPEGGEMEK, [In] float2 DJBCABFODEO);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class IOKNMEGGHLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x646D560", Offset = "0x646C760", VA = "0x18646D560")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x646D740", Offset = "0x646C940", VA = "0x18646D740")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x646D690", Offset = "0x646C890", VA = "0x18646D690")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x646D8A0", Offset = "0x646CAA0", VA = "0x18646D8A0")]
		public static void IPKFGEDDFJP([Out] float2 IGNKINGMAIB, ushort INOKKCNGMGM, [In] float2 HKNPEGGEMEK, [In] float2 DJBCABFODEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public unsafe delegate void KHHJIEMHHAM(float2* NFAKOBDBIML, ushort* BAGALGIJAJE, int KLFJEECIELH, [In] float2 HKNPEGGEMEK, [In] float2 DJBCABFODEO);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal static class POPKAJIGHBN
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6476810", Offset = "0x6475A10", VA = "0x186476810")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x64769F0", Offset = "0x6475BF0", VA = "0x1864769F0")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6476940", Offset = "0x6475B40", VA = "0x186476940")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6476B50", Offset = "0x6475D50", VA = "0x186476B50")]
		public unsafe static void IPKFGEDDFJP(float2* NFAKOBDBIML, ushort* BAGALGIJAJE, int KLFJEECIELH, [In] float2 HKNPEGGEMEK, [In] float2 DJBCABFODEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public unsafe delegate void KKCMGPEKKKL(ushort* LFHFLGAPDFG, [In] float4* EBPKPILMOCD, int NFMAHABOEGE, int CMBOPJALLLC);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal static class ICOJAMFACMC
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x646C4F0", Offset = "0x646B6F0", VA = "0x18646C4F0")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x646C6D0", Offset = "0x646B8D0", VA = "0x18646C6D0")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x646C620", Offset = "0x646B820", VA = "0x18646C620")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x646C830", Offset = "0x646BA30", VA = "0x18646C830")]
		public unsafe static void IPKFGEDDFJP(ushort* LFHFLGAPDFG, [In] float4* EBPKPILMOCD, int NFMAHABOEGE, int CMBOPJALLLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate ushort FABONLJIEBD([In] float4 JGNOHJGELCE);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal static class LFMODLGFHOA
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6475030", Offset = "0x6474230", VA = "0x186475030")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6475210", Offset = "0x6474410", VA = "0x186475210")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6475160", Offset = "0x6474360", VA = "0x186475160")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6475370", Offset = "0x6474570", VA = "0x186475370")]
		public static ushort IPKFGEDDFJP([In] float4 JGNOHJGELCE)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public unsafe delegate void HFNDKBOCOKF(float4* LFHFLGAPDFG, [In] ushort* BBPMLBNBJBP, int KLFJEECIELH);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal static class EDHJNMJNKFB
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6469240", Offset = "0x6468440", VA = "0x186469240")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6469420", Offset = "0x6468620", VA = "0x186469420")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6469370", Offset = "0x6468570", VA = "0x186469370")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6469580", Offset = "0x6468780", VA = "0x186469580")]
		public unsafe static void IPKFGEDDFJP(float4* LFHFLGAPDFG, [In] ushort* BBPMLBNBJBP, int KLFJEECIELH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void FDMLJLKDLEP([Out] float4 JBENFHJBMMN, ushort INOKKCNGMGM);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class HOHCIJMOBPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x646BF30", Offset = "0x646B130", VA = "0x18646BF30")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x646C110", Offset = "0x646B310", VA = "0x18646C110")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x646C060", Offset = "0x646B260", VA = "0x18646C060")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x646C270", Offset = "0x646B470", VA = "0x18646C270")]
		public static void IPKFGEDDFJP([Out] float4 JBENFHJBMMN, ushort INOKKCNGMGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public unsafe delegate void BGKCDIKKIMG(float4* CMMJKBEICIM, byte* FLEACCMIJOM, [Out] int KCIFLMAJJLL, [Out] int CKKGALPJLGF, float4* JOKKCLGAEJO, int NFMAHABOEGE, int CMBOPJALLLC);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class EJEKGBFCCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x64697D0", Offset = "0x64689D0", VA = "0x1864697D0")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x64699B0", Offset = "0x6468BB0", VA = "0x1864699B0")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6469900", Offset = "0x6468B00", VA = "0x186469900")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6469B10", Offset = "0x6468D10", VA = "0x186469B10")]
		public unsafe static void IPKFGEDDFJP(float4* CMMJKBEICIM, byte* FLEACCMIJOM, [Out] int KCIFLMAJJLL, [Out] int CKKGALPJLGF, float4* JOKKCLGAEJO, int NFMAHABOEGE, int CMBOPJALLLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public unsafe delegate void LCNAKJHKEDG(float4* AOBLHNELMNH, [In] NEGHODLIFNB* PDEGHCDBAEK, [In] byte* PFMPGAJCHKF, int KLFJEECIELH);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class COFBGBPAGNO
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6466CE0", Offset = "0x6465EE0", VA = "0x186466CE0")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6466EC0", Offset = "0x64660C0", VA = "0x186466EC0")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6466E10", Offset = "0x6466010", VA = "0x186466E10")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6467020", Offset = "0x6466220", VA = "0x186467020")]
		public unsafe static void IPKFGEDDFJP(float4* AOBLHNELMNH, [In] NEGHODLIFNB* PDEGHCDBAEK, [In] byte* PFMPGAJCHKF, int KLFJEECIELH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public unsafe delegate int DENGADNMFKJ(byte* EDLKLAMGLMN, [In] int* BCBELHIIMLD, int BPOPPCBJHFM);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class CMAOJEOJMNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6466720", Offset = "0x6465920", VA = "0x186466720")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6466900", Offset = "0x6465B00", VA = "0x186466900")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6466850", Offset = "0x6465A50", VA = "0x186466850")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6466A60", Offset = "0x6465C60", VA = "0x186466A60")]
		public unsafe static int IPKFGEDDFJP(byte* EDLKLAMGLMN, [In] int* BCBELHIIMLD, int BPOPPCBJHFM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public unsafe delegate void HFDEDLMMIDM(int* BKDCKMNJGOH, [In] byte* BAACFONHOCP, int NMJAALBACJK);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class IOHFCCFJPKG
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x646CFE0", Offset = "0x646C1E0", VA = "0x18646CFE0")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x646D1C0", Offset = "0x646C3C0", VA = "0x18646D1C0")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x646D110", Offset = "0x646C310", VA = "0x18646D110")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x646D320", Offset = "0x646C520", VA = "0x18646D320")]
		public unsafe static void IPKFGEDDFJP(int* BKDCKMNJGOH, [In] byte* BAACFONHOCP, int NMJAALBACJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void DCNIHOCELPN([Out] float3 IGNKINGMAIB, ushort INOKKCNGMGM);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class JEIMGFLEABE
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x646F850", Offset = "0x646EA50", VA = "0x18646F850")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x646FA30", Offset = "0x646EC30", VA = "0x18646FA30")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x646F980", Offset = "0x646EB80", VA = "0x18646F980")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x646FB90", Offset = "0x646ED90", VA = "0x18646FB90")]
		public static void IPKFGEDDFJP([Out] float3 IGNKINGMAIB, ushort INOKKCNGMGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate ushort PKLLFOPDDCD([In] float3 JGNOHJGELCE);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class LMCEGKCOOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr JGNGPCMHMNE;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr GBGDPDDKEAL;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6475580", Offset = "0x6474780", VA = "0x186475580")]
		[BurstDiscard]
		private static void BAEFCLDJDEM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6475760", Offset = "0x6474960", VA = "0x186475760")]
		private static IntPtr ICFPCPJGIOK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x64756B0", Offset = "0x64748B0", VA = "0x1864756B0")]
		public static void DJNOPPGBNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public static void CNOOLEDIEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x64758C0", Offset = "0x6474AC0", VA = "0x1864758C0")]
		public static ushort IPKFGEDDFJP([In] float3 JGNOHJGELCE)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int KLFJEECIELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int NMJAALBACJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> CAPLDKNBNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> BACMHADEMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> KENFHEBDBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> MFENPCFHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<NEGHODLIFNB> MBKBKJAKEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> BBHJKHLAHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> PMDLHGKDDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 IICIEPKAAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 BBHOKHMEMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 HKNPEGGEMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 DJBCABFODEO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long DNMJLMLHPPC;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long LJJOOEBCFFC;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float NADGHCIMENN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool GFGEKCLJOEE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PEJFDHEMNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6465D40", Offset = "0x6464F40", VA = "0x186465D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6466580", Offset = "0x6465780", VA = "0x186466580")]
	public void PGPPPADIAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6462EB0", Offset = "0x64620B0", VA = "0x186462EB0")]
	public static CIMFJBKGKCL ADOMMGOMPJC(Allocator LGNDPBNMKMP, FBPCJNPPGNE DGIGOIFEMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64630F0", Offset = "0x64622F0", VA = "0x1864630F0")]
	public static CIMFJBKGKCL ADOMMGOMPJC(Allocator LGNDPBNMKMP, NativeArray<float3> JFDJGKCOOCC, NativeArray<float3> PNNNFDMFIFP, NativeArray<float2> BAGALGIJAJE, NativeArray<float4> JOKKCLGAEJO, bool BNBJMACNLBO, NativeArray<float4> BBPMLBNBJBP, NativeArray<int> BCBELHIIMLD, int KLFJEECIELH, int GEFHAJPBJOJ, int NMJAALBACJK, int NFMAHABOEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6464200", Offset = "0x6463400", VA = "0x186464200")]
	public FBPCJNPPGNE CHMNAPKBCPJ(Allocator LGNDPBNMKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6464FC0", Offset = "0x64641C0", VA = "0x186464FC0")]
	public void FLMHCNBANMH(Mesh COKNMDIBDNP, bool MIAFABJPKHK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6465B40", Offset = "0x6464D40", VA = "0x186465B40")]
	public long KDKDLCEDEBL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64658B0", Offset = "0x6464AB0", VA = "0x1864658B0")]
	public static long IMCOFCHAFME(int BBBNMJNEMAL, int ENMBGLOLEHO, bool FICDHEPMLNK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6465820", Offset = "0x6464A20", VA = "0x186465820")]
	public long IMCOFCHAFME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6465C30", Offset = "0x6464E30", VA = "0x186465C30")]
	private void KNDKEEBKAEP(int EEKCCPEHAHL, int CMBOPJALLLC, Allocator LGNDPBNMKMP, bool AKHMCPAGCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6465380", Offset = "0x6464580", VA = "0x186465380")]
	private void HKIPNHDJDAF(NativeArray<float3> CBPDEIMGCIG, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6465480", Offset = "0x6464680", VA = "0x186465480")]
	[BurstCompile]
	private unsafe static void HKIPNHDJDAF(float3* CBPDEIMGCIG, [In] ushort* JFDJGKCOOCC, int KLFJEECIELH, [In] float3 IICIEPKAAIF, [In] float3 BBHOKHMEMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6464C10", Offset = "0x6463E10", VA = "0x186464C10")]
	private void DDDOLJFOOKG(NativeArray<float3> JFDJGKCOOCC, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6464B80", Offset = "0x6463D80", VA = "0x186464B80")]
	[BurstCompile]
	private unsafe static void DDDOLJFOOKG(ushort* CBPDEIMGCIG, [Out] float3 PJHIIIBMJFI, [Out] float3 BBHOKHMEMGL, [In] float3* JFDJGKCOOCC, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x64638C0", Offset = "0x6462AC0", VA = "0x1864638C0")]
	private void BAADBBGFHLH(NativeArray<float3> PNNNFDMFIFP, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x64636A0", Offset = "0x64628A0", VA = "0x1864636A0")]
	[BurstCompile]
	private unsafe static void BAADBBGFHLH(ushort* CMAJGLEKHHN, [In] float3* PNNNFDMFIFP, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6466200", Offset = "0x6465400", VA = "0x186466200")]
	private void NOEBJNFAICC(NativeArray<float3> EMEGEHNMJOG, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x64662D0", Offset = "0x64654D0", VA = "0x1864662D0")]
	[BurstCompile]
	private unsafe static void NOEBJNFAICC(float3* EMEGEHNMJOG, [In] ushort* PNNNFDMFIFP, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6465500", Offset = "0x6464700", VA = "0x186465500")]
	private void IGDOJIDKFHI(NativeArray<float2> BAGALGIJAJE, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x64655D0", Offset = "0x64647D0", VA = "0x1864655D0")]
	[BurstCompile]
	private unsafe static void IGDOJIDKFHI(ushort* NFAKOBDBIML, [Out] float2 HKLJOONHEMD, [Out] float2 DJBCABFODEO, [In] float2* BAGALGIJAJE, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6464DB0", Offset = "0x6463FB0", VA = "0x186464DB0")]
	[BurstCompile]
	private static void EJCBBHFMHNL([Out] float2 IGNKINGMAIB, ushort INOKKCNGMGM, [In] float2 HKNPEGGEMEK, [In] float2 DJBCABFODEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x64663C0", Offset = "0x64655C0", VA = "0x1864663C0")]
	private void OBEPBAMGDKA(NativeArray<float2> NFAKOBDBIML, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6466340", Offset = "0x6465540", VA = "0x186466340")]
	[BurstCompile]
	private unsafe static void OBEPBAMGDKA(float2* NFAKOBDBIML, ushort* BAGALGIJAJE, int KLFJEECIELH, [In] float2 HKNPEGGEMEK, [In] float2 DJBCABFODEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6463A00", Offset = "0x6462C00", VA = "0x186463A00")]
	private void BBPPHJIEFML(NativeArray<float4> BBPMLBNBJBP, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6463980", Offset = "0x6462B80", VA = "0x186463980")]
	[BurstCompile]
	private unsafe static void BBPPHJIEFML(ushort* LFHFLGAPDFG, [In] float4* EBPKPILMOCD, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6462E60", Offset = "0x6462060", VA = "0x186462E60")]
	[BurstCompile]
	private static ushort ADLBNHHAEED([In] float4 JGNOHJGELCE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x64650A0", Offset = "0x64642A0", VA = "0x1864650A0")]
	private void FPIBFFLAJAB(NativeArray<float4> LFHFLGAPDFG, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6465170", Offset = "0x6464370", VA = "0x186465170")]
	[BurstCompile]
	private unsafe static void FPIBFFLAJAB(float4* LFHFLGAPDFG, [In] ushort* BBPMLBNBJBP, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6465320", Offset = "0x6464520", VA = "0x186465320")]
	[BurstCompile]
	private static void GMEBEIBJJMH([Out] float4 JBENFHJBMMN, ushort INOKKCNGMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6463AF0", Offset = "0x6462CF0", VA = "0x186463AF0")]
	private void BENBDADEKEE(Allocator LGNDPBNMKMP, NativeArray<float4> JOKKCLGAEJO, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6463ED0", Offset = "0x64630D0", VA = "0x186463ED0")]
	[BurstCompile]
	private unsafe static void BENBDADEKEE(float4* CMMJKBEICIM, byte* FLEACCMIJOM, [Out] int KCIFLMAJJLL, [Out] int CKKGALPJLGF, float4* JOKKCLGAEJO, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6464A70", Offset = "0x6463C70", VA = "0x186464A70")]
	private static void CODEJPNOLGC(NativeArray<float4> AOBLHNELMNH, NativeArray<NEGHODLIFNB> PDEGHCDBAEK, NativeArray<byte> PFMPGAJCHKF, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x64649F0", Offset = "0x6463BF0", VA = "0x1864649F0")]
	[BurstCompile]
	private unsafe static void CODEJPNOLGC(float4* AOBLHNELMNH, [In] NEGHODLIFNB* PDEGHCDBAEK, [In] byte* PFMPGAJCHKF, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x64635C0", Offset = "0x64627C0", VA = "0x1864635C0")]
	private void ANGNJPCIDHB(Allocator LGNDPBNMKMP, NativeArray<int> BCBELHIIMLD, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6465D80", Offset = "0x6464F80", VA = "0x186465D80")]
	private static NativeArray<byte> NGNJIIPBLPH(Allocator LGNDPBNMKMP, NativeArray<int> BCBELHIIMLD, int BPOPPCBJHFM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6465FF0", Offset = "0x64651F0", VA = "0x186465FF0")]
	[BurstCompile]
	private unsafe static int NGNJIIPBLPH(byte* EDLKLAMGLMN, [In] int* BCBELHIIMLD, int BPOPPCBJHFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6464E30", Offset = "0x6464030", VA = "0x186464E30")]
	private static void EJIHIDDHEPK(NativeArray<int> BKDCKMNJGOH, NativeArray<byte> BAACFONHOCP, int NMJAALBACJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6464F00", Offset = "0x6464100", VA = "0x186464F00")]
	[BurstCompile]
	private unsafe static void EJIHIDDHEPK(int* BKDCKMNJGOH, [In] byte* BAACFONHOCP, int NMJAALBACJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6465BD0", Offset = "0x6464DD0", VA = "0x186465BD0")]
	[BurstCompile]
	private static void KKBHKBPGLBP([Out] float3 IGNKINGMAIB, ushort INOKKCNGMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x64647E0", Offset = "0x64639E0", VA = "0x1864647E0")]
	[BurstCompile]
	private static ushort CNHCJOCFBHK([In] float3 JGNOHJGELCE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public CIMFJBKGKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6458D70", Offset = "0x6457F70", VA = "0x186458D70")]
	[BurstCompile]
	public unsafe static void KFJEJNBAGHH(float3* CBPDEIMGCIG, [In] ushort* JFDJGKCOOCC, int KLFJEECIELH, [In] float3 IICIEPKAAIF, [In] float3 BBHOKHMEMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6458990", Offset = "0x6457B90", VA = "0x186458990")]
	[BurstCompile]
	public unsafe static void JCDCAPMOOLE(ushort* CBPDEIMGCIG, [Out] float3 PJHIIIBMJFI, [Out] float3 BBHOKHMEMGL, [In] float3* JFDJGKCOOCC, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6458730", Offset = "0x6457930", VA = "0x186458730")]
	[BurstCompile]
	public unsafe static void FPBDOIHNJBD(ushort* CMAJGLEKHHN, [In] float3* PNNNFDMFIFP, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6465900", Offset = "0x6464B00", VA = "0x186465900")]
	[BurstCompile]
	public unsafe static void JJDIOKMIBME(float3* EMEGEHNMJOG, [In] ushort* PNNNFDMFIFP, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6458470", Offset = "0x6457670", VA = "0x186458470")]
	[BurstCompile]
	public unsafe static void BMEBBLBIHKJ(ushort* NFAKOBDBIML, [Out] float2 HKLJOONHEMD, [Out] float2 DJBCABFODEO, [In] float2* BAGALGIJAJE, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6464F70", Offset = "0x6464170", VA = "0x186464F70")]
	[BurstCompile]
	public static void FKCLIEGGCDM([Out] float2 IGNKINGMAIB, ushort INOKKCNGMGM, [In] float2 HKNPEGGEMEK, [In] float2 DJBCABFODEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6464120", Offset = "0x6463320", VA = "0x186464120")]
	[BurstCompile]
	public unsafe static void BMCBCCGIILP(float2* NFAKOBDBIML, ushort* BAGALGIJAJE, int KLFJEECIELH, [In] float2 HKNPEGGEMEK, [In] float2 DJBCABFODEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6464D10", Offset = "0x6463F10", VA = "0x186464D10")]
	[BurstCompile]
	public unsafe static void ECIGJMPKFAN(ushort* LFHFLGAPDFG, [In] float4* EBPKPILMOCD, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6466060", Offset = "0x6465260", VA = "0x186466060")]
	[BurstCompile]
	public static ushort NIMFMOLAFJI([In] float4 JGNOHJGELCE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6466680", Offset = "0x6465880", VA = "0x186466680")]
	[BurstCompile]
	public unsafe static void POJKCIJBJJK(float4* LFHFLGAPDFG, [In] ushort* BBPMLBNBJBP, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x64664C0", Offset = "0x64656C0", VA = "0x1864664C0")]
	[BurstCompile]
	public static void PAKBPJAAKNO([Out] float4 JBENFHJBMMN, ushort INOKKCNGMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6459180", Offset = "0x6458380", VA = "0x186459180")]
	[BurstCompile]
	public unsafe static void PAGGHOANHOL(float4* CMMJKBEICIM, byte* FLEACCMIJOM, [Out] int KCIFLMAJJLL, [Out] int CKKGALPJLGF, float4* JOKKCLGAEJO, int NFMAHABOEGE, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x64660C0", Offset = "0x64652C0", VA = "0x1864660C0")]
	[BurstCompile]
	public unsafe static void NMAIGCAOPAP(float4* AOBLHNELMNH, [In] NEGHODLIFNB* PDEGHCDBAEK, [In] byte* PFMPGAJCHKF, int KLFJEECIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6465A40", Offset = "0x6464C40", VA = "0x186465A40")]
	[BurstCompile]
	public unsafe static int KDIOJBMNPJC(byte* EDLKLAMGLMN, [In] int* BCBELHIIMLD, int BPOPPCBJHFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x64659A0", Offset = "0x6464BA0", VA = "0x1864659A0")]
	[BurstCompile]
	public unsafe static void KBIAKMJEIGC(int* BKDCKMNJGOH, [In] byte* BAACFONHOCP, int NMJAALBACJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x64651E0", Offset = "0x64643E0", VA = "0x1864651E0")]
	[BurstCompile]
	public static void GKGDCHLCKNG([Out] float3 IGNKINGMAIB, ushort INOKKCNGMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6458FC0", Offset = "0x64581C0", VA = "0x186458FC0")]
	[BurstCompile]
	public static ushort ONMLABLGBEE([In] float3 JGNOHJGELCE)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CHEPMPMIAAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float2 DJNLHOOGNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float2 BONJNMKEEEJ;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ALPMDIIMDEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<CHEPMPMIAAF> OFGCFCAJFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<int> FEJNFOENJIL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HOBAKICFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BOGJAJJGCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFF0", Offset = "0x7CD1F0", VA = "0x1807CDFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6460CB0", Offset = "0x645FEB0", VA = "0x186460CB0")]
	public ALPMDIIMDEO(int EEKCCPEHAHL, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6460B70", Offset = "0x645FD70", VA = "0x186460B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6460BD0", Offset = "0x645FDD0", VA = "0x186460BD0")]
	public void FMKPBENDBJE(ALPMDIIMDEO GDCHOBNEDKF, int ODAIGGKJLDM, int CJICFAPMKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IPIKDNPJCDK
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static ALPMDIIMDEO EECOJMLKNBF;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static NativeList<NMOEIHLKOJB> PDNLPIPCKGF;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static int[] MOIJHGGCPKK;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static bool OKIMEHGGFHE;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, ALPMDIIMDEO> NBCCACMJHEM;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, ALPMDIIMDEO> EKCKIPKHBKA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool IOCFJJMLGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x646F010", Offset = "0x646E210", VA = "0x18646F010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<NMOEIHLKOJB> HMLKJMPAJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x646E010", Offset = "0x646D210", VA = "0x18646E010")]
		get
		{
			return default(NativeList<NMOEIHLKOJB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static ALPMDIIMDEO BPELNAKPANH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x646DCB0", Offset = "0x646CEB0", VA = "0x18646DCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x646E5F0", Offset = "0x646D7F0", VA = "0x18646E5F0")]
	private static void JJLAKILNELE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x646DC80", Offset = "0x646CE80", VA = "0x18646DC80")]
	public static int CCJGGJLJHFO(bool EKMOCHKJIKL, int KELBLBJNBMC, bool NPIEFEONFIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x646F090", Offset = "0x646E290", VA = "0x18646F090")]
	private static int OGMLJJEJGFI(int KELBLBJNBMC, bool FBOOKEGBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x646F140", Offset = "0x646E340", VA = "0x18646F140")]
	private static int OLLGHIHOPEG(int KELBLBJNBMC, bool FBOOKEGBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x646E4E0", Offset = "0x646D6E0", VA = "0x18646E4E0")]
	public static int IFJBEOLNIAD(int IMEBMAMHMJD, int KELBLBJNBMC, int HHKECDDOHLO, bool FBOOKEGBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x646F0B0", Offset = "0x646E2B0", VA = "0x18646F0B0")]
	public static int OJOKBFGKDCK(int IMEBMAMHMJD, int KELBLBJNBMC, int HHKECDDOHLO, bool FBOOKEGBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x646E000", Offset = "0x646D200", VA = "0x18646E000")]
	public static int GDLKLFEPDNL(int HHKECDDOHLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x646E570", Offset = "0x646D770", VA = "0x18646E570")]
	private static int INBOBINGBGK(int KELBLBJNBMC, bool FBOOKEGBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x646DAE0", Offset = "0x646CCE0", VA = "0x18646DAE0")]
	private static int AEBPNNBJBPG(int KELBLBJNBMC, bool FBOOKEGBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x646E580", Offset = "0x646D780", VA = "0x18646E580")]
	public static int INNLFDPLCND(int IMEBMAMHMJD, int KELBLBJNBMC, int HHKECDDOHLO, bool FBOOKEGBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x646DB00", Offset = "0x646CD00", VA = "0x18646DB00")]
	public static int BHAJOACMMEL(int IMEBMAMHMJD, int KELBLBJNBMC, int HHKECDDOHLO, bool FBOOKEGBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x646DD50", Offset = "0x646CF50", VA = "0x18646DD50")]
	public static int FFLPCCDGEOC(int HHKECDDOHLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x646DB90", Offset = "0x646CD90", VA = "0x18646DB90")]
	public static ALPMDIIMDEO BNDLOEDIADA(int KELBLBJNBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x646DD70", Offset = "0x646CF70", VA = "0x18646DD70")]
	private static ALPMDIIMDEO FLNOBNBMCIA(int KELBLBJNBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x646E0B0", Offset = "0x646D2B0", VA = "0x18646E0B0")]
	public static ALPMDIIMDEO HBCLDOPEGEN(int KELBLBJNBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x646E1A0", Offset = "0x646D3A0", VA = "0x18646E1A0")]
	private static ALPMDIIMDEO IBNNFGNEJAC(int KELBLBJNBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x646EC00", Offset = "0x646DE00", VA = "0x18646EC00")]
	public static void MANENJEHFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct OAGNFIDNGBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int DMHLDPGBDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 GEMMEBAPPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion PJLJFJOKKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float AIJCJLNADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float KMCMKIMDANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int COFJHALALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int HJNOELOMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int HBANHKNKADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool GNCFDNKIDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool EKJONKGBABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float FGCOLKCDJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 LGCLCIJLPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool MOMAIJKAIJH;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct ONKKJHMOOPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int EDLHGAGDMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int APDJJCNCFMK;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct GHOBBGFBFAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NativeList<OAGNFIDNGBF> CAIJEBEIDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeArray<LIEHKAGFPDJ> FEAJAFDEOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<NMOEIHLKOJB> BCKAGCBGHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<ONKKJHMOOPE> MLMFKJFGGFB;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x646BD00", Offset = "0x646AF00", VA = "0x18646BD00")]
	public GHOBBGFBFAA(NativeArray<LIEHKAGFPDJ> FEAJAFDEOGC, int AGHIAPEPFJE = 1, Allocator LGNDPBNMKMP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x646BC10", Offset = "0x646AE10", VA = "0x18646BC10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
public struct KGNCCKMGPKD : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<CHEPMPMIAAF> GEHBBCIEPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<int> GPNOJAOOOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeList<NMOEIHLKOJB> IMOAJJJGFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<OAGNFIDNGBF> CAIJEBEIDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<LIEHKAGFPDJ> FEAJAFDEOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<NMOEIHLKOJB> BCKAGCBGHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<ONKKJHMOOPE> MLMFKJFGGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private int ENGLKIGCFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int ELADJHGBOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float3 PKPMPBJOHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private quaternion OEPILMIOBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 MNPMFKFNAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LAFBJDGNOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BBBCNLOAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EOEFOCHLKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NAKFAJGOFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> HCDCHLKAGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CLPCJPHPKLF;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6474BA0", Offset = "0x6473DA0", VA = "0x186474BA0")]
	public KGNCCKMGPKD(BLKDECCMDKP NPHJJLHAPLD, FBPCJNPPGNE EPHPHFPPCAE, float3 CCDDNHPPLGI, quaternion PFEDPCAGLNJ, float PDOIGGFGKHP, int DAMHMHLHCMM = 0, int MDDALKLCGEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6474970", Offset = "0x6473B70", VA = "0x186474970")]
	public KGNCCKMGPKD(GHOBBGFBFAA NPHJJLHAPLD, FBPCJNPPGNE EPHPHFPPCAE, float3 CCDDNHPPLGI, quaternion PFEDPCAGLNJ, float3 PDOIGGFGKHP, int DAMHMHLHCMM = 0, int MDDALKLCGEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6474840", Offset = "0x6473A40", VA = "0x186474840")]
	private float3 PKOLFEKCIMD(float3 BGFFLCDCIOJ, Matrix4x4 ACJOHMDFHNG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x64741E0", Offset = "0x64733E0", VA = "0x1864741E0")]
	private float3x3 FFNGOEACOPL(float3x3 GALOHCOEIBJ, float3x3 NBHAPCEEIIP)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6474260", Offset = "0x6473460", VA = "0x186474260")]
	private float GDEDIFKMHEH(float MGKBJKPBCFA, float FFLLAPMMHAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6473040", Offset = "0x6472240", VA = "0x186473040", Slot = "4")]
	public void Execute(int EBLANDPJDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x64746D0", Offset = "0x64738D0", VA = "0x1864746D0")]
	private void OKMHMMBIPML(int EJBEIEBCHJK, float3 CAOOPLKANIG, float3 BGIIKDPIDDB, float3 MBNLKPDJGPN, float HMEOAAPKBEC, bool CHLCMLIGNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6474270", Offset = "0x6473470", VA = "0x186474270")]
	private void MLEAFKNJHCF(OAGNFIDNGBF BCNPEFKKJJI, float3 AMCKGDEABAD, float3x3 HKEEEIOLJKM, float MGKBJKPBCFA, int HFJGPPFDPJH, int FINCMHGBBPF, int GLBNMKNOAOH, float GNHEACLMDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x64729F0", Offset = "0x6471BF0", VA = "0x1864729F0")]
	private void EGFEKBEANIL(int EJBEIEBCHJK, int NKLPLPKENAP, OAGNFIDNGBF BCNPEFKKJJI, float3 AMCKGDEABAD, float3x3 HKEEEIOLJKM, bool MICEHOLIEDC, float MGKBJKPBCFA, int NLAAEOMLKED, int EOEOKAFIHID, int GLBNMKNOAOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CBNCKLDOBNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeList<NMACKCLOFPM> LMJEILFLJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeList<NMOEIHLKOJB> IHHKLDNOKPK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6462D70", Offset = "0x6461F70", VA = "0x186462D70")]
	public CBNCKLDOBNI(int AGHIAPEPFJE, Allocator LGNDPBNMKMP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6462CD0", Offset = "0x6461ED0", VA = "0x186462CD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
public struct EBJMMELFJMM : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private enum IPKBMCENOHI
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
	private NativeList<float3> KONIOKCDHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private NativeArray<float3> MDIKKOBJNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private NativeList<int> ACJDFLOCEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeArray<int> KLHFBDFBFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeArray<float4> JKHDJLIBKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeArray<float4> KPJBABIDNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<float4> DOMCPLLMCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<float3> HGFMGEMDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private NativeList<NMOEIHLKOJB> CMINLHPOKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private NativeList<NMACKCLOFPM> LMJEILFLJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private NativeList<NMOEIHLKOJB> IHHKLDNOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private int ENGLKIGCFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private int ELADJHGBOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LAFBJDGNOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BBBCNLOAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EOEFOCHLKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NAKFAJGOFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> HCDCHLKAGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CLPCJPHPKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private float3 MNPMFKFNAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private quaternion OEPILMIOBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 PKPMPBJOHJH;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6469050", Offset = "0x6468250", VA = "0x186469050")]
	public EBJMMELFJMM(BLKDECCMDKP NPHJJLHAPLD, FBPCJNPPGNE EPHPHFPPCAE, float3 CCDDNHPPLGI, quaternion PFEDPCAGLNJ, float PDOIGGFGKHP, int DAMHMHLHCMM = 0, int MDDALKLCGEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6468E60", Offset = "0x6468060", VA = "0x186468E60")]
	public EBJMMELFJMM(CBNCKLDOBNI JLJKEBMIIPF, FBPCJNPPGNE EPHPHFPPCAE, float3 CCDDNHPPLGI, quaternion PFEDPCAGLNJ, float3 PDOIGGFGKHP, int DAMHMHLHCMM = 0, int MDDALKLCGEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6467E00", Offset = "0x6467000", VA = "0x186467E00", Slot = "4")]
	public void Execute(int EBLANDPJDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6467A50", Offset = "0x6466C50", VA = "0x186467A50")]
	private void CJOLNJBKJML(float4x4 LFDBOGKPJGC, int EBLANDPJDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6468D60", Offset = "0x6467F60", VA = "0x186468D60")]
	private IPKBMCENOHI GEOCFEGNPJI(float3 BGIIKDPIDDB)
	{
		return default(IPKBMCENOHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6468DD0", Offset = "0x6467FD0", VA = "0x186468DD0")]
	private float4 HHCPLCDODPP(IPKBMCENOHI BOECFDJCIBM, int PMNHOLIPOMJ)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6468E20", Offset = "0x6468020", VA = "0x186468E20")]
	private float2 NMFABFJEPDG(IPKBMCENOHI BOECFDJCIBM, float3 CAOOPLKANIG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KANKNAPODKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum CMHAEPEMKBI
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static KANKNAPODKJ NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public float3 HFHFPGFAPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public float3x3 HFLDDHFJBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public float3 BGCPNAGJMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public CMHAEPEMKBI GADMEDLKBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 GCIPAJDNOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 MGIGLMLDJOJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DOILPLLJOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6471F20", Offset = "0x6471120", VA = "0x186471F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 EPIBGOODDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6472020", Offset = "0x6471220", VA = "0x186472020")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x64727B0", Offset = "0x64719B0", VA = "0x1864727B0")]
	public KANKNAPODKJ(float3 CAOOPLKANIG, quaternion JCCMNAMJFGM, float3 AGHIAPEPFJE, CMHAEPEMKBI HHJOOHJDNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6472100", Offset = "0x6471300", VA = "0x186472100")]
	public float HCFEMONEMCM(float3 AMCKGDEABAD, float LNCDIGNEIJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6471F30", Offset = "0x6471130", VA = "0x186471F30")]
	public bool FEHPIPPDPHH(float3 BGIIKDPIDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6472590", Offset = "0x6471790", VA = "0x186472590")]
	public void OJECLCIENBM(float3 NDMNGPGNFCG, float3x3 FBAAGJCPIBC, float JLNELAHPOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6471E20", Offset = "0x6471020", VA = "0x186471E20")]
	private void AKKDFKIIFML(float3 OGPMBFEEKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6472300", Offset = "0x6471500", VA = "0x186472300")]
	public void IFOJFMHNGKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
public struct JIOKBLPJPLM : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeList<KANKNAPODKJ> JLJKEBMIIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeList<float3> CAPLDKNBNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<int> PMDLHGKDDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CJPGDNEHEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<NMOEIHLKOJB> IHHKLDNOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private int BBLNIBGIGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int JNCIIDFFFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private float LNCDIGNEIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private float DDNCFNKIKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> BDOKGONLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> NDAENCHGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> PPMMHHHAAOE;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6470990", Offset = "0x646FB90", VA = "0x186470990")]
	public JIOKBLPJPLM(FBPCJNPPGNE COKNMDIBDNP, float CJALIDFMGPD, int CJICFAPMKCE, int HFJGPPFDPJH, NativeList<KANKNAPODKJ> JLJKEBMIIPF, NativeArray<int> CJPGDNEHEEC, NativeList<NMOEIHLKOJB> IHHKLDNOKPK, PNFCDLKODPA DFNNDJIPMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x646FFB0", Offset = "0x646F1B0", VA = "0x18646FFB0", Slot = "4")]
	public void Execute(int HLLIAOBMBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x646FEF0", Offset = "0x646F0F0", VA = "0x18646FEF0")]
	private bool BNLOFOKNJPG(KANKNAPODKJ BPOHBPAMNLC, KANKNAPODKJ NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x64706F0", Offset = "0x646F8F0", VA = "0x1864706F0")]
	private bool KKMLHINLJNO(KANKNAPODKJ PIKGAJBAGIE, int ENPCOFMHLIA, int NKGMDJLOJDO, int POKMDFKKANC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class PNFCDLKODPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<bool> BICKJBKOOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<int> FALFDCIDGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<bool> OGAEMGMGDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float> EFANCPPKBCO;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6476620", Offset = "0x6475820", VA = "0x186476620")]
	public void KNDKEEBKAEP(int EEKCCPEHAHL, int CMBOPJALLLC, Allocator LGNDPBNMKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6476600", Offset = "0x6475800", VA = "0x186476600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6476720", Offset = "0x6475920", VA = "0x186476720")]
	public void PGPPPADIAAB(JobHandle KNINPPAAPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public PNFCDLKODPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
public struct GGHGKCCMHBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NativeList<float3> CAPLDKNBNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NativeArray<float3> BACMHADEMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private NativeArray<float4> MBKBKJAKEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeArray<float2> MFENPCFHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private NativeList<int> PMDLHGKDDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KENFHEBDBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<int> JCDFPLIMDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeArray<bool> BDOKGONLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<bool> NDAENCHGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private int DAMHMHLHCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private int MDDALKLCGEK;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x646BB90", Offset = "0x646AD90", VA = "0x18646BB90")]
	public GGHGKCCMHBP(FBPCJNPPGNE COKNMDIBDNP, PNFCDLKODPA DFNNDJIPMKE, int MDDALKLCGEK = 0, int DAMHMHLHCMM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x646B750", Offset = "0x646A950", VA = "0x18646B750", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x646BB30", Offset = "0x646AD30", VA = "0x18646BB30")]
	private void IPKELKLOAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class IIHBLMOAOND
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x29D83F0", Offset = "0x29D75F0", VA = "0x1829D83F0")]
	public static bool EIHFHHLBIBJ<T>(NativeArray<T> HPGKNFECNHG, int AGHIAPEPFJE, Allocator LGNDPBNMKMP, NativeArrayOptions PPBCABJPHLO = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x29D8530", Offset = "0x29D7730", VA = "0x1829D8530")]
	public static bool EIHFHHLBIBJ<T>(NativeList<T> AIMBMINBCPM, int AGHIAPEPFJE, Allocator LGNDPBNMKMP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum FAJEAHMKGJD
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
public interface HBFFDCAHNHG
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JOGDFDJGOEF(FAJEAHMKGJD IMEBMAMHMJD);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KBINDIMKHCM(FAJEAHMKGJD IMEBMAMHMJD);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds FIHOIPMOHCC();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float LOFBBOPBMLC();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODADOICKMGN(FAJEAHMKGJD IMEBMAMHMJD, BLKDECCMDKP MDGIAKJGMPA, int NOKGGPHEOBG = -1);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FBPCJNPPGNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const int MFAFNLKFPNF = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NativeList<float3> PGGCDEEGOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public NativeArray<float3> HEHAMINKGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public NativeArray<float4> BMOAFDOJBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public NativeArray<float4> NFMCMFEKOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeArray<float2> LKDHIHBLGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<int> FKOKOGFBJID;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KPPCPAJJDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6469D70", Offset = "0x6468F70", VA = "0x186469D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HOBAKICFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6469D30", Offset = "0x6468F30", VA = "0x186469D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BOGJAJJGCPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x646AE90", Offset = "0x646A090", VA = "0x18646AE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PEJFDHEMNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x646AE50", Offset = "0x646A050", VA = "0x18646AE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x646A3E0", Offset = "0x64695E0", VA = "0x18646A3E0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x646AC80", Offset = "0x6469E80", VA = "0x18646AC80")]
	public void KNDKEEBKAEP(int EEKCCPEHAHL, int CMBOPJALLLC, Allocator LGNDPBNMKMP, bool AKPNPCOGEIE, bool AKHMCPAGCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x646B070", Offset = "0x646A270", VA = "0x18646B070")]
	public void OHPACKOKPCM(int EEKCCPEHAHL, int CMBOPJALLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x646A760", Offset = "0x6469960", VA = "0x18646A760", Slot = "6")]
	public bool GOLOMLOCEGO(Mesh COKNMDIBDNP, bool MIAFABJPKHK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6469DB0", Offset = "0x6468FB0", VA = "0x186469DB0")]
	public bool DAFABHLHIKO(Mesh COKNMDIBDNP, FBPCJNPPGNE CGIMKJKIMFH, bool MIAFABJPKHK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x646A4F0", Offset = "0x64696F0", VA = "0x18646A4F0")]
	public void FMKPBENDBJE(FBPCJNPPGNE COKNMDIBDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x646AED0", Offset = "0x646A0D0", VA = "0x18646AED0")]
	public FBPCJNPPGNE NJPJPNDOPCO(Allocator LGNDPBNMKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x646AB40", Offset = "0x6469D40", VA = "0x18646AB40")]
	public long KDKDLCEDEBL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x646B010", Offset = "0x646A210", VA = "0x18646B010")]
	public void NOAMFJNBLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FBPCJNPPGNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KEKNONNJGJF
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x64728A0", Offset = "0x6471AA0", VA = "0x1864728A0")]
	public static void MANENJEHFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class JNKPEGBIDAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<float3> PGGCDEEGOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<float3> HEHAMINKGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<int> KGBKAJGCPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<float4> LBALBLNFMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<float4> BFNHAJNDJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float4> MFMEIBOKBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public NativeList<float3> FDLJPCJEDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public NativeList<int> FKOKOGFBJID;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HOBAKICFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6470A30", Offset = "0x646FC30", VA = "0x186470A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BOGJAJJGCPO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x64718D0", Offset = "0x6470AD0", VA = "0x1864718D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PAEBIGHOPFC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6470B80", Offset = "0x646FD80", VA = "0x186470B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6471C00", Offset = "0x6470E00", VA = "0x186471C00")]
	public JNKPEGBIDAM(int EEKCCPEHAHL, int CMBOPJALLLC, int IDJMKCGPPEL, Allocator LGNDPBNMKMP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6471910", Offset = "0x6470B10", VA = "0x186471910")]
	public JNKPEGBIDAM(Mesh COKNMDIBDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6470A70", Offset = "0x646FC70", VA = "0x186470A70", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6470BC0", Offset = "0x646FDC0", VA = "0x186470BC0")]
	public void FMKPBENDBJE(JNKPEGBIDAM COKNMDIBDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6470EC0", Offset = "0x64700C0", VA = "0x186470EC0")]
	private void GBIMGIDIADP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6471350", Offset = "0x6470550", VA = "0x186471350")]
	private void GMCBENDENGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct NMOEIHLKOJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public int DDMKJIHLDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public int HOBAKICFGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public int BHPAACBAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public int BOGJAJJGCPO;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1323FC0", Offset = "0x13231C0", VA = "0x181323FC0")]
	public NMOEIHLKOJB(int HFJGPPFDPJH, int KLFJEECIELH, int CJICFAPMKCE, int NMJAALBACJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class MLAOPFGOPGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<NMOEIHLKOJB> HIEOIAGBGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<NMOEIHLKOJB>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8E5680", Offset = "0x8E4880", VA = "0x1808E5680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JNKPEGBIDAM NDBAHHNICBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6475B00", Offset = "0x6474D00", VA = "0x186475B00")]
	public MLAOPFGOPGA(IEnumerable<JNKPEGBIDAM> ODAEDPFMKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6475A90", Offset = "0x6474C90", VA = "0x186475A90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum MKBOGCCPOLF
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FPKHFCMHMHA
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static NativeArray<float2> FODALEFJGME;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static NativeArray<float3> GFPGNOCMOFK;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static NativeArray<float4> FBFBKELLFEJ;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static NativeArray<int> EKEAEMDJGPB;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x646B200", Offset = "0x646A400", VA = "0x18646B200")]
	public static void MANENJEHFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x646B430", Offset = "0x646A630", VA = "0x18646B430")]
	public static NativeArray<float2> NOOOLFBABPM(NativeArray<float2> FDFDCBGFIOM, int JCGJAKPLJGN, NativeArray<float2> DJGLHGODCJL, int AEJKDOEFNPG)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x646B0F0", Offset = "0x646A2F0", VA = "0x18646B0F0")]
	public static NativeArray<float3> LGGKKCCEGGC(NativeArray<float3> FDFDCBGFIOM, int JCGJAKPLJGN, NativeArray<float3> DJGLHGODCJL, int AEJKDOEFNPG)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x646B320", Offset = "0x646A520", VA = "0x18646B320")]
	public static NativeArray<float4> MICEKOBNMPL(NativeArray<float4> FDFDCBGFIOM, int JCGJAKPLJGN, NativeArray<float4> DJGLHGODCJL, int AEJKDOEFNPG)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x646B540", Offset = "0x646A740", VA = "0x18646B540")]
	public static NativeArray<int> OOIOFAFNHNB(NativeArray<int> FDFDCBGFIOM, int JCGJAKPLJGN, NativeArray<int> DJGLHGODCJL, int AEJKDOEFNPG)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2966990", Offset = "0x2965B90", VA = "0x182966990")]
	private static void FICKGLBAPGE<T>(NativeArray<T> HPGKNFECNHG, int JPHJKPENALI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x29668E0", Offset = "0x2965AE0", VA = "0x1829668E0")]
	private static void BHDBEAIKNOE<T>(NativeArray<T> FDFDCBGFIOM, int JCGJAKPLJGN, NativeArray<T> DJGLHGODCJL, int AEJKDOEFNPG, NativeArray<T> AMOOHIFAAMJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DebuggerStepThrough]
public static class NNEFLKCJDFP
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	public static void EOFDCFANENN(bool AOLAKAPHPCK, string CGODEMKFBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	public static void EOFDCFANENN(bool AOLAKAPHPCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class AJIOCEKAIIO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal enum ALJNHMIDODC
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
	public class PGKHDFMAIFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CIMFJBKGKCL COKNMDIBDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int OJNCGJKFFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int HKFGPPFJGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long GLKACPAHGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public long LMFEOIDOGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float EPOKONKLDAB;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6483310", Offset = "0x6482510", VA = "0x186483310")]
		public PGKHDFMAIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x64832D0", Offset = "0x64824D0", VA = "0x1864832D0")]
		public void PGPPPADIAAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly string DPODHJABPJC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly string BKKHGCKHBGA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker NHAKLMAHFCJ;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ProfilerMarker DKJLIACBFBK;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker AGILONNBNJH;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker HJBOCCBLILL;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly ProfilerMarker KHKKGJEPMKC;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker KMOLBMOLPMH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker EJNONKMEIDD;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker NJBFNACDGIJ;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker DJOCIPALMAP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker KECBNAGFLKJ;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker OAIAMGHDDNL;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker NEPLJOECADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<HBFFDCAHNHG> OKMFPJLHBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly BPDAEKAOABP JKEFLDBPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int KLFJEECIELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int NMJAALBACJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool IPAGKPCAJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	internal bool KCBGHDHLJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	internal ALJNHMIDODC JLPFJEBDMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	internal bool OAIOAKOOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal float3 BNECMAINCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal float3 LBHFIHMGBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal float DCMIPOPKLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	internal float IIGOILHANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	internal int BGNOCLPHOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	internal int LCHNPECJPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int FPOGFEPLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float NIGONJODNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float JDAPCDPGELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int MJJNFEDGDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private long DMAJDHOBELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long GPMGECKNAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private long PGODOCMKFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public int LNPLBMEHAEL;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int GGHFNEKDINO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float[] NHEADDBJCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private int[] CAAGKOGOLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private long[] AKNLLIIHKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private FBPCJNPPGNE JJMKJDAKNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private long BOIOJHPHCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private long OFBMDLPCJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int MGNCEJKLEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private List<PGKHDFMAIFF> FCGPPINNJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	internal float GHJJCMGPCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool MKBKIGOLICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NGMBEHBLCJL OKDBCJJDBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private JobHandle HNHNINFCHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal NativeArray<long> LFLFODPMPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool BFDIPAMEKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private JobHandle MCIPKLKIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private FBPCJNPPGNE NPJCEDHKEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Transform BHEGGLMOCDC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh NDBAHHNICBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4F0", Offset = "0x7CA6F0", VA = "0x1807CB4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer MEPNOIFLLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int NEGLCNMHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x834E80", Offset = "0x834080", VA = "0x180834E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MGMGMDDCOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7F00C0", Offset = "0x7EF2C0", VA = "0x1807F00C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int HOBAKICFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6459680", Offset = "0x6458880", VA = "0x186459680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<HBFFDCAHNHG> HKGOJOHKFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x645FD50", Offset = "0x645EF50", VA = "0x18645FD50")]
	public void PDKKNKDEGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x645B940", Offset = "0x645AB40", VA = "0x18645B940")]
	private void FIPDMNLPJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6460380", Offset = "0x645F580", VA = "0x186460380")]
	public AJIOCEKAIIO(string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x645FD60", Offset = "0x645EF60", VA = "0x18645FD60")]
	public void PGPPPADIAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x645B8B0", Offset = "0x645AAB0", VA = "0x18645B8B0")]
	public void FALENHPJKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x645D6F0", Offset = "0x645C8F0", VA = "0x18645D6F0")]
	private void IDJFNOLCNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x645FBF0", Offset = "0x645EDF0", VA = "0x18645FBF0")]
	public void NGHFOPKNKOI(HBFFDCAHNHG HPJNJIOIOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x645D960", Offset = "0x645CB60", VA = "0x18645D960")]
	public bool IJBNPGGFJFH(HBFFDCAHNHG HPJNJIOIOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x645A810", Offset = "0x6459A10", VA = "0x18645A810")]
	public bool EJPMGDOHJOE(HBFFDCAHNHG HPJNJIOIOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x645EAD0", Offset = "0x645DCD0", VA = "0x18645EAD0", Slot = "4")]
	public virtual void LPBJFHGDOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x645A490", Offset = "0x6459690", VA = "0x18645A490")]
	public void DONCFJLOJHD(Transform COJGEBAHKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x645DD90", Offset = "0x645CF90", VA = "0x18645DD90")]
	public bool LFGGDGMGJNL(Transform COJGEBAHKPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x645AAF0", Offset = "0x6459CF0", VA = "0x18645AAF0")]
	public bool EPDKFDCMMJH(bool DDKOGEANEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x645FE70", Offset = "0x645F070", VA = "0x18645FE70")]
	public void POMEFHFJMFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x645CB80", Offset = "0x645BD80", VA = "0x18645CB80")]
	public bool HHGKDLMLLOJ(float4x4 FNFMJEFHKAG, BatchedMeshRenderer OKMPEODIOLK, bool FINPKGLHMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x645A740", Offset = "0x6459940", VA = "0x18645A740")]
	public void EGEAIIBEFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x645E8A0", Offset = "0x645DAA0", VA = "0x18645E8A0")]
	public bool LLPHDEKBMCP(bool DDKOGEANEGM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x64596A0", Offset = "0x64588A0", VA = "0x1864596A0")]
	public void AFDJMJFCNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x645A460", Offset = "0x6459660", VA = "0x18645A460")]
	public void CFCPLFFDFBM(FBPCJNPPGNE COKNMDIBDNP, int KGDGMBCBAGA, float BJIBHAFANHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6459B00", Offset = "0x6458D00", VA = "0x186459B00")]
	public void BIBMFGFFNAM(CIMFJBKGKCL LKHGIDIPMEE, int KGDGMBCBAGA, float BJIBHAFANHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x645DA00", Offset = "0x645CC00", VA = "0x18645DA00")]
	public long KDKDLCEDEBL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7D2360", Offset = "0x7D1560", VA = "0x1807D2360")]
	public long MLCNOJNOLEN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x645A5D0", Offset = "0x64597D0", VA = "0x18645A5D0")]
	private void EDLGILLMGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x645DA10", Offset = "0x645CC10", VA = "0x18645DA10")]
	public (long, long) LBGPIJEPBPO(float EINOPADGLHL, float4x4 FNFMJEFHKAG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xB3FB40", Offset = "0xB3ED40", VA = "0x180B3FB40")]
	internal void ILOGNIIGILB(ALJNHMIDODC PNCGHDDKCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x645BB20", Offset = "0x645AD20", VA = "0x18645BB20")]
	private (float, float, float) GJEGNPCBOPI(float KJGEAOPBDBP, float4x4 FNFMJEFHKAG)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x645A870", Offset = "0x6459A70", VA = "0x18645A870")]
	private (int, int) ENOODHOPMNI(float OCONPACLMPG)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x645EB80", Offset = "0x645DD80", VA = "0x18645EB80")]
	public void MKKIAOFEHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6459B30", Offset = "0x6458D30", VA = "0x186459B30")]
	private void BNBMGOBNHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6459940", Offset = "0x6458B40", VA = "0x186459940")]
	private void BCDAJENIOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x645C2B0", Offset = "0x645B4B0", VA = "0x18645C2B0")]
	private void GMEDMADFFIO(FBPCJNPPGNE OGBDCKGIIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x64596B0", Offset = "0x64588B0", VA = "0x1864596B0")]
	private void AOOPANGMJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6459B60", Offset = "0x6458D60", VA = "0x186459B60")]
	private void BNPDNFNIBAM(FBPCJNPPGNE COKNMDIBDNP, CIMFJBKGKCL LKHGIDIPMEE, int KGDGMBCBAGA, float BJIBHAFANHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[BurstCompile]
internal struct NGMBEHBLCJL : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct LLGIBGNPCHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int AJLBDJDICON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int KBIGNDNIHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int IGHPLDAHGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int LLPILEJJFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int BCOJMPHMENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int IIIPHPAGOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int OJNCGJKFFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int HKFGPPFJGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float EPOKONKLDAB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct KHPPIMIDCBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public EJDJDHNGDJK.ODAICFOJPEB NKCDAMBLNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float AMAMMGAJEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float HPKNEAIOCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float AAFFGAHCGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float APLDPEEJODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float JIBCLBCCNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float JGAOJIIOOPA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct IGDBAPOHDHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NativeArray<float3> PGGCDEEGOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public NativeArray<float3> HEHAMINKGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public NativeArray<float4> BMOAFDOJBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public NativeArray<float4> NFMCMFEKOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public NativeArray<float2> LKDHIHBLGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NativeArray<int> FKOKOGFBJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool BNBJMACNLBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int HOBAKICFGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int BOGJAJJGCPO;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x64808A0", Offset = "0x647FAA0", VA = "0x1864808A0")]
		public void KNDKEEBKAEP(int EEKCCPEHAHL, int CMBOPJALLLC, Allocator LGNDPBNMKMP, bool AKHMCPAGCMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6480650", Offset = "0x647F850", VA = "0x186480650")]
		public static IGDBAPOHDHJ DHHCCLKPNJC(FBPCJNPPGNE NAKAAHDEHKM)
		{
			return default(IGDBAPOHDHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x64809F0", Offset = "0x647FBF0", VA = "0x1864809F0")]
		public void PGPPPADIAAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly ProfilerMarker JBAHFMFDKMM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly ProfilerMarker NLLCENMIMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private NativeArray<LLGIBGNPCHP> GBAADDHGPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private IGDBAPOHDHJ FFONJNKICOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private IGDBAPOHDHJ OGBDCKGIIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private float3 FBDBBDLINPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private float3 MNJELPEPPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private KHPPIMIDCBC ALMJNKIBJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* PMBFKGDBKKI;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6482CC0", Offset = "0x6481EC0", VA = "0x186482CC0")]
	public NGMBEHBLCJL([In] List<AJIOCEKAIIO.PGKHDFMAIFF> BFPCMFNPEBN, [In] FBPCJNPPGNE GDAAFFPABFE, [In] AJIOCEKAIIO BGBHDIKOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6480EF0", Offset = "0x64800F0", VA = "0x186480EF0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64824E0", Offset = "0x64816E0", VA = "0x1864824E0")]
	public void OJNIKHKFHPO(List<AJIOCEKAIIO.PGKHDFMAIFF> DOFJDDBMFFB, [In] AJIOCEKAIIO BGBHDIKOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6480F40", Offset = "0x6480140", VA = "0x186480F40")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool KMIENCMHHEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6482410", Offset = "0x6481610", VA = "0x186482410")]
	private CIMFJBKGKCL NCFDBHEENMH(int OGMGPGBPHFC, Allocator LGNDPBNMKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6480F60", Offset = "0x6480160", VA = "0x186480F60")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void LDAIAPGKNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6480AB0", Offset = "0x647FCB0", VA = "0x186480AB0")]
	[IgnoreWarning(1371)]
	private LLGIBGNPCHP ABDPAFBIPOM([In] LLGIBGNPCHP EDCPBKEMCBF, int GICLNAOAPEF, [In] NativeArray<int> PMDLHGKDDFM, [In] NativeArray<bool> NDAENCHGBKI, NativeArray<int> CDILCJLDCCM)
	{
		return default(LLGIBGNPCHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6482B20", Offset = "0x6481D20", VA = "0x186482B20")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int PMDNNAKFABO(NativeArray<int> PMDLHGKDDFM, int NKHGPJIGBMJ, int POELHAGFIDF, int HKPPMCHOHBI)
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
		private static readonly ProfilerMarker NNOOFMGMCPJ;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly ProfilerMarker PACGOHALAAC;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly ProfilerMarker GLMAIBJLBNH;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly ProfilerMarker FJFEMFLFCAE;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly ProfilerMarker KHKKGJEPMKC;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly ProfilerMarker NHENDEPBGGI;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly ProfilerMarker EKNCMDJFCCJ;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal const int OLBIMBAPNEH = 65000;

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
		private Dictionary<Material, List<AJIOCEKAIIO>> EGCEJIINJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		internal List<AJIOCEKAIIO> CFPHOOOPOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private List<MeshRenderer> DDPGJJBLEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool JMENGPFBMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool CJJNNDPHEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int KPKMILJDOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Dictionary<int, float> JKGFCGOGAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Dictionary<int, Color> EHEEJMHJJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Dictionary<int, Vector4> DNIFFCKEBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Dictionary<int, Matrix4x4> MOJAEIIIJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private AJIOCEKAIIO JPPFFJMHEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private Material FNFKPDBJIJH;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> DOJIJCHODBA
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int KLNBNMFCJEM
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x6480600", Offset = "0x647F800", VA = "0x186480600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x647D1B0", Offset = "0x647C3B0", VA = "0x18647D1B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x647B070", Offset = "0x647A270", VA = "0x18647B070")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x647AE40", Offset = "0x647A040", VA = "0x18647AE40")]
		public AJIOCEKAIIO AddToBatchedMesh(HBFFDCAHNHG CPBKGHCKIDH, Material OOHAKCENEJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x647F7E0", Offset = "0x647E9E0", VA = "0x18647F7E0")]
		public void RemoveFromBatchedMesh(HBFFDCAHNHG COKNMDIBDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x647AF40", Offset = "0x647A140", VA = "0x18647AF40")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x647F920", Offset = "0x647EB20", VA = "0x18647F920")]
		public void SetMaterialProperty(int FNCDBPBCGFM, Color LHAAJEOMGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x647FDA0", Offset = "0x647EFA0", VA = "0x18647FDA0")]
		public void SetMaterialProperty(int FNCDBPBCGFM, float HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x647FFB0", Offset = "0x647F1B0", VA = "0x18647FFB0")]
		public void SetMaterialProperty(int FNCDBPBCGFM, Vector4 IKBGLNDNGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x647FB40", Offset = "0x647ED40", VA = "0x18647FB40")]
		public void SetMaterialProperty(int FNCDBPBCGFM, Matrix4x4 EKNONJGCKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x647B230", Offset = "0x647A430", VA = "0x18647B230")]
		private void FIICNDMKHEM(Renderer MNDOIBEKKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x647B830", Offset = "0x647AA30", VA = "0x18647B830")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x647B820", Offset = "0x647AA20", VA = "0x18647B820")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x647BE50", Offset = "0x647B050", VA = "0x18647BE50")]
		private void HFKKAPGMLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x647C390", Offset = "0x647B590", VA = "0x18647C390")]
		private AJIOCEKAIIO HNBAPCNFBKD(HBFFDCAHNHG COKNMDIBDNP, Material OOHAKCENEJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x647C5A0", Offset = "0x647B7A0", VA = "0x18647C5A0")]
		private AJIOCEKAIIO LMINMGMLLBK(Material OOHAKCENEJE, int MFIBKPFHILN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x647CC80", Offset = "0x647BE80", VA = "0x18647CC80")]
		private AJIOCEKAIIO NHLDMCFEPPL(Material OOHAKCENEJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x17EBBC0", Offset = "0x17EADC0", VA = "0x1817EBBC0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x647C7A0", Offset = "0x647B9A0", VA = "0x18647C7A0")]
		public void MarkDirty(HBFFDCAHNHG COKNMDIBDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x647C900", Offset = "0x647BB00", VA = "0x18647C900")]
		public (long, long) MemorySizeInBytesForChosenDetail(float EINOPADGLHL)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x647E950", Offset = "0x647DB50", VA = "0x18647E950")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x647B8D0", Offset = "0x647AAD0", VA = "0x18647B8D0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x647D4A0", Offset = "0x647C6A0", VA = "0x18647D4A0")]
		public void RebatchOptimally(int FGKJEJDEIFH, int FGMELAAJDDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6480390", Offset = "0x647F590", VA = "0x186480390")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class AFHBOEPNKHM
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct JJGCIOHPJNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public float GMDNJIBGHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BatchedMeshRenderer NHCENDKGICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AJIOCEKAIIO BNBHHBMDOIN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly ProfilerMarker KHKKGJEPMKC;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly ProfilerMarker FMCIFMKONBK;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly ProfilerMarker KAICGMMNNCA;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly ProfilerMarker OLNNJEBHDJC;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public static float3 COEIAAMNAHE;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public static int OGOFKLBGDOP;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public static int JLLODEGCCJG;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public static int APDLNGOHNIO;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public static int KBCDKFDFLHP;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public static int CAOPDLOKEFJ;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static int FJCIBJGBECC;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static int KHKCHELKOHP;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static int NIEEKDCGHBF;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public static int BIGDKGMMDCP;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public static int HDAJJBMCFHE;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public static int FFEEIJEPBNF;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public static int EIOLKHPMCIN;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public static int JCLDHFDEDGC;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public static int HOBOKKLADBH;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public static int AEOGDPNACGO;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public static int PKIDBDEJPHO;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public static long HAMCPODDCCI;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public static bool GBGIGDJIKLO;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static List<BatchedMeshRenderer> OCJCINHJGCB;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static List<JJGCIOHPJNK> FAGALCAHNOF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool BCMECNLAAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6477480", Offset = "0x6476680", VA = "0x186477480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6479840", Offset = "0x6478A40", VA = "0x186479840")]
	public static void ICOEADAEIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x647A500", Offset = "0x6479700", VA = "0x18647A500")]
	public static void KMFHBPOIJJC(BatchedMeshRenderer BKNAGBHLDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x64770D0", Offset = "0x64762D0", VA = "0x1864770D0")]
	public static void DCICPBIEMFB(BatchedMeshRenderer BKNAGBHLDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6477840", Offset = "0x6476A40", VA = "0x186477840")]
	private static void FLPCPDICDOA([Out] long FNDPGJHKKCH, [Out] long GJAMKJGIBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6477B30", Offset = "0x6476D30", VA = "0x186477B30")]
	public static void HHGKDLMLLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6477600", Offset = "0x6476800", VA = "0x186477600")]
	public static void FKOKLPNDIDM(AJIOCEKAIIO BNBHHBMDOIN, BatchedMeshRenderer NHCENDKGICM, float GMDNJIBGHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x64779F0", Offset = "0x6476BF0", VA = "0x1864779F0")]
	public static void GGAHPIBHLDE(AJIOCEKAIIO BNBHHBMDOIN, BatchedMeshRenderer NHCENDKGICM, float ILGKILPHNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6477A90", Offset = "0x6476C90", VA = "0x186477A90")]
	public static void GLMLPPNDCFA(AJIOCEKAIIO BNBHHBMDOIN, BatchedMeshRenderer NHCENDKGICM, float ILGKILPHNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6476F70", Offset = "0x6476170", VA = "0x186476F70")]
	public static void CGCPKIIMFPL(AJIOCEKAIIO BNBHHBMDOIN, BatchedMeshRenderer NHCENDKGICM, float GMDNJIBGHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x64776A0", Offset = "0x64768A0", VA = "0x1864776A0")]
	public static void FLHBMJKPKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x647A9C0", Offset = "0x6479BC0", VA = "0x18647A9C0")]
	public static void OBHCFOCOLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6477180", Offset = "0x6476380", VA = "0x186477180")]
	public static float DNOBODLHCAN(long CECDONKGEMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x647A7F0", Offset = "0x64799F0", VA = "0x18647A7F0")]
	public static (long, long) LBGPIJEPBPO(float EINOPADGLHL)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6479A20", Offset = "0x6478C20", VA = "0x186479A20")]
	public static void IDHKGFBHJGJ(bool HOBJOJDNPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6477510", Offset = "0x6476710", VA = "0x186477510")]
	public static int EJAHOBNMBKA()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HCPBHHAKDDB<KeyType> : AJIOCEKAIIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly Dictionary<KeyType, HBFFDCAHNHG> NANCINMKKBK;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A3D0", Offset = "0x3A295D0", VA = "0x183A2A3D0")]
	public HCPBHHAKDDB(string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A2B0", Offset = "0x3A294B0", VA = "0x183A2A2B0")]
	public void NGHFOPKNKOI(KeyType MNOIAMGNLNL, HBFFDCAHNHG HPJNJIOIOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A060", Offset = "0x3A29260", VA = "0x183A2A060")]
	public bool IGAPKDCCHMC(KeyType MNOIAMGNLNL, HBFFDCAHNHG EOCIMCMMECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A130", Offset = "0x3A29330", VA = "0x183A2A130")]
	public void ILFMILDIPOL(KeyType MNOIAMGNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A270", Offset = "0x3A29470", VA = "0x183A2A270", Slot = "4")]
	public override void LPBJFHGDOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6483360", Offset = "0x6482560", VA = "0x186483360")]
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
