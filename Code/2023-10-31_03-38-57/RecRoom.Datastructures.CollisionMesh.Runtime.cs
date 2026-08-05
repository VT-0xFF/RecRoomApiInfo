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
public struct CGMAGKEPCDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct JJAJHFPHEHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int DFMMPHKCIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int KBGCNCCOPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int KHHKCCDEALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int AJCCFMKHKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int MJBNOLILLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int NLIOGBMPGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 NFCBNHOGKDC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5C497D0", Offset = "0x5C48BD0", VA = "0x185C497D0")]
		public JJAJHFPHEHK(int GGBMOKIDGOC, int MDBIGLHHPDB, int KAPDKOMNLEG, int NKCPFFFDPHB, int AELNGOEFNPI, int JAMLJCFHGEL, float3 MBCOBAGMLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct PLNGNGDKKGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int OCEHBEANAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int IBOCMJOBAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float EABMIMOPGCH;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE98280", Offset = "0xE97680", VA = "0x180E98280")]
		public PLNGNGDKKGK(int DCHCBCCCIIP, int JKHIFGJJLLD, float EGKDMEOOPIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JONCFFFLNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int IBOCMJOBAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int PFCPCALIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int HJDDBCPPBBM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, JJAJHFPHEHK> PMLLJMACDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<PLNGNGDKKGK> BDOGPMNIIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> FCPHEGLJOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<JONCFFFLNAL> JIGLBAMAPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> DEOJIPEGHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int OKBHONMABPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int LHPFHKNOAPI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C46690", Offset = "0x5C45A90", VA = "0x185C46690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C46D20", Offset = "0x5C46120", VA = "0x185C46D20")]
	public bool FILNHDGMNFM([In] NativeArray<float3> BAKFOGDFOFO, NativeList<float3> PJKOGLNFPJD, NativeList<int> PIHPAKAJMHN, Allocator KIKFOGPECEC, CancellationToken ELGJALILGJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C46B40", Offset = "0x5C45F40", VA = "0x185C46B40")]
	private void FGBNJEBGKMH([In] NativeArray<float3> BAKFOGDFOFO, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5C46EF0", Offset = "0x5C462F0", VA = "0x185C46EF0")]
	private void HMKGECEAHJB([In] NativeArray<float3> BAKFOGDFOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C47F00", Offset = "0x5C47300", VA = "0x185C47F00")]
	private void IBBBFBKJPBH([In] NativeArray<float3> BAKFOGDFOFO, [Out] int IGHOMANGJIJ, [Out] int PIHEBIFBOCO, [Out] int MCBALJJOPCA, [Out] int MALAKENOPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C46490", Offset = "0x5C45890", VA = "0x185C46490")]
	private void DFDOCENMCDG([In] NativeArray<float3> BAKFOGDFOFO, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C49370", Offset = "0x5C48770", VA = "0x185C49370")]
	private void NLKPKNODCIE([In] NativeArray<float3> BAKFOGDFOFO, float3 GKDNLKGKKGN, int PCDACGFJEFH, JJAJHFPHEHK JPAKMPNIAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5C48890", Offset = "0x5C47C90", VA = "0x185C48890")]
	private void MFOHAOFAOPO([In] NativeArray<float3> BAKFOGDFOFO, float3 GKDNLKGKKGN, int JMGOCINMMOK, int LHPFHKNOAPI, JJAJHFPHEHK JPAKMPNIAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C48C60", Offset = "0x5C48060", VA = "0x185C48C60")]
	private void MOCAFPIIDBP([In] NativeArray<float3> BAKFOGDFOFO, int BJIGFFDNBPJ, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C467D0", Offset = "0x5C45BD0", VA = "0x185C467D0")]
	private void EAOMOEIKHJC([In] NativeArray<float3> BAKFOGDFOFO, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C483C0", Offset = "0x5C477C0", VA = "0x185C483C0")]
	private void MFDKIHFEMGN([In] NativeArray<float3> BAKFOGDFOFO, NativeList<float3> PJKOGLNFPJD, NativeList<int> PIHPAKAJMHN, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C46430", Offset = "0x5C45830", VA = "0x185C46430")]
	private float DAGPNLDEHLN(float3 GKDNLKGKKGN, float3 LFGHOLKCIHK, JJAJHFPHEHK JPAKMPNIAGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C49260", Offset = "0x5C48660", VA = "0x185C49260")]
	private float3 NFCBNHOGKDC(float3 GGBMOKIDGOC, float3 MDBIGLHHPDB, float3 KAPDKOMNLEG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C46EC0", Offset = "0x5C462C0", VA = "0x185C46EC0")]
	private static float HGCENBBKJFC(float3 IFAOGMEBPFN, float3 DNPBOPMFFFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C46E60", Offset = "0x5C46260", VA = "0x185C46E60")]
	private static float3 HDDCMIINLNE(float3 IFAOGMEBPFN, float3 DNPBOPMFFFF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C46010", Offset = "0x5C45410", VA = "0x185C46010")]
	private bool ACDDFIGGEDK(float3 IFAOGMEBPFN, float3 DNPBOPMFFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C46360", Offset = "0x5C45760", VA = "0x185C46360")]
	private bool BLGEDMMJKAI(float3 IFAOGMEBPFN, float3 DNPBOPMFFFF, float3 AGEAOGKCCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C46070", Offset = "0x5C45470", VA = "0x185C46070")]
	private bool AMLEPAPAMGG(float3 IFAOGMEBPFN, float3 DNPBOPMFFFF, float3 AGEAOGKCCKA, float3 EGKDMEOOPIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PFGBOCEBCCG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DIPODPIOICJ
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
	private NativeList<float3> BNGAGFFHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> IIABFCMCPIO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DLKNAEBHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5C49B80", Offset = "0x5C48F80", VA = "0x185C49B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OHBANGANJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C49DA0", Offset = "0x5C491A0", VA = "0x185C49DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ONBNDEEHGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C4A7A0", Offset = "0x5C49BA0", VA = "0x185C4A7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MALKLJFPLPC BCCLHHPOFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5C4A880", Offset = "0x5C49C80", VA = "0x185C4A880")]
		get
		{
			return default(MALKLJFPLPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C4AE00", Offset = "0x5C4A200", VA = "0x185C4AE00")]
	public PFGBOCEBCCG(int FKEMHPOHBOG, int IIACCFFIKCA, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A900", Offset = "0x5C49D00", VA = "0x185C4A900")]
	public PFGBOCEBCCG(MALKLJFPLPC NJJMNGCBOBJ, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A930", Offset = "0x5C49D30", VA = "0x185C4A930")]
	public PFGBOCEBCCG(Mesh PACIGNFPLIB, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C4AAA0", Offset = "0x5C49EA0", VA = "0x185C4AAA0")]
	public PFGBOCEBCCG(PFGBOCEBCCG GHFAAPNAFDE, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C49D10", Offset = "0x5C49110", VA = "0x185C49D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C49DE0", Offset = "0x5C491E0", VA = "0x185C49DE0")]
	public void INMJBKGEACO([In] PFGBOCEBCCG OAGNBNMPALP, float4x4 HADNJFPICLN, Transform BDIPMCHFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C49BC0", Offset = "0x5C48FC0", VA = "0x185C49BC0")]
	public void DCNONABHEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A2B0", Offset = "0x5C496B0", VA = "0x185C4A2B0")]
	public void OHFLJLDJOLP(float EJKOOCGEPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C49980", Offset = "0x5C48D80", VA = "0x185C49980")]
	public PFGBOCEBCCG AEHCBIINMHP(Allocator KIKFOGPECEC, CancellationToken ELGJALILGJE)
	{
		return default(PFGBOCEBCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A190", Offset = "0x5C49590", VA = "0x185C4A190")]
	public Mesh MELNDEFJNHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A830", Offset = "0x5C49C30", VA = "0x185C4A830")]
	private unsafe static float3* PCGIDIMEHEE(NativeArray<float3> FFAHMFOPGLA)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A7E0", Offset = "0x5C49BE0", VA = "0x185C4A7E0")]
	private unsafe static int* PCGIDIMEHEE(NativeArray<int> FFAHMFOPGLA)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A160", Offset = "0x5C49560", VA = "0x185C4A160")]
	[CompilerGenerated]
	internal static void JCIEOIOIAOA(int DICIIPNJPOL, int DPDJFMOKKNO, DIPODPIOICJ P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MALKLJFPLPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int DLKNAEBHFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int OHBANGANJKE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ABCEKHKKBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C49810", Offset = "0x5C48C10", VA = "0x185C49810")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B880D0", Offset = "0x1B874D0", VA = "0x181B880D0")]
	public static MALKLJFPLPC GCOIEPKDLBA(MALKLJFPLPC IFAOGMEBPFN, MALKLJFPLPC DNPBOPMFFFF)
	{
		return default(MALKLJFPLPC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C498C0", Offset = "0x5C48CC0", VA = "0x185C498C0")]
	public static MALKLJFPLPC LOFOMPNOEOG(MALKLJFPLPC AJJIEOEHDOG, int HKKGEHMHEGP)
	{
		return default(MALKLJFPLPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C49820", Offset = "0x5C48C20", VA = "0x185C49820", Slot = "0")]
	public override bool Equals(object IBNKCBBPNON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C49870", Offset = "0x5C48C70", VA = "0x185C49870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C498E0", Offset = "0x5C48CE0", VA = "0x185C498E0", Slot = "3")]
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
