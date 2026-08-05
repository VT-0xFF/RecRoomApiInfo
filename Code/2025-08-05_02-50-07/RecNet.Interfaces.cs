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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x773C900", Offset = "0x773BD00", VA = "0x18773C900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EHMGDHLEOFL
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum ANOFDHMMKEE
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
	public string KMIKIIJOAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string EDOIDLDOCPP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ANOFDHMMKEE JGANNEDDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(ANOFDHMMKEE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NFBMIKHJFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2321C00", Offset = "0x2321000", VA = "0x182321C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LFICEOBFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19CB5E0", Offset = "0x19CA9E0", VA = "0x1819CB5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7734AF0", Offset = "0x7733EF0", VA = "0x187734AF0")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static EHMGDHLEOFL KMAEPPNCJOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7734B50", Offset = "0x7733F50", VA = "0x187734B50")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static EHMGDHLEOFL NAJHPEJOGOO([Optional] string ODICBAAEMOB, [Optional] string FBPBNIMPFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EHMGDHLEOFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ILNKFBJNJDF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string CNFEPDMDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string LNJOODLPDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NDNFIOOBALK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ILNKFBJNJDF> JNCCGIBPGBD(string GIEDBGIDEDD, string CEMPIJDGFJL, string ONPKNOLJFMP, VoiceOption PGMNGEDFIEF, string? HCHBGHGMKJP, float DLHGECLFIPG, [Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GBDCMLADEHH : NDNFIOOBALK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BDMBHKKDJBE? GIIBJKJNDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BBKKNBJGBDM<MNENFCNEDEI> CLJEAELKFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BBKKNBJGBDM<LCCIDKIOJKH> DLAFEBOAICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BBKKNBJGBDM<EMNABAKKAKA> BBHIPGJBCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OFFOKCJIMNI MGODFGPLENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMENDOOHGHJ();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CIBLINIDADN<byte>> OAAGGGFCOBH(string AFMPILNIBJI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<HFCBDPJJDFA> DKKNIKGOOHP(bool DJEGFCJCIPE, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<BNPKKEFIOKG<KPHGPEDGMMJ>> EHIOLLNALMN(bool AIMEGPNJDFO = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<HFCBDPJJDFA> ICCJPCENCJP(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<JMGMKEEJIFI<AOBPEDHMIOO>> JFCHPDJMGKK(long DCONEHIDLCB, bool ODLLLPEFJPF = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<KPKALMODPGL> KNCBCCOBPBH([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KPKALMODPGL> JKFDAEPCMOA(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<EEHMPCBBEBA> CFCIIOOLHFH(bool ODLLLPEFJPF = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<AIBIKEGHLEH> LIDHCFAKIGL([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<HFCBDPJJDFA> FADKCHKIAMP(bool ODLLLPEFJPF = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<HFCBDPJJDFA> DAMBKLNKFCB([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<HFCBDPJJDFA> EAMBFIGCALA(string GIEDBGIDEDD, Guid BHNMHEIBCEK, long DCONEHIDLCB, long DAKBFKLMPGD, decimal IPIGFBNGLDK, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<BNPKKEFIOKG<KPHGPEDGMMJ>> MMBNCKHKKLL(Guid BHNMHEIBCEK, long DCONEHIDLCB, long DAKBFKLMPGD, decimal IPIGFBNGLDK, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task IMCJCAMMAKE(string NJKPMDJOLDC, string IAONKOEGDIB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<BHGDAOHAGJH> CMEEMJIDGGL(string CEMPIJDGFJL, string NOJFJKJJBMD, bool KHIGFMLPBEH, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<EMNABAKKAKA> CIPKAPEGODF(long DCONEHIDLCB, string NHCIOPCEIAN, string IEFGJLNKNBK, string NOJFJKJJBMD, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<EMNABAKKAKA> BMDMPAKEPOK(long EFAHIMBLKLN, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<BABIBMDDJKB> PAPOMMAKGOJ(string? CEMPIJDGFJL, string NOJFJKJJBMD, string JDPAGNELAJI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<BABIBMDDJKB> PAPOMMAKGOJ(string? CEMPIJDGFJL, string NOJFJKJJBMD, byte[] NKNOGCDFJHI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<BABIBMDDJKB> NABOAIHLFEI(long DCONEHIDLCB, string? CEMPIJDGFJL, string NOJFJKJJBMD, string JDPAGNELAJI, float? DLHGECLFIPG, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<BABIBMDDJKB> NABOAIHLFEI(long DCONEHIDLCB, string? CEMPIJDGFJL, string NOJFJKJJBMD, byte[] NKNOGCDFJHI, float? DLHGECLFIPG, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<BHGDAOHAGJH> DMOMHJFGIOA(long DCONEHIDLCB, MNALFLDEIKD IDLJGJGIGEG, byte[] NKNOGCDFJHI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<BHGDAOHAGJH> JKGLODDBPOG(MNALFLDEIKD IDLJGJGIGEG, string NHCIOPCEIAN, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<BHGDAOHAGJH> FFKIDDLLDCM(long DCONEHIDLCB, string CEMPIJDGFJL, string NOJFJKJJBMD, bool KHIGFMLPBEH, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<NIGMHCHAIBJ> LJFBMNLKOOK(string NOJFJKJJBMD, int DLCLIHPGOLF, string BDHICMIBGMG, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<NIGMHCHAIBJ> AOABPJMHKDF(string NOJFJKJJBMD, int DLCLIHPGOLF, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<ILIKDBCLABL> PCBKOKPJCBC(string? CEMPIJDGFJL, string NOJFJKJJBMD, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<BDMBHKKDJBE> NCILLALOCPI(string NOJFJKJJBMD, AODAAMEIPME? EKPJDHANGLH, IReadOnlyList<AODAAMEIPME>? LFNMIODHFMN, IReadOnlyList<string> EBJNGOEEGJA, GGJIOLNIJKO HFDKCBHNBMB, [Optional] string? BFLGMCPEBFM, [Optional] string? PCEFNKEGPIJ, [Optional] string? ENNILDFGFKB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<BDMBHKKDJBE> NEKMJAAICFD(string AINAMMEFIOC, AODAAMEIPME? EKPJDHANGLH, IReadOnlyList<string> EBJNGOEEGJA, GGJIOLNIJKO HFDKCBHNBMB, [Optional] string? PCEFNKEGPIJ, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<List<string>> ENFFKDICLIN(string NOJFJKJJBMD, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<string> JKIDFFKEKDG(GGJIOLNIJKO HFDKCBHNBMB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task JKBNJPBPMEP(string MICKAKKPGLH, VoiceOption PGMNGEDFIEF, string? ONPKNOLJFMP, Action<string> OFHDHCIPAFL, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<string> DDNNEBLGLJJ(ReadOnlyMemory<byte> EFOMKPMNAOF, int MBLOEPMGFGN, int FCFHMBNBOIH, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<MKFFNIJAJFL> FFGNDJMBBMA(List<GNGAFGGFBMC> BOELAPFBLKG, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<MKFFNIJAJFL> IHEHADPAHDI([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task FPBDIFEHCEN(string JEPAKFMGLNE, BNEOFCDCDMP IKDIELBILBK, string CAIIFLDFGNH, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task AAKAJGEOHCA(string JEPAKFMGLNE, string GMNMCCHPCLF, string HGHNDNAANCF, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<KDFMCMMAOGK?>? JJHHKLOAFOG(string JEPAKFMGLNE, [Optional] string? CEMPIJDGFJL, [Optional] float? DLHGECLFIPG, [Optional] PJPLDNEIIOG? DOKACCNGNNB, [Optional] IReadOnlyCollection<PJPLDNEIIOG>? NMHHOCLGABC, DMNGIBEBGGB CJOIBECIMFH = DMNGIBEBGGB.Auto, [Optional] string? DHENNHACPDJ, [Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GEIINFJEHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string OJAPPALHMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string BOKNNDIJKII;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string LCBFIBCFEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string NKAKLCPMDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string LPMGILJMEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string GCENBILAPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int? ICAFDILODMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int? IEMHPILNBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x77361D0", Offset = "0x77355D0", VA = "0x1877361D0")]
	public GEIINFJEHEJ(string JOCMKDJLIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x77361A0", Offset = "0x77355A0", VA = "0x1877361A0")]
	public void HHCLHPJGBMB(string KFKCMLIGOKF = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77360A0", Offset = "0x77354A0", VA = "0x1877360A0")]
	private void DGOONBOIIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CBEIAMOCBJN
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FNAODHMLAAP MDFHKMLHNON
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OLOABCDBBEM> MFIHECAOIAG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JMAIEFEOIJA> DMKPGGLNANL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JMAIEFEOIJA> HNLHPLDPBEG(bool HOLLHNOPKGC = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NCIABLHHOKM([Out] JMAIEFEOIJA MBHJDFHDMEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LCOIKBFJKDF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x773ADD0", Offset = "0x773A1D0", VA = "0x18773ADD0")]
	public static bool KLBJEEGLMAE(this CBEIAMOCBJN DEOLEFPOAKM, [Out] OLOABCDBBEM CKKBFNHMBBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x773ACF0", Offset = "0x773A0F0", VA = "0x18773ACF0")]
	public static bool GJAGBOADPGH(this CBEIAMOCBJN DEOLEFPOAKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HBAHGCKPBKG
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DBCMNCDDOKD(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OCNBCGKLKAJ(int OBFAKOICLIH, [Out] NIKCLFEEJJG? HFDKCBHNBMB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NIKCLFEEJJG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int NNPJDALDPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string? GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool? GHMKOLLDGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string? NBFFHOICOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? CIFPCINDMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AKBECHJNLHC? FIAHCIEPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MKJJKLKDKPH(string DAFGNMEBNBA, [Out] PCPBEKGGLFJ? HFDKCBHNBMB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PCPBEKGGLFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? BOIMKKDBOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string? PFJJNLGCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string? BHCFCEFFCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IReadOnlyList<GBGELFHKJFC>? HHNDGIDPFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	AKBECHJNLHC? FIAHCIEPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	long? DPCCKKDBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GBGELFHKJFC
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string PFJJNLGCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DLKHMKJKOFA FNPHAICJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AKBECHJNLHC
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string PFJJNLGCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string? PAJFOOGNDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[EIJCMKCDLED]
public class OIINIPAIOFN
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public List<AALDJKFNGJM> GJLBNKDBCGN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Dictionary<string, string> AINEAIKKEEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x773D5D0", Offset = "0x773C9D0", VA = "0x18773D5D0")]
	public OIINIPAIOFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[EIJCMKCDLED]
public class AALDJKFNGJM
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int NNPJDALDPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string NBFFHOICOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string CIFPCINDMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool? GHMKOLLDGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xE5E9C0", Offset = "0xE5DDC0", VA = "0x180E5E9C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xE5E9D0", Offset = "0xE5DDD0", VA = "0x180E5E9D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IFBFIMEDMLP FIAHCIEPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Dictionary<string, BABIBNFFPCB> IJCFPLDPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x77327D0", Offset = "0x7731BD0", VA = "0x1877327D0")]
	public AALDJKFNGJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[EIJCMKCDLED]
public class IFBFIMEDMLP
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string PFJJNLGCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string PAJFOOGNDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IFBFIMEDMLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[EIJCMKCDLED]
public class BABIBNFFPCB
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string BOIMKKDBOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string PFJJNLGCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string BHCFCEFFCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public List<FOBKHIDLPKH> HHNDGIDPFPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IFBFIMEDMLP FIAHCIEPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long DPCCKKDBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA7B820", Offset = "0xA7AC20", VA = "0x180A7B820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x77331E0", Offset = "0x77325E0", VA = "0x1877331E0")]
	public BABIBNFFPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum DLKHMKJKOFA
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
[EIJCMKCDLED]
public class FOBKHIDLPKH
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string PFJJNLGCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DLKHMKJKOFA FNPHAICJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(DLKHMKJKOFA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FOBKHIDLPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct PLPEMGDLDEE : IEquatable<PLPEMGDLDEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool FFOMBOPIAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime MCIBIIFCOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool GIIKBEMDMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly BHKAGDNLKEG? NKOLDGMNLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string DLJNBAIKKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? AHKFKHHPNKG;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static PLPEMGDLDEE FDOFGDMEOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2A0F5E0", Offset = "0x2A0E9E0", VA = "0x182A0F5E0")]
		get
		{
			return default(PLPEMGDLDEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x773E400", Offset = "0x773D800", VA = "0x18773E400")]
	public PLPEMGDLDEE(DateTime LJEJFKFFFAA, bool MGLBIJCIAND, BHKAGDNLKEG? KDPOCPGFCKC, string PGDGCMJHHOF, int? GBCDEABPEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x773E2A0", Offset = "0x773D6A0", VA = "0x18773E2A0")]
	public OLOABCDBBEM MNPFBDOPLPL(FNAODHMLAAP KKPLENBLEDD)
	{
		return default(OLOABCDBBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x773E220", Offset = "0x773D620", VA = "0x18773E220")]
	private static OLOABCDBBEM KJKBDGBPMOP(FNAODHMLAAP KKPLENBLEDD, DateTime LJEJFKFFFAA)
	{
		return default(OLOABCDBBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x773DFE0", Offset = "0x773D3E0", VA = "0x18773DFE0", Slot = "4")]
	public bool Equals(PLPEMGDLDEE LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x773DF30", Offset = "0x773D330", VA = "0x18773DF30", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x773E140", Offset = "0x773D540", VA = "0x18773E140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x773E1F0", Offset = "0x773D5F0", VA = "0x18773E1F0")]
	public static bool ILMCFLMCOJH(PLPEMGDLDEE JLJHECODIOL, PLPEMGDLDEE DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x773DEF0", Offset = "0x773D2F0", VA = "0x18773DEF0")]
	public static bool AMDBHCBNEEF(PLPEMGDLDEE JLJHECODIOL, PLPEMGDLDEE DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x773E330", Offset = "0x773D730", VA = "0x18773E330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct JMAIEFEOIJA : IEquatable<JMAIEFEOIJA>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly JMAIEFEOIJA FDOFGDMEOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool JDPJAANKGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly OLOABCDBBEM BEPHKKLODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly PLPEMGDLDEE JBDHAEAPJKJ;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x77386F0", Offset = "0x7737AF0", VA = "0x1877386F0")]
	public JMAIEFEOIJA(OLOABCDBBEM CKKBFNHMBBC, PLPEMGDLDEE BOJMGIDDJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7738250", Offset = "0x7737650", VA = "0x187738250", Slot = "4")]
	public bool Equals(JMAIEFEOIJA LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7738300", Offset = "0x7737700", VA = "0x187738300", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7738430", Offset = "0x7737830", VA = "0x187738430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x77384F0", Offset = "0x77378F0", VA = "0x1877384F0")]
	public static bool ILMCFLMCOJH(JMAIEFEOIJA JLJHECODIOL, JMAIEFEOIJA DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7738130", Offset = "0x7737530", VA = "0x187738130")]
	public static bool AMDBHCBNEEF(JMAIEFEOIJA JLJHECODIOL, JMAIEFEOIJA DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7738600", Offset = "0x7737A00", VA = "0x187738600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum OLOABCDBBEM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KDPBCPAKGOB : FNAODHMLAAP
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string DGDNHDCGEEL = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch GHGCDEPGPAK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? IKGMBOBDIEF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly KDPBCPAKGOB CDEDDCLKCCJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static FNAODHMLAAP NKAKNKMIPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x773A020", Offset = "0x7739420", VA = "0x18773A020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal static KDPBCPAKGOB IIODDOMHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x773A480", Offset = "0x7739880", VA = "0x18773A480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static DateTimeOffset HOHCLJKPOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x773A290", Offset = "0x7739690", VA = "0x18773A290")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static DateTime EMKIMJHLBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x773A3F0", Offset = "0x77397F0", VA = "0x18773A3F0")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime MLKIAMDNKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7739F60", Offset = "0x7739360", VA = "0x187739F60", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DateTimeOffset ILNMALEOHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x773A4D0", Offset = "0x77398D0", VA = "0x18773A4D0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	private KDPBCPAKGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x773A070", Offset = "0x7739470", VA = "0x18773A070")]
	internal static void DJPPPNCABBA(DateTime? GOBCHJAFOGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum KAEFFAOLCBH
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JHMMNKGHGNP
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[EIJCMKCDLED]
public class EMNLKCIAKAO : OKFEDOGLILB, DKGDNEFFHIH, EODJFKKINLJ, JPGLNCIFIDA, PBKNJNKCPKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct LLMEBEPCDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EMNLKCIAKAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x773B750", Offset = "0x773AB50", VA = "0x18773B750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x773BB00", Offset = "0x773AF00", VA = "0x18773BB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static NADJFCAAKAN DJKKMHOOAJC;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int ADGNCLKPOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public POKGCAJLAGP OIFIHHJMGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC60", Offset = "0xA8C060", VA = "0x180A8CC60", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(POKGCAJLAGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x16F6310", Offset = "0x16F5710", VA = "0x1816F6310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool FCIGCNAKAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD31600", Offset = "0xD30A00", VA = "0x180D31600", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xE3FF90", Offset = "0xE3F390", VA = "0x180E3FF90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CMHBNIDPGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xEAF8F0", Offset = "0xEAECF0", VA = "0x180EAF8F0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xEAE260", Offset = "0xEAD660", VA = "0x180EAE260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool NKPFPHKCOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x213B970", Offset = "0x213AD70", VA = "0x18213B970", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x213B180", Offset = "0x213A580", VA = "0x18213B180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int? IMIAINMCDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7734FD0", Offset = "0x77343D0", VA = "0x187734FD0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7734D50", Offset = "0x7734150", VA = "0x187734D50", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string BBJOEENHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string PBBEGACCBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string NHKKOPFPPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xF911E0", Offset = "0xF905E0", VA = "0x180F911E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public DateTime PGKBDGCPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xF90B70", Offset = "0xF8FF70", VA = "0x180F90B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public KAEFFAOLCBH CPMFHHOFLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xAD9060", Offset = "0xAD8460", VA = "0x180AD9060", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(KAEFFAOLCBH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x15C2F70", Offset = "0x15C2370", VA = "0x1815C2F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string KOEFHKOPINB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9B0", Offset = "0xA7BDB0", VA = "0x180A7C9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int IPKCAEIMJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xD5C6F0", Offset = "0xD5BAF0", VA = "0x180D5C6F0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xD5C9F0", Offset = "0xD5BDF0", VA = "0x180D5C9F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public IReadOnlyList<OKKEHLNKJBB> PBGPNOFNPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xB1ECE0", Offset = "0xB1E0E0", VA = "0x180B1ECE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IReadOnlyList<NENDGPAMBCI> DEJFADPNFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public NAJMNCODMAO LHJCHAKDEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7C860", Offset = "0xA7BC60", VA = "0x180A7C860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7C970", Offset = "0xA7BD70", VA = "0x180A7C970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string OGOPICBLACO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7734D30", Offset = "0x7734130", VA = "0x187734D30", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public BHKEDJFHKGB HKNPOEGBFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xC11DD0", Offset = "0xC111D0", VA = "0x180C11DD0", Slot = "24")]
		get
		{
			return default(BHKEDJFHKGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7734D30", Offset = "0x7734130", VA = "0x187734D30", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool KMBPPPEDPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EBJFCGJIDIH GPADKJEJPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAC00D0", Offset = "0xABF4D0", VA = "0x180AC00D0", Slot = "30")]
		get
		{
			return default(EBJFCGJIDIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string PGAICCMNNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public LHBKFFHMLKB? DFOHLLFJCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7734DE0", Offset = "0x77341E0", VA = "0x187734DE0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public OGFBEMPGJHE MEGDOIAEGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xC11DD0", Offset = "0xC111D0", VA = "0x180C11DD0", Slot = "33")]
		get
		{
			return default(OGFBEMPGJHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool ALGJAIPBOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EMNLKCIAKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x10B98B0", Offset = "0x10B8CB0", VA = "0x1810B98B0")]
	public EMNLKCIAKAO([Optional] Guid NPMPEIAPAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7734E30", Offset = "0x7734230", VA = "0x187734E30", Slot = "35")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7734C60", Offset = "0x7734060", VA = "0x187734C60", Slot = "36")]
	[AsyncStateMachine(typeof(LLMEBEPCDDJ))]
	public Task CLBBHINLKGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7734D60", Offset = "0x7734160", VA = "0x187734D60")]
	public EMNLKCIAKAO PKJKLOPGALM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[EIJCMKCDLED]
public class HABPCJCJLLP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public int? IMIAINMCDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x13852D0", Offset = "0x13846D0", VA = "0x1813852D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x10509D0", Offset = "0x104FDD0", VA = "0x1810509D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string BBJOEENHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public POKGCAJLAGP OIFIHHJMGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		[CompilerGenerated]
		get
		{
			return default(POKGCAJLAGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public KAEFFAOLCBH? CPMFHHOFLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xABD750", Offset = "0xABCB50", VA = "0x180ABD750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xABD760", Offset = "0xABCB60", VA = "0x180ABD760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HABPCJCJLLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[EIJCMKCDLED]
public class LJGOBCHIAGI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int ADGNCLKPOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int? IMIAINMCDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1385110", Offset = "0x1384510", VA = "0x181385110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x138FD10", Offset = "0x138F110", VA = "0x18138FD10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string PBBEGACCBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string BBJOEENHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LJGOBCHIAGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[EIJCMKCDLED]
public class HFLHHGGHOIG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int? IMIAINMCDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string BBJOEENHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HFLHHGGHOIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct MGNEEBANKIB
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int FAFEKKCAPAH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int LDKHFPFHNCK;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int ILAPKHOMCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int HHPANJLGKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBA0", Offset = "0x2FBAFA0", VA = "0x182FBBBA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static MGNEEBANKIB BCIBOEFGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x773BC40", Offset = "0x773B040", VA = "0x18773BC40")]
		get
		{
			return default(MGNEEBANKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x773BCF0", Offset = "0x773B0F0", VA = "0x18773BCF0")]
	public MGNEEBANKIB(int ALEILFPOFPO, int GCPIFCMJCNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[EIJCMKCDLED]
public class IOMEBPKCPNF : EODJFKKINLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int DOKEMIPIMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int GNJHHPJBLEE;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IOMEBPKCPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[EIJCMKCDLED]
public class MDGHKFMHBCG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int JPNGOMMMOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int? LEEKIAFMOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1385110", Offset = "0x1384510", VA = "0x181385110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x138FD10", Offset = "0x138F110", VA = "0x18138FD10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string? PBICDNNDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x773BBE0", Offset = "0x773AFE0", VA = "0x18773BBE0")]
	public MDGHKFMHBCG(int BIHCLINBKCD, int? GMGOLJMFFDK, string? AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MDGHKFMHBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[EIJCMKCDLED]
public class PEOIIPACFBP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public NOHGPJINMCJ.JMGKKLIOJLM EKODKMHFCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(NOHGPJINMCJ.JMGKKLIOJLM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public string CIHBEGAJAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int? KKHKCKPFIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PEOIIPACFBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NENDGPAMBCI
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long EGDLDIFPEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Guid EGENNPOMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string PJHMFKCGFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string BGDANBBDICC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int KAKEPKOJFME
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string FAHDFJDIKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string BAFGAGFDBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	string KGGPNHLBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	string CEGFGIOFCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int IPKCAEIMJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[EIJCMKCDLED]
public class OKKEHLNKJBB : NENDGPAMBCI, EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public long EGDLDIFPEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Guid EGENNPOMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x13E0010", Offset = "0x13DF410", VA = "0x1813E0010", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1518150", Offset = "0x1517550", VA = "0x181518150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA7B820", Offset = "0xA7AC20", VA = "0x180A7B820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string PJHMFKCGFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string BGDANBBDICC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int KAKEPKOJFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xE6F700", Offset = "0xE6EB00", VA = "0x180E6F700", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xFB5540", Offset = "0xFB4940", VA = "0x180FB5540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string FAHDFJDIKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string BAFGAGFDBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public string KGGPNHLBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA70240", Offset = "0xA6F640", VA = "0x180A70240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string CEGFGIOFCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA70170", Offset = "0xA6F570", VA = "0x180A70170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int IPKCAEIMJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xAD9060", Offset = "0xAD8460", VA = "0x180AD9060", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x15C2F70", Offset = "0x15C2370", VA = "0x1815C2F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "15")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OKKEHLNKJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Flags]
public enum JJJIMHCLCBC
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum DDDAONPIBHA
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
public static class OLCLHBNCPBI
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x773DD10", Offset = "0x773D110", VA = "0x18773DD10")]
	public static int? CJLIPCCDDFP(JJJIMHCLCBC? LNJBIJKAMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x773DC80", Offset = "0x773D080", VA = "0x18773DC80")]
	public static int? AHDPHLACNOH(DDDAONPIBHA? BDLEJBNOEGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[EIJCMKCDLED]
public class CCKDIJMIFPP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int? IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public POKGCAJLAGP? OIFIHHJMGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA703A0", Offset = "0xA6F7A0", VA = "0x180A703A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CCKDIJMIFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[EIJCMKCDLED]
public class AMMBECAJBIA : GDNDDINAKDK, EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public byte KCAKJCBNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AMMBECAJBIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class MKECKGIOHIC
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x773BD50", Offset = "0x773B150", VA = "0x18773BD50")]
	public static EEPNMBMKPKK NMJCIHDAPBN(this AMMBECAJBIA DMFKPMONDPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OKFEDOGLILB
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	int ADGNCLKPOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	int IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	POKGCAJLAGP OIFIHHJMGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool FCIGCNAKAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool CMHBNIDPGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool NKPFPHKCOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	int? IMIAINMCDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string BBJOEENHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	string PBBEGACCBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string NHKKOPFPPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	DateTime PGKBDGCPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	KAEFFAOLCBH CPMFHHOFLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string KOEFHKOPINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	int IPKCAEIMJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string OGOPICBLACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x773DA20", Offset = "0x773CE20", VA = "0x18773DA20", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PBKNJNKCPKE
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	IReadOnlyList<NENDGPAMBCI> DEJFADPNFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	int ADGNCLKPOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool NKPFPHKCOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int IPKCAEIMJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	int? IMIAINMCDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	POKGCAJLAGP OIFIHHJMGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FHPAGOJJDBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HPJKOAHNEHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IEnumerable<JPGLNCIFIDA> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x77371B0", Offset = "0x77365B0", VA = "0x1877371B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7737460", Offset = "0x7736860", VA = "0x187737460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7735690", Offset = "0x7734A90", VA = "0x187735690")]
	public static bool BMGJOAPMABC(this IEnumerable<EODJFKKINLJ> KIGLENMLJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x77358C0", Offset = "0x7734CC0", VA = "0x1877358C0")]
	[AsyncStateMachine(typeof(HPJKOAHNEHI))]
	public static Task HGGBKDIEGFJ(this IEnumerable<JPGLNCIFIDA> KIGLENMLJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct APAGCNALJKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly string JNADOBLDKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly string HGPLLNICEAH;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly APAGCNALJKL FJMDDOMHAHI;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
	public APAGCNALJKL(string AFMPILNIBJI, string GONCBGJFGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x13A88D0", Offset = "0x13A7CD0", VA = "0x1813A88D0")]
	public bool HELOPPPCEGA(APAGCNALJKL LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7732DA0", Offset = "0x77321A0", VA = "0x187732DA0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7732E80", Offset = "0x7732280", VA = "0x187732E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7732EF0", Offset = "0x77322F0", VA = "0x187732EF0")]
	public static bool ILMCFLMCOJH(APAGCNALJKL JLJHECODIOL, APAGCNALJKL DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7732D20", Offset = "0x7732120", VA = "0x187732D20")]
	public static bool AMDBHCBNEEF(APAGCNALJKL JLJHECODIOL, APAGCNALJKL DABLONGJEGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PLOHKLECJHB
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	GEIINFJEHEJ CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string ELEPMNGBPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string BPOBJEHDFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	long CIDFLEJPLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string ODCLMMHODJD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string CACNDLCLDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	string PFGADJPBBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	string CLAFPPCAELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[EIJCMKCDLED]
public class OFLKMKFEFGO : LCMCHNGCJFI
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string ABJCIGHIFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public JHEBICNNMKD IBONGJNBOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(JHEBICNNMKD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public DCPHCABLLAN LOLHABHJJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
		[CompilerGenerated]
		get
		{
			return default(DCPHCABLLAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public NDIPFAGGFOA EEJFJKIPGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(NDIPFAGGFOA);
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	[DataMember(Name = "Header")]
	public string? FIKANMAAPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string? BOIMKKDBOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string? LKCFPAJGDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public List<string> OJLHCDJPBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public List<KGFOPJFCAML> HHNDGIDPFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x773D480", Offset = "0x773C880", VA = "0x18773D480", Slot = "5")]
	public override void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x773D490", Offset = "0x773C890", VA = "0x18773D490")]
	public OFLKMKFEFGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum AABBGCEEAPP
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
public enum JHEBICNNMKD
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum DCPHCABLLAN
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum NDIPFAGGFOA
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[EIJCMKCDLED]
public class KGFOPJFCAML : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public AABBGCEEAPP BLJEFPKNLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(AABBGCEEAPP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? FGHPFFKNPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[DataMember(Name = "LinkParameter")]
	public string? NLNDCBHEKKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? NMLOHGBLCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KGFOPJFCAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class LCMCHNGCJFI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	[IgnoreDataMember]
	public string? HAICMFBLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void POEGDHEICKD();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x773AC90", Offset = "0x773A090", VA = "0x18773AC90")]
	protected LCMCHNGCJFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[EIJCMKCDLED]
public class NOIBANFOCNJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? PCBFFNPNAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NOIBANFOCNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[EIJCMKCDLED]
public class NABMEMGFNFG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal static Func<string, OFLKMKFEFGO>? IAHMEKGNGAM;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	internal static Func<string, IGBAEFGHINO>? NHFAPPDNCCH;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public string? PCBFFNPNAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string? MLFLGEDENFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool IPDJIEOFFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public BHKAGDNLKEG LGJMBCALBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
		[CompilerGenerated]
		get
		{
			return default(BHKAGDNLKEG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IMFBMEFPKNK EGIHDOKIJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(IMFBMEFPKNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public int GGCGBFNNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xABF670", Offset = "0xABEA70", VA = "0x180ABF670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1646810", Offset = "0x1645C10", VA = "0x181646810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DateTime IMBJIOIINPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA70450", Offset = "0xA6F850", VA = "0x180A70450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[DataMember(Name = "IsRead")]
	internal bool CFHOCLNJCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xACC370", Offset = "0xACB770", VA = "0x180ACC370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xACC0E0", Offset = "0xACB4E0", VA = "0x180ACC0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[IgnoreDataMember]
	public bool LOCGKNAEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x152AB90", Offset = "0x1529F90", VA = "0x18152AB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x152A850", Offset = "0x1529C50", VA = "0x18152A850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public JAKGLFOEBCD OBAAGGJIBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC60", Offset = "0xA8C060", VA = "0x180A8CC60")]
		[CompilerGenerated]
		get
		{
			return default(JAKGLFOEBCD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x16F6310", Offset = "0x16F5710", VA = "0x1816F6310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public MOKFGPADOCC DCFNMBFDJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
		[CompilerGenerated]
		get
		{
			return default(MOKFGPADOCC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CE0", Offset = "0xAD80E0", VA = "0x180AD8CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	internal string? NPCEAIHBGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public OFLKMKFEFGO? EMLKFFCCBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x773C110", Offset = "0x773B510", VA = "0x18773C110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	[IgnoreDataMember]
	public IGBAEFGHINO? DLGDOJJIELM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x773C080", Offset = "0x773B480", VA = "0x18773C080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	[IgnoreDataMember]
	public LCMCHNGCJFI? LFPJBHCGKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x773C1A0", Offset = "0x773B5A0", VA = "0x18773C1A0", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0xA8A7F0", Offset = "0xA89BF0", VA = "0x180A8A7F0")]
	public NABMEMGFNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[EIJCMKCDLED]
public class ABCHFIJMHIP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public NJNIIPJJOOI KLKKOPCJEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(NJNIIPJJOOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string CNKGNKANFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int IHHKJPGPGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7732860", Offset = "0x7731C60", VA = "0x187732860")]
	public ABCHFIJMHIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[EIJCMKCDLED]
public class IGBAEFGHINO : LCMCHNGCJFI
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public string JGFCKBOAGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string? GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public ABCJNOHEINB GCEAEAHJEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(ABCJNOHEINB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	[DataMember(Name = "all_conditions_required")]
	public bool EDLHGDJMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x180AAC0", Offset = "0x1809EC0", VA = "0x18180AAC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1046C60", Offset = "0x1046060", VA = "0x181046C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public List<ABCHFIJMHIP> BHGIEEOHEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7737900", Offset = "0x7736D00", VA = "0x187737900", Slot = "5")]
	public override void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7737910", Offset = "0x7736D10", VA = "0x187737910")]
	public IGBAEFGHINO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum MOKFGPADOCC
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum JAKGLFOEBCD
{
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum ABCJNOHEINB
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum NJNIIPJJOOI
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
public interface LCIPCDNMIKB
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool IECFCMEPCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	BBKKNBJGBDM<NABMEMGFNFG> GFBOGIMJMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	BBKKNBJGBDM<string> ECCPAMMBMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	BBKKNBJGBDM<NABMEMGFNFG> ENCMEDPHAKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	BBKKNBJGBDM<NABMEMGFNFG> IFDBDBANLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<NABMEMGFNFG> EDPNLHNFMCH(JAKGLFOEBCD KOIMDLHEDHM);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<NABMEMGFNFG> NFAKELKCJJF(JAKGLFOEBCD KOIMDLHEDHM);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NABMEMGFNFG EHIGMNPIEJM(JAKGLFOEBCD KOIMDLHEDHM, string CFJNLEKPCLF);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NABMEMGFNFG DEJICPJKHEK(JAKGLFOEBCD KOIMDLHEDHM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AJMLFEMALBI(JAKGLFOEBCD KOIMDLHEDHM);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HMBPCIEKADL(JAKGLFOEBCD KOIMDLHEDHM);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task HBIFLNIMJEH();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DIAMPJPKHFO(NABMEMGFNFG AFDNIPHJHMO);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IMHNEFIICNI
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	IBLNOABCJCM PCINLJNCFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	int EEIPMFMKNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool FFHDBEADGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool ICDCALAIOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool FCHFKEEAILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool DIKBLMFFEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool EIMHAJEKPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	bool PMNFFLLNPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	bool OFPEJDCAOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool KPIKCGPNKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	bool APJKHDBPGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	bool IJOHFOLJJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LMFPCHPPNPN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action GPPGLMPJIAJ;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FHMCAMOMJOP<PLMNPNIMMNE> FMEKGAJBMPE(int MNAACFOHONJ);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IHCAHILICGC JELOPGBCCMP(DateTime OGCDDPGPJOP);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IHCAHILICGC DBMNKPHOBKF(string EHBFBALMPAM);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task LHGGOAKKMAA([Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum NNDDBDLMGFK
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class JGOCEADBPIB
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7737FF0", Offset = "0x77373F0", VA = "0x187737FF0")]
	public static string CCMIDHFPNEC(this NNDDBDLMGFK IKDIELBILBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface GHPPJKFIMNB
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<NABMEMGFNFG>> MPGKHJODGMC(JAKGLFOEBCD KOIMDLHEDHM);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DIAMPJPKHFO(string CFJNLEKPCLF);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface GKIHMCEBBMB
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AJLEDLHBFNL> HCBHCGIHBCI();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface BNOHJJGIMIP
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHMCAMOMJOP<List<OIMCNOBFPAM>> AOINGBDOPHL();

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHMCAMOMJOP<List<OIMCNOBFPAM>> DHJNMOHDFJG();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<OIMCNOBFPAM>> OOBLGBFPGLC([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FHMCAMOMJOP<List<OIMCNOBFPAM>> MKCABBFDPBN(List<PBBHALCOHCB> HDIKJCHNEIM);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHMCAMOMJOP<List<OIMCNOBFPAM>> DHGNAEDGDCL(List<PBBHALCOHCB> HDIKJCHNEIM);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface GGPAGPBMOHM
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	List<KGCPCHPAGKE> HBFGDHKBLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<PGONCLBKNNI> DCFODEADCBP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<KGCPCHPAGKE> MLJABIABJPF;

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IHCAHILICGC PNPGGOLDFDP(KGCPCHPAGKE EJHLOODJAPA);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BCPOEPIHKPI(KGCPCHPAGKE EJHLOODJAPA);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	FHMCAMOMJOP<KGCPCHPAGKE> FLBNFNNHMIB(PGIDFLAKNGN HFJHENFIDEF, PGIDFLAKNGN? CMDAEBCMIDP, bool FBOEKMKHBEE, string AFDNIPHJHMO);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FHMCAMOMJOP<KGCPCHPAGKE> FLBNFNNHMIB(PGIDFLAKNGN HFJHENFIDEF, string AFDNIPHJHMO);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EAGPNIBHOCI(KGCPCHPAGKE GHBKNJKNOAF, bool KGOEHJPFGNO = false, bool ICBNKCLMJMF = false, bool BKPBJEBDBCF = true);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FHMCAMOMJOP<List<KGCPCHPAGKE>> CCJHNHKPHGP();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DLMAEJPKIEH
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string KHJBLMOOBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	bool GMHAGAINJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IHCAHILICGC GJCIEMLEGFL();

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IHCAHILICGC CIDLGNGPBOK(string EJPLHAPPBNB, string LMFPOBOMAOM);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IHCAHILICGC NKMBLNEEHDF(string JPFFBKAFBJB);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFIELCNFLJN();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<GKNPMBBKGOL> EEBBMDLOIPE(string EHBFBALMPAM, string JPFFBKAFBJB, bool IOEAEEDBOPJ, string BAIFOECHMHD, string CEOOAGCPOBO, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task GHMCJNHCPPG(int MNAACFOHONJ, string JAOACJIIMLI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task OCGAGDOCDCG(int MNAACFOHONJ, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task IFDKCIBCFFI([Optional] NNDDBDLMGFK? DEBACINLJII, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<JHEFDODHEKH>> IAJNLGOHGMH([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task OKHMMAFAPMG([Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BJFJLEDKLIC
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<NILDBLPGAJG>> EKGLDJABIDN([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<NPCAMOJHMBH>> JHHJEPCNCCJ([Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface FBBJBDAMLDC
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BKMJFPLFJAE([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNEJFADOIKI();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface PHMFOLOABIP
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event AGLCIPKHOJL? NBAIFKGBNDI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event AGLCIPKHOJL? OLPLMMFOOGI;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event AGLCIPKHOJL? HOEMGLNBKIE;

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<HBAHGJJIJND> POFPIMHJALB();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<HBAHGJJIJND?>? CJLBCAIHHLO(int MNAACFOHONJ);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<OKJPEBPHEFO>> ODLJNICPKLM(List<int> COIIJJPDABO);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, HBAHGJJIJND>> EMEJEIEINEB();

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<HBAHGJJIJND?>?>? LGAFOKEIGFP(int MNAACFOHONJ);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task OOBCMJILCEH(int DNCNBFLLNOA);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<BCMKODJOJFH> BAMHCECEPAH(HBAHGJJIJND IEPFCDMILLM);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate void AGLCIPKHOJL(int MNAACFOHONJ, int DNCNBFLLNOA, HBAHGJJIJND? IEPFCDMILLM);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface NADJFCAAKAN : FCGNCHFMIOK, CIGEKBDFKAO
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[Flags]
	public enum FPJMEBJCNIK
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	string JNHMGGJBGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	EKHLHFMOIJD JDKEDPKAEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	BHKAGDNLKEG LGJMBCALBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	string DLJNBAIKKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	byte DIDJLCPAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	int OBCKDKDLMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	int CAMLDOLKDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool HEHNJGJJAII
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool OBFHHMPCAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool KKBOCFIODPD
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool CEGLGAHMAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	bool GMPIBOJEIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	bool JMHCHCEHKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	bool IDILLCHHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHMCAMOMJOP<string> KDOAMFEGAGB();

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> GPHFEAEMCFE();

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FHMCAMOMJOP<bool> IsPlayerCommunicationRestricted(int MNAACFOHONJ);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string BHKIFMOBJOA(string HDNPPEBJPAE, bool OPFKKNBDOGD = true);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> OMJNPONOMBI(string HDNPPEBJPAE, bool OPFKKNBDOGD = true);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FHMCAMOMJOP<string> MakeRoomNameAdhereToPlatformRequirements(long DCONEHIDLCB, string HDNPPEBJPAE);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string KLGPHHLAHGM, FPJMEBJCNIK IKAKGDFEOJE = FPJMEBJCNIK.FilterProfanity | FPJMEBJCNIK.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string KLGPHHLAHGM, FPJMEBJCNIK IKAKGDFEOJE = FPJMEBJCNIK.FilterProfanity | FPJMEBJCNIK.FilterURL, bool PIBLOLLDAHJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string HDNPPEBJPAE, FPJMEBJCNIK IKAKGDFEOJE = FPJMEBJCNIK.FilterProfanity | FPJMEBJCNIK.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "23")]
	FHMCAMOMJOP<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface MLLCMCOGMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<GPFCJPHOJFA>> HGCLJOOLEKA([Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface EPNGJAJBPED
{
	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHIOBEPCHDI(byte[] GONCBGJFGEK, byte[] GOPJIIDCLND);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface BCPIAGHOHFG
{
	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HNDJHGEPNDL(string JGHNHKCGKGL);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface JDAFACNNIAD
{
	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	BBKKNBJGBDM<IGDGBKCBFBC> NFKKDOMNIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> LBEFFBIALMK(string FBJJAKHOMAK);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HNNPCBOINCI> HKIFKFPBOGO(string FBJJAKHOMAK, string MNAKJLHKPBO);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BPGMJNAMKLL(string FBJJAKHOMAK, IEnumerable<string> LGNKMHLOMGI, int GACAILCFNJI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<JMGMKEEJIFI<FilteredTextDTO>>> IKPFLFBKHPK(uint POLGGJPFHMN, IEnumerable<string> LGNKMHLOMGI);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface EJNBIOKABAL
{
	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MAILFGBCAPL([Out] bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBEANACGPIA([Out] bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PEOMOLPJMKE([Out] int CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFBBFAJKMJD([Out] bool CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum ENOJCFGMHMF
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum IICHKBMJHDO
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
public enum GILGMCEBMLB
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
public enum AHBOKCIFIFL
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
public enum IMJDBFFGBBM
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
public enum OKBIDJACGED
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
public interface PLMNPNIMMNE
{
	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int NPOLMJHPEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string CLEGBHEPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	string AIFAOIGBFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	string KHMBPEMNAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	string GGFJOPDKHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	string CBMOONDOLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	string IOLLOFANLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool MIGBNHMONMK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	bool NCNEEAACMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	GILGMCEBMLB CGNFLMEFLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	AHBOKCIFIFL GPOBAOPNEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	bool? PNAKGEIIJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NKHEDAJFGPC(bool NHDKIEJIGGP);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PBIHOBCPNAL(bool CNHHOIOPPPM);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface IBLNOABCJCM : PLMNPNIMMNE
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	string ELIDBLNBHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	string LCIDADADHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	DateTime? IOHFFGAOGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	ENOJCFGMHMF BEMEGJGBJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	int? FEPMBAIMLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	int CJAPEJIHGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	bool KGNHLIGAGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	bool KHCJPJJJDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	bool? KHCIIGIBHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CGLHAFLGCBG
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public PLMNPNIMMNE EIGALNCJENN
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public IICHKBMJHDO LBAFEONHOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(IICHKBMJHDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public string IINJBIEJODA
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x70C5920", Offset = "0x70C4D20", VA = "0x1870C5920")]
	public CGLHAFLGCBG(PLMNPNIMMNE ALKPHKOIMNL, IICHKBMJHDO NDJEGEEECGH, string DBOODGICJHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface AFNCNMLDLHE
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	int NPOLMJHPEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	bool FLCGAIILPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface OJEDKDDIHMD
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	int NPOLMJHPEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	bool INNOPNNIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface NKJKAOAENAK
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	int NPOLMJHPEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	string KKPBAAHINDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum LHBKFFHMLKB
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class OIMCNOBFPAM
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public LHBKFFHMLKB DFOHLLFJCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(LHBKFFHMLKB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public string EGFFHIKHDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public EBJFCGJIDIH GPADKJEJPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(EBJFCGJIDIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string ENNHPHJIPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public int EEKLKEKCBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool LELLNFHPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xF79120", Offset = "0xF78520", VA = "0x180F79120")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xF78A80", Offset = "0xF77E80", VA = "0x180F78A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public PBBHALCOHCB HJILKPFKOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x151E3F0", Offset = "0x151D7F0", VA = "0x18151E3F0")]
		[CompilerGenerated]
		get
		{
			return default(PBBHALCOHCB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x773D660", Offset = "0x773CA60", VA = "0x18773D660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public FGBKOBFMFHG NCPKCJPHFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1BF7A80", Offset = "0x1BF6E80", VA = "0x181BF7A80")]
		[CompilerGenerated]
		get
		{
			return default(FGBKOBFMFHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4FA20F0", Offset = "0x4FA14F0", VA = "0x184FA20F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string JPPHJNOHNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9B0", Offset = "0xA7BDB0", VA = "0x180A7C9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x52AED30", Offset = "0x52AE130", VA = "0x1852AED30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x773D680", Offset = "0x773CA80", VA = "0x18773D680")]
	internal OIMCNOBFPAM(HOBPLKPEHDG AIOJGFJOJFD, IDLEGOLOPCF MEBEADNNHCH, PNAAMOOFGFL MHOGLOHJNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x773D8E0", Offset = "0x773CCE0", VA = "0x18773D8E0")]
	public OIMCNOBFPAM(LHBKFFHMLKB MIJNMIIDJNM = LHBKFFHMLKB.Outfit, [Optional] PBBHALCOHCB BFGAHAJBIBM, [Optional] string IEFGJLNKNBK, [Optional] string GGNOKCHEJFE, EBJFCGJIDIH OALOIONAGKI = EBJFCGJIDIH.Common, [Optional] string HIAGIONPPCF, int JCGHBPGKAOE = 0, bool LDAICLNFACL = false, [Optional] string OBKFCFMCGJP, [Optional] DateTime? PCGHPDOLFBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[EIJCMKCDLED]
public class HOBPLKPEHDG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public LHBKFFHMLKB DFOHLLFJCDN
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(LHBKFFHMLKB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	[DataMember(Name = "AvatarItemDesc")]
	public string GHLDGMCIKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string EGFFHIKHDPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public EBJFCGJIDIH GPADKJEJPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDA0", Offset = "0xA7B1A0", VA = "0x180A7BDA0")]
		[CompilerGenerated]
		get
		{
			return default(EBJFCGJIDIH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA10", Offset = "0xA7AE10", VA = "0x180A7BA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string ENNHPHJIPFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int EEKLKEKCBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CE0", Offset = "0xAD80E0", VA = "0x180AD8CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool LELLNFHPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x19341E0", Offset = "0x19335E0", VA = "0x1819341E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x19457A0", Offset = "0x1944BA0", VA = "0x1819457A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public string IBNOKFFNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xF78A90", Offset = "0xF77E90", VA = "0x180F78A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HOBPLKPEHDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[EIJCMKCDLED]
public sealed class LEHPMEMCKGA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public List<string> IHNJIFOHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x773AEB0", Offset = "0x773A2B0", VA = "0x18773AEB0")]
	public LEHPMEMCKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public LEHPMEMCKGA(List<string> HDIKJCHNEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[EIJCMKCDLED]
public class AJLEDLHBFNL : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public GIJLGKMEKCB BPFKEFCHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public CFKAINIMPAM HDPJAGLFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AJLEDLHBFNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public AJLEDLHBFNL(GIJLGKMEKCB LLBLAOMNHKO, CFKAINIMPAM CNLFOFKFPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum EJEEDGPCGGD
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum ACHAJDFNHOP : byte
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
[EIJCMKCDLED]
public class GIJLGKMEKCB : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public EJEEDGPCGGD GMMNBEIEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(EJEEDGPCGGD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public ACHAJDFNHOP? BJFOOJEPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x31A83D0", Offset = "0x31A77D0", VA = "0x1831A83D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x75C9650", Offset = "0x75C8A50", VA = "0x1875C9650")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool LMGBIFPLKNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x20309F0", Offset = "0x202FDF0", VA = "0x1820309F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2030A10", Offset = "0x202FE10", VA = "0x182030A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7736930", Offset = "0x7735D30", VA = "0x187736930")]
	public GIJLGKMEKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x77368A0", Offset = "0x7735CA0", VA = "0x1877368A0")]
	public GIJLGKMEKCB(EJEEDGPCGGD NJONFCIHOHO, ACHAJDFNHOP IJLEEKLKNLA, bool BDHCFOAFCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[EIJCMKCDLED]
public class CFKAINIMPAM : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public string LKCJKGBOBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public string LCNHDEKAFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CFKAINIMPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public CFKAINIMPAM(string JECEHPIFAPF, string GPILFHNJIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum EKHLHFMOIJD
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
public struct PGONCLBKNNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public KGCPCHPAGKE GCKBDDAIGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public bool CGAFMJHDDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool NDDIDPAMMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public bool FJKKGEJHCPE;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[EIJCMKCDLED]
public class KGCPCHPAGKE : JPGLNCIFIDA, EODJFKKINLJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct HCHBHCNAKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public KGCPCHPAGKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7736C40", Offset = "0x7736040", VA = "0x187736C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7736DD0", Offset = "0x77361D0", VA = "0x187736DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal static Action<KGCPCHPAGKE> LOFEMILPDLM;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal static Func<KGCPCHPAGKE, Task> BALLLIIGIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[IgnoreDataMember]
	public bool FDHAAJPHPGI;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public long? NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public int MEGGFBBKPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public int? CFFEICFONLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x13852D0", Offset = "0x13846D0", VA = "0x1813852D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x10509D0", Offset = "0x104FDD0", VA = "0x1810509D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public string PGAICCMNNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public LHBKFFHMLKB? DFOHLLFJCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA7B820", Offset = "0xA7AC20", VA = "0x180A7B820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	[DataMember(Name = "AvatarItemDesc")]
	public string MFEMBNFNCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Guid? CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7737500", Offset = "0x7736900", VA = "0x187737500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x77374C0", Offset = "0x77368C0", VA = "0x1877374C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public string HHJOOFLGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public string FBCGDGJOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA70240", Offset = "0xA6F640", VA = "0x180A70240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public LPMAKBILGPG CCNNBBBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA96380", Offset = "0xA95780", VA = "0x180A96380")]
		[CompilerGenerated]
		get
		{
			return default(LPMAKBILGPG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1580E90", Offset = "0x1580290", VA = "0x181580E90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public int KFBIGKPKPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA963E0", Offset = "0xA957E0", VA = "0x180A963E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1581680", Offset = "0x1580A80", VA = "0x181581680")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public int BDDLKEDCANI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xAD9060", Offset = "0xAD8460", VA = "0x180AD9060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x15C2F70", Offset = "0x15C2370", VA = "0x1815C2F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public PGIDFLAKNGN DJACKLFPKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xAD9090", Offset = "0xAD8490", VA = "0x180AD9090")]
		[CompilerGenerated]
		get
		{
			return default(PGIDFLAKNGN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x15C2410", Offset = "0x15C1810", VA = "0x1815C2410")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public EBJFCGJIDIH BJNMIMPLFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xD2A380", Offset = "0xD29780", VA = "0x180D2A380")]
		[CompilerGenerated]
		get
		{
			return default(EBJFCGJIDIH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1599030", Offset = "0x1598430", VA = "0x181599030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	[DataMember(Name = "Message")]
	public string NMKDEMIOJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7C810", Offset = "0xA7BC10", VA = "0x180A7C810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public string FBAJHIDNKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xB1ECE0", Offset = "0xB1E0E0", VA = "0x180B1ECE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool GDJHHAFGGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xF78D00", Offset = "0xF78100", VA = "0x180F78D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xF78AA0", Offset = "0xF77EA0", VA = "0x180F78AA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public BHKAGDNLKEG LGJMBCALBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xF001B0", Offset = "0xEFF5B0", VA = "0x180F001B0")]
		[CompilerGenerated]
		get
		{
			return default(BHKAGDNLKEG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xEFE840", Offset = "0xEFDC40", VA = "0x180EFE840")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public IMFBMEFPKNK HBPBIKMBMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8D0", Offset = "0xA7BCD0", VA = "0x180A7C8D0")]
		[CompilerGenerated]
		get
		{
			return default(IMFBMEFPKNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA7C880", Offset = "0xA7BC80", VA = "0x180A7C880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public LPGACNHIPAP? GNDNEKCEOED
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x14AAB10", Offset = "0x14A9F10", VA = "0x1814AAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x773A6F0", Offset = "0x7739AF0", VA = "0x18773A6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool OOMHDPCOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x773A720", Offset = "0x7739B20", VA = "0x18773A720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool MLNAFHFFEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x773A700", Offset = "0x7739B00", VA = "0x18773A700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool OKLHBGIPJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x773A790", Offset = "0x7739B90", VA = "0x18773A790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	[IgnoreDataMember]
	public bool BJMHGANLMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA71480", Offset = "0xA70880", VA = "0x180A71480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA71490", Offset = "0xA70890", VA = "0x180A71490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	[IgnoreDataMember]
	public bool JDPJAANKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E2F1B0", Offset = "0x2E2E5B0", VA = "0x182E2F1B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E2EEF0", Offset = "0x2E2E2F0", VA = "0x182E2EEF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	[IgnoreDataMember]
	public string KDDHGFOMKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xB1ED30", Offset = "0xB1E130", VA = "0x180B1ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xB1F130", Offset = "0xB1E530", VA = "0x180B1F130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	[IgnoreDataMember]
	public string COIHPPBDMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xE7BEF0", Offset = "0xE7B2F0", VA = "0x180E7BEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xE7BF00", Offset = "0xE7B300", VA = "0x180E7BF00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	[IgnoreDataMember]
	public bool CMAOJPLDJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x1073BA0", Offset = "0x1072FA0", VA = "0x181073BA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xD128C0", Offset = "0xD11CC0", VA = "0x180D128C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x773A7B0", Offset = "0x7739BB0", VA = "0x18773A7B0", Slot = "5")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x773A620", Offset = "0x7739A20", VA = "0x18773A620", Slot = "6")]
	[AsyncStateMachine(typeof(HCHBHCNAKFL))]
	public virtual Task CLBBHINLKGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x15C2410", Offset = "0x15C1810", VA = "0x1815C2410")]
	public void CGBOLJGBJNC(PGIDFLAKNGN HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KGCPCHPAGKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface OIBNPFLCFNB
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	long PPHONLPHPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string HDGKGJBCJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	int ODBIOPINCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	string HPLABJDEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	string POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	byte GFHJCFCIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	int CEKMLLNOAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int ECPHBNBMIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	POKGCAJLAGP OIFIHHJMGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	bool FCIGCNAKAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	DateTime PGKBDGCPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	DateTime? MNGMJCMLPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	long? NPDPDCENHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	int DLKAGACDPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	int MBIEIAHPGOB
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	int DFBEDNAFJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	APEIBEALMAP DBACDEKABAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	APEIBEALMAP KBKLBEHMJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool FCANBCPGGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	bool LDBLCJOGPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	bool NKPFPHKCOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	bool EFJOFMKDDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int? IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool JGKKNIMACNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	string NBHGJHENBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEGICMNGDJN();

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPOGIFFCKDF();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[EIJCMKCDLED]
public class BHEFEOCEOJC : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public List<IBEMBLNCLJE> PANODMBOAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x77333F0", Offset = "0x77327F0", VA = "0x1877333F0")]
	public List<string> IAOINIMLALJ(params IOLKEAPEMPA[] BCLJEOMDIIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7733370", Offset = "0x7732770", VA = "0x187733370")]
	public List<string> BEEFMMFFGEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x77335B0", Offset = "0x77329B0", VA = "0x1877335B0")]
	public List<string> MKFPKEODOAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7733600", Offset = "0x7732A00", VA = "0x187733600", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BHEFEOCEOJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[EIJCMKCDLED]
public class OAJOLCIBNJN : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int ODBIOPINCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OAJOLCIBNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[EIJCMKCDLED]
public class FCMEAAEACLH : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public long PPHONLPHPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public string HDGKGJBCJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int HMFLKKGPGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool MOJDOJALBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xE55AB0", Offset = "0xE54EB0", VA = "0x180E55AB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xE55AC0", Offset = "0xE54EC0", VA = "0x180E55AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int IJNBEPCEHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int EPONHGNCMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xABF670", Offset = "0xABEA70", VA = "0x180ABF670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1646810", Offset = "0x1645C10", VA = "0x181646810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public int NCNHMNNHCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDA0", Offset = "0xA7B1A0", VA = "0x180A7BDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA10", Offset = "0xA7AE10", VA = "0x180A7BA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int PALAIFJGALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xAAF120", Offset = "0xAAE520", VA = "0x180AAF120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xAAE260", Offset = "0xAAD660", VA = "0x180AAE260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public string MIPCKKAFHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public string GMHKNDMJOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1394000", Offset = "0x1393400", VA = "0x181394000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public POKGCAJLAGP? HGHHBHNIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xF78A90", Offset = "0xF77E90", VA = "0x180F78A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public IReadOnlyList<Guid> HIDKNNPMLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public APAGCNALJKL ELAKGGPFMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x77350B0", Offset = "0x77344B0", VA = "0x1877350B0")]
		get
		{
			return default(APAGCNALJKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7735100", Offset = "0x7734500", VA = "0x187735100", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7735370", Offset = "0x7734770", VA = "0x187735370")]
	public bool HELOPPPCEGA(FCMEAAEACLH EAGHDKDLMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7735190", Offset = "0x7734590", VA = "0x187735190")]
	private bool GJAKDGPEFCL(FCMEAAEACLH EAGHDKDLMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7735380", Offset = "0x7734780", VA = "0x187735380")]
	private static bool OKBFGBBICJB(IReadOnlyList<Guid> IPEJMADOCCH, IReadOnlyList<Guid> FHMGKHMOKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B140", Offset = "0x2A7A540", VA = "0x182A7B140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FCMEAAEACLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[EIJCMKCDLED]
public class PDCHLPLOIPF : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public int PAMPGBNKOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PDCHLPLOIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[EIJCMKCDLED]
public class HNHGJPGKFDI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool LAHOPOJGMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HNHGJPGKFDI()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[EIJCMKCDLED]
	public class NewInventionRequestDTO : EODJFKKINLJ
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
		public JPNNICBILFM creatorAccountRole;

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

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1031880", Offset = "0x1030C80", VA = "0x181031880", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x773C8F0", Offset = "0x773BCF0", VA = "0x18773C8F0")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[EIJCMKCDLED]
	public class AddVersionInventionRequestDTO : EODJFKKINLJ
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

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1031880", Offset = "0x1030C80", VA = "0x181031880", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x77331D0", Offset = "0x77325D0", VA = "0x1877331D0")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[EIJCMKCDLED]
	public class ModifyTagsRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[EIJCMKCDLED]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[EIJCMKCDLED]
	public class ReportRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public LNMFMMOAECP ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[EIJCMKCDLED]
	public class CheerRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[EIJCMKCDLED]
	public class UpdatePriceRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[EIJCMKCDLED]
	public class UpdateInventionMetadataRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1031880", Offset = "0x1030C80", VA = "0x181031880", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[EIJCMKCDLED]
	public class UpdateInventionGeneralPermissionRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public APEIBEALMAP Permission
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(APEIBEALMAP);
			}
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[EIJCMKCDLED]
	public class PublishInventionRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public APEIBEALMAP Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(APEIBEALMAP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public POKGCAJLAGP Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
			[CompilerGenerated]
			get
			{
				return default(POKGCAJLAGP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[EIJCMKCDLED]
	public class UnpublishInventionRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[EIJCMKCDLED]
	public class DeleteInventionRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[EIJCMKCDLED]
	public class SetInventionVersionAccessibilityRequest : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public POKGCAJLAGP NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
			[CompilerGenerated]
			get
			{
				return default(POKGCAJLAGP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[EIJCMKCDLED]
	public class SpecialTags : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum NFABAKPEPJA
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
public enum LNMFMMOAECP
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
public enum DEHPEENGDIB
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface JHEFDODHEKH
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	BHKAGDNLKEG LGJMBCALBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	string DLJNBAIKKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	int NPOLMJHPEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	DateTime BMHBCAPNMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool AIIAKODGELL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string JOKHKMGOGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	PLMNPNIMMNE EIGALNCJENN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void POEGDHEICKD();

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HCOPFNMPADJ(PLMNPNIMMNE ALKPHKOIMNL);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface MAEIHHMNHOK
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	string PFJJNLGCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	bool DAGGIFNCLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void POEGDHEICKD();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct GKNPMBBKGOL
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public POJOCMKHHND EBPGGHOMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		[CompilerGenerated]
		readonly get
		{
			return default(POJOCMKHHND);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public MAEIHHMNHOK JBIICJNODKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5D30", VA = "0x180AF6930")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xED8D20", Offset = "0xED8120", VA = "0x180ED8D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public string KEKLMBHDMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6157710", Offset = "0x6156B10", VA = "0x186157710")]
	public GKNPMBBKGOL(POJOCMKHHND CHLOFLMLPBP, [Optional] MAEIHHMNHOK FHKGJGINHKL, [Optional] string CEOOAGCPOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum POJOCMKHHND
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
[EIJCMKCDLED]
public class NILDBLPGAJG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string KDEFLKPGCHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string MHDGDGOJBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string EAOJAKGNFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string PDCDGHFKDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public List<JDALMENHMNK> KINBAMGAJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NILDBLPGAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE740", Offset = "0x4EEDB40", VA = "0x184EEE740")]
	public NILDBLPGAJG([Optional] string EHPHANJCNCI, [Optional] string DLKPFOFOMAN, [Optional] string LCIINDJLEEC, [Optional] string PDAENJHICPI, [Optional] List<JDALMENHMNK> CPICAGAMMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[EIJCMKCDLED]
public class JDALMENHMNK : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public string PFGADJPBBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public string PDCDGHFKDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JDALMENHMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[EIJCMKCDLED]
public class NPCAMOJHMBH : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public string MHDGDGOJBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string EBPGGHOMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public string KDEFLKPGCHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public List<string> BCJMMAKGFID
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NPCAMOJHMBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[EIJCMKCDLED]
public interface EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POEGDHEICKD();
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[EIJCMKCDLED]
public interface JPGLNCIFIDA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CLBBHINLKGP();
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DGOPKGIKBOF]
public interface GDNDDINAKDK : EODJFKKINLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[EIJCMKCDLED]
public class EEPNMBMKPKK : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public int KCAKJCBNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public string PBBMKHLEHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public string BGDANBBDICC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EEPNMBMKPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x7734A80", Offset = "0x7733E80", VA = "0x187734A80")]
	public EEPNMBMKPKK([Optional] Guid NPMPEIAPAOF, int FBBAOHEBJDH = 0, [Optional] string LLMEEHPGIMI, [Optional] string DAGBBBHOPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[EIJCMKCDLED]
public class HBAHGJJIJND : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public const int GNCCBCEHFGE = 0;

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public long EJCKAFCKDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public ICAGGCEOOAB IJKPNMAMODO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public string OPCFHJFENJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public List<EEPNMBMKPKK> MGDOHGGNPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public int MHAKBAFPMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDA0", Offset = "0xA7B1A0", VA = "0x180A7BDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA10", Offset = "0xA7AE10", VA = "0x180A7BA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public POKGCAJLAGP OIFIHHJMGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
		[CompilerGenerated]
		get
		{
			return default(POKGCAJLAGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CE0", Offset = "0xAD80E0", VA = "0x180AD8CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string PJHMFKCGFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public bool EHDJMHANBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x20B8840", Offset = "0x20B7C40", VA = "0x1820B8840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7736A90", Offset = "0x7735E90", VA = "0x187736A90")]
	public HBAHGJJIJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7736B20", Offset = "0x7735F20", VA = "0x187736B20")]
	public HBAHGJJIJND(long AHACJPDCGOK = 0L, [Optional] ICAGGCEOOAB HGCPONKEBHK, [Optional] string KOJFKNGJJIL, [Optional] List<EEPNMBMKPKK> AICGEPFLEKK, int DNCNBFLLNOA = 0, [Optional] string HDNPPEBJPAE, POKGCAJLAGP LGGIEAFHOLJ = POKGCAJLAGP.Private, [Optional] string MEMPINOLJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class OKJPEBPHEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public readonly int NPOLMJHPEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public readonly HBAHGJJIJND LGOABPPEPCN;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x102F000", Offset = "0x102E400", VA = "0x18102F000")]
	public OKJPEBPHEFO(int MNAACFOHONJ, HBAHGJJIJND IEPFCDMILLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[EIJCMKCDLED]
public class ICAGGCEOOAB : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public string HFHOCFNJMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public string NJGPKFHBFIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public string DICAKIGMEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public string GAOLGCIPKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public string DEPINCJDAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public string MGDOHGGNPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7737890", Offset = "0x7736C90", VA = "0x187737890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ICAGGCEOOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE740", Offset = "0x4EEDB40", VA = "0x184EEE740")]
	public ICAGGCEOOAB([Optional] string GMCDKABHGNA, [Optional] string OIBKAFPDOIM, [Optional] string GGDMCMCCLKK, [Optional] string KDLGBEPEAHI, [Optional] string KDDELBIKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[EIJCMKCDLED]
public class FKIDMMLEHBG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public Dictionary<int, HBAHGJJIJND> AKDAFJPDODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FKIDMMLEHBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[EIJCMKCDLED]
public class DNBJIJICILC : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public List<int> IMPFANBPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public byte? DIDJLCPAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x31ADEF0", Offset = "0x31AD2F0", VA = "0x1831ADEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x31ADE80", Offset = "0x31AD280", VA = "0x1831ADE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public int? OBCKDKDLMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x13852C0", Offset = "0x13846C0", VA = "0x1813852C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x13852F0", Offset = "0x13846F0", VA = "0x1813852F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DNBJIJICILC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class FFGEEFEDPAK
{
	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7735420", Offset = "0x7734820", VA = "0x187735420")]
	public static AMMBECAJBIA FOAEGKDIHFF(this EEPNMBMKPKK DMFKPMONDPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[Flags]
public enum IMFBMEFPKNK
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum BHKAGDNLKEG
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[EIJCMKCDLED]
public class JLMIOOMANME : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	[DataMember(Name = "PlayerId")]
	public int NPOLMJHPEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public int HJLKMMJPKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xB508B0", Offset = "0xB4FCB0", VA = "0x180B508B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int JANDBMMNPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JLMIOOMANME()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[EIJCMKCDLED]
	public class ProgressionEventRecordDTO : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public int NPOLMJHPEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public int BDDLKEDCANI
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xB508B0", Offset = "0xB4FCB0", VA = "0x180B508B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public int OKJDGALILOL
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public int NIHPLMPLIHF
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int NMKHKBEPLEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public DateTime? PODGLKIFAJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x13E0010", Offset = "0x13DF410", VA = "0x1813E0010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x1518150", Offset = "0x1517550", VA = "0x181518150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public int KLFFPPEJEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x773E5F0", Offset = "0x773D9F0", VA = "0x18773E5F0")]
		public ProgressionEventRecordDTO(int MNAACFOHONJ = 0, int GAIKFCCAPFK = 0, int OBKDIKPLIKM = 0, int GDJIJAFBDHO = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[EIJCMKCDLED]
	public class ProgressionEventDTO : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public long BFEAIPLDPAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public List<ProgressionEventRewardDTO> GDOPAKAFCEB
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public List<KeepsakeRoomListDTO> CJMBHNHGMLK
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public DateTime CCCCNFBIIMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA70450", Offset = "0xA6F850", VA = "0x180A70450")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public DateTime JHLPLEDKNHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA7B820", Offset = "0xA7AC20", VA = "0x180A7B820")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public DateTime GFCAMLJOIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xF78720", Offset = "0xF77B20", VA = "0x180F78720")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public bool ADAGHOLONAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xD315F0", Offset = "0xD309F0", VA = "0x180D315F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xD58890", Offset = "0xD57C90", VA = "0x180D58890")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public int AGFAGOJMBPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x146C6F0", Offset = "0x146BAF0", VA = "0x18146C6F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x22C4FD0", Offset = "0x22C43D0", VA = "0x1822C4FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public float KNEFBAFJHPO
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x1246850", Offset = "0x1245C50", VA = "0x181246850")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x1419100", Offset = "0x1418500", VA = "0x181419100")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public Guid? HLCCGLIKBKE
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x773E510", Offset = "0x773D910", VA = "0x18773E510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x773E530", Offset = "0x773D930", VA = "0x18773E530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public string GFEHHKGJFLC
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA70240", Offset = "0xA6F640", VA = "0x180A70240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public string OEENMCAOINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xA70170", Offset = "0xA6F570", VA = "0x180A70170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public string CGDIOOLKOGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xA7C8A0", Offset = "0xA7BCA0", VA = "0x180A7C8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9A0", Offset = "0xA7BDA0", VA = "0x180A7C9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public string GKKJECNPCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9B0", Offset = "0xA7BDB0", VA = "0x180A7C9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x773E540", Offset = "0x773D940", VA = "0x18773E540")]
		public ProgressionEventDTO(long JAMKCCNJKDH = 0L, [Optional] string HDNPPEBJPAE, [Optional] List<ProgressionEventRewardDTO> FODLJEJDCPH, [Optional] List<KeepsakeRoomListDTO> KGILFCGDHLK, [Optional] DateTime PJLONFPDOGE, [Optional] DateTime GMKLOKOGGIC, [Optional] DateTime EMBLFIKBBBG, bool CBMGJJCDOHI = false, int IIEJFFHDNLH = 0, float PKOJIGAGPNH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[EIJCMKCDLED]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long FENNCGPPOKL
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public long BFEAIPLDPAG
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public int? HBBHEALKFKE
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public int? GMBFEDBKDOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xA703A0", Offset = "0xA6F7A0", VA = "0x180A703A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public long? HIKEPELNOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xF1DE10", Offset = "0xF1D210", VA = "0x180F1DE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xF1DA50", Offset = "0xF1CE50", VA = "0x180F1DA50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public long CNGENPLDFNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xF78720", Offset = "0xF77B20", VA = "0x180F78720")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public TimeSpan EEGHFEPFEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x773AAB0", Offset = "0x7739EB0", VA = "0x18773AAB0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public long IHCMPFDDHCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x1394000", Offset = "0x1393400", VA = "0x181394000")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public TimeSpan BIIGNCDEECC
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x773AB00", Offset = "0x7739F00", VA = "0x18773AB00")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int EECFDCGGCGK
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xE6F700", Offset = "0xE6EB00", VA = "0x180E6F700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xFB5540", Offset = "0xFB4940", VA = "0x180FB5540")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public CFEADMJDODF BGOLBIGAMMB
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x12C9B60", Offset = "0x12C8F60", VA = "0x1812C9B60")]
			[CompilerGenerated]
			get
			{
				return default(CFEADMJDODF);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x249C2A0", Offset = "0x249B6A0", VA = "0x18249C2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public List<KeepsakeRoomDTO> ECMPNGBHLML
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x773AB50", Offset = "0x7739F50", VA = "0x18773AB50")]
		public KeepsakeRoomListDTO(long KBKINMPLJNM = 0L, long JAMKCCNJKDH = 0L, [Optional] int? CNFNDKMGEGP, [Optional] int? KJCNMIBMDIC, [Optional] long? BPHAIAFAAJN, long AINIILLHKJA = 0L, long FEAEMEGFNNH = 0L, int FFCANKOIIID = 0, CFEADMJDODF GLDCJNFPFBO = CFEADMJDODF.Standard, [Optional] List<KeepsakeRoomDTO> FNIOEKOBAGK)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[EIJCMKCDLED]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public long FADIDKFHAAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public long NMJFOBHOBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public long FENNCGPPOKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public CFEADMJDODF GBFFBDIJNIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
			[CompilerGenerated]
			get
			{
				return default(CFEADMJDODF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public int PFAOFEIDEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xABF670", Offset = "0xABEA70", VA = "0x180ABF670")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x1646810", Offset = "0x1645C10", VA = "0x181646810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x773AA50", Offset = "0x7739E50", VA = "0x18773AA50")]
		public KeepsakeRoomDTO(long FCCINKFCHPK = 0L, long DCONEHIDLCB = 0L, long KBKINMPLJNM = 0L, CFEADMJDODF IIHAKBEOLJD = CFEADMJDODF.Standard, int ANNGKNJEELJ = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[EIJCMKCDLED]
	public class ProgressionEventRewardDTO : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public long NLHLENCDEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public int EJLCNPCEEOK
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public string POEEFANCFBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public int BDDLKEDCANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public int LELPCOICMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xABF670", Offset = "0xABEA70", VA = "0x180ABF670")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x1646810", Offset = "0x1645C10", VA = "0x181646810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public bool NOPPECMCHOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public bool OBJMJNKJKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xF1B7F0", Offset = "0xF1ABF0", VA = "0x180F1B7F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x158DBB0", Offset = "0x158CFB0", VA = "0x18158DBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[EIJCMKCDLED]
	public class ProgressionEventPurchasableXpBoostDTO : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public Guid OBDFBAJIHDC
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public int NGJGIDJGOCB
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public int POPAKBDJNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public int PMLBAADENFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public long PCCPDNJFOGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xA70450", Offset = "0xA6F850", VA = "0x180A70450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public long CMKFJNAEMGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0xA7B820", Offset = "0xA7AC20", VA = "0x180A7B820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public enum CFEADMJDODF
{
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum IJIHCOGNCDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[EIJCMKCDLED]
public class GPFCJPHOJFA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	public string JNADOBLDKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public string? HGPLLNICEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GPFCJPHOJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface HFCBDPJJDFA
{
	[Cpp2IlInjected.Token(Token = "0x17000200")]
	bool KMAEPPNCJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	string? BAINEHDIEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	string? NEMGOFMLGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface BNPKKEFIOKG<T> : HFCBDPJJDFA
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class OLJAIAIHAIC
{
	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA490", Offset = "0x3EB9890", VA = "0x183EBA490")]
	public static BNPKKEFIOKG<T> MDOMHAEDEOM<T, U>(this BNPKKEFIOKG<U> HJBCDFKDKBA, Func<U, T> LOJAEGKDDLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct LHMKLFJBFJH<T> : BNPKKEFIOKG<T>, HFCBDPJJDFA
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public bool KMAEPPNCJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x105C9D0", Offset = "0x105BDD0", VA = "0x18105C9D0", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA490", Offset = "0x2CE9890", VA = "0x182CEA490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public string? BAINEHDIEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5D30", VA = "0x180AF6930", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xED8D20", Offset = "0xED8120", VA = "0x180ED8D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public string? NEMGOFMLGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x550CA90", Offset = "0x550BE90", VA = "0x18550CA90")]
	public static LHMKLFJBFJH<T> CEBBIFMPJFI(T CBMEHPPMEEA)
	{
		return default(LHMKLFJBFJH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x550CB30", Offset = "0x550BF30", VA = "0x18550CB30")]
	public static LHMKLFJBFJH<T> FCAOJPMMNKF(string FKPCAPOIAIK, string LPHGLKBFDFK = "")
	{
		return default(LHMKLFJBFJH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[EIJCMKCDLED]
public class BCMKODJOJFH : HFCBDPJJDFA, EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public bool KMAEPPNCJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public string? BAINEHDIEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	[DataMember(Name = "error_id")]
	public string? NEMGOFMLGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	public virtual void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x7733270", Offset = "0x7732670", VA = "0x187733270")]
	public static BCMKODJOJFH CEBBIFMPJFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x77332E0", Offset = "0x77326E0", VA = "0x1877332E0")]
	public static BCMKODJOJFH FCAOJPMMNKF(string FKPCAPOIAIK, string LPHGLKBFDFK = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BCMKODJOJFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[IOEFKGDICCL]
public abstract class CMGFICFIMPK<T> : BCMKODJOJFH, BNPKKEFIOKG<T>, HFCBDPJJDFA
{
	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	public T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	protected CMGFICFIMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[IOEFKGDICCL]
public class PJDAEOIHJBA<T> : CMGFICFIMPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB0C0", Offset = "0x5ACA4C0", VA = "0x185ACB0C0")]
	private static void DGPPDLHAPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x44ECB20", Offset = "0x44EBF20", VA = "0x1844ECB20")]
	public PJDAEOIHJBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[IOEFKGDICCL]
public class JMGMKEEJIFI<T> : CMGFICFIMPK<T>, JPGLNCIFIDA, EODJFKKINLJ where T : EODJFKKINLJ, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct GJIINNBOIIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public JMGMKEEJIFI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F5B080", Offset = "0x4F5A480", VA = "0x184F5B080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F5B280", Offset = "0x4F5A680", VA = "0x184F5B280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5376C70", Offset = "0x5376070", VA = "0x185376C70", Slot = "8")]
	public override void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x5376A60", Offset = "0x5375E60", VA = "0x185376A60", Slot = "10")]
	[AsyncStateMachine(typeof(JMGMKEEJIFI<>.GJIINNBOIIN))]
	public Task CLBBHINLKGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x5376930", Offset = "0x5375D30", VA = "0x185376930")]
	public static JMGMKEEJIFI<T> CEBBIFMPJFI(T CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5376B30", Offset = "0x5375F30", VA = "0x185376B30")]
	public new static JMGMKEEJIFI<T> FCAOJPMMNKF(string FKPCAPOIAIK, string LPHGLKBFDFK = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
	public JMGMKEEJIFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[IOEFKGDICCL]
public class JODLFPEPOEO<T> : CMGFICFIMPK<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x44ECB20", Offset = "0x44EBF20", VA = "0x1844ECB20")]
	public JODLFPEPOEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[IOEFKGDICCL]
public class CIFABGJDNDB<T> : CMGFICFIMPK<List<T>>, JPGLNCIFIDA, EODJFKKINLJ where T : EODJFKKINLJ, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct MDNMMMMBBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CIFABGJDNDB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x576CA40", Offset = "0x576BE40", VA = "0x18576CA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x576CC40", Offset = "0x576C040", VA = "0x18576CC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D76490", Offset = "0x6D75890", VA = "0x186D76490")]
	public static CIFABGJDNDB<T> CEBBIFMPJFI(List<T> CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D76680", Offset = "0x6D75A80", VA = "0x186D76680")]
	public new static CIFABGJDNDB<T> FCAOJPMMNKF(string FKPCAPOIAIK, string LPHGLKBFDFK = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D767C0", Offset = "0x6D75BC0", VA = "0x186D767C0", Slot = "8")]
	public override void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D765B0", Offset = "0x6D759B0", VA = "0x186D765B0", Slot = "10")]
	[AsyncStateMachine(typeof(CIFABGJDNDB<>.MDNMMMMBBJG))]
	public Task CLBBHINLKGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x53D4360", Offset = "0x53D3760", VA = "0x1853D4360")]
	public CIFABGJDNDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum HLLLLOOAEGO
{
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class NIEFFDKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x773C870", Offset = "0x773BC70", VA = "0x18773C870")]
	public static bool FEHLAJHADAO(this HLLLLOOAEGO KNNNGIFKPIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x773C870", Offset = "0x773BC70", VA = "0x18773C870")]
	public static bool ELMFIBKBIEK(this HLLLLOOAEGO KNNNGIFKPIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum LPMAKBILGPG
{
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	ProgressionEvent = 400,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	RoomieCredits = 500
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum LPGACNHIPAP
{
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	NonPurchasedEarnedByP2Pv2 = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	RoomieEnergyPack = 1101
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum PGIDFLAKNGN
{
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public enum EBJFCGJIDIH
{
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public enum LIKLNMJLDJD
{
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[EIJCMKCDLED]
	public class BalanceResponseDTO : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public LPMAKBILGPG CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(LPMAKBILGPG);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		[DataMember(Name = "Platform")]
		public LPGACNHIPAP BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
			[CompilerGenerated]
			get
			{
				return default(LPGACNHIPAP);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public virtual void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[EIJCMKCDLED]
	public class FilteredTextDTO : EODJFKKINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public string PFJJNLGCEHI
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public int INCDHCEACIA
		{
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[EIJCMKCDLED]
public class AKHCOJAACHG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public string CIEDPLDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string LBCCBEPMCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AKHCOJAACHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[EIJCMKCDLED]
public class HNNPCBOINCI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public List<AKHCOJAACHG> FIPAPMCGOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HNNPCBOINCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[EIJCMKCDLED]
public class LBHJJEFBMHJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public string KAEKCONJMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public LBHJJEFBMHJ(string DEKGJHOIGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[EIJCMKCDLED]
public class GKJMODLMCEE : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public List<AKHCOJAACHG> FIPAPMCGOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GKJMODLMCEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[EIJCMKCDLED]
public class OEDMKFJHHIF : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public List<LBHJJEFBMHJ> OLODPDLBOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public string DAKGPOOCGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public bool KBDIPINBEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public int NKJMFMHBBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OEDMKFJHHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x773D200", Offset = "0x773C600", VA = "0x18773D200")]
	public OEDMKFJHHIF(string FBJJAKHOMAK, List<LBHJJEFBMHJ> LGNKMHLOMGI, bool JOHIHEPFCEN, int GACAILCFNJI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[EIJCMKCDLED]
public class CFFOBJCGPMB : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public List<GKJMODLMCEE> ELNNIHDHBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public bool KBDIPINBEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CFFOBJCGPMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[EIJCMKCDLED]
public class IGDGBKCBFBC : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public enum NFGNFICDEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public const string NLFDOMFMLAG = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public string DAKGPOOCGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public NFGNFICDEIJ EBPGGHOMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(NFGNFICDEIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x77379D0", Offset = "0x7736DD0", VA = "0x1877379D0")]
	public IGDGBKCBFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x77379E0", Offset = "0x7736DE0", VA = "0x1877379E0")]
	public IGDGBKCBFBC(string FBJJAKHOMAK, NFGNFICDEIJ CHLOFLMLPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[EIJCMKCDLED]
public class DFOAPDGBDCH : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public bool PKANNOIOGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DFOAPDGBDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class NOHGPJINMCJ
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public enum JMGKKLIOJLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[EIJCMKCDLED]
public class JHLBIAGAANP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public long NMJFOBHOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public Guid DPLIIOGDGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public long LIADGMEIMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA703A0", Offset = "0xA6F7A0", VA = "0x180A703A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public FBIDCEKLFMJ BOOHHFAMMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JHLBIAGAANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x77380D0", Offset = "0x77374D0", VA = "0x1877380D0")]
	public JHLBIAGAANP(long DCONEHIDLCB, Guid ODMLPILCPKF, long CMFLOMKPDCN, FBIDCEKLFMJ CMHJABEPNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7736800", Offset = "0x7735C00", VA = "0x187736800", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[EIJCMKCDLED]
public class BNNGHPCBJDM : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public OBDKPKCMBBN OMMOIDMJEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(OBDKPKCMBBN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public OEINNDAJNEG HNLGAPNECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BNNGHPCBJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x102F000", Offset = "0x102E400", VA = "0x18102F000")]
	public BNNGHPCBJDM(OBDKPKCMBBN HJBCDFKDKBA, OEINNDAJNEG MGKBDPHONDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[EIJCMKCDLED]
public class FBIDCEKLFMJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public Guid? OLEDAILBKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x3170A30", Offset = "0x316FE30", VA = "0x183170A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7735050", Offset = "0x7734450", VA = "0x187735050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public Guid HPDNKMNGBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xE6F720", Offset = "0xE6EB20", VA = "0x180E6F720")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x1060CC0", Offset = "0x10600C0", VA = "0x181060CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FBIDCEKLFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x7735060", Offset = "0x7734460", VA = "0x187735060")]
	public FBIDCEKLFMJ(Guid? MJCBMMNPAHJ, Guid EKFKKBCMDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[EIJCMKCDLED]
public class OEINNDAJNEG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public long NMJFOBHOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public Guid DPLIIOGDGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public long JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA703A0", Offset = "0xA6F7A0", VA = "0x180A703A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public Guid CBGNDMAIBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xF1DE10", Offset = "0xF1D210", VA = "0x180F1DE10")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xF1DA50", Offset = "0xF1CE50", VA = "0x180F1DA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xF78720", Offset = "0xF77B20", VA = "0x180F78720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public DateTime PGKBDGCPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x1394000", Offset = "0x1393400", VA = "0x181394000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OEINNDAJNEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[EIJCMKCDLED]
public class LKHGIMACKKK : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public string POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public List<long> LLAJGPJNEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public List<ODHIBACPGPH> AMEKABFCMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public string IBKAFBPMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public byte? HOEANGCJCGM
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x773B710", Offset = "0x773AB10", VA = "0x18773B710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x773B700", Offset = "0x773AB00", VA = "0x18773B700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public int? JNGGFLPINKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7734FD0", Offset = "0x77343D0", VA = "0x187734FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7734D50", Offset = "0x7734150", VA = "0x187734D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public Guid? DDIIOLNOJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x773B730", Offset = "0x773AB30", VA = "0x18773B730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x773B720", Offset = "0x773AB20", VA = "0x18773B720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public bool KAPKPGEPALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA703C0", Offset = "0xA6F7C0", VA = "0x180A703C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA70460", Offset = "0xA6F860", VA = "0x180A70460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LKHGIMACKKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[EIJCMKCDLED]
public class DOMGOCPPJBI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public Guid DDIIOLNOJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public long NMJFOBHOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public string POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xF78720", Offset = "0xF77B20", VA = "0x180F78720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public DateTime PGKBDGCPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x1394000", Offset = "0x1393400", VA = "0x181394000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public string IBKAFBPMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public List<long> LLAJGPJNEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public List<ENBKGOEFIJF> AMEKABFCMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public byte HOEANGCJCGM
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xAD90F0", Offset = "0xAD84F0", VA = "0x180AD90F0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xAD90E0", Offset = "0xAD84E0", VA = "0x180AD90E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public int JNGGFLPINKO
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xAA53F0", Offset = "0xAA47F0", VA = "0x180AA53F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x1581650", Offset = "0x1580A50", VA = "0x181581650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DOMGOCPPJBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[EIJCMKCDLED]
public class BJJHAJEGOCN : DOMGOCPPJBI
{
	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public Guid GJHBGEDEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x1BF7A80", Offset = "0x1BF6E80", VA = "0x181BF7A80")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x4FA20F0", Offset = "0x4FA14F0", VA = "0x184FA20F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BJJHAJEGOCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum OBDKPKCMBBN
{
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public interface IJOKBILOPDN
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMGFICFIMPK<DOMGOCPPJBI>> OEMMPFJKKMK(Guid? KOEDADEEMCB, long DCONEHIDLCB, string HDNPPEBJPAE, string GMABBLIJJKB, string JDPAGNELAJI, string AKIFNAENEFG, byte PDPKIFONADM, int IFBOGFLAOGG, [Optional] List<long> POCIFBHGJGK, [Optional] List<ENBKGOEFIJF> NAEOOFHFMCG, bool LDEHICOMJIF = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CMGFICFIMPK<DOMGOCPPJBI>> LLACNHOEGLK(Guid ODMLPILCPKF, long DCONEHIDLCB, [Optional] string HDNPPEBJPAE, [Optional] string GMABBLIJJKB, [Optional] string JDPAGNELAJI, [Optional] List<long> POCIFBHGJGK, [Optional] Dictionary<string, string> NAEOOFHFMCG, [Optional] string AKIFNAENEFG, [Optional] byte? PDPKIFONADM, [Optional] int? IFBOGFLAOGG, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BCMKODJOJFH> IHCKGDOCAGM(Guid ODMLPILCPKF, long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<DOMGOCPPJBI>> HPAAEOLOKBK(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<OEINNDAJNEG>> EPAIJBCNHAC(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<BNNGHPCBJDM>> JMIMNGKIHNC(long DCONEHIDLCB, List<JHLBIAGAANP> EILMPOKFKPI, [Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[EIJCMKCDLED]
public class ODHIBACPGPH : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string IBKAFBPMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ODHIBACPGPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[EIJCMKCDLED]
public class ENBKGOEFIJF : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public long EKFILPEIAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string IBKAFBPMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ENBKGOEFIJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[EIJCMKCDLED]
public class HOBELNEOFPO : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public long EKFILPEIAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public string IBKAFBPMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9E00", Offset = "0x4EF9200", VA = "0x184EF9E00")]
	public HOBELNEOFPO(long JFBBOAHPOJP, string GALOKDCMNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface AFNNGNMLGFJ
{
	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMGFICFIMPK<List<ENBKGOEFIJF>>> FCEEPBOGKHF(long DCONEHIDLCB, List<HOBELNEOFPO> EILMPOKFKPI, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BCMKODJOJFH> BOGLNHIJGAO(long JFBBOAHPOJP, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<ENBKGOEFIJF>> IHKFDBGLMOG(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[EIJCMKCDLED]
public class GKIFHJAFKJH : MOOGFFFPOEO, IEquatable<GKIFHJAFKJH>
{
	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7736980", Offset = "0x7735D80", VA = "0x187736980", Slot = "7")]
	public bool Equals(GKIFHJAFKJH LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x77369C0", Offset = "0x7735DC0", VA = "0x1877369C0", Slot = "6")]
	public override MOOGFFFPOEO JCIOENFMGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GKIFHJAFKJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class DKEBHIIIJKG
{
	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x77342D0", Offset = "0x77336D0", VA = "0x1877342D0")]
	public static GKIFHJAFKJH JGFCKBOAGNM(this LINPEJLLFHG GBDPBDHPLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x7734340", Offset = "0x7733740", VA = "0x187734340")]
	public static GKIFHJAFKJH MKFOPNFNPDF(string AIGLACFCMCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[EIJCMKCDLED]
public class LINPEJLLFHG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public const int AANGCEFDCBL = 3;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public const int FKEEGCJGOPF = 40;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public const int NOKICIINKNE = 180;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public const int OGOIAPKHGDA = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public const int PBBLENENGLD = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public const int DBDBPHOJBEA = 8;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public const int KLGDEFNJJCN = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public const int HHDEIIDNEMF = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public const int ANPPOOEJFNK = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? KGJEHKBMOON;

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public Guid DDIIOLNOJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public long NMJFOBHOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public string? GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public string? POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public int IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CE0", Offset = "0xAD80E0", VA = "0x180AD8CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public Guid? DLAILNGEHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x773B270", Offset = "0x773A670", VA = "0x18773B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x773B290", Offset = "0x773A690", VA = "0x18773B290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xAD29F0", Offset = "0xAD1DF0", VA = "0x180AD29F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xE9DB50", Offset = "0xE9CF50", VA = "0x180E9DB50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public int? JGGPEDOFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7156660", Offset = "0x7155A60", VA = "0x187156660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x7156680", Offset = "0x7155A80", VA = "0x187156680")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public int? NPMGABMLGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x773AF40", Offset = "0x773A340", VA = "0x18773AF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x773AF50", Offset = "0x773A350", VA = "0x18773AF50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public IReadOnlyList<LCDDEENJBGK> LIJPFMIHIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xA70170", Offset = "0xA6F570", VA = "0x180A70170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8A0", Offset = "0xA7BCA0", VA = "0x180A7C8A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xF908B0", Offset = "0xF8FCB0", VA = "0x180F908B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public DateTime PGKBDGCPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xF90340", Offset = "0xF8F740", VA = "0x180F90340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	[IgnoreDataMember]
	public MICOCAOOCPB DMPKKHGPLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x773B2A0", Offset = "0x773A6A0", VA = "0x18773B2A0")]
		get
		{
			return default(MICOCAOOCPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> MDKLCGDPMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x773B220", Offset = "0x773A620", VA = "0x18773B220")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA7C810", Offset = "0xA7BC10", VA = "0x180A7C810")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x773B380", Offset = "0x773A780", VA = "0x18773B380", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LINPEJLLFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x773B390", Offset = "0x773A790", VA = "0x18773B390")]
	public LINPEJLLFHG(Guid KOEDADEEMCB, long DCONEHIDLCB, string HDNPPEBJPAE, string GMABBLIJJKB, string JDPAGNELAJI, int EGEKCECLJKJ, int? OFEEFNJOJDN, int? JJPOLNDAAHG, List<LCDDEENJBGK> KEDIPMKOFME, [Optional] DateTime PCGHPDOLFBK, [Optional] DateTime AHFFGJLCFCD, [Optional] Guid? LNPEGDEHDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x773B310", Offset = "0x773A710", VA = "0x18773B310")]
	private MICOCAOOCPB MPFONNHGMIM()
	{
		return default(MICOCAOOCPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x773AF60", Offset = "0x773A360", VA = "0x18773AF60")]
	private Dictionary<Guid, int> FFIKKJBDOBG(IReadOnlyList<LCDDEENJBGK> KEDIPMKOFME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[EIJCMKCDLED]
public class LKLDEPLIDEK : EODJFKKINLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public Guid DDIIOLNOJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public long NMJFOBHOBJD;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LKLDEPLIDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[EIJCMKCDLED]
public class OFCJOCLDOJB : LINPEJLLFHG
{
	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public Guid EHIHHKHKHPI
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xF91030", Offset = "0xF90430", VA = "0x180F91030")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xF91020", Offset = "0xF90420", VA = "0x180F91020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public Guid? LILNAOBINAC
	{
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x773D460", Offset = "0x773C860", VA = "0x18773D460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x773D440", Offset = "0x773C840", VA = "0x18773D440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OFCJOCLDOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[EIJCMKCDLED]
public class IAOONBKOBLO : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public string? GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public string? POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public int IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public int? JGGPEDOFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x13852B0", Offset = "0x13846B0", VA = "0x1813852B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x13852E0", Offset = "0x13846E0", VA = "0x1813852E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public int? NPMGABMLGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xDDB100", Offset = "0xDDA500", VA = "0x180DDB100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xDDB140", Offset = "0xDDA540", VA = "0x180DDB140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public List<LCDDEENJBGK> LIJPFMIHIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public Guid? LILNAOBINAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7737500", Offset = "0x7736900", VA = "0x187737500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x77374C0", Offset = "0x77368C0", VA = "0x1877374C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public Guid? DDIIOLNOJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x77374E0", Offset = "0x77368E0", VA = "0x1877374E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x77374D0", Offset = "0x77368D0", VA = "0x1877374D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public bool KAPKPGEPALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xE6C760", Offset = "0xE6BB60", VA = "0x180E6C760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xFD7F10", Offset = "0xFD7310", VA = "0x180FD7F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x7737520", Offset = "0x7736920", VA = "0x187737520", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IAOONBKOBLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[EIJCMKCDLED]
public class LCDDEENJBGK : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public NHMMLIBGNHL HKNPOEGBFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
		[CompilerGenerated]
		get
		{
			return default(NHMMLIBGNHL);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public Guid MNLBFNDEJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E390", Offset = "0x1B6D790", VA = "0x181B6E390")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D41D40", Offset = "0x5D41140", VA = "0x185D41D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LCDDEENJBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x773AC40", Offset = "0x773A040", VA = "0x18773AC40")]
	public LCDDEENJBGK(Guid IHELPNJHPMA, NHMMLIBGNHL IIHAKBEOLJD, int PPNAGMANAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[EIJCMKCDLED]
public class FAICHEFKBON : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public Guid FIMJKOAEOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public int FHIMNIBNGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public DateTime GJGMMMODOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xA70450", Offset = "0xA6F850", VA = "0x180A70450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x7734FE0", Offset = "0x77343E0", VA = "0x187734FE0")]
	public FAICHEFKBON(Guid MGPLBKACNPF, string HDNPPEBJPAE, int IMKOAGNGNDD, DateTime KCFPKLNADPO, int CDBBOGJDAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FAICHEFKBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[EIJCMKCDLED]
public class PHFKDEJECGE : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public Guid FIMJKOAEOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public int GEHEJEGPALI
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PHFKDEJECGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x4FAD370", Offset = "0x4FAC770", VA = "0x184FAD370")]
	public PHFKDEJECGE(Guid MGPLBKACNPF, int JAFPDNDNMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[EIJCMKCDLED]
public class NBCJJLMALCN : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public int GEHEJEGPALI
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public Guid GEDKIHEBMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E390", Offset = "0x1B6D790", VA = "0x181B6E390")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D41D40", Offset = "0x5D41140", VA = "0x185D41D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public int CDELKEFJJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public Guid? HPJNEBCKJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xF8E1B0", Offset = "0xF8D5B0", VA = "0x180F8E1B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x24A3430", Offset = "0x24A2830", VA = "0x1824A3430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public int FNAPEEJMJKP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC60", Offset = "0xA8C060", VA = "0x180A8CC60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x16F6310", Offset = "0x16F5710", VA = "0x1816F6310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public Dictionary<Guid, Guid?> HEEJBKDDGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NBCJJLMALCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x773C7F0", Offset = "0x773BBF0", VA = "0x18773C7F0")]
	public NBCJJLMALCN(int JAFPDNDNMNE, Guid DKGPEIIAKDP, int ILNICHBFCBF, Guid? JJMKHHDNMIG, int IFLIHMOKCKD, Dictionary<Guid, Guid?> EJDLPOFEJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[EIJCMKCDLED]
public class CEFHINBABFP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public GLONJGPFHBH AKMHGLMNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
		[CompilerGenerated]
		get
		{
			return default(GLONJGPFHBH);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public LIKLNMJLDJD? OLCHJEOGAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x1385110", Offset = "0x1384510", VA = "0x181385110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x138FD10", Offset = "0x138F110", VA = "0x18138FD10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public BalanceResponseDTO MGPGLJPLIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public List<OEINNDAJNEG> IOHPKDLAIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CEFHINBABFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x7734220", Offset = "0x7733620", VA = "0x187734220")]
	public CEFHINBABFP(GLONJGPFHBH OHOFKEMACDA, LIKLNMJLDJD? PPLPJLKMKJI, BalanceResponseDTO FKCACIMLMDJ, List<OEINNDAJNEG> HFEGJMLJMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x7734210", Offset = "0x7733610", VA = "0x187734210", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum NHMMLIBGNHL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public enum GLONJGPFHBH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum MICOCAOOCPB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public interface EBOIOPJKJJB
{
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	static BBKKNBJGBDM<LINPEJLLFHG> PGHGOPIPNGL;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	static BBKKNBJGBDM<LINPEJLLFHG> OLKBAGFMPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	static BBKKNBJGBDM<Guid> PPGGGPOHFJE;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMGFICFIMPK<LINPEJLLFHG?>?>? CAFAIENJPPG(Guid? KOEDADEEMCB, long DCONEHIDLCB, string HDNPPEBJPAE, string? GMABBLIJJKB, string? JDPAGNELAJI, int EGEKCECLJKJ, MICOCAOOCPB NKOALNGNDPB, [Optional] Dictionary<Guid, int>? MAILLHHOCAP, [Optional] Guid? BOGCAANECFJ, bool LDEHICOMJIF = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CMGFICFIMPK<LINPEJLLFHG?>?>? PMOAMINIPFM(Guid MGPLBKACNPF, long DCONEHIDLCB, string HDNPPEBJPAE, string? GMABBLIJJKB, string? JDPAGNELAJI, int EGEKCECLJKJ, MICOCAOOCPB NKOALNGNDPB, [Optional] Dictionary<Guid, int>? MAILLHHOCAP, [Optional] Guid? BOGCAANECFJ, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BCMKODJOJFH> BCFJDEDCPPK(Guid MGPLBKACNPF, long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<LINPEJLLFHG>> AAPGAKACBMM(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<CMGFICFIMPK<List<PHFKDEJECGE>>> CMONNPNJEHC(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CMGFICFIMPK<List<FAICHEFKBON>>> DHHPGMOGFNE(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CEFHINBABFP> CDMAGCIJCON(Guid MGPLBKACNPF, long DCONEHIDLCB, int JAFPDNDNMNE, int ILNICHBFCBF, Guid? HCFJLDJEIAC, int IFLIHMOKCKD, Dictionary<Guid, Guid?> HBDENFLNHON, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7734700", Offset = "0x7733B00", VA = "0x187734700")]
	static EBOIOPJKJJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[EIJCMKCDLED]
public class KABEAHPCJGE : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public long NMJFOBHOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public bool ENICCCONNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KABEAHPCJGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public interface EEKFMJKAGIO
{
	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KABEAHPCJGE> LOFNEFNONNL(long DCONEHIDLCB, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BCMKODJOJFH> LONNOOHHNBO(long DCONEHIDLCB, bool FIOOPFKINAE, [Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[IOEFKGDICCL]
public class ELEIIAPKOHP<DataType> where DataType : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public long MEDKFLKOAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	public LPMAKBILGPG CCNNBBBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(LPMAKBILGPG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	public LPGACNHIPAP GNDNEKCEOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
		[CompilerGenerated]
		get
		{
			return default(LPGACNHIPAP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public DataType NMPPAMCHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ELEIIAPKOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[IOEFKGDICCL]
public class MGGHDMLGPAI<DataType> where DataType : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public long MEDKFLKOAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public LPMAKBILGPG CCNNBBBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(LPMAKBILGPG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public LPGACNHIPAP GNDNEKCEOED
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
		[CompilerGenerated]
		get
		{
			return default(LPGACNHIPAP);
		}
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public List<DataType> NMPPAMCHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MGGHDMLGPAI()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[IOEFKGDICCL]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : EODJFKKINLJ, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[IOEFKGDICCL]
		public class LHDJJNGKIAB : JPGLNCIFIDA, EODJFKKINLJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E9")]
			[CompilerGenerated]
			private struct IDLCANNIOKK : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000425")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000426")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				public LHDJJNGKIAB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000428")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0x50AA670", Offset = "0x50A9A70", VA = "0x1850AA670", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0x50AA920", Offset = "0x50A9D20", VA = "0x1850AA920", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000285")]
			public LIKLNMJLDJD HBMEPNOFLKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000613")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				[CompilerGenerated]
				get
				{
					return default(LIKLNMJLDJD);
				}
				[Cpp2IlInjected.Token(Token = "0x6000614")]
				[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000286")]
			public DataTypeDTO NMPPAMCHJMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000615")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000616")]
				[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x550C7E0", Offset = "0x550BBE0", VA = "0x18550C7E0", Slot = "5")]
			public void POEGDHEICKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x550C710", Offset = "0x550BB10", VA = "0x18550C710", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.LHDJJNGKIAB.IDLCANNIOKK))]
			public Task CLBBHINLKGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public LHDJJNGKIAB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		public List<LHDJJNGKIAB> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x5B632E0", Offset = "0x5B626E0", VA = "0x185B632E0", Slot = "5")]
		public override void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[IOEFKGDICCL]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : EODJFKKINLJ, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		[IOEFKGDICCL]
		public class KABIKKKCFIN : JPGLNCIFIDA, EODJFKKINLJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EC")]
			[CompilerGenerated]
			private struct JAENMDLAFPC : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042D")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042E")]
				public KABIKKKCFIN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042F")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000627")]
				[Cpp2IlInjected.Address(RVA = "0x52FAB10", Offset = "0x52F9F10", VA = "0x1852FAB10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000628")]
				[Cpp2IlInjected.Address(RVA = "0x52FAD60", Offset = "0x52FA160", VA = "0x1852FAD60", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000288")]
			public LIKLNMJLDJD HBMEPNOFLKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000620")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				[CompilerGenerated]
				get
				{
					return default(LIKLNMJLDJD);
				}
				[Cpp2IlInjected.Token(Token = "0x6000621")]
				[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000289")]
			public List<DataTypeDTO> NMPPAMCHJMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000622")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000623")]
				[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x542E580", Offset = "0x542D980", VA = "0x18542E580", Slot = "5")]
			public void POEGDHEICKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x542E4B0", Offset = "0x542D8B0", VA = "0x18542E4B0", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.KABIKKKCFIN.JAENMDLAFPC))]
			public Task CLBBHINLKGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public KABIKKKCFIN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public List<KABIKKKCFIN> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x5B632E0", Offset = "0x5B626E0", VA = "0x185B632E0", Slot = "5")]
		public override void POEGDHEICKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[DPPLCKBACOG]
public class KNAEFLBIHGM : PurchaseBalanceUpdateResponseDTO<KGCPCHPAGKE>
{
	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x773A8C0", Offset = "0x7739CC0", VA = "0x18773A8C0")]
	public KNAEFLBIHGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[DPPLCKBACOG]
public class CEPJHOOFFDP : PurchaseBalanceUpdateResponseDTO<KGCPCHPAGKE>.KABIKKKCFIN
{
	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x7734290", Offset = "0x7733690", VA = "0x187734290")]
	public CEPJHOOFFDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[EIJCMKCDLED]
public class PHMLDJDKPCI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public IBEKCKGJFCJ LEKCGJKAOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public long JPNGOMMMOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public GiftItemDTO? DFJONFIFKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public long? JGLGENPAHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x13E0010", Offset = "0x13DF410", VA = "0x1813E0010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x1518150", Offset = "0x1517550", VA = "0x181518150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	public int BOEMOEOINEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x773DDF0", Offset = "0x773D1F0", VA = "0x18773DDF0")]
	public PHMLDJDKPCI(IBEKCKGJFCJ ENHCBOABPOD, long BIHCLINBKCD, GiftItemDTO? EJHLOODJAPA, int ECMAAKHGBMG = 1, [Optional] long? HAJBKPPPIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[EIJCMKCDLED]
public class PJCALAEJOFA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	public List<PHMLDJDKPCI> GDHMDGHNIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	public BKFNKFFICGC? DJOIEJJJPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	public LPMAKBILGPG CCNNBBBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(LPMAKBILGPG);
		}
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public bool HOGADPKOFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xE55AB0", Offset = "0xE54EB0", VA = "0x180E55AB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xE55AC0", Offset = "0xE54EC0", VA = "0x180E55AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public bool LDDCHLNGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x15C5ED0", Offset = "0x15C52D0", VA = "0x1815C5ED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x290B330", Offset = "0x290A730", VA = "0x18290B330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public Guid? JIPHDFFMFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xF8E1B0", Offset = "0xF8D5B0", VA = "0x180F8E1B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x24A3430", Offset = "0x24A2830", VA = "0x1824A3430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x773DE70", Offset = "0x773D270", VA = "0x18773DE70")]
	public PJCALAEJOFA(List<PHMLDJDKPCI> IDCGPOCKNFJ, BKFNKFFICGC? DAFHFGCBPCL, LPMAKBILGPG JDIPBOIIMNA, bool NOJBCKGDCPN, bool FPEPALPMLNN = false, [Optional] Guid? GKOINLEHOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[EIJCMKCDLED]
public class FGHKIOLBNJJ : JPGLNCIFIDA, EODJFKKINLJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct AAEINOLBGAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public FGHKIOLBNJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7732490", Offset = "0x7731890", VA = "0x187732490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7732770", Offset = "0x7731B70", VA = "0x187732770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	internal static Action<KGCPCHPAGKE>? FHEIHBFNCIB;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	internal static Func<KGCPCHPAGKE, Task>? OCIPMAPCPCO;

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public KGCPCHPAGKE GCKBDDAIGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public int? HOFBEIGODPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public EMNLKCIAKAO? OOFGADNKMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x7735560", Offset = "0x7734960", VA = "0x187735560", Slot = "5")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x7735490", Offset = "0x7734890", VA = "0x187735490", Slot = "6")]
	[AsyncStateMachine(typeof(AAEINOLBGAC))]
	public virtual Task CLBBHINLKGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FGHKIOLBNJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[DPPLCKBACOG]
public class IDKHIAFNNFL : BalanceUpdateResponseDTO<FGHKIOLBNJJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x77378C0", Offset = "0x7736CC0", VA = "0x1877378C0")]
	public IDKHIAFNNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[DPPLCKBACOG]
public class GJPCFMMPEAI : BalanceUpdateResponseDTO<FGHKIOLBNJJ>.LHDJJNGKIAB
{
	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7736940", Offset = "0x7735D40", VA = "0x187736940")]
	public GJPCFMMPEAI()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[EIJCMKCDLED]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public PGIDFLAKNGN GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
			[CompilerGenerated]
			get
			{
				return default(PGIDFLAKNGN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[EIJCMKCDLED]
public class NAJMNCODMAO : EODJFKKINLJ, IMOLFKIAMFH
{
	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public LIOOKEBEHEM? PEDMGPAGIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	[IgnoreDataMember]
	public Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x773C770", Offset = "0x773BB70", VA = "0x18773C770", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public IBEKCKGJFCJ? EGLBMGJKIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public List<PBNABDNEJDP>? PKKLNDEIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public DateTime? HNKHLMPHPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x13E0010", Offset = "0x13DF410", VA = "0x1813E0010", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x1518150", Offset = "0x1517550", VA = "0x181518150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public DateTime? NBBGDGLBIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x15C7F20", Offset = "0x15C7320", VA = "0x1815C7F20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x15C6940", Offset = "0x15C5D40", VA = "0x1815C6940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public DateTime? KEIFLOLKIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xE6C720", Offset = "0xE6BB20", VA = "0x180E6C720", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x5D3EC30", Offset = "0x5D3E030", VA = "0x185D3EC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public bool GMDMCLLKCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xD1A4E0", Offset = "0xD198E0", VA = "0x180D1A4E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xD198B0", Offset = "0xD18CB0", VA = "0x180D198B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public bool AHNCHMDDCGM
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x10786E0", Offset = "0x1077AE0", VA = "0x1810786E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x124D440", Offset = "0x124C840", VA = "0x18124D440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public bool KMBPPPEDPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x103CE40", Offset = "0x103C240", VA = "0x18103CE40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x124D430", Offset = "0x124C830", VA = "0x18124D430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public bool CMHBNIDPGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x10340B0", Offset = "0x10334B0", VA = "0x1810340B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x103CD40", Offset = "0x103C140", VA = "0x18103CD40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x773C4D0", Offset = "0x773B8D0", VA = "0x18773C4D0")]
	public static NAJMNCODMAO FONDBDENFJJ(Guid NPMPEIAPAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NAJMNCODMAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[EIJCMKCDLED]
public class OBHLCMPEJFF
{
	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public string GFBGIPICFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public string OGAJOJLHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public Dictionary<int, JEMLJHLCDOM> HLGPFBOCPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public Dictionary<string, int> KHPJJCFAKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public Dictionary<JIFIMNNODAB, List<int>> OBJLFBHEIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public Dictionary<string, string> EKLMKNFGIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OBHLCMPEJFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum JIFIMNNODAB
{
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[EIJCMKCDLED]
public class JEMLJHLCDOM : PGCNAGFMLBN
{
	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public IMFBMEFPKNK CDLDBMBKFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(IMFBMEFPKNK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public bool PBJCNBENCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x12CA5C0", Offset = "0x12C99C0", VA = "0x1812CA5C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x15C3F00", Offset = "0x15C3300", VA = "0x1815C3F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public bool DAKFBFOCAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2030A20", Offset = "0x202FE20", VA = "0x182030A20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2030A00", Offset = "0x202FE00", VA = "0x182030A00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public string OHFPBGHPGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public string NLNEMJKCAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	public string LIIMLMNPAGL
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	public string CICDDPNCEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	public Dictionary<BHKAGDNLKEG, string> EGDNHAOJGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x15C3F10", Offset = "0x15C3310", VA = "0x1815C3F10")]
	public JEMLJHLCDOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[EIJCMKCDLED]
public class MLEONPHBAOI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	public IReadOnlyList<LIOOKEBEHEM>? BEDJDBAFGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MLEONPHBAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public MLEONPHBAOI(IReadOnlyList<LIOOKEBEHEM>? OMJPKHFINGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public enum OGFBEMPGJHE
{
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface IMOLFKIAMFH
{
	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	IBEKCKGJFCJ? EGLBMGJKIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	List<PBNABDNEJDP>? PKKLNDEIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	DateTime? HNKHLMPHPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	DateTime? NBBGDGLBIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	DateTime? KEIFLOLKIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	bool GMDMCLLKCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	bool KMBPPPEDPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	bool CMHBNIDPGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface EINLJJKCBLB
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action GBMLEFAKGBG;

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DBCMNCDDOKD(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EPGNAFDFHAI(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JNLIJIFMIAB([Out] BGMIAEMECPD HFDKCBHNBMB);
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface BGMIAEMECPD
{
	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	string GFBGIPICFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	string OGAJOJLHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	IReadOnlyDictionary<JIFIMNNODAB, IReadOnlyList<PGCNAGFMLBN>> LACHMEJJONA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	IReadOnlyDictionary<string, string> EKLMKNFGIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface PGCNAGFMLBN
{
	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	string NLNEMJKCAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	string OHFPBGHPGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	string LIIMLMNPAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	string CICDDPNCEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public interface DKGDNEFFHIH
{
	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	BHKEDJFHKGB HKNPOEGBFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	string NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	string NHKKOPFPPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	bool CMHBNIDPGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	bool KMBPPPEDPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	EBJFCGJIDIH GPADKJEJPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	string PGAICCMNNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	LHBKFFHMLKB? DFOHLLFJCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	OGFBEMPGJHE MEGDOIAEGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	bool ALGJAIPBOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[EIJCMKCDLED]
public class IBEKCKGJFCJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public BHKEDJFHKGB GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(BHKEDJFHKGB);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public int? EEEFMCKONOM
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x1385110", Offset = "0x1384510", VA = "0x181385110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x138FD10", Offset = "0x138F110", VA = "0x18138FD10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public Guid? OHOFNEJMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA7C940", Offset = "0xA7BD40", VA = "0x180A7C940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8E0", Offset = "0xA7BCE0", VA = "0x180A7C8E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x7737730", Offset = "0x7736B30", VA = "0x187737730")]
	public static IBEKCKGJFCJ EDIGDCPHEBA(int BJMOAIPPFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x77377D0", Offset = "0x7736BD0", VA = "0x1877377D0")]
	public static IBEKCKGJFCJ LLOALMMJAAE(Guid NPMPEIAPAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x7737530", Offset = "0x7736930", VA = "0x187737530")]
	public static IBEKCKGJFCJ BLDPOKEMCDB(JNLOJNJGNOF FFGGOFOKADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IBEKCKGJFCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum BHKEDJFHKGB
{
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[EIJCMKCDLED]
public class PBNABDNEJDP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public LPMAKBILGPG CCNNBBBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(LPMAKBILGPG);
		}
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public int IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xB508B0", Offset = "0xB4FCB0", VA = "0x180B508B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public FNEHFHNIKNF PDKJIAMCLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x1031880", Offset = "0x1030C80", VA = "0x181031880", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x773DDA0", Offset = "0x773D1A0", VA = "0x18773DDA0")]
	public int GKKDHFLCMLC(DateTime NNHGLAGGBKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PBNABDNEJDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[EIJCMKCDLED]
public class FNEHFHNIKNF : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public int OACKHMCNKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public DateTime? EPBICJPPLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public DateTime? HBCBHFHHPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x13E0010", Offset = "0x13DF410", VA = "0x1813E0010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x1518150", Offset = "0x1517550", VA = "0x181518150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x7735E90", Offset = "0x7735290", VA = "0x187735E90")]
	public bool EBBNPLHJFHG(DateTime NNHGLAGGBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x7736070", Offset = "0x7735470", VA = "0x187736070")]
	public int KAPADKHIAEP(DateTime NNHGLAGGBKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x7735F80", Offset = "0x7735380", VA = "0x187735F80")]
	public TimeSpan? HMMKJMMDCKP(DateTime NNHGLAGGBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FNEHFHNIKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum BKFNKFFICGC
{
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public enum OGEHKOHMFFG
{
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public enum MMJCNPABCHD
{
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public enum JCAMMGPGIKK
{
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum KCBBGIKNOML
{
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[EIJCMKCDLED]
public class KAOOCLPBGJG : IEquatable<KAOOCLPBGJG>
{
	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public int? EGDLAINNIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public int? NHHJGDPHBED
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public int? OOIEGAIKLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public List<int>? KFAPGKFGAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x7739DD0", Offset = "0x77391D0", VA = "0x187739DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x7739D70", Offset = "0x7739170", VA = "0x187739D70")]
	public static KAOOCLPBGJG PODFLPDOOCM(int? FLGKNMFGBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x7739970", Offset = "0x7738D70", VA = "0x187739970", Slot = "4")]
	public bool Equals(KAOOCLPBGJG? LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x7739CD0", Offset = "0x77390D0", VA = "0x187739CD0")]
	private static bool NBABKJABCNC(List<int>? HCFCOMCPJPA, List<int>? JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x7739740", Offset = "0x7738B40", VA = "0x187739740", Slot = "0")]
	public override bool Equals(object? DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x7739AF0", Offset = "0x7738EF0", VA = "0x187739AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KAOOCLPBGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public struct JNLOJNJGNOF : IEquatable<JNLOJNJGNOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public readonly BHKEDJFHKGB HKNPOEGBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly int EEEFMCKONOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly Guid OHOFNEJMJCM;

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public Guid CDAPHDPIEII
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x7739420", Offset = "0x7738820", VA = "0x187739420")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public int HOFBEIGODPG
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x7738E50", Offset = "0x7738250", VA = "0x187738E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public string IADCHAPFECI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x77393D0", Offset = "0x77387D0", VA = "0x1877393D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x7738F90", Offset = "0x7738390", VA = "0x187738F90")]
	public static bool MDNPGNBFALF(string FHEMIGFOAKF, [Out] JNLOJNJGNOF FFGGOFOKADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x7738720", Offset = "0x7737B20", VA = "0x187738720")]
	public static bool DBEAGCFLFJM(string BFMPEAAKNAO, [Out] JNLOJNJGNOF FFGGOFOKADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x7738E60", Offset = "0x7738260", VA = "0x187738E60")]
	public static JNLOJNJGNOF LKNDILNKGOG(int CLNGGGMIBPI)
	{
		return default(JNLOJNJGNOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x7738D00", Offset = "0x7738100", VA = "0x187738D00")]
	public static JNLOJNJGNOF HELBIPAPEPJ(Guid CLNGGGMIBPI)
	{
		return default(JNLOJNJGNOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x77389F0", Offset = "0x7737DF0", VA = "0x1877389F0")]
	private static bool DNINOLLNAAN(string FHEMIGFOAKF, [Out] BHKEDJFHKGB FHACIBPEDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x7739540", Offset = "0x7738940", VA = "0x187739540")]
	private JNLOJNJGNOF(BHKEDJFHKGB FHACIBPEDGD, int? BCAPCBMNCMB, Guid? NPMPEIAPAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x7738B00", Offset = "0x7737F00", VA = "0x187738B00", Slot = "4")]
	public bool Equals(JNLOJNJGNOF LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x7738B70", Offset = "0x7737F70", VA = "0x187738B70", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x7738C70", Offset = "0x7738070", VA = "0x187738C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x7739490", Offset = "0x7738890", VA = "0x187739490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[EIJCMKCDLED]
public abstract class MOOGFFFPOEO : IEquatable<MOOGFFFPOEO>, EODJFKKINLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public Guid OGNDGGFKAJO;

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x773C010", Offset = "0x773B410", VA = "0x18773C010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x773BF90", Offset = "0x773B390", VA = "0x18773BF90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x7736980", Offset = "0x7735D80", VA = "0x187736980", Slot = "4")]
	public bool Equals(MOOGFFFPOEO LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x773BE70", Offset = "0x773B270", VA = "0x18773BE70", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract MOOGFFFPOEO JCIOENFMGMF();

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected MOOGFFFPOEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public enum IHDNLHKBJIA
{
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
[EIJCMKCDLED]
public class LIOOKEBEHEM : MOOGFFFPOEO, IEquatable<LIOOKEBEHEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public IHDNLHKBJIA FHACIBPEDGD;

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x773B620", Offset = "0x773AA20", VA = "0x18773B620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x773B4C0", Offset = "0x773A8C0", VA = "0x18773B4C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LIOOKEBEHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x773B6C0", Offset = "0x773AAC0", VA = "0x18773B6C0")]
	public LIOOKEBEHEM(IHDNLHKBJIA FHACIBPEDGD, Guid OGNDGGFKAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x773B540", Offset = "0x773A940", VA = "0x18773B540")]
	public static LIOOKEBEHEM HELBIPAPEPJ(Guid JCGHBPGKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x773B470", Offset = "0x773A870", VA = "0x18773B470", Slot = "7")]
	public bool Equals(LIOOKEBEHEM LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x773B5B0", Offset = "0x773A9B0", VA = "0x18773B5B0", Slot = "6")]
	public override MOOGFFFPOEO JCIOENFMGMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public static class OEPLBMBAJNH
{
	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x773D270", Offset = "0x773C670", VA = "0x18773D270")]
	public static LIOOKEBEHEM JGFCKBOAGNM(this OKJBJDGFKHF GBDPBDHPLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x773D2E0", Offset = "0x773C6E0", VA = "0x18773D2E0")]
	public static LIOOKEBEHEM MKFOPNFNPDF(string EOOMIMIELNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x773D3D0", Offset = "0x773C7D0", VA = "0x18773D3D0")]
	public static LIOOKEBEHEM MNCAHEBDDGK(Guid ONOLAMODLNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[EIJCMKCDLED]
public class OKJBJDGFKHF : GDNDDINAKDK, EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public IHDNLHKBJIA HKNPOEGBFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(IHDNLHKBJIA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public Guid PEDMGPAGIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E390", Offset = "0x1B6D790", VA = "0x181B6E390")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x5D41D40", Offset = "0x5D41140", VA = "0x185D41D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public string POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public long? NMJFOBHOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x102B400", Offset = "0x102A800", VA = "0x18102B400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x102B3F0", Offset = "0x102A7F0", VA = "0x18102B3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public long IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xF78A90", Offset = "0xF77E90", VA = "0x180F78A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public Guid? FJNNLHHCJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x773DAE0", Offset = "0x773CEE0", VA = "0x18773DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x773DB00", Offset = "0x773CF00", VA = "0x18773DB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xF90B70", Offset = "0xF8FF70", VA = "0x180F90B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public DateTime PGKBDGCPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8A0", Offset = "0xA7BCA0", VA = "0x180A7C8A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xF908B0", Offset = "0xF8FCB0", VA = "0x180F908B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OKJBJDGFKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x773DBC0", Offset = "0x773CFC0", VA = "0x18773DBC0")]
	public OKJBJDGFKHF(IHDNLHKBJIA FHACIBPEDGD, Guid OGNDGGFKAJO, [Optional] string HDNPPEBJPAE, [Optional] string GMABBLIJJKB, [Optional] string JDPAGNELAJI, [Optional] long? DCONEHIDLCB, long EGEKCECLJKJ = 0L, [Optional] Guid? GNLEHMIANKJ, [Optional] DateTime PCGHPDOLFBK, [Optional] DateTime AHFFGJLCFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x773DB10", Offset = "0x773CF10", VA = "0x18773DB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public interface KLGNFEKAJCB
{
	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public interface BCOKDIBGMED<out TId> : KLGNFEKAJCB where TId : struct
{
	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	TId NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[EIJCMKCDLED]
public class FNCOEPOJNHE : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public List<AFBKDIKAKCJ> MDNIMKMLPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public List<HNPAPNIJBPG> HEEHMGLEPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public List<GCNNGPHCLIH> GEINHBLGJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public List<GHIFHLBJOLO> BLCLKLAOCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public List<BLLBIKDFPJP> CLELLAKHCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public List<HCLIBBJJDAD> JDFAIEEOMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public List<APFDOBGOCMJ> NCDNNDEOILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public HGLBHAHBOLL NALAANGLDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public HGLBHAHBOLL EMOODBADOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public HGLBHAHBOLL CKJAIPEGGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x7735A80", Offset = "0x7734E80", VA = "0x187735A80", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x7735C30", Offset = "0x7735030", VA = "0x187735C30")]
	public FNCOEPOJNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[EIJCMKCDLED]
public class AFBKDIKAKCJ : EODJFKKINLJ, IEquatable<AFBKDIKAKCJ>
{
	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public CHFGHJDODPM AKPPECNMOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
		[CompilerGenerated]
		get
		{
			return default(CHFGHJDODPM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public BKEFICJKCBH OMDPFKCPEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xB32050", Offset = "0xB31450", VA = "0x180B32050")]
		[CompilerGenerated]
		get
		{
			return default(BKEFICJKCBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xB31FD0", Offset = "0xB313D0", VA = "0x180B31FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public Guid LNEDPKLJIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E390", Offset = "0x1B6D790", VA = "0x181B6E390")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x5D41D40", Offset = "0x5D41140", VA = "0x185D41D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public Guid HFPKHNACIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xE6F720", Offset = "0xE6EB20", VA = "0x180E6F720")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x1060CC0", Offset = "0x10600C0", VA = "0x181060CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x77328B0", Offset = "0x7731CB0", VA = "0x1877328B0", Slot = "5")]
	public bool Equals(AFBKDIKAKCJ LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x7732950", Offset = "0x7731D50", VA = "0x187732950", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x7732AC0", Offset = "0x7731EC0", VA = "0x187732AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x150B8B0", Offset = "0x150ACB0", VA = "0x18150B8B0")]
	public static bool ILMCFLMCOJH(AFBKDIKAKCJ JLJHECODIOL, AFBKDIKAKCJ DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x150B1A0", Offset = "0x150A5A0", VA = "0x18150B1A0")]
	public static bool AMDBHCBNEEF(AFBKDIKAKCJ JLJHECODIOL, AFBKDIKAKCJ DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AFBKDIKAKCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[EIJCMKCDLED]
public class HGLBHAHBOLL : EODJFKKINLJ, BCOKDIBGMED<BKEFICJKCBH>, KLGNFEKAJCB
{
	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public BKEFICJKCBH NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(BKEFICJKCBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public PPPBILHJLPD BKCAFOLNODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public float HJLJDOPLJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x1057300", Offset = "0x1056700", VA = "0x181057300")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x1561E90", Offset = "0x1561290", VA = "0x181561E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public float KAADEPHJOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xD61A50", Offset = "0xD60E50", VA = "0x180D61A50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xD61A60", Offset = "0xD60E60", VA = "0x180D61A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public float EEFPAJPMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xD23FD0", Offset = "0xD233D0", VA = "0x180D23FD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x1048C10", Offset = "0x1048010", VA = "0x181048C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x7736F00", Offset = "0x7736300", VA = "0x187736F00", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x7736F50", Offset = "0x7736350", VA = "0x187736F50")]
	public HGLBHAHBOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[EIJCMKCDLED]
public class HNPAPNIJBPG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public AFBKDIKAKCJ BPKEMDDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public string KPEBJNHBGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public OEKLLCHGOJK IMPILLMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x1031880", Offset = "0x1030C80", VA = "0x181031880", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x7737130", Offset = "0x7736530", VA = "0x187737130")]
	public HNPAPNIJBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[EIJCMKCDLED]
public class GCNNGPHCLIH : EODJFKKINLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public string EHAHKONJAOD;

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public BKEFICJKCBH OMDPFKCPEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
		[CompilerGenerated]
		get
		{
			return default(BKEFICJKCBH);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GCNNGPHCLIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[EIJCMKCDLED]
public class GHIFHLBJOLO : EODJFKKINLJ, BCOKDIBGMED<Guid>, KLGNFEKAJCB
{
	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x7736790", Offset = "0x7735B90", VA = "0x187736790", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public Guid NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public int LEFFHKPNGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public string EHAHKONJAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public OEKLLCHGOJK LEHEPOAPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x7736800", Offset = "0x7735C00", VA = "0x187736800", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x7736820", Offset = "0x7735C20", VA = "0x187736820")]
	public GHIFHLBJOLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[EIJCMKCDLED]
public class BLLBIKDFPJP : EODJFKKINLJ, BCOKDIBGMED<Guid>, KLGNFEKAJCB
{
	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public Guid NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public float HGMLLJMGOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x1057300", Offset = "0x1056700", VA = "0x181057300")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x1561E90", Offset = "0x1561290", VA = "0x181561E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public DHCONLKOPDO NMDEICLGKML
	{
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x180AAC0", Offset = "0x1809EC0", VA = "0x18180AAC0")]
		[CompilerGenerated]
		get
		{
			return default(DHCONLKOPDO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x1046C60", Offset = "0x1046060", VA = "0x181046C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public List<MCKPDBGLACP> OAEAPLPFDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x7733AD0", Offset = "0x7732ED0", VA = "0x187733AD0", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x7733B70", Offset = "0x7732F70", VA = "0x187733B70")]
	public BLLBIKDFPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[EIJCMKCDLED]
public class HCLIBBJJDAD : EODJFKKINLJ, BCOKDIBGMED<Guid>, KLGNFEKAJCB
{
	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public Guid NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public PPPBILHJLPD BKCAFOLNODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x7736E30", Offset = "0x7736230", VA = "0x187736E30", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x7736E80", Offset = "0x7736280", VA = "0x187736E80")]
	public HCLIBBJJDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[EIJCMKCDLED]
public class PPPBILHJLPD : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public List<JLNCHCFAFNF> BFOFNOBLHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x773E440", Offset = "0x773D840", VA = "0x18773E440", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x773E480", Offset = "0x773D880", VA = "0x18773E480")]
	public PPPBILHJLPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[EIJCMKCDLED]
public class JLNCHCFAFNF : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public float LHIIPNAHAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xD43CC0", Offset = "0xD430C0", VA = "0x180D43CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xDB9C10", Offset = "0xDB9010", VA = "0x180DB9C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public float JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xE55900", Offset = "0xE54D00", VA = "0x180E55900")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xE55AA0", Offset = "0xE54EA0", VA = "0x180E55AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public float BBCCDFLDCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x138FD00", Offset = "0x138F100", VA = "0x18138FD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public float DPCJAEPFCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xE7B0A0", Offset = "0xE7A4A0", VA = "0x180E7B0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public float COKKKDFBHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xABFF20", Offset = "0xABF320", VA = "0x180ABFF20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x10509E0", Offset = "0x104FDE0", VA = "0x1810509E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public float AIMIOONELPN
	{
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xACB6F0", Offset = "0xACAAF0", VA = "0x180ACB6F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xACB550", Offset = "0xACA950", VA = "0x180ACB550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public int CJCOAFEMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public int CBFCCGPADMM
	{
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0xABF670", Offset = "0xABEA70", VA = "0x180ABF670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x1646810", Offset = "0x1645C10", VA = "0x181646810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JLNCHCFAFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[EIJCMKCDLED]
public class MCKPDBGLACP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public float LHIIPNAHAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0xD43CC0", Offset = "0xD430C0", VA = "0x180D43CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xDB9C10", Offset = "0xDB9010", VA = "0x180DB9C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public OEKLLCHGOJK LEHEPOAPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x1031880", Offset = "0x1030C80", VA = "0x181031880", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x773BB60", Offset = "0x773AF60", VA = "0x18773BB60")]
	public MCKPDBGLACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[EIJCMKCDLED]
public class OEKLLCHGOJK : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public float DEGILMJFPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0xD43CC0", Offset = "0xD430C0", VA = "0x180D43CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xDB9C10", Offset = "0xDB9010", VA = "0x180DB9C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public float JKNCHJBEFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xE55900", Offset = "0xE54D00", VA = "0x180E55900")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0xE55AA0", Offset = "0xE54EA0", VA = "0x180E55AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public float AOIBNJOCOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x138FD00", Offset = "0x138F100", VA = "0x18138FD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public float FJAIOBILGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xE7B0A0", Offset = "0xE7A4A0", VA = "0x180E7B0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OEKLLCHGOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x7735A20", Offset = "0x7734E20", VA = "0x187735A20")]
	public OEKLLCHGOJK(float GDOMDKGJNLG, float OCIGECIELML, float JOCIBENNGKI, float HCFCOMCPJPA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[EIJCMKCDLED]
public class APFDOBGOCMJ : EODJFKKINLJ, BCOKDIBGMED<Guid>, KLGNFEKAJCB
{
	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public Guid NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public string MKHCPJEOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public string MAIIPIPBPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public bool NAACGPJDJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xACC370", Offset = "0xACB770", VA = "0x180ACC370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xACC0E0", Offset = "0xACB4E0", VA = "0x180ACC0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public float LBEHPCGOECC
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xAC27B0", Offset = "0xAC1BB0", VA = "0x180AC27B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xD22440", Offset = "0xD21840", VA = "0x180D22440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public OALDLFMCCII JKKPIJBGNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public OALDLFMCCII CHKBJLAIDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public OALDLFMCCII PHNBDCPPPJP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public OALDLFMCCII CJHIPKPMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public FLOIMIJKPKG JBKNEGJDANK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x7733000", Offset = "0x7732400", VA = "0x187733000", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x77330C0", Offset = "0x77324C0", VA = "0x1877330C0")]
	public APFDOBGOCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[EIJCMKCDLED]
public class OALDLFMCCII : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public AKABBELLFJL MOBKIEDOCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public float NBKLPIPIBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x138FD00", Offset = "0x138F100", VA = "0x18138FD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public float JHFLIDFOKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xE7B0A0", Offset = "0xE7A4A0", VA = "0x180E7B0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public FLOIMIJKPKG CLPGJEIMAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x773C980", Offset = "0x773BD80", VA = "0x18773C980", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x773C9A0", Offset = "0x773BDA0", VA = "0x18773C9A0")]
	public OALDLFMCCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[EIJCMKCDLED]
public class AKABBELLFJL : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public float JPPEPKOPNMB
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xD43CC0", Offset = "0xD430C0", VA = "0x180D43CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xDB9C10", Offset = "0xDB9010", VA = "0x180DB9C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public float MPFDPACHOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xE55900", Offset = "0xE54D00", VA = "0x180E55900")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xE55AA0", Offset = "0xE54EA0", VA = "0x180E55AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AKABBELLFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x7715980", Offset = "0x7714D80", VA = "0x187715980")]
	public AKABBELLFJL(float FNBJHADJBNG, float MODFPFNICHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	public virtual void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[EIJCMKCDLED]
public class FLOIMIJKPKG : AKABBELLFJL
{
	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public float HGMLIAIGKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x138FD00", Offset = "0x138F100", VA = "0x18138FD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public float BOMHAFFCMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xE7B0A0", Offset = "0xE7A4A0", VA = "0x180E7B0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FLOIMIJKPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D2")]
	[Cpp2IlInjected.Address(RVA = "0x7735A20", Offset = "0x7734E20", VA = "0x187735A20")]
	public FLOIMIJKPKG(float FNBJHADJBNG, float MODFPFNICHM, float CACADFINDPI, float DJODONHGGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	public override void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal static class OCNEJFPECIE
{
	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E86E30", Offset = "0x3E86230", VA = "0x183E86E30")]
	public static void MCJIMNIOHMC<T>(IList<T>? GJNBADGBDAL) where T : EODJFKKINLJ
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public enum CHFGHJDODPM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	Emission,
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	PlayerHeadScale,
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	Aura,
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	Texture
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public enum BKEFICJKCBH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	PlayerVoiceInput,
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	PlayerVelocity,
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	AnimationCurve,
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	HighFiveCount,
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	AlwaysOn
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public enum DHCONLKOPDO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	Time,
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	ValueRamp
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public static class BLIHKLOBMEB
{
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public static readonly CHFGHJDODPM[] IJJDJLLHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000557")]
	public static readonly CHFGHJDODPM[] MIDLENIFOLC;

	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public static readonly BKEFICJKCBH[] NEAGMGFHLKN;

	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public static readonly BKEFICJKCBH[] NGNHDPIJFCN;
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public enum IOLKEAPEMPA
{
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	General,
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public enum HPNCGAGGPDI
{
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[EIJCMKCDLED]
public class DOOJKDIHLPL : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public HPNCGAGGPDI OMMOIDMJEKM
	{
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(HPNCGAGGPDI);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public List<string> PANODMBOAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x7734450", Offset = "0x7733850", VA = "0x187734450")]
	public string BBPFEKKCELL(int GLNGOAGPKGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DOOJKDIHLPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
[EIJCMKCDLED]
public class IBEMBLNCLJE : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public string HKDCHEDCIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public IOLKEAPEMPA GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(IOLKEAPEMPA);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IBEMBLNCLJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public static class IHMFLJKNMJC
{
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	public const string NOPEAOCGJGO = "costume";

	[Cpp2IlInjected.Token(Token = "0x4000574")]
	public const string JELAOAFBMGF = "gadget";

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	public const string LBOHCMMEAAA = "holotar";

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	public const string NPJDIFCNIBJ = "large";

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public const string BBPNIKCCGNM = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	public const string DJFNBDCEHJE = "small";

	[Cpp2IlInjected.Token(Token = "0x4000579")]
	public const string JOAAIPFNFNC = "sound";

	[Cpp2IlInjected.Token(Token = "0x400057A")]
	public const string PIPHAEPFPIG = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x400057B")]
	public const string LKMPCPNPAED = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x400057C")]
	public const string NHDKFDFANIJ = "r2";

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public static List<string> OFPKAGNFNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x7737A30", Offset = "0x7736E30", VA = "0x187737A30")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public static class CFLBIALNDFG
{
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	public const string DJCIFGDOCKI = "beta";

	[Cpp2IlInjected.Token(Token = "0x400057E")]
	public const string IBJLNIAEKHI = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[EIJCMKCDLED]
public class MHAHPGHHNPH : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public List<string> KMAOAHNLLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public List<string> HNCGENGFEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public List<string> GNKGONGGHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MHAHPGHHNPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public class OBPEPENMMKD : IEquatable<OBPEPENMMKD>
{
	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	protected virtual Type EGGNAPINHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x773CF50", Offset = "0x773C350", VA = "0x18773CF50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public HLLLLOOAEGO? COCDEIBFEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public HttpMethod? ONBILJDCENC
	{
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public string? GEPEGCFBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x773D1B0", Offset = "0x773C5B0", VA = "0x18773D1B0")]
	public OBPEPENMMKD(HLLLLOOAEGO? COCDEIBFEDD, HttpMethod? ONBILJDCENC, string? GEPEGCFBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x773D040", Offset = "0x773C440", VA = "0x18773D040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x773CDF0", Offset = "0x773C1F0", VA = "0x18773CDF0", Slot = "6")]
	protected virtual bool LAHPDPPCCNN(StringBuilder IDAMHGBLFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x1244400", Offset = "0x1243800", VA = "0x181244400")]
	public static bool AMDBHCBNEEF(OBPEPENMMKD? DOGEBCJNCBM, OBPEPENMMKD? CADKJEGELGB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x1244770", Offset = "0x1243B70", VA = "0x181244770")]
	public static bool ILMCFLMCOJH(OBPEPENMMKD? DOGEBCJNCBM, OBPEPENMMKD? CADKJEGELGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x773CC80", Offset = "0x773C080", VA = "0x18773CC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x773CBF0", Offset = "0x773BFF0", VA = "0x18773CBF0", Slot = "0")]
	public override bool Equals(object? DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x773CA60", Offset = "0x773BE60", VA = "0x18773CA60", Slot = "7")]
	public virtual bool Equals(OBPEPENMMKD? LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x773CFB0", Offset = "0x773C3B0", VA = "0x18773CFB0", Slot = "8")]
	public virtual OBPEPENMMKD OPEMMHFGBGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x773D150", Offset = "0x773C550", VA = "0x18773D150")]
	protected OBPEPENMMKD(OBPEPENMMKD NGLOBNNAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x773CA20", Offset = "0x773BE20", VA = "0x18773CA20")]
	public void BBBPACNHLNO([Out] HLLLLOOAEGO? COCDEIBFEDD, [Out] HttpMethod? ONBILJDCENC, [Out] string? GEPEGCFBNCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public class CBEHNNPIIHH : IEquatable<CBEHNNPIIHH>
{
	[Cpp2IlInjected.Token(Token = "0x17000342")]
	protected virtual Type EGGNAPINHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x7734020", Offset = "0x7733420", VA = "0x187734020", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public int NFKBMNNCCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public EEGCBIHAADJ PIKBKEBJKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0")]
		[CompilerGenerated]
		get
		{
			return default(EEGCBIHAADJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xB508B0", Offset = "0xB4FCB0", VA = "0x180B508B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x7734200", Offset = "0x7733600", VA = "0x187734200")]
	public CBEHNNPIIHH(int NFKBMNNCCJO, EEGCBIHAADJ PIKBKEBJKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x77340F0", Offset = "0x77334F0", VA = "0x1877340F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x7733EF0", Offset = "0x77332F0", VA = "0x187733EF0", Slot = "6")]
	protected virtual bool LAHPDPPCCNN(StringBuilder IDAMHGBLFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x1244400", Offset = "0x1243800", VA = "0x181244400")]
	public static bool AMDBHCBNEEF(CBEHNNPIIHH? DOGEBCJNCBM, CBEHNNPIIHH? CADKJEGELGB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x1244770", Offset = "0x1243B70", VA = "0x181244770")]
	public static bool ILMCFLMCOJH(CBEHNNPIIHH? DOGEBCJNCBM, CBEHNNPIIHH? CADKJEGELGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x7733DE0", Offset = "0x77331E0", VA = "0x187733DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x7733C10", Offset = "0x7733010", VA = "0x187733C10", Slot = "0")]
	public override bool Equals(object? DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x7733CA0", Offset = "0x77330A0", VA = "0x187733CA0", Slot = "7")]
	public virtual bool Equals(CBEHNNPIIHH? LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x7734080", Offset = "0x7733480", VA = "0x187734080", Slot = "8")]
	public virtual CBEHNNPIIHH OPEMMHFGBGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0xCC9740", Offset = "0xCC8B40", VA = "0x180CC9740")]
	protected CBEHNNPIIHH(CBEHNNPIIHH NGLOBNNAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x7733C00", Offset = "0x7733000", VA = "0x187733C00")]
	public void BBBPACNHLNO([Out] int NFKBMNNCCJO, [Out] EEGCBIHAADJ PIKBKEBJKFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
public enum EEGCBIHAADJ
{
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public interface OGNIMNBALKD
{
	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<OBPEPENMMKD, CBEHNNPIIHH> DIKLJKKILPJ();

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJBFOGGGEJB(OBPEPENMMKD PEENICAIFOP, CBEHNNPIIHH ENDEKEOKCCM);

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICCAANDBPDM(OBPEPENMMKD PEENICAIFOP);

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IOBDGBICIPB();

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KDNHCLDCJOA(HLLLLOOAEGO KNNNGIFKPIN, HttpMethod GAAAFGHGFFJ, string FDLFPIGANJG, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
public interface KHEJLFODHPP
{
	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<Guid>> NIGMEMMAEGA(string FMLIGIJCJJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[IOEFKGDICCL]
public class KJHGDBFNAOK<TResult> where TResult : EODJFKKINLJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public IReadOnlyList<TResult> GDOPJANAOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public long PDLGPLDINFH
	{
		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KJHGDBFNAOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
public enum KAJLLPBNGBG
{
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public interface FCGNCHFMIOK : CIGEKBDFKAO
{
	[Cpp2IlInjected.Token(Token = "0x17000347")]
	bool NDFNBDDLGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long DKGPEIIAKDP, EDMAJOBPNLI KOFKFMIDEIO);

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EHMGDHLEOFL> PurchaseAsync(EDMAJOBPNLI KOFKFMIDEIO, KAOOCLPBGJG LNGNNFOIHCO);

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(KPNGGABMDIO PKKLFJDPGGG, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
public interface CIGEKBDFKAO
{
	[Cpp2IlInjected.Token(Token = "0x17000348")]
	bool OECBICPFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
public interface GGHFMKCDAFB
{
	[Cpp2IlInjected.Token(Token = "0x17000349")]
	int FFFPLPGFKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<EDMAJOBPNLI>> MDAOHLJJHBC(bool HOLLHNOPKGC = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IFOEKCPLPGJ([Out] EDMAJOBPNLI? CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EDMAJOBPNLI> GHKGGFEKLBL(bool HOLLHNOPKGC = false, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELDNGNMLLEO(string HBHJOPNAJMN = "");
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
public interface HEIACEAAOJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KELMKNFMOGJ(KPNGGABMDIO PKKLFJDPGGG, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NKKPLPHKKLI(KPNGGABMDIO PKKLFJDPGGG, CancellationToken GMKBGHHNCDJ, [Optional] LGPBCMOAKOE? HIPPOGCOFLL);
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public interface LGPBCMOAKOE
{
	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBFAMKBBOOO(string CAIIFLDFGNH);
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public interface ENIPJLPLNDN
{
	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FAOBJNGHAPP(KPNGGABMDIO DJNCOADJJNJ, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public interface DNPALNPCING
{
	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	bool MJFDADHCDIM
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public interface LBDHKJBHHKK
{
	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPNGGABMDIO JPGNCINIFHD(EDMAJOBPNLI KOFKFMIDEIO, KAOOCLPBGJG LNGNNFOIHCO, string GPKHLJMACIK, [Optional] HEIACEAAOJJ? NHCOHOLLIJF);
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public interface GJDKADMBJGK
{
	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJKFBPAFFOL(ENIPJLPLNDN IGJIAOCAHMB);

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool APDDGHELDFE(ENIPJLPLNDN IGJIAOCAHMB);

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task IONKEHFNJPP(KPNGGABMDIO PKKLFJDPGGG, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public interface KPNGGABMDIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	LHKDFCCLCGC EFHOHHBEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	EDMAJOBPNLI FJIOAPECMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	KAOOCLPBGJG HLODFJACFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	string MOBEEKGMPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	string CBBHCMFCNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FHDGPCHCPDO> DAHDJNJFOHF(CancellationToken NILMHHOPMOB, [Optional] LGPBCMOAKOE? HIPPOGCOFLL);

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLHJECCDBPG(string KMNBOEKAFCD);

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLHJECCDBPG<T>(Func<T, string> KMNBOEKAFCD, [In] T JMGCEFFLLGP);
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public abstract class HDHFIPLBDBD
{
	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected HDHFIPLBDBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public enum FAEDAOOPBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public enum GFDNMOOOCKB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[EIJCMKCDLED]
public class EDMAJOBPNLI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public int NNPJDALDPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public string POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public int IOJPGNIMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDA0", Offset = "0xA7B1A0", VA = "0x180A7BDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA10", Offset = "0xA7AE10", VA = "0x180A7BA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public string LPNDCCKCKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public string KBABDLKOMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	[DataMember(Name = "PsnProductLabel")]
	public string FKOLHMFNLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public string GEKCODBIKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public string CIGIHGKMPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public string ALPCJIIONDN
	{
		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public string HODDGMNJAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xA70240", Offset = "0xA6F640", VA = "0x180A70240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public string ODOJENJLMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA70170", Offset = "0xA6F570", VA = "0x180A70170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public bool JJCHOJMLECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xD5A390", Offset = "0xD59790", VA = "0x180D5A390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xD59740", Offset = "0xD58B40", VA = "0x180D59740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public bool BDFEPJMHOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x1839930", Offset = "0x1838D30", VA = "0x181839930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0x1839B10", Offset = "0x1838F10", VA = "0x181839B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public FJDJDBECGHE NMPPAMCHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9B0", Offset = "0xA7BDB0", VA = "0x180A7C9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000360")]
	[IgnoreDataMember]
	public string AKKNGEOKPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C810", Offset = "0xA7BC10", VA = "0x180A7C810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	[IgnoreDataMember]
	public string HPLABJDEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xB1ECE0", Offset = "0xB1E0E0", VA = "0x180B1ECE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000362")]
	[IgnoreDataMember]
	public string NNADIHJDBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C860", Offset = "0xA7BC60", VA = "0x180A7C860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C970", Offset = "0xA7BD70", VA = "0x180A7C970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	[IgnoreDataMember]
	public HDHFIPLBDBD MLDDLMOFPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xB1F0B0", Offset = "0xB1E4B0", VA = "0x180B1F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xB1F110", Offset = "0xB1E510", VA = "0x180B1F110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	[IgnoreDataMember]
	public bool OIHBFOGMJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x7734860", Offset = "0x7733C60", VA = "0x187734860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	[IgnoreDataMember]
	public string NBFFHOICOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA76C50", Offset = "0xA76050", VA = "0x180A76C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA76BE0", Offset = "0xA75FE0", VA = "0x180A76BE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x7734920", Offset = "0x7733D20", VA = "0x187734920", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x7734880", Offset = "0x7733C80", VA = "0x187734880")]
	public static EDMAJOBPNLI DOMFHHLLDMN(int CLNGGGMIBPI, string HDNPPEBJPAE, string JDPAGNELAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x7734A10", Offset = "0x7733E10", VA = "0x187734A10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EDMAJOBPNLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[EIJCMKCDLED]
public class FJDJDBECGHE : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000366")]
	public List<int> FHPKIOLJHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public string PBICDNNDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public CAPJMAANAPO OBHKOPFDDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x1031880", Offset = "0x1030C80", VA = "0x181031880", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FJDJDBECGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
public readonly struct FHDGPCHCPDO
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public enum NCDFPLHGMCL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	public readonly NCDFPLHGMCL IFCPBBBLFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	public readonly GFDNMOOOCKB DODILKFMCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	public readonly FAEDAOOPBDL GECHKFKFCEC;

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x7735680", Offset = "0x7734A80", VA = "0x187735680")]
	private FHDGPCHCPDO(NCDFPLHGMCL JPDKKKJJNLC, GFDNMOOOCKB NPDMKNBGBJG = GFDNMOOOCKB.Unknown, FAEDAOOPBDL DEMKAMOBGPA = FAEDAOOPBDL.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x7735640", Offset = "0x7734A40", VA = "0x187735640")]
	public static FHDGPCHCPDO KMAEPPNCJOM()
	{
		return default(FHDGPCHCPDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x7735660", Offset = "0x7734A60", VA = "0x187735660")]
	public static FHDGPCHCPDO NAJHPEJOGOO()
	{
		return default(FHDGPCHCPDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x7735620", Offset = "0x7734A20", VA = "0x187735620")]
	public static FHDGPCHCPDO BAINEHDIEAA(GFDNMOOOCKB NPDMKNBGBJG, FAEDAOOPBDL DEMKAMOBGPA)
	{
		return default(FHDGPCHCPDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public enum DGJELMIHJOP
{
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public enum EIAEBHBLHFA
{
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[EIJCMKCDLED]
public class CAPJMAANAPO : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public DGJELMIHJOP HJLKMMJPKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(DGJELMIHJOP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public EIAEBHBLHFA EDBICAPCEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0")]
		[CompilerGenerated]
		get
		{
			return default(EIAEBHBLHFA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xB508B0", Offset = "0xB4FCB0", VA = "0x180B508B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public bool GIIKBEMDMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CAPJMAANAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public enum LHKDFCCLCGC
{
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
[EIJCMKCDLED]
public class KPHGPEDGMMJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	public long OJFOBKJAAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	public long JEJCNNEGDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	public bool ADEKNFBALIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000883")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000884")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KPHGPEDGMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[EIJCMKCDLED]
public class DJIPNKEHNPJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	public string JACBFBILHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000370")]
	public AODAAMEIPME? LJBPGDPEEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000371")]
	public IReadOnlyList<AODAAMEIPME>? KGHFINMBPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000372")]
	public IReadOnlyList<string>? JGEMDFJNFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	public GGJIOLNIJKO GLDKAJEHDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000374")]
	public string? PICAHOMBMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000375")]
	public string? CMHBKCNFDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000376")]
	public string? AJMIIEAPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DJIPNKEHNPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[EIJCMKCDLED]
public class FMHJEBIHAGF : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000377")]
	public string PKFOILGCDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000378")]
	public AODAAMEIPME? LJBPGDPEEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000379")]
	public GGJIOLNIJKO GLDKAJEHDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037A")]
	public string? CMHBKCNFDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037B")]
	public IReadOnlyList<string>? JGEMDFJNFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A2")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FMHJEBIHAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[EIJCMKCDLED]
public class GGJIOLNIJKO : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700037C")]
	public string EHNDEMHPGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037D")]
	public bool JCDIDCABFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037E")]
	public bool JAEGOIBOEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x11CFDA0", Offset = "0x11CF1A0", VA = "0x1811CFDA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x1337DB0", Offset = "0x13371B0", VA = "0x181337DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037F")]
	public bool BPJNACAEMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x11CFD90", Offset = "0x11CF190", VA = "0x1811CFD90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x16820C0", Offset = "0x16814C0", VA = "0x1816820C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000380")]
	public bool NNBHENOAFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x11CFD80", Offset = "0x11CF180", VA = "0x1811CFD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x52BAEE0", Offset = "0x52BA2E0", VA = "0x1852BAEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000381")]
	public bool DOFOJCJCBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xB259A0", Offset = "0xB24DA0", VA = "0x180B259A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xE55AD0", Offset = "0xE54ED0", VA = "0x180E55AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000382")]
	public bool INGJCBELEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xB25B00", Offset = "0xB24F00", VA = "0x180B25B00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0xE55A20", Offset = "0xE54E20", VA = "0x180E55A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000383")]
	public bool GDJPEOGANON
	{
		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x1ADCCA0", Offset = "0x1ADC0A0", VA = "0x181ADCCA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x77366D0", Offset = "0x7735AD0", VA = "0x1877366D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000384")]
	public bool DMEBAGELGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x1ACA6F0", Offset = "0x1AC9AF0", VA = "0x181ACA6F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x77366C0", Offset = "0x7735AC0", VA = "0x1877366C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000385")]
	public bool NCNFMLMKMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000386")]
	public bool CNLIMFMKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x15552D0", Offset = "0x15546D0", VA = "0x1815552D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x1554FC0", Offset = "0x15543C0", VA = "0x181554FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000387")]
	public bool AIKOHJLJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x1646D10", Offset = "0x1646110", VA = "0x181646D10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x1646820", Offset = "0x1645C20", VA = "0x181646820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x77366E0", Offset = "0x7735AE0", VA = "0x1877366E0")]
	public GGJIOLNIJKO(string GLCJPCLODBN, bool COPLBJGEJEI, bool PAAFPHHHLGF, bool IHOFGCKJKOM, bool OHJFHDHGKGP, bool COMNIEEPOIF, bool EIINIBDCCKO, bool LFBLLKNFIDA, bool OGGMAFDCMNL, bool IGDINNAPEOF, bool JAKKNMODFAM, bool CEGOIANAKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[EIJCMKCDLED]
public class CIMKMJKEDPM : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000388")]
	public string HIECOGBMJME
	{
		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000389")]
	public string AJMIIEAPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038A")]
	public string PICAHOMBMHC
	{
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038B")]
	public string? AMLLICLDAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038C")]
	public string? LPNHNDFNGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038D")]
	public float ONACIJFKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xAC27C0", Offset = "0xAC1BC0", VA = "0x180AC27C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7910", Offset = "0x1EB6D10", VA = "0x181EB7910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CIMKMJKEDPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
[EIJCMKCDLED]
public class OJDLNGJNKOO : ILNKFBJNJDF, EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700038E")]
	public string CNFEPDMDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038F")]
	public string LNJOODLPDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OJDLNGJNKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[EIJCMKCDLED]
public class LIEGEEDNABD : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000390")]
	public Guid DBCFLHOHOMN
	{
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000391")]
	public long NMJFOBHOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000392")]
	public long GBPOIBECPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xA703A0", Offset = "0xA6F7A0", VA = "0x180A703A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000393")]
	public decimal FBJNBDCIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0xF1DE10", Offset = "0xF1D210", VA = "0x180F1DE10")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xF1DA50", Offset = "0xF1CE50", VA = "0x180F1DA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LIEGEEDNABD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[EIJCMKCDLED]
public class EACAMIFDBAJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000394")]
	public string CNFEPDMDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000395")]
	public string NAIBFDAOGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EACAMIFDBAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public EACAMIFDBAJ(string NJKPMDJOLDC, string IAONKOEGDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[EIJCMKCDLED]
public class EPECKMMGIPI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000396")]
	public string AJMIIEAPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000397")]
	public string JACBFBILHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000398")]
	public bool FFNBLLDIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EPECKMMGIPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[EIJCMKCDLED]
public class BHGDAOHAGJH : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000399")]
	public string JNADOBLDKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039A")]
	public decimal MNINBFMBKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BHGDAOHAGJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[EIJCMKCDLED]
public class EGAJFBKAOPF : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700039B")]
	public string? AJMIIEAPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039C")]
	public string JACBFBILHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039D")]
	public float? ONACIJFKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039E")]
	public string? POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EGAJFBKAOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[EIJCMKCDLED]
public class BABIBMDDJKB : ILIKDBCLABL
{
	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BABIBMDDJKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
[EIJCMKCDLED]
public class CECDEOCNIFK : DLNJJFDNMHD
{
	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CECDEOCNIFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[EIJCMKCDLED]
public class JKCNDBGPIFA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700039F")]
	public string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A0")]
	public string JACBFBILHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A1")]
	public bool JGFNMFMMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JKCNDBGPIFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[EIJCMKCDLED]
public class IJNEKMEHBEM : JKCNDBGPIFA
{
	[Cpp2IlInjected.Token(Token = "0x170003A2")]
	public string POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IJNEKMEHBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
[EIJCMKCDLED]
public class EMNABAKKAKA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003A3")]
	public long MLECPKHANCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A4")]
	public string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A5")]
	public CHCIPLBFLFN PECKHIFNHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(CHCIPLBFLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A6")]
	public Guid? EGENNPOMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x7734C30", Offset = "0x7734030", VA = "0x187734C30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x7734C50", Offset = "0x7734050", VA = "0x187734C50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A7")]
	public string? LDEGALDJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000911")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000912")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EMNABAKKAKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
public enum CHCIPLBFLFN
{
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	Requested = 0,
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	ProviderMeshRequested = 1,
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	ProviderMeshGenerated = 2,
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	ProviderMeshGenFailed = 3,
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	CloudBuildRequested = 11,
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	CloudBuildCompleted = 12,
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	CloudBuildFailed = 13,
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	MeshGenCompleted = 21,
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	ImageReferenceRequested = 31,
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	ImageReferenceGenerated = 32,
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	ImageReferenceGenerationFailed = 33
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[EIJCMKCDLED]
public class MNALFLDEIKD : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003A8")]
	public string? AJMIIEAPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A9")]
	public string JACBFBILHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0x773BE20", Offset = "0x773B220", VA = "0x18773BE20")]
	public MNALFLDEIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
[EIJCMKCDLED]
public class DLNJJFDNMHD : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003AA")]
	public string AJMIIEAPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AB")]
	public string JACBFBILHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DLNJJFDNMHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[EIJCMKCDLED]
public class ILIKDBCLABL : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003AC")]
	public List<string> HLJIAKENPIB
	{
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AD")]
	public decimal NGJGIDJGOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000923")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000924")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ILIKDBCLABL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[EIJCMKCDLED]
public class FIGMPIBDJHP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003AE")]
	public int NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AF")]
	public string GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B0")]
	public string? GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B1")]
	public IReadOnlyList<int> LMNOKFLNLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B2")]
	public string? FJOLFOAJOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600092F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x7735990", Offset = "0x7734D90", VA = "0x187735990")]
	public FIGMPIBDJHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[EIJCMKCDLED]
public class IIDMHGAKONJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003B3")]
	public int NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B4")]
	public Guid? OHOFNEJMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x24A3530", Offset = "0x24A2930", VA = "0x1824A3530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x24A3220", Offset = "0x24A2620", VA = "0x1824A3220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B5")]
	public string GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B6")]
	public List<FIGMPIBDJHP> NBPMMMBKFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B7")]
	public List<FIGMPIBDJHP> IBKFJPMLPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B8")]
	public string? GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B9")]
	public string? FJOLFOAJOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BA")]
	public string? JFKCKNHGHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x7737F00", Offset = "0x7737300", VA = "0x187737F00", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x7737F30", Offset = "0x7737330", VA = "0x187737F30")]
	public IIDMHGAKONJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[EIJCMKCDLED]
public class NJOIOGLKAKJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003BB")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BC")]
	public IIDMHGAKONJ NBPMMMBKFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BD")]
	public IIDMHGAKONJ IBKFJPMLPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BE")]
	public string? JFKCKNHGHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x773C890", Offset = "0x773BC90", VA = "0x18773C890", Slot = "5")]
	public virtual void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NJOIOGLKAKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[EIJCMKCDLED]
public class KNBDFGHGHNO : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003BF")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C0")]
	public IReadOnlyList<IIDMHGAKONJ> AJHOHOPJKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C1")]
	public IReadOnlyList<NJOIOGLKAKJ> AHFAIGOHCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C2")]
	public IReadOnlyList<KNBDFGHGHNO> DCAFMPKBOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C3")]
	public string? JFKCKNHGHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x773A900", Offset = "0x7739D00", VA = "0x18773A900", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x773A930", Offset = "0x7739D30", VA = "0x18773A930")]
	public KNBDFGHGHNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[EIJCMKCDLED]
public class DHOABKJMGFA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	public const string IHNLLBPCMGL = "REPL_";

	[Cpp2IlInjected.Token(Token = "0x170003C4")]
	public string NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C5")]
	public int KKFBMPFCGED
	{
		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DHOABKJMGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[EIJCMKCDLED]
public class AODAAMEIPME : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003C6")]
	public int? BPKEMDDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C7")]
	public string? MJLDNBBCPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C8")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C9")]
	public string GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CA")]
	public List<AODAAMEIPME>? IBDCABEELNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CB")]
	public DHOABKJMGFA? KHIJJOOOPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x7732D00", Offset = "0x7732100", VA = "0x187732D00", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AODAAMEIPME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[EIJCMKCDLED]
public class IBLEGCJOKPP : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003CC")]
	public string MJPDFKFKOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CD")]
	public string KAGKPLAIDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IBLEGCJOKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[EIJCMKCDLED]
public class HLDNDCFOHCA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003CE")]
	public string NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CF")]
	public KNBDFGHGHNO EFMHGMJDMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D0")]
	public AODAAMEIPME? LJBPGDPEEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D1")]
	public List<AODAAMEIPME>? KGHFINMBPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D2")]
	public IReadOnlyList<IIDMHGAKONJ> AAJGJGJFBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D3")]
	public IReadOnlyList<IBLEGCJOKPP> BDPADHHKFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D4")]
	public string? PKFOILGCDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x7736FD0", Offset = "0x77363D0", VA = "0x187736FD0", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x7737060", Offset = "0x7736460", VA = "0x187737060")]
	public HLDNDCFOHCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[EIJCMKCDLED]
public class BDMBHKKDJBE : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003D5")]
	public JMGMKEEJIFI<HLDNDCFOHCA> OMMOIDMJEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D6")]
	public decimal IBABMBLOJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x76441D0", Offset = "0x76435D0", VA = "0x1876441D0", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BDMBHKKDJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public enum LIPLMBFDGDG
{
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
[EIJCMKCDLED]
public class MNENFCNEDEI : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003D7")]
	public LIPLMBFDGDG OKDNAPJPFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(LIPLMBFDGDG);
		}
		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D8")]
	public DateTime EPGLLHOMIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MNENFCNEDEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
[EIJCMKCDLED]
public class LCCIDKIOJKH : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003D9")]
	public LIPLMBFDGDG DMIOJAGEGED
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(LIPLMBFDGDG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DA")]
	public float BGCBOGIKALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0xE55900", Offset = "0xE54D00", VA = "0x180E55900")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0xE55AA0", Offset = "0xE54EA0", VA = "0x180E55AA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LCCIDKIOJKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[EIJCMKCDLED]
public class EEHMPCBBEBA : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003DB")]
	public LIPLMBFDGDG OKDNAPJPFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(LIPLMBFDGDG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DC")]
	public DateTime EPGLLHOMIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DD")]
	public LIPLMBFDGDG DMIOJAGEGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(LIPLMBFDGDG);
		}
		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DE")]
	public float BGCBOGIKALE
	{
		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0xACB6F0", Offset = "0xACAAF0", VA = "0x180ACB6F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xACB550", Offset = "0xACA950", VA = "0x180ACB550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DF")]
	public LIPLMBFDGDG LFDCKGAFFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		[CompilerGenerated]
		get
		{
			return default(LIPLMBFDGDG);
		}
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E0")]
	public float GBNBEBENPOB
	{
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0xD61A50", Offset = "0xD60E50", VA = "0x180D61A50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0xD61A60", Offset = "0xD60E60", VA = "0x180D61A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EEHMPCBBEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[EIJCMKCDLED]
public class AIBIKEGHLEH : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003E1")]
	public TimeSpan DPCCKKDBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E2")]
	public TimeSpan PAMPGBNKOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AIBIKEGHLEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[EIJCMKCDLED]
public class FAKFJKEDCOG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003E3")]
	public List<string> JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FAKFJKEDCOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[EIJCMKCDLED]
public class EMKPKLPMBBK : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003E4")]
	public string? AJMIIEAPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E5")]
	public string NBPMMMBKFID
	{
		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E6")]
	public string AMLLICLDAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E7")]
	public string ABEEMFBFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E8")]
	public string? PICAHOMBMHC
	{
		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x7734BE0", Offset = "0x7733FE0", VA = "0x187734BE0")]
	public EMKPKLPMBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[EIJCMKCDLED]
public class AOBPEDHMIOO : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003E9")]
	public BCMKODJOJFH PNGHMBKKKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EA")]
	public LIPLMBFDGDG AMAEMDMJBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(LIPLMBFDGDG);
		}
		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EB")]
	public long? DCMGAKCGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0xE6C740", Offset = "0xE6BB40", VA = "0x180E6C740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0xF57B20", Offset = "0xF56F20", VA = "0x180F57B20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EC")]
	public DateTime? IIBHIOPBKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0xF1DE10", Offset = "0xF1D210", VA = "0x180F1DE10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0xF1DA50", Offset = "0xF1CE50", VA = "0x180F1DA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003ED")]
	public long? DNIDILJFHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x102B400", Offset = "0x102A800", VA = "0x18102B400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x102B3F0", Offset = "0x102A7F0", VA = "0x18102B3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AOBPEDHMIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[EIJCMKCDLED]
public class KPKALMODPGL : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003EE")]
	public int KNAMJIEAGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EF")]
	public DateTime? DLGNEBDOFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KPKALMODPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[EIJCMKCDLED]
public class NMOIBMHHMED : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003F0")]
	public List<GNGAFGGFBMC> KLHGKCDGFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NMOIBMHHMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[EIJCMKCDLED]
public class GNGAFGGFBMC : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003F1")]
	public string OMKHIGBIJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x7736A30", Offset = "0x7735E30", VA = "0x187736A30")]
	public GNGAFGGFBMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[EIJCMKCDLED]
public class MKFFNIJAJFL : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003F2")]
	public List<LGDNNLDKDCB> PHOAJJIKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F3")]
	public string DIDPJGCGMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x773BDC0", Offset = "0x773B1C0", VA = "0x18773BDC0")]
	public MKFFNIJAJFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[EIJCMKCDLED]
public class LGDNNLDKDCB : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003F4")]
	public string NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F5")]
	public string GBPCKDBHANP
	{
		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F6")]
	public string HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F7")]
	public string EMPAJLCIIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F8")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0xA70450", Offset = "0xA6F850", VA = "0x180A70450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public LGDNNLDKDCB(string CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public enum BNEOFCDCDMP
{
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	User,
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	System,
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	AI
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[EIJCMKCDLED]
public class FLCIPLJEABN : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003F9")]
	public string OEFABFMAGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FA")]
	public BNEOFCDCDMP FGDHDBMGFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(BNEOFCDCDMP);
		}
		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FB")]
	public string PFJJNLGCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FLCIPLJEABN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[EIJCMKCDLED]
public class PBLIHFHKBBE : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003FC")]
	public string OEFABFMAGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FD")]
	public string JOOFNELLJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FE")]
	public string FLIFIGDLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PBLIHFHKBBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public enum DMNGIBEBGGB
{
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	Required,
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	Forced
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[EIJCMKCDLED]
public class PJPLDNEIIOG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x170003FF")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000400")]
	public string FAPCBGDBGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000401")]
	public string? GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PJPLDNEIIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[EIJCMKCDLED]
public class KKJILCECEII : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000402")]
	public string OEFABFMAGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000403")]
	public string? AJMIIEAPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000404")]
	public float? ONACIJFKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000405")]
	public PJPLDNEIIOG? ABEEMFBFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000406")]
	public List<PJPLDNEIIOG> MKDJMAEDJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000407")]
	public DMNGIBEBGGB LGLHJFPMLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		[CompilerGenerated]
		get
		{
			return default(DMNGIBEBGGB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000408")]
	public string? GPHGJDOLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x773A810", Offset = "0x7739C10", VA = "0x18773A810", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x773A830", Offset = "0x7739C30", VA = "0x18773A830")]
	public KKJILCECEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[EIJCMKCDLED]
public class AGJNOMIDMOG : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000409")]
	public string NGBODNHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040A")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040B")]
	public string HFGKOCCMEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AGJNOMIDMOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[EIJCMKCDLED]
public class KDFMCMMAOGK : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700040C")]
	public List<string> GHPGBAGOFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040D")]
	public List<AGJNOMIDMOG>? BLBIMGHECCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x7739F40", Offset = "0x7739340", VA = "0x187739F40", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KDFMCMMAOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[EIJCMKCDLED]
public class NIGMHCHAIBJ : EODJFKKINLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700040E")]
	public string JNADOBLDKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void POEGDHEICKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NIGMHCHAIBJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200017F")]
public class FCNBKKGCIKA
{
	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FCNBKKGCIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x745EEE0", Offset = "0x745E2E0", VA = "0x18745EEE0")]
	public static string AMPEGALKAAA(byte[] EMJFEBGJAHC, byte[] EODODMDCONG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
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
