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
using RecRoom.DataLayer.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78E6870", Offset = "0x78E4E70", VA = "0x1878E6870")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FOKLHLCOEBD
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum BGPIEEIGGIA
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
	public string GPGHGFNHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string IPIAKMGCBHC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BGPIEEIGGIA MBIAGNBHOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(BGPIEEIGGIA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DLLNCADNDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23764E0", Offset = "0x2374AE0", VA = "0x1823764E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HKCPLKLOJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A24A40", Offset = "0x1A23040", VA = "0x181A24A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78E0540", Offset = "0x78DEB40", VA = "0x1878E0540")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static FOKLHLCOEBD DBIJHINPEKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78E04B0", Offset = "0x78DEAB0", VA = "0x1878E04B0")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static FOKLHLCOEBD CEIDMBJFDPL([Optional] string JNPCFIIOMDM, [Optional] string MBJPNEBKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FOKLHLCOEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EOCKCBCDILD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string EDCLJBEHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string GCMFCBIOEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BHLKHJCKEAE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EOCKCBCDILD> DIAHHFKDHDP(string PELNHKIBOBC, string MAHKAFHEJID, string HMBNKJCIOJO, VoiceOption AOJPPGLDHNI, string? HHILGDFKKBA, float DPENBEMKJHB, [Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IHNBIIBBKOO : BHLKHJCKEAE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MHCMNDDJAEK? CHJOLHPLJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GJIKMKGBNOL<BFNCFKKJJMO> MEKEGLFHFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GJIKMKGBNOL<BDOGKLPIDON> OMGPIIAAHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GJIKMKGBNOL<EFMBAANCAJJ> KMAOLKKNHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HBPNKKOKOOA IFDHFDOBAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDOFINOBNCO();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<NBNGBFNBDKJ<byte>> KHLCGNOHJLG(string LIMCNPKEPJF, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<KBCLCEENLJL> DCHDICPKPIP(bool GKIBDIMCJCD, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<FIHIMGKHCPI<JINJJBBMDKP>> BKJMIEGNIAC(bool GBPIGLPGNAL = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<KBCLCEENLJL> LFCNOGKNAEE(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<FPEHGGCGONO<GFOCHFKAPIE>> OFEHAKOFDMA(long PANGCFBNCCJ, bool HPMDGKAAIKB = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<MKCNMNOIOPH> FBGNGCADBKK([Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<MKCNMNOIOPH> DCEAPEGAPFD(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<NBFPFGIPLPC> AEOGCJHMMCM(bool HPMDGKAAIKB = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<MMIDGFHFCME> FFJIKMOKHFJ([Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<KBCLCEENLJL> OFCKNNDMDHM(bool HPMDGKAAIKB = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<KBCLCEENLJL> NHAKEMECBEN([Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<KBCLCEENLJL> EMHCLGGHNCO(string PELNHKIBOBC, Guid ILECBMFGBIG, long PANGCFBNCCJ, long MECJEAAIDNJ, decimal LLCJMFKPAMJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<FIHIMGKHCPI<JINJJBBMDKP>> JHKIPMOGHNK(Guid ILECBMFGBIG, long PANGCFBNCCJ, long MECJEAAIDNJ, decimal LLCJMFKPAMJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task PMNCOEIDDDB(string FIGODFNPPLD, string JJIEIDBIPEL, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<HOPFPIMIFPE> AFMNFOPNMCL(string MAHKAFHEJID, string EBNCBIMGAHM, bool MJLBIAHNNDF, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<EFMBAANCAJJ> EAJDLJJDCIG(long PANGCFBNCCJ, string LEBMCKNMFOB, string PGGAFHEJNAP, string EBNCBIMGAHM, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<EFMBAANCAJJ> NKFMAJEEMGN(long DPPAJNEFKNP, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<KMMBNCPGLMO> GKKFGPGLDJE(string? MAHKAFHEJID, string EBNCBIMGAHM, string IFCAGKLINAN, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<KMMBNCPGLMO> GKKFGPGLDJE(string? MAHKAFHEJID, string EBNCBIMGAHM, byte[] HIKABCHEINB, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<KMMBNCPGLMO> BOMFMDJGIAM(long PANGCFBNCCJ, string? MAHKAFHEJID, string EBNCBIMGAHM, string IFCAGKLINAN, float? DPENBEMKJHB, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<KMMBNCPGLMO> BOMFMDJGIAM(long PANGCFBNCCJ, string? MAHKAFHEJID, string EBNCBIMGAHM, byte[] HIKABCHEINB, float? DPENBEMKJHB, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<HOPFPIMIFPE> KCGEKFDBJOG(long PANGCFBNCCJ, MCMHCGOAPFI MLCIBEJGDFC, byte[] HIKABCHEINB, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<HOPFPIMIFPE> IMDNKNNADGO(MCMHCGOAPFI MLCIBEJGDFC, string LEBMCKNMFOB, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<HOPFPIMIFPE> HKFFAJOBMFO(long PANGCFBNCCJ, string? MAHKAFHEJID, string EBNCBIMGAHM, bool MJLBIAHNNDF, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<BHJLICJIIMM> FCNGMLAPANL(string EBNCBIMGAHM, int ECPJMMFGCIP, string ECGDMNPOECP, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<BHJLICJIIMM> LHHKFICICBK(string EBNCBIMGAHM, int ECPJMMFGCIP, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<BLGOMGCKJIM> HHIBMMKGKFD(string? MAHKAFHEJID, string EBNCBIMGAHM, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<MHCMNDDJAEK> NKNGJLILPBN(string EBNCBIMGAHM, IGJGNEMCLCM? GGOIOAEEKHE, IReadOnlyList<IGJGNEMCLCM>? KAJLEEGKHKL, IReadOnlyList<string> ICFMLLFHCNL, LLOHHAJCGAN CKJHMCELOAA, [Optional] string? FANKAKBDKMN, [Optional] string? NJIKCNJNNIK, [Optional] string? PLJDAGAEFOP, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<MHCMNDDJAEK> KBKKCIACJNJ(string KBFPIDKMNOD, IGJGNEMCLCM? GGOIOAEEKHE, IReadOnlyList<string> ICFMLLFHCNL, LLOHHAJCGAN CKJHMCELOAA, [Optional] string? NJIKCNJNNIK, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<List<string>> MCKJPLHJNMA(string EBNCBIMGAHM, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<string> AMMNBKBIIJB(LLOHHAJCGAN CKJHMCELOAA, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task AIDIKDBFGIH(string EKNLPIEMHNC, VoiceOption AOJPPGLDHNI, string? HMBNKJCIOJO, Action<string> MKKHLPMGOGK, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<string> KGAMKBBIKFM(ReadOnlyMemory<byte> JEDONKNEIFP, int FPJPLDGHLOG, int LGGEJMJANBC, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<PDKKCENDLHN> CPDLKFEOEGP(List<BIPLGIAICHB> PLBIHOJAFDJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<PDKKCENDLHN> FAJGGCPDLIA([Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<bool> JIGGANIODKE(string ENCDNAAELEH, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task MLKMKPEFPII(string BHPNHCIFMPF, KLEFFKBMIOG LLJPOLHCCON, string DMGMBCGCHOD, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task POMEOIAOPEN(string BHPNHCIFMPF, string CELFNCGCOKJ, string LEFGFCJGALC, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<NFDCCLPNAPD?>? FIGFFJDEKGN(string BHPNHCIFMPF, [Optional] string? MAHKAFHEJID, [Optional] float? DPENBEMKJHB, [Optional] LGKOKOJLAFP? LOKKOLKLMJP, [Optional] IReadOnlyCollection<LGKOKOJLAFP>? OIGOHKDJEMA, HEAELPENINP OINGIMJGFAL = HEAELPENINP.Auto, [Optional] string? EJNMLMFLNEI, [Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MAOANFCLKDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string IKGABLBAAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string ODEPMFIGJND;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string NLGOOHNKBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string MLIHFBMJKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string GLFFDNLNDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string PAHAKHPOHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int? ABEAFFAJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int? DCBBAMPEOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x78E4340", Offset = "0x78E2940", VA = "0x1878E4340")]
	public MAOANFCLKDM(string PNAPNFLBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x78E4210", Offset = "0x78E2810", VA = "0x1878E4210")]
	public void DGLFAINBLMP(string IKLHLFJALAJ = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x78E4240", Offset = "0x78E2840", VA = "0x1878E4240")]
	private void LGMPELPCKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CEHJAAFAAFO
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NBJJMADLGPF AEKJKHPGLED
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<IMLGAIGKJEG> AJHBLCNAIFH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DDPNKLGGJFL> CLCOOPBBEHH;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DDPNKLGGJFL> DLIKAALKKOK(bool PMELHEGLJGC = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ECEFMBONGAE([Out] DDPNKLGGJFL NGOBHJALIMD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BGLEBDAEHGF
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x78DC790", Offset = "0x78DAD90", VA = "0x1878DC790")]
	public static bool NPHMCECAKBI(this CEHJAAFAAFO EANPBNEBKIC, [Out] IMLGAIGKJEG PKILKHLCHBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x78DC6B0", Offset = "0x78DACB0", VA = "0x1878DC6B0")]
	public static bool MHOBDKBMLFL(this CEHJAAFAAFO EANPBNEBKIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GEDHDJDFFOL
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LNEOLNLCAMK(CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDGOAGMBHAB(int HDHMAIICDKI, [Out] KLJAJDCFIJF? CKJHMCELOAA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KLJAJDCFIJF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int PBFAPMDHDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string? CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool? FBHBOHKBLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string? NBEHJGDGMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? MFNMNHODNBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NGAFJPKDFJD? LOMKNGLLGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ANFNLPLJKKG(string ACGIOBFNGFA, [Out] OOGOBCHLEHE? CKJHMCELOAA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OOGOBCHLEHE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? MHECIONFMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string? FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string? NBKCJEEPODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IReadOnlyList<FLDFBCFHALM>? IMHBKOMALDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	NGAFJPKDFJD? LOMKNGLLGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	long? DCNABOLNDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FLDFBCFHALM
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HMDCBEPOHBF GGMPIFNLHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NGAFJPKDFJD
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string? LLDDPIGCBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[GIJKPPBGMNE]
public class DCEEPDDONLD
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public List<GDCPJJIHMJN> FHMACGAEMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Dictionary<string, string> PEAINEPLNOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x78DD2C0", Offset = "0x78DB8C0", VA = "0x1878DD2C0")]
	public DCEEPDDONLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[GIJKPPBGMNE]
public class GDCPJJIHMJN
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int PBFAPMDHDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string NBEHJGDGMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string MFNMNHODNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool? FBHBOHKBLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xEA1540", Offset = "0xE9FB40", VA = "0x180EA1540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xEA1550", Offset = "0xE9FB50", VA = "0x180EA1550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BNFCGIPHNAB LOMKNGLLGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Dictionary<string, IGEJLCALFHL> NFJANMBPLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x78E0700", Offset = "0x78DED00", VA = "0x1878E0700")]
	public GDCPJJIHMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GIJKPPBGMNE]
public class BNFCGIPHNAB
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string LLDDPIGCBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BNFCGIPHNAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[GIJKPPBGMNE]
public class IGEJLCALFHL
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string MHECIONFMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string NBKCJEEPODP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public List<NPNKEJJNDDE> IMHBKOMALDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BNFCGIPHNAB LOMKNGLLGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long DCNABOLNDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F20", Offset = "0xAA0520", VA = "0x180AA1F20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x78E14E0", Offset = "0x78DFAE0", VA = "0x1878E14E0")]
	public IGEJLCALFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum HMDCBEPOHBF
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
[Cpp2IlInjected.Token(Token = "0x2000018")]
[GIJKPPBGMNE]
public class NPNKEJJNDDE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HMDCBEPOHBF GGMPIFNLHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(HMDCBEPOHBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NPNKEJJNDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct HPLHLLMMFNK : IEquatable<HPLHLLMMFNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool PLGLDFMDJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime MLGPAAPKNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool NEBOCGJBAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly PEHMMGGEDNB? ILEMKCKEGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string BHEEDJFJNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? DCPCHENJCJL;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static HPLHLLMMFNK MAAGEGDDNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D870", Offset = "0x2A7BE70", VA = "0x182A7D870")]
		get
		{
			return default(HPLHLLMMFNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x78E13E0", Offset = "0x78DF9E0", VA = "0x1878E13E0")]
	public HPLHLLMMFNK(DateTime FCMCCNDHEJM, bool EFJPNDDCJOP, PEHMMGGEDNB? FEOAJNGCHFG, string BPLGLOFHDJM, int? GEAOAEBDCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x78E1190", Offset = "0x78DF790", VA = "0x1878E1190")]
	public IMLGAIGKJEG HLENBHPIPEF(NBJJMADLGPF NEAJBOMOKKJ)
	{
		return default(IMLGAIGKJEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x78E1220", Offset = "0x78DF820", VA = "0x1878E1220")]
	private static IMLGAIGKJEG HNDEIBIAMFN(NBJJMADLGPF NEAJBOMOKKJ, DateTime FCMCCNDHEJM)
	{
		return default(IMLGAIGKJEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x78E0F80", Offset = "0x78DF580", VA = "0x1878E0F80", Slot = "4")]
	public bool Equals(HPLHLLMMFNK IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x78E0ED0", Offset = "0x78DF4D0", VA = "0x1878E0ED0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x78E10E0", Offset = "0x78DF6E0", VA = "0x1878E10E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x78E12A0", Offset = "0x78DF8A0", VA = "0x1878E12A0")]
	public static bool LMIMJGGKHMP(HPLHLLMMFNK LEOAACGBJCD, HPLHLLMMFNK GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x78E12D0", Offset = "0x78DF8D0", VA = "0x1878E12D0")]
	public static bool PACMOMIAEBP(HPLHLLMMFNK LEOAACGBJCD, HPLHLLMMFNK GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x78E1310", Offset = "0x78DF910", VA = "0x1878E1310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct DDPNKLGGJFL : IEquatable<DDPNKLGGJFL>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly DDPNKLGGJFL MAAGEGDDNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool EJBELALFPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IMLGAIGKJEG BLCGGEJLJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly HPLHLLMMFNK BLAMFEIMIIA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x78DD910", Offset = "0x78DBF10", VA = "0x1878DD910")]
	public DDPNKLGGJFL(IMLGAIGKJEG PKILKHLCHBF, HPLHLLMMFNK CJOKNBOMHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x78DD350", Offset = "0x78DB950", VA = "0x1878DD350", Slot = "4")]
	public bool Equals(DDPNKLGGJFL IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x78DD400", Offset = "0x78DBA00", VA = "0x1878DD400", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x78DD530", Offset = "0x78DBB30", VA = "0x1878DD530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x78DD5F0", Offset = "0x78DBBF0", VA = "0x1878DD5F0")]
	public static bool LMIMJGGKHMP(DDPNKLGGJFL LEOAACGBJCD, DDPNKLGGJFL GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x78DD700", Offset = "0x78DBD00", VA = "0x1878DD700")]
	public static bool PACMOMIAEBP(DDPNKLGGJFL LEOAACGBJCD, DDPNKLGGJFL GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x78DD820", Offset = "0x78DBE20", VA = "0x1878DD820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IMLGAIGKJEG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DLAKNICEGFG : NBJJMADLGPF
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string JPFDJBNILJA = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch IAHFLFKKACL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? HLEKPPDCHFK;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly DLAKNICEGFG PLKOLLOCKHK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static NBJJMADLGPF DOBPPELCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78DE0D0", Offset = "0x78DC6D0", VA = "0x1878DE0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal static DLAKNICEGFG ENPJBJDBDAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x78DE270", Offset = "0x78DC870", VA = "0x1878DE270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static DateTimeOffset NKLMFMNFAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x78DDD50", Offset = "0x78DC350", VA = "0x1878DDD50")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static DateTime MOOLGDPKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x78DE1E0", Offset = "0x78DC7E0", VA = "0x1878DE1E0")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime KIJAJHNAKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78DE120", Offset = "0x78DC720", VA = "0x1878DE120", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DateTimeOffset JDBMCFILILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x78DE2C0", Offset = "0x78DC8C0", VA = "0x1878DE2C0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	private DLAKNICEGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x78DDEB0", Offset = "0x78DC4B0", VA = "0x1878DDEB0")]
	internal static void IBGADALFAJL(DateTime? OLMGGGJOJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PNIPNHJMHLC
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GNFCAPCPIPE
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[GIJKPPBGMNE]
public class LJCEPDOBDJL : MEOALPKGGCL, NOCNMFAMICC, KPJILIFBKOE, JLFPDMLALBM, JCHAPBFMJOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct FCJLLJFBLHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public LJCEPDOBDJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x78DF920", Offset = "0x78DDF20", VA = "0x1878DF920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x78DFCD0", Offset = "0x78DE2D0", VA = "0x1878DFCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static LJBJNEKAKNC AMGNKCPOFJL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int AIOMMCFMFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public KJFAHMKAJPA AJPLFIKPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAB3890", Offset = "0xAB1E90", VA = "0x180AB3890", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(KJFAHMKAJPA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1745450", Offset = "0x1743A50", VA = "0x181745450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool MHPNHFFBDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD946A0", Offset = "0xD92CA0", VA = "0x180D946A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xE83B20", Offset = "0xE82120", VA = "0x180E83B20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MHAEHJFGFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xF0E330", Offset = "0xF0C930", VA = "0x180F0E330", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xF0DFC0", Offset = "0xF0C5C0", VA = "0x180F0DFC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool PDBINEEFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2193CD0", Offset = "0x21922D0", VA = "0x182193CD0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2193980", Offset = "0x2191F80", VA = "0x182193980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int? EIKECLCGEED
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x78E3D00", Offset = "0x78E2300", VA = "0x1878E3D00", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x78E3CF0", Offset = "0x78E22F0", VA = "0x1878E3CF0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string CLFFMEGFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string GEOEBJHGGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string EGNKLBLDFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA962F0", Offset = "0xA948F0", VA = "0x180A962F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xFDC840", Offset = "0xFDAE40", VA = "0x180FDC840")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public DateTime HHDAJLCBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA99380", Offset = "0xA97980", VA = "0x180A99380", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xFDC860", Offset = "0xFDAE60", VA = "0x180FDC860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public PNIPNHJMHLC JJGGEHBPHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xB19EC0", Offset = "0xB184C0", VA = "0x180B19EC0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(PNIPNHJMHLC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1629A20", Offset = "0x1628020", VA = "0x181629A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string GEGDIKBPAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA9D7B0", Offset = "0xA9BDB0", VA = "0x180A9D7B0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9D620", Offset = "0xA9BC20", VA = "0x180A9D620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int DGJLAMEDFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xDB3F60", Offset = "0xDB2560", VA = "0x180DB3F60", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xDB4260", Offset = "0xDB2860", VA = "0x180DB4260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public IReadOnlyList<GAGPGKGCPGC> ABOBGFLGFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xB19E20", Offset = "0xB18420", VA = "0x180B19E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xB65E80", Offset = "0xB64480", VA = "0x180B65E80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IReadOnlyList<EOEOBLPAJGD> BIJMPBFDCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xB19E20", Offset = "0xB18420", VA = "0x180B19E20", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public GFKBGHMDNDB MKIBAPPOJGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9D630", Offset = "0xA9BC30", VA = "0x180A9D630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA9D710", Offset = "0xA9BD10", VA = "0x180A9D710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string CKOBMBPLABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x78E3980", Offset = "0x78E1F80", VA = "0x1878E3980", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ICOOGNIIMPB ELLFDIPCJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xC21180", Offset = "0xC1F780", VA = "0x180C21180", Slot = "24")]
		get
		{
			return default(ICOOGNIIMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x78E3980", Offset = "0x78E1F80", VA = "0x1878E3980", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string KOEPNMMBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool DHLHAGKFKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public BJBMFDPJGHF EEHEOFKOOAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAE6860", Offset = "0xAE4E60", VA = "0x180AE6860", Slot = "30")]
		get
		{
			return default(BJBMFDPJGHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string NLODIPMBEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public OJKGOLKIFJC? INAMIKGPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x78E3BD0", Offset = "0x78E21D0", VA = "0x1878E3BD0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public NOOOFIKEBPO DOEPMBFPDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xC21180", Offset = "0xC1F780", VA = "0x180C21180", Slot = "33")]
		get
		{
			return default(NOOOFIKEBPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool PPLCAEDLBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LJCEPDOBDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x10D6DD0", Offset = "0x10D53D0", VA = "0x1810D6DD0")]
	public LJCEPDOBDJL([Optional] Guid MECFNLMOEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x78E3A20", Offset = "0x78E2020", VA = "0x1878E3A20", Slot = "35")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x78E3C20", Offset = "0x78E2220", VA = "0x1878E3C20", Slot = "36")]
	[AsyncStateMachine(typeof(FCJLLJFBLHD))]
	public Task LDEFHJHMLKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x78E39A0", Offset = "0x78E1FA0", VA = "0x1878E39A0")]
	public LJCEPDOBDJL CCEONOOKKGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[GIJKPPBGMNE]
public class JHPIKFLNOJK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public int? EIKECLCGEED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x13CF4F0", Offset = "0x13CDAF0", VA = "0x1813CF4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1085230", Offset = "0x1083830", VA = "0x181085230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string CLFFMEGFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KJFAHMKAJPA AJPLFIKPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		[CompilerGenerated]
		get
		{
			return default(KJFAHMKAJPA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public PNIPNHJMHLC? JJGGEHBPHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAE3800", Offset = "0xAE1E00", VA = "0x180AE3800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAE3810", Offset = "0xAE1E10", VA = "0x180AE3810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JHPIKFLNOJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[GIJKPPBGMNE]
public class FNFGLFLIBKD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int AIOMMCFMFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int? EIKECLCGEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x13CF390", Offset = "0x13CD990", VA = "0x1813CF390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F60", Offset = "0x13D8560", VA = "0x1813D9F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string GEOEBJHGGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string CLFFMEGFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FNFGLFLIBKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[GIJKPPBGMNE]
public class MGPAAMMKOCG : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int? EIKECLCGEED
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string CLFFMEGFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MGPAAMMKOCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct EPCPMLHHCMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int AJMLEEDNFMA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int NJJLLCNIEMD;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int PLAHJKPDIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int MCCKONKJOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x302EA30", Offset = "0x302D030", VA = "0x18302EA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static EPCPMLHHCMJ COLNIIHALMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x78DF010", Offset = "0x78DD610", VA = "0x1878DF010")]
		get
		{
			return default(EPCPMLHHCMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x78DF0C0", Offset = "0x78DD6C0", VA = "0x1878DF0C0")]
	public EPCPMLHHCMJ(int FGEEPEFOICB, int OACHOKGBEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[GIJKPPBGMNE]
public class JDAMGHILBNI : KPJILIFBKOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int DGMGIMIBDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int KEBAKFJLOIP;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JDAMGHILBNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[GIJKPPBGMNE]
public class CJBDJMCKPKD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int LPJGJBNKGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int? OMPPEIIBCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x13CF390", Offset = "0x13CD990", VA = "0x1813CF390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F60", Offset = "0x13D8560", VA = "0x1813D9F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string? OGPGDHDIMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x78DD070", Offset = "0x78DB670", VA = "0x1878DD070")]
	public CJBDJMCKPKD(int AAAJLJAAJIM, int? JKECLNJHHCE, string? IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CJBDJMCKPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[GIJKPPBGMNE]
public class GGJMOEHGCFG : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HNMPHHEKBGH.ABCKHDHOHNO KHGPCBGNFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(HNMPHHEKBGH.ABCKHDHOHNO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public string EMMNNEOHEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int? OPINHBDPCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GGJMOEHGCFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EOEOBLPAJGD
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long PAIALIOKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Guid MIGCGALIJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string CJKKPJOCAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string CAHBEGDICLE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int JONCMKBDACN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string KDPJIHNIHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string MLCBANAOHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	string BJCHMLLECAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	string OOMLFEHDLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int DGJLAMEDFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[GIJKPPBGMNE]
public class GAGPGKGCPGC : EOEOBLPAJGD, KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public long PAIALIOKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Guid MIGCGALIJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x14274A0", Offset = "0x1425AA0", VA = "0x1814274A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x155F7E0", Offset = "0x155DDE0", VA = "0x18155F7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F20", Offset = "0xAA0520", VA = "0x180AA1F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string CJKKPJOCAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string CAHBEGDICLE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int JONCMKBDACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xEA1DD0", Offset = "0xEA03D0", VA = "0x180EA1DD0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xFF7A80", Offset = "0xFF6080", VA = "0x180FF7A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string KDPJIHNIHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string MLCBANAOHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA962F0", Offset = "0xA948F0", VA = "0x180A962F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public string BJCHMLLECAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA962E0", Offset = "0xA948E0", VA = "0x180A962E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string OOMLFEHDLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA99380", Offset = "0xA97980", VA = "0x180A99380", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA99450", Offset = "0xA97A50", VA = "0x180A99450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int DGJLAMEDFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xB19EC0", Offset = "0xB184C0", VA = "0x180B19EC0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1629A20", Offset = "0x1628020", VA = "0x181629A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "15")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GAGPGKGCPGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Flags]
public enum DINIPMNPHHH
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum JKOJFAAODCF
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NLLINDBOLHL
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x78E6740", Offset = "0x78E4D40", VA = "0x1878E6740")]
	public static int? CNHKMMGCONG(DINIPMNPHHH? FOLPAEHGMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x78E67D0", Offset = "0x78E4DD0", VA = "0x1878E67D0")]
	public static int? JGMBOAJANKP(JKOJFAAODCF? EBOAEHEJOHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[GIJKPPBGMNE]
public class CGDHLEKDLOG : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int? DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public KJFAHMKAJPA? AJPLFIKPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA94FD0", Offset = "0xA935D0", VA = "0x180A94FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CGDHLEKDLOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[GIJKPPBGMNE]
public class CPEFFIJECFJ : DHGDINDKNOD, KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public byte KOLJEAGHCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CPEFFIJECFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PCDKDFMJBBG
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x78E72C0", Offset = "0x78E58C0", VA = "0x1878E72C0")]
	public static DMNGFFKFFEM BJGMMLPKACL(this CPEFFIJECFJ CCKLBDLJPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface MEOALPKGGCL
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	int AIOMMCFMFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	int DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	KJFAHMKAJPA AJPLFIKPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool MHPNHFFBDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool MHAEHJFGFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool PDBINEEFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	int? EIKECLCGEED
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string CLFFMEGFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	string GEOEBJHGGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string EGNKLBLDFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	DateTime HHDAJLCBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	PNIPNHJMHLC JJGGEHBPHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string GEGDIKBPAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	int DGJLAMEDFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string CKOBMBPLABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x78E4BB0", Offset = "0x78E31B0", VA = "0x1878E4BB0", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JCHAPBFMJOG
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	IReadOnlyList<EOEOBLPAJGD> BIJMPBFDCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	int AIOMMCFMFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool PDBINEEFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int DGJLAMEDFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	int? EIKECLCGEED
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	KJFAHMKAJPA AJPLFIKPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PDFCPAHGONM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct AACOIDDELFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IEnumerable<JLFPDMLALBM> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x78DBEE0", Offset = "0x78DA4E0", VA = "0x1878DBEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x78DC190", Offset = "0x78DA790", VA = "0x1878DC190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x78E7400", Offset = "0x78E5A00", VA = "0x1878E7400")]
	public static bool GFONGDCDACG(this IEnumerable<KPJILIFBKOE> AHJLBOEGGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x78E7330", Offset = "0x78E5930", VA = "0x1878E7330")]
	[AsyncStateMachine(typeof(AACOIDDELFK))]
	public static Task FNLHAOIKLBN(this IEnumerable<JLFPDMLALBM> AHJLBOEGGKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct AOCLCGMPLAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly string GEBIGOAJPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly string HNNOIPHAHBO;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly AOCLCGMPLAI HJDKPCINMKP;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
	public AOCLCGMPLAI(string LIMCNPKEPJF, string PDDACHIAKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x13F2B80", Offset = "0x13F1180", VA = "0x1813F2B80")]
	public bool HILCECGHHLN(AOCLCGMPLAI IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x78DC2A0", Offset = "0x78DA8A0", VA = "0x1878DC2A0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x78DC380", Offset = "0x78DA980", VA = "0x1878DC380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x78DC3F0", Offset = "0x78DA9F0", VA = "0x1878DC3F0")]
	public static bool LMIMJGGKHMP(AOCLCGMPLAI LEOAACGBJCD, AOCLCGMPLAI GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x78DC470", Offset = "0x78DAA70", VA = "0x1878DC470")]
	public static bool PACMOMIAEBP(AOCLCGMPLAI LEOAACGBJCD, AOCLCGMPLAI GDBFOEGEGHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface NPBBMPJHIME
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	MAOANFCLKDM CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string CGHLEDCHFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string IKDGLFDFGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	long DPOKLNLCNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string GPCNEAHCGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string PHAKPAEKCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	string IAOFJNNCNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	string DKEHKOPOGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[GIJKPPBGMNE]
public class PHBMBGDOIGP : EPAIALEMEPC
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string BEPLPBADFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public EIFAFPGEPFD BEJCLKLOMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(EIFAFPGEPFD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public HCGHBHPJKOB CBICAGFKNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
		[CompilerGenerated]
		get
		{
			return default(HCGHBHPJKOB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public CPIENKICMEH AHHNOGHLGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(CPIENKICMEH);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	[DataMember(Name = "Header")]
	public string? MIAGHBDCBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string? MHECIONFMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string? GKOINGMGINN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public List<string> ILIIOGFGHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public List<AACENHEGMPE> IMHBKOMALDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x78E7860", Offset = "0x78E5E60", VA = "0x1878E7860", Slot = "5")]
	public override void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x78E7870", Offset = "0x78E5E70", VA = "0x1878E7870")]
	public PHBMBGDOIGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum NFJEHPAMBGL
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum EIFAFPGEPFD
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum HCGHBHPJKOB
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum CPIENKICMEH
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[GIJKPPBGMNE]
public class AACENHEGMPE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public NFJEHPAMBGL JGKFNDKKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(NFJEHPAMBGL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? LLNKBCBCODB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[DataMember(Name = "LinkParameter")]
	public string? DHCKFLEDFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? MMNBGLBDABG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public AACENHEGMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class EPAIALEMEPC : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	[IgnoreDataMember]
	public string? GLLCIBGLPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void EOCKPKLKCMF();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x78DEFB0", Offset = "0x78DD5B0", VA = "0x1878DEFB0")]
	protected EPAIALEMEPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[GIJKPPBGMNE]
public class MLDMOKKGJJB : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? JNIMEMKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MLDMOKKGJJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[GIJKPPBGMNE]
public class CAGEIJHNEIC : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal static Func<string, PHBMBGDOIGP>? JLEEKCPNCPB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	internal static Func<string, CIAEBHGHDIJ>? MJGOHJPKPKI;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public string? JNIMEMKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string? JCLDLALPNEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool INKLAHDEMFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public PEHMMGGEDNB JCCHFCAOGFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
		[CompilerGenerated]
		get
		{
			return default(PEHMMGGEDNB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public ENHFOBPIJHD NDHMKHMJIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(ENHFOBPIJHD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public int LFLEHKJBBGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1696150", Offset = "0x1694750", VA = "0x181696150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DateTime LNKCBGJCEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA95020", Offset = "0xA93620", VA = "0x180A95020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[DataMember(Name = "IsRead")]
	internal bool IHMNEIBJPMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xAE7930", Offset = "0xAE5F30", VA = "0x180AE7930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAE7FC0", Offset = "0xAE65C0", VA = "0x180AE7FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[IgnoreDataMember]
	public bool CHPCNBMFLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1572830", Offset = "0x1570E30", VA = "0x181572830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x15724F0", Offset = "0x1570AF0", VA = "0x1815724F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public PJCMCFHDGEN GCGMJPBDABM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xAB3890", Offset = "0xAB1E90", VA = "0x180AB3890")]
		[CompilerGenerated]
		get
		{
			return default(PJCMCFHDGEN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1745450", Offset = "0x1743A50", VA = "0x181745450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public EACDAKCMDCO FLHDAEDBPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
		[CompilerGenerated]
		get
		{
			return default(EACDAKCMDCO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xB18030", Offset = "0xB16630", VA = "0x180B18030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	internal string? KBFALILEPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public PHBMBGDOIGP? KOMMPLBHILM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x78DCC40", Offset = "0x78DB240", VA = "0x1878DCC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	[IgnoreDataMember]
	public CIAEBHGHDIJ? ADEFPDACPED
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x78DCCD0", Offset = "0x78DB2D0", VA = "0x1878DCCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	[IgnoreDataMember]
	public EPAIALEMEPC? LECEBFGMANG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x78DC910", Offset = "0x78DAF10", VA = "0x1878DC910", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0xABFEB0", Offset = "0xABE4B0", VA = "0x180ABFEB0")]
	public CAGEIJHNEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[GIJKPPBGMNE]
public class KNDDIOMHKCD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public GHBAGEINAEO JBLONJKBJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(GHBAGEINAEO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string FKEPEHJAMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int HPODOKLNJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x78E2A10", Offset = "0x78E1010", VA = "0x1878E2A10")]
	public KNDDIOMHKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[GIJKPPBGMNE]
public class CIAEBHGHDIJ : EPAIALEMEPC
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public string KJMDBDOADCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string? CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DOPCBBOKOMB DBAAAAOAEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(DOPCBBOKOMB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	[DataMember(Name = "all_conditions_required")]
	public bool OEAEKIBLOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1859660", Offset = "0x1857C60", VA = "0x181859660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1086430", Offset = "0x1084A30", VA = "0x181086430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public List<KNDDIOMHKCD> OPHOPOJECMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x78DCFA0", Offset = "0x78DB5A0", VA = "0x1878DCFA0", Slot = "5")]
	public override void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x78DCFB0", Offset = "0x78DB5B0", VA = "0x1878DCFB0")]
	public CIAEBHGHDIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum EACDAKCMDCO
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum PJCMCFHDGEN
{
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum DOPCBBOKOMB
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum GHBAGEINAEO
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	EnteredRoom = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	TimeInRoom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	ObjectInteractionRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	ObjectPlaceStartedRoom = 4
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface ECKLOGBMHFL
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool MENAGCGFOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	GJIKMKGBNOL<CAGEIJHNEIC> NDBGAGEPMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	GJIKMKGBNOL<string> JNOPIPJONNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	GJIKMKGBNOL<CAGEIJHNEIC> LIHMPOBFLBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	GJIKMKGBNOL<CAGEIJHNEIC> IDJPDEBPIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<CAGEIJHNEIC> HKCDHGAJCMA(PJCMCFHDGEN CNDNKIKDKCJ);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CAGEIJHNEIC> DJMCEHGEIGB(PJCMCFHDGEN CNDNKIKDKCJ);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CAGEIJHNEIC MEOBFACOOLE(PJCMCFHDGEN CNDNKIKDKCJ, string JPJJPKECGCJ);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CAGEIJHNEIC HGGDCPEOIHM(PJCMCFHDGEN CNDNKIKDKCJ);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HAIDCHMLBOK(PJCMCFHDGEN CNDNKIKDKCJ);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CBKAMHNEJEK(PJCMCFHDGEN CNDNKIKDKCJ);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task FOFIENKJBAM();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task BPPAEPGFMOF(CAGEIJHNEIC IFEHDCDCFPK);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KDODIGCGHOH
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	LPDBNLCIABG JNMEPNENFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	int ELCHPMBAFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool GPFFKCDBKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool KMFGNNANPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool GFMBKNJGAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool CGIICFHECFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool GINNCJEMHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	bool EHBECDHKFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	bool OMKKDIIHJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool COFCNLOEJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	bool GKPHIAPMMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	bool JLMAEBFHGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NMPHLFPLMMD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action MOGIFPNPCDB;

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LDNIFFJFEMD<DNELOPHIANP> ICOKHGHFECF(int PPFHIIIBKME);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CNOKEDEBLOH CNOOFMBHOMD(DateTime HICIEHACMGO);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CNOKEDEBLOH GPFMFHJPNKO(string IBBLKDOEJIC);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DOGMPIOIGDM([Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum DHJDMCNDAPE
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class OJMJCMCHGPN
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x78E7040", Offset = "0x78E5640", VA = "0x1878E7040")]
	public static string BOIOAGAINHB(this DHJDMCNDAPE LLJPOLHCCON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface GEFKGNBLMEH
{
	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<CAGEIJHNEIC>> JGFAICKANPM(PJCMCFHDGEN CNDNKIKDKCJ);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BPPAEPGFMOF(string JPJJPKECGCJ);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface BFKAKKDOAKL
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KFOCOGJMOCL> DLIPHCOEJIL();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface PNNDLBPJPFB
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LDNIFFJFEMD<List<LDIMDAHEKKB>> MPCBACEIBGC();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LDNIFFJFEMD<List<LDIMDAHEKKB>> DFOAJCAGLEG();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<LDIMDAHEKKB>> FKOIKLEHEGH([Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LDNIFFJFEMD<List<LDIMDAHEKKB>> NPHCBOHMFCH(List<BDDFNOANCGH> ENJIHNECBGF);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDNIFFJFEMD<List<LDIMDAHEKKB>> EHJBEKPPACM(List<BDDFNOANCGH> ENJIHNECBGF);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KGNHCANDILK
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	List<MGDIHOEKGMD> DICMDLJCKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<BNPGBAKMNMM> IKMEIOCCAGM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<MGDIHOEKGMD> IFNCPBNPEEH;

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CNOKEDEBLOH FIEMHIHFJGH(MGDIHOEKGMD ANAJMBOIHMA);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task OJIEEKHEHJN(MGDIHOEKGMD ANAJMBOIHMA);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	LDNIFFJFEMD<MGDIHOEKGMD> GPNOHMHIJFB(LLODCHIGJPE HHPFOCCGJIF, LLODCHIGJPE? HHHGMMFKOJD, bool KMCKBKPMMPL, string IFEHDCDCFPK);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LDNIFFJFEMD<MGDIHOEKGMD> GPNOHMHIJFB(LLODCHIGJPE HHPFOCCGJIF, string IFEHDCDCFPK);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IABJIPNDBMF(MGDIHOEKGMD DGHLHJGODGI, bool KMMJJIIANNG = false, bool JCALEGGKNMM = false, bool EBIIBFKMBKP = true);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LDNIFFJFEMD<List<MGDIHOEKGMD>> LHPGIBIOGBN();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface OFFIKIFFADL
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string GLKENHGIOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	bool DJNMGLNLKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNOKEDEBLOH GDJDDPINNNM();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CNOKEDEBLOH FNNELJFCFHI(string DGOCMPHDNFJ, string HLNFLDINENB);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CNOKEDEBLOH NANNHALGFPD(string JIFNPHIDLOE);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLPBDACPPHD();

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<JKIFBDABLJF> AIPLICDCPBI(string IBBLKDOEJIC, string JIFNPHIDLOE, bool PEGHLCPJCPI, string HNMHNCBNFGB, string PLCLGCLENOD, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EDEJBKAKHIH(int PPFHIIIBKME, string CAPLOAJJHHG, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task NOOKCOALCEO(int PPFHIIIBKME, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task LHCDOHELLGM([Optional] DHJDMCNDAPE? GEJAPLHCPEC, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<BGBNHGEPLCD>> DGGHHLAABPC([Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task ICJKCDFHELP([Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface MMPPFPKHPMM
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<AHCFJLFNKPN>> MIKJBEPHABA([Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<MGEAMDFLMKA>> CAJIGLAJBFI([Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface FMNKOPKAEFK
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PPIBNKOHFLE([Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHBPELHDHLN();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface HMBCDKHDNOK
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event EJOKOAIKCFD? LHHGAJKMOMF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EJOKOAIKCFD? FNDGBJDKJAA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event EJOKOAIKCFD? CBFKADBICFI;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<DADENNIAJDJ> LEEMAPKBMBM();

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<DADENNIAJDJ?>? GNPFFAKHKBG(int PPFHIIIBKME);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<ABDIMGFNFBG>> ENJHEBPKPLB(List<int> ILJKBFDPPPO);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, DADENNIAJDJ>> BAJOEPEAAEO();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<DADENNIAJDJ?>?>? CGDPNKFHKOC(int PPFHIIIBKME);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task LMEICEOKAOP(int JLKLAKIGBEB);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<HEFFBECLBFK> DMEPACFPFMK(DADENNIAJDJ CHJINAPIKBH);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate void EJOKOAIKCFD(int PPFHIIIBKME, int JLKLAKIGBEB, DADENNIAJDJ? CHJINAPIKBH);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface LJBJNEKAKNC : ONIHPNACPKI, LOKNMGKIMFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[Flags]
	public enum AOEECFLIIGM
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	string GBOBJKFCMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	KDPHBKIKMHH DGEIKKAILEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	PEHMMGGEDNB JCCHFCAOGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	string BHEEDJFJNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	byte NHNLDEBJNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	int DIGADJMFCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	int PKHODCMKNLO
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool FPKCEICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool AAOGGACBHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool HPHADBFGOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool PHOHENLPEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	bool DOPKAALIJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	bool HNPGIEMFLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	bool DKMPFKKFMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDNIFFJFEMD<string> EGMCILDLELO();

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> MMAHAMMGHDH();

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LDNIFFJFEMD<bool> IsPlayerCommunicationRestricted(int PPFHIIIBKME);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string CGHJGJNGGCA(string DJFMCHMDHGK, bool JPAEDMFMNKP = true);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> EFIKFMJHFGO(string DJFMCHMDHGK, bool JPAEDMFMNKP = true);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "18")]
	LDNIFFJFEMD<string> MakeRoomNameAdhereToPlatformRequirements(long PANGCFBNCCJ, string DJFMCHMDHGK);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string FBIPAAELDBA, AOEECFLIIGM ILJEIBEBOAP = AOEECFLIIGM.FilterProfanity | AOEECFLIIGM.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string FBIPAAELDBA, AOEECFLIIGM ILJEIBEBOAP = AOEECFLIIGM.FilterProfanity | AOEECFLIIGM.FilterURL, bool IGFDGIIDDNJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string DJFMCHMDHGK, AOEECFLIIGM ILJEIBEBOAP = AOEECFLIIGM.FilterProfanity | AOEECFLIIGM.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "23")]
	LDNIFFJFEMD<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface FFEPFNBFPCC
{
	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<APLMOMCENDB>> FPHGNIMBEML([Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface AENELNDPFLM
{
	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GCLCLCCDKFJ(byte[] PDDACHIAKKM, byte[] DHNPNENPBGH);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface NJCBBCJHNBI
{
	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ABHCJLPONDL(string NNDPFNMKLIB);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface GDKKOIHJELA
{
	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	GJIKMKGBNOL<OBPCMEDCJCL> JCBCNOJBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> HKJJEKPGMOD(string ONKLKNCHMGE);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<POBDEJDKBGP> KKIPKGIKMNJ(string ONKLKNCHMGE, string NDAAANJKKGB);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EFFLIOMNDPK(string ONKLKNCHMGE, IEnumerable<string> CJGEJGFKMBA, int OKDCHLACJMH = 0);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<FPEHGGCGONO<FilteredTextDTO>>> OFBKHOMCLDG(uint DNJPLOOCCDA, IEnumerable<string> CJGEJGFKMBA);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HJBLIKAICEP
{
	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCKMNCBLHON([Out] bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BDEHNDCGDGI([Out] bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKNIHFDMGIM([Out] int FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFOHLAHGAAE([Out] bool FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum IGCMJKOFCEO
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum GHHEOFKDOIJ
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Flags]
public enum MJKIGIDMINN
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Flags]
public enum PMFGKOOKCDI
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum ADCEDNGKBIF
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum NKFCPCAMPHO
{
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface DNELOPHIANP
{
	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int NGMDLLPJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string AJINNPMLCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	string AAKHMBKKOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	string KEAFAIGDFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	string DEGJANFGJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	string BNHPOPKCBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	string FLLKAKGJBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool OMOCEJKNNID
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	bool FOPHNOCPGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	MJKIGIDMINN LMKHECOHIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	PMFGKOOKCDI HCJBIAOHKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	bool? NINIGEAOAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void APDHKAECNJH(bool PEMENMHEFLP);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IEJOCGCFCHL(bool KHOPPCMAINI);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface LPDBNLCIABG : DNELOPHIANP
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	string BDGJNJAGFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	string KFIBNDJGLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	DateTime? OGKFJNIGOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	IGCMJKOFCEO GNFCDBHGJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	int? IPDHNFJBCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	int OOBEKLBCCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	bool LOHIGAHCHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	bool DBNDCAACOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	bool? ANELEEJABGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GLKFPEHPHAI
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public DNELOPHIANP BIBOHIGKJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public GHHEOFKDOIJ PHHAGFFDBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(GHHEOFKDOIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public string DLDHHDHHKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x72720B0", Offset = "0x72706B0", VA = "0x1872720B0")]
	public GLKFPEHPHAI(DNELOPHIANP KIKOMEHHJKA, GHHEOFKDOIJ DCDHHILGBBM, string BBICMGLEPCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface DJFIJIPICDF
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	int NGMDLLPJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	bool HJNMDAOJNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface DPAAEIDMPPK
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	int NGMDLLPJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	bool EHBJGCNLCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface EPNLOABJOAM
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	int NGMDLLPJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	string GJFMCKDICFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum OJKGOLKIFJC
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class LDIMDAHEKKB
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public OJKGOLKIFJC INAMIKGPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(OJKGOLKIFJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public string KOEPNMMBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public string CBLKBJCGALM
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public BJBMFDPJGHF EEHEOFKOOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(BJBMFDPJGHF);
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string CANMCOAGMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public int GNBLJCPNAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool FCIDBEFJFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xFC0810", Offset = "0xFBEE10", VA = "0x180FC0810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xFC0910", Offset = "0xFBEF10", VA = "0x180FC0910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public BDDFNOANCGH JCLEDFMMFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1568F00", Offset = "0x1567500", VA = "0x181568F00")]
		[CompilerGenerated]
		get
		{
			return default(BDDFNOANCGH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x78E3260", Offset = "0x78E1860", VA = "0x1878E3260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public IDKLMMFDGOH EMPKMKBCFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1C43FB0", Offset = "0x1C425B0", VA = "0x181C43FB0")]
		[CompilerGenerated]
		get
		{
			return default(IDKLMMFDGOH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C500", Offset = "0x5C8AB00", VA = "0x185C8C500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string MKIOKJDKKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA9D7B0", Offset = "0xA9BDB0", VA = "0x180A9D7B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA9D620", Offset = "0xA9BC20", VA = "0x180A9D620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA9D770", Offset = "0xA9BD70", VA = "0x180A9D770")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x55C53D0", Offset = "0x55C39D0", VA = "0x1855C53D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x78E33C0", Offset = "0x78E19C0", VA = "0x1878E33C0")]
	internal LDIMDAHEKKB(DAOGIALOKOJ DIDGGPKPHPA, OAGGKJEICID ABPONKCBMDG, ICDMELAABPI KPCLGEPKDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x78E3280", Offset = "0x78E1880", VA = "0x1878E3280")]
	public LDIMDAHEKKB(OJKGOLKIFJC OODMGLAHNBP = OJKGOLKIFJC.Outfit, [Optional] BDDFNOANCGH IOGIFFAICEI, [Optional] string PGGAFHEJNAP, [Optional] string NJLNINNCAGA, BJBMFDPJGHF POGGCIEFBNG = BJBMFDPJGHF.Common, [Optional] string ODAKNEMCCEE, int NGIIDBPAAGG = 0, bool FPLMGLAODNL = false, [Optional] string IBPONJAPAIJ, [Optional] DateTime? BOLFBHDEFLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[GIJKPPBGMNE]
public class DAOGIALOKOJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public OJKGOLKIFJC INAMIKGPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(OJKGOLKIFJC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	[DataMember(Name = "AvatarItemDesc")]
	public string PBOIIMPKHED
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string KOEPNMMBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string CBLKBJCGALM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public BJBMFDPJGHF EEHEOFKOOAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F10", Offset = "0xAA0510", VA = "0x180AA1F10")]
		[CompilerGenerated]
		get
		{
			return default(BJBMFDPJGHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA2490", Offset = "0xAA0A90", VA = "0x180AA2490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string CANMCOAGMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int GNBLJCPNAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xB18030", Offset = "0xB16630", VA = "0x180B18030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool FCIDBEFJFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x19825C0", Offset = "0x1980BC0", VA = "0x1819825C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1992160", Offset = "0x1990760", VA = "0x181992160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public string HHMPCEMLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xFC0E60", Offset = "0xFBF460", VA = "0x180FC0E60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DAOGIALOKOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[GIJKPPBGMNE]
public sealed class HNCJHPODJGC : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public List<string> MHMDELMPOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x78E0D70", Offset = "0x78DF370", VA = "0x1878E0D70")]
	public HNCJHPODJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public HNCJHPODJGC(List<string> ENJIHNECBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[GIJKPPBGMNE]
public class KFOCOGJMOCL : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public BDENIIBGHGJ KENGFDCFBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public HIKGPGDBNFJ DGBHMBGOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KFOCOGJMOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
	public KFOCOGJMOCL(BDENIIBGHGJ FOFLDHALMLJ, HIKGPGDBNFJ ACCCBHOGAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum GBKAKDOJBPP
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum OAMFIGPJLNB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[GIJKPPBGMNE]
public class BDENIIBGHGJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public GBKAKDOJBPP OIDDCPGEBAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(GBKAKDOJBPP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public OAMFIGPJLNB? HEIJEJDEFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3211380", Offset = "0x320F980", VA = "0x183211380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7776380", Offset = "0x7774980", VA = "0x187776380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool KBHDGFMALEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2088F30", Offset = "0x2087530", VA = "0x182088F30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2088F50", Offset = "0x2087550", VA = "0x182088F50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x78DC6A0", Offset = "0x78DACA0", VA = "0x1878DC6A0")]
	public BDENIIBGHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x78DC610", Offset = "0x78DAC10", VA = "0x1878DC610")]
	public BDENIIBGHGJ(GBKAKDOJBPP FLFKIKLHGKO, OAMFIGPJLNB LDFGHEPFDGK, bool DBEGOEPHDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[GIJKPPBGMNE]
public class HIKGPGDBNFJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public string FCNFELELIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public string JIHCBEJPNHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HIKGPGDBNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
	public HIKGPGDBNFJ(string LIKAOLOHOGN, string BGEJBAEMPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum KDPHBKIKMHH
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct BNPGBAKMNMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public MGDIHOEKGMD OBAJBALBCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public bool MANFHAMHDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool FIAOBOIGDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public bool DNAABBAGEPH;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[GIJKPPBGMNE]
public class MGDIHOEKGMD : JLFPDMLALBM, KPJILIFBKOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct PPDMFKHAEFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public MGDIHOEKGMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x78E7A40", Offset = "0x78E6040", VA = "0x1878E7A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x78E7BD0", Offset = "0x78E61D0", VA = "0x1878E7BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal static Action<MGDIHOEKGMD> JANHOKDCCGB;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal static Func<MGDIHOEKGMD, Task> DNEMDMMAEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[IgnoreDataMember]
	public bool CCJDEEHLKGE;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public long? AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public int EFPILIKODBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public int? PIEALCHAGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x13CF4F0", Offset = "0x13CDAF0", VA = "0x1813CF4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1085230", Offset = "0x1083830", VA = "0x181085230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public string NLODIPMBEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public OJKGOLKIFJC? INAMIKGPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F20", Offset = "0xAA0520", VA = "0x180AA1F20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	[DataMember(Name = "AvatarItemDesc")]
	public string PDFOJMGMFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Guid? HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x78E0A90", Offset = "0x78DF090", VA = "0x1878E0A90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x78E0A60", Offset = "0x78DF060", VA = "0x1878E0A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public string NKIFGEDFEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA962F0", Offset = "0xA948F0", VA = "0x180A962F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public string EMPMPANDJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA962E0", Offset = "0xA948E0", VA = "0x180A962E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PGOJGHPEBGE CHBGGBNGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xABCF40", Offset = "0xABB540", VA = "0x180ABCF40")]
		[CompilerGenerated]
		get
		{
			return default(PGOJGHPEBGE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x15C6170", Offset = "0x15C4770", VA = "0x1815C6170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public int GJOLGFCDOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xABCFA0", Offset = "0xABB5A0", VA = "0x180ABCFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x15C6160", Offset = "0x15C4760", VA = "0x1815C6160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public int FIACHHAOIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xB19EC0", Offset = "0xB184C0", VA = "0x180B19EC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x1629A20", Offset = "0x1628020", VA = "0x181629A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public LLODCHIGJPE IHKDAIIHFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xB19E70", Offset = "0xB18470", VA = "0x180B19E70")]
		[CompilerGenerated]
		get
		{
			return default(LLODCHIGJPE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1625FB0", Offset = "0x16245B0", VA = "0x181625FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public BJBMFDPJGHF OFOIAKEJGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xD6A6E0", Offset = "0xD68CE0", VA = "0x180D6A6E0")]
		[CompilerGenerated]
		get
		{
			return default(BJBMFDPJGHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x15E7D40", Offset = "0x15E6340", VA = "0x1815E7D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	[DataMember(Name = "Message")]
	public string DDHKENPDGNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA9D770", Offset = "0xA9BD70", VA = "0x180A9D770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA9D7C0", Offset = "0xA9BDC0", VA = "0x180A9D7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public string FJEEJPDEKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xB19E20", Offset = "0xB18420", VA = "0x180B19E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xB65E80", Offset = "0xB64480", VA = "0x180B65E80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool KBEHKDFONLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xFC0E30", Offset = "0xFBF430", VA = "0x180FC0E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xFC0E50", Offset = "0xFBF450", VA = "0x180FC0E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public PEHMMGGEDNB JCCHFCAOGFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xF42850", Offset = "0xF40E50", VA = "0x180F42850")]
		[CompilerGenerated]
		get
		{
			return default(PEHMMGGEDNB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xF412B0", Offset = "0xF3F8B0", VA = "0x180F412B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public ENHFOBPIJHD HHNPHKGHNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA9D700", Offset = "0xA9BD00", VA = "0x180A9D700")]
		[CompilerGenerated]
		get
		{
			return default(ENHFOBPIJHD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA9D730", Offset = "0xA9BD30", VA = "0x180A9D730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public FIMKKFHMKJA? PDINKKKDLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1517A50", Offset = "0x1516050", VA = "0x181517A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x78E4CF0", Offset = "0x78E32F0", VA = "0x1878E4CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool IGFLFMJHNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x78E4D00", Offset = "0x78E3300", VA = "0x1878E4D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool JPGHOFMLEFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x78E4C70", Offset = "0x78E3270", VA = "0x1878E4C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool ODGMAODDMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x78E4E40", Offset = "0x78E3440", VA = "0x1878E4E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	[IgnoreDataMember]
	public bool NCAHFFJEELI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA9EB90", Offset = "0xA9D190", VA = "0x180A9EB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9EBF0", Offset = "0xA9D1F0", VA = "0x180A9EBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	[IgnoreDataMember]
	public bool EJBELALFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2EB4140", Offset = "0x2EB2740", VA = "0x182EB4140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2EB46D0", Offset = "0x2EB2CD0", VA = "0x182EB46D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	[IgnoreDataMember]
	public string IGPFOCIBCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xB66230", Offset = "0xB64830", VA = "0x180B66230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xB66210", Offset = "0xB64810", VA = "0x180B66210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	[IgnoreDataMember]
	public string MFLKJPOOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xEBE400", Offset = "0xEBCA00", VA = "0x180EBE400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xEBE410", Offset = "0xEBCA10", VA = "0x180EBE410")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	[IgnoreDataMember]
	public bool BLDHBDPGELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x10B7D80", Offset = "0x10B6380", VA = "0x1810B7D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xD517C0", Offset = "0xD4FDC0", VA = "0x180D517C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x78E4C90", Offset = "0x78E3290", VA = "0x1878E4C90", Slot = "5")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x78E4D70", Offset = "0x78E3370", VA = "0x1878E4D70", Slot = "6")]
	[AsyncStateMachine(typeof(PPDMFKHAEFA))]
	public virtual Task LDEFHJHMLKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1625FB0", Offset = "0x16245B0", VA = "0x181625FB0")]
	public void LHDJMMNLLII(LLODCHIGJPE HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MGDIHOEKGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface JPLIAFAPLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	long JPEICEICIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string JOHMIIKHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	int LEBCLIMMDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	string AKGGLAINNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	string GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	byte FCCDGIJAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	int DOFEHCHALCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int FHFNLDDBPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	KJFAHMKAJPA AJPLFIKPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	bool MHPNHFFBDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	DateTime HHDAJLCBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	DateTime? BFJMEKNBIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	long? JLDMKEFIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	int MLGIOIPAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	int GMKKLMIDIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	int CCOAKKNJMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	FBKLNOOENKC PMMALKOJADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	FBKLNOOENKC MPFCJMPAAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool HGJKGGNLEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	bool ANCEAOMANGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	bool PDBINEEFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	bool NBBAKDACDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int? DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool LDFDPNBGBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	string EMKCDKDDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGBINKOAFDG();

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HEHECPKHNOK();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[GIJKPPBGMNE]
public class IPAIOMABHCG : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public List<CBOLJLILBKO> BIOLBJHCKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x78E1A80", Offset = "0x78E0080", VA = "0x1878E1A80")]
	public List<string> HFNINLJHCFN(params BMEJHGOLBNP[] MNKFKLCPHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x78E1A00", Offset = "0x78E0000", VA = "0x1878E1A00")]
	public List<string> GEOMLEGDOJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x78E1C40", Offset = "0x78E0240", VA = "0x1878E1C40")]
	public List<string> IMCMBAGNCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x78E1910", Offset = "0x78DFF10", VA = "0x1878E1910", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IPAIOMABHCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[GIJKPPBGMNE]
public class BGFOEJEGFLN : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int LEBCLIMMDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BGFOEJEGFLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[GIJKPPBGMNE]
public class NJJHMAGBFBF : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public long JPEICEICIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public string JOHMIIKHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int LKMNNIBADKO
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool HKFICFMGMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xE8C780", Offset = "0xE8AD80", VA = "0x180E8C780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCA0", Offset = "0xE8A2A0", VA = "0x180E8BCA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int GLPOKJADEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int HEHEMLKJGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1696150", Offset = "0x1694750", VA = "0x181696150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public int MCLEMMLNJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F10", Offset = "0xAA0510", VA = "0x180AA1F10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xAA2490", Offset = "0xAA0A90", VA = "0x180AA2490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int CILEHKFLAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xAD6F80", Offset = "0xAD5580", VA = "0x180AD6F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xAD6580", Offset = "0xAD4B80", VA = "0x180AD6580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public string BNOEAPNFFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public string MNNAPCGNOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x13DE260", Offset = "0x13DC860", VA = "0x1813DE260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public KJFAHMKAJPA? MJLJICDMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xFC0E60", Offset = "0xFBF460", VA = "0x180FC0E60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public IReadOnlyList<Guid> JFPDAAEIPEB
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public AOCLCGMPLAI MECOMNNLOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x78E6100", Offset = "0x78E4700", VA = "0x1878E6100")]
		get
		{
			return default(AOCLCGMPLAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x78E6330", Offset = "0x78E4930", VA = "0x1878E6330", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x78E63C0", Offset = "0x78E49C0", VA = "0x1878E63C0")]
	public bool HILCECGHHLN(NJJHMAGBFBF EGPNAPLBFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x78E6150", Offset = "0x78E4750", VA = "0x1878E6150")]
	private bool EFCEBHPNHOP(NJJHMAGBFBF EGPNAPLBFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x78E63D0", Offset = "0x78E49D0", VA = "0x1878E63D0")]
	private static bool MIIJNIPLDIK(IReadOnlyList<Guid> BPFMFNIKDEA, IReadOnlyList<Guid> PDJGEJJEOCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC070", Offset = "0x2AEA670", VA = "0x182AEC070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NJJHMAGBFBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[GIJKPPBGMNE]
public class DPMFLEIGDKD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public int GDCIOCLCKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DPMFLEIGDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[GIJKPPBGMNE]
public class EPFNMHMDLDA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool KNDJMNMHDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public EPFNMHMDLDA()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[GIJKPPBGMNE]
	public class NewInventionRequestDTO : KPJILIFBKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public JPDHCCGLEHO creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x10755E0", Offset = "0x1073BE0", VA = "0x1810755E0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x78E6860", Offset = "0x78E4E60", VA = "0x1878E6860")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[GIJKPPBGMNE]
	public class AddVersionInventionRequestDTO : KPJILIFBKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x10755E0", Offset = "0x1073BE0", VA = "0x1810755E0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x78DC580", Offset = "0x78DAB80", VA = "0x1878DC580")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[GIJKPPBGMNE]
	public class ModifyTagsRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[GIJKPPBGMNE]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[GIJKPPBGMNE]
	public class ReportRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public DJPCPBDFFGF ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[GIJKPPBGMNE]
	public class CheerRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[GIJKPPBGMNE]
	public class UpdatePriceRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[GIJKPPBGMNE]
	public class UpdateInventionMetadataRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x10755E0", Offset = "0x1073BE0", VA = "0x1810755E0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[GIJKPPBGMNE]
	public class UpdateInventionGeneralPermissionRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public FBKLNOOENKC Permission
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(FBKLNOOENKC);
			}
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[GIJKPPBGMNE]
	public class PublishInventionRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public FBKLNOOENKC Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(FBKLNOOENKC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public KJFAHMKAJPA Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			[CompilerGenerated]
			get
			{
				return default(KJFAHMKAJPA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[GIJKPPBGMNE]
	public class UnpublishInventionRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[GIJKPPBGMNE]
	public class DeleteInventionRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[GIJKPPBGMNE]
	public class SetInventionVersionAccessibilityRequest : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public KJFAHMKAJPA NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			[CompilerGenerated]
			get
			{
				return default(KJFAHMKAJPA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[GIJKPPBGMNE]
	public class SpecialTags : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum CCPKINBAIEE
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum DJPCPBDFFGF
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum MCMPBDCBGGN
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface BGBNHGEPLCD
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	PEHMMGGEDNB JCCHFCAOGFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	string BHEEDJFJNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	int NGMDLLPJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	DateTime ILNECJIIDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool MMPMJJFHKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string CDKNAFCBLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	DNELOPHIANP BIBOHIGKJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOCKPKLKCMF();

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KDKBKMEMIBJ(DNELOPHIANP KIKOMEHHJKA);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface ILNHNLLLCKC
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	string FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	bool FIGEFPABHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOCKPKLKCMF();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct JKIFBDABLJF
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public LHGOEIMNNPK EFFFEGIOMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		[CompilerGenerated]
		readonly get
		{
			return default(LHGOEIMNNPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public ILNHNLLLCKC EGKPBNBFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xF36D30", Offset = "0xF35330", VA = "0x180F36D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public string JEGBGHICMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x62DD8E0", Offset = "0x62DBEE0", VA = "0x1862DD8E0")]
	public JKIFBDABLJF(LHGOEIMNNPK MCNLLIMEENK, [Optional] ILNHNLLLCKC MHEFLGFBEBC, [Optional] string PLCLGCLENOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum LHGOEIMNNPK
{
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[GIJKPPBGMNE]
public class FLGPGGHGPHA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string PFPEKFLIIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FLGPGGHGPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[GIJKPPBGMNE]
public class AHCFJLFNKPN : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string NOPBPBFCNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string DJFNJDHNHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string BIKJKODPEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public string KEEBHCCHGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public List<OADJAPHEJMO> ICMEMCNBGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public AHCFJLFNKPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x4F94830", Offset = "0x4F92E30", VA = "0x184F94830")]
	public AHCFJLFNKPN([Optional] string JICEHFJDDCD, [Optional] string KIBOIALCEHB, [Optional] string EICJPFKBPEA, [Optional] string BGLIDAAMFMN, [Optional] List<OADJAPHEJMO> GBLKHLOFOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[GIJKPPBGMNE]
public class OADJAPHEJMO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public string IAOFJNNCNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public string KEEBHCCHGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OADJAPHEJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[GIJKPPBGMNE]
public class MGEAMDFLMKA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string DJFNJDHNHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public string EFFFEGIOMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public string NOPBPBFCNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public List<string> EPPEAFLNLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MGEAMDFLMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[GIJKPPBGMNE]
public interface KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOCKPKLKCMF();
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[GIJKPPBGMNE]
public interface JLFPDMLALBM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LDEFHJHMLKP();
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[EADHFPAOFHO]
public interface DHGDINDKNOD : KPJILIFBKOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[GIJKPPBGMNE]
public class DMNGFFKFFEM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public int KOLJEAGHCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public string DADEEPGMLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public string CAHBEGDICLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DMNGFFKFFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x78DE480", Offset = "0x78DCA80", VA = "0x1878DE480")]
	public DMNGFFKFFEM([Optional] Guid MECFNLMOEBM, int CGKEIIDMLBB = 0, [Optional] string BPPJLJCNFGJ, [Optional] string EAEOKNLIPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[GIJKPPBGMNE]
public class DADENNIAJDJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public const int INMLPDPHADM = 0;

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public long JLCFFEENKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public BHKCKFPPGOJ JCHDGCBIPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public string LGLDAJEBFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public List<DMNGFFKFFEM> MPGOKCBFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public int DOPBCHBPMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F10", Offset = "0xAA0510", VA = "0x180AA1F10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA2490", Offset = "0xAA0A90", VA = "0x180AA2490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public KJFAHMKAJPA AJPLFIKPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
		[CompilerGenerated]
		get
		{
			return default(KJFAHMKAJPA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xB18030", Offset = "0xB16630", VA = "0x180B18030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public string CJKKPJOCAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public bool PGCAHFEAIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x217EA40", Offset = "0x217D040", VA = "0x18217EA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x78DD0D0", Offset = "0x78DB6D0", VA = "0x1878DD0D0")]
	public DADENNIAJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x78DD160", Offset = "0x78DB760", VA = "0x1878DD160")]
	public DADENNIAJDJ(long EBOLKPJBCEI = 0L, [Optional] BHKCKFPPGOJ DLJGALHAFCH, [Optional] string DCBLDKNLCIB, [Optional] List<DMNGFFKFFEM> JOKEAFMNPCC, int JLKLAKIGBEB = 0, [Optional] string DJFMCHMDHGK, KJFAHMKAJPA CMNPBHOKKNN = KJFAHMKAJPA.Private, [Optional] string GCJHAFFFKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class ABDIMGFNFBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public readonly int NGMDLLPJPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public readonly DADENNIAJDJ JNIGLMNIFNH;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x106B260", Offset = "0x1069860", VA = "0x18106B260")]
	public ABDIMGFNFBG(int PPFHIIIBKME, DADENNIAJDJ CHJINAPIKBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[GIJKPPBGMNE]
public class BHKCKFPPGOJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public string BPPPBNLHGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public string JOLEPIOAKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public string AIDFLOBLCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public string JJCHEACENKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public string KKEHEJPMBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public string MPGOKCBFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x78DC880", Offset = "0x78DAE80", VA = "0x1878DC880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BHKCKFPPGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F94830", Offset = "0x4F92E30", VA = "0x184F94830")]
	public BHKCKFPPGOJ([Optional] string HGKPEJMPGNP, [Optional] string FLENHKGNAPP, [Optional] string GCLOMJGLIDI, [Optional] string FLDOKNIDLGO, [Optional] string FOBPLFIJKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[GIJKPPBGMNE]
public class MBBMPKOBECK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public Dictionary<int, DADENNIAJDJ> CPMMPJKBJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MBBMPKOBECK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[GIJKPPBGMNE]
public class FMBCKNBNHIO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public List<int> KODFBMJLLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public byte? NHNLDEBJNME
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x321EDB0", Offset = "0x321D3B0", VA = "0x18321EDB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x321EEA0", Offset = "0x321D4A0", VA = "0x18321EEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public int? DIGADJMFCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x13CF4E0", Offset = "0x13CDAE0", VA = "0x1813CF4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x13CF510", Offset = "0x13CDB10", VA = "0x1813CF510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FMBCKNBNHIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class NHPECEPEGKO
{
	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x78E6090", Offset = "0x78E4690", VA = "0x1878E6090")]
	public static CPEFFIJECFJ JCCPHCNGLCM(this DMNGFFKFFEM CCKLBDLJPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
public enum ENHFOBPIJHD
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public enum PEHMMGGEDNB
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[GIJKPPBGMNE]
public class LEFBBEKGEME : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	[DataMember(Name = "PlayerId")]
	public int NGMDLLPJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int AFNDEKPIHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public int FIJCJJPNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LEFBBEKGEME()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[GIJKPPBGMNE]
	public class ProgressionEventRecordDTO : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public int NGMDLLPJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public int FIACHHAOIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public int EHOFOOJLJMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int JIPJCNPDFNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public int DKFIBFGKKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public DateTime? DKMMFECMDGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x14274A0", Offset = "0x1425AA0", VA = "0x1814274A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x155F7E0", Offset = "0x155DDE0", VA = "0x18155F7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public int LNNOCJFDBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x78E7D10", Offset = "0x78E6310", VA = "0x1878E7D10")]
		public ProgressionEventRecordDTO(int PPFHIIIBKME = 0, int HKMENKMILGC = 0, int CLBGJJKNNBI = 0, int PDPBBKCCPIH = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[GIJKPPBGMNE]
	public class ProgressionEventDTO : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public long NHLKDHNPENB
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public string CLGAHBNBCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public List<ProgressionEventRewardDTO> OMKJIFFAHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public List<KeepsakeRoomListDTO> FGDLOGNACFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public DateTime MPIAMPGKFLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xA95020", Offset = "0xA93620", VA = "0x180A95020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public DateTime NFBBOOEHCEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F20", Offset = "0xAA0520", VA = "0x180AA1F20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public DateTime JLCLEBEPGFM
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E20", Offset = "0xFBF420", VA = "0x180FC0E20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public bool AOLJBJCGGME
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xD94690", Offset = "0xD92C90", VA = "0x180D94690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xDB03D0", Offset = "0xDAE9D0", VA = "0x180DB03D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public int DOPDKOCOFAK
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x14B8A00", Offset = "0x14B7000", VA = "0x1814B8A00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x2330C10", Offset = "0x232F210", VA = "0x182330C10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public float CMJNAGILKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x128CCA0", Offset = "0x128B2A0", VA = "0x18128CCA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x14635F0", Offset = "0x1461BF0", VA = "0x1814635F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Guid? NAJODLLBAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x78E7C40", Offset = "0x78E6240", VA = "0x1878E7C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x78E7C30", Offset = "0x78E6230", VA = "0x1878E7C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public string APEOMIADFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xA962E0", Offset = "0xA948E0", VA = "0x180A962E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public string OFGIBCINDGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xA99380", Offset = "0xA97980", VA = "0x180A99380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xA99450", Offset = "0xA97A50", VA = "0x180A99450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public string MFAPBEKHLPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xA9D690", Offset = "0xA9BC90", VA = "0x180A9D690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xA9D640", Offset = "0xA9BC40", VA = "0x180A9D640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public string GMDGHPIAHED
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xA9D7B0", Offset = "0xA9BDB0", VA = "0x180A9D7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA9D620", Offset = "0xA9BC20", VA = "0x180A9D620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x78E7C60", Offset = "0x78E6260", VA = "0x1878E7C60")]
		public ProgressionEventDTO(long DBKMLACHOOC = 0L, [Optional] string DJFMCHMDHGK, [Optional] List<ProgressionEventRewardDTO> LLGMPADICGP, [Optional] List<KeepsakeRoomListDTO> CIIFGNNDEBI, [Optional] DateTime AJOEJHMGHBJ, [Optional] DateTime FLAHAAINADJ, [Optional] DateTime KNIFABBHDCG, bool PHJMFFHOGEM = false, int NJOCPJNAOIN = 0, float OGFDLPPECJN = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[GIJKPPBGMNE]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public long JPHBBDMHGCP
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public long NHLKDHNPENB
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public int? IFKJMINDHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public int? FODKPLONJKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA94FD0", Offset = "0xA935D0", VA = "0x180A94FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public long? JBENBMPHGNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xF61520", Offset = "0xF5FB20", VA = "0x180F61520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xF621F0", Offset = "0xF607F0", VA = "0x180F621F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public long OBLFDFAPPCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E20", Offset = "0xFBF420", VA = "0x180FC0E20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public TimeSpan EEGMGDIBFMK
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x78E2AC0", Offset = "0x78E10C0", VA = "0x1878E2AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public long LCOAOPPGDDC
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x13DE260", Offset = "0x13DC860", VA = "0x1813DE260")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public TimeSpan FCHHKANHOFO
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x78E2B10", Offset = "0x78E1110", VA = "0x1878E2B10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public int KBMBLPMLMIM
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xEA1DD0", Offset = "0xEA03D0", VA = "0x180EA1DD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xFF7A80", Offset = "0xFF6080", VA = "0x180FF7A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public ONPGLOLIMJA MFIJFKHDJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x130D2A0", Offset = "0x130B8A0", VA = "0x18130D2A0")]
			[CompilerGenerated]
			get
			{
				return default(ONPGLOLIMJA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x250B320", Offset = "0x2509920", VA = "0x18250B320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public List<KeepsakeRoomDTO> EDMDDMKMOCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x78E2B60", Offset = "0x78E1160", VA = "0x1878E2B60")]
		public KeepsakeRoomListDTO(long DPAAGCAMIEF = 0L, long DBKMLACHOOC = 0L, [Optional] int? OKFLIIIFLFB, [Optional] int? LLNIMPHGHFO, [Optional] long? NBIBMMKIMGB, long CFDHCMKKPMJ = 0L, long LGBINBDMJPA = 0L, int NJBPDDGFIKA = 0, ONPGLOLIMJA MKGBBGPINMH = ONPGLOLIMJA.Standard, [Optional] List<KeepsakeRoomDTO> LIOCPDKFEFG)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[GIJKPPBGMNE]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public long DDOKLKLMGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public long CLONBIJNLDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public long JPHBBDMHGCP
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public ONPGLOLIMJA MONFNOPPPGA
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
			[CompilerGenerated]
			get
			{
				return default(ONPGLOLIMJA);
			}
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public int HBFGFFLJNDB
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x1696150", Offset = "0x1694750", VA = "0x181696150")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x78E2A60", Offset = "0x78E1060", VA = "0x1878E2A60")]
		public KeepsakeRoomDTO(long FAMAGHMHIDF = 0L, long PANGCFBNCCJ = 0L, long DPAAGCAMIEF = 0L, ONPGLOLIMJA EHLAHNIAPLD = ONPGLOLIMJA.Standard, int OGFNFILHJOI = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[GIJKPPBGMNE]
	public class ProgressionEventRewardDTO : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public long AKLHJOBCFCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public int LAOJDOEBODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public string GKPCMLDMKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public int FIACHHAOIPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public int JIHOFMJEDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x1696150", Offset = "0x1694750", VA = "0x181696150")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public bool PKLOEJNJHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public bool LDGMFJNHCOF
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xF51DC0", Offset = "0xF503C0", VA = "0x180F51DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x15CE8A0", Offset = "0x15CCEA0", VA = "0x1815CE8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[GIJKPPBGMNE]
	public class ProgressionEventPurchasableXpBoostDTO : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public Guid DBIKLEPHEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public int EABFKBNJLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public int CAGEBPDNAGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public int HILGJBLIBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public long EDHMPNAHEKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA95020", Offset = "0xA93620", VA = "0x180A95020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		public long AKNFGKGAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F20", Offset = "0xAA0520", VA = "0x180AA1F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum ONPGLOLIMJA
{
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public enum FHPPEAFCOMD
{
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[GIJKPPBGMNE]
public class APLMOMCENDB : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public string GEBIGOAJPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public string? HNNOIPHAHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public APLMOMCENDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface KBCLCEENLJL
{
	[Cpp2IlInjected.Token(Token = "0x17000201")]
	bool DBIJHINPEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	string? BMACIBIONGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	string? HJGHOPNCCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public interface FIHIMGKHCPI<T> : KBCLCEENLJL
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class IGCELGAAGGN
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x3E04390", Offset = "0x3E02990", VA = "0x183E04390")]
	public static FIHIMGKHCPI<T> ADNKINOHCOK<T, U>(this FIHIMGKHCPI<U> CENCPMGPALN, Func<U, T> DHIKLCCINDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct KDAPBJGLNBN<T> : FIHIMGKHCPI<T>, KBCLCEENLJL
{
	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public bool DBIJHINPEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x10B0470", Offset = "0x10AEA70", VA = "0x1810B0470", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FA20", Offset = "0x2D7E020", VA = "0x182D7FA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public string? BMACIBIONGO
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xF36D30", Offset = "0xF35330", VA = "0x180F36D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public string? HJGHOPNCCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x55B23F0", Offset = "0x55B09F0", VA = "0x1855B23F0")]
	public static KDAPBJGLNBN<T> LMCDMBILHLK(T FKMNCAKIOFK)
	{
		return default(KDAPBJGLNBN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x55B2330", Offset = "0x55B0930", VA = "0x1855B2330")]
	public static KDAPBJGLNBN<T> GNOMGHBDLGI(string GJJJIJGCEEO, string EIGJJNLAGIM = "")
	{
		return default(KDAPBJGLNBN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[GIJKPPBGMNE]
public class HEFFBECLBFK : KBCLCEENLJL, KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public bool DBIJHINPEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public string? BMACIBIONGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	[DataMember(Name = "error_id")]
	public string? HJGHOPNCCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
	public virtual void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x78E0C30", Offset = "0x78DF230", VA = "0x1878E0C30")]
	public static HEFFBECLBFK LMCDMBILHLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x78E0BA0", Offset = "0x78DF1A0", VA = "0x1878E0BA0")]
	public static HEFFBECLBFK GNOMGHBDLGI(string GJJJIJGCEEO, string EIGJJNLAGIM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HEFFBECLBFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[COMCBLKEMJL]
public abstract class JPPKKBJBENK<T> : HEFFBECLBFK, FIHIMGKHCPI<T>, KBCLCEENLJL
{
	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	protected JPPKKBJBENK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[COMCBLKEMJL]
public class BEDFMODCOCJ<T> : JPPKKBJBENK<T>
{
	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x685FFC0", Offset = "0x685E5C0", VA = "0x18685FFC0")]
	private static void NCDEPCNDLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x4A126E0", Offset = "0x4A10CE0", VA = "0x184A126E0")]
	public BEDFMODCOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[COMCBLKEMJL]
public class FPEHGGCGONO<T> : JPPKKBJBENK<T>, JLFPDMLALBM, KPJILIFBKOE where T : KPJILIFBKOE, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct JBPJFHJCEGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public FPEHGGCGONO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x549D920", Offset = "0x549BF20", VA = "0x18549D920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x549DBA0", Offset = "0x549C1A0", VA = "0x18549DBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x4F527C0", Offset = "0x4F50DC0", VA = "0x184F527C0", Slot = "8")]
	public override void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4F52A00", Offset = "0x4F51000", VA = "0x184F52A00", Slot = "10")]
	[AsyncStateMachine(typeof(FPEHGGCGONO<>.JBPJFHJCEGK))]
	public Task LDEFHJHMLKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4F52AD0", Offset = "0x4F510D0", VA = "0x184F52AD0")]
	public static FPEHGGCGONO<T> LMCDMBILHLK(T FKMNCAKIOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x4F528B0", Offset = "0x4F50EB0", VA = "0x184F528B0")]
	public new static FPEHGGCGONO<T> GNOMGHBDLGI(string GJJJIJGCEEO, string EIGJJNLAGIM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
	public FPEHGGCGONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[COMCBLKEMJL]
public class HKNNEKDIDCB<T> : JPPKKBJBENK<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A126E0", Offset = "0x4A10CE0", VA = "0x184A126E0")]
	public HKNNEKDIDCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[COMCBLKEMJL]
public class FHAEAOBGIID<T> : JPPKKBJBENK<List<T>>, JLFPDMLALBM, KPJILIFBKOE where T : KPJILIFBKOE, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct IMADILPJEBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public FHAEAOBGIID<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x525DC40", Offset = "0x525C240", VA = "0x18525DC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x525DE40", Offset = "0x525C440", VA = "0x18525DE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x4F3EAC0", Offset = "0x4F3D0C0", VA = "0x184F3EAC0")]
	public static FHAEAOBGIID<T> LMCDMBILHLK(List<T> FKMNCAKIOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x4F3E8A0", Offset = "0x4F3CEA0", VA = "0x184F3E8A0")]
	public new static FHAEAOBGIID<T> GNOMGHBDLGI(string GJJJIJGCEEO, string EIGJJNLAGIM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x4F3E640", Offset = "0x4F3CC40", VA = "0x184F3E640", Slot = "8")]
	public override void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F3E9F0", Offset = "0x4F3CFF0", VA = "0x184F3E9F0", Slot = "10")]
	[AsyncStateMachine(typeof(FHAEAOBGIID<>.IMADILPJEBF))]
	public Task LDEFHJHMLKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x4F3EBF0", Offset = "0x4F3D1F0", VA = "0x184F3EBF0")]
	public FHAEAOBGIID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum EBDAMLPHNFF
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class NADGCHDGKLN
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x78E5EC0", Offset = "0x78E44C0", VA = "0x1878E5EC0")]
	public static bool DJGABNADKIC(this EBDAMLPHNFF PDGKOFDJCFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x78E5EC0", Offset = "0x78E44C0", VA = "0x1878E5EC0")]
	public static bool HLEENIPLAEE(this EBDAMLPHNFF PDGKOFDJCFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum PGOJGHPEBGE
{
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	ProgressionEvent = 400,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	RoomieCredits = 500
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum FIMKKFHMKJA
{
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	NonPurchasedEarnedByP2Pv2 = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	RoomieEnergyPack = 1101
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public enum LLODCHIGJPE
{
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public enum BJBMFDPJGHF
{
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public enum HJJLKPHCDEI
{
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[GIJKPPBGMNE]
	public class BalanceResponseDTO : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public PGOJGHPEBGE CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(PGOJGHPEBGE);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		[DataMember(Name = "Platform")]
		public FIMKKFHMKJA BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			[CompilerGenerated]
			get
			{
				return default(FIMKKFHMKJA);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public virtual void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[GIJKPPBGMNE]
	public class FilteredTextDTO : KPJILIFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public string FDJBGNNLJAG
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public int BEJGGFIOHKI
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[GIJKPPBGMNE]
public class CMEAHPDDABK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string EOAKLGBANMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public string FGEKNDBCEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CMEAHPDDABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[GIJKPPBGMNE]
public class POBDEJDKBGP : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public List<CMEAHPDDABK> FPMJGOIFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public POBDEJDKBGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[GIJKPPBGMNE]
public class IFGEEIBMIII : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public string PINDBGJPNJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public IFGEEIBMIII(string OJGCAEHHMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[GIJKPPBGMNE]
public class IFLDPDECDLD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public List<CMEAHPDDABK> FPMJGOIFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IFLDPDECDLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[GIJKPPBGMNE]
public class KIEFFENDPAJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public List<IFGEEIBMIII> JKPANLFDCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public string BCPPPEDIICI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public bool BFDMLLEKBII
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public int CEAEKGIPPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KIEFFENDPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x78E29A0", Offset = "0x78E0FA0", VA = "0x1878E29A0")]
	public KIEFFENDPAJ(string ONKLKNCHMGE, List<IFGEEIBMIII> CJGEJGFKMBA, bool MADEGCCENHI, int OKDCHLACJMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[GIJKPPBGMNE]
public class MIFPIHPHNEK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public List<IFLDPDECDLD> MBCPKBKOBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public bool BFDMLLEKBII
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MIFPIHPHNEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[GIJKPPBGMNE]
public class OBPCMEDCJCL : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum LPIINNAFGCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public const string NMEHFLIDCDD = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public string BCPPPEDIICI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public LPIINNAFGCM EFFFEGIOMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(LPIINNAFGCM);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x78E6940", Offset = "0x78E4F40", VA = "0x1878E6940")]
	public OBPCMEDCJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x78E68F0", Offset = "0x78E4EF0", VA = "0x1878E68F0")]
	public OBPCMEDCJCL(string ONKLKNCHMGE, LPIINNAFGCM MCNLLIMEENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[GIJKPPBGMNE]
public class LNPIPHAJILH : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public bool LKJNELEDEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LNPIPHAJILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class HNMPHHEKBGH
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public enum ABCKHDHOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[GIJKPPBGMNE]
public class LMFMPEAEIBE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public Guid JGFHMKKHHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public long HAHALELAGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA94FD0", Offset = "0xA935D0", VA = "0x180A94FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public ICJJPMNBKGE DDMJHEPBFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LMFMPEAEIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x78E3E00", Offset = "0x78E2400", VA = "0x1878E3E00")]
	public LMFMPEAEIBE(long PANGCFBNCCJ, Guid GDJMGKDOGCK, long DKCPHNPHHEP, ICJJPMNBKGE OGKEEPNOLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x78E3DE0", Offset = "0x78E23E0", VA = "0x1878E3DE0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[GIJKPPBGMNE]
public class BGCFJHLFDMK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public CDNAMBEPHLK AJMNBCHCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(CDNAMBEPHLK);
		}
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public POJIMGKOIHD OBAGOOEDJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BGCFJHLFDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x106B260", Offset = "0x1069860", VA = "0x18106B260")]
	public BGCFJHLFDMK(CDNAMBEPHLK CENCPMGPALN, POJIMGKOIHD PHFCKNAFAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[GIJKPPBGMNE]
public class ICJJPMNBKGE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public Guid? NIJEIJILPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x31E5480", Offset = "0x31E3A80", VA = "0x1831E5480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x78E1480", Offset = "0x78DFA80", VA = "0x1878E1480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public Guid OJEMCBEHEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xEA1DE0", Offset = "0xEA03E0", VA = "0x180EA1DE0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x10A58A0", Offset = "0x10A3EA0", VA = "0x1810A58A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public ICJJPMNBKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x78E1490", Offset = "0x78DFA90", VA = "0x1878E1490")]
	public ICJJPMNBKGE(Guid? EPLGIIKDDPM, Guid PHENGOKPAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[GIJKPPBGMNE]
public class POJIMGKOIHD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public Guid JGFHMKKHHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public long DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FD0", Offset = "0xA935D0", VA = "0x180A94FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public Guid HHJPKAFDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xF61520", Offset = "0xF5FB20", VA = "0x180F61520")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xF621F0", Offset = "0xF607F0", VA = "0x180F621F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xFC0E20", Offset = "0xFBF420", VA = "0x180FC0E20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public DateTime HHDAJLCBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x13DE260", Offset = "0x13DC860", VA = "0x1813DE260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public POJIMGKOIHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[GIJKPPBGMNE]
public class OGKFFNBLGEM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public string GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public List<long> OODDNGKFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public List<LGFIBDAMPBO> CBKDAFBPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public string NOKHPHJDFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public byte? OIIMPGAOFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x78E6AC0", Offset = "0x78E50C0", VA = "0x1878E6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x78E6B00", Offset = "0x78E5100", VA = "0x1878E6B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public int? JNIMADACGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x78E3D00", Offset = "0x78E2300", VA = "0x1878E3D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x78E3CF0", Offset = "0x78E22F0", VA = "0x1878E3CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public Guid? HJKMAGGEDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x78E6AE0", Offset = "0x78E50E0", VA = "0x1878E6AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x78E6AD0", Offset = "0x78E50D0", VA = "0x1878E6AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public bool GBGLFCMGIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xA99370", Offset = "0xA97970", VA = "0x180A99370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA99260", Offset = "0xA97860", VA = "0x180A99260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OGKFFNBLGEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[GIJKPPBGMNE]
public class NPPHCBECOKK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public Guid HJKMAGGEDII
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public string GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xFC0E20", Offset = "0xFBF420", VA = "0x180FC0E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public DateTime HHDAJLCBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x13DE260", Offset = "0x13DC860", VA = "0x1813DE260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public string NOKHPHJDFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public List<long> OODDNGKFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public List<MLDNDEOEJCJ> CBKDAFBPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA962F0", Offset = "0xA948F0", VA = "0x180A962F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public byte OIIMPGAOFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xB19E40", Offset = "0xB18440", VA = "0x180B19E40")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xB19E50", Offset = "0xB18450", VA = "0x180B19E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public int JNIMADACGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACAE50", VA = "0x180ACC850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x15C6150", Offset = "0x15C4750", VA = "0x1815C6150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NPPHCBECOKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[GIJKPPBGMNE]
public class BBOCKFKDCJH : NPPHCBECOKK
{
	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public Guid NCDLKMDCKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1C43FB0", Offset = "0x1C425B0", VA = "0x181C43FB0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C500", Offset = "0x5C8AB00", VA = "0x185C8C500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BBOCKFKDCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public enum CDNAMBEPHLK
{
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public interface CLGDAEGFDFG
{
	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JPPKKBJBENK<NPPHCBECOKK>> PKIANPFGCDG(Guid? GFKCOHLNPGF, long PANGCFBNCCJ, string DJFMCHMDHGK, string OINDFPIKPLL, string IFCAGKLINAN, string OFPLHAGNOLG, byte NDLHPLKACFL, int ONDGBPEOGJF, [Optional] List<long> KOJHLIGHDBJ, [Optional] List<MLDNDEOEJCJ> KJHJEJJKHMC, bool LKBFHKBPJDF = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JPPKKBJBENK<NPPHCBECOKK>> FEKNJJGFPHF(Guid GDJMGKDOGCK, long PANGCFBNCCJ, [Optional] string DJFMCHMDHGK, [Optional] string OINDFPIKPLL, [Optional] string IFCAGKLINAN, [Optional] List<long> KOJHLIGHDBJ, [Optional] Dictionary<string, string> KJHJEJJKHMC, [Optional] string OFPLHAGNOLG, [Optional] byte? NDLHPLKACFL, [Optional] int? ONDGBPEOGJF, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HEFFBECLBFK> KGBEKILJNDN(Guid GDJMGKDOGCK, long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<NPPHCBECOKK>> EKNINFEOOCN(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<POJIMGKOIHD>> MGNJBBEMLKB(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<BGCFJHLFDMK>> GHHLBBFJLJE(long PANGCFBNCCJ, List<LMFMPEAEIBE> FAJNOCIIJMC, [Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[GIJKPPBGMNE]
public class LGFIBDAMPBO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public string NOKHPHJDFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LGFIBDAMPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[GIJKPPBGMNE]
public class MLDNDEOEJCJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public long DFCNOLFDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public string NOKHPHJDFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MLDNDEOEJCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[GIJKPPBGMNE]
public class PFAHMEDCFHN : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public long DFCNOLFDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public string NOKHPHJDFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2F80", Offset = "0x4FA1580", VA = "0x184FA2F80")]
	public PFAHMEDCFHN(long CGJNLNOKCBF, string MKBODFCJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public interface NCKNBLKODIO
{
	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JPPKKBJBENK<List<MLDNDEOEJCJ>>> MLJPEILBJMI(long PANGCFBNCCJ, List<PFAHMEDCFHN> FAJNOCIIJMC, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HEFFBECLBFK> PJEBMBBOBJN(long CGJNLNOKCBF, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<MLDNDEOEJCJ>> DPEDLICJKFA(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[GIJKPPBGMNE]
public class OMGHINDDJBK : NKIEJEBHMKH, IEquatable<OMGHINDDJBK>
{
	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x78E6610", Offset = "0x78E4C10", VA = "0x1878E6610", Slot = "7")]
	public bool Equals(OMGHINDDJBK IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x78E7120", Offset = "0x78E5720", VA = "0x1878E7120", Slot = "6")]
	public override NKIEJEBHMKH JJDCBGIHCCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OMGHINDDJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public static class MEJMCPNKPPC
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x78E4A30", Offset = "0x78E3030", VA = "0x1878E4A30")]
	public static OMGHINDDJBK KJMDBDOADCO(this OIBEPGAIAEK KGKOGFAMIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x78E4AA0", Offset = "0x78E30A0", VA = "0x1878E4AA0")]
	public static OMGHINDDJBK OJFOBNBEBIL(string MBOLDFDJOOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[GIJKPPBGMNE]
public class OIBEPGAIAEK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public const int KFNDJDAFHDO = 3;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public const int ECOHKCDKMOB = 40;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public const int BBJPNBGEOJJ = 180;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public const int JFNCNIHEANH = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public const int ICFKPFKAEOC = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public const int HNIICDEJLBD = 8;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public const int NNCBKOGLKEA = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public const int HDEHAPIEPMG = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public const int OPKHEDEBPDO = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? MFNNJGKDBJC;

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public Guid HJKMAGGEDII
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public string? ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public string? GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public int DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xB18030", Offset = "0xB16630", VA = "0x180B18030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public Guid? KOIHHIIPJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x78E6F40", Offset = "0x78E5540", VA = "0x1878E6F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x78E6EC0", Offset = "0x78E54C0", VA = "0x1878E6EC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xAF9970", Offset = "0xAF7F70", VA = "0x180AF9970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xEFD050", Offset = "0xEFB650", VA = "0x180EFD050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public int? AJBLEOOONLL
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x7302AB0", Offset = "0x73010B0", VA = "0x187302AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7302AD0", Offset = "0x73010D0", VA = "0x187302AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public int? PLKAOGJFPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x78E6E30", Offset = "0x78E5430", VA = "0x1878E6E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x78E6EB0", Offset = "0x78E54B0", VA = "0x1878E6EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public IReadOnlyList<HGNGKIOMOJK> MLHFFKMLOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA99380", Offset = "0xA97980", VA = "0x180A99380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA99450", Offset = "0xA97A50", VA = "0x180A99450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA9D690", Offset = "0xA9BC90", VA = "0x180A9D690")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xFDC550", Offset = "0xFDAB50", VA = "0x180FDC550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public DateTime HHDAJLCBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA9D7B0", Offset = "0xA9BDB0", VA = "0x180A9D7B0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xFDC7A0", Offset = "0xFDADA0", VA = "0x180FDC7A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	[IgnoreDataMember]
	public PNEONIGCEOA ONPJOMPJDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x78E6E40", Offset = "0x78E5440", VA = "0x1878E6E40")]
		get
		{
			return default(PNEONIGCEOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> GLKBDAAHLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x78E6DE0", Offset = "0x78E53E0", VA = "0x1878E6DE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA9D7C0", Offset = "0xA9BDC0", VA = "0x180A9D7C0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x78E6DD0", Offset = "0x78E53D0", VA = "0x1878E6DD0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OIBEPGAIAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x78E6F60", Offset = "0x78E5560", VA = "0x1878E6F60")]
	public OIBEPGAIAEK(Guid GFKCOHLNPGF, long PANGCFBNCCJ, string DJFMCHMDHGK, string OINDFPIKPLL, string IFCAGKLINAN, int NCCILLFFLEP, int? MCCABHOJFFO, int? CPLEDCEDBHD, List<HGNGKIOMOJK> EHOHMPPBOJP, [Optional] DateTime BOLFBHDEFLN, [Optional] DateTime GLBKFHNLKAJ, [Optional] Guid? EJMENEBFOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x78E6ED0", Offset = "0x78E54D0", VA = "0x1878E6ED0")]
	private PNEONIGCEOA OMMGOCGMLJG()
	{
		return default(PNEONIGCEOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x78E6B10", Offset = "0x78E5110", VA = "0x1878E6B10")]
	private Dictionary<Guid, int> ALGBKFAONEH(IReadOnlyList<HGNGKIOMOJK> EHOHMPPBOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[GIJKPPBGMNE]
public class MAJKHDOEGNF : KPJILIFBKOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public Guid HJKMAGGEDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public long CLONBIJNLDA;

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MAJKHDOEGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[GIJKPPBGMNE]
public class MPPLCCDKIGD : OIBEPGAIAEK
{
	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public Guid HNPGKDJCAGA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xFDCA10", Offset = "0xFDB010", VA = "0x180FDCA10")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xFDC770", Offset = "0xFDAD70", VA = "0x180FDC770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public Guid? JLGGJGNLDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x78E5EA0", Offset = "0x78E44A0", VA = "0x1878E5EA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x78E5E80", Offset = "0x78E4480", VA = "0x1878E5E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MPPLCCDKIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[GIJKPPBGMNE]
public class GIGNGCOOFAN : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public string? ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public string? GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public int DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public int? AJBLEOOONLL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x13CF4D0", Offset = "0x13CDAD0", VA = "0x1813CF4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x13CF500", Offset = "0x13CDB00", VA = "0x1813CF500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public int? PLKAOGJFPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xE19CE0", Offset = "0xE182E0", VA = "0x180E19CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xE19D20", Offset = "0xE18320", VA = "0x180E19D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public List<HGNGKIOMOJK> MLHFFKMLOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public Guid? JLGGJGNLDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x78E0A90", Offset = "0x78DF090", VA = "0x1878E0A90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x78E0A60", Offset = "0x78DF060", VA = "0x1878E0A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public Guid? HJKMAGGEDII
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x78E0AB0", Offset = "0x78DF0B0", VA = "0x1878E0AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x78E0A80", Offset = "0x78DF080", VA = "0x1878E0A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public bool GBGLFCMGIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xEAD260", Offset = "0xEAB860", VA = "0x180EAD260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x1010CD0", Offset = "0x100F2D0", VA = "0x181010CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x78E0A70", Offset = "0x78DF070", VA = "0x1878E0A70", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GIGNGCOOFAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[GIJKPPBGMNE]
public class HGNGKIOMOJK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public KMCLNMBABCP ELLFDIPCJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(KMCLNMBABCP);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public Guid OHIHLABPIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x1BBFBF0", Offset = "0x1BBE1F0", VA = "0x181BBFBF0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9C90", Offset = "0x5EB8290", VA = "0x185EB9C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HGNGKIOMOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x78E0D20", Offset = "0x78DF320", VA = "0x1878E0D20")]
	public HGNGKIOMOJK(Guid EODFJHHBOPB, KMCLNMBABCP EHLAHNIAPLD, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[GIJKPPBGMNE]
public class DMDIJFCNNDF : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public Guid MECOLNBLPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public int BNJMNIBGADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public DateTime PHGHCJDDHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xA95020", Offset = "0xA93620", VA = "0x180A95020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x78DE410", Offset = "0x78DCA10", VA = "0x1878DE410")]
	public DMDIJFCNNDF(Guid IHPOFPCDFAB, string DJFMCHMDHGK, int JDMHOBFDDID, DateTime OHAKEBALFGN, int FOBPLBPGNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DMDIJFCNNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[GIJKPPBGMNE]
public class KDOAMAFAKGG : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public Guid MECOLNBLPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public int CGOABNPPMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KDOAMAFAKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x5974210", Offset = "0x5972810", VA = "0x185974210")]
	public KDOAMAFAKGG(Guid IHPOFPCDFAB, int IPIGJIEEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[GIJKPPBGMNE]
public class EJNIJLEGJML : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public int CGOABNPPMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public Guid FLLGNJHPOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x1BBFBF0", Offset = "0x1BBE1F0", VA = "0x181BBFBF0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9C90", Offset = "0x5EB8290", VA = "0x185EB9C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public int JDDEMOKINLO
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public Guid? CGJCKOOCIHN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xFD88B0", Offset = "0xFD6EB0", VA = "0x180FD88B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x24E8E30", Offset = "0x24E7430", VA = "0x1824E8E30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public int IKBOCCHIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xAB3890", Offset = "0xAB1E90", VA = "0x180AB3890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x1745450", Offset = "0x1743A50", VA = "0x181745450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public Dictionary<Guid, Guid?> APOCFJEHFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public EJNIJLEGJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x78DEDA0", Offset = "0x78DD3A0", VA = "0x1878DEDA0")]
	public EJNIJLEGJML(int IPIGJIEEHGA, Guid CNLOJHGAIPP, int JNOCFIOMBDH, Guid? MEGFHAHJEMD, int JELIMCDIAMI, Dictionary<Guid, Guid?> PPEHIDJNCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[GIJKPPBGMNE]
public class ODLEBGBKKPI : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public JEALKKALOOI LMBBJLLHPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(JEALKKALOOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public HJJLKPHCDEI? JOMNLIOMHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x13CF390", Offset = "0x13CD990", VA = "0x1813CF390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F60", Offset = "0x13D8560", VA = "0x1813D9F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public BalanceResponseDTO OBKLAIJJCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public List<POJIMGKOIHD> EDAPLIOCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public ODLEBGBKKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x78E6960", Offset = "0x78E4F60", VA = "0x1878E6960")]
	public ODLEBGBKKPI(JEALKKALOOI AIOOMAPCDNK, HJJLKPHCDEI? NOGPCHOLONN, BalanceResponseDTO FJNNDBMDIBA, List<POJIMGKOIHD> FDJIKGJBPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x78E6950", Offset = "0x78E4F50", VA = "0x1878E6950", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public enum KMCLNMBABCP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum JEALKKALOOI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum PNEONIGCEOA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public interface EFGIPPOJNJL
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	static GJIKMKGBNOL<OIBEPGAIAEK> NGJCJBELIPE;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	static GJIKMKGBNOL<OIBEPGAIAEK> NABNPGGLKLF;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	static GJIKMKGBNOL<Guid> BLHDJBDEFJD;

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JPPKKBJBENK<OIBEPGAIAEK?>?>? JIEOCFAAFFL(Guid? GFKCOHLNPGF, long PANGCFBNCCJ, string DJFMCHMDHGK, string? OINDFPIKPLL, string? IFCAGKLINAN, int NCCILLFFLEP, PNEONIGCEOA MMAOMOIFICI, [Optional] Dictionary<Guid, int>? GOPCCCHKNPA, [Optional] Guid? PFEOIFBFCBF, bool LKBFHKBPJDF = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JPPKKBJBENK<OIBEPGAIAEK?>?>? JBLHEJLLNPC(Guid IHPOFPCDFAB, long PANGCFBNCCJ, string DJFMCHMDHGK, string? OINDFPIKPLL, string? IFCAGKLINAN, int NCCILLFFLEP, PNEONIGCEOA MMAOMOIFICI, [Optional] Dictionary<Guid, int>? GOPCCCHKNPA, [Optional] Guid? PFEOIFBFCBF, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HEFFBECLBFK> PCODDOBJICP(Guid IHPOFPCDFAB, long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<OIBEPGAIAEK>> LCDOAHGOPOI(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<JPPKKBJBENK<List<KDOAMAFAKGG>>> HOBGGPMECBO(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JPPKKBJBENK<List<DMDIJFCNNDF>>> PELKGEPFDNE(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<ODLEBGBKKPI> DJKOILNPFHG(Guid IHPOFPCDFAB, long PANGCFBNCCJ, int IPIGJIEEHGA, int JNOCFIOMBDH, Guid? EGNKNFNFDIL, int JELIMCDIAMI, Dictionary<Guid, Guid?> LDFLHCGDLCC, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x78DE4F0", Offset = "0x78DCAF0", VA = "0x1878DE4F0")]
	static EFGIPPOJNJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[GIJKPPBGMNE]
public class KOAEMLBLAAL : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public bool CIGFKLAJNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KOAEMLBLAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public interface JCPCIKAIGAK
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KOAEMLBLAAL> CDNHGLJIAFI(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HEFFBECLBFK> OPAKAIMDPJE(long PANGCFBNCCJ, bool GFLEALNDFPM, [Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[COMCBLKEMJL]
public class DEAHKPCCKLP<DataType> where DataType : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	public long PKCCEFBNPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	public PGOJGHPEBGE CHBGGBNGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(PGOJGHPEBGE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public FIMKKFHMKJA PDINKKKDLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
		[CompilerGenerated]
		get
		{
			return default(FIMKKFHMKJA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public DataType AIJFAAIOPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DEAHKPCCKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[COMCBLKEMJL]
public class OKEIJDHBMCN<DataType> where DataType : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public long PKCCEFBNPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public PGOJGHPEBGE CHBGGBNGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(PGOJGHPEBGE);
		}
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public FIMKKFHMKJA PDINKKKDLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
		[CompilerGenerated]
		get
		{
			return default(FIMKKFHMKJA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000284")]
	public List<DataType> AIJFAAIOPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OKEIJDHBMCN()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[COMCBLKEMJL]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : KPJILIFBKOE, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[COMCBLKEMJL]
		public class CHFODBFJFLD : JLFPDMLALBM, KPJILIFBKOE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EA")]
			[CompilerGenerated]
			private struct OOBNNMHJCLP : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000426")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000428")]
				public CHFODBFJFLD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000429")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x5B9C7D0", Offset = "0x5B9ADD0", VA = "0x185B9C7D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000620")]
				[Cpp2IlInjected.Address(RVA = "0x5B9CA30", Offset = "0x5B9B030", VA = "0x185B9CA30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000286")]
			public HJJLKPHCDEI EPPPNEFNOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000618")]
				[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
				[CompilerGenerated]
				get
				{
					return default(HJJLKPHCDEI);
				}
				[Cpp2IlInjected.Token(Token = "0x6000619")]
				[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000287")]
			public DataTypeDTO AIJFAAIOPNI
			{
				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x6DDF360", Offset = "0x6DDD960", VA = "0x186DDF360", Slot = "5")]
			public void EOCKPKLKCMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x6DDF440", Offset = "0x6DDDA40", VA = "0x186DDF440", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.CHFODBFJFLD.OOBNNMHJCLP))]
			public Task LDEFHJHMLKP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public CHFODBFJFLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public List<CHFODBFJFLD> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x5CCD800", Offset = "0x5CCBE00", VA = "0x185CCD800", Slot = "5")]
		public override void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[COMCBLKEMJL]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : KPJILIFBKOE, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[COMCBLKEMJL]
		public class IHAKIMGNGAN : JLFPDMLALBM, KPJILIFBKOE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000ED")]
			[CompilerGenerated]
			private struct CKGNHFIEBFO : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042E")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042F")]
				public IHAKIMGNGAN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000430")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600062C")]
				[Cpp2IlInjected.Address(RVA = "0x6EC2240", Offset = "0x6EC0840", VA = "0x186EC2240", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600062D")]
				[Cpp2IlInjected.Address(RVA = "0x6EC24A0", Offset = "0x6EC0AA0", VA = "0x186EC24A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000289")]
			public HJJLKPHCDEI EPPPNEFNOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000625")]
				[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
				[CompilerGenerated]
				get
				{
					return default(HJJLKPHCDEI);
				}
				[Cpp2IlInjected.Token(Token = "0x6000626")]
				[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700028A")]
			public List<DataTypeDTO> AIJFAAIOPNI
			{
				[Cpp2IlInjected.Token(Token = "0x6000627")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000628")]
				[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x523A990", Offset = "0x5238F90", VA = "0x18523A990", Slot = "5")]
			public void EOCKPKLKCMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x523AC10", Offset = "0x5239210", VA = "0x18523AC10", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.IHAKIMGNGAN.CKGNHFIEBFO))]
			public Task LDEFHJHMLKP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public IHAKIMGNGAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public List<IHAKIMGNGAN> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x5CCD800", Offset = "0x5CCBE00", VA = "0x185CCD800", Slot = "5")]
		public override void EOCKPKLKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[DCIBIMMHDPE]
public class OMOIDFPHCCB : PurchaseBalanceUpdateResponseDTO<MGDIHOEKGMD>
{
	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x78E7190", Offset = "0x78E5790", VA = "0x1878E7190")]
	public OMOIDFPHCCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[DCIBIMMHDPE]
public class NGEDODCBIAA : PurchaseBalanceUpdateResponseDTO<MGDIHOEKGMD>.IHAKIMGNGAN
{
	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x78E5F00", Offset = "0x78E4500", VA = "0x1878E5F00")]
	public NGEDODCBIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[GIJKPPBGMNE]
public class MEGEEIFBPMP : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public LEAAEHIBMAM NJHHKOEGGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public long LPJGJBNKGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public GiftItemDTO? OOOCFHLIMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	public long? KCCJMDDFFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x14274A0", Offset = "0x1425AA0", VA = "0x1814274A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x155F7E0", Offset = "0x155DDE0", VA = "0x18155F7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	public int DJOCOPNNBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x78E49B0", Offset = "0x78E2FB0", VA = "0x1878E49B0")]
	public MEGEEIFBPMP(LEAAEHIBMAM MAAJICFONBC, long AAAJLJAAJIM, GiftItemDTO? ANAJMBOIHMA, int PBDPLHCCLON = 1, [Optional] long? NEOLJBOHKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[GIJKPPBGMNE]
public class HFJNIAJIBCC : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000290")]
	public List<MEGEEIFBPMP> FHKEDOAOLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	public LKJBAEHKLIH? LLOJMPLHBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public PGOJGHPEBGE CHBGGBNGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(PGOJGHPEBGE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public bool LMDIIOOHAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE8C780", Offset = "0xE8AD80", VA = "0x180E8C780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCA0", Offset = "0xE8A2A0", VA = "0x180E8BCA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public bool ICPHCCAJCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1613D50", Offset = "0x1612350", VA = "0x181613D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x294B910", Offset = "0x2949F10", VA = "0x18294B910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public Guid? OICGJJAMGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xFD88B0", Offset = "0xFD6EB0", VA = "0x180FD88B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x24E8E30", Offset = "0x24E7430", VA = "0x1824E8E30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x78E0CA0", Offset = "0x78DF2A0", VA = "0x1878E0CA0")]
	public HFJNIAJIBCC(List<MEGEEIFBPMP> PMDMONHGGNL, LKJBAEHKLIH? KPDCODBGJCJ, PGOJGHPEBGE ECAHMHDPJME, bool PAAAPMPNEDD, bool OIJOHBMOKDL = false, [Optional] Guid? JANBOFBHOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[GIJKPPBGMNE]
public class LOOOEICNEDE : JLFPDMLALBM, KPJILIFBKOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct EHBCHMEFAJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public LOOOEICNEDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x78DE680", Offset = "0x78DCC80", VA = "0x1878DE680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x78DE960", Offset = "0x78DCF60", VA = "0x1878DE960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	internal static Action<MGDIHOEKGMD>? CICMJOMLICE;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	internal static Func<MGDIHOEKGMD, Task>? KCJALLCJFEI;

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public MGDIHOEKGMD OBAJBALBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public int? IEIFDCKJKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	public LJCEPDOBDJL? NLOLMCNEDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x78E4080", Offset = "0x78E2680", VA = "0x1878E4080", Slot = "5")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x78E4140", Offset = "0x78E2740", VA = "0x1878E4140", Slot = "6")]
	[AsyncStateMachine(typeof(EHBCHMEFAJL))]
	public virtual Task LDEFHJHMLKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LOOOEICNEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[DCIBIMMHDPE]
public class JCGKCKAOCNM : BalanceUpdateResponseDTO<LOOOEICNEDE>
{
	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x78E1C90", Offset = "0x78E0290", VA = "0x1878E1C90")]
	public JCGKCKAOCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[DCIBIMMHDPE]
public class DBIBLBMGONE : BalanceUpdateResponseDTO<LOOOEICNEDE>.CHFODBFJFLD
{
	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x78DD280", Offset = "0x78DB880", VA = "0x1878DD280")]
	public DBIBLBMGONE()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[GIJKPPBGMNE]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public LLODCHIGJPE GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
			[CompilerGenerated]
			get
			{
				return default(LLODCHIGJPE);
			}
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[GIJKPPBGMNE]
public class GFKBGHMDNDB : KPJILIFBKOE, NMBBKLCKGLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public FJIHDMFNCHN? CBJABEHCDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	[IgnoreDataMember]
	public Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x78E0790", Offset = "0x78DED90", VA = "0x1878E0790", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public LEAAEHIBMAM? BNLALMOHFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public List<CCBENINGJHO>? BGMPIGBEDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public DateTime? GADNBGDGDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x14274A0", Offset = "0x1425AA0", VA = "0x1814274A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x155F7E0", Offset = "0x155DDE0", VA = "0x18155F7E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public DateTime? CDJEOKLECFE
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x1617610", Offset = "0x1615C10", VA = "0x181617610", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x1617600", Offset = "0x1615C00", VA = "0x181617600")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public DateTime? GJALFGFKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xEAD270", Offset = "0xEAB870", VA = "0x180EAD270", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6860", Offset = "0x5EB4E60", VA = "0x185EB6860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public bool LELLAEBKAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xD59A60", Offset = "0xD58060", VA = "0x180D59A60", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xD58D60", Offset = "0xD57360", VA = "0x180D58D60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public bool DFEAHKJBLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x10C47C0", Offset = "0x10C2DC0", VA = "0x1810C47C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x128F050", Offset = "0x128D650", VA = "0x18128F050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public bool DHLHAGKFKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x1081920", Offset = "0x107FF20", VA = "0x181081920", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x128F040", Offset = "0x128D640", VA = "0x18128F040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public bool MHAEHJFGFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x1078BA0", Offset = "0x10771A0", VA = "0x181078BA0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x10821B0", Offset = "0x10807B0", VA = "0x1810821B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x78E0810", Offset = "0x78DEE10", VA = "0x1878E0810")]
	public static GFKBGHMDNDB FBLNAFFIELD(Guid MECFNLMOEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GFKBGHMDNDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[GIJKPPBGMNE]
public class NHNIEKPEPKF
{
	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public string ECILEDCFKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public string HDGCLACOIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public Dictionary<int, HHJJGNJMNDP> JOKOBFAAODH
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public Dictionary<string, int> DALBAGKIEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public Dictionary<HHFIGCAAPLE, List<int>> GKDEOKMHDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public Dictionary<string, string> AFEBDBEOLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NHNIEKPEPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public enum HHFIGCAAPLE
{
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[GIJKPPBGMNE]
public class HHJJGNJMNDP : GAMIKNIDKCF
{
	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public ENHFOBPIJHD CHNILKDBPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(ENHFOBPIJHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public bool MFKGJGLFMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x130DD00", Offset = "0x130C300", VA = "0x18130DD00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x1623410", Offset = "0x1621A10", VA = "0x181623410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public bool HKIADECKAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2088F20", Offset = "0x2087520", VA = "0x182088F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x2088F40", Offset = "0x2087540", VA = "0x182088F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public string HMPFPOKDKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	public string MEIKDLPBJNB
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	public string IDEFJMEBLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	public string KJMOJFHOJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	public Dictionary<PEHMMGGEDNB, string> AJFNFBDDLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x1623420", Offset = "0x1621A20", VA = "0x181623420")]
	public HHJJGNJMNDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[GIJKPPBGMNE]
public class GDPKMLLLFCI : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	public IReadOnlyList<FJIHDMFNCHN>? OEIABEMOMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GDPKMLLLFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public GDPKMLLLFCI(IReadOnlyList<FJIHDMFNCHN>? EBBONFBKGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum NOOOFIKEBPO
{
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface NMBBKLCKGLJ
{
	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	LEAAEHIBMAM? BNLALMOHFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	List<CCBENINGJHO>? BGMPIGBEDID
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	DateTime? GADNBGDGDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	DateTime? CDJEOKLECFE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	DateTime? GJALFGFKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	bool LELLAEBKAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	bool DHLHAGKFKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	bool MHAEHJFGFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface DJHPHELJHMN
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action BLPBNABEMIE;

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LNEOLNLCAMK(CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BLGPJPHNLDC(CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AOCLODCGJNE([Out] CNJPKAMIFPC CKJHMCELOAA);
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface CNJPKAMIFPC
{
	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	string ECILEDCFKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	string HDGCLACOIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	IReadOnlyDictionary<HHFIGCAAPLE, IReadOnlyList<GAMIKNIDKCF>> HEICLBLJEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	IReadOnlyDictionary<string, string> AFEBDBEOLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public interface GAMIKNIDKCF
{
	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	string MEIKDLPBJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	string HMPFPOKDKBF
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	string IDEFJMEBLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	string KJMOJFHOJKP
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public interface NOCNMFAMICC
{
	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	ICOOGNIIMPB ELLFDIPCJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	string AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	string KOEPNMMBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	string EGNKLBLDFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	bool MHAEHJFGFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	bool DHLHAGKFKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	BJBMFDPJGHF EEHEOFKOOAA
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	string NLODIPMBEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	OJKGOLKIFJC? INAMIKGPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	NOOOFIKEBPO DOEPMBFPDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	bool PPLCAEDLBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[GIJKPPBGMNE]
public class LEAAEHIBMAM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public ICOOGNIIMPB MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(ICOOGNIIMPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public int? GFIDIDCKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x13CF390", Offset = "0x13CD990", VA = "0x1813CF390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F60", Offset = "0x13D8560", VA = "0x1813D9F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public Guid? AGFJPIILPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9D790", Offset = "0xA9BD90", VA = "0x180A9D790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA9D6A0", Offset = "0xA9BCA0", VA = "0x180A9D6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x78E3820", Offset = "0x78E1E20", VA = "0x1878E3820")]
	public static LEAAEHIBMAM OEODNMLPCPL(int IDALAIEKKKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x78E38C0", Offset = "0x78E1EC0", VA = "0x1878E38C0")]
	public static LEAAEHIBMAM PCGBKKOIMLI(Guid MECFNLMOEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x78E3620", Offset = "0x78E1C20", VA = "0x1878E3620")]
	public static LEAAEHIBMAM HIEFNAHLNPI(MLCFDBKEEGL GJODIGPCMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LEAAEHIBMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum ICOOGNIIMPB
{
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[GIJKPPBGMNE]
public class CCBENINGJHO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public PGOJGHPEBGE CHBGGBNGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(PGOJGHPEBGE);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public int DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public JNFDIGEPHPA JOJILJMPOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x10755E0", Offset = "0x1073BE0", VA = "0x1810755E0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x78DCD60", Offset = "0x78DB360", VA = "0x1878DCD60")]
	public int NGAEOFPMMDG(DateTime BPMDCNPGKDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CCBENINGJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[GIJKPPBGMNE]
public class JNFDIGEPHPA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public int BDBKEDLFEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public DateTime? KBAOMOOFLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public DateTime? FDKAAJHDKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x14274A0", Offset = "0x1425AA0", VA = "0x1814274A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x155F7E0", Offset = "0x155DDE0", VA = "0x18155F7E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x78E2640", Offset = "0x78E0C40", VA = "0x1878E2640")]
	public bool HJKIBDNEMEE(DateTime BPMDCNPGKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x78E2730", Offset = "0x78E0D30", VA = "0x1878E2730")]
	public int PHIKNNBJPKG(DateTime BPMDCNPGKDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x78E2550", Offset = "0x78E0B50", VA = "0x1878E2550")]
	public TimeSpan? CEOHDFDHFOJ(DateTime BPMDCNPGKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JNFDIGEPHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public enum LKJBAEHKLIH
{
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public enum IPEFKGNOEDJ
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public enum HDAANEOGIAN
{
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum AMAKCMDLCEB
{
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public enum GNFHHLOJJNE
{
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[GIJKPPBGMNE]
public class FAONLFIEAOL : IEquatable<FAONLFIEAOL>
{
	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public int? IMNKGIPKIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public int? KNMLCADJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public int? LCDNIHNOJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public List<int>? HDGOOBGNGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x78DF7B0", Offset = "0x78DDDB0", VA = "0x1878DF7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x78DF6B0", Offset = "0x78DDCB0", VA = "0x1878DF6B0")]
	public static FAONLFIEAOL HNCCENFGJMM(int? BPHDELLDHGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x78DF120", Offset = "0x78DD720", VA = "0x1878DF120", Slot = "4")]
	public bool Equals(FAONLFIEAOL? IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x78DF710", Offset = "0x78DDD10", VA = "0x1878DF710")]
	private static bool MKMJNIAKLHK(List<int>? IAFDMJDNHDH, List<int>? DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x78DF2A0", Offset = "0x78DD8A0", VA = "0x1878DF2A0", Slot = "0")]
	public override bool Equals(object? NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x78DF4D0", Offset = "0x78DDAD0", VA = "0x1878DF4D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FAONLFIEAOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public struct MLCFDBKEEGL : IEquatable<MLCFDBKEEGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public readonly ICOOGNIIMPB ELLFDIPCJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly int GFIDIDCKOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly Guid AGFJPIILPPG;

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x78E53F0", Offset = "0x78E39F0", VA = "0x1878E53F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public int IEIFDCKJKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x78E5770", Offset = "0x78E3D70", VA = "0x1878E5770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public string DFBBONCGFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x78E58B0", Offset = "0x78E3EB0", VA = "0x1878E58B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x78E4E60", Offset = "0x78E3460", VA = "0x1878E4E60")]
	public static bool ABLHAGFIIDN(string BOKKEFJOAFD, [Out] MLCFDBKEEGL GJODIGPCMPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x78E5900", Offset = "0x78E3F00", VA = "0x1878E5900")]
	public static bool NGAFNEPDNEA(string GJBCKNFLNAN, [Out] MLCFDBKEEGL GJODIGPCMPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x78E5780", Offset = "0x78E3D80", VA = "0x1878E5780")]
	public static MLCFDBKEEGL KNJEDAJPMIO(int JIEJOKBHEMF)
	{
		return default(MLCFDBKEEGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x78E52A0", Offset = "0x78E38A0", VA = "0x1878E52A0")]
	public static MLCFDBKEEGL ADAAELCAACE(Guid JIEJOKBHEMF)
	{
		return default(MLCFDBKEEGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x78E5460", Offset = "0x78E3A60", VA = "0x1878E5460")]
	private static bool CGJDOELKACP(string BOKKEFJOAFD, [Out] ICOOGNIIMPB HPGOBCAACJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x78E5C80", Offset = "0x78E4280", VA = "0x1878E5C80")]
	private MLCFDBKEEGL(ICOOGNIIMPB HPGOBCAACJM, int? KIDBNKAKMBG, Guid? MECFNLMOEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x78E5670", Offset = "0x78E3C70", VA = "0x1878E5670", Slot = "4")]
	public bool Equals(MLCFDBKEEGL IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x78E5570", Offset = "0x78E3B70", VA = "0x1878E5570", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x78E56E0", Offset = "0x78E3CE0", VA = "0x1878E56E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x78E5BD0", Offset = "0x78E41D0", VA = "0x1878E5BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[GIJKPPBGMNE]
public abstract class NKIEJEBHMKH : IEquatable<NKIEJEBHMKH>, KPJILIFBKOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public Guid HFMNEOLFGJA;

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x78E66D0", Offset = "0x78E4CD0", VA = "0x1878E66D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x78E6650", Offset = "0x78E4C50", VA = "0x1878E6650", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x78E6610", Offset = "0x78E4C10", VA = "0x1878E6610", Slot = "4")]
	public bool Equals(NKIEJEBHMKH IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x78E64F0", Offset = "0x78E4AF0", VA = "0x1878E64F0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract NKIEJEBHMKH JJDCBGIHCCL();

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected NKIEJEBHMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public enum KPIMDEJMMMK
{
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[GIJKPPBGMNE]
public class FJIHDMFNCHN : NKIEJEBHMKH, IEquatable<FJIHDMFNCHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public KPIMDEJMMMK HPGOBCAACJM;

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x78E00B0", Offset = "0x78DE6B0", VA = "0x1878E00B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x78DFFC0", Offset = "0x78DE5C0", VA = "0x1878DFFC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FJIHDMFNCHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x78E0150", Offset = "0x78DE750", VA = "0x1878E0150")]
	public FJIHDMFNCHN(KPIMDEJMMMK HPGOBCAACJM, Guid HFMNEOLFGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x78DFF00", Offset = "0x78DE500", VA = "0x1878DFF00")]
	public static FJIHDMFNCHN ADAAELCAACE(Guid NGIIDBPAAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x78DFF70", Offset = "0x78DE570", VA = "0x1878DFF70", Slot = "7")]
	public bool Equals(FJIHDMFNCHN IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x78E0040", Offset = "0x78DE640", VA = "0x1878E0040", Slot = "6")]
	public override NKIEJEBHMKH JJDCBGIHCCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public static class FHCCNFFEBLL
{
	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x78DFDA0", Offset = "0x78DE3A0", VA = "0x1878DFDA0")]
	public static FJIHDMFNCHN KJMDBDOADCO(this CGKNEGCCMPE KGKOGFAMIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x78DFE10", Offset = "0x78DE410", VA = "0x1878DFE10")]
	public static FJIHDMFNCHN OJFOBNBEBIL(string CINPOONNICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x78DFD30", Offset = "0x78DE330", VA = "0x1878DFD30")]
	public static FJIHDMFNCHN CKODNBMJJFE(Guid HIAHPMFLBHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
[GIJKPPBGMNE]
public class CGKNEGCCMPE : DHGDINDKNOD, KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public KPIMDEJMMMK ELLFDIPCJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(KPIMDEJMMMK);
		}
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public Guid CBJABEHCDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x1BBFBF0", Offset = "0x1BBE1F0", VA = "0x181BBFBF0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9C90", Offset = "0x5EB8290", VA = "0x185EB9C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public string GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public long? CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x106F980", Offset = "0x106DF80", VA = "0x18106F980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x106F990", Offset = "0x106DF90", VA = "0x18106F990")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public long DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xFC0E60", Offset = "0xFBF460", VA = "0x180FC0E60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public Guid? BKKDKDGGBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x78DCDC0", Offset = "0x78DB3C0", VA = "0x1878DCDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x78DCDB0", Offset = "0x78DB3B0", VA = "0x1878DCDB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA99380", Offset = "0xA97980", VA = "0x180A99380")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xFDC860", Offset = "0xFDAE60", VA = "0x180FDC860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public DateTime HHDAJLCBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA9D690", Offset = "0xA9BC90", VA = "0x180A9D690")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xFDC550", Offset = "0xFDAB50", VA = "0x180FDC550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CGKNEGCCMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x78DCE90", Offset = "0x78DB490", VA = "0x1878DCE90")]
	public CGKNEGCCMPE(KPIMDEJMMMK HPGOBCAACJM, Guid HFMNEOLFGJA, [Optional] string DJFMCHMDHGK, [Optional] string OINDFPIKPLL, [Optional] string IFCAGKLINAN, [Optional] long? PANGCFBNCCJ, long NCCILLFFLEP = 0L, [Optional] Guid? CCBIIGMJIOA, [Optional] DateTime BOLFBHDEFLN, [Optional] DateTime GLBKFHNLKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x78DCDE0", Offset = "0x78DB3E0", VA = "0x1878DCDE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public interface NDGBLCAONBG
{
	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public interface HGCOAODPIFB<out TId> : NDGBLCAONBG where TId : struct
{
	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	TId AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[GIJKPPBGMNE]
public class DHNNHNFDCAG : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public List<FJONJGFCHEG> HIBBHFGGDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public List<NKBMIMGAINM> LADOHEKLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public List<HHPDKEFPDBA> CABCLBJCEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public List<OEBCNOCFHHJ> DFJHLJNKICF
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public List<MCBPOOJKEJB> LKDNBGHDANC
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public List<HOBDECCNHIA> LKFKFPJBAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public List<PGBKIPDIHCN> MKAHBKPGBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public ILKMLENHMFC LMHKJJGFFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public ILKMLENHMFC MEJJCBAOOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public ILKMLENHMFC NJIMCEJDIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x78DD940", Offset = "0x78DBF40", VA = "0x1878DD940", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x78DDAF0", Offset = "0x78DC0F0", VA = "0x1878DDAF0")]
	public DHNNHNFDCAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[GIJKPPBGMNE]
public class FJONJGFCHEG : KPJILIFBKOE, IEquatable<FJONJGFCHEG>
{
	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public PFJFPMGJFPL BNFBAHBOHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(PFJFPMGJFPL);
		}
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public NCABNKEBGPH GGOBGGBOECO
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xB72670", Offset = "0xB70C70", VA = "0x180B72670")]
		[CompilerGenerated]
		get
		{
			return default(NCABNKEBGPH);
		}
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xB72660", Offset = "0xB70C60", VA = "0x180B72660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public Guid BDCHBKCBMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x1BBFBF0", Offset = "0x1BBE1F0", VA = "0x181BBFBF0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9C90", Offset = "0x5EB8290", VA = "0x185EB9C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public Guid CHPDAOCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xEA1DE0", Offset = "0xEA03E0", VA = "0x180EA1DE0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x10A58A0", Offset = "0x10A3EA0", VA = "0x1810A58A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x78E0190", Offset = "0x78DE790", VA = "0x1878E0190", Slot = "5")]
	public bool Equals(FJONJGFCHEG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x78E0230", Offset = "0x78DE830", VA = "0x1878E0230", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x78E03A0", Offset = "0x78DE9A0", VA = "0x1878E03A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x1550550", Offset = "0x154EB50", VA = "0x181550550")]
	public static bool LMIMJGGKHMP(FJONJGFCHEG LEOAACGBJCD, FJONJGFCHEG GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x1550750", Offset = "0x154ED50", VA = "0x181550750")]
	public static bool PACMOMIAEBP(FJONJGFCHEG LEOAACGBJCD, FJONJGFCHEG GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FJONJGFCHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[GIJKPPBGMNE]
public class ILKMLENHMFC : KPJILIFBKOE, HGCOAODPIFB<NCABNKEBGPH>, NDGBLCAONBG
{
	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public NCABNKEBGPH AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NCABNKEBGPH);
		}
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public HDNGCACGFHA BGBBIIJKGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public float MKJIOCLMDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x109BE00", Offset = "0x109A400", VA = "0x18109BE00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x15ACBD0", Offset = "0x15AB1D0", VA = "0x1815ACBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public float CLKKBBNJEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xDB9260", Offset = "0xDB7860", VA = "0x180DB9260")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xDB9270", Offset = "0xDB7870", VA = "0x180DB9270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public float IKKEOJCGBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xD657B0", Offset = "0xD63DB0", VA = "0x180D657B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x1087540", Offset = "0x1085B40", VA = "0x181087540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x78E1840", Offset = "0x78DFE40", VA = "0x1878E1840", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x78E1890", Offset = "0x78DFE90", VA = "0x1878E1890")]
	public ILKMLENHMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[GIJKPPBGMNE]
public class NKBMIMGAINM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public FJONJGFCHEG PMMIAHCCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public string POGCBIFIIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public PLDCANBENHM AMJHCGCEDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x10755E0", Offset = "0x1073BE0", VA = "0x1810755E0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x78E6470", Offset = "0x78E4A70", VA = "0x1878E6470")]
	public NKBMIMGAINM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[GIJKPPBGMNE]
public class HHPDKEFPDBA : KPJILIFBKOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public string AOAOJACCMIC;

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public NCABNKEBGPH GGOBGGBOECO
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(NCABNKEBGPH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HHPDKEFPDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[GIJKPPBGMNE]
public class OEBCNOCFHHJ : KPJILIFBKOE, HGCOAODPIFB<Guid>, NDGBLCAONBG
{
	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x78E69D0", Offset = "0x78E4FD0", VA = "0x1878E69D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public Guid AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public int OCGACENPEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public string AOAOJACCMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public PLDCANBENHM JIIKHGGPGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x78E3DE0", Offset = "0x78E23E0", VA = "0x1878E3DE0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x78E6A40", Offset = "0x78E5040", VA = "0x1878E6A40")]
	public OEBCNOCFHHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[GIJKPPBGMNE]
public class MCBPOOJKEJB : KPJILIFBKOE, HGCOAODPIFB<Guid>, NDGBLCAONBG
{
	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public Guid AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public float JLBEAFCAAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x109BE00", Offset = "0x109A400", VA = "0x18109BE00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x15ACBD0", Offset = "0x15AB1D0", VA = "0x1815ACBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public FDGDOFFBAKE EGJFKCMAJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x1859660", Offset = "0x1857C60", VA = "0x181859660")]
		[CompilerGenerated]
		get
		{
			return default(FDGDOFFBAKE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x1086430", Offset = "0x1084A30", VA = "0x181086430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public List<BAHPCCDODAH> LBGBNPBODIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x78E4830", Offset = "0x78E2E30", VA = "0x1878E4830", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x78E48D0", Offset = "0x78E2ED0", VA = "0x1878E48D0")]
	public MCBPOOJKEJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[GIJKPPBGMNE]
public class HOBDECCNHIA : KPJILIFBKOE, HGCOAODPIFB<Guid>, NDGBLCAONBG
{
	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public Guid AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public HDNGCACGFHA BGBBIIJKGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x78E0E00", Offset = "0x78DF400", VA = "0x1878E0E00", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x78E0E50", Offset = "0x78DF450", VA = "0x1878E0E50")]
	public HOBDECCNHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[GIJKPPBGMNE]
public class HDNGCACGFHA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public List<OHGJGJODLGM> LKKGGMPFHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x78E0AD0", Offset = "0x78DF0D0", VA = "0x1878E0AD0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x78E0B10", Offset = "0x78DF110", VA = "0x1878E0B10")]
	public HDNGCACGFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[GIJKPPBGMNE]
public class OHGJGJODLGM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public float ABINFPFCBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xD847A0", Offset = "0xD82DA0", VA = "0x180D847A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xDFA620", Offset = "0xDF8C20", VA = "0x180DFA620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public float FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCC0", Offset = "0xE8A2C0", VA = "0x180E8BCC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xE8C790", Offset = "0xE8AD90", VA = "0x180E8C790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public float PHMIGFMNLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F50", Offset = "0x13D8550", VA = "0x1813D9F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public float JPHBBFMHNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xEBD6A0", Offset = "0xEBBCA0", VA = "0x180EBD6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public float FBJEOKCHKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EC0", Offset = "0xAF14C0", VA = "0x180AF2EC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x1084DD0", Offset = "0x10833D0", VA = "0x181084DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public float JLPOMNHAGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFC0", Offset = "0xAEC5C0", VA = "0x180AEDFC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFB0", Offset = "0xAEC5B0", VA = "0x180AEDFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public int EILJGNAHBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public int JHPGLODLMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x1696150", Offset = "0x1694750", VA = "0x181696150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OHGJGJODLGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[GIJKPPBGMNE]
public class BAHPCCDODAH : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public float ABINFPFCBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xD847A0", Offset = "0xD82DA0", VA = "0x180D847A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0xDFA620", Offset = "0xDF8C20", VA = "0x180DFA620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public PLDCANBENHM JIIKHGGPGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x10755E0", Offset = "0x1073BE0", VA = "0x1810755E0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x78DC590", Offset = "0x78DAB90", VA = "0x1878DC590")]
	public BAHPCCDODAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[GIJKPPBGMNE]
public class PLDCANBENHM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public float AIPLOFOGKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xD847A0", Offset = "0xD82DA0", VA = "0x180D847A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xDFA620", Offset = "0xDF8C20", VA = "0x180DFA620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public float GGIKBGGDLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCC0", Offset = "0xE8A2C0", VA = "0x180E8BCC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xE8C790", Offset = "0xE8AD90", VA = "0x180E8C790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public float CPFKEBEGJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F50", Offset = "0x13D8550", VA = "0x1813D9F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public float DCIOCPGLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xEBD6A0", Offset = "0xEBBCA0", VA = "0x180EBD6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public PLDCANBENHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x78E1420", Offset = "0x78DFA20", VA = "0x1878E1420")]
	public PLDCANBENHM(float FIECNFDCBKN, float ANEMBPECCCL, float DFKKOPOBCBA, float IAFDMJDNHDH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[GIJKPPBGMNE]
public class PGBKIPDIHCN : KPJILIFBKOE, HGCOAODPIFB<Guid>, NDGBLCAONBG
{
	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public Guid AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public string NGAACMGJAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public string CKHEJEFKNGA
	{
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public bool LPDEDNICPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xAE7930", Offset = "0xAE5F30", VA = "0x180AE7930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xAE7FC0", Offset = "0xAE65C0", VA = "0x180AE7FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public float AMBAFDHICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xAE9940", Offset = "0xAE7F40", VA = "0x180AE9940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xD5D940", Offset = "0xD5BF40", VA = "0x180D5D940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public JHECBMOJNIA JCNJMEMHIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public JHECBMOJNIA CGOMOPKAMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public JHECBMOJNIA DGFJLDGIPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public JHECBMOJNIA JJIJKGCEACB
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public IBDKEBOGIMC HKCJDCOJCCG
	{
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA962F0", Offset = "0xA948F0", VA = "0x180A962F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x78E7690", Offset = "0x78E5C90", VA = "0x1878E7690", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x78E7750", Offset = "0x78E5D50", VA = "0x1878E7750")]
	public PGBKIPDIHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[GIJKPPBGMNE]
public class JHECBMOJNIA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public IDCFCOGDDDM DKPHKFIMCOO
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public float NPGJBOFOIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F50", Offset = "0x13D8550", VA = "0x1813D9F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public float HNIEBKKAGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xEBD6A0", Offset = "0xEBBCA0", VA = "0x180EBD6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public IBDKEBOGIMC EAHMMHOFBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x78E24B0", Offset = "0x78E0AB0", VA = "0x1878E24B0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x78E24D0", Offset = "0x78E0AD0", VA = "0x1878E24D0")]
	public JHECBMOJNIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[GIJKPPBGMNE]
public class IDCFCOGDDDM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public float MPNFLKFDIME
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0xD847A0", Offset = "0xD82DA0", VA = "0x180D847A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0xDFA620", Offset = "0xDF8C20", VA = "0x180DFA620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public float FHJOJDDKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCC0", Offset = "0xE8A2C0", VA = "0x180E8BCC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0xE8C790", Offset = "0xE8AD90", VA = "0x180E8C790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IDCFCOGDDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x78BECC0", Offset = "0x78BD2C0", VA = "0x1878BECC0")]
	public IDCFCOGDDDM(float POMPNNDHCKO, float JLAHKMCOIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
	public virtual void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[GIJKPPBGMNE]
public class IBDKEBOGIMC : IDCFCOGDDDM
{
	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public float AIFNOLKDMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F50", Offset = "0x13D8550", VA = "0x1813D9F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public float DHHOJGCCEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0xEBD6A0", Offset = "0xEBBCA0", VA = "0x180EBD6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IBDKEBOGIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x78E1420", Offset = "0x78DFA20", VA = "0x1878E1420")]
	public IBDKEBOGIMC(float POMPNNDHCKO, float JLAHKMCOIFF, float GFIJDJGEMLL, float EDHBJBGECMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
	public override void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal static class GCFGDKDJGPK
{
	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x3D98A70", Offset = "0x3D97070", VA = "0x183D98A70")]
	public static void DBEAKOONOBH<T>(IList<T>? JIEFNCIIKMO) where T : KPJILIFBKOE
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public enum PFJFPMGJFPL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	Emission,
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	PlayerHeadScale,
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	Aura,
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	Texture
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public enum NCABNKEBGPH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	PlayerVoiceInput,
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	PlayerVelocity,
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	AnimationCurve,
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	HighFiveCount,
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	AlwaysOn
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public enum FDGDOFFBAKE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	Time,
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	ValueRamp
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public static class EIAPDOLEGOA
{
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	public static readonly PFJFPMGJFPL[] FCDMDGEMKBN;

	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public static readonly PFJFPMGJFPL[] ACINJHIGODH;

	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public static readonly NCABNKEBGPH[] AGFFNMELAND;

	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public static readonly NCABNKEBGPH[] BPJJPOFLLGO;
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public enum BMEJHGOLBNP
{
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	General,
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public enum PFCBPMJJOOD
{
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
[GIJKPPBGMNE]
public class IJDPOGELKLP : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public PFCBPMJJOOD AJMNBCHCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(PFCBPMJJOOD);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public List<string> BIOLBJHCKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x78E1590", Offset = "0x78DFB90", VA = "0x1878E1590")]
	public string FCNABOMGBAE(int LHONACAPFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IJDPOGELKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[GIJKPPBGMNE]
public class CBOLJLILBKO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public string MKNFAJBBNGA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public BMEJHGOLBNP MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(BMEJHGOLBNP);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CBOLJLILBKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public static class KANNFOKCOCO
{
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	public const string JEJCJBGEMFK = "costume";

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	public const string NBGDCJCFPGD = "gadget";

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	public const string EBFEGMNHEAO = "holotar";

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public const string EGFEOLFCFBJ = "large";

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	public const string NKALFGGLOOL = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000579")]
	public const string EFPAGPAIBCG = "small";

	[Cpp2IlInjected.Token(Token = "0x400057A")]
	public const string NEGNAKKEGMO = "sound";

	[Cpp2IlInjected.Token(Token = "0x400057B")]
	public const string LMNFBJBGDEA = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x400057C")]
	public const string BBONBMAILBI = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x400057D")]
	public const string DEKLFLPAKEB = "r2";

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public static List<string> BCLGPNLDIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x78E2760", Offset = "0x78E0D60", VA = "0x1878E2760")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public static class HJKHEOFBNHM
{
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	public const string JELDADNIJEA = "beta";

	[Cpp2IlInjected.Token(Token = "0x400057F")]
	public const string BBILJGBMLEH = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[GIJKPPBGMNE]
public class MNEPPAFBPHG : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public List<string> MOEKPPGBHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public List<string> KAJGCAHDHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public List<string> JHJFNNMPADO
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MNEPPAFBPHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public class JEAHDFLFPEH : IEquatable<JEAHDFLFPEH>
{
	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	protected virtual Type IDPJOIDDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x78E2290", Offset = "0x78E0890", VA = "0x1878E2290", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public EBDAMLPHNFF? GNKILFDGMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public HttpMethod? KBIKFJGIGON
	{
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public string? GBGBOEECELO
	{
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x78E2460", Offset = "0x78E0A60", VA = "0x1878E2460")]
	public JEAHDFLFPEH(EBDAMLPHNFF? GNKILFDGMLB, HttpMethod? KBIKFJGIGON, string? GBGBOEECELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x78E22F0", Offset = "0x78E08F0", VA = "0x1878E22F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x78E1F30", Offset = "0x78E0530", VA = "0x1878E1F30", Slot = "6")]
	protected virtual bool FEEJNMKOALE(StringBuilder MBGGGJHKEDJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x129AB10", Offset = "0x1299110", VA = "0x18129AB10")]
	public static bool PACMOMIAEBP(JEAHDFLFPEH? KCALPCMINJB, JEAHDFLFPEH? LLDLIDKIBDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x129AAE0", Offset = "0x12990E0", VA = "0x18129AAE0")]
	public static bool LMIMJGGKHMP(JEAHDFLFPEH? KCALPCMINJB, JEAHDFLFPEH? LLDLIDKIBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x78E2090", Offset = "0x78E0690", VA = "0x1878E2090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x78E1D10", Offset = "0x78E0310", VA = "0x1878E1D10", Slot = "0")]
	public override bool Equals(object? NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x78E1DA0", Offset = "0x78E03A0", VA = "0x1878E1DA0", Slot = "7")]
	public virtual bool Equals(JEAHDFLFPEH? IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x78E2200", Offset = "0x78E0800", VA = "0x1878E2200", Slot = "8")]
	public virtual JEAHDFLFPEH JIGFIMEFMEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x78E2400", Offset = "0x78E0A00", VA = "0x1878E2400")]
	protected JEAHDFLFPEH(JEAHDFLFPEH JECPIAPPEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x78E1CD0", Offset = "0x78E02D0", VA = "0x1878E1CD0")]
	public void BHACFNDCJGJ([Out] EBDAMLPHNFF? GNKILFDGMLB, [Out] HttpMethod? KBIKFJGIGON, [Out] string? GBGBOEECELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
public class LBFADMDMDCB : IEquatable<LBFADMDMDCB>
{
	[Cpp2IlInjected.Token(Token = "0x17000343")]
	protected virtual Type IDPJOIDDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x78E30E0", Offset = "0x78E16E0", VA = "0x1878E30E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public int GKNMAJEDBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public BENPBCCNMHK MLAOFNPELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0")]
		[CompilerGenerated]
		get
		{
			return default(BENPBCCNMHK);
		}
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x78E3250", Offset = "0x78E1850", VA = "0x1878E3250")]
	public LBFADMDMDCB(int GKNMAJEDBPE, BENPBCCNMHK MLAOFNPELBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x78E3140", Offset = "0x78E1740", VA = "0x1878E3140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x78E2E30", Offset = "0x78E1430", VA = "0x1878E2E30", Slot = "6")]
	protected virtual bool FEEJNMKOALE(StringBuilder MBGGGJHKEDJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x129AB10", Offset = "0x1299110", VA = "0x18129AB10")]
	public static bool PACMOMIAEBP(LBFADMDMDCB? KCALPCMINJB, LBFADMDMDCB? LLDLIDKIBDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x129AAE0", Offset = "0x12990E0", VA = "0x18129AAE0")]
	public static bool LMIMJGGKHMP(LBFADMDMDCB? KCALPCMINJB, LBFADMDMDCB? LLDLIDKIBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x78E2F60", Offset = "0x78E1560", VA = "0x1878E2F60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x78E2DA0", Offset = "0x78E13A0", VA = "0x1878E2DA0", Slot = "0")]
	public override bool Equals(object? NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x78E2C60", Offset = "0x78E1260", VA = "0x1878E2C60", Slot = "7")]
	public virtual bool Equals(LBFADMDMDCB? IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x78E3070", Offset = "0x78E1670", VA = "0x1878E3070", Slot = "8")]
	public virtual LBFADMDMDCB JIGFIMEFMEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0xD09080", Offset = "0xD07680", VA = "0x180D09080")]
	protected LBFADMDMDCB(LBFADMDMDCB JECPIAPPEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x78E2C50", Offset = "0x78E1250", VA = "0x1878E2C50")]
	public void BHACFNDCJGJ([Out] int GKNMAJEDBPE, [Out] BENPBCCNMHK MLAOFNPELBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public enum BENPBCCNMHK
{
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
public interface OCKHJLONMAC
{
	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<JEAHDFLFPEH, LBFADMDMDCB> NOEHAJICJBC();

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEPDNLKCAFJ(JEAHDFLFPEH HFLDIIIPBCG, LBFADMDMDCB CBDPHPPPDFI);

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNKFBENJEHN(JEAHDFLFPEH HFLDIIIPBCG);

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMDGANJDHPA();

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FIAFFJEFOOK(EBDAMLPHNFF PDGKOFDJCFH, HttpMethod GMJJMMCAFFM, string BHEJFKBMGOG, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
public interface ANCMNLNECCK
{
	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<Guid>> OHOHEHBIBBK(string LBDILMDENBP);
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[COMCBLKEMJL]
public class DHAOPPAFIFF<TResult> where TResult : KPJILIFBKOE, new()
{
	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public IReadOnlyList<TResult> KIPHIMLCAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public long DFINIKCFHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DHAOPPAFIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public enum HKEMAIEDJMF
{
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
public interface ONIHPNACPKI : LOKNMGKIMFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000348")]
	bool HFGODNPOAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long CNLOJHGAIPP, LNJJFGLDOKJ OMJBEMCGGKE);

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<FOKLHLCOEBD> PurchaseAsync(LNJJFGLDOKJ OMJBEMCGGKE, FAONLFIEAOL OIDOPHOBNIM);

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(JEDKPLKEFOO LFGHJFDOCLK, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
public interface LOKNMGKIMFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000349")]
	bool LACHOMJMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
public interface CMJKIIJEDNG
{
	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	int ONMAEGCILHK
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<LNJJFGLDOKJ>> ILIJNMMIKBI(bool PMELHEGLJGC = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLGGDCHECAJ([Out] LNJJFGLDOKJ? FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LNJJFGLDOKJ> KOAABOJKCKL(bool PMELHEGLJGC = false, [Optional] CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDNOINOMLJI(string DAAMNHJEIGF = "");
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public interface BBFLMHJAICC
{
	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KKJGPCPNJPM(JEDKPLKEFOO LFGHJFDOCLK, CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FFBCLHGEPAK(JEDKPLKEFOO LFGHJFDOCLK, CancellationToken MEKNAIONNND, [Optional] AKIFMBOGMDI? JPAFIECIEAK);
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public interface AKIFMBOGMDI
{
	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFOLIBGKENC(string DMGMBCGCHOD);
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public interface JKIPCEBBFMK
{
	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FDMNCLEBNEA(JEDKPLKEFOO NKOIGIALFBN, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public interface KLODABGPHBG
{
	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	bool OIFNOMFFJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public interface AFBMEMEGONF
{
	[Cpp2IlInjected.Token(Token = "0x6000832")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JEDKPLKEFOO DHNAFJDHCEA(LNJJFGLDOKJ OMJBEMCGGKE, FAONLFIEAOL OIDOPHOBNIM, string EDGIBEOPFAL, [Optional] BBFLMHJAICC? NJFPGEHNAPB);
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public interface GEIAMFOKHKK
{
	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDAEHDNIDNK(JKIPCEBBFMK CACEFGPINFP);

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNODBICGFME(JKIPCEBBFMK CACEFGPINFP);

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task MIKMMLPKMJK(JEDKPLKEFOO LFGHJFDOCLK, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public interface JEDKPLKEFOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	MIGOPEAPGMC BEGPBPBHIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	LNJJFGLDOKJ FDOHOFBKIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	FAONLFIEAOL BEOAJIIEGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	string OJMJPDJFPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000350")]
	string NLPEECOONLH
	{
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KBLGANCCJGO> OPAGGOLALII(CancellationToken MMLPHNDIFBG, [Optional] AKIFMBOGMDI? JPAFIECIEAK);

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MKGNNOBGKME(string JPBPIMBIGPE);

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MKGNNOBGKME<T>(Func<T, string> JPBPIMBIGPE, [In] T JLPMOIMMGJN);
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public abstract class DDANFFPEOGI
{
	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected DDANFFPEOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public enum DEMLEJBKDOB
{
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public enum EAACJPCJGLN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x40005A6")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[GIJKPPBGMNE]
public class LNJJFGLDOKJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public int PBFAPMDHDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public string ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public string GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public int DGJDOALNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F10", Offset = "0xAA0510", VA = "0x180AA1F10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xAA2490", Offset = "0xAA0A90", VA = "0x180AA2490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public string HAALAAKEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public string EBPNGIJPNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	[DataMember(Name = "PsnProductLabel")]
	public string HBOEHIIBGFG
	{
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public string NJMEANPCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public string GECDJIMJHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public string PEIBMKGPHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xA962F0", Offset = "0xA948F0", VA = "0x180A962F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public string CKKMCBPEJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA962E0", Offset = "0xA948E0", VA = "0x180A962E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public string JLLEEAJIEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0xA99380", Offset = "0xA97980", VA = "0x180A99380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA99450", Offset = "0xA97A50", VA = "0x180A99450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public bool COHHNECPNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xDB1C00", Offset = "0xDB0200", VA = "0x180DB1C00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xDB1540", Offset = "0xDAFB40", VA = "0x180DB1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public bool PCBLKBGEDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x1889830", Offset = "0x1887E30", VA = "0x181889830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x1889A10", Offset = "0x1888010", VA = "0x181889A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000360")]
	public HOBAEDBFMJN AIJFAAIOPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA9D7B0", Offset = "0xA9BDB0", VA = "0x180A9D7B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA9D620", Offset = "0xA9BC20", VA = "0x180A9D620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	[IgnoreDataMember]
	public string DOFKHNLFAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA9D770", Offset = "0xA9BD70", VA = "0x180A9D770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA9D7C0", Offset = "0xA9BDC0", VA = "0x180A9D7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000362")]
	[IgnoreDataMember]
	public string AKGGLAINNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xB19E20", Offset = "0xB18420", VA = "0x180B19E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xB65E80", Offset = "0xB64480", VA = "0x180B65E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	[IgnoreDataMember]
	public string DODKDGLOFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA9D630", Offset = "0xA9BC30", VA = "0x180A9D630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA9D710", Offset = "0xA9BD10", VA = "0x180A9D710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	[IgnoreDataMember]
	public DDANFFPEOGI AJBKMHKIHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xB65DA0", Offset = "0xB643A0", VA = "0x180B65DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0xB65E50", Offset = "0xB64450", VA = "0x180B65E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	[IgnoreDataMember]
	public bool KDBHLBABAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x78E3F50", Offset = "0x78E2550", VA = "0x1878E3F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000366")]
	[IgnoreDataMember]
	public string NBEHJGDGMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0xA9F180", Offset = "0xA9D780", VA = "0x180A9F180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0xA9F110", Offset = "0xA9D710", VA = "0x180A9F110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x78E3E60", Offset = "0x78E2460", VA = "0x1878E3E60", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x78E3F70", Offset = "0x78E2570", VA = "0x1878E3F70")]
	public static LNJJFGLDOKJ OAINMOJCGLP(int JIEJOKBHEMF, string DJFMCHMDHGK, string IFCAGKLINAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x78E4010", Offset = "0x78E2610", VA = "0x1878E4010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LNJJFGLDOKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[GIJKPPBGMNE]
public class HOBAEDBFMJN : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public List<int> PEJKMHJOMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public string OGPGDHDIMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public GBFNNKNPJLE FFNLOHGKKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x10755E0", Offset = "0x1073BE0", VA = "0x1810755E0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HOBAEDBFMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public readonly struct KBLGANCCJGO
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public enum OMHJKHJNBPF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	public readonly OMHJKHJNBPF LHFMGIICELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	public readonly EAACJPCJGLN CNJIBADGIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	public readonly DEMLEJBKDOB IBEHKCHAOCP;

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x78E2990", Offset = "0x78E0F90", VA = "0x1878E2990")]
	private KBLGANCCJGO(OMHJKHJNBPF BJGEPEKIJPC, EAACJPCJGLN EHFHIHPGKHJ = EAACJPCJGLN.Unknown, DEMLEJBKDOB CPLLIENODFK = DEMLEJBKDOB.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x78E2970", Offset = "0x78E0F70", VA = "0x1878E2970")]
	public static KBLGANCCJGO DBIJHINPEKF()
	{
		return default(KBLGANCCJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0x78E2950", Offset = "0x78E0F50", VA = "0x1878E2950")]
	public static KBLGANCCJGO CEIDMBJFDPL()
	{
		return default(KBLGANCCJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0x78E2930", Offset = "0x78E0F30", VA = "0x1878E2930")]
	public static KBLGANCCJGO BMACIBIONGO(EAACJPCJGLN EHFHIHPGKHJ, DEMLEJBKDOB CPLLIENODFK)
	{
		return default(KBLGANCCJGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public enum AJKCKOAEAMA
{
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public enum CNNMDBHGBHO
{
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[GIJKPPBGMNE]
public class GBFNNKNPJLE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public AJKCKOAEAMA AFNDEKPIHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(AJKCKOAEAMA);
		}
		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public CNNMDBHGBHO PMGBLMKJKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0")]
		[CompilerGenerated]
		get
		{
			return default(CNNMDBHGBHO);
		}
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	public bool NEBOCGJBAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GBFNNKNPJLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public enum MIGOPEAPGMC
{
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[GIJKPPBGMNE]
public class JINJJBBMDKP : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	public long HPPBGBKEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	public long HAKGPNILGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	public bool DGMABCDHAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000888")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000889")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JINJJBBMDKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[GIJKPPBGMNE]
public class KKJPPAGIKPI : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000370")]
	public string MABKHIEBOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000371")]
	public IGJGNEMCLCM? FAOLNPNLDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000372")]
	public IReadOnlyList<IGJGNEMCLCM>? APNPLCDPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	public IReadOnlyList<string>? AJFEEMGCFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000374")]
	public LLOHHAJCGAN MJOLOMDFKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000375")]
	public string? DJAPMMKKKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000376")]
	public string? JKEIBEOBDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000377")]
	public string? LOLIJMCCANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KKJPPAGIKPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[GIJKPPBGMNE]
public class FPPPHMHJNFK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000378")]
	public string GNNJIEAEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000379")]
	public IGJGNEMCLCM? FAOLNPNLDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037A")]
	public LLOHHAJCGAN MJOLOMDFKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037B")]
	public string? JKEIBEOBDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037C")]
	public IReadOnlyList<string>? AJFEEMGCFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FPPPHMHJNFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[GIJKPPBGMNE]
public class LLOHHAJCGAN : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700037D")]
	public string GEAPLEOHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037E")]
	public bool COOEHMNLNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037F")]
	public bool JDEELCJPHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x1218960", Offset = "0x1216F60", VA = "0x181218960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x139A320", Offset = "0x1398920", VA = "0x18139A320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000380")]
	public bool JIPBPGENGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x1218950", Offset = "0x1216F50", VA = "0x181218950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x16D62A0", Offset = "0x16D48A0", VA = "0x1816D62A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000381")]
	public bool KHGJEEMLBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x1218940", Offset = "0x1216F40", VA = "0x181218940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x4A985C0", Offset = "0x4A96BC0", VA = "0x184A985C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000382")]
	public bool EECCPDLIHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xB52370", Offset = "0xB50970", VA = "0x180B52370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xE8C4B0", Offset = "0xE8AAB0", VA = "0x180E8C4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000383")]
	public bool FBFBKCLKCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xB521E0", Offset = "0xB507E0", VA = "0x180B521E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCB0", Offset = "0xE8A2B0", VA = "0x180E8BCB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000384")]
	public bool DFIEEOKBMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x1B30A10", Offset = "0x1B2F010", VA = "0x181B30A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x78E3D20", Offset = "0x78E2320", VA = "0x1878E3D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000385")]
	public bool MNMLGALJKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x1B1B090", Offset = "0x1B19690", VA = "0x181B1B090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x78E3D10", Offset = "0x78E2310", VA = "0x1878E3D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000386")]
	public bool KLGGDGGPJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000387")]
	public bool JAIGFKGNMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x159F660", Offset = "0x159DC60", VA = "0x18159F660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x159F350", Offset = "0x159D950", VA = "0x18159F350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000388")]
	public bool PCHLIHKPCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x1696560", Offset = "0x1694B60", VA = "0x181696560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x16960F0", Offset = "0x16946F0", VA = "0x1816960F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x78E3D30", Offset = "0x78E2330", VA = "0x1878E3D30")]
	public LLOHHAJCGAN(string KBJBJHKKLEO, bool BIPPAANOAEH, bool LNOHAMBPHDA, bool DIJMIKPDHAA, bool LKKBILMIDIB, bool BALMNEAFKKH, bool CMIPIFIFHOP, bool JIDBOKAOAPI, bool KCBEDAJMNGN, bool CGFKPJCNFGO, bool HCNJBEGEFFD, bool HLJHIMKPCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
[GIJKPPBGMNE]
public class PJLNOFHDGCE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000389")]
	public string ILJEIHMJBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038A")]
	public string LOLIJMCCANK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038B")]
	public string DJAPMMKKKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038C")]
	public string? JLIHPPIKJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038D")]
	public string? LGCJGLENOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038E")]
	public float HGNJKFPDEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xAE9950", Offset = "0xAE7F50", VA = "0x180AE9950")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x1F1DE30", Offset = "0x1F1C430", VA = "0x181F1DE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public PJLNOFHDGCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[GIJKPPBGMNE]
public class FMJFAACNPEF : EOCKCBCDILD, KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700038F")]
	public string EDCLJBEHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000390")]
	public string GCMFCBIOEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "6")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FMJFAACNPEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[GIJKPPBGMNE]
public class NGODLPIAAIO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000391")]
	public Guid BEFEFCGJHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000392")]
	public long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000393")]
	public long KFDHAJGBKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FD0", Offset = "0xA935D0", VA = "0x180A94FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000394")]
	public decimal NBMDOKKEELK
	{
		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xF61520", Offset = "0xF5FB20", VA = "0x180F61520")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xF621F0", Offset = "0xF607F0", VA = "0x180F621F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NGODLPIAAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[GIJKPPBGMNE]
public class GDMHOGMODII : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000395")]
	public string EDCLJBEHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000396")]
	public string KKIHKBPKEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GDMHOGMODII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
	public GDMHOGMODII(string FIGODFNPPLD, string JJIEIDBIPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[GIJKPPBGMNE]
public class CLLGMFIPAGF : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000397")]
	public string LOLIJMCCANK
	{
		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000398")]
	public string MABKHIEBOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000399")]
	public bool JICPMHACEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CLLGMFIPAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[GIJKPPBGMNE]
public class HOPFPIMIFPE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700039A")]
	public string GEBIGOAJPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039B")]
	public decimal APIJMOENIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HOPFPIMIFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[GIJKPPBGMNE]
public class FJPIMDKBDIA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700039C")]
	public string? LOLIJMCCANK
	{
		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039D")]
	public string MABKHIEBOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039E")]
	public float? HGNJKFPDEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039F")]
	public string? GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FJPIMDKBDIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
[GIJKPPBGMNE]
public class KMMBNCPGLMO : BLGOMGCKJIM
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KMMBNCPGLMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[GIJKPPBGMNE]
public class CFLKAHANFEA : OBBEDABEIMA
{
	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CFLKAHANFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[GIJKPPBGMNE]
public class POJOBEJCIJO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003A0")]
	public string KOEPNMMBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A1")]
	public string MABKHIEBOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A2")]
	public bool PLAOILAKJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public POJOBEJCIJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
[GIJKPPBGMNE]
public class NACKPHGJJBC : POJOBEJCIJO
{
	[Cpp2IlInjected.Token(Token = "0x170003A3")]
	public string GKPCMLDMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NACKPHGJJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[GIJKPPBGMNE]
public class EFMBAANCAJJ : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003A4")]
	public long PDIHFDJEING
	{
		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A5")]
	public string KOEPNMMBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A6")]
	public HKKIFJOFEFO LMCFLLGHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(HKKIFJOFEFO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A7")]
	public Guid? MIGCGALIJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x78DE650", Offset = "0x78DCC50", VA = "0x1878DE650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x78DE670", Offset = "0x78DCC70", VA = "0x1878DE670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A8")]
	public string? HBKAKIAFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000916")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public EFMBAANCAJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
public enum HKKIFJOFEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	Requested = 0,
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	ProviderMeshRequested = 1,
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	ProviderMeshGenerated = 2,
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	ProviderMeshGenFailed = 3,
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	CloudBuildRequested = 11,
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	CloudBuildCompleted = 12,
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	CloudBuildFailed = 13,
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	MeshGenCompleted = 21,
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	ImageReferenceRequested = 31,
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	ImageReferenceGenerated = 32,
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	ImageReferenceGenerationFailed = 33
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
[GIJKPPBGMNE]
public class MCMHCGOAPFI : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003A9")]
	public string? LOLIJMCCANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AA")]
	public string MABKHIEBOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600091C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(RVA = "0x78E4960", Offset = "0x78E2F60", VA = "0x1878E4960")]
	public MCMHCGOAPFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[GIJKPPBGMNE]
public class OBBEDABEIMA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003AB")]
	public string LOLIJMCCANK
	{
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AC")]
	public string MABKHIEBOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000922")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000923")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OBBEDABEIMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[GIJKPPBGMNE]
public class BLGOMGCKJIM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003AD")]
	public List<string> JIBIHBNFFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AE")]
	public decimal EABFKBNJLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000929")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BLGOMGCKJIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[GIJKPPBGMNE]
public class PHLFCONGNCC : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003AF")]
	public int AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B0")]
	public string MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B1")]
	public string? CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B2")]
	public IReadOnlyList<int> MABEEJFEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B3")]
	public string? HPONKGIFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000934")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000935")]
	[Cpp2IlInjected.Address(RVA = "0x78E79B0", Offset = "0x78E5FB0", VA = "0x1878E79B0")]
	public PHLFCONGNCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[GIJKPPBGMNE]
public class PAJNEEALNFO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003B4")]
	public int AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B5")]
	public Guid? AGFJPIILPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x24E9060", Offset = "0x24E7660", VA = "0x1824E9060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x24E9050", Offset = "0x24E7650", VA = "0x1824E9050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B6")]
	public string MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B7")]
	public List<PHLFCONGNCC> DGPJMGNBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B8")]
	public List<PHLFCONGNCC> GKIJCJFBFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B9")]
	public string? CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BA")]
	public string? HPONKGIFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BB")]
	public string? DGJGBDJHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x78E71D0", Offset = "0x78E57D0", VA = "0x1878E71D0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x78E7200", Offset = "0x78E5800", VA = "0x1878E7200")]
	public PAJNEEALNFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[GIJKPPBGMNE]
public class FNCLADNEDMF : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003BC")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BD")]
	public PAJNEEALNFO DGPJMGNBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BE")]
	public PAJNEEALNFO GKIJCJFBFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BF")]
	public string? DGJGBDJHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x78E0450", Offset = "0x78DEA50", VA = "0x1878E0450", Slot = "5")]
	public virtual void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FNCLADNEDMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[GIJKPPBGMNE]
public class NGHAAJFKLCH : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003C0")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C1")]
	public IReadOnlyList<PAJNEEALNFO> FJJFLMGNOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C2")]
	public IReadOnlyList<FNCLADNEDMF> PKNKNOELNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C3")]
	public IReadOnlyList<NGHAAJFKLCH> EFNBOBGINKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C4")]
	public string? DGJGBDJHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x78E5F40", Offset = "0x78E4540", VA = "0x1878E5F40", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x78E5F70", Offset = "0x78E4570", VA = "0x1878E5F70")]
	public NGHAAJFKLCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[GIJKPPBGMNE]
public class HINABDACBAF : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	public const string DPDEGINOHPD = "REPL_";

	[Cpp2IlInjected.Token(Token = "0x170003C5")]
	public string AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C6")]
	public int PPMMJPMHBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HINABDACBAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[GIJKPPBGMNE]
public class IGJGNEMCLCM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003C7")]
	public int? PMMIAHCCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C8")]
	public string? POMOJJGOKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C9")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CA")]
	public string MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CB")]
	public List<IGJGNEMCLCM>? CKHLPOACJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CC")]
	public HINABDACBAF? NNJAMNFINMO
	{
		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x78E1570", Offset = "0x78DFB70", VA = "0x1878E1570", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IGJGNEMCLCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[GIJKPPBGMNE]
public class MPKKIOKPOKC : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003CD")]
	public string BDNDJKCLALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CE")]
	public string OAJCKEGPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MPKKIOKPOKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[GIJKPPBGMNE]
public class FPNPCCGBBBH : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003CF")]
	public string AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D0")]
	public NGHAAJFKLCH CJHGPDHLOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D1")]
	public IGJGNEMCLCM? FAOLNPNLDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D2")]
	public List<IGJGNEMCLCM>? APNPLCDPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D3")]
	public IReadOnlyList<PAJNEEALNFO> IECJDNMOLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D4")]
	public IReadOnlyList<MPKKIOKPOKC> BBFIEGPHKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D5")]
	public string? GNNJIEAEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x78E05A0", Offset = "0x78DEBA0", VA = "0x1878E05A0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x78E0630", Offset = "0x78DEC30", VA = "0x1878E0630")]
	public FPNPCCGBBBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[GIJKPPBGMNE]
public class MHCMNDDJAEK : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003D6")]
	public FPEHGGCGONO<FPNPCCGBBBH> AJMNBCHCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D7")]
	public decimal IEBFJHHKAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x77EE130", Offset = "0x77EC730", VA = "0x1877EE130", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MHCMNDDJAEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public enum DGPLHKOOGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
[GIJKPPBGMNE]
public class BFNCFKKJJMO : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003D8")]
	public DGPLHKOOGAM GHOMDHPNCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(DGPLHKOOGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D9")]
	public DateTime OCABLKCELJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BFNCFKKJJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[GIJKPPBGMNE]
public class BDOGKLPIDON : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003DA")]
	public DGPLHKOOGAM DBNLLCIKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(DGPLHKOOGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DB")]
	public float CBAHOLMMBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCC0", Offset = "0xE8A2C0", VA = "0x180E8BCC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0xE8C790", Offset = "0xE8AD90", VA = "0x180E8C790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BDOGKLPIDON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[GIJKPPBGMNE]
public class NBFPFGIPLPC : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003DC")]
	public DGPLHKOOGAM GHOMDHPNCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(DGPLHKOOGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DD")]
	public DateTime OCABLKCELJN
	{
		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DE")]
	public DGPLHKOOGAM DBNLLCIKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(DGPLHKOOGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DF")]
	public float CBAHOLMMBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFC0", Offset = "0xAEC5C0", VA = "0x180AEDFC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFB0", Offset = "0xAEC5B0", VA = "0x180AEDFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E0")]
	public DGPLHKOOGAM EDLMFNBPFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(DGPLHKOOGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E1")]
	public float NLHOJFEFHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xDB9260", Offset = "0xDB7860", VA = "0x180DB9260")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xDB9270", Offset = "0xDB7870", VA = "0x180DB9270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NBFPFGIPLPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[GIJKPPBGMNE]
public class MMIDGFHFCME : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003E2")]
	public TimeSpan DCNABOLNDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E3")]
	public TimeSpan GDCIOCLCKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MMIDGFHFCME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[GIJKPPBGMNE]
public class LCLOHHLALPE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003E4")]
	public List<string> FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LCLOHHLALPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[GIJKPPBGMNE]
public class CHOOGGGGHLD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003E5")]
	public string? LOLIJMCCANK
	{
		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E6")]
	public string DGPJMGNBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E7")]
	public string JLIHPPIKJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E8")]
	public string OJBNAMMFPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E9")]
	public string? DJAPMMKKKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x78DCF50", Offset = "0x78DB550", VA = "0x1878DCF50")]
	public CHOOGGGGHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[GIJKPPBGMNE]
public class GFOCHFKAPIE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003EA")]
	public HEFFBECLBFK KOGINNIHMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EB")]
	public DGPLHKOOGAM HKLJLFDGDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(DGPLHKOOGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EC")]
	public long? OJKIEFAFFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0xEAD290", Offset = "0xEAB890", VA = "0x180EAD290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xF95BE0", Offset = "0xF941E0", VA = "0x180F95BE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003ED")]
	public DateTime? BEFBLPLOBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xF61520", Offset = "0xF5FB20", VA = "0x180F61520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xF621F0", Offset = "0xF607F0", VA = "0x180F621F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EE")]
	public long? PFFMOOCPHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x106F980", Offset = "0x106DF80", VA = "0x18106F980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x106F990", Offset = "0x106DF90", VA = "0x18106F990")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GFOCHFKAPIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[GIJKPPBGMNE]
public class MKCNMNOIOPH : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003EF")]
	public int JEBHFFGKMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F0")]
	public DateTime? AMDMNJKBEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MKCNMNOIOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[GIJKPPBGMNE]
public class PDGOJAKFHDP : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003F1")]
	public List<BIPLGIAICHB> BBMAMOJGBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public PDGOJAKFHDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[GIJKPPBGMNE]
public class BIPLGIAICHB : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003F2")]
	public string DKKHAJFLDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x78DC8B0", Offset = "0x78DAEB0", VA = "0x1878DC8B0")]
	public BIPLGIAICHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[GIJKPPBGMNE]
public class PDKKCENDLHN : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003F3")]
	public List<FGFJLHPMCEM> MJOFFGPNBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F4")]
	public string FFHANENOIHN
	{
		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x78E7630", Offset = "0x78E5C30", VA = "0x1878E7630")]
	public PDKKCENDLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[GIJKPPBGMNE]
public class FGFJLHPMCEM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003F5")]
	public string AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F6")]
	public string DILHFCFNPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F7")]
	public string JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F8")]
	public string GLNPGKOCJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F9")]
	public DateTime EIHKFHDJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0xA95020", Offset = "0xA93620", VA = "0x180A95020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public FGFJLHPMCEM(string JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
public enum KLEFFKBMIOG
{
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	User,
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	System,
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	AI
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[GIJKPPBGMNE]
public class GEAOMMGJICL : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003FA")]
	public string NNBLNDGFICB
	{
		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FB")]
	public KLEFFKBMIOG BGJHGENHODA
	{
		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(KLEFFKBMIOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FC")]
	public string FDJBGNNLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GEAOMMGJICL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[GIJKPPBGMNE]
public class IJMJECNHKGE : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x170003FD")]
	public string NNBLNDGFICB
	{
		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FE")]
	public string JBEEJBOMGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FF")]
	public string HAEIJDGMAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IJMJECNHKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public enum HEAELPENINP
{
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	Required,
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	Forced
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[GIJKPPBGMNE]
public class LGKOKOJLAFP : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000400")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000401")]
	public string JBGPOMGKKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000402")]
	public string? ACHJJIPNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LGKOKOJLAFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[GIJKPPBGMNE]
public class AHINCJJIOFA : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000403")]
	public string NNBLNDGFICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000404")]
	public string? LOLIJMCCANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000405")]
	public float? HGNJKFPDEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000406")]
	public LGKOKOJLAFP? OJBNAMMFPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000407")]
	public List<LGKOKOJLAFP> MMEJPFGJABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000408")]
	public HEAELPENINP BMMGGKBBGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		[CompilerGenerated]
		get
		{
			return default(HEAELPENINP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000409")]
	public string? GHLAJKMMMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x78DC1F0", Offset = "0x78DA7F0", VA = "0x1878DC1F0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x78DC210", Offset = "0x78DA810", VA = "0x1878DC210")]
	public AHINCJJIOFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[GIJKPPBGMNE]
public class GEPPEEMFBMD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700040A")]
	public string AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040B")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040C")]
	public string OHLDBKFFHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GEPPEEMFBMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[GIJKPPBGMNE]
public class NFDCCLPNAPD : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700040D")]
	public List<string> MDACEGOOEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040E")]
	public List<GEPPEEMFBMD>? FFBNBJAAGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x78E5EE0", Offset = "0x78E44E0", VA = "0x1878E5EE0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NFDCCLPNAPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[GIJKPPBGMNE]
public class BHJLICJIIMM : KPJILIFBKOE
{
	[Cpp2IlInjected.Token(Token = "0x1700040F")]
	public string GEBIGOAJPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void EOCKPKLKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BHJLICJIIMM()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
public class CMLEPANJLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CMLEPANJLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x7603210", Offset = "0x7601810", VA = "0x187603210")]
	public static string LGLCMNMBJJF(byte[] HIJEGMKCLKI, byte[] BBJNPAEMBIM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
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
