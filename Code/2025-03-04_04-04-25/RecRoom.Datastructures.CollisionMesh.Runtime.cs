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
public struct INBJILPLODB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct PIKNKJDNDON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int PJCCOFFGPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int NBFMCFCEPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int GKMODMIEOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int NJDJMCCCIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int HPJOIOMPBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int PIIJNLOLGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 CEPDBDAPIFF;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74C1480", Offset = "0x74BFA80", VA = "0x1874C1480")]
		public PIKNKJDNDON(int APEAIFHAOFM, int OLMIKPCCIFF, int FEJLIJOHCGG, int EPGLMICKEHI, int HAGEDMGPKMG, int POAAACNCLLF, float3 FGKLFPNFOKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct OFGEOMPIOOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int JBFGPKNBLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int AOCBABGCAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float OJFJGLIBDIN;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB66390", Offset = "0xB64990", VA = "0x180B66390")]
		public OFGEOMPIOOO(int FCEAHINHNGO, int EOONBMFFCPK, float CAADECGPKHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct OCPAPKGFKBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int AOCBABGCAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int HBGPFPNKFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int HBDFICLAALD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, PIKNKJDNDON> OPCNIMNPMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<OFGEOMPIOOO> OJBGBGJHFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> OJAHPAPKAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<OCPAPKGFKBJ> EJPCMKCNCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> EGCMIOAMELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int DNHJJKOFCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int FKDLNFBLNJH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x74BD030", Offset = "0x74BB630", VA = "0x1874BD030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74BD1D0", Offset = "0x74BB7D0", VA = "0x1874BD1D0")]
	public bool EKPMOLCPECL([In] NativeArray<float3> BNMLNEKDHCB, NativeList<float3> PJPHLIICOIJ, NativeList<int> HKAJIOBOKII, Allocator LEILKJFLDFN, CancellationToken LAEIHJHNGEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74BE660", Offset = "0x74BCC60", VA = "0x1874BE660")]
	private void HPHCPPKCEKM([In] NativeArray<float3> BNMLNEKDHCB, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74BE840", Offset = "0x74BCE40", VA = "0x1874BE840")]
	private void NOHOLPDDBIA([In] NativeArray<float3> BNMLNEKDHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74BD310", Offset = "0x74BB910", VA = "0x1874BD310")]
	private void FICLJCJKJKL([In] NativeArray<float3> BNMLNEKDHCB, [Out] int FMMAPHHOBEF, [Out] int KOBJNMOFNFO, [Out] int KKCIOOBIGJE, [Out] int MJHCPNAFNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74BFD40", Offset = "0x74BE340", VA = "0x1874BFD40")]
	private void PPLMOCBNAMH([In] NativeArray<float3> BNMLNEKDHCB, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74BF860", Offset = "0x74BDE60", VA = "0x1874BF860")]
	private void OGNHMFLLPJM([In] NativeArray<float3> BNMLNEKDHCB, float3 ILGJMEDBDKJ, int IMIFKKCDOPM, PIKNKJDNDON MBNIPGPOELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74BD7D0", Offset = "0x74BBDD0", VA = "0x1874BD7D0")]
	private void GACGNPHAION([In] NativeArray<float3> BNMLNEKDHCB, float3 ILGJMEDBDKJ, int GEHMAFBEPGB, int FKDLNFBLNJH, PIKNKJDNDON MBNIPGPOELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74BDBC0", Offset = "0x74BC1C0", VA = "0x1874BDBC0")]
	private void GCBBHCDAEJC([In] NativeArray<float3> BNMLNEKDHCB, int EAJLBHAJDPK, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74BE220", Offset = "0x74BC820", VA = "0x1874BE220")]
	private void HHPIIGBMEBB([In] NativeArray<float3> BNMLNEKDHCB, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74BC690", Offset = "0x74BAC90", VA = "0x1874BC690")]
	private void AJKNCIMBKGG([In] NativeArray<float3> BNMLNEKDHCB, NativeList<float3> PJPHLIICOIJ, NativeList<int> HKAJIOBOKII, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74BE1C0", Offset = "0x74BC7C0", VA = "0x1874BE1C0")]
	private float HACBFEJHFLG(float3 ILGJMEDBDKJ, float3 PPNIDMAIMJH, PIKNKJDNDON MBNIPGPOELA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74BCE90", Offset = "0x74BB490", VA = "0x1874BCE90")]
	private float3 CEPDBDAPIFF(float3 APEAIFHAOFM, float3 OLMIKPCCIFF, float3 FEJLIJOHCGG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74BD000", Offset = "0x74BB600", VA = "0x1874BD000")]
	private static float DNJOKFNILHP(float3 AMGCKABOOPF, float3 PPCFCAEIJMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74BD170", Offset = "0x74BB770", VA = "0x1874BD170")]
	private static float3 EKEGLKBPEOD(float3 AMGCKABOOPF, float3 PPCFCAEIJMM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74BCFA0", Offset = "0x74BB5A0", VA = "0x1874BCFA0")]
	private bool CNJOEAKCNHI(float3 AMGCKABOOPF, float3 PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74BE590", Offset = "0x74BCB90", VA = "0x1874BE590")]
	private bool HJONCHJKMFP(float3 AMGCKABOOPF, float3 PPCFCAEIJMM, float3 OPLPABIPAJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74BCB70", Offset = "0x74BB170", VA = "0x1874BCB70")]
	private bool BEAIFBLOAKC(float3 AMGCKABOOPF, float3 PPCFCAEIJMM, float3 OPLPABIPAJI, float3 CAADECGPKHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KCONLOEGBJG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct IDPCPMCCFDP
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
	private NativeList<float3> OMPCIFEFKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> EPLKJIAFONN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DHJENKIBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74BFF40", Offset = "0x74BE540", VA = "0x1874BFF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DILBJJMOMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74C06F0", Offset = "0x74BECF0", VA = "0x1874C06F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74C0610", Offset = "0x74BEC10", VA = "0x1874C0610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DFCNFNNOIMI OLNGBIEDHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74C0010", Offset = "0x74BE610", VA = "0x1874C0010")]
		get
		{
			return default(DFCNFNNOIMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74C1220", Offset = "0x74BF820", VA = "0x1874C1220")]
	public KCONLOEGBJG(int EJENEKIJBLE, int BHEMEOKJHOM, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74C12E0", Offset = "0x74BF8E0", VA = "0x1874C12E0")]
	public KCONLOEGBJG(DFCNFNNOIMI FLNALAHAGDP, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74C1310", Offset = "0x74BF910", VA = "0x1874C1310")]
	public KCONLOEGBJG(Mesh LCGHOEMEOEK, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74C0EC0", Offset = "0x74BF4C0", VA = "0x1874C0EC0")]
	public KCONLOEGBJG(KCONLOEGBJG GIDGOODJFLJ, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74BFF80", Offset = "0x74BE580", VA = "0x1874BFF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74C0290", Offset = "0x74BE890", VA = "0x1874C0290")]
	public void HBHDBABAKDP([In] KCONLOEGBJG MBDLAJMBAIN, float4x4 GLNFFLIPMPB, Transform JCKCCIGACED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74C0730", Offset = "0x74BED30", VA = "0x1874C0730")]
	public void LLCMNFDGDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74C0880", Offset = "0x74BEE80", VA = "0x1874C0880")]
	public void NAMNDHPANNA(float HIAAOMCAGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74C0090", Offset = "0x74BE690", VA = "0x1874C0090")]
	public KCONLOEGBJG GOGNPFEDNJM(Allocator LEILKJFLDFN, CancellationToken LAEIHJHNGEK)
	{
		return default(KCONLOEGBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74C0DA0", Offset = "0x74BF3A0", VA = "0x1874C0DA0")]
	public Mesh PCNJPGHJCAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74C0650", Offset = "0x74BEC50", VA = "0x1874C0650")]
	private unsafe static float3* KDDDEOBEPKO(NativeArray<float3> CJFOOLJEHLK)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74C06A0", Offset = "0x74BECA0", VA = "0x1874C06A0")]
	private unsafe static int* KDDDEOBEPKO(NativeArray<int> CJFOOLJEHLK)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74C0D70", Offset = "0x74BF370", VA = "0x1874C0D70")]
	[CompilerGenerated]
	internal static void OGJGAPPMONO(int MBGGPHILDPB, int NMGAEEJOGCA, IDPCPMCCFDP P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct DFCNFNNOIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int DHJENKIBIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int DILBJJMOMGG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NNKNOENKLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74BC520", Offset = "0x74BAB20", VA = "0x1874BC520")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x247E300", Offset = "0x247C900", VA = "0x18247E300")]
	public static DFCNFNNOIMI FHOKCPBBLGF(DFCNFNNOIMI AMGCKABOOPF, DFCNFNNOIMI PPCFCAEIJMM)
	{
		return default(DFCNFNNOIMI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74BC5D0", Offset = "0x74BABD0", VA = "0x1874BC5D0")]
	public static DFCNFNNOIMI KDIDDBIHBIM(DFCNFNNOIMI NEDNPDOKBDN, int EOJJAMCHAEH)
	{
		return default(DFCNFNNOIMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74BC530", Offset = "0x74BAB30", VA = "0x1874BC530", Slot = "0")]
	public override bool Equals(object OLANAFCDCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74BC580", Offset = "0x74BAB80", VA = "0x1874BC580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74BC5F0", Offset = "0x74BABF0", VA = "0x1874BC5F0", Slot = "3")]
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
