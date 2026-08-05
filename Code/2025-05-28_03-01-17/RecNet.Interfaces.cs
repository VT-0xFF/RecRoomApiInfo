using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72B9160", Offset = "0x72B7F60", VA = "0x1872B9160")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CFGDEKGIHBB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum ONAAIOOLNOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string OJFAJIAFCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string LADHEFEPKCA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ONAAIOOLNOC FEEAIEDJDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(ONAAIOOLNOC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JEKHBECNEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x209F5B0", Offset = "0x209E3B0", VA = "0x18209F5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CNFNIMFLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1787040", Offset = "0x1785E40", VA = "0x181787040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72B2520", Offset = "0x72B1320", VA = "0x1872B2520")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static CFGDEKGIHBB LGKACBKCCFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72B2580", Offset = "0x72B1380", VA = "0x1872B2580")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static CFGDEKGIHBB PBLFCHFNKLM([Optional] string PLHNAAGFEIK, [Optional] string FFFKPDADHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CFGDEKGIHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OPBMCPPAMED
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string BNMJOLDIMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string KLJLBLKKEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PLKFFEGLFHD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BJCHAHBBDOF? IPMHCNJEJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IMAAKJGDPMH<CODPEOEOKGF> GDHCIGOKEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IMAAKJGDPMH<MOHJGEPGKJL> INMLNNAAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEEJLGGNEJD();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<PPMNBPGEJIK> CAPPEABDMNP(bool MGGFAMIINNJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HIJHBPMDPJG> AHNKJGBPCLJ(bool EEGIGPEPDIG = false, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<KGGPBHHFBAE> CNCNFMMMNOL([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<PPMNBPGEJIK> PAAHNHADKAK(bool EEGIGPEPDIG = false, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<PPMNBPGEJIK> FKOBPIHCICA([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<OPBMCPPAMED> NGNJPALMIIN(string NKOHJLKNDPG, string KBLGHHGFDJN, string LGDEHLKNJHN, string? BIOKICLCOOE, float FEMLEGIONNB, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<PPMNBPGEJIK> BONHAGFCDNK(long KEIIDMOKGJE, decimal BCHCAIDNCKF, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task NPBNONEMJFI(string BBAEOJCMCPP, string FPHCMDLADLF, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task LFGMEIHKCIA(long FKEKPMLCHOF, string FPHCMDLADLF, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<string> LOIIPFBJOAB(long FKEKPMLCHOF, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<BPIJLHOAFLK> NJJPDFMLIJP(string NKOHJLKNDPG, string NIKLDCKGLMB, bool NCIDCOMPFKO, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<BJCHAHBBDOF?>? ANBJAMBOPOC(string NIKLDCKGLMB, BKADGBHGPFO? CGNHBIBNIBM, string? DALNGNOKHLL, bool AJIHFACFKGL, FNKMNMEGPGP EKMDFFAGMPN, [Optional] string? LNJOAFGAIOK, [Optional] string? EDGMNHOLOOJ, [Optional] string? HNLGDOMFFCJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<BJCHAHBBDOF> CKOPNELCKKO(string OICKECDHHGJ, BKADGBHGPFO? CGNHBIBNIBM, bool AJIHFACFKGL, FNKMNMEGPGP EKMDFFAGMPN, [Optional] string? EDGMNHOLOOJ, [Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KGCHCMFNGJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string GKDIEDHDDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string DCGKODEGAAN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string DLCGJKIHFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string OHPEMHBCBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string MGFOCHNBPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string CAJLALKEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int? LDKOHELLCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int? PHCNDOGGBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72B84D0", Offset = "0x72B72D0", VA = "0x1872B84D0")]
	public KGCHCMFNGJO(string DMANPKBDKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72B83A0", Offset = "0x72B71A0", VA = "0x1872B83A0")]
	public void IBOOEKOMDCN(string LFBLBEBFMAH = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72B83D0", Offset = "0x72B71D0", VA = "0x1872B83D0")]
	private void NNHGELDEJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NEIDDPCBCDB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	ENLBBEJIIBF LKNEDABHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MBEACPKIJMJ> NIPOHGKLMON;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EKIMHDMABPL> JFCMOOIJOFL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EKIMHDMABPL> DPMMBGPKCIE(bool KFIIBFPEOPB = false, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HGMCMMOKJNC([Out] EKIMHDMABPL CHDBGLADHAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KEHEGLKOBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72B82B0", Offset = "0x72B70B0", VA = "0x1872B82B0")]
	public static bool PNDJJHGOACO(this NEIDDPCBCDB IKBMLOLEHGD, [Out] MBEACPKIJMJ GPDEOPOCKPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x72B81C0", Offset = "0x72B6FC0", VA = "0x1872B81C0")]
	public static bool CFAMCAKHDNL(this NEIDDPCBCDB IKBMLOLEHGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GKPLDEJIIOH
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CDMOLGIFKLC(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NAPEOIPDLAJ(int PBLPDOAFLFJ, [Out] INBCDGHKCII? EKMDFFAGMPN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface INBCDGHKCII
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int KCOONFNMDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string? KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string? OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool? NLFGNHAGHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? PCDJPKOCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string? IPKOHANJMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LJDECFEDNFI? CCLNNLAGBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GKOEHDCLLPK(string AOEAACDOEJC, [Out] BOCHFLCNMCI? EKMDFFAGMPN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BOCHFLCNMCI
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? MOBOLHLCBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string? HLFEJLMDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? KFGIJMNCDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IReadOnlyList<BDPIEGKJPNM>? ELCEDMOEFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LJDECFEDNFI? CCLNNLAGBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	long? EGFMHEAKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BDPIEGKJPNM
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string HLFEJLMDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	BBGAOGHMFAA OGCPLEOBMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LJDECFEDNFI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string HLFEJLMDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string? JCGGHFDHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[IGNMLPIHKKI]
public class KKIOKICAJOO
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public List<INHLCIIIOBE> AMDPEHOBOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Dictionary<string, string> FPMHDHOMBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72B89C0", Offset = "0x72B77C0", VA = "0x1872B89C0")]
	public KKIOKICAJOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[IGNMLPIHKKI]
public class INHLCIIIOBE
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int KCOONFNMDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string PCDJPKOCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string IPKOHANJMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool? NLFGNHAGHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xD52150", Offset = "0xD50F50", VA = "0x180D52150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD52160", Offset = "0xD50F60", VA = "0x180D52160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public DLKMLCAKKMG CCLNNLAGBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Dictionary<string, GIMFEFJCEFJ> GLEHBGNJGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x72B7360", Offset = "0x72B6160", VA = "0x1872B7360")]
	public INHLCIIIOBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[IGNMLPIHKKI]
public class DLKMLCAKKMG
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string HLFEJLMDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string JCGGHFDHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public DLKMLCAKKMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IGNMLPIHKKI]
public class GIMFEFJCEFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string MOBOLHLCBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string HLFEJLMDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string KFGIJMNCDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public List<OPAHFBGKOPD> ELCEDMOEFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public DLKMLCAKKMG CCLNNLAGBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public long EGFMHEAKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA128F0", Offset = "0xA116F0", VA = "0x180A128F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72B5D10", Offset = "0x72B4B10", VA = "0x1872B5D10")]
	public GIMFEFJCEFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum BBGAOGHMFAA
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	DismissDialog,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	CloseWatch,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	GoToStore,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	GoToCreate,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	GoToDayPass,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	PositiveEvent,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NegativeEvent,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CancelEvent
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[IGNMLPIHKKI]
public class OPAHFBGKOPD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string HLFEJLMDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BBGAOGHMFAA OGCPLEOBMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(BBGAOGHMFAA);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OPAHFBGKOPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct ABNNODPNMJP : IEquatable<ABNNODPNMJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool KBOAGBNFJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime FFIEEDPKCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool EFBBFPDNDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly PAMJNKEHFFA? PJAEDOHDMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string PLIIGANAOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? BKJNHPCENDJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static ABNNODPNMJP BAMIFPNBJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x27C1900", Offset = "0x27C0700", VA = "0x1827C1900")]
		get
		{
			return default(ABNNODPNMJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72B0E10", Offset = "0x72AFC10", VA = "0x1872B0E10")]
	public ABNNODPNMJP(DateTime BBBBGCNPOGI, bool ODMFLACGILE, PAMJNKEHFFA? ALBEOCEICEN, string IGCBLBHFHCB, int? AIGAOLCDLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72B0C80", Offset = "0x72AFA80", VA = "0x1872B0C80")]
	public MBEACPKIJMJ OEMGOJDFKOH(ENLBBEJIIBF PBJHCMBFABM)
	{
		return default(MBEACPKIJMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72B0C00", Offset = "0x72AFA00", VA = "0x1872B0C00")]
	private static MBEACPKIJMJ JOHBKLFDOAO(ENLBBEJIIBF PBJHCMBFABM, DateTime BBBBGCNPOGI)
	{
		return default(MBEACPKIJMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72B09B0", Offset = "0x72AF7B0", VA = "0x1872B09B0", Slot = "4")]
	public bool Equals(ABNNODPNMJP HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72B0900", Offset = "0x72AF700", VA = "0x1872B0900", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72B0B10", Offset = "0x72AF910", VA = "0x1872B0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72B0D10", Offset = "0x72AFB10", VA = "0x1872B0D10")]
	public static bool PBEBFPKJKLO(ABNNODPNMJP EFOOGHNHGNH, ABNNODPNMJP IFJAPBHAPEE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72B0BC0", Offset = "0x72AF9C0", VA = "0x1872B0BC0")]
	public static bool INFPGDPCEAI(ABNNODPNMJP EFOOGHNHGNH, ABNNODPNMJP IFJAPBHAPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x72B0D40", Offset = "0x72AFB40", VA = "0x1872B0D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct EKIMHDMABPL : IEquatable<EKIMHDMABPL>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly EKIMHDMABPL BAMIFPNBJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool JOCIPIGBAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly MBEACPKIJMJ DPIMADOHCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly ABNNODPNMJP BCCIGIJFNNM;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x72B5150", Offset = "0x72B3F50", VA = "0x1872B5150")]
	public EKIMHDMABPL(MBEACPKIJMJ GPDEOPOCKPN, ABNNODPNMJP DNENBKPAOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x72B4CC0", Offset = "0x72B3AC0", VA = "0x1872B4CC0", Slot = "4")]
	public bool Equals(EKIMHDMABPL HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x72B4B90", Offset = "0x72B3990", VA = "0x1872B4B90", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72B4D70", Offset = "0x72B3B70", VA = "0x1872B4D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x72B4F50", Offset = "0x72B3D50", VA = "0x1872B4F50")]
	public static bool PBEBFPKJKLO(EKIMHDMABPL EFOOGHNHGNH, EKIMHDMABPL IFJAPBHAPEE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72B4E30", Offset = "0x72B3C30", VA = "0x1872B4E30")]
	public static bool INFPGDPCEAI(EKIMHDMABPL EFOOGHNHGNH, EKIMHDMABPL IFJAPBHAPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x72B5060", Offset = "0x72B3E60", VA = "0x1872B5060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum MBEACPKIJMJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OLJNMFHAPJL : ENLBBEJIIBF
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string ENILHMOGDJN = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch CCFCBJFAPPK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? HPPJBIALJEO;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly OLJNMFHAPJL BNOFOIBJLLE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static ENLBBEJIIBF ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x72B9630", Offset = "0x72B8430", VA = "0x1872B9630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	internal static OLJNMFHAPJL GKNGIODPDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x72B99F0", Offset = "0x72B87F0", VA = "0x1872B99F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static DateTimeOffset FACGHOKHLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72B9A40", Offset = "0x72B8840", VA = "0x1872B9A40")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static DateTime BDEMIKDMJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72B9960", Offset = "0x72B8760", VA = "0x1872B9960")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime KBKEPAMOAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72B98A0", Offset = "0x72B86A0", VA = "0x1872B98A0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTimeOffset JDJOBFNPOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72B9BA0", Offset = "0x72B89A0", VA = "0x1872B9BA0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	private OLJNMFHAPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x72B9680", Offset = "0x72B8480", VA = "0x1872B9680")]
	internal static void ADBHGCBFOBD(DateTime? BLEELLBNDHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum CMPCJACNOBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum IDFHDJOPKPO
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[IGNMLPIHKKI]
public class BADAFKCAGKI : ENEIBBPOIAJ, PAJCNFAEALM, OAAIBPONJHJ, LBLGPGHMOJK, DLAJPMFGOIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct OMONKNCNBDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public BADAFKCAGKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72B9CF0", Offset = "0x72B8AF0", VA = "0x1872B9CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x72BA0A0", Offset = "0x72B8EA0", VA = "0x1872BA0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static CABLHEBFPCF ILIOICAKPIH;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int MJNBAJCFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD88FB0", Offset = "0xD87DB0", VA = "0x180D88FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LBKDEAGGCAC IOJPJCMBNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA276F0", Offset = "0xA264F0", VA = "0x180A276F0", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(LBKDEAGGCAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x14D7010", Offset = "0x14D5E10", VA = "0x1814D7010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool ALPHHCHCNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xC3A4D0", Offset = "0xC392D0", VA = "0x180C3A4D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xD17420", Offset = "0xD16220", VA = "0x180D17420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool JJBLPNKHDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xDA1EE0", Offset = "0xDA0CE0", VA = "0x180DA1EE0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xDA1E40", Offset = "0xDA0C40", VA = "0x180DA1E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HBEOHJENAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1ED0DE0", Offset = "0x1ECFBE0", VA = "0x181ED0DE0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1ED0510", Offset = "0x1ECF310", VA = "0x181ED0510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int? IAHOIKJDAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72B1DA0", Offset = "0x72B0BA0", VA = "0x1872B1DA0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72B1AA0", Offset = "0x72B08A0", VA = "0x1872B1AA0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string CHJLODIDMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string PPOBELBCGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string JEONBCCPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xE8C0E0", Offset = "0xE8AEE0", VA = "0x180E8C0E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public DateTime LMHCPFIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xE8BD70", Offset = "0xE8AB70", VA = "0x180E8BD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public CMPCJACNOBJ PFEBEGJOMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xDDDD70", Offset = "0xDDCB70", VA = "0x180DDDD70", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(CMPCJACNOBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xEBF4D0", Offset = "0xEBE2D0", VA = "0x180EBF4D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string BDFLCGBNAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9C0", Offset = "0xA0C7C0", VA = "0x180A0D9C0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0D960", Offset = "0xA0C760", VA = "0x180A0D960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int CEHBDLOOONB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC72A90", Offset = "0xC71890", VA = "0x180C72A90", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC72D90", Offset = "0xC71B90", VA = "0x180C72D90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public IReadOnlyList<COKIEMIFCJB> DOCJCFFCFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xBFED10", Offset = "0xBFDB10", VA = "0x180BFED10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x135D320", Offset = "0x135C120", VA = "0x18135D320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IReadOnlyList<OABIJCHFMEN> IEJACBHHOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xBFED10", Offset = "0xBFDB10", VA = "0x180BFED10", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public EFEJJNPJICP KPJHKJFONNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA10", Offset = "0xA0C810", VA = "0x180A0DA10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0D930", Offset = "0xA0C730", VA = "0x180A0D930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public string CEBAKMNMDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72B1AB0", Offset = "0x72B08B0", VA = "0x1872B1AB0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public JPAKMCHALJJ GALKPGJPKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "24")]
		get
		{
			return default(JPAKMCHALJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string OCNPBLDHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x72B1AB0", Offset = "0x72B08B0", VA = "0x1872B1AB0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public string KPDIBFFPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool HAHMNKAHJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public NAHJKMGHOEN FHFICPPBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xFCC180", Offset = "0xFCAF80", VA = "0x180FCC180", Slot = "30")]
		get
		{
			return default(NAHJKMGHOEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string JKAANLEPEOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public NDBIOOABJBM? MDIHPCFBLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72B1D50", Offset = "0x72B0B50", VA = "0x1872B1D50", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public BGFFMOHEJKA GGBOGHLJKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "33")]
		get
		{
			return default(BGFFMOHEJKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool OIIGMGNFIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BADAFKCAGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0xFE3E80", Offset = "0xFE2C80", VA = "0x180FE3E80")]
	public BADAFKCAGKI([Optional] Guid FIBIOFOKNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x72B1BA0", Offset = "0x72B09A0", VA = "0x1872B1BA0", Slot = "35")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x72B1AD0", Offset = "0x72B08D0", VA = "0x1872B1AD0", Slot = "36")]
	[AsyncStateMachine(typeof(OMONKNCNBDE))]
	public Task GIBKODDCFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x72B1A30", Offset = "0x72B0830", VA = "0x1872B1A30")]
	public BADAFKCAGKI AHIDGMOAFFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[IGNMLPIHKKI]
public class KCGKIDDGLCB : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int? IAHOIKJDAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xEFDEC0", Offset = "0xEFCCC0", VA = "0x180EFDEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xEFDEF0", Offset = "0xEFCCF0", VA = "0x180EFDEF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public string CHJLODIDMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LBKDEAGGCAC IOJPJCMBNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
		[CompilerGenerated]
		get
		{
			return default(LBKDEAGGCAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xD88FB0", Offset = "0xD87DB0", VA = "0x180D88FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public CMPCJACNOBJ? PFEBEGJOMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F30", Offset = "0xCD4D30", VA = "0x180CD5F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F80", Offset = "0xCD4D80", VA = "0x180CD5F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KCGKIDDGLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[IGNMLPIHKKI]
public class AAMIABJMAFG : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int MJNBAJCFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int? IAHOIKJDAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xEFDE20", Offset = "0xEFCC20", VA = "0x180EFDE20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xF082F0", Offset = "0xF070F0", VA = "0x180F082F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string PPOBELBCGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public string CHJLODIDMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public AAMIABJMAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[IGNMLPIHKKI]
public class EIFHADIOOIM : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int? IAHOIKJDAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string CHJLODIDMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public EIFHADIOOIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct NJLBNFGLLMG
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int OEMICFHBAHP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int MAKLEBGFNPL;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int FKGNKGALAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int JDNPLPKGFCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x72B9060", Offset = "0x72B7E60", VA = "0x1872B9060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static NJLBNFGLLMG OOIHKAJEMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72B9010", Offset = "0x72B7E10", VA = "0x1872B9010")]
		get
		{
			return default(NJLBNFGLLMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x72B9100", Offset = "0x72B7F00", VA = "0x1872B9100")]
	public NJLBNFGLLMG(int JDPFJGEJMMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[IGNMLPIHKKI]
public class FLNIECNNBDB : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int MPCICGEILHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int? NDFEFDOBMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xEFDE20", Offset = "0xEFCC20", VA = "0x180EFDE20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xF082F0", Offset = "0xF070F0", VA = "0x180F082F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string? BGIMHHCKDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A60", Offset = "0x72B4860", VA = "0x1872B5A60")]
	public FLNIECNNBDB(int LNEMGKKPNAE, int? CMLNAGEKNLD, string? NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FLNIECNNBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[IGNMLPIHKKI]
public class CHKGHJAOPLD : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public PFMLKNHNKDO.KFJCLHFBOLB LNFOBHMLLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(PFMLKNHNKDO.KFJCLHFBOLB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string ANMDNIDGLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int? GPMMIKCJJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CHKGHJAOPLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OABIJCHFMEN
{
	[Cpp2IlInjected.Token(Token = "0x17000074")]
	long EIGHFOIHPBG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Guid JHILAODNCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string FMPEFBLFJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string KIGBAFCINFB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int BKHGFCJHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string LENAOBIIOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string APBLAKDBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string CHIHJNIGLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string INANMEFIMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int CEHBDLOOONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[IGNMLPIHKKI]
public class COKIEMIFCJB : OABIJCHFMEN, OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public long EIGHFOIHPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xDF46D0", Offset = "0xDF34D0", VA = "0x180DF46D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Guid JHILAODNCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x12E0300", Offset = "0x12DF100", VA = "0x1812E0300", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x12E0BD0", Offset = "0x12DF9D0", VA = "0x1812E0BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA128F0", Offset = "0xA116F0", VA = "0x180A128F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string FMPEFBLFJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public string KIGBAFCINFB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int BKHGFCJHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xD5AFA0", Offset = "0xD59DA0", VA = "0x180D5AFA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xEA6460", Offset = "0xEA5260", VA = "0x180EA6460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string LENAOBIIOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public string APBLAKDBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string CHIHJNIGLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFD0", Offset = "0xA0BDD0", VA = "0x180A0CFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string INANMEFIMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED20", Offset = "0xA0DB20", VA = "0x180A0ED20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int CEHBDLOOONB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xDDDD70", Offset = "0xDDCB70", VA = "0x180DDDD70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xEBF4D0", Offset = "0xEBE2D0", VA = "0x180EBF4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "15")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public COKIEMIFCJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum CIDFMLFHINB
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum EANGDPGIDDI
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GHOBMJBCOLJ
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72B5C80", Offset = "0x72B4A80", VA = "0x1872B5C80")]
	public static int? MEALIKFPINM(CIDFMLFHINB? IAKCJAHLOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72B5BF0", Offset = "0x72B49F0", VA = "0x1872B5BF0")]
	public static int? KOEEOGIEDPP(EANGDPGIDDI? LAGIDDIJNGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[IGNMLPIHKKI]
public class MPNBPHMFKNJ : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int? GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public LBKDEAGGCAC? IOJPJCMBNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECF0", Offset = "0xA0DAF0", VA = "0x180A0ECF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MPNBPHMFKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[IGNMLPIHKKI]
public class JLMAAIOIKHE : KDCOIBLMAFL, OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public byte HLMNABLPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JLMAAIOIKHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FOMDAJDHMNI
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x72B5B30", Offset = "0x72B4930", VA = "0x1872B5B30")]
	public static CKAAJMIKLMN EJDDEKBPEGP(this JLMAAIOIKHE FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ENEIBBPOIAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	int MJNBAJCFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	int GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	LBKDEAGGCAC IOJPJCMBNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	bool ALPHHCHCNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	bool JJBLPNKHDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool HBEOHJENAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int? IAHOIKJDAOC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	string CHJLODIDMJO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	string PPOBELBCGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string JEONBCCPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	DateTime LMHCPFIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	CMPCJACNOBJ PFEBEGJOMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string BDFLCGBNAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	int CEHBDLOOONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string CEBAKMNMDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x72B5180", Offset = "0x72B3F80", VA = "0x1872B5180", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DLAJPMFGOIF
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	IReadOnlyList<OABIJCHFMEN> IEJACBHHOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int MJNBAJCFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool HBEOHJENAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int CEHBDLOOONB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	int? IAHOIKJDAOC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	LBKDEAGGCAC IOJPJCMBNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class IHNDMONPFGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct AIAOPFBJGBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<LBLGPGHMOJK> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x72B1630", Offset = "0x72B0430", VA = "0x1872B1630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x72B18E0", Offset = "0x72B06E0", VA = "0x1872B18E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x72B6B80", Offset = "0x72B5980", VA = "0x1872B6B80")]
	public static bool AMGOFLKBJGL(this IEnumerable<OAAIBPONJHJ> COKPAJOONAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72B6DC0", Offset = "0x72B5BC0", VA = "0x1872B6DC0")]
	[AsyncStateMachine(typeof(AIAOPFBJGBG))]
	public static Task JBBDMOMDACI(this IEnumerable<LBLGPGHMOJK> COKPAJOONAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CKNMKLKMAFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly string IOHBNCAAHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly string PIJPBCNJOLM;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static readonly CKNMKLKMAFP LABFBGKEAKD;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
	public CKNMKLKMAFP(string DAMKDIMJAFC, string CHKEMFCNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xF1F100", Offset = "0xF1DF00", VA = "0x180F1F100")]
	public bool GOGCPGAMALL(CKNMKLKMAFP HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72B29B0", Offset = "0x72B17B0", VA = "0x1872B29B0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x72B2A80", Offset = "0x72B1880", VA = "0x1872B2A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x72B2B70", Offset = "0x72B1970", VA = "0x1872B2B70")]
	public static bool PBEBFPKJKLO(CKNMKLKMAFP EFOOGHNHGNH, CKNMKLKMAFP IFJAPBHAPEE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x72B2AF0", Offset = "0x72B18F0", VA = "0x1872B2AF0")]
	public static bool INFPGDPCEAI(CKNMKLKMAFP EFOOGHNHGNH, CKNMKLKMAFP IFJAPBHAPEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LDDGJEHKKJP
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	KGCHCMFNGJO JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string BLJDFFDGMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	string MCIPKBAPMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	long LMMAFAOJIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string NPLDGAAEOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string KPELOEDLBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string LJIAJODLPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string EJMPGHOMPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[IGNMLPIHKKI]
public class CEDCLGLFHJM : LKMNEHDJEKL
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string JHFPALKIJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public AEBGKBAIIOL GIMILBADPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(AEBGKBAIIOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public NFHABDMMJCB ELOHKNLACHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
		[CompilerGenerated]
		get
		{
			return default(NFHABDMMJCB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CGFEOKFFLON LMJCPKMJPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		[CompilerGenerated]
		get
		{
			return default(CGFEOKFFLON);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[DataMember(Name = "Header")]
	public string? FKGNMEELCPH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string? MOBOLHLCBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public string? EFDCAEFFEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public List<string> IMNGINCKOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public List<MEKENHAFLFN> ELCEDMOEFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x72B23D0", Offset = "0x72B11D0", VA = "0x1872B23D0", Slot = "5")]
	public override void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x72B23E0", Offset = "0x72B11E0", VA = "0x1872B23E0")]
	public CEDCLGLFHJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum PILOFENMIJK
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum AEBGKBAIIOL
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum NFHABDMMJCB
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum CGFEOKFFLON
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[IGNMLPIHKKI]
public class MEKENHAFLFN : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public PILOFENMIJK CEDBPPBEBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(PILOFENMIJK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public string? BAJHPGBIJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	[DataMember(Name = "LinkParameter")]
	public string? IPAPPMFECIH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? DHCALPFGDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MEKENHAFLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class LKMNEHDJEKL : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[IgnoreDataMember]
	public string? PHKOHPIIHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void HHDPONBNNOO();

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x72B8C40", Offset = "0x72B7A40", VA = "0x1872B8C40")]
	protected LKMNEHDJEKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[IGNMLPIHKKI]
public class GCPCIPJPELN : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? BFIKOHFPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GCPCIPJPELN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[IGNMLPIHKKI]
public class JBBNLOKLIAD : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	internal static Func<string, CEDCLGLFHJM>? HCFJGKJFIAF;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal static Func<string, EECLGKLOFPE>? FGLLDIOKGII;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string? BFIKOHFPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? JGDFGAMOHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool EIHOHIODLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public PAMJNKEHFFA IENDGNJHALA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
		[CompilerGenerated]
		get
		{
			return default(PAMJNKEHFFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public AJJFEMDAEDB FKBEBLLOELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		[CompilerGenerated]
		get
		{
			return default(AJJFEMDAEDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int JIMKPCCKHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xC910C0", Offset = "0xC8FEC0", VA = "0x180C910C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1415040", Offset = "0x1413E40", VA = "0x181415040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime MLOGICEOOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAE0", Offset = "0xA0D8E0", VA = "0x180A0EAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[DataMember(Name = "IsRead")]
	internal bool KLCNEDOPHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xDA8E40", Offset = "0xDA7C40", VA = "0x180DA8E40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xDA8E60", Offset = "0xDA7C60", VA = "0x180DA8E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	[IgnoreDataMember]
	public bool EKLKKGNMPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xDA8E50", Offset = "0xDA7C50", VA = "0x180DA8E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xDA8E70", Offset = "0xDA7C70", VA = "0x180DA8E70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public BGFOAAKGBCI CCBNHJOJPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA276F0", Offset = "0xA264F0", VA = "0x180A276F0")]
		[CompilerGenerated]
		get
		{
			return default(BGFOAAKGBCI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x14D7010", Offset = "0x14D5E10", VA = "0x1814D7010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public AHNIFALNBHM KOPJCKMLLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xC15DC0", Offset = "0xC14BC0", VA = "0x180C15DC0")]
		[CompilerGenerated]
		get
		{
			return default(AHNIFALNBHM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xE44A60", Offset = "0xE43860", VA = "0x180E44A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	internal string? OJGPGKLPLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	[IgnoreDataMember]
	public CEDCLGLFHJM? NOKCOFOJHID
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x72B7A30", Offset = "0x72B6830", VA = "0x1872B7A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	[IgnoreDataMember]
	public EECLGKLOFPE? CPIFGBLPKGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x72B7AB0", Offset = "0x72B68B0", VA = "0x1872B7AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public LKMNEHDJEKL? HHDIEEPMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x72B7700", Offset = "0x72B6500", VA = "0x1872B7700", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xA34300", Offset = "0xA33100", VA = "0x180A34300")]
	public JBBNLOKLIAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[IGNMLPIHKKI]
public class PDBCEHEKPPA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public MOLIJCKAKED ANFHNBLIMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(MOLIJCKAKED);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public string FMBFNHGBNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int CGMCGKBAHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x72BA2A0", Offset = "0x72B90A0", VA = "0x1872BA2A0")]
	public PDBCEHEKPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[IGNMLPIHKKI]
public class EECLGKLOFPE : LKMNEHDJEKL
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string HLFNKPBADEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public string? KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public HBIEKFLAKHC NHFNAEIGEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		[CompilerGenerated]
		get
		{
			return default(HBIEKFLAKHC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	[DataMember(Name = "all_conditions_required")]
	public bool DKBCOLAFDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x15EEC20", Offset = "0x15EDA20", VA = "0x1815EEC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xF52570", Offset = "0xF51370", VA = "0x180F52570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public List<PDBCEHEKPPA> DKIHAJPJCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x72B47F0", Offset = "0x72B35F0", VA = "0x1872B47F0", Slot = "5")]
	public override void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x72B4800", Offset = "0x72B3600", VA = "0x1872B4800")]
	public EECLGKLOFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum AHNIFALNBHM
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum BGFOAAKGBCI
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum HBIEKFLAKHC
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum MOLIJCKAKED
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	EnteredRoom = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	TimeInRoom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ObjectInteractionRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ObjectPlaceStartedRoom = 4
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OGHFLFEEBHG
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	bool GECMEKFAKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	IMAAKJGDPMH<JBBNLOKLIAD> HJANPKHBGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	IMAAKJGDPMH<string> JHBJAOHKKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	IMAAKJGDPMH<JBBNLOKLIAD> NJPDMMKJDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	IMAAKJGDPMH<JBBNLOKLIAD> HAHFHCONFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<JBBNLOKLIAD> JHPPAILKJJE(BGFOAAKGBCI ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<JBBNLOKLIAD> FNJAJBBBAPP(BGFOAAKGBCI ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBBNLOKLIAD IOKBAMGJNFC(BGFOAAKGBCI ONKHCNLCBAI, string IEHHHAACPDA);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JBBNLOKLIAD IGGHOPLBIOO(BGFOAAKGBCI ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CPPMIDLPMKK(BGFOAAKGBCI ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MHKCMAAKOPA(BGFOAAKGBCI ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task NHKKIIAGFEC();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task ANBNNKNANGO(JBBNLOKLIAD NJJDPBHNDPA);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CNLDFKCLFLK
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	GJNLEHACNGD MLKMPJBHKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	int DDKDNJEKJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool BHMOBCMDKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool LOAGOKFDPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool ANCNIJOLOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool JAPAJFPAACK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool GEIOFBJOKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool PILDLAIAEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool JNDNOEDGIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GDBGJKMFPGA;

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HMBEFKLHMDK<IDPAJCCDCOM> LNAMFBPNOCM(int OEBMJHLGKIE);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	AAFDGGPNGMA GAOPHNPBLDI(DateTime LBGNLOMJJHD);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AAFDGGPNGMA HFGNBGNIEMM(string OMJGEILIBAO);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task IGKEEKDMDFH([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum OEOKJOGDPJA
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EOCFNLKIFPH
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72B5240", Offset = "0x72B4040", VA = "0x1872B5240")]
	public static string COPPJHLNIFI(this OEOKJOGDPJA IFFKPBALCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface AKDMGLIMJEM
{
	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<JBBNLOKLIAD>> MKLPALIECHD(BGFOAAKGBCI ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ANBNNKNANGO(string IEHHHAACPDA);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface KAEOFIJKJKC
{
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ECHHDPDFEJC> IOELPHKEFHO();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface GHLNMLNMIGN
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HMBEFKLHMDK<List<DFNCDDNKLFM>> LKFCMBELDCG();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HMBEFKLHMDK<List<DFNCDDNKLFM>> FIMMOADNMNK();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<DFNCDDNKLFM>> MAALHECCKLG([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HMBEFKLHMDK<List<DFNCDDNKLFM>> KJHGPLICCCB(List<KJIKALIBABJ> FBPKHPHIGCN);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HMBEFKLHMDK<List<DFNCDDNKLFM>> MGIMLLCDLDP(List<KJIKALIBABJ> FBPKHPHIGCN);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface NIGONPEOPPE
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	List<CAJGGKMOJIB> NONHAMDINFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<LLEHDPMEANK> DFPDLLAGFGI;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AAFDGGPNGMA ECEDNKGIPPG(CAJGGKMOJIB NGCOADOFPJB);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	HMBEFKLHMDK<CAJGGKMOJIB> IGGLJPOHGLO(OGMKPJCJPIA JAPGNGDBBIF, OGMKPJCJPIA? FDIPBKCGHHN, bool BHAPDAPJOML, string NJJDPBHNDPA);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HMBEFKLHMDK<CAJGGKMOJIB> IGGLJPOHGLO(OGMKPJCJPIA JAPGNGDBBIF, string NJJDPBHNDPA);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANDDDLNIEPK(CAJGGKMOJIB EGDKPBFOBDC, bool AHHMKJMEBLA = false, bool BBMKOJLGIGK = false, bool NHPCLOCALGG = true);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HMBEFKLHMDK<List<CAJGGKMOJIB>> ANKIEPJKFKH();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface GPODIONABCE
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	string FIDGKIPFIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool JKHENPGGHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AAFDGGPNGMA LLICCOBLOPG();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AAFDGGPNGMA PEGNAFOKNJP(string LGBHNPLCJAG, string ICCJNKHPNPD);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAFDGGPNGMA HCDEEBIICKA(string PBDCLDADKIH);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OBBLJIBMOFD();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<ABOKHCLEKNN> CJPNHIKGGBG(string OMJGEILIBAO, string PBDCLDADKIH, bool DOKFIPOGMLL, string LAJCHBPPEAF, string HJMDNBAOKHN, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CCPCONJPPEG(int OEBMJHLGKIE, string JNJAJOAAJIH, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task PHHCPGGOFAA(int OEBMJHLGKIE, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task NKJGMNGPHAA([Optional] OEOKJOGDPJA? DEFPKAHCGBG, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<JKAEBBPJIOI>> IMJHGHCLMDA([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task OLCKHMGNLMG([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface AICLFAPECFP
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<HPNJIJLEHBO>> GFFNNKJDBCM([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<ODMAKJCCHDI>> PNOOJBGPLEB([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface POKHCIHAJLG
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HICFHHHGHFK([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAIHEAGEBBJ();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface IKKAELHLKHI
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FAFMPLJOOKC? FMNAOLLGEFF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event FAFMPLJOOKC? GHBPFMGGLFA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FAFMPLJOOKC? HPFNLADKDAP;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<BFNIAFOELEN> GJHIGLPFLJI();

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<BFNIAFOELEN?>? GBPECIHHKHP(int OEBMJHLGKIE);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<JKLOFIBFAIE>> KCOMFCGDKFJ(List<int> GKEFFKPGGEA);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, BFNIAFOELEN>> JCBKEJCNDOF();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<BFNIAFOELEN?>?>? IPCLDGCJELN(int OEBMJHLGKIE);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task NKGEIHDOAAD(int DNPDDCMEHGG);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<ONAJOACHAJH> PDGIMFHKIBG(BFNIAFOELEN EAGCCPCCAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void FAFMPLJOOKC(int OEBMJHLGKIE, int DNPDDCMEHGG, BFNIAFOELEN? EAGCCPCCAEL);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface CABLHEBFPCF : OOKEPPFFMHD, OJFIPNNEBDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Flags]
	public enum GCBHANGEHLO
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	string GFGDIDBFIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	HGNOHPJPPIO CJCOKKDCABI
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	PAMJNKEHFFA IENDGNJHALA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string PLIIGANAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	byte DMCONAEIFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	int GKFIOMBAKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	int GGOLIKNLICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	bool KIFDODIIAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	bool OAKMCCEJAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	bool FMNCOHHLEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	bool NCKOCBHLLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	bool JEHOMGENJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool OOLHKAMJJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool HGPBLDJPCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HMBEFKLHMDK<string> FHEGBOIEAHM();

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> IEIPMMECIAM();

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HMBEFKLHMDK<bool> IsPlayerCommunicationRestricted(int OEBMJHLGKIE);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string LDCLPMHOIEO(string IHGFMOMOADA, bool AKDKCGJFINI = true);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> MFDGHAMOOLL(string IHGFMOMOADA, bool AKDKCGJFINI = true);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	HMBEFKLHMDK<string> MakeRoomNameAdhereToPlatformRequirements(long CEACGIDOODJ, string IHGFMOMOADA);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string PMGHIOBDCDB, GCBHANGEHLO FGGJOEAFFHJ = GCBHANGEHLO.FilterProfanity | GCBHANGEHLO.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string PMGHIOBDCDB, GCBHANGEHLO FGGJOEAFFHJ = GCBHANGEHLO.FilterProfanity | GCBHANGEHLO.FilterURL, bool MMADILMAFBH = false);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string IHGFMOMOADA, GCBHANGEHLO FGGJOEAFFHJ = GCBHANGEHLO.FilterProfanity | GCBHANGEHLO.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "23")]
	HMBEFKLHMDK<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface HDECELDPDGA
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<CGAOBFHJANI>> ILNPOKKDHKN([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface FBDNBDIHMHO
{
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLLILEMFEOB(byte[] CHKEMFCNGMN, byte[] GHLJFOFMCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface KFDLHOKGLOG
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CIEJPDCKKCM(string CFOBIGDIECD);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MFDNAJBPFBK
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	IMAAKJGDPMH<ANIBMJIFONA> DKLGAHOLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> BFIKMILLPKI(string DJINGFJDDFE);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OHGPNNMHLKL> FCLDJDMONCG(string DJINGFJDDFE, string DHJIAEMPACN);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DAHLMAGCGNG(string DJINGFJDDFE, IEnumerable<string> JIMIKIEHNBM, int GJEGAGBEGDN = 0);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<AEMAHMMCBBC<FilteredTextDTO>>> LEOJKOKFGLO(uint PMMHIMPNHFA, IEnumerable<string> JIMIKIEHNBM);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface OADJDEIGOHE
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IBKEDJALBNE([Out] bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DICMHONMPFC([Out] bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCLHPLGCDDL([Out] int OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum DAJDFAGFOFC
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum OODLEGNPEIL
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[Flags]
public enum CAGCJAOAJKB
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Flags]
public enum CLKAMGMMBPG
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum PMMFAPDAKMM
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum CHFJAJENGHE
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface IDPAJCCDCOM
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	int OBGCOEMGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	string MPHONFHCMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	string HGOKPFHLCAP
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	string HNIKHJFMNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	string FIFNKMGKLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	string LGAPEAOCCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string AILKMHCJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	bool FPCJFJKPIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	bool EBODIIAFMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	CAGCJAOAJKB ECIMMGEHMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	CLKAMGMMBPG GPCKCHCPNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool? BEIHGDFEHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AIBOJAEBKBC(bool KCPCAGADFPF);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KMKCNOPOOEE(bool BJFJBELIAHE);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface GJNLEHACNGD : IDPAJCCDCOM
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	string EJJOEHKLEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	string DCMEGEPDMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	DateTime? INKECGKGMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	DAJDFAGFOFC PGKHHOBBIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	int? JDJNGDKOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	int LJGBHCOIMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool IOIOIBEMOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	bool PPJCBFGOHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	bool? MABMODELOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class AFDOGMNEEKH
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public IDPAJCCDCOM NHLMBNPNDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public OODLEGNPEIL CGDNJLMPFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(OODLEGNPEIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public string KDKHKPIDPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6C41DE0", Offset = "0x6C40BE0", VA = "0x186C41DE0")]
	public AFDOGMNEEKH(IDPAJCCDCOM LIFHNEIANMJ, OODLEGNPEIL FGOGLHJMBCE, string PGABMEDKCKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface HDBABDNFPBD
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int OBGCOEMGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	bool BIJHPGLOPKA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface OFBIGJELHBL
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	int OBGCOEMGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	bool MAAPAKFINBC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface JLFDJLJOAFL
{
	[Cpp2IlInjected.Token(Token = "0x17000117")]
	int OBGCOEMGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	string OMOOPJOCPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public enum NDBIOOABJBM
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class DFNCDDNKLFM
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public NDBIOOABJBM MDIHPCFBLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(NDBIOOABJBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public string KPDIBFFPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public string LAABGGGODLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public NAHJKMGHOEN FHFICPPBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		[CompilerGenerated]
		get
		{
			return default(NAHJKMGHOEN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public string IDJBFNPOFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public int HMKBGFIHHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xD88FB0", Offset = "0xD87DB0", VA = "0x180D88FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool EOLMCLNCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE52870", Offset = "0xE51670", VA = "0x180E52870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xE52140", Offset = "0xE50F40", VA = "0x180E52140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public KJIKALIBABJ EFPHJECAPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x12F5F40", Offset = "0x12F4D40", VA = "0x1812F5F40")]
		[CompilerGenerated]
		get
		{
			return default(KJIKALIBABJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x72B36B0", Offset = "0x72B24B0", VA = "0x1872B36B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public NJLPOIFALEJ CPBAILAFDII
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x19A75E0", Offset = "0x19A63E0", VA = "0x1819A75E0")]
		[CompilerGenerated]
		get
		{
			return default(NJLPOIFALEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4F93EA0", Offset = "0x4F92CA0", VA = "0x184F93EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string OPAAEHPKPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9C0", Offset = "0xA0C7C0", VA = "0x180A0D9C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA0D960", Offset = "0xA0C760", VA = "0x180A0D960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA0D980", Offset = "0xA0C780", VA = "0x180A0D980")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x46026A0", Offset = "0x46014A0", VA = "0x1846026A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x72B36D0", Offset = "0x72B24D0", VA = "0x1872B36D0")]
	internal DFNCDDNKLFM(GLOFJJLGBKJ ONICMANAHMG, AHAKLCHKBAC MNMLNIOGKCE, DDMMKMHMKPG AGJFMPEIFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x72B3930", Offset = "0x72B2730", VA = "0x1872B3930")]
	public DFNCDDNKLFM(NDBIOOABJBM IDMKPGLAPBJ = NDBIOOABJBM.Outfit, [Optional] KJIKALIBABJ DHGPABPLMLK, [Optional] string DCBGPPPDNMF, [Optional] string BGKGIIPFPBO, NAHJKMGHOEN DCOLCFHOOIN = NAHJKMGHOEN.Common, [Optional] string OPCNAJFMHBK, int MENEGNEOGDO = 0, bool GHFFNFPCIPN = false, [Optional] string OCGFKGDCJDN, [Optional] DateTime? KJBIJEAOBEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[IGNMLPIHKKI]
public class GLOFJJLGBKJ : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public NDBIOOABJBM MDIHPCFBLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(NDBIOOABJBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	[DataMember(Name = "AvatarItemDesc")]
	public string MDIGMMHOHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public string KPDIBFFPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string LAABGGGODLF
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public NAHJKMGHOEN FHFICPPBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA123A0", Offset = "0xA111A0", VA = "0x180A123A0")]
		[CompilerGenerated]
		get
		{
			return default(NAHJKMGHOEN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11510", VA = "0x180A12710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public string IDJBFNPOFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public int HMKBGFIHHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xC15DC0", Offset = "0xC14BC0", VA = "0x180C15DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xE44A60", Offset = "0xE43860", VA = "0x180E44A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool EOLMCLNCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x16E0890", Offset = "0x16DF690", VA = "0x1816E0890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x17044F0", Offset = "0x17032F0", VA = "0x1817044F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string JEIBADOMFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xE52900", Offset = "0xE51700", VA = "0x180E52900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GLOFJJLGBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[IGNMLPIHKKI]
public sealed class JJMFAEGIIDM : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public List<string> HBEAKBKBMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x72B7CD0", Offset = "0x72B6AD0", VA = "0x1872B7CD0")]
	public JJMFAEGIIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public JJMFAEGIIDM(List<string> FBPKHPHIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[IGNMLPIHKKI]
public class ECHHDPDFEJC : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public JKLLBHPHHAO IDDJJMMAIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public MCCADLENLOA DBFIODNFEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public ECHHDPDFEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public ECHHDPDFEJC(JKLLBHPHHAO ADNJGAGOOEL, MCCADLENLOA LEAIPLMEEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum FHFDPIHEEKI
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum PJLDBBJJKLN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[IGNMLPIHKKI]
public class JKLLBHPHHAO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public FHFDPIHEEKI DAHEFGPPMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(FHFDPIHEEKI);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public PJLDBBJJKLN? MFBOKKCOKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2EB7D50", Offset = "0x2EB6B50", VA = "0x182EB7D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x71413F0", Offset = "0x71401F0", VA = "0x1871413F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool LJKOGKFKFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBD40", Offset = "0x1DCAB40", VA = "0x181DCBD40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBBF0", Offset = "0x1DCA9F0", VA = "0x181DCBBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x72B7D60", Offset = "0x72B6B60", VA = "0x1872B7D60")]
	public JKLLBHPHHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x72B7D70", Offset = "0x72B6B70", VA = "0x1872B7D70")]
	public JKLLBHPHHAO(FHFDPIHEEKI DNDCCLMADGM, PJLDBBJJKLN LJBDDPJKHHM, bool CDGPAGIOKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[IGNMLPIHKKI]
public class MCCADLENLOA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public string IIAMOCBBNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public string KFFIGMIEDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MCCADLENLOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public MCCADLENLOA(string LFPBKJDFPMN, string AMBIFONGOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum HGNOHPJPPIO
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LLEHDPMEANK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public CAJGGKMOJIB KINLDEIMDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool PMCBPEICNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public bool OMPNHCLAENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool KIJNLNLNAGF;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[IGNMLPIHKKI]
public class CAJGGKMOJIB : LBLGPGHMOJK, OAAIBPONJHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct DAINEBKFDLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CAJGGKMOJIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x72B3480", Offset = "0x72B2280", VA = "0x1872B3480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x72B3610", Offset = "0x72B2410", VA = "0x1872B3610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal static Action<CAJGGKMOJIB> FBJMCHIOMEJ;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal static Func<CAJGGKMOJIB, Task> AIOGPCEOFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[IgnoreDataMember]
	public bool OADJHKDHGPO;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public long? OCNPBLDHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public int PFOPKNGJLID
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public int? JHEIEANDIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xEFDEC0", Offset = "0xEFCCC0", VA = "0x180EFDEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xEFDEF0", Offset = "0xEFCCF0", VA = "0x180EFDEF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public string JKAANLEPEOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public NDBIOOABJBM? MDIHPCFBLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA128F0", Offset = "0xA116F0", VA = "0x180A128F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	[DataMember(Name = "AvatarItemDesc")]
	public string AMCOHDOFLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Guid? CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x72B21A0", Offset = "0x72B0FA0", VA = "0x1872B21A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x72B23A0", Offset = "0x72B11A0", VA = "0x1872B23A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public string JHLNPAPDNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public string JCLGLCBHDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFD0", Offset = "0xA0BDD0", VA = "0x180A0CFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public POKBHADPEGG CIDODMPPDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA30D50", Offset = "0xA2FB50", VA = "0x180A30D50")]
		[CompilerGenerated]
		get
		{
			return default(POKBHADPEGG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1355A80", Offset = "0x1354880", VA = "0x181355A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public int CABBOEDPKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA30DB0", Offset = "0xA2FBB0", VA = "0x180A30DB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1355240", Offset = "0x1354040", VA = "0x181355240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public int JFEPEOHIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xDDDD70", Offset = "0xDDCB70", VA = "0x180DDDD70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xEBF4D0", Offset = "0xEBE2D0", VA = "0x180EBF4D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public OGMKPJCJPIA GKKFGDCEEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xE64600", Offset = "0xE63400", VA = "0x180E64600")]
		[CompilerGenerated]
		get
		{
			return default(OGMKPJCJPIA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x13B53C0", Offset = "0x13B41C0", VA = "0x1813B53C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public NAHJKMGHOEN NCGOBPEKINO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xC31F60", Offset = "0xC30D60", VA = "0x180C31F60")]
		[CompilerGenerated]
		get
		{
			return default(NAHJKMGHOEN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x138C640", Offset = "0x138B440", VA = "0x18138C640")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	[DataMember(Name = "Message")]
	public string JCFMKHCJEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0D980", Offset = "0xA0C780", VA = "0x180A0D980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA30", Offset = "0xA0C830", VA = "0x180A0DA30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public string LABEEBJHBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xBFED10", Offset = "0xBFDB10", VA = "0x180BFED10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x135D320", Offset = "0x135C120", VA = "0x18135D320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool AFHMADEENBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE512F0", VA = "0x180E524F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE52520", Offset = "0xE51320", VA = "0x180E52520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public PAMJNKEHFFA IENDGNJHALA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xDDCA90", Offset = "0xDDB890", VA = "0x180DDCA90")]
		[CompilerGenerated]
		get
		{
			return default(PAMJNKEHFFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xDDAB70", Offset = "0xDD9970", VA = "0x180DDAB70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public AJJFEMDAEDB MBBOCEDCGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9F0", Offset = "0xA0C7F0", VA = "0x180A0D9F0")]
		[CompilerGenerated]
		get
		{
			return default(AJJFEMDAEDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA0D8F0", Offset = "0xA0C6F0", VA = "0x180A0D8F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public BMEIJOCDMOI? JCGMNDEBGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x72B2230", Offset = "0x72B1030", VA = "0x1872B2230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x72B2260", Offset = "0x72B1060", VA = "0x1872B2260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool EIGCILGFMOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x72B21C0", Offset = "0x72B0FC0", VA = "0x1872B21C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool DLJGPNIPMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x72B23B0", Offset = "0x72B11B0", VA = "0x1872B23B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool BCHILMEJEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x72B2240", Offset = "0x72B1040", VA = "0x1872B2240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	[IgnoreDataMember]
	public bool OPMCFEPKIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA082A0", Offset = "0xA070A0", VA = "0x180A082A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA08230", Offset = "0xA07030", VA = "0x180A08230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	[IgnoreDataMember]
	public bool JOCIPIGBAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DA90", Offset = "0x2B9C890", VA = "0x182B9DA90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DBA0", Offset = "0x2B9C9A0", VA = "0x182B9DBA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	[IgnoreDataMember]
	public string MOMNHMHKAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xD8BC60", Offset = "0xD8AA60", VA = "0x180D8BC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xE8DAA0", Offset = "0xE8C8A0", VA = "0x180E8DAA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	[IgnoreDataMember]
	public string BOEHMNFMOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xD6F900", Offset = "0xD6E700", VA = "0x180D6F900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xD6F910", Offset = "0xD6E710", VA = "0x180D6F910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	[IgnoreDataMember]
	public bool LMNLLOEGDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xF871F0", Offset = "0xF85FF0", VA = "0x180F871F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xBF8A20", Offset = "0xBF7820", VA = "0x180BF8A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x72B2340", Offset = "0x72B1140", VA = "0x1872B2340", Slot = "5")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x72B2270", Offset = "0x72B1070", VA = "0x1872B2270", Slot = "6")]
	[AsyncStateMachine(typeof(DAINEBKFDLP))]
	public virtual Task GIBKODDCFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x13B53C0", Offset = "0x13B41C0", VA = "0x1813B53C0")]
	public void OJEGPPPHJDB(OGMKPJCJPIA JAPGNGDBBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CAJGGKMOJIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface OFKLKPLJMKO
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	long PJPDKAKKBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	string LGFOJPCEALB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	int KNIJJCDNKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	string POKJFMDLLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string OGEKIGBBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	byte DPDHLDHCDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	int ONCDNFGMBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	int GNPLAFDMCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	LBKDEAGGCAC IOJPJCMBNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	bool ALPHHCHCNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	DateTime LMHCPFIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	DateTime? JBEDFHKJABF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	long? NFACFIKGKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	int NCMLNPFCNCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	int HDLKEJLGJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	int IDHBGANIHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	GJGENKMHAEF LAIFKKMJHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	GJGENKMHAEF CMOBADAENGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	bool IGHCNBLAPOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	bool PAKNBAMADOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	bool HBEOHJENAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	bool IDCKHCGEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	int? GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool PHBKHPHAIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	string IAFCJENIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJKCNNNFJJH();

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAOFEHKMMKK();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[IGNMLPIHKKI]
public class DLGLJBBEKKJ : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public List<LKEJPEGHBLK> MDJKMHIGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x72B4550", Offset = "0x72B3350", VA = "0x1872B4550")]
	public List<string> HMCACNJGMCN(params MJJKDBOAPEA[] HDHEOGPDINN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x72B43E0", Offset = "0x72B31E0", VA = "0x1872B43E0")]
	public List<string> FKMPDCHHLEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x72B4710", Offset = "0x72B3510", VA = "0x1872B4710")]
	public List<string> IOBEDHPLELH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x72B4460", Offset = "0x72B3260", VA = "0x1872B4460", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public DLGLJBBEKKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[IGNMLPIHKKI]
public class GFPGLGMNLAN : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int KNIJJCDNKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GFPGLGMNLAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[IGNMLPIHKKI]
public class DHJCKBCGHMG : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public long PJPDKAKKBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public string LGFOJPCEALB
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int HKGEPGJNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool GMOMBOPPLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xD4A770", Offset = "0xD49570", VA = "0x180D4A770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xD4A780", Offset = "0xD49580", VA = "0x180D4A780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int KPFNOKIICAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public int KCDJLKHHAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xC910C0", Offset = "0xC8FEC0", VA = "0x180C910C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1415040", Offset = "0x1413E40", VA = "0x181415040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int CCIADBCPMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA123A0", Offset = "0xA111A0", VA = "0x180A123A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11510", VA = "0x180A12710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int NCKDHAEIBGF
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2A0", Offset = "0xA490A0", VA = "0x180A4A2A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA49E40", Offset = "0xA48C40", VA = "0x180A49E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public string KDLGAODOMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public string IKKBHJCPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AD0", Offset = "0x6FF08D0", VA = "0x186FF1AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public LBKDEAGGCAC? LJDCNJPJJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xE52900", Offset = "0xE51700", VA = "0x180E52900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public IReadOnlyList<Guid> CCOIBIPMKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public CKNMKLKMAFP DJNCHLEFNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x72B3A70", Offset = "0x72B2870", VA = "0x1872B3A70")]
		get
		{
			return default(CKNMKLKMAFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x72B3AC0", Offset = "0x72B28C0", VA = "0x1872B3AC0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x72B3B40", Offset = "0x72B2940", VA = "0x1872B3B40")]
	public bool GOGCPGAMALL(DHJCKBCGHMG GDBJOGNPNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x72B3BF0", Offset = "0x72B29F0", VA = "0x1872B3BF0")]
	private bool PKONAPLOHBO(DHJCKBCGHMG GDBJOGNPNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x72B3B50", Offset = "0x72B2950", VA = "0x1872B3B50")]
	private static bool JMPOAGNHGMB(IReadOnlyList<Guid> PKNFLPFFMPG, IReadOnlyList<Guid> GFFPPHPKICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2820C00", Offset = "0x281FA00", VA = "0x182820C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public DHJCKBCGHMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[IGNMLPIHKKI]
public class HACEIIABKIB : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public int FGHHNEJDNML
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HACEIIABKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[IGNMLPIHKKI]
public class OICEDEDMOLM : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public bool OJBABLKEOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OICEDEDMOLM()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[IGNMLPIHKKI]
	public class NewInventionRequestDTO : OAAIBPONJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public OKJOLANABCP creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xED6F10", Offset = "0xED5D10", VA = "0x180ED6F10", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x72B9150", Offset = "0x72B7F50", VA = "0x1872B9150")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[IGNMLPIHKKI]
	public class AddVersionInventionRequestDTO : OAAIBPONJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xED6F10", Offset = "0xED5D10", VA = "0x180ED6F10", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x72B1A20", Offset = "0x72B0820", VA = "0x1872B1A20")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[IGNMLPIHKKI]
	public class ModifyTagsRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[IGNMLPIHKKI]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[IGNMLPIHKKI]
	public class ReportRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public EKALPIPFMIE ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[IGNMLPIHKKI]
	public class CheerRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[IGNMLPIHKKI]
	public class UpdatePriceRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[IGNMLPIHKKI]
	public class UpdateInventionMetadataRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xED6F10", Offset = "0xED5D10", VA = "0x180ED6F10", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[IGNMLPIHKKI]
	public class UpdateInventionGeneralPermissionRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public GJGENKMHAEF Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(GJGENKMHAEF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[IGNMLPIHKKI]
	public class PublishInventionRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public GJGENKMHAEF Permission
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(GJGENKMHAEF);
			}
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public LBKDEAGGCAC Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00")]
			[CompilerGenerated]
			get
			{
				return default(LBKDEAGGCAC);
			}
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xD8DB90", Offset = "0xD8C990", VA = "0x180D8DB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[IGNMLPIHKKI]
	public class UnpublishInventionRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[IGNMLPIHKKI]
	public class DeleteInventionRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[IGNMLPIHKKI]
	public class SetInventionVersionAccessibilityRequest : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public LBKDEAGGCAC NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00")]
			[CompilerGenerated]
			get
			{
				return default(LBKDEAGGCAC);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xD8DB90", Offset = "0xD8C990", VA = "0x180D8DB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[IGNMLPIHKKI]
	public class SpecialTags : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum BDHDIKNMEBB
{
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum EKALPIPFMIE
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum EKMNPAFFIOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	True,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface JKAEBBPJIOI
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	PAMJNKEHFFA IENDGNJHALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	string PLIIGANAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	int OBGCOEMGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	DateTime APIKPFOLJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	bool JPFBHFBMOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	string BNOALFALPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	IDPAJCCDCOM NHLMBNPNDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HHDPONBNNOO();

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CBCKKODIPAC(IDPAJCCDCOM LIFHNEIANMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface JKPKLFPJHNG
{
	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	string HLFEJLMDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool ALGOAPKDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHDPONBNNOO();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ABOKHCLEKNN
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public EDHLCBNNGIB AOPKDKEBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60")]
		[CompilerGenerated]
		readonly get
		{
			return default(EDHLCBNNGIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public JKPKLFPJHNG CADHCLNPEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xDB93E0", Offset = "0xDB81E0", VA = "0x180DB93E0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xDB9310", Offset = "0xDB8110", VA = "0x180DB9310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public string FAOHGKFCLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6F10", Offset = "0x5DD5D10", VA = "0x185DD6F10")]
	public ABOKHCLEKNN(EDHLCBNNGIB LGDMNONEILJ, [Optional] JKPKLFPJHNG DADLPPDKMNA, [Optional] string HJMDNBAOKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public enum EDHLCBNNGIB
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[IGNMLPIHKKI]
public class HPNJIJLEHBO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public string HBEMPFHFDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public string IOIPHPDBABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public string AILMEKEONLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public string NOLBGAJAMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public List<HCCPBMAHLDI> JHJMHHGIOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HPNJIJLEHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E540", Offset = "0x4B1D340", VA = "0x184B1E540")]
	public HPNJIJLEHBO([Optional] string CIDNLIIKLPM, [Optional] string CONONOLAJMJ, [Optional] string FMLHEJELNHF, [Optional] string DGKMBCIIBKC, [Optional] List<HCCPBMAHLDI> OKOHBFNKIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[IGNMLPIHKKI]
public class HCCPBMAHLDI : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string LJIAJODLPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string NOLBGAJAMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HCCPBMAHLDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[IGNMLPIHKKI]
public class ODMAKJCCHDI : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string IOIPHPDBABC
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string AOPKDKEBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public string HBEMPFHFDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public List<string> JLICOODCEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public ODMAKJCCHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[IGNMLPIHKKI]
public interface OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHDPONBNNOO();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[IGNMLPIHKKI]
public interface LBLGPGHMOJK : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GIBKODDCFJF();
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[LPFPFADCFLL]
public interface KDCOIBLMAFL : OAAIBPONJHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[IGNMLPIHKKI]
public class CKAAJMIKLMN : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public int HLMNABLPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string EEFPLEDDMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public string KIGBAFCINFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CKAAJMIKLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x72B2940", Offset = "0x72B1740", VA = "0x1872B2940")]
	public CKAAJMIKLMN([Optional] Guid FIBIOFOKNFN, int PEADOPOCNJH = 0, [Optional] string IBEPLBFJIHI, [Optional] string FFPFGHEABIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[IGNMLPIHKKI]
public class BFNIAFOELEN : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public const int DCPKJLGBJGI = 0;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public long DMGOBPIAFOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public PCDHPMDKECE CIFJJDFLAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public string BFGMHBGAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public List<CKAAJMIKLMN> AGECOHLMBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public int DFMCJHAIGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA123A0", Offset = "0xA111A0", VA = "0x180A123A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11510", VA = "0x180A12710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public LBKDEAGGCAC IOJPJCMBNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xC15DC0", Offset = "0xC14BC0", VA = "0x180C15DC0")]
		[CompilerGenerated]
		get
		{
			return default(LBKDEAGGCAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xE44A60", Offset = "0xE43860", VA = "0x180E44A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public string FMPEFBLFJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public bool NADNJMFLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E545B0", Offset = "0x1E533B0", VA = "0x181E545B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x72B1E30", Offset = "0x72B0C30", VA = "0x1872B1E30")]
	public BFNIAFOELEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x72B1EC0", Offset = "0x72B0CC0", VA = "0x1872B1EC0")]
	public BFNIAFOELEN(long OCBLGJHMFFK = 0L, [Optional] PCDHPMDKECE EFODPBCCPFB, [Optional] string PALPACMIEEB, [Optional] List<CKAAJMIKLMN> CLAOHEJPMNA, int DNPDDCMEHGG = 0, [Optional] string IHGFMOMOADA, LBKDEAGGCAC FIFIPCHEABN = LBKDEAGGCAC.Private, [Optional] string AOPELLBMFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class JKLOFIBFAIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly int OBGCOEMGDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public readonly BFNIAFOELEN AMENGMHFMLC;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xEEB9B0", Offset = "0xEEA7B0", VA = "0x180EEB9B0")]
	public JKLOFIBFAIE(int OEBMJHLGKIE, BFNIAFOELEN EAGCCPCCAEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[IGNMLPIHKKI]
public class PCDHPMDKECE : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public string OLCMOJMPFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string IOAMAKGNEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public string GEDOBOHOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string JNHAHDIGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public string PLGAKOMFHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public string AGECOHLMBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x72BA270", Offset = "0x72B9070", VA = "0x1872BA270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PCDHPMDKECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E540", Offset = "0x4B1D340", VA = "0x184B1E540")]
	public PCDHPMDKECE([Optional] string HDDFMJOJJOG, [Optional] string AFKCAGMJIFK, [Optional] string DOOHJCKKNJI, [Optional] string JHMKGMDNNGA, [Optional] string DOGGPNBLHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[IGNMLPIHKKI]
public class BDKAHGOOEMO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public Dictionary<int, BFNIAFOELEN> FKAKHDGCPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BDKAHGOOEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[IGNMLPIHKKI]
public class BLAODPGINOM : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public List<int> KIGBMAGCELC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public byte? DMCONAEIFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E9D390", Offset = "0x2E9C190", VA = "0x182E9D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2E9D380", Offset = "0x2E9C180", VA = "0x182E9D380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public int? GKFIOMBAKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xEFDEB0", Offset = "0xEFCCB0", VA = "0x180EFDEB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xEFDEE0", Offset = "0xEFCCE0", VA = "0x180EFDEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BLAODPGINOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class FBPLPMEAGHE
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x72B54B0", Offset = "0x72B42B0", VA = "0x1872B54B0")]
	public static JLMAAIOIKHE MOIKEEKHIDF(this CKAAJMIKLMN FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
public enum AJJFEMDAEDB
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public enum PAMJNKEHFFA
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[IGNMLPIHKKI]
public class MHFGLKDJGFM : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	[DataMember(Name = "PlayerId")]
	public int OBGCOEMGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public int OHCKBHMGBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xB97DF0", Offset = "0xB96BF0", VA = "0x180B97DF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xC82D00", Offset = "0xC81B00", VA = "0x180C82D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public int DAOCFGIMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MHFGLKDJGFM()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[IGNMLPIHKKI]
	public class ProgressionEventRecordDTO : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public int OBGCOEMGDCC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public int JFEPEOHIJMP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xB97DF0", Offset = "0xB96BF0", VA = "0x180B97DF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xC82D00", Offset = "0xC81B00", VA = "0x180C82D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public int NGMHBBCKJBC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public int GDDBINIPMGC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xD8DB90", Offset = "0xD8C990", VA = "0x180D8DB90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public int MBAHDHEIGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public DateTime? PCBCKIIAFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x12E0300", Offset = "0x12DF100", VA = "0x1812E0300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x12E0BD0", Offset = "0x12DF9D0", VA = "0x1812E0BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public int IDGOBIJBBHO
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xD88FB0", Offset = "0xD87DB0", VA = "0x180D88FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x72BABE0", Offset = "0x72B99E0", VA = "0x1872BABE0")]
		public ProgressionEventRecordDTO(int OEBMJHLGKIE = 0, int BFCBNDKBEOM = 0, int MHAKIILMPGO = 0, int LAOLLKKCDPD = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[IGNMLPIHKKI]
	public class ProgressionEventDTO : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public long IOHDCGGPDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public List<ProgressionEventRewardDTO> DNGFGFNNEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public List<KeepsakeRoomListDTO> IAILGMAKOOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public DateTime GFADGNOGEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAE0", Offset = "0xA0D8E0", VA = "0x180A0EAE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public DateTime ICGKAIPIHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xA128F0", Offset = "0xA116F0", VA = "0x180A128F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public DateTime EAAKAOJEIGF
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xE52500", Offset = "0xE51300", VA = "0x180E52500")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public bool GNEGDJDLCPL
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xC3A4C0", Offset = "0xC392C0", VA = "0x180C3A4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xC6F4E0", Offset = "0xC6E2E0", VA = "0x180C6F4E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public int INKECCMOFIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x13AF010", Offset = "0x13ADE10", VA = "0x1813AF010")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x20608A0", Offset = "0x205F6A0", VA = "0x1820608A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public float KANPOACCCOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x1111410", Offset = "0x1110210", VA = "0x181111410")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x13BA7D0", Offset = "0x13B95D0", VA = "0x1813BA7D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public Guid? OGFMMDLCDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x72BAB00", Offset = "0x72B9900", VA = "0x1872BAB00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x72BAB20", Offset = "0x72B9920", VA = "0x1872BAB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public string JMOLAAGJHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA0CFD0", Offset = "0xA0BDD0", VA = "0x180A0CFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public string BPJGNPIIEJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED20", Offset = "0xA0DB20", VA = "0x180A0ED20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public string CABJJKHBHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xA0D8A0", Offset = "0xA0C6A0", VA = "0x180A0D8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA0D8E0", Offset = "0xA0C6E0", VA = "0x180A0D8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public string CPNHBKBDAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xA0D9C0", Offset = "0xA0C7C0", VA = "0x180A0D9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA0D960", Offset = "0xA0C760", VA = "0x180A0D960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x72BAB30", Offset = "0x72B9930", VA = "0x1872BAB30")]
		public ProgressionEventDTO(long LBGJNPLAOBD = 0L, [Optional] string IHGFMOMOADA, [Optional] List<ProgressionEventRewardDTO> DIOGIJLAHBJ, [Optional] List<KeepsakeRoomListDTO> GGKEPPAMCKN, [Optional] DateTime DKELFJONAAD, [Optional] DateTime PEAKBOBJENO, [Optional] DateTime BEDEMIDLPBK, bool GHIMPGMLHNE = false, int KHEKFMHJAMH = 0, float ONFOGIJOIIF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[IGNMLPIHKKI]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public long GADCGJLLILM
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public long IOHDCGGPDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public int? GIEOPFLJCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public int? OIOGMCBJLFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECF0", Offset = "0xA0DAF0", VA = "0x180A0ECF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public long? HHKIHKJAMNK
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xDEA430", Offset = "0xDE9230", VA = "0x180DEA430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xDEA750", Offset = "0xDE9550", VA = "0x180DEA750")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long BJDIJIIPGFD
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xE52500", Offset = "0xE51300", VA = "0x180E52500")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public TimeSpan DMLGCBNLDHP
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x72B8B00", Offset = "0x72B7900", VA = "0x1872B8B00")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public long HOAGNIBMCOA
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x6FF1AD0", Offset = "0x6FF08D0", VA = "0x186FF1AD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public TimeSpan KFHBPCJOEGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x72B8AB0", Offset = "0x72B78B0", VA = "0x1872B8AB0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public int PDMIJFLBHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xD5AFA0", Offset = "0xD59DA0", VA = "0x180D5AFA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xEA6460", Offset = "0xEA5260", VA = "0x180EA6460")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public EGMKOKDOLNC KFMHLMCCBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x1172700", Offset = "0x1171500", VA = "0x181172700")]
			[CompilerGenerated]
			get
			{
				return default(EGMKOKDOLNC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x21FBD80", Offset = "0x21FAB80", VA = "0x1821FBD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public List<KeepsakeRoomDTO> GJPCNBOJDIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x72B8B50", Offset = "0x72B7950", VA = "0x1872B8B50")]
		public KeepsakeRoomListDTO(long PEBABFGJOFP = 0L, long LBGJNPLAOBD = 0L, [Optional] int? NLNGOAOBDNK, [Optional] int? ELMEDEIIGGM, [Optional] long? AMDNAICLGHH, long DHMGFGOGEID = 0L, long IJAMNJIHLKF = 0L, int HAFADBJEINC = 0, EGMKOKDOLNC GDNLNDBNIDD = EGMKOKDOLNC.Standard, [Optional] List<KeepsakeRoomDTO> GMAOBHAJECL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[IGNMLPIHKKI]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public long PGLOEEOGOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public long FBNGFADIKHM
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public long GADCGJLLILM
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public EGMKOKDOLNC KDNIOMEAELB
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
			[CompilerGenerated]
			get
			{
				return default(EGMKOKDOLNC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public int FKNHKLMNPNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xC910C0", Offset = "0xC8FEC0", VA = "0x180C910C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x1415040", Offset = "0x1413E40", VA = "0x181415040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x72B8A50", Offset = "0x72B7850", VA = "0x1872B8A50")]
		public KeepsakeRoomDTO(long MIBJABNLKEL = 0L, long CEACGIDOODJ = 0L, long PEBABFGJOFP = 0L, EGMKOKDOLNC AAFMBEEMJAC = EGMKOKDOLNC.Standard, int NPHMDGDNHJJ = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[IGNMLPIHKKI]
	public class ProgressionEventRewardDTO : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public long IPHHIIFKAEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public int BOECOCFLDBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public string OGEKIGBBLLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public int JFEPEOHIJMP
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public int IGDBIMGEGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xC910C0", Offset = "0xC8FEC0", VA = "0x180C910C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x1415040", Offset = "0x1413E40", VA = "0x181415040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public bool MPKKKDIBCLO
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xA36F20", Offset = "0xA35D20", VA = "0x180A36F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA36E80", Offset = "0xA35C80", VA = "0x180A36E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public bool GJNOFEMCMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xDD4380", Offset = "0xDD3180", VA = "0x180DD4380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x1357120", Offset = "0x1355F20", VA = "0x181357120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[IGNMLPIHKKI]
	public class ProgressionEventPurchasableXpBoostDTO : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public Guid HLGLBEMBMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public int KIEBCNMGGBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public int HEHDKCCEFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public int BGKMEGAPOKE
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public long OOKGJCHOFJB
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAE0", Offset = "0xA0D8E0", VA = "0x180A0EAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public long CNHCOLBECIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA128F0", Offset = "0xA116F0", VA = "0x180A128F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum EGMKOKDOLNC
{
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum IDPKHHDKFDH
{
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[IGNMLPIHKKI]
public class CGAOBFHJANI : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	public string IOHBNCAAHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	public string? PIJPBCNJOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CGAOBFHJANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface PPMNBPGEJIK
{
	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	bool LGKACBKCCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	string? NBJHKBOJJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	string? AOKLBLIMDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface AFFMLPHACFP<T> : PPMNBPGEJIK
{
	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class FJGKMIBLHOB
{
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x38E91C0", Offset = "0x38E7FC0", VA = "0x1838E91C0")]
	public static AFFMLPHACFP<T> MNFKMLBDMML<T, U>(this AFFMLPHACFP<U> BPINCJLADGC, Func<U, T> KNPJDDKLIIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct FPKFCNPKNHN<T> : AFFMLPHACFP<T>, PPMNBPGEJIK
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public bool LGKACBKCCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xF776F0", Offset = "0xF764F0", VA = "0x180F776F0", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2A25C90", Offset = "0x2A24A90", VA = "0x182A25C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public string? NBJHKBOJJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xDB93E0", Offset = "0xDB81E0", VA = "0x180DB93E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xDB9310", Offset = "0xDB8110", VA = "0x180DB9310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	public string? AOKLBLIMDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	public T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8C10", Offset = "0x4AE7A10", VA = "0x184AE8C10")]
	public static FPKFCNPKNHN<T> LCDCIGKFNNB(T OAIIHELJHLG)
	{
		return default(FPKFCNPKNHN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8CB0", Offset = "0x4AE7AB0", VA = "0x184AE8CB0")]
	public static FPKFCNPKNHN<T> PBDNIFNMKEK(string NGENEEODOJL, string ICPIIJBOPGP = "")
	{
		return default(FPKFCNPKNHN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[IGNMLPIHKKI]
public class ONAJOACHAJH : PPMNBPGEJIK, OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	public bool LGKACBKCCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public string? NBJHKBOJJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	[DataMember(Name = "error_id")]
	public string? AOKLBLIMDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "8")]
	public virtual void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x72BA100", Offset = "0x72B8F00", VA = "0x1872BA100")]
	public static ONAJOACHAJH LCDCIGKFNNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x72BA170", Offset = "0x72B8F70", VA = "0x1872BA170")]
	public static ONAJOACHAJH PBDNIFNMKEK(string NGENEEODOJL, string ICPIIJBOPGP = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public ONAJOACHAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[DHFCNGCHGGB]
public abstract class HADGKGMEIJF<T> : ONAJOACHAJH, AFFMLPHACFP<T>, PPMNBPGEJIK
{
	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
	protected HADGKGMEIJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[DHFCNGCHGGB]
public class HFJCIFLPOLP<T> : HADGKGMEIJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4C229C0", Offset = "0x4C217C0", VA = "0x184C229C0")]
	private static void MMABCGMLPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x4592CE0", Offset = "0x4591AE0", VA = "0x184592CE0")]
	public HFJCIFLPOLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[DHFCNGCHGGB]
public class AEMAHMMCBBC<T> : HADGKGMEIJF<T>, LBLGPGHMOJK, OAAIBPONJHJ where T : OAAIBPONJHJ, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct MKNBEOHJHJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AEMAHMMCBBC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x53CB7C0", Offset = "0x53CA5C0", VA = "0x1853CB7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x53CBA40", Offset = "0x53CA840", VA = "0x1853CBA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4BC0", Offset = "0x4BA39C0", VA = "0x184BA4BC0", Slot = "8")]
	public override void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4AF0", Offset = "0x4BA38F0", VA = "0x184BA4AF0", Slot = "10")]
	[AsyncStateMachine(typeof(AEMAHMMCBBC<>.MKNBEOHJHJO))]
	public Task GIBKODDCFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4C50", Offset = "0x4BA3A50", VA = "0x184BA4C50")]
	public static AEMAHMMCBBC<T> LCDCIGKFNNB(T OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4DB0", Offset = "0x4BA3BB0", VA = "0x184BA4DB0")]
	public new static AEMAHMMCBBC<T> PBDNIFNMKEK(string NGENEEODOJL, string ICPIIJBOPGP = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
	public AEMAHMMCBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[DHFCNGCHGGB]
public class PPICMEHHPFL<T> : HADGKGMEIJF<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4592CE0", Offset = "0x4591AE0", VA = "0x184592CE0")]
	public PPICMEHHPFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[DHFCNGCHGGB]
public class GCANHDJDIAC<T> : HADGKGMEIJF<List<T>>, LBLGPGHMOJK, OAAIBPONJHJ where T : OAAIBPONJHJ, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct AFPGHPLNEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public GCANHDJDIAC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8D00", Offset = "0x4BA7B00", VA = "0x184BA8D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8F10", Offset = "0x4BA7D10", VA = "0x184BA8F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7FC80", Offset = "0x4B7EA80", VA = "0x184B7FC80")]
	public static GCANHDJDIAC<T> LCDCIGKFNNB(List<T> OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7FDC0", Offset = "0x4B7EBC0", VA = "0x184B7FDC0")]
	public new static GCANHDJDIAC<T> PBDNIFNMKEK(string NGENEEODOJL, string ICPIIJBOPGP = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x4B7FA00", Offset = "0x4B7E800", VA = "0x184B7FA00", Slot = "8")]
	public override void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F930", Offset = "0x4B7E730", VA = "0x184B7F930", Slot = "10")]
	[AsyncStateMachine(typeof(GCANHDJDIAC<>.AFPGHPLNEBA))]
	public Task GIBKODDCFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4B7FF10", Offset = "0x4B7ED10", VA = "0x184B7FF10")]
	public GCANHDJDIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum BGOHMAHABDH
{
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class DPLPPFAMGFC
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x72B4760", Offset = "0x72B3560", VA = "0x1872B4760")]
	public static bool EJNGCAEPOOC(this BGOHMAHABDH BMACFGNFKCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x72B4760", Offset = "0x72B3560", VA = "0x1872B4760")]
	public static bool BNLMPLKEGFO(this BGOHMAHABDH BMACFGNFKCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum POKBHADPEGG
{
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	ProgressionEvent = 400
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum BMEIJOCDMOI
{
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	NonPurchasedEarnedByP2Pv2 = 1001
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum OGMKPJCJPIA
{
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum NAHJKMGHOEN
{
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum MBILGBFPJKP
{
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[IGNMLPIHKKI]
	public class BalanceResponseDTO : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public POKBHADPEGG CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(POKBHADPEGG);
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[DataMember(Name = "Platform")]
		public BMEIJOCDMOI BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00")]
			[CompilerGenerated]
			get
			{
				return default(BMEIJOCDMOI);
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xD8DB90", Offset = "0xD8C990", VA = "0x180D8DB90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public virtual void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[IGNMLPIHKKI]
	public class FilteredTextDTO : OAAIBPONJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public string HLFEJLMDOCD
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public int DCFGGHJMDLI
		{
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[IGNMLPIHKKI]
public class LDLFJOAOEIC : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	public string EHMBNOOFDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	public string MKDLGFANCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LDLFJOAOEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[IGNMLPIHKKI]
public class OHGPNNMHLKL : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public List<LDLFJOAOEIC> PIDNHNPBNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OHGPNNMHLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[IGNMLPIHKKI]
public class NJILNBMICJH : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	public string GHHAMFIGCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public NJILNBMICJH(string LLFFLGCGFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[IGNMLPIHKKI]
public class FHPAPHIPMEJ : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	public List<LDLFJOAOEIC> PIDNHNPBNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FHPAPHIPMEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[IGNMLPIHKKI]
public class FKPJNLKKDDB : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public List<NJILNBMICJH> HLKKEPLFEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string KLBNDDAEOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public bool AJIONJHGLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public int KBLDEAHDCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FKPJNLKKDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x72B59F0", Offset = "0x72B47F0", VA = "0x1872B59F0")]
	public FKPJNLKKDDB(string DJINGFJDDFE, List<NJILNBMICJH> JIMIKIEHNBM, bool NMPPDCGJGPI, int GJEGAGBEGDN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[IGNMLPIHKKI]
public class CFHDMENEAPP : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public List<FHPAPHIPMEJ> KMEAKIGAODO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public bool AJIONJHGLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0B690", Offset = "0xA0A490", VA = "0x180A0B690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CFHDMENEAPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[IGNMLPIHKKI]
public class ANIBMJIFONA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum PBGGNNIFMLC
	{
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public const string CGOGMCLIAMN = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public string KLBNDDAEOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public PBGGNNIFMLC AOPKDKEBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(PBGGNNIFMLC);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x72B19C0", Offset = "0x72B07C0", VA = "0x1872B19C0")]
	public ANIBMJIFONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x72B19D0", Offset = "0x72B07D0", VA = "0x1872B19D0")]
	public ANIBMJIFONA(string DJINGFJDDFE, PBGGNNIFMLC LGDMNONEILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[IGNMLPIHKKI]
public class BNGKFPDBGNH : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public bool MGNLAFKALCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BNGKFPDBGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class PFMLKNHNKDO
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum KFJCLHFBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[IGNMLPIHKKI]
public class AIAPJJNPNBF : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public long FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public Guid EHEKBKNMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xDF46D0", Offset = "0xDF34D0", VA = "0x180DF46D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public long HEBHICMMGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECF0", Offset = "0xA0DAF0", VA = "0x180A0ECF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public GLMKLCKGOFP AFCBGKMAIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public AIAPJJNPNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x72B1960", Offset = "0x72B0760", VA = "0x1872B1960")]
	public AIAPJJNPNBF(long CEACGIDOODJ, Guid CMKJHAGJPED, long CGKKBLKIKKA, GLMKLCKGOFP GPFMJIGJOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x72B1940", Offset = "0x72B0740", VA = "0x1872B1940", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[IGNMLPIHKKI]
public class AKPINJIPEKK : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public LHABPDEBEFJ IBGOAACNDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(LHABPDEBEFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public GLNKJILIANA KDDLEDPMCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public AKPINJIPEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0xEEB9B0", Offset = "0xEEA7B0", VA = "0x180EEB9B0")]
	public AKPINJIPEKK(LHABPDEBEFJ BPINCJLADGC, GLNKJILIANA GBCBLMPEJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[IGNMLPIHKKI]
public class GLMKLCKGOFP : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public Guid? FAHHPBMEJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x2E7AE10", Offset = "0x2E79C10", VA = "0x182E7AE10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x72B5DA0", Offset = "0x72B4BA0", VA = "0x1872B5DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public Guid MEHOCBAJJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xD5AF70", Offset = "0xD59D70", VA = "0x180D5AF70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xF76C80", Offset = "0xF75A80", VA = "0x180F76C80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GLMKLCKGOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x72B5DB0", Offset = "0x72B4BB0", VA = "0x1872B5DB0")]
	public GLMKLCKGOFP(Guid? GJKOHNCDINC, Guid EKNBHAHJHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[IGNMLPIHKKI]
public class GLNKJILIANA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public long FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public Guid EHEKBKNMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xDF46D0", Offset = "0xDF34D0", VA = "0x180DF46D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public long GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECF0", Offset = "0xA0DAF0", VA = "0x180A0ECF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public Guid IBJNHCPDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xDEA430", Offset = "0xDE9230", VA = "0x180DEA430")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xDEA750", Offset = "0xDE9550", VA = "0x180DEA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xE52500", Offset = "0xE51300", VA = "0x180E52500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public DateTime LMHCPFIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AD0", Offset = "0x6FF08D0", VA = "0x186FF1AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GLNKJILIANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[IGNMLPIHKKI]
public class OGPFDFNBJGE : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public string OGEKIGBBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public List<long> DMGEPMEHDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public List<BFBCIGOILKH> COKAEMNGBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public string AHPNGHHEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public byte? NLENIPGDJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x72B9620", Offset = "0x72B8420", VA = "0x1872B9620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x72B9610", Offset = "0x72B8410", VA = "0x1872B9610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public int? FBBKNJCDNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x72B1DA0", Offset = "0x72B0BA0", VA = "0x1872B1DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x72B1AA0", Offset = "0x72B08A0", VA = "0x1872B1AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public Guid? BMCEFNAGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x72B95F0", Offset = "0x72B83F0", VA = "0x1872B95F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x72B95E0", Offset = "0x72B83E0", VA = "0x1872B95E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public bool JFFKLCPKJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED40", Offset = "0xA0DB40", VA = "0x180A0ED40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAD0", Offset = "0xA0D8D0", VA = "0x180A0EAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OGPFDFNBJGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[IGNMLPIHKKI]
public class MAHLFJHHAOK : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public Guid BMCEFNAGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public long FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public string OGEKIGBBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xE52500", Offset = "0xE51300", VA = "0x180E52500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public DateTime LMHCPFIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AD0", Offset = "0x6FF08D0", VA = "0x186FF1AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public string AHPNGHHEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public List<long> DMGEPMEHDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public List<EHEPKBOFNKL> COKAEMNGBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public byte NLENIPGDJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xD55D00", Offset = "0xD54B00", VA = "0x180D55D00")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x126D6F0", Offset = "0x126C4F0", VA = "0x18126D6F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public int FBBKNJCDNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xA40980", Offset = "0xA3F780", VA = "0x180A40980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x1355A90", Offset = "0x1354890", VA = "0x181355A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MAHLFJHHAOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum LHABPDEBEFJ
{
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface INFDDCICJNJ
{
	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HADGKGMEIJF<MAHLFJHHAOK>> OFLKOGIBONK(Guid? AGGEDCBPBDE, long CEACGIDOODJ, string IHGFMOMOADA, string CDDMBEEGKND, string DBCDJMCMAJM, string BCIPKLJAOMN, byte HMDNNMIJNJJ, int DEJLIDMJHPI, [Optional] List<long> LPODAADEFKK, [Optional] List<EHEPKBOFNKL> NKOOIEHKAOG, bool KCOAHFLFPNO = false, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HADGKGMEIJF<MAHLFJHHAOK>> CLBPOPLDFBG(Guid CMKJHAGJPED, long CEACGIDOODJ, [Optional] string IHGFMOMOADA, [Optional] string CDDMBEEGKND, [Optional] string DBCDJMCMAJM, [Optional] List<long> LPODAADEFKK, [Optional] Dictionary<string, string> NKOOIEHKAOG, [Optional] string BCIPKLJAOMN, [Optional] byte? HMDNNMIJNJJ, [Optional] int? DEJLIDMJHPI, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ONAJOACHAJH> BCEMBOKMDJH(Guid CMKJHAGJPED, long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<MAHLFJHHAOK>> AJBMNIDGPCA(long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<GLNKJILIANA>> MPCKCGPJBGK(long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<AKPINJIPEKK>> CHMOLAGAIEH(long CEACGIDOODJ, List<AIAPJJNPNBF> KKEOIEBPBPK, [Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[IGNMLPIHKKI]
public class BFBCIGOILKH : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public string AHPNGHHEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BFBCIGOILKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[IGNMLPIHKKI]
public class EHEPKBOFNKL : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public long NDHKHHEELCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public string AHPNGHHEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public EHEPKBOFNKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[IGNMLPIHKKI]
public class GOABJCEBOJG : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public long NDHKHHEELCO
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public string AHPNGHHEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x4B1EF70", Offset = "0x4B1DD70", VA = "0x184B1EF70")]
	public GOABJCEBOJG(long NFFIHLEPONH, string ADPBPEDNFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public interface EJNBEGODCBL
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HADGKGMEIJF<List<EHEPKBOFNKL>>> KIEHCCKAENC(long CEACGIDOODJ, List<GOABJCEBOJG> KKEOIEBPBPK, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ONAJOACHAJH> KIDFEIGHGFH(long NFFIHLEPONH, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<EHEPKBOFNKL>> ANMIDBGIPND(long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[IGNMLPIHKKI]
public class MGCAOEDLPIH : PNOKONLOLNA, IEquatable<MGCAOEDLPIH>
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x72B8CA0", Offset = "0x72B7AA0", VA = "0x1872B8CA0", Slot = "7")]
	public bool Equals(MGCAOEDLPIH HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x72B8CE0", Offset = "0x72B7AE0", VA = "0x1872B8CE0", Slot = "6")]
	public override PNOKONLOLNA LAGKNEOGNDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MGCAOEDLPIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class MNNBDJNCLMC
{
	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x72B8F60", Offset = "0x72B7D60", VA = "0x1872B8F60")]
	public static MGCAOEDLPIH HLFNKPBADEA(this PKCPMDDLLPP HHHFHHLBBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x72B8E50", Offset = "0x72B7C50", VA = "0x1872B8E50")]
	public static MGCAOEDLPIH BJJEBOHCGPP(string KBMAKEIHADM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[IGNMLPIHKKI]
public class PKCPMDDLLPP : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public const int FJONJKJLOKJ = 3;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public const int NBEHBPHOLFH = 40;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public const int DIBDJEPDACJ = 180;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public const int AJEMODMHMKA = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public const int MHEICNCFEHJ = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public const int MOIEDJBFEEJ = 8;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public const int HCPHLKOGHOM = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public const int PDPPHGEFBEA = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public const int JEFJJGMBPAL = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? FGPLDMPHHNA;

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public Guid BMCEFNAGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public long FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string? OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public string? OGEKIGBBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public int GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xC15DC0", Offset = "0xC14BC0", VA = "0x180C15DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xE44A60", Offset = "0xE43860", VA = "0x180E44A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public Guid? ODMDMNECKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x72BA3C0", Offset = "0x72B91C0", VA = "0x1872BA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x72BA810", Offset = "0x72B9610", VA = "0x1872BA810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xD99670", Offset = "0xD98470", VA = "0x180D99670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xD99660", Offset = "0xD98460", VA = "0x180D99660")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public int? EIFAPEAEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2090", Offset = "0x6CD0E90", VA = "0x186CD2090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x6CD20B0", Offset = "0x6CD0EB0", VA = "0x186CD20B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public int? GKKGONGOGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x72BA4C0", Offset = "0x72B92C0", VA = "0x1872BA4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x72BA4A0", Offset = "0x72B92A0", VA = "0x1872BA4A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public IReadOnlyList<IJBCDEAJFJC> DBDHEINDNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED20", Offset = "0xA0DB20", VA = "0x180A0ED20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA0D8A0", Offset = "0xA0C6A0", VA = "0x180A0D8A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xE8BD80", Offset = "0xE8AB80", VA = "0x180E8BD80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public DateTime LMHCPFIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9C0", Offset = "0xA0C7C0", VA = "0x180A0D9C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xE8B8B0", Offset = "0xE8A6B0", VA = "0x180E8B8B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	[IgnoreDataMember]
	public PLJLLNMIBDO CKPMBMAOIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x72BA4D0", Offset = "0x72B92D0", VA = "0x1872BA4D0")]
		get
		{
			return default(PLJLLNMIBDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> KEPPBENFHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x72BA450", Offset = "0x72B9250", VA = "0x1872BA450")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA30", Offset = "0xA0C830", VA = "0x180A0DA30")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x72BA4B0", Offset = "0x72B92B0", VA = "0x1872BA4B0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PKCPMDDLLPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x72BA820", Offset = "0x72B9620", VA = "0x1872BA820")]
	public PKCPMDDLLPP(Guid AGGEDCBPBDE, long CEACGIDOODJ, string IHGFMOMOADA, string CDDMBEEGKND, string DBCDJMCMAJM, int NNBINNDLPGM, int? EJGCODNIEJB, int? EGDOKPJMGBF, List<IJBCDEAJFJC> BKMIGEDDBAL, [Optional] DateTime KJBIJEAOBEA, [Optional] DateTime KOIBGPKNMPL, [Optional] Guid? EAIOKAJMJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x72BA3E0", Offset = "0x72B91E0", VA = "0x1872BA3E0")]
	private PLJLLNMIBDO ECOLJFCJFEJ()
	{
		return default(PLJLLNMIBDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x72BA540", Offset = "0x72B9340", VA = "0x1872BA540")]
	private Dictionary<Guid, int> MJANENDPCAL(IReadOnlyList<IJBCDEAJFJC> BKMIGEDDBAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[IGNMLPIHKKI]
public class PADBGCKEKBH : OAAIBPONJHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public Guid BMCEFNAGBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public long FBNGFADIKHM;

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PADBGCKEKBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[IGNMLPIHKKI]
public class DBCODJLKKOA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public string? OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public string? OGEKIGBBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public int GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public int? EIFAPEAEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xEFDEA0", Offset = "0xEFCCA0", VA = "0x180EFDEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xEFDED0", Offset = "0xEFCCD0", VA = "0x180EFDED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	public int? GKKGONGOGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F40", Offset = "0xCD4D40", VA = "0x180CD5F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F90", Offset = "0xCD4D90", VA = "0x180CD5F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public List<IJBCDEAJFJC> DBDHEINDNON
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public Guid? AJICBOFHLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x72B21A0", Offset = "0x72B0FA0", VA = "0x1872B21A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x72B23A0", Offset = "0x72B11A0", VA = "0x1872B23A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public Guid? BMCEFNAGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x72B3690", Offset = "0x72B2490", VA = "0x1872B3690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x72B3670", Offset = "0x72B2470", VA = "0x1872B3670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public bool JFFKLCPKJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xD55D20", Offset = "0xD54B20", VA = "0x180D55D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xE9B620", Offset = "0xE9A420", VA = "0x180E9B620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x72B3680", Offset = "0x72B2480", VA = "0x1872B3680", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public DBCODJLKKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[IGNMLPIHKKI]
public class IJBCDEAJFJC : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public OJPKHAEBLGL GALKPGJPKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
		[CompilerGenerated]
		get
		{
			return default(OJPKHAEBLGL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public Guid CPBFEAFLDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x193BF80", Offset = "0x193AD80", VA = "0x18193BF80")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x59D0890", Offset = "0x59CF690", VA = "0x1859D0890")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IJBCDEAJFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x72B6E90", Offset = "0x72B5C90", VA = "0x1872B6E90")]
	public IJBCDEAJFJC(Guid PMBEKIBBKJF, OJPKHAEBLGL AAFMBEEMJAC, int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[IGNMLPIHKKI]
public class PAIDHJNCPFF : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public Guid CIEHFBMBNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public int HDOGKEOCBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public DateTime BHEHGKIFNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAE0", Offset = "0xA0D8E0", VA = "0x180A0EAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xD88FB0", Offset = "0xD87DB0", VA = "0x180D88FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x72BA200", Offset = "0x72B9000", VA = "0x1872BA200")]
	public PAIDHJNCPFF(Guid LDIMDMPDINA, string IHGFMOMOADA, int JAAEODMGDHM, DateTime OFNFOFHMHIK, int MFIBIFPFGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PAIDHJNCPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[IGNMLPIHKKI]
public class AHBLEFDBOLO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public Guid CIEHFBMBNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public int KNLINBNNPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public AHBLEFDBOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x4B5B010", Offset = "0x4B59E10", VA = "0x184B5B010")]
	public AHBLEFDBOLO(Guid LDIMDMPDINA, int OBEMPCGDLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[IGNMLPIHKKI]
public class JPKBIMOJNEA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public int KNLINBNNPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public Guid GJJBAHPCMPI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x193BF80", Offset = "0x193AD80", VA = "0x18193BF80")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x59D0890", Offset = "0x59CF690", VA = "0x1859D0890")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public int NBBJMKGDIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public Guid? MDCPPFIFGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xE8DC50", Offset = "0xE8CA50", VA = "0x180E8DC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x21EB370", Offset = "0x21EA170", VA = "0x1821EB370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public int MOJBKJCPIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA276F0", Offset = "0xA264F0", VA = "0x180A276F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x14D7010", Offset = "0x14D5E10", VA = "0x1814D7010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public Dictionary<Guid, Guid?> DIOOPKFKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JPKBIMOJNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x72B8140", Offset = "0x72B6F40", VA = "0x1872B8140")]
	public JPKBIMOJNEA(int OBEMPCGDLDJ, Guid NHEJHPMHFIP, int LACJOKGLHBH, Guid? FIHDKDACLDE, int DMKAFBNDALG, Dictionary<Guid, Guid?> MOGICHFJKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[IGNMLPIHKKI]
public class IOABAGGBBCO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public IHKKHFBENBM KANMOHJAPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
		[CompilerGenerated]
		get
		{
			return default(IHKKHFBENBM);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public MBILGBFPJKP? CDLAOKHFOMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xEFDE20", Offset = "0xEFCC20", VA = "0x180EFDE20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xF082F0", Offset = "0xF070F0", VA = "0x180F082F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public BalanceResponseDTO GLAMAFGAOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public List<GLNKJILIANA> IIEEGLFIPBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IOABAGGBBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x72B7400", Offset = "0x72B6200", VA = "0x1872B7400")]
	public IOABAGGBBCO(IHKKHFBENBM EMHGHLIPKOE, MBILGBFPJKP? POGBNIALGAF, BalanceResponseDTO BFCKEKAGFBB, List<GLNKJILIANA> LDOPKKGHONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x72B73F0", Offset = "0x72B61F0", VA = "0x1872B73F0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public enum OJPKHAEBLGL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public enum IHKKHFBENBM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public enum PLJLLNMIBDO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public interface CGCNPJINBDG
{
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	static IMAAKJGDPMH<PKCPMDDLLPP> MMLOCLEFPGN;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	static IMAAKJGDPMH<PKCPMDDLLPP> BBLGKFNEBHO;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	static IMAAKJGDPMH<Guid> KOKLFFAMHMA;

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HADGKGMEIJF<PKCPMDDLLPP?>?>? JCJCLMILIBK(Guid? AGGEDCBPBDE, long CEACGIDOODJ, string IHGFMOMOADA, string? CDDMBEEGKND, string? DBCDJMCMAJM, int NNBINNDLPGM, PLJLLNMIBDO BGGLOFIJEIA, [Optional] Dictionary<Guid, int>? NODKJNGMOOA, [Optional] Guid? DLKBONGECHE, bool KCOAHFLFPNO = false, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HADGKGMEIJF<PKCPMDDLLPP?>?>? FIPOEHKACMO(Guid LDIMDMPDINA, long CEACGIDOODJ, string IHGFMOMOADA, string? CDDMBEEGKND, string? DBCDJMCMAJM, int NNBINNDLPGM, PLJLLNMIBDO BGGLOFIJEIA, [Optional] Dictionary<Guid, int>? NODKJNGMOOA, [Optional] Guid? DLKBONGECHE, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ONAJOACHAJH> GLFMFOGFOKL(Guid LDIMDMPDINA, long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<PKCPMDDLLPP>> AEJJHKMEDDE(long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<HADGKGMEIJF<List<AHBLEFDBOLO>>> DLPKAKNGILI(long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HADGKGMEIJF<List<PAIDHJNCPFF>>> JDOMCGHMAGM(long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<IOABAGGBBCO> MDKCOHGKCLJ(Guid LDIMDMPDINA, long CEACGIDOODJ, int OBEMPCGDLDJ, int LACJOKGLHBH, Guid? LMBMIDCCOKJ, int DMKAFBNDALG, Dictionary<Guid, Guid?> AMMJNFCDCKE, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x72B2610", Offset = "0x72B1410", VA = "0x1872B2610")]
	static CGCNPJINBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[IGNMLPIHKKI]
public class LJHIFNOOPIO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public long FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public bool FJJCKMNNCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xA0B690", Offset = "0xA0A490", VA = "0x180A0B690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LJHIFNOOPIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface DKJNCOOLOJH
{
	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LJHIFNOOPIO> NHNGNOGNHJB(long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ONAJOACHAJH> KCOAHHNBAJH(long CEACGIDOODJ, bool OPLCKDFFAFK, [Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[DHFCNGCHGGB]
public class AFOEEGNLDMN<DataType> where DataType : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public long LDBABKCPOED
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public POKBHADPEGG CIDODMPPDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(POKBHADPEGG);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public BMEIJOCDMOI JCGMNDEBGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00")]
		[CompilerGenerated]
		get
		{
			return default(BMEIJOCDMOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xD8DB90", Offset = "0xD8C990", VA = "0x180D8DB90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public DataType NOKLNLDMACL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public AFOEEGNLDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[DHFCNGCHGGB]
public class KJNFLEGMLBJ<DataType> where DataType : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public long LDBABKCPOED
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public POKBHADPEGG CIDODMPPDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(POKBHADPEGG);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public BMEIJOCDMOI JCGMNDEBGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00")]
		[CompilerGenerated]
		get
		{
			return default(BMEIJOCDMOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xD8DB90", Offset = "0xD8C990", VA = "0x180D8DB90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public List<DataType> NOKLNLDMACL
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KJNFLEGMLBJ()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[DHFCNGCHGGB]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : OAAIBPONJHJ, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[DHFCNGCHGGB]
		public class ALEGLAIOOBG : LBLGPGHMOJK, OAAIBPONJHJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			[CompilerGenerated]
			private struct NMHMOFEOOGF : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041E")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041F")]
				public ALEGLAIOOBG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000420")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005EA")]
				[Cpp2IlInjected.Address(RVA = "0x54FEAF0", Offset = "0x54FD8F0", VA = "0x1854FEAF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005EB")]
				[Cpp2IlInjected.Address(RVA = "0x54FEDD0", Offset = "0x54FDBD0", VA = "0x1854FEDD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027D")]
			public MBILGBFPJKP BLMAODGDPJO
			{
				[Cpp2IlInjected.Token(Token = "0x60005E3")]
				[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
				[CompilerGenerated]
				get
				{
					return default(MBILGBFPJKP);
				}
				[Cpp2IlInjected.Token(Token = "0x60005E4")]
				[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027E")]
			public DataTypeDTO NOKLNLDMACL
			{
				[Cpp2IlInjected.Token(Token = "0x60005E5")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005E6")]
				[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x4DC3650", Offset = "0x4DC2450", VA = "0x184DC3650", Slot = "5")]
			public void HHDPONBNNOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x4DC3580", Offset = "0x4DC2380", VA = "0x184DC3580", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.ALEGLAIOOBG.NMHMOFEOOGF))]
			public Task GIBKODDCFJF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public ALEGLAIOOBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		public List<ALEGLAIOOBG> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x57EF240", Offset = "0x57EE040", VA = "0x1857EF240", Slot = "5")]
		public override void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[DHFCNGCHGGB]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : OAAIBPONJHJ, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[DHFCNGCHGGB]
		public class EDHPCGOBEFC : LBLGPGHMOJK, OAAIBPONJHJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			[CompilerGenerated]
			private struct IFILJCBKCJJ : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000424")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000425")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000426")]
				public EDHPCGOBEFC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005F7")]
				[Cpp2IlInjected.Address(RVA = "0x4D338B0", Offset = "0x4D326B0", VA = "0x184D338B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F8")]
				[Cpp2IlInjected.Address(RVA = "0x4D33B20", Offset = "0x4D32920", VA = "0x184D33B20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000280")]
			public MBILGBFPJKP BLMAODGDPJO
			{
				[Cpp2IlInjected.Token(Token = "0x60005F0")]
				[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
				[CompilerGenerated]
				get
				{
					return default(MBILGBFPJKP);
				}
				[Cpp2IlInjected.Token(Token = "0x60005F1")]
				[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000281")]
			public List<DataTypeDTO> NOKLNLDMACL
			{
				[Cpp2IlInjected.Token(Token = "0x60005F2")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005F3")]
				[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x45D95C0", Offset = "0x45D83C0", VA = "0x1845D95C0", Slot = "5")]
			public void HHDPONBNNOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x45D94F0", Offset = "0x45D82F0", VA = "0x1845D94F0", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.EDHPCGOBEFC.IFILJCBKCJJ))]
			public Task GIBKODDCFJF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public EDHPCGOBEFC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		public List<EDHPCGOBEFC> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x57EF240", Offset = "0x57EE040", VA = "0x1857EF240", Slot = "5")]
		public override void HHDPONBNNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[OGKELMEDAGH]
public class NAAGJOHPGFH : PurchaseBalanceUpdateResponseDTO<CAJGGKMOJIB>
{
	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x72B8FD0", Offset = "0x72B7DD0", VA = "0x1872B8FD0")]
	public NAAGJOHPGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[OGKELMEDAGH]
public class CHADFPDPBLM : PurchaseBalanceUpdateResponseDTO<CAJGGKMOJIB>.EDHPCGOBEFC
{
	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x72B2770", Offset = "0x72B1570", VA = "0x1872B2770")]
	public CHADFPDPBLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[IGNMLPIHKKI]
public class BBPBFFKNPGL : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public JGLJJMGKLGN HGJCOAMKFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public long MPCICGEILHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000284")]
	public GiftItemDTO? JIDPAOOCOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000285")]
	public long? JPAFMHJPFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x12E0300", Offset = "0x12DF100", VA = "0x1812E0300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x12E0BD0", Offset = "0x12DF9D0", VA = "0x1812E0BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000286")]
	public int FAINGEBGLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xD88FB0", Offset = "0xD87DB0", VA = "0x180D88FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x72B1DB0", Offset = "0x72B0BB0", VA = "0x1872B1DB0")]
	public BBPBFFKNPGL(JGLJJMGKLGN HLBJKBAFHIA, long LNEMGKKPNAE, GiftItemDTO? NGCOADOFPJB, int MBHFMJNJEFI = 1, [Optional] long? MHFKFHANFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[IGNMLPIHKKI]
public class PINKIKPMPBH : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000287")]
	public List<BBPBFFKNPGL> MCEDACFNFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000288")]
	public MOKDLLFJIKJ? CODLLEHFNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000289")]
	public POKBHADPEGG CIDODMPPDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(POKBHADPEGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public bool NDJBBLLPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xD4A770", Offset = "0xD49570", VA = "0x180D4A770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xD4A780", Offset = "0xD49580", VA = "0x180D4A780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public bool HOAEEFMHJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x13C2BC0", Offset = "0x13C19C0", VA = "0x1813C2BC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x26C0460", Offset = "0x26BF260", VA = "0x1826C0460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x72BA350", Offset = "0x72B9150", VA = "0x1872BA350")]
	public PINKIKPMPBH(List<BBPBFFKNPGL> GGPBNKCEJBC, MOKDLLFJIKJ? HGELOFJPHBB, POKBHADPEGG KCCJJMPBCCD, bool MJHJGOPOEIA, bool CABHNJBHIMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[IGNMLPIHKKI]
public class CHJJJKIEJLA : LBLGPGHMOJK, OAAIBPONJHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct JKPKGOBBHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public CHJJJKIEJLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x72B7E00", Offset = "0x72B6C00", VA = "0x1872B7E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x72B80E0", Offset = "0x72B6EE0", VA = "0x1872B80E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	internal static Action<CAJGGKMOJIB>? LDCPJIMPALB;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	internal static Func<CAJGGKMOJIB, Task>? ILANDHDGMLD;

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public CAJGGKMOJIB KINLDEIMDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public BADAFKCAGKI? BBCCDGIODFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x72B2880", Offset = "0x72B1680", VA = "0x1872B2880", Slot = "5")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x72B27B0", Offset = "0x72B15B0", VA = "0x1872B27B0", Slot = "6")]
	[AsyncStateMachine(typeof(JKPKGOBBHNG))]
	public virtual Task GIBKODDCFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CHJJJKIEJLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[OGKELMEDAGH]
public class HILGKCLGJKN : BalanceUpdateResponseDTO<CHJJJKIEJLA>
{
	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x72B6B40", Offset = "0x72B5940", VA = "0x1872B6B40")]
	public HILGKCLGJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[OGKELMEDAGH]
public class JEJAMNFLCOH : BalanceUpdateResponseDTO<CHJJJKIEJLA>.ALEGLAIOOBG
{
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x72B7B30", Offset = "0x72B6930", VA = "0x1872B7B30")]
	public JEJAMNFLCOH()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[IGNMLPIHKKI]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public OGMKPJCJPIA GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
			[CompilerGenerated]
			get
			{
				return default(OGMKPJCJPIA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[IGNMLPIHKKI]
public class EFEJJNPJICP : OAAIBPONJHJ, ELHHJKFDJGF
{
	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public IOIOJHBPKHI? IBGIHIDLEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	[IgnoreDataMember]
	public Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x72B48C0", Offset = "0x72B36C0", VA = "0x1872B48C0", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public JGLJJMGKLGN? NFNKGBGLIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public List<GDGAJLLAIPD>? KIGIOGIKEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public DateTime? MNOOMGGINGO
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x12E0300", Offset = "0x12DF100", VA = "0x1812E0300", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x12E0BD0", Offset = "0x12DF9D0", VA = "0x1812E0BD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public DateTime? BHALJKHPEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x13BBD50", Offset = "0x13BAB50", VA = "0x1813BBD50", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x13BA7E0", Offset = "0x13B95E0", VA = "0x1813BA7E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	public DateTime? JDNEKGGGFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xD55D40", Offset = "0xD54B40", VA = "0x180D55D40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x59CD1F0", Offset = "0x59CBFF0", VA = "0x1859CD1F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000299")]
	public bool LHHLNJCGFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xC26320", Offset = "0xC25120", VA = "0x180C26320", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xC25B50", Offset = "0xC24950", VA = "0x180C25B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public bool CLNGNGFDGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x1115D40", Offset = "0x1114B40", VA = "0x181115D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x1115D50", Offset = "0x1114B50", VA = "0x181115D50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	public bool HAHMNKAHJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xEDD4D0", Offset = "0xEDC2D0", VA = "0x180EDD4D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x15B1550", Offset = "0x15B0350", VA = "0x1815B1550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public bool JJBLPNKHDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xED8EB0", Offset = "0xED7CB0", VA = "0x180ED8EB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xEDD7C0", Offset = "0xEDC5C0", VA = "0x180EDD7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x72B4940", Offset = "0x72B3740", VA = "0x1872B4940")]
	public static EFEJJNPJICP NGKBBPIEOJH(Guid FIBIOFOKNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public EFEJJNPJICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[IGNMLPIHKKI]
public class IDIIMNAIHOK
{
	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public string NCJJGDBANLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public string PFMCFOAFGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public Dictionary<int, OMEMOEHPCDA> IEPDCLJKKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public Dictionary<string, int> PPHDNEEOFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public Dictionary<EKEEPBEIMEL, List<int>> EEJEHLGMHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public Dictionary<string, string> NIODBHMADPF
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IDIIMNAIHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum EKEEPBEIMEL
{
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[IGNMLPIHKKI]
public class OMEMOEHPCDA : IOHGOAPFMCL
{
	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public AJJFEMDAEDB KNBOJOPNOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(AJJFEMDAEDB);
		}
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public bool MAOMENDDNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x1173110", Offset = "0x1171F10", VA = "0x181173110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x13C56B0", Offset = "0x13C44B0", VA = "0x1813C56B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public bool MLMJAOOADJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBD50", Offset = "0x1DCAB50", VA = "0x181DCBD50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBBE0", Offset = "0x1DCA9E0", VA = "0x181DCBBE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public string EGJGCKKDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public string CJDBLCJACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public string LGCKBOMJBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public string KOJDEPPGBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public Dictionary<PAMJNKEHFFA, string> HACPILIEAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x13C5700", Offset = "0x13C4500", VA = "0x1813C5700")]
	public OMEMOEHPCDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[IGNMLPIHKKI]
public class PEOFLIDENDO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public IReadOnlyList<IOIOJHBPKHI>? GLKKPFGJGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PEOFLIDENDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public PEOFLIDENDO(IReadOnlyList<IOIOJHBPKHI>? BJJOHONFGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public enum BGFFMOHEJKA
{
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface ELHHJKFDJGF
{
	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	JGLJJMGKLGN? NFNKGBGLIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	List<GDGAJLLAIPD>? KIGIOGIKEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	DateTime? MNOOMGGINGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	DateTime? BHALJKHPEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	DateTime? JDNEKGGGFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	bool LHHLNJCGFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	bool HAHMNKAHJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	bool JJBLPNKHDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface DDIJGGBHHIN
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action JDDGPABHIDN;

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task CDMOLGIFKLC(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KFGOOCMAFDO(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DIJEKLGPOOD([Out] KPIAFGIBOKF EKMDFFAGMPN);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface KPIAFGIBOKF
{
	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	string NCJJGDBANLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	string PFMCFOAFGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	IReadOnlyDictionary<EKEEPBEIMEL, IReadOnlyList<IOHGOAPFMCL>> MCFLPMHNJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	IReadOnlyDictionary<string, string> NIODBHMADPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface IOHGOAPFMCL
{
	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	string CJDBLCJACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	string EGJGCKKDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	string LGCKBOMJBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	string KOJDEPPGBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface PAJCNFAEALM
{
	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	JPAKMCHALJJ GALKPGJPKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	string OCNPBLDHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	string KPDIBFFPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	string JEONBCCPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	bool JJBLPNKHDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	bool HAHMNKAHJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	NAHJKMGHOEN FHFICPPBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	string JKAANLEPEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	NDBIOOABJBM? MDIHPCFBLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	BGFFMOHEJKA GGBOGHLJKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	bool OIIGMGNFIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[IGNMLPIHKKI]
public class JGLJJMGKLGN : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	public JPAKMCHALJJ KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(JPAKMCHALJJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	public int? AIJHGNCDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xEFDE20", Offset = "0xEFCC20", VA = "0x180EFDE20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xF082F0", Offset = "0xF070F0", VA = "0x180F082F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	public Guid? IDIICJAOKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9D0", Offset = "0xA0C7D0", VA = "0x180A0D9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA0D950", Offset = "0xA0C750", VA = "0x180A0D950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x72B7C30", Offset = "0x72B6A30", VA = "0x1872B7C30")]
	public static JGLJJMGKLGN NLEKFIFDMKA(int HGDCEGNJLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x72B7B70", Offset = "0x72B6970", VA = "0x1872B7B70")]
	public static JGLJJMGKLGN HNAOCHJDCBN(Guid FIBIOFOKNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JGLJJMGKLGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public enum JPAKMCHALJJ
{
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[IGNMLPIHKKI]
public class GDGAJLLAIPD : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	public POKBHADPEGG CIDODMPPDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(POKBHADPEGG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	public int GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xB97DF0", Offset = "0xB96BF0", VA = "0x180B97DF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xC82D00", Offset = "0xC81B00", VA = "0x180C82D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	public FFNEPJIAONI OAJLAFJPGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0xED6F10", Offset = "0xED5D10", VA = "0x180ED6F10", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x72B5BA0", Offset = "0x72B49A0", VA = "0x1872B5BA0")]
	public int MANOBFDLLJO(DateTime LGDPMOOCLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GDGAJLLAIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[IGNMLPIHKKI]
public class FFNEPJIAONI : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	public int PMPOGJODLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	public DateTime? CIBKKNGKMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xDF46D0", Offset = "0xDF34D0", VA = "0x180DF46D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public DateTime? JGLJPKPPHFG
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x12E0300", Offset = "0x12DF100", VA = "0x1812E0300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x12E0BD0", Offset = "0x12DF9D0", VA = "0x1812E0BD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x72B57E0", Offset = "0x72B45E0", VA = "0x1872B57E0")]
	public bool NEJFBOLNLIK(DateTime LGDPMOOCLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x72B58D0", Offset = "0x72B46D0", VA = "0x1872B58D0")]
	public int NPDCHFAOCFI(DateTime LGDPMOOCLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x72B56F0", Offset = "0x72B44F0", VA = "0x1872B56F0")]
	public TimeSpan? AFDPFAGDNNF(DateTime LGDPMOOCLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FFNEPJIAONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public enum MOKDLLFJIKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum KIMHCOEHNMG
{
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum JALLABNHNMC
{
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public enum IEIJBHEMKCE
{
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum NOPKDLAMBEE
{
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[IGNMLPIHKKI]
public class CLOCKGIEBFH : IEquatable<CLOCKGIEBFH>
{
	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	public int? KBHCBOKLBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public int? BMNPLLIJJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public int? MAGIPOKCJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public List<int>? CIOEHFDIJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x72B3310", Offset = "0x72B2110", VA = "0x1872B3310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x72B3030", Offset = "0x72B1E30", VA = "0x1872B3030")]
	public static CLOCKGIEBFH FCKIEDNHPCN(int? EOLGKMIMIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x72B2EB0", Offset = "0x72B1CB0", VA = "0x1872B2EB0", Slot = "4")]
	public bool Equals(CLOCKGIEBFH? HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x72B3090", Offset = "0x72B1E90", VA = "0x1872B3090")]
	private static bool FOMHCAFHILM(List<int>? CHIPBNNCPBF, List<int>? MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x72B2C80", Offset = "0x72B1A80", VA = "0x1872B2C80", Slot = "0")]
	public override bool Equals(object? GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x72B3130", Offset = "0x72B1F30", VA = "0x1872B3130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CLOCKGIEBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct GOHCGJMKCAB : IEquatable<GOHCGJMKCAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public readonly JPAKMCHALJJ GALKPGJPKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private readonly int AIJHGNCDMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private readonly Guid IDIICJAOKAC;

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public Guid CAJGHADLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x72B5E00", Offset = "0x72B4C00", VA = "0x1872B5E00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public int FPGLPBKEALO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x72B6060", Offset = "0x72B4E60", VA = "0x1872B6060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public string BEECKCBNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x72B6070", Offset = "0x72B4E70", VA = "0x1872B6070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x72B6300", Offset = "0x72B5100", VA = "0x1872B6300")]
	public static bool KFANGKAFJMA(string MOOAPBNCPIN, [Out] GOHCGJMKCAB POFODOPFKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x72B60C0", Offset = "0x72B4EC0", VA = "0x1872B60C0")]
	public static GOHCGJMKCAB INMPNEHKJFB(int FONJFDCCINO)
	{
		return default(GOHCGJMKCAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x72B6740", Offset = "0x72B5540", VA = "0x1872B6740")]
	public static GOHCGJMKCAB MAIGPEFAPFK(Guid FONJFDCCINO)
	{
		return default(GOHCGJMKCAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x72B61F0", Offset = "0x72B4FF0", VA = "0x1872B61F0")]
	private static bool KEEKAGGOIBB(string MOOAPBNCPIN, [Out] JPAKMCHALJJ GMDHJIHAEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x72B6940", Offset = "0x72B5740", VA = "0x1872B6940")]
	private GOHCGJMKCAB(JPAKMCHALJJ GMDHJIHAEGA, int? DFMAIJDLFDA, Guid? FIBIOFOKNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x72B5F60", Offset = "0x72B4D60", VA = "0x1872B5F60", Slot = "4")]
	public bool Equals(GOHCGJMKCAB HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x72B5E70", Offset = "0x72B4C70", VA = "0x1872B5E70", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x72B5FD0", Offset = "0x72B4DD0", VA = "0x1872B5FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x72B6890", Offset = "0x72B5690", VA = "0x1872B6890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
[IGNMLPIHKKI]
public abstract class PNOKONLOLNA : IEquatable<PNOKONLOLNA>, OAAIBPONJHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public Guid BPLOOBBHEML;

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x72BAA90", Offset = "0x72B9890", VA = "0x1872BAA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x72BAA10", Offset = "0x72B9810", VA = "0x1872BAA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x72B8CA0", Offset = "0x72B7AA0", VA = "0x1872B8CA0", Slot = "4")]
	public bool Equals(PNOKONLOLNA HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x72BA900", Offset = "0x72B9700", VA = "0x1872BA900", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract PNOKONLOLNA LAGKNEOGNDP();

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected PNOKONLOLNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum DMMDHLMLBIF
{
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[IGNMLPIHKKI]
public class IOIOJHBPKHI : PNOKONLOLNA, IEquatable<IOIOJHBPKHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public DMMDHLMLBIF GMDHJIHAEGA;

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x72B7620", Offset = "0x72B6420", VA = "0x1872B7620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x72B74C0", Offset = "0x72B62C0", VA = "0x1872B74C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IOIOJHBPKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x72B76C0", Offset = "0x72B64C0", VA = "0x1872B76C0")]
	public IOIOJHBPKHI(DMMDHLMLBIF GMDHJIHAEGA, Guid BPLOOBBHEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x72B75B0", Offset = "0x72B63B0", VA = "0x1872B75B0")]
	public static IOIOJHBPKHI MAIGPEFAPFK(Guid MENEGNEOGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x72B7470", Offset = "0x72B6270", VA = "0x1872B7470", Slot = "7")]
	public bool Equals(IOIOJHBPKHI HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x72B7540", Offset = "0x72B6340", VA = "0x1872B7540", Slot = "6")]
	public override PNOKONLOLNA LAGKNEOGNDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public static class FEHDAGHAGGP
{
	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x72B5610", Offset = "0x72B4410", VA = "0x1872B5610")]
	public static IOIOJHBPKHI HLFNKPBADEA(this BIOLDJJDCCM HHHFHHLBBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x72B5520", Offset = "0x72B4320", VA = "0x1872B5520")]
	public static IOIOJHBPKHI BJJEBOHCGPP(string IIHFEOOCGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x72B5680", Offset = "0x72B4480", VA = "0x1872B5680")]
	public static IOIOJHBPKHI JNFPGDFLLAH(Guid KMPFMAAMMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[IGNMLPIHKKI]
public class BIOLDJJDCCM : KDCOIBLMAFL, OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public DMMDHLMLBIF GALKPGJPKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(DMMDHLMLBIF);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public Guid IBGIHIDLEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x193BF80", Offset = "0x193AD80", VA = "0x18193BF80")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x59D0890", Offset = "0x59CF690", VA = "0x1859D0890")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public string OGEKIGBBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public long? FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xEE56F0", Offset = "0xEE44F0", VA = "0x180EE56F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xEE5820", Offset = "0xEE4620", VA = "0x180EE5820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public long GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xE52900", Offset = "0xE51700", VA = "0x180E52900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public Guid? JPFGDHKCHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x72B1FF0", Offset = "0x72B0DF0", VA = "0x1872B1FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x72B1FE0", Offset = "0x72B0DE0", VA = "0x1872B1FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xE8BD70", Offset = "0xE8AB70", VA = "0x180E8BD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public DateTime LMHCPFIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA0D8A0", Offset = "0xA0C6A0", VA = "0x180A0D8A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xE8BD80", Offset = "0xE8AB80", VA = "0x180E8BD80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BIOLDJJDCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x72B20C0", Offset = "0x72B0EC0", VA = "0x1872B20C0")]
	public BIOLDJJDCCM(DMMDHLMLBIF GMDHJIHAEGA, Guid BPLOOBBHEML, [Optional] string IHGFMOMOADA, [Optional] string CDDMBEEGKND, [Optional] string DBCDJMCMAJM, [Optional] long? CEACGIDOODJ, long NNBINNDLPGM = 0L, [Optional] Guid? ACFBLBKOEFL, [Optional] DateTime KJBIJEAOBEA, [Optional] DateTime KOIBGPKNMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x72B2010", Offset = "0x72B0E10", VA = "0x1872B2010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public enum MJJKDBOAPEA
{
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public enum DMAOPJNIPLM
{
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[IGNMLPIHKKI]
public class INCJKKKEBEA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public DMAOPJNIPLM IBGOAACNDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(DMAOPJNIPLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public List<string> MDJKMHIGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x72B70B0", Offset = "0x72B5EB0", VA = "0x1872B70B0")]
	public string HIJFCCEINFC(int OKKAFDHPCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public INCJKKKEBEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[IGNMLPIHKKI]
public class LKEJPEGHBLK : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public string IFIMJEFENMP
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public MJJKDBOAPEA KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(MJJKDBOAPEA);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LKEJPEGHBLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public static class ILMDENGAHOK
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public const string CFAFKAEAKGE = "costume";

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public const string KGCMAHHFHGM = "gadget";

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public const string GDFNJEJILDN = "holotar";

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public const string IOAOHCHMOGI = "large";

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public const string BGAMMOGEGKL = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public const string MLBBECJIMIF = "small";

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public const string OOGALCHDJBF = "sound";

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public const string ONKEHFLKEBJ = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public const string PMNECKNIMJO = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public const string GBBCKFJGNKF = "r2";

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public static List<string> OEFAKBLHMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x72B6EE0", Offset = "0x72B5CE0", VA = "0x1872B6EE0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public static class KHOBNKHDIKE
{
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public const string CIEPKKLLBJP = "beta";

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public const string IFKEIPFEHNO = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[IGNMLPIHKKI]
public class CAHNJPOONOB : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public List<string> EOAIBKFNBFM
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public List<string> PEIDNOLEKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public List<string> OBELBNDOLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CAHNJPOONOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public class AFOCKABHFHI : IEquatable<AFOCKABHFHI>
{
	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	protected virtual Type IJONAJDJLMA
	{
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x72B0E50", Offset = "0x72AFC50", VA = "0x1872B0E50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public BGOHMAHABDH? ABKCLAPEKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public HttpMethod? MGFFLDADLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public string? OLDAPIPJIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x72B15E0", Offset = "0x72B03E0", VA = "0x1872B15E0")]
	public AFOCKABHFHI(BGOHMAHABDH? ABKCLAPEKEN, HttpMethod? MGFFLDADLAE, string? OLDAPIPJIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x72B1470", Offset = "0x72B0270", VA = "0x1872B1470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x72B1310", Offset = "0x72B0110", VA = "0x1872B1310", Slot = "6")]
	protected virtual bool OAAPMMHLNDN(StringBuilder NDOKADCMHOI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0xF38BE0", Offset = "0xF379E0", VA = "0x180F38BE0")]
	public static bool INFPGDPCEAI(AFOCKABHFHI? MHEGIEGDFMG, AFOCKABHFHI? MLGJODBONID)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0xF38BB0", Offset = "0xF379B0", VA = "0x180F38BB0")]
	public static bool PBEBFPKJKLO(AFOCKABHFHI? MHEGIEGDFMG, AFOCKABHFHI? MLGJODBONID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x72B1110", Offset = "0x72AFF10", VA = "0x1872B1110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x72B1040", Offset = "0x72AFE40", VA = "0x1872B1040", Slot = "0")]
	public override bool Equals(object? GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x72B0EB0", Offset = "0x72AFCB0", VA = "0x1872B0EB0", Slot = "7")]
	public virtual bool Equals(AFOCKABHFHI? HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x72B1280", Offset = "0x72B0080", VA = "0x1872B1280", Slot = "8")]
	public virtual AFOCKABHFHI HCLLDOBCDFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x72B1580", Offset = "0x72B0380", VA = "0x1872B1580")]
	protected AFOCKABHFHI(AFOCKABHFHI BECJIFFOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x72B10D0", Offset = "0x72AFED0", VA = "0x1872B10D0")]
	public void GOKNENBJBKI([Out] BGOHMAHABDH? ABKCLAPEKEN, [Out] HttpMethod? MGFFLDADLAE, [Out] string? OLDAPIPJIPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public class DIIPJMCINIF : IEquatable<DIIPJMCINIF>
{
	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	protected virtual Type IJONAJDJLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x72B3DD0", Offset = "0x72B2BD0", VA = "0x1872B3DD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public int JNHCJFBCMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public FLJONFIEIFO DOHOFCFCBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xB97DF0", Offset = "0xB96BF0", VA = "0x180B97DF0")]
		[CompilerGenerated]
		get
		{
			return default(FLJONFIEIFO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xC82D00", Offset = "0xC81B00", VA = "0x180C82D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x72B43D0", Offset = "0x72B31D0", VA = "0x1872B43D0")]
	public DIIPJMCINIF(int JNHCJFBCMEL, FLJONFIEIFO DOHOFCFCBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x72B42C0", Offset = "0x72B30C0", VA = "0x1872B42C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x72B4190", Offset = "0x72B2F90", VA = "0x1872B4190", Slot = "6")]
	protected virtual bool OAAPMMHLNDN(StringBuilder NDOKADCMHOI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0xF38BE0", Offset = "0xF379E0", VA = "0x180F38BE0")]
	public static bool INFPGDPCEAI(DIIPJMCINIF? MHEGIEGDFMG, DIIPJMCINIF? MLGJODBONID)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0xF38BB0", Offset = "0xF379B0", VA = "0x180F38BB0")]
	public static bool PBEBFPKJKLO(DIIPJMCINIF? MHEGIEGDFMG, DIIPJMCINIF? MLGJODBONID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x72B4010", Offset = "0x72B2E10", VA = "0x1872B4010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x72B3E30", Offset = "0x72B2C30", VA = "0x1872B3E30", Slot = "0")]
	public override bool Equals(object? GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x72B3EC0", Offset = "0x72B2CC0", VA = "0x1872B3EC0", Slot = "7")]
	public virtual bool Equals(DIIPJMCINIF? HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x72B4120", Offset = "0x72B2F20", VA = "0x1872B4120", Slot = "8")]
	public virtual DIIPJMCINIF HCLLDOBCDFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0xB97F00", Offset = "0xB96D00", VA = "0x180B97F00")]
	protected DIIPJMCINIF(DIIPJMCINIF BECJIFFOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x72B4000", Offset = "0x72B2E00", VA = "0x1872B4000")]
	public void GOKNENBJBKI([Out] int JNHCJFBCMEL, [Out] FLJONFIEIFO DOHOFCFCBCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public enum FLJONFIEIFO
{
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public interface CAKLEHCNEBM
{
	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<AFOCKABHFHI, DIIPJMCINIF> CADEKDBHPMG();

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBJKFKBDKIP(AFOCKABHFHI MAKJJJECHHB, DIIPJMCINIF CFDGGKIIHOI);

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHOPJFDNJMK(AFOCKABHFHI MAKJJJECHHB);

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGMJODCPHFM();

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task IEGDGKLLJJL(BGOHMAHABDH BMACFGNFKCL, HttpMethod KAHHHPDDBEL, string ALKKHIPFNPE, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[DHFCNGCHGGB]
public class IEHHPLNDNNN<TResult> where TResult : OAAIBPONJHJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public IReadOnlyList<TResult> GGNBHIMLBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public long EFKDNHPFNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IEHHPLNDNNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public enum BGCEKNNEBPO
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public interface OOKEPPFFMHD : OJFIPNNEBDJ
{
	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	bool DABNHEMKDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long NHEJHPMHFIP, ODFPIELGIHC PGJGOOMAMEN);

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CFGDEKGIHBB> PurchaseAsync(ODFPIELGIHC PGJGOOMAMEN, CLOCKGIEBFH DIKLGJIMMOL);

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(FJKNKCFPMIE OPIDPFAKFHC, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public interface OJFIPNNEBDJ
{
	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	bool ONJMFEHPGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public interface OAGDKCLKCLC
{
	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	int KNEIKKILNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<ODFPIELGIHC>> BANOBGFKBMC(bool KFIIBFPEOPB = false, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGPHKGHDLHP([Out] ODFPIELGIHC? OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ODFPIELGIHC> JBKFJBOIEPA(bool KFIIBFPEOPB = false, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPKICOIFCLL(string KLOPBEMIGAO = "");
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public interface KDMHFCILFFO
{
	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NFHHECNIDIL(FJKNKCFPMIE OPIDPFAKFHC, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HMPMJFBELCH(FJKNKCFPMIE OPIDPFAKFHC, CancellationToken GHKBKDKNIOM, [Optional] ELEFIGKIGLM? PFIMKODDPEH);
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public interface ELEFIGKIGLM
{
	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INKCIPOABFJ(string KMIPFFIBFDN);
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public interface PHHDOCKGPLG
{
	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CBLFFCCCOIK(FJKNKCFPMIE BPJOEKMNEDG, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public interface KFIHNPCHLJG
{
	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	bool KMLLBKBMDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public interface EHBEENDPMGG
{
	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJKNKCFPMIE FJJLEJILJBH(ODFPIELGIHC PGJGOOMAMEN, CLOCKGIEBFH DIKLGJIMMOL, string JEJENINNLJN, [Optional] KDMHFCILFFO? HGNBANNPLOC);
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public interface HAPBEMAJNMG
{
	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HMCCLKDHCFI(PHHDOCKGPLG EAEFPGALELD);

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJHAPNHOOJK(PHHDOCKGPLG EAEFPGALELD);

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task EKEKBCEDCDG(FJKNKCFPMIE OPIDPFAKFHC, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public interface FJKNKCFPMIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	ILMLGDPDEFJ LEILAPGILAB
	{
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	ODFPIELGIHC EFHEEIOPGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	CLOCKGIEBFH HBLJAKCIIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	string CNCJMNJMOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	string AGDHNMNAFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EACDMHLEFCF> MEGNADKDMNK(CancellationToken KKIGNHNCIEJ, [Optional] ELEFIGKIGLM? PFIMKODDPEH);

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PGBFLNHLELG(string IDNIHMABKME);

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PGBFLNHLELG<T>(Func<T, string> IDNIHMABKME, [In] T KPIJAHLABBG);
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public abstract class CJPGEKJHAKK
{
	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected CJPGEKJHAKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public enum KBCMBKAIGNB
{
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public enum PPMBGOAKKAF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
[IGNMLPIHKKI]
public class ODFPIELGIHC : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public int KCOONFNMDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public string OGEKIGBBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public int GBLLGFHMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA123A0", Offset = "0xA111A0", VA = "0x180A123A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11510", VA = "0x180A12710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public string JBDBMIGPFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public string KEGPKNNNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	[DataMember(Name = "PsnProductLabel")]
	public string BFKNCHCLIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public string KDDCBJLEILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public string PBDIECKGPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public string GGHEMDHINKH
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public string DGJBDGOAJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFD0", Offset = "0xA0BDD0", VA = "0x180A0CFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public string IEHKKEOEFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED20", Offset = "0xA0DB20", VA = "0x180A0ED20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public bool IEDGGKNECNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xC70730", Offset = "0xC6F530", VA = "0x180C70730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xC6FB00", Offset = "0xC6E900", VA = "0x180C6FB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public bool JMHNCADGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x161A470", Offset = "0x1619270", VA = "0x18161A470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x161A650", Offset = "0x1619450", VA = "0x18161A650")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public MDHPJMDFJII NOKLNLDMACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9C0", Offset = "0xA0C7C0", VA = "0x180A0D9C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xA0D960", Offset = "0xA0C760", VA = "0x180A0D960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	[IgnoreDataMember]
	public string NJDIPBMKMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA0D980", Offset = "0xA0C780", VA = "0x180A0D980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA30", Offset = "0xA0C830", VA = "0x180A0DA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	[IgnoreDataMember]
	public string POKJFMDLLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xBFED10", Offset = "0xBFDB10", VA = "0x180BFED10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x135D320", Offset = "0x135C120", VA = "0x18135D320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	[IgnoreDataMember]
	public string BNGENANAJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA10", Offset = "0xA0C810", VA = "0x180A0DA10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA0D930", Offset = "0xA0C730", VA = "0x180A0D930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	[IgnoreDataMember]
	public CJPGEKJHAKK ODNEABIDMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xCFC430", Offset = "0xCFB230", VA = "0x180CFC430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xE8AF40", Offset = "0xE89D40", VA = "0x180E8AF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	[IgnoreDataMember]
	public bool HOIBAAFNAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x72B94C0", Offset = "0x72B82C0", VA = "0x1872B94C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	[IgnoreDataMember]
	public string PCDJPKOCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC20", Offset = "0xA0AA20", VA = "0x180A0BC20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC50", Offset = "0xA0AA50", VA = "0x180A0BC50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x72B93D0", Offset = "0x72B81D0", VA = "0x1872B93D0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x72B9330", Offset = "0x72B8130", VA = "0x1872B9330")]
	public static ODFPIELGIHC DPNBIJLANCN(int FONJFDCCINO, string IHGFMOMOADA, string DBCDJMCMAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x72B94E0", Offset = "0x72B82E0", VA = "0x1872B94E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public ODFPIELGIHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
[IGNMLPIHKKI]
public class MDHPJMDFJII : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public List<int> OLHDMHNBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public string BGIMHHCKDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public INLCLBPKOKJ MHCACJPOFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0xED6F10", Offset = "0xED5D10", VA = "0x180ED6F10", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MDHPJMDFJII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public readonly struct EACDMHLEFCF
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	public enum OBNBHMMGANG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public readonly OBNBHMMGANG BJEDEKIAONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	public readonly PPMBGOAKKAF AADKENNIHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public readonly KBCMBKAIGNB CGBFEKAPFKC;

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x72B47E0", Offset = "0x72B35E0", VA = "0x1872B47E0")]
	private EACDMHLEFCF(OBNBHMMGANG JNOIIIFBOLM, PPMBGOAKKAF BGPJFEMOMCA = PPMBGOAKKAF.Unknown, KBCMBKAIGNB HFMLPJKGANC = KBCMBKAIGNB.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x72B4780", Offset = "0x72B3580", VA = "0x1872B4780")]
	public static EACDMHLEFCF LGKACBKCCFB()
	{
		return default(EACDMHLEFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x72B47C0", Offset = "0x72B35C0", VA = "0x1872B47C0")]
	public static EACDMHLEFCF PBLFCHFNKLM()
	{
		return default(EACDMHLEFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x72B47A0", Offset = "0x72B35A0", VA = "0x1872B47A0")]
	public static EACDMHLEFCF NBJHKBOJJKI(PPMBGOAKKAF BGPJFEMOMCA, KBCMBKAIGNB HFMLPJKGANC)
	{
		return default(EACDMHLEFCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public enum OENAJGDDDAO
{
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public enum JFPGMFOEDLO
{
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[IGNMLPIHKKI]
public class INLCLBPKOKJ : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public OENAJGDDDAO OHCKBHMGBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(OENAJGDDDAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public JFPGMFOEDLO HGDDMIHMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xB97DF0", Offset = "0xB96BF0", VA = "0x180B97DF0")]
		[CompilerGenerated]
		get
		{
			return default(JFPGMFOEDLO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xC82D00", Offset = "0xC81B00", VA = "0x180C82D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public bool EFBBFPDNDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA0B690", Offset = "0xA0A490", VA = "0x180A0B690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000787")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public INLCLBPKOKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public enum ILMLGDPDEFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[IGNMLPIHKKI]
public class NLJEANMDAIC : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public string FBBBPNJFANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public BKADGBHGPFO? IPIMIGEMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public string? FHMJKBFIMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public bool NJLPPGLDCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public FNKMNMEGPGP NLEDFONIOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public string? NENFOCFKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public string? PEPCLHOAPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public string? LIEKEOKLCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public NLJEANMDAIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[IGNMLPIHKKI]
public class CMNPKECDPCO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public string JAOBBLBJLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public BKADGBHGPFO? IPIMIGEMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public bool NJLPPGLDCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public FNKMNMEGPGP NLEDFONIOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public string? PEPCLHOAPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CMNPKECDPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[IGNMLPIHKKI]
public class FNKMNMEGPGP : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public string DPIBDAAGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public bool LGCMFNCPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xA0B690", Offset = "0xA0A490", VA = "0x180A0B690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public bool GLFJDFAKPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xF89B00", Offset = "0xF88900", VA = "0x180F89B00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xF898B0", Offset = "0xF886B0", VA = "0x180F898B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public bool BEMAMHFBNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x10B8B30", Offset = "0x10B7930", VA = "0x1810B8B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x147A2C0", Offset = "0x14790C0", VA = "0x18147A2C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public bool ACGOHOFAKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x10B8B20", Offset = "0x10B7920", VA = "0x1810B8B20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x5503630", Offset = "0x5502430", VA = "0x185503630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x72B5AC0", Offset = "0x72B48C0", VA = "0x1872B5AC0")]
	public FNKMNMEGPGP(string JJMJEGPMKJL, bool NAEOIDLMAAJ, bool IGLFHAOFCLM, bool BHEMLAOCMNA, bool EFAHFHFKNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[IGNMLPIHKKI]
public class IFIOGDEOKAC : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public string LIEKEOKLCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public string NENFOCFKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public string NOOBEEEKGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public string? PDGLIICNDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public float HONNFFDHKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xC2C270", Offset = "0xC2B070", VA = "0x180C2C270")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xF524F0", Offset = "0xF512F0", VA = "0x180F524F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IFIOGDEOKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[IGNMLPIHKKI]
public class LILMGJCIPLC : OPBMCPPAMED, OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public string BNMJOLDIMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public string KLJLBLKKEIK
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "6")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LILMGJCIPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[IGNMLPIHKKI]
public class FMNNCHGLFNP : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public long MOMDHFMMIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public decimal BMJHGJKOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xDF46D0", Offset = "0xDF34D0", VA = "0x180DF46D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FMNNCHGLFNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[IGNMLPIHKKI]
public class GEGGHKOGIGB : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public string BNMJOLDIMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public string KFGIKLJHKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GEGGHKOGIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public GEGGHKOGIGB(string BBAEOJCMCPP, string FPHCMDLADLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[IGNMLPIHKKI]
public class LIOKIJHBOLB : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public string KFGIKLJHKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LIOKIJHBOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
[IGNMLPIHKKI]
public class LPMJEIJGDAO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public string LIEKEOKLCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public string FBBBPNJFANI
	{
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public bool GJLHDKHMPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LPMJEIJGDAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[IGNMLPIHKKI]
public class BPIJLHOAFLK : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public string IOHBNCAAHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public decimal ABHNNBBFEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xDF46D0", Offset = "0xDF34D0", VA = "0x180DF46D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BPIJLHOAFLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[IGNMLPIHKKI]
public class OGIALJMFKIO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public int OCNPBLDHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public string KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public string? KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public IReadOnlyList<int> JIDHFHBDAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public string? HFIKHEIKFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x72B9550", Offset = "0x72B8350", VA = "0x1872B9550")]
	public OGIALJMFKIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[IGNMLPIHKKI]
public class FILHKIEJJCO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public int OCNPBLDHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public Guid? IDIICJAOKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x21EB470", Offset = "0x21EA270", VA = "0x1821EB470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x21EB160", Offset = "0x21E9F60", VA = "0x1821EB160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public string KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public List<OGIALJMFKIO> LMPPEAHCIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public List<OGIALJMFKIO> KJGAOFHAFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public string? KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public string? HFIKHEIKFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000348")]
	public string? OEFBFJAFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x72B5900", Offset = "0x72B4700", VA = "0x1872B5900", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x72B5930", Offset = "0x72B4730", VA = "0x1872B5930")]
	public FILHKIEJJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[IGNMLPIHKKI]
public class PIMIMCHNJKA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000349")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	public FILHKIEJJCO LMPPEAHCIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	public FILHKIEJJCO KJGAOFHAFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	public string? OEFBFJAFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x72BA2F0", Offset = "0x72B90F0", VA = "0x1872BA2F0", Slot = "5")]
	public virtual void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PIMIMCHNJKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[IGNMLPIHKKI]
public class OCMNCGCKPEH : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	public IReadOnlyList<FILHKIEJJCO> BELMPEMPMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	public IReadOnlyList<PIMIMCHNJKA> FOFMOHMCCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public IReadOnlyList<OCMNCGCKPEH> JPFCCDGKEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public string? OEFBFJAFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x72B91E0", Offset = "0x72B7FE0", VA = "0x1872B91E0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x72B9210", Offset = "0x72B8010", VA = "0x1872B9210")]
	public OCMNCGCKPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[IGNMLPIHKKI]
public class BKADGBHGPFO : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public string KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public List<BKADGBHGPFO>? HDOMAGFGOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x72B2180", Offset = "0x72B0F80", VA = "0x1872B2180", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BKADGBHGPFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[IGNMLPIHKKI]
public class PAGDDJMFAAA : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public string JNFEGONPJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public string BFINDKPOMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PAGDDJMFAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
[IGNMLPIHKKI]
public class MLLNBPGFAIJ : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public string OCNPBLDHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public OCMNCGCKPEH ECECOJLOMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public BKADGBHGPFO? IPIMIGEMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public IReadOnlyList<PAGDDJMFAAA> GIEIENJOOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public string? JAOBBLBJLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0x72B8D50", Offset = "0x72B7B50", VA = "0x1872B8D50", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000831")]
	[Cpp2IlInjected.Address(RVA = "0x72B8DC0", Offset = "0x72B7BC0", VA = "0x1872B8DC0")]
	public MLLNBPGFAIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[IGNMLPIHKKI]
public class BJCHAHBBDOF : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public AEMAHMMCBBC<MLLNBPGFAIJ> IBGOAACNDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public decimal NEIPHNBNNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xDF46D0", Offset = "0xDF34D0", VA = "0x180DF46D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x7075BF0", Offset = "0x70749F0", VA = "0x187075BF0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BJCHAHBBDOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public enum ECGMAJDODFD
{
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
[IGNMLPIHKKI]
public class CODPEOEOKGF : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public ECGMAJDODFD MCECGAJMCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(ECGMAJDODFD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public DateTime JGCPPOHPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CODPEOEOKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
[IGNMLPIHKKI]
public class MOHJGEPGKJL : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000360")]
	public ECGMAJDODFD KMPAJGALLNE
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(ECGMAJDODFD);
		}
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	public float DMNJDPACFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xD49CC0", Offset = "0xD48AC0", VA = "0x180D49CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xD49F60", Offset = "0xD48D60", VA = "0x180D49F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MOHJGEPGKJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[IGNMLPIHKKI]
public class HIJHBPMDPJG : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000362")]
	public ECGMAJDODFD MCECGAJMCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(ECGMAJDODFD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	public DateTime JGCPPOHPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	public ECGMAJDODFD KMPAJGALLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(ECGMAJDODFD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	public float DMNJDPACFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x10B8B40", Offset = "0x10B7940", VA = "0x1810B8B40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x12D9440", Offset = "0x12D8240", VA = "0x1812D9440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000366")]
	public ECGMAJDODFD EPGNFHPPCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		[CompilerGenerated]
		get
		{
			return default(ECGMAJDODFD);
		}
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public float COCCMPIEAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xC77D90", Offset = "0xC76B90", VA = "0x180C77D90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xC77DA0", Offset = "0xC76BA0", VA = "0x180C77DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HIJHBPMDPJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[IGNMLPIHKKI]
public class KGGPBHHFBAE : OAAIBPONJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public TimeSpan EGFMHEAKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public TimeSpan FGHHNEJDNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void HHDPONBNNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KGGPBHHFBAE()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000146")]
public class KAMDLADCGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KAMDLADCGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA290", Offset = "0x6FD9090", VA = "0x186FDA290")]
	public static string IOPCBHBPJBI(byte[] OGDNKKDHKAM, byte[] MCJGCJPDJFH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace Cpp2IlInjected
{
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
}
