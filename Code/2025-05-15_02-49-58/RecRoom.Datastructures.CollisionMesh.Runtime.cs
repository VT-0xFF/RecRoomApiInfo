using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct FOJKCHNJCBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct EPAPHEGHLGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int EMDKFIJLHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int FFLDCHFPHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int NICDKPGDIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int FJEHKADBMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int CBKGNIPALCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int OLCBNKCHOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 ENMINAOPOCJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BEBE80", Offset = "0x7BEA480", VA = "0x187BEBE80")]
		public EPAPHEGHLGC(int HPLOFABFHPL, int PPMLHPJGPIJ, int IFMEGLHJPDI, int PBIEIJLAOHM, int OGDJJBGJHPA, int IOGFODJKAHA, float3 HPAMHMBDLLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct KDJKCCMDFIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int JEJBDMNPGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int JGFBMMBDOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float KBIJJOIMHJE;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCB19A0", Offset = "0xCAFFA0", VA = "0x180CB19A0")]
		public KDJKCCMDFIB(int NOOBIPOJNNG, int LDKFHHCLJOM, float IAEAOGJCDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct IDJBPGIBKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int JGFBMMBDOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int MKNOPGOHOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int BKANOJBFFBC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, EPAPHEGHLGC> FLFOIOHHLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<KDJKCCMDFIB> KGGIJMDHJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> IIFLAGJNKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<IDJBPGIBKPH> FIJCFNJBMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> NGHBKJKPKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int JCDPPPKFLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int GCEAHGBOKML;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7BECA10", Offset = "0x7BEB010", VA = "0x187BECA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7BECC60", Offset = "0x7BEB260", VA = "0x187BECC60")]
	public bool EODDHKJBDMN([In] NativeArray<float3> FPGLCMFAFBI, NativeList<float3> JAIBDMKDPON, NativeList<int> HKHJDBHLOPP, Allocator NDFENJBGNOB, CancellationToken CBJPDIFOEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBEC0", Offset = "0x7BEA4C0", VA = "0x187BEBEC0")]
	private void ANJKPBDKBKO([In] NativeArray<float3> FPGLCMFAFBI, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BED450", Offset = "0x7BEBA50", VA = "0x187BED450")]
	private void JMIMKOKDEJC([In] NativeArray<float3> FPGLCMFAFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC490", Offset = "0x7BEAA90", VA = "0x187BEC490")]
	private void DCIINJEFKPG([In] NativeArray<float3> FPGLCMFAFBI, [Out] int KPHCGPCNJGF, [Out] int AJHJLMFGIBI, [Out] int IKODBJCNBDN, [Out] int GCJCKGMGOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF560", Offset = "0x7BEDB60", VA = "0x187BEF560")]
	private void PJIFPELPEOA([In] NativeArray<float3> FPGLCMFAFBI, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE540", Offset = "0x7BECB40", VA = "0x187BEE540")]
	private void OLGKFLKFJJF([In] NativeArray<float3> FPGLCMFAFBI, float3 DJHCIGKJNEI, int LIKLGAEKOOG, EPAPHEGHLGC FLGOFLOCIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC0A0", Offset = "0x7BEA6A0", VA = "0x187BEC0A0")]
	private void CMFEOMGJGBD([In] NativeArray<float3> FPGLCMFAFBI, float3 DJHCIGKJNEI, int GDBHLMJLKEJ, int GCEAHGBOKML, EPAPHEGHLGC FLGOFLOCIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEF00", Offset = "0x7BED500", VA = "0x187BEEF00")]
	private void OOFMCBMHNJK([In] NativeArray<float3> FPGLCMFAFBI, int PKNICCENLBL, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BED0E0", Offset = "0x7BEB6E0", VA = "0x187BED0E0")]
	private void HEGEJOEHBDE([In] NativeArray<float3> FPGLCMFAFBI, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEA20", Offset = "0x7BED020", VA = "0x187BEEA20")]
	private void OOCPGLLBCGG([In] NativeArray<float3> FPGLCMFAFBI, NativeList<float3> JAIBDMKDPON, NativeList<int> HKHJDBHLOPP, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC950", Offset = "0x7BEAF50", VA = "0x187BEC950")]
	private float DLDJDCPHLHP(float3 DJHCIGKJNEI, float3 EICNBIHOGDD, EPAPHEGHLGC FLGOFLOCIFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BECB50", Offset = "0x7BEB150", VA = "0x187BECB50")]
	private float3 ENMINAOPOCJ(float3 HPLOFABFHPL, float3 PPMLHPJGPIJ, float3 IFMEGLHJPDI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BECDA0", Offset = "0x7BEB3A0", VA = "0x187BECDA0")]
	private static float GEJOPMECMPD(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC9B0", Offset = "0x7BEAFB0", VA = "0x187BEC9B0")]
	private static float3 DNMMKNLHOHN(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF500", Offset = "0x7BEDB00", VA = "0x187BEF500")]
	private bool OOIPMFMEMPI(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE470", Offset = "0x7BECA70", VA = "0x187BEE470")]
	private bool OJGKAFCFNNG(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM, float3 JKIBOICMIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BECDD0", Offset = "0x7BEB3D0", VA = "0x187BECDD0")]
	private bool GINEJNELAPP(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM, float3 JKIBOICMIDJ, float3 IAEAOGJCDGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EHAHPPOABGC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NLMNBCOCOCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public unsafe int* indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int indexCount;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<float3> ADPKGAEKHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> JHJMFPLBLBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB880", Offset = "0x7BE9E80", VA = "0x187BEB880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7BEAE80", Offset = "0x7BE9480", VA = "0x187BEAE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7BEAE40", Offset = "0x7BE9440", VA = "0x187BEAE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OIHBNDKGOEA ONFBCHHKPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BEADC0", Offset = "0x7BE93C0", VA = "0x187BEADC0")]
		get
		{
			return default(OIHBNDKGOEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBDC0", Offset = "0x7BEA3C0", VA = "0x187BEBDC0")]
	public EHAHPPOABGC(int NPGNODKKKAD, int PCGPKCCHANN, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB8C0", Offset = "0x7BE9EC0", VA = "0x187BEB8C0")]
	public EHAHPPOABGC(OIHBNDKGOEA PKCEJFAFCCA, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB8F0", Offset = "0x7BE9EF0", VA = "0x187BEB8F0")]
	public EHAHPPOABGC(Mesh PEPFHNJFNIL, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBA60", Offset = "0x7BEA060", VA = "0x187BEBA60")]
	public EHAHPPOABGC(EHAHPPOABGC APDBNIMCPID, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAD30", Offset = "0x7BE9330", VA = "0x187BEAD30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB4D0", Offset = "0x7BE9AD0", VA = "0x187BEB4D0")]
	public void IIGLPCDPOEE([In] EHAHPPOABGC NEKLMLONNIM, float4x4 HFLBLHLDCPA, Transform HGJDCEPMKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEA940", Offset = "0x7BE8F40", VA = "0x187BEA940")]
	public void ALDNNLJKFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAFE0", Offset = "0x7BE95E0", VA = "0x187BEAFE0")]
	public void ICMCOBOIBMC(float JPGIFEODCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAB30", Offset = "0x7BE9130", VA = "0x187BEAB30")]
	public EHAHPPOABGC CGLLPDDGPDA(Allocator NDFENJBGNOB, CancellationToken CBJPDIFOEKF)
	{
		return default(EHAHPPOABGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAEC0", Offset = "0x7BE94C0", VA = "0x187BEAEC0")]
	public Mesh GHGLJPLOCLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAA90", Offset = "0x7BE9090", VA = "0x187BEAA90")]
	private unsafe static float3* AMOLIELBFAG(NativeArray<float3> NBBLCIBNPBK)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAAE0", Offset = "0x7BE90E0", VA = "0x187BEAAE0")]
	private unsafe static int* AMOLIELBFAG(NativeArray<int> NBBLCIBNPBK)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB850", Offset = "0x7BE9E50", VA = "0x187BEB850")]
	[CompilerGenerated]
	internal static void MMDINCNDDIG(int OHAPAIELIKB, int PLLDGDDNDJH, NLMNBCOCOCD P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OIHBNDKGOEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int DCHGDNOGAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int BGNONGNFGEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FLOPHDADGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF760", Offset = "0x7BEDD60", VA = "0x187BEF760")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26661C0", Offset = "0x26647C0", VA = "0x1826661C0")]
	public static OIHBNDKGOEA MBKCEPDOHAP(OIHBNDKGOEA FDJHCIBLFFB, OIHBNDKGOEA CNIMJCCKEDM)
	{
		return default(OIHBNDKGOEA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF810", Offset = "0x7BEDE10", VA = "0x187BEF810")]
	public static OIHBNDKGOEA PHPPGOMNCAO(OIHBNDKGOEA OLMBJMMIOHD, int KLJKHLHNLGP)
	{
		return default(OIHBNDKGOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF770", Offset = "0x7BEDD70", VA = "0x187BEF770", Slot = "0")]
	public override bool Equals(object OHIOLHDCJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF7C0", Offset = "0x7BEDDC0", VA = "0x187BEF7C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF830", Offset = "0x7BEDE30", VA = "0x187BEF830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
