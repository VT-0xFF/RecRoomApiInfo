using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MHNNPFANOOA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class NKAHAIPAPCI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal delegate void AGNBPGGENNK(KPBFCMJELIP KIHHMPFECNA);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C530", Offset = "0x6B6B130", VA = "0x186B6C530")]
	private static void MOHFDBJIDBH(KPBFCMJELIP KIHHMPFECNA, AGNBPGGENNK MCNPOGDKJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C700", Offset = "0x6B6B300", VA = "0x186B6C700")]
	public static bool NFFEOFIFFIJ(this KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, [Optional] AGNBPGGENNK MCNPOGDKJIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C3E0", Offset = "0x6B6AFE0", VA = "0x186B6C3E0")]
	public static FKHBEIKGPKD LDFJDLNDCLM(this KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, string GLMEMJNJKAN, [Optional] AGNBPGGENNK MCNPOGDKJIA)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C2A0", Offset = "0x6B6AEA0", VA = "0x186B6C2A0")]
	public static FKHBEIKGPKD EMHPLCPOFFE(this KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, int GLMEMJNJKAN, [Optional] AGNBPGGENNK MCNPOGDKJIA)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C150", Offset = "0x6B6AD50", VA = "0x186B6C150")]
	public static FKHBEIKGPKD AIOJEFBOMJK(this KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, bool GLMEMJNJKAN, [Optional] AGNBPGGENNK MCNPOGDKJIA)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C5B0", Offset = "0x6B6B1B0", VA = "0x186B6C5B0")]
	public static FKHBEIKGPKD NDAJFJFNPKP(this KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, float GLMEMJNJKAN, [Optional] AGNBPGGENNK MCNPOGDKJIA)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C930", Offset = "0x6B6B530", VA = "0x186B6C930")]
	public static FKHBEIKGPKD PBMMPEMHBGA(this KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, DateTime GLMEMJNJKAN, [Optional] AGNBPGGENNK MCNPOGDKJIA)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C7F0", Offset = "0x6B6B3F0", VA = "0x186B6C7F0")]
	public static FKHBEIKGPKD OLPLCGMNLFI(this KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, long GLMEMJNJKAN, [Optional] AGNBPGGENNK MCNPOGDKJIA)
	{
		return default(FKHBEIKGPKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JAHBCLHBCHD : PEFCFPMAJDK, KPBFCMJELIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BKMLBFGBBKD JBEDICJCAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> KFHJGJGGAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> HEHOJKCMLMG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> EBAOFILACAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B66B70", Offset = "0x6B65770", VA = "0x186B66B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action JEMOCNPIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B67900", Offset = "0x6B66500", VA = "0x186B67900")]
	[Preserve]
	public JAHBCLHBCHD([GOICEJLKLIB(null)] BKMLBFGBBKD JBEDICJCAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
	public void PGCIOEOHDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B65FB0", Offset = "0x6B64BB0", VA = "0x186B65FB0")]
	private DirectoryInfo DFCFMCJOANN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B65F20", Offset = "0x6B64B20", VA = "0x186B65F20", Slot = "6")]
	public Task CDMAKBDNKCO(long BPEMGGMPAIP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B65E40", Offset = "0x6B64A40", VA = "0x186B65E40", Slot = "14")]
	public float ABNJKBPGGPE(string DPHIOKCFMFC, float NJMAFDCOBGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B660B0", Offset = "0x6B64CB0", VA = "0x186B660B0", Slot = "13")]
	public void DIDCCLFDDEO(string DPHIOKCFMFC, bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B674A0", Offset = "0x6B660A0", VA = "0x186B674A0", Slot = "12")]
	public bool OAHCABPNBHG(string DPHIOKCFMFC, bool NJMAFDCOBGL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B66A90", Offset = "0x6B65690", VA = "0x186B66A90", Slot = "10")]
	public int JOMJJGLIEKK(string DPHIOKCFMFC, int NJMAFDCOBGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B66640", Offset = "0x6B65240", VA = "0x186B66640", Slot = "18")]
	public DateTime GHKGLCEBGBK(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B664D0", Offset = "0x6B650D0", VA = "0x186B664D0", Slot = "19")]
	public void FENGPAFBIIH(string DPHIOKCFMFC, DateTime GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B66120", Offset = "0x6B64D20", VA = "0x186B66120", Slot = "15")]
	public void DOFFAOBGDJO(string DPHIOKCFMFC, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6B66B00", Offset = "0x6B65700", VA = "0x186B66B00", Slot = "11")]
	public void KHDDBFJMNEH(string DPHIOKCFMFC, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B66760", Offset = "0x6B65360", VA = "0x186B66760", Slot = "20")]
	public long HEDEOKKOBDK(string ALMPCPBBOLG, long NJMAFDCOBGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B65EB0", Offset = "0x6B64AB0", VA = "0x186B65EB0", Slot = "21")]
	public void CADMBBPFOAN(string ALMPCPBBOLG, long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5890", Offset = "0x2AC4490", VA = "0x182AC5890", Slot = "22")]
	public T OEIIJMDMFCP<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5890", Offset = "0x2AC4490", VA = "0x182AC5890", Slot = "23")]
	public void CILAHCJPCLH<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B666B0", Offset = "0x6B652B0", VA = "0x186B666B0", Slot = "16")]
	public string HCBFGBKOCGD(string DPHIOKCFMFC, string NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B67430", Offset = "0x6B66030", VA = "0x186B67430", Slot = "17")]
	public void NIIDMLBINDG(string DPHIOKCFMFC, string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B669D0", Offset = "0x6B655D0", VA = "0x186B669D0", Slot = "24")]
	public void IMGGAMIGBHE(string DPHIOKCFMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B66BB0", Offset = "0x6B657B0", VA = "0x186B66BB0", Slot = "9")]
	public bool MEFAPJAPPDM(string DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B66190", Offset = "0x6B64D90", VA = "0x186B66190", Slot = "25")]
	public Task FCDAFJDCONL(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B67570", Offset = "0x6B66170", VA = "0x186B67570")]
	private void OBJKPBFBAAP(DirectoryInfo JHNDIBPEDDG, string NDBCEPPDJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B667D0", Offset = "0x6B653D0", VA = "0x186B667D0")]
	private static string HNJDBFGOKBG(string DPHIOKCFMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B66540", Offset = "0x6B65140", VA = "0x186B66540")]
	private static string FHILFKKPJHF(byte[] HNGDLLNOPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B92A70", Offset = "0x2B91670", VA = "0x182B92A70")]
	private T HCNFCFFAFEI<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, [Optional] MINEKBJCNJM<T> AIOIANOFCGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B91690", Offset = "0x2B90290", VA = "0x182B91690")]
	private void CBGDEMCKLAL<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, [Optional] MINEKBJCNJM<T> AIOIANOFCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B66C40", Offset = "0x6B65840", VA = "0x186B66C40")]
	private Dictionary<string, string> MINEHJLDJKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class KIDJBDCDOCK
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B67B90", Offset = "0x6B66790", VA = "0x186B67B90")]
	[FJJFAIMPJIC(JBEKPLNNIEC.None)]
	private static void GBNHEMCAJHC(LLIMAHMFNLB INBELNINGBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OKLAOLOKCID : OBPAGILMKHG
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D100", Offset = "0x6B6BD00", VA = "0x186B6D100")]
	[Preserve]
	public OKLAOLOKCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OBPAGILMKHG : PEFCFPMAJDK, KPBFCMJELIP, KPGPPIHBBIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> MPNFKCBMFPH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JEMOCNPIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
	public void PGCIOEOHDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CB60", Offset = "0x6B6B760", VA = "0x186B6CB60", Slot = "6")]
	public Task CDMAKBDNKCO(long BPEMGGMPAIP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CFE0", Offset = "0x6B6BBE0", VA = "0x186B6CFE0", Slot = "9")]
	public bool MEFAPJAPPDM(string ALMPCPBBOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CF20", Offset = "0x6B6BB20", VA = "0x186B6CF20", Slot = "10")]
	public int JOMJJGLIEKK(string ALMPCPBBOLG, int NJMAFDCOBGL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CF80", Offset = "0x6B6BB80", VA = "0x186B6CF80", Slot = "11")]
	public void KHDDBFJMNEH(string ALMPCPBBOLG, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D0A0", Offset = "0x6B6BCA0", VA = "0x186B6D0A0", Slot = "12")]
	public bool OAHCABPNBHG(string ALMPCPBBOLG, bool NJMAFDCOBGL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CBF0", Offset = "0x6B6B7F0", VA = "0x186B6CBF0", Slot = "13")]
	public void DIDCCLFDDEO(string ALMPCPBBOLG, bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CAA0", Offset = "0x6B6B6A0", VA = "0x186B6CAA0", Slot = "14")]
	public float ABNJKBPGGPE(string ALMPCPBBOLG, float NJMAFDCOBGL = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CC50", Offset = "0x6B6B850", VA = "0x186B6CC50", Slot = "15")]
	public void DOFFAOBGDJO(string ALMPCPBBOLG, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CE00", Offset = "0x6B6BA00", VA = "0x186B6CE00", Slot = "16")]
	public string HCBFGBKOCGD(string ALMPCPBBOLG, [Optional] string NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D040", Offset = "0x6B6BC40", VA = "0x186B6D040", Slot = "17")]
	public void NIIDMLBINDG(string ALMPCPBBOLG, string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CDA0", Offset = "0x6B6B9A0", VA = "0x186B6CDA0", Slot = "18")]
	public DateTime GHKGLCEBGBK(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CD40", Offset = "0x6B6B940", VA = "0x186B6CD40", Slot = "19")]
	public void FENGPAFBIIH(string ALMPCPBBOLG, DateTime GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CE60", Offset = "0x6B6BA60", VA = "0x186B6CE60", Slot = "20")]
	public long HEDEOKKOBDK(string ALMPCPBBOLG, long NJMAFDCOBGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CB00", Offset = "0x6B6B700", VA = "0x186B6CB00", Slot = "21")]
	public void CADMBBPFOAN(string ALMPCPBBOLG, long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6870", Offset = "0x2CD5470", VA = "0x182CD6870", Slot = "22")]
	public T OEIIJMDMFCP<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5EF0", Offset = "0x2CD4AF0", VA = "0x182CD5EF0", Slot = "23")]
	public void CILAHCJPCLH<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5FD0", Offset = "0x2CD4BD0", VA = "0x182CD5FD0")]
	public T HCNFCFFAFEI<T>(string ALMPCPBBOLG, T NJMAFDCOBGL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5A00", Offset = "0x2CD4600", VA = "0x182CD5A00")]
	public void CBGDEMCKLAL<T>(string ALMPCPBBOLG, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CEC0", Offset = "0x6B6BAC0", VA = "0x186B6CEC0", Slot = "24")]
	public void IMGGAMIGBHE(string ALMPCPBBOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CCB0", Offset = "0x6B6B8B0", VA = "0x186B6CCB0", Slot = "25")]
	public Task FCDAFJDCONL(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D100", Offset = "0x6B6BD00", VA = "0x186B6D100")]
	public OBPAGILMKHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class OOHNDHLOPMA<TParent> where TParent : KPBFCMJELIP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<OOHNDHLOPMA<TParent>> ONMDJJJGENL;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4654BD0", Offset = "0x46537D0", VA = "0x184654BD0")]
	protected OOHNDHLOPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void ONDHHAABKMO();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void IAPFLGGHGDF(string DPHIOKCFMFC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4654850", Offset = "0x4653450", VA = "0x184654850")]
	public static void PLLBDHPKHEJ(string DPHIOKCFMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4654620", Offset = "0x4653220", VA = "0x184654620")]
	public static void ONPDEOINLOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LEMIJGJGMKM<TParent, TValue> : OOHNDHLOPMA<TParent> where TParent : KPBFCMJELIP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly LEMIJGJGMKM<TParent, TValue> IOGFCHMIMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> CNLLMEALKNO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41F3BC0", Offset = "0x41F27C0", VA = "0x1841F3BC0")]
	public bool CMBHFEACNLN(string KGJLOOCNEOA, [Out] TValue MHABCMINOEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41F3C80", Offset = "0x41F2880", VA = "0x1841F3C80")]
	public void FHJGNOPIDAO(string KGJLOOCNEOA, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3C74660", Offset = "0x3C73260", VA = "0x183C74660", Slot = "4")]
	protected override void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3809370", Offset = "0x3807F70", VA = "0x183809370", Slot = "5")]
	protected override void IAPFLGGHGDF(string KGJLOOCNEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x41F3EC0", Offset = "0x41F2AC0", VA = "0x1841F3EC0")]
	public LEMIJGJGMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KPBFCMJELIP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGCIOEOHDJP();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MEFAPJAPPDM(string ALMPCPBBOLG);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JOMJJGLIEKK(string ALMPCPBBOLG, int NJMAFDCOBGL = 0);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHDDBFJMNEH(string ALMPCPBBOLG, int GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OAHCABPNBHG(string ALMPCPBBOLG, bool NJMAFDCOBGL = false);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DIDCCLFDDEO(string ALMPCPBBOLG, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float ABNJKBPGGPE(string ALMPCPBBOLG, float NJMAFDCOBGL = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DOFFAOBGDJO(string ALMPCPBBOLG, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string HCBFGBKOCGD(string ALMPCPBBOLG, [Optional] string NJMAFDCOBGL);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NIIDMLBINDG(string ALMPCPBBOLG, string GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime GHKGLCEBGBK(string ALMPCPBBOLG, [Optional] DateTime BJLJAPCDCJC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FENGPAFBIIH(string ALMPCPBBOLG, DateTime BJLJAPCDCJC);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long HEDEOKKOBDK(string ALMPCPBBOLG, long NJMAFDCOBGL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CADMBBPFOAN(string ALMPCPBBOLG, long GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T OEIIJMDMFCP<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, MINEKBJCNJM<T> MFDGNKPCBCO);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CILAHCJPCLH<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, MINEKBJCNJM<T> MFDGNKPCBCO);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IMGGAMIGBHE(string ALMPCPBBOLG);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task FCDAFJDCONL([Optional] CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PEFCFPMAJDK : KPBFCMJELIP
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JEMOCNPIGBA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task CDMAKBDNKCO(long BPEMGGMPAIP, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KPGPPIHBBIE : KPBFCMJELIP
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BEGLPIIIEHL : PEFCFPMAJDK, KPBFCMJELIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KEMNALHCKCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public BEGLPIIIEHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6B679A0", Offset = "0x6B665A0", VA = "0x186B679A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6B67B30", Offset = "0x6B66730", VA = "0x186B67B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EJIBLGJGADM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public BEGLPIIIEHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6B65470", Offset = "0x6B64070", VA = "0x186B65470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6B65760", Offset = "0x6B64360", VA = "0x186B65760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PEFCFPMAJDK JIBPOBLGOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly JAHBCLHBCHD KCFPLJEPMMC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6B649B0", Offset = "0x6B635B0", VA = "0x186B649B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JEMOCNPIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B64210", Offset = "0x6B62E10", VA = "0x186B64210", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B64830", Offset = "0x6B63430", VA = "0x186B64830", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B64EC0", Offset = "0x6B63AC0", VA = "0x186B64EC0")]
	[Preserve]
	public BEGLPIIIEHL([GOICEJLKLIB(null)] BKMLBFGBBKD JBEDICJCAIO, [GOICEJLKLIB("Disk_Unity")] PEFCFPMAJDK JIBPOBLGOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B64E60", Offset = "0x6B63A60", VA = "0x186B64E60", Slot = "8")]
	public void PGCIOEOHDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B64BD0", Offset = "0x6B637D0", VA = "0x186B64BD0", Slot = "9")]
	public bool MEFAPJAPPDM(string ALMPCPBBOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B64A10", Offset = "0x6B63610", VA = "0x186B64A10", Slot = "10")]
	public int JOMJJGLIEKK(string ALMPCPBBOLG, int NJMAFDCOBGL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B64B60", Offset = "0x6B63760", VA = "0x186B64B60", Slot = "11")]
	public void KHDDBFJMNEH(string ALMPCPBBOLG, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B64CD0", Offset = "0x6B638D0", VA = "0x186B64CD0", Slot = "12")]
	public bool OAHCABPNBHG(string ALMPCPBBOLG, bool NJMAFDCOBGL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B64130", Offset = "0x6B62D30", VA = "0x186B64130", Slot = "13")]
	public void DIDCCLFDDEO(string ALMPCPBBOLG, bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B63E50", Offset = "0x6B62A50", VA = "0x186B63E50", Slot = "14")]
	public float ABNJKBPGGPE(string ALMPCPBBOLG, float NJMAFDCOBGL = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B641A0", Offset = "0x6B62DA0", VA = "0x186B641A0", Slot = "15")]
	public void DOFFAOBGDJO(string ALMPCPBBOLG, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B64530", Offset = "0x6B63130", VA = "0x186B64530", Slot = "16")]
	public string HCBFGBKOCGD(string ALMPCPBBOLG, [Optional] string NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B64C60", Offset = "0x6B63860", VA = "0x186B64C60", Slot = "17")]
	public void NIIDMLBINDG(string ALMPCPBBOLG, string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B643D0", Offset = "0x6B62FD0", VA = "0x186B643D0", Slot = "18")]
	public DateTime GHKGLCEBGBK(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B64360", Offset = "0x6B62F60", VA = "0x186B64360", Slot = "19")]
	public void FENGPAFBIIH(string ALMPCPBBOLG, DateTime BJLJAPCDCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B646D0", Offset = "0x6B632D0", VA = "0x186B646D0", Slot = "20")]
	public long HEDEOKKOBDK(string ALMPCPBBOLG, long NJMAFDCOBGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B63FB0", Offset = "0x6B62BB0", VA = "0x186B63FB0", Slot = "21")]
	public void CADMBBPFOAN(string ALMPCPBBOLG, long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2882F70", Offset = "0x2881B70", VA = "0x182882F70", Slot = "22")]
	public T OEIIJMDMFCP<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2882E30", Offset = "0x2881A30", VA = "0x182882E30", Slot = "23")]
	public void CILAHCJPCLH<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6B648A0", Offset = "0x6B634A0", VA = "0x186B648A0", Slot = "24")]
	public void IMGGAMIGBHE(string ALMPCPBBOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B64270", Offset = "0x6B62E70", VA = "0x186B64270", Slot = "25")]
	[AsyncStateMachine(typeof(KEMNALHCKCE))]
	public Task FCDAFJDCONL([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B64020", Offset = "0x6B62C20", VA = "0x186B64020", Slot = "6")]
	[AsyncStateMachine(typeof(EJIBLGJGADM))]
	public Task CDMAKBDNKCO(long BPEMGGMPAIP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ABDOPICGIIE : PEFCFPMAJDK, KPBFCMJELIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HENPGGEKCLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public ABDOPICGIIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6B65A10", Offset = "0x6B64610", VA = "0x186B65A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6B65DE0", Offset = "0x6B649E0", VA = "0x186B65DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GNFGIGBJONG : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ABDOPICGIIE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public GNFGIGBJONG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6B65950", Offset = "0x6B64550", VA = "0x186B65950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6B659C0", Offset = "0x6B645C0", VA = "0x186B659C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BKMLBFGBBKD JBEDICJCAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool JKDLPEENDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool EGECHPNGIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private FCOOAPKDPMG CKOLOLELOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private GNHKJFLENJL KKDFOOPLFNF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action JEMOCNPIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B63830", Offset = "0x6B62430", VA = "0x186B63830")]
	[Preserve]
	public ABDOPICGIIE([GOICEJLKLIB(null)] BKMLBFGBBKD JBEDICJCAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
	public void PGCIOEOHDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B63130", Offset = "0x6B61D30", VA = "0x186B63130", Slot = "6")]
	public Task CDMAKBDNKCO(long BPEMGGMPAIP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x11BED20", Offset = "0x11BD920", VA = "0x1811BED20")]
	private static int MLKBNFOOINL(bool GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B637B0", Offset = "0x6B623B0", VA = "0x186B637B0", Slot = "9")]
	public bool MEFAPJAPPDM(string ALMPCPBBOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6B636E0", Offset = "0x6B622E0", VA = "0x186B636E0", Slot = "10")]
	public int JOMJJGLIEKK(string ALMPCPBBOLG, int NJMAFDCOBGL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B63710", Offset = "0x6B62310", VA = "0x186B63710", Slot = "11")]
	public void KHDDBFJMNEH(string ALMPCPBBOLG, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B63800", Offset = "0x6B62400", VA = "0x186B63800", Slot = "12")]
	public bool OAHCABPNBHG(string ALMPCPBBOLG, bool NJMAFDCOBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B63260", Offset = "0x6B61E60", VA = "0x186B63260", Slot = "13")]
	public void DIDCCLFDDEO(string ALMPCPBBOLG, bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6B63020", Offset = "0x6B61C20", VA = "0x186B63020", Slot = "14")]
	public float ABNJKBPGGPE(string ALMPCPBBOLG, float NJMAFDCOBGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B63290", Offset = "0x6B61E90", VA = "0x186B63290", Slot = "15")]
	public void DOFFAOBGDJO(string ALMPCPBBOLG, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B63440", Offset = "0x6B62040", VA = "0x186B63440", Slot = "18")]
	public DateTime GHKGLCEBGBK(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B633D0", Offset = "0x6B61FD0", VA = "0x186B633D0", Slot = "19")]
	public void FENGPAFBIIH(string ALMPCPBBOLG, DateTime BJLJAPCDCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B634E0", Offset = "0x6B620E0", VA = "0x186B634E0", Slot = "20")]
	public long HEDEOKKOBDK(string ALMPCPBBOLG, long NJMAFDCOBGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B63050", Offset = "0x6B61C50", VA = "0x186B63050", Slot = "21")]
	public void CADMBBPFOAN(string ALMPCPBBOLG, long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x31D6170", Offset = "0x31D4D70", VA = "0x1831D6170", Slot = "22")]
	public T OEIIJMDMFCP<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x31D6170", Offset = "0x31D4D70", VA = "0x1831D6170", Slot = "23")]
	public void CILAHCJPCLH<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x31D6300", Offset = "0x31D4F00", VA = "0x1831D6300")]
	private T DNNKKMOMHLJ<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, [Optional] MINEKBJCNJM<T> AIOIANOFCGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x31D6E60", Offset = "0x31D5A60", VA = "0x1831D6E60")]
	private void HNDNBEGBOEN<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, [Optional] MINEKBJCNJM<T> AIOIANOFCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B634B0", Offset = "0x6B620B0", VA = "0x186B634B0", Slot = "16")]
	public string HCBFGBKOCGD(string ALMPCPBBOLG, string NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6B637D0", Offset = "0x6B623D0", VA = "0x186B637D0", Slot = "17")]
	public void NIIDMLBINDG(string ALMPCPBBOLG, string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6B632C0", Offset = "0x6B61EC0", VA = "0x186B632C0")]
	private void EJKCNDCOBAK(string ALMPCPBBOLG, string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6B63640", Offset = "0x6B62240", VA = "0x186B63640")]
	private string IOHALAMNNJJ(string ALMPCPBBOLG, string NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6B635B0", Offset = "0x6B621B0", VA = "0x186B635B0", Slot = "24")]
	public void IMGGAMIGBHE(string ALMPCPBBOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6B631C0", Offset = "0x6B61DC0", VA = "0x186B631C0")]
	private string CHAACHEFBIO(string DPHIOKCFMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6B632E0", Offset = "0x6B61EE0", VA = "0x186B632E0", Slot = "25")]
	[AsyncStateMachine(typeof(HENPGGEKCLE))]
	public Task FCDAFJDCONL(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6B63660", Offset = "0x6B62260", VA = "0x186B63660")]
	[IteratorStateMachine(typeof(GNFGIGBJONG))]
	private IEnumerator<OGKGDFEHPGC> JJCPIBFFKCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B63550", Offset = "0x6B62150", VA = "0x186B63550")]
	private void HOOINFECNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B63740", Offset = "0x6B62340", VA = "0x186B63740")]
	private void LOEAOJBKAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B630C0", Offset = "0x6B61CC0", VA = "0x186B630C0")]
	private void CCILAEPDCBC(bool IPHBFEGENLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MNFBLGPBGBN : PEFCFPMAJDK, KPBFCMJELIP
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Dictionary<string, string> HEHOJKCMLMG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string LMIMLKHIGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6B6B060", Offset = "0x6B69C60", VA = "0x186B6B060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> EBAOFILACAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6B6B8C0", Offset = "0x6B6A4C0", VA = "0x186B6B8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action JEMOCNPIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	[Preserve]
	public MNFBLGPBGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
	public void PGCIOEOHDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B140", Offset = "0x6B69D40", VA = "0x186B6B140", Slot = "6")]
	public Task CDMAKBDNKCO(long BPEMGGMPAIP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B6AFF0", Offset = "0x6B69BF0", VA = "0x186B6AFF0", Slot = "14")]
	public float ABNJKBPGGPE(string DPHIOKCFMFC, float NJMAFDCOBGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B1D0", Offset = "0x6B69DD0", VA = "0x186B6B1D0", Slot = "13")]
	public void DIDCCLFDDEO(string DPHIOKCFMFC, bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BD30", Offset = "0x6B6A930", VA = "0x186B6BD30", Slot = "12")]
	public bool OAHCABPNBHG(string DPHIOKCFMFC, bool NJMAFDCOBGL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B7E0", Offset = "0x6B6A3E0", VA = "0x186B6B7E0", Slot = "10")]
	public int JOMJJGLIEKK(string DPHIOKCFMFC, int NJMAFDCOBGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B590", Offset = "0x6B6A190", VA = "0x186B6B590", Slot = "18")]
	public DateTime GHKGLCEBGBK(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B520", Offset = "0x6B6A120", VA = "0x186B6B520", Slot = "19")]
	public void FENGPAFBIIH(string DPHIOKCFMFC, DateTime GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B240", Offset = "0x6B69E40", VA = "0x186B6B240", Slot = "15")]
	public void DOFFAOBGDJO(string DPHIOKCFMFC, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B850", Offset = "0x6B6A450", VA = "0x186B6B850", Slot = "11")]
	public void KHDDBFJMNEH(string DPHIOKCFMFC, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B6B0", Offset = "0x6B6A2B0", VA = "0x186B6B6B0", Slot = "20")]
	public long HEDEOKKOBDK(string ALMPCPBBOLG, long NJMAFDCOBGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B0D0", Offset = "0x6B69CD0", VA = "0x186B6B0D0", Slot = "21")]
	public void CADMBBPFOAN(string ALMPCPBBOLG, long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5890", Offset = "0x2AC4490", VA = "0x182AC5890", Slot = "22")]
	public T OEIIJMDMFCP<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5890", Offset = "0x2AC4490", VA = "0x182AC5890", Slot = "23")]
	public void CILAHCJPCLH<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, MINEKBJCNJM<T> MFDGNKPCBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B600", Offset = "0x6B6A200", VA = "0x186B6B600", Slot = "16")]
	public string HCBFGBKOCGD(string DPHIOKCFMFC, string NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BC90", Offset = "0x6B6A890", VA = "0x186B6BC90", Slot = "17")]
	public void NIIDMLBINDG(string DPHIOKCFMFC, string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B720", Offset = "0x6B6A320", VA = "0x186B6B720", Slot = "24")]
	public void IMGGAMIGBHE(string DPHIOKCFMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B900", Offset = "0x6B6A500", VA = "0x186B6B900", Slot = "9")]
	public bool MEFAPJAPPDM(string DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B2B0", Offset = "0x6B69EB0", VA = "0x186B6B2B0", Slot = "25")]
	public Task FCDAFJDCONL(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C44A50", Offset = "0x2C43650", VA = "0x182C44A50")]
	private T HCNFCFFAFEI<T>(string ALMPCPBBOLG, T NJMAFDCOBGL, [Optional] MINEKBJCNJM<T> AIOIANOFCGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C439E0", Offset = "0x2C425E0", VA = "0x182C439E0")]
	private void CBGDEMCKLAL<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, [Optional] MINEKBJCNJM<T> AIOIANOFCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B990", Offset = "0x6B6A590", VA = "0x186B6B990")]
	private Dictionary<string, string> MINEHJLDJKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IAJFHEPFFKH
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JEMOCNPIGBA;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGCIOEOHDJP();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PDNGFNMKJCH(long BPEMGGMPAIP);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FDLAIOGIPBB(MHNNPFANOOA GFCOALLCGPM = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MIGIEBBBNFA(string ALMPCPBBOLG, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OFAMGNKFNMK(string ALMPCPBBOLG, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string FOGKNFCCHHA(string ALMPCPBBOLG, [Optional] string NJMAFDCOBGL, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FKHBEIKGPKD JHFPPBIKEED(string ALMPCPBBOLG, string GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int BFKBDCMPKOK(string ALMPCPBBOLG, int NJMAFDCOBGL = 0, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FKHBEIKGPKD FIFOCFIFBPL(string ALMPCPBBOLG, int GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DFKKJLBLNOG(string ALMPCPBBOLG, bool NJMAFDCOBGL, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FKHBEIKGPKD BPPGIPKPIDJ(string ALMPCPBBOLG, bool GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float DLEDBAODGMA(string ALMPCPBBOLG, float NJMAFDCOBGL = 0f, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FKHBEIKGPKD HCPGDIACGLF(string ALMPCPBBOLG, float GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime JDBJGDKCNGM(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FKHBEIKGPKD FICIMHGHBIH(string ALMPCPBBOLG, DateTime GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long DGJHMBCNNBA(string ALMPCPBBOLG, long NJMAFDCOBGL = 0L, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FKHBEIKGPKD EJLCMFKBGJC(string ALMPCPBBOLG, long GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T MJPMPCCNNIP<T>(string ALMPCPBBOLG, [Optional] T NJMAFDCOBGL, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FKHBEIKGPKD HHFEBLMBEFG<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool LGKICAEMINB(string ALMPCPBBOLG);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool DAKKBBAMJBF(string ALMPCPBBOLG);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string FKPBCMAAMPF(string ALMPCPBBOLG, [Optional] string NJMAFDCOBGL);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FKHBEIKGPKD MBGPMHHCFEJ(string ALMPCPBBOLG, string GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int EHDPIEEBKMI(string ALMPCPBBOLG, int NJMAFDCOBGL = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FKHBEIKGPKD HPPCLMMDKNM(string ALMPCPBBOLG, int GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GMKCPLJCHAI(string ALMPCPBBOLG, bool NJMAFDCOBGL);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "28")]
	FKHBEIKGPKD FBJFMNILJEE(string ALMPCPBBOLG, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float PFDNAHNAAFJ(string ALMPCPBBOLG, float NJMAFDCOBGL = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "30")]
	FKHBEIKGPKD BKMKJLPBICH(string ALMPCPBBOLG, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime LNBPLJIGKIB(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FKHBEIKGPKD GPLGCFGJEMN(string ALMPCPBBOLG, DateTime GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long NFEOBOKANIH(string ALMPCPBBOLG, long NJMAFDCOBGL = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "34")]
	FKHBEIKGPKD HFJPGCPMJFA(string ALMPCPBBOLG, long GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LBBJEILGAHG<T>(MINEKBJCNJM<T> MFDGNKPCBCO, [Optional] IEqualityComparer<T> DPJNHLBPBGL);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CAPKEOLHLFK<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable FHKPOFMHGOK();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AFKLKIGANDA(float EACMJFLDLDP);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task HOOINFECNLG([Optional] CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum FKHBEIKGPKD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KLABJPCGDEM : IAJFHEPFFKH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class MIHFKJJKNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<MIHFKJJKNGJ> EBMPOFEBENL;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6B6AE20", Offset = "0x6B69A20", VA = "0x186B6AE20")]
		public static void ONPDEOINLOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ONDHHAABKMO();

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		protected MIHFKJJKNGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class PNGCEAJNICD<T> : MIHFKJJKNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly PNGCEAJNICD<T> GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MINEKBJCNJM<T> ADGFGKLHEID
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> POPPFDIMKPP
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GJNMDGHINNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x37A6960", Offset = "0x37A5560", VA = "0x1837A6960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4781010", Offset = "0x477FC10", VA = "0x184781010")]
		private PNGCEAJNICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4780A60", Offset = "0x477F660", VA = "0x184780A60")]
		public void FHCDBNBHAOK(MINEKBJCNJM<T> AIOIANOFCGH, [Optional] IEqualityComparer<T> DPJNHLBPBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4780DC0", Offset = "0x477F9C0", VA = "0x184780DC0", Slot = "4")]
		public override void ONDHHAABKMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class PKDMGEHABPE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly KLABJPCGDEM PCCOKILBAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object FAHMACCGPHP;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D2A0", Offset = "0x6B6BEA0", VA = "0x186B6D2A0")]
		public PKDMGEHABPE(KLABJPCGDEM PCCOKILBAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D270", Offset = "0x6B6BE70", VA = "0x186B6D270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct MOIJFGMPKJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public KLABJPCGDEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6B6BE00", Offset = "0x6B6AA00", VA = "0x186B6BE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C0F0", Offset = "0x6B6ACF0", VA = "0x186B6C0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct EMBOMNDLGII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KLABJPCGDEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public KPBFCMJELIP backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6B657C0", Offset = "0x6B643C0", VA = "0x186B657C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct AKNJNPGJOPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public KLABJPCGDEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6B63920", Offset = "0x6B62520", VA = "0x186B63920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6B63DF0", Offset = "0x6B629F0", VA = "0x186B63DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OMGEJPODKPB : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public KLABJPCGDEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public OMGEJPODKPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D190", Offset = "0x6B6BD90", VA = "0x186B6D190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D220", Offset = "0x6B6BE20", VA = "0x186B6D220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly PEFCFPMAJDK HFAFLPBMLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly PEFCFPMAJDK AJGAMMMBDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KPGPPIHBBIE NLOLHCIPAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly FCOOAPKDPMG CKOLOLELOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NKAHAIPAPCI.AGNBPGGENNK MCNPOGDKJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EFNEIMDDKAG CDKLHELPDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<KPBFCMJELIP> FBKNJNCLEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task IGINAKABHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> DLPAMFIBLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private GNHKJFLENJL JHHANKDFGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object ONAMIKINNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object BLEIHLJLAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long APFJHPGIOPE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool OLMOAJOJFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B68160", Offset = "0x6B66D60", VA = "0x186B68160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource ACCFLEKOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8433B0", Offset = "0x841FB0", VA = "0x1808433B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x843340", Offset = "0x841F40", VA = "0x180843340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action JEMOCNPIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6B68A60", Offset = "0x6B67660", VA = "0x186B68A60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B69970", Offset = "0x6B68570", VA = "0x186B69970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B69A10", Offset = "0x6B68610", VA = "0x186B69A10")]
	[FJJFAIMPJIC(JBEKPLNNIEC.None)]
	private static void JAPOJOAJPPN(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B6AA50", Offset = "0x6B69650", VA = "0x186B6AA50")]
	[Preserve]
	public KLABJPCGDEM([GOICEJLKLIB("Disk")] PEFCFPMAJDK HFAFLPBMLJJ, [GOICEJLKLIB("Cloud")] PEFCFPMAJDK AJGAMMMBDFA, [GOICEJLKLIB(null)] KPGPPIHBBIE NLOLHCIPAPD, [GOICEJLKLIB(null)] FCOOAPKDPMG CKOLOLELOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B68700", Offset = "0x6B67300", VA = "0x186B68700", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B68630", Offset = "0x6B67230", VA = "0x186B68630")]
	private void DLLDOEMOGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A9E0", Offset = "0x6B695E0", VA = "0x186B6A9E0", Slot = "6")]
	public void PGCIOEOHDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A7A0", Offset = "0x6B693A0", VA = "0x186B6A7A0", Slot = "7")]
	public Task PDNGFNMKJCH(long BPEMGGMPAIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A420", Offset = "0x6B69020", VA = "0x186B6A420")]
	[AsyncStateMachine(typeof(MOIJFGMPKJB))]
	private Task NNPFIFDPEEO(long BPEMGGMPAIP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A120", Offset = "0x6B68D20", VA = "0x186B6A120")]
	private void LOELIJNJEGM(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B68680", Offset = "0x6B67280", VA = "0x186B68680")]
	private void DMAJHBKNDGG(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6B68100", Offset = "0x6B66D00", VA = "0x186B68100")]
	private string CBPLGOAPJAB(string KNGEIFIBLDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A170", Offset = "0x6B68D70", VA = "0x186B6A170")]
	private void MHOLBIFLBDL(MHNNPFANOOA GFCOALLCGPM, string DPHIOKCFMFC, [Out] PEFCFPMAJDK KIHHMPFECNA, [Out] string KGLCEIKFCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6B69120", Offset = "0x6B67D20", VA = "0x186B69120")]
	private PEFCFPMAJDK FMPIPPNPNAO(MHNNPFANOOA GFCOALLCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6B68C00", Offset = "0x6B67800", VA = "0x186B68C00", Slot = "8")]
	public bool FDLAIOGIPBB(MHNNPFANOOA GFCOALLCGPM = MHNNPFANOOA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A310", Offset = "0x6B68F10", VA = "0x186B6A310", Slot = "9")]
	public bool MIGIEBBBNFA(string ALMPCPBBOLG, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A530", Offset = "0x6B69130", VA = "0x186B6A530", Slot = "10")]
	public bool OFAMGNKFNMK(string ALMPCPBBOLG, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6B691A0", Offset = "0x6B67DA0", VA = "0x186B691A0", Slot = "11")]
	public string FOGKNFCCHHA(string ALMPCPBBOLG, [Optional] string NJMAFDCOBGL, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6B69B20", Offset = "0x6B68720", VA = "0x186B69B20", Slot = "12")]
	public FKHBEIKGPKD JHFPPBIKEED(string ALMPCPBBOLG, string GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6B67D60", Offset = "0x6B66960", VA = "0x186B67D60", Slot = "13")]
	public int BFKBDCMPKOK(string ALMPCPBBOLG, int NJMAFDCOBGL = 0, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6B68F40", Offset = "0x6B67B40", VA = "0x186B68F40", Slot = "14")]
	public FKHBEIKGPKD FIFOCFIFBPL(string ALMPCPBBOLG, int GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6B68250", Offset = "0x6B66E50", VA = "0x186B68250", Slot = "15")]
	public bool DFKKJLBLNOG(string ALMPCPBBOLG, bool NJMAFDCOBGL, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6B67F90", Offset = "0x6B66B90", VA = "0x186B67F90", Slot = "16")]
	public FKHBEIKGPKD BPPGIPKPIDJ(string ALMPCPBBOLG, bool GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6B68580", Offset = "0x6B67180", VA = "0x186B68580", Slot = "17")]
	public float DLEDBAODGMA(string ALMPCPBBOLG, float NJMAFDCOBGL = 0f, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6B692E0", Offset = "0x6B67EE0", VA = "0x186B692E0", Slot = "18")]
	public FKHBEIKGPKD HCPGDIACGLF(string ALMPCPBBOLG, float GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6B69A80", Offset = "0x6B68680", VA = "0x186B69A80", Slot = "19")]
	public DateTime JDBJGDKCNGM(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6B68DA0", Offset = "0x6B679A0", VA = "0x186B68DA0", Slot = "20")]
	public FKHBEIKGPKD FICIMHGHBIH(string ALMPCPBBOLG, DateTime GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6B68300", Offset = "0x6B66F00", VA = "0x186B68300", Slot = "21")]
	public long DGJHMBCNNBA(string ALMPCPBBOLG, long NJMAFDCOBGL = 0L, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6B688F0", Offset = "0x6B674F0", VA = "0x186B688F0", Slot = "22")]
	public FKHBEIKGPKD EJLCMFKBGJC(string ALMPCPBBOLG, long GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFB70", Offset = "0x2BCE770", VA = "0x182BCFB70", Slot = "23")]
	public T MJPMPCCNNIP<T>(string ALMPCPBBOLG, [Optional] T NJMAFDCOBGL, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFB70", Offset = "0x2BCE770", VA = "0x182BCFB70", Slot = "24")]
	public FKHBEIKGPKD HHFEBLMBEFG<T>(string ALMPCPBBOLG, T GLMEMJNJKAN, MHNNPFANOOA LEMEKGPCOHP = MHNNPFANOOA.CLOUD)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A050", Offset = "0x6B68C50", VA = "0x186B6A050", Slot = "25")]
	public bool LGKICAEMINB(string ALMPCPBBOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6B68210", Offset = "0x6B66E10", VA = "0x186B68210", Slot = "26")]
	public bool DAKKBBAMJBF(string ALMPCPBBOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6B690B0", Offset = "0x6B67CB0", VA = "0x186B690B0", Slot = "27")]
	public string FKPBCMAAMPF(string ALMPCPBBOLG, [Optional] string NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A140", Offset = "0x6B68D40", VA = "0x186B6A140", Slot = "28")]
	public FKHBEIKGPKD MBGPMHHCFEJ(string ALMPCPBBOLG, string GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6B68880", Offset = "0x6B67480", VA = "0x186B68880", Slot = "29")]
	public int EHDPIEEBKMI(string ALMPCPBBOLG, int NJMAFDCOBGL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6B696C0", Offset = "0x6B682C0", VA = "0x186B696C0", Slot = "30")]
	public FKHBEIKGPKD HPPCLMMDKNM(string ALMPCPBBOLG, int GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6B69240", Offset = "0x6B67E40", VA = "0x186B69240", Slot = "31")]
	public bool GMKCPLJCHAI(string ALMPCPBBOLG, bool NJMAFDCOBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6B68B00", Offset = "0x6B67700", VA = "0x186B68B00", Slot = "32")]
	public FKHBEIKGPKD FBJFMNILJEE(string ALMPCPBBOLG, bool GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A970", Offset = "0x6B69570", VA = "0x186B6A970", Slot = "33")]
	public float PFDNAHNAAFJ(string ALMPCPBBOLG, float NJMAFDCOBGL = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6B67F60", Offset = "0x6B66B60", VA = "0x186B67F60", Slot = "34")]
	public FKHBEIKGPKD BKMKJLPBICH(string ALMPCPBBOLG, float GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A0B0", Offset = "0x6B68CB0", VA = "0x186B6A0B0", Slot = "35")]
	public DateTime LNBPLJIGKIB(string ALMPCPBBOLG, [Optional] DateTime NJMAFDCOBGL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6B692B0", Offset = "0x6B67EB0", VA = "0x186B692B0", Slot = "36")]
	public FKHBEIKGPKD GPLGCFGJEMN(string ALMPCPBBOLG, DateTime GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A3B0", Offset = "0x6B68FB0", VA = "0x186B6A3B0", Slot = "37")]
	public long NFEOBOKANIH(string ALMPCPBBOLG, long NJMAFDCOBGL = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6B69460", Offset = "0x6B68060", VA = "0x186B69460", Slot = "38")]
	public FKHBEIKGPKD HFJPGCPMJFA(string ALMPCPBBOLG, long GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6B67D00", Offset = "0x6B66900", VA = "0x186B67D00")]
	private bool BCNOPIJGIJH(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6B69E10", Offset = "0x6B68A10", VA = "0x186B69E10")]
	private bool JNPPBGLLOBH(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B69F00", Offset = "0x6B68B00", VA = "0x186B69F00")]
	private FKHBEIKGPKD JPBMFIHLEIG(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, string GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6B68740", Offset = "0x6B67340", VA = "0x186B68740")]
	private FKHBEIKGPKD EAAHPLHPOPG(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, int GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B69490", Offset = "0x6B68090", VA = "0x186B69490")]
	private FKHBEIKGPKD HJLGIEBFOGO(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, bool GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6B67E10", Offset = "0x6B66A10", VA = "0x186B67E10")]
	private FKHBEIKGPKD BKAIKMGGIDD(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, float GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6B69CA0", Offset = "0x6B688A0", VA = "0x186B69CA0")]
	private FKHBEIKGPKD JLDKCFAALOO(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, DateTime GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A660", Offset = "0x6B69260", VA = "0x186B6A660")]
	private FKHBEIKGPKD PBHFBEFGHCP(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, long GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF600", Offset = "0x2BCE200", VA = "0x182BCF600")]
	private T GFIHCHMNMOI<T>(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, T NJMAFDCOBGL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFF80", Offset = "0x2BCEB80", VA = "0x182BCFF80")]
	private FKHBEIKGPKD OFBPFNBEEAJ<T>(KPBFCMJELIP KIHHMPFECNA, string ALMPCPBBOLG, T GLMEMJNJKAN)
	{
		return default(FKHBEIKGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFD40", Offset = "0x2BCE940", VA = "0x182BCFD40", Slot = "39")]
	public void LBBJEILGAHG<T>(MINEKBJCNJM<T> MFDGNKPCBCO, [Optional] IEqualityComparer<T> DPJNHLBPBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF580", Offset = "0x2BCE180", VA = "0x182BCF580", Slot = "40")]
	public void CAPKEOLHLFK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6B68B30", Offset = "0x6B67730", VA = "0x186B68B30")]
	[AsyncStateMachine(typeof(EMBOMNDLGII))]
	private void FCDAFJDCONL(KPBFCMJELIP LGJJCBEOKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6B695D0", Offset = "0x6B681D0", VA = "0x186B695D0", Slot = "43")]
	[AsyncStateMachine(typeof(AKNJNPGJOPP))]
	public Task HOOINFECNLG([Optional] CancellationToken FGIAGALCIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6B683A0", Offset = "0x6B66FA0", VA = "0x186B683A0")]
	private void DJBIBEGDAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6B68CC0", Offset = "0x6B678C0", VA = "0x186B68CC0", Slot = "41")]
	public IDisposable FHKPOFMHGOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6B67CF0", Offset = "0x6B668F0", VA = "0x186B67CF0", Slot = "42")]
	public void AFKLKIGANDA(float EACMJFLDLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6B696F0", Offset = "0x6B682F0", VA = "0x186B696F0")]
	private void IJDBJJLMLBN(float BCLAKHCBNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6B68180", Offset = "0x6B66D80", VA = "0x186B68180")]
	[IteratorStateMachine(typeof(OMGEJPODKPB))]
	private IEnumerator<OGKGDFEHPGC> CGIKCHPNAJI(float EACMJFLDLDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6B68220", Offset = "0x6B66E20", VA = "0x186B68220")]
	[CompilerGenerated]
	private void DBFEDPNFFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EFIFAKMNKDC : MMJDAIMIPGK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static EFIFAKMNKDC GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6B64FD0", Offset = "0x6B63BD0", VA = "0x186B64FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6B652A0", Offset = "0x6B63EA0", VA = "0x186B652A0", Slot = "9")]
	public override string PLFEAILJDFE(bool HJNPKADFMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6B65020", Offset = "0x6B63C20", VA = "0x186B65020", Slot = "10")]
	protected override bool HFIMINAGKLG(string HJNPKADFMMO, [Out] bool GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6B65430", Offset = "0x6B64030", VA = "0x186B65430")]
	public EFIFAKMNKDC()
	{
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
