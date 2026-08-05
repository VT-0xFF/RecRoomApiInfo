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
public struct OMMPPIAMFOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct CGAPCKKCGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int MMJNIFODBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int HPKJOPIKJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int JLJMIMOFFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int EKPPMJNKPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int FCKFBOJJNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int CHEHOPFIFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 BNEAMNJFFCC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x177FA70", Offset = "0x177E670", VA = "0x18177FA70")]
		public CGAPCKKCGIJ(int EOKNBJODDCH, int BEHEEOGCJMF, int FHFOEGCHAEM, int DNGIAIDHMAE, int EEMONOKIEJM, int DAEFNGABHJK, float3 CKJOCFEAOON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct DEGCFKAPGHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int IFDMOPBBLLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int PMEAOMJLAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float GDCJOFPNOOH;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x177FAB0", Offset = "0x177E6B0", VA = "0x18177FAB0")]
		public DEGCFKAPGHO(int MOHICFNMKJK, int EMCNBABKKEG, float KOLFADHHADO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct KELBHIKBMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int PMEAOMJLAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int DPFGELPFBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int JHEACGFKJME;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, CGAPCKKCGIJ> KOKGEDLCNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<DEGCFKAPGHO> ACDDNNHCHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> EFBKFCBAOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<KELBHIKBMON> ILLMOKKHBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> LBEMCGGPKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int EDCABKNDNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int HJGFKDFPHIO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1781370", Offset = "0x177FF70", VA = "0x181781370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1783410", Offset = "0x1782010", VA = "0x181783410")]
	public bool IGEDDOCADAN(in NativeArray<float3> IMPMNPMHICJ, ref NativeList<float3> KOJEANMHKGC, ref NativeList<int> GLOIMKGLFDE, Allocator GMPKDKMDMBG, CancellationToken DDPNAGPNMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1783990", Offset = "0x1782590", VA = "0x181783990")]
	private void NFHIBICHHJH(in NativeArray<float3> IMPMNPMHICJ, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1783C80", Offset = "0x1782880", VA = "0x181783C80")]
	private void OCNLNACILPI(in NativeArray<float3> IMPMNPMHICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1782FD0", Offset = "0x1781BD0", VA = "0x181782FD0")]
	private void IEHNMPMECOM(in NativeArray<float3> IMPMNPMHICJ, out int CAAMPCBFJHN, out int LPIOEKPNGPE, out int BIJCGALJIMM, out int COKDPODBHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1781460", Offset = "0x1780060", VA = "0x181781460")]
	private void EHPMPHBOEJK(in NativeArray<float3> IMPMNPMHICJ, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1782A90", Offset = "0x1781690", VA = "0x181782A90")]
	private void HMDEBEKCPKA(in NativeArray<float3> IMPMNPMHICJ, float3 IABANLOJEAM, int BGNKHPOKDJA, CGAPCKKCGIJ KAKLEPABFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x17816B0", Offset = "0x17802B0", VA = "0x1817816B0")]
	private void EMFMGAPOMKD(in NativeArray<float3> IMPMNPMHICJ, float3 IABANLOJEAM, int HMBEOCBHLGJ, int HJGFKDFPHIO, CGAPCKKCGIJ KAKLEPABFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x17825C0", Offset = "0x17811C0", VA = "0x1817825C0")]
	private void GJMKEKDMIEM(in NativeArray<float3> IMPMNPMHICJ, int BBECLCJBNFH, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1782280", Offset = "0x1780E80", VA = "0x181782280")]
	private void FFEKDCPIJBA(in NativeArray<float3> IMPMNPMHICJ, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x17834F0", Offset = "0x17820F0", VA = "0x1817834F0")]
	private void IJBFKOLMKPN(in NativeArray<float3> IMPMNPMHICJ, ref NativeList<float3> KOJEANMHKGC, ref NativeList<int> GLOIMKGLFDE, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1784820", Offset = "0x1783420", VA = "0x181784820")]
	private float PPGAMFDFCJJ(float3 IABANLOJEAM, float3 IKLNHKMJKCP, CGAPCKKCGIJ KAKLEPABFPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x17811E0", Offset = "0x177FDE0", VA = "0x1817811E0")]
	private float3 BNEAMNJFFCC(float3 EOKNBJODDCH, float3 BEHEEOGCJMF, float3 FHFOEGCHAEM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x16D4830", Offset = "0x16D3430", VA = "0x1816D4830")]
	private static float MMIEGOFEKMM(float3 FIJKOPICOJA, float3 JCHDICMDCKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1783AF0", Offset = "0x17826F0", VA = "0x181783AF0")]
	private static float3 NLBMHNCOCMB(float3 FIJKOPICOJA, float3 JCHDICMDCKL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1783BC0", Offset = "0x17827C0", VA = "0x181783BC0")]
	private bool OCALGKLJLKI(float3 FIJKOPICOJA, float3 JCHDICMDCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1783850", Offset = "0x1782450", VA = "0x181783850")]
	private bool LHGNBKJOBAC(float3 FIJKOPICOJA, float3 JCHDICMDCKL, float3 DILCHLNKBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1781AE0", Offset = "0x17806E0", VA = "0x181781AE0")]
	private bool FDNFADHGAPD(float3 FIJKOPICOJA, float3 JCHDICMDCKL, float3 DILCHLNKBGI, float3 KOLFADHHADO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MNFDEKABCLH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OPNLABMEEJK
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
	private NativeList<float3> MCDNBLNIEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> OBMAEEIEDNB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JMDCGNEMBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1780B40", Offset = "0x177F740", VA = "0x181780B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AKICFHHHDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1780730", Offset = "0x177F330", VA = "0x181780730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OEFMLAFNFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1780B00", Offset = "0x177F700", VA = "0x181780B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JMOBOKMADNI KFHBPGNODDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1780770", Offset = "0x177F370", VA = "0x181780770")]
		get
		{
			return default(JMOBOKMADNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1780ED0", Offset = "0x177FAD0", VA = "0x181780ED0")]
	public MNFDEKABCLH(int DDEMDHHCHHL, int NLGAGPNAJIO, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x17811B0", Offset = "0x177FDB0", VA = "0x1817811B0")]
	public MNFDEKABCLH(JMOBOKMADNI HIGNHBBCBMJ, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1780D50", Offset = "0x177F950", VA = "0x181780D50")]
	public MNFDEKABCLH(Mesh NBBCOGHADLE, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1780F80", Offset = "0x177FB80", VA = "0x181780F80")]
	public MNFDEKABCLH(MNFDEKABCLH MCCGGLNMBDL, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x17801E0", Offset = "0x177EDE0", VA = "0x1817801E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x177FDE0", Offset = "0x177E9E0", VA = "0x18177FDE0")]
	public void DLPDCPCMKFM(in MNFDEKABCLH NFBENFHFKBO, float4x4 NPOFFLJHAPF, Transform GMDFFJHDCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x177FC20", Offset = "0x177E820", VA = "0x18177FC20")]
	public void BNHMGGCHBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1780260", Offset = "0x177EE60", VA = "0x181780260")]
	public void EDDJFBBABGP(float AAGCHNKPMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x17807F0", Offset = "0x177F3F0", VA = "0x1817807F0")]
	public MNFDEKABCLH KADGECALPNF(Allocator GMPKDKMDMBG, CancellationToken DDPNAGPNMPM)
	{
		return default(MNFDEKABCLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1780BB0", Offset = "0x177F7B0", VA = "0x181780BB0")]
	public Mesh MPPDCPCIMMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1780CB0", Offset = "0x177F8B0", VA = "0x181780CB0")]
	private unsafe static float3* NCMJMIAGIDI(NativeArray<float3> BBFDALJHIIP)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1780D00", Offset = "0x177F900", VA = "0x181780D00")]
	private unsafe static int* NCMJMIAGIDI(NativeArray<int> BBFDALJHIIP)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1780B80", Offset = "0x177F780", VA = "0x181780B80")]
	[CompilerGenerated]
	internal static void LELFBADIGPL(int IKEAIGFLMML, int LJPBIPGEFNJ, ref OPNLABMEEJK P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JMOBOKMADNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int JMDCGNEMBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int AKICFHHHDIE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AEHHFIPECBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x177FB30", Offset = "0x177E730", VA = "0x18177FB30")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x13FEF20", Offset = "0x13FDB20", VA = "0x1813FEF20")]
	public static JMOBOKMADNI OHGKCMEBKBN(JMOBOKMADNI FIJKOPICOJA, JMOBOKMADNI JCHDICMDCKL)
	{
		return default(JMOBOKMADNI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x177FAC0", Offset = "0x177E6C0", VA = "0x18177FAC0")]
	public static JMOBOKMADNI BDCMCKMONNE(JMOBOKMADNI CIJFEHEKHGL, int JFMIANKFBPB)
	{
		return default(JMOBOKMADNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x177FAE0", Offset = "0x177E6E0", VA = "0x18177FAE0", Slot = "0")]
	public override bool Equals(object KBCGKEIDENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x177FB40", Offset = "0x177E740", VA = "0x18177FB40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x177FB90", Offset = "0x177E790", VA = "0x18177FB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GAAJFMOIACF
{
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
