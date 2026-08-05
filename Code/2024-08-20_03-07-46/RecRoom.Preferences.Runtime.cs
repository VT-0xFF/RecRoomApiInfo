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
public enum KFBHAONGCND : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class OEBEMOFKONJ
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal delegate void GKGBLNKIPKH(ENPFGEFHANH LLCIPEGJGCO);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AEF0", Offset = "0x6C19EF0", VA = "0x186C1AEF0")]
	private static void GAFDHOMDICF(ENPFGEFHANH LLCIPEGJGCO, GKGBLNKIPKH PBLICJNEIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B0B0", Offset = "0x6C1A0B0", VA = "0x186C1B0B0")]
	public static bool IKCCKAJNPFH(this ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, [Optional] GKGBLNKIPKH PBLICJNEIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AAE0", Offset = "0x6C19AE0", VA = "0x186C1AAE0")]
	public static CDHJMIFGAJE AJBDNFAJPAC(this ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, string JJCEIJMGOAB, [Optional] GKGBLNKIPKH PBLICJNEIJF)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AF70", Offset = "0x6C19F70", VA = "0x186C1AF70")]
	public static CDHJMIFGAJE GMFJELEJPDN(this ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, int JJCEIJMGOAB, [Optional] GKGBLNKIPKH PBLICJNEIJF)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AC30", Offset = "0x6C19C30", VA = "0x186C1AC30")]
	public static CDHJMIFGAJE DJJGJGOMPKA(this ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, bool JJCEIJMGOAB, [Optional] GKGBLNKIPKH PBLICJNEIJF)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B2E0", Offset = "0x6C1A2E0", VA = "0x186C1B2E0")]
	public static CDHJMIFGAJE LFEJLOHEMEJ(this ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, float JJCEIJMGOAB, [Optional] GKGBLNKIPKH PBLICJNEIJF)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AD80", Offset = "0x6C19D80", VA = "0x186C1AD80")]
	public static CDHJMIFGAJE EFDFMGGFDGL(this ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, DateTime JJCEIJMGOAB, [Optional] GKGBLNKIPKH PBLICJNEIJF)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B1A0", Offset = "0x6C1A1A0", VA = "0x186C1B1A0")]
	public static CDHJMIFGAJE IMFMGGDEIFC(this ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, long JJCEIJMGOAB, [Optional] GKGBLNKIPKH PBLICJNEIJF)
	{
		return default(CDHJMIFGAJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KAIOIDIFENH : FPNDDJLPIEF, ENPFGEFHANH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly POPCJNCPHJO CGMFAANHCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> NCLOCIBGLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> KMCODFKCCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> EINENAGBJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C16020", Offset = "0x6C15020", VA = "0x186C16020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action DBAFKPHMLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C16E10", Offset = "0x6C15E10", VA = "0x186C16E10")]
	[Preserve]
	public KAIOIDIFENH([JONIFKKOOAA(null)] POPCJNCPHJO CGMFAANHCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "8")]
	public void BEJIBGENNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C15CE0", Offset = "0x6C14CE0", VA = "0x186C15CE0")]
	private DirectoryInfo DALKLINHADH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C16860", Offset = "0x6C15860", VA = "0x186C16860", Slot = "6")]
	public Task LFJFGJKGOHM(long MIMMEPLPBEE, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C169A0", Offset = "0x6C159A0", VA = "0x186C169A0", Slot = "14")]
	public float OLCIBHFCCCK(string GMFCIHEFPPO, float KCDEJIJHLPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C15EE0", Offset = "0x6C14EE0", VA = "0x186C15EE0", Slot = "13")]
	public void EHIDFKFNCAC(string GMFCIHEFPPO, bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C15F50", Offset = "0x6C14F50", VA = "0x186C15F50", Slot = "12")]
	public bool EJGANMEBEAK(string GMFCIHEFPPO, bool KCDEJIJHLPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C16060", Offset = "0x6C15060", VA = "0x186C16060", Slot = "10")]
	public int GAAPCCBOLEG(string GMFCIHEFPPO, int KCDEJIJHLPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C167F0", Offset = "0x6C157F0", VA = "0x186C167F0", Slot = "18")]
	public DateTime KLOAKNFAGCJ(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C16DA0", Offset = "0x6C15DA0", VA = "0x186C16DA0", Slot = "19")]
	public void PFCCLOPBIDO(string GMFCIHEFPPO, DateTime JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C153C0", Offset = "0x6C143C0", VA = "0x186C153C0", Slot = "15")]
	public void CHGIHGOBHPP(string GMFCIHEFPPO, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C160D0", Offset = "0x6C150D0", VA = "0x186C160D0", Slot = "11")]
	public void GFJEOGELPGL(string GMFCIHEFPPO, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C163D0", Offset = "0x6C153D0", VA = "0x186C163D0", Slot = "20")]
	public long IFLGNEGJKOI(string BGJCPPOHOEL, long KCDEJIJHLPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C16780", Offset = "0x6C15780", VA = "0x186C16780", Slot = "21")]
	public void IHIGBPAFNNP(string BGJCPPOHOEL, long JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA88B0", Offset = "0x2BA78B0", VA = "0x182BA88B0", Slot = "22")]
	public T BBPJJDPKLAE<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA88B0", Offset = "0x2BA78B0", VA = "0x182BA88B0", Slot = "23")]
	public void BOHIOJMDEIB<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C168F0", Offset = "0x6C158F0", VA = "0x186C168F0", Slot = "16")]
	public string OBIFGHCIBHP(string GMFCIHEFPPO, string KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C15350", Offset = "0x6C14350", VA = "0x186C15350", Slot = "17")]
	public void BGEBKLFKIOM(string GMFCIHEFPPO, string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C15430", Offset = "0x6C14430", VA = "0x186C15430", Slot = "24")]
	public void CPLBNNGHCFO(string GMFCIHEFPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C16340", Offset = "0x6C15340", VA = "0x186C16340", Slot = "9")]
	public bool HMPNAMFJIOD(string GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C16440", Offset = "0x6C15440", VA = "0x186C16440", Slot = "25")]
	public Task IHDBJEPNCOO(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C16A10", Offset = "0x6C15A10", VA = "0x186C16A10")]
	private void OLJJDKJEGPI(DirectoryInfo NKKGNJNJCDI, string ACNFMMFDJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C16140", Offset = "0x6C15140", VA = "0x186C16140")]
	private static string HIAINGLINAJ(string GMFCIHEFPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C15DE0", Offset = "0x6C14DE0", VA = "0x186C15DE0")]
	private static string EANOGEDPLCH(byte[] KABOAHAAMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C5E9A0", Offset = "0x2C5D9A0", VA = "0x182C5E9A0")]
	private T MKHPGHPCCLG<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, [Optional] CDAJDHIMEPD<T> ONJKGJJDEDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D6D0", Offset = "0x2C5C6D0", VA = "0x182C5D6D0")]
	private void HACKMLKKHNE<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, [Optional] CDAJDHIMEPD<T> ONJKGJJDEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C154F0", Offset = "0x6C144F0", VA = "0x186C154F0")]
	private Dictionary<string, string> DAHNMIOKBNH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class NKKMIBKCLCL
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A980", Offset = "0x6C19980", VA = "0x186C1A980")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	private static void BJONJIDIGGM(NDJGECDCBMH MMBLPJPOBHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NANBFJOKELC : HGEAALLBMLK
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C14D90", Offset = "0x6C13D90", VA = "0x186C14D90")]
	[Preserve]
	public NANBFJOKELC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HGEAALLBMLK : FPNDDJLPIEF, ENPFGEFHANH, NHFKBBGKJJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> FFCOEAPLANB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DBAFKPHMLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "8")]
	public void BEJIBGENNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C14BE0", Offset = "0x6C13BE0", VA = "0x186C14BE0", Slot = "6")]
	public Task LFJFGJKGOHM(long MIMMEPLPBEE, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C149D0", Offset = "0x6C139D0", VA = "0x186C149D0", Slot = "9")]
	public bool HMPNAMFJIOD(string BGJCPPOHOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C14910", Offset = "0x6C13910", VA = "0x186C14910", Slot = "10")]
	public int GAAPCCBOLEG(string BGJCPPOHOEL, int KCDEJIJHLPJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C14970", Offset = "0x6C13970", VA = "0x186C14970", Slot = "11")]
	public void GFJEOGELPGL(string BGJCPPOHOEL, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C148B0", Offset = "0x6C138B0", VA = "0x186C148B0", Slot = "12")]
	public bool EJGANMEBEAK(string BGJCPPOHOEL, bool KCDEJIJHLPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C14850", Offset = "0x6C13850", VA = "0x186C14850", Slot = "13")]
	public void EHIDFKFNCAC(string BGJCPPOHOEL, bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C14CD0", Offset = "0x6C13CD0", VA = "0x186C14CD0", Slot = "14")]
	public float OLCIBHFCCCK(string BGJCPPOHOEL, float KCDEJIJHLPJ = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C14790", Offset = "0x6C13790", VA = "0x186C14790", Slot = "15")]
	public void CHGIHGOBHPP(string BGJCPPOHOEL, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C14C70", Offset = "0x6C13C70", VA = "0x186C14C70", Slot = "16")]
	public string OBIFGHCIBHP(string BGJCPPOHOEL, [Optional] string KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C14730", Offset = "0x6C13730", VA = "0x186C14730", Slot = "17")]
	public void BGEBKLFKIOM(string BGJCPPOHOEL, string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C14B80", Offset = "0x6C13B80", VA = "0x186C14B80", Slot = "18")]
	public DateTime KLOAKNFAGCJ(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C14D30", Offset = "0x6C13D30", VA = "0x186C14D30", Slot = "19")]
	public void PFCCLOPBIDO(string BGJCPPOHOEL, DateTime JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C14A30", Offset = "0x6C13A30", VA = "0x186C14A30", Slot = "20")]
	public long IFLGNEGJKOI(string BGJCPPOHOEL, long KCDEJIJHLPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C14B20", Offset = "0x6C13B20", VA = "0x186C14B20", Slot = "21")]
	public void IHIGBPAFNNP(string BGJCPPOHOEL, long JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC39E0", Offset = "0x2BC29E0", VA = "0x182BC39E0", Slot = "22")]
	public T BBPJJDPKLAE<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3AF0", Offset = "0x2BC2AF0", VA = "0x182BC3AF0", Slot = "23")]
	public void BOHIOJMDEIB<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BC40C0", Offset = "0x2BC30C0", VA = "0x182BC40C0")]
	public T MKHPGHPCCLG<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3BD0", Offset = "0x2BC2BD0", VA = "0x182BC3BD0")]
	public void HACKMLKKHNE<T>(string BGJCPPOHOEL, T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C147F0", Offset = "0x6C137F0", VA = "0x186C147F0", Slot = "24")]
	public void CPLBNNGHCFO(string BGJCPPOHOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C14A90", Offset = "0x6C13A90", VA = "0x186C14A90", Slot = "25")]
	public Task IHDBJEPNCOO(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C14D90", Offset = "0x6C13D90", VA = "0x186C14D90")]
	public HGEAALLBMLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class DJIOCLOODJN<TParent> where TParent : ENPFGEFHANH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<DJIOCLOODJN<TParent>> FHPNJGOPNOD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5875AF0", Offset = "0x5874AF0", VA = "0x185875AF0")]
	protected DJIOCLOODJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void PKAGCAPLLKG();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void OCOECGEHLBI(string GMFCIHEFPPO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5875550", Offset = "0x5874550", VA = "0x185875550")]
	public static void CAOBGDONPKM(string GMFCIHEFPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5875790", Offset = "0x5874790", VA = "0x185875790")]
	public static void LBBBKLCJDPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LFNMLCCKLDC<TParent, TValue> : DJIOCLOODJN<TParent> where TParent : ENPFGEFHANH
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly LFNMLCCKLDC<TParent, TValue> OCOPOGJODOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> MEJOBCJGJBI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x42E7C50", Offset = "0x42E6C50", VA = "0x1842E7C50")]
	public bool HNEILIJEPGH(string GNKBMNIDCFJ, [Out] TValue MADGJLBABJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x42E7CB0", Offset = "0x42E6CB0", VA = "0x1842E7CB0")]
	public void IIIJPCPFNHK(string GNKBMNIDCFJ, TValue JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3E3B8A0", Offset = "0x3E3A8A0", VA = "0x183E3B8A0", Slot = "4")]
	protected override void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E3B850", Offset = "0x3E3A850", VA = "0x183E3B850", Slot = "5")]
	protected override void OCOECGEHLBI(string GNKBMNIDCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x42E7F50", Offset = "0x42E6F50", VA = "0x1842E7F50")]
	public LFNMLCCKLDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ENPFGEFHANH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEJIBGENNIC();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMPNAMFJIOD(string BGJCPPOHOEL);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GAAPCCBOLEG(string BGJCPPOHOEL, int KCDEJIJHLPJ = 0);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GFJEOGELPGL(string BGJCPPOHOEL, int JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EJGANMEBEAK(string BGJCPPOHOEL, bool KCDEJIJHLPJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHIDFKFNCAC(string BGJCPPOHOEL, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float OLCIBHFCCCK(string BGJCPPOHOEL, float KCDEJIJHLPJ = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHGIHGOBHPP(string BGJCPPOHOEL, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string OBIFGHCIBHP(string BGJCPPOHOEL, [Optional] string KCDEJIJHLPJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BGEBKLFKIOM(string BGJCPPOHOEL, string JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime KLOAKNFAGCJ(string BGJCPPOHOEL, [Optional] DateTime HILIJCPFBNH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PFCCLOPBIDO(string BGJCPPOHOEL, DateTime HILIJCPFBNH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long IFLGNEGJKOI(string BGJCPPOHOEL, long KCDEJIJHLPJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IHIGBPAFNNP(string BGJCPPOHOEL, long JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T BBPJJDPKLAE<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, CDAJDHIMEPD<T> HFKDGEOKEMH);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BOHIOJMDEIB<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, CDAJDHIMEPD<T> HFKDGEOKEMH);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CPLBNNGHCFO(string BGJCPPOHOEL);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task IHDBJEPNCOO([Optional] CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FPNDDJLPIEF : ENPFGEFHANH
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DBAFKPHMLGG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LFJFGJKGOHM(long MIMMEPLPBEE, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NHFKBBGKJJA : ENPFGEFHANH
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PMBNGIACNPC : FPNDDJLPIEF, ENPFGEFHANH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CDOLFLDIPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public PMBNGIACNPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C12ED0", Offset = "0x6C11ED0", VA = "0x186C12ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C13060", Offset = "0x6C12060", VA = "0x186C13060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EEBCFKCJDNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public PMBNGIACNPC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6C130C0", Offset = "0x6C120C0", VA = "0x186C130C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C133B0", Offset = "0x6C123B0", VA = "0x186C133B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FPNDDJLPIEF PNEONOLIEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly KAIOIDIFENH NCOJDNFGLIP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B9D0", Offset = "0x6C1A9D0", VA = "0x186C1B9D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DBAFKPHMLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C3B0", Offset = "0x6C1B3B0", VA = "0x186C1C3B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C5B0", Offset = "0x6C1B5B0", VA = "0x186C1C5B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C7F0", Offset = "0x6C1B7F0", VA = "0x186C1C7F0")]
	[Preserve]
	public PMBNGIACNPC([JONIFKKOOAA(null)] POPCJNCPHJO CGMFAANHCIE, [JONIFKKOOAA("Disk_Unity")] FPNDDJLPIEF PNEONOLIEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B780", Offset = "0x6C1A780", VA = "0x186C1B780", Slot = "8")]
	public void BEJIBGENNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BDF0", Offset = "0x6C1ADF0", VA = "0x186C1BDF0", Slot = "9")]
	public bool HMPNAMFJIOD(string BGJCPPOHOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BC30", Offset = "0x6C1AC30", VA = "0x186C1BC30", Slot = "10")]
	public int GAAPCCBOLEG(string BGJCPPOHOEL, int KCDEJIJHLPJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BD80", Offset = "0x6C1AD80", VA = "0x186C1BD80", Slot = "11")]
	public void GFJEOGELPGL(string BGJCPPOHOEL, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BAA0", Offset = "0x6C1AAA0", VA = "0x186C1BAA0", Slot = "12")]
	public bool EJGANMEBEAK(string BGJCPPOHOEL, bool KCDEJIJHLPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BA30", Offset = "0x6C1AA30", VA = "0x186C1BA30", Slot = "13")]
	public void EHIDFKFNCAC(string BGJCPPOHOEL, bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C620", Offset = "0x6C1B620", VA = "0x186C1C620", Slot = "14")]
	public float OLCIBHFCCCK(string BGJCPPOHOEL, float KCDEJIJHLPJ = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B850", Offset = "0x6C1A850", VA = "0x186C1B850", Slot = "15")]
	public void CHGIHGOBHPP(string BGJCPPOHOEL, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C410", Offset = "0x6C1B410", VA = "0x186C1C410", Slot = "16")]
	public string OBIFGHCIBHP(string BGJCPPOHOEL, [Optional] string KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B7E0", Offset = "0x6C1A7E0", VA = "0x186C1B7E0", Slot = "17")]
	public void BGEBKLFKIOM(string BGJCPPOHOEL, string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C140", Offset = "0x6C1B140", VA = "0x186C1C140", Slot = "18")]
	public DateTime KLOAKNFAGCJ(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C780", Offset = "0x6C1B780", VA = "0x186C1C780", Slot = "19")]
	public void PFCCLOPBIDO(string BGJCPPOHOEL, DateTime HILIJCPFBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BE80", Offset = "0x6C1AE80", VA = "0x186C1BE80", Slot = "20")]
	public long IFLGNEGJKOI(string BGJCPPOHOEL, long KCDEJIJHLPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C0D0", Offset = "0x6C1B0D0", VA = "0x186C1C0D0", Slot = "21")]
	public void IHIGBPAFNNP(string BGJCPPOHOEL, long JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2D7D090", Offset = "0x2D7C090", VA = "0x182D7D090", Slot = "22")]
	public T BBPJJDPKLAE<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2D7D800", Offset = "0x2D7C800", VA = "0x182D7D800", Slot = "23")]
	public void BOHIOJMDEIB<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B8C0", Offset = "0x6C1A8C0", VA = "0x186C1B8C0", Slot = "24")]
	public void CPLBNNGHCFO(string BGJCPPOHOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BFE0", Offset = "0x6C1AFE0", VA = "0x186C1BFE0", Slot = "25")]
	[AsyncStateMachine(typeof(CDOLFLDIPPN))]
	public Task IHDBJEPNCOO([Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C2A0", Offset = "0x6C1B2A0", VA = "0x186C1C2A0", Slot = "6")]
	[AsyncStateMachine(typeof(EEBCFKCJDNG))]
	public Task LFJFGJKGOHM(long MIMMEPLPBEE, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BDHCKHMHFKL : FPNDDJLPIEF, ENPFGEFHANH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EJMFFLKOEDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BDHCKHMHFKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C13410", Offset = "0x6C12410", VA = "0x186C13410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C137E0", Offset = "0x6C127E0", VA = "0x186C137E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LLJKCDELKMJ : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BDHCKHMHFKL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public LLJKCDELKMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C17160", Offset = "0x6C16160", VA = "0x186C17160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C171D0", Offset = "0x6C161D0", VA = "0x186C171D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly POPCJNCPHJO CGMFAANHCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool CFMDNHJEPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool JBPNJOEPKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MGMNJOKCKBN LGKKNNLAAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private HDBNHMIPDLF HFHGHJKHOML;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action DBAFKPHMLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C12DE0", Offset = "0x6C11DE0", VA = "0x186C12DE0")]
	[Preserve]
	public BDHCKHMHFKL([JONIFKKOOAA(null)] POPCJNCPHJO CGMFAANHCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "8")]
	public void BEJIBGENNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C12C80", Offset = "0x6C11C80", VA = "0x186C12C80", Slot = "6")]
	public Task LFJFGJKGOHM(long MIMMEPLPBEE, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x12F62C0", Offset = "0x12F52C0", VA = "0x1812F62C0")]
	private static int PGLPMFPFMDO(bool JJCEIJMGOAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C12870", Offset = "0x6C11870", VA = "0x186C12870", Slot = "9")]
	public bool HMPNAMFJIOD(string BGJCPPOHOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C12810", Offset = "0x6C11810", VA = "0x186C12810", Slot = "10")]
	public int GAAPCCBOLEG(string BGJCPPOHOEL, int KCDEJIJHLPJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C12840", Offset = "0x6C11840", VA = "0x186C12840", Slot = "11")]
	public void GFJEOGELPGL(string BGJCPPOHOEL, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C12750", Offset = "0x6C11750", VA = "0x186C12750", Slot = "12")]
	public bool EJGANMEBEAK(string BGJCPPOHOEL, bool KCDEJIJHLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C12720", Offset = "0x6C11720", VA = "0x186C12720", Slot = "13")]
	public void EHIDFKFNCAC(string BGJCPPOHOEL, bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C12D40", Offset = "0x6C11D40", VA = "0x186C12D40", Slot = "14")]
	public float OLCIBHFCCCK(string BGJCPPOHOEL, float KCDEJIJHLPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C12600", Offset = "0x6C11600", VA = "0x186C12600", Slot = "15")]
	public void CHGIHGOBHPP(string BGJCPPOHOEL, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C12C10", Offset = "0x6C11C10", VA = "0x186C12C10", Slot = "18")]
	public DateTime KLOAKNFAGCJ(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C12D70", Offset = "0x6C11D70", VA = "0x186C12D70", Slot = "19")]
	public void PFCCLOPBIDO(string BGJCPPOHOEL, DateTime HILIJCPFBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C129B0", Offset = "0x6C119B0", VA = "0x186C129B0", Slot = "20")]
	public long IFLGNEGJKOI(string BGJCPPOHOEL, long KCDEJIJHLPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C12B10", Offset = "0x6C11B10", VA = "0x186C12B10", Slot = "21")]
	public void IHIGBPAFNNP(string BGJCPPOHOEL, long JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2926370", Offset = "0x2925370", VA = "0x182926370", Slot = "22")]
	public T BBPJJDPKLAE<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2926370", Offset = "0x2925370", VA = "0x182926370", Slot = "23")]
	public void BOHIOJMDEIB<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2926DB0", Offset = "0x2925DB0", VA = "0x182926DB0")]
	private T PCIDPOHGKCH<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, [Optional] CDAJDHIMEPD<T> ONJKGJJDEDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2926660", Offset = "0x2925660", VA = "0x182926660")]
	private void GDKHCIILMMA<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, [Optional] CDAJDHIMEPD<T> ONJKGJJDEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C12D10", Offset = "0x6C11D10", VA = "0x186C12D10", Slot = "16")]
	public string OBIFGHCIBHP(string BGJCPPOHOEL, string KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C125D0", Offset = "0x6C115D0", VA = "0x186C125D0", Slot = "17")]
	public void BGEBKLFKIOM(string BGJCPPOHOEL, string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C127F0", Offset = "0x6C117F0", VA = "0x186C127F0")]
	private void FJAAFAJKDOK(string BGJCPPOHOEL, string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C12B80", Offset = "0x6C11B80", VA = "0x186C12B80")]
	private string JKHFDGIKIJJ(string BGJCPPOHOEL, string KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C12630", Offset = "0x6C11630", VA = "0x186C12630", Slot = "24")]
	public void CPLBNNGHCFO(string BGJCPPOHOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C12910", Offset = "0x6C11910", VA = "0x186C12910")]
	private string ICEIKPHEGLC(string GMFCIHEFPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6C12A20", Offset = "0x6C11A20", VA = "0x186C12A20", Slot = "25")]
	[AsyncStateMachine(typeof(EJMFFLKOEDC))]
	public Task IHDBJEPNCOO(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6C12890", Offset = "0x6C11890", VA = "0x186C12890")]
	[IteratorStateMachine(typeof(LLJKCDELKMJ))]
	private IEnumerator<FAKEPIEMOLB> HPLKLHALACH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C126C0", Offset = "0x6C116C0", VA = "0x186C126C0")]
	private void DOCDFHPJECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C12BA0", Offset = "0x6C11BA0", VA = "0x186C12BA0")]
	private void JMPIMIIKHBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C12780", Offset = "0x6C11780", VA = "0x186C12780")]
	private void FCBMBEABELP(bool BINMFMMBPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FJHLOABGGIF : FPNDDJLPIEF, ENPFGEFHANH
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
	private Dictionary<string, string> KMCODFKCCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string NEPLNENCDMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C13F30", Offset = "0x6C12F30", VA = "0x186C13F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> EINENAGBJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6C13FA0", Offset = "0x6C12FA0", VA = "0x186C13FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DBAFKPHMLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	[Preserve]
	public FJHLOABGGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "8")]
	public void BEJIBGENNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C14510", Offset = "0x6C13510", VA = "0x186C14510", Slot = "6")]
	public Task LFJFGJKGOHM(long MIMMEPLPBEE, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C14650", Offset = "0x6C13650", VA = "0x186C14650", Slot = "14")]
	public float OLCIBHFCCCK(string GMFCIHEFPPO, float KCDEJIJHLPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C13DF0", Offset = "0x6C12DF0", VA = "0x186C13DF0", Slot = "13")]
	public void EHIDFKFNCAC(string GMFCIHEFPPO, bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C13E60", Offset = "0x6C12E60", VA = "0x186C13E60", Slot = "12")]
	public bool EJGANMEBEAK(string GMFCIHEFPPO, bool KCDEJIJHLPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C13FE0", Offset = "0x6C12FE0", VA = "0x186C13FE0", Slot = "10")]
	public int GAAPCCBOLEG(string GMFCIHEFPPO, int KCDEJIJHLPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C144A0", Offset = "0x6C134A0", VA = "0x186C144A0", Slot = "18")]
	public DateTime KLOAKNFAGCJ(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C146C0", Offset = "0x6C136C0", VA = "0x186C146C0", Slot = "19")]
	public void PFCCLOPBIDO(string GMFCIHEFPPO, DateTime JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C139C0", Offset = "0x6C129C0", VA = "0x186C139C0", Slot = "15")]
	public void CHGIHGOBHPP(string GMFCIHEFPPO, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C14050", Offset = "0x6C13050", VA = "0x186C14050", Slot = "11")]
	public void GFJEOGELPGL(string GMFCIHEFPPO, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C14150", Offset = "0x6C13150", VA = "0x186C14150", Slot = "20")]
	public long IFLGNEGJKOI(string BGJCPPOHOEL, long KCDEJIJHLPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C14430", Offset = "0x6C13430", VA = "0x186C14430", Slot = "21")]
	public void IHIGBPAFNNP(string BGJCPPOHOEL, long JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2BA88B0", Offset = "0x2BA78B0", VA = "0x182BA88B0", Slot = "22")]
	public T BBPJJDPKLAE<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BA88B0", Offset = "0x2BA78B0", VA = "0x182BA88B0", Slot = "23")]
	public void BOHIOJMDEIB<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, CDAJDHIMEPD<T> HFKDGEOKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C145A0", Offset = "0x6C135A0", VA = "0x186C145A0", Slot = "16")]
	public string OBIFGHCIBHP(string GMFCIHEFPPO, string KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C13920", Offset = "0x6C12920", VA = "0x186C13920", Slot = "17")]
	public void BGEBKLFKIOM(string GMFCIHEFPPO, string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C13A30", Offset = "0x6C12A30", VA = "0x186C13A30", Slot = "24")]
	public void CPLBNNGHCFO(string GMFCIHEFPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6C140C0", Offset = "0x6C130C0", VA = "0x186C140C0", Slot = "9")]
	public bool HMPNAMFJIOD(string GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C141C0", Offset = "0x6C131C0", VA = "0x186C141C0", Slot = "25")]
	public Task IHDBJEPNCOO(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9AE0", Offset = "0x2BA8AE0", VA = "0x182BA9AE0")]
	private T MKHPGHPCCLG<T>(string BGJCPPOHOEL, T KCDEJIJHLPJ, [Optional] CDAJDHIMEPD<T> ONJKGJJDEDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8AB0", Offset = "0x2BA7AB0", VA = "0x182BA8AB0")]
	private void HACKMLKKHNE<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, [Optional] CDAJDHIMEPD<T> ONJKGJJDEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C13AF0", Offset = "0x6C12AF0", VA = "0x186C13AF0")]
	private Dictionary<string, string> DAHNMIOKBNH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LFDOIPPMKHF
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action DBAFKPHMLGG;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEJIBGENNIC();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BPJENKIMPLK(long MIMMEPLPBEE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FHHKLDNGBDF(KFBHAONGCND MIINKKIJBDI = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HDNHEHNMIBA(string BGJCPPOHOEL, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BJPHINPKLGA(string BGJCPPOHOEL, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string MLBLLMCCLGH(string BGJCPPOHOEL, [Optional] string KCDEJIJHLPJ, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CDHJMIFGAJE FGEIGPFAFCL(string BGJCPPOHOEL, string JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int MEKKKILOHNJ(string BGJCPPOHOEL, int KCDEJIJHLPJ = 0, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CDHJMIFGAJE PPMOHADGCOG(string BGJCPPOHOEL, int JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HDJDMHHMIJM(string BGJCPPOHOEL, bool KCDEJIJHLPJ, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CDHJMIFGAJE FBJMNMAOGFC(string BGJCPPOHOEL, bool JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float IIMFBCFIJLK(string BGJCPPOHOEL, float KCDEJIJHLPJ = 0f, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CDHJMIFGAJE KBAJFJOJIDG(string BGJCPPOHOEL, float JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime OPIHOOGOLOC(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CDHJMIFGAJE PPAIADOIPPA(string BGJCPPOHOEL, DateTime JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long HHHLIJPMLOF(string BGJCPPOHOEL, long KCDEJIJHLPJ = 0L, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CDHJMIFGAJE DOFIMBKCPCH(string BGJCPPOHOEL, long JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T OHHOFBMOMJP<T>(string BGJCPPOHOEL, [Optional] T KCDEJIJHLPJ, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	CDHJMIFGAJE IKJEMHOFFDC<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool AOAHOEALJJD(string BGJCPPOHOEL);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool CEAFOFDDBEH(string BGJCPPOHOEL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string IOCNPFGJDNF(string BGJCPPOHOEL, [Optional] string KCDEJIJHLPJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CDHJMIFGAJE CICKPOJBDPG(string BGJCPPOHOEL, string JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int JPFCHLPAFKB(string BGJCPPOHOEL, int KCDEJIJHLPJ = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CDHJMIFGAJE HOMBDLHFJCC(string BGJCPPOHOEL, int JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool ONONOBMBKCG(string BGJCPPOHOEL, bool KCDEJIJHLPJ);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CDHJMIFGAJE OMKCMNCMACN(string BGJCPPOHOEL, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float JBPNMMBFPNA(string BGJCPPOHOEL, float KCDEJIJHLPJ = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "30")]
	CDHJMIFGAJE AEHKGCHLJBI(string BGJCPPOHOEL, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime CBJGGEDIBJI(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "32")]
	CDHJMIFGAJE BJOEPDJLKFJ(string BGJCPPOHOEL, DateTime JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long ACKGCDKGJKO(string BGJCPPOHOEL, long KCDEJIJHLPJ = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "34")]
	CDHJMIFGAJE EPNFOCFGEMH(string BGJCPPOHOEL, long JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void OGBDPDABOFL<T>(CDAJDHIMEPD<T> HFKDGEOKEMH, [Optional] IEqualityComparer<T> PBGGGGHIKLD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JLIIIHGBEOH<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable EJJEILHIEPI();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FCBMPFLJNIJ(float GHCGFNCODKM);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task DOCDFHPJECH([Optional] CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum CDHJMIFGAJE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LOCLIGBMHPC : LFDOIPPMKHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class KIAOLHENDKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<KIAOLHENDKD> MMKPJGDLGFB;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6C16EB0", Offset = "0x6C15EB0", VA = "0x186C16EB0")]
		public static void LBBBKLCJDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void PKAGCAPLLKG();

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		protected KIAOLHENDKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class JABBIHAGCHP<T> : KIAOLHENDKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly JABBIHAGCHP<T> PNNELGGLBHA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CDAJDHIMEPD<T> GDCFGAOEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> BNCMOLKJKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool POOEFDNAGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x38794F0", Offset = "0x38784F0", VA = "0x1838794F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x40FB0A0", Offset = "0x40FA0A0", VA = "0x1840FB0A0")]
		private JABBIHAGCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x40FA9C0", Offset = "0x40F99C0", VA = "0x1840FA9C0")]
		public void GGLLICMBJNI(CDAJDHIMEPD<T> ONJKGJJDEDI, [Optional] IEqualityComparer<T> PBGGGGHIKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x40FAED0", Offset = "0x40F9ED0", VA = "0x1840FAED0", Slot = "4")]
		public override void PKAGCAPLLKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class EOKJFFCBEBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly LOCLIGBMHPC JEHJGGHNNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object CCGIFKHICJC;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6C13870", Offset = "0x6C12870", VA = "0x186C13870")]
		public EOKJFFCBEBE(LOCLIGBMHPC JEHJGGHNNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6C13840", Offset = "0x6C12840", VA = "0x186C13840", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct OGFDAIHGLNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LOCLIGBMHPC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6C1B430", Offset = "0x6C1A430", VA = "0x186C1B430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B720", Offset = "0x6C1A720", VA = "0x186C1B720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct NIOBIJHGFEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LOCLIGBMHPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ENPFGEFHANH backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A7F0", Offset = "0x6C197F0", VA = "0x186C1A7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct IAIIJKKEAOP : IAsyncStateMachine
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
		public LOCLIGBMHPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6C14E20", Offset = "0x6C13E20", VA = "0x186C14E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6C152F0", Offset = "0x6C142F0", VA = "0x186C152F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LFJCDDMKMMH : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LOCLIGBMHPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public LFJCDDMKMMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6C17080", Offset = "0x6C16080", VA = "0x186C17080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6C17110", Offset = "0x6C16110", VA = "0x186C17110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly FPNDDJLPIEF LLIBIFPIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly FPNDDJLPIEF NNFKPOKFJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NHFKBBGKJJA AHGFAIGEJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MGMNJOKCKBN LGKKNNLAAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OEBEMOFKONJ.GKGBLNKIPKH PBLICJNEIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MBGIGHPFJLL FJEPGEGMEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<ENPFGEFHANH> ADJANBHGKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task EODLGLHGICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> GDDFMIFDCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private HDBNHMIPDLF EINJHBPGEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object JODFDKPHAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object INIJMDHFMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long CBPGGKBLKJH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool AAMIPJFHJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6C187E0", Offset = "0x6C177E0", VA = "0x186C187E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource EEIEDCPAOGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8505F0", VA = "0x1808515F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8518B0", Offset = "0x8508B0", VA = "0x1808518B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action DBAFKPHMLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C19830", Offset = "0x6C18830", VA = "0x186C19830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C198F0", Offset = "0x6C188F0", VA = "0x186C198F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C18900", Offset = "0x6C17900", VA = "0x186C18900")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	private static void HDKCILMBALK(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6C19F80", Offset = "0x6C18F80", VA = "0x186C19F80")]
	[Preserve]
	public LOCLIGBMHPC([JONIFKKOOAA("Disk")] FPNDDJLPIEF LLIBIFPIHJH, [JONIFKKOOAA("Cloud")] FPNDDJLPIEF NNFKPOKFJKL, [JONIFKKOOAA(null)] NHFKBBGKJJA AHGFAIGEJMO, [JONIFKKOOAA(null)] MGMNJOKCKBN LGKKNNLAAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C17FA0", Offset = "0x6C16FA0", VA = "0x186C17FA0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6C18800", Offset = "0x6C17800", VA = "0x186C18800")]
	private void HBOOLFAPIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6C17610", Offset = "0x6C16610", VA = "0x186C17610", Slot = "6")]
	public void BEJIBGENNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C177E0", Offset = "0x6C167E0", VA = "0x186C177E0", Slot = "7")]
	public Task BPJENKIMPLK(long MIMMEPLPBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C173E0", Offset = "0x6C163E0", VA = "0x186C173E0")]
	[AsyncStateMachine(typeof(OGFDAIHGLNH))]
	private Task AEGPBKOLGCD(long MIMMEPLPBEE, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6C198D0", Offset = "0x6C188D0", VA = "0x186C198D0")]
	private void OBLMBADMLNI(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C195D0", Offset = "0x6C185D0", VA = "0x186C195D0")]
	private void LFOIBGNBGAF(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6C197D0", Offset = "0x6C187D0", VA = "0x186C197D0")]
	private string NIHIMIGPOGH(string IONGOHCHJJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C17A60", Offset = "0x6C16A60", VA = "0x186C17A60")]
	private void CNJGFEFPHHD(KFBHAONGCND MIINKKIJBDI, string GMFCIHEFPPO, [Out] FPNDDJLPIEF LLCIPEGJGCO, [Out] string PJIPOCBEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C18AB0", Offset = "0x6C17AB0", VA = "0x186C18AB0")]
	private FPNDDJLPIEF HLGLKCFNMGH(KFBHAONGCND MIINKKIJBDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C183F0", Offset = "0x6C173F0", VA = "0x186C183F0", Slot = "8")]
	public bool FHHKLDNGBDF(KFBHAONGCND MIINKKIJBDI = KFBHAONGCND.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C18970", Offset = "0x6C17970", VA = "0x186C18970", Slot = "9")]
	public bool HDNHEHNMIBA(string BGJCPPOHOEL, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C176B0", Offset = "0x6C166B0", VA = "0x186C176B0", Slot = "10")]
	public bool BJPHINPKLGA(string BGJCPPOHOEL, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C19700", Offset = "0x6C18700", VA = "0x186C19700", Slot = "11")]
	public string MLBLLMCCLGH(string BGJCPPOHOEL, [Optional] string KCDEJIJHLPJ, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C18270", Offset = "0x6C17270", VA = "0x186C18270", Slot = "12")]
	public CDHJMIFGAJE FGEIGPFAFCL(string BGJCPPOHOEL, string JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C19650", Offset = "0x6C18650", VA = "0x186C19650", Slot = "13")]
	public int MEKKKILOHNJ(string BGJCPPOHOEL, int KCDEJIJHLPJ = 0, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C19E10", Offset = "0x6C18E10", VA = "0x186C19E10", Slot = "14")]
	public CDHJMIFGAJE PPMOHADGCOG(string BGJCPPOHOEL, int JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C18850", Offset = "0x6C17850", VA = "0x186C18850", Slot = "15")]
	public bool HDJDMHHMIJM(string BGJCPPOHOEL, bool KCDEJIJHLPJ, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6C180F0", Offset = "0x6C170F0", VA = "0x186C180F0", Slot = "16")]
	public CDHJMIFGAJE FBJMNMAOGFC(string BGJCPPOHOEL, bool JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6C18E90", Offset = "0x6C17E90", VA = "0x186C18E90", Slot = "17")]
	public float IIMFBCFIJLK(string BGJCPPOHOEL, float KCDEJIJHLPJ = 0f, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6C19450", Offset = "0x6C18450", VA = "0x186C19450", Slot = "18")]
	public CDHJMIFGAJE KBAJFJOJIDG(string BGJCPPOHOEL, float JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6C19B70", Offset = "0x6C18B70", VA = "0x186C19B70", Slot = "19")]
	public DateTime OPIHOOGOLOC(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6C19C10", Offset = "0x6C18C10", VA = "0x186C19C10", Slot = "20")]
	public CDHJMIFGAJE PPAIADOIPPA(string BGJCPPOHOEL, DateTime JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6C18A10", Offset = "0x6C17A10", VA = "0x186C18A10", Slot = "21")]
	public long HHHLIJPMLOF(string BGJCPPOHOEL, long KCDEJIJHLPJ = 0L, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C17E30", Offset = "0x6C16E30", VA = "0x186C17E30", Slot = "22")]
	public CDHJMIFGAJE DOFIMBKCPCH(string BGJCPPOHOEL, long JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2C81F50", Offset = "0x2C80F50", VA = "0x182C81F50", Slot = "23")]
	public T OHHOFBMOMJP<T>(string BGJCPPOHOEL, [Optional] T KCDEJIJHLPJ, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2C81F50", Offset = "0x2C80F50", VA = "0x182C81F50", Slot = "24")]
	public CDHJMIFGAJE IKJEMHOFFDC<T>(string BGJCPPOHOEL, T JJCEIJMGOAB, KFBHAONGCND CBOAFNAFGBD = KFBHAONGCND.CLOUD)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C175B0", Offset = "0x6C165B0", VA = "0x186C175B0", Slot = "25")]
	public bool AOAHOEALJJD(string BGJCPPOHOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C17A20", Offset = "0x6C16A20", VA = "0x186C17A20", Slot = "26")]
	public bool CEAFOFDDBEH(string BGJCPPOHOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C19080", Offset = "0x6C18080", VA = "0x186C19080", Slot = "27")]
	public string IOCNPFGJDNF(string BGJCPPOHOEL, [Optional] string KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C17A30", Offset = "0x6C16A30", VA = "0x186C17A30", Slot = "28")]
	public CDHJMIFGAJE CICKPOJBDPG(string BGJCPPOHOEL, string JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6C193E0", Offset = "0x6C183E0", VA = "0x186C193E0", Slot = "29")]
	public int JPFCHLPAFKB(string BGJCPPOHOEL, int KCDEJIJHLPJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C18C20", Offset = "0x6C17C20", VA = "0x186C18C20", Slot = "30")]
	public CDHJMIFGAJE HOMBDLHFJCC(string BGJCPPOHOEL, int JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6C199C0", Offset = "0x6C189C0", VA = "0x186C199C0", Slot = "31")]
	public bool ONONOBMBKCG(string BGJCPPOHOEL, bool KCDEJIJHLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6C19990", Offset = "0x6C18990", VA = "0x186C19990", Slot = "32")]
	public CDHJMIFGAJE OMKCMNCMACN(string BGJCPPOHOEL, bool JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6C190F0", Offset = "0x6C180F0", VA = "0x186C190F0", Slot = "33")]
	public float JBPNMMBFPNA(string BGJCPPOHOEL, float KCDEJIJHLPJ = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6C174F0", Offset = "0x6C164F0", VA = "0x186C174F0", Slot = "34")]
	public CDHJMIFGAJE AEHKGCHLJBI(string BGJCPPOHOEL, float JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6C179B0", Offset = "0x6C169B0", VA = "0x186C179B0", Slot = "35")]
	public DateTime CBJGGEDIBJI(string BGJCPPOHOEL, [Optional] DateTime KCDEJIJHLPJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6C17680", Offset = "0x6C16680", VA = "0x186C17680", Slot = "36")]
	public CDHJMIFGAJE BJOEPDJLKFJ(string BGJCPPOHOEL, DateTime JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C17370", Offset = "0x6C16370", VA = "0x186C17370", Slot = "37")]
	public long ACKGCDKGJKO(string BGJCPPOHOEL, long KCDEJIJHLPJ = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C180C0", Offset = "0x6C170C0", VA = "0x186C180C0", Slot = "38")]
	public CDHJMIFGAJE EPNFOCFGEMH(string BGJCPPOHOEL, long JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C19DB0", Offset = "0x6C18DB0", VA = "0x186C19DB0")]
	private bool PPIHJBKJEFP(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C18B30", Offset = "0x6C17B30", VA = "0x186C18B30")]
	private bool HNCPPIAPIDM(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C17220", Offset = "0x6C16220", VA = "0x186C17220")]
	private CDHJMIFGAJE ABONILHDLED(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, string JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C18F40", Offset = "0x6C17F40", VA = "0x186C18F40")]
	private CDHJMIFGAJE INHJAKOAPKB(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, int JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C19A30", Offset = "0x6C18A30", VA = "0x186C19A30")]
	private CDHJMIFGAJE OPBBPCJKMBG(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, bool JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C18690", Offset = "0x6C17690", VA = "0x186C18690")]
	private CDHJMIFGAJE GFMBOBOJBJC(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, float JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C18D20", Offset = "0x6C17D20", VA = "0x186C18D20")]
	private CDHJMIFGAJE IIHDEBPCPBN(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, DateTime JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6C17C00", Offset = "0x6C16C00", VA = "0x186C17C00")]
	private CDHJMIFGAJE DHOJGJIDKPK(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, long JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2C82120", Offset = "0x2C81120", VA = "0x182C82120")]
	private T JGHANBGCMJK<T>(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, T KCDEJIJHLPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2C82700", Offset = "0x2C81700", VA = "0x182C82700")]
	private CDHJMIFGAJE KKHFCOMNDGJ<T>(ENPFGEFHANH LLCIPEGJGCO, string BGJCPPOHOEL, T JJCEIJMGOAB)
	{
		return default(CDHJMIFGAJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2C83290", Offset = "0x2C82290", VA = "0x182C83290", Slot = "39")]
	public void OGBDPDABOFL<T>(CDAJDHIMEPD<T> HFKDGEOKEMH, [Optional] IEqualityComparer<T> PBGGGGHIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2C82680", Offset = "0x2C81680", VA = "0x182C82680", Slot = "40")]
	public void JLIIIHGBEOH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C18C50", Offset = "0x6C17C50", VA = "0x186C18C50")]
	[AsyncStateMachine(typeof(NIOBIJHGFEI))]
	private void IHDBJEPNCOO(ENPFGEFHANH NBHBBOLCBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C17D40", Offset = "0x6C16D40", VA = "0x186C17D40", Slot = "43")]
	[AsyncStateMachine(typeof(IAIIJKKEAOP))]
	public Task DOCDFHPJECH([Optional] CancellationToken DJIBMMAIGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C184B0", Offset = "0x6C174B0", VA = "0x186C184B0")]
	private void GBKJJCCCCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C17FE0", Offset = "0x6C16FE0", VA = "0x186C17FE0", Slot = "41")]
	public IDisposable EJJEILHIEPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C18260", Offset = "0x6C17260", VA = "0x186C18260", Slot = "42")]
	public void FCBMPFLJNIJ(float GHCGFNCODKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6C19160", Offset = "0x6C18160", VA = "0x186C19160")]
	private void JHDJKLOPJCI(float PFBNNKNPALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6C17520", Offset = "0x6C16520", VA = "0x186C17520")]
	[IteratorStateMachine(typeof(LFJCDDMKMMH))]
	private IEnumerator<FAKEPIEMOLB> ANMGJPMKKHM(float GHCGFNCODKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C197A0", Offset = "0x6C187A0", VA = "0x186C197A0")]
	[CompilerGenerated]
	private void NBCJGLBKHFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MGCLBMMBHNF : IFCEPHANOKM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static MGCLBMMBHNF PNNELGGLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A350", Offset = "0x6C19350", VA = "0x186C1A350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A620", Offset = "0x6C19620", VA = "0x186C1A620", Slot = "9")]
	public override string JMNIMAIKKED(bool MIFEONEPPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A3A0", Offset = "0x6C193A0", VA = "0x186C1A3A0", Slot = "10")]
	protected override bool IAPOMJCJIPP(string MIFEONEPPKP, [Out] bool JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A7B0", Offset = "0x6C197B0", VA = "0x186C1A7B0")]
	public MGCLBMMBHNF()
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
