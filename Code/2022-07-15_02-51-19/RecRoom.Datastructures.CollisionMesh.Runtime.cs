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
public struct DBDPDHKOALK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct KCLJNDLHBHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int DABGHIDCGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int IOABOEALJME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int IOHEAKIJKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int LMPICNGFPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int IAOCLIGMMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int FJCFBOLEGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 JFCMDNAFOCK;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51C5920", Offset = "0x51C4920", VA = "0x1851C5920")]
		public KCLJNDLHBHK(int EPIEOHJPLLB, int OCOBOINOFOP, int IOFECCNHMEJ, int GIFFOLMDKPC, int HOIBFICKEKG, int BEIPBCMINOE, float3 PCBNALDEFKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct OGDJMEMBDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int KAABMNCPOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int ABKDDELEMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float MOJJFHANNMN;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CDA0", Offset = "0x1E6BDA0", VA = "0x181E6CDA0")]
		public OGDJMEMBDLC(int FLFKMIKGJFJ, int CKCPJOBAOGJ, float LPFPPCBAAAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct EGINDOHMDGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int ABKDDELEMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int IENPGOKNNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int IBEDHPJNPNI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, KCLJNDLHBHK> OFHPBIOBCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<OGDJMEMBDLC> OEOAANDDFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> AEIONEILBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<EGINDOHMDGP> DMIDOOLPDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> FFKBDPIJDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int GFAHBFKLBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int MLKANNLPIFF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x51C28A0", Offset = "0x51C18A0", VA = "0x1851C28A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51C4260", Offset = "0x51C3260", VA = "0x1851C4260")]
	public bool KOGFNFMAIFA(in NativeArray<float3> IFOFIPGGOLP, ref NativeList<float3> GFBGHIOCBJF, ref NativeList<int> NFPGLJOONCA, Allocator NFKJHPBOKBG, CancellationToken MCLPFBCBLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51C3DC0", Offset = "0x51C2DC0", VA = "0x1851C3DC0")]
	private void JMPIMFJAEKM(in NativeArray<float3> IFOFIPGGOLP, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x51C3010", Offset = "0x51C2010", VA = "0x1851C3010")]
	private void HBMJFPNGCIN(in NativeArray<float3> IFOFIPGGOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x51C4340", Offset = "0x51C3340", VA = "0x1851C4340")]
	private void MMIHHNDJMIJ(in NativeArray<float3> IFOFIPGGOLP, out int CEDNJADKNPO, out int GIGDPKBEOEE, out int MGFJIHIJIOM, out int BLKNHLJFFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x51C2DC0", Offset = "0x51C1DC0", VA = "0x1851C2DC0")]
	private void FNPOBLJHKCI(in NativeArray<float3> IFOFIPGGOLP, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x51C5280", Offset = "0x51C4280", VA = "0x1851C5280")]
	private void OMBLGLOECLK(in NativeArray<float3> IFOFIPGGOLP, float3 DLKGDIEINAF, int DJCCHEPABLH, KCLJNDLHBHK EENFMCFOEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x51C2990", Offset = "0x51C1990", VA = "0x1851C2990")]
	private void EIMKAJJCBNE(in NativeArray<float3> IFOFIPGGOLP, float3 DLKGDIEINAF, int ILMDDBAKNKH, int MLKANNLPIFF, KCLJNDLHBHK EENFMCFOEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x51C2290", Offset = "0x51C1290", VA = "0x1851C2290")]
	private void BJDIJPPKKOD(in NativeArray<float3> IFOFIPGGOLP, int POCMLAJNFDK, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51C3F20", Offset = "0x51C2F20", VA = "0x1851C3F20")]
	private void JPKFLACJMCH(in NativeArray<float3> IFOFIPGGOLP, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x51C4F20", Offset = "0x51C3F20", VA = "0x1851C4F20")]
	private void OFAPHFKNGFE(in NativeArray<float3> IFOFIPGGOLP, ref NativeList<float3> GFBGHIOCBJF, ref NativeList<int> NFPGLJOONCA, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51C3BB0", Offset = "0x51C2BB0", VA = "0x1851C3BB0")]
	private float HFMOFDHOHFD(float3 DLKGDIEINAF, float3 DCNGHCJENMH, KCLJNDLHBHK EENFMCFOEJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x51C3C30", Offset = "0x51C2C30", VA = "0x1851C3C30")]
	private float3 JFCMDNAFOCK(float3 EPIEOHJPLLB, float3 OCOBOINOFOP, float3 IOFECCNHMEJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x513B320", Offset = "0x513A320", VA = "0x18513B320")]
	private static float EJGODKMHMCJ(float3 INIPPOEHOLP, float3 BMEGDOGJIKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x51C2100", Offset = "0x51C1100", VA = "0x1851C2100")]
	private static float3 AEDBNDPKDOC(float3 INIPPOEHOLP, float3 BMEGDOGJIKK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x51C21D0", Offset = "0x51C11D0", VA = "0x1851C21D0")]
	private bool AOJGLAIDNEO(float3 INIPPOEHOLP, float3 BMEGDOGJIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x51C2760", Offset = "0x51C1760", VA = "0x1851C2760")]
	private bool DDPFMPLIEGI(float3 INIPPOEHOLP, float3 BMEGDOGJIKK, float3 HEMCNHOJBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x51C4780", Offset = "0x51C3780", VA = "0x1851C4780")]
	private bool OCPFGEABAKJ(float3 INIPPOEHOLP, float3 BMEGDOGJIKK, float3 HEMCNHOJBJG, float3 LPFPPCBAAAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AGBHBDMNHDD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct EAHGIIDENBO
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
	private NativeList<float3> PNCBBPMAOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> AJACOEFCNOD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CFBOHNDNLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x51C18E0", Offset = "0x51C08E0", VA = "0x1851C18E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ILADHJAIGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51C1040", Offset = "0x51C0040", VA = "0x1851C1040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GNPMOBMGFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51C1A40", Offset = "0x51C0A40", VA = "0x1851C1A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FJAGCDBMGJI JMPIHHFCBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x51C19C0", Offset = "0x51C09C0", VA = "0x1851C19C0")]
		get
		{
			return default(FJAGCDBMGJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x51C1C70", Offset = "0x51C0C70", VA = "0x1851C1C70")]
	public AGBHBDMNHDD(int AOLMHAAFCMF, int CPLAHFFOPJN, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x51C1D20", Offset = "0x51C0D20", VA = "0x1851C1D20")]
	public AGBHBDMNHDD(FJAGCDBMGJI DBHBELNEOAM, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x51C1F80", Offset = "0x51C0F80", VA = "0x1851C1F80")]
	public AGBHBDMNHDD(Mesh HEEINMMNNBJ, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51C1D50", Offset = "0x51C0D50", VA = "0x1851C1D50")]
	public AGBHBDMNHDD(AGBHBDMNHDD MPLJOBCIMCD, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x51C1860", Offset = "0x51C0860", VA = "0x1851C1860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x51C0C40", Offset = "0x51BFC40", VA = "0x1851C0C40")]
	public void CGEJAMCGIKA(in AGBHBDMNHDD GLLFOKJFDGL, float4x4 LKIILANJKKI, Transform GBBJFKNJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x51C1A80", Offset = "0x51C0A80", VA = "0x1851C1A80")]
	public void MPOFOPPFLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x51C1390", Offset = "0x51C0390", VA = "0x1851C1390")]
	public void DJAFDLLNMLK(float CPAOJNIIONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x51C1080", Offset = "0x51C0080", VA = "0x1851C1080")]
	public AGBHBDMNHDD CNLAJPFEKAE(Allocator NFKJHPBOKBG, CancellationToken MCLPFBCBLEM)
	{
		return default(AGBHBDMNHDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x51C0B40", Offset = "0x51BFB40", VA = "0x1851C0B40")]
	public Mesh CDBOCECMLGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x51C1920", Offset = "0x51C0920", VA = "0x1851C1920")]
	private unsafe static float3* JMFEJMLJDFL(NativeArray<float3> FOHKJBHGAHL)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x51C1970", Offset = "0x51C0970", VA = "0x1851C1970")]
	private unsafe static int* JMFEJMLJDFL(NativeArray<int> FOHKJBHGAHL)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x51C1C40", Offset = "0x51C0C40", VA = "0x1851C1C40")]
	[CompilerGenerated]
	internal static void OIGCKDOEEAP(int HAKJLFGHMFI, int BDDDCDJDMHM, ref EAHGIIDENBO P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FJAGCDBMGJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int CFBOHNDNLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int ILADHJAIGAG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NIHNBAGEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x51C5860", Offset = "0x51C4860", VA = "0x1851C5860")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42914C0", Offset = "0x42904C0", VA = "0x1842914C0")]
	public static FJAGCDBMGJI IBMLGIDJCMG(FJAGCDBMGJI INIPPOEHOLP, FJAGCDBMGJI BMEGDOGJIKK)
	{
		return default(FJAGCDBMGJI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x51C5870", Offset = "0x51C4870", VA = "0x1851C5870")]
	public static FJAGCDBMGJI NPFFEJJEGGA(FJAGCDBMGJI OIMFJAHGPGG, int HMLCAOBJHJF)
	{
		return default(FJAGCDBMGJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51C57C0", Offset = "0x51C47C0", VA = "0x1851C57C0", Slot = "0")]
	public override bool Equals(object KOBLMHGEGDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x51C5810", Offset = "0x51C4810", VA = "0x1851C5810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51C5890", Offset = "0x51C4890", VA = "0x1851C5890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OLLLKDBJDJG
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
