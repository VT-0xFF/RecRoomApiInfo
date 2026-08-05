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
		[Cpp2IlInjected.Address(RVA = "0x7C1EEF0", Offset = "0x7C1DEF0", VA = "0x187C1EEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC8C5B0", Offset = "0xC8B5B0", VA = "0x180C8C5B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C1FA80", Offset = "0x7C1EA80", VA = "0x187C1FA80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FCD0", Offset = "0x7C1ECD0", VA = "0x187C1FCD0")]
	public bool EODDHKJBDMN([In] NativeArray<float3> FPGLCMFAFBI, NativeList<float3> JAIBDMKDPON, NativeList<int> HKHJDBHLOPP, Allocator NDFENJBGNOB, CancellationToken CBJPDIFOEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EF30", Offset = "0x7C1DF30", VA = "0x187C1EF30")]
	private void ANJKPBDKBKO([In] NativeArray<float3> FPGLCMFAFBI, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C204D0", Offset = "0x7C1F4D0", VA = "0x187C204D0")]
	private void JMIMKOKDEJC([In] NativeArray<float3> FPGLCMFAFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F500", Offset = "0x7C1E500", VA = "0x187C1F500")]
	private void DCIINJEFKPG([In] NativeArray<float3> FPGLCMFAFBI, [Out] int KPHCGPCNJGF, [Out] int AJHJLMFGIBI, [Out] int IKODBJCNBDN, [Out] int GCJCKGMGOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C225E0", Offset = "0x7C215E0", VA = "0x187C225E0")]
	private void PJIFPELPEOA([In] NativeArray<float3> FPGLCMFAFBI, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C215C0", Offset = "0x7C205C0", VA = "0x187C215C0")]
	private void OLGKFLKFJJF([In] NativeArray<float3> FPGLCMFAFBI, float3 DJHCIGKJNEI, int LIKLGAEKOOG, EPAPHEGHLGC FLGOFLOCIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F110", Offset = "0x7C1E110", VA = "0x187C1F110")]
	private void CMFEOMGJGBD([In] NativeArray<float3> FPGLCMFAFBI, float3 DJHCIGKJNEI, int GDBHLMJLKEJ, int GCEAHGBOKML, EPAPHEGHLGC FLGOFLOCIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C21F80", Offset = "0x7C20F80", VA = "0x187C21F80")]
	private void OOFMCBMHNJK([In] NativeArray<float3> FPGLCMFAFBI, int PKNICCENLBL, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C20160", Offset = "0x7C1F160", VA = "0x187C20160")]
	private void HEGEJOEHBDE([In] NativeArray<float3> FPGLCMFAFBI, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C21AA0", Offset = "0x7C20AA0", VA = "0x187C21AA0")]
	private void OOCPGLLBCGG([In] NativeArray<float3> FPGLCMFAFBI, NativeList<float3> JAIBDMKDPON, NativeList<int> HKHJDBHLOPP, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F9C0", Offset = "0x7C1E9C0", VA = "0x187C1F9C0")]
	private float DLDJDCPHLHP(float3 DJHCIGKJNEI, float3 EICNBIHOGDD, EPAPHEGHLGC FLGOFLOCIFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FBC0", Offset = "0x7C1EBC0", VA = "0x187C1FBC0")]
	private float3 ENMINAOPOCJ(float3 HPLOFABFHPL, float3 PPMLHPJGPIJ, float3 IFMEGLHJPDI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FE10", Offset = "0x7C1EE10", VA = "0x187C1FE10")]
	private static float GEJOPMECMPD(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FA20", Offset = "0x7C1EA20", VA = "0x187C1FA20")]
	private static float3 DNMMKNLHOHN(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C22580", Offset = "0x7C21580", VA = "0x187C22580")]
	private bool OOIPMFMEMPI(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C214F0", Offset = "0x7C204F0", VA = "0x187C214F0")]
	private bool OJGKAFCFNNG(float3 FDJHCIBLFFB, float3 CNIMJCCKEDM, float3 JKIBOICMIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FE40", Offset = "0x7C1EE40", VA = "0x187C1FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C1E8E0", Offset = "0x7C1D8E0", VA = "0x187C1E8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DEE0", Offset = "0x7C1CEE0", VA = "0x187C1DEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DEA0", Offset = "0x7C1CEA0", VA = "0x187C1DEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OIHBNDKGOEA ONFBCHHKPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE20", Offset = "0x7C1CE20", VA = "0x187C1DE20")]
		get
		{
			return default(OIHBNDKGOEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EE30", Offset = "0x7C1DE30", VA = "0x187C1EE30")]
	public EHAHPPOABGC(int NPGNODKKKAD, int PCGPKCCHANN, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E920", Offset = "0x7C1D920", VA = "0x187C1E920")]
	public EHAHPPOABGC(OIHBNDKGOEA PKCEJFAFCCA, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E950", Offset = "0x7C1D950", VA = "0x187C1E950")]
	public EHAHPPOABGC(Mesh PEPFHNJFNIL, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EAC0", Offset = "0x7C1DAC0", VA = "0x187C1EAC0")]
	public EHAHPPOABGC(EHAHPPOABGC APDBNIMCPID, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DD90", Offset = "0x7C1CD90", VA = "0x187C1DD90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E530", Offset = "0x7C1D530", VA = "0x187C1E530")]
	public void IIGLPCDPOEE([In] EHAHPPOABGC NEKLMLONNIM, float4x4 HFLBLHLDCPA, Transform HGJDCEPMKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D9A0", Offset = "0x7C1C9A0", VA = "0x187C1D9A0")]
	public void ALDNNLJKFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E040", Offset = "0x7C1D040", VA = "0x187C1E040")]
	public void ICMCOBOIBMC(float JPGIFEODCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DB90", Offset = "0x7C1CB90", VA = "0x187C1DB90")]
	public EHAHPPOABGC CGLLPDDGPDA(Allocator NDFENJBGNOB, CancellationToken CBJPDIFOEKF)
	{
		return default(EHAHPPOABGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DF20", Offset = "0x7C1CF20", VA = "0x187C1DF20")]
	public Mesh GHGLJPLOCLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DAF0", Offset = "0x7C1CAF0", VA = "0x187C1DAF0")]
	private unsafe static float3* AMOLIELBFAG(NativeArray<float3> NBBLCIBNPBK)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DB40", Offset = "0x7C1CB40", VA = "0x187C1DB40")]
	private unsafe static int* AMOLIELBFAG(NativeArray<int> NBBLCIBNPBK)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E8B0", Offset = "0x7C1D8B0", VA = "0x187C1E8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C227E0", Offset = "0x7C217E0", VA = "0x187C227E0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2663C60", Offset = "0x2662C60", VA = "0x182663C60")]
	public static OIHBNDKGOEA MBKCEPDOHAP(OIHBNDKGOEA FDJHCIBLFFB, OIHBNDKGOEA CNIMJCCKEDM)
	{
		return default(OIHBNDKGOEA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C22890", Offset = "0x7C21890", VA = "0x187C22890")]
	public static OIHBNDKGOEA PHPPGOMNCAO(OIHBNDKGOEA OLMBJMMIOHD, int KLJKHLHNLGP)
	{
		return default(OIHBNDKGOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C227F0", Offset = "0x7C217F0", VA = "0x187C227F0", Slot = "0")]
	public override bool Equals(object OHIOLHDCJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C22840", Offset = "0x7C21840", VA = "0x187C22840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C228B0", Offset = "0x7C218B0", VA = "0x187C228B0", Slot = "3")]
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
