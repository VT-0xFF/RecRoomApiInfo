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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ABKMBLPFLPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int KLDFOEGIOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 PFIPPOPALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion CNDPFNJHDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 DHOMDEHAOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int LFJDLLMANNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int EGNDENEKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int LINJNGFKIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float ACOOCBBAHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 IMKAKIKOKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool BBHOGDKGKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public EBJLMDNPGNO AOFNPIHHFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 ILEAOHBFNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float MJEGBICDHJM;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KCEIJKCLJEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static CHBIFHOLPBJ KLNIHFMENKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<ABKMBLPFLPG> OFBLBOIFPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<MAEDAELIDON> PJOLAPOLKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<ALEGOEMKEBB> LCACDPCIKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<KHOFDKJIMMJ> LOEHAIKLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<MAEDAELIDON> HKAPNGGHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<NELLNKNGCPN> KCABONACANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<KHOFDKJIMMJ>> PGBHPJNBGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<DNELJBPIEHN> CEDMNNOKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> JKAFIFPBFNK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GNOHGDFLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB98B60", Offset = "0xB97F60", VA = "0x180B98B60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB981A0", Offset = "0xB975A0", VA = "0x180B981A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB98B70", Offset = "0xB97F70", VA = "0x180B98B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB98190", Offset = "0xB97590", VA = "0x180B98190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B070", Offset = "0x5E5A470", VA = "0x185E5B070")]
	public KCEIJKCLJEC(int OIFHGFDKDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A530", Offset = "0x5E59930", VA = "0x185E5A530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A550", Offset = "0x5E59950", VA = "0x185E5A550")]
	public void FJNCMFNOBDL(JobHandle ALPBNEDDHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A9D0", Offset = "0x5E59DD0", VA = "0x185E5A9D0")]
	public void FKMBFOPDDPN(ABKMBLPFLPG KKOACPFFAML, DNELJBPIEHN EJMEHDCAMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5ABF0", Offset = "0x5E59FF0", VA = "0x185E5ABF0")]
	public void HINOHCCAMMI(ALEGOEMKEBB KKOACPFFAML, NativeArray<KHOFDKJIMMJ> PEJGLFKMHFP, int OHMLLCELOAI, int MPIKDMCFKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E59520", Offset = "0x5E58920", VA = "0x185E59520")]
	public JobHandle ANKGKMLLGLO(OEHGBLLJPLO AHGAKJHGCJO, DMLHOGODMFL ABAGKOIHPKA, float3 DHHOOMMPNGB, quaternion HHBINENECFJ, float JIENKPEFAMI, bool MIJHALOKOCB, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AD30", Offset = "0x5E5A130", VA = "0x185E5AD30")]
	public static JobHandle MADAELICKJP(FMKEHFJGEGE LOGOAFJFDOC, OEHGBLLJPLO AHGAKJHGCJO, ABKMBLPFLPG KKOACPFFAML, JobHandle ALPBNEDDHKE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A720", Offset = "0x5E59B20", VA = "0x185E5A720")]
	public static JobHandle FKGKNIFMLGP(IMAALBJILME LOGOAFJFDOC, OEHGBLLJPLO AHGAKJHGCJO, ALEGOEMKEBB KKOACPFFAML, NativeArray<KHOFDKJIMMJ> PEJGLFKMHFP, int OHMLLCELOAI, int MPIKDMCFKKF, JobHandle ALPBNEDDHKE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ICIKOGJAAOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 ABGKMLNHNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 DPCBAHGNEDF;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OCMMNELBCGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ICIKOGJAAOD> JFNPGGFHOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> LBBFGCPGLFF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GNOHGDFLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x770C30", Offset = "0x770030", VA = "0x180770C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77B2F0", Offset = "0x77A6F0", VA = "0x18077B2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E617D0", Offset = "0x5E60BD0", VA = "0x185E617D0")]
	public OCMMNELBCGD(int IBKPKDGCLCA, int HHGPGPKHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E61770", Offset = "0x5E60B70", VA = "0x185E61770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E61690", Offset = "0x5E60A90", VA = "0x185E61690")]
	public void DAIHEFLJOCM(OCMMNELBCGD IKLOBGLLKIL, int NHBIDNBDLAH, int HHKMAFFMIKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MNMONCKDEDF
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static OCMMNELBCGD HAAKAHMHDHE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<MAEDAELIDON> IMLIIILAPML;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] JFCIKLODAHM;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool OHGDHJDAAPA;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, OCMMNELBCGD> DEDFONFIOLP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, OCMMNELBCGD> JJMCGBLLPHL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool GINJAIDPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E280", Offset = "0x5E5D680", VA = "0x185E5E280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<MAEDAELIDON> KMJNOFDMBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F150", Offset = "0x5E5E550", VA = "0x185E5F150")]
		get
		{
			return default(NativeList<MAEDAELIDON>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static OCMMNELBCGD BJNDFJALNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EA20", Offset = "0x5E5DE20", VA = "0x185E5EA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E410", Offset = "0x5E5D810", VA = "0x185E5E410")]
	private static void GNHIPBDNLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E240", Offset = "0x5E5D640", VA = "0x185E5E240")]
	public static int EBLIGHBCHGG(bool HLLHNOAJEHO, int JNABAFMMPPI, bool MGFIHAHOGCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F130", Offset = "0x5E5E530", VA = "0x185E5F130")]
	private static int ONLIKOHHBAG(int JNABAFMMPPI, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E270", Offset = "0x5E5D670", VA = "0x185E5E270")]
	private static int FEIIFOIBCDE(int JNABAFMMPPI, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EE10", Offset = "0x5E5E210", VA = "0x185E5EE10")]
	public static int JEGFANLDDKP(int MDIGKGAIJFE, int JNABAFMMPPI, int FPOLHGKNDHH, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EEA0", Offset = "0x5E5E2A0", VA = "0x185E5EEA0")]
	public static int JIPALHOLFEM(int MDIGKGAIJFE, int JNABAFMMPPI, int FPOLHGKNDHH, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EAC0", Offset = "0x5E5DEC0", VA = "0x185E5EAC0")]
	public static int HKHNLOBNDAF(int FPOLHGKNDHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EF30", Offset = "0x5E5E330", VA = "0x185E5EF30")]
	private static int LFGIIHGFMDE(int JNABAFMMPPI, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DB80", Offset = "0x5E5CF80", VA = "0x185E5DB80")]
	private static int CDMOFKAJGFJ(int JNABAFMMPPI, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F0C0", Offset = "0x5E5E4C0", VA = "0x185E5F0C0")]
	public static int NMJNGFNJHIO(int MDIGKGAIJFE, int JNABAFMMPPI, int FPOLHGKNDHH, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EF40", Offset = "0x5E5E340", VA = "0x185E5EF40")]
	public static int MEIGMLMOBCB(int MDIGKGAIJFE, int JNABAFMMPPI, int FPOLHGKNDHH, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E3F0", Offset = "0x5E5D7F0", VA = "0x185E5E3F0")]
	public static int FOOJFGPDFIF(int FPOLHGKNDHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E300", Offset = "0x5E5D700", VA = "0x185E5E300")]
	public static OCMMNELBCGD FKCCNLNDLPK(int JNABAFMMPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DBA0", Offset = "0x5E5CFA0", VA = "0x185E5DBA0")]
	private static OCMMNELBCGD CFDILOPOMOE(int JNABAFMMPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EFD0", Offset = "0x5E5E3D0", VA = "0x185E5EFD0")]
	public static OCMMNELBCGD MOGPGIJGLPC(int JNABAFMMPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EAD0", Offset = "0x5E5DED0", VA = "0x185E5EAD0")]
	private static OCMMNELBCGD IFMDOGLKDAE(int JNABAFMMPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DE30", Offset = "0x5E5D230", VA = "0x185E5DE30")]
	public static void DHFGLODJHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ALEGOEMKEBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int NPBOFJBLCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 PFIPPOPALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion CNDPFNJHDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float DHOMDEHAOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float AKIIEKDONLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int LFJDLLMANNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int EGNDENEKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int LINJNGFKIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool OGNKDOIOCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool DHHMMKFIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float ACOOCBBAHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 IMKAKIKOKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool GBNPBGGBCOD;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NELLNKNGCPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int CBPIHBGNBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int CCADIOMGIAA;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IMAALBJILME : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<ALEGOEMKEBB> NNLJMHJFANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<KHOFDKJIMMJ> NHADIJHHLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<MAEDAELIDON> AJJBKCOODPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<NELLNKNGCPN> FDMIIFDOLCE;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E593F0", Offset = "0x5E587F0", VA = "0x185E593F0")]
	public IMAALBJILME(NativeArray<KHOFDKJIMMJ> NHADIJHHLNL, int PEGIIHFIAHP = 1, Allocator LJHPECEMAME = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E59300", Offset = "0x5E58700", VA = "0x185E59300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct LIGFCDIMHHP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<ICIKOGJAAOD> PEHCLEBEGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> JDJJDFGIEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<MAEDAELIDON> CHNPIAHDJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<ALEGOEMKEBB> NNLJMHJFANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<KHOFDKJIMMJ> NHADIJHHLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<MAEDAELIDON> AJJBKCOODPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<NELLNKNGCPN> FDMIIFDOLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int HAHGJMPMNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int LILAIPKIKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 NHFCHECIOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion KMDFPMPPJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 NLMLEGLCKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BBFJGKDMLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EOEHHIBEOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GJGJODJPHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GEIEICKFLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> DFLAKIENJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> COAJJLDIFKC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D6C0", Offset = "0x5E5CAC0", VA = "0x185E5D6C0")]
	public LIGFCDIMHHP(KCEIJKCLJEC FKMMNLEENJA, OEHGBLLJPLO BNKEOBMCGDL, float3 ACEENOKIOOG, quaternion LFCJDBNGGAH, float KNFDJEMEIGD, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D950", Offset = "0x5E5CD50", VA = "0x185E5D950")]
	public LIGFCDIMHHP(IMAALBJILME FKMMNLEENJA, OEHGBLLJPLO BNKEOBMCGDL, float3 ACEENOKIOOG, quaternion LFCJDBNGGAH, float3 KNFDJEMEIGD, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B740", Offset = "0x5E5AB40", VA = "0x185E5B740")]
	private float3 BHGDGDPPLOI(float3 LJIEBJONHKL, Matrix4x4 LACKHELHMIM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CA10", Offset = "0x5E5BE10", VA = "0x185E5CA10")]
	private float3x3 GMOLFGBMFPH(float3x3 AKDJHKILGAI, float3x3 EDFEEEDLIAM)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CEF0", Offset = "0x5E5C2F0", VA = "0x185E5CEF0")]
	private float LJJJGGKMCEI(float HHEJIMODBII, float BDLGADJBIPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B870", Offset = "0x5E5AC70", VA = "0x185E5B870", Slot = "4")]
	public void Execute(int DMMFKFNAHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF00", Offset = "0x5E5C300", VA = "0x185E5CF00")]
	private void OPLNHKJNLNE(int IKCNIKLIHDN, float3 JCADPOBEOPO, float3 CEGMEAOIEDE, float3 KEMEKCKBAAC, float PFKJICHCDMG, bool JPAFGFDHGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CA90", Offset = "0x5E5BE90", VA = "0x185E5CA90")]
	private void HFFIFFDCIPC(ALEGOEMKEBB PPJCGKEHKPF, float3 JCCIEPIALNO, float3x3 ODIJDPIEKIL, float HHEJIMODBII, int HBALOONADIA, int CCHBLFBEDOL, int DEDJGLNMBFC, float OJAHNNLBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D070", Offset = "0x5E5C470", VA = "0x185E5D070")]
	private void PLICKFGMLPB(int IKCNIKLIHDN, int JLHCGOGBOKP, ALEGOEMKEBB PPJCGKEHKPF, float3 JCCIEPIALNO, float3x3 ODIJDPIEKIL, bool HPALLMIPPPP, float HHEJIMODBII, int NILAJLLEJDE, int GJPNIFFANEN, int DEDJGLNMBFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct FMKEHFJGEGE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<ABKMBLPFLPG> PMHJMGIGAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<MAEDAELIDON> AAMKPBPAJFB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E581B0", Offset = "0x5E575B0", VA = "0x185E581B0")]
	public FMKEHFJGEGE(int PEGIIHFIAHP, Allocator LJHPECEMAME = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E58110", Offset = "0x5E57510", VA = "0x185E58110", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct NEKPHAIDJNE : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum NBLIINGOLPF
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
	private NativeList<float3> NBFOHNPCICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> ACAGGPCPIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> OFMJAADMCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> HBIGCJEHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> KADPGHKPOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> FHMAEFPOCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> CMDMBELFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> HMMICIEOPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<MAEDAELIDON> ALLBANFLOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<ABKMBLPFLPG> PMHJMGIGAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<MAEDAELIDON> AAMKPBPAJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int HAHGJMPMNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int LILAIPKIKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BBFJGKDMLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EOEHHIBEOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GJGJODJPHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GEIEICKFLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> DFLAKIENJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> COAJJLDIFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 NLMLEGLCKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion KMDFPMPPJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 NHFCHECIOCH;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E614A0", Offset = "0x5E608A0", VA = "0x185E614A0")]
	public NEKPHAIDJNE(KCEIJKCLJEC FKMMNLEENJA, OEHGBLLJPLO BNKEOBMCGDL, float3 ACEENOKIOOG, quaternion LFCJDBNGGAH, float KNFDJEMEIGD, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E612B0", Offset = "0x5E606B0", VA = "0x185E612B0")]
	public NEKPHAIDJNE(FMKEHFJGEGE KKOACPFFAML, OEHGBLLJPLO BNKEOBMCGDL, float3 ACEENOKIOOG, quaternion LFCJDBNGGAH, float3 KNFDJEMEIGD, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FEA0", Offset = "0x5E5F2A0", VA = "0x185E5FEA0", Slot = "4")]
	public void Execute(int DMMFKFNAHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E60E00", Offset = "0x5E60200", VA = "0x185E60E00")]
	private void FAIBONNEAOL(float4x4 CNAABKOCLGP, int DMMFKFNAHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E61200", Offset = "0x5E60600", VA = "0x185E61200")]
	private NBLIINGOLPF FPKMJOJNDCD(float3 CEGMEAOIEDE)
	{
		return default(NBLIINGOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E611B0", Offset = "0x5E605B0", VA = "0x185E611B0")]
	private float4 FOLOLAFDGEH(NBLIINGOLPF BDJJKJJPEID, int DIENMHDGFGP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61270", Offset = "0x5E60670", VA = "0x185E61270")]
	private float2 GPIOJPHKHPL(NBLIINGOLPF BDJJKJJPEID, float3 JCADPOBEOPO)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DNELJBPIEHN
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum NCNIEGGLMAC
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static DNELJBPIEHN ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 ECKCOGAKGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 GNPIBLFPCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 DIHNPGKKGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NCNIEGGLMAC MELBEGGEDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 CABEGELIDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 JEPKJMBNJHG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ECMFHABJICO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E57230", Offset = "0x5E56630", VA = "0x185E57230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 DFPMLNFPJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E576D0", Offset = "0x5E56AD0", VA = "0x185E576D0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E57AC0", Offset = "0x5E56EC0", VA = "0x185E57AC0")]
	public DNELJBPIEHN(float3 JCADPOBEOPO, quaternion KCLDFAAPKAB, float3 PEGIIHFIAHP, NCNIEGGLMAC LFLAEPCPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E574D0", Offset = "0x5E568D0", VA = "0x185E574D0")]
	public float ENHNDPAGLAF(float3 JCCIEPIALNO, float MKFMNGGMCBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E577B0", Offset = "0x5E56BB0", VA = "0x185E577B0")]
	public bool NNGLGKKKIPL(float3 CEGMEAOIEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E578A0", Offset = "0x5E56CA0", VA = "0x185E578A0")]
	public void PLMPLMPGGGG(float3 HFLCPHCAODH, float3x3 MHEDKLJICGE, float HKADCDOPCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E57130", Offset = "0x5E56530", VA = "0x185E57130")]
	private void BOMIKCDNHEN(float3 GGCAPAPOAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E57240", Offset = "0x5E56640", VA = "0x185E57240")]
	public void EGCOPNICOJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct NBHMNENMDHL : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<DNELJBPIEHN> KKOACPFFAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> NEJKLBDMMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> HEOECKOHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JKAFIFPBFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<MAEDAELIDON> AAMKPBPAJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int BLCAFJMKONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int EHKGBPINIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float MKFMNGGMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float ENGIMHHDHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> BDCDOLGALBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> BFAPPDNIEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> PNEPKHNDICE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FE00", Offset = "0x5E5F200", VA = "0x185E5FE00")]
	public NBHMNENMDHL(OEHGBLLJPLO OFPOBDLGBHI, float JGOKNBAEEKA, int HHKMAFFMIKG, int HBALOONADIA, NativeList<DNELJBPIEHN> KKOACPFFAML, NativeArray<int> JKAFIFPBFNK, NativeList<MAEDAELIDON> AAMKPBPAJFB, DMLHOGODMFL ABAGKOIHPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F360", Offset = "0x5E5E760", VA = "0x185E5F360", Slot = "4")]
	public void Execute(int PGINCDMIOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FD40", Offset = "0x5E5F140", VA = "0x185E5FD40")]
	private bool INABJMBMOHJ(DNELJBPIEHN JMHOJIPAIMC, DNELJBPIEHN MLKGDIFPGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FAA0", Offset = "0x5E5EEA0", VA = "0x185E5FAA0")]
	private bool FEKHIIHBBLG(DNELJBPIEHN IIPNDJEHBDD, int JGDHCGJBBHO, int GEFHKMGEMMC, int GAOMCGJDOON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DMLHOGODMFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> LKIHNDKLKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> HHPEINPCAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> FKAFOBPECAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> FNDMCPIJLIK;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E56F40", Offset = "0x5E56340", VA = "0x185E56F40")]
	public void FABEHFIHOAA(int IBKPKDGCLCA, int HHGPGPKHFOA, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E56F20", Offset = "0x5E56320", VA = "0x185E56F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E57040", Offset = "0x5E56440", VA = "0x185E57040")]
	public void FJNCMFNOBDL(JobHandle ALPBNEDDHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DMLHOGODMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct LFICGFENOBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> NEJKLBDMMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> CMJJFEFPPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> GNDHJLMJILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> OFDAFMLMMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> HEOECKOHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CIGLEDOHINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> ANBFABNLOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> BDCDOLGALBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> BFAPPDNIEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int PCDKBCADOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int LNNJHNKGAOH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B6C0", Offset = "0x5E5AAC0", VA = "0x185E5B6C0")]
	public LFICGFENOBP(OEHGBLLJPLO OFPOBDLGBHI, DMLHOGODMFL ABAGKOIHPKA, int LNNJHNKGAOH = 0, int PCDKBCADOOM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B280", Offset = "0x5E5A680", VA = "0x185E5B280", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B660", Offset = "0x5E5AA60", VA = "0x185E5B660")]
	private void LFCIBFKMDPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ICKNKJNHAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x253DE90", Offset = "0x253D290", VA = "0x18253DE90")]
	public static bool MIKKIFJABKO<T>(NativeArray<T> NCABOBFFNFK, int PEGIIHFIAHP, Allocator LJHPECEMAME, NativeArrayOptions AHMINIDFCHC = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x253DFD0", Offset = "0x253D3D0", VA = "0x18253DFD0")]
	public static bool MIKKIFJABKO<T>(NativeList<T> HAPGAOAPCEH, int PEGIIHFIAHP, Allocator LJHPECEMAME) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum IFLIEPAMDOK
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
public interface GFBGKPHBOPL
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EMKACCKFFJE(IFLIEPAMDOK MDIGKGAIJFE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KBDCIAILCKG(IFLIEPAMDOK MDIGKGAIJFE);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBCNGMAKKBC(IFLIEPAMDOK MDIGKGAIJFE, KCEIJKCLJEC AFPAKEHNNEJ, int NCNKIJGJBFK = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OEHGBLLJPLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int LLPOOMCAAKJ = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> CBMEFFIKFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> DDOMJLGHOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> MJAOKOPHKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> HJMMFFPPFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> ODNPMAGGOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> MIEGOKHBMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BKHFNIBKMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E61A20", Offset = "0x5E60E20", VA = "0x185E61A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GNOHGDFLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E626C0", Offset = "0x5E61AC0", VA = "0x185E626C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E618D0", Offset = "0x5E60CD0", VA = "0x185E618D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BCHCKKJGOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E61890", Offset = "0x5E60C90", VA = "0x185E61890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E61910", Offset = "0x5E60D10", VA = "0x185E61910", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61A60", Offset = "0x5E60E60", VA = "0x185E61A60")]
	public void FABEHFIHOAA(int IBKPKDGCLCA, int HHGPGPKHFOA, Allocator LJHPECEMAME, bool NIBIGMOJPJA, bool KLNDCEDLJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61C30", Offset = "0x5E61030", VA = "0x185E61C30")]
	public void KELNBFOMBDL(int IBKPKDGCLCA, int HHGPGPKHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E61CB0", Offset = "0x5E610B0", VA = "0x185E61CB0", Slot = "6")]
	public bool MEAIJJICPCM(Mesh OFPOBDLGBHI, bool BAHAFECGCPG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E62090", Offset = "0x5E61490", VA = "0x185E62090")]
	public bool NPELALFKGNK(Mesh OFPOBDLGBHI, OEHGBLLJPLO JDJCPJIIFEL, bool BAHAFECGCPG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public OEHGBLLJPLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IKLLJDKKNJN
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E591B0", Offset = "0x5E585B0", VA = "0x185E591B0")]
	public static void DHFGLODJHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PMPNKMFMMBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> CBMEFFIKFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> DDOMJLGHOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> LKKPINIDEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> IFNBOBHIKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> FADEDKICNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> CKEKPHGOJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> LHOPFFGPHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> MIEGOKHBMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GNOHGDFLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E635A0", Offset = "0x5E629A0", VA = "0x185E635A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E62740", Offset = "0x5E61B40", VA = "0x185E62740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BGGJPAABPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E62700", Offset = "0x5E61B00", VA = "0x185E62700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E635E0", Offset = "0x5E629E0", VA = "0x185E635E0")]
	public PMPNKMFMMBL(int IBKPKDGCLCA, int HHGPGPKHFOA, int LHBMLLNLFIJ, Allocator LJHPECEMAME = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E63800", Offset = "0x5E62C00", VA = "0x185E63800")]
	public PMPNKMFMMBL(Mesh OFPOBDLGBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E62A80", Offset = "0x5E61E80", VA = "0x185E62A80", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E62780", Offset = "0x5E61B80", VA = "0x185E62780")]
	public void DAIHEFLJOCM(PMPNKMFMMBL OFPOBDLGBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E62B90", Offset = "0x5E61F90", VA = "0x185E62B90")]
	private void MEEICGFEJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5E63020", Offset = "0x5E62420", VA = "0x185E63020")]
	private void MLNNKDIIDOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MAEDAELIDON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int LMELAMFNPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int GNOHGDFLCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int CDFNIFNHPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int DALMIIANPBP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x113AD70", Offset = "0x113A170", VA = "0x18113AD70")]
	public MAEDAELIDON(int HBALOONADIA, int OHMLLCELOAI, int HHKMAFFMIKG, int MPIKDMCFKKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CHBIFHOLPBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<MAEDAELIDON> LENCHOMGELL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB18F40", Offset = "0xB18340", VA = "0x180B18F40")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<MAEDAELIDON>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1B6F580", Offset = "0x1B6E980", VA = "0x181B6F580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public PMPNKMFMMBL DEGIAFMDNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x775420", Offset = "0x774820", VA = "0x180775420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E56960", Offset = "0x5E55D60", VA = "0x185E56960")]
	public CHBIFHOLPBJ(IEnumerable<PMPNKMFMMBL> BIPPHMHFFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E568F0", Offset = "0x5E55CF0", VA = "0x185E568F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum EBJLMDNPGNO
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EJIIFKOGOJE
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> ICGMNHDPBON;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> OECMDCHPHEF;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> LPHHGOMBIKC;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> PCKMFMIHOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E57BB0", Offset = "0x5E56FB0", VA = "0x185E57BB0")]
	public static void DHFGLODJHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E57EF0", Offset = "0x5E572F0", VA = "0x185E57EF0")]
	public static NativeArray<float2> INOOOHHNDOP(NativeArray<float2> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<float2> LFIPPCDPFLN, int PNDEHICAIHO)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E57DE0", Offset = "0x5E571E0", VA = "0x185E57DE0")]
	public static NativeArray<float3> FNEMOIJPHJH(NativeArray<float3> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<float3> LFIPPCDPFLN, int PNDEHICAIHO)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E57CD0", Offset = "0x5E570D0", VA = "0x185E57CD0")]
	public static NativeArray<float4> EIHJIPIMOFL(NativeArray<float4> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<float4> LFIPPCDPFLN, int PNDEHICAIHO)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E58000", Offset = "0x5E57400", VA = "0x185E58000")]
	public static NativeArray<int> OCKDIOJNNDD(NativeArray<int> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<int> LFIPPCDPFLN, int PNDEHICAIHO)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x23D4310", Offset = "0x23D3710", VA = "0x1823D4310")]
	private static void OKNCOHOKHAN<T>(NativeArray<T> NCABOBFFNFK, int KAMPFHLDEMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x23D4260", Offset = "0x23D3660", VA = "0x1823D4260")]
	private static void IPNKPHOGBLK<T>(NativeArray<T> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<T> LFIPPCDPFLN, int PNDEHICAIHO, NativeArray<T> DMAEHMGKHCN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GHGDMPJMHKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<GFBGKPHBOPL> ABDBKDILDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly EOJHLDCAFED HBOLJCGABGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int OHMLLCELOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int MPIKDMCFKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool INEMIDCEMCO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh DEGIAFMDNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x775A50", Offset = "0x774E50", VA = "0x180775A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer NECMEEOCIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GNOHGDFLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E58E00", Offset = "0x5E58200", VA = "0x185E58E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2092E80", Offset = "0x2092280", VA = "0x182092E80")]
	public void ODIEGFPCADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E59090", Offset = "0x5E58490", VA = "0x185E59090")]
	public GHGDMPJMHKA(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E58370", Offset = "0x5E57770", VA = "0x185E58370")]
	public void FJNCMFNOBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E585A0", Offset = "0x5E579A0", VA = "0x185E585A0")]
	public void MBGJEPADCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E583B0", Offset = "0x5E577B0", VA = "0x185E583B0")]
	public void GCCPLHBCBKI(GFBGKPHBOPL LAMFNNBPFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E58E20", Offset = "0x5E58220", VA = "0x185E58E20")]
	private void PMKBGJIAGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E58300", Offset = "0x5E57700", VA = "0x185E58300")]
	public bool CNLKLMGFLAN(GFBGKPHBOPL LAMFNNBPFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E582A0", Offset = "0x5E576A0", VA = "0x185E582A0")]
	public bool CCJBPIIMLHG(GFBGKPHBOPL LAMFNNBPFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E58530", Offset = "0x5E57930", VA = "0x185E58530", Slot = "4")]
	public virtual void IDNGNGGDHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E58460", Offset = "0x5E57860", VA = "0x185E58460")]
	public void GEMDBBMBFHL(Transform EPGHFEOAKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E585D0", Offset = "0x5E579D0", VA = "0x185E585D0")]
	public bool MHLHKCLMNBO(Transform EPGHFEOAKCG, [Out] (OEHGBLLJPLO destMesh, Mesh mesh, JobHandle job) KKOACPFFAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E58D50", Offset = "0x5E58150", VA = "0x185E58D50")]
	public void NCFOAHDNCJM([In] (OEHGBLLJPLO destMesh, Mesh mesh, JobHandle job) KKOACPFFAML)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker GLNCOBLAHFO;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker BENJFPGBCNL;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker FCOHONMNDBJ;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int IGPBLBFCEMB = 65000;

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
		private Dictionary<Material, List<GHGDMPJMHKA>> DPJEBGKCCCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<GHGDMPJMHKA> PKKGFPJGDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> OIJEDGMOICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(GHGDMPJMHKA, (OEHGBLLJPLO, Mesh, JobHandle))> CDOJMBDLAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool CLOGCKKAFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> ANBJJEIMJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> GOFJDAHLAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> LHJCNJFEMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> AAHNEBHKGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private GHGDMPJMHKA CDGOBBAIJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material CJPFBBLLDPO;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> IHFHKJEGACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E556B0", Offset = "0x5E54AB0", VA = "0x185E556B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E54580", Offset = "0x5E53980", VA = "0x185E54580")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E53E50", Offset = "0x5E53250", VA = "0x185E53E50")]
		public GHGDMPJMHKA AddToBatchedMesh(GFBGKPHBOPL FNEPJPAFLNB, Material OLONCOMGJHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E55B00", Offset = "0x5E54F00", VA = "0x185E55B00")]
		public void RemoveFromBatchedMesh(GFBGKPHBOPL OFPOBDLGBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E543E0", Offset = "0x5E537E0", VA = "0x185E543E0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E55C80", Offset = "0x5E55080", VA = "0x185E55C80")]
		public void SetMaterialProperty(int EBCGACDFJOO, Color DDJLPLIEHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E56110", Offset = "0x5E55510", VA = "0x185E56110")]
		public void SetMaterialProperty(int EBCGACDFJOO, float NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E56330", Offset = "0x5E55730", VA = "0x185E56330")]
		public void SetMaterialProperty(int EBCGACDFJOO, Vector4 HGPHGPPDDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E55EB0", Offset = "0x5E552B0", VA = "0x185E55EB0")]
		public void SetMaterialProperty(int EBCGACDFJOO, Matrix4x4 IFIHPMOFBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5E54EA0", Offset = "0x5E542A0", VA = "0x185E54EA0")]
		private void HJPOOIFMAOK(Renderer GPEFMCEJIAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E54E90", Offset = "0x5E54290", VA = "0x185E54E90")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E54760", Offset = "0x5E53B60", VA = "0x185E54760")]
		private void EHOOFNDHEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E55900", Offset = "0x5E54D00", VA = "0x185E55900")]
		private GHGDMPJMHKA PHJNCCMPLOD(GFBGKPHBOPL OFPOBDLGBHI, Material OLONCOMGJHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E54CC0", Offset = "0x5E540C0", VA = "0x185E54CC0")]
		private GHGDMPJMHKA ELECPBJJGJE(Material OLONCOMGJHB, int CJAGMHIEFLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E53F30", Offset = "0x5E53330", VA = "0x185E53F30")]
		private GHGDMPJMHKA BDKJHKGLHCA(Material OLONCOMGJHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E55620", Offset = "0x5E54A20", VA = "0x185E55620")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E55490", Offset = "0x5E54890", VA = "0x185E55490")]
		public void MarkDirty(GFBGKPHBOPL OFPOBDLGBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E56630", Offset = "0x5E55A30", VA = "0x185E56630")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JOHHELNKBHL<KeyType> : GHGDMPJMHKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, GFBGKPHBOPL> CEMKFEFICMJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3916F70", Offset = "0x3916370", VA = "0x183916F70")]
	public JOHHELNKBHL(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3916D40", Offset = "0x3916140", VA = "0x183916D40")]
	public void GCCPLHBCBKI(KeyType MIMFBLPNKOG, GFBGKPHBOPL LAMFNNBPFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3916EA0", Offset = "0x39162A0", VA = "0x183916EA0")]
	public bool OBHMGLPGBML(KeyType MIMFBLPNKOG, GFBGKPHBOPL HOOFHMFLLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3916C00", Offset = "0x3916000", VA = "0x183916C00")]
	public void CPIBGBAOMEC(KeyType MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3916D90", Offset = "0x3916190", VA = "0x183916D90", Slot = "4")]
	public override void IDNGNGGDHBH()
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
