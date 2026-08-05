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
public struct IFKDLLIHFAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct PDNGHHGEHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int ABEECFKNFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int OGIBFEGHEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int PLKONHJPMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int LCGPJNMBGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int BKLBDFGBIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int EKGFDNKDGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 HEEFGJFKPPG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71E2AB0", Offset = "0x71E1CB0", VA = "0x1871E2AB0")]
		public PDNGHHGEHPM(int OJJHPIHPCEK, int JDECIDMPPAB, int PKIKAKKOBFB, int ELHMMEGNLKO, int PKPJEBPHIBI, int OAHGBHELGLA, float3 LAOLFCMCDHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct HFFIFNEHCOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int GHDHCANJBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int NBOFAKNGHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float GHBHFHPIBIA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB3FEB0", Offset = "0xB3F0B0", VA = "0x180B3FEB0")]
		public HFFIFNEHCOK(int GBPBPMJPBKO, int MOIIPGPIBJH, float MKPCDIHBHGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct BMCCFGOBJBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int NBOFAKNGHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int OLHCJFFCAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int GCPOAEECKEK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, PDNGHHGEHPM> AGBFHJFAHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<HFFIFNEHCOK> ENLHIEDFILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> EJILDPJNBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<BMCCFGOBJBD> KCIOGFBPBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> PMJKEAEIIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int NJDLFEFEFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int KLHFPADEAKB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71DFD00", Offset = "0x71DEF00", VA = "0x1871DFD00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71E2970", Offset = "0x71E1B70", VA = "0x1871E2970")]
	public bool PKDFJLGGDKO([In] NativeArray<float3> NKGBJFHDGLO, NativeList<float3> LKCAPANOMPA, NativeList<int> OCINKDDHGEM, Allocator NNHCNMKJHLF, CancellationToken BGEKICMONBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x71DFE40", Offset = "0x71DF040", VA = "0x1871DFE40")]
	private void GGPOBANFNOP([In] NativeArray<float3> NKGBJFHDGLO, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x71E0AB0", Offset = "0x71DFCB0", VA = "0x1871E0AB0")]
	private void JOMCPNNNJAF([In] NativeArray<float3> NKGBJFHDGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71DF640", Offset = "0x71DE840", VA = "0x1871DF640")]
	private void BPPGHEFMOBB([In] NativeArray<float3> NKGBJFHDGLO, [Out] int POALGKPHFLG, [Out] int CPJGKHEPFKK, [Out] int HOIOIACFDCC, [Out] int CPJEKIBEDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x71DFB00", Offset = "0x71DED00", VA = "0x1871DFB00")]
	private void DCPDOMMAILL([In] NativeArray<float3> NKGBJFHDGLO, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71E2040", Offset = "0x71E1240", VA = "0x1871E2040")]
	private void NNJGMDEBLKM([In] NativeArray<float3> NKGBJFHDGLO, float3 NGCBFLBKHCA, int JFOOPDEKCOA, PDNGHHGEHPM MIEHNNGHNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x71E2520", Offset = "0x71E1720", VA = "0x1871E2520")]
	private void OEBEMKPKEBI([In] NativeArray<float3> NKGBJFHDGLO, float3 NGCBFLBKHCA, int IDDJLEDDEJD, int KLHFPADEAKB, PDNGHHGEHPM MIEHNNGHNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x71E0190", Offset = "0x71DF390", VA = "0x1871E0190")]
	private void JAHEPGPHDIL([In] NativeArray<float3> NKGBJFHDGLO, int IOFCCNECABL, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71DF200", Offset = "0x71DE400", VA = "0x1871DF200")]
	private void AAAHPILACLH([In] NativeArray<float3> NKGBJFHDGLO, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71E1B60", Offset = "0x71E0D60", VA = "0x1871E1B60")]
	private void MLAGNFDPLFH([In] NativeArray<float3> NKGBJFHDGLO, NativeList<float3> LKCAPANOMPA, NativeList<int> OCINKDDHGEM, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71E1B00", Offset = "0x71E0D00", VA = "0x1871E1B00")]
	private float LGDLKKIPLCL(float3 NGCBFLBKHCA, float3 HOOENOCOGJG, PDNGHHGEHPM MIEHNNGHNIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x71E0080", Offset = "0x71DF280", VA = "0x1871E0080")]
	private float3 HEEFGJFKPPG(float3 OJJHPIHPCEK, float3 JDECIDMPPAB, float3 PKIKAKKOBFB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x71E1AD0", Offset = "0x71E0CD0", VA = "0x1871E1AD0")]
	private static float KOPDLIOJGPJ(float3 KKLLOEEDINO, float3 NHCGDJCFKIC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x71E2910", Offset = "0x71E1B10", VA = "0x1871E2910")]
	private static float3 PAFAGIEDAJI(float3 KKLLOEEDINO, float3 NHCGDJCFKIC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x71E0020", Offset = "0x71DF220", VA = "0x1871E0020")]
	private bool GPOBKFCEEOF(float3 KKLLOEEDINO, float3 NHCGDJCFKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x71DF570", Offset = "0x71DE770", VA = "0x1871DF570")]
	private bool BGFIIPDGOLG(float3 KKLLOEEDINO, float3 NHCGDJCFKIC, float3 FDEJAKKFLHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71E0790", Offset = "0x71DF990", VA = "0x1871E0790")]
	private bool JIMNBFHDGBI(float3 KKLLOEEDINO, float3 NHCGDJCFKIC, float3 FDEJAKKFLHE, float3 MKPCDIHBHGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BLAADOMLHLJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DNOGCNGCFMO
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
	private NativeList<float3> IBEDFJCHBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> EKAMDBEHCPO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JGGAFOOFKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71DE150", Offset = "0x71DD350", VA = "0x1871DE150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FBEPFNIBOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71DEA90", Offset = "0x71DDC90", VA = "0x1871DEA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GJCMKJAFLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71DE680", Offset = "0x71DD880", VA = "0x1871DE680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HIHHKGEJINP HICNLKFLECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71DDB50", Offset = "0x71DCD50", VA = "0x1871DDB50")]
		get
		{
			return default(HIHHKGEJINP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x71DEC70", Offset = "0x71DDE70", VA = "0x1871DEC70")]
	public BLAADOMLHLJ(int HHOBCJPHCLK, int GPNDHDAGKOH, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x71DEC40", Offset = "0x71DDE40", VA = "0x1871DEC40")]
	public BLAADOMLHLJ(HIHHKGEJINP ANOJOEKHMDK, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71DEAD0", Offset = "0x71DDCD0", VA = "0x1871DEAD0")]
	public BLAADOMLHLJ(Mesh NNPLONBDKAB, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x71DED30", Offset = "0x71DDF30", VA = "0x1871DED30")]
	public BLAADOMLHLJ(BLAADOMLHLJ LFDKFEEPNFP, Allocator NNHCNMKJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x71DE6F0", Offset = "0x71DD8F0", VA = "0x1871DE6F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x71DDDD0", Offset = "0x71DCFD0", VA = "0x1871DDDD0")]
	public void CKLHJOINNOK([In] BLAADOMLHLJ PDEGCFKDOBB, float4x4 HGDBCCODBIA, Transform JMKDNMDBFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x71DE780", Offset = "0x71DD980", VA = "0x1871DE780")]
	public void EACGDGABNIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x71DE190", Offset = "0x71DD390", VA = "0x1871DE190")]
	public void DDCMBLMEMCM(float ABBGAHJHLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x71DDBD0", Offset = "0x71DCDD0", VA = "0x1871DDBD0")]
	public BLAADOMLHLJ CAKFFCAJLNH(Allocator NNHCNMKJHLF, CancellationToken BGEKICMONBE)
	{
		return default(BLAADOMLHLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x71DE8D0", Offset = "0x71DDAD0", VA = "0x1871DE8D0")]
	public Mesh EFAHIMABHMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x71DEA40", Offset = "0x71DDC40", VA = "0x1871DEA40")]
	private unsafe static float3* JKCHCFFIIPE(NativeArray<float3> HCOCCGHLKNN)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x71DE9F0", Offset = "0x71DDBF0", VA = "0x1871DE9F0")]
	private unsafe static int* JKCHCFFIIPE(NativeArray<int> HCOCCGHLKNN)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x71DE6C0", Offset = "0x71DD8C0", VA = "0x1871DE6C0")]
	[CompilerGenerated]
	internal static void DJHKLNLMOED(int PPJBHGDGDHM, int OKCJJLOLBFB, DNOGCNGCFMO P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HIHHKGEJINP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int JGGAFOOFKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int FBEPFNIBOCD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JDFOOJIHNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71DF100", Offset = "0x71DE300", VA = "0x1871DF100")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x240AEF0", Offset = "0x240A0F0", VA = "0x18240AEF0")]
	public static HIHHKGEJINP OBLDLBNGOBN(HIHHKGEJINP KKLLOEEDINO, HIHHKGEJINP NHCGDJCFKIC)
	{
		return default(HIHHKGEJINP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71DF0E0", Offset = "0x71DE2E0", VA = "0x1871DF0E0")]
	public static HIHHKGEJINP FDDHJGNJPGD(HIHHKGEJINP PCECHGENOCI, int FOENIOOLJIF)
	{
		return default(HIHHKGEJINP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x71DF090", Offset = "0x71DE290", VA = "0x1871DF090", Slot = "0")]
	public override bool Equals(object DHBLHFPFLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x71DF110", Offset = "0x71DE310", VA = "0x1871DF110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x71DF160", Offset = "0x71DE360", VA = "0x1871DF160", Slot = "3")]
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
