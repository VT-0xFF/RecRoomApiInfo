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
public struct MFDLLDELAIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct IECOADPNJIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int ABPPIAKEDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int OOPOPDDGOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int BPEPLKEFDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int GDAMECMGGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int MAODBLAMHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int LDIMIFIFJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 JCJMLJKLEPH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x69CD940", Offset = "0x69CBF40", VA = "0x1869CD940")]
		public IECOADPNJIA(int GKKODBNLEOJ, int JNHCBBLBFFJ, int FBCMHDNHBPL, int PBBNEHAPFGC, int KKACCMDLPDK, int JOJENCFEMEK, float3 MHHLIPGJMOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct AHKOBGCKHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int AGJNICLFCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int PBIHNFDKENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float KDKHGBNOLDE;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x11FE290", Offset = "0x11FC890", VA = "0x1811FE290")]
		public AHKOBGCKHGD(int FFJDFAKILFM, int MELEBOPHCBH, float NLNPOEKBPGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JGPDMBBAIBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int PBIHNFDKENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int ALMADDOODNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int PPKBNDDCFOL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, IECOADPNJIA> CKMGJDAEABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<AHKOBGCKHGD> KKGCODCPMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> PHGOGCANKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<JGPDMBBAIBC> DDILNMPMGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> HDKKBBGAOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int KNHAIGJFKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int EPCOFCCNOMB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69CF430", Offset = "0x69CDA30", VA = "0x1869CF430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69CEAC0", Offset = "0x69CD0C0", VA = "0x1869CEAC0")]
	public bool CHKMOGIEFCI([In] NativeArray<float3> CGEPEAAAENM, NativeList<float3> AGOKMFNHMLE, NativeList<int> FLNOIJGKJIO, Allocator KOIILCBLJPK, CancellationToken FIMAIPEFOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D0F70", Offset = "0x69CF570", VA = "0x1869D0F70")]
	private void PNLKNBIHCGI([In] NativeArray<float3> CGEPEAAAENM, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69CD980", Offset = "0x69CBF80", VA = "0x1869CD980")]
	private void BAMPLOHPEBI([In] NativeArray<float3> CGEPEAAAENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69CEC00", Offset = "0x69CD200", VA = "0x1869CEC00")]
	private void DAONFJMFAKF([In] NativeArray<float3> CGEPEAAAENM, [Out] int CDEBNPIMHOK, [Out] int KDACFEPNBGG, [Out] int PBPPFCPDAOA, [Out] int DEHPLEPMHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69CFDA0", Offset = "0x69CE3A0", VA = "0x1869CFDA0")]
	private void FGNMDPLPELN([In] NativeArray<float3> CGEPEAAAENM, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69CF940", Offset = "0x69CDF40", VA = "0x1869CF940")]
	private void EOOKMMOCHLN([In] NativeArray<float3> CGEPEAAAENM, float3 PKGGNLMKLOL, int EDCCDKGGBBM, IECOADPNJIA FAEMLPOKAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69CF570", Offset = "0x69CDB70", VA = "0x1869CF570")]
	private void EFOALDOGIHJ([In] NativeArray<float3> CGEPEAAAENM, float3 PKGGNLMKLOL, int IMDNHMMKPLB, int EPCOFCCNOMB, IECOADPNJIA FAEMLPOKAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69D0480", Offset = "0x69CEA80", VA = "0x1869D0480")]
	private void IAJKPMCMGDH([In] NativeArray<float3> CGEPEAAAENM, int IIMDDMPMPNI, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69CF0C0", Offset = "0x69CD6C0", VA = "0x1869CF0C0")]
	private void DBENEODLMJL([In] NativeArray<float3> CGEPEAAAENM, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69CFFA0", Offset = "0x69CE5A0", VA = "0x1869CFFA0")]
	private void HFJEMKOOPNL([In] NativeArray<float3> CGEPEAAAENM, NativeList<float3> AGOKMFNHMLE, NativeList<int> FLNOIJGKJIO, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69CE990", Offset = "0x69CCF90", VA = "0x1869CE990")]
	private float BBNPMLBFJND(float3 PKGGNLMKLOL, float3 NINLOFABFAF, IECOADPNJIA FAEMLPOKAGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69D0A80", Offset = "0x69CF080", VA = "0x1869D0A80")]
	private float3 JCJMLJKLEPH(float3 GKKODBNLEOJ, float3 JNHCBBLBFFJ, float3 FBCMHDNHBPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x69D0EE0", Offset = "0x69CF4E0", VA = "0x1869D0EE0")]
	private static float NOMBHPBJBLM(float3 KHKPJFABMKM, float3 CGBLKAAFCDI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69D0E80", Offset = "0x69CF480", VA = "0x1869D0E80")]
	private static float3 LFECHIOOCBN(float3 KHKPJFABMKM, float3 CGBLKAAFCDI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69D0F10", Offset = "0x69CF510", VA = "0x1869D0F10")]
	private bool PNDCEAKEIBO(float3 KHKPJFABMKM, float3 CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69CE9F0", Offset = "0x69CCFF0", VA = "0x1869CE9F0")]
	private bool BODHDKMENNL(float3 KHKPJFABMKM, float3 CGBLKAAFCDI, float3 NAHNDCNFAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69D0B90", Offset = "0x69CF190", VA = "0x1869D0B90")]
	private bool JCNMGGGMLBJ(float3 KHKPJFABMKM, float3 CGBLKAAFCDI, float3 NAHNDCNFAJC, float3 NLNPOEKBPGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ADGGFFECFJL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MOCEBKGADOM
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
	private NativeList<float3> IADKEPJGKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> JMDHNHGDBOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69CC300", Offset = "0x69CA900", VA = "0x1869CC300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ALMEHFENJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69CC3D0", Offset = "0x69CA9D0", VA = "0x1869CC3D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ANHMLBKHNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69CCFD0", Offset = "0x69CB5D0", VA = "0x1869CCFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AELPHCGDNMB CPPPCKDDMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69CC280", Offset = "0x69CA880", VA = "0x1869CC280")]
		get
		{
			return default(AELPHCGDNMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69CD3A0", Offset = "0x69CB9A0", VA = "0x1869CD3A0")]
	public ADGGFFECFJL(int KJLIFFOOJEF, int PHNKJDLMLOL, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69CD370", Offset = "0x69CB970", VA = "0x1869CD370")]
	public ADGGFFECFJL(AELPHCGDNMB GCHBOKPJEEB, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69CD200", Offset = "0x69CB800", VA = "0x1869CD200")]
	public ADGGFFECFJL(Mesh CKFPIMAMAKM, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69CD460", Offset = "0x69CBA60", VA = "0x1869CD460")]
	public ADGGFFECFJL(ADGGFFECFJL MMDLBEBNCGC, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69CC340", Offset = "0x69CA940", VA = "0x1869CC340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69CC640", Offset = "0x69CAC40", VA = "0x1869CC640")]
	public void LHEPNGLDBLI([In] ADGGFFECFJL MADFKNCBFBG, float4x4 GCKKDKDKEHM, Transform MGFHCPPOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69CD010", Offset = "0x69CB610", VA = "0x1869CD010")]
	public void OIAPOMFIMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69CC9C0", Offset = "0x69CAFC0", VA = "0x1869CC9C0")]
	public void LMBCDBINANJ(float KPAPKDHNJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69CC410", Offset = "0x69CAA10", VA = "0x1869CC410")]
	public ADGGFFECFJL JEKIBFCHNCE(Allocator KOIILCBLJPK, CancellationToken FIMAIPEFOAM)
	{
		return default(ADGGFFECFJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69CCEB0", Offset = "0x69CB4B0", VA = "0x1869CCEB0")]
	public Mesh MFHBNNIPFCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69CD1B0", Offset = "0x69CB7B0", VA = "0x1869CD1B0")]
	private unsafe static float3* PLKBGECAIIB(NativeArray<float3> FAJBEEIFFCK)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69CD160", Offset = "0x69CB760", VA = "0x1869CD160")]
	private unsafe static int* PLKBGECAIIB(NativeArray<int> FAJBEEIFFCK)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69CC610", Offset = "0x69CAC10", VA = "0x1869CC610")]
	[CompilerGenerated]
	internal static void JIPGMJPMBLP(int NFIACONGDMJ, int GPENLMKJKLG, MOCEBKGADOM P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct AELPHCGDNMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int DJEJONINPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int ALMEHFENJNK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MHGAEPJHELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69CD7D0", Offset = "0x69CBDD0", VA = "0x1869CD7D0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0FB0", Offset = "0x1EEF5B0", VA = "0x181EF0FB0")]
	public static AELPHCGDNMB PKEDDAIIGLG(AELPHCGDNMB KHKPJFABMKM, AELPHCGDNMB CGBLKAAFCDI)
	{
		return default(AELPHCGDNMB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69CD880", Offset = "0x69CBE80", VA = "0x1869CD880")]
	public static AELPHCGDNMB HFILMEPHGDP(AELPHCGDNMB BFAKIMCNNKD, int NOOFNNECEBO)
	{
		return default(AELPHCGDNMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69CD7E0", Offset = "0x69CBDE0", VA = "0x1869CD7E0", Slot = "0")]
	public override bool Equals(object IEFFCIPANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69CD830", Offset = "0x69CBE30", VA = "0x1869CD830", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69CD8A0", Offset = "0x69CBEA0", VA = "0x1869CD8A0", Slot = "3")]
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
