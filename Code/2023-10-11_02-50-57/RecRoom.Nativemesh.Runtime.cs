using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JINOALMNJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int GFLKEPCBJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 MGGLAABECGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion GEBEGGAGIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 NNDEIEMOOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CCNKODIFEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int MKICFNHIEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int EHLOLOMBKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float LHKCENDKKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 MHIIBGCMIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool LBNCNPBABJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public PELOFEEDMNB BPJECCFFDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 HCOPMJKLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float PKIDBGOGDPK;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GEODHLJEBLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static CLJBKFNJMEB NEIHGAJHOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<JINOALMNJIK> NCCAJAJPMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<HINNECFHGMC> DEJFBJKKAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<MIICCIEIFEA> IGLFOLPAOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<HHMGMDJFKGN> IHEEJCJCAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<HINNECFHGMC> MPKGKCCFNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<PPHABCCLDFP> LLFDHLKNHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<HHMGMDJFKGN>> NKPFBLBLNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<AONJIFPFGAL> EJIANKPDMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> JBOLFDEFEAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FEPGFEKGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE2200", Offset = "0xAE1000", VA = "0x180AE2200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAE0990", Offset = "0xADF790", VA = "0x180AE0990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GGMFGFMCAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE1010", VA = "0x180AE2210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAE1D20", Offset = "0xAE0B20", VA = "0x180AE1D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D218C0", Offset = "0x5D206C0", VA = "0x185D218C0")]
	public GEODHLJEBLP(int EPNGAGEDHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D21200", Offset = "0x5D20000", VA = "0x185D21200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D21030", Offset = "0x5D1FE30", VA = "0x185D21030")]
	public void DGLGEELFCGD(JobHandle GLEFMKPHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D216A0", Offset = "0x5D204A0", VA = "0x185D216A0")]
	public void MLPAEADBMEI(JINOALMNJIK PFDMLBFKIAP, AONJIFPFGAL DFJEBIMLGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D21220", Offset = "0x5D20020", VA = "0x185D21220")]
	public void IFOCEOAHMFG(MIICCIEIFEA PFDMLBFKIAP, NativeArray<HHMGMDJFKGN> IMHBABHIFNO, int AHPOHNAOEEI, int GEAGADHINOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FD70", Offset = "0x5D1EB70", VA = "0x185D1FD70")]
	public JobHandle ADAIKEICNFA(JPMCJAOPOAE COGPADJCFOD, AININHEMHOC KPOCEPJEEIB, float3 MFFFJNEBECL, quaternion IGKLDDKNNHK, float EJHAMMDIEIJ, bool OAPNNOFBIAI, int DBKMIFIEMDF = 0, int KLIIFJFLFBC = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D21360", Offset = "0x5D20160", VA = "0x185D21360")]
	public static JobHandle LBDPMMFBPAK(JCHOMPIBNAN NEGOPCHDDEB, JPMCJAOPOAE COGPADJCFOD, JINOALMNJIK PFDMLBFKIAP, JobHandle GLEFMKPHENM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D20D80", Offset = "0x5D1FB80", VA = "0x185D20D80")]
	public static JobHandle ALMGPLHPNAM(IODDHJEDHNE NEGOPCHDDEB, JPMCJAOPOAE COGPADJCFOD, MIICCIEIFEA PFDMLBFKIAP, NativeArray<HHMGMDJFKGN> IMHBABHIFNO, int AHPOHNAOEEI, int GEAGADHINOG, JobHandle GLEFMKPHENM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GGDEKDPPMCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 FLEHAKPGOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 IPOFMPLPLMP;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OFIGPGDNGMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<GGDEKDPPMCH> LGOHJEEDFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> HEOAOBMLCPF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FEPGFEKGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GGMFGFMCAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x761620", Offset = "0x760420", VA = "0x180761620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B690", Offset = "0x5D2A490", VA = "0x185D2B690")]
	public OFIGPGDNGMI(int DEIOHAOEKEO, int JKKHOALODAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B550", Offset = "0x5D2A350", VA = "0x185D2B550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B5B0", Offset = "0x5D2A3B0", VA = "0x185D2B5B0")]
	public void NDHEFBHKNAB(OFIGPGDNGMI LOPJHIBPCJA, int BPKNCLOGFKM, int KMGLIANDLEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HIBEKLJAFPO
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static OFIGPGDNGMI KHLMFHLJMKF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<HINNECFHGMC> GEHDLEBBHGN;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] PKGBKEKDGEK;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool LEDPBNOHICE;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, OFIGPGDNGMI> CLCLOGKAIHM;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, OFIGPGDNGMI> GCLOLFGGMKB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool IEJGFFAIOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D220C0", Offset = "0x5D20EC0", VA = "0x185D220C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<HINNECFHGMC> MNHIOJMEGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5D22200", Offset = "0x5D21000", VA = "0x185D22200")]
		get
		{
			return default(NativeList<HINNECFHGMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static OFIGPGDNGMI JPJPGOHOFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D222A0", Offset = "0x5D210A0", VA = "0x185D222A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D22780", Offset = "0x5D21580", VA = "0x185D22780")]
	private static void LMCGEMDLJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D22750", Offset = "0x5D21550", VA = "0x185D22750")]
	public static int LFKPGNFDHDI(bool IMJGKCLBEFI, int AAFAHPPCOME, bool MEMOHFBNCJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D221D0", Offset = "0x5D20FD0", VA = "0x185D221D0")]
	private static int GPMPMMMIPPK(int AAFAHPPCOME, bool EGANNCPAAKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D221F0", Offset = "0x5D20FF0", VA = "0x185D221F0")]
	private static int HDPJJEILKCC(int AAFAHPPCOME, bool EGANNCPAAKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D22140", Offset = "0x5D20F40", VA = "0x185D22140")]
	public static int GFOGPLLCDJH(int AHOEGIJAMMB, int AAFAHPPCOME, int IGMMLEECJIH, bool EGANNCPAAKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D21F90", Offset = "0x5D20D90", VA = "0x185D21F90")]
	public static int DKAHKCJHEMJ(int AHOEGIJAMMB, int AAFAHPPCOME, int IGMMLEECJIH, bool EGANNCPAAKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D22020", Offset = "0x5D20E20", VA = "0x185D22020")]
	public static int DMMLJLCFLOL(int IGMMLEECJIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D22E20", Offset = "0x5D21C20", VA = "0x185D22E20")]
	private static int MLKLFAFBEMH(int AAFAHPPCOME, bool EGANNCPAAKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D232A0", Offset = "0x5D220A0", VA = "0x185D232A0")]
	private static int PBPENMDMKIO(int AAFAHPPCOME, bool EGANNCPAAKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D22D90", Offset = "0x5D21B90", VA = "0x185D22D90")]
	public static int MECOMKIELAM(int AHOEGIJAMMB, int AAFAHPPCOME, int IGMMLEECJIH, bool EGANNCPAAKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D22030", Offset = "0x5D20E30", VA = "0x185D22030")]
	public static int EBDAHMGOELA(int AHOEGIJAMMB, int AAFAHPPCOME, int IGMMLEECJIH, bool EGANNCPAAKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D22E00", Offset = "0x5D21C00", VA = "0x185D22E00")]
	public static int MEEDLPHFJGC(int IGMMLEECJIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D22F20", Offset = "0x5D21D20", VA = "0x185D22F20")]
	public static OFIGPGDNGMI OKDLKGGPJLP(int AAFAHPPCOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D23010", Offset = "0x5D21E10", VA = "0x185D23010")]
	private static OFIGPGDNGMI PBMIAAHJCPO(int AAFAHPPCOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D22E30", Offset = "0x5D21C30", VA = "0x185D22E30")]
	public static OFIGPGDNGMI NFPJAMHLJIA(int AAFAHPPCOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D232C0", Offset = "0x5D220C0", VA = "0x185D232C0")]
	private static OFIGPGDNGMI PDEKKJJIGKM(int AAFAHPPCOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D22340", Offset = "0x5D21140", VA = "0x185D22340")]
	public static void KNGNKIPFPGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MIICCIEIFEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int EHJJDHFBLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 MGGLAABECGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion GEBEGGAGIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float NNDEIEMOOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float NCJPBJGHGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int CCNKODIFEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int MKICFNHIEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int EHLOLOMBKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool ELMCKKJGDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool EHLDKDIKGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float LHKCENDKKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 MHIIBGCMIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool OHHKDJFAEBJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PPHABCCLDFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int HBMOMHCDFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int LHEDDHFMDBB;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IODDHJEDHNE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<MIICCIEIFEA> HKADMIFNPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<HHMGMDJFKGN> CPJPMEHBDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<HINNECFHGMC> LOPKAHGOONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<PPHABCCLDFP> BECINMHNPCH;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D239B0", Offset = "0x5D227B0", VA = "0x185D239B0")]
	public IODDHJEDHNE(NativeArray<HHMGMDJFKGN> CPJPMEHBDOK, int MEDHPDICIDE = 1, Allocator JFLEKJGGDHL = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D238C0", Offset = "0x5D226C0", VA = "0x185D238C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct KBDPNFAOEKC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<GGDEKDPPMCH> NEFBKFHGAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> BMJONHBHMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<HINNECFHGMC> DHLGGKFKMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<MIICCIEIFEA> HKADMIFNPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<HHMGMDJFKGN> CPJPMEHBDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<HINNECFHGMC> LOPKAHGOONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<PPHABCCLDFP> BECINMHNPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int AEODGIPAFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int ALOEOLHHACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 GNKGOGNAEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion OKKMGIEOOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 FHDOBNMBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NHHCLDFFHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> IACAMKBIKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MOIELBLMCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NNEIJLFOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KGIPFHJPNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DOCLPGGJPJO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D28080", Offset = "0x5D26E80", VA = "0x185D28080")]
	public KBDPNFAOEKC(GEODHLJEBLP OJPEIFJLCGP, JPMCJAOPOAE DDDBBOGJBCC, float3 EHJPKMPAGJA, quaternion KJHFDLNCIKN, float FEILLKAPBHD, int DBKMIFIEMDF = 0, int KLIIFJFLFBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D27E50", Offset = "0x5D26C50", VA = "0x185D27E50")]
	public KBDPNFAOEKC(IODDHJEDHNE OJPEIFJLCGP, JPMCJAOPOAE DDDBBOGJBCC, float3 EHJPKMPAGJA, quaternion KJHFDLNCIKN, float3 FEILLKAPBHD, int DBKMIFIEMDF = 0, int KLIIFJFLFBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D274D0", Offset = "0x5D262D0", VA = "0x185D274D0")]
	private float3 HILJCEMBLBE(float3 JPGMOOPFLGP, Matrix4x4 ADKFFGFLBKM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D27DD0", Offset = "0x5D26BD0", VA = "0x185D27DD0")]
	private float3x3 NPODBKHMGJP(float3x3 GJKPMNJCGHJ, float3x3 CMDLBCFFOLO)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D27600", Offset = "0x5D26400", VA = "0x185D27600")]
	private float IIJFHOOEDPG(float GBJGBGCFEKM, float ILMIGHIFMAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D26330", Offset = "0x5D25130", VA = "0x185D26330", Slot = "4")]
	public void Execute(int CGKIPLDGPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D27610", Offset = "0x5D26410", VA = "0x185D27610")]
	private void KHODPNLADHH(int MAEKGGJAANJ, float3 AILFIIEAPKM, float3 LNAACFFHHMA, float3 KNIDMBCPLCA, float OMKKAIJAKIM, bool BEAOMFGKKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D25ED0", Offset = "0x5D24CD0", VA = "0x185D25ED0")]
	private void CKMMKLGBEFN(MIICCIEIFEA ENJINDJJKBA, float3 AIEJDLEEMCB, float3x3 KAHMHDLHHJI, float GBJGBGCFEKM, int NGBEKFEAHHH, int CNCFDBIHOGI, int CBKHNEPCFLH, float JKDACOMACIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D27780", Offset = "0x5D26580", VA = "0x185D27780")]
	private void NCCNBPKOAPN(int MAEKGGJAANJ, int CLHPBEAGFHO, MIICCIEIFEA ENJINDJJKBA, float3 AIEJDLEEMCB, float3x3 KAHMHDLHHJI, bool MHELNCODLJH, float GBJGBGCFEKM, int JADEPGAMEEN, int LHAEDEEPFHH, int CBKHNEPCFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JCHOMPIBNAN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<JINOALMNJIK> ICEBEOPPBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<HINNECFHGMC> IBPONOBPGNN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D24F70", Offset = "0x5D23D70", VA = "0x185D24F70")]
	public JCHOMPIBNAN(int MEDHPDICIDE, Allocator JFLEKJGGDHL = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D24ED0", Offset = "0x5D23CD0", VA = "0x185D24ED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct MBDMLLGFPCI : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum EOEKKLIIOFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeList<float3> CKJMNGBJEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> AKOGICODCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> MODLBOKGIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> DJAEKHKHOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> DICNGDPLFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> BPCGJMLJBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> PDPLGDNBNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> FBAAHLNMFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<HINNECFHGMC> ONINAJOGNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<JINOALMNJIK> ICEBEOPPBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<HINNECFHGMC> IBPONOBPGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int AEODGIPAFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int ALOEOLHHACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NHHCLDFFHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> IACAMKBIKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MOIELBLMCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NNEIJLFOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KGIPFHJPNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DOCLPGGJPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 FHDOBNMBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion OKKMGIEOOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 GNKGOGNAEPB;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B360", Offset = "0x5D2A160", VA = "0x185D2B360")]
	public MBDMLLGFPCI(GEODHLJEBLP OJPEIFJLCGP, JPMCJAOPOAE DDDBBOGJBCC, float3 EHJPKMPAGJA, quaternion KJHFDLNCIKN, float FEILLKAPBHD, int DBKMIFIEMDF = 0, int KLIIFJFLFBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B170", Offset = "0x5D29F70", VA = "0x185D2B170")]
	public MBDMLLGFPCI(JCHOMPIBNAN PFDMLBFKIAP, JPMCJAOPOAE DDDBBOGJBCC, float3 EHJPKMPAGJA, quaternion KJHFDLNCIKN, float3 FEILLKAPBHD, int DBKMIFIEMDF = 0, int KLIIFJFLFBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D29E20", Offset = "0x5D28C20", VA = "0x185D29E20", Slot = "4")]
	public void Execute(int CGKIPLDGPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AD80", Offset = "0x5D29B80", VA = "0x185D2AD80")]
	private void LHJHOEFEMPE(float4x4 IKJJIOIHAIN, int CGKIPLDGPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D29DB0", Offset = "0x5D28BB0", VA = "0x185D29DB0")]
	private EOEKKLIIOFI DMEIPIAEILF(float3 LNAACFFHHMA)
	{
		return default(EOEKKLIIOFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D29D60", Offset = "0x5D28B60", VA = "0x185D29D60")]
	private float4 AFKINMMACPO(EOEKKLIIOFI JLNALOPFENF, int DOJILIOCHKM)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B130", Offset = "0x5D29F30", VA = "0x185D2B130")]
	private float2 MJKGNPCLFOA(EOEKKLIIOFI JLNALOPFENF, float3 AILFIIEAPKM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AONJIFPFGAL
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum BGCBCKGICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static AONJIFPFGAL AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 BADBABAFMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 HBLKKLKOPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 ALAHGBICDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public BGCBCKGICLJ DNFOEPJPNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 OGHDNPMMCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 FDKHDDIFKOF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EHIDAKAHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C150", Offset = "0x5D1AF50", VA = "0x185D1C150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 CBNGOLEICDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C160", Offset = "0x5D1AF60", VA = "0x185D1C160")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C630", Offset = "0x5D1B430", VA = "0x185D1C630")]
	public AONJIFPFGAL(float3 AILFIIEAPKM, quaternion GIBIBDOGOLL, float3 MEDHPDICIDE, BGCBCKGICLJ PEMNIEMPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BCA0", Offset = "0x5D1AAA0", VA = "0x185D1BCA0")]
	public float AMJNLBEDGCH(float3 AIEJDLEEMCB, float DKEEPGFBGOL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C240", Offset = "0x5D1B040", VA = "0x185D1C240")]
	public bool KOHAHNBANCE(float3 LNAACFFHHMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BFA0", Offset = "0x5D1ADA0", VA = "0x185D1BFA0")]
	public void CNHAPMOBNID(float3 IJCLGHMKEIG, float3x3 IJACMNAMJOP, float FBDIFCCGOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BEA0", Offset = "0x5D1ACA0", VA = "0x185D1BEA0")]
	private void CBGIKFEOKCP(float3 EPFKACHOOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C330", Offset = "0x5D1B130", VA = "0x185D1C330")]
	public void OHAHBNIGPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct LAEKFCECGFO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<AONJIFPFGAL> PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> FPMGDMJGJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> NFOFHIAHFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JBOLFDEFEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<HINNECFHGMC> IBPONOBPGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int ENPJHOKAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int OMPAKECFABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float DKEEPGFBGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float CCJLFJHMPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> IKNHGPLHINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JDCHLJOGFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> MONKAHBIBGD;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5D28DB0", Offset = "0x5D27BB0", VA = "0x185D28DB0")]
	public LAEKFCECGFO(JPMCJAOPOAE OMEBACPPAHK, float JPIKMGIFKCA, int KMGLIANDLEO, int NGBEKFEAHHH, NativeList<AONJIFPFGAL> PFDMLBFKIAP, NativeArray<int> JBOLFDEFEAO, NativeList<HINNECFHGMC> IBPONOBPGNN, AININHEMHOC KPOCEPJEEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D28310", Offset = "0x5D27110", VA = "0x185D28310", Slot = "4")]
	public void Execute(int PIPEDALKGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D28CF0", Offset = "0x5D27AF0", VA = "0x185D28CF0")]
	private bool KJACBIHMAFG(AONJIFPFGAL MACGGKMNKNM, AONJIFPFGAL JHKDDIMPPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5D28A50", Offset = "0x5D27850", VA = "0x185D28A50")]
	private bool JGGEOJGLEDG(AONJIFPFGAL BIGGLMECNJE, int JGJFPMHJNHO, int DEFACMLHGEO, int MLJCPCBNHEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AININHEMHOC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> CBLLOJGEIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> LJGELCAACCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> AGAMFOMIFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> NJIBOLGDIEP;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BB80", Offset = "0x5D1A980", VA = "0x185D1BB80")]
	public void DLIAHKDEJKN(int DEIOHAOEKEO, int JKKHOALODAF, Allocator JFLEKJGGDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BC80", Offset = "0x5D1AA80", VA = "0x185D1BC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BA90", Offset = "0x5D1A890", VA = "0x185D1BA90")]
	public void DGLGEELFCGD(JobHandle GLEFMKPHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public AININHEMHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct GOOGKHDELCM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> FPMGDMJGJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> MCAPKPMBCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> GGDOEDHEEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> GFKHCKMAPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> NFOFHIAHFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JDGEOPNAKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> DKCGNNLJMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> IKNHGPLHINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> JDCHLJOGFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int DBKMIFIEMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int KLIIFJFLFBC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D21F10", Offset = "0x5D20D10", VA = "0x185D21F10")]
	public GOOGKHDELCM(JPMCJAOPOAE OMEBACPPAHK, AININHEMHOC KPOCEPJEEIB, int KLIIFJFLFBC = 0, int DBKMIFIEMDF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D21B30", Offset = "0x5D20930", VA = "0x185D21B30", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D21AD0", Offset = "0x5D208D0", VA = "0x185D21AD0")]
	private void BBGLEAFIING()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OFMFINDGJCF
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24F0470", Offset = "0x24EF270", VA = "0x1824F0470")]
	public static bool PPPHPBEDMMJ<T>(NativeArray<T> FNIMPMJDPGM, int MEDHPDICIDE, Allocator JFLEKJGGDHL, NativeArrayOptions DJBANEJKJAN = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x24F0510", Offset = "0x24EF310", VA = "0x1824F0510")]
	public static bool PPPHPBEDMMJ<T>(NativeList<T> NDKEAGMKBJJ, int MEDHPDICIDE, Allocator JFLEKJGGDHL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NDOKECGLLBK
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HBBMFJHEENA
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EELFKIOJHEG(NDOKECGLLBK AHOEGIJAMMB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FMDOMKNOBIP(NDOKECGLLBK AHOEGIJAMMB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHEFEDCJIAG(NDOKECGLLBK AHOEGIJAMMB, GEODHLJEBLP ODEDONPKNJA, int GCIBLOCBKAO = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JPMCJAOPOAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int JEJDJPJFPPE = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> MBOFLDAPOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> EHNEFNPELPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> CGIAFIACMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> AKFHGJGCOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> HCAKNGPIOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> JGOANFPDHNC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool GBAJLLCPBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5D25690", Offset = "0x5D24490", VA = "0x185D25690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FEPGFEKGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D256D0", Offset = "0x5D244D0", VA = "0x185D256D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GGMFGFMCAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D259F0", Offset = "0x5D247F0", VA = "0x185D259F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NHHKFPBACAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D25AB0", Offset = "0x5D248B0", VA = "0x185D25AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D258E0", Offset = "0x5D246E0", VA = "0x185D258E0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D25710", Offset = "0x5D24510", VA = "0x185D25710")]
	public void DLIAHKDEJKN(int DEIOHAOEKEO, int JKKHOALODAF, Allocator JFLEKJGGDHL, bool JNOBBHLAAMI, bool FKOFNHNLNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D25A30", Offset = "0x5D24830", VA = "0x185D25A30")]
	public void GEIMFLKMJMO(int DEIOHAOEKEO, int JKKHOALODAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D25AF0", Offset = "0x5D248F0", VA = "0x185D25AF0", Slot = "6")]
	public bool MMADPKFGAKK(Mesh OMEBACPPAHK, bool CEOCJIAAEOM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D25060", Offset = "0x5D23E60", VA = "0x185D25060")]
	public bool AJONMKDIEPD(Mesh OMEBACPPAHK, JPMCJAOPOAE NKLNNDBFFMM, bool CEOCJIAAEOM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JPMCJAOPOAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IOCMHDLDMGO
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D23770", Offset = "0x5D22570", VA = "0x185D23770")]
	public static void KNGNKIPFPGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IPBELJLMIKB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> MBOFLDAPOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> EHNEFNPELPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> DKGKDECOOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> PJOIAPOGPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> MCDBOJKJEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> LNEBCGHHFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> AFNKCPBJECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> JGOANFPDHNC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FEPGFEKGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5D23AE0", Offset = "0x5D228E0", VA = "0x185D23AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int GGMFGFMCAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5D240C0", Offset = "0x5D22EC0", VA = "0x185D240C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CDGJINLAFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D24400", Offset = "0x5D23200", VA = "0x185D24400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D249C0", Offset = "0x5D237C0", VA = "0x185D249C0")]
	public IPBELJLMIKB(int DEIOHAOEKEO, int JKKHOALODAF, int EFNDCIMIFGH, Allocator JFLEKJGGDHL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D24BE0", Offset = "0x5D239E0", VA = "0x185D24BE0")]
	public IPBELJLMIKB(Mesh OMEBACPPAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D23B20", Offset = "0x5D22920", VA = "0x185D23B20", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D24100", Offset = "0x5D22F00", VA = "0x185D24100")]
	public void NDHEFBHKNAB(IPBELJLMIKB OMEBACPPAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D23C30", Offset = "0x5D22A30", VA = "0x185D23C30")]
	private void FLKOFJMLNFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D24440", Offset = "0x5D23240", VA = "0x185D24440")]
	private void OOJMGKJLBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HINNECFHGMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int KHFPBCDDGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int FEPGFEKGBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int JBKNLNOIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int GGMFGFMCAIC;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x106C320", Offset = "0x106B120", VA = "0x18106C320")]
	public HINNECFHGMC(int NGBEKFEAHHH, int AHPOHNAOEEI, int KMGLIANDLEO, int GEAGADHINOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CLJBKFNJMEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<HINNECFHGMC> MCGIIKAAENM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HINNECFHGMC>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A730E0", Offset = "0x1A71EE0", VA = "0x181A730E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IPBELJLMIKB OBDLJKNNILL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F250", Offset = "0x5D1E050", VA = "0x185D1F250")]
	public CLJBKFNJMEB(IEnumerable<IPBELJLMIKB> BNIICCEGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F1E0", Offset = "0x5D1DFE0", VA = "0x185D1F1E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PELOFEEDMNB
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GEEFBILPHCN
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> KFMIHEDJPFK;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> ICHOILFODED;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> OOGNEJIALAJ;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> LBOICHFIHAA;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FB40", Offset = "0x5D1E940", VA = "0x185D1FB40")]
	public static void KNGNKIPFPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FA30", Offset = "0x5D1E830", VA = "0x185D1FA30")]
	public static NativeArray<float2> KLCIDCGDBGM(NativeArray<float2> DALDPDHFFKN, int BHMONNKPEPJ, NativeArray<float2> BMHDMGPMBNN, int BMHNBGHHNBD)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F920", Offset = "0x5D1E720", VA = "0x185D1F920")]
	public static NativeArray<float3> HOMMINNBLAG(NativeArray<float3> DALDPDHFFKN, int BHMONNKPEPJ, NativeArray<float3> BMHDMGPMBNN, int BMHNBGHHNBD)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F810", Offset = "0x5D1E610", VA = "0x185D1F810")]
	public static NativeArray<float4> EDJMGDBOGFD(NativeArray<float4> DALDPDHFFKN, int BHMONNKPEPJ, NativeArray<float4> BMHDMGPMBNN, int BMHNBGHHNBD)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FC60", Offset = "0x5D1EA60", VA = "0x185D1FC60")]
	public static NativeArray<int> MKGJOPMNMPB(NativeArray<int> DALDPDHFFKN, int BHMONNKPEPJ, NativeArray<int> BMHDMGPMBNN, int BMHNBGHHNBD)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2357ED0", Offset = "0x2356CD0", VA = "0x182357ED0")]
	private static void FOCGFJIJKCE<T>(NativeArray<T> FNIMPMJDPGM, int ALANAGFIKEI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x23580D0", Offset = "0x2356ED0", VA = "0x1823580D0")]
	private static void JMIDGLBAEGM<T>(NativeArray<T> DALDPDHFFKN, int BHMONNKPEPJ, NativeArray<T> BMHDMGPMBNN, int BMHNBGHHNBD, NativeArray<T> INILLLNHMHJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LNBFGCHLJMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<HBBMFJHEENA> AAGGKIKNJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JNONPGBJGNA OFCNILOHOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int AHPOHNAOEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int GEAGADHINOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool FDBHJINABPA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh OBDLJKNNILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x768590", Offset = "0x767390", VA = "0x180768590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer BBFKLMFALHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int FEPGFEKGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5D28E50", Offset = "0x5D27C50", VA = "0x185D28E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1B60", Offset = "0x1FC0960", VA = "0x181FC1B60")]
	public void NDKLMNCJFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C40", Offset = "0x5D28A40", VA = "0x185D29C40")]
	public LNBFGCHLJMF(string ONIBECKLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D28E70", Offset = "0x5D27C70", VA = "0x185D28E70")]
	public void DGLGEELFCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C10", Offset = "0x5D28A10", VA = "0x185D29C10")]
	public void PMJOHLHMHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D29810", Offset = "0x5D28610", VA = "0x185D29810")]
	public void INOAHDJFGPC(HBBMFJHEENA HECAGKLPIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D298C0", Offset = "0x5D286C0", VA = "0x185D298C0")]
	private void JCIEGFACHGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D29BA0", Offset = "0x5D289A0", VA = "0x185D29BA0")]
	public bool PDMOFIFPBAB(HBBMFJHEENA HECAGKLPIKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D297B0", Offset = "0x5D285B0", VA = "0x185D297B0")]
	public bool FEMGIDLEFLP(HBBMFJHEENA HECAGKLPIKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D29B30", Offset = "0x5D28930", VA = "0x185D29B30", Slot = "4")]
	public virtual void NMHONGPAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D28EB0", Offset = "0x5D27CB0", VA = "0x185D28EB0")]
	public void DOFEPHOAAPK(Transform HMAFNLFJHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D29030", Offset = "0x5D27E30", VA = "0x185D29030")]
	public bool EIMOHDJEIHE(Transform HMAFNLFJHAE, [Out] (JPMCJAOPOAE destMesh, Mesh mesh, JobHandle job) PFDMLBFKIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D28F80", Offset = "0x5D27D80", VA = "0x185D28F80")]
	public void EAMIPEGHJCF([In] (JPMCJAOPOAE destMesh, Mesh mesh, JobHandle job) PFDMLBFKIAP)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker NIFCMOEJNDE;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker FIMGJIBJONJ;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker HGLBJNMLDHK;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int GIFANONFBFH = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<Material, List<LNBFGCHLJMF>> GBEEOGCMBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<LNBFGCHLJMF> HCOEPDBOGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> DJPFEOKDPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(LNBFGCHLJMF, (JPMCJAOPOAE, Mesh, JobHandle))> LDPIBGFFBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool JDPAJNDBLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> LLOOJCMONOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> LFDIOMEAKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> IBBEENOPHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> NOJACNCKLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private LNBFGCHLJMF NHGGFFCJLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material PODBGNNOPAG;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> CDPCDEMCGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E180", Offset = "0x5D1CF80", VA = "0x185D1E180")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D020", Offset = "0x5D1BE20", VA = "0x185D1D020")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C720", Offset = "0x5D1B520", VA = "0x185D1C720")]
		public LNBFGCHLJMF AddToBatchedMesh(HBBMFJHEENA BFMMJKOCHKC, Material DDNJBDIAIEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E3F0", Offset = "0x5D1D1F0", VA = "0x185D1E3F0")]
		public void RemoveFromBatchedMesh(HBBMFJHEENA OMEBACPPAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1CE80", Offset = "0x5D1BC80", VA = "0x185D1CE80")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E570", Offset = "0x5D1D370", VA = "0x185D1E570")]
		public void SetMaterialProperty(int NLJCIKGMHGO, Color BJLKCDOCMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EA00", Offset = "0x5D1D800", VA = "0x185D1EA00")]
		public void SetMaterialProperty(int NLJCIKGMHGO, float GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EC20", Offset = "0x5D1DA20", VA = "0x185D1EC20")]
		public void SetMaterialProperty(int NLJCIKGMHGO, Vector4 NOOGIIKHJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E7A0", Offset = "0x5D1D5A0", VA = "0x185D1E7A0")]
		public void SetMaterialProperty(int NLJCIKGMHGO, Matrix4x4 CMDCPCAEEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D410", Offset = "0x5D1C210", VA = "0x185D1D410")]
		private void IOJDNABGEML(Renderer EJFPJKGFNJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D200", Offset = "0x5D1C000", VA = "0x185D1D200")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DA00", Offset = "0x5D1C800", VA = "0x185D1DA00")]
		private void LNOOLMCIJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D210", Offset = "0x5D1C010", VA = "0x185D1D210")]
		private LNBFGCHLJMF GCJMHAKJDHG(HBBMFJHEENA OMEBACPPAHK, Material DDNJBDIAIEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C800", Offset = "0x5D1B600", VA = "0x185D1C800")]
		private LNBFGCHLJMF BFKEDHMFKBB(Material DDNJBDIAIEB, int IFGCPMDONJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C9D0", Offset = "0x5D1B7D0", VA = "0x185D1C9D0")]
		private LNBFGCHLJMF CFBEKHBFPDD(Material DDNJBDIAIEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DF60", Offset = "0x5D1CD60", VA = "0x185D1DF60")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DFF0", Offset = "0x5D1CDF0", VA = "0x185D1DFF0")]
		public void MarkDirty(HBBMFJHEENA OMEBACPPAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EF20", Offset = "0x5D1DD20", VA = "0x185D1EF20")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LGMMGENNDLD<KeyType> : LNBFGCHLJMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, HBBMFJHEENA> BJDDBJBKEFK;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3946E40", Offset = "0x3945C40", VA = "0x183946E40")]
	public LGMMGENNDLD(string ONIBECKLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3946AD0", Offset = "0x39458D0", VA = "0x183946AD0")]
	public void INOAHDJFGPC(KeyType JLDFGFPAIIN, HBBMFJHEENA HECAGKLPIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3946C60", Offset = "0x3945A60", VA = "0x183946C60")]
	public bool LICEJBDIGFL(KeyType JLDFGFPAIIN, HBBMFJHEENA IDNIOGPGOAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3946B20", Offset = "0x3945920", VA = "0x183946B20")]
	public void KJKLLBOFBNJ(KeyType JLDFGFPAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3946E00", Offset = "0x3945C00", VA = "0x183946E00", Slot = "4")]
	public override void NMHONGPAMFA()
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
