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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x78277D0", Offset = "0x78265D0", VA = "0x1878277D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KFKKBMPEBJB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum LLENINHBKEC
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
	public string NOIHPICCOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string MPHPOMEKGGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LLENINHBKEC PKJHNPEHPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(LLENINHBKEC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HGDEGDOBEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x235DC00", Offset = "0x235CA00", VA = "0x18235DC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GEIDNILBBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A09930", Offset = "0x1A08730", VA = "0x181A09930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7824570", Offset = "0x7823370", VA = "0x187824570")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static KFKKBMPEBJB PNPKBINCNBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78244E0", Offset = "0x78232E0", VA = "0x1878244E0")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static KFKKBMPEBJB JNKKPAKGBGJ([Optional] string CEIEFAOADMP, [Optional] string CMGPAGPPOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KFKKBMPEBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JLAKCDBCOLM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string AGHJGEKMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string PMBHPHIEOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BJOGCMIGHDN
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JLAKCDBCOLM> EJEPBKNNOON(string EFDAMCFDHPB, string DEDKKCEGKBE, string KPDGHKFKEJM, VoiceOption JLKDEPFEJBD, string? GPOPGDNMKNJ, float EABOGDKHFEA, [Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KADEKFHNILF : BJOGCMIGHDN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OFBOKAFHAAO? OPPLACDNCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GBCEOPMAPJH<OGICKLAGCCF> MGIFCCENEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GBCEOPMAPJH<JAFEKLIEDCH> NPHHGCENICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GBCEOPMAPJH<KDJJJJKKNKH> FKLDJOLPACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MKAEDPHCCBC PAGFCMGCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDANIOHNGCJ();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<HMEAPBNKFME<byte>> INDKNOKPDDM(string GJJBKNNMHFP, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<FBHBLFFAFNF> PEBAMABICNJ(bool KNNJPFNKMBJ, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<GABDJEHJFAJ<MJPBIDCMLMG>> JLMMNDJEOGH(bool ALNJCKCPFJE = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<FBHBLFFAFNF> GHGLCFGOIGH(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<LBBCKEKMIBK<KGPIBEGJCGL>> AIFHJDOHMIB(long MDNJLMOPJKG, bool NNLLEBIJPDO = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<LIFACNKLEAO> LLGILEFBHKC([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<LIFACNKLEAO> MIPHCAAGMDM(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<FOEGKOIIFLL> KHIAHJAAKCO(bool NNLLEBIJPDO = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<OIJMHBDAAKH> GILIJDDHLJL([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<FBHBLFFAFNF> BKPHLAOHMBK(bool NNLLEBIJPDO = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<FBHBLFFAFNF> ENNIPGAALLC([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<FBHBLFFAFNF> OEPLCIFLDGI(string EFDAMCFDHPB, Guid CCNMAHKNGLG, long MDNJLMOPJKG, long FMOODPJPGFG, decimal KOKFFEBINNI, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<GABDJEHJFAJ<MJPBIDCMLMG>> BOHEOANDMJK(Guid CCNMAHKNGLG, long MDNJLMOPJKG, long FMOODPJPGFG, decimal KOKFFEBINNI, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task JBGOMFOJPGJ(string JOJHHDMMADL, string IJGBIFEEHOK, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<PNBNOCCMBME> FMKBBIAMDCE(string DEDKKCEGKBE, string ODHPMGPBONO, bool LAFLNAIFEAL, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<KDJJJJKKNKH> LPDFCOKCPBJ(long MDNJLMOPJKG, string CNNNGHPMIIB, string CGDIPBADIMH, string ODHPMGPBONO, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<KDJJJJKKNKH> DIGJGDKFPLO(long OIBDIAPGEMI, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<JCHCECDGHBP> CBAKEOFDPME(string? DEDKKCEGKBE, string ODHPMGPBONO, string ECFOLMEBCEO, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<JCHCECDGHBP> CBAKEOFDPME(string? DEDKKCEGKBE, string ODHPMGPBONO, byte[] MGNCGPAGGKC, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<JCHCECDGHBP> OMAAOILMKOJ(long MDNJLMOPJKG, string? DEDKKCEGKBE, string ODHPMGPBONO, string ECFOLMEBCEO, float? EABOGDKHFEA, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<JCHCECDGHBP> OMAAOILMKOJ(long MDNJLMOPJKG, string? DEDKKCEGKBE, string ODHPMGPBONO, byte[] MGNCGPAGGKC, float? EABOGDKHFEA, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<PNBNOCCMBME> CIBCCADHBBN(long MDNJLMOPJKG, NLBFEKHAMGC FGKGCIHOGKN, byte[] MGNCGPAGGKC, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<PNBNOCCMBME> DKHAGLCOPJP(NLBFEKHAMGC FGKGCIHOGKN, string CNNNGHPMIIB, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<PNBNOCCMBME> LAOHIIHOOGK(long MDNJLMOPJKG, string? DEDKKCEGKBE, string ODHPMGPBONO, bool LAFLNAIFEAL, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<ADAOJHIIFLH> MDFKJCHJBPK(string ODHPMGPBONO, int DFOOIFEDPMI, string HBPFEBDAGAJ, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<ADAOJHIIFLH> NHMNLPICHFK(string ODHPMGPBONO, int DFOOIFEDPMI, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<HHAOGKCPLIA> KKBHBPACGPC(string? DEDKKCEGKBE, string ODHPMGPBONO, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<OFBOKAFHAAO> KFIIFMPPFEH(string ODHPMGPBONO, CPALKGFGBHB? BODLKNODPCL, IReadOnlyList<CPALKGFGBHB>? GHPNBFCFELP, IReadOnlyList<string> MPJENOGKBMP, PBHPLKCCJMD AFFIHAGMLBN, [Optional] string? AOBHLNODEJI, [Optional] string? ELPNLFGBCGG, [Optional] string? ILPBJHJLOCL, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<OFBOKAFHAAO> CJBJCLKIJOP(string OIBEBELDBPO, CPALKGFGBHB? BODLKNODPCL, IReadOnlyList<string> MPJENOGKBMP, PBHPLKCCJMD AFFIHAGMLBN, [Optional] string? ELPNLFGBCGG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<List<string>> ODJEMLHOJOP(string ODHPMGPBONO, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<string> MIMFCJDMCJI(PBHPLKCCJMD AFFIHAGMLBN, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task EMOOCGAHPJK(string DANFKLEPBNF, VoiceOption JLKDEPFEJBD, string? KPDGHKFKEJM, Action<string> ODHPKJKBMAH, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<string> CONPPPHLAEG(ReadOnlyMemory<byte> DAIGEMFAHOG, int GBHDIJIKCIM, int FMAPGJELDND, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<POHFIAONIBA> MKIAAPLCFGL(List<MNFANDEFOBF> ABPBELPJFAI, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<POHFIAONIBA> MABACPADADJ([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<bool> CMKJJIIMKKA(string KPJMCBDDBCB, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task KIOHOHLKIPO(string JEHBGLLFGAH, JMAGHHGMBMK OLKFCFIJLPF, string IMIIGPOLNDC, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task NKLJPEBFIJF(string JEHBGLLFGAH, string HPLNMGGHDPB, string PNCENNMICLF, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<OFNMFDPKNFE?>? JGICFADJGNL(string JEHBGLLFGAH, [Optional] string? DEDKKCEGKBE, [Optional] float? EABOGDKHFEA, [Optional] HFHDOGPCANB? FCFDPDPPBON, [Optional] IReadOnlyCollection<HFHDOGPCANB>? JNFEMPJIECJ, IAEIJMKLLFE BAGMAMFJFGH = IAEIJMKLLFE.Auto, [Optional] string? NLHCNHEPPIC, [Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CIBBPAKJHMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string BPPEJBCODCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string MGMIMOEDBCJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string NDIMMJCCPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string DPPGNOCBKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string DJOIGFGPGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string IKHGJCMPCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int? LCGEDIPENNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int? DHBIPMAPLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x781F350", Offset = "0x781E150", VA = "0x18781F350")]
	public CIBBPAKJHMI(string OFFOIJDIGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x781F220", Offset = "0x781E020", VA = "0x18781F220")]
	public void AJOOJNLKEEM(string HGNDLLCOHPM = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x781F250", Offset = "0x781E050", VA = "0x18781F250")]
	private void EKJPPHNENEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DJANCCALMCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BKDMPJHFGEA FFFPEIODLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FHNCHIIKIPD> MKBLJPKGHFF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FPNCNJJNHBO> MBEPCDJCBPC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FPNCNJJNHBO> JNGGIJPLLLE(bool IAJHFOOHLLO = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CMFBELKENAE([Out] FPNCNJJNHBO ABJBGCAFDME);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BBGBLOAIIAB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x781D680", Offset = "0x781C480", VA = "0x18781D680")]
	public static bool JNNHPKPLCBG(this DJANCCALMCJ CPHOKEJBOPM, [Out] FHNCHIIKIPD MJKEGEIKKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x781D590", Offset = "0x781C390", VA = "0x18781D590")]
	public static bool GCNMMAPELLK(this DJANCCALMCJ CPHOKEJBOPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EOMKOIKKDJO
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IMINDGFOAMB(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKFFKJBGBMH(int HLINGIOCPNM, [Out] ODKDMDHJDML? AFFIHAGMLBN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ODKDMDHJDML
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int HKKGIPLPHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string? LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool? HIFHDBLDKOE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string? INFGBJJOLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? OLAEJOKNJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NALMAOJBLCF? GKPOABABEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FAMLNJIBHKA(string POHHKCEOCFK, [Out] FKPMDICDICH? AFFIHAGMLBN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FKPMDICDICH
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? DGOKKDFBCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string? JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string? BIOAGBKLHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IReadOnlyList<JEOJLIEGLKB>? EPIDBPHMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	NALMAOJBLCF? GKPOABABEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	long? KKNLDGLOCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JEOJLIEGLKB
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BPNKDHKMHHH LGJMFJJMNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NALMAOJBLCF
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string? NCKKBEKBHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[MBIAOMFNMDN]
public class KBGONIJCDPL
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public List<AINMDFMJGIP> FJMAJCNKJON
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Dictionary<string, string> CNAHKFLKOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7824380", Offset = "0x7823180", VA = "0x187824380")]
	public KBGONIJCDPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[MBIAOMFNMDN]
public class AINMDFMJGIP
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int HKKGIPLPHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string INFGBJJOLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string OLAEJOKNJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool? HIFHDBLDKOE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xE9CBF0", Offset = "0xE9B9F0", VA = "0x180E9CBF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xE9CC00", Offset = "0xE9BA00", VA = "0x180E9CC00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GNGMNBCLLFI GKPOABABEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Dictionary<string, DFCNMDPPDCM> PIPNGCEEBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x781D280", Offset = "0x781C080", VA = "0x18781D280")]
	public AINMDFMJGIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[MBIAOMFNMDN]
public class GNGMNBCLLFI
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string NCKKBEKBHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public GNGMNBCLLFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[MBIAOMFNMDN]
public class DFCNMDPPDCM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string DGOKKDFBCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string BIOAGBKLHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public List<HMIOFALOLMP> EPIDBPHMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GNGMNBCLLFI GKPOABABEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long KKNLDGLOCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAA2020", Offset = "0xAA0E20", VA = "0x180AA2020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x781FFE0", Offset = "0x781EDE0", VA = "0x18781FFE0")]
	public DFCNMDPPDCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BPNKDHKMHHH
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
[MBIAOMFNMDN]
public class HMIOFALOLMP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BPNKDHKMHHH LGJMFJJMNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(BPNKDHKMHHH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HMIOFALOLMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct NPGMLILKNHA : IEquatable<NPGMLILKNHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool NOJPLPCECFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime AKACNIJEFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool KIFICLCIENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly LGBPLMEOAKA? PDDNJNPJCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string MELGGCOLAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? MAPGJKDDMGK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static NPGMLILKNHA ONCCDGFJJML
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2A5E4C0", Offset = "0x2A5D2C0", VA = "0x182A5E4C0")]
		get
		{
			return default(NPGMLILKNHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7827780", Offset = "0x7826580", VA = "0x187827780")]
	public NPGMLILKNHA(DateTime ACBGEHPNKFD, bool GFAPPPOGMJE, LGBPLMEOAKA? FJMJCKAPOGA, string NAAAHLBNOHN, int? EDDILGNAEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7827620", Offset = "0x7826420", VA = "0x187827620")]
	public FHNCHIIKIPD JMENIMKNIAE(BKDMPJHFGEA NFKAINNHNEK)
	{
		return default(FHNCHIIKIPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x78274C0", Offset = "0x78262C0", VA = "0x1878274C0")]
	private static FHNCHIIKIPD GMBAGOKLPHA(BKDMPJHFGEA NFKAINNHNEK, DateTime ACBGEHPNKFD)
	{
		return default(FHNCHIIKIPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7827320", Offset = "0x7826120", VA = "0x187827320", Slot = "4")]
	public bool Equals(NPGMLILKNHA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7827270", Offset = "0x7826070", VA = "0x187827270", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7827540", Offset = "0x7826340", VA = "0x187827540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x78275F0", Offset = "0x78263F0", VA = "0x1878275F0")]
	public static bool IKIADGFKNFC(NPGMLILKNHA NNEMEIEKIAF, NPGMLILKNHA JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7827480", Offset = "0x7826280", VA = "0x187827480")]
	public static bool GFAFFKCBFKA(NPGMLILKNHA NNEMEIEKIAF, NPGMLILKNHA JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x78276B0", Offset = "0x78264B0", VA = "0x1878276B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct FPNCNJJNHBO : IEquatable<FPNCNJJNHBO>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly FPNCNJJNHBO ONCCDGFJJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool HCIMLNOEIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly FHNCHIIKIPD BEIOGIGKIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly NPGMLILKNHA ACHNCMCEAMG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7822670", Offset = "0x7821470", VA = "0x187822670")]
	public FPNCNJJNHBO(FHNCHIIKIPD MJKEGEIKKJH, NPGMLILKNHA AMDMDPFOJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x78221E0", Offset = "0x7820FE0", VA = "0x1878221E0", Slot = "4")]
	public bool Equals(FPNCNJJNHBO FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x78220B0", Offset = "0x7820EB0", VA = "0x1878220B0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x78223B0", Offset = "0x78211B0", VA = "0x1878223B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7822470", Offset = "0x7821270", VA = "0x187822470")]
	public static bool IKIADGFKNFC(FPNCNJJNHBO NNEMEIEKIAF, FPNCNJJNHBO JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7822290", Offset = "0x7821090", VA = "0x187822290")]
	public static bool GFAFFKCBFKA(FPNCNJJNHBO NNEMEIEKIAF, FPNCNJJNHBO JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7822580", Offset = "0x7821380", VA = "0x187822580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum FHNCHIIKIPD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CFGEJCFLFBB : BKDMPJHFGEA
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string JCBKKJDGOII = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch GOGNCEJANLO;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? HALNAKILOEI;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly CFGEJCFLFBB HNKFODIAFKO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static BKDMPJHFGEA MOIOIMEFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x781EEB0", Offset = "0x781DCB0", VA = "0x18781EEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal static CFGEJCFLFBB IPMDDHGCNCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x781E9C0", Offset = "0x781D7C0", VA = "0x18781E9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static DateTimeOffset CAPLKBDKJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x781EAD0", Offset = "0x781D8D0", VA = "0x18781EAD0")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static DateTime HPHNNIHOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x781E930", Offset = "0x781D730", VA = "0x18781E930")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime LPKBGNGFCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x781EA10", Offset = "0x781D810", VA = "0x18781EA10", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DateTimeOffset GKKKGKEBDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x781EE50", Offset = "0x781DC50", VA = "0x18781EE50", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	private CFGEJCFLFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x781EC30", Offset = "0x781DA30", VA = "0x18781EC30")]
	internal static void KHFBHGDABLB(DateTime? KCOLFJADLHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum NFBCDHHPBCN
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum EKEHGJDFIJJ
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[MBIAOMFNMDN]
public class FAFHAGKOPBD : PBDNBPBNBNG, OBCKBDNDNAI, HHPMDFAHMHN, HPMMHONDJKB, BJKJLIECEHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct OPHGJHEMJLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FAFHAGKOPBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7827940", Offset = "0x7826740", VA = "0x187827940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7827CE0", Offset = "0x7826AE0", VA = "0x187827CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static NKFKONJEHCF BOBJJMBFMHK;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int LMGMOOPIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IHPKKIOOIAO EOKIEPCGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A00", Offset = "0xAB1800", VA = "0x180AB2A00", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(IHPKKIOOIAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x17380D0", Offset = "0x1736ED0", VA = "0x1817380D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KKNMHCPFCPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD913C0", Offset = "0xD901C0", VA = "0x180D913C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xE7F1E0", Offset = "0xE7DFE0", VA = "0x180E7F1E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool GOEEKCBOMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xF07610", Offset = "0xF06410", VA = "0x180F07610", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xF05FA0", Offset = "0xF04DA0", VA = "0x180F05FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool BKIDNIOCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x217D170", Offset = "0x217BF70", VA = "0x18217D170", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x217CE30", Offset = "0x217BC30", VA = "0x18217CE30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int? HDPNEBOEFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7820D30", Offset = "0x781FB30", VA = "0x187820D30", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7820CB0", Offset = "0x781FAB0", VA = "0x187820CB0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string ICODJHLJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string HFAOFCHNHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string KPKMPAMEBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xFD3260", Offset = "0xFD2060", VA = "0x180FD3260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public DateTime PGHCONMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xFD2390", Offset = "0xFD1190", VA = "0x180FD2390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NFBCDHHPBCN GFBCCENIKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xB1E4F0", Offset = "0xB1D2F0", VA = "0x180B1E4F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(NFBCDHHPBCN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x160BD10", Offset = "0x160AB10", VA = "0x18160BD10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string KHOEIJJFICH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE70", Offset = "0xA9DC70", VA = "0x180A9EE70", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDA0", Offset = "0xA9DBA0", VA = "0x180A9EDA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int NLALDDIBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xDB0A50", Offset = "0xDAF850", VA = "0x180DB0A50", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xDB0D50", Offset = "0xDAFB50", VA = "0x180DB0D50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public IReadOnlyList<AMEKGOPDNGC> EPIPMAGCBCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xB633E0", Offset = "0xB621E0", VA = "0x180B633E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IReadOnlyList<AGEBAMJJIEH> HHAKBBBMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public HCAAEADMMIL DLKFJDCAMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE60", Offset = "0xA9DC60", VA = "0x180A9EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE40", Offset = "0xA9DC40", VA = "0x180A9EE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string DAPDFCJEEIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7820CC0", Offset = "0x781FAC0", VA = "0x187820CC0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public LGCCIJILPFA FFHBHGNOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xC21FD0", Offset = "0xC20DD0", VA = "0x180C21FD0", Slot = "24")]
		get
		{
			return default(LGCCIJILPFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7820CC0", Offset = "0x781FAC0", VA = "0x187820CC0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool OLHAFHDAGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public AHJINCPIKDJ FMMFMMDFBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAE5B70", Offset = "0xAE4970", VA = "0x180AE5B70", Slot = "30")]
		get
		{
			return default(AHJINCPIKDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string MFPOJMEDJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public BFHAFIEPAFC? IOCECBFENDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7820CE0", Offset = "0x781FAE0", VA = "0x187820CE0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public PDMMBMIFBNP IKDCEEFKANM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xC21FD0", Offset = "0xC20DD0", VA = "0x180C21FD0", Slot = "33")]
		get
		{
			return default(PDMMBMIFBNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool LHEGDGAECIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FAFHAGKOPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x10F61A0", Offset = "0x10F4FA0", VA = "0x1810F61A0")]
	public FAFHAGKOPBD([Optional] Guid PJJIOIOLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7820B00", Offset = "0x781F900", VA = "0x187820B00", Slot = "35")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x78209C0", Offset = "0x781F7C0", VA = "0x1878209C0", Slot = "36")]
	[AsyncStateMachine(typeof(OPHGJHEMJLD))]
	public Task BCLOKBHDFOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7820A90", Offset = "0x781F890", VA = "0x187820A90")]
	public FAFHAGKOPBD BGGJAJMLDMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[MBIAOMFNMDN]
public class LJIFLAICJLM : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public int? HDPNEBOEFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x13C5A20", Offset = "0x13C4820", VA = "0x1813C5A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1089DB0", Offset = "0x1088BB0", VA = "0x181089DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string ICODJHLJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public IHPKKIOOIAO EOKIEPCGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		[CompilerGenerated]
		get
		{
			return default(IHPKKIOOIAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NFBCDHHPBCN? GFBCCENIKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAE2C00", Offset = "0xAE1A00", VA = "0x180AE2C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAE2C10", Offset = "0xAE1A10", VA = "0x180AE2C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LJIFLAICJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[MBIAOMFNMDN]
public class OHILBOHDPDC : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int LMGMOOPIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int? HDPNEBOEFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x13C58C0", Offset = "0x13C46C0", VA = "0x1813C58C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x13D0910", Offset = "0x13CF710", VA = "0x1813D0910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string HFAOFCHNHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string ICODJHLJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OHILBOHDPDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[MBIAOMFNMDN]
public class AAOEEKDLFPK : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int? HDPNEBOEFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string ICODJHLJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AAOEEKDLFPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct ACLFLPJENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int DPAPHKBHAHO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int EEIHBKKMBOM;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int KLJALIENILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int OOIJBOELJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x300A170", Offset = "0x3008F70", VA = "0x18300A170")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x300A160", Offset = "0x3008F60", VA = "0x18300A160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static ACLFLPJENGL HANIMDCJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x781CA10", Offset = "0x781B810", VA = "0x18781CA10")]
		get
		{
			return default(ACLFLPJENGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x781CAC0", Offset = "0x781B8C0", VA = "0x18781CAC0")]
	public ACLFLPJENGL(int MFNGFJCFNEH, int DMGNOGCKPBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[MBIAOMFNMDN]
public class ENDCNODHONN : HHPMDFAHMHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int EJCCPPLAIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int PDPIDGHNKGH;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ENDCNODHONN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[MBIAOMFNMDN]
public class KFHHAHPJAOF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int LOMPFENIOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int? MJAEILEPFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x13C58C0", Offset = "0x13C46C0", VA = "0x1813C58C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x13D0910", Offset = "0x13CF710", VA = "0x1813D0910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string? KFFFDCFEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7824480", Offset = "0x7823280", VA = "0x187824480")]
	public KFHHAHPJAOF(int FHHAGIABJGI, int? FNCEOMPANKI, string? JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KFHHAHPJAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[MBIAOMFNMDN]
public class DOFOACKAFGF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CIOMDPBAHFA.NGEBNMPHDDE EMKLIGNENHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(CIOMDPBAHFA.NGEBNMPHDDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public string GNPPHEEIJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int? FHNPFAIKAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DOFOACKAFGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AGEBAMJJIEH
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long MNDOJICLFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Guid EJDIBFPKOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string MFALKFEKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string HAKOGLOKKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int GJLEPBFGGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string FJMGBNCHIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string PAEMGONCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	string LMFHMNOPHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	string DLKDCIKDDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int NLALDDIBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[MBIAOMFNMDN]
public class AMEKGOPDNGC : AGEBAMJJIEH, HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public long MNDOJICLFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Guid EJDIBFPKOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x141B2F0", Offset = "0x141A0F0", VA = "0x18141B2F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1553FB0", Offset = "0x1552DB0", VA = "0x181553FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAA2020", Offset = "0xAA0E20", VA = "0x180AA2020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string MFALKFEKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string HAKOGLOKKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int GJLEPBFGGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xEA1460", Offset = "0xEA0260", VA = "0x180EA1460", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xFF01B0", Offset = "0xFEEFB0", VA = "0x180FF01B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string FJMGBNCHIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string PAEMGONCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public string LMFHMNOPHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA93200", Offset = "0xA92000", VA = "0x180A93200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string DLKDCIKDDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA98250", Offset = "0xA97050", VA = "0x180A98250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int NLALDDIBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xB1E4F0", Offset = "0xB1D2F0", VA = "0x180B1E4F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x160BD10", Offset = "0x160AB10", VA = "0x18160BD10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "15")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AMEKGOPDNGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Flags]
public enum ANCIFEOHKGJ
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum ADFIBKKDCBC
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
public static class AHHALOHGAPG
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x781D160", Offset = "0x781BF60", VA = "0x18781D160")]
	public static int? LKEMNJPLPCC(ANCIFEOHKGJ? PECBBLDLPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x781D0D0", Offset = "0x781BED0", VA = "0x18781D0D0")]
	public static int? CBJJCAGGBMH(ADFIBKKDCBC? HJEGBCBIEEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[MBIAOMFNMDN]
public class DOJFMAACEAD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int? IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public IHPKKIOOIAO? EOKIEPCGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA98AC0", Offset = "0xA978C0", VA = "0x180A98AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DOJFMAACEAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[MBIAOMFNMDN]
public class ECJGOBMDJGD : GGHMLGOOCJO, HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public byte ALGBMMFFJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ECJGOBMDJGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class LEFDABBLPEA
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x78267A0", Offset = "0x78255A0", VA = "0x1878267A0")]
	public static MAAJLACIBNH INIJFNMFHMG(this ECJGOBMDJGD DBBEADIHLKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface PBDNBPBNBNG
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	int LMGMOOPIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	int IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	IHPKKIOOIAO EOKIEPCGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool KKNMHCPFCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool GOEEKCBOMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool BKIDNIOCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	int? HDPNEBOEFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string ICODJHLJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	string HFAOFCHNHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string KPKMPAMEBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	DateTime PGHCONMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	NFBCDHHPBCN GFBCCENIKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string KHOEIJJFICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	int NLALDDIBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string DAPDFCJEEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7827D40", Offset = "0x7826B40", VA = "0x187827D40", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BJKJLIECEHM
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	IReadOnlyList<AGEBAMJJIEH> HHAKBBBMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	int LMGMOOPIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool BKIDNIOCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int NLALDDIBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	int? HDPNEBOEFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	IHPKKIOOIAO EOKIEPCGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BFPKKLIMICB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IKEJHFHGMNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IEnumerable<HPMMHONDJKB> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x78234F0", Offset = "0x78222F0", VA = "0x1878234F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7823790", Offset = "0x7822590", VA = "0x187823790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x781D940", Offset = "0x781C740", VA = "0x18781D940")]
	public static bool CONFFDILMMP(this IEnumerable<HHPMDFAHMHN> NGGCNGNMEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x781DB80", Offset = "0x781C980", VA = "0x18781DB80")]
	[AsyncStateMachine(typeof(IKEJHFHGMNH))]
	public static Task HNLCAJPLGDK(this IEnumerable<HPMMHONDJKB> NGGCNGNMEBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct PEDNEEGBGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly string NFHHLFGCAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly string KIBKGAHBMPN;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly PEDNEEGBGKL NPEEJKJJDMI;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
	public PEDNEEGBGKL(string GJJBKNNMHFP, string HOHPDECNKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x13E93E0", Offset = "0x13E81E0", VA = "0x1813E93E0")]
	public bool PLPDMPBLIKB(PEDNEEGBGKL FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7828000", Offset = "0x7826E00", VA = "0x187828000", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7828150", Offset = "0x7826F50", VA = "0x187828150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x78281C0", Offset = "0x7826FC0", VA = "0x1878281C0")]
	public static bool IKIADGFKNFC(PEDNEEGBGKL NNEMEIEKIAF, PEDNEEGBGKL JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x78280D0", Offset = "0x7826ED0", VA = "0x1878280D0")]
	public static bool GFAFFKCBFKA(PEDNEEGBGKL NNEMEIEKIAF, PEDNEEGBGKL JOGLOLMOJGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MEJAFHGHGMF
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	CIBBPAKJHMI ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string LGLDHNMKKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string EOLHOBNDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	long PKLFMMGCBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string IIDAFJGHAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string ECBEOGONMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	string LOPBKCLEGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	string KMJIGANHBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[MBIAOMFNMDN]
public class IDNKDOAFIOF : BLFDNICCDID
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string FLDGPKFKFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public HMLJOGNPHFN DLMGEADGLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(HMLJOGNPHFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BJHHLCIOKPL ILHOHOFPFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
		[CompilerGenerated]
		get
		{
			return default(BJHHLCIOKPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public DOPHCDJKEAK KIAPDFKDDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(DOPHCDJKEAK);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	[DataMember(Name = "Header")]
	public string? NIPFMNLBHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string? DGOKKDFBCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string? DHECODAKDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public List<string> JLFNBBOFOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public List<EDHCKEJHNEK> EPIDBPHMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7822CE0", Offset = "0x7821AE0", VA = "0x187822CE0", Slot = "5")]
	public override void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7822CF0", Offset = "0x7821AF0", VA = "0x187822CF0")]
	public IDNKDOAFIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum GBHCOHPNGDH
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
public enum HMLJOGNPHFN
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum BJHHLCIOKPL
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum DOPHCDJKEAK
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[MBIAOMFNMDN]
public class EDHCKEJHNEK : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public GBHCOHPNGDH GFJNOKANPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(GBHCOHPNGDH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? EKAHABJAGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[DataMember(Name = "LinkParameter")]
	public string? GPMPHEPLNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? GKHJIKAJIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EDHCKEJHNEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class BLFDNICCDID : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	[IgnoreDataMember]
	public string? LKAEKHKJAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DEABHIFMEFG();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x781E8E0", Offset = "0x781D6E0", VA = "0x18781E8E0")]
	protected BLFDNICCDID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[MBIAOMFNMDN]
public class KNEHFPHHEBP : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? MEPIDIFEKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KNEHFPHHEBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[MBIAOMFNMDN]
public class DIPHKEHFIPN : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal static Func<string, IDNKDOAFIOF>? AGPIJEPDCNO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	internal static Func<string, JIEOIDJKCFK>? CLDOMMLFCEE;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public string? MEPIDIFEKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string? LHHBFAPJLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool MDPBAHDJAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public LGBPLMEOAKA GPHGECLOBFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
		[CompilerGenerated]
		get
		{
			return default(LGBPLMEOAKA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public MALLPKNKEKG EGFKHBFMFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(MALLPKNKEKG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public int MNAEAPLJABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x168AAA0", Offset = "0x16898A0", VA = "0x18168AAA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DateTime NEHGJLMPBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA98B70", Offset = "0xA97970", VA = "0x180A98B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[DataMember(Name = "IsRead")]
	internal bool INHCPGEHLML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xAEFA50", Offset = "0xAEE850", VA = "0x180AEFA50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAEFDA0", Offset = "0xAEEBA0", VA = "0x180AEFDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[IgnoreDataMember]
	public bool PBDMDFJGBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1567B50", Offset = "0x1566950", VA = "0x181567B50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1567400", Offset = "0x1566200", VA = "0x181567400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public MMHAEDBNPJE LCFEAAEINDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A00", Offset = "0xAB1800", VA = "0x180AB2A00")]
		[CompilerGenerated]
		get
		{
			return default(MMHAEDBNPJE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x17380D0", Offset = "0x1736ED0", VA = "0x1817380D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public PFPJFACKIFP BJPJHPGJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
		[CompilerGenerated]
		get
		{
			return default(PFPJFACKIFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xB169F0", Offset = "0xB157F0", VA = "0x180B169F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	internal string? ALKHJDJBLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public IDNKDOAFIOF? FJBHGEKEEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7820410", Offset = "0x781F210", VA = "0x187820410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	[IgnoreDataMember]
	public JIEOIDJKCFK? BAEIPENCMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7820390", Offset = "0x781F190", VA = "0x187820390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	[IgnoreDataMember]
	public BLFDNICCDID? FBOBCDJEOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7820070", Offset = "0x781EE70", VA = "0x187820070", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0xABF990", Offset = "0xABE790", VA = "0x180ABF990")]
	public DIPHKEHFIPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[MBIAOMFNMDN]
public class KHIIGAFMJBO : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public NGBADFBNOKD ACKLOPFAIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(NGBADFBNOKD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string FGFLDFIIBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int DMPKLFPOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7824DF0", Offset = "0x7823BF0", VA = "0x187824DF0")]
	public KHIIGAFMJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[MBIAOMFNMDN]
public class JIEOIDJKCFK : BLFDNICCDID
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public string ONEJLDMHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string? LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public MDDLLMGNOEF HJJNBKKLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(MDDLLMGNOEF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	[DataMember(Name = "all_conditions_required")]
	public bool GCADPMJNFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x184BDC0", Offset = "0x184ABC0", VA = "0x18184BDC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x108D570", Offset = "0x108C370", VA = "0x18108D570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public List<KHIIGAFMJBO> CGMDPHKBLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7824010", Offset = "0x7822E10", VA = "0x187824010", Slot = "5")]
	public override void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7824020", Offset = "0x7822E20", VA = "0x187824020")]
	public JIEOIDJKCFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum PFPJFACKIFP
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum MMHAEDBNPJE
{
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum MDDLLMGNOEF
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum NGBADFBNOKD
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
public interface CEGLAGDIKFE
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool NHKECHIOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	GBCEOPMAPJH<DIPHKEHFIPN> AELLBKPOLII
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	GBCEOPMAPJH<string> FLGKKDCOLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	GBCEOPMAPJH<DIPHKEHFIPN> CFAPPDMBHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	GBCEOPMAPJH<DIPHKEHFIPN> JFGELKBDGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<DIPHKEHFIPN> LBBJAIKDNIK(MMHAEDBNPJE BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DIPHKEHFIPN> HMDEIJPJEPL(MMHAEDBNPJE BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DIPHKEHFIPN NIGMAMGNGKF(MMHAEDBNPJE BHFLBALEEDF, string MJIAGEIMKKC);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DIPHKEHFIPN KNOLNEDOJJI(MMHAEDBNPJE BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IFCGPJGJDHF(MMHAEDBNPJE BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IHNCPCALLPO(MMHAEDBNPJE BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task NGLAMLCJDBK();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OHENOMKAOJH(DIPHKEHFIPN JDFCBBCKOGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IEKKMGGMCFO
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	IHAJFBMKLOC IDEBEDDJJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	int NBMPGCPKDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool OOELONPJFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool JPDGPDILGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool ABOGNDEAOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool OIFPFBBJIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool GOPOBGJDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	bool HJNIOHNJCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	bool GJABCNOIPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool JBHIGKEDHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	bool IEKDCKIDGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	bool AOFMGIIDPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FAPFENDLFMK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action KNFJCBHEKGD;

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AIKJELDGMEB<FPEENFNKEAH> EBGGKAOFEON(int OCHPGIEAOKE);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BFMPGGMMDDD KDDJPFJBAJI(DateTime IGJJLAPKDJL);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	BFMPGGMMDDD CKLOKFCGBAA(string LEOCENBGHEP);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task NHEAINGEONK([Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum DKHJILFHFAL
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class EODPOHDBCMB
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7820890", Offset = "0x781F690", VA = "0x187820890")]
	public static string PHBBEEAKMCP(this DKHJILFHFAL OLKFCFIJLPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface GFBIHCCMDAI
{
	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<DIPHKEHFIPN>> MHIELDIAKOC(MMHAEDBNPJE BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OHENOMKAOJH(string MJIAGEIMKKC);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface LGOOPMIBOEN
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OOCDNOMBNPA> KMCMHJKKCAI();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface OJGJINOLMEI
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIKJELDGMEB<List<FKGJBFAFIJO>> FPCHEGIMODL();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIKJELDGMEB<List<FKGJBFAFIJO>> ADDBLDKHKNM();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<FKGJBFAFIJO>> HFIGJLIHEII([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AIKJELDGMEB<List<FKGJBFAFIJO>> MPDMJLENLFD(List<EPADPFJDNDI> JECFKPLBKPB);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AIKJELDGMEB<List<FKGJBFAFIJO>> MCFNMCPIENM(List<EPADPFJDNDI> JECFKPLBKPB);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface ELAOGMGNFOO
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	List<DELIHCCELHP> LJFEHBMLANI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<CKDOJJMBIIA> MLCMECILFDA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<DELIHCCELHP> EOJJNABDBOD;

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BFMPGGMMDDD POBOMAKNCDC(DELIHCCELHP PLAEHGJHGJO);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task LLCLBFBNDNI(DELIHCCELHP PLAEHGJHGJO);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	AIKJELDGMEB<DELIHCCELHP> ALENLMAMMMK(LBBELABPADG KKBNGKDBMPF, LBBELABPADG? MLCBDADCOEG, bool ILEFOONCKKI, string JDFCBBCKOGJ);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIKJELDGMEB<DELIHCCELHP> ALENLMAMMMK(LBBELABPADG KKBNGKDBMPF, string JDFCBBCKOGJ);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DCJLJKIFOLL(DELIHCCELHP ONFDOCMIAPO, bool MJGCFDFBOFN = false, bool ANEIEACEJJP = false, bool DKDMBPECLPP = true);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AIKJELDGMEB<List<DELIHCCELHP>> KNFGAKFBECM();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface HDHLPPECPFG
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string CGFMPJHBLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	bool PJJGNJIKBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFMPGGMMDDD CNLBKJPMMHA();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFMPGGMMDDD NEFAEKNBJHF(string PJODHDFMPBH, string MHDNKAMLPAC);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BFMPGGMMDDD JPBKOHMPCIK(string JIJCMIOCLKI);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJHEKHJDKOG();

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<NAMGDPMJAFA> OLHIIPAPIEP(string LEOCENBGHEP, string JIJCMIOCLKI, bool FIFFEOEAACD, string KKIDBEKIOHE, string HNBEMIKFNFH, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DFFHBCFEJIO(int OCHPGIEAOKE, string PJOAPNAGPHA, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task KKBGKJMEAEA(int OCHPGIEAOKE, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task MNIBAFJNDAK([Optional] DKHJILFHFAL? DONMFGHOCOI, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<ABMMAIHICGI>> BJABKKICFLM([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task CIBBKCEBBAB([Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BLJMCJPKDGJ
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<LBLDOLHGJNH>> MNHNCHACLMN([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<APJBNIJELJM>> AJFNKDLBEFJ([Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface NOIMACDODIH
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HLKGGPCKOEG([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBGHIEODIJB();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface HCMABFALJJO
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event IIMICOKMEOH? OIHPENDAFBJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IIMICOKMEOH? JFPABIONIOP;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event IIMICOKMEOH? GCCLPCBFOHB;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<DBKPFJPOFHC> CPJPLBJKAHE();

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<DBKPFJPOFHC?>? MOODDBBFEEA(int OCHPGIEAOKE);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<KHNCFBICHGM>> MLIIJKHEMCC(List<int> MGPNGCCNFHA);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, DBKPFJPOFHC>> FBHODJMABBC();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<DBKPFJPOFHC?>?>? EJGBIEFBOJH(int OCHPGIEAOKE);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task GNMLIIJAMHC(int HPEFGPPMOIE);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KNPLFMAGNCA> JOOFDJCMALN(DBKPFJPOFHC AFPCNDFAMIF);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate void IIMICOKMEOH(int OCHPGIEAOKE, int HPEFGPPMOIE, DBKPFJPOFHC? AFPCNDFAMIF);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface NKFKONJEHCF : AEOIKJMMBBH, DONALMEIJCK
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[Flags]
	public enum HOFAKEEAEJK
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	string FCLBMPOFCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	ONMPCBKJNPC HKGDJPJCIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	LGBPLMEOAKA GPHGECLOBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	string MELGGCOLAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	byte MMBJOAHJJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	int GNAKBOKGEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	int PAPDPLFOAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool MBJJPKDLLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool PIPFIGICFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool HPPMCCPIIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool FKFCOOMPLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	bool KKKGMNHJEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	bool CFLCCAIPOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	bool PNCGBKHIAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AIKJELDGMEB<string> CIHPEOGOHJC();

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> MKCOILCLFML();

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AIKJELDGMEB<bool> IsPlayerCommunicationRestricted(int OCHPGIEAOKE);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string LILOPMEDHGG(string PFLDDMDPCBI, bool LDDPEKCAFGH = true);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> OADJJHELLDF(string PFLDDMDPCBI, bool LDDPEKCAFGH = true);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "18")]
	AIKJELDGMEB<string> MakeRoomNameAdhereToPlatformRequirements(long MDNJLMOPJKG, string PFLDDMDPCBI);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string IECOGBHGGAA, HOFAKEEAEJK HKFNPDPFNIK = HOFAKEEAEJK.FilterProfanity | HOFAKEEAEJK.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string IECOGBHGGAA, HOFAKEEAEJK HKFNPDPFNIK = HOFAKEEAEJK.FilterProfanity | HOFAKEEAEJK.FilterURL, bool KLOGLKFLIMP = false);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string PFLDDMDPCBI, HOFAKEEAEJK HKFNPDPFNIK = HOFAKEEAEJK.FilterProfanity | HOFAKEEAEJK.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "23")]
	AIKJELDGMEB<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LPACJLHEDBC
{
	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<DCPABEHKCLI>> AOBDDBFKNBL([Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface JLNAFPBIDKA
{
	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIHDLFKNLBP(byte[] HOHPDECNKDA, byte[] JGDCKIHGHKM);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface JCBDJGGAGII
{
	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GLAFENCJPDI(string EDGNKLMMKMD);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NNLLLHMEMPI
{
	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	GBCEOPMAPJH<CKFBPBDMNJI> MOANKPIHNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> LEPOKONNFJK(string HPEDPAFLMJB);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HALPDBENFHB> CGAFNKOCJNA(string HPEDPAFLMJB, string GBAKGKMHJHG);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task CONACMKFIOC(string HPEDPAFLMJB, IEnumerable<string> GGJLDDNEKHI, int MNDABBGPMEP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<LBBCKEKMIBK<FilteredTextDTO>>> DDADLCLCBPD(uint AMAOPHEHBIK, IEnumerable<string> GGJLDDNEKHI);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface MPKAAKMHGGH
{
	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCCHFCJCNIC([Out] bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BLLKLFDBGDI([Out] bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PKNCJDOHLJM([Out] int HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DCLPKIDAKJH([Out] bool HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum JEFOAGFFMFK
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum LDKLNOMDMED
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
public enum MAPKKIIIPIH
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
public enum OOHPKKGGIGD
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
public enum LEOIAOMEAGN
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
public enum GDIJGHEBEKG
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
public interface FPEENFNKEAH
{
	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int NBKBDJDGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string LOAEPDLEEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	string JCPKGPEJPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	string FLIJPJIHMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	string CFOMLJJEOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	string LGAPPJIHHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	string BKNOEPEDFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool DPHJJDJAHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	bool JCBAPFFNCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	MAPKKIIIPIH FDOKNPHMNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	OOHPKKGGIGD JHNDHMNKCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	bool? LJPLFNPFBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MAEAKJHCCNG(bool ELGEBDLIHOM);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BBDLACFDLLH(bool OGLNHKDNLGO);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface IHAJFBMKLOC : FPEENFNKEAH
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	string AIJFOPDPGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	string LJGPPEKHIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	DateTime? HBOCOMPIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	JEFOAGFFMFK MPBIEKJAGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	int? LGJLDDDKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	int EICGFLGKCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	bool HCKBFNKHJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	bool GJHDJLEDDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	bool? GBBHFLNKDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class EAOEJKPPNKE
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public FPEENFNKEAH FKMKMOCHKGC
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public LDKLNOMDMED OBIBIEMDAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(LDKLNOMDMED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public string KFMDFPJOILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x71BD030", Offset = "0x71BBE30", VA = "0x1871BD030")]
	public EAOEJKPPNKE(FPEENFNKEAH HKLALGGFIFC, LDKLNOMDMED CFLNFDPPIBP, string OEGCDOAEKID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface PMGJJIGEOGE
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	int NBKBDJDGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	bool JFCLEDAMLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface LHFNLOCIBJP
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	int NBKBDJDGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	bool BOHAOMCIPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface IGFNHAMPDJB
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	int NBKBDJDGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	string CJOLOJOONFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum BFHAFIEPAFC
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class FKGJBFAFIJO
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public BFHAFIEPAFC IOCECBFENDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(BFHAFIEPAFC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public string NLICGKBFGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public AHJINCPIKDJ FMMFMMDFBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(AHJINCPIKDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string GBBIGKHIFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public int GLPGLCAOIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool OEONEBMIGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xFBC1B0", Offset = "0xFBAFB0", VA = "0x180FBC1B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xFBC1A0", Offset = "0xFBAFA0", VA = "0x180FBC1A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public EPADPFJDNDI AGOAHOKJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x155BCA0", Offset = "0x155AAA0", VA = "0x18155BCA0")]
		[CompilerGenerated]
		get
		{
			return default(EPADPFJDNDI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x78216F0", Offset = "0x78204F0", VA = "0x1878216F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public OEOJAONNJFH MAGCBNOCOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1C31E80", Offset = "0x1C30C80", VA = "0x181C31E80")]
		[CompilerGenerated]
		get
		{
			return default(OEOJAONNJFH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x4A49090", Offset = "0x4A47E90", VA = "0x184A49090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string EEJLFILAGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE70", Offset = "0xA9DC70", VA = "0x180A9EE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDA0", Offset = "0xA9DBA0", VA = "0x180A9EDA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEE0", Offset = "0xA9DCE0", VA = "0x180A9EEE0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x4FBC940", Offset = "0x4FBB740", VA = "0x184FBC940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7821710", Offset = "0x7820510", VA = "0x187821710")]
	internal FKGJBFAFIJO(FEGDNJNAODO GNMAIIPILPF, EFOAHIEBMAB EEDIEBACHIN, NHIJPMINOCB LJIELAOKOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7821970", Offset = "0x7820770", VA = "0x187821970")]
	public FKGJBFAFIJO(BFHAFIEPAFC NIMLECJPMAA = BFHAFIEPAFC.Outfit, [Optional] EPADPFJDNDI CHMBDGDHBJN, [Optional] string CGDIPBADIMH, [Optional] string HLNDOAJKLDD, AHJINCPIKDJ GBMAFBGIJBI = AHJINCPIKDJ.Common, [Optional] string KKEAMJJCKHK, int DCAPIGMJMIJ = 0, bool JJNGHNIBCIP = false, [Optional] string EFJIJMEJHNP, [Optional] DateTime? LAIMBCDDMHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[MBIAOMFNMDN]
public class FEGDNJNAODO : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public BFHAFIEPAFC IOCECBFENDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(BFHAFIEPAFC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	[DataMember(Name = "AvatarItemDesc")]
	public string GLEAANCHNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string NLICGKBFGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public AHJINCPIKDJ FMMFMMDFBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xAA2200", Offset = "0xAA1000", VA = "0x180AA2200")]
		[CompilerGenerated]
		get
		{
			return default(AHJINCPIKDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA23A0", Offset = "0xAA11A0", VA = "0x180AA23A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string GBBIGKHIFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int GLPGLCAOIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xB169F0", Offset = "0xB157F0", VA = "0x180B169F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool OEONEBMIGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1973EF0", Offset = "0x1972CF0", VA = "0x181973EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1984A80", Offset = "0x1983880", VA = "0x181984A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public string IOMCKAANFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xFBCE50", Offset = "0xFBBC50", VA = "0x180FBCE50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FEGDNJNAODO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[MBIAOMFNMDN]
public sealed class AHLACGEMDOD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public List<string> NOFCDECGFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x781D1F0", Offset = "0x781BFF0", VA = "0x18781D1F0")]
	public AHLACGEMDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public AHLACGEMDOD(List<string> JECFKPLBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[MBIAOMFNMDN]
public class OOCDNOMBNPA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public KPBGGDGGMBF IPPLCDMGONO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public AEIDABAJKBH DIHFGDJGBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OOCDNOMBNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public OOCDNOMBNPA(KPBGGDGGMBF NMKIPCDJICN, AEIDABAJKBH MJANPPEEJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum PPELIFDNGKB
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum BEMCPMBCBNI : byte
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
[MBIAOMFNMDN]
public class KPBGGDGGMBF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public PPELIFDNGKB FPAKNFBDOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(PPELIFDNGKB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public BEMCPMBCBNI? EGPCLHELDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x31E82B0", Offset = "0x31E70B0", VA = "0x1831E82B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x76BC400", Offset = "0x76BB200", VA = "0x1876BC400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool JCLANPLBDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2072680", Offset = "0x2071480", VA = "0x182072680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2072670", Offset = "0x2071470", VA = "0x182072670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7826490", Offset = "0x7825290", VA = "0x187826490")]
	public KPBGGDGGMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x78264A0", Offset = "0x78252A0", VA = "0x1878264A0")]
	public KPBGGDGGMBF(PPELIFDNGKB IPHOEJOPOPC, BEMCPMBCBNI JPEPBOBBJLB, bool LBPMDIJGMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[MBIAOMFNMDN]
public class AEIDABAJKBH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public string FPFDNKHHPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public string LCJBAOJCGID
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AEIDABAJKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public AEIDABAJKBH(string CMPIDHAGPHM, string FBEFKPBJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum ONMPCBKJNPC
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
public struct CKDOJJMBIIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public DELIHCCELHP HKPNMLAFPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public bool OOKINCGOLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool CCMLGCJGPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public bool DMFANCMCAAP;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[MBIAOMFNMDN]
public class DELIHCCELHP : HPMMHONDJKB, HHPMDFAHMHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct AGIOPENHMNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public DELIHCCELHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x781CEE0", Offset = "0x781BCE0", VA = "0x18781CEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x781D070", Offset = "0x781BE70", VA = "0x18781D070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal static Action<DELIHCCELHP> BFOGPHJJHGG;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal static Func<DELIHCCELHP, Task> NJCLKFGBECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[IgnoreDataMember]
	public bool DPLMPJJCGMB;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public long? FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public int ANJGCGGKKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public int? CCMJGKGLIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x13C5A20", Offset = "0x13C4820", VA = "0x1813C5A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1089DB0", Offset = "0x1088BB0", VA = "0x181089DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public string MFPOJMEDJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public BFHAFIEPAFC? IOCECBFENDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAA2020", Offset = "0xAA0E20", VA = "0x180AA2020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	[DataMember(Name = "AvatarItemDesc")]
	public string HPIMOHKEPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Guid? JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x781FEA0", Offset = "0x781ECA0", VA = "0x18781FEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x781FDC0", Offset = "0x781EBC0", VA = "0x18781FDC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public string MJBNAIIBHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public string KJEODJOOEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA93200", Offset = "0xA92000", VA = "0x180A93200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public COKNLBOGDAO KNPAPNNIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xABC1F0", Offset = "0xABAFF0", VA = "0x180ABC1F0")]
		[CompilerGenerated]
		get
		{
			return default(COKNLBOGDAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x15BB3B0", Offset = "0x15BA1B0", VA = "0x1815BB3B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public int KDKMBFLPDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xABC250", Offset = "0xABB050", VA = "0x180ABC250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x15BB380", Offset = "0x15BA180", VA = "0x1815BB380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public int KJDDINEDLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xB1E4F0", Offset = "0xB1D2F0", VA = "0x180B1E4F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x160BD10", Offset = "0x160AB10", VA = "0x18160BD10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public LBBELABPADG FCEBPIFNAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xB1E530", Offset = "0xB1D330", VA = "0x180B1E530")]
		[CompilerGenerated]
		get
		{
			return default(LBBELABPADG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x160BB40", Offset = "0x160A940", VA = "0x18160BB40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public AHJINCPIKDJ FNNOJMNLDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xD679D0", Offset = "0xD667D0", VA = "0x180D679D0")]
		[CompilerGenerated]
		get
		{
			return default(AHJINCPIKDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x15DD8D0", Offset = "0x15DC6D0", VA = "0x1815DD8D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	[DataMember(Name = "Message")]
	public string DAFNMHLIJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEE0", Offset = "0xA9DCE0", VA = "0x180A9EEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDF0", Offset = "0xA9DBF0", VA = "0x180A9EDF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public string PEFBAPGODLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xB633E0", Offset = "0xB621E0", VA = "0x180B633E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool AJBEMEPKKHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xFBC190", Offset = "0xFBAF90", VA = "0x180FBC190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xFBCA80", Offset = "0xFBB880", VA = "0x180FBCA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public LGBPLMEOAKA GPHGECLOBFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xF3D3C0", Offset = "0xF3C1C0", VA = "0x180F3D3C0")]
		[CompilerGenerated]
		get
		{
			return default(LGBPLMEOAKA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xF3B3C0", Offset = "0xF3A1C0", VA = "0x180F3B3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public MALLPKNKEKG LCIIGDBHCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE10", Offset = "0xA9DC10", VA = "0x180A9EE10")]
		[CompilerGenerated]
		get
		{
			return default(MALLPKNKEKG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE20", Offset = "0xA9DC20", VA = "0x180A9EE20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public KNHAMAEBGGK? NCMMEBNICBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x150E330", Offset = "0x150D130", VA = "0x18150E330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x781FFB0", Offset = "0x781EDB0", VA = "0x18781FFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool OEENDHANJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x781FF20", Offset = "0x781ED20", VA = "0x18781FF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool KFPODEJKGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x781FFC0", Offset = "0x781EDC0", VA = "0x18781FFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool ABJGKEBMDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x781FF90", Offset = "0x781ED90", VA = "0x18781FF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	[IgnoreDataMember]
	public bool COOHGLEBBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA39C0", Offset = "0xAA27C0", VA = "0x180AA39C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA39E0", Offset = "0xAA27E0", VA = "0x180AA39E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	[IgnoreDataMember]
	public bool HCIMLNOEIII
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E815F0", Offset = "0x2E803F0", VA = "0x182E815F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2E81390", Offset = "0x2E80190", VA = "0x182E81390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	[IgnoreDataMember]
	public string APKHNGFMBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xB631D0", Offset = "0xB61FD0", VA = "0x180B631D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xB633B0", Offset = "0xB621B0", VA = "0x180B633B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	[IgnoreDataMember]
	public string OJCMJCAKDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xEB9C60", Offset = "0xEB8A60", VA = "0x180EB9C60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xEB9C70", Offset = "0xEB8A70", VA = "0x180EB9C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	[IgnoreDataMember]
	public bool JONJMAJOMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A80", Offset = "0x10B0880", VA = "0x1810B1A80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xD4E100", Offset = "0xD4CF00", VA = "0x180D4E100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x781FEC0", Offset = "0x781ECC0", VA = "0x18781FEC0", Slot = "5")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x781FDD0", Offset = "0x781EBD0", VA = "0x18781FDD0", Slot = "6")]
	[AsyncStateMachine(typeof(AGIOPENHMNM))]
	public virtual Task BCLOKBHDFOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x160BB40", Offset = "0x160A940", VA = "0x18160BB40")]
	public void JPOLEHCIDBE(LBBELABPADG KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DELIHCCELHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface ODHPKKHBEJF
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	long GKDFEGBHHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string FFIJPBJLOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	int PAIEKLADKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	string FCEMPAIADHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	string PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	byte ENIMBHPOODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	int KFNMOONNPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int FIMEOHIFPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IHPKKIOOIAO EOKIEPCGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	bool KKNMHCPFCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	DateTime PGHCONMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	DateTime? DFFDHDHBPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	long? JJNJOCMEBON
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	int JABBEHILCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	int PHJNCEEPONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	int KEKIJAGDIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	DNLALIJEMOE AHNMDIJAHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	DNLALIJEMOE DMHGLCBMMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool MCJMMEPMNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	bool IBBMGGLBEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	bool BKIDNIOCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	bool GNBANCLEIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int? IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool AEJJKECPMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	string PGCBMMMDIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDLGEONLBMM();

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHFCKLJCDEH();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[MBIAOMFNMDN]
public class MJPIKDOKFLN : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public List<BHHJAGFLBGH> OIGDAHHELLH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7826DE0", Offset = "0x7825BE0", VA = "0x187826DE0")]
	public List<string> CAJIJLPELFH(params JEIDIJJBPCC[] DLPOKKPPFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x78270E0", Offset = "0x7825EE0", VA = "0x1878270E0")]
	public List<string> POOMPEJNJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7827090", Offset = "0x7825E90", VA = "0x187827090")]
	public List<string> NKOFDOKOAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7826FA0", Offset = "0x7825DA0", VA = "0x187826FA0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MJPIKDOKFLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[MBIAOMFNMDN]
public class OLELHBPDGBH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int PAIEKLADKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OLELHBPDGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[MBIAOMFNMDN]
public class ACNHFGCECMA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public long GKDFEGBHHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public string FFIJPBJLOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int OCOAEDMDKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool EPJBCGKINJP
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xE8D440", Offset = "0xE8C240", VA = "0x180E8D440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xE8D060", Offset = "0xE8BE60", VA = "0x180E8D060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int OPOFKOMADIL
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int GJKDFOBLKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x168AAA0", Offset = "0x16898A0", VA = "0x18168AAA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public int EHFMHIPMPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xAA2200", Offset = "0xAA1000", VA = "0x180AA2200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xAA23A0", Offset = "0xAA11A0", VA = "0x180AA23A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int IFLCCEDDDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DB0", Offset = "0xAD4BB0", VA = "0x180AD5DB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xAD5080", Offset = "0xAD3E80", VA = "0x180AD5080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public string GCGPFHICKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public string KEDEKBEDGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x13D4C20", Offset = "0x13D3A20", VA = "0x1813D4C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public IHPKKIOOIAO? MAGKHBHCFDC
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xFBCE50", Offset = "0xFBBC50", VA = "0x180FBCE50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public IReadOnlyList<Guid> OFLHKKCCCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public PEDNEEGBGKL CCCFFIPFCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x781CC40", Offset = "0x781BA40", VA = "0x18781CC40")]
		get
		{
			return default(PEDNEEGBGKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x781CBC0", Offset = "0x781B9C0", VA = "0x18781CBC0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x781CE70", Offset = "0x781BC70", VA = "0x18781CE70")]
	public bool PLPDMPBLIKB(ACNHFGCECMA FHFOBDIAEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x781CC90", Offset = "0x781BA90", VA = "0x18781CC90")]
	private bool IIMDODAAHDA(ACNHFGCECMA FHFOBDIAEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x781CB20", Offset = "0x781B920", VA = "0x18781CB20")]
	private static bool ELIHLHKBNLJ(IReadOnlyList<Guid> AIBJJAMMPEC, IReadOnlyList<Guid> LEDLOOEGIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9E60", Offset = "0x2AC8C60", VA = "0x182AC9E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ACNHFGCECMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[MBIAOMFNMDN]
public class PANIJBDKBJH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public int GKGDODHFGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PANIJBDKBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[MBIAOMFNMDN]
public class MKMKLHHNNIE : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool FFCOKMJGJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MKMKLHHNNIE()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[MBIAOMFNMDN]
	public class NewInventionRequestDTO : HHPMDFAHMHN
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
		public DPLLHLFGGEJ creatorAccountRole;

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
		[Cpp2IlInjected.Address(RVA = "0x106F330", Offset = "0x106E130", VA = "0x18106F330", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x78277C0", Offset = "0x78265C0", VA = "0x1878277C0")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[MBIAOMFNMDN]
	public class AddVersionInventionRequestDTO : HHPMDFAHMHN
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
		[Cpp2IlInjected.Address(RVA = "0x106F330", Offset = "0x106E130", VA = "0x18106F330", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x781D580", Offset = "0x781C380", VA = "0x18781D580")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[MBIAOMFNMDN]
	public class ModifyTagsRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[MBIAOMFNMDN]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[MBIAOMFNMDN]
	public class ReportRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public ABNGKNPBFKP ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[MBIAOMFNMDN]
	public class CheerRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[MBIAOMFNMDN]
	public class UpdatePriceRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[MBIAOMFNMDN]
	public class UpdateInventionMetadataRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x106F330", Offset = "0x106E130", VA = "0x18106F330", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[MBIAOMFNMDN]
	public class UpdateInventionGeneralPermissionRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public DNLALIJEMOE Permission
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(DNLALIJEMOE);
			}
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[MBIAOMFNMDN]
	public class PublishInventionRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public DNLALIJEMOE Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(DNLALIJEMOE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public IHPKKIOOIAO Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			[CompilerGenerated]
			get
			{
				return default(IHPKKIOOIAO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[MBIAOMFNMDN]
	public class UnpublishInventionRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[MBIAOMFNMDN]
	public class DeleteInventionRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[MBIAOMFNMDN]
	public class SetInventionVersionAccessibilityRequest : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public IHPKKIOOIAO NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			[CompilerGenerated]
			get
			{
				return default(IHPKKIOOIAO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[MBIAOMFNMDN]
	public class SpecialTags : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum DHPODAELFAK
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
public enum ABNGKNPBFKP
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
public enum GCPFGIGJDBP
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface ABMMAIHICGI
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	LGBPLMEOAKA GPHGECLOBFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	string MELGGCOLAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	int NBKBDJDGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	DateTime EGHAGOBFJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool PKNDINCLIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string CNDIBNEKHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	FPEENFNKEAH FKMKMOCHKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DEABHIFMEFG();

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EMBAHEDKKPE(FPEENFNKEAH HKLALGGFIFC);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface GADDGDCCPEP
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	string JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	bool GBMOCIJNDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEABHIFMEFG();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct NAMGDPMJAFA
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public DCAHJJJJJDE MCBGFBIKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780")]
		[CompilerGenerated]
		readonly get
		{
			return default(DCAHJJJJJDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public GADDGDCCPEP CMBFIIEPEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8B0", Offset = "0xB3B6B0", VA = "0x180B3C8B0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xF31A70", Offset = "0xF30870", VA = "0x180F31A70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public string EGDEPANIJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6255FB0", Offset = "0x6254DB0", VA = "0x186255FB0")]
	public NAMGDPMJAFA(DCAHJJJJJDE BEGHOHJIGBF, [Optional] GADDGDCCPEP LPLFKLLGKMH, [Optional] string HNBEMIKFNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum DCAHJJJJJDE
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
[MBIAOMFNMDN]
public class NOGGDPPBLAP : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string CIBCMLGLGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NOGGDPPBLAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[MBIAOMFNMDN]
public class LBLDOLHGJNH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string NKKNFLJNLII
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string GMPJPJJAKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string DJDNPNFKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public string FFBFIHEECFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public List<DCEGPBHMNNA> KLPCIBGPCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LBLDOLHGJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FA40", Offset = "0x4F6E840", VA = "0x184F6FA40")]
	public LBLDOLHGJNH([Optional] string JIGJPCOOJHE, [Optional] string POOLFGMOBNO, [Optional] string NGEEBLCBCMJ, [Optional] string JLPFMFJLFJA, [Optional] List<DCEGPBHMNNA> DGGFBFHFHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[MBIAOMFNMDN]
public class DCEGPBHMNNA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public string LOPBKCLEGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public string FFBFIHEECFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DCEGPBHMNNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[MBIAOMFNMDN]
public class APJBNIJELJM : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string GMPJPJJAKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public string MCBGFBIKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public string NKKNFLJNLII
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public List<string> CFLCFOOBLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public APJBNIJELJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[MBIAOMFNMDN]
public interface HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEABHIFMEFG();
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[MBIAOMFNMDN]
public interface HPMMHONDJKB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BCLOKBHDFOD();
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[OGABCAMHDIH]
public interface GGHMLGOOCJO : HHPMDFAHMHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[MBIAOMFNMDN]
public class MAAJLACIBNH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public int ALGBMMFFJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public string EOJOCMJKAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public string HAKOGLOKKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MAAJLACIBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x7826CA0", Offset = "0x7825AA0", VA = "0x187826CA0")]
	public MAAJLACIBNH([Optional] Guid PJJIOIOLAMC, int DPNGCNNOBCC = 0, [Optional] string HNKCBMNKHLP, [Optional] string JAOPIBAJPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[MBIAOMFNMDN]
public class DBKPFJPOFHC : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public const int ICMIADMJGGA = 0;

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public long CBFHDCJCLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public IGLMKMBJILH HMHABFKAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public string LKOFCJOIAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public List<MAAJLACIBNH> KAMGIOMCCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public int GHHMAEBJKBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA2200", Offset = "0xAA1000", VA = "0x180AA2200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA23A0", Offset = "0xAA11A0", VA = "0x180AA23A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public IHPKKIOOIAO EOKIEPCGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
		[CompilerGenerated]
		get
		{
			return default(IHPKKIOOIAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xB169F0", Offset = "0xB157F0", VA = "0x180B169F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public string MFALKFEKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public bool LGPJPNOAPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2168030", Offset = "0x2166E30", VA = "0x182168030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x781FB60", Offset = "0x781E960", VA = "0x18781FB60")]
	public DBKPFJPOFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x781FA40", Offset = "0x781E840", VA = "0x18781FA40")]
	public DBKPFJPOFHC(long LJBKHNDOECM = 0L, [Optional] IGLMKMBJILH FODNKAPAJOP, [Optional] string AFKLAOKOGBI, [Optional] List<MAAJLACIBNH> IDCBPNENJGG, int HPEFGPPMOIE = 0, [Optional] string PFLDDMDPCBI, IHPKKIOOIAO FHOECEOGNGE = IHPKKIOOIAO.Private, [Optional] string COPJMBHFBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class KHNCFBICHGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public readonly int NBKBDJDGPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public readonly DBKPFJPOFHC NDNHAKEMEMD;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x105CC60", Offset = "0x105BA60", VA = "0x18105CC60")]
	public KHNCFBICHGM(int OCHPGIEAOKE, DBKPFJPOFHC AFPCNDFAMIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[MBIAOMFNMDN]
public class IGLMKMBJILH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public string FPKGIJFBAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public string IKNCHAIKOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public string KFHDNDNGGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public string IMBFIGGJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public string HDCGPIHAIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public string KAMGIOMCCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x7823240", Offset = "0x7822040", VA = "0x187823240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public IGLMKMBJILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FA40", Offset = "0x4F6E840", VA = "0x184F6FA40")]
	public IGLMKMBJILH([Optional] string FHGMKDFAJNH, [Optional] string PPPPHLPEOEI, [Optional] string NGMHLIHHOJH, [Optional] string GICOGPHOODF, [Optional] string NPHMCJPPIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[MBIAOMFNMDN]
public class LIPLJOBENGB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public Dictionary<int, DBKPFJPOFHC> BHPOEBBFFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LIPLJOBENGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[MBIAOMFNMDN]
public class ECMFLHGPOMN : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public List<int> MFNCAIIGGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public byte? MMBJOAHJJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x31EEAE0", Offset = "0x31ED8E0", VA = "0x1831EEAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x31EEAF0", Offset = "0x31ED8F0", VA = "0x1831EEAF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public int? GNAKBOKGEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x13C5A10", Offset = "0x13C4810", VA = "0x1813C5A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x13C5A40", Offset = "0x13C4840", VA = "0x1813C5A40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ECMFLHGPOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class GMLAPHAGHDL
{
	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x78226A0", Offset = "0x78214A0", VA = "0x1878226A0")]
	public static ECJGOBMDJGD ENAFIPJGLDO(this MAAJLACIBNH DBBEADIHLKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
public enum MALLPKNKEKG
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
public enum LGBPLMEOAKA
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
[MBIAOMFNMDN]
public class KNABHGFKPEO : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	[DataMember(Name = "PlayerId")]
	public int NBKBDJDGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int LFDJBJPJPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public int PIBNJGEKBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KNABHGFKPEO()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[MBIAOMFNMDN]
	public class ProgressionEventRecordDTO : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public int NBKBDJDGPIC
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public int KJDDINEDLFD
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public int JCPAHEABDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int OMCAINDEFNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public int FCIFAAMLOFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public DateTime? MHBLCLBOBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x141B2F0", Offset = "0x141A0F0", VA = "0x18141B2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x1553FB0", Offset = "0x1552DB0", VA = "0x181553FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public int FFBGBGFHELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7828710", Offset = "0x7827510", VA = "0x187828710")]
		public ProgressionEventRecordDTO(int OCHPGIEAOKE = 0, int BHHAIJDHOBO = 0, int MHMPHBBHEMP = 0, int ICAIOELNKOO = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[MBIAOMFNMDN]
	public class ProgressionEventDTO : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public long FCGOLOGDJBO
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public string LBDOKALIJED
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public List<ProgressionEventRewardDTO> AFDPJNLDIPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public List<KeepsakeRoomListDTO> CADAKJNGKOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public DateTime PCMHDJHOPIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xA98B70", Offset = "0xA97970", VA = "0x180A98B70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public DateTime LKALADIEKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAA2020", Offset = "0xAA0E20", VA = "0x180AA2020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public DateTime ONEDGHEAJFD
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xFBCAA0", Offset = "0xFBB8A0", VA = "0x180FBCAA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public bool HBCABFLIPCN
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xD913B0", Offset = "0xD901B0", VA = "0x180D913B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xDACDA0", Offset = "0xDABBA0", VA = "0x180DACDA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public int OPAJEOLOCLH
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x14AEA20", Offset = "0x14AD820", VA = "0x1814AEA20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x2317A50", Offset = "0x2316850", VA = "0x182317A50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public float DMPNHEBLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x1284C80", Offset = "0x1283A80", VA = "0x181284C80")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x1459A90", Offset = "0x1458890", VA = "0x181459A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Guid? OKKBIBBOIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x7828630", Offset = "0x7827430", VA = "0x187828630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x7828650", Offset = "0x7827450", VA = "0x187828650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public string GADGNNPCNBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xA93200", Offset = "0xA92000", VA = "0x180A93200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public string KBJKDGCKFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xA98250", Offset = "0xA97050", VA = "0x180A98250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public string OGAGGOOIPHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xA9EEB0", Offset = "0xA9DCB0", VA = "0x180A9EEB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xA9EE90", Offset = "0xA9DC90", VA = "0x180A9EE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public string GHLODPOONFA
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xA9EE70", Offset = "0xA9DC70", VA = "0x180A9EE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA9EDA0", Offset = "0xA9DBA0", VA = "0x180A9EDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7828660", Offset = "0x7827460", VA = "0x187828660")]
		public ProgressionEventDTO(long PLJIDOFCCEP = 0L, [Optional] string PFLDDMDPCBI, [Optional] List<ProgressionEventRewardDTO> AMBJHAPKOLF, [Optional] List<KeepsakeRoomListDTO> BFNNCIKEGJK, [Optional] DateTime FNCCBDMLILN, [Optional] DateTime MAEDMBKLJNJ, [Optional] DateTime INPPDEGBAFC, bool HDLJPLLODHG = false, int BFDGLHFMONG = 0, float KHAINOCKMLE = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[MBIAOMFNMDN]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public long CMNBBEFIOFP
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public long FCGOLOGDJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public int? JLJLDLBHGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public int? OIABANJBGNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA98AC0", Offset = "0xA978C0", VA = "0x180A98AC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public long? MIDLJPPOEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xF5AAD0", Offset = "0xF598D0", VA = "0x180F5AAD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xF5A8A0", Offset = "0xF596A0", VA = "0x180F5A8A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public long DMLIGFIMIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xFBCAA0", Offset = "0xFBB8A0", VA = "0x180FBCAA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public TimeSpan FHLMJHLFJDD
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x7826610", Offset = "0x7825410", VA = "0x187826610")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public long BOFENLOLILM
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x13D4C20", Offset = "0x13D3A20", VA = "0x1813D4C20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public TimeSpan OGKPLMGFADK
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x7826660", Offset = "0x7825460", VA = "0x187826660")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public int PDHNIDALOPM
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xEA1460", Offset = "0xEA0260", VA = "0x180EA1460")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xFF01B0", Offset = "0xFEEFB0", VA = "0x180FF01B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public FPKMMDCDBCK LHIKBCAJGME
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x12FCE00", Offset = "0x12FBC00", VA = "0x1812FCE00")]
			[CompilerGenerated]
			get
			{
				return default(FPKMMDCDBCK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x24F0950", Offset = "0x24EF750", VA = "0x1824F0950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public List<KeepsakeRoomDTO> OOFAPMFBIKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x78266B0", Offset = "0x78254B0", VA = "0x1878266B0")]
		public KeepsakeRoomListDTO(long PNLNCBFPHNC = 0L, long PLJIDOFCCEP = 0L, [Optional] int? PEMPJOOKEKH, [Optional] int? EDKHGBJOKBC, [Optional] long? BLLKEKEPGBE, long NBDBCCJIEPJ = 0L, long OMIOKJCEHOC = 0L, int IOLBOICEOOD = 0, FPKMMDCDBCK HEJFKLNCHPB = FPKMMDCDBCK.Standard, [Optional] List<KeepsakeRoomDTO> MGMJJAFEOPP)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[MBIAOMFNMDN]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public long MLGDPEBMBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public long PCLKEPGGEEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public long CMNBBEFIOFP
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public FPKMMDCDBCK FOJLLEMFFFA
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
			[CompilerGenerated]
			get
			{
				return default(FPKMMDCDBCK);
			}
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public int IICMLMPBLOO
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x168AAA0", Offset = "0x16898A0", VA = "0x18168AAA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x78265B0", Offset = "0x78253B0", VA = "0x1878265B0")]
		public KeepsakeRoomDTO(long DHJJCDMCKIC = 0L, long MDNJLMOPJKG = 0L, long PNLNCBFPHNC = 0L, FPKMMDCDBCK ADGMECOLKNH = FPKMMDCDBCK.Standard, int MBIPCKLBHPE = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[MBIAOMFNMDN]
	public class ProgressionEventRewardDTO : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public long FMFLEBCCONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public int FHOGEAAJKOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public string PHKHFNAGCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public int KJDDINEDLFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public int ADGEMECCAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x168AAA0", Offset = "0x16898A0", VA = "0x18168AAA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public bool MLDJFBHCHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xAC2300", Offset = "0xAC1100", VA = "0x180AC2300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public bool GGCEAANCEML
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xF4A830", Offset = "0xF49630", VA = "0x180F4A830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x15C3550", Offset = "0x15C2350", VA = "0x1815C3550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[MBIAOMFNMDN]
	public class ProgressionEventPurchasableXpBoostDTO : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public Guid BPJHAJHLDGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public int LNCIMPBJKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public int NAHNPNGPLJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public int GIJPJJEJEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public long BEJBLEBKBHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA98B70", Offset = "0xA97970", VA = "0x180A98B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		public long IFDKDFDLHGA
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0xAA2020", Offset = "0xAA0E20", VA = "0x180AA2020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum FPKMMDCDBCK
{
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public enum PEIKCOPGDKJ
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
[MBIAOMFNMDN]
public class DCPABEHKCLI : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public string NFHHLFGCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public string? KIBKGAHBMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DCPABEHKCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface FBHBLFFAFNF
{
	[Cpp2IlInjected.Token(Token = "0x17000201")]
	bool PNPKBINCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	string? AKEBJPNKCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	string? JONCFOGAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public interface GABDJEHJFAJ<T> : FBHBLFFAFNF
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class BFFEBLLEAOD
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3B60", Offset = "0x3AA2960", VA = "0x183AA3B60")]
	public static GABDJEHJFAJ<T> DGABKBJAOAH<T, U>(this GABDJEHJFAJ<U> MOBFLOHJOKJ, Func<U, T> ONHIJHBBEIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct OLNGAGGBCBL<T> : GABDJEHJFAJ<T>, FBHBLFFAFNF
{
	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public bool PNPKBINCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x109E800", Offset = "0x109D600", VA = "0x18109E800", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2D58AB0", Offset = "0x2D578B0", VA = "0x182D58AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public string? AKEBJPNKCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8B0", Offset = "0xB3B6B0", VA = "0x180B3C8B0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xF31A70", Offset = "0xF30870", VA = "0x180F31A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public string? JONCFOGAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B270A0", Offset = "0x5B25EA0", VA = "0x185B270A0")]
	public static OLNGAGGBCBL<T> DODKDNIAPPH(T HGMAIPELJHM)
	{
		return default(OLNGAGGBCBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B27140", Offset = "0x5B25F40", VA = "0x185B27140")]
	public static OLNGAGGBCBL<T> FKKPEONAGPN(string DFOJBJDIKPM, string ELLDNIIFBHB = "")
	{
		return default(OLNGAGGBCBL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[MBIAOMFNMDN]
public class KNPLFMAGNCA : FBHBLFFAFNF, HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public bool PNPKBINCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public string? AKEBJPNKCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	[DataMember(Name = "error_id")]
	public string? JONCFOGAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public virtual void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x7826390", Offset = "0x7825190", VA = "0x187826390")]
	public static KNPLFMAGNCA DODKDNIAPPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x7826400", Offset = "0x7825200", VA = "0x187826400")]
	public static KNPLFMAGNCA FKKPEONAGPN(string DFOJBJDIKPM, string ELLDNIIFBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KNPLFMAGNCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[CKPMFNBPEDM]
public abstract class NMBCNJBJCJP<T> : KNPLFMAGNCA, GABDJEHJFAJ<T>, FBHBLFFAFNF
{
	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	protected NMBCNJBJCJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[CKPMFNBPEDM]
public class KCFAEBENAAD<T> : NMBCNJBJCJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x55C38A0", Offset = "0x55C26A0", VA = "0x1855C38A0")]
	private static void NPLKIPIJHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x45B1FD0", Offset = "0x45B0DD0", VA = "0x1845B1FD0")]
	public KCFAEBENAAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[CKPMFNBPEDM]
public class LBBCKEKMIBK<T> : NMBCNJBJCJP<T>, HPMMHONDJKB, HHPMDFAHMHN where T : HHPMDFAHMHN, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct FIDLEEEHCJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public LBBCKEKMIBK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x4F0C170", Offset = "0x4F0AF70", VA = "0x184F0C170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x4F0C3F0", Offset = "0x4F0B1F0", VA = "0x184F0C3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5674E20", Offset = "0x5673C20", VA = "0x185674E20", Slot = "8")]
	public override void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5674D50", Offset = "0x5673B50", VA = "0x185674D50", Slot = "10")]
	[AsyncStateMachine(typeof(LBBCKEKMIBK<>.FIDLEEEHCJK))]
	public Task BCLOKBHDFOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5674EB0", Offset = "0x5673CB0", VA = "0x185674EB0")]
	public static LBBCKEKMIBK<T> DODKDNIAPPH(T HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5674FF0", Offset = "0x5673DF0", VA = "0x185674FF0")]
	public new static LBBCKEKMIBK<T> FKKPEONAGPN(string DFOJBJDIKPM, string ELLDNIIFBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
	public LBBCKEKMIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[CKPMFNBPEDM]
public class EPBCCIMCOPB<T> : NMBCNJBJCJP<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x45B1FD0", Offset = "0x45B0DD0", VA = "0x1845B1FD0")]
	public EPBCCIMCOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[CKPMFNBPEDM]
public class LNEPMEOKBGI<T> : NMBCNJBJCJP<List<T>>, HPMMHONDJKB, HHPMDFAHMHN where T : HHPMDFAHMHN, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct EEPGNEIDDKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public LNEPMEOKBGI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x4A442C0", Offset = "0x4A430C0", VA = "0x184A442C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x4A444C0", Offset = "0x4A432C0", VA = "0x184A444C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x569D3C0", Offset = "0x569C1C0", VA = "0x18569D3C0")]
	public static LNEPMEOKBGI<T> DODKDNIAPPH(List<T> HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x569D4F0", Offset = "0x569C2F0", VA = "0x18569D4F0")]
	public new static LNEPMEOKBGI<T> FKKPEONAGPN(string DFOJBJDIKPM, string ELLDNIIFBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x569D160", Offset = "0x569BF60", VA = "0x18569D160", Slot = "8")]
	public override void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x569D090", Offset = "0x569BE90", VA = "0x18569D090", Slot = "10")]
	[AsyncStateMachine(typeof(LNEPMEOKBGI<>.EEPGNEIDDKL))]
	public Task BCLOKBHDFOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5503060", Offset = "0x5501E60", VA = "0x185503060")]
	public LNEPMEOKBGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum JICFJGPJPAF
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
public static class OBIKJNBMPPK
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x7827850", Offset = "0x7826650", VA = "0x187827850")]
	public static bool ELIFONDBNPN(this JICFJGPJPAF PJFNDJALEFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x7827850", Offset = "0x7826650", VA = "0x187827850")]
	public static bool PCCNDKLOFEJ(this JICFJGPJPAF PJFNDJALEFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum COKNLBOGDAO
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
public enum KNHAMAEBGGK
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
public enum LBBELABPADG
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
public enum AHJINCPIKDJ
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
public enum IJNABNOAHHD
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
	[MBIAOMFNMDN]
	public class BalanceResponseDTO : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public COKNLBOGDAO CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(COKNLBOGDAO);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		[DataMember(Name = "Platform")]
		public KNHAMAEBGGK BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			[CompilerGenerated]
			get
			{
				return default(KNHAMAEBGGK);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public virtual void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[MBIAOMFNMDN]
	public class FilteredTextDTO : HHPMDFAHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public string JEMNDLOEAAI
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public int NPMJLEEBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[MBIAOMFNMDN]
public class LNDFADBFDLM : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string AJMFNFCFDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public string HKLHNHCMKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LNDFADBFDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[MBIAOMFNMDN]
public class HALPDBENFHB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public List<LNDFADBFDLM> HEBKLOGAKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HALPDBENFHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[MBIAOMFNMDN]
public class FDPLHMIBGDL : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public string LKEOALAJGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public FDPLHMIBGDL(string NHCKOHFCDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[MBIAOMFNMDN]
public class HAFOKIGHMJF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public List<LNDFADBFDLM> HEBKLOGAKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HAFOKIGHMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[MBIAOMFNMDN]
public class HPEGIHCPEEJ : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public List<FDPLHMIBGDL> EKGOFPMJOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public string IDHFMEEAEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public bool FPCCPIKOAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public int PGLBDMDENGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HPEGIHCPEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x7822C20", Offset = "0x7821A20", VA = "0x187822C20")]
	public HPEGIHCPEEJ(string HPEDPAFLMJB, List<FDPLHMIBGDL> GGJLDDNEKHI, bool MMOPBGBIFOP, int MNDABBGPMEP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[MBIAOMFNMDN]
public class NHDDIOPADFI : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public List<HAFOKIGHMJF> MOECJIFNNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public bool FPCCPIKOAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NHDDIOPADFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[MBIAOMFNMDN]
public class CKFBPBDMNJI : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum HPADHNFFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public const string APFJJHJNMDF = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public string IDHFMEEAEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public HPADHNFFFLO MCBGFBIKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(HPADHNFFFLO);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x781FA10", Offset = "0x781E810", VA = "0x18781FA10")]
	public CKFBPBDMNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x781F9C0", Offset = "0x781E7C0", VA = "0x18781F9C0")]
	public CKFBPBDMNJI(string HPEDPAFLMJB, HPADHNFFFLO BEGHOHJIGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[MBIAOMFNMDN]
public class CAPBKKCLDPI : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public bool KJKAFGHNHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CAPBKKCLDPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class CIOMDPBAHFA
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public enum NGEBNMPHDDE
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
[MBIAOMFNMDN]
public class PFHGEMBKAHC : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public Guid CCILFNOJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public long IIIOIIELAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA98AC0", Offset = "0xA978C0", VA = "0x180A98AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public ONBJBHMADCB IHHFMBGFMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PFHGEMBKAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x78282E0", Offset = "0x78270E0", VA = "0x1878282E0")]
	public PFHGEMBKAHC(long MDNJLMOPJKG, Guid EILFOEEDPMF, long EBABNKEEAMD, ONBJBHMADCB MKGCHJHDLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x78282C0", Offset = "0x78270C0", VA = "0x1878282C0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[MBIAOMFNMDN]
public class HGDPGPPAEEI : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public NPODIONALLL JOLJDOILEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(NPODIONALLL);
		}
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public COAABHJIMMF FLABKCLKCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HGDPGPPAEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x105CC60", Offset = "0x105BA60", VA = "0x18105CC60")]
	public HGDPGPPAEEI(NPODIONALLL MOBFLOHJOKJ, COAABHJIMMF PIGPNPJKFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[MBIAOMFNMDN]
public class ONBJBHMADCB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public Guid? NHPBGABICLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x31B9C30", Offset = "0x31B8A30", VA = "0x1831B9C30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x78278E0", Offset = "0x78266E0", VA = "0x1878278E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public Guid OEAEMOHAGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xEA1490", Offset = "0xEA0290", VA = "0x180EA1490")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x10A7600", Offset = "0x10A6400", VA = "0x1810A7600")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ONBJBHMADCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x78278F0", Offset = "0x78266F0", VA = "0x1878278F0")]
	public ONBJBHMADCB(Guid? MOLBNOPCCCO, Guid BPCMHFNCDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[MBIAOMFNMDN]
public class COAABHJIMMF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public Guid CCILFNOJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public long KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AC0", Offset = "0xA978C0", VA = "0x180A98AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public Guid MAKPDJNDDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xF5AAD0", Offset = "0xF598D0", VA = "0x180F5AAD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xF5A8A0", Offset = "0xF596A0", VA = "0x180F5A8A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xFBCAA0", Offset = "0xFBB8A0", VA = "0x180FBCAA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public DateTime PGHCONMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x13D4C20", Offset = "0x13D3A20", VA = "0x1813D4C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public COAABHJIMMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[MBIAOMFNMDN]
public class HPLGFMCMIMG : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public string PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public List<long> BBJELCLNGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public List<AFLEOIEMINH> PGHNLBLJLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public string NLHEDKPIJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public byte? OMCPLHFCKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x7822CC0", Offset = "0x7821AC0", VA = "0x187822CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7822CD0", Offset = "0x7821AD0", VA = "0x187822CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public int? LIIHIDOECGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x7820D30", Offset = "0x781FB30", VA = "0x187820D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7820CB0", Offset = "0x781FAB0", VA = "0x187820CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public Guid? FBDJFFJAENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7822CA0", Offset = "0x7821AA0", VA = "0x187822CA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7822C90", Offset = "0x7821A90", VA = "0x187822C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public bool GAAGKBCAOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xA98B80", Offset = "0xA97980", VA = "0x180A98B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA98B30", Offset = "0xA97930", VA = "0x180A98B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HPLGFMCMIMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[MBIAOMFNMDN]
public class MMCGJDDLPCD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public Guid FBDJFFJAENE
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public string PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xFBCAA0", Offset = "0xFBB8A0", VA = "0x180FBCAA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public DateTime PGHCONMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x13D4C20", Offset = "0x13D3A20", VA = "0x1813D4C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public string NLHEDKPIJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public List<long> BBJELCLNGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public List<OBBMAADMKFG> PGHNLBLJLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public byte OMCPLHFCKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xB1E570", Offset = "0xB1D370", VA = "0x180B1E570")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xB1E580", Offset = "0xB1D380", VA = "0x180B1E580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public int LIIHIDOECGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xACBD80", Offset = "0xACAB80", VA = "0x180ACBD80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x15BB370", Offset = "0x15BA170", VA = "0x1815BB370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MMCGJDDLPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[MBIAOMFNMDN]
public class PICHOILBHAA : MMCGJDDLPCD
{
	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public Guid JLKNCFMDCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1C31E80", Offset = "0x1C30C80", VA = "0x181C31E80")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x4A49090", Offset = "0x4A47E90", VA = "0x184A49090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PICHOILBHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public enum NPODIONALLL
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
public interface GHPHFNDNBAG
{
	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NMBCNJBJCJP<MMCGJDDLPCD>> LBDHMAEJOFI(Guid? LHMBOGGFNPO, long MDNJLMOPJKG, string PFLDDMDPCBI, string CDEPGINEGKG, string ECFOLMEBCEO, string NOHEOJLJFPA, byte ADPIMLAGACM, int BGBIPHDMBPB, [Optional] List<long> HBDODEBOMAF, [Optional] List<OBBMAADMKFG> OMCANAEJFHP, bool GLOBDHAMDBI = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NMBCNJBJCJP<MMCGJDDLPCD>> LIDLMIIFNCA(Guid EILFOEEDPMF, long MDNJLMOPJKG, [Optional] string PFLDDMDPCBI, [Optional] string CDEPGINEGKG, [Optional] string ECFOLMEBCEO, [Optional] List<long> HBDODEBOMAF, [Optional] Dictionary<string, string> OMCANAEJFHP, [Optional] string NOHEOJLJFPA, [Optional] byte? ADPIMLAGACM, [Optional] int? BGBIPHDMBPB, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KNPLFMAGNCA> CHHBLHHEJGD(Guid EILFOEEDPMF, long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<MMCGJDDLPCD>> FLNBAFDGANH(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<COAABHJIMMF>> NHHKKLABOMA(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<HGDPGPPAEEI>> FIOCLDOFOHF(long MDNJLMOPJKG, List<PFHGEMBKAHC> JJPHDMFIAJE, [Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[MBIAOMFNMDN]
public class AFLEOIEMINH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public string NLHEDKPIJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AFLEOIEMINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[MBIAOMFNMDN]
public class OBBMAADMKFG : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public long BDPACNIMDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public string NLHEDKPIJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OBBMAADMKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[MBIAOMFNMDN]
public class NIIDBGFJCBH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public long BDPACNIMDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public string NLHEDKPIJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B010", Offset = "0x4F79E10", VA = "0x184F7B010")]
	public NIIDBGFJCBH(long LAHANCCOJIN, string EAHIEHKAAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public interface DEAMLDNHCBH
{
	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NMBCNJBJCJP<List<OBBMAADMKFG>>> MNOCFCCNOPH(long MDNJLMOPJKG, List<NIIDBGFJCBH> JJPHDMFIAJE, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KNPLFMAGNCA> BPBNEDPICLG(long LAHANCCOJIN, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<OBBMAADMKFG>> KDDOBLAMMKJ(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[MBIAOMFNMDN]
public class FKDIFEKIGGC : CGIOODNGEEO, IEquatable<FKDIFEKIGGC>
{
	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x781F0F0", Offset = "0x781DEF0", VA = "0x18781F0F0", Slot = "7")]
	public bool Equals(FKDIFEKIGGC FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x7821680", Offset = "0x7820480", VA = "0x187821680", Slot = "6")]
	public override CGIOODNGEEO BKCDCCJFPOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FKDIFEKIGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public static class POLDAJMGKDA
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x78285C0", Offset = "0x78273C0", VA = "0x1878285C0")]
	public static FKDIFEKIGGC ONEJLDMHNMF(this KJFALBFOFBC IIHDHELGAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x78284C0", Offset = "0x78272C0", VA = "0x1878284C0")]
	public static FKDIFEKIGGC OFHJNFCGDPP(string FMPMCLDBEAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[MBIAOMFNMDN]
public class KJFALBFOFBC : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public const int KNBGDMHKENC = 3;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public const int OGFFLNJFOOP = 40;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public const int FONMNGEOJKO = 180;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public const int NHHKKIDAECN = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public const int HOAHLHLMEFC = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public const int DGFBAPBNHGH = 8;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public const int LJPDOFOLFIC = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public const int EJDAKBNLOPM = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public const int DPDOOAGNDIN = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? OLDCNGCBCBA;

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public Guid FBDJFFJAENE
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public string? LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public string? PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public int IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xB169F0", Offset = "0xB157F0", VA = "0x180B169F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public Guid? FBAHAMAHJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x7824EB0", Offset = "0x7823CB0", VA = "0x187824EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x7824E90", Offset = "0x7823C90", VA = "0x187824E90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xAF8A80", Offset = "0xAF7880", VA = "0x180AF8A80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xEF7510", Offset = "0xEF6310", VA = "0x180EF7510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public int? BGNEAAJHENG
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x724CE40", Offset = "0x724BC40", VA = "0x18724CE40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x724CE60", Offset = "0x724BC60", VA = "0x18724CE60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public int? ENGNMBCEIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7825290", Offset = "0x7824090", VA = "0x187825290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7824FB0", Offset = "0x7823DB0", VA = "0x187824FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public IReadOnlyList<EONDHLBDHBJ> AHPAILOLLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA98250", Offset = "0xA97050", VA = "0x180A98250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEB0", Offset = "0xA9DCB0", VA = "0x180A9EEB0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xFD2970", Offset = "0xFD1770", VA = "0x180FD2970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public DateTime PGHCONMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE70", Offset = "0xA9DC70", VA = "0x180A9EE70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xFD2F10", Offset = "0xFD1D10", VA = "0x180FD2F10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	[IgnoreDataMember]
	public MNMKIIAAPGL FNIHNMAJNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7824F40", Offset = "0x7823D40", VA = "0x187824F40")]
		get
		{
			return default(MNMKIIAAPGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> EODCCLJPGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7824E40", Offset = "0x7823C40", VA = "0x187824E40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDF0", Offset = "0xA9DBF0", VA = "0x180A9EDF0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x7824EA0", Offset = "0x7823CA0", VA = "0x187824EA0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KJFALBFOFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x78252A0", Offset = "0x78240A0", VA = "0x1878252A0")]
	public KJFALBFOFBC(Guid LHMBOGGFNPO, long MDNJLMOPJKG, string PFLDDMDPCBI, string CDEPGINEGKG, string ECFOLMEBCEO, int CEKHJIDJMLP, int? KFDNEGDDFJM, int? DAHGKJDIOGG, List<EONDHLBDHBJ> AHEOIFNKOGB, [Optional] DateTime LAIMBCDDMHI, [Optional] DateTime EMIHCPOIFMB, [Optional] Guid? MKJBDAOPLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x7824ED0", Offset = "0x7823CD0", VA = "0x187824ED0")]
	private MNMKIIAAPGL HIFGEHPNDDK()
	{
		return default(MNMKIIAAPGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x7824FC0", Offset = "0x7823DC0", VA = "0x187824FC0")]
	private Dictionary<Guid, int> NOEDJMGHIJJ(IReadOnlyList<EONDHLBDHBJ> AHEOIFNKOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[MBIAOMFNMDN]
public class CFNJOGOANJL : HHPMDFAHMHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public Guid FBDJFFJAENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public long PCLKEPGGEEE;

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CFNJOGOANJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[MBIAOMFNMDN]
public class HJJAOANGGPG : KJFALBFOFBC
{
	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public Guid HNKDLMFJLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xFD2C60", Offset = "0xFD1A60", VA = "0x180FD2C60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xFD31B0", Offset = "0xFD1FB0", VA = "0x180FD31B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public Guid? ODHPJNLCCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x78229D0", Offset = "0x78217D0", VA = "0x1878229D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x78229F0", Offset = "0x78217F0", VA = "0x1878229F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HJJAOANGGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[MBIAOMFNMDN]
public class KEDDFIBLFBB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public string? LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public string? PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public int IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public int? BGNEAAJHENG
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x13C5A00", Offset = "0x13C4800", VA = "0x1813C5A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x13C5A30", Offset = "0x13C4830", VA = "0x1813C5A30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public int? ENGNMBCEIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xE184A0", Offset = "0xE172A0", VA = "0x180E184A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xE184E0", Offset = "0xE172E0", VA = "0x180E184E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public List<EONDHLBDHBJ> AHPAILOLLFC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public Guid? ODHPJNLCCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x781FEA0", Offset = "0x781ECA0", VA = "0x18781FEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x781FDC0", Offset = "0x781EBC0", VA = "0x18781FDC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public Guid? FBDJFFJAENE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7824460", Offset = "0x7823260", VA = "0x187824460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x7824440", Offset = "0x7823240", VA = "0x187824440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public bool GAAGKBCAOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xEA0FB0", Offset = "0xE9FDB0", VA = "0x180EA0FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x101CDA0", Offset = "0x101BBA0", VA = "0x18101CDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x7824450", Offset = "0x7823250", VA = "0x187824450", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KEDDFIBLFBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[MBIAOMFNMDN]
public class EONDHLBDHBJ : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public OIGODFGNNIO FFHBHGNOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
		[CompilerGenerated]
		get
		{
			return default(OIGODFGNNIO);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public Guid BEJBKLGEKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x1BA7710", Offset = "0x1BA6510", VA = "0x181BA7710")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E32020", Offset = "0x5E30E20", VA = "0x185E32020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EONDHLBDHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x7820970", Offset = "0x781F770", VA = "0x187820970")]
	public EONDHLBDHBJ(Guid IBNJFJNMBKC, OIGODFGNNIO ADGMECOLKNH, int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[MBIAOMFNMDN]
public class FPEIDHIENDF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public Guid FNJHDLCHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public int NKDBLMFBBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public DateTime PEJDBIGNNII
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xA98B70", Offset = "0xA97970", VA = "0x180A98B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x7822040", Offset = "0x7820E40", VA = "0x187822040")]
	public FPEIDHIENDF(Guid GJIFBNOCMLB, string PFLDDMDPCBI, int LANDMFLIPNL, DateTime GGAKIJNLGGL, int HNEGIKALKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FPEIDHIENDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[MBIAOMFNMDN]
public class FCJGBKEEDPO : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public Guid FNJHDLCHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public int AGOELGKNPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FCJGBKEEDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x518C570", Offset = "0x518B370", VA = "0x18518C570")]
	public FCJGBKEEDPO(Guid GJIFBNOCMLB, int PHIBFHFGACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[MBIAOMFNMDN]
public class LHBADGFMLCA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public int AGOELGKNPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public Guid JCIDEEGHDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x1BA7710", Offset = "0x1BA6510", VA = "0x181BA7710")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E32020", Offset = "0x5E30E20", VA = "0x185E32020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public int LKEAHOODJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public Guid? MKLMADKHLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xFCBB00", Offset = "0xFCA900", VA = "0x180FCBB00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x24CCDE0", Offset = "0x24CBBE0", VA = "0x1824CCDE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public int INOMIIDGOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A00", Offset = "0xAB1800", VA = "0x180AB2A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x17380D0", Offset = "0x1736ED0", VA = "0x1817380D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public Dictionary<Guid, Guid?> IJNLOCCPCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LHBADGFMLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x7826850", Offset = "0x7825650", VA = "0x187826850")]
	public LHBADGFMLCA(int PHIBFHFGACE, Guid CECDCJHBNPO, int CNDDHOKEEOO, Guid? HGMCDFFHFBJ, int PEPGHAPJCJB, Dictionary<Guid, Guid?> LMEIHNAPKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[MBIAOMFNMDN]
public class KPEHGONECBE : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public GJACPBFIJDC KGNFKLPEKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
		[CompilerGenerated]
		get
		{
			return default(GJACPBFIJDC);
		}
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public IJNABNOAHHD? BDDNFNKPMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x13C58C0", Offset = "0x13C46C0", VA = "0x1813C58C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x13D0910", Offset = "0x13CF710", VA = "0x1813D0910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public BalanceResponseDTO IDLNIGNKKBA
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public List<COAABHJIMMF> HNANCOFLIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KPEHGONECBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x7826540", Offset = "0x7825340", VA = "0x187826540")]
	public KPEHGONECBE(GJACPBFIJDC ILPBDKLJKMK, IJNABNOAHHD? IDMBNBHNCBI, BalanceResponseDTO POJGKLDNGEJ, List<COAABHJIMMF> BHLCFIOIDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x7826530", Offset = "0x7825330", VA = "0x187826530", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public enum OIGODFGNNIO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum GJACPBFIJDC : byte
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
public enum MNMKIIAAPGL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public interface IOACKABALCD
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	static GBCEOPMAPJH<KJFALBFOFBC> OALFCMJFOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	static GBCEOPMAPJH<KJFALBFOFBC> MDCDHPKPFIP;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	static GBCEOPMAPJH<Guid> IEPCKPFGAOJ;

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NMBCNJBJCJP<KJFALBFOFBC?>?>? CMEONHOKOMF(Guid? LHMBOGGFNPO, long MDNJLMOPJKG, string PFLDDMDPCBI, string? CDEPGINEGKG, string? ECFOLMEBCEO, int CEKHJIDJMLP, MNMKIIAAPGL DCKGHDHCKEH, [Optional] Dictionary<Guid, int>? GNKMEBHDFDO, [Optional] Guid? DAFPKFMJMHM, bool GLOBDHAMDBI = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NMBCNJBJCJP<KJFALBFOFBC?>?>? AKPMFACHIBL(Guid GJIFBNOCMLB, long MDNJLMOPJKG, string PFLDDMDPCBI, string? CDEPGINEGKG, string? ECFOLMEBCEO, int CEKHJIDJMLP, MNMKIIAAPGL DCKGHDHCKEH, [Optional] Dictionary<Guid, int>? GNKMEBHDFDO, [Optional] Guid? DAFPKFMJMHM, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KNPLFMAGNCA> JPKECNEJMGM(Guid GJIFBNOCMLB, long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<KJFALBFOFBC>> KHLBAICHPNO(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<NMBCNJBJCJP<List<FCJGBKEEDPO>>> KNJCMHELJDJ(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NMBCNJBJCJP<List<FPEIDHIENDF>>> FFFABPHLICH(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<KPEHGONECBE> JGINAJCLAGM(Guid GJIFBNOCMLB, long MDNJLMOPJKG, int PHIBFHFGACE, int CNDDHOKEEOO, Guid? INHJDGIOJPP, int PEPGHAPJCJB, Dictionary<Guid, Guid?> NHELMEILNJL, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x78237F0", Offset = "0x78225F0", VA = "0x1878237F0")]
	static IOACKABALCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[MBIAOMFNMDN]
public class LJJLEGAKDGN : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public bool JNDMPJGBLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LJJLEGAKDGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public interface ALMBKNLAGNO
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LJJLEGAKDGN> KDLJOBCKBBF(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KNPLFMAGNCA> INFMMKBJCJM(long MDNJLMOPJKG, bool OGAMGBEGCMH, [Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[CKPMFNBPEDM]
public class BPMOIMACCID<DataType> where DataType : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	public long IJOHPBEMIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	public COKNLBOGDAO KNPAPNNIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(COKNLBOGDAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public KNHAMAEBGGK NCMMEBNICBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
		[CompilerGenerated]
		get
		{
			return default(KNHAMAEBGGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public DataType CFOLCKLFPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BPMOIMACCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[CKPMFNBPEDM]
public class CNMPHLDEAOA<DataType> where DataType : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public long IJOHPBEMIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public COKNLBOGDAO KNPAPNNIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(COKNLBOGDAO);
		}
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public KNHAMAEBGGK NCMMEBNICBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
		[CompilerGenerated]
		get
		{
			return default(KNHAMAEBGGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000284")]
	public List<DataType> CFOLCKLFPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CNMPHLDEAOA()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CKPMFNBPEDM]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : HHPMDFAHMHN, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CKPMFNBPEDM]
		public class PALBPPPGOHH : HPMMHONDJKB, HHPMDFAHMHN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EA")]
			[CompilerGenerated]
			private struct MEAKGGLGKBM : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000426")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000428")]
				public PALBPPPGOHH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000429")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x589E040", Offset = "0x589CE40", VA = "0x18589E040", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000620")]
				[Cpp2IlInjected.Address(RVA = "0x589E310", Offset = "0x589D110", VA = "0x18589E310", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000286")]
			public IJNABNOAHHD BGHEFIMGLFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000618")]
				[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
				[CompilerGenerated]
				get
				{
					return default(IJNABNOAHHD);
				}
				[Cpp2IlInjected.Token(Token = "0x6000619")]
				[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000287")]
			public DataTypeDTO CFOLCKLFPKO
			{
				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC1E0", Offset = "0x5BEAFE0", VA = "0x185BEC1E0", Slot = "5")]
			public void DEABHIFMEFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC110", Offset = "0x5BEAF10", VA = "0x185BEC110", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.PALBPPPGOHH.MEAKGGLGKBM))]
			public Task BCLOKBHDFOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public PALBPPPGOHH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public List<PALBPPPGOHH> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x5C47160", Offset = "0x5C45F60", VA = "0x185C47160", Slot = "5")]
		public override void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CKPMFNBPEDM]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : HHPMDFAHMHN, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CKPMFNBPEDM]
		public class LIIIDPHKBJF : HPMMHONDJKB, HHPMDFAHMHN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000ED")]
			[CompilerGenerated]
			private struct PFPMOPAGJOD : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042E")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042F")]
				public LIIIDPHKBJF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000430")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600062C")]
				[Cpp2IlInjected.Address(RVA = "0x5BF8C50", Offset = "0x5BF7A50", VA = "0x185BF8C50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600062D")]
				[Cpp2IlInjected.Address(RVA = "0x5BF8EB0", Offset = "0x5BF7CB0", VA = "0x185BF8EB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000289")]
			public IJNABNOAHHD BGHEFIMGLFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000625")]
				[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
				[CompilerGenerated]
				get
				{
					return default(IJNABNOAHHD);
				}
				[Cpp2IlInjected.Token(Token = "0x6000626")]
				[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700028A")]
			public List<DataTypeDTO> CFOLCKLFPKO
			{
				[Cpp2IlInjected.Token(Token = "0x6000627")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000628")]
				[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x568EAD0", Offset = "0x568D8D0", VA = "0x18568EAD0", Slot = "5")]
			public void DEABHIFMEFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x568EA00", Offset = "0x568D800", VA = "0x18568EA00", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.LIIIDPHKBJF.PFPMOPAGJOD))]
			public Task BCLOKBHDFOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public LIIIDPHKBJF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public List<LIIIDPHKBJF> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x5C47160", Offset = "0x5C45F60", VA = "0x185C47160", Slot = "5")]
		public override void DEABHIFMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[APFOCEAFNCD]
public class LGEFHCIOMLA : PurchaseBalanceUpdateResponseDTO<DELIHCCELHP>
{
	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x7826810", Offset = "0x7825610", VA = "0x187826810")]
	public LGEFHCIOMLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[APFOCEAFNCD]
public class FEIOGFHHDJD : PurchaseBalanceUpdateResponseDTO<DELIHCCELHP>.LIIIDPHKBJF
{
	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x7821030", Offset = "0x781FE30", VA = "0x187821030")]
	public FEIOGFHHDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[MBIAOMFNMDN]
public class BGIJCBAECHJ : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public IEJIMKIBBAA NPDPABPLEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public long LOMPFENIOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public GiftItemDTO? DJNMIBMHJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	public long? FEPIEJOHNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x141B2F0", Offset = "0x141A0F0", VA = "0x18141B2F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x1553FB0", Offset = "0x1552DB0", VA = "0x181553FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	public int NCJBNBNMPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x781DC50", Offset = "0x781CA50", VA = "0x18781DC50")]
	public BGIJCBAECHJ(IEJIMKIBBAA DOHCICNLHOD, long FHHAGIABJGI, GiftItemDTO? PLAEHGJHGJO, int HNMGLFCIJHN = 1, [Optional] long? CJLLIGONALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[MBIAOMFNMDN]
public class DNOMCAFKJHC : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000290")]
	public List<BGIJCBAECHJ> CHCFGJNBBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	public BKMPEOKAHJC? MMGAEELBOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public COKNLBOGDAO KNPAPNNIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(COKNLBOGDAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public bool NMEIOENONMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE8D440", Offset = "0xE8C240", VA = "0x180E8D440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE8D060", Offset = "0xE8BE60", VA = "0x180E8D060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public bool KPEFHLIDMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1616140", Offset = "0x1614F40", VA = "0x181616140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x292CBD0", Offset = "0x292B9D0", VA = "0x18292CBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public Guid? FIFICDAAMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xFCBB00", Offset = "0xFCA900", VA = "0x180FCBB00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x24CCDE0", Offset = "0x24CBBE0", VA = "0x1824CCDE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x7820740", Offset = "0x781F540", VA = "0x187820740")]
	public DNOMCAFKJHC(List<BGIJCBAECHJ> AJCICMOMMJK, BKMPEOKAHJC? DFJCPOCMFHP, COKNLBOGDAO EGEEBANPJFL, bool NGGFGKICAEN, bool AGBFEDDIEFE = false, [Optional] Guid? ANONDBJLEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[MBIAOMFNMDN]
public class CJJJLJHDAJJ : HPMMHONDJKB, HHPMDFAHMHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct JEPJIGPNHJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public CJJJLJHDAJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7823A20", Offset = "0x7822820", VA = "0x187823A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x7823D00", Offset = "0x7822B00", VA = "0x187823D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	internal static Action<DELIHCCELHP>? PMIGNDCIPOM;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	internal static Func<DELIHCCELHP, Task>? JIENPPPIPNE;

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public DELIHCCELHP HKPNMLAFPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public int? KDDHCFIOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	public FAFHAGKOPBD? OGJEOIADPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x781F900", Offset = "0x781E700", VA = "0x18781F900", Slot = "5")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x781F830", Offset = "0x781E630", VA = "0x18781F830", Slot = "6")]
	[AsyncStateMachine(typeof(JEPJIGPNHJF))]
	public virtual Task BCLOKBHDFOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CJJJLJHDAJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[APFOCEAFNCD]
public class KHDOOHEFLJL : BalanceUpdateResponseDTO<CJJJLJHDAJJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x78245D0", Offset = "0x78233D0", VA = "0x1878245D0")]
	public KHDOOHEFLJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[APFOCEAFNCD]
public class PNIDBOFPJNA : BalanceUpdateResponseDTO<CJJJLJHDAJJ>.PALBPPPGOHH
{
	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x7828340", Offset = "0x7827140", VA = "0x187828340")]
	public PNIDBOFPJNA()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[MBIAOMFNMDN]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public LBBELABPADG GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
			[CompilerGenerated]
			get
			{
				return default(LBBELABPADG);
			}
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[MBIAOMFNMDN]
public class HCAAEADMMIL : HHPMDFAHMHN, ECFDNOLKKJI
{
	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public FEEJACDGGBD? EAEOCAGCOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	[IgnoreDataMember]
	public Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x7822710", Offset = "0x7821510", VA = "0x187822710", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public IEJIMKIBBAA? OKCMLPEOAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public List<OCDBPPBGNFP>? KIDPKOGHKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public DateTime? PFLBPFOGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x141B2F0", Offset = "0x141A0F0", VA = "0x18141B2F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x1553FB0", Offset = "0x1552DB0", VA = "0x181553FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public DateTime? FJDKGNOFDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x1608130", Offset = "0x1606F30", VA = "0x181608130", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x1605660", Offset = "0x1604460", VA = "0x181605660")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public DateTime? KODCPOMILNE
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xEA0FA0", Offset = "0xE9FDA0", VA = "0x180EA0FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EBF0", Offset = "0x5E2D9F0", VA = "0x185E2EBF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public bool NPPNBKNFADD
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xD5ADA0", Offset = "0xD59BA0", VA = "0x180D5ADA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xD5A210", Offset = "0xD59010", VA = "0x180D5A210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public bool MEMEDLDICND
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x10B4BC0", Offset = "0x10B39C0", VA = "0x1810B4BC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x128A940", Offset = "0x1289740", VA = "0x18128A940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public bool OLHAFHDAGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x1078F90", Offset = "0x1077D90", VA = "0x181078F90", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x128A930", Offset = "0x1289730", VA = "0x18128A930")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public bool GOEEKCBOMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x1071870", Offset = "0x1070670", VA = "0x181071870", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x107AB00", Offset = "0x1079900", VA = "0x18107AB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x7822790", Offset = "0x7821590", VA = "0x187822790")]
	public static HCAAEADMMIL EDKAKHPNMAP(Guid PJJIOIOLAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HCAAEADMMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[MBIAOMFNMDN]
public class GNNGALNAPEN
{
	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public string EHIOAHNECDL
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public string ODJPOMNGIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public Dictionary<int, KGIFPIICPNO> JDHJNJEHJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public Dictionary<string, int> HOIIEPBNKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public Dictionary<MBHCPMLAFAO, List<int>> IDAMHNKKPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public Dictionary<string, string> EFKIKOKDFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public GNNGALNAPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public enum MBHCPMLAFAO
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
[MBIAOMFNMDN]
public class KGIFPIICPNO : GGEIMLFDFFO
{
	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public MALLPKNKEKG HJDPKLPLDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(MALLPKNKEKG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public bool ENHOLFLJMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x12FD860", Offset = "0x12FC660", VA = "0x1812FD860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x1608700", Offset = "0x1607500", VA = "0x181608700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public bool LOJMDJAAMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x20726A0", Offset = "0x20714A0", VA = "0x1820726A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x20726B0", Offset = "0x20714B0", VA = "0x1820726B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public string CCBLHLBBOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	public string LKGEOPOLIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	public string IMPOHNEMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	public string JPNKAHHNGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	public Dictionary<LGBPLMEOAKA, string> DMAHGAGBALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x1608710", Offset = "0x1607510", VA = "0x181608710")]
	public KGIFPIICPNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[MBIAOMFNMDN]
public class MBGMNFHNFHA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	public IReadOnlyList<FEEJACDGGBD>? FOHBHCIKPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MBGMNFHNFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public MBGMNFHNFHA(IReadOnlyList<FEEJACDGGBD>? PIDHDCCPHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum PDMMBMIFBNP
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
public interface ECFDNOLKKJI
{
	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	IEJIMKIBBAA? OKCMLPEOAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	List<OCDBPPBGNFP>? KIDPKOGHKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	DateTime? PFLBPFOGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	DateTime? FJDKGNOFDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	DateTime? KODCPOMILNE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	bool NPPNBKNFADD
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	bool OLHAFHDAGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	bool GOEEKCBOMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface FGCIGFGEPFL
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action HMMMHPBEDAP;

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task IMINDGFOAMB(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NNHNIPODFOD(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HJGGKDFMLEO([Out] MHOPDJOFKHH AFFIHAGMLBN);
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface MHOPDJOFKHH
{
	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	string EHIOAHNECDL
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	string ODJPOMNGIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	IReadOnlyDictionary<MBHCPMLAFAO, IReadOnlyList<GGEIMLFDFFO>> IEICCODOCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	IReadOnlyDictionary<string, string> EFKIKOKDFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public interface GGEIMLFDFFO
{
	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	string LKGEOPOLIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	string CCBLHLBBOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	string IMPOHNEMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	string JPNKAHHNGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public interface OBCKBDNDNAI
{
	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	LGCCIJILPFA FFHBHGNOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	string FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	string KPKMPAMEBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	bool GOEEKCBOMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	bool OLHAFHDAGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	AHJINCPIKDJ FMMFMMDFBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	string MFPOJMEDJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	BFHAFIEPAFC? IOCECBFENDC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	PDMMBMIFBNP IKDCEEFKANM
	{
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	bool LHEGDGAECIO
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[MBIAOMFNMDN]
public class IEJIMKIBBAA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public LGCCIJILPFA FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(LGCCIJILPFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public int? EBIOMBKBOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x13C58C0", Offset = "0x13C46C0", VA = "0x1813C58C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x13D0910", Offset = "0x13CF710", VA = "0x1813D0910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public Guid? OLKNMCLLIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDB0", Offset = "0xA9DBB0", VA = "0x180A9EDB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEA0", Offset = "0xA9DCA0", VA = "0x180A9EEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7822E30", Offset = "0x7821C30", VA = "0x187822E30")]
	public static IEJIMKIBBAA AHDEFPILELP(int DAOECODEBJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x78230D0", Offset = "0x7821ED0", VA = "0x1878230D0")]
	public static IEJIMKIBBAA PKLAGGAPKJP(Guid PJJIOIOLAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x7822ED0", Offset = "0x7821CD0", VA = "0x187822ED0")]
	public static IEJIMKIBBAA BGDCCMEDBMF(KLAOHEICPLP EPHCLDOPEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public IEJIMKIBBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum LGCCIJILPFA
{
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[MBIAOMFNMDN]
public class OCDBPPBGNFP : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public COKNLBOGDAO KNPAPNNIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(COKNLBOGDAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public int IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public HKAAJGMDKLL NEINLBHOKND
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x106F330", Offset = "0x106E130", VA = "0x18106F330", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x7827870", Offset = "0x7826670", VA = "0x187827870")]
	public int LAGAENHPCIJ(DateTime EEMAGLEPFIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OCDBPPBGNFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[MBIAOMFNMDN]
public class HKAAJGMDKLL : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public int LGEKLLBFOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public DateTime? JDNJGKDPJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public DateTime? HMFFDOPAPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x141B2F0", Offset = "0x141A0F0", VA = "0x18141B2F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x1553FB0", Offset = "0x1552DB0", VA = "0x181553FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x7822A10", Offset = "0x7821810", VA = "0x187822A10")]
	public bool DIEFJMINMNA(DateTime EEMAGLEPFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x7822BF0", Offset = "0x78219F0", VA = "0x187822BF0")]
	public int LFAMGCNDGOJ(DateTime EEMAGLEPFIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x7822B00", Offset = "0x7821900", VA = "0x187822B00")]
	public TimeSpan? DKEKFNOEBPJ(DateTime EEMAGLEPFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HKAAJGMDKLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public enum BKMPEOKAHJC
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
public enum NBKCFIFLKOC
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public enum IAEMKPMDALH
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
public enum NHOMGBPCGAA
{
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public enum DOPPMBBENBK
{
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[MBIAOMFNMDN]
public class BHCEAFCCILI : IEquatable<BHCEAFCCILI>
{
	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public int? FBACDOJPLAE
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public int? ABMPEKMCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public int? CLPGAKEBBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public List<int>? BFIFMDJCPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x781E770", Offset = "0x781D570", VA = "0x18781E770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x781E710", Offset = "0x781D510", VA = "0x18781E710")]
	public static BHCEAFCCILI OPDDOLCLJGM(int? ADJBJCLKOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x781E0E0", Offset = "0x781CEE0", VA = "0x18781E0E0", Slot = "4")]
	public bool Equals(BHCEAFCCILI? FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x781E670", Offset = "0x781D470", VA = "0x18781E670")]
	private static bool IAEEKAECANE(List<int>? GENJGFGGINA, List<int>? KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x781E260", Offset = "0x781D060", VA = "0x18781E260", Slot = "0")]
	public override bool Equals(object? ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x781E490", Offset = "0x781D290", VA = "0x18781E490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BHCEAFCCILI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public struct KLAOHEICPLP : IEquatable<KLAOHEICPLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public readonly LGCCIJILPFA FFHBHGNOAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly int EBIOMBKBOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly Guid OLKNMCLLIMA;

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public Guid JPGHKDHGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x7825380", Offset = "0x7824180", VA = "0x187825380")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public int KDDHCFIOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x7825B60", Offset = "0x7824960", VA = "0x187825B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public string PBMGIEJKGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x7825550", Offset = "0x7824350", VA = "0x187825550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x7825CA0", Offset = "0x7824AA0", VA = "0x187825CA0")]
	public static bool PJKONFNNFCK(string BEBMEOPHIHO, [Out] KLAOHEICPLP EPHCLDOPEPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x7825890", Offset = "0x7824690", VA = "0x187825890")]
	public static bool NODANCDJGKI(string HLDAMBCDPKK, [Out] KLAOHEICPLP EPHCLDOPEPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x7825B70", Offset = "0x7824970", VA = "0x187825B70")]
	public static KLAOHEICPLP PDLMJKPPGLL(int FMFDAFLDAAK)
	{
		return default(KLAOHEICPLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x7825740", Offset = "0x7824540", VA = "0x187825740")]
	public static KLAOHEICPLP LMAJKLPOFMJ(Guid FMFDAFLDAAK)
	{
		return default(KLAOHEICPLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x7825630", Offset = "0x7824430", VA = "0x187825630")]
	private static bool HFOMCNFBLMJ(string BEBMEOPHIHO, [Out] LGCCIJILPFA DJFIONKHNPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x7826190", Offset = "0x7824F90", VA = "0x187826190")]
	private KLAOHEICPLP(LGCCIJILPFA DJFIONKHNPB, int? LEPIDMMLEFC, Guid? PJJIOIOLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x78253F0", Offset = "0x78241F0", VA = "0x1878253F0", Slot = "4")]
	public bool Equals(KLAOHEICPLP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x7825460", Offset = "0x7824260", VA = "0x187825460", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x78255A0", Offset = "0x78243A0", VA = "0x1878255A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x78260E0", Offset = "0x7824EE0", VA = "0x1878260E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[MBIAOMFNMDN]
public abstract class CGIOODNGEEO : IEquatable<CGIOODNGEEO>, HHPMDFAHMHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public Guid NNHDOHLBMKN;

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x781F1B0", Offset = "0x781DFB0", VA = "0x18781F1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x781F130", Offset = "0x781DF30", VA = "0x18781F130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x781F0F0", Offset = "0x781DEF0", VA = "0x18781F0F0", Slot = "4")]
	public bool Equals(CGIOODNGEEO FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x781EFE0", Offset = "0x781DDE0", VA = "0x18781EFE0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract CGIOODNGEEO BKCDCCJFPOM();

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected CGIOODNGEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public enum CGNGIDGHPFA
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
[MBIAOMFNMDN]
public class FEEJACDGGBD : CGIOODNGEEO, IEquatable<FEEJACDGGBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public CGNGIDGHPFA DJFIONKHNPB;

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x7820F50", Offset = "0x781FD50", VA = "0x187820F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x7820E60", Offset = "0x781FC60", VA = "0x187820E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FEEJACDGGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x7820FF0", Offset = "0x781FDF0", VA = "0x187820FF0")]
	public FEEJACDGGBD(CGNGIDGHPFA DJFIONKHNPB, Guid NNHDOHLBMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x7820EE0", Offset = "0x781FCE0", VA = "0x187820EE0")]
	public static FEEJACDGGBD LMAJKLPOFMJ(Guid DCAPIGMJMIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7820E10", Offset = "0x781FC10", VA = "0x187820E10", Slot = "7")]
	public bool Equals(FEEJACDGGBD FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x7820DA0", Offset = "0x781FBA0", VA = "0x187820DA0", Slot = "6")]
	public override CGIOODNGEEO BKCDCCJFPOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public static class DEBMBBAPLMO
{
	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x781FD50", Offset = "0x781EB50", VA = "0x18781FD50")]
	public static FEEJACDGGBD ONEJLDMHNMF(this AJICICIIHFC IIHDHELGAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x781FBF0", Offset = "0x781E9F0", VA = "0x18781FBF0")]
	public static FEEJACDGGBD OFHJNFCGDPP(string KKPEEJPDOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x781FCE0", Offset = "0x781EAE0", VA = "0x18781FCE0")]
	public static FEEJACDGGBD OJLPFKMHHNK(Guid CAEAAAIELOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
[MBIAOMFNMDN]
public class AJICICIIHFC : GGHMLGOOCJO, HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public CGNGIDGHPFA FFHBHGNOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(CGNGIDGHPFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public Guid EAEOCAGCOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x1BA7710", Offset = "0x1BA6510", VA = "0x181BA7710")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x5E32020", Offset = "0x5E30E20", VA = "0x185E32020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public string PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public long? PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x10666B0", Offset = "0x10654B0", VA = "0x1810666B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x10667E0", Offset = "0x10655E0", VA = "0x1810667E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public long IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xFBCE50", Offset = "0xFBBC50", VA = "0x180FBCE50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public Guid? CLEAFGLEOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x781D320", Offset = "0x781C120", VA = "0x18781D320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x781D310", Offset = "0x781C110", VA = "0x18781D310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xFD2390", Offset = "0xFD1190", VA = "0x180FD2390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public DateTime PGHCONMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEB0", Offset = "0xA9DCB0", VA = "0x180A9EEB0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xFD2970", Offset = "0xFD1770", VA = "0x180FD2970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AJICICIIHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x781D3F0", Offset = "0x781C1F0", VA = "0x18781D3F0")]
	public AJICICIIHFC(CGNGIDGHPFA DJFIONKHNPB, Guid NNHDOHLBMKN, [Optional] string PFLDDMDPCBI, [Optional] string CDEPGINEGKG, [Optional] string ECFOLMEBCEO, [Optional] long? MDNJLMOPJKG, long CEKHJIDJMLP = 0L, [Optional] Guid? BMAEOFOMINH, [Optional] DateTime LAIMBCDDMHI, [Optional] DateTime EMIHCPOIFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x781D340", Offset = "0x781C140", VA = "0x18781D340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public interface ANBGCLEKCHL
{
	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public interface ODBMDDOHJGD<out TId> : ANBGCLEKCHL where TId : struct
{
	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	TId FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[MBIAOMFNMDN]
public class BGKKKOAJCBB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public List<LIKLLKKKHBP> DKLGPGLACNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public List<JOPEEOEEHGA> GFPJLFBGBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public List<BDBDHAAAJLK> IABADNNHFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public List<PNLOFGOEKDF> CNJEHOOMJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public List<PDLJNAPLJCO> BBCGFKBNPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public List<ALPJFMOJIHO> GBFGKDPBCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public List<FKJEBKIFHAN> COIPNAPFGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public ELJAMIDCPAP IGLPDOKNDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public ELJAMIDCPAP IIIEIOJGEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public ELJAMIDCPAP HMEOMLBAJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x781DCD0", Offset = "0x781CAD0", VA = "0x18781DCD0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x781DE80", Offset = "0x781CC80", VA = "0x18781DE80")]
	public BGKKKOAJCBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[MBIAOMFNMDN]
public class LIKLLKKKHBP : HHPMDFAHMHN, IEquatable<LIKLLKKKHBP>
{
	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public LLFPFPNGEIM BLHOBIMNOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
		[CompilerGenerated]
		get
		{
			return default(LLFPFPNGEIM);
		}
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public MOEGFPMBPFH FMIIKBALPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC30", Offset = "0xB7AA30", VA = "0x180B7BC30")]
		[CompilerGenerated]
		get
		{
			return default(MOEGFPMBPFH);
		}
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC40", Offset = "0xB7AA40", VA = "0x180B7BC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public Guid GIAGFKALNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x1BA7710", Offset = "0x1BA6510", VA = "0x181BA7710")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x5E32020", Offset = "0x5E30E20", VA = "0x185E32020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public Guid PCBFNEMPIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xEA1490", Offset = "0xEA0290", VA = "0x180EA1490")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x10A7600", Offset = "0x10A6400", VA = "0x1810A7600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x7826A30", Offset = "0x7825830", VA = "0x187826A30", Slot = "5")]
	public bool Equals(LIKLLKKKHBP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x78268D0", Offset = "0x78256D0", VA = "0x1878268D0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x7826AD0", Offset = "0x78258D0", VA = "0x187826AD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x154A950", Offset = "0x1549750", VA = "0x18154A950")]
	public static bool IKIADGFKNFC(LIKLLKKKHBP NNEMEIEKIAF, LIKLLKKKHBP JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x154A490", Offset = "0x1549290", VA = "0x18154A490")]
	public static bool GFAFFKCBFKA(LIKLLKKKHBP NNEMEIEKIAF, LIKLLKKKHBP JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LIKLLKKKHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[MBIAOMFNMDN]
public class ELJAMIDCPAP : HHPMDFAHMHN, ODBMDDOHJGD<MOEGFPMBPFH>, ANBGCLEKCHL
{
	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public MOEGFPMBPFH FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MOEGFPMBPFH);
		}
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public MFELPMANHFC EEPMFHLMMON
	{
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public float JEGCJLEEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x10948F0", Offset = "0x10936F0", VA = "0x1810948F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x15A1790", Offset = "0x15A0590", VA = "0x1815A1790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public float IGIJLDNEANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xDB5D10", Offset = "0xDB4B10", VA = "0x180DB5D10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xDB5D20", Offset = "0xDB4B20", VA = "0x180DB5D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public float LPJPNBOCIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xD62830", Offset = "0xD61630", VA = "0x180D62830")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x108D9C0", Offset = "0x108C7C0", VA = "0x18108D9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x78207C0", Offset = "0x781F5C0", VA = "0x1878207C0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x7820810", Offset = "0x781F610", VA = "0x187820810")]
	public ELJAMIDCPAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[MBIAOMFNMDN]
public class JOPEEOEEHGA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public LIKLLKKKHBP DIHMBOJAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public string MILNNBDDBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public DIAJACAHEFE OCMJDBALDON
	{
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x106F330", Offset = "0x106E130", VA = "0x18106F330", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x7824300", Offset = "0x7823100", VA = "0x187824300")]
	public JOPEEOEEHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[MBIAOMFNMDN]
public class BDBDHAAAJLK : HHPMDFAHMHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public string HDHDMLDNOMB;

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public MOEGFPMBPFH FMIIKBALPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
		[CompilerGenerated]
		get
		{
			return default(MOEGFPMBPFH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BDBDHAAAJLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[MBIAOMFNMDN]
public class PNLOFGOEKDF : HHPMDFAHMHN, ODBMDDOHJGD<Guid>, ANBGCLEKCHL
{
	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x7828380", Offset = "0x7827180", VA = "0x187828380", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public Guid FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public int JOFAHAMCBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public string HDHDMLDNOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public DIAJACAHEFE MDANDEECNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x78282C0", Offset = "0x78270C0", VA = "0x1878282C0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x78283F0", Offset = "0x78271F0", VA = "0x1878283F0")]
	public PNLOFGOEKDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[MBIAOMFNMDN]
public class PDLJNAPLJCO : HHPMDFAHMHN, ODBMDDOHJGD<Guid>, ANBGCLEKCHL
{
	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public Guid FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public float DFHMKCIHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x10948F0", Offset = "0x10936F0", VA = "0x1810948F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x15A1790", Offset = "0x15A0590", VA = "0x1815A1790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public MOCDADEJHPA DHHCOFNJKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x184BDC0", Offset = "0x184ABC0", VA = "0x18184BDC0")]
		[CompilerGenerated]
		get
		{
			return default(MOCDADEJHPA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x108D570", Offset = "0x108C370", VA = "0x18108D570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public List<LJJKOLJGHJP> LMBDHIFBJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x7827ED0", Offset = "0x7826CD0", VA = "0x187827ED0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x7827F70", Offset = "0x7826D70", VA = "0x187827F70")]
	public PDLJNAPLJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[MBIAOMFNMDN]
public class ALPJFMOJIHO : HHPMDFAHMHN, ODBMDDOHJGD<Guid>, ANBGCLEKCHL
{
	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public Guid FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public MFELPMANHFC EEPMFHLMMON
	{
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x781D4B0", Offset = "0x781C2B0", VA = "0x18781D4B0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x781D500", Offset = "0x781C300", VA = "0x18781D500")]
	public ALPJFMOJIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[MBIAOMFNMDN]
public class MFELPMANHFC : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public List<ALPHEBJAPPE> LPKLGIJIMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x7826D10", Offset = "0x7825B10", VA = "0x187826D10", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x7826D50", Offset = "0x7825B50", VA = "0x187826D50")]
	public MFELPMANHFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[MBIAOMFNMDN]
public class ALPHEBJAPPE : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public float EKCKINLNALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xD80840", Offset = "0xD7F640", VA = "0x180D80840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xDF0080", Offset = "0xDEEE80", VA = "0x180DF0080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public float DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xE8D430", Offset = "0xE8C230", VA = "0x180E8D430")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xE8D6E0", Offset = "0xE8C4E0", VA = "0x180E8D6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public float CHFILLPHFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xAE7AE0", Offset = "0xAE68E0", VA = "0x180AE7AE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x13D0900", Offset = "0x13CF700", VA = "0x1813D0900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public float FFLBHMNACCN
	{
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xAE79E0", Offset = "0xAE67E0", VA = "0x180AE79E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xEB8B40", Offset = "0xEB7940", VA = "0x180EB8B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public float OKBAPPINPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xAE79F0", Offset = "0xAE67F0", VA = "0x180AE79F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x1089DA0", Offset = "0x1088BA0", VA = "0x181089DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public float JGAODJADIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xAE76E0", Offset = "0xAE64E0", VA = "0x180AE76E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xAE69C0", Offset = "0xAE57C0", VA = "0x180AE69C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public int PKMCPLDPICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public int LGKPBODJGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x168AAA0", Offset = "0x16898A0", VA = "0x18168AAA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ALPHEBJAPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[MBIAOMFNMDN]
public class LJJKOLJGHJP : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public float EKCKINLNALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xD80840", Offset = "0xD7F640", VA = "0x180D80840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0xDF0080", Offset = "0xDEEE80", VA = "0x180DF0080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public DIAJACAHEFE MDANDEECNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x106F330", Offset = "0x106E130", VA = "0x18106F330", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x7826C20", Offset = "0x7825A20", VA = "0x187826C20")]
	public LJJKOLJGHJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[MBIAOMFNMDN]
public class DIAJACAHEFE : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public float LJACMFAALOK
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xD80840", Offset = "0xD7F640", VA = "0x180D80840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xDF0080", Offset = "0xDEEE80", VA = "0x180DF0080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public float IJMFAHCEAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xE8D430", Offset = "0xE8C230", VA = "0x180E8D430")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xE8D6E0", Offset = "0xE8C4E0", VA = "0x180E8D6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public float HLOIDJLPHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xAE7AE0", Offset = "0xAE68E0", VA = "0x180AE7AE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x13D0900", Offset = "0x13CF700", VA = "0x1813D0900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public float DIAOFOEBKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xAE79E0", Offset = "0xAE67E0", VA = "0x180AE79E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xEB8B40", Offset = "0xEB7940", VA = "0x180EB8B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DIAJACAHEFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x781CE80", Offset = "0x781BC80", VA = "0x18781CE80")]
	public DIAJACAHEFE(float BIHPDMNFJGD, float OLHLMPHEMHN, float KMNEIBIPMKI, float GENJGFGGINA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[MBIAOMFNMDN]
public class FKJEBKIFHAN : HHPMDFAHMHN, ODBMDDOHJGD<Guid>, ANBGCLEKCHL
{
	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public Guid FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public string DEFLGPEBOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public string AIIIBDMKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public bool OKHIGOLCOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xAEFA50", Offset = "0xAEE850", VA = "0x180AEFA50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xAEFDA0", Offset = "0xAEEBA0", VA = "0x180AEFDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public float BEKAENLIJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xAE89F0", Offset = "0xAE77F0", VA = "0x180AE89F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xD5B980", Offset = "0xD5A780", VA = "0x180D5B980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public LIPFHIIEJAD BMDAPCCGMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public LIPFHIIEJAD CMHFHKNIHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public LIPFHIIEJAD BJBPOABANKH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public LIPFHIIEJAD NECOPPBEPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public AEFMAIJOGOJ CMGAMHFMPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x7821AB0", Offset = "0x78208B0", VA = "0x187821AB0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x7821B70", Offset = "0x7820970", VA = "0x187821B70")]
	public FKJEBKIFHAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[MBIAOMFNMDN]
public class LIPFHIIEJAD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public MEEGBLDOOPD AAJPNCOJLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public float EJLFCFJDMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xAE7AE0", Offset = "0xAE68E0", VA = "0x180AE7AE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x13D0900", Offset = "0x13CF700", VA = "0x1813D0900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public float NBHNBMHJKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xAE79E0", Offset = "0xAE67E0", VA = "0x180AE79E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xEB8B40", Offset = "0xEB7940", VA = "0x180EB8B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public AEFMAIJOGOJ DNEGBKDBJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x7826B80", Offset = "0x7825980", VA = "0x187826B80", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x7826BA0", Offset = "0x78259A0", VA = "0x187826BA0")]
	public LIPFHIIEJAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[MBIAOMFNMDN]
public class MEEGBLDOOPD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public float JAPINGNAFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0xD80840", Offset = "0xD7F640", VA = "0x180D80840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0xDF0080", Offset = "0xDEEE80", VA = "0x180DF0080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public float AOFLJOHNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0xE8D430", Offset = "0xE8C230", VA = "0x180E8D430")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0xE8D6E0", Offset = "0xE8C4E0", VA = "0x180E8D6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MEEGBLDOOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x77FFCE0", Offset = "0x77FEAE0", VA = "0x1877FFCE0")]
	public MEEGBLDOOPD(float DBBMOEGPNPP, float COFKGIHGCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
	public virtual void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[MBIAOMFNMDN]
public class AEFMAIJOGOJ : MEEGBLDOOPD
{
	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public float NENFKFCDDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xAE7AE0", Offset = "0xAE68E0", VA = "0x180AE7AE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x13D0900", Offset = "0x13CF700", VA = "0x1813D0900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public float NNMJOLIGIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0xAE79E0", Offset = "0xAE67E0", VA = "0x180AE79E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0xEB8B40", Offset = "0xEB7940", VA = "0x180EB8B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AEFMAIJOGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x781CE80", Offset = "0x781BC80", VA = "0x18781CE80")]
	public AEFMAIJOGOJ(float DBBMOEGPNPP, float COFKGIHGCOO, float OONOCAMNEIP, float GFOPEPPIPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
	public override void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal static class NAEOAAJGGGH
{
	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E6E290", Offset = "0x3E6D090", VA = "0x183E6E290")]
	public static void FPLFCINAGKP<T>(IList<T>? FMPBGOEJLJC) where T : HHPMDFAHMHN
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public enum LLFPFPNGEIM : byte
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
public enum MOEGFPMBPFH : byte
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
public enum MOCDADEJHPA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	Time,
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	ValueRamp
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public static class FMMBFNJIPBH
{
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	public static readonly LLFPFPNGEIM[] NKJCILDDMAA;

	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public static readonly LLFPFPNGEIM[] PCEHEABKAKA;

	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public static readonly MOEGFPMBPFH[] KELBNLFLILJ;

	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public static readonly MOEGFPMBPFH[] DAIKLJMHNID;
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public enum JEIDIJJBPCC
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
public enum DKCAEBNDCAB
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
[MBIAOMFNMDN]
public class JIAJMEJBFLG : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public DKCAEBNDCAB JOLJDOILEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(DKCAEBNDCAB);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public List<string> OIGDAHHELLH
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x7823D60", Offset = "0x7822B60", VA = "0x187823D60")]
	public string MEAHAHIMIGL(int NMIOMLHEBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JIAJMEJBFLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[MBIAOMFNMDN]
public class BHHJAGFLBGH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public string PKAGMDJPJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public JEIDIJJBPCC FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(JEIDIJJBPCC);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BHHJAGFLBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public static class BCIBNOJKAPB
{
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	public const string PIDAMCHICOL = "costume";

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	public const string DAHBJENLNEI = "gadget";

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	public const string ECECPGEGGJC = "holotar";

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public const string KHLHGPIPOGP = "large";

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	public const string OFCBCALOJNO = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000579")]
	public const string BIOKCNNDGFH = "small";

	[Cpp2IlInjected.Token(Token = "0x400057A")]
	public const string FIKGMNEBGJM = "sound";

	[Cpp2IlInjected.Token(Token = "0x400057B")]
	public const string OJMPLGOMGDA = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x400057C")]
	public const string GAJEKADLBJJ = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x400057D")]
	public const string BLKHNNJLIAK = "r2";

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public static List<string> AHOMPPBLODG
	{
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x781D770", Offset = "0x781C570", VA = "0x18781D770")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public static class GACLBLFBBMI
{
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	public const string FCILFCOOKBN = "beta";

	[Cpp2IlInjected.Token(Token = "0x400057F")]
	public const string IDPPNGOCHDF = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[MBIAOMFNMDN]
public class KOBLIBCDAFO : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public List<string> OPIHMEDOHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public List<string> EBFBGNJBIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public List<string> BGOPMNABION
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KOBLIBCDAFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public class KHGGHBGONLK : IEquatable<KHGGHBGONLK>
{
	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	protected virtual Type OEFOLDOCPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x78246A0", Offset = "0x78234A0", VA = "0x1878246A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public JICFJGPJPAF? GKPOBDHGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public HttpMethod? OLOFNHDLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public string? JBLFOOMDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x7824D40", Offset = "0x7823B40", VA = "0x187824D40")]
	public KHGGHBGONLK(JICFJGPJPAF? GKPOBDHGPKI, HttpMethod? OLOFNHDLDGB, string? JBLFOOMDCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x7824C30", Offset = "0x7823A30", VA = "0x187824C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x7824700", Offset = "0x7823500", VA = "0x187824700", Slot = "6")]
	protected virtual bool EHGPOBJHANF(StringBuilder MFKHJJEIPDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x1288840", Offset = "0x1287640", VA = "0x181288840")]
	public static bool GFAFFKCBFKA(KHGGHBGONLK? LIBGDNFNANP, KHGGHBGONLK? ABBNFCGILDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x12889A0", Offset = "0x12877A0", VA = "0x1812889A0")]
	public static bool IKIADGFKNFC(KHGGHBGONLK? LIBGDNFNANP, KHGGHBGONLK? ABBNFCGILDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x7824A80", Offset = "0x7823880", VA = "0x187824A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x7824860", Offset = "0x7823660", VA = "0x187824860", Slot = "0")]
	public override bool Equals(object? ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x78248F0", Offset = "0x78236F0", VA = "0x1878248F0", Slot = "7")]
	public virtual bool Equals(KHGGHBGONLK? FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x7824610", Offset = "0x7823410", VA = "0x187824610", Slot = "8")]
	public virtual KHGGHBGONLK BFCPCOJEJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x7824D90", Offset = "0x7823B90", VA = "0x187824D90")]
	protected KHGGHBGONLK(KHGGHBGONLK HGJABFBKDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x7824BF0", Offset = "0x78239F0", VA = "0x187824BF0")]
	public void MLOAOPFMIPK([Out] JICFJGPJPAF? GKPOBDHGPKI, [Out] HttpMethod? OLOFNHDLDGB, [Out] string? JBLFOOMDCMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
public class FKBAGBMNJMM : IEquatable<FKBAGBMNJMM>
{
	[Cpp2IlInjected.Token(Token = "0x17000343")]
	protected virtual Type OEFOLDOCPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x78210E0", Offset = "0x781FEE0", VA = "0x1878210E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public int AJLANGFNBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public OBMMLFBBDHF CAIMBLJJOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
		[CompilerGenerated]
		get
		{
			return default(OBMMLFBBDHF);
		}
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x7821670", Offset = "0x7820470", VA = "0x187821670")]
	public FKBAGBMNJMM(int AJLANGFNBAD, OBMMLFBBDHF CAIMBLJJOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x7821560", Offset = "0x7820360", VA = "0x187821560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x7821140", Offset = "0x781FF40", VA = "0x187821140", Slot = "6")]
	protected virtual bool EHGPOBJHANF(StringBuilder MFKHJJEIPDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x1288840", Offset = "0x1287640", VA = "0x181288840")]
	public static bool GFAFFKCBFKA(FKBAGBMNJMM? LIBGDNFNANP, FKBAGBMNJMM? ABBNFCGILDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x12889A0", Offset = "0x12877A0", VA = "0x1812889A0")]
	public static bool IKIADGFKNFC(FKBAGBMNJMM? LIBGDNFNANP, FKBAGBMNJMM? ABBNFCGILDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x7821440", Offset = "0x7820240", VA = "0x187821440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x78213B0", Offset = "0x78201B0", VA = "0x1878213B0", Slot = "0")]
	public override bool Equals(object? ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x7821270", Offset = "0x7820070", VA = "0x187821270", Slot = "7")]
	public virtual bool Equals(FKBAGBMNJMM? FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x7821070", Offset = "0x781FE70", VA = "0x187821070", Slot = "8")]
	public virtual FKBAGBMNJMM BFCPCOJEJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0xD03C70", Offset = "0xD02A70", VA = "0x180D03C70")]
	protected FKBAGBMNJMM(FKBAGBMNJMM HGJABFBKDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x7821550", Offset = "0x7820350", VA = "0x187821550")]
	public void MLOAOPFMIPK([Out] int AJLANGFNBAD, [Out] OBMMLFBBDHF CAIMBLJJOCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public enum OBMMLFBBDHF
{
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
public interface IMGKFKHBPDO
{
	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<KHGGHBGONLK, FKBAGBMNJMM> JBGLJMFHMHC();

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAEHFHIABFF(KHGGHBGONLK OPGJHIOADCK, FKBAGBMNJMM IJBAPONMLAP);

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPBIOPFPJGF(KHGGHBGONLK OPGJHIOADCK);

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPCHGJBHEOE();

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HEKIPPAHKPP(JICFJGPJPAF PJFNDJALEFK, HttpMethod BBGEIKGKENC, string PBNGNOCJKEC, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
public interface ABBDMDGDNNB
{
	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<Guid>> ONIKLMJDIJG(string OAOIIIHAHNC);
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[CKPMFNBPEDM]
public class BJBJIPJCLPD<TResult> where TResult : HHPMDFAHMHN, new()
{
	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public IReadOnlyList<TResult> DDCEOMKKDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public long KDMLPCLEMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BJBJIPJCLPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public enum HGEAFFIEPOA
{
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
public interface AEOIKJMMBBH : DONALMEIJCK
{
	[Cpp2IlInjected.Token(Token = "0x17000348")]
	bool CCLJJPEPKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long CECDCJHBNPO, JMHKPLDEDFD MGMABCBPMBL);

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KFKKBMPEBJB> PurchaseAsync(JMHKPLDEDFD MGMABCBPMBL, BHCEAFCCILI JEAMFIDBJOI);

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(KODNFBOPAAI NKBCCMIHHEL, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
public interface DONALMEIJCK
{
	[Cpp2IlInjected.Token(Token = "0x17000349")]
	bool CKFKEJFBMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
public interface EJODCLHMOCG
{
	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	int JIKNAPLPGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<JMHKPLDEDFD>> FKFGGBNOJLH(bool IAJHFOOHLLO = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CNKGLAKKPAO([Out] JMHKPLDEDFD? HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JMHKPLDEDFD> FHGBIHBMFOK(bool IAJHFOOHLLO = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMILKCMEHFH(string BCDABHDFJPD = "");
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public interface LALADIMHHLO
{
	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AGFJDFMAHII(KODNFBOPAAI NKBCCMIHHEL, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MEMBMIMABFG(KODNFBOPAAI NKBCCMIHHEL, CancellationToken BKHGNHANFKK, [Optional] LKMMLMBAMCC? BCMEAILHKFJ);
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public interface LKMMLMBAMCC
{
	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECLBFBPDJPC(string IMIIGPOLNDC);
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public interface HHGDOEIOLEF
{
	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DAAPLNGOIOI(KODNFBOPAAI OKMLAGPICIC, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public interface KFNOKAEKIMH
{
	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	bool JBLANICMADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public interface AANAKDPNOIO
{
	[Cpp2IlInjected.Token(Token = "0x6000832")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KODNFBOPAAI MMBNJLBFNLD(JMHKPLDEDFD MGMABCBPMBL, BHCEAFCCILI JEAMFIDBJOI, string BINIEENOJEB, [Optional] LALADIMHHLO? OPNOJBIKNMO);
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public interface ALIGJIKFFEP
{
	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OAPDBCIFHGP(HHGDOEIOLEF PMJKNCNKPFJ);

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCMKJEGBFPN(HHGDOEIOLEF PMJKNCNKPFJ);

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LFDLBDAJIAH(KODNFBOPAAI NKBCCMIHHEL, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public interface KODNFBOPAAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	APKPNAGAEFH POMPNOCJNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	JMHKPLDEDFD EDOBEJIIKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	BHCEAFCCILI DOMEFMBDFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	string PPDFBHIDAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000350")]
	string AOMPCANKGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MMOGCACBNDC> KFKBHOIHINL(CancellationToken EGDCEEDDFBN, [Optional] LKMMLMBAMCC? BCMEAILHKFJ);

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PACDLNHLEGD(string FLNBBIAICOK);

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PACDLNHLEGD<T>(Func<T, string> FLNBBIAICOK, [In] T FJPEMMENMCD);
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public abstract class KCKOGFIFGEG
{
	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected KCKOGFIFGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public enum IFOJLCNHLCM
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
public enum NJKAEGLMHPM : byte
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
[MBIAOMFNMDN]
public class JMHKPLDEDFD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public int HKKGIPLPHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public string PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public int IJKFCPGIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xAA2200", Offset = "0xAA1000", VA = "0x180AA2200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xAA23A0", Offset = "0xAA11A0", VA = "0x180AA23A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public string LHCBNHJBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public string HHNNFPIBKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	[DataMember(Name = "PsnProductLabel")]
	public string NDOJGIGBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public string FCDMNFIJKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public string IOEKGJPLIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public string BFANEAHEBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public string OJCFBOFHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA93200", Offset = "0xA92000", VA = "0x180A93200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public string JFANLCILKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA98250", Offset = "0xA97050", VA = "0x180A98250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public bool HAEALEHHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xDAE710", Offset = "0xDAD510", VA = "0x180DAE710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xDADAE0", Offset = "0xDAC8E0", VA = "0x180DADAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public bool FHBOBKIGJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x187D7A0", Offset = "0x187C5A0", VA = "0x18187D7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x187D980", Offset = "0x187C780", VA = "0x18187D980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000360")]
	public BGFFHPPDANJ CFOLCKLFPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE70", Offset = "0xA9DC70", VA = "0x180A9EE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDA0", Offset = "0xA9DBA0", VA = "0x180A9EDA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	[IgnoreDataMember]
	public string JLLBBBIDJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEE0", Offset = "0xA9DCE0", VA = "0x180A9EEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDF0", Offset = "0xA9DBF0", VA = "0x180A9EDF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000362")]
	[IgnoreDataMember]
	public string FCEMPAIADHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xB633E0", Offset = "0xB621E0", VA = "0x180B633E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	[IgnoreDataMember]
	public string CILDHECJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE60", Offset = "0xA9DC60", VA = "0x180A9EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE40", Offset = "0xA9DC40", VA = "0x180A9EE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	[IgnoreDataMember]
	public KCKOGFIFGEG KINBHCMIMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xB631C0", Offset = "0xB61FC0", VA = "0x180B631C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0xB635F0", Offset = "0xB623F0", VA = "0x180B635F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	[IgnoreDataMember]
	public bool GJJHFJAACIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x78241D0", Offset = "0x7822FD0", VA = "0x1878241D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000366")]
	[IgnoreDataMember]
	public string INFGBJJOLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0xAA3060", Offset = "0xAA1E60", VA = "0x180AA3060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA1F20", VA = "0x180AA3120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x78240E0", Offset = "0x7822EE0", VA = "0x1878240E0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x78241F0", Offset = "0x7822FF0", VA = "0x1878241F0")]
	public static JMHKPLDEDFD KNAHBFHEDPL(int FMFDAFLDAAK, string PFLDDMDPCBI, string ECFOLMEBCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x7824290", Offset = "0x7823090", VA = "0x187824290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JMHKPLDEDFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[MBIAOMFNMDN]
public class BGFFHPPDANJ : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public List<int> MLPEOJGINMM
	{
		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public string KFFFDCFEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public KIJICMGPCBA MNPPILHJOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x106F330", Offset = "0x106E130", VA = "0x18106F330", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BGFFHPPDANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public readonly struct MMOGCACBNDC
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public enum GDEFFACILDA : byte
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
	public readonly GDEFFACILDA FLGAGBCKFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	public readonly NJKAEGLMHPM CLPAIPOIGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	public readonly IFOJLCNHLCM KONGPGLBKGG;

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x78271C0", Offset = "0x7825FC0", VA = "0x1878271C0")]
	private MMOGCACBNDC(GDEFFACILDA GKGDEKNIOCH, NJKAEGLMHPM KFOKMBADPFA = NJKAEGLMHPM.Unknown, IFOJLCNHLCM EGFNGNANLOG = IFOJLCNHLCM.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x78271A0", Offset = "0x7825FA0", VA = "0x1878271A0")]
	public static MMOGCACBNDC PNPKBINCNBO()
	{
		return default(MMOGCACBNDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0x7827180", Offset = "0x7825F80", VA = "0x187827180")]
	public static MMOGCACBNDC JNKKPAKGBGJ()
	{
		return default(MMOGCACBNDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0x7827160", Offset = "0x7825F60", VA = "0x187827160")]
	public static MMOGCACBNDC AKEBJPNKCKJ(NJKAEGLMHPM KFOKMBADPFA, IFOJLCNHLCM EGFNGNANLOG)
	{
		return default(MMOGCACBNDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public enum MINBIIPGLAO
{
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public enum DGLGCHDKPIM
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
[MBIAOMFNMDN]
public class KIJICMGPCBA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public MINBIIPGLAO LFDJBJPJPOB
	{
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(MINBIIPGLAO);
		}
		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public DGLGCHDKPIM NNLKEBEPECO
	{
		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
		[CompilerGenerated]
		get
		{
			return default(DGLGCHDKPIM);
		}
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	public bool KIFICLCIENB
	{
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KIJICMGPCBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public enum APKPNAGAEFH
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
[MBIAOMFNMDN]
public class MJPBIDCMLMG : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	public long FJBJHJEPLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	public long LDNIEBFPLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	public bool CMFIBAGFLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000888")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000889")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MJPBIDCMLMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[MBIAOMFNMDN]
public class ODLEMNMDMKF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000370")]
	public string CCEMMOECIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000371")]
	public CPALKGFGBHB? GMEKOEKGFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000372")]
	public IReadOnlyList<CPALKGFGBHB>? IBEAAAJOAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	public IReadOnlyList<string>? GCKFNBAFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000374")]
	public PBHPLKCCJMD NCGJILFJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000375")]
	public string? IDBGICKCCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000376")]
	public string? HGKEBGLDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000377")]
	public string? LOCFCCAKONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ODLEMNMDMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[MBIAOMFNMDN]
public class MHEHNMEDDKC : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000378")]
	public string OBIGNCNHICG
	{
		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000379")]
	public CPALKGFGBHB? GMEKOEKGFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037A")]
	public PBHPLKCCJMD NCGJILFJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037B")]
	public string? HGKEBGLDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037C")]
	public IReadOnlyList<string>? GCKFNBAFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MHEHNMEDDKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[MBIAOMFNMDN]
public class PBHPLKCCJMD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700037D")]
	public string IDLGIGLECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037E")]
	public bool HPKDEOKHJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037F")]
	public bool JPNIKNONMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x120E0D0", Offset = "0x120CED0", VA = "0x18120E0D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x1387EC0", Offset = "0x1386CC0", VA = "0x181387EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000380")]
	public bool IGHNHHLLMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x120E0C0", Offset = "0x120CEC0", VA = "0x18120E0C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x16CA080", Offset = "0x16C8E80", VA = "0x1816CA080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000381")]
	public bool LFOIJGEJGOG
	{
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x120E0B0", Offset = "0x120CEB0", VA = "0x18120E0B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x522C410", Offset = "0x522B210", VA = "0x18522C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000382")]
	public bool GLIGLLCBLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xB62D30", Offset = "0xB61B30", VA = "0x180B62D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xE8D6C0", Offset = "0xE8C4C0", VA = "0x180E8D6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000383")]
	public bool BLOKLKFHJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xB62DA0", Offset = "0xB61BA0", VA = "0x180B62DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xE8D6D0", Offset = "0xE8C4D0", VA = "0x180E8D6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000384")]
	public bool ANDMLEBHONA
	{
		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x1B1DA10", Offset = "0x1B1C810", VA = "0x181B1DA10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x7827E00", Offset = "0x7826C00", VA = "0x187827E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000385")]
	public bool EKEOIFJEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x1B075A0", Offset = "0x1B063A0", VA = "0x181B075A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x7827E10", Offset = "0x7826C10", VA = "0x187827E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000386")]
	public bool NHIICGOALIO
	{
		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000387")]
	public bool CDPHCLMECKL
	{
		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x1594640", Offset = "0x1593440", VA = "0x181594640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x1594010", Offset = "0x1592E10", VA = "0x181594010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000388")]
	public bool EELJMHOKFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x168AF80", Offset = "0x1689D80", VA = "0x18168AF80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x168AB00", Offset = "0x1689900", VA = "0x18168AB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x7827E20", Offset = "0x7826C20", VA = "0x187827E20")]
	public PBHPLKCCJMD(string LOCBNDENJOG, bool MMGLJBGKJKA, bool OFAABIFKDCP, bool NOBJBDGPIDF, bool JCIPPLKIKBO, bool PALDOFPPOMB, bool OICECKOHDDG, bool EMAJBAEINFL, bool MCEDOAAKDGK, bool EPMMOEPFCJG, bool PAPMMMMGEBP, bool JIGEONIPNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
[MBIAOMFNMDN]
public class NDGNHLDPCOM : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000389")]
	public string JAHEDNPLIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038A")]
	public string LOCFCCAKONN
	{
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038B")]
	public string IDBGICKCCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038C")]
	public string? HIHOILGKPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038D")]
	public string? NCNPLIILDAB
	{
		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038E")]
	public float MPPCJDMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xAE8A00", Offset = "0xAE7800", VA = "0x180AE8A00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x1F01470", Offset = "0x1F00270", VA = "0x181F01470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NDGNHLDPCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[MBIAOMFNMDN]
public class MJNIGJLIBJB : JLAKCDBCOLM, HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700038F")]
	public string AGHJGEKMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000390")]
	public string PMBHPHIEOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "6")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MJNIGJLIBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[MBIAOMFNMDN]
public class DLJENGNCMIB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000391")]
	public Guid MNFKBNFPKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000392")]
	public long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000393")]
	public long DHAFGBDDNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xA98AC0", Offset = "0xA978C0", VA = "0x180A98AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000394")]
	public decimal MBBIHFJBEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xF5AAD0", Offset = "0xF598D0", VA = "0x180F5AAD0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xF5A8A0", Offset = "0xF596A0", VA = "0x180F5A8A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DLJENGNCMIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[MBIAOMFNMDN]
public class LLPNCAHGHIF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000395")]
	public string AGHJGEKMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000396")]
	public string JBDGJMDADPK
	{
		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LLPNCAHGHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public LLPNCAHGHIF(string JOJHHDMMADL, string IJGBIFEEHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[MBIAOMFNMDN]
public class CJCKEACKEHB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000397")]
	public string LOCFCCAKONN
	{
		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000398")]
	public string CCEMMOECIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000399")]
	public bool OCBLCNIBHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CJCKEACKEHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[MBIAOMFNMDN]
public class PNBNOCCMBME : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700039A")]
	public string NFHHLFGCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039B")]
	public decimal CPBOAGCKMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PNBNOCCMBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[MBIAOMFNMDN]
public class FLEPICLACFD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700039C")]
	public string? LOCFCCAKONN
	{
		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039D")]
	public string CCEMMOECIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039E")]
	public float? MPPCJDMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039F")]
	public string? PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FLEPICLACFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
[MBIAOMFNMDN]
public class JCHCECDGHBP : HHAOGKCPLIA
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JCHCECDGHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[MBIAOMFNMDN]
public class KEFGFGDMGDI : KOPKMEAJOMH
{
	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KEFGFGDMGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[MBIAOMFNMDN]
public class FKMNPCHAJFB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003A0")]
	public string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A1")]
	public string CCEMMOECIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A2")]
	public bool DFGBKNJINHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FKMNPCHAJFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
[MBIAOMFNMDN]
public class PONFPEECFPP : FKMNPCHAJFB
{
	[Cpp2IlInjected.Token(Token = "0x170003A3")]
	public string PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PONFPEECFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[MBIAOMFNMDN]
public class KDJJJJKKNKH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003A4")]
	public long JHIBEGFGEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A5")]
	public string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A6")]
	public PHAJCHENNOH GHJBHDNFNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(PHAJCHENNOH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A7")]
	public Guid? EJDIBFPKOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x7824410", Offset = "0x7823210", VA = "0x187824410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x7824430", Offset = "0x7823230", VA = "0x187824430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A8")]
	public string? HGLADAPDIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000916")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KDJJJJKKNKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
public enum PHAJCHENNOH
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
[MBIAOMFNMDN]
public class NLBFEKHAMGC : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003A9")]
	public string? LOCFCCAKONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AA")]
	public string CCEMMOECIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600091C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(RVA = "0x7827220", Offset = "0x7826020", VA = "0x187827220")]
	public NLBFEKHAMGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[MBIAOMFNMDN]
public class KOPKMEAJOMH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003AB")]
	public string LOCFCCAKONN
	{
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AC")]
	public string CCEMMOECIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000922")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000923")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KOPKMEAJOMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[MBIAOMFNMDN]
public class HHAOGKCPLIA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003AD")]
	public List<string> LMMANHPLGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AE")]
	public decimal LNCIMPBJKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000929")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HHAOGKCPLIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[MBIAOMFNMDN]
public class JCPHJDLDIGI : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003AF")]
	public int FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B0")]
	public string FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B1")]
	public string? LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B2")]
	public IReadOnlyList<int> KEEBMDGAHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B3")]
	public string? JFHFGJEJFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000934")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000935")]
	[Cpp2IlInjected.Address(RVA = "0x7823990", Offset = "0x7822790", VA = "0x187823990")]
	public JCPHJDLDIGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[MBIAOMFNMDN]
public class IHPFJADGJMI : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003B4")]
	public int FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B5")]
	public Guid? OLKNMCLLIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x24CCE00", Offset = "0x24CBC00", VA = "0x1824CCE00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x24CCDF0", Offset = "0x24CBBF0", VA = "0x1824CCDF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B6")]
	public string FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B7")]
	public List<JCPHJDLDIGI> OBAMKJFNKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B8")]
	public List<JCPHJDLDIGI> JLIMPLADEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B9")]
	public string? LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BA")]
	public string? JFHFGJEJFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BB")]
	public string? HCPAOIIFNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x7823270", Offset = "0x7822070", VA = "0x187823270", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x78232A0", Offset = "0x78220A0", VA = "0x1878232A0")]
	public IHPFJADGJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[MBIAOMFNMDN]
public class FBNEPMLAFNL : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003BC")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BD")]
	public IHPFJADGJMI OBAMKJFNKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BE")]
	public IHPFJADGJMI JLIMPLADEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BF")]
	public string? HCPAOIIFNHM
	{
		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x7820D40", Offset = "0x781FB40", VA = "0x187820D40", Slot = "5")]
	public virtual void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FBNEPMLAFNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[MBIAOMFNMDN]
public class DMDLLMCBEDJ : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003C0")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C1")]
	public IReadOnlyList<IHPFJADGJMI> GHGDNBBDGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C2")]
	public IReadOnlyList<FBNEPMLAFNL> FEHKFBGDJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C3")]
	public IReadOnlyList<DMDLLMCBEDJ> HEBPJIDODEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C4")]
	public string? HCPAOIIFNHM
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x78205F0", Offset = "0x781F3F0", VA = "0x1878205F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x7820620", Offset = "0x781F420", VA = "0x187820620")]
	public DMDLLMCBEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[MBIAOMFNMDN]
public class JPGPBHJMEBD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	public const string HBMNLNPELHE = "REPL_";

	[Cpp2IlInjected.Token(Token = "0x170003C5")]
	public string FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C6")]
	public int LPHHGKHHDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JPGPBHJMEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[MBIAOMFNMDN]
public class CPALKGFGBHB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003C7")]
	public int? DIHMBOJAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C8")]
	public string? ALLLNJEMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C9")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CA")]
	public string FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CB")]
	public List<CPALKGFGBHB>? OHHIJKHDBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CC")]
	public JPGPBHJMEBD? CKLAJCMHJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x781FA20", Offset = "0x781E820", VA = "0x18781FA20", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CPALKGFGBHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[MBIAOMFNMDN]
public class OEAFFDAKEDJ : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003CD")]
	public string BIEGFJOIOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CE")]
	public string BLHLCODIDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OEAFFDAKEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[MBIAOMFNMDN]
public class DLJOGFPHNFB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003CF")]
	public string FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D0")]
	public DMDLLMCBEDJ GJDMKOPEMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D1")]
	public CPALKGFGBHB? GMEKOEKGFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D2")]
	public List<CPALKGFGBHB>? IBEAAAJOAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D3")]
	public IReadOnlyList<IHPFJADGJMI> JBEFHFCLCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D4")]
	public IReadOnlyList<OEAFFDAKEDJ> LGEPFHFBBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D5")]
	public string? OBIGNCNHICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x7820490", Offset = "0x781F290", VA = "0x187820490", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x7820520", Offset = "0x781F320", VA = "0x187820520")]
	public DLJOGFPHNFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[MBIAOMFNMDN]
public class OFBOKAFHAAO : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003D6")]
	public LBBCKEKMIBK<DLJOGFPHNFB> JOLJDOILEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D7")]
	public decimal GNAGBOIIMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x7731750", Offset = "0x7730550", VA = "0x187731750", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OFBOKAFHAAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public enum DIJCCBHFKLF
{
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
[MBIAOMFNMDN]
public class OGICKLAGCCF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003D8")]
	public DIJCCBHFKLF OOJKKMFOKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(DIJCCBHFKLF);
		}
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D9")]
	public DateTime PHBMBGCLJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OGICKLAGCCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[MBIAOMFNMDN]
public class JAFEKLIEDCH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003DA")]
	public DIJCCBHFKLF LMAOCKBJFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(DIJCCBHFKLF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DB")]
	public float GLCDEGFFBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xE8D430", Offset = "0xE8C230", VA = "0x180E8D430")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0xE8D6E0", Offset = "0xE8C4E0", VA = "0x180E8D6E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JAFEKLIEDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[MBIAOMFNMDN]
public class FOEGKOIIFLL : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003DC")]
	public DIJCCBHFKLF OOJKKMFOKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(DIJCCBHFKLF);
		}
		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DD")]
	public DateTime PHBMBGCLJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DE")]
	public DIJCCBHFKLF LMAOCKBJFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(DIJCCBHFKLF);
		}
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DF")]
	public float GLCDEGFFBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0xAE76E0", Offset = "0xAE64E0", VA = "0x180AE76E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0xAE69C0", Offset = "0xAE57C0", VA = "0x180AE69C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E0")]
	public DIJCCBHFKLF ANOICBFNFOM
	{
		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		[CompilerGenerated]
		get
		{
			return default(DIJCCBHFKLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E1")]
	public float HMFGBPGOKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xDB5D10", Offset = "0xDB4B10", VA = "0x180DB5D10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xDB5D20", Offset = "0xDB4B20", VA = "0x180DB5D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FOEGKOIIFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[MBIAOMFNMDN]
public class OIJMHBDAAKH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003E2")]
	public TimeSpan KKNLDGLOCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E3")]
	public TimeSpan GKGDODHFGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OIJMHBDAAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[MBIAOMFNMDN]
public class IDPFMIJMNHE : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003E4")]
	public List<string> DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public IDPFMIJMNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[MBIAOMFNMDN]
public class IOPNIECOJFB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003E5")]
	public string? LOCFCCAKONN
	{
		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E6")]
	public string OBAMKJFNKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E7")]
	public string HIHOILGKPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E8")]
	public string CBHFGIMHGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E9")]
	public string? IDBGICKCCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x7823940", Offset = "0x7822740", VA = "0x187823940")]
	public IOPNIECOJFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[MBIAOMFNMDN]
public class KGPIBEGJCGL : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003EA")]
	public KNPLFMAGNCA NCMCMAGOJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EB")]
	public DIJCCBHFKLF GBJFCJPMOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(DIJCCBHFKLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EC")]
	public long? MLIJBDLAKBH
	{
		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0xEA0F90", Offset = "0xE9FD90", VA = "0x180EA0F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xF8DE40", Offset = "0xF8CC40", VA = "0x180F8DE40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003ED")]
	public DateTime? EJGONBCIJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xF5AAD0", Offset = "0xF598D0", VA = "0x180F5AAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xF5A8A0", Offset = "0xF596A0", VA = "0x180F5A8A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EE")]
	public long? LPFHLDINFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x10666B0", Offset = "0x10654B0", VA = "0x1810666B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x10667E0", Offset = "0x10655E0", VA = "0x1810667E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KGPIBEGJCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[MBIAOMFNMDN]
public class LIFACNKLEAO : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003EF")]
	public int DPMDDGAFGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F0")]
	public DateTime? POGJHLOHINA
	{
		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LIFACNKLEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[MBIAOMFNMDN]
public class IPDMPLPBCHD : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003F1")]
	public List<MNFANDEFOBF> DCEOKFFEPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public IPDMPLPBCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[MBIAOMFNMDN]
public class MNFANDEFOBF : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003F2")]
	public string PEPBILEHDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x78271D0", Offset = "0x7825FD0", VA = "0x1878271D0")]
	public MNFANDEFOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[MBIAOMFNMDN]
public class POHFIAONIBA : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003F3")]
	public List<OHKBPNJAJGB> CIANLBGKNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F4")]
	public string ENFHCAADCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x7828470", Offset = "0x7827270", VA = "0x187828470")]
	public POHFIAONIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[MBIAOMFNMDN]
public class OHKBPNJAJGB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003F5")]
	public string FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F6")]
	public string LLGJEEHMBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F7")]
	public string DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F8")]
	public string BHPOMAAPGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F9")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0xA98B70", Offset = "0xA97970", VA = "0x180A98B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public OHKBPNJAJGB(string FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
public enum JMAGHHGMBMK
{
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	User,
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	System,
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	AI
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[MBIAOMFNMDN]
public class KOAIPIIOCCM : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003FA")]
	public string JPCEMHPBMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FB")]
	public JMAGHHGMBMK KLJPIPADLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(JMAGHHGMBMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FC")]
	public string JEMNDLOEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KOAIPIIOCCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[MBIAOMFNMDN]
public class BCOBKKOIOBP : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x170003FD")]
	public string JPCEMHPBMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FE")]
	public string PDGFEHBFCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FF")]
	public string LNDALBPMLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BCOBKKOIOBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public enum IAEIJMKLLFE
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
[MBIAOMFNMDN]
public class HFHDOGPCANB : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000400")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000401")]
	public string OEFDNBEIBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000402")]
	public string? LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HFHDOGPCANB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[MBIAOMFNMDN]
public class IGECHOBKGLM : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x17000403")]
	public string JPCEMHPBMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000404")]
	public string? LOCFCCAKONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000405")]
	public float? MPPCJDMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000406")]
	public HFHDOGPCANB? CBHFGIMHGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000407")]
	public List<HFHDOGPCANB> DMFONFCBLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000408")]
	public IAEIJMKLLFE JOHFPLNCLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		[CompilerGenerated]
		get
		{
			return default(IAEIJMKLLFE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000409")]
	public string? AGJACNJBBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x7823190", Offset = "0x7821F90", VA = "0x187823190", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x78231B0", Offset = "0x7821FB0", VA = "0x1878231B0")]
	public IGECHOBKGLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[MBIAOMFNMDN]
public class OKAEDPPIEEM : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700040A")]
	public string FBLHFPABBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040B")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040C")]
	public string HEOKEOPCLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OKAEDPPIEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[MBIAOMFNMDN]
public class OFNMFDPKNFE : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700040D")]
	public List<string> CPLAEKDMKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040E")]
	public List<OKAEDPPIEEM>? OICIIMBOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x78278C0", Offset = "0x78266C0", VA = "0x1878278C0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OFNMFDPKNFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[MBIAOMFNMDN]
public class ADAOJHIIFLH : HHPMDFAHMHN
{
	[Cpp2IlInjected.Token(Token = "0x1700040F")]
	public string NFHHLFGCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void DEABHIFMEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ADAOJHIIFLH()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
public class EDFFLPDHNEN
{
	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EDFFLPDHNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x7550F60", Offset = "0x754FD60", VA = "0x187550F60")]
	public static string IAPJDHPINOL(byte[] JBCIGBMHOPF, byte[] DKAEMMPPGGA)
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
