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
public struct CGADPLCKLIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct BIFBNNHDGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int FFJJLAHFLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int LLFOHFPBJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int BNELIFLCPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int PIDKBPOHPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int LGDFBLNEEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int IIFMFFJFFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 JHAAGJCGCDG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71A41E0", Offset = "0x71A27E0", VA = "0x1871A41E0")]
		public BIFBNNHDGNH(int HCINFDFCPJC, int LODCJOOKOKB, int BGNINEPEJBJ, int LNNAHKBMPEN, int KKCMBCGFLJO, int LJCJEGCNNHJ, float3 MCAKNKCONJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct OALAGDMEGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int EOLBIDJIPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int APHANFJFIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float JOCFCMPHCDH;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x229F750", Offset = "0x229DD50", VA = "0x18229F750")]
		public OALAGDMEGKG(int KMJAIGGLKJN, int EEPDLDPLPOD, float FGJCLMKLDKK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct BCOJMFECCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int APHANFJFIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int FJNPOANLCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int NNMABFDGIDO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, BIFBNNHDGNH> BHNDKGAAPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<OALAGDMEGKG> EHAHMIIMHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> PAPDGFFHHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<BCOJMFECCDC> OAIADGPAGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> FAFPBFOMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int HOHNPKELNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int MPBINGIOBIN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71A5560", Offset = "0x71A3B60", VA = "0x1871A5560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71A56A0", Offset = "0x71A3CA0", VA = "0x1871A56A0")]
	public bool EOEMCMMIGNF(in NativeArray<float3> LDCHJOGLABL, ref NativeList<float3> EJNLHGKCEDH, ref NativeList<int> KEFLDCLCCNN, Allocator HDOCJKNPNPA, CancellationToken OOAGLCBNIOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x71A71F0", Offset = "0x71A57F0", VA = "0x1871A71F0")]
	private void KGHKJOCLFMF(in NativeArray<float3> LDCHJOGLABL, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x71A63A0", Offset = "0x71A49A0", VA = "0x1871A63A0")]
	private void KEKOIBDOLKP(in NativeArray<float3> LDCHJOGLABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71A5E60", Offset = "0x71A4460", VA = "0x1871A5E60")]
	private void IICAICPABBO(in NativeArray<float3> LDCHJOGLABL, out int MFHGNIIFGHI, out int IHEBODDIPKN, out int JNKGCDPJCBD, out int CJJMAOCGDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x71A5790", Offset = "0x71A3D90", VA = "0x1871A5790")]
	private void FKGNCNEMAOE(in NativeArray<float3> LDCHJOGLABL, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71A4750", Offset = "0x71A2D50", VA = "0x1871A4750")]
	private void AGAPNAIGEAP(in NativeArray<float3> LDCHJOGLABL, float3 DEGODPDOPJM, int IMFEKFHCBAE, BIFBNNHDGNH BBKIDFCMKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x71A5980", Offset = "0x71A3F80", VA = "0x1871A5980")]
	private void HDHKNGGIBJH(in NativeArray<float3> LDCHJOGLABL, float3 DEGODPDOPJM, int HELLLGDPIKF, int MPBINGIOBIN, BIFBNNHDGNH BBKIDFCMKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x71A4C30", Offset = "0x71A3230", VA = "0x1871A4C30")]
	private void CIKEFIJJALH(in NativeArray<float3> LDCHJOGLABL, int PGMJBJHMLEN, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71A51E0", Offset = "0x71A37E0", VA = "0x1871A51E0")]
	private void DEKMAICMLEA(in NativeArray<float3> LDCHJOGLABL, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71A4390", Offset = "0x71A2990", VA = "0x1871A4390")]
	private void ABFOEMDJHGN(in NativeArray<float3> LDCHJOGLABL, ref NativeList<float3> EJNLHGKCEDH, ref NativeList<int> KEFLDCLCCNN, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71A5DF0", Offset = "0x71A43F0", VA = "0x1871A5DF0")]
	private float HMHBLOOAFCC(float3 DEGODPDOPJM, float3 IDONPOBMIDF, BIFBNNHDGNH BBKIDFCMKIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x71A3D80", Offset = "0x71A2380", VA = "0x1871A3D80")]
	private float3 JHAAGJCGCDG(float3 HCINFDFCPJC, float3 LODCJOOKOKB, float3 BGNINEPEJBJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3F60", Offset = "0x5CC2560", VA = "0x185CC3F60")]
	private static float OIEJMNCAFGC(float3 LLAFGJINMOA, float3 LKIHFBEPDMH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AC90", Offset = "0x6C99290", VA = "0x186C9AC90")]
	private static float3 NOPDIOFHHAP(float3 LLAFGJINMOA, float3 LKIHFBEPDMH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x71A5D90", Offset = "0x71A4390", VA = "0x1871A5D90")]
	private bool HFEMEAKIGGL(float3 LLAFGJINMOA, float3 LKIHFBEPDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x71A62C0", Offset = "0x71A48C0", VA = "0x1871A62C0")]
	private bool IICGAGJOEOO(float3 LLAFGJINMOA, float3 LKIHFBEPDMH, float3 HFOHBFLEBEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71A73D0", Offset = "0x71A59D0", VA = "0x1871A73D0")]
	private bool NLLAKANONEJ(float3 LLAFGJINMOA, float3 LKIHFBEPDMH, float3 HFOHBFLEBEL, float3 FGJCLMKLDKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EELKLGDBKIO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct EFHBJKPDPOO
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
	private NativeList<float3> FHDNHEAPBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> IILPIBLHNHA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EPDNMCKBADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71A7F70", Offset = "0x71A6570", VA = "0x1871A7F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DKADNFEGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71A7FB0", Offset = "0x71A65B0", VA = "0x1871A7FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EGOPANFHJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71A8110", Offset = "0x71A6710", VA = "0x1871A8110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BNHPPLOEAGC JEMNPFDBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71A7C40", Offset = "0x71A6240", VA = "0x1871A7C40")]
		get
		{
			return default(BNHPPLOEAGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x71A86F0", Offset = "0x71A6CF0", VA = "0x1871A86F0")]
	public EELKLGDBKIO(int NCPBCDOMEDF, int HOFACLLPHDP, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x71A86C0", Offset = "0x71A6CC0", VA = "0x1871A86C0")]
	public EELKLGDBKIO(BNHPPLOEAGC MDMJFCDBPFI, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71A87B0", Offset = "0x71A6DB0", VA = "0x1871A87B0")]
	public EELKLGDBKIO(Mesh BIDOMMGPLKN, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x71A8940", Offset = "0x71A6F40", VA = "0x1871A8940")]
	public EELKLGDBKIO(EELKLGDBKIO GOMDNNCBLHP, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x71A7BB0", Offset = "0x71A61B0", VA = "0x1871A7BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x71A8360", Offset = "0x71A6960", VA = "0x1871A8360")]
	public void PEECNHFNIGK(in EELKLGDBKIO BDIPIDIIILI, float4x4 HBDOGBNHOBE, Transform CCEOLMAOMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x71A8150", Offset = "0x71A6750", VA = "0x1871A8150")]
	public void LINOMCNIJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x71A76F0", Offset = "0x71A5CF0", VA = "0x1871A76F0")]
	public void AOKPMJLFLME(float HPJGDBFIPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x71A7CC0", Offset = "0x71A62C0", VA = "0x1871A7CC0")]
	public EELKLGDBKIO EKMHJPHKBEP(Allocator HDOCJKNPNPA, CancellationToken OOAGLCBNIOG)
	{
		return default(EELKLGDBKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x71A7FF0", Offset = "0x71A65F0", VA = "0x1871A7FF0")]
	public Mesh HPLDENFHBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x71A82C0", Offset = "0x71A68C0", VA = "0x1871A82C0")]
	private unsafe static float3* NIOGEGMKJCA(NativeArray<float3> JHKFLJIAOGC)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x71A8310", Offset = "0x71A6910", VA = "0x1871A8310")]
	private unsafe static int* NIOGEGMKJCA(NativeArray<int> JHKFLJIAOGC)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x71A7F40", Offset = "0x71A6540", VA = "0x1871A7F40")]
	[CompilerGenerated]
	internal static void FADIAPKILBO(int HAKIBPLBKKI, int DIGPBPFAHIK, ref EFHBJKPDPOO P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct BNHPPLOEAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int EPDNMCKBADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int DKADNFEGNAM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NHKFKCHGNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71A4240", Offset = "0x71A2840", VA = "0x1871A4240")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x71A42D0", Offset = "0x71A28D0", VA = "0x1871A42D0")]
	public static BNHPPLOEAGC HDDBLAAJMND(BNHPPLOEAGC LLAFGJINMOA, BNHPPLOEAGC LKIHFBEPDMH)
	{
		return default(BNHPPLOEAGC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71A4220", Offset = "0x71A2820", VA = "0x1871A4220")]
	public static BNHPPLOEAGC BBOJOCNCBOP(BNHPPLOEAGC KGPEEAENLMH, int CIHCFCNBEAO)
	{
		return default(BNHPPLOEAGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x71A4250", Offset = "0x71A2850", VA = "0x1871A4250", Slot = "0")]
	public override bool Equals(object LMHPKJDJEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x71A4290", Offset = "0x71A2890", VA = "0x1871A4290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x71A42F0", Offset = "0x71A28F0", VA = "0x1871A42F0", Slot = "3")]
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
