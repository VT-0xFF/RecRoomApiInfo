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
public struct BOMEDNALEBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct CLPBALONHDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int NHMKBMOAACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int OLPKPODKODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int MHNBHCGLBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int FHAEGEDPLFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int OFODCJEAHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int ALFELFMAODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 JGPHLFJNKJL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8AC0", Offset = "0x5FE74C0", VA = "0x185FE8AC0")]
		public CLPBALONHDA(int BFDFNNAGLEP, int KLABEJNNPCE, int IFJPFILEALF, int JJMGKDGHNKI, int AKNKLIMOLJL, int MBMEEDFKPPP, float3 FOAJMMCBCNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct OIHBDHODLEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int IPBNOFEBJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int APKIKEJMFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float GJKENOAOJKL;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x185D5A0", Offset = "0x185BFA0", VA = "0x18185D5A0")]
		public OIHBDHODLEC(int JEHKGNEAMEK, int DDANOCEMCFE, float GJJCEGJKENH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct OEBOGLIOLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int APKIKEJMFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int GKCOMFEBPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int CNEOLAIIKNK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, CLPBALONHDA> JPBPBDLIKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<OIHBDHODLEC> CCEBECKPLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> ALLBMAJCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<OEBOGLIOLME> FHPJDGIFFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> EJHDFPFKEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int PDBJIEMFOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int AELNPFHIPOE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5990", Offset = "0x5FE4390", VA = "0x185FE5990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7D20", Offset = "0x5FE6720", VA = "0x185FE7D20")]
	public bool MNOEBMBGJFK(in NativeArray<float3> PPFKLDLPECN, ref NativeList<float3> IOPLFLGAFHN, ref NativeList<int> BBEAMCNAAON, Allocator FAMNMGKAFPB, CancellationToken OGOJJPCADFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5E90", Offset = "0x5FE4890", VA = "0x185FE5E90")]
	private void GICNDCMAEJH(in NativeArray<float3> PPFKLDLPECN, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6C20", Offset = "0x5FE5620", VA = "0x185FE6C20")]
	private void KHLPDCOLKAJ(in NativeArray<float3> PPFKLDLPECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6400", Offset = "0x5FE4E00", VA = "0x185FE6400")]
	private void HPOAPHELEOJ(in NativeArray<float3> PPFKLDLPECN, out int DCKOFGGJACK, out int BNDIFDCPKBE, out int KINFFDIEAHA, out int PIBPLAEKLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FE88D0", Offset = "0x5FE72D0", VA = "0x185FE88D0")]
	private void PJEHJHHIKED(in NativeArray<float3> PPFKLDLPECN, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8380", Offset = "0x5FE6D80", VA = "0x185FE8380")]
	private void ODCKABAJCGB(in NativeArray<float3> PPFKLDLPECN, float3 OLLEMKHHKDM, int NKLCIDDEDJE, CLPBALONHDA LHIBDDFEGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6830", Offset = "0x5FE5230", VA = "0x185FE6830")]
	private void KBAFHEEFEEJ(in NativeArray<float3> PPFKLDLPECN, float3 OLLEMKHHKDM, int ANCAMPDFFFN, int AELNPFHIPOE, CLPBALONHDA LHIBDDFEGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7E00", Offset = "0x5FE6800", VA = "0x185FE7E00")]
	private void NCHGJJDJHHJ(in NativeArray<float3> PPFKLDLPECN, int APODGFJKFHF, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6080", Offset = "0x5FE4A80", VA = "0x185FE6080")]
	private void HFELFAMJHNC(in NativeArray<float3> PPFKLDLPECN, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE55A0", Offset = "0x5FE3FA0", VA = "0x185FE55A0")]
	private void CJAFMEPHADI(in NativeArray<float3> PPFKLDLPECN, ref NativeList<float3> IOPLFLGAFHN, ref NativeList<int> BBEAMCNAAON, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE67B0", Offset = "0x5FE51B0", VA = "0x185FE67B0")]
	private float JMHNJFJIHDC(float3 OLLEMKHHKDM, float3 AOPOGEJLCLF, CLPBALONHDA LHIBDDFEGJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5430", Offset = "0x5FE3E30", VA = "0x185FE5430")]
	private float3 JGPHLFJNKJL(float3 BFDFNNAGLEP, float3 KLABEJNNPCE, float3 IFJPFILEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x59433D0", Offset = "0x5941DD0", VA = "0x1859433D0")]
	private static float KABJMKIDOCE(float3 LDIEPFCHCFG, float3 KCHCODPDAGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6000", Offset = "0x5FE4A00", VA = "0x185FE6000")]
	private static float3 GKPKBBBCNNO(float3 LDIEPFCHCFG, float3 KCHCODPDAGF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5AD0", Offset = "0x5FE44D0", VA = "0x185FE5AD0")]
	private bool GFFNCONCHDK(float3 LDIEPFCHCFG, float3 KCHCODPDAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4FE0", Offset = "0x5FE39E0", VA = "0x185FE4FE0")]
	private bool AAHKIGANJJD(float3 LDIEPFCHCFG, float3 KCHCODPDAGF, float3 DANKALDMBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5B50", Offset = "0x5FE4550", VA = "0x185FE5B50")]
	private bool GGKFCNHKMED(float3 LDIEPFCHCFG, float3 KCHCODPDAGF, float3 DANKALDMBIP, float3 GJJCEGJKENH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MGGJLIKBFJH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CNLHLCCHGJL
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
	private NativeList<float3> FDNOPCIEOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> CPGMPFJIMHF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KJMNLILIJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FE95E0", Offset = "0x5FE7FE0", VA = "0x185FE95E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JLPOJLHGGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FE95A0", Offset = "0x5FE7FA0", VA = "0x185FE95A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8C50", Offset = "0x5FE7650", VA = "0x185FE8C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JLOHKMKOLJA NOMMIMMGDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9A60", Offset = "0x5FE8460", VA = "0x185FE9A60")]
		get
		{
			return default(JLOHKMKOLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA1D0", Offset = "0x5FE8BD0", VA = "0x185FEA1D0")]
	public MGGJLIKBFJH(int HHMBNMHFBDG, int IMLKDBLMHBF, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA280", Offset = "0x5FE8C80", VA = "0x185FEA280")]
	public MGGJLIKBFJH(JLOHKMKOLJA KDAOEEJNJGF, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9DD0", Offset = "0x5FE87D0", VA = "0x185FE9DD0")]
	public MGGJLIKBFJH(Mesh LJOHGOPFNGB, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9F70", Offset = "0x5FE8970", VA = "0x185FE9F70")]
	public MGGJLIKBFJH(MGGJLIKBFJH PJIINDGLAPJ, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8F10", Offset = "0x5FE7910", VA = "0x185FE8F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9650", Offset = "0x5FE8050", VA = "0x185FE9650")]
	public void MJIKPLNABDE(in MGGJLIKBFJH JAKENEGIGGH, float4x4 AKDPEMHOGAK, Transform LMNCNCMINKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8D30", Offset = "0x5FE7730", VA = "0x185FE8D30")]
	public void DDIPJMOLBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FE90C0", Offset = "0x5FE7AC0", VA = "0x185FE90C0")]
	public void HFMPGLDLJBF(float DDIDJKAFDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9AE0", Offset = "0x5FE84E0", VA = "0x185FE9AE0")]
	public MGGJLIKBFJH OICKBNFEGML(Allocator FAMNMGKAFPB, CancellationToken OGOJJPCADFI)
	{
		return default(MGGJLIKBFJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8FA0", Offset = "0x5FE79A0", VA = "0x185FE8FA0")]
	public Mesh FKFHDKKGBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8C90", Offset = "0x5FE7690", VA = "0x185FE8C90")]
	private unsafe static float3* CBODIJJBMJC(NativeArray<float3> EIOACKOCJCB)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8CE0", Offset = "0x5FE76E0", VA = "0x185FE8CE0")]
	private unsafe static int* CBODIJJBMJC(NativeArray<int> EIOACKOCJCB)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9620", Offset = "0x5FE8020", VA = "0x185FE9620")]
	[CompilerGenerated]
	internal static void JDLACEIBBFA(int BMLCFLJKLCC, int EHAJCBEKOAJ, ref CNLHLCCHGJL P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JLOHKMKOLJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int KJMNLILIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JLPOJLHGGFC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ELEFFENBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8BA0", Offset = "0x5FE75A0", VA = "0x185FE8BA0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5325500", Offset = "0x5323F00", VA = "0x185325500")]
	public static JLOHKMKOLJA HFHDNGEDPOA(JLOHKMKOLJA LDIEPFCHCFG, JLOHKMKOLJA KCHCODPDAGF)
	{
		return default(JLOHKMKOLJA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8B80", Offset = "0x5FE7580", VA = "0x185FE8B80")]
	public static JLOHKMKOLJA HFJNKCOBNJM(JLOHKMKOLJA OIFCJGBGOGB, int JMEPHEBPBHC)
	{
		return default(JLOHKMKOLJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8B00", Offset = "0x5FE7500", VA = "0x185FE8B00", Slot = "0")]
	public override bool Equals(object DIMGLEPKFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8B40", Offset = "0x5FE7540", VA = "0x185FE8B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8BB0", Offset = "0x5FE75B0", VA = "0x185FE8BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NDAHMKJEPHA
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
