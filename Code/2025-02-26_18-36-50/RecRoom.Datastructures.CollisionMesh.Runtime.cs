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
		[Cpp2IlInjected.Address(RVA = "0x74231C0", Offset = "0x74225C0", VA = "0x1874231C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB600D0", Offset = "0xB5F4D0", VA = "0x180B600D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x741ED70", Offset = "0x741E170", VA = "0x18741ED70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x741EF10", Offset = "0x741E310", VA = "0x18741EF10")]
	public bool EKPMOLCPECL([In] NativeArray<float3> BNMLNEKDHCB, NativeList<float3> PJPHLIICOIJ, NativeList<int> HKAJIOBOKII, Allocator LEILKJFLDFN, CancellationToken LAEIHJHNGEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74203A0", Offset = "0x741F7A0", VA = "0x1874203A0")]
	private void HPHCPPKCEKM([In] NativeArray<float3> BNMLNEKDHCB, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7420580", Offset = "0x741F980", VA = "0x187420580")]
	private void NOHOLPDDBIA([In] NativeArray<float3> BNMLNEKDHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x741F050", Offset = "0x741E450", VA = "0x18741F050")]
	private void FICLJCJKJKL([In] NativeArray<float3> BNMLNEKDHCB, [Out] int FMMAPHHOBEF, [Out] int KOBJNMOFNFO, [Out] int KKCIOOBIGJE, [Out] int MJHCPNAFNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7421A80", Offset = "0x7420E80", VA = "0x187421A80")]
	private void PPLMOCBNAMH([In] NativeArray<float3> BNMLNEKDHCB, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74215A0", Offset = "0x74209A0", VA = "0x1874215A0")]
	private void OGNHMFLLPJM([In] NativeArray<float3> BNMLNEKDHCB, float3 ILGJMEDBDKJ, int IMIFKKCDOPM, PIKNKJDNDON MBNIPGPOELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x741F510", Offset = "0x741E910", VA = "0x18741F510")]
	private void GACGNPHAION([In] NativeArray<float3> BNMLNEKDHCB, float3 ILGJMEDBDKJ, int GEHMAFBEPGB, int FKDLNFBLNJH, PIKNKJDNDON MBNIPGPOELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x741F900", Offset = "0x741ED00", VA = "0x18741F900")]
	private void GCBBHCDAEJC([In] NativeArray<float3> BNMLNEKDHCB, int EAJLBHAJDPK, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x741FF60", Offset = "0x741F360", VA = "0x18741FF60")]
	private void HHPIIGBMEBB([In] NativeArray<float3> BNMLNEKDHCB, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x741E3D0", Offset = "0x741D7D0", VA = "0x18741E3D0")]
	private void AJKNCIMBKGG([In] NativeArray<float3> BNMLNEKDHCB, NativeList<float3> PJPHLIICOIJ, NativeList<int> HKAJIOBOKII, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x741FF00", Offset = "0x741F300", VA = "0x18741FF00")]
	private float HACBFEJHFLG(float3 ILGJMEDBDKJ, float3 PPNIDMAIMJH, PIKNKJDNDON MBNIPGPOELA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x741EBD0", Offset = "0x741DFD0", VA = "0x18741EBD0")]
	private float3 CEPDBDAPIFF(float3 APEAIFHAOFM, float3 OLMIKPCCIFF, float3 FEJLIJOHCGG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x741ED40", Offset = "0x741E140", VA = "0x18741ED40")]
	private static float DNJOKFNILHP(float3 AMGCKABOOPF, float3 PPCFCAEIJMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x741EEB0", Offset = "0x741E2B0", VA = "0x18741EEB0")]
	private static float3 EKEGLKBPEOD(float3 AMGCKABOOPF, float3 PPCFCAEIJMM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x741ECE0", Offset = "0x741E0E0", VA = "0x18741ECE0")]
	private bool CNJOEAKCNHI(float3 AMGCKABOOPF, float3 PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74202D0", Offset = "0x741F6D0", VA = "0x1874202D0")]
	private bool HJONCHJKMFP(float3 AMGCKABOOPF, float3 PPCFCAEIJMM, float3 OPLPABIPAJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x741E8B0", Offset = "0x741DCB0", VA = "0x18741E8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7421C80", Offset = "0x7421080", VA = "0x187421C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DILBJJMOMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7422430", Offset = "0x7421830", VA = "0x187422430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7422350", Offset = "0x7421750", VA = "0x187422350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DFCNFNNOIMI OLNGBIEDHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7421D50", Offset = "0x7421150", VA = "0x187421D50")]
		get
		{
			return default(DFCNFNNOIMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7422F60", Offset = "0x7422360", VA = "0x187422F60")]
	public KCONLOEGBJG(int EJENEKIJBLE, int BHEMEOKJHOM, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7423020", Offset = "0x7422420", VA = "0x187423020")]
	public KCONLOEGBJG(DFCNFNNOIMI FLNALAHAGDP, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7423050", Offset = "0x7422450", VA = "0x187423050")]
	public KCONLOEGBJG(Mesh LCGHOEMEOEK, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7422C00", Offset = "0x7422000", VA = "0x187422C00")]
	public KCONLOEGBJG(KCONLOEGBJG GIDGOODJFLJ, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7421CC0", Offset = "0x74210C0", VA = "0x187421CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7421FD0", Offset = "0x74213D0", VA = "0x187421FD0")]
	public void HBHDBABAKDP([In] KCONLOEGBJG MBDLAJMBAIN, float4x4 GLNFFLIPMPB, Transform JCKCCIGACED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7422470", Offset = "0x7421870", VA = "0x187422470")]
	public void LLCMNFDGDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74225C0", Offset = "0x74219C0", VA = "0x1874225C0")]
	public void NAMNDHPANNA(float HIAAOMCAGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7421DD0", Offset = "0x74211D0", VA = "0x187421DD0")]
	public KCONLOEGBJG GOGNPFEDNJM(Allocator LEILKJFLDFN, CancellationToken LAEIHJHNGEK)
	{
		return default(KCONLOEGBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7422AE0", Offset = "0x7421EE0", VA = "0x187422AE0")]
	public Mesh PCNJPGHJCAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7422390", Offset = "0x7421790", VA = "0x187422390")]
	private unsafe static float3* KDDDEOBEPKO(NativeArray<float3> CJFOOLJEHLK)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74223E0", Offset = "0x74217E0", VA = "0x1874223E0")]
	private unsafe static int* KDDDEOBEPKO(NativeArray<int> CJFOOLJEHLK)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7422AB0", Offset = "0x7421EB0", VA = "0x187422AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x741E260", Offset = "0x741D660", VA = "0x18741E260")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x244B580", Offset = "0x244A980", VA = "0x18244B580")]
	public static DFCNFNNOIMI FHOKCPBBLGF(DFCNFNNOIMI AMGCKABOOPF, DFCNFNNOIMI PPCFCAEIJMM)
	{
		return default(DFCNFNNOIMI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x741E310", Offset = "0x741D710", VA = "0x18741E310")]
	public static DFCNFNNOIMI KDIDDBIHBIM(DFCNFNNOIMI NEDNPDOKBDN, int EOJJAMCHAEH)
	{
		return default(DFCNFNNOIMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x741E270", Offset = "0x741D670", VA = "0x18741E270", Slot = "0")]
	public override bool Equals(object OLANAFCDCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x741E2C0", Offset = "0x741D6C0", VA = "0x18741E2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x741E330", Offset = "0x741D730", VA = "0x18741E330", Slot = "3")]
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
