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
		[Cpp2IlInjected.Address(RVA = "0xB98AB0", Offset = "0xB97EB0", VA = "0x180B98AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB980F0", Offset = "0xB974F0", VA = "0x180B980F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB98AC0", Offset = "0xB97EC0", VA = "0x180B98AC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB980E0", Offset = "0xB974E0", VA = "0x180B980E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B150", Offset = "0x5E5A550", VA = "0x185E5B150")]
	public KCEIJKCLJEC(int OIFHGFDKDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A610", Offset = "0x5E59A10", VA = "0x185E5A610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A630", Offset = "0x5E59A30", VA = "0x185E5A630")]
	public void FJNCMFNOBDL(JobHandle ALPBNEDDHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AAB0", Offset = "0x5E59EB0", VA = "0x185E5AAB0")]
	public void FKMBFOPDDPN(ABKMBLPFLPG KKOACPFFAML, DNELJBPIEHN EJMEHDCAMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5ACD0", Offset = "0x5E5A0D0", VA = "0x185E5ACD0")]
	public void HINOHCCAMMI(ALEGOEMKEBB KKOACPFFAML, NativeArray<KHOFDKJIMMJ> PEJGLFKMHFP, int OHMLLCELOAI, int MPIKDMCFKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E59600", Offset = "0x5E58A00", VA = "0x185E59600")]
	public JobHandle ANKGKMLLGLO(OEHGBLLJPLO AHGAKJHGCJO, DMLHOGODMFL ABAGKOIHPKA, float3 DHHOOMMPNGB, quaternion HHBINENECFJ, float JIENKPEFAMI, bool MIJHALOKOCB, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AE10", Offset = "0x5E5A210", VA = "0x185E5AE10")]
	public static JobHandle MADAELICKJP(FMKEHFJGEGE LOGOAFJFDOC, OEHGBLLJPLO AHGAKJHGCJO, ABKMBLPFLPG KKOACPFFAML, JobHandle ALPBNEDDHKE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A800", Offset = "0x5E59C00", VA = "0x185E5A800")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E618B0", Offset = "0x5E60CB0", VA = "0x185E618B0")]
	public OCMMNELBCGD(int IBKPKDGCLCA, int HHGPGPKHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E61850", Offset = "0x5E60C50", VA = "0x185E61850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E61770", Offset = "0x5E60B70", VA = "0x185E61770")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E5E360", Offset = "0x5E5D760", VA = "0x185E5E360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<MAEDAELIDON> KMJNOFDMBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F230", Offset = "0x5E5E630", VA = "0x185E5F230")]
		get
		{
			return default(NativeList<MAEDAELIDON>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static OCMMNELBCGD BJNDFJALNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EB00", Offset = "0x5E5DF00", VA = "0x185E5EB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E4F0", Offset = "0x5E5D8F0", VA = "0x185E5E4F0")]
	private static void GNHIPBDNLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E320", Offset = "0x5E5D720", VA = "0x185E5E320")]
	public static int EBLIGHBCHGG(bool HLLHNOAJEHO, int JNABAFMMPPI, bool MGFIHAHOGCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F210", Offset = "0x5E5E610", VA = "0x185E5F210")]
	private static int ONLIKOHHBAG(int JNABAFMMPPI, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E350", Offset = "0x5E5D750", VA = "0x185E5E350")]
	private static int FEIIFOIBCDE(int JNABAFMMPPI, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EEF0", Offset = "0x5E5E2F0", VA = "0x185E5EEF0")]
	public static int JEGFANLDDKP(int MDIGKGAIJFE, int JNABAFMMPPI, int FPOLHGKNDHH, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EF80", Offset = "0x5E5E380", VA = "0x185E5EF80")]
	public static int JIPALHOLFEM(int MDIGKGAIJFE, int JNABAFMMPPI, int FPOLHGKNDHH, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EBA0", Offset = "0x5E5DFA0", VA = "0x185E5EBA0")]
	public static int HKHNLOBNDAF(int FPOLHGKNDHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F010", Offset = "0x5E5E410", VA = "0x185E5F010")]
	private static int LFGIIHGFMDE(int JNABAFMMPPI, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DC60", Offset = "0x5E5D060", VA = "0x185E5DC60")]
	private static int CDMOFKAJGFJ(int JNABAFMMPPI, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F1A0", Offset = "0x5E5E5A0", VA = "0x185E5F1A0")]
	public static int NMJNGFNJHIO(int MDIGKGAIJFE, int JNABAFMMPPI, int FPOLHGKNDHH, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F020", Offset = "0x5E5E420", VA = "0x185E5F020")]
	public static int MEIGMLMOBCB(int MDIGKGAIJFE, int JNABAFMMPPI, int FPOLHGKNDHH, bool BFDBIDKAIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E4D0", Offset = "0x5E5D8D0", VA = "0x185E5E4D0")]
	public static int FOOJFGPDFIF(int FPOLHGKNDHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E3E0", Offset = "0x5E5D7E0", VA = "0x185E5E3E0")]
	public static OCMMNELBCGD FKCCNLNDLPK(int JNABAFMMPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DC80", Offset = "0x5E5D080", VA = "0x185E5DC80")]
	private static OCMMNELBCGD CFDILOPOMOE(int JNABAFMMPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F0B0", Offset = "0x5E5E4B0", VA = "0x185E5F0B0")]
	public static OCMMNELBCGD MOGPGIJGLPC(int JNABAFMMPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EBB0", Offset = "0x5E5DFB0", VA = "0x185E5EBB0")]
	private static OCMMNELBCGD IFMDOGLKDAE(int JNABAFMMPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DF10", Offset = "0x5E5D310", VA = "0x185E5DF10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E594D0", Offset = "0x5E588D0", VA = "0x185E594D0")]
	public IMAALBJILME(NativeArray<KHOFDKJIMMJ> NHADIJHHLNL, int PEGIIHFIAHP = 1, Allocator LJHPECEMAME = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E593E0", Offset = "0x5E587E0", VA = "0x185E593E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E5D7A0", Offset = "0x5E5CBA0", VA = "0x185E5D7A0")]
	public LIGFCDIMHHP(KCEIJKCLJEC FKMMNLEENJA, OEHGBLLJPLO BNKEOBMCGDL, float3 ACEENOKIOOG, quaternion LFCJDBNGGAH, float KNFDJEMEIGD, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DA30", Offset = "0x5E5CE30", VA = "0x185E5DA30")]
	public LIGFCDIMHHP(IMAALBJILME FKMMNLEENJA, OEHGBLLJPLO BNKEOBMCGDL, float3 ACEENOKIOOG, quaternion LFCJDBNGGAH, float3 KNFDJEMEIGD, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B820", Offset = "0x5E5AC20", VA = "0x185E5B820")]
	private float3 BHGDGDPPLOI(float3 LJIEBJONHKL, Matrix4x4 LACKHELHMIM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CAF0", Offset = "0x5E5BEF0", VA = "0x185E5CAF0")]
	private float3x3 GMOLFGBMFPH(float3x3 AKDJHKILGAI, float3x3 EDFEEEDLIAM)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CFD0", Offset = "0x5E5C3D0", VA = "0x185E5CFD0")]
	private float LJJJGGKMCEI(float HHEJIMODBII, float BDLGADJBIPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B950", Offset = "0x5E5AD50", VA = "0x185E5B950", Slot = "4")]
	public void Execute(int DMMFKFNAHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CFE0", Offset = "0x5E5C3E0", VA = "0x185E5CFE0")]
	private void OPLNHKJNLNE(int IKCNIKLIHDN, float3 JCADPOBEOPO, float3 CEGMEAOIEDE, float3 KEMEKCKBAAC, float PFKJICHCDMG, bool JPAFGFDHGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CB70", Offset = "0x5E5BF70", VA = "0x185E5CB70")]
	private void HFFIFFDCIPC(ALEGOEMKEBB PPJCGKEHKPF, float3 JCCIEPIALNO, float3x3 ODIJDPIEKIL, float HHEJIMODBII, int HBALOONADIA, int CCHBLFBEDOL, int DEDJGLNMBFC, float OJAHNNLBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D150", Offset = "0x5E5C550", VA = "0x185E5D150")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E58290", Offset = "0x5E57690", VA = "0x185E58290")]
	public FMKEHFJGEGE(int PEGIIHFIAHP, Allocator LJHPECEMAME = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E581F0", Offset = "0x5E575F0", VA = "0x185E581F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E61580", Offset = "0x5E60980", VA = "0x185E61580")]
	public NEKPHAIDJNE(KCEIJKCLJEC FKMMNLEENJA, OEHGBLLJPLO BNKEOBMCGDL, float3 ACEENOKIOOG, quaternion LFCJDBNGGAH, float KNFDJEMEIGD, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E61390", Offset = "0x5E60790", VA = "0x185E61390")]
	public NEKPHAIDJNE(FMKEHFJGEGE KKOACPFFAML, OEHGBLLJPLO BNKEOBMCGDL, float3 ACEENOKIOOG, quaternion LFCJDBNGGAH, float3 KNFDJEMEIGD, int PCDKBCADOOM = 0, int LNNJHNKGAOH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FF80", Offset = "0x5E5F380", VA = "0x185E5FF80", Slot = "4")]
	public void Execute(int DMMFKFNAHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E60EE0", Offset = "0x5E602E0", VA = "0x185E60EE0")]
	private void FAIBONNEAOL(float4x4 CNAABKOCLGP, int DMMFKFNAHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E612E0", Offset = "0x5E606E0", VA = "0x185E612E0")]
	private NBLIINGOLPF FPKMJOJNDCD(float3 CEGMEAOIEDE)
	{
		return default(NBLIINGOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61290", Offset = "0x5E60690", VA = "0x185E61290")]
	private float4 FOLOLAFDGEH(NBLIINGOLPF BDJJKJJPEID, int DIENMHDGFGP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61350", Offset = "0x5E60750", VA = "0x185E61350")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E57310", Offset = "0x5E56710", VA = "0x185E57310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 DFPMLNFPJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E577B0", Offset = "0x5E56BB0", VA = "0x185E577B0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E57BA0", Offset = "0x5E56FA0", VA = "0x185E57BA0")]
	public DNELJBPIEHN(float3 JCADPOBEOPO, quaternion KCLDFAAPKAB, float3 PEGIIHFIAHP, NCNIEGGLMAC LFLAEPCPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E575B0", Offset = "0x5E569B0", VA = "0x185E575B0")]
	public float ENHNDPAGLAF(float3 JCCIEPIALNO, float MKFMNGGMCBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E57890", Offset = "0x5E56C90", VA = "0x185E57890")]
	public bool NNGLGKKKIPL(float3 CEGMEAOIEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E57980", Offset = "0x5E56D80", VA = "0x185E57980")]
	public void PLMPLMPGGGG(float3 HFLCPHCAODH, float3x3 MHEDKLJICGE, float HKADCDOPCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E57210", Offset = "0x5E56610", VA = "0x185E57210")]
	private void BOMIKCDNHEN(float3 GGCAPAPOAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E57320", Offset = "0x5E56720", VA = "0x185E57320")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E5FEE0", Offset = "0x5E5F2E0", VA = "0x185E5FEE0")]
	public NBHMNENMDHL(OEHGBLLJPLO OFPOBDLGBHI, float JGOKNBAEEKA, int HHKMAFFMIKG, int HBALOONADIA, NativeList<DNELJBPIEHN> KKOACPFFAML, NativeArray<int> JKAFIFPBFNK, NativeList<MAEDAELIDON> AAMKPBPAJFB, DMLHOGODMFL ABAGKOIHPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F440", Offset = "0x5E5E840", VA = "0x185E5F440", Slot = "4")]
	public void Execute(int PGINCDMIOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FE20", Offset = "0x5E5F220", VA = "0x185E5FE20")]
	private bool INABJMBMOHJ(DNELJBPIEHN JMHOJIPAIMC, DNELJBPIEHN MLKGDIFPGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FB80", Offset = "0x5E5EF80", VA = "0x185E5FB80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E57020", Offset = "0x5E56420", VA = "0x185E57020")]
	public void FABEHFIHOAA(int IBKPKDGCLCA, int HHGPGPKHFOA, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E57000", Offset = "0x5E56400", VA = "0x185E57000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E57120", Offset = "0x5E56520", VA = "0x185E57120")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E5B7A0", Offset = "0x5E5ABA0", VA = "0x185E5B7A0")]
	public LFICGFENOBP(OEHGBLLJPLO OFPOBDLGBHI, DMLHOGODMFL ABAGKOIHPKA, int LNNJHNKGAOH = 0, int PCDKBCADOOM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B360", Offset = "0x5E5A760", VA = "0x185E5B360", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B740", Offset = "0x5E5AB40", VA = "0x185E5B740")]
	private void LFCIBFKMDPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ICKNKJNHAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x253DE00", Offset = "0x253D200", VA = "0x18253DE00")]
	public static bool MIKKIFJABKO<T>(NativeArray<T> NCABOBFFNFK, int PEGIIHFIAHP, Allocator LJHPECEMAME, NativeArrayOptions AHMINIDFCHC = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x253DF40", Offset = "0x253D340", VA = "0x18253DF40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E61B00", Offset = "0x5E60F00", VA = "0x185E61B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GNOHGDFLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E627A0", Offset = "0x5E61BA0", VA = "0x185E627A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E619B0", Offset = "0x5E60DB0", VA = "0x185E619B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BCHCKKJGOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E61970", Offset = "0x5E60D70", VA = "0x185E61970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E619F0", Offset = "0x5E60DF0", VA = "0x185E619F0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61B40", Offset = "0x5E60F40", VA = "0x185E61B40")]
	public void FABEHFIHOAA(int IBKPKDGCLCA, int HHGPGPKHFOA, Allocator LJHPECEMAME, bool NIBIGMOJPJA, bool KLNDCEDLJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61D10", Offset = "0x5E61110", VA = "0x185E61D10")]
	public void KELNBFOMBDL(int IBKPKDGCLCA, int HHGPGPKHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E61D90", Offset = "0x5E61190", VA = "0x185E61D90", Slot = "6")]
	public bool MEAIJJICPCM(Mesh OFPOBDLGBHI, bool BAHAFECGCPG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E62170", Offset = "0x5E61570", VA = "0x185E62170")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E59290", Offset = "0x5E58690", VA = "0x185E59290")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E63680", Offset = "0x5E62A80", VA = "0x185E63680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E62820", Offset = "0x5E61C20", VA = "0x185E62820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BGGJPAABPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E627E0", Offset = "0x5E61BE0", VA = "0x185E627E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E636C0", Offset = "0x5E62AC0", VA = "0x185E636C0")]
	public PMPNKMFMMBL(int IBKPKDGCLCA, int HHGPGPKHFOA, int LHBMLLNLFIJ, Allocator LJHPECEMAME = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E638E0", Offset = "0x5E62CE0", VA = "0x185E638E0")]
	public PMPNKMFMMBL(Mesh OFPOBDLGBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E62B60", Offset = "0x5E61F60", VA = "0x185E62B60", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E62860", Offset = "0x5E61C60", VA = "0x185E62860")]
	public void DAIHEFLJOCM(PMPNKMFMMBL OFPOBDLGBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E62C70", Offset = "0x5E62070", VA = "0x185E62C70")]
	private void MEEICGFEJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5E63100", Offset = "0x5E62500", VA = "0x185E63100")]
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
	[Cpp2IlInjected.Address(RVA = "0x113ACC0", Offset = "0x113A0C0", VA = "0x18113ACC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<MAEDAELIDON>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1B6F390", Offset = "0x1B6E790", VA = "0x181B6F390")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E56A40", Offset = "0x5E55E40", VA = "0x185E56A40")]
	public CHBIFHOLPBJ(IEnumerable<PMPNKMFMMBL> BIPPHMHFFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E569D0", Offset = "0x5E55DD0", VA = "0x185E569D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E57C90", Offset = "0x5E57090", VA = "0x185E57C90")]
	public static void DHFGLODJHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E57FD0", Offset = "0x5E573D0", VA = "0x185E57FD0")]
	public static NativeArray<float2> INOOOHHNDOP(NativeArray<float2> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<float2> LFIPPCDPFLN, int PNDEHICAIHO)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E57EC0", Offset = "0x5E572C0", VA = "0x185E57EC0")]
	public static NativeArray<float3> FNEMOIJPHJH(NativeArray<float3> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<float3> LFIPPCDPFLN, int PNDEHICAIHO)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E57DB0", Offset = "0x5E571B0", VA = "0x185E57DB0")]
	public static NativeArray<float4> EIHJIPIMOFL(NativeArray<float4> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<float4> LFIPPCDPFLN, int PNDEHICAIHO)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E580E0", Offset = "0x5E574E0", VA = "0x185E580E0")]
	public static NativeArray<int> OCKDIOJNNDD(NativeArray<int> ALLKLGPIKKE, int NBONBAMHFHE, NativeArray<int> LFIPPCDPFLN, int PNDEHICAIHO)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x23D4280", Offset = "0x23D3680", VA = "0x1823D4280")]
	private static void OKNCOHOKHAN<T>(NativeArray<T> NCABOBFFNFK, int KAMPFHLDEMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x23D41D0", Offset = "0x23D35D0", VA = "0x1823D41D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E58EE0", Offset = "0x5E582E0", VA = "0x185E58EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2092DC0", Offset = "0x20921C0", VA = "0x182092DC0")]
	public void ODIEGFPCADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E59170", Offset = "0x5E58570", VA = "0x185E59170")]
	public GHGDMPJMHKA(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E58450", Offset = "0x5E57850", VA = "0x185E58450")]
	public void FJNCMFNOBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E58680", Offset = "0x5E57A80", VA = "0x185E58680")]
	public void MBGJEPADCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E58490", Offset = "0x5E57890", VA = "0x185E58490")]
	public void GCCPLHBCBKI(GFBGKPHBOPL LAMFNNBPFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E58F00", Offset = "0x5E58300", VA = "0x185E58F00")]
	private void PMKBGJIAGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E583E0", Offset = "0x5E577E0", VA = "0x185E583E0")]
	public bool CNLKLMGFLAN(GFBGKPHBOPL LAMFNNBPFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E58380", Offset = "0x5E57780", VA = "0x185E58380")]
	public bool CCJBPIIMLHG(GFBGKPHBOPL LAMFNNBPFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E58610", Offset = "0x5E57A10", VA = "0x185E58610", Slot = "4")]
	public virtual void IDNGNGGDHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E58540", Offset = "0x5E57940", VA = "0x185E58540")]
	public void GEMDBBMBFHL(Transform EPGHFEOAKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E586B0", Offset = "0x5E57AB0", VA = "0x185E586B0")]
	public bool MHLHKCLMNBO(Transform EPGHFEOAKCG, [Out] (OEHGBLLJPLO destMesh, Mesh mesh, JobHandle job) KKOACPFFAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E58E30", Offset = "0x5E58230", VA = "0x185E58E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E55790", Offset = "0x5E54B90", VA = "0x185E55790")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E54660", Offset = "0x5E53A60", VA = "0x185E54660")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E53F30", Offset = "0x5E53330", VA = "0x185E53F30")]
		public GHGDMPJMHKA AddToBatchedMesh(GFBGKPHBOPL FNEPJPAFLNB, Material OLONCOMGJHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E55BE0", Offset = "0x5E54FE0", VA = "0x185E55BE0")]
		public void RemoveFromBatchedMesh(GFBGKPHBOPL OFPOBDLGBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E544C0", Offset = "0x5E538C0", VA = "0x185E544C0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E55D60", Offset = "0x5E55160", VA = "0x185E55D60")]
		public void SetMaterialProperty(int EBCGACDFJOO, Color DDJLPLIEHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E561F0", Offset = "0x5E555F0", VA = "0x185E561F0")]
		public void SetMaterialProperty(int EBCGACDFJOO, float NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E56410", Offset = "0x5E55810", VA = "0x185E56410")]
		public void SetMaterialProperty(int EBCGACDFJOO, Vector4 HGPHGPPDDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E55F90", Offset = "0x5E55390", VA = "0x185E55F90")]
		public void SetMaterialProperty(int EBCGACDFJOO, Matrix4x4 IFIHPMOFBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5E54F80", Offset = "0x5E54380", VA = "0x185E54F80")]
		private void HJPOOIFMAOK(Renderer GPEFMCEJIAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E54F70", Offset = "0x5E54370", VA = "0x185E54F70")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E54840", Offset = "0x5E53C40", VA = "0x185E54840")]
		private void EHOOFNDHEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E559E0", Offset = "0x5E54DE0", VA = "0x185E559E0")]
		private GHGDMPJMHKA PHJNCCMPLOD(GFBGKPHBOPL OFPOBDLGBHI, Material OLONCOMGJHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E54DA0", Offset = "0x5E541A0", VA = "0x185E54DA0")]
		private GHGDMPJMHKA ELECPBJJGJE(Material OLONCOMGJHB, int CJAGMHIEFLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E54010", Offset = "0x5E53410", VA = "0x185E54010")]
		private GHGDMPJMHKA BDKJHKGLHCA(Material OLONCOMGJHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E55700", Offset = "0x5E54B00", VA = "0x185E55700")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E55570", Offset = "0x5E54970", VA = "0x185E55570")]
		public void MarkDirty(GFBGKPHBOPL OFPOBDLGBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E56710", Offset = "0x5E55B10", VA = "0x185E56710")]
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
	[Cpp2IlInjected.Address(RVA = "0x3915A50", Offset = "0x3914E50", VA = "0x183915A50")]
	public JOHHELNKBHL(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3915820", Offset = "0x3914C20", VA = "0x183915820")]
	public void GCCPLHBCBKI(KeyType MIMFBLPNKOG, GFBGKPHBOPL LAMFNNBPFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3915980", Offset = "0x3914D80", VA = "0x183915980")]
	public bool OBHMGLPGBML(KeyType MIMFBLPNKOG, GFBGKPHBOPL HOOFHMFLLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x39156E0", Offset = "0x3914AE0", VA = "0x1839156E0")]
	public void CPIBGBAOMEC(KeyType MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3915870", Offset = "0x3914C70", VA = "0x183915870", Slot = "4")]
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
