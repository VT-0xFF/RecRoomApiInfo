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
public struct PHMIFPGEKBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct LCCCFJCPCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int CKKNFBAOKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int KHJLKCCNMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int FNOJNDJMNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int AKEILGKNHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int DBNHNPPCPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int JDCDIAKLHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 KIEMKHOKNKL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x65E75B0", Offset = "0x65E63B0", VA = "0x1865E75B0")]
		public LCCCFJCPCDO(int MAOJOLKPEHP, int NCGGMAHKBNE, int BLHKKLCIEGP, int FFCKKMMEOMF, int AFNEPJDIAHF, int KNHEDEMKGFL, float3 FBLODFOLDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct GLEPGJAGKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int OCKMKDFBLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int OEIIGOGPNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float DGJLPPBOHPO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2593500", Offset = "0x2592300", VA = "0x182593500")]
		public GLEPGJAGKJD(int BDHLMGMJDKP, int JCCNICLOFED, float IJADEPADDKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct HBIMBHIBNFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int OEIIGOGPNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int IDOPNMKFOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int BGCDPOEANCE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, LCCCFJCPCDO> EFIHAAABDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<GLEPGJAGKJD> OIHAIEKHNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> BJNELDJOHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<HBIMBHIBNFH> EJBLBKBOPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> DMGGNBFPPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int FGHJPBKFHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int FODMPHCPCOP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65E8DB0", Offset = "0x65E7BB0", VA = "0x1865E8DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65E92E0", Offset = "0x65E80E0", VA = "0x1865E92E0")]
	public bool EOCAHNCIAJC(in NativeArray<float3> MCGPLHPFOKA, ref NativeList<float3> POANGNHIBOK, ref NativeList<int> AJGFBNHKPHM, Allocator HIEJKCFDMDD, CancellationToken ONFKFAAPNBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x65E97F0", Offset = "0x65E85F0", VA = "0x1865E97F0")]
	private void GIHONBOCKDC(in NativeArray<float3> MCGPLHPFOKA, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65E7740", Offset = "0x65E6540", VA = "0x1865E7740")]
	private void BBLGLHGPGDA(in NativeArray<float3> MCGPLHPFOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65E93C0", Offset = "0x65E81C0", VA = "0x1865E93C0")]
	private void EOMIHECDNHO(in NativeArray<float3> MCGPLHPFOKA, out int AGPNDIIIMGK, out int GEEDCGNBKFD, out int ELHAOABFOCP, out int IEHMOGGLNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x65E8BC0", Offset = "0x65E79C0", VA = "0x1865E8BC0")]
	private void COOGOPNOJAJ(in NativeArray<float3> MCGPLHPFOKA, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65E9CA0", Offset = "0x65E8AA0", VA = "0x1865E9CA0")]
	private void KMCEPJIELGC(in NativeArray<float3> MCGPLHPFOKA, float3 LKPMINMHIIB, int DKJCJNIANBA, LCCCFJCPCDO EPCNCIEFCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65EA7F0", Offset = "0x65E95F0", VA = "0x1865EA7F0")]
	private void MMHCIFFDJAO(in NativeArray<float3> MCGPLHPFOKA, float3 LKPMINMHIIB, int PIGEACMLFDI, int FODMPHCPCOP, LCCCFJCPCDO EPCNCIEFCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65EA270", Offset = "0x65E9070", VA = "0x1865EA270")]
	private void LMHGHHHKAJB(in NativeArray<float3> MCGPLHPFOKA, int NGFBILGALJL, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x65E8840", Offset = "0x65E7640", VA = "0x1865E8840")]
	private void BEJPLKHNHEI(in NativeArray<float3> MCGPLHPFOKA, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65E8EF0", Offset = "0x65E7CF0", VA = "0x1865E8EF0")]
	private void ECCAFGNJNLJ(in NativeArray<float3> MCGPLHPFOKA, ref NativeList<float3> POANGNHIBOK, ref NativeList<int> AJGFBNHKPHM, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65E9770", Offset = "0x65E8570", VA = "0x1865E9770")]
	private float GEONJJHFIGH(float3 LKPMINMHIIB, float3 NKHNOLBOGNP, LCCCFJCPCDO EPCNCIEFCPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65E5CD0", Offset = "0x65E4AD0", VA = "0x1865E5CD0")]
	private float3 KIEMKHOKNKL(float3 MAOJOLKPEHP, float3 NCGGMAHKBNE, float3 BLHKKLCIEGP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1128530", Offset = "0x1127330", VA = "0x181128530")]
	private static float MECPOOFICBJ(float3 FEIPFLDEPBD, float3 MIECAKFJHNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65EABE0", Offset = "0x65E99E0", VA = "0x1865EABE0")]
	private static float3 PFGJABAEKAP(float3 FEIPFLDEPBD, float3 MIECAKFJHNF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x65EA1F0", Offset = "0x65E8FF0", VA = "0x1865EA1F0")]
	private bool LIDBDKKGOLG(float3 FEIPFLDEPBD, float3 MIECAKFJHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x65E5E40", Offset = "0x65E4C40", VA = "0x1865E5E40")]
	private bool LEPOJGNMEDK(float3 FEIPFLDEPBD, float3 MIECAKFJHNF, float3 BPJNCMDPHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x65E9960", Offset = "0x65E8760", VA = "0x1865E9960")]
	private bool HPKALDLHLIK(float3 FEIPFLDEPBD, float3 MIECAKFJHNF, float3 BPJNCMDPHOE, float3 IJADEPADDKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GJIFGFAHOPK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DMIJGJEMPGN
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
	private NativeList<float3> FDEMFAODGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> HOPELLFNLLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NEJAHCIMIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x65E68C0", Offset = "0x65E56C0", VA = "0x1865E68C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HHEFOFMKAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65E7090", Offset = "0x65E5E90", VA = "0x1865E7090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AMFLHOGACPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65E7050", Offset = "0x65E5E50", VA = "0x1865E7050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NEHBJPJEAOA LJHGGBGBAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x65E6E80", Offset = "0x65E5C80", VA = "0x1865E6E80")]
		get
		{
			return default(NEHBJPJEAOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65E7500", Offset = "0x65E6300", VA = "0x1865E7500")]
	public GJIFGFAHOPK(int EKPCEBDDKAC, int LGEEIEEFHKK, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x65E70D0", Offset = "0x65E5ED0", VA = "0x1865E70D0")]
	public GJIFGFAHOPK(NEHBJPJEAOA IINLFMFGINH, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65E7100", Offset = "0x65E5F00", VA = "0x1865E7100")]
	public GJIFGFAHOPK(Mesh DPOJLBHHPEO, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x65E72A0", Offset = "0x65E60A0", VA = "0x1865E72A0")]
	public GJIFGFAHOPK(GJIFGFAHOPK PHAPMEHMHAK, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x65E6830", Offset = "0x65E5630", VA = "0x1865E6830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x65E5F50", Offset = "0x65E4D50", VA = "0x1865E5F50")]
	public void AHKNMMEAEHA(in GJIFGFAHOPK HOKEJKCPCMA, float4x4 LDPEGCBPJII, Transform PDOKGEDOHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x65E6650", Offset = "0x65E5450", VA = "0x1865E6650")]
	public void BMAMKGBIJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65E6900", Offset = "0x65E5700", VA = "0x1865E6900")]
	public void GMGKLCDKAOE(float EMEIKNNEGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65E6360", Offset = "0x65E5160", VA = "0x1865E6360")]
	public GJIFGFAHOPK BGDBBKMKJPE(Allocator HIEJKCFDMDD, CancellationToken ONFKFAAPNBK)
	{
		return default(GJIFGFAHOPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x65E6F30", Offset = "0x65E5D30", VA = "0x1865E6F30")]
	public Mesh KCAEKIFBODB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x65E6E30", Offset = "0x65E5C30", VA = "0x1865E6E30")]
	private unsafe static float3* HIIACBPIIKL(NativeArray<float3> ECEFKNGMHII)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x65E6DE0", Offset = "0x65E5BE0", VA = "0x1865E6DE0")]
	private unsafe static int* HIIACBPIIKL(NativeArray<int> ECEFKNGMHII)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x65E6F00", Offset = "0x65E5D00", VA = "0x1865E6F00")]
	[CompilerGenerated]
	internal static void IIJAAJDHKFE(int EBNGNJPOKHK, int HJGCENOFFKB, ref DMIJGJEMPGN P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NEHBJPJEAOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int NEJAHCIMIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int HHEFOFMKAHN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PHBGNEMPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x65E75F0", Offset = "0x65E63F0", VA = "0x1865E75F0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5A20350", Offset = "0x5A1F150", VA = "0x185A20350")]
	public static NEHBJPJEAOA DHHECOJPLIP(NEHBJPJEAOA FEIPFLDEPBD, NEHBJPJEAOA MIECAKFJHNF)
	{
		return default(NEHBJPJEAOA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65E7640", Offset = "0x65E6440", VA = "0x1865E7640")]
	public static NEHBJPJEAOA GIFOIJBGNMF(NEHBJPJEAOA KPMBAPECPPG, int CJONLFIMNPH)
	{
		return default(NEHBJPJEAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65E7600", Offset = "0x65E6400", VA = "0x1865E7600", Slot = "0")]
	public override bool Equals(object NJIMLODJFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65E7660", Offset = "0x65E6460", VA = "0x1865E7660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65E76A0", Offset = "0x65E64A0", VA = "0x1865E76A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ACBDJNNCAPM
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
