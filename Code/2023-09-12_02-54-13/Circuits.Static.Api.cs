using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7151750", Offset = "0x7150B50", VA = "0x187151750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LJCFMDJIFAH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed(in HMJBHGHBCLG BHDJLNNKMCD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HMDCAHKPIDA : MCPAKNAJJEF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNFBEGDMHOD(MCPAKNAJJEF KMBLOCADLHE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDPMCCCKLBI();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOBOHMPHNJE(MCPAKNAJJEF KMBLOCADLHE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IPEILICCBFP(in MLIFGPEKEEI EIFGPNBPBFJ);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class KGDBODCAOBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LOOGBCOPJKG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IABLOIJILEG
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x19B2260", Offset = "0x19B1660", VA = "0x1819B2260")]
	public static bool NFJCCPLFJPM(this LOOGBCOPJKG FOGPFBBPCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x19B2260", Offset = "0x19B1660", VA = "0x1819B2260")]
	public static bool BBLOCIOKEDO(this LOOGBCOPJKG FOGPFBBPCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x19B2260", Offset = "0x19B1660", VA = "0x1819B2260")]
	public static bool AFFKMNEEFKJ(this LOOGBCOPJKG FOGPFBBPCHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MCNADINAFIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly NDCIODPAKEL GPIGAKIDEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly BJBOEPGJCCF CBNIJOGBABJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
	public MCNADINAFIO(NDCIODPAKEL JDFPBLIKABN, BJBOEPGJCCF CJHPLNELDPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MJFDJJKLKAI : IEquatable<MJFDJJKLKAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly DKANMAFBNHO MKNFCGACNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string GEAMPGKCMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4D30", Offset = "0x6F4130")]
	public readonly IReadOnlyDictionary<JDIHKGFCOHC<EPJKOIFFCFO>, NMMCMABCFMK> PPFNNECAJJJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7151430", Offset = "0x7150830", VA = "0x187151430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71514B0", Offset = "0x71508B0", VA = "0x1871514B0")]
	public MJFDJJKLKAI(DKANMAFBNHO NDIOGKALOHC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4D90", Offset = "0x6F4190")] IReadOnlyDictionary<JDIHKGFCOHC<EPJKOIFFCFO>, NMMCMABCFMK> OGIIHFFGCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7150BD0", Offset = "0x714FFD0", VA = "0x187150BD0")]
	public static MJFDJJKLKAI EFFJDOFDOEN(DHHNOOAADNM CLCAIFLMLCJ)
	{
		return default(MJFDJJKLKAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7150A20", Offset = "0x714FE20", VA = "0x187150A20")]
	public DHHNOOAADNM CJMDONJKOCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7150F50", Offset = "0x7150350", VA = "0x187150F50", Slot = "4")]
	public bool Equals(MJFDJJKLKAI ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EPJKOIFFCFO
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MCPAKNAJJEF
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LBJHNGFEJEH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NPIIJBFCPIL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface OGOLBNGEMOL
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5310", Offset = "0x6F4710")]
		Action<NPIIJBFCPIL> GIKNPGHHOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "1")]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5250", Offset = "0x6F4650")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5370", Offset = "0x6F4770")]
		Action<NPIIJBFCPIL> MNPDMMFCJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "3")]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F52B0", Offset = "0x6F46B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MCPAKNAJJEF KNKHNLPLIEB(Func<byte> ECLPCMHCIBM, Action<byte> GECBKKENKHH, Func<int> EAHEGBOECFJ, Action<int> IBIMBBCPFAM, [Optional] Func<bool>? GIABJADFOMH);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BDEGPEOJJCB();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GPECAJNPKPK(MCPAKNAJJEF KMBLOCADLHE);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OGOLBNGEMOL LBADJCALCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCPAKNAJJEF FNAIJGFODAG(Action PAAOMOHNCEI, string AAOPMJIELIH = "", [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional] Func<bool>? OAIBHHLMGLA, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCPAKNAJJEF IJODIFJBMPO(IReadOnlyList<MCPAKNAJJEF> JFJPDDKMGLD, [Optional] float? IGGCICMLLGE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCPAKNAJJEF CFOPBCOBHLF(Func<int> HCPICFJCHCC, Action<int> LGGDNJIOKKI, [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, bool HHMPAENCFBL = false, string AAOPMJIELIH = "Color", [Optional] Func<bool>? OAIBHHLMGLA, bool GPBCLOCNIJO = true, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MCPAKNAJJEF NECKKKIKCAC(MCPAKNAJJEF KMBLOCADLHE);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HMDCAHKPIDA HLPPFMLBHFJ(int DDFBJCJBGLB, string AAOPMJIELIH, string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4E30", Offset = "0x6F4230")] List<MCPAKNAJJEF> JFJPDDKMGLD, [Optional] Func<bool>? GIABJADFOMH, bool FFACMPNNBOH = true, [Optional] Func<bool>? PDGPBJIEKNK, [Optional] Action<bool>? KHGCPKGBFHM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MCPAKNAJJEF LKDECAPPLFE(string PBGNFGHMDLB, [Optional] Func<bool>? GIABJADFOMH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MCPAKNAJJEF ADDANPJFDPK(Func<string> IEBCALGMAJB, Action<string> PIGGOKONJIO, [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional] int? LIDHFEEAJEP, bool EEHBDPKBJLI = false, string AAOPMJIELIH = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] Func<bool>? OAIBHHLMGLA, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MCPAKNAJJEF DFLKMIGOPBA(Func<float> IEBCALGMAJB, Action<float> PIGGOKONJIO, string AAOPMJIELIH = "", string KALFNBOIPPK = "", string DCDBEGICKKD = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", bool HKINHNIJKOC = false, float AMGADMFJPLI = 0f, float BOGPLNMMHKE = 1000f, [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional] Func<bool>? OAIBHHLMGLA, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MCPAKNAJJEF LNCGJOKPOHF(Func<int> IEBCALGMAJB, Action<int> PIGGOKONJIO, string AAOPMJIELIH = "", [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4E90", Offset = "0x6F4290")] Func<string> FOPDGMDPAGM, string KALFNBOIPPK = "", [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4EF0", Offset = "0x6F42F0")] Func<string> IFCDCPELIJP, string DCDBEGICKKD = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", bool HKINHNIJKOC = false, int AMGADMFJPLI = 0, int BOGPLNMMHKE = 1000, [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional] Func<bool>? OAIBHHLMGLA, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MCPAKNAJJEF LEINFNFHDBE(Type AFJFEPCGIJM, IReadOnlyList<object> NBNBJFGKBNJ, Func<int> BODKNFAFIBK, Action<object> GALHPCENKHP, string AAOPMJIELIH = "", string KALFNBOIPPK = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4F50", Offset = "0x6F4350")] Func<object, string> MADBECDLKMI, bool KCCIPNKLINI = true, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MCPAKNAJJEF PNHODPICOBG(Func<string> IEBCALGMAJB, Action<string> PIGGOKONJIO, int CANJJKFNPPK = 1000, EIJLGKMONCJ EPOFKIJKAJJ = EIJLGKMONCJ.Alphanumeric, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4FB0", Offset = "0x6F43B0")] Func<string, bool> BJFNCOMAHJA, [Optional] string? ELPBDPPNLFJ, [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, string AAOPMJIELIH = "", string KALFNBOIPPK = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", bool EEHBDPKBJLI = false, [Optional] Func<bool>? OAIBHHLMGLA, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MCPAKNAJJEF DCMFGMLGMKO(Func<float> IEBCALGMAJB, Action<float> PIGGOKONJIO, float AMGADMFJPLI = 0f, float BOGPLNMMHKE = 1000f, [Optional] Func<bool>? DAAJOHPEICP, int LOLBAAANIDF = -1, string AAOPMJIELIH = "", string KALFNBOIPPK = "", string DCDBEGICKKD = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] Func<float, float>? CILJLADBHHK, [Optional] Func<float, float>? CKFEMFELHAN, [Optional] Func<bool>? OAIBHHLMGLA, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MCPAKNAJJEF GACDKFLFIHB(Func<string> IEBCALGMAJB, Action<string> PIGGOKONJIO, Action PAAOMOHNCEI, [Optional] Func<bool>? GIABJADFOMH, EIJLGKMONCJ EPOFKIJKAJJ = EIJLGKMONCJ.Alphanumeric, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5010", Offset = "0x6F4410")] Func<string, bool> BJFNCOMAHJA, JLJHOJOADLK EBCMAOIJKMA = JLJHOJOADLK.Alphanumeric, [Optional] string? ELPBDPPNLFJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5070", Offset = "0x6F4470")] List<MCPAKNAJJEF> EMNIOJJEEPA, string AAOPMJIELIH = "", string NJHOFDBEEHB = "", string DPGDEIDLLBP = "", string GLMGCKPAHKH = "", bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MCPAKNAJJEF IGOBMNILFAA(Func<string> IEBCALGMAJB, Action<string> PIGGOKONJIO, [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional] int? LIDHFEEAJEP, bool EEHBDPKBJLI = false, string AAOPMJIELIH = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] Func<bool>? OAIBHHLMGLA, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MCPAKNAJJEF APIJKCIGBLN(Func<bool> IEBCALGMAJB, Action<bool> PIGGOKONJIO, [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, string AAOPMJIELIH = "", string KALFNBOIPPK = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] int? DDFBJCJBGLB, [Optional] Func<bool>? OAIBHHLMGLA, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FMBDIBDBPFN PKOBAOFIBKF(Dictionary<string, AJAANKKCNBO> OIEACLJHHPB, Func<int> HCPICFJCHCC, Action<int> LGGDNJIOKKI, string AAOPMJIELIH, string KALFNBOIPPK = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] Action? CCBDKLFIKJL, [Optional] Action? OIMALKPECPP, [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F50D0", Offset = "0x6F44D0")] Func<int, string> OFDPEGFNHKK, bool KCCIPNKLINI = true, bool OHHFLGKKIIF = true, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FMBDIBDBPFN MLEAPFAJBMF(Func<Dictionary<string, AJAANKKCNBO>> HGAEAHLODNF, Func<int> HCPICFJCHCC, Action<int> LGGDNJIOKKI, string AAOPMJIELIH, string KALFNBOIPPK = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional] Func<bool>? ABHGMAIKJCN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5130", Offset = "0x6F4530")] Func<int, string> OFDPEGFNHKK, bool KCCIPNKLINI = true, bool OHHFLGKKIIF = true, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MCPAKNAJJEF OKLDGGPABGB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5190", Offset = "0x6F4590")] Func<List<KeyValuePair<string, AJAANKKCNBO>>> HGAEAHLODNF, Func<int> HCPICFJCHCC, Action<int> LGGDNJIOKKI, string AAOPMJIELIH, string KALFNBOIPPK = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, [Optional] Func<bool>? ABHGMAIKJCN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F51F0", Offset = "0x6F45F0")] Func<int, string> OFDPEGFNHKK, [Optional] Action? CCBDKLFIKJL, [Optional] Action? OIMALKPECPP, bool KCCIPNKLINI = true, bool OHHFLGKKIIF = true, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MCPAKNAJJEF CAGFEFDOBMJ(Func<List<object>> HGAEAHLODNF, Func<object> BODKNFAFIBK, Action<object> GALHPCENKHP, Func<object, string> MADBECDLKMI, string AAOPMJIELIH = "", string KALFNBOIPPK = "", string NJHOFDBEEHB = "", string CADBHBPMPHK = "", [Optional] Func<bool>? GIABJADFOMH, [Optional] Func<bool>? FGFICIGNKCO, bool KCCIPNKLINI = true, bool OINJGOFIDHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MCPAKNAJJEF HALBKCLHHMO(string AAOPMJIELIH, Func<object> BODKNFAFIBK, Action<object> GALHPCENKHP, Func<object, string> MADBECDLKMI, Func<IReadOnlyList<object>> IHPNDLIILEG, [Optional] Func<bool>? GIABJADFOMH);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HNFNCPHFNJB(MCPAKNAJJEF KMBLOCADLHE);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EIEDBCFIGEI(string FABMIHNLHGJ, Action LGAHEMGOOBM, bool DBEPJAMIGOJ, string MOEPEJLJJAL, Action LFEHCCNEMPC, string FHDJIGKOLJM, string FJIALGMLGCF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KJMDAFMAAFO(string IOEBIEJNMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum HGKPCLNJEND
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Follow,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Orbit,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Attached,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Detached
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CDJKGJFIGCL : AFLGEIHOOJA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeRecorderData(string JFOKKNEINFK, Action<string, float> LPNAMDHFEMC);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F53D0", Offset = "0x6F47D0")]
		public readonly JDIHKGFCOHC<NCMNDELHLHG> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5430", Offset = "0x6F4830")]
		public readonly NAHKHOEBAGF<BLAHIDJELBP> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5490", Offset = "0x6F4890")]
		public readonly NAHKHOEBAGF<GIELGOFFGGN> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F54F0", Offset = "0x6F48F0")]
		public readonly JDIHKGFCOHC<NCMNDELHLHG> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5550", Offset = "0x6F4950")]
		public readonly NAHKHOEBAGF<BLAHIDJELBP> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F55B0", Offset = "0x6F49B0")]
		public readonly NAHKHOEBAGF<OFHCAOKOEAI> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EBEFA0", Offset = "0x5EBE3A0", VA = "0x185EBEFA0")]
		public StaticEdge([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5610", Offset = "0x6F4A10")] in JDIHKGFCOHC<NCMNDELHLHG> FHLOIFEEILK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5680", Offset = "0x6F4A80")] NAHKHOEBAGF<BLAHIDJELBP> GNFFIBGGKCB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F56E0", Offset = "0x6F4AE0")] NAHKHOEBAGF<GIELGOFFGGN> NCEJECFAIMH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5740", Offset = "0x6F4B40")] in JDIHKGFCOHC<NCMNDELHLHG> NIEPLEDMECK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F57B0", Offset = "0x6F4BB0")] NAHKHOEBAGF<BLAHIDJELBP> AMBDJKPPBPN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5810", Offset = "0x6F4C10")] NAHKHOEBAGF<OFHCAOKOEAI> NDJGJGIFFGP)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7151C10", Offset = "0x7151010", VA = "0x187151C10")]
		public static bool PHJEMBLBEDF(in StaticEdge FINJCDHFPJB, in StaticEdge JHJGODIMNAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7151980", Offset = "0x7150D80", VA = "0x187151980", Slot = "4")]
		public bool Equals(StaticEdge ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7151A70", Offset = "0x7150E70", VA = "0x187151A70", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7151B20", Offset = "0x7150F20", VA = "0x187151B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7151D00", Offset = "0x7151100", VA = "0x187151D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OLLLANJMIIA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7151820", Offset = "0x7150C20", VA = "0x187151820")]
	public static StaticEdge EFFJDOFDOEN(this EMKEHCIEMHE ODBHDBFBMOB)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class DDOHBEGADNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OJCINIICELG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLDKBJFGIHB();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AEJGNIGBPMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EBFBHNKBMPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void AMMIIAPPMIE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6670", Offset = "0x6F5A70")] NAHKHOEBAGF<BLAHIDJELBP> PINJDLEFOFM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F66D0", Offset = "0x6F5AD0")] NAHKHOEBAGF<BLAHIDJELBP> FNIKJMODJCE);

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NPHBJEOMHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HMLBGDIFPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PDOJDPIEMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6170", Offset = "0x6F5570")]
	JDIHKGFCOHC<NMNEKCGKICM> INBHDLKLECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ADLBFCPLCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F61E0", Offset = "0x6F55E0")]
	FKHDGLBMILJ<OFHCAOKOEAI, FGHKEONGAMC> AHGCIIGAPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6240", Offset = "0x6F5640")]
	JDIHKGFCOHC<NCMNDELHLHG> GLMAJHDOAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F62B0", Offset = "0x6F56B0")]
	FKHDGLBMILJ<GIELGOFFGGN, BGPJNFPBOKH> GNMOLDCJCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6310", Offset = "0x6F5710")]
	NAHKHOEBAGF<BLAHIDJELBP> AOAJFOOBJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MADJAKEKPJE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NAHKHOEBAGF<OFHCAOKOEAI>, NAHKHOEBAGF<OFHCAOKOEAI>> EKFIEJLCECI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<NAHKHOEBAGF<GIELGOFFGGN>, NAHKHOEBAGF<GIELGOFFGGN>> EFJACJGHCGB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NAHKHOEBAGF<OFHCAOKOEAI>, FGHKEONGAMC> GDHDMNBBDFG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<NAHKHOEBAGF<OFHCAOKOEAI>> AIOEFFFNBAM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<NAHKHOEBAGF<OFHCAOKOEAI>, FGHKEONGAMC> MPGACKOGMMF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<NAHKHOEBAGF<GIELGOFFGGN>, BGPJNFPBOKH> GBPNJKPNKMM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<NAHKHOEBAGF<GIELGOFFGGN>> LAGHAOILELG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<NAHKHOEBAGF<GIELGOFFGGN>, BGPJNFPBOKH> CANHNNBNGAP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> KEBMNKDKIMO();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> IPGNOCLMKHA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5E70", Offset = "0x6F5270")] NAHKHOEBAGF<EKJLBDBLLBL> AFNBLFHJFCB);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> COLMIFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5ED0", Offset = "0x6F52D0")] NAHKHOEBAGF<GJLAOGMDHNK> GPMADLPFJNB);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> ACGIHOGHIIH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5F30", Offset = "0x6F5330")] NAHKHOEBAGF<EKJLBDBLLBL> AFNBLFHJFCB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5F90", Offset = "0x6F5390")] NAHKHOEBAGF<EKJLBDBLLBL> NMCOJCMCCID);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> BKFNJALOJFL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5FF0", Offset = "0x6F53F0")] NAHKHOEBAGF<GJLAOGMDHNK> GPMADLPFJNB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6050", Offset = "0x6F5450")] NAHKHOEBAGF<GJLAOGMDHNK> NMCOJCMCCID);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> PJELGADAFPC();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> CJLIDCCPLHO(string DDNNJPJBEIC);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> LIIMEBGBDNO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F60B0", Offset = "0x6F54B0")] NAHKHOEBAGF<EKJLBDBLLBL> AFNBLFHJFCB, string GDKOBCHHFLB);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> EFDGDHCDHDF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6110", Offset = "0x6F5510")] NAHKHOEBAGF<GJLAOGMDHNK> GPMADLPFJNB, string GDKOBCHHFLB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public delegate void FCDEAGMLONP(in HMJBHGHBCLG BHDJLNNKMCD);
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EKHHHNBOLIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<StaticEdge> COJNJLNPGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DisplayKind AENBCKFALCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F67F0", Offset = "0x6F5BF0")]
	JDIHKGFCOHC<NMNEKCGKICM> INBHDLKLECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6860", Offset = "0x6F5C60")]
	JDIHKGFCOHC<NCMNDELHLHG> GLMAJHDOAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F68D0", Offset = "0x6F5CD0")]
	NAHKHOEBAGF<BLAHIDJELBP> AOAJFOOBJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6930", Offset = "0x6F5D30")]
	NAHKHOEBAGF<EAPOGJCHIFM> LBHDPIKNKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NBLHGGLIPIM JAODAJLIEME
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	PortImage EOHCCEPOKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MNDAMCJFIMF(LBJHNGFEJEH NLKFHPJEICP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JAOPPMOKAOC(LJCFMDJIFAH NLKFHPJEICP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BFGFHFMABEO(OJCKCLPKHND OFODECHODGO);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KEIGHKPDNON(LBJHNGFEJEH NLKFHPJEICP);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IGHOHCOODNF(LJCFMDJIFAH NLKFHPJEICP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LDIIECAJPDM
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public readonly struct EHLEOHHANCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly IOFJGKDDOJM MHEJAMJJAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly IReadOnlyDictionary<Guid, Guid> PEOCHEGAIPK;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x232CD60", Offset = "0x232C160", VA = "0x18232CD60")]
		public EHLEOHHANCO(IOFJGKDDOJM JIBJDOHNKCK, IReadOnlyDictionary<Guid, Guid> LLKNBGJNGOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public readonly struct GJEAPAGKEEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly IReadOnlyCollection<ByteString> HGCKCDOCOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly IReadOnlyCollection<ByteString> LPCHADPAKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly IReadOnlyCollection<ByteString> BJLBKBDLLPC;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60")]
		public GJEAPAGKEEM(IReadOnlyCollection<ByteString> GPJEAHHBAGD, IReadOnlyCollection<ByteString> DBBDBOICMPG, IReadOnlyCollection<ByteString> GIPAGJMBJMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public readonly struct IOCJJFICKDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly LOOGBCOPJKG GMEHGBKGPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly IOFJGKDDOJM MHEJAMJJAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public readonly IEnumerable<FEKGKBGNILG> CFEGBMJHDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly bool NBGIOJDLANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6B30", Offset = "0x6F5F30")]
		public readonly JDIHKGFCOHC<NMNEKCGKICM> MOACBECOFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly int? NICJOAAPCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HFOJPNLDEBJ? BPEIJJJDEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly HFOJPNLDEBJ? JBFHILELEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly GJEAPAGKEEM? KICFGFKOIKG;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x71508F0", Offset = "0x714FCF0", VA = "0x1871508F0")]
		public IOCJJFICKDP(LOOGBCOPJKG PGDCEHHINBA, in IOFJGKDDOJM JIBJDOHNKCK, IEnumerable<FEKGKBGNILG> FMKJCDJMOLH, bool EDLLHCLBOMD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6B90", Offset = "0x6F5F90")] in JDIHKGFCOHC<NMNEKCGKICM> OFHKKHEBLJK, int? ENLGCFFMGIA, in HFOJPNLDEBJ? IKAHCKEPODI, in HFOJPNLDEBJ? LAEOFIFBMCJ, in GJEAPAGKEEM? MFGAHGIDLGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGLMDNACIOM? BCNDOLEEGEM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6990", Offset = "0x6F5D90")] in JDIHKGFCOHC<NMNEKCGKICM?> AANELEBBHAJ);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBHOMBGKHDM? JJPKOMHAFKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6A00", Offset = "0x6F5E00")] in JDIHKGFCOHC<NCMNDELHLHG?> MNLPDHHHFIF);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<DGBNAMOFHAH> KLGJCEADNGE(bool ELGBNFPGHEO, bool ODJADCDJKEO, bool PDCKOCGNILL, bool PBOBIJDNCEO);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ADOGIEMPLPD<EHLEOHHANCO, FJCGAAAECJI> LDENLEHFOOG(in IOCJJFICKDP AIEGNLJMEEC);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OHJLPPOCLNE ICKMIMJBODG(IEnumerable<FEKGKBGNILG> FMKJCDJMOLH);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OHJLPPOCLNE HDOEHEJPLOA();

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IOFJGKDDOJM FIIIMFKCBLC(LOOGBCOPJKG PGDCEHHINBA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6A70", Offset = "0x6F5E70")] IEnumerable<JDIHKGFCOHC<NCMNDELHLHG>> GFODMCJLFLC, IEnumerable<FEKGKBGNILG> FMKJCDJMOLH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FMBDIBDBPFN : MCPAKNAJJEF
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INCGAJONHCG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NBLHGGLIPIM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LMNOIJOBLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JFBBNDDJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TypeKey JGJPKDIBNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LLODIANJCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CBONNABHMLO
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface HDNJIDFMLLF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string AMCMMNAKPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int LGMEHFBDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KGOOIBKNECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OJGIEILNKGG : EHBFCIBBIKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum EIJLGKMONCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[EFPBIFFAEEN("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class BLAHIDJELBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct COPJHJLCNJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly string ANHHJLAHIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly LNPFLNMAEOE.IDFMAGOEABF.GGBAMDKFEEB KKGIMOKLODL;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xE965A0", Offset = "0xE959A0", VA = "0x180E965A0")]
	public COPJHJLCNJB(string GDKOBCHHFLB, LNPFLNMAEOE.IDFMAGOEABF.GGBAMDKFEEB PCBDOIPKOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x714F700", Offset = "0x714EB00", VA = "0x18714F700")]
	internal static COPJHJLCNJB EFFJDOFDOEN(LNPFLNMAEOE CLCAIFLMLCJ)
	{
		return default(COPJHJLCNJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x714F680", Offset = "0x714EA80", VA = "0x18714F680")]
	internal LNPFLNMAEOE CJMDONJKOCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x714F810", Offset = "0x714EC10", VA = "0x18714F810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x714F770", Offset = "0x714EB70", VA = "0x18714F770", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5082800", Offset = "0x5081C00", VA = "0x185082800")]
	public bool EKENCFDIDKH(COPJHJLCNJB ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x714F870", Offset = "0x714EC70", VA = "0x18714F870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct CHJCPLHJJFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly JEDGOKEIKMD IILIFLDGEJI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	public CHJCPLHJJFG(JEDGOKEIKMD PGHCOJJFPAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum JLJHOJOADLK
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Digit,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Integer,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Decimal,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Regex,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CustomValidator
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BGPJNFPBOKH : EKHHHNBOLIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6CB0", Offset = "0x6F60B0")]
	NAHKHOEBAGF<GIELGOFFGGN> OENCDLAKPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class DPGHGBONKOF : EHBFCIBBIKB
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GJLAOGMDHNK
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct NMMCMABCFMK : IEquatable<NMMCMABCFMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly string OJLOBKCOKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly int NEHPFHLNNJI;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xE965A0", Offset = "0xE959A0", VA = "0x180E965A0")]
	public NMMCMABCFMK(string KNPFDHANMOI, int GDMLMJCBLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5082800", Offset = "0x5081C00", VA = "0x185082800", Slot = "4")]
	public bool Equals(NMMCMABCFMK ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface DGBNAMOFHAH
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string NIMAGGAENNN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ADOGIEMPLPD<NAHKHOEBAGF<EKJLBDBLLBL>, NADLJLPONBH>> OGHCHCOLPLG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6D30", Offset = "0x6F6130")] JDIHKGFCOHC<NMNEKCGKICM> AANELEBBHAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6D90", Offset = "0x6F6190")] JDIHKGFCOHC<NCMNDELHLHG> MNLPDHHHFIF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6DF0", Offset = "0x6F61F0")] NAHKHOEBAGF<BLAHIDJELBP> FAFDNFIBPDL, string GDKOBCHHFLB);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ADOGIEMPLPD<NAHKHOEBAGF<GJLAOGMDHNK>, NADLJLPONBH>> CAFIKLGIEFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6E50", Offset = "0x6F6250")] JDIHKGFCOHC<NMNEKCGKICM> AANELEBBHAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6EB0", Offset = "0x6F62B0")] JDIHKGFCOHC<NCMNDELHLHG> MNLPDHHHFIF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6F10", Offset = "0x6F6310")] NAHKHOEBAGF<BLAHIDJELBP> FAFDNFIBPDL, string GDKOBCHHFLB);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface AFLGEIHOOJA
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnHide();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DoneEditing();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IICLIGBIKEB
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LDIIECAJPDM? FNGGPKJOCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FPNNCNFEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool EOCIPKNOJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<LDIIECAJPDM> APLOHJEEAEC();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ADOGIEMPLPD<MCNADINAFIO, FJCGAAAECJI> FBAEMKLBGBF(in MCNADINAFIO JIBJDOHNKCK, IEnumerable<FEKGKBGNILG> FMKJCDJMOLH, int OBLCADMLBBM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface IEEGLBLDKMK
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class NMNEKCGKICM
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class KPHGGNNGMNC
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NGLMDNACIOM
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IMHMLCPMBCJ? ECBAOGDPGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct KCEHAIKBJIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly DGBNAMOFHAH HMEMKPALKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly DGBNAMOFHAH CCJKBIDGFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly DGBNAMOFHAH CLGBFLKAJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly DGBNAMOFHAH OOPBBFDABCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly DGBNAMOFHAH BEEPDBCKOOE;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x10A5280", Offset = "0x10A4680", VA = "0x1810A5280")]
	public KCEHAIKBJIB(DGBNAMOFHAH GBGIEFGPFKH, DGBNAMOFHAH BJHBPGNJGKG, DGBNAMOFHAH KFEKBHDAEHO, DGBNAMOFHAH DHKGMNGIIIJ, DGBNAMOFHAH GHALODGJOGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KBHOMBGKHDM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	object ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7390", Offset = "0x6F6790")]
	JDIHKGFCOHC<CBONNABHMLO> EALPHLCICOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NADNJFLEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int ELOLHJCDFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FNMJKOMNCDE PEGFFJIILCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	string CHKPNKDLBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NodeVisualizationKey JGJPKDIBNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F73F0", Offset = "0x6F67F0")]
	NAHKHOEBAGF<KGDBODCAOBA> OOFFKMOEMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool ELKJDICMKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool JDHLEBPEOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BDNFFHKJCGL BGOCEGNAJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool NGPCPAPHAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool FGIGEHGFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool MCEKBELPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int GFCOMNAILDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool NAEEJBJBEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string EGFEPLAOOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool KIEFHPFBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JJCDDHKBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool DLKGFHMJIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BPDENKAMAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool PIJMBJDEAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	COJODKLKBHB NEGNDNNABPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MLIFGPEKEEI DOIAKOGFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CDCOPLCCHBB(true, "FloatingText")]
	bool LPMPLABAHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HDNJIDFMLLF? CFLIPCAKCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7480", Offset = "0x6F6880")]
	JDIHKGFCOHC<NMNEKCGKICM> INBHDLKLECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[EFPBIFFAEEN("This isn't great UX and we should consider removing it.")]
	bool PPLIKMBIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7520", Offset = "0x6F6920")]
	JDIHKGFCOHC<NMNEKCGKICM>? KBIMNMMJAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7590", Offset = "0x6F6990")]
	IEnumerable<JDIHKGFCOHC<NCMNDELHLHG>> HDPCKOKNDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool LKKEPPBFJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool BNHHHBCEEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F75F0", Offset = "0x6F69F0")]
	JDIHKGFCOHC<NCMNDELHLHG> GLMAJHDOAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7660", Offset = "0x6F6A60")]
	FKHDGLBMILJ<BLAHIDJELBP, EBFBHNKBMPN> DEPCHLCCJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F76C0", Offset = "0x6F6AC0")]
	NAHKHOEBAGF<BLAHIDJELBP>? APAJHOJHKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action GKMOEDPLMME;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DCNANNMLAED IGCIOJHIHIF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event IPEILICCBFP JAIFLGAIGHJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DFBBPJFHCNH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action DNLBIIGJJML;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<NAHKHOEBAGF<BLAHIDJELBP>, EBFBHNKBMPN> PDGDFDKCJJG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NAHKHOEBAGF<BLAHIDJELBP>> FKMBLEKNAKI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<NAHKHOEBAGF<BLAHIDJELBP>, EBFBHNKBMPN> BFFCMFKEHON;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<NAHKHOEBAGF<BLAHIDJELBP>, NAHKHOEBAGF<BLAHIDJELBP>> DCNELJNIPOB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<NAHKHOEBAGF<BLAHIDJELBP>, EBFBHNKBMPN> PHOJNEJFHLN;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODEHFGKHPAH(int DINFJOMKCHD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool BOAKGFBBALM(in COJODKLKBHB AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool PEJHJFHKCAB(in MLIFGPEKEEI AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LNINOFNKENJ();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> BEICCIIIJPN(COJODKLKBHB? IEGBDEAOAGE, MLIFGPEKEEI? IKMDCPAAKBK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PDMKJIJPOJO();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DBGOCDLGGKO();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool ADIALLFNKIO(out Guid OOJNBAAADPL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool NKOKJAENDIB(in Guid AANELEBBHAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void IKCBOKMOGJK();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void GDJIJKBBJLE(bool EBGDCFONBDP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "45")]
	AFLGEIHOOJA NFEJOEEFAHF(in CDJKGJFIGCL GIHDNNPPDDP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void LAPDCGHLHCH(object LMLJAJBMELJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void ICFJOKMPKMA(object LMLJAJBMELJ);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void OEKEHCMEKPA(NPIIJBFCPIL PLBFPFKMLCF);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "71")]
	HFOJPNLDEBJ MELIDBAEFBM();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<ADOGIEMPLPD<PNGLJAGHHDL, NADLJLPONBH>> KLNKJLKEFBK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7330", Offset = "0x6F6730")] NAHKHOEBAGF<BLAHIDJELBP> FAFDNFIBPDL);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		List,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		StateTransition
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class EHBFCIBBIKB
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct OHJLPPOCLNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly MCNADINAFIO GANACBGNCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly CHJCPLHJJFG NBDLAGLIJKG;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x71517E0", Offset = "0x7150BE0", VA = "0x1871517E0")]
	public OHJLPPOCLNE(in MCNADINAFIO LGMMPALIFIG, CHJCPLHJJFG OOGBKJBIGHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class AMCLCAHIAIB
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Color
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface FGHKEONGAMC : EKHHHNBOLIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7900", Offset = "0x6F6D00")]
	NAHKHOEBAGF<OFHCAOKOEAI> LBJOKLJLAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool AIKJGILJBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKPEADIPGDM(OJCINIICELG MFACNOGMIFD);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEKEHCMEKPA(GLHDDPNDBLC CGLDCMNBFDC);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string KMIJJFIDJHG(int GECDAKMBGDI);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POFMIELMDNN(AEJGNIGBPMJ NLKFHPJEICP);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGMDEEKKIBB(AEJGNIGBPMJ NLKFHPJEICP);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface OJCKCLPKHND
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCCLEPHGKFL();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABKNAOFCILN(string IKELKGKHILD, in FNMJKOMNCDE DEJOCIOKOBF);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHDFJNHOOGG(string FHDJIGKOLJM);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMMMINLKIGA(string PBGNFGHMDLB);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class EKJLBDBLLBL
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct HMJBHGHBCLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool DLOKJNBCFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly NHCBGJJMILA EMIJAOPGDJA;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x176ADE0", Offset = "0x176A1E0", VA = "0x18176ADE0")]
	public HMJBHGHBCLG(bool JGLJLNLDBGM, NHCBGJJMILA CLNLDMHCDBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class NCMNDELHLHG
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public delegate void DCNANNMLAED(in COJODKLKBHB KMCELLJPILA);
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class EAPOGJCHIFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct IOFJGKDDOJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly KGBOIFKJOND DEHDAMPINGA;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	public IOFJGKDDOJM(KGBOIFKJOND JGIHPGHLELN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class GIELGOFFGGN : EAPOGJCHIFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NADLJLPONBH : FJCGAAAECJI
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct DKANMAFBNHO : IEquatable<DKANMAFBNHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly string ANHHJLAHIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly IReadOnlyList<COPJHJLCNJB> AHGCIIGAPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly IReadOnlyList<COPJHJLCNJB> GNMOLDCJCJH;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x71502A0", Offset = "0x714F6A0", VA = "0x1871502A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60")]
	public DKANMAFBNHO(string GDKOBCHHFLB, IReadOnlyList<COPJHJLCNJB> LMDNLMHPDFC, IReadOnlyList<COPJHJLCNJB> HNHIDKGLBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x714FE30", Offset = "0x714F230", VA = "0x18714FE30")]
	public static DKANMAFBNHO EFFJDOFDOEN(EJCJJJJACAJ CLCAIFLMLCJ)
	{
		return default(DKANMAFBNHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x714FB90", Offset = "0x714EF90", VA = "0x18714FB90")]
	public EJCJJJJACAJ CJMDONJKOCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7150220", Offset = "0x714F620", VA = "0x187150220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x71502C0", Offset = "0x714F6C0", VA = "0x1871502C0")]
	private static int NKCGKLOCNAD(IReadOnlyList<COPJHJLCNJB> LPMIDCCEDAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7150170", Offset = "0x714F570", VA = "0x187150170", Slot = "4")]
	public bool Equals(DKANMAFBNHO ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x71504A0", Offset = "0x714F8A0", VA = "0x1871504A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface GLHDDPNDBLC
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFOKAEPEHGO(string AAOPMJIELIH, Func<string> IEBCALGMAJB, Action<string> PIGGOKONJIO, Func<bool> GIABJADFOMH);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLPGNAHDDED(string AAOPMJIELIH, Action PAAOMOHNCEI, Func<bool> GIABJADFOMH);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFINJJKMELG(string AAOPMJIELIH, Func<int> HCPICFJCHCC, Action<int> LGGDNJIOKKI, Func<bool> GIABJADFOMH);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCFAAPNGNHE(string AAOPMJIELIH, Func<int> IEBCALGMAJB, Action<int> PIGGOKONJIO, Func<bool> GIABJADFOMH);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKPCHNAKIFH(string AAOPMJIELIH, Func<int> BODKNFAFIBK, Action<object> GALHPCENKHP, Func<object, string> MADBECDLKMI, Func<bool> GIABJADFOMH, Type AFJFEPCGIJM, IReadOnlyList<object> NBNBJFGKBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCDOCHNPOCO(string AAOPMJIELIH, Func<string> IEBCALGMAJB, Action<string> PIGGOKONJIO, Func<bool> GIABJADFOMH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GEDGPHCEAFP(string AAOPMJIELIH, Func<bool> IEBCALGMAJB, Action<bool> PIGGOKONJIO, Func<bool> GIABJADFOMH);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum NHCBGJJMILA
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface MKMHBCBCDHA : HDLFPPODDLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	IICLIGBIKEB DAHABFCNOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class OFHCAOKOEAI : EAPOGJCHIFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct IMHMLCPMBCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7960", Offset = "0x6F6D60")]
	public readonly JDIHKGFCOHC<NCMNDELHLHG> MAJKNMHHOAA;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x20CE640", Offset = "0x20CDA40", VA = "0x1820CE640")]
	public IMHMLCPMBCJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F79C0", Offset = "0x6F6DC0")] in JDIHKGFCOHC<NCMNDELHLHG> DIOBHKKFKIB)
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
