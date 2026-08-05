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
public struct GANBFKPNIMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct GJHLGNOAHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int JAHIGJJDOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int AICJJPHDFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int GMMCOGJMMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int CKGLECMIABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int KILBDEGMLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int PEGDMFNCBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 PCOFPIMFJLC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5C9E220", Offset = "0x5C9D620", VA = "0x185C9E220")]
		public GJHLGNOAHBJ(int LNKPLKCJAAF, int CDPLKIFCGIE, int JNGJHFAJAPD, int AANFEBGHJIK, int IBMPLLJBGLC, int MDECONHAGFO, float3 DDEDMKGDKMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct NFDCDIFKHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int EDHOIAAEBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int PPIIHDNEJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float CAKDDCGKDGE;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE61C40", Offset = "0xE61040", VA = "0x180E61C40")]
		public NFDCDIFKHIK(int HGOEIFPLBFO, int AKGCOEOHLAC, float NHFCBHANLPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct IOJABJKBJFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int PPIIHDNEJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int DGCPDPACDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int HOCPNFLKENG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, GJHLGNOAHBJ> NKBDGGDANML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<NFDCDIFKHIK> GBDLHDLNPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> AFMFEOHFNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<IOJABJKBJFM> DNHMJMDMBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> NMDBEAGMAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int BJMBDNHHELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int JLIOLLKIAHG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C9AFC0", Offset = "0x5C9A3C0", VA = "0x185C9AFC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C9A8F0", Offset = "0x5C99CF0", VA = "0x185C9A8F0")]
	public bool CMMDANEOCDD([In] NativeArray<float3> PGBLLPKGDNO, NativeList<float3> CLFDIPCDIKC, NativeList<int> FDAPJIJNFKC, Allocator JIIMEDFKEME, CancellationToken OMFABMCIOAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DDC0", Offset = "0x5C9D1C0", VA = "0x185C9DDC0")]
	private void OMELHDOHHCI([In] NativeArray<float3> PGBLLPKGDNO, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C0C0", Offset = "0x5C9B4C0", VA = "0x185C9C0C0")]
	private void GCDKGPCCGGJ([In] NativeArray<float3> PGBLLPKGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D900", Offset = "0x5C9CD00", VA = "0x185C9D900")]
	private void NHDAGALPJAA([In] NativeArray<float3> PGBLLPKGDNO, [Out] int DNJLFIIOFAA, [Out] int IDOGLFEHHIC, [Out] int CHEFNLFKKKG, [Out] int JODKEGNMHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BEC0", Offset = "0x5C9B2C0", VA = "0x185C9BEC0")]
	private void FNMDIMNCIAI([In] NativeArray<float3> PGBLLPKGDNO, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C9AA30", Offset = "0x5C99E30", VA = "0x185C9AA30")]
	private void DGFJJPGOEPO([In] NativeArray<float3> PGBLLPKGDNO, float3 NODMEHJAHII, int AMKHFBIAMNG, GJHLGNOAHBJ KBGHOEEAOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D4D0", Offset = "0x5C9C8D0", VA = "0x185C9D4D0")]
	private void MKEEGEBNIIO([In] NativeArray<float3> PGBLLPKGDNO, float3 NODMEHJAHII, int GDHJLNOKHAC, int JLIOLLKIAHG, GJHLGNOAHBJ KBGHOEEAOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C9B100", Offset = "0x5C9A500", VA = "0x185C9B100")]
	private void EBJIHAACPMF([In] NativeArray<float3> PGBLLPKGDNO, int CAFFAHJHGFF, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D0D0", Offset = "0x5C9C4D0", VA = "0x185C9D0D0")]
	private void HAKIBIJKBJP([In] NativeArray<float3> PGBLLPKGDNO, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C9B9F0", Offset = "0x5C9ADF0", VA = "0x185C9B9F0")]
	private void FKPGJOGFKFE([In] NativeArray<float3> PGBLLPKGDNO, NativeList<float3> CLFDIPCDIKC, NativeList<int> FDAPJIJNFKC, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D440", Offset = "0x5C9C840", VA = "0x185C9D440")]
	private float KGEFJEDHFLH(float3 NODMEHJAHII, float3 FDJOKDEFIOM, GJHLGNOAHBJ KBGHOEEAOED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DFA0", Offset = "0x5C9D3A0", VA = "0x185C9DFA0")]
	private float3 PCOFPIMFJLC(float3 LNKPLKCJAAF, float3 CDPLKIFCGIE, float3 JNGJHFAJAPD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D4A0", Offset = "0x5C9C8A0", VA = "0x185C9D4A0")]
	private static float MDIFBFEAEPN(float3 BOGGCLFEFDJ, float3 OGHJEHJOFGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C9AE90", Offset = "0x5C9A290", VA = "0x185C9AE90")]
	private static float3 DGIDOHDLCGN(float3 BOGGCLFEFDJ, float3 OGHJEHJOFGN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D8A0", Offset = "0x5C9CCA0", VA = "0x185C9D8A0")]
	private bool NDONGPNKAIF(float3 BOGGCLFEFDJ, float3 OGHJEHJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C9AEF0", Offset = "0x5C9A2F0", VA = "0x185C9AEF0")]
	private bool DHIPJPBMDLK(float3 BOGGCLFEFDJ, float3 OGHJEHJOFGN, float3 EEFMDFBJECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C9B700", Offset = "0x5C9AB00", VA = "0x185C9B700")]
	private bool EEEHCHCJOCG(float3 BOGGCLFEFDJ, float3 OGHJEHJOFGN, float3 EEFMDFBJECO, float3 NHFCBHANLPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JHHLFKDAPGO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BIIKLNPGCIA
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
	private NativeList<float3> NBODMDGPJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> DKKLFAGEFFK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int POLGGJALALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5C9F160", Offset = "0x5C9E560", VA = "0x185C9F160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HNJDPPFFOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C9F1A0", Offset = "0x5C9E5A0", VA = "0x185C9F1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PJPBOLEMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C9EEA0", Offset = "0x5C9E2A0", VA = "0x185C9EEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GGFOCOJEFDD BMNHNJJPJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5C9EEE0", Offset = "0x5C9E2E0", VA = "0x185C9EEE0")]
		get
		{
			return default(GGFOCOJEFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C9F540", Offset = "0x5C9E940", VA = "0x185C9F540")]
	public JHHLFKDAPGO(int ILFDMDPFNKA, int HNOAEBMNBGJ, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C9F770", Offset = "0x5C9EB70", VA = "0x185C9F770")]
	public JHHLFKDAPGO(GGFOCOJEFDD PBBALNNLAAD, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C9F600", Offset = "0x5C9EA00", VA = "0x185C9F600")]
	public JHHLFKDAPGO(Mesh PFHPDAMABCN, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C9F1E0", Offset = "0x5C9E5E0", VA = "0x185C9F1E0")]
	public JHHLFKDAPGO(JHHLFKDAPGO OOIBMCBCEPD, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E910", Offset = "0x5C9DD10", VA = "0x185C9E910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C9EB20", Offset = "0x5C9DF20", VA = "0x185C9EB20")]
	public void GIHKKMKIIOJ([In] JHHLFKDAPGO OFAFLOECBGM, float4x4 BFDECFAPKAM, Transform CKIEOJHNAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E9A0", Offset = "0x5C9DDA0", VA = "0x185C9E9A0")]
	public void EHDHMIGKMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E420", Offset = "0x5C9D820", VA = "0x185C9E420")]
	public void DBPLCOBOKCA(float FECAAKMJJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C9EF60", Offset = "0x5C9E360", VA = "0x185C9EF60")]
	public JHHLFKDAPGO ICHDHMDAPCP(Allocator JIIMEDFKEME, CancellationToken OMFABMCIOAC)
	{
		return default(JHHLFKDAPGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E300", Offset = "0x5C9D700", VA = "0x185C9E300")]
	public Mesh CNHCHDNBPDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E2B0", Offset = "0x5C9D6B0", VA = "0x185C9E2B0")]
	private unsafe static float3* BLMJGLDHBCF(NativeArray<float3> FOAJABBKLPB)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E260", Offset = "0x5C9D660", VA = "0x185C9E260")]
	private unsafe static int* BLMJGLDHBCF(NativeArray<int> FOAJABBKLPB)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C9EAF0", Offset = "0x5C9DEF0", VA = "0x185C9EAF0")]
	[CompilerGenerated]
	internal static void EHNFFIEOCHL(int KHDFENNBNCP, int JBIJDBCCPEK, BIIKLNPGCIA P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GGFOCOJEFDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int POLGGJALALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int HNJDPPFFOOK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EIIBPKGIONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C9E0B0", Offset = "0x5C9D4B0", VA = "0x185C9E0B0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B4DAE0", Offset = "0x1B4CEE0", VA = "0x181B4DAE0")]
	public static GGFOCOJEFDD LIGONOCHFCL(GGFOCOJEFDD BOGGCLFEFDJ, GGFOCOJEFDD OGHJEHJOFGN)
	{
		return default(GGFOCOJEFDD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E0C0", Offset = "0x5C9D4C0", VA = "0x185C9E0C0")]
	public static GGFOCOJEFDD DIEJCLKIEGD(GGFOCOJEFDD GPMBDODCIFN, int AJKNMOMPICG)
	{
		return default(GGFOCOJEFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E0E0", Offset = "0x5C9D4E0", VA = "0x185C9E0E0", Slot = "0")]
	public override bool Equals(object GCLOPEKDKCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E130", Offset = "0x5C9D530", VA = "0x185C9E130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E180", Offset = "0x5C9D580", VA = "0x185C9E180", Slot = "3")]
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
