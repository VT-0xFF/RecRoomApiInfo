using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct NDFFLPDJFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int ECKCDHHFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 MCPLMEMBBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion CCFBDBBHEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 FIPDNODMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int INPIEMOHLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int BIIABBCDBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int CBPJIPGLMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float FPIBEHIMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 OMOPGEDNIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool DNGKOAHLPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public CILCICJNGBL IDHGGENHLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 LPBAKCGEEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float PJHGKPDNDLL;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HBEJALPEJBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static MHBBIOHOAEN BPGCIIKNIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<NDFFLPDJFEM> FJDKLIAJOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<LMCBECAHALF> PGBPBFJKBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<GEMMNELCGJL> IODMBDLILEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<KMKPHCINLAN> EMEGFCDBBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<LMCBECAHALF> CGGBONNACLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<PJBDBINLPNB> EIIBBLAIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<KMKPHCINLAN>> IBALHHAOCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<MNIALFGOFCP> FMIMKECKLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> LOCABNAKHNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FJBKCCGNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x826260", Offset = "0x825460", VA = "0x180826260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xFBED00", Offset = "0xFBDF00", VA = "0x180FBED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EFNJJMOBPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x826270", Offset = "0x825470", VA = "0x180826270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x159CF00", Offset = "0x159C100", VA = "0x18159CF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A330", Offset = "0x1D09530", VA = "0x181D0A330")]
	public HBEJALPEJBN(int AFEACEPEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D095D0", Offset = "0x1D087D0", VA = "0x181D095D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D09440", Offset = "0x1D08640", VA = "0x181D09440")]
	public void DIPAICNNLME(JobHandle NOHHECKHGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D091B0", Offset = "0x1D083B0", VA = "0x181D091B0")]
	public void DDBNBEINCOL(NDFFLPDJFEM ADIGGFBANFM, MNIALFGOFCP NOKCHNHMDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D09600", Offset = "0x1D08800", VA = "0x181D09600")]
	public void JIHJNJLIEEP(GEMMNELCGJL ADIGGFBANFM, NativeArray<KMKPHCINLAN> MDHFBNEDMIK, int CHKDMBCENDF, int PNNPIELBFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D09720", Offset = "0x1D08920", VA = "0x181D09720")]
	public JobHandle OCJOJOMOGIF(PDOFANKIOIP NPDJPLEDCDA, ILJMFGEJDLA LMIBFBNGJIN, float3 IBACLPHLMOP, quaternion OADJNNFPOIJ, float EKCFEEGOPMH, bool BLEKMDJFPGL, int KGJMGMEOOHM = 0, int LLAIKMAGPJG = 0)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MPBOHOFEOND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 OHLOJJOAFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 MONHKICKIJF;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HDEGDCAAAOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<MPBOHOFEOND> BIHFPJGGDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> LMEDPLIFDDM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FJBKCCGNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EFNJJMOBPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3A0", Offset = "0x7E95A0", VA = "0x1807EA3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A5F0", Offset = "0x1D097F0", VA = "0x181D0A5F0")]
	public HDEGDCAAAOB(int BJCPGDNACIP, int FNEGKCBANIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A4C0", Offset = "0x1D096C0", VA = "0x181D0A4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A510", Offset = "0x1D09710", VA = "0x181D0A510")]
	public void FGDHAMDMOPA(HDEGDCAAAOB CBJKBEJGKHN, int LHPINOCHPCK, int KKDHFPHHHIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BAGGKKMJGDE
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static HDEGDCAAAOB AHPFOAKMKOF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<LMCBECAHALF> GOKKFMCOFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private const int DFLPCNJEFNI = 5;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static int[] IBKEPODNBFK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static bool KHBNBFOFCCN;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, HDEGDCAAAOB> HPHIEKGBKFH;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static Dictionary<int, HDEGDCAAAOB> LIPHILCFGNJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool KMNKLFMBMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1D02200", Offset = "0x1D01400", VA = "0x181D02200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<LMCBECAHALF> HIIOACHNGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1D02290", Offset = "0x1D01490", VA = "0x181D02290")]
		get
		{
			return default(NativeList<LMCBECAHALF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static HDEGDCAAAOB PBEDOJICHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1D02340", Offset = "0x1D01540", VA = "0x181D02340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D02400", Offset = "0x1D01600", VA = "0x181D02400")]
	public static int CJINNNDEEPA(int GNECEHOOFLL, int ENNIGHKJGKP, int KGKAMEHCDNH, bool AEJKDJKDAJJ, bool CMJELJNLDML, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D01F80", Offset = "0x1D01180", VA = "0x181D01F80")]
	public static int ABCECKOEKNH(int GNECEHOOFLL, int ENNIGHKJGKP, int KGKAMEHCDNH, bool AEJKDJKDAJJ, bool CMJELJNLDML, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D02AD0", Offset = "0x1D01CD0", VA = "0x181D02AD0")]
	private static void HEKMJGLKBFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D037C0", Offset = "0x1D029C0", VA = "0x181D037C0")]
	public static int PIPBABKDBKL(bool ALLFAKLFBBG, int KGKAMEHCDNH, bool AEJKDJKDAJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D02F30", Offset = "0x1D02130", VA = "0x181D02F30")]
	private static int IHIHNFCIPFJ(int KGKAMEHCDNH, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D02F70", Offset = "0x1D02170", VA = "0x181D02F70")]
	private static int LAMKLKCCGGI(int KGKAMEHCDNH, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D03730", Offset = "0x1D02930", VA = "0x181D03730")]
	public static int OFPJFLGKCDA(int ENNIGHKJGKP, int KGKAMEHCDNH, int EFFHNMLDNJP, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D02A30", Offset = "0x1D01C30", VA = "0x181D02A30")]
	public static int FEHBDGBIPGB(int ENNIGHKJGKP, int KGKAMEHCDNH, int EFFHNMLDNJP, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1D02620", Offset = "0x1D01820", VA = "0x181D02620")]
	public static int DLEIKLIHFKD(int EFFHNMLDNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D037F0", Offset = "0x1D029F0", VA = "0x181D037F0")]
	private static int PJGFPPEFKAJ(int KGKAMEHCDNH, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1D02AC0", Offset = "0x1D01CC0", VA = "0x181D02AC0")]
	private static int HALBNGBKNAH(int KGKAMEHCDNH, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D025B0", Offset = "0x1D017B0", VA = "0x181D025B0")]
	public static int CPOFHOKFHNP(int ENNIGHKJGKP, int KGKAMEHCDNH, int EFFHNMLDNJP, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1D02F80", Offset = "0x1D02180", VA = "0x181D02F80")]
	public static int LHLMCGMEMAC(int ENNIGHKJGKP, int KGKAMEHCDNH, int EFFHNMLDNJP, bool KECLBNKFNEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1D02F50", Offset = "0x1D02150", VA = "0x181D02F50")]
	public static int IMJNPIBFPEG(int EFFHNMLDNJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1D02120", Offset = "0x1D01320", VA = "0x181D02120")]
	public static HDEGDCAAAOB ACJKKFFAOGN(int KGKAMEHCDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1D03020", Offset = "0x1D02220", VA = "0x181D03020")]
	private static HDEGDCAAAOB MGLMCADPKGF(int KGKAMEHCDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D03650", Offset = "0x1D02850", VA = "0x181D03650")]
	public static HDEGDCAAAOB MKLLMIMEMLB(int KGKAMEHCDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1D032F0", Offset = "0x1D024F0", VA = "0x181D032F0")]
	private static HDEGDCAAAOB MHDJHKFCLGN(int KGKAMEHCDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1D02630", Offset = "0x1D01830", VA = "0x181D02630")]
	public static void DLICAGOBCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KMKPHCINLAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 AAFOEIIFAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 BMCBDKGAEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float GMDBNAGGBFL;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GEMMNELCGJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public int HBBAOKLCEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3 MCPLMEMBBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public quaternion CCFBDBBHEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float FIPDNODMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float OMBIAJDAGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int INPIEMOHLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int BIIABBCDBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int CBPJIPGLMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool MILCGOLKKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool KDANKEPIGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float FPIBEHIMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float3 OMOPGEDNIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public bool BHAFJJAKLJF;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PJBDBINLPNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int NLELIKECMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int ELFIKDPKGDK;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[BurstCompile]
public struct HAIHEJCAADF : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<MPBOHOFEOND> EFOBDNHPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> COICJFHDCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<LMCBECAHALF> AHMOFLOONDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<GEMMNELCGJL> GBEGDDAFGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<KMKPHCINLAN> LELMIJGGEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<LMCBECAHALF> PJDHDPDJDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<PJBDBINLPNB> EFHFBANMAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int EMMKADCEAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int HELIENAKFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float LNMNDPKLAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion FDGCPOPJEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 FDMOMKMMLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GPGOCIIMDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ACACJCIPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FDCDDALBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FMNADNOONHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NECIAAKGPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BHGJPDLJJPB;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D08EB0", Offset = "0x1D080B0", VA = "0x181D08EB0")]
	public HAIHEJCAADF(HBEJALPEJBN LHINDOBMBIA, PDOFANKIOIP MPENKNHMKFN, float3 GPDABJFNGEI, quaternion MNANGNIODOD, float HDLBMJANHPL, int KGJMGMEOOHM = 0, int LLAIKMAGPJG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1D08730", Offset = "0x1D07930", VA = "0x181D08730")]
	private float3 MODOJCLODPD(float3 PCAHKKKKFEB, Matrix4x4 KOPNMOKCLCG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1D08520", Offset = "0x1D07720", VA = "0x181D08520")]
	private float3x3 GGIAFDCFILD(float3x3 BDAJLKGCCAE, float3x3 LMKEBHFKGKF)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D085A0", Offset = "0x1D077A0", VA = "0x181D085A0")]
	private float KOPHPNLDJGE(float HGMELPNGMLB, float BAGCHOAMOHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1D07260", Offset = "0x1D06460", VA = "0x181D07260", Slot = "4")]
	public void Execute(int PBHKOJIKFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D085B0", Offset = "0x1D077B0", VA = "0x181D085B0")]
	private void LOOFAPCIDFN(int PMKIIEBEPCD, float3 BCCJFEBGGPE, float3 DBLFCAOKHOI, float3 NLDEGMONLPD, float LNOJNMGCCCF, bool JDLMIONJFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1D088D0", Offset = "0x1D07AD0", VA = "0x181D088D0")]
	private void PPOPNAKCLFG(GEMMNELCGJL HHDLHKICPAM, float3 OAFKFLNPFNC, float3x3 AGGJNOPHEAI, float HGMELPNGMLB, int KEKHDAJOELF, int BOGFBGJMKLB, int OEDBGGOOHHD, float EGJEGCJLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1D06C80", Offset = "0x1D05E80", VA = "0x181D06C80")]
	private void CLNDOBHNBEI(ref int PMKIIEBEPCD, ref int NGOCGHIGOJJ, GEMMNELCGJL HHDLHKICPAM, float3 OAFKFLNPFNC, float3x3 AGGJNOPHEAI, bool JNLCNKLPENC, float HGMELPNGMLB, int HMDIEKELMPG, int DPMBOEHAMIP, int OEDBGGOOHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BurstCompile]
public struct PACIGPMGLFB : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private enum CGBOACLCEOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[ReadOnly]
	private NativeList<float3> PCNIDEDLHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ReadOnly]
	private NativeArray<float3> HCGFBBAPIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeList<int> AAGMOCDKLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<int> PELFMKGJLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeArray<float4> HCGLMMFKAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<float4> KDLEJGBKLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> MGMDODJFIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeList<float3> LEMPOMPBCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeList<LMCBECAHALF> OALGJFLIIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<NDFFLPDJFEM> GJADCCKDKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<LMCBECAHALF> HFEAKICHGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private int EMMKADCEAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private int HELIENAKFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GPGOCIIMDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ACACJCIPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FDCDDALBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FMNADNOONHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NECIAAKGPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BHGJPDLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ReadOnly]
	private float3 FDMOMKMMLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[ReadOnly]
	private quaternion FDGCPOPJEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float LNMNDPKLAOF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1D15A20", Offset = "0x1D14C20", VA = "0x181D15A20")]
	public PACIGPMGLFB(HBEJALPEJBN LHINDOBMBIA, PDOFANKIOIP MPENKNHMKFN, float3 GPDABJFNGEI, quaternion MNANGNIODOD, float HDLBMJANHPL, int KGJMGMEOOHM = 0, int LLAIKMAGPJG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1D14860", Offset = "0x1D13A60", VA = "0x181D14860", Slot = "4")]
	public void Execute(int PBHKOJIKFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1D15630", Offset = "0x1D14830", VA = "0x181D15630")]
	private void JFOBPCKAIAA(float4x4 EBGPFEMLMPB, int PBHKOJIKFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1D13020", Offset = "0x1D12220", VA = "0x181D13020")]
	private CGBOACLCEOL BGLHPEMLPDA(float3 DBLFCAOKHOI)
	{
		return default(CGBOACLCEOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1D145C0", Offset = "0x1D137C0", VA = "0x181D145C0")]
	private float4 JKJHAJNCOEF(CGBOACLCEOL CALPPBHMEPO, int MJNAIOAAGCG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1D14610", Offset = "0x1D13810", VA = "0x181D14610")]
	private float2 KMAKOKKNOIE(CGBOACLCEOL CALPPBHMEPO, float3 BCCJFEBGGPE)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EIABDNCJFPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float OMBIAJDAGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float4 NMFDNEJDGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int NHEJCEMFHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool MILCGOLKKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public bool KDANKEPIGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float FPIBEHIMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 OMOPGEDNIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool BHAFJJAKLJF;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct OPDILEKDCEH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<MPBOHOFEOND> MILFPGGLEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<int> BPOCCOGJOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<KMKPHCINLAN> AIJOFKHFHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private EIABDNCJFPM DDJOPJFHLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private float DBEEBJDCFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private float3x3 BOMEPJJAPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private float3 BKJGDAJHDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private Matrix4x4 KOPNMOKCLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private float3x3 LMKEBHFKGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private float BAGCHOAMOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int NKHFAAPMJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int JJBCJFFLEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GPGOCIIMDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ACACJCIPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FDCDDALBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FMNADNOONHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NECIAAKGPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BHGJPDLJJPB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1D12750", Offset = "0x1D11950", VA = "0x181D12750")]
	public OPDILEKDCEH(Transform LEIHADOJCKG, PDOFANKIOIP MPENKNHMKFN, Transform OAHFGNIILPC, NativeList<KMKPHCINLAN> AIJOFKHFHGK, EIABDNCJFPM DDJOPJFHLBD, int NKHFAAPMJFG = 0, int JJBCJFFLEKO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1D11EA0", Offset = "0x1D110A0", VA = "0x181D11EA0")]
	private float3 MODOJCLODPD(float3 PCAHKKKKFEB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1D11C80", Offset = "0x1D10E80", VA = "0x181D11C80")]
	private float3x3 GGIAFDCFILD(float3x3 BDAJLKGCCAE)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1D11D10", Offset = "0x1D10F10", VA = "0x181D11D10")]
	private float KOPHPNLDJGE(float HGMELPNGMLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1D12050", Offset = "0x1D11250", VA = "0x181D12050")]
	private float3 OLECMNIECOA(float3 KBBMBNFNHAE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D111E0", Offset = "0x1D103E0", VA = "0x181D111E0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1D11D20", Offset = "0x1D10F20", VA = "0x181D11D20")]
	private void LOOFAPCIDFN(int PMKIIEBEPCD, float3 BCCJFEBGGPE, float3 DBLFCAOKHOI, float3 NLDEGMONLPD, float LNOJNMGCCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1D121A0", Offset = "0x1D113A0", VA = "0x181D121A0")]
	private void PPOPNAKCLFG(KMKPHCINLAN PHPGPNPNLJC, int KEKHDAJOELF, float EGJEGCJLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1D10CA0", Offset = "0x1D0FEA0", VA = "0x181D10CA0")]
	private void CLNDOBHNBEI(ref int PMKIIEBEPCD, ref int NGOCGHIGOJJ, float3 OAFKFLNPFNC, float3x3 AGGJNOPHEAI, bool JNLCNKLPENC, float HGMELPNGMLB, int HMDIEKELMPG, float EGJEGCJLGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[BurstCompile]
public struct PABEEDALIEL : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private enum DILHFLGDLCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private NativeList<float3> CLAHPJOPAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private NativeArray<float3> JACDBKIEECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private NativeList<int> IKFHNDDPJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private NativeArray<int> OEKIJFLHKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private NativeArray<float4> AAGDHDKPIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private NativeArray<float4> LCICDJDDPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private NativeArray<float4> JEMAJHHNHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	public NativeList<float3> OOGPHEJHLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NBJKLEDLPLJ NHLMLOANCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private int NKHFAAPMJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private int JJBCJFFLEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GPGOCIIMDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ACACJCIPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FDCDDALBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FMNADNOONHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NECIAAKGPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BHGJPDLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private float3 BKJGDAJHDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private float3x3 BOMEPJJAPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private float DBEEBJDCFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private float3 BCCJFEBGGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private quaternion PAOOIKIKMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	private float3 HGMELPNGMLB;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D130E0", Offset = "0x1D122E0", VA = "0x181D130E0")]
	public static PABEEDALIEL CNOGLGNGFED(AILCBLLDEOL ILCGDGAJDBF, NBJKLEDLPLJ GJADCCKDKDA, PDOFANKIOIP MPENKNHMKFN, float HGMELPNGMLB, Transform NJOCCOMMOOL)
	{
		return default(PABEEDALIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1D13370", Offset = "0x1D12570", VA = "0x181D13370")]
	public static PABEEDALIEL CNOGLGNGFED(AILCBLLDEOL ILCGDGAJDBF, Transform KNIENDLPDFD, NBJKLEDLPLJ GJADCCKDKDA, Transform LEIHADOJCKG, PDOFANKIOIP MPENKNHMKFN, int NKHFAAPMJFG, int JJBCJFFLEKO)
	{
		return default(PABEEDALIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1D14650", Offset = "0x1D13850", VA = "0x181D14650")]
	public PABEEDALIEL(AILCBLLDEOL ILCGDGAJDBF, NBJKLEDLPLJ GJADCCKDKDA, PDOFANKIOIP MPENKNHMKFN, int NKHFAAPMJFG, int JJBCJFFLEKO, float DBEEBJDCFPF, float3 BKJGDAJHDHF, float3x3 BOMEPJJAPOB, float3 BCCJFEBGGPE, quaternion PAOOIKIKMBJ, float3 HGMELPNGMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1D13830", Offset = "0x1D12A30", VA = "0x181D13830", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1D14270", Offset = "0x1D13470", VA = "0x181D14270")]
	private void JFOBPCKAIAA(float4x4 EBGPFEMLMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1D13020", Offset = "0x1D12220", VA = "0x181D13020")]
	private DILHFLGDLCG BGLHPEMLPDA(float3 DBLFCAOKHOI)
	{
		return default(DILHFLGDLCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1D145C0", Offset = "0x1D137C0", VA = "0x181D145C0")]
	private float4 JKJHAJNCOEF(DILHFLGDLCG CALPPBHMEPO, int MJNAIOAAGCG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1D14610", Offset = "0x1D13810", VA = "0x181D14610")]
	private float2 KMAKOKKNOIE(DILHFLGDLCG CALPPBHMEPO, float3 BCCJFEBGGPE)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MNIALFGOFCP
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ADOGBAFHAKC
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static MNIALFGOFCP NPKBEJHDJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public float3 AAFOEIIFAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public float3x3 BMCBDKGAEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public float3 FFGCGCCOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public ADOGBAFHAKC IHACIPDHDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public float3 GAHBCLGMCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public float3 HKAPEJDNDHE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1D10AD0", Offset = "0x1D0FCD0", VA = "0x181D10AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 PEMAIBJJMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1D0FEF0", Offset = "0x1D0F0F0", VA = "0x181D0FEF0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1D10B60", Offset = "0x1D0FD60", VA = "0x181D10B60")]
	public MNIALFGOFCP(float3 BCCJFEBGGPE, quaternion PAOOIKIKMBJ, float3 DFCIFDODMGE, ADOGBAFHAKC BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D10490", Offset = "0x1D0F690", VA = "0x181D10490")]
	public float KOHNJAACKKN(float3 OAFKFLNPFNC, float IMJHEAJNKKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1D0FDB0", Offset = "0x1D0EFB0", VA = "0x181D0FDB0")]
	public bool HKDPDHDJAMG(float3 DBLFCAOKHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1D10730", Offset = "0x1D0F930", VA = "0x181D10730")]
	public void MALFPAFCACF(float3 BKJGDAJHDHF, float3x3 BPLDHCAKEIG, float MNCJIPJDOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1D10030", Offset = "0x1D0F230", VA = "0x181D10030")]
	private void JBOJMJJKHHJ(float3 FPDOMCKPEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1D101B0", Offset = "0x1D0F3B0", VA = "0x181D101B0")]
	public void JFFLLLNMFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1D10910", Offset = "0x1D0FB10", VA = "0x181D10910")]
	public static void MBFCHMMHAIG(Transform NJOCCOMMOOL, out float3 BKJGDAJHDHF, out float3x3 BPLDHCAKEIG, out float MNCJIPJDOBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DEJIECPKCGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int OGOMPPAFFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int EFNJJMOBPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int FFDLACFGBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int FJBKCCGNMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int GHJGANFCHFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct AACKNIEHEBG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private const float HBJPCECHJEP = 0.002f;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private const float HMEBNPIBFOP = 0.02f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<MNIALFGOFCP> ADIGGFBANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<float3> IOGKJDMDHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private NativeList<int> OHIFGOLKNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LOCABNAKHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<LMCBECAHALF> HFEAKICHGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	private int OEGEECMCJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private int PBLDIBEFFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private float IMJHEAJNKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float DIHOHDPFFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> PAODJDHOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> ALNKJLCPEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> BMCFFNBAMJN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1D00AA0", Offset = "0x1CFFCA0", VA = "0x181D00AA0")]
	public AACKNIEHEBG(PDOFANKIOIP EICLBLAAFOL, float DBEEBJDCFPF, int KKDHFPHHHIP, int KEKHDAJOELF, NativeList<MNIALFGOFCP> ADIGGFBANFM, NativeArray<int> LOCABNAKHNG, NativeList<LMCBECAHALF> HFEAKICHGKA, ILJMFGEJDLA LMIBFBNGJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1CFFEB0", Offset = "0x1CFF0B0", VA = "0x181CFFEB0", Slot = "4")]
	public void Execute(int LODLAAKECJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1D00690", Offset = "0x1CFF890", VA = "0x181D00690")]
	private bool GELBLJAJLOC(MNIALFGOFCP PJIOBOBOEGF, MNIALFGOFCP KLGGEDCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1D00760", Offset = "0x1CFF960", VA = "0x181D00760")]
	private bool HIADLDICNKN(MNIALFGOFCP NMCOJHAIJEG, int LFFOLLMHCCE, int LOKAHEBCOIE, int HECFGGMGOAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BurstCompile]
public struct IGCLAHIDNMP : IJob
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private const float HBJPCECHJEP = 0.002f;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private const float HMEBNPIBFOP = 0.02f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeList<MNIALFGOFCP> ADIGGFBANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> IOGKJDMDHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<int> OHIFGOLKNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private int KKDHFPHHHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private int PNNPIELBFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int KEKHDAJOELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int CHKDMBCENDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float IMJHEAJNKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private float DIHOHDPFFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private float3 OGJBMBKCBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private float3 GKFLMHJFNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private MNIALFGOFCP.ADOGBAFHAKC NNJAGNAKGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> PAODJDHOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> ALNKJLCPEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> BMCFFNBAMJN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DED0", Offset = "0x1D0D0D0", VA = "0x181D0DED0")]
	public IGCLAHIDNMP(MNIALFGOFCP HKDNNNKILDL, PDOFANKIOIP EICLBLAAFOL, float DBEEBJDCFPF, int KKDHFPHHHIP, int PNNPIELBFNN, int KEKHDAJOELF, int CHKDMBCENDF, NativeList<MNIALFGOFCP> ADIGGFBANFM, ILJMFGEJDLA LMIBFBNGJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D6F0", Offset = "0x1D0C8F0", VA = "0x181D0D6F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DAC0", Offset = "0x1D0CCC0", VA = "0x181D0DAC0")]
	private bool FINACPKEGKB(MNIALFGOFCP NMCOJHAIJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DB90", Offset = "0x1D0CD90", VA = "0x181D0DB90")]
	private bool HIADLDICNKN(MNIALFGOFCP NMCOJHAIJEG, int LFFOLLMHCCE, int LOKAHEBCOIE, int HECFGGMGOAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ILJMFGEJDLA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public NativeArray<bool> DCDAAIAHIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public NativeArray<int> ABKMEJPLDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public NativeArray<bool> IGJOJKLNIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NativeArray<float> ICGCONFMFNH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E0C0", Offset = "0x1D0D2C0", VA = "0x181D0E0C0")]
	public void OKPPMECPMKM(int BJCPGDNACIP, int FNEGKCBANIF, Allocator MKFODJKMOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E090", Offset = "0x1D0D290", VA = "0x181D0E090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DFB0", Offset = "0x1D0D1B0", VA = "0x181D0DFB0")]
	public void DIPAICNNLME(JobHandle NOHHECKHGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public ILJMFGEJDLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[BurstCompile]
public struct KEIIKIEFNLJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private NativeList<float3> IOGKJDMDHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NativeArray<float3> IOPPGLPNGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<float4> HMMEFNKFHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<float2> EJCLIHCHMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeList<int> OHIFGOLKNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HPGJDIODGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> IHLKFMLNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ReadOnly]
	private NativeArray<bool> PAODJDHOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ReadOnly]
	private NativeArray<bool> ALNKJLCPEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[ReadOnly]
	private int KGJMGMEOOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[ReadOnly]
	private int LLAIKMAGPJG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F770", Offset = "0x1D0E970", VA = "0x181D0F770")]
	public KEIIKIEFNLJ(PDOFANKIOIP EICLBLAAFOL, ILJMFGEJDLA LMIBFBNGJIN, int LLAIKMAGPJG = 0, int KGJMGMEOOHM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F3E0", Offset = "0x1D0E5E0", VA = "0x181D0F3E0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F390", Offset = "0x1D0E590", VA = "0x181D0F390")]
	private void DBAKNGMEMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OHCJGFOOLPB
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1860", Offset = "0x3AE0A60", VA = "0x183AE1860")]
	public static bool FFBLLCICMMN<T>(ref NativeArray<T> NAJOFPKLJJG, int DFCIFDODMGE, Allocator MKFODJKMOCC, NativeArrayOptions CKKKILJPPHH = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1910", Offset = "0x3AE0B10", VA = "0x183AE1910")]
	public static bool FFBLLCICMMN<T>(ref NativeList<T> MDBHJOENILE, int DFCIFDODMGE, Allocator MKFODJKMOCC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum DDAFJOJEIDO
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	None
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KAKFFKFHJLL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IEnumerable<MKKHEKFHCDH> IOIEHPFCKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int CLMNELBOECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CBGKELEJBJC DNMLMNAIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface MKKHEKFHCDH
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CJINNNDEEPA(DDAFJOJEIDO ENNIGHKJGKP);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ABCECKOEKNH(DDAFJOJEIDO ENNIGHKJGKP);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLPHJCIHLKF(DDAFJOJEIDO ENNIGHKJGKP, HBEJALPEJBN AJEGKIENOEL, int MFFJLFEJEEM = -1);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PDOFANKIOIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const int MDHJNPGNGLD = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NativeList<float3> EBPOPGNAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NativeArray<float3> ECLBHFMLAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NativeArray<float4> GJMKLCECNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public NativeArray<float4> GAOLHMAJMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public NativeArray<float2> FGGBJEPGGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public NativeList<int> FDPBINEFLOL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool AEDNLGNMBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1D16B00", Offset = "0x1D15D00", VA = "0x181D16B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FJBKCCGNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1D16310", Offset = "0x1D15510", VA = "0x181D16310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int EFNJJMOBPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1D166B0", Offset = "0x1D158B0", VA = "0x181D166B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MJHCICDIEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D16350", Offset = "0x1D15550", VA = "0x181D16350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1D16390", Offset = "0x1D15590", VA = "0x181D16390", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D16B40", Offset = "0x1D15D40", VA = "0x181D16B40")]
	public void OKPPMECPMKM(int BJCPGDNACIP, int FNEGKCBANIF, Allocator MKFODJKMOCC, bool PAPECCLPOKA, bool JHJJKJBOPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D16A90", Offset = "0x1D15C90", VA = "0x181D16A90")]
	public void NIBFBJJIGIM(int BJCPGDNACIP, int FNEGKCBANIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D166F0", Offset = "0x1D158F0", VA = "0x181D166F0")]
	public bool ILKCIGODDID(Mesh EICLBLAAFOL, bool EAPFNKBNHAP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D15BE0", Offset = "0x1D14DE0", VA = "0x181D15BE0")]
	public bool ANOBBAHGNCP(Mesh EICLBLAAFOL, PDOFANKIOIP MIICINIJPDN, bool EAPFNKBNHAP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D16470", Offset = "0x1D15670", VA = "0x181D16470")]
	public void FGDHAMDMOPA(PDOFANKIOIP EICLBLAAFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public PDOFANKIOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JLFHFAEDLEH
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F230", Offset = "0x1D0E430", VA = "0x181D0F230")]
	public static void DLICAGOBCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AILCBLLDEOL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public NativeList<float3> EBPOPGNAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<float3> ECLBHFMLAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> KHKGMCKMILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<float4> CEBPGGDGLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float4> DNNAPFCEJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public NativeArray<float4> CEGIDBPDMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public NativeList<float3> EIEEMOLOBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public NativeList<int> FDPBINEFLOL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FJBKCCGNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1D00B40", Offset = "0x1CFFD40", VA = "0x181D00B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EFNJJMOBPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1D00F60", Offset = "0x1D00160", VA = "0x181D00F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int KPBOMBBDODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1D00C50", Offset = "0x1CFFE50", VA = "0x181D00C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D01AA0", Offset = "0x1D00CA0", VA = "0x181D01AA0")]
	public AILCBLLDEOL(int BJCPGDNACIP, int FNEGKCBANIF, int MAJKDKKKLOL, Allocator MKFODJKMOCC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D01C90", Offset = "0x1D00E90", VA = "0x181D01C90")]
	public AILCBLLDEOL(Mesh EICLBLAAFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D00B80", Offset = "0x1CFFD80", VA = "0x181D00B80", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1D00C90", Offset = "0x1CFFE90", VA = "0x181D00C90")]
	public void FGDHAMDMOPA(AILCBLLDEOL EICLBLAAFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D00FA0", Offset = "0x1D001A0", VA = "0x181D00FA0")]
	private void MLOMDMGJBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1D01420", Offset = "0x1D00620", VA = "0x181D01420")]
	private void PJOPJBLLPNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LMCBECAHALF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public int FFDLACFGBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public int FJBKCCGNMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int OGOMPPAFFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public int EFNJJMOBPFB;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1A63520", Offset = "0x1A62720", VA = "0x181A63520")]
	public LMCBECAHALF(int KEKHDAJOELF, int CHKDMBCENDF, int KKDHFPHHHIP, int PNNPIELBFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MHBBIOHOAEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<LMCBECAHALF> ABFJFNHNNCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD290", Offset = "0x6FC490", VA = "0x1806FD290")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LMCBECAHALF>);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD280", Offset = "0x6FC480", VA = "0x1806FD280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AILCBLLDEOL GJBHPMDMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F860", Offset = "0x1D0EA60", VA = "0x181D0F860")]
	public MHBBIOHOAEN(IEnumerable<AILCBLLDEOL> DOMDGLHBAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F7F0", Offset = "0x1D0E9F0", VA = "0x181D0F7F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum CILCICJNGBL
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NBJKLEDLPLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public float4 NMFDNEJDGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public float FPIBEHIMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float3 OMOPGEDNIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool DNGKOAHLPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public CILCICJNGBL IDHGGENHLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public float3 LPBAKCGEEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public float PJHGKPDNDLL;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D10C50", Offset = "0x1D0FE50", VA = "0x181D10C50")]
	public NBJKLEDLPLJ(float4 CLOLPMPMNPC, CILCICJNGBL NEFNOJDDIKG, float3 DNFCBHMBBDL, float GMJEKALNDOK, float GGLMBJPOPAA, float3 DLNBBMMHNIO, bool BHJEEEDMGLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FCDINIMPCPL
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private const int KLDDNAPOEBD = 100;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static NativeArray<float2> HBLJDNECIEA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static NativeArray<float3> JDNEJNGIHCF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static NativeArray<float4> FAMJMHAGLLN;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static NativeArray<int> BEIIFJHGAJA;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D06890", Offset = "0x1D05A90", VA = "0x181D06890")]
	public static void DLICAGOBCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D069B0", Offset = "0x1D05BB0", VA = "0x181D069B0")]
	public static NativeArray<float2> EFCGGIKJOPE(NativeArray<float2> EACIGGGBEOP, int EEOCAFIKKEG, NativeArray<float2> DLHIGMPHLDL, int NNFADJFKPDK)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1D06B90", Offset = "0x1D05D90", VA = "0x181D06B90")]
	public static NativeArray<float3> INPECFEJEIO(NativeArray<float3> EACIGGGBEOP, int EEOCAFIKKEG, NativeArray<float3> DLHIGMPHLDL, int NNFADJFKPDK)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1D067A0", Offset = "0x1D059A0", VA = "0x181D067A0")]
	public static NativeArray<float4> AGCODGCKCCK(NativeArray<float4> EACIGGGBEOP, int EEOCAFIKKEG, NativeArray<float4> DLHIGMPHLDL, int NNFADJFKPDK)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1D06AA0", Offset = "0x1D05CA0", VA = "0x181D06AA0")]
	public static NativeArray<int> HLBNLGPJFCO(NativeArray<int> EACIGGGBEOP, int EEOCAFIKKEG, NativeArray<int> DLHIGMPHLDL, int NNFADJFKPDK)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4552FC0", Offset = "0x45521C0", VA = "0x184552FC0")]
	private static void DGIJDGJEIND<T>(ref NativeArray<T> NAJOFPKLJJG, int KFOAGFOOEMK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4553050", Offset = "0x4552250", VA = "0x184553050")]
	private static void PHPKHEBKBEL<T>(NativeArray<T> EACIGGGBEOP, int EEOCAFIKKEG, NativeArray<T> DLHIGMPHLDL, int NNFADJFKPDK, NativeArray<T> IIAMIFOCFPI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EFJDJGEDIOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly List<MKKHEKFHCDH> DBJAENPKIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int CHKDMBCENDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int PNNPIELBFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool PCKMJAHLBJH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Mesh GJBHPMDMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int FJBKCCGNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1D06410", Offset = "0x1D05610", VA = "0x181D06410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xEE8060", Offset = "0xEE7260", VA = "0x180EE8060")]
	public void FCAINIGBGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1D066E0", Offset = "0x1D058E0", VA = "0x181D066E0")]
	public EFJDJGEDIOE(string JFLKGPEABBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1D06430", Offset = "0x1D05630", VA = "0x181D06430")]
	public void DIPAICNNLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1D064C0", Offset = "0x1D056C0", VA = "0x181D064C0")]
	public void JGADOOBCNLH(MKKHEKFHCDH EHPGPEPIJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1D058F0", Offset = "0x1D04AF0", VA = "0x181D058F0")]
	private void APDHNNIGKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1D06670", Offset = "0x1D05870", VA = "0x181D06670")]
	public bool OJAELLANOOF(MKKHEKFHCDH EHPGPEPIJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1D06460", Offset = "0x1D05660", VA = "0x181D06460")]
	public bool HIPEHFAIGLD(MKKHEKFHCDH EHPGPEPIJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1D063C0", Offset = "0x1D055C0", VA = "0x181D063C0", Slot = "4")]
	public virtual void CANDNFPNCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1D06620", Offset = "0x1D05820", VA = "0x181D06620")]
	public void OAPNJDBDNBF(Transform NJOCCOMMOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1D05B10", Offset = "0x1D04D10", VA = "0x181D05B10")]
	public bool APJPPDCMDNP(Transform NJOCCOMMOOL, out (PDOFANKIOIP destMesh, Mesh mesh, JobHandle job) ADIGGFBANFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1D06570", Offset = "0x1D05770", VA = "0x181D06570")]
	public void LFFHKBCGNHD(in (PDOFANKIOIP destMesh, Mesh mesh, JobHandle job) ADIGGFBANFM)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly ProfilerMarker JAILBHONEPD;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly ProfilerMarker LEGLFIMELPI;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ProfilerMarker HCMMJFHBJDM;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private const int AHDBGAGDIKH = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<Material, List<EFJDJGEDIOE>> JMNKOLHJAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private List<EFJDJGEDIOE> CIHIFJHMLND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<MeshRenderer> HINJMBIKMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private List<(EFJDJGEDIOE, (PDOFANKIOIP, Mesh, JobHandle))> PILFJCHKENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private bool EDLOKIHJLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Dictionary<int, float> JCDCIBJFBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private Dictionary<int, Color> KJOBKKDFLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private Dictionary<int, Vector4> JPOJEMPNALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Dictionary<int, Matrix4x4> FKOCMPJHEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private EFJDJGEDIOE BKJMFAINACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private Material IGBMCMADNEP;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyList<MeshRenderer> LFEANOAMGLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1D04E10", Offset = "0x1D04010", VA = "0x181D04E10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1D03900", Offset = "0x1D02B00", VA = "0x181D03900")]
		public void AddToBatchedMesh(MKKHEKFHCDH IJNBNCHMOEE, Material CEMALPIHFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1D04F30", Offset = "0x1D04130", VA = "0x181D04F30")]
		public void RemoveFromBatchedMesh(MKKHEKFHCDH EICLBLAAFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1D03F20", Offset = "0x1D03120", VA = "0x181D03F20")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1D053C0", Offset = "0x1D045C0", VA = "0x181D053C0")]
		public void SetMaterialProperty(int FMBNLFNGBEI, Color JGDHNJNCLMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1D05530", Offset = "0x1D04730", VA = "0x181D05530")]
		public void SetMaterialProperty(int FMBNLFNGBEI, float ADBNEBBHMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1D05090", Offset = "0x1D04290", VA = "0x181D05090")]
		public void SetMaterialProperty(int FMBNLFNGBEI, Vector4 GAMEFPCEHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1D05200", Offset = "0x1D04400", VA = "0x181D05200")]
		public void SetMaterialProperty(int FMBNLFNGBEI, Matrix4x4 NIJKPBGPJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D039D0", Offset = "0x1D02BD0", VA = "0x181D039D0")]
		private void CJINBBECJAE(Renderer KJOPNCBPHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D04090", Offset = "0x1D03290", VA = "0x181D04090")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D04420", Offset = "0x1D03620", VA = "0x181D04420")]
		private void JNNJMKEFCGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D048A0", Offset = "0x1D03AA0", VA = "0x181D048A0")]
		private EFJDJGEDIOE LGONPFFNINE(MKKHEKFHCDH EICLBLAAFOL, Material CEMALPIHFNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D04A70", Offset = "0x1D03C70", VA = "0x181D04A70")]
		private EFJDJGEDIOE MOONGCDHABD(Material CEMALPIHFNA, int BFKFMHANAAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D040A0", Offset = "0x1D032A0", VA = "0x181D040A0")]
		private EFJDJGEDIOE JNLBDMBDGLC(Material CEMALPIHFNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D04C40", Offset = "0x1D03E40", VA = "0x181D04C40")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D04CB0", Offset = "0x1D03EB0", VA = "0x181D04CB0")]
		public void MarkDirty(MKKHEKFHCDH EICLBLAAFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D05730", Offset = "0x1D04930", VA = "0x181D05730")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BHJNAGLIFPE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int GCDLCFHABDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FOFBCNAACJP(int PBHKOJIKFGJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion JLMLEFLPLPJ(int PBHKOJIKFGJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float IMOGBMKEBPO(int PBHKOJIKFGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IBIBMCMDANK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct CAEKDLBBGPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Vector3 AAFOEIIFAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Quaternion BMCBDKGAEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float GMDBNAGGBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Quaternion LJFPOBBCOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public float HBBCBDFEMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public float OLFHAHAEAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public float MPJKCPJIPAK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static List<CAEKDLBBGPL> LPNKOLHAPHB;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A9C0", Offset = "0x1D09BC0", VA = "0x181D0A9C0")]
	public static NativeList<KMKPHCINLAN> JFHJCAJKDEN(BHJNAGLIFPE LFBIOJBBNIJ)
	{
		return default(NativeList<KMKPHCINLAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C710", Offset = "0x1D0B910", VA = "0x181D0C710")]
	private static bool OOLFKCAINDB(int OCLFFJGEIJK, NativeList<KMKPHCINLAN> LHPJBAGJLHP, List<CAEKDLBBGPL> LKBLEBOCKEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A7E0", Offset = "0x1D099E0", VA = "0x181D0A7E0")]
	private static KMKPHCINLAN IIDLCLDDOJM(int PBHKOJIKFGJ, List<CAEKDLBBGPL> LKBLEBOCKEN)
	{
		return default(KMKPHCINLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C230", Offset = "0x1D0B430", VA = "0x181D0C230")]
	private static KMKPHCINLAN OMGBFJNGIAD(int PBHKOJIKFGJ, List<CAEKDLBBGPL> LKBLEBOCKEN)
	{
		return default(KMKPHCINLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A6B0", Offset = "0x1D098B0", VA = "0x181D0A6B0")]
	private static KMKPHCINLAN EIHOEDFDAPE(Vector3 OAFKFLNPFNC, Quaternion AGGJNOPHEAI, float LNOJNMGCCCF)
	{
		return default(KMKPHCINLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B020", Offset = "0x1D0A220", VA = "0x181D0B020")]
	public static NativeList<KMKPHCINLAN> MFBBHDEDGJL(BHJNAGLIFPE LFBIOJBBNIJ, float OMKNMLONEKO)
	{
		return default(NativeList<KMKPHCINLAN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JHCMFEKLAPB
{
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static Vector3 PLHKOFONFPE;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static Vector3 PGJJEACGGLJ;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EAB0", Offset = "0x1D0DCB0", VA = "0x181D0EAB0")]
	public static Vector3 EGDDOIDHBLA(Quaternion PAOOIKIKMBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EE70", Offset = "0x1D0E070", VA = "0x181D0EE70")]
	public static Vector3 HIJBPJADBJL(Quaternion PAOOIKIKMBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E9C0", Offset = "0x1D0DBC0", VA = "0x181D0E9C0")]
	public static Quaternion DNMBNIHMBHK(Vector3 KJGKDNLKBAL, Vector3 DBLFCAOKHOI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EF50", Offset = "0x1D0E150", VA = "0x181D0EF50")]
	public static Vector3 KCEPHAINCNA(Vector3 EFAFGFDKFCL, Vector3 AEFIHJDPMIA, Vector3 DBLFCAOKHOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E790", Offset = "0x1D0D990", VA = "0x181D0E790")]
	public static Vector3 DCHFPCLLJIP(Vector3 GKINNEEFNHM, Vector3 DBLFCAOKHOI, Quaternion PAOOIKIKMBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EB90", Offset = "0x1D0DD90", VA = "0x181D0EB90")]
	public static Quaternion HEJAIHHFLAE(Quaternion AGGJNOPHEAI, Vector3 KJGKDNLKBAL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GMICFHNOJAH<KeyType> : EFJDJGEDIOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<KeyType, MKKHEKFHCDH> CKOOJLBCFOG;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x44E2D60", Offset = "0x44E1F60", VA = "0x1844E2D60")]
	public GMICFHNOJAH(string JFLKGPEABBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x44E2B90", Offset = "0x44E1D90", VA = "0x1844E2B90")]
	public void JGADOOBCNLH(KeyType JCNAPFOCJDI, MKKHEKFHCDH EHPGPEPIJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x44E2CA0", Offset = "0x44E1EA0", VA = "0x1844E2CA0")]
	public bool KLKELGNECBM(KeyType JCNAPFOCJDI, MKKHEKFHCDH NODKMKCBDMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x44E2A30", Offset = "0x44E1C30", VA = "0x1844E2A30")]
	public void CAILMJCJDIF(KeyType JCNAPFOCJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x44E2B50", Offset = "0x44E1D50", VA = "0x1844E2B50", Slot = "4")]
	public override void CANDNFPNCNO()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E4D0", Offset = "0x1D0D6D0", VA = "0x181D0E4D0")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E1A0", Offset = "0x1D0D3A0", VA = "0x181D0E1A0")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
